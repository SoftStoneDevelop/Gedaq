

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
    Id = 1,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("120.7.190.121"),
System.Net.IPAddress.Parse("54.95.50.172"),
System.Net.IPAddress.Parse("244.49.185.212"),
System.Net.IPAddress.Parse("198.132.218.160"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 7,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("198.168.186.72"),
System.Net.IPAddress.Parse("204.168.131.49"),
System.Net.IPAddress.Parse("109.199.173.194"),
System.Net.IPAddress.Parse("117.223.135.70"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 2,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("203.120.135.183"),
System.Net.IPAddress.Parse("127.202.251.215"),
System.Net.IPAddress.Parse("242.142.186.29"),
System.Net.IPAddress.Parse("91.205.88.186"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("150.56.64.243"),
System.Net.IPAddress.Parse("117.235.198.208"),
System.Net.IPAddress.Parse("117.187.107.39"),
System.Net.IPAddress.Parse("48.61.112.175"),
},
},
            new IPAddressinetArray1M
{
    Id = 10,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("31.230.58.199"),
System.Net.IPAddress.Parse("168.96.45.74"),
System.Net.IPAddress.Parse("153.201.78.20"),
System.Net.IPAddress.Parse("59.158.129.7"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("237.179.234.130"),
System.Net.IPAddress.Parse("52.215.52.162"),
System.Net.IPAddress.Parse("77.50.224.251"),
System.Net.IPAddress.Parse("184.2.114.19"),
},
},
            new IPAddressinetArray1M
{
    Id = 19,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("1.0.184.17"),
System.Net.IPAddress.Parse("230.18.242.225"),
System.Net.IPAddress.Parse("220.14.8.134"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 6,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("175.113.94.181"),
System.Net.IPAddress.Parse("197.210.139.55"),
System.Net.IPAddress.Parse("85.191.104.18"),
System.Net.IPAddress.Parse("125.152.183.158"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 24,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("220.225.221.2"),
System.Net.IPAddress.Parse("243.143.130.248"),
System.Net.IPAddress.Parse("128.80.201.149"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 25,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("56.247.248.154"),
System.Net.IPAddress.Parse("122.219.76.199"),
System.Net.IPAddress.Parse("10.188.29.146"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 8,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("163.191.151.128"),
System.Net.IPAddress.Parse("192.130.7.235"),
System.Net.IPAddress.Parse("79.56.220.5"),
System.Net.IPAddress.Parse("173.173.106.235"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 31,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("106.193.57.185"),
System.Net.IPAddress.Parse("159.227.110.215"),
System.Net.IPAddress.Parse("178.120.121.74"),
System.Net.IPAddress.Parse("18.201.131.156"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("187.33.163.120"),
System.Net.IPAddress.Parse("236.63.103.60"),
System.Net.IPAddress.Parse("59.199.192.106"),
System.Net.IPAddress.Parse("65.182.247.177"),
},
},
            new IPAddressinetArray1M
{
    Id = 32,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("208.74.91.56"),
System.Net.IPAddress.Parse("142.153.62.145"),
System.Net.IPAddress.Parse("62.41.186.60"),
System.Net.IPAddress.Parse("154.211.144.139"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 16,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("79.32.115.202"),
System.Net.IPAddress.Parse("243.228.131.69"),
System.Net.IPAddress.Parse("32.205.207.160"),
System.Net.IPAddress.Parse("67.106.187.80"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("146.98.148.236"),
System.Net.IPAddress.Parse("190.15.172.204"),
System.Net.IPAddress.Parse("172.201.225.97"),
},
},
            new IPAddressinetArray1M
{
    Id = 34,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("205.207.113.125"),
System.Net.IPAddress.Parse("122.166.24.170"),
System.Net.IPAddress.Parse("121.127.155.236"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("109.60.40.109"),
System.Net.IPAddress.Parse("45.43.156.46"),
System.Net.IPAddress.Parse("88.210.4.186"),
System.Net.IPAddress.Parse("97.223.226.180"),
},
},
            new IPAddressinetArray1M
{
    Id = 36,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.169.82.242"),
System.Net.IPAddress.Parse("184.170.223.121"),
System.Net.IPAddress.Parse("23.7.7.68"),
System.Net.IPAddress.Parse("146.130.26.237"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 18,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("202.67.222.210"),
System.Net.IPAddress.Parse("6.65.233.19"),
System.Net.IPAddress.Parse("142.107.104.25"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("126.16.179.150"),
System.Net.IPAddress.Parse("123.223.208.149"),
System.Net.IPAddress.Parse("234.201.36.166"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("143.114.0.178"),
System.Net.IPAddress.Parse("4.130.249.23"),
System.Net.IPAddress.Parse("123.200.173.171"),
},
},
            new IPAddressinetArray1M
{
    Id = 44,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("30.222.39.183"),
System.Net.IPAddress.Parse("193.212.24.185"),
System.Net.IPAddress.Parse("197.22.230.117"),
System.Net.IPAddress.Parse("214.108.210.148"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 51,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("109.150.130.6"),
System.Net.IPAddress.Parse("144.158.62.146"),
System.Net.IPAddress.Parse("195.196.249.21"),
System.Net.IPAddress.Parse("245.73.187.71"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 22,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("76.140.103.180"),
System.Net.IPAddress.Parse("67.160.103.93"),
System.Net.IPAddress.Parse("49.224.211.197"),
System.Net.IPAddress.Parse("117.160.29.154"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("146.166.254.23"),
System.Net.IPAddress.Parse("241.159.130.158"),
System.Net.IPAddress.Parse("207.192.68.33"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("6.59.233.200"),
System.Net.IPAddress.Parse("110.37.200.38"),
System.Net.IPAddress.Parse("34.168.167.157"),
},
},
            new IPAddressinetArray1M
{
    Id = 58,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("188.188.191.115"),
System.Net.IPAddress.Parse("29.225.74.62"),
System.Net.IPAddress.Parse("126.205.241.0"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 64,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("194.106.8.228"),
System.Net.IPAddress.Parse("181.215.87.251"),
System.Net.IPAddress.Parse("252.87.220.196"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 31,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("18.172.56.124"),
System.Net.IPAddress.Parse("104.51.109.178"),
System.Net.IPAddress.Parse("84.89.225.6"),
System.Net.IPAddress.Parse("0.10.226.146"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("48.52.102.217"),
System.Net.IPAddress.Parse("116.38.228.145"),
System.Net.IPAddress.Parse("33.1.167.129"),
System.Net.IPAddress.Parse("190.203.67.135"),
},
},
            new IPAddressinetArray1M
{
    Id = 71,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("105.94.128.51"),
System.Net.IPAddress.Parse("214.143.92.249"),
System.Net.IPAddress.Parse("247.187.26.168"),
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
System.Net.IPAddress.Parse("181.54.251.241"),
System.Net.IPAddress.Parse("0.114.82.112"),
System.Net.IPAddress.Parse("62.129.4.17"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 35,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("89.112.198.175"),
System.Net.IPAddress.Parse("160.50.8.66"),
System.Net.IPAddress.Parse("124.107.54.167"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("203.5.205.10"),
System.Net.IPAddress.Parse("192.111.209.160"),
System.Net.IPAddress.Parse("63.12.30.161"),
System.Net.IPAddress.Parse("171.32.138.121"),
},
},
            new IPAddressinetArray1M
{
    Id = 78,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("53.194.126.116"),
System.Net.IPAddress.Parse("197.240.23.42"),
System.Net.IPAddress.Parse("95.142.104.55"),
System.Net.IPAddress.Parse("54.227.122.241"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("4.90.50.76"),
System.Net.IPAddress.Parse("92.162.153.108"),
System.Net.IPAddress.Parse("153.20.252.32"),
System.Net.IPAddress.Parse("122.77.50.100"),
},
},
            new IPAddressinetArray1M
{
    Id = 85,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("250.163.65.202"),
System.Net.IPAddress.Parse("54.34.35.219"),
System.Net.IPAddress.Parse("222.91.98.153"),
System.Net.IPAddress.Parse("98.35.149.21"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 42,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("21.200.125.129"),
System.Net.IPAddress.Parse("190.230.174.120"),
System.Net.IPAddress.Parse("122.0.231.159"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("222.226.11.222"),
System.Net.IPAddress.Parse("97.253.51.251"),
System.Net.IPAddress.Parse("209.242.64.47"),
},
},
            new IPAddressinetArray1M
{
    Id = 91,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("203.135.136.171"),
System.Net.IPAddress.Parse("71.104.85.120"),
System.Net.IPAddress.Parse("195.253.152.17"),
System.Net.IPAddress.Parse("251.45.36.90"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("138.208.54.179"),
System.Net.IPAddress.Parse("100.44.80.247"),
System.Net.IPAddress.Parse("52.238.42.40"),
},
},
            new IPAddressinetArray1M
{
    Id = 92,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("58.149.35.184"),
System.Net.IPAddress.Parse("67.72.254.140"),
System.Net.IPAddress.Parse("217.72.50.249"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 51,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.131.30.18"),
System.Net.IPAddress.Parse("163.169.217.35"),
System.Net.IPAddress.Parse("168.62.120.17"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("24.222.111.28"),
System.Net.IPAddress.Parse("165.133.102.152"),
System.Net.IPAddress.Parse("171.80.70.37"),
System.Net.IPAddress.Parse("71.19.127.226"),
},
},
            new IPAddressinetArray1M
{
    Id = 100,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("31.179.10.36"),
System.Net.IPAddress.Parse("182.201.175.188"),
System.Net.IPAddress.Parse("178.210.250.28"),
System.Net.IPAddress.Parse("148.198.56.36"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 108,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("65.10.185.213"),
System.Net.IPAddress.Parse("201.0.178.148"),
System.Net.IPAddress.Parse("236.222.83.39"),
System.Net.IPAddress.Parse("243.77.54.177"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 58,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.40.218.66"),
System.Net.IPAddress.Parse("162.16.43.230"),
System.Net.IPAddress.Parse("160.42.22.114"),
System.Net.IPAddress.Parse("154.242.247.243"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("56.216.199.162"),
System.Net.IPAddress.Parse("134.230.118.119"),
System.Net.IPAddress.Parse("2.17.82.174"),
System.Net.IPAddress.Parse("11.141.60.250"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("10.253.44.67"),
System.Net.IPAddress.Parse("142.160.49.69"),
System.Net.IPAddress.Parse("79.169.78.66"),
},
},
            new IPAddressinetArray1M
{
    Id = 110,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("98.14.240.191"),
System.Net.IPAddress.Parse("221.50.241.248"),
System.Net.IPAddress.Parse("9.5.195.37"),
System.Net.IPAddress.Parse("66.243.23.58"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 111,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("168.121.199.75"),
System.Net.IPAddress.Parse("122.156.181.194"),
System.Net.IPAddress.Parse("105.40.178.177"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 63,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("157.140.141.244"),
System.Net.IPAddress.Parse("28.47.144.191"),
System.Net.IPAddress.Parse("166.105.17.130"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 116,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("42.230.199.185"),
System.Net.IPAddress.Parse("86.3.200.3"),
System.Net.IPAddress.Parse("124.150.87.0"),
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
System.Net.IPAddress.Parse("32.229.74.193"),
System.Net.IPAddress.Parse("230.208.171.56"),
System.Net.IPAddress.Parse("207.42.109.252"),
System.Net.IPAddress.Parse("171.221.248.3"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 67,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("174.174.187.138"),
System.Net.IPAddress.Parse("130.47.163.208"),
System.Net.IPAddress.Parse("61.149.87.233"),
System.Net.IPAddress.Parse("111.19.75.19"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("96.86.93.41"),
System.Net.IPAddress.Parse("67.44.31.143"),
System.Net.IPAddress.Parse("241.27.30.112"),
System.Net.IPAddress.Parse("232.86.8.175"),
},
},
            new IPAddressinetArray1M
{
    Id = 130,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("16.156.198.181"),
System.Net.IPAddress.Parse("134.207.105.224"),
System.Net.IPAddress.Parse("241.125.184.124"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 137,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("198.247.243.28"),
System.Net.IPAddress.Parse("130.135.52.249"),
System.Net.IPAddress.Parse("221.235.180.115"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 72,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("226.248.98.193"),
System.Net.IPAddress.Parse("61.241.78.31"),
System.Net.IPAddress.Parse("206.173.64.60"),
System.Net.IPAddress.Parse("89.104.244.222"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("147.135.14.64"),
System.Net.IPAddress.Parse("235.115.1.148"),
System.Net.IPAddress.Parse("33.56.18.45"),
},
},
            new IPAddressinetArray1M
{
    Id = 139,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("254.212.186.42"),
System.Net.IPAddress.Parse("165.199.180.212"),
System.Net.IPAddress.Parse("146.92.161.190"),
System.Net.IPAddress.Parse("181.39.217.236"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("6.165.117.150"),
System.Net.IPAddress.Parse("158.145.52.43"),
System.Net.IPAddress.Parse("174.53.136.112"),
System.Net.IPAddress.Parse("81.145.22.195"),
},
},
            new IPAddressinetArray1M
{
    Id = 140,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("227.253.84.18"),
System.Net.IPAddress.Parse("151.239.186.110"),
System.Net.IPAddress.Parse("252.127.3.242"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 75,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("58.159.50.160"),
System.Net.IPAddress.Parse("226.56.39.220"),
System.Net.IPAddress.Parse("39.149.118.95"),
System.Net.IPAddress.Parse("118.248.184.76"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("233.195.184.237"),
System.Net.IPAddress.Parse("247.40.21.143"),
System.Net.IPAddress.Parse("32.145.161.74"),
System.Net.IPAddress.Parse("19.100.69.246"),
},
},
    NullableValue = null,
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
System.Net.IPAddress.Parse("187.33.163.120"),
System.Net.IPAddress.Parse("236.63.103.60"),
System.Net.IPAddress.Parse("59.199.192.106"),
System.Net.IPAddress.Parse("65.182.247.177"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("146.98.148.236"),
System.Net.IPAddress.Parse("190.15.172.204"),
System.Net.IPAddress.Parse("172.201.225.97"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("109.60.40.109"),
System.Net.IPAddress.Parse("45.43.156.46"),
System.Net.IPAddress.Parse("88.210.4.186"),
System.Net.IPAddress.Parse("97.223.226.180"),
}));
                nullable =  ((IIPAddressArrayinetArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("143.114.0.178"),
System.Net.IPAddress.Parse("4.130.249.23"),
System.Net.IPAddress.Parse("123.200.173.171"),
}));
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
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("6.59.233.200"),
System.Net.IPAddress.Parse("110.37.200.38"),
System.Net.IPAddress.Parse("34.168.167.157"),
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
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M), typeof(FlatIPAddressinetArray1M)],
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
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
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
                        Assert.That(models, Has.Count.EqualTo(7));
FlatIPAddressinetArray1M.AssertModel(models[0],_testData[23], false);FlatIPAddressinetArray1M.AssertModel(models[1],_testData[24], false);FlatIPAddressinetArray1M.AssertModel(models[2],_testData[25], false);FlatIPAddressinetArray1M.AssertModel(models[3],_testData[26], false);FlatIPAddressinetArray1M.AssertModel(models[4],_testData[27], false);FlatIPAddressinetArray1M.AssertModel(models[5],_testData[28], false);FlatIPAddressinetArray1M.AssertModel(models[6],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 64;
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatIPAddressinetArray1M.AssertModel(models[0],_testData[14], false);FlatIPAddressinetArray1M.AssertModel(models[1],_testData[15], false);FlatIPAddressinetArray1M.AssertModel(models[2],_testData[16], false);FlatIPAddressinetArray1M.AssertModel(models[3],_testData[17], false);FlatIPAddressinetArray1M.AssertModel(models[4],_testData[18], false);FlatIPAddressinetArray1M.AssertModel(models[5],_testData[19], false);FlatIPAddressinetArray1M.AssertModel(models[6],_testData[20], false);FlatIPAddressinetArray1M.AssertModel(models[7],_testData[21], false);FlatIPAddressinetArray1M.AssertModel(models[8],_testData[22], false);FlatIPAddressinetArray1M.AssertModel(models[9],_testData[23], false);FlatIPAddressinetArray1M.AssertModel(models[10],_testData[24], false);FlatIPAddressinetArray1M.AssertModel(models[11],_testData[25], false);FlatIPAddressinetArray1M.AssertModel(models[12],_testData[26], false);FlatIPAddressinetArray1M.AssertModel(models[13],_testData[27], false);FlatIPAddressinetArray1M.AssertModel(models[14],_testData[28], false);FlatIPAddressinetArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatIPAddressinetArray1M.AssertModel(models[0],_testData[24], false);FlatIPAddressinetArray1M.AssertModel(models[1],_testData[25], false);FlatIPAddressinetArray1M.AssertModel(models[2],_testData[26], false);FlatIPAddressinetArray1M.AssertModel(models[3],_testData[27], false);FlatIPAddressinetArray1M.AssertModel(models[4],_testData[28], false);FlatIPAddressinetArray1M.AssertModel(models[5],_testData[29], false);
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
                var models = await((IIPAddressArrayinetArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
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
                        Assert.That(models, Has.Count.EqualTo(29));
IPAddressinetArray1M.AssertModel(models[0],_testData[1], false);IPAddressinetArray1M.AssertModel(models[1],_testData[2], false);IPAddressinetArray1M.AssertModel(models[2],_testData[3], false);IPAddressinetArray1M.AssertModel(models[3],_testData[4], false);IPAddressinetArray1M.AssertModel(models[4],_testData[5], false);IPAddressinetArray1M.AssertModel(models[5],_testData[6], false);IPAddressinetArray1M.AssertModel(models[6],_testData[7], false);IPAddressinetArray1M.AssertModel(models[7],_testData[8], false);IPAddressinetArray1M.AssertModel(models[8],_testData[9], false);IPAddressinetArray1M.AssertModel(models[9],_testData[10], false);IPAddressinetArray1M.AssertModel(models[10],_testData[11], false);IPAddressinetArray1M.AssertModel(models[11],_testData[12], false);IPAddressinetArray1M.AssertModel(models[12],_testData[13], false);IPAddressinetArray1M.AssertModel(models[13],_testData[14], false);IPAddressinetArray1M.AssertModel(models[14],_testData[15], false);IPAddressinetArray1M.AssertModel(models[15],_testData[16], false);IPAddressinetArray1M.AssertModel(models[16],_testData[17], false);IPAddressinetArray1M.AssertModel(models[17],_testData[18], false);IPAddressinetArray1M.AssertModel(models[18],_testData[19], false);IPAddressinetArray1M.AssertModel(models[19],_testData[20], false);IPAddressinetArray1M.AssertModel(models[20],_testData[21], false);IPAddressinetArray1M.AssertModel(models[21],_testData[22], false);IPAddressinetArray1M.AssertModel(models[22],_testData[23], false);IPAddressinetArray1M.AssertModel(models[23],_testData[24], false);IPAddressinetArray1M.AssertModel(models[24],_testData[25], false);IPAddressinetArray1M.AssertModel(models[25],_testData[26], false);IPAddressinetArray1M.AssertModel(models[26],_testData[27], false);IPAddressinetArray1M.AssertModel(models[27],_testData[28], false);IPAddressinetArray1M.AssertModel(models[28],_testData[29], false);
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
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
IPAddressinetArray1M.AssertModel(models[0],_testData[12], false);IPAddressinetArray1M.AssertModel(models[1],_testData[13], false);IPAddressinetArray1M.AssertModel(models[2],_testData[14], false);IPAddressinetArray1M.AssertModel(models[3],_testData[15], false);IPAddressinetArray1M.AssertModel(models[4],_testData[16], false);IPAddressinetArray1M.AssertModel(models[5],_testData[17], false);IPAddressinetArray1M.AssertModel(models[6],_testData[18], false);IPAddressinetArray1M.AssertModel(models[7],_testData[19], false);IPAddressinetArray1M.AssertModel(models[8],_testData[20], false);IPAddressinetArray1M.AssertModel(models[9],_testData[21], false);IPAddressinetArray1M.AssertModel(models[10],_testData[22], false);IPAddressinetArray1M.AssertModel(models[11],_testData[23], false);IPAddressinetArray1M.AssertModel(models[12],_testData[24], false);IPAddressinetArray1M.AssertModel(models[13],_testData[25], false);IPAddressinetArray1M.AssertModel(models[14],_testData[26], false);IPAddressinetArray1M.AssertModel(models[15],_testData[27], false);IPAddressinetArray1M.AssertModel(models[16],_testData[28], false);IPAddressinetArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
IPAddressinetArray1M.AssertModel(models[0],_testData[3], false);IPAddressinetArray1M.AssertModel(models[1],_testData[4], false);IPAddressinetArray1M.AssertModel(models[2],_testData[5], false);IPAddressinetArray1M.AssertModel(models[3],_testData[6], false);IPAddressinetArray1M.AssertModel(models[4],_testData[7], false);IPAddressinetArray1M.AssertModel(models[5],_testData[8], false);IPAddressinetArray1M.AssertModel(models[6],_testData[9], false);IPAddressinetArray1M.AssertModel(models[7],_testData[10], false);IPAddressinetArray1M.AssertModel(models[8],_testData[11], false);IPAddressinetArray1M.AssertModel(models[9],_testData[12], false);IPAddressinetArray1M.AssertModel(models[10],_testData[13], false);IPAddressinetArray1M.AssertModel(models[11],_testData[14], false);IPAddressinetArray1M.AssertModel(models[12],_testData[15], false);IPAddressinetArray1M.AssertModel(models[13],_testData[16], false);IPAddressinetArray1M.AssertModel(models[14],_testData[17], false);IPAddressinetArray1M.AssertModel(models[15],_testData[18], false);IPAddressinetArray1M.AssertModel(models[16],_testData[19], false);IPAddressinetArray1M.AssertModel(models[17],_testData[20], false);IPAddressinetArray1M.AssertModel(models[18],_testData[21], false);IPAddressinetArray1M.AssertModel(models[19],_testData[22], false);IPAddressinetArray1M.AssertModel(models[20],_testData[23], false);IPAddressinetArray1M.AssertModel(models[21],_testData[24], false);IPAddressinetArray1M.AssertModel(models[22],_testData[25], false);IPAddressinetArray1M.AssertModel(models[23],_testData[26], false);IPAddressinetArray1M.AssertModel(models[24],_testData[27], false);IPAddressinetArray1M.AssertModel(models[25],_testData[28], false);IPAddressinetArray1M.AssertModel(models[26],_testData[29], false);
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
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 111, query1, 64, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatIPAddressinetArray1M.AssertModel(models[0],_testData[24], false);FlatIPAddressinetArray1M.AssertModel(models[1],_testData[25], false);FlatIPAddressinetArray1M.AssertModel(models[2],_testData[26], false);FlatIPAddressinetArray1M.AssertModel(models[3],_testData[27], false);FlatIPAddressinetArray1M.AssertModel(models[4],_testData[28], false);FlatIPAddressinetArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatIPAddressinetArray1M.AssertModel(models[0],_testData[14], false);FlatIPAddressinetArray1M.AssertModel(models[1],_testData[15], false);FlatIPAddressinetArray1M.AssertModel(models[2],_testData[16], false);FlatIPAddressinetArray1M.AssertModel(models[3],_testData[17], false);FlatIPAddressinetArray1M.AssertModel(models[4],_testData[18], false);FlatIPAddressinetArray1M.AssertModel(models[5],_testData[19], false);FlatIPAddressinetArray1M.AssertModel(models[6],_testData[20], false);FlatIPAddressinetArray1M.AssertModel(models[7],_testData[21], false);FlatIPAddressinetArray1M.AssertModel(models[8],_testData[22], false);FlatIPAddressinetArray1M.AssertModel(models[9],_testData[23], false);FlatIPAddressinetArray1M.AssertModel(models[10],_testData[24], false);FlatIPAddressinetArray1M.AssertModel(models[11],_testData[25], false);FlatIPAddressinetArray1M.AssertModel(models[12],_testData[26], false);FlatIPAddressinetArray1M.AssertModel(models[13],_testData[27], false);FlatIPAddressinetArray1M.AssertModel(models[14],_testData[28], false);FlatIPAddressinetArray1M.AssertModel(models[15],_testData[29], false);
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
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 64, query1, 116, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatIPAddressinetArray1M.AssertModel(models[0],_testData[14], false);FlatIPAddressinetArray1M.AssertModel(models[1],_testData[15], false);FlatIPAddressinetArray1M.AssertModel(models[2],_testData[16], false);FlatIPAddressinetArray1M.AssertModel(models[3],_testData[17], false);FlatIPAddressinetArray1M.AssertModel(models[4],_testData[18], false);FlatIPAddressinetArray1M.AssertModel(models[5],_testData[19], false);FlatIPAddressinetArray1M.AssertModel(models[6],_testData[20], false);FlatIPAddressinetArray1M.AssertModel(models[7],_testData[21], false);FlatIPAddressinetArray1M.AssertModel(models[8],_testData[22], false);FlatIPAddressinetArray1M.AssertModel(models[9],_testData[23], false);FlatIPAddressinetArray1M.AssertModel(models[10],_testData[24], false);FlatIPAddressinetArray1M.AssertModel(models[11],_testData[25], false);FlatIPAddressinetArray1M.AssertModel(models[12],_testData[26], false);FlatIPAddressinetArray1M.AssertModel(models[13],_testData[27], false);FlatIPAddressinetArray1M.AssertModel(models[14],_testData[28], false);FlatIPAddressinetArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatIPAddressinetArray1M.AssertModel(models[0],_testData[25], false);FlatIPAddressinetArray1M.AssertModel(models[1],_testData[26], false);FlatIPAddressinetArray1M.AssertModel(models[2],_testData[27], false);FlatIPAddressinetArray1M.AssertModel(models[3],_testData[28], false);FlatIPAddressinetArray1M.AssertModel(models[4],_testData[29], false);
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
                var models = await((IIPAddressArrayinetArray)this).DbConnectionSelectModelAsync(connection, 0);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSelectModelBatchAsync(connection, 25, 100))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
IPAddressinetArray1M.AssertModel(models[0],_testData[6], false);IPAddressinetArray1M.AssertModel(models[1],_testData[7], false);IPAddressinetArray1M.AssertModel(models[2],_testData[8], false);IPAddressinetArray1M.AssertModel(models[3],_testData[9], false);IPAddressinetArray1M.AssertModel(models[4],_testData[10], false);IPAddressinetArray1M.AssertModel(models[5],_testData[11], false);IPAddressinetArray1M.AssertModel(models[6],_testData[12], false);IPAddressinetArray1M.AssertModel(models[7],_testData[13], false);IPAddressinetArray1M.AssertModel(models[8],_testData[14], false);IPAddressinetArray1M.AssertModel(models[9],_testData[15], false);IPAddressinetArray1M.AssertModel(models[10],_testData[16], false);IPAddressinetArray1M.AssertModel(models[11],_testData[17], false);IPAddressinetArray1M.AssertModel(models[12],_testData[18], false);IPAddressinetArray1M.AssertModel(models[13],_testData[19], false);IPAddressinetArray1M.AssertModel(models[14],_testData[20], false);IPAddressinetArray1M.AssertModel(models[15],_testData[21], false);IPAddressinetArray1M.AssertModel(models[16],_testData[22], false);IPAddressinetArray1M.AssertModel(models[17],_testData[23], false);IPAddressinetArray1M.AssertModel(models[18],_testData[24], false);IPAddressinetArray1M.AssertModel(models[19],_testData[25], false);IPAddressinetArray1M.AssertModel(models[20],_testData[26], false);IPAddressinetArray1M.AssertModel(models[21],_testData[27], false);IPAddressinetArray1M.AssertModel(models[22],_testData[28], false);IPAddressinetArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
IPAddressinetArray1M.AssertModel(models[0],_testData[21], false);IPAddressinetArray1M.AssertModel(models[1],_testData[22], false);IPAddressinetArray1M.AssertModel(models[2],_testData[23], false);IPAddressinetArray1M.AssertModel(models[3],_testData[24], false);IPAddressinetArray1M.AssertModel(models[4],_testData[25], false);IPAddressinetArray1M.AssertModel(models[5],_testData[26], false);IPAddressinetArray1M.AssertModel(models[6],_testData[27], false);IPAddressinetArray1M.AssertModel(models[7],_testData[28], false);IPAddressinetArray1M.AssertModel(models[8],_testData[29], false);
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
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSelectModelBatch(connection, 24, 10))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
IPAddressinetArray1M.AssertModel(models[0],_testData[5], false);IPAddressinetArray1M.AssertModel(models[1],_testData[6], false);IPAddressinetArray1M.AssertModel(models[2],_testData[7], false);IPAddressinetArray1M.AssertModel(models[3],_testData[8], false);IPAddressinetArray1M.AssertModel(models[4],_testData[9], false);IPAddressinetArray1M.AssertModel(models[5],_testData[10], false);IPAddressinetArray1M.AssertModel(models[6],_testData[11], false);IPAddressinetArray1M.AssertModel(models[7],_testData[12], false);IPAddressinetArray1M.AssertModel(models[8],_testData[13], false);IPAddressinetArray1M.AssertModel(models[9],_testData[14], false);IPAddressinetArray1M.AssertModel(models[10],_testData[15], false);IPAddressinetArray1M.AssertModel(models[11],_testData[16], false);IPAddressinetArray1M.AssertModel(models[12],_testData[17], false);IPAddressinetArray1M.AssertModel(models[13],_testData[18], false);IPAddressinetArray1M.AssertModel(models[14],_testData[19], false);IPAddressinetArray1M.AssertModel(models[15],_testData[20], false);IPAddressinetArray1M.AssertModel(models[16],_testData[21], false);IPAddressinetArray1M.AssertModel(models[17],_testData[22], false);IPAddressinetArray1M.AssertModel(models[18],_testData[23], false);IPAddressinetArray1M.AssertModel(models[19],_testData[24], false);IPAddressinetArray1M.AssertModel(models[20],_testData[25], false);IPAddressinetArray1M.AssertModel(models[21],_testData[26], false);IPAddressinetArray1M.AssertModel(models[22],_testData[27], false);IPAddressinetArray1M.AssertModel(models[23],_testData[28], false);IPAddressinetArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
IPAddressinetArray1M.AssertModel(models[0],_testData[3], false);IPAddressinetArray1M.AssertModel(models[1],_testData[4], false);IPAddressinetArray1M.AssertModel(models[2],_testData[5], false);IPAddressinetArray1M.AssertModel(models[3],_testData[6], false);IPAddressinetArray1M.AssertModel(models[4],_testData[7], false);IPAddressinetArray1M.AssertModel(models[5],_testData[8], false);IPAddressinetArray1M.AssertModel(models[6],_testData[9], false);IPAddressinetArray1M.AssertModel(models[7],_testData[10], false);IPAddressinetArray1M.AssertModel(models[8],_testData[11], false);IPAddressinetArray1M.AssertModel(models[9],_testData[12], false);IPAddressinetArray1M.AssertModel(models[10],_testData[13], false);IPAddressinetArray1M.AssertModel(models[11],_testData[14], false);IPAddressinetArray1M.AssertModel(models[12],_testData[15], false);IPAddressinetArray1M.AssertModel(models[13],_testData[16], false);IPAddressinetArray1M.AssertModel(models[14],_testData[17], false);IPAddressinetArray1M.AssertModel(models[15],_testData[18], false);IPAddressinetArray1M.AssertModel(models[16],_testData[19], false);IPAddressinetArray1M.AssertModel(models[17],_testData[20], false);IPAddressinetArray1M.AssertModel(models[18],_testData[21], false);IPAddressinetArray1M.AssertModel(models[19],_testData[22], false);IPAddressinetArray1M.AssertModel(models[20],_testData[23], false);IPAddressinetArray1M.AssertModel(models[21],_testData[24], false);IPAddressinetArray1M.AssertModel(models[22],_testData[25], false);IPAddressinetArray1M.AssertModel(models[23],_testData[26], false);IPAddressinetArray1M.AssertModel(models[24],_testData[27], false);IPAddressinetArray1M.AssertModel(models[25],_testData[28], false);IPAddressinetArray1M.AssertModel(models[26],_testData[29], false);
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
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 51);
                var models = await ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
IPAddressinetArray1M.AssertModel(models[0],_testData[12], false);IPAddressinetArray1M.AssertModel(models[1],_testData[13], false);IPAddressinetArray1M.AssertModel(models[2],_testData[14], false);IPAddressinetArray1M.AssertModel(models[3],_testData[15], false);IPAddressinetArray1M.AssertModel(models[4],_testData[16], false);IPAddressinetArray1M.AssertModel(models[5],_testData[17], false);IPAddressinetArray1M.AssertModel(models[6],_testData[18], false);IPAddressinetArray1M.AssertModel(models[7],_testData[19], false);IPAddressinetArray1M.AssertModel(models[8],_testData[20], false);IPAddressinetArray1M.AssertModel(models[9],_testData[21], false);IPAddressinetArray1M.AssertModel(models[10],_testData[22], false);IPAddressinetArray1M.AssertModel(models[11],_testData[23], false);IPAddressinetArray1M.AssertModel(models[12],_testData[24], false);IPAddressinetArray1M.AssertModel(models[13],_testData[25], false);IPAddressinetArray1M.AssertModel(models[14],_testData[26], false);IPAddressinetArray1M.AssertModel(models[15],_testData[27], false);IPAddressinetArray1M.AssertModel(models[16],_testData[28], false);IPAddressinetArray1M.AssertModel(models[17],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 32);
                var models =  ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
IPAddressinetArray1M.AssertModel(models[0],_testData[8], false);IPAddressinetArray1M.AssertModel(models[1],_testData[9], false);IPAddressinetArray1M.AssertModel(models[2],_testData[10], false);IPAddressinetArray1M.AssertModel(models[3],_testData[11], false);IPAddressinetArray1M.AssertModel(models[4],_testData[12], false);IPAddressinetArray1M.AssertModel(models[5],_testData[13], false);IPAddressinetArray1M.AssertModel(models[6],_testData[14], false);IPAddressinetArray1M.AssertModel(models[7],_testData[15], false);IPAddressinetArray1M.AssertModel(models[8],_testData[16], false);IPAddressinetArray1M.AssertModel(models[9],_testData[17], false);IPAddressinetArray1M.AssertModel(models[10],_testData[18], false);IPAddressinetArray1M.AssertModel(models[11],_testData[19], false);IPAddressinetArray1M.AssertModel(models[12],_testData[20], false);IPAddressinetArray1M.AssertModel(models[13],_testData[21], false);IPAddressinetArray1M.AssertModel(models[14],_testData[22], false);IPAddressinetArray1M.AssertModel(models[15],_testData[23], false);IPAddressinetArray1M.AssertModel(models[16],_testData[24], false);IPAddressinetArray1M.AssertModel(models[17],_testData[25], false);IPAddressinetArray1M.AssertModel(models[18],_testData[26], false);IPAddressinetArray1M.AssertModel(models[19],_testData[27], false);IPAddressinetArray1M.AssertModel(models[20],_testData[28], false);IPAddressinetArray1M.AssertModel(models[21],_testData[29], false);
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

