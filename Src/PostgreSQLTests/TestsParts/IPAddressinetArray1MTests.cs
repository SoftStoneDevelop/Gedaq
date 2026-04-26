

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
    Id = 7,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("214.243.133.70"),
System.Net.IPAddress.Parse("20.239.184.36"),
System.Net.IPAddress.Parse("238.174.251.38"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 14,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("72.155.233.252"),
System.Net.IPAddress.Parse("49.13.77.210"),
System.Net.IPAddress.Parse("232.198.224.86"),
System.Net.IPAddress.Parse("72.87.26.150"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 4,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("247.236.103.225"),
System.Net.IPAddress.Parse("91.217.168.189"),
System.Net.IPAddress.Parse("109.61.5.25"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("148.94.171.223"),
System.Net.IPAddress.Parse("133.81.76.173"),
System.Net.IPAddress.Parse("6.188.234.33"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 17,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("33.243.52.250"),
System.Net.IPAddress.Parse("24.107.163.162"),
System.Net.IPAddress.Parse("184.228.77.230"),
System.Net.IPAddress.Parse("21.229.217.186"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("230.41.187.66"),
System.Net.IPAddress.Parse("147.79.233.190"),
System.Net.IPAddress.Parse("246.32.194.144"),
},
},
            new IPAddressinetArray1M
{
    Id = 24,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("93.97.62.217"),
System.Net.IPAddress.Parse("179.154.17.193"),
System.Net.IPAddress.Parse("3.128.236.244"),
System.Net.IPAddress.Parse("82.95.67.61"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 6,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("2.131.111.190"),
System.Net.IPAddress.Parse("36.177.89.186"),
System.Net.IPAddress.Parse("37.97.179.120"),
System.Net.IPAddress.Parse("132.111.74.191"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 25,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("158.225.37.156"),
System.Net.IPAddress.Parse("0.200.51.80"),
System.Net.IPAddress.Parse("63.0.183.79"),
System.Net.IPAddress.Parse("164.75.67.233"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 26,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("99.27.66.42"),
System.Net.IPAddress.Parse("48.151.93.120"),
System.Net.IPAddress.Parse("71.144.71.58"),
System.Net.IPAddress.Parse("86.27.176.197"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 10,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("24.152.189.84"),
System.Net.IPAddress.Parse("10.141.39.144"),
System.Net.IPAddress.Parse("213.71.224.12"),
System.Net.IPAddress.Parse("16.64.159.87"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("60.192.177.144"),
System.Net.IPAddress.Parse("164.105.0.30"),
System.Net.IPAddress.Parse("189.42.211.126"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("45.63.196.70"),
System.Net.IPAddress.Parse("127.91.103.212"),
System.Net.IPAddress.Parse("46.177.36.160"),
System.Net.IPAddress.Parse("68.164.166.7"),
},
},
            new IPAddressinetArray1M
{
    Id = 28,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("139.86.221.221"),
System.Net.IPAddress.Parse("63.236.253.152"),
System.Net.IPAddress.Parse("65.69.112.180"),
System.Net.IPAddress.Parse("216.84.129.86"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 37,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("25.149.120.174"),
System.Net.IPAddress.Parse("141.39.97.42"),
System.Net.IPAddress.Parse("142.84.41.137"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 15,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("59.247.53.126"),
System.Net.IPAddress.Parse("235.243.184.211"),
System.Net.IPAddress.Parse("227.186.5.58"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("167.172.115.27"),
System.Net.IPAddress.Parse("102.60.11.112"),
System.Net.IPAddress.Parse("199.212.88.237"),
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
System.Net.IPAddress.Parse("6.167.227.113"),
System.Net.IPAddress.Parse("137.209.46.185"),
System.Net.IPAddress.Parse("26.233.98.241"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("214.2.192.97"),
System.Net.IPAddress.Parse("133.242.134.125"),
System.Net.IPAddress.Parse("238.19.156.26"),
System.Net.IPAddress.Parse("92.183.16.136"),
},
},
            new IPAddressinetArray1M
{
    Id = 51,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("6.28.103.82"),
System.Net.IPAddress.Parse("37.122.133.59"),
System.Net.IPAddress.Parse("114.171.193.15"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 16,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("45.46.61.27"),
System.Net.IPAddress.Parse("218.159.253.35"),
System.Net.IPAddress.Parse("229.103.127.13"),
System.Net.IPAddress.Parse("157.53.105.129"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("144.50.136.164"),
System.Net.IPAddress.Parse("123.253.98.105"),
System.Net.IPAddress.Parse("157.185.197.4"),
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
System.Net.IPAddress.Parse("93.29.171.49"),
System.Net.IPAddress.Parse("236.250.111.216"),
System.Net.IPAddress.Parse("131.215.37.161"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 61,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("242.240.242.140"),
System.Net.IPAddress.Parse("35.71.79.187"),
System.Net.IPAddress.Parse("245.31.90.90"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 25,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("62.204.55.155"),
System.Net.IPAddress.Parse("17.123.225.24"),
System.Net.IPAddress.Parse("223.77.121.229"),
System.Net.IPAddress.Parse("162.227.69.20"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("237.163.180.76"),
System.Net.IPAddress.Parse("87.88.140.119"),
System.Net.IPAddress.Parse("188.41.167.209"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("15.34.46.98"),
System.Net.IPAddress.Parse("146.11.0.32"),
System.Net.IPAddress.Parse("30.55.178.250"),
System.Net.IPAddress.Parse("131.133.154.150"),
},
},
            new IPAddressinetArray1M
{
    Id = 65,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("175.7.199.159"),
System.Net.IPAddress.Parse("157.28.33.103"),
System.Net.IPAddress.Parse("41.215.170.33"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("61.15.79.72"),
System.Net.IPAddress.Parse("196.165.248.19"),
System.Net.IPAddress.Parse("119.190.33.72"),
System.Net.IPAddress.Parse("14.181.209.137"),
},
},
            new IPAddressinetArray1M
{
    Id = 74,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("243.50.200.213"),
System.Net.IPAddress.Parse("29.70.177.55"),
System.Net.IPAddress.Parse("99.250.69.88"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 32,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("124.249.103.220"),
System.Net.IPAddress.Parse("5.15.249.105"),
System.Net.IPAddress.Parse("95.18.162.181"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("188.73.173.118"),
System.Net.IPAddress.Parse("211.31.231.183"),
System.Net.IPAddress.Parse("227.41.195.92"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("178.97.105.20"),
System.Net.IPAddress.Parse("113.29.226.97"),
System.Net.IPAddress.Parse("174.129.103.73"),
},
},
            new IPAddressinetArray1M
{
    Id = 79,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("75.156.170.137"),
System.Net.IPAddress.Parse("226.82.121.161"),
System.Net.IPAddress.Parse("86.171.28.184"),
System.Net.IPAddress.Parse("219.105.252.182"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("216.62.237.83"),
System.Net.IPAddress.Parse("53.60.95.236"),
System.Net.IPAddress.Parse("219.91.57.127"),
System.Net.IPAddress.Parse("244.98.149.94"),
},
},
            new IPAddressinetArray1M
{
    Id = 85,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("159.3.13.199"),
System.Net.IPAddress.Parse("90.245.145.30"),
System.Net.IPAddress.Parse("227.158.58.222"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 37,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("192.175.96.52"),
System.Net.IPAddress.Parse("59.86.59.151"),
System.Net.IPAddress.Parse("184.233.206.174"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("50.14.125.95"),
System.Net.IPAddress.Parse("55.185.231.77"),
System.Net.IPAddress.Parse("181.113.19.66"),
},
},
            new IPAddressinetArray1M
{
    Id = 87,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("251.16.238.247"),
System.Net.IPAddress.Parse("148.169.217.7"),
System.Net.IPAddress.Parse("171.152.184.63"),
System.Net.IPAddress.Parse("193.193.88.21"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("62.95.219.138"),
System.Net.IPAddress.Parse("88.231.213.224"),
System.Net.IPAddress.Parse("12.149.184.24"),
},
},
            new IPAddressinetArray1M
{
    Id = 95,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("71.117.76.131"),
System.Net.IPAddress.Parse("178.174.131.244"),
System.Net.IPAddress.Parse("16.82.201.232"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 38,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("47.74.111.103"),
System.Net.IPAddress.Parse("131.129.177.56"),
System.Net.IPAddress.Parse("192.98.61.23"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 102,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("120.162.183.137"),
System.Net.IPAddress.Parse("112.240.244.146"),
System.Net.IPAddress.Parse("122.207.163.244"),
System.Net.IPAddress.Parse("217.149.251.12"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("244.198.187.50"),
System.Net.IPAddress.Parse("188.189.32.209"),
System.Net.IPAddress.Parse("69.19.233.52"),
System.Net.IPAddress.Parse("96.15.228.178"),
},
},
            new IPAddressinetArray1M
{
    Id = 110,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("164.211.54.90"),
System.Net.IPAddress.Parse("201.126.223.58"),
System.Net.IPAddress.Parse("220.71.25.129"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 39,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("42.150.23.80"),
System.Net.IPAddress.Parse("210.117.56.92"),
System.Net.IPAddress.Parse("52.48.26.2"),
System.Net.IPAddress.Parse("65.26.212.2"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 119,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("37.214.86.112"),
System.Net.IPAddress.Parse("182.168.127.238"),
System.Net.IPAddress.Parse("197.103.3.151"),
System.Net.IPAddress.Parse("253.7.191.169"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("206.39.160.232"),
System.Net.IPAddress.Parse("240.34.59.4"),
System.Net.IPAddress.Parse("79.178.1.187"),
},
},
            new IPAddressinetArray1M
{
    Id = 126,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("173.25.63.5"),
System.Net.IPAddress.Parse("176.241.86.91"),
System.Net.IPAddress.Parse("76.196.139.105"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 40,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("184.142.44.93"),
System.Net.IPAddress.Parse("117.85.193.7"),
System.Net.IPAddress.Parse("195.32.52.133"),
System.Net.IPAddress.Parse("57.0.176.201"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("157.221.5.47"),
System.Net.IPAddress.Parse("58.184.229.80"),
System.Net.IPAddress.Parse("181.89.165.44"),
},
},
            new IPAddressinetArray1M
{
    Id = 134,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("38.57.45.153"),
System.Net.IPAddress.Parse("143.95.67.147"),
System.Net.IPAddress.Parse("198.127.212.224"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("143.147.113.6"),
System.Net.IPAddress.Parse("8.113.164.201"),
System.Net.IPAddress.Parse("248.227.225.147"),
System.Net.IPAddress.Parse("215.148.105.180"),
},
},
            new IPAddressinetArray1M
{
    Id = 136,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("74.154.89.129"),
System.Net.IPAddress.Parse("87.39.241.36"),
System.Net.IPAddress.Parse("132.86.252.230"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 42,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("51.183.101.121"),
System.Net.IPAddress.Parse("175.30.174.73"),
System.Net.IPAddress.Parse("107.175.110.29"),
System.Net.IPAddress.Parse("50.213.87.250"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("131.183.12.168"),
System.Net.IPAddress.Parse("205.69.18.64"),
System.Net.IPAddress.Parse("114.83.98.65"),
System.Net.IPAddress.Parse("121.169.181.238"),
},
},
            new IPAddressinetArray1M
{
    Id = 142,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("94.55.4.253"),
System.Net.IPAddress.Parse("241.63.197.73"),
System.Net.IPAddress.Parse("9.4.250.128"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 151,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("147.97.214.140"),
System.Net.IPAddress.Parse("160.146.88.19"),
System.Net.IPAddress.Parse("19.102.216.133"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 45,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("209.206.34.62"),
System.Net.IPAddress.Parse("87.43.58.21"),
System.Net.IPAddress.Parse("154.20.158.141"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("168.207.84.7"),
System.Net.IPAddress.Parse("104.180.117.192"),
System.Net.IPAddress.Parse("97.134.141.181"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("14.46.44.224"),
System.Net.IPAddress.Parse("230.71.1.63"),
System.Net.IPAddress.Parse("205.72.128.28"),
System.Net.IPAddress.Parse("37.76.21.243"),
},
},
            new IPAddressinetArray1M
{
    Id = 157,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("8.118.222.132"),
System.Net.IPAddress.Parse("110.152.165.96"),
System.Net.IPAddress.Parse("174.189.180.122"),
System.Net.IPAddress.Parse("134.207.125.15"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("186.151.172.176"),
System.Net.IPAddress.Parse("82.26.111.38"),
System.Net.IPAddress.Parse("82.160.218.6"),
},
},
            new IPAddressinetArray1M
{
    Id = 165,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("180.211.219.150"),
System.Net.IPAddress.Parse("10.228.250.114"),
System.Net.IPAddress.Parse("49.106.201.192"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 52,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("228.178.48.206"),
System.Net.IPAddress.Parse("140.186.158.107"),
System.Net.IPAddress.Parse("178.182.204.42"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.52.175.233"),
System.Net.IPAddress.Parse("163.191.61.235"),
System.Net.IPAddress.Parse("101.43.156.67"),
System.Net.IPAddress.Parse("224.164.129.51"),
},
},
            new IPAddressinetArray1M
{
    Id = 172,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("243.89.37.120"),
System.Net.IPAddress.Parse("170.72.134.120"),
System.Net.IPAddress.Parse("163.4.113.115"),
System.Net.IPAddress.Parse("100.31.34.194"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.206.53.198"),
System.Net.IPAddress.Parse("119.146.203.220"),
System.Net.IPAddress.Parse("22.44.55.103"),
System.Net.IPAddress.Parse("100.39.41.132"),
},
},
            new IPAddressinetArray1M
{
    Id = 181,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("118.116.206.117"),
System.Net.IPAddress.Parse("248.45.85.94"),
System.Net.IPAddress.Parse("194.169.19.10"),
System.Net.IPAddress.Parse("76.232.19.80"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 54,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("38.56.153.250"),
System.Net.IPAddress.Parse("169.240.146.7"),
System.Net.IPAddress.Parse("144.69.79.179"),
System.Net.IPAddress.Parse("197.225.27.80"),
},
    NullableValue = null,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("45.63.196.70"),
System.Net.IPAddress.Parse("127.91.103.212"),
System.Net.IPAddress.Parse("46.177.36.160"),
System.Net.IPAddress.Parse("68.164.166.7"),
}));
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
System.Net.IPAddress.Parse("214.2.192.97"),
System.Net.IPAddress.Parse("133.242.134.125"),
System.Net.IPAddress.Parse("238.19.156.26"),
System.Net.IPAddress.Parse("92.183.16.136"),
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
System.Net.IPAddress.Parse("15.34.46.98"),
System.Net.IPAddress.Parse("146.11.0.32"),
System.Net.IPAddress.Parse("30.55.178.250"),
System.Net.IPAddress.Parse("131.133.154.150"),
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[30], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[29], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[30], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[27],_testData[29], false);
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
                parametr1.Value = 17;
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[24],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[25],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[29], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[30], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[30], false);
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
                parametr1.Value = 165;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[29], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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
                await ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 7, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[30], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 14, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[27],_testData[29], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 28, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[30], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 26, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[29], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 136, query1, 28, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[29], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 151, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[24],_testData[30], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 65, query1, 37, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 79, query1, 28, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[30], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 119, 79))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[29], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatch(connection, 151, 79))
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[29], false);
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

                Assert.That(models, Has.Count.EqualTo(20));
IPAddressinetArray1M.AssertModel(models[0],_testData[10], false);IPAddressinetArray1M.AssertModel(models[1],_testData[11], false);IPAddressinetArray1M.AssertModel(models[2],_testData[12], false);IPAddressinetArray1M.AssertModel(models[3],_testData[13], false);IPAddressinetArray1M.AssertModel(models[4],_testData[14], false);IPAddressinetArray1M.AssertModel(models[5],_testData[15], false);IPAddressinetArray1M.AssertModel(models[6],_testData[16], false);IPAddressinetArray1M.AssertModel(models[7],_testData[17], false);IPAddressinetArray1M.AssertModel(models[8],_testData[18], false);IPAddressinetArray1M.AssertModel(models[9],_testData[19], false);IPAddressinetArray1M.AssertModel(models[10],_testData[20], false);IPAddressinetArray1M.AssertModel(models[11],_testData[21], false);IPAddressinetArray1M.AssertModel(models[12],_testData[22], false);IPAddressinetArray1M.AssertModel(models[13],_testData[23], false);IPAddressinetArray1M.AssertModel(models[14],_testData[24], false);IPAddressinetArray1M.AssertModel(models[15],_testData[25], false);IPAddressinetArray1M.AssertModel(models[16],_testData[26], false);IPAddressinetArray1M.AssertModel(models[17],_testData[27], false);IPAddressinetArray1M.AssertModel(models[18],_testData[28], false);IPAddressinetArray1M.AssertModel(models[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 126);
                var models =  ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
IPAddressinetArray1M.AssertModel(models[0],_testData[22], false);IPAddressinetArray1M.AssertModel(models[1],_testData[23], false);IPAddressinetArray1M.AssertModel(models[2],_testData[24], false);IPAddressinetArray1M.AssertModel(models[3],_testData[25], false);IPAddressinetArray1M.AssertModel(models[4],_testData[26], false);IPAddressinetArray1M.AssertModel(models[5],_testData[27], false);IPAddressinetArray1M.AssertModel(models[6],_testData[28], false);IPAddressinetArray1M.AssertModel(models[7],_testData[29], false);
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

