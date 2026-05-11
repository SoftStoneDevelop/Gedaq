

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
    internal partial interface IIPAddressMArrayinetMArrayD2
    {
    }
    
    internal partial class IPAddressMArrayinetMArrayD2 : IIPAddressMArrayinetMArrayD2
    {


#region TestData

        private readonly IPAddressinetMArrayD2E1M[] _testData = new IPAddressinetMArrayD2E1M[]
        {
            new IPAddressinetMArrayD2E1M
{
    Id = 1,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("222.142.110.16"),
System.Net.IPAddress.Parse("229.192.240.0"), } },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMArrayD2E1M
{
    Id = 4,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("240.225.139.175"),
System.Net.IPAddress.Parse("3.94.12.42"), } },
    ModelInner = new IPAddressinetMArrayD21MI
{
    Id = 6,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("233.79.240.114"),
System.Net.IPAddress.Parse("28.248.134.233"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("208.17.15.131"),
System.Net.IPAddress.Parse("198.125.12.80"), } },
},
            new IPAddressinetMArrayD2E1M
{
    Id = 9,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("240.194.236.128"),
System.Net.IPAddress.Parse("4.180.69.177"), } },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMArrayD2E1M
{
    Id = 11,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("254.114.64.170"),
System.Net.IPAddress.Parse("80.137.108.153"), } },
    ModelInner = new IPAddressinetMArrayD21MI
{
    Id = 14,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("57.171.116.14"),
System.Net.IPAddress.Parse("203.6.27.201"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("245.51.144.162"),
System.Net.IPAddress.Parse("94.188.30.247"), } },
},
            new IPAddressinetMArrayD2E1M
{
    Id = 12,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("126.18.97.55"),
System.Net.IPAddress.Parse("204.87.215.171"), } },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("81.65.115.150"),
System.Net.IPAddress.Parse("91.252.181.50"), } },
},
            new IPAddressinetMArrayD2E1M
{
    Id = 19,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("40.157.175.227"),
System.Net.IPAddress.Parse("142.32.155.252"), } },
    ModelInner = new IPAddressinetMArrayD21MI
{
    Id = 20,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("211.50.231.89"),
System.Net.IPAddress.Parse("183.114.253.25"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("220.214.18.243"),
System.Net.IPAddress.Parse("52.235.165.190"), } },
},
    NullableValue = null,
},
            new IPAddressinetMArrayD2E1M
{
    Id = 27,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("198.91.132.179"),
System.Net.IPAddress.Parse("222.245.203.150"), } },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMArrayD2E1M
{
    Id = 35,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("160.117.102.27"),
System.Net.IPAddress.Parse("240.23.101.223"), } },
    ModelInner = new IPAddressinetMArrayD21MI
{
    Id = 28,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("252.151.94.72"),
System.Net.IPAddress.Parse("131.39.52.8"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMArrayD2E1M
{
    Id = 42,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("160.69.53.22"),
System.Net.IPAddress.Parse("11.135.248.64"), } },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMArrayD2E1M
{
    Id = 46,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("85.68.49.157"),
System.Net.IPAddress.Parse("164.185.179.212"), } },
    ModelInner = new IPAddressinetMArrayD21MI
{
    Id = 35,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("186.40.107.154"),
System.Net.IPAddress.Parse("209.94.14.82"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMArrayD2E1M
{
    Id = 50,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("232.235.186.129"),
System.Net.IPAddress.Parse("5.187.246.101"), } },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMArrayD2E1M
{
    Id = 59,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("150.175.6.198"),
System.Net.IPAddress.Parse("85.238.132.158"), } },
    ModelInner = new IPAddressinetMArrayD21MI
{
    Id = 43,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("132.53.100.72"),
System.Net.IPAddress.Parse("151.182.65.117"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("104.193.176.214"),
System.Net.IPAddress.Parse("48.181.51.79"), } },
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("10.220.213.55"),
System.Net.IPAddress.Parse("183.6.73.48"), } },
},
            new IPAddressinetMArrayD2E1M
{
    Id = 66,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("132.185.176.215"),
System.Net.IPAddress.Parse("204.215.177.209"), } },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("222.117.176.53"),
System.Net.IPAddress.Parse("0.112.254.34"), } },
},
            new IPAddressinetMArrayD2E1M
{
    Id = 69,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("201.200.120.202"),
System.Net.IPAddress.Parse("163.150.71.251"), } },
    ModelInner = new IPAddressinetMArrayD21MI
{
    Id = 47,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("96.89.42.235"),
System.Net.IPAddress.Parse("9.226.24.131"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMArrayD2E1M
{
    Id = 78,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("154.250.89.100"),
System.Net.IPAddress.Parse("175.93.126.31"), } },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("128.184.214.193"),
System.Net.IPAddress.Parse("109.45.152.64"), } },
},
            new IPAddressinetMArrayD2E1M
{
    Id = 84,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("84.86.30.17"),
System.Net.IPAddress.Parse("74.72.20.98"), } },
    ModelInner = new IPAddressinetMArrayD21MI
{
    Id = 52,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("102.216.214.228"),
System.Net.IPAddress.Parse("227.192.22.17"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMArrayD2E1M
{
    Id = 93,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("73.253.215.60"),
System.Net.IPAddress.Parse("24.142.151.109"), } },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("108.140.229.205"),
System.Net.IPAddress.Parse("158.91.39.86"), } },
},
            new IPAddressinetMArrayD2E1M
{
    Id = 97,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("101.68.210.209"),
System.Net.IPAddress.Parse("183.233.244.221"), } },
    ModelInner = new IPAddressinetMArrayD21MI
{
    Id = 56,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("132.90.71.126"),
System.Net.IPAddress.Parse("149.232.209.184"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("13.225.35.160"),
System.Net.IPAddress.Parse("35.96.17.216"), } },
},
            new IPAddressinetMArrayD2E1M
{
    Id = 106,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("143.12.152.178"),
System.Net.IPAddress.Parse("155.210.112.219"), } },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMArrayD2E1M
{
    Id = 109,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("18.187.57.77"),
System.Net.IPAddress.Parse("203.200.57.10"), } },
    ModelInner = new IPAddressinetMArrayD21MI
{
    Id = 61,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("74.151.94.1"),
System.Net.IPAddress.Parse("165.148.111.243"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("112.105.136.52"),
System.Net.IPAddress.Parse("5.153.194.229"), } },
},
            new IPAddressinetMArrayD2E1M
{
    Id = 110,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("171.10.205.246"),
System.Net.IPAddress.Parse("249.170.138.212"), } },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("156.253.82.82"),
System.Net.IPAddress.Parse("197.152.227.132"), } },
},
            new IPAddressinetMArrayD2E1M
{
    Id = 113,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("201.186.232.199"),
System.Net.IPAddress.Parse("48.19.197.179"), } },
    ModelInner = new IPAddressinetMArrayD21MI
{
    Id = 68,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("13.77.42.235"),
System.Net.IPAddress.Parse("129.65.157.94"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("0.64.110.68"),
System.Net.IPAddress.Parse("232.205.64.184"), } },
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("1.82.154.190"),
System.Net.IPAddress.Parse("69.2.66.43"), } },
},
            new IPAddressinetMArrayD2E1M
{
    Id = 122,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("2.9.7.17"),
System.Net.IPAddress.Parse("141.109.117.179"), } },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("34.19.187.203"),
System.Net.IPAddress.Parse("157.234.194.148"), } },
},
            new IPAddressinetMArrayD2E1M
{
    Id = 126,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("106.30.102.199"),
System.Net.IPAddress.Parse("240.253.71.149"), } },
    ModelInner = new IPAddressinetMArrayD21MI
{
    Id = 77,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("181.117.21.78"),
System.Net.IPAddress.Parse("51.207.183.2"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("27.3.158.239"),
System.Net.IPAddress.Parse("237.48.110.231"), } },
},
            new IPAddressinetMArrayD2E1M
{
    Id = 128,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("42.110.64.146"),
System.Net.IPAddress.Parse("53.191.147.190"), } },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("161.147.130.118"),
System.Net.IPAddress.Parse("117.42.202.165"), } },
},
            new IPAddressinetMArrayD2E1M
{
    Id = 137,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("35.40.76.133"),
System.Net.IPAddress.Parse("22.182.223.223"), } },
    ModelInner = new IPAddressinetMArrayD21MI
{
    Id = 81,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("235.164.221.163"),
System.Net.IPAddress.Parse("242.47.48.20"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMArrayD2E1M
{
    Id = 146,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("145.7.225.65"),
System.Net.IPAddress.Parse("238.99.105.210"), } },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("80.100.150.71"),
System.Net.IPAddress.Parse("139.183.49.58"), } },
},
            new IPAddressinetMArrayD2E1M
{
    Id = 152,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("30.30.155.51"),
System.Net.IPAddress.Parse("67.135.138.20"), } },
    ModelInner = new IPAddressinetMArrayD21MI
{
    Id = 89,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("162.182.128.13"),
System.Net.IPAddress.Parse("83.15.169.170"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("17.161.43.23"),
System.Net.IPAddress.Parse("251.34.237.252"), } },
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("178.166.6.193"),
System.Net.IPAddress.Parse("130.228.53.197"), } },
},
            new IPAddressinetMArrayD2E1M
{
    Id = 154,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("36.0.242.231"),
System.Net.IPAddress.Parse("14.155.29.254"), } },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("216.147.98.117"),
System.Net.IPAddress.Parse("156.225.99.223"), } },
},
            new IPAddressinetMArrayD2E1M
{
    Id = 159,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("85.14.223.251"),
System.Net.IPAddress.Parse("224.248.135.147"), } },
    ModelInner = new IPAddressinetMArrayD21MI
{
    Id = 98,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("72.64.150.243"),
System.Net.IPAddress.Parse("26.9.6.223"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("153.92.82.133"),
System.Net.IPAddress.Parse("175.150.62.26"), } },
},
    NullableValue = null,
},
            new IPAddressinetMArrayD2E1M
{
    Id = 162,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("75.62.46.75"),
System.Net.IPAddress.Parse("62.131.234.3"), } },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMArrayD2E1M
{
    Id = 163,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("74.205.23.3"),
System.Net.IPAddress.Parse("136.5.164.102"), } },
    ModelInner = new IPAddressinetMArrayD21MI
{
    Id = 99,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("180.10.108.93"),
System.Net.IPAddress.Parse("92.14.41.174"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("48.169.119.31"),
System.Net.IPAddress.Parse("140.85.0.214"), } },
},
    NullableValue = null,
},
            new IPAddressinetMArrayD2E1M
{
    Id = 168,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("5.105.124.75"),
System.Net.IPAddress.Parse("80.172.253.51"), } },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("208.167.159.103"),
System.Net.IPAddress.Parse("104.230.14.135"), } },
},
            new IPAddressinetMArrayD2E1M
{
    Id = 171,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("78.20.224.146"),
System.Net.IPAddress.Parse("82.210.155.37"), } },
    ModelInner = new IPAddressinetMArrayD21MI
{
    Id = 104,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("213.26.232.207"),
System.Net.IPAddress.Parse("234.243.81.174"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("66.211.32.223"),
System.Net.IPAddress.Parse("194.252.152.44"), } },
},
    NullableValue = null,
},
            new IPAddressinetMArrayD2E1M
{
    Id = 175,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("254.52.29.229"),
System.Net.IPAddress.Parse("97.6.170.59"), } },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmarrayd21mi(
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
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmarrayd21mi(
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
            queryMapTypes: [typeof(IPAddressinetMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624))]
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

                changedRows =  ((IIPAddressMArrayinetMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IIPAddressMArrayinetMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IIPAddressMArrayinetMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IIPAddressMArrayinetMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmarrayd2e1m(
	id,
    value,
    nullablevalue,
    ipaddressinetmarrayd21mi_id
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
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "ipaddressinetmarrayd21mi_id", 
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
                changedRows =  ((IIPAddressMArrayinetMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IIPAddressMArrayinetMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmarrayd2e1m(
	id,
    value,
    nullablevalue,
    ipaddressinetmarrayd21mi_id
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
    ipaddressinetmarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(IPAddressinetMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
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
                System.Net.IPAddress[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[,]>();
                    ((NpgsqlParameter<System.Net.IPAddress[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
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

                    nullable =  ((IIPAddressMArrayinetMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("81.65.115.150"),
System.Net.IPAddress.Parse("91.252.181.50"), } }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[,]>();
                    ((NpgsqlParameter<System.Net.IPAddress[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
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

                    nullable =  ((IIPAddressMArrayinetMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Net.IPAddress[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[,]>();
                    ((NpgsqlParameter<System.Net.IPAddress[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
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

                    nullable = await ((IIPAddressMArrayinetMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[,]>();
                    ((NpgsqlParameter<System.Net.IPAddress[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
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

                    nullable = await ((IIPAddressMArrayinetMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmarrayd2e1m(
	id,
    value,
    nullablevalue,
    ipaddressinetmarrayd21mi_id
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
    ipaddressinetmarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(IPAddressinetMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "ipaddressinetmarrayd21mi_id", 
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
                System.Net.IPAddress[,] nullable = null;
                nullable =  ((IIPAddressMArrayinetMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IIPAddressMArrayinetMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Net.IPAddress[,] nullable = null;
                nullable = await ((IIPAddressMArrayinetMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IIPAddressMArrayinetMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("10.220.213.55"),
System.Net.IPAddress.Parse("183.6.73.48"), } }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetMArrayD2E1M> models = null;

                models =  ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetMArrayD2E1M> models = null;

                models = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IIPAddressMArrayinetMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetMArrayD2E1M), typeof(FlatIPAddressinetMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var models2 = new List<FlatIPAddressinetMArrayD2E1M>();
                await ((IIPAddressMArrayinetMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var models2 = new List<FlatIPAddressinetMArrayD2E1M>();
                ((IIPAddressMArrayinetMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IIPAddressMArrayinetMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IIPAddressMArrayinetMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmarrayd2e1m m
LEFT JOIN public.ipaddressinetmarrayd21mi mi ON mi.id = m.ipaddressinetmarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinetMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
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
                var models = await ((IIPAddressMArrayinetMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IIPAddressMArrayinetMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetMArrayD2E1M), typeof(FlatIPAddressinetMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var models2 = new List<FlatIPAddressinetMArrayD2E1M>();
                await ((IIPAddressMArrayinetMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var models2 = new List<FlatIPAddressinetMArrayD2E1M>();
                ((IIPAddressMArrayinetMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IIPAddressMArrayinetMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressMArrayinetMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmarrayd2e1m m
LEFT JOIN public.ipaddressinetmarrayd21mi mi ON mi.id = m.ipaddressinetmarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(IPAddressinetMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
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
                var models = await ((IIPAddressMArrayinetMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IIPAddressMArrayinetMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetMArrayD2E1M), typeof(FlatIPAddressinetMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var models2 = new List<FlatIPAddressinetMArrayD2E1M>();
                await((IIPAddressMArrayinetMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 84;
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
FROM public.ipaddressinetmarrayd2e1m m
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var firstItems2 = new List<FlatIPAddressinetMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var secondItems2 = new List<FlatIPAddressinetMArrayD2E1M>();
                await ((IIPAddressMArrayinetMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 128;
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
FROM public.ipaddressinetmarrayd2e1m m
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var firstItems2 = new List<FlatIPAddressinetMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                await ((IIPAddressMArrayinetMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var models2 = new List<FlatIPAddressinetMArrayD2E1M>();
                ((IIPAddressMArrayinetMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 9;
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
FROM public.ipaddressinetmarrayd2e1m m
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var firstItems2 = new List<FlatIPAddressinetMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var secondItems2 = new List<FlatIPAddressinetMArrayD2E1M>();
                 ((IIPAddressMArrayinetMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
FROM public.ipaddressinetmarrayd2e1m m
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var firstItems2 = new List<FlatIPAddressinetMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                 ((IIPAddressMArrayinetMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IIPAddressMArrayinetMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetmarrayd2e1m m
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressMArrayinetMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 106;
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
FROM public.ipaddressinetmarrayd2e1m m
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var secondItems2 = new List<FlatIPAddressinetMArrayD2E1M>();
                await ((IIPAddressMArrayinetMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IIPAddressMArrayinetMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetmarrayd2e1m m
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressMArrayinetMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetmarrayd2e1m m
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var secondItems2 = new List<FlatIPAddressinetMArrayD2E1M>();
                 ((IIPAddressMArrayinetMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.ipaddressinetmarrayd2e1m m
LEFT JOIN public.ipaddressinetmarrayd21mi mi ON mi.id = m.ipaddressinetmarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinetMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
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
                var models = await((IIPAddressMArrayinetMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressMArrayinetMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[30],_testData[34], false);
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
                var models = ((IIPAddressMArrayinetMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressMArrayinetMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetMArrayD2E1M), typeof(FlatIPAddressinetMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var models2 = new List<FlatIPAddressinetMArrayD2E1M>();
                await((IIPAddressMArrayinetMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetmarrayd2e1m m
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var firstItems2 = new List<FlatIPAddressinetMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var secondItems2 = new List<FlatIPAddressinetMArrayD2E1M>();
                await ((IIPAddressMArrayinetMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 19, query1, 154, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.ipaddressinetmarrayd2e1m m
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var firstItems2 = new List<FlatIPAddressinetMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                await ((IIPAddressMArrayinetMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 50, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var models2 = new List<FlatIPAddressinetMArrayD2E1M>();
                ((IIPAddressMArrayinetMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetmarrayd2e1m m
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var firstItems2 = new List<FlatIPAddressinetMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var secondItems2 = new List<FlatIPAddressinetMArrayD2E1M>();
                 ((IIPAddressMArrayinetMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 78, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.ipaddressinetmarrayd2e1m m
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var firstItems2 = new List<FlatIPAddressinetMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                 ((IIPAddressMArrayinetMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 106, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IIPAddressMArrayinetMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmarrayd2e1m m
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressMArrayinetMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 163, query1, 163, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[2],_testData[34], false);
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
FROM public.ipaddressinetmarrayd2e1m m
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var secondItems2 = new List<FlatIPAddressinetMArrayD2E1M>();
                await ((IIPAddressMArrayinetMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 168, query1, 126, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressMArrayinetMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmarrayd2e1m m
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressMArrayinetMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 137, query1, 126, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
FROM public.ipaddressinetmarrayd2e1m m
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
FROM public.ipaddressinetmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD2E1M>();
                var secondItems2 = new List<FlatIPAddressinetMArrayD2E1M>();
                 ((IIPAddressMArrayinetMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 4, query1, 93, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatIPAddressinetMArrayD2E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.ipaddressinetmarrayd2e1m m
LEFT JOIN public.ipaddressinetmarrayd21mi mi ON mi.id = m.ipaddressinetmarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(IPAddressinetMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
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
                var models = await((IIPAddressMArrayinetMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IIPAddressMArrayinetMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 106, 122))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[11],_testData[34], false);
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
                var models = ((IIPAddressMArrayinetMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IIPAddressMArrayinetMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 126, 128))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        IPAddressinetMArrayD2E1M.AssertModel(models[9],_testData[34], false);
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
                await using var cmd = await ((IIPAddressMArrayinetMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IIPAddressMArrayinetMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 159);
                var models = await ((IIPAddressMArrayinetMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                IPAddressinetMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                IPAddressinetMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                IPAddressinetMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                IPAddressinetMArrayD2E1M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressMArrayinetMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressMArrayinetMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 84);
                var models =  ((IIPAddressMArrayinetMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                IPAddressinetMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                IPAddressinetMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                IPAddressinetMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                IPAddressinetMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                IPAddressinetMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                IPAddressinetMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                IPAddressinetMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                IPAddressinetMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                IPAddressinetMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                IPAddressinetMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                IPAddressinetMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                IPAddressinetMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                IPAddressinetMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                IPAddressinetMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                IPAddressinetMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                IPAddressinetMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                IPAddressinetMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                IPAddressinetMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                IPAddressinetMArrayD2E1M.AssertModel(models[18],_testData[34], false);
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
FROM public.binary_ipaddressinetmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(IPAddressinetMArrayD21MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMArrayD21MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressMArrayinetMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinetmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IIPAddressMArrayinetMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMArrayD21MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressMArrayinetMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinetmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressMArrayinetMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMArrayD21MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(IPAddressinetMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMArrayD21MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressMArrayinetMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinetmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IIPAddressMArrayinetMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMArrayD21MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressMArrayinetMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinetmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressMArrayinetMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMArrayD21MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetmarrayd21mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(IPAddressinetMArrayD21MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMArrayD21MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IIPAddressMArrayinetMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IIPAddressMArrayinetMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMArrayD21MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMArrayD21MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IIPAddressMArrayinetMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IIPAddressMArrayinetMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMArrayD21MI.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(IPAddressinetMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMArrayD21MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressMArrayinetMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IIPAddressMArrayinetMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMArrayD21MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressMArrayinetMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IIPAddressMArrayinetMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMArrayD21MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
ipaddressinetmarrayd21mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(IPAddressinetMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2))]
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
FROM public.binary_ipaddressinetmarrayd2e1m m
LEFT JOIN public.binary_ipaddressinetmarrayd21mi mi ON mi.id = m.ipaddressinetmarrayd21mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(IPAddressinetMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IIPAddressMArrayinetMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IIPAddressMArrayinetMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    IPAddressinetMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IIPAddressMArrayinetMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IIPAddressMArrayinetMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    IPAddressinetMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    ipaddressinetmarrayd21mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(IPAddressinetMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
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
                var models =  ((IIPAddressMArrayinetMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    IPAddressinetMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressMArrayinetMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    IPAddressinetMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD21MIWA), typeof(IPAddressinetMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
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
                var models1 = new List<IPAddressinetMArrayD21MIWA>();
                var models2 = new List<IPAddressinetMArrayD21MIWA>();
                await ((IIPAddressMArrayinetMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetMArrayD21MIWA>();
                var models2 = new List<IPAddressinetMArrayD21MIWA>();
                ((IIPAddressMArrayinetMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
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
                var models = await ((IIPAddressMArrayinetMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_ipaddressinetmarrayd21mi
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
                    IPAddressinetMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressMArrayinetMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_ipaddressinetmarrayd21mi
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
                    IPAddressinetMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD21MIWA), typeof(IPAddressinetMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2))]
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
                var models1 = new List<IPAddressinetMArrayD21MIWA>();
                var models2 = new List<IPAddressinetMArrayD21MIWA>();
                await ((IIPAddressMArrayinetMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetMArrayD21MIWA>();
                var models2 = new List<IPAddressinetMArrayD21MIWA>();
                ((IIPAddressMArrayinetMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2))]
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
                var models = await ((IIPAddressMArrayinetMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_ipaddressinetmarrayd21mi
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
                    IPAddressinetMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressMArrayinetMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_ipaddressinetmarrayd21mi
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
                    IPAddressinetMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_ipaddressinetmarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD21MI), typeof(IPAddressinetMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
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
                var models1 = new List<IPAddressinetMArrayD21MI>();
                var models2 = new List<IPAddressinetMArrayD21MI>();
                await ((IIPAddressMArrayinetMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMArrayD21MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetMArrayD21MI>();
                var models2 = new List<IPAddressinetMArrayD21MI>();
                ((IIPAddressMArrayinetMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMArrayD21MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetmarrayd21mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
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
                var models = await ((IIPAddressMArrayinetMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetMArrayD21MI.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressMArrayinetMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetMArrayD21MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_ipaddressinetmarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD21MIWA), typeof(IPAddressinetMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2))]
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
                var models1 = new List<IPAddressinetMArrayD21MIWA>();
                var models2 = new List<IPAddressinetMArrayD21MIWA>();
                await ((IIPAddressMArrayinetMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetMArrayD21MIWA>();
                var models2 = new List<IPAddressinetMArrayD21MIWA>();
                ((IIPAddressMArrayinetMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetmarrayd21mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD2))]
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
                var models = await ((IIPAddressMArrayinetMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressMArrayinetMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

