

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
    Id = 6,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("53.111.171.252"),
System.Net.IPAddress.Parse("209.196.34.243"),
System.Net.IPAddress.Parse("84.135.0.139"),
System.Net.IPAddress.Parse("120.88.166.162"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 10,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("69.243.231.205"),
System.Net.IPAddress.Parse("248.179.51.145"),
System.Net.IPAddress.Parse("149.98.56.176"),
System.Net.IPAddress.Parse("62.73.88.206"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 8,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("135.182.212.63"),
System.Net.IPAddress.Parse("145.53.102.73"),
System.Net.IPAddress.Parse("68.8.135.240"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("239.115.100.141"),
System.Net.IPAddress.Parse("154.207.169.252"),
System.Net.IPAddress.Parse("175.51.133.140"),
System.Net.IPAddress.Parse("228.220.190.17"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("61.106.147.237"),
System.Net.IPAddress.Parse("63.58.214.215"),
System.Net.IPAddress.Parse("128.154.238.222"),
},
},
            new IPAddressinetArray1M
{
    Id = 17,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("220.53.20.121"),
System.Net.IPAddress.Parse("119.5.165.75"),
System.Net.IPAddress.Parse("19.198.16.248"),
System.Net.IPAddress.Parse("157.10.56.185"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 20,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("199.209.145.84"),
System.Net.IPAddress.Parse("155.5.73.211"),
System.Net.IPAddress.Parse("199.85.198.66"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 16,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("221.70.85.177"),
System.Net.IPAddress.Parse("32.164.143.90"),
System.Net.IPAddress.Parse("155.243.224.109"),
System.Net.IPAddress.Parse("122.234.166.147"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("118.33.199.244"),
System.Net.IPAddress.Parse("230.217.26.44"),
System.Net.IPAddress.Parse("82.146.107.139"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("73.5.189.165"),
System.Net.IPAddress.Parse("211.201.71.202"),
System.Net.IPAddress.Parse("56.71.210.213"),
},
},
            new IPAddressinetArray1M
{
    Id = 23,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("21.244.99.205"),
System.Net.IPAddress.Parse("133.160.90.245"),
System.Net.IPAddress.Parse("62.248.197.23"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 30,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("137.60.63.190"),
System.Net.IPAddress.Parse("141.183.210.215"),
System.Net.IPAddress.Parse("162.44.183.55"),
System.Net.IPAddress.Parse("164.64.252.246"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 17,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("67.47.179.19"),
System.Net.IPAddress.Parse("230.240.77.235"),
System.Net.IPAddress.Parse("217.128.245.166"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 36,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("113.91.108.137"),
System.Net.IPAddress.Parse("253.137.241.23"),
System.Net.IPAddress.Parse("129.168.79.112"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("244.167.240.77"),
System.Net.IPAddress.Parse("131.87.1.226"),
System.Net.IPAddress.Parse("200.106.13.106"),
System.Net.IPAddress.Parse("144.206.38.204"),
},
},
            new IPAddressinetArray1M
{
    Id = 41,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("66.13.210.200"),
System.Net.IPAddress.Parse("221.249.197.96"),
System.Net.IPAddress.Parse("54.97.87.131"),
System.Net.IPAddress.Parse("62.5.82.251"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 21,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("252.136.58.235"),
System.Net.IPAddress.Parse("4.112.87.250"),
System.Net.IPAddress.Parse("75.244.88.122"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("110.41.90.25"),
System.Net.IPAddress.Parse("10.14.204.74"),
System.Net.IPAddress.Parse("114.239.34.118"),
System.Net.IPAddress.Parse("159.176.31.217"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 44,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("193.129.43.191"),
System.Net.IPAddress.Parse("249.218.143.65"),
System.Net.IPAddress.Parse("238.145.115.57"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("97.80.88.137"),
System.Net.IPAddress.Parse("163.217.225.119"),
System.Net.IPAddress.Parse("85.200.204.99"),
System.Net.IPAddress.Parse("51.208.154.127"),
},
},
            new IPAddressinetArray1M
{
    Id = 46,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("158.246.77.163"),
System.Net.IPAddress.Parse("189.153.119.177"),
System.Net.IPAddress.Parse("172.194.115.226"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 27,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("155.99.45.217"),
System.Net.IPAddress.Parse("199.148.87.216"),
System.Net.IPAddress.Parse("233.131.107.122"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("218.81.167.102"),
System.Net.IPAddress.Parse("99.192.112.102"),
System.Net.IPAddress.Parse("109.218.105.224"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 54,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("138.147.130.18"),
System.Net.IPAddress.Parse("75.141.47.130"),
System.Net.IPAddress.Parse("15.116.227.91"),
System.Net.IPAddress.Parse("105.58.254.253"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 59,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("71.144.113.13"),
System.Net.IPAddress.Parse("47.154.119.50"),
System.Net.IPAddress.Parse("240.26.219.127"),
System.Net.IPAddress.Parse("99.90.245.148"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 36,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("3.205.193.143"),
System.Net.IPAddress.Parse("89.241.139.44"),
System.Net.IPAddress.Parse("41.135.24.190"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("29.101.203.102"),
System.Net.IPAddress.Parse("1.53.232.140"),
System.Net.IPAddress.Parse("74.95.51.0"),
System.Net.IPAddress.Parse("251.232.202.209"),
},
},
            new IPAddressinetArray1M
{
    Id = 61,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("164.177.120.115"),
System.Net.IPAddress.Parse("81.191.59.228"),
System.Net.IPAddress.Parse("233.139.189.18"),
System.Net.IPAddress.Parse("228.172.118.163"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("129.180.116.242"),
System.Net.IPAddress.Parse("36.94.73.249"),
System.Net.IPAddress.Parse("173.200.185.23"),
},
},
            new IPAddressinetArray1M
{
    Id = 69,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("201.73.130.155"),
System.Net.IPAddress.Parse("101.217.166.94"),
System.Net.IPAddress.Parse("26.198.187.42"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 44,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("105.52.174.74"),
System.Net.IPAddress.Parse("26.252.83.76"),
System.Net.IPAddress.Parse("243.72.107.8"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("28.38.192.76"),
System.Net.IPAddress.Parse("69.231.10.39"),
System.Net.IPAddress.Parse("108.135.109.115"),
},
},
            new IPAddressinetArray1M
{
    Id = 75,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("157.214.60.99"),
System.Net.IPAddress.Parse("210.73.40.70"),
System.Net.IPAddress.Parse("35.141.235.100"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 78,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("64.23.254.54"),
System.Net.IPAddress.Parse("236.73.104.38"),
System.Net.IPAddress.Parse("81.103.248.180"),
System.Net.IPAddress.Parse("4.177.223.44"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 45,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("97.77.153.93"),
System.Net.IPAddress.Parse("239.145.32.238"),
System.Net.IPAddress.Parse("253.214.88.195"),
System.Net.IPAddress.Parse("60.23.249.29"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("141.69.25.218"),
System.Net.IPAddress.Parse("223.72.153.193"),
System.Net.IPAddress.Parse("50.191.244.172"),
System.Net.IPAddress.Parse("250.130.25.160"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("100.197.127.235"),
System.Net.IPAddress.Parse("24.176.94.38"),
System.Net.IPAddress.Parse("229.76.141.36"),
},
},
            new IPAddressinetArray1M
{
    Id = 86,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("59.21.53.202"),
System.Net.IPAddress.Parse("172.115.103.8"),
System.Net.IPAddress.Parse("35.164.113.7"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("239.44.101.234"),
System.Net.IPAddress.Parse("74.24.150.248"),
System.Net.IPAddress.Parse("4.18.210.142"),
},
},
            new IPAddressinetArray1M
{
    Id = 91,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("52.202.192.230"),
System.Net.IPAddress.Parse("30.185.94.54"),
System.Net.IPAddress.Parse("189.216.165.107"),
System.Net.IPAddress.Parse("138.54.159.0"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 53,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("132.154.62.159"),
System.Net.IPAddress.Parse("25.159.46.88"),
System.Net.IPAddress.Parse("68.2.129.193"),
System.Net.IPAddress.Parse("228.143.138.208"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 99,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("147.190.30.102"),
System.Net.IPAddress.Parse("174.178.155.142"),
System.Net.IPAddress.Parse("204.4.232.69"),
System.Net.IPAddress.Parse("22.162.218.151"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("106.183.237.6"),
System.Net.IPAddress.Parse("28.226.13.108"),
System.Net.IPAddress.Parse("243.27.250.4"),
},
},
            new IPAddressinetArray1M
{
    Id = 106,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("57.87.89.127"),
System.Net.IPAddress.Parse("69.224.226.198"),
System.Net.IPAddress.Parse("109.89.73.18"),
System.Net.IPAddress.Parse("37.98.242.37"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 54,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("186.69.40.171"),
System.Net.IPAddress.Parse("230.11.8.6"),
System.Net.IPAddress.Parse("128.248.160.206"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 107,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("167.169.85.103"),
System.Net.IPAddress.Parse("136.130.198.15"),
System.Net.IPAddress.Parse("158.92.28.175"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 116,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("75.188.167.141"),
System.Net.IPAddress.Parse("179.250.200.29"),
System.Net.IPAddress.Parse("225.110.17.76"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 59,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("190.134.151.188"),
System.Net.IPAddress.Parse("194.234.228.103"),
System.Net.IPAddress.Parse("2.147.32.130"),
System.Net.IPAddress.Parse("173.107.207.239"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 118,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("243.223.146.142"),
System.Net.IPAddress.Parse("238.4.24.85"),
System.Net.IPAddress.Parse("229.92.129.215"),
System.Net.IPAddress.Parse("182.51.67.166"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 123,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("13.219.128.203"),
System.Net.IPAddress.Parse("27.14.251.26"),
System.Net.IPAddress.Parse("205.63.160.168"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 62,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("62.202.201.138"),
System.Net.IPAddress.Parse("203.171.162.67"),
System.Net.IPAddress.Parse("197.105.62.179"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("51.8.124.8"),
System.Net.IPAddress.Parse("102.153.41.100"),
System.Net.IPAddress.Parse("32.17.217.49"),
System.Net.IPAddress.Parse("170.249.70.205"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("15.105.195.246"),
System.Net.IPAddress.Parse("122.78.129.79"),
System.Net.IPAddress.Parse("140.170.0.198"),
},
},
            new IPAddressinetArray1M
{
    Id = 124,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("21.111.244.53"),
System.Net.IPAddress.Parse("244.171.216.227"),
System.Net.IPAddress.Parse("91.254.51.185"),
System.Net.IPAddress.Parse("189.244.236.222"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 125,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("189.58.109.186"),
System.Net.IPAddress.Parse("217.10.25.119"),
System.Net.IPAddress.Parse("93.49.91.29"),
System.Net.IPAddress.Parse("138.244.113.127"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 65,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("163.224.8.28"),
System.Net.IPAddress.Parse("219.115.97.5"),
System.Net.IPAddress.Parse("14.152.34.38"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("127.58.146.143"),
System.Net.IPAddress.Parse("249.201.67.3"),
System.Net.IPAddress.Parse("115.112.12.180"),
System.Net.IPAddress.Parse("80.113.103.213"),
},
},
            new IPAddressinetArray1M
{
    Id = 129,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("219.243.188.193"),
System.Net.IPAddress.Parse("94.92.232.30"),
System.Net.IPAddress.Parse("115.58.209.27"),
System.Net.IPAddress.Parse("22.212.253.50"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 134,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.133.88.184"),
System.Net.IPAddress.Parse("132.202.184.90"),
System.Net.IPAddress.Parse("175.180.80.236"),
System.Net.IPAddress.Parse("38.219.114.49"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 70,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("120.214.213.2"),
System.Net.IPAddress.Parse("229.146.169.210"),
System.Net.IPAddress.Parse("154.92.90.238"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("2.127.114.212"),
System.Net.IPAddress.Parse("165.141.235.131"),
System.Net.IPAddress.Parse("132.83.28.11"),
System.Net.IPAddress.Parse("8.105.51.117"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 142,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("177.209.27.28"),
System.Net.IPAddress.Parse("132.20.2.125"),
System.Net.IPAddress.Parse("90.58.61.94"),
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
System.Net.IPAddress.Parse("149.230.91.135"),
System.Net.IPAddress.Parse("8.10.143.29"),
System.Net.IPAddress.Parse("19.43.233.102"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 79,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("80.218.101.0"),
System.Net.IPAddress.Parse("132.143.162.189"),
System.Net.IPAddress.Parse("8.209.22.227"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("60.119.234.233"),
System.Net.IPAddress.Parse("73.191.9.116"),
System.Net.IPAddress.Parse("92.226.119.137"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("244.167.240.77"),
System.Net.IPAddress.Parse("131.87.1.226"),
System.Net.IPAddress.Parse("200.106.13.106"),
System.Net.IPAddress.Parse("144.206.38.204"),
}));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("97.80.88.137"),
System.Net.IPAddress.Parse("163.217.225.119"),
System.Net.IPAddress.Parse("85.200.204.99"),
System.Net.IPAddress.Parse("51.208.154.127"),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("29.101.203.102"),
System.Net.IPAddress.Parse("1.53.232.140"),
System.Net.IPAddress.Parse("74.95.51.0"),
System.Net.IPAddress.Parse("251.232.202.209"),
}));
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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M)],
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
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
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
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IIPAddressArrayinetArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((IIPAddressArrayinetArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M)],
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
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
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
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IIPAddressArrayinetArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((IIPAddressArrayinetArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray1m m
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
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
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
FlatIPAddressinetArray1M.AssertModel(models[0],_testData[17], false);FlatIPAddressinetArray1M.AssertModel(models[1],_testData[18], false);FlatIPAddressinetArray1M.AssertModel(models[2],_testData[19], false);FlatIPAddressinetArray1M.AssertModel(models[3],_testData[20], false);FlatIPAddressinetArray1M.AssertModel(models[4],_testData[21], false);FlatIPAddressinetArray1M.AssertModel(models[5],_testData[22], false);FlatIPAddressinetArray1M.AssertModel(models[6],_testData[23], false);FlatIPAddressinetArray1M.AssertModel(models[7],_testData[24], false);FlatIPAddressinetArray1M.AssertModel(models[8],_testData[25], false);FlatIPAddressinetArray1M.AssertModel(models[9],_testData[26], false);FlatIPAddressinetArray1M.AssertModel(models[10],_testData[27], false);FlatIPAddressinetArray1M.AssertModel(models[11],_testData[28], false);FlatIPAddressinetArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatIPAddressinetArray1M.AssertModel(models[0],_testData[26], false);FlatIPAddressinetArray1M.AssertModel(models[1],_testData[27], false);FlatIPAddressinetArray1M.AssertModel(models[2],_testData[28], false);FlatIPAddressinetArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray1m m
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
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
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatIPAddressinetArray1M.AssertModel(models[0],_testData[1], false);FlatIPAddressinetArray1M.AssertModel(models[1],_testData[2], false);FlatIPAddressinetArray1M.AssertModel(models[2],_testData[3], false);FlatIPAddressinetArray1M.AssertModel(models[3],_testData[4], false);FlatIPAddressinetArray1M.AssertModel(models[4],_testData[5], false);FlatIPAddressinetArray1M.AssertModel(models[5],_testData[6], false);FlatIPAddressinetArray1M.AssertModel(models[6],_testData[7], false);FlatIPAddressinetArray1M.AssertModel(models[7],_testData[8], false);FlatIPAddressinetArray1M.AssertModel(models[8],_testData[9], false);FlatIPAddressinetArray1M.AssertModel(models[9],_testData[10], false);FlatIPAddressinetArray1M.AssertModel(models[10],_testData[11], false);FlatIPAddressinetArray1M.AssertModel(models[11],_testData[12], false);FlatIPAddressinetArray1M.AssertModel(models[12],_testData[13], false);FlatIPAddressinetArray1M.AssertModel(models[13],_testData[14], false);FlatIPAddressinetArray1M.AssertModel(models[14],_testData[15], false);FlatIPAddressinetArray1M.AssertModel(models[15],_testData[16], false);FlatIPAddressinetArray1M.AssertModel(models[16],_testData[17], false);FlatIPAddressinetArray1M.AssertModel(models[17],_testData[18], false);FlatIPAddressinetArray1M.AssertModel(models[18],_testData[19], false);FlatIPAddressinetArray1M.AssertModel(models[19],_testData[20], false);FlatIPAddressinetArray1M.AssertModel(models[20],_testData[21], false);FlatIPAddressinetArray1M.AssertModel(models[21],_testData[22], false);FlatIPAddressinetArray1M.AssertModel(models[22],_testData[23], false);FlatIPAddressinetArray1M.AssertModel(models[23],_testData[24], false);FlatIPAddressinetArray1M.AssertModel(models[24],_testData[25], false);FlatIPAddressinetArray1M.AssertModel(models[25],_testData[26], false);FlatIPAddressinetArray1M.AssertModel(models[26],_testData[27], false);FlatIPAddressinetArray1M.AssertModel(models[27],_testData[28], false);FlatIPAddressinetArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatIPAddressinetArray1M.AssertModel(models[0],_testData[18], false);FlatIPAddressinetArray1M.AssertModel(models[1],_testData[19], false);FlatIPAddressinetArray1M.AssertModel(models[2],_testData[20], false);FlatIPAddressinetArray1M.AssertModel(models[3],_testData[21], false);FlatIPAddressinetArray1M.AssertModel(models[4],_testData[22], false);FlatIPAddressinetArray1M.AssertModel(models[5],_testData[23], false);FlatIPAddressinetArray1M.AssertModel(models[6],_testData[24], false);FlatIPAddressinetArray1M.AssertModel(models[7],_testData[25], false);FlatIPAddressinetArray1M.AssertModel(models[8],_testData[26], false);FlatIPAddressinetArray1M.AssertModel(models[9],_testData[27], false);FlatIPAddressinetArray1M.AssertModel(models[10],_testData[28], false);FlatIPAddressinetArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((IIPAddressArrayinetArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
IPAddressinetArray1M.AssertModel(models[0],_testData[1], false);IPAddressinetArray1M.AssertModel(models[1],_testData[2], false);IPAddressinetArray1M.AssertModel(models[2],_testData[3], false);IPAddressinetArray1M.AssertModel(models[3],_testData[4], false);IPAddressinetArray1M.AssertModel(models[4],_testData[5], false);IPAddressinetArray1M.AssertModel(models[5],_testData[6], false);IPAddressinetArray1M.AssertModel(models[6],_testData[7], false);IPAddressinetArray1M.AssertModel(models[7],_testData[8], false);IPAddressinetArray1M.AssertModel(models[8],_testData[9], false);IPAddressinetArray1M.AssertModel(models[9],_testData[10], false);IPAddressinetArray1M.AssertModel(models[10],_testData[11], false);IPAddressinetArray1M.AssertModel(models[11],_testData[12], false);IPAddressinetArray1M.AssertModel(models[12],_testData[13], false);IPAddressinetArray1M.AssertModel(models[13],_testData[14], false);IPAddressinetArray1M.AssertModel(models[14],_testData[15], false);IPAddressinetArray1M.AssertModel(models[15],_testData[16], false);IPAddressinetArray1M.AssertModel(models[16],_testData[17], false);IPAddressinetArray1M.AssertModel(models[17],_testData[18], false);IPAddressinetArray1M.AssertModel(models[18],_testData[19], false);IPAddressinetArray1M.AssertModel(models[19],_testData[20], false);IPAddressinetArray1M.AssertModel(models[20],_testData[21], false);IPAddressinetArray1M.AssertModel(models[21],_testData[22], false);IPAddressinetArray1M.AssertModel(models[22],_testData[23], false);IPAddressinetArray1M.AssertModel(models[23],_testData[24], false);IPAddressinetArray1M.AssertModel(models[24],_testData[25], false);IPAddressinetArray1M.AssertModel(models[25],_testData[26], false);IPAddressinetArray1M.AssertModel(models[26],_testData[27], false);IPAddressinetArray1M.AssertModel(models[27],_testData[28], false);IPAddressinetArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
IPAddressinetArray1M.AssertModel(models[0],_testData[8], false);IPAddressinetArray1M.AssertModel(models[1],_testData[9], false);IPAddressinetArray1M.AssertModel(models[2],_testData[10], false);IPAddressinetArray1M.AssertModel(models[3],_testData[11], false);IPAddressinetArray1M.AssertModel(models[4],_testData[12], false);IPAddressinetArray1M.AssertModel(models[5],_testData[13], false);IPAddressinetArray1M.AssertModel(models[6],_testData[14], false);IPAddressinetArray1M.AssertModel(models[7],_testData[15], false);IPAddressinetArray1M.AssertModel(models[8],_testData[16], false);IPAddressinetArray1M.AssertModel(models[9],_testData[17], false);IPAddressinetArray1M.AssertModel(models[10],_testData[18], false);IPAddressinetArray1M.AssertModel(models[11],_testData[19], false);IPAddressinetArray1M.AssertModel(models[12],_testData[20], false);IPAddressinetArray1M.AssertModel(models[13],_testData[21], false);IPAddressinetArray1M.AssertModel(models[14],_testData[22], false);IPAddressinetArray1M.AssertModel(models[15],_testData[23], false);IPAddressinetArray1M.AssertModel(models[16],_testData[24], false);IPAddressinetArray1M.AssertModel(models[17],_testData[25], false);IPAddressinetArray1M.AssertModel(models[18],_testData[26], false);IPAddressinetArray1M.AssertModel(models[19],_testData[27], false);IPAddressinetArray1M.AssertModel(models[20],_testData[28], false);IPAddressinetArray1M.AssertModel(models[21],_testData[29], false);
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

                var models =  ((IIPAddressArrayinetArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
IPAddressinetArray1M.AssertModel(models[0],_testData[1], false);IPAddressinetArray1M.AssertModel(models[1],_testData[2], false);IPAddressinetArray1M.AssertModel(models[2],_testData[3], false);IPAddressinetArray1M.AssertModel(models[3],_testData[4], false);IPAddressinetArray1M.AssertModel(models[4],_testData[5], false);IPAddressinetArray1M.AssertModel(models[5],_testData[6], false);IPAddressinetArray1M.AssertModel(models[6],_testData[7], false);IPAddressinetArray1M.AssertModel(models[7],_testData[8], false);IPAddressinetArray1M.AssertModel(models[8],_testData[9], false);IPAddressinetArray1M.AssertModel(models[9],_testData[10], false);IPAddressinetArray1M.AssertModel(models[10],_testData[11], false);IPAddressinetArray1M.AssertModel(models[11],_testData[12], false);IPAddressinetArray1M.AssertModel(models[12],_testData[13], false);IPAddressinetArray1M.AssertModel(models[13],_testData[14], false);IPAddressinetArray1M.AssertModel(models[14],_testData[15], false);IPAddressinetArray1M.AssertModel(models[15],_testData[16], false);IPAddressinetArray1M.AssertModel(models[16],_testData[17], false);IPAddressinetArray1M.AssertModel(models[17],_testData[18], false);IPAddressinetArray1M.AssertModel(models[18],_testData[19], false);IPAddressinetArray1M.AssertModel(models[19],_testData[20], false);IPAddressinetArray1M.AssertModel(models[20],_testData[21], false);IPAddressinetArray1M.AssertModel(models[21],_testData[22], false);IPAddressinetArray1M.AssertModel(models[22],_testData[23], false);IPAddressinetArray1M.AssertModel(models[23],_testData[24], false);IPAddressinetArray1M.AssertModel(models[24],_testData[25], false);IPAddressinetArray1M.AssertModel(models[25],_testData[26], false);IPAddressinetArray1M.AssertModel(models[26],_testData[27], false);IPAddressinetArray1M.AssertModel(models[27],_testData[28], false);IPAddressinetArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
IPAddressinetArray1M.AssertModel(models[0],_testData[15], false);IPAddressinetArray1M.AssertModel(models[1],_testData[16], false);IPAddressinetArray1M.AssertModel(models[2],_testData[17], false);IPAddressinetArray1M.AssertModel(models[3],_testData[18], false);IPAddressinetArray1M.AssertModel(models[4],_testData[19], false);IPAddressinetArray1M.AssertModel(models[5],_testData[20], false);IPAddressinetArray1M.AssertModel(models[6],_testData[21], false);IPAddressinetArray1M.AssertModel(models[7],_testData[22], false);IPAddressinetArray1M.AssertModel(models[8],_testData[23], false);IPAddressinetArray1M.AssertModel(models[9],_testData[24], false);IPAddressinetArray1M.AssertModel(models[10],_testData[25], false);IPAddressinetArray1M.AssertModel(models[11],_testData[26], false);IPAddressinetArray1M.AssertModel(models[12],_testData[27], false);IPAddressinetArray1M.AssertModel(models[13],_testData[28], false);IPAddressinetArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
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
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 59, query1, 59, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatIPAddressinetArray1M.AssertModel(models[0],_testData[12], false);FlatIPAddressinetArray1M.AssertModel(models[1],_testData[13], false);FlatIPAddressinetArray1M.AssertModel(models[2],_testData[14], false);FlatIPAddressinetArray1M.AssertModel(models[3],_testData[15], false);FlatIPAddressinetArray1M.AssertModel(models[4],_testData[16], false);FlatIPAddressinetArray1M.AssertModel(models[5],_testData[17], false);FlatIPAddressinetArray1M.AssertModel(models[6],_testData[18], false);FlatIPAddressinetArray1M.AssertModel(models[7],_testData[19], false);FlatIPAddressinetArray1M.AssertModel(models[8],_testData[20], false);FlatIPAddressinetArray1M.AssertModel(models[9],_testData[21], false);FlatIPAddressinetArray1M.AssertModel(models[10],_testData[22], false);FlatIPAddressinetArray1M.AssertModel(models[11],_testData[23], false);FlatIPAddressinetArray1M.AssertModel(models[12],_testData[24], false);FlatIPAddressinetArray1M.AssertModel(models[13],_testData[25], false);FlatIPAddressinetArray1M.AssertModel(models[14],_testData[26], false);FlatIPAddressinetArray1M.AssertModel(models[15],_testData[27], false);FlatIPAddressinetArray1M.AssertModel(models[16],_testData[28], false);FlatIPAddressinetArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatIPAddressinetArray1M.AssertModel(models[0],_testData[12], false);FlatIPAddressinetArray1M.AssertModel(models[1],_testData[13], false);FlatIPAddressinetArray1M.AssertModel(models[2],_testData[14], false);FlatIPAddressinetArray1M.AssertModel(models[3],_testData[15], false);FlatIPAddressinetArray1M.AssertModel(models[4],_testData[16], false);FlatIPAddressinetArray1M.AssertModel(models[5],_testData[17], false);FlatIPAddressinetArray1M.AssertModel(models[6],_testData[18], false);FlatIPAddressinetArray1M.AssertModel(models[7],_testData[19], false);FlatIPAddressinetArray1M.AssertModel(models[8],_testData[20], false);FlatIPAddressinetArray1M.AssertModel(models[9],_testData[21], false);FlatIPAddressinetArray1M.AssertModel(models[10],_testData[22], false);FlatIPAddressinetArray1M.AssertModel(models[11],_testData[23], false);FlatIPAddressinetArray1M.AssertModel(models[12],_testData[24], false);FlatIPAddressinetArray1M.AssertModel(models[13],_testData[25], false);FlatIPAddressinetArray1M.AssertModel(models[14],_testData[26], false);FlatIPAddressinetArray1M.AssertModel(models[15],_testData[27], false);FlatIPAddressinetArray1M.AssertModel(models[16],_testData[28], false);FlatIPAddressinetArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
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
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 106, query1, 99, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatIPAddressinetArray1M.AssertModel(models[0],_testData[20], false);FlatIPAddressinetArray1M.AssertModel(models[1],_testData[21], false);FlatIPAddressinetArray1M.AssertModel(models[2],_testData[22], false);FlatIPAddressinetArray1M.AssertModel(models[3],_testData[23], false);FlatIPAddressinetArray1M.AssertModel(models[4],_testData[24], false);FlatIPAddressinetArray1M.AssertModel(models[5],_testData[25], false);FlatIPAddressinetArray1M.AssertModel(models[6],_testData[26], false);FlatIPAddressinetArray1M.AssertModel(models[7],_testData[27], false);FlatIPAddressinetArray1M.AssertModel(models[8],_testData[28], false);FlatIPAddressinetArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatIPAddressinetArray1M.AssertModel(models[0],_testData[19], false);FlatIPAddressinetArray1M.AssertModel(models[1],_testData[20], false);FlatIPAddressinetArray1M.AssertModel(models[2],_testData[21], false);FlatIPAddressinetArray1M.AssertModel(models[3],_testData[22], false);FlatIPAddressinetArray1M.AssertModel(models[4],_testData[23], false);FlatIPAddressinetArray1M.AssertModel(models[5],_testData[24], false);FlatIPAddressinetArray1M.AssertModel(models[6],_testData[25], false);FlatIPAddressinetArray1M.AssertModel(models[7],_testData[26], false);FlatIPAddressinetArray1M.AssertModel(models[8],_testData[27], false);FlatIPAddressinetArray1M.AssertModel(models[9],_testData[28], false);FlatIPAddressinetArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressArrayinetArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSelectModelBatchAsync(connection, 17, 91))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
IPAddressinetArray1M.AssertModel(models[0],_testData[3], false);IPAddressinetArray1M.AssertModel(models[1],_testData[4], false);IPAddressinetArray1M.AssertModel(models[2],_testData[5], false);IPAddressinetArray1M.AssertModel(models[3],_testData[6], false);IPAddressinetArray1M.AssertModel(models[4],_testData[7], false);IPAddressinetArray1M.AssertModel(models[5],_testData[8], false);IPAddressinetArray1M.AssertModel(models[6],_testData[9], false);IPAddressinetArray1M.AssertModel(models[7],_testData[10], false);IPAddressinetArray1M.AssertModel(models[8],_testData[11], false);IPAddressinetArray1M.AssertModel(models[9],_testData[12], false);IPAddressinetArray1M.AssertModel(models[10],_testData[13], false);IPAddressinetArray1M.AssertModel(models[11],_testData[14], false);IPAddressinetArray1M.AssertModel(models[12],_testData[15], false);IPAddressinetArray1M.AssertModel(models[13],_testData[16], false);IPAddressinetArray1M.AssertModel(models[14],_testData[17], false);IPAddressinetArray1M.AssertModel(models[15],_testData[18], false);IPAddressinetArray1M.AssertModel(models[16],_testData[19], false);IPAddressinetArray1M.AssertModel(models[17],_testData[20], false);IPAddressinetArray1M.AssertModel(models[18],_testData[21], false);IPAddressinetArray1M.AssertModel(models[19],_testData[22], false);IPAddressinetArray1M.AssertModel(models[20],_testData[23], false);IPAddressinetArray1M.AssertModel(models[21],_testData[24], false);IPAddressinetArray1M.AssertModel(models[22],_testData[25], false);IPAddressinetArray1M.AssertModel(models[23],_testData[26], false);IPAddressinetArray1M.AssertModel(models[24],_testData[27], false);IPAddressinetArray1M.AssertModel(models[25],_testData[28], false);IPAddressinetArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
IPAddressinetArray1M.AssertModel(models[0],_testData[18], false);IPAddressinetArray1M.AssertModel(models[1],_testData[19], false);IPAddressinetArray1M.AssertModel(models[2],_testData[20], false);IPAddressinetArray1M.AssertModel(models[3],_testData[21], false);IPAddressinetArray1M.AssertModel(models[4],_testData[22], false);IPAddressinetArray1M.AssertModel(models[5],_testData[23], false);IPAddressinetArray1M.AssertModel(models[6],_testData[24], false);IPAddressinetArray1M.AssertModel(models[7],_testData[25], false);IPAddressinetArray1M.AssertModel(models[8],_testData[26], false);IPAddressinetArray1M.AssertModel(models[9],_testData[27], false);IPAddressinetArray1M.AssertModel(models[10],_testData[28], false);IPAddressinetArray1M.AssertModel(models[11],_testData[29], false);
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
                var models =  ((IIPAddressArrayinetArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSelectModelBatch(connection, 124, 6))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
IPAddressinetArray1M.AssertModel(models[0],_testData[25], false);IPAddressinetArray1M.AssertModel(models[1],_testData[26], false);IPAddressinetArray1M.AssertModel(models[2],_testData[27], false);IPAddressinetArray1M.AssertModel(models[3],_testData[28], false);IPAddressinetArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
IPAddressinetArray1M.AssertModel(models[0],_testData[1], false);IPAddressinetArray1M.AssertModel(models[1],_testData[2], false);IPAddressinetArray1M.AssertModel(models[2],_testData[3], false);IPAddressinetArray1M.AssertModel(models[3],_testData[4], false);IPAddressinetArray1M.AssertModel(models[4],_testData[5], false);IPAddressinetArray1M.AssertModel(models[5],_testData[6], false);IPAddressinetArray1M.AssertModel(models[6],_testData[7], false);IPAddressinetArray1M.AssertModel(models[7],_testData[8], false);IPAddressinetArray1M.AssertModel(models[8],_testData[9], false);IPAddressinetArray1M.AssertModel(models[9],_testData[10], false);IPAddressinetArray1M.AssertModel(models[10],_testData[11], false);IPAddressinetArray1M.AssertModel(models[11],_testData[12], false);IPAddressinetArray1M.AssertModel(models[12],_testData[13], false);IPAddressinetArray1M.AssertModel(models[13],_testData[14], false);IPAddressinetArray1M.AssertModel(models[14],_testData[15], false);IPAddressinetArray1M.AssertModel(models[15],_testData[16], false);IPAddressinetArray1M.AssertModel(models[16],_testData[17], false);IPAddressinetArray1M.AssertModel(models[17],_testData[18], false);IPAddressinetArray1M.AssertModel(models[18],_testData[19], false);IPAddressinetArray1M.AssertModel(models[19],_testData[20], false);IPAddressinetArray1M.AssertModel(models[20],_testData[21], false);IPAddressinetArray1M.AssertModel(models[21],_testData[22], false);IPAddressinetArray1M.AssertModel(models[22],_testData[23], false);IPAddressinetArray1M.AssertModel(models[23],_testData[24], false);IPAddressinetArray1M.AssertModel(models[24],_testData[25], false);IPAddressinetArray1M.AssertModel(models[25],_testData[26], false);IPAddressinetArray1M.AssertModel(models[26],_testData[27], false);IPAddressinetArray1M.AssertModel(models[27],_testData[28], false);IPAddressinetArray1M.AssertModel(models[28],_testData[29], false);
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
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 61);
                var models = await ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
IPAddressinetArray1M.AssertModel(models[0],_testData[13], false);IPAddressinetArray1M.AssertModel(models[1],_testData[14], false);IPAddressinetArray1M.AssertModel(models[2],_testData[15], false);IPAddressinetArray1M.AssertModel(models[3],_testData[16], false);IPAddressinetArray1M.AssertModel(models[4],_testData[17], false);IPAddressinetArray1M.AssertModel(models[5],_testData[18], false);IPAddressinetArray1M.AssertModel(models[6],_testData[19], false);IPAddressinetArray1M.AssertModel(models[7],_testData[20], false);IPAddressinetArray1M.AssertModel(models[8],_testData[21], false);IPAddressinetArray1M.AssertModel(models[9],_testData[22], false);IPAddressinetArray1M.AssertModel(models[10],_testData[23], false);IPAddressinetArray1M.AssertModel(models[11],_testData[24], false);IPAddressinetArray1M.AssertModel(models[12],_testData[25], false);IPAddressinetArray1M.AssertModel(models[13],_testData[26], false);IPAddressinetArray1M.AssertModel(models[14],_testData[27], false);IPAddressinetArray1M.AssertModel(models[15],_testData[28], false);IPAddressinetArray1M.AssertModel(models[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 123);
                var models =  ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
IPAddressinetArray1M.AssertModel(models[0],_testData[24], false);IPAddressinetArray1M.AssertModel(models[1],_testData[25], false);IPAddressinetArray1M.AssertModel(models[2],_testData[26], false);IPAddressinetArray1M.AssertModel(models[3],_testData[27], false);IPAddressinetArray1M.AssertModel(models[4],_testData[28], false);IPAddressinetArray1M.AssertModel(models[5],_testData[29], false);
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

