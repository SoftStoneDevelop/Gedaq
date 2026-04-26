

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
    internal partial interface IIPAddressArrayinetArray
    {
    }
    
    internal partial class IPAddressArrayinetArray : IIPAddressArrayinetArray
    {


#region TestData

        private readonly IPAddressinetArray1M[] _testData = new IPAddressinetArray1M[]
        {
            new IPAddressinetArray1M
{
    Id = 4,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("141.217.77.87"),
System.Net.IPAddress.Parse("129.246.191.61"),
System.Net.IPAddress.Parse("248.247.124.218"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 11,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("39.44.122.189"),
System.Net.IPAddress.Parse("68.209.141.43"),
System.Net.IPAddress.Parse("187.229.111.13"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 1,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("245.250.50.132"),
System.Net.IPAddress.Parse("125.161.108.102"),
System.Net.IPAddress.Parse("43.172.105.254"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 17,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("238.72.119.27"),
System.Net.IPAddress.Parse("87.168.105.142"),
System.Net.IPAddress.Parse("96.163.71.113"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 19,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("88.196.190.109"),
System.Net.IPAddress.Parse("38.120.226.103"),
System.Net.IPAddress.Parse("99.68.154.236"),
System.Net.IPAddress.Parse("40.166.58.248"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 9,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("135.95.2.180"),
System.Net.IPAddress.Parse("240.171.124.129"),
System.Net.IPAddress.Parse("96.189.74.228"),
System.Net.IPAddress.Parse("31.228.122.128"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("100.98.141.44"),
System.Net.IPAddress.Parse("22.45.62.102"),
System.Net.IPAddress.Parse("93.106.31.233"),
System.Net.IPAddress.Parse("83.238.51.127"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 26,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("63.125.171.207"),
System.Net.IPAddress.Parse("11.228.39.147"),
System.Net.IPAddress.Parse("36.205.91.130"),
System.Net.IPAddress.Parse("56.207.157.115"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 29,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("251.86.236.92"),
System.Net.IPAddress.Parse("237.127.222.8"),
System.Net.IPAddress.Parse("34.222.114.164"),
System.Net.IPAddress.Parse("162.54.32.30"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 13,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("252.45.115.122"),
System.Net.IPAddress.Parse("206.166.7.9"),
System.Net.IPAddress.Parse("219.157.96.37"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 32,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("74.217.117.111"),
System.Net.IPAddress.Parse("85.176.190.70"),
System.Net.IPAddress.Parse("49.132.12.13"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 41,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("108.155.171.220"),
System.Net.IPAddress.Parse("177.213.20.18"),
System.Net.IPAddress.Parse("49.206.180.224"),
System.Net.IPAddress.Parse("128.157.165.23"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 15,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("14.154.172.198"),
System.Net.IPAddress.Parse("141.34.183.115"),
System.Net.IPAddress.Parse("21.111.101.209"),
System.Net.IPAddress.Parse("75.142.41.2"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("163.119.50.53"),
System.Net.IPAddress.Parse("133.142.87.113"),
System.Net.IPAddress.Parse("248.231.7.142"),
System.Net.IPAddress.Parse("109.63.254.20"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("142.195.101.244"),
System.Net.IPAddress.Parse("248.99.204.70"),
System.Net.IPAddress.Parse("59.156.3.79"),
System.Net.IPAddress.Parse("141.245.177.215"),
},
},
            new IPAddressinetArray1M
{
    Id = 47,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("15.203.198.25"),
System.Net.IPAddress.Parse("157.236.42.204"),
System.Net.IPAddress.Parse("242.202.237.11"),
System.Net.IPAddress.Parse("109.103.32.45"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 48,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("207.208.184.75"),
System.Net.IPAddress.Parse("154.67.139.251"),
System.Net.IPAddress.Parse("70.80.239.144"),
System.Net.IPAddress.Parse("15.4.186.185"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 22,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("162.182.113.102"),
System.Net.IPAddress.Parse("65.248.206.29"),
System.Net.IPAddress.Parse("208.105.66.123"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("37.27.64.11"),
System.Net.IPAddress.Parse("229.190.57.215"),
System.Net.IPAddress.Parse("215.133.10.215"),
System.Net.IPAddress.Parse("118.62.37.80"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 52,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("233.144.161.113"),
System.Net.IPAddress.Parse("166.48.170.39"),
System.Net.IPAddress.Parse("18.236.143.10"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 60,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("208.201.60.122"),
System.Net.IPAddress.Parse("7.172.47.229"),
System.Net.IPAddress.Parse("212.167.67.33"),
System.Net.IPAddress.Parse("199.44.103.100"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 23,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("111.41.59.182"),
System.Net.IPAddress.Parse("179.108.31.135"),
System.Net.IPAddress.Parse("201.232.13.142"),
System.Net.IPAddress.Parse("28.246.121.137"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 65,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("123.44.170.4"),
System.Net.IPAddress.Parse("231.140.142.67"),
System.Net.IPAddress.Parse("136.49.0.52"),
System.Net.IPAddress.Parse("204.175.248.172"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 74,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("137.116.222.179"),
System.Net.IPAddress.Parse("69.71.23.209"),
System.Net.IPAddress.Parse("144.239.138.122"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 26,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("87.149.86.85"),
System.Net.IPAddress.Parse("150.117.210.16"),
System.Net.IPAddress.Parse("140.134.254.17"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("242.87.78.101"),
System.Net.IPAddress.Parse("186.19.205.189"),
System.Net.IPAddress.Parse("192.200.96.133"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("85.238.196.128"),
System.Net.IPAddress.Parse("212.104.201.184"),
System.Net.IPAddress.Parse("142.136.11.200"),
},
},
            new IPAddressinetArray1M
{
    Id = 82,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.195.173.20"),
System.Net.IPAddress.Parse("193.154.94.200"),
System.Net.IPAddress.Parse("147.216.139.53"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("108.38.116.122"),
System.Net.IPAddress.Parse("82.236.10.64"),
System.Net.IPAddress.Parse("246.185.37.131"),
},
},
            new IPAddressinetArray1M
{
    Id = 84,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("200.128.88.189"),
System.Net.IPAddress.Parse("120.242.31.210"),
System.Net.IPAddress.Parse("130.201.57.194"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 29,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("104.139.58.82"),
System.Net.IPAddress.Parse("140.167.194.10"),
System.Net.IPAddress.Parse("167.172.196.227"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.76.16.223"),
System.Net.IPAddress.Parse("133.179.229.236"),
System.Net.IPAddress.Parse("82.240.62.39"),
System.Net.IPAddress.Parse("218.236.190.62"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 85,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("70.250.242.228"),
System.Net.IPAddress.Parse("131.251.239.26"),
System.Net.IPAddress.Parse("21.87.159.199"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 94,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("254.82.83.134"),
System.Net.IPAddress.Parse("124.82.148.27"),
System.Net.IPAddress.Parse("72.107.122.93"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 36,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("207.92.250.138"),
System.Net.IPAddress.Parse("178.51.88.154"),
System.Net.IPAddress.Parse("25.39.204.112"),
System.Net.IPAddress.Parse("85.31.50.207"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 98,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("76.162.51.246"),
System.Net.IPAddress.Parse("157.196.156.209"),
System.Net.IPAddress.Parse("27.231.252.115"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 100,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("198.6.150.231"),
System.Net.IPAddress.Parse("49.65.193.182"),
System.Net.IPAddress.Parse("231.41.214.153"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 39,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("182.76.199.151"),
System.Net.IPAddress.Parse("36.238.75.12"),
System.Net.IPAddress.Parse("32.198.252.180"),
System.Net.IPAddress.Parse("93.40.30.194"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("248.61.178.12"),
System.Net.IPAddress.Parse("147.186.196.219"),
System.Net.IPAddress.Parse("151.200.221.202"),
System.Net.IPAddress.Parse("62.59.15.29"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 106,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("194.41.50.221"),
System.Net.IPAddress.Parse("189.12.142.146"),
System.Net.IPAddress.Parse("229.161.12.148"),
System.Net.IPAddress.Parse("14.121.83.0"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("78.29.70.80"),
System.Net.IPAddress.Parse("238.143.192.216"),
System.Net.IPAddress.Parse("114.5.17.15"),
},
},
            new IPAddressinetArray1M
{
    Id = 112,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("141.94.88.218"),
System.Net.IPAddress.Parse("84.76.117.145"),
System.Net.IPAddress.Parse("141.56.135.229"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 43,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("75.183.196.52"),
System.Net.IPAddress.Parse("169.237.43.167"),
System.Net.IPAddress.Parse("117.210.207.175"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("124.201.177.164"),
System.Net.IPAddress.Parse("250.133.146.113"),
System.Net.IPAddress.Parse("245.62.159.67"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("117.252.0.213"),
System.Net.IPAddress.Parse("188.243.247.92"),
System.Net.IPAddress.Parse("215.73.247.31"),
System.Net.IPAddress.Parse("175.199.26.142"),
},
},
            new IPAddressinetArray1M
{
    Id = 118,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("153.91.177.181"),
System.Net.IPAddress.Parse("41.180.15.175"),
System.Net.IPAddress.Parse("245.176.178.147"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("58.139.169.166"),
System.Net.IPAddress.Parse("20.71.141.91"),
System.Net.IPAddress.Parse("62.224.241.176"),
System.Net.IPAddress.Parse("116.135.80.5"),
},
},
            new IPAddressinetArray1M
{
    Id = 126,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("242.101.114.173"),
System.Net.IPAddress.Parse("4.77.59.118"),
System.Net.IPAddress.Parse("95.102.252.209"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 48,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("72.130.254.231"),
System.Net.IPAddress.Parse("172.126.240.168"),
System.Net.IPAddress.Parse("104.180.28.141"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("115.27.228.150"),
System.Net.IPAddress.Parse("229.66.248.31"),
System.Net.IPAddress.Parse("185.123.136.152"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 131,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("86.229.248.235"),
System.Net.IPAddress.Parse("55.237.48.97"),
System.Net.IPAddress.Parse("122.238.95.236"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("7.126.59.180"),
System.Net.IPAddress.Parse("249.130.66.209"),
System.Net.IPAddress.Parse("224.93.31.57"),
},
},
            new IPAddressinetArray1M
{
    Id = 139,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("11.48.150.15"),
System.Net.IPAddress.Parse("121.66.166.170"),
System.Net.IPAddress.Parse("30.131.223.112"),
System.Net.IPAddress.Parse("201.43.250.101"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 56,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("231.88.168.160"),
System.Net.IPAddress.Parse("35.252.146.59"),
System.Net.IPAddress.Parse("53.114.24.59"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("98.146.153.251"),
System.Net.IPAddress.Parse("249.185.116.26"),
System.Net.IPAddress.Parse("206.125.73.203"),
},
},
            new IPAddressinetArray1M
{
    Id = 144,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("220.26.99.240"),
System.Net.IPAddress.Parse("227.123.45.205"),
System.Net.IPAddress.Parse("8.137.203.226"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 149,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("217.179.180.202"),
System.Net.IPAddress.Parse("109.254.31.103"),
System.Net.IPAddress.Parse("108.21.162.91"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 63,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("49.163.130.56"),
System.Net.IPAddress.Parse("189.83.253.189"),
System.Net.IPAddress.Parse("187.217.6.130"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("204.215.168.59"),
System.Net.IPAddress.Parse("139.48.206.151"),
System.Net.IPAddress.Parse("80.54.92.71"),
},
},
            new IPAddressinetArray1M
{
    Id = 157,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("252.204.91.104"),
System.Net.IPAddress.Parse("122.202.81.71"),
System.Net.IPAddress.Parse("94.167.160.134"),
System.Net.IPAddress.Parse("187.178.114.77"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 160,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("223.27.30.94"),
System.Net.IPAddress.Parse("5.59.1.115"),
System.Net.IPAddress.Parse("150.215.135.133"),
System.Net.IPAddress.Parse("217.11.87.39"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 68,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("156.33.156.30"),
System.Net.IPAddress.Parse("233.153.76.194"),
System.Net.IPAddress.Parse("55.206.2.52"),
System.Net.IPAddress.Parse("207.70.240.153"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("42.227.43.220"),
System.Net.IPAddress.Parse("90.93.63.197"),
System.Net.IPAddress.Parse("122.139.164.9"),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray1mi(
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray1mi(
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
            queryMapTypes: [typeof(IPAddressinetArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]), 
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

                changedRows =  ((IIPAddressArrayinetArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IIPAddressArrayinetArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IIPAddressArrayinetArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressArrayinetArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IIPAddressArrayinetArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IIPAddressArrayinetArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray1m(
	id,
    value,
    nullablevalue,
    ipaddressinetarray1mi_id
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
            asPartInterface: typeof(IIPAddressArrayinetArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "ipaddressinetarray1mi_id", 
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
                changedRows =  ((IIPAddressArrayinetArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IIPAddressArrayinetArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IIPAddressArrayinetArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IIPAddressArrayinetArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray1m(
	id,
    value,
    nullablevalue,
    ipaddressinetarray1mi_id
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
    ipaddressinetarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                System.Net.IPAddress[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[]>();
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((IIPAddressArrayinetArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[]>();
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((IIPAddressArrayinetArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Net.IPAddress[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[]>();
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((IIPAddressArrayinetArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[]>();
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((IIPAddressArrayinetArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("142.195.101.244"),
System.Net.IPAddress.Parse("248.99.204.70"),
System.Net.IPAddress.Parse("59.156.3.79"),
System.Net.IPAddress.Parse("141.245.177.215"),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray1m(
	id,
    value,
    nullablevalue,
    ipaddressinetarray1mi_id
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
    ipaddressinetarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "ipaddressinetarray1mi_id", 
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
                System.Net.IPAddress[] nullable = null;
                nullable =  ((IIPAddressArrayinetArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IIPAddressArrayinetArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Net.IPAddress[] nullable = null;
                nullable = await ((IIPAddressArrayinetArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IIPAddressArrayinetArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetArray1M> models = null;

                models =  ((IIPAddressArrayinetArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IIPAddressArrayinetArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IIPAddressArrayinetArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IIPAddressArrayinetArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetArray1M> models = null;

                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M), typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                ((IIPAddressArrayinetArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IIPAddressArrayinetArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IIPAddressArrayinetArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                var models = await ((IIPAddressArrayinetArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IIPAddressArrayinetArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M), typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                ((IIPAddressArrayinetArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IIPAddressArrayinetArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressArrayinetArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                var models = await ((IIPAddressArrayinetArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IIPAddressArrayinetArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M), typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                await((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 131;
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[28],_testData[29], false);
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                 ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                 ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[26],_testData[29], false);
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                 ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[29], false);
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
FROM public.ipaddressinetarray1m m
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                var models = await((IIPAddressArrayinetArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[29], false);
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
                var models = ((IIPAddressArrayinetArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[7], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[8], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[9], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[10], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[9], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[10], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M), typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                await((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 94, query1, 144, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 84, query1, 29, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[29], false);
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                 ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 126, query1, 82, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                 ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 82, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 82, query1, 19, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[24],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[25],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 126, query1, 112, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[29], false);
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 131, query1, 106, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                 ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 84, query1, 26, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.ipaddressinetarray1m m
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                var models = await((IIPAddressArrayinetArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 17, 65))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[3], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[4], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[5], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[6], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[7], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[8], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[9], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[10], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[24],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[25],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[29], false);
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
                var models = ((IIPAddressArrayinetArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatch(connection, 131, 94))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[29], false);
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
                await using var cmd = await ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 4);
                var models = await ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
IPAddressinetArray1M.AssertModel(models[0],_testData[1], false);IPAddressinetArray1M.AssertModel(models[1],_testData[2], false);IPAddressinetArray1M.AssertModel(models[2],_testData[3], false);IPAddressinetArray1M.AssertModel(models[3],_testData[4], false);IPAddressinetArray1M.AssertModel(models[4],_testData[5], false);IPAddressinetArray1M.AssertModel(models[5],_testData[6], false);IPAddressinetArray1M.AssertModel(models[6],_testData[7], false);IPAddressinetArray1M.AssertModel(models[7],_testData[8], false);IPAddressinetArray1M.AssertModel(models[8],_testData[9], false);IPAddressinetArray1M.AssertModel(models[9],_testData[10], false);IPAddressinetArray1M.AssertModel(models[10],_testData[11], false);IPAddressinetArray1M.AssertModel(models[11],_testData[12], false);IPAddressinetArray1M.AssertModel(models[12],_testData[13], false);IPAddressinetArray1M.AssertModel(models[13],_testData[14], false);IPAddressinetArray1M.AssertModel(models[14],_testData[15], false);IPAddressinetArray1M.AssertModel(models[15],_testData[16], false);IPAddressinetArray1M.AssertModel(models[16],_testData[17], false);IPAddressinetArray1M.AssertModel(models[17],_testData[18], false);IPAddressinetArray1M.AssertModel(models[18],_testData[19], false);IPAddressinetArray1M.AssertModel(models[19],_testData[20], false);IPAddressinetArray1M.AssertModel(models[20],_testData[21], false);IPAddressinetArray1M.AssertModel(models[21],_testData[22], false);IPAddressinetArray1M.AssertModel(models[22],_testData[23], false);IPAddressinetArray1M.AssertModel(models[23],_testData[24], false);IPAddressinetArray1M.AssertModel(models[24],_testData[25], false);IPAddressinetArray1M.AssertModel(models[25],_testData[26], false);IPAddressinetArray1M.AssertModel(models[26],_testData[27], false);IPAddressinetArray1M.AssertModel(models[27],_testData[28], false);IPAddressinetArray1M.AssertModel(models[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 26);
                var models =  ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
IPAddressinetArray1M.AssertModel(models[0],_testData[5], false);IPAddressinetArray1M.AssertModel(models[1],_testData[6], false);IPAddressinetArray1M.AssertModel(models[2],_testData[7], false);IPAddressinetArray1M.AssertModel(models[3],_testData[8], false);IPAddressinetArray1M.AssertModel(models[4],_testData[9], false);IPAddressinetArray1M.AssertModel(models[5],_testData[10], false);IPAddressinetArray1M.AssertModel(models[6],_testData[11], false);IPAddressinetArray1M.AssertModel(models[7],_testData[12], false);IPAddressinetArray1M.AssertModel(models[8],_testData[13], false);IPAddressinetArray1M.AssertModel(models[9],_testData[14], false);IPAddressinetArray1M.AssertModel(models[10],_testData[15], false);IPAddressinetArray1M.AssertModel(models[11],_testData[16], false);IPAddressinetArray1M.AssertModel(models[12],_testData[17], false);IPAddressinetArray1M.AssertModel(models[13],_testData[18], false);IPAddressinetArray1M.AssertModel(models[14],_testData[19], false);IPAddressinetArray1M.AssertModel(models[15],_testData[20], false);IPAddressinetArray1M.AssertModel(models[16],_testData[21], false);IPAddressinetArray1M.AssertModel(models[17],_testData[22], false);IPAddressinetArray1M.AssertModel(models[18],_testData[23], false);IPAddressinetArray1M.AssertModel(models[19],_testData[24], false);IPAddressinetArray1M.AssertModel(models[20],_testData[25], false);IPAddressinetArray1M.AssertModel(models[21],_testData[26], false);IPAddressinetArray1M.AssertModel(models[22],_testData[27], false);IPAddressinetArray1M.AssertModel(models[23],_testData[28], false);IPAddressinetArray1M.AssertModel(models[24],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MI)],
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
            asPartInterface: typeof(IIPAddressArrayinetArray))]
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
FROM public.binary_ipaddressinetarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<IPAddressinetArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IIPAddressArrayinetArray)this).ImportModelInner(connection, importCollection);
                var models = ((IIPAddressArrayinetArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray1MI.AssertModel(actual, expect, false);
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
                await ((IIPAddressArrayinetArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IIPAddressArrayinetArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
ipaddressinetarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
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
            asPartInterface: typeof(IIPAddressArrayinetArray))]
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
FROM public.binary_ipaddressinetarray1m m
LEFT JOIN public.binary_ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<IPAddressinetArray1M>(15);

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
                ((IIPAddressArrayinetArray)this).ImportModel(connection, importCollection);
                var models = ((IIPAddressArrayinetArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                IPAddressinetArray1M.AssertModel(models[0],_testData[0], false);
                IPAddressinetArray1M.AssertModel(models[1],_testData[1], false);
                IPAddressinetArray1M.AssertModel(models[2],_testData[2], false);
                IPAddressinetArray1M.AssertModel(models[3],_testData[3], false);
                IPAddressinetArray1M.AssertModel(models[4],_testData[4], false);
                IPAddressinetArray1M.AssertModel(models[5],_testData[5], false);
                IPAddressinetArray1M.AssertModel(models[6],_testData[6], false);
                IPAddressinetArray1M.AssertModel(models[7],_testData[7], false);
                IPAddressinetArray1M.AssertModel(models[8],_testData[8], false);
                IPAddressinetArray1M.AssertModel(models[9],_testData[9], false);
                IPAddressinetArray1M.AssertModel(models[10],_testData[10], false);
                IPAddressinetArray1M.AssertModel(models[11],_testData[11], false);
                IPAddressinetArray1M.AssertModel(models[12],_testData[12], false);
                IPAddressinetArray1M.AssertModel(models[13],_testData[13], false);
                IPAddressinetArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((IIPAddressArrayinetArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IIPAddressArrayinetArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                IPAddressinetArray1M.AssertModel(models[0],_testData[0], false);
                IPAddressinetArray1M.AssertModel(models[1],_testData[1], false);
                IPAddressinetArray1M.AssertModel(models[2],_testData[2], false);
                IPAddressinetArray1M.AssertModel(models[3],_testData[3], false);
                IPAddressinetArray1M.AssertModel(models[4],_testData[4], false);
                IPAddressinetArray1M.AssertModel(models[5],_testData[5], false);
                IPAddressinetArray1M.AssertModel(models[6],_testData[6], false);
                IPAddressinetArray1M.AssertModel(models[7],_testData[7], false);
                IPAddressinetArray1M.AssertModel(models[8],_testData[8], false);
                IPAddressinetArray1M.AssertModel(models[9],_testData[9], false);
                IPAddressinetArray1M.AssertModel(models[10],_testData[10], false);
                IPAddressinetArray1M.AssertModel(models[11],_testData[11], false);
                IPAddressinetArray1M.AssertModel(models[12],_testData[12], false);
                IPAddressinetArray1M.AssertModel(models[13],_testData[13], false);
                IPAddressinetArray1M.AssertModel(models[14],_testData[14], false);
                IPAddressinetArray1M.AssertModel(models[15],_testData[15], false);
                IPAddressinetArray1M.AssertModel(models[16],_testData[16], false);
                IPAddressinetArray1M.AssertModel(models[17],_testData[17], false);
                IPAddressinetArray1M.AssertModel(models[18],_testData[18], false);
                IPAddressinetArray1M.AssertModel(models[19],_testData[19], false);
                IPAddressinetArray1M.AssertModel(models[20],_testData[20], false);
                IPAddressinetArray1M.AssertModel(models[21],_testData[21], false);
                IPAddressinetArray1M.AssertModel(models[22],_testData[22], false);
                IPAddressinetArray1M.AssertModel(models[23],_testData[23], false);
                IPAddressinetArray1M.AssertModel(models[24],_testData[24], false);
                IPAddressinetArray1M.AssertModel(models[25],_testData[25], false);
                IPAddressinetArray1M.AssertModel(models[26],_testData[26], false);
                IPAddressinetArray1M.AssertModel(models[27],_testData[27], false);
                IPAddressinetArray1M.AssertModel(models[28],_testData[28], false);
                IPAddressinetArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    ipaddressinetarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
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
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IIPAddressArrayinetArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    IPAddressinetArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressArrayinetArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    IPAddressinetArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MI)],
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
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IIPAddressArrayinetArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressArrayinetArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

