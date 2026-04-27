

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
    Id = 5,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("13.95.52.13"),
System.Net.IPAddress.Parse("48.114.73.36"),
System.Net.IPAddress.Parse("66.29.124.23"),
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
System.Net.IPAddress.Parse("252.64.129.174"),
System.Net.IPAddress.Parse("178.238.27.170"),
System.Net.IPAddress.Parse("9.245.203.40"),
System.Net.IPAddress.Parse("120.41.50.153"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 5,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("83.91.156.58"),
System.Net.IPAddress.Parse("60.151.27.163"),
System.Net.IPAddress.Parse("102.215.204.42"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("108.104.144.14"),
System.Net.IPAddress.Parse("139.37.211.234"),
System.Net.IPAddress.Parse("113.167.161.227"),
System.Net.IPAddress.Parse("31.13.50.42"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("242.247.68.66"),
System.Net.IPAddress.Parse("21.74.85.17"),
System.Net.IPAddress.Parse("6.171.103.106"),
},
},
            new IPAddressinetArray1M
{
    Id = 13,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("59.205.44.102"),
System.Net.IPAddress.Parse("152.116.207.191"),
System.Net.IPAddress.Parse("113.246.161.67"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 19,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("17.51.252.59"),
System.Net.IPAddress.Parse("229.79.39.157"),
System.Net.IPAddress.Parse("41.71.187.125"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 11,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("193.65.101.157"),
System.Net.IPAddress.Parse("244.251.231.64"),
System.Net.IPAddress.Parse("80.13.249.58"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("144.146.83.212"),
System.Net.IPAddress.Parse("161.187.83.233"),
System.Net.IPAddress.Parse("111.187.163.237"),
System.Net.IPAddress.Parse("181.211.229.2"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 24,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("97.191.180.35"),
System.Net.IPAddress.Parse("53.251.49.168"),
System.Net.IPAddress.Parse("17.191.131.213"),
System.Net.IPAddress.Parse("0.102.76.224"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 33,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("31.173.124.210"),
System.Net.IPAddress.Parse("116.122.20.238"),
System.Net.IPAddress.Parse("54.208.34.166"),
System.Net.IPAddress.Parse("166.52.153.226"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 18,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("120.218.237.207"),
System.Net.IPAddress.Parse("62.64.2.63"),
System.Net.IPAddress.Parse("94.253.88.162"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 38,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("104.77.84.26"),
System.Net.IPAddress.Parse("181.121.26.69"),
System.Net.IPAddress.Parse("90.196.195.198"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("33.86.26.235"),
System.Net.IPAddress.Parse("85.109.3.98"),
System.Net.IPAddress.Parse("74.58.22.190"),
System.Net.IPAddress.Parse("79.114.172.0"),
},
},
            new IPAddressinetArray1M
{
    Id = 45,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("190.98.142.188"),
System.Net.IPAddress.Parse("10.116.60.64"),
System.Net.IPAddress.Parse("42.7.152.211"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 24,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("224.241.216.113"),
System.Net.IPAddress.Parse("86.227.121.210"),
System.Net.IPAddress.Parse("201.213.10.143"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("226.238.191.38"),
System.Net.IPAddress.Parse("249.239.193.79"),
System.Net.IPAddress.Parse("164.235.108.143"),
},
},
            new IPAddressinetArray1M
{
    Id = 54,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("6.193.163.54"),
System.Net.IPAddress.Parse("251.174.204.206"),
System.Net.IPAddress.Parse("248.71.193.46"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("79.134.42.177"),
System.Net.IPAddress.Parse("127.17.52.32"),
System.Net.IPAddress.Parse("245.32.67.216"),
},
},
            new IPAddressinetArray1M
{
    Id = 62,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("73.115.151.243"),
System.Net.IPAddress.Parse("0.210.43.225"),
System.Net.IPAddress.Parse("30.82.228.136"),
System.Net.IPAddress.Parse("253.121.90.167"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 33,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("41.13.245.122"),
System.Net.IPAddress.Parse("226.107.160.14"),
System.Net.IPAddress.Parse("129.253.89.96"),
System.Net.IPAddress.Parse("113.51.54.163"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("92.201.32.207"),
System.Net.IPAddress.Parse("27.211.239.194"),
System.Net.IPAddress.Parse("235.224.3.59"),
System.Net.IPAddress.Parse("12.207.149.170"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("179.41.65.78"),
System.Net.IPAddress.Parse("178.111.100.111"),
System.Net.IPAddress.Parse("67.23.211.193"),
System.Net.IPAddress.Parse("27.90.216.60"),
},
},
            new IPAddressinetArray1M
{
    Id = 68,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("120.110.132.224"),
System.Net.IPAddress.Parse("63.175.58.129"),
System.Net.IPAddress.Parse("2.53.54.146"),
System.Net.IPAddress.Parse("205.72.69.67"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 72,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("209.49.1.112"),
System.Net.IPAddress.Parse("145.206.58.0"),
System.Net.IPAddress.Parse("154.129.76.59"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 42,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("175.147.176.179"),
System.Net.IPAddress.Parse("122.26.70.129"),
System.Net.IPAddress.Parse("200.183.250.180"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("172.91.7.61"),
System.Net.IPAddress.Parse("235.241.0.229"),
System.Net.IPAddress.Parse("44.183.166.187"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("67.203.25.30"),
System.Net.IPAddress.Parse("230.165.138.1"),
System.Net.IPAddress.Parse("136.197.15.128"),
System.Net.IPAddress.Parse("33.117.247.35"),
},
},
            new IPAddressinetArray1M
{
    Id = 73,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("188.156.140.195"),
System.Net.IPAddress.Parse("147.119.120.178"),
System.Net.IPAddress.Parse("120.52.168.226"),
System.Net.IPAddress.Parse("73.202.240.158"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("43.244.28.212"),
System.Net.IPAddress.Parse("222.67.241.197"),
System.Net.IPAddress.Parse("156.252.62.139"),
System.Net.IPAddress.Parse("202.96.77.66"),
},
},
            new IPAddressinetArray1M
{
    Id = 81,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("105.153.41.2"),
System.Net.IPAddress.Parse("241.21.232.155"),
System.Net.IPAddress.Parse("244.126.172.174"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 50,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("169.202.202.78"),
System.Net.IPAddress.Parse("220.219.116.76"),
System.Net.IPAddress.Parse("62.47.12.228"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 82,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("88.54.103.213"),
System.Net.IPAddress.Parse("246.70.49.211"),
System.Net.IPAddress.Parse("101.110.82.97"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 88,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("249.136.93.187"),
System.Net.IPAddress.Parse("107.62.75.144"),
System.Net.IPAddress.Parse("72.246.96.36"),
System.Net.IPAddress.Parse("223.77.9.144"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 54,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("68.231.195.24"),
System.Net.IPAddress.Parse("25.231.121.13"),
System.Net.IPAddress.Parse("112.253.227.162"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 93,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("15.133.113.81"),
System.Net.IPAddress.Parse("93.135.253.84"),
System.Net.IPAddress.Parse("35.6.70.231"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("6.85.68.220"),
System.Net.IPAddress.Parse("191.182.62.223"),
System.Net.IPAddress.Parse("204.21.203.72"),
System.Net.IPAddress.Parse("232.192.192.105"),
},
},
            new IPAddressinetArray1M
{
    Id = 95,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("50.162.153.162"),
System.Net.IPAddress.Parse("46.92.17.7"),
System.Net.IPAddress.Parse("20.8.55.30"),
System.Net.IPAddress.Parse("81.27.202.131"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 57,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("6.176.149.156"),
System.Net.IPAddress.Parse("131.116.119.69"),
System.Net.IPAddress.Parse("44.114.249.25"),
System.Net.IPAddress.Parse("19.190.116.144"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("16.183.33.107"),
System.Net.IPAddress.Parse("24.181.143.68"),
System.Net.IPAddress.Parse("244.102.160.12"),
System.Net.IPAddress.Parse("169.151.189.195"),
},
},
            new IPAddressinetArray1M
{
    Id = 101,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("33.10.77.47"),
System.Net.IPAddress.Parse("175.143.209.236"),
System.Net.IPAddress.Parse("80.208.209.165"),
System.Net.IPAddress.Parse("21.190.160.50"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("2.161.139.232"),
System.Net.IPAddress.Parse("238.249.226.203"),
System.Net.IPAddress.Parse("20.207.216.39"),
System.Net.IPAddress.Parse("74.29.39.248"),
},
},
            new IPAddressinetArray1M
{
    Id = 105,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("115.172.212.136"),
System.Net.IPAddress.Parse("230.41.8.131"),
System.Net.IPAddress.Parse("97.247.203.231"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 58,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("246.159.239.251"),
System.Net.IPAddress.Parse("100.215.54.254"),
System.Net.IPAddress.Parse("232.208.4.248"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("79.201.88.128"),
System.Net.IPAddress.Parse("118.149.46.144"),
System.Net.IPAddress.Parse("227.231.18.230"),
System.Net.IPAddress.Parse("49.109.22.27"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("34.156.4.146"),
System.Net.IPAddress.Parse("42.122.177.68"),
System.Net.IPAddress.Parse("192.226.210.175"),
},
},
            new IPAddressinetArray1M
{
    Id = 114,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("161.128.182.207"),
System.Net.IPAddress.Parse("53.92.156.80"),
System.Net.IPAddress.Parse("37.221.176.131"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 120,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("58.10.55.179"),
System.Net.IPAddress.Parse("6.216.131.16"),
System.Net.IPAddress.Parse("192.160.232.180"),
System.Net.IPAddress.Parse("213.54.43.90"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 65,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("165.162.102.150"),
System.Net.IPAddress.Parse("188.58.45.159"),
System.Net.IPAddress.Parse("135.4.163.83"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("241.15.27.221"),
System.Net.IPAddress.Parse("131.134.8.0"),
System.Net.IPAddress.Parse("247.34.170.112"),
},
},
            new IPAddressinetArray1M
{
    Id = 121,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.194.40.141"),
System.Net.IPAddress.Parse("156.14.23.22"),
System.Net.IPAddress.Parse("25.147.157.41"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("189.69.179.117"),
System.Net.IPAddress.Parse("116.196.201.250"),
System.Net.IPAddress.Parse("173.221.250.91"),
},
},
            new IPAddressinetArray1M
{
    Id = 130,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("0.192.218.129"),
System.Net.IPAddress.Parse("4.190.114.164"),
System.Net.IPAddress.Parse("198.227.125.163"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 70,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("15.179.151.222"),
System.Net.IPAddress.Parse("194.2.188.6"),
System.Net.IPAddress.Parse("254.3.9.249"),
System.Net.IPAddress.Parse("209.213.204.161"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 134,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("167.219.192.248"),
System.Net.IPAddress.Parse("77.189.235.240"),
System.Net.IPAddress.Parse("57.117.183.165"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("33.149.5.142"),
System.Net.IPAddress.Parse("48.132.178.14"),
System.Net.IPAddress.Parse("202.176.108.103"),
System.Net.IPAddress.Parse("76.136.195.60"),
},
},
            new IPAddressinetArray1M
{
    Id = 138,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("173.53.251.225"),
System.Net.IPAddress.Parse("73.115.66.111"),
System.Net.IPAddress.Parse("240.171.203.178"),
System.Net.IPAddress.Parse("252.106.61.170"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 72,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("223.160.194.108"),
System.Net.IPAddress.Parse("102.10.79.160"),
System.Net.IPAddress.Parse("191.156.132.175"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("16.205.195.134"),
System.Net.IPAddress.Parse("229.180.170.38"),
System.Net.IPAddress.Parse("190.145.83.200"),
System.Net.IPAddress.Parse("1.197.7.224"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 147,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("200.179.176.66"),
System.Net.IPAddress.Parse("52.136.217.115"),
System.Net.IPAddress.Parse("222.231.216.226"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.164.6.228"),
System.Net.IPAddress.Parse("219.253.52.233"),
System.Net.IPAddress.Parse("163.91.218.3"),
System.Net.IPAddress.Parse("206.160.139.179"),
},
},
            new IPAddressinetArray1M
{
    Id = 152,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("102.169.61.184"),
System.Net.IPAddress.Parse("228.147.192.18"),
System.Net.IPAddress.Parse("170.232.190.109"),
System.Net.IPAddress.Parse("27.193.190.223"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 74,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("183.94.95.222"),
System.Net.IPAddress.Parse("71.122.187.26"),
System.Net.IPAddress.Parse("242.104.198.238"),
System.Net.IPAddress.Parse("228.21.228.252"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 154,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("57.107.245.226"),
System.Net.IPAddress.Parse("145.172.13.151"),
System.Net.IPAddress.Parse("47.199.144.168"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("183.115.109.120"),
System.Net.IPAddress.Parse("236.145.113.120"),
System.Net.IPAddress.Parse("60.145.154.140"),
},
},
            new IPAddressinetArray1M
{
    Id = 157,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("109.189.60.104"),
System.Net.IPAddress.Parse("99.154.150.140"),
System.Net.IPAddress.Parse("239.186.75.13"),
System.Net.IPAddress.Parse("33.212.109.19"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 78,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("213.94.190.65"),
System.Net.IPAddress.Parse("250.205.46.170"),
System.Net.IPAddress.Parse("99.215.73.146"),
System.Net.IPAddress.Parse("18.49.116.139"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("155.36.167.95"),
System.Net.IPAddress.Parse("164.169.125.116"),
System.Net.IPAddress.Parse("223.217.54.230"),
System.Net.IPAddress.Parse("93.113.159.252"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("102.89.34.238"),
System.Net.IPAddress.Parse("121.200.109.141"),
System.Net.IPAddress.Parse("248.124.200.139"),
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
System.Net.IPAddress.Parse("33.86.26.235"),
System.Net.IPAddress.Parse("85.109.3.98"),
System.Net.IPAddress.Parse("74.58.22.190"),
System.Net.IPAddress.Parse("79.114.172.0"),
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
System.Net.IPAddress.Parse("226.238.191.38"),
System.Net.IPAddress.Parse("249.239.193.79"),
System.Net.IPAddress.Parse("164.235.108.143"),
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
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("79.134.42.177"),
System.Net.IPAddress.Parse("127.17.52.32"),
System.Net.IPAddress.Parse("245.32.67.216"),
}));
                nullable =  ((IIPAddressArrayinetArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("179.41.65.78"),
System.Net.IPAddress.Parse("178.111.100.111"),
System.Net.IPAddress.Parse("67.23.211.193"),
System.Net.IPAddress.Parse("27.90.216.60"),
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
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("67.203.25.30"),
System.Net.IPAddress.Parse("230.165.138.1"),
System.Net.IPAddress.Parse("136.197.15.128"),
System.Net.IPAddress.Parse("33.117.247.35"),
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 95;
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 10;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[24],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[25],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[26],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[29], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[29], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 5, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[29], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 68, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[29], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 33, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[29], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 93, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 33, query1, 120, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[29], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 101, query1, 62, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 81, query1, 19, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[29], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 13, query1, 73, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[29], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 138, 130))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[29], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatch(connection, 38, 72))
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[29], false);
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
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 147);
                var models = await ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
IPAddressinetArray1M.AssertModel(models[0],_testData[27], false);IPAddressinetArray1M.AssertModel(models[1],_testData[28], false);IPAddressinetArray1M.AssertModel(models[2],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 62);
                var models =  ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
IPAddressinetArray1M.AssertModel(models[0],_testData[10], false);IPAddressinetArray1M.AssertModel(models[1],_testData[11], false);IPAddressinetArray1M.AssertModel(models[2],_testData[12], false);IPAddressinetArray1M.AssertModel(models[3],_testData[13], false);IPAddressinetArray1M.AssertModel(models[4],_testData[14], false);IPAddressinetArray1M.AssertModel(models[5],_testData[15], false);IPAddressinetArray1M.AssertModel(models[6],_testData[16], false);IPAddressinetArray1M.AssertModel(models[7],_testData[17], false);IPAddressinetArray1M.AssertModel(models[8],_testData[18], false);IPAddressinetArray1M.AssertModel(models[9],_testData[19], false);IPAddressinetArray1M.AssertModel(models[10],_testData[20], false);IPAddressinetArray1M.AssertModel(models[11],_testData[21], false);IPAddressinetArray1M.AssertModel(models[12],_testData[22], false);IPAddressinetArray1M.AssertModel(models[13],_testData[23], false);IPAddressinetArray1M.AssertModel(models[14],_testData[24], false);IPAddressinetArray1M.AssertModel(models[15],_testData[25], false);IPAddressinetArray1M.AssertModel(models[16],_testData[26], false);IPAddressinetArray1M.AssertModel(models[17],_testData[27], false);IPAddressinetArray1M.AssertModel(models[18],_testData[28], false);IPAddressinetArray1M.AssertModel(models[19],_testData[29], false);
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
            queryMapType: typeof(IPAddressinetArray1MI),
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
            queryMapType: typeof(IPAddressinetArray1M),
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

