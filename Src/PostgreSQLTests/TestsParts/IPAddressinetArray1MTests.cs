

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
    Id = 3,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("33.92.195.42"),
System.Net.IPAddress.Parse("215.226.250.99"),
System.Net.IPAddress.Parse("220.34.109.239"),
System.Net.IPAddress.Parse("197.243.239.67"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("119.75.95.103"),
System.Net.IPAddress.Parse("44.216.6.37"),
System.Net.IPAddress.Parse("251.231.80.216"),
},
},
            new IPAddressinetArray1M
{
    Id = 11,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("233.17.47.43"),
System.Net.IPAddress.Parse("92.177.4.200"),
System.Net.IPAddress.Parse("63.117.243.228"),
System.Net.IPAddress.Parse("38.24.4.223"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 2,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("238.217.13.125"),
System.Net.IPAddress.Parse("234.20.158.194"),
System.Net.IPAddress.Parse("79.7.135.60"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("20.100.97.4"),
System.Net.IPAddress.Parse("143.71.233.110"),
System.Net.IPAddress.Parse("40.177.24.254"),
},
},
            new IPAddressinetArray1M
{
    Id = 17,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("41.168.47.88"),
System.Net.IPAddress.Parse("66.221.241.88"),
System.Net.IPAddress.Parse("195.33.1.1"),
System.Net.IPAddress.Parse("15.123.117.151"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("55.137.102.16"),
System.Net.IPAddress.Parse("25.99.222.153"),
System.Net.IPAddress.Parse("194.222.29.213"),
},
},
            new IPAddressinetArray1M
{
    Id = 19,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("122.98.151.197"),
System.Net.IPAddress.Parse("231.160.10.85"),
System.Net.IPAddress.Parse("220.168.108.134"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 5,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("46.107.121.185"),
System.Net.IPAddress.Parse("53.231.218.150"),
System.Net.IPAddress.Parse("123.27.30.207"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("226.158.114.5"),
System.Net.IPAddress.Parse("169.87.69.145"),
System.Net.IPAddress.Parse("117.185.143.153"),
System.Net.IPAddress.Parse("220.96.37.107"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("117.253.213.235"),
System.Net.IPAddress.Parse("213.9.137.75"),
System.Net.IPAddress.Parse("245.240.177.176"),
},
},
            new IPAddressinetArray1M
{
    Id = 24,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("122.139.244.2"),
System.Net.IPAddress.Parse("163.147.139.126"),
System.Net.IPAddress.Parse("25.186.18.139"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("233.27.4.169"),
System.Net.IPAddress.Parse("101.82.28.152"),
System.Net.IPAddress.Parse("80.130.216.24"),
},
},
            new IPAddressinetArray1M
{
    Id = 27,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("160.224.213.214"),
System.Net.IPAddress.Parse("76.49.190.56"),
System.Net.IPAddress.Parse("164.202.180.232"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 12,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("113.219.106.38"),
System.Net.IPAddress.Parse("129.148.240.238"),
System.Net.IPAddress.Parse("251.65.75.13"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("10.128.74.246"),
System.Net.IPAddress.Parse("241.182.109.128"),
System.Net.IPAddress.Parse("244.123.207.135"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 32,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("25.51.174.236"),
System.Net.IPAddress.Parse("14.223.192.5"),
System.Net.IPAddress.Parse("72.202.70.63"),
System.Net.IPAddress.Parse("235.164.205.226"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("130.117.10.162"),
System.Net.IPAddress.Parse("228.28.68.132"),
System.Net.IPAddress.Parse("247.73.120.44"),
System.Net.IPAddress.Parse("137.165.172.173"),
},
},
            new IPAddressinetArray1M
{
    Id = 38,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("88.177.104.250"),
System.Net.IPAddress.Parse("22.60.32.60"),
System.Net.IPAddress.Parse("79.190.127.27"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 17,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("210.59.103.252"),
System.Net.IPAddress.Parse("22.98.151.112"),
System.Net.IPAddress.Parse("9.208.205.2"),
System.Net.IPAddress.Parse("12.143.226.187"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("214.242.162.47"),
System.Net.IPAddress.Parse("166.92.40.246"),
System.Net.IPAddress.Parse("150.23.243.191"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 46,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("194.0.107.207"),
System.Net.IPAddress.Parse("142.177.89.180"),
System.Net.IPAddress.Parse("151.165.156.75"),
System.Net.IPAddress.Parse("39.179.57.19"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("33.10.32.49"),
System.Net.IPAddress.Parse("104.143.60.238"),
System.Net.IPAddress.Parse("200.125.242.175"),
System.Net.IPAddress.Parse("133.78.179.121"),
},
},
            new IPAddressinetArray1M
{
    Id = 54,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("242.226.12.195"),
System.Net.IPAddress.Parse("18.187.56.248"),
System.Net.IPAddress.Parse("181.167.225.140"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 26,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("121.125.241.92"),
System.Net.IPAddress.Parse("251.94.42.98"),
System.Net.IPAddress.Parse("199.158.22.153"),
System.Net.IPAddress.Parse("192.85.39.239"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("186.44.99.57"),
System.Net.IPAddress.Parse("218.234.5.21"),
System.Net.IPAddress.Parse("241.194.103.74"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("231.136.16.212"),
System.Net.IPAddress.Parse("247.219.19.48"),
System.Net.IPAddress.Parse("40.223.116.48"),
},
},
            new IPAddressinetArray1M
{
    Id = 58,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.99.154.157"),
System.Net.IPAddress.Parse("33.70.89.132"),
System.Net.IPAddress.Parse("29.139.2.163"),
System.Net.IPAddress.Parse("179.149.106.22"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 67,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("133.208.210.78"),
System.Net.IPAddress.Parse("123.111.34.52"),
System.Net.IPAddress.Parse("156.136.156.149"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 27,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("252.50.241.7"),
System.Net.IPAddress.Parse("147.184.19.90"),
System.Net.IPAddress.Parse("115.148.176.49"),
System.Net.IPAddress.Parse("57.144.209.118"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 69,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("111.224.92.24"),
System.Net.IPAddress.Parse("197.78.183.232"),
System.Net.IPAddress.Parse("111.98.100.99"),
System.Net.IPAddress.Parse("166.225.97.8"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("84.94.227.60"),
System.Net.IPAddress.Parse("67.7.130.119"),
System.Net.IPAddress.Parse("177.186.205.85"),
System.Net.IPAddress.Parse("184.241.5.39"),
},
},
            new IPAddressinetArray1M
{
    Id = 77,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("14.125.124.222"),
System.Net.IPAddress.Parse("135.130.75.197"),
System.Net.IPAddress.Parse("171.98.241.19"),
System.Net.IPAddress.Parse("135.1.28.110"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 32,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.43.131.121"),
System.Net.IPAddress.Parse("137.105.225.33"),
System.Net.IPAddress.Parse("250.122.127.177"),
System.Net.IPAddress.Parse("123.82.70.184"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("100.184.201.160"),
System.Net.IPAddress.Parse("140.112.131.2"),
System.Net.IPAddress.Parse("252.41.106.13"),
System.Net.IPAddress.Parse("146.247.50.185"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("194.203.155.12"),
System.Net.IPAddress.Parse("9.129.77.206"),
System.Net.IPAddress.Parse("185.47.224.142"),
System.Net.IPAddress.Parse("66.243.234.168"),
},
},
            new IPAddressinetArray1M
{
    Id = 83,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("245.13.136.185"),
System.Net.IPAddress.Parse("62.145.248.197"),
System.Net.IPAddress.Parse("26.172.77.251"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 89,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("9.100.166.101"),
System.Net.IPAddress.Parse("94.28.48.18"),
System.Net.IPAddress.Parse("195.10.215.220"),
System.Net.IPAddress.Parse("146.118.96.224"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 40,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("129.32.81.41"),
System.Net.IPAddress.Parse("146.124.57.245"),
System.Net.IPAddress.Parse("177.108.213.245"),
System.Net.IPAddress.Parse("227.68.79.32"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("93.19.70.21"),
System.Net.IPAddress.Parse("195.186.3.92"),
System.Net.IPAddress.Parse("61.34.209.26"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("63.162.6.186"),
System.Net.IPAddress.Parse("93.116.242.166"),
System.Net.IPAddress.Parse("43.157.86.199"),
},
},
            new IPAddressinetArray1M
{
    Id = 90,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("108.86.195.52"),
System.Net.IPAddress.Parse("21.80.137.6"),
System.Net.IPAddress.Parse("85.132.66.246"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("1.196.1.179"),
System.Net.IPAddress.Parse("20.47.29.70"),
System.Net.IPAddress.Parse("90.141.150.210"),
System.Net.IPAddress.Parse("204.157.49.126"),
},
},
            new IPAddressinetArray1M
{
    Id = 94,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("61.60.129.228"),
System.Net.IPAddress.Parse("165.40.165.130"),
System.Net.IPAddress.Parse("36.182.27.115"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 47,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.134.215.239"),
System.Net.IPAddress.Parse("226.101.158.110"),
System.Net.IPAddress.Parse("145.181.182.120"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("169.243.12.198"),
System.Net.IPAddress.Parse("61.83.206.74"),
System.Net.IPAddress.Parse("143.93.15.153"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("5.211.91.23"),
System.Net.IPAddress.Parse("201.175.61.221"),
System.Net.IPAddress.Parse("10.98.154.5"),
System.Net.IPAddress.Parse("100.126.154.236"),
},
},
            new IPAddressinetArray1M
{
    Id = 95,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("109.94.250.46"),
System.Net.IPAddress.Parse("196.162.180.182"),
System.Net.IPAddress.Parse("50.215.30.60"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("124.180.138.237"),
System.Net.IPAddress.Parse("67.72.185.235"),
System.Net.IPAddress.Parse("202.70.45.85"),
},
},
            new IPAddressinetArray1M
{
    Id = 100,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("208.216.53.154"),
System.Net.IPAddress.Parse("133.72.178.186"),
System.Net.IPAddress.Parse("51.21.11.181"),
System.Net.IPAddress.Parse("247.27.121.26"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 55,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("172.144.128.208"),
System.Net.IPAddress.Parse("214.51.34.237"),
System.Net.IPAddress.Parse("154.109.207.137"),
System.Net.IPAddress.Parse("70.231.75.62"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("208.185.144.20"),
System.Net.IPAddress.Parse("22.7.22.157"),
System.Net.IPAddress.Parse("247.42.210.11"),
System.Net.IPAddress.Parse("157.19.51.216"),
},
},
            new IPAddressinetArray1M
{
    Id = 108,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("133.184.131.6"),
System.Net.IPAddress.Parse("118.231.180.3"),
System.Net.IPAddress.Parse("207.203.7.109"),
System.Net.IPAddress.Parse("20.242.228.168"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 116,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.224.247.44"),
System.Net.IPAddress.Parse("127.208.5.129"),
System.Net.IPAddress.Parse("246.18.9.110"),
System.Net.IPAddress.Parse("236.102.48.220"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 64,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("132.99.220.225"),
System.Net.IPAddress.Parse("160.77.43.41"),
System.Net.IPAddress.Parse("28.153.244.58"),
System.Net.IPAddress.Parse("131.169.83.93"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("168.64.90.22"),
System.Net.IPAddress.Parse("15.40.6.233"),
System.Net.IPAddress.Parse("2.46.89.70"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("180.239.157.126"),
System.Net.IPAddress.Parse("233.74.106.215"),
System.Net.IPAddress.Parse("91.177.231.197"),
},
},
            new IPAddressinetArray1M
{
    Id = 124,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("118.237.66.135"),
System.Net.IPAddress.Parse("78.32.186.76"),
System.Net.IPAddress.Parse("55.158.232.68"),
System.Net.IPAddress.Parse("150.15.252.83"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.56.64.52"),
System.Net.IPAddress.Parse("24.57.227.53"),
System.Net.IPAddress.Parse("211.151.88.152"),
},
},
            new IPAddressinetArray1M
{
    Id = 126,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("146.183.239.173"),
System.Net.IPAddress.Parse("144.227.35.0"),
System.Net.IPAddress.Parse("217.105.242.238"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 66,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("219.104.24.132"),
System.Net.IPAddress.Parse("215.162.182.35"),
System.Net.IPAddress.Parse("179.76.80.63"),
System.Net.IPAddress.Parse("145.108.16.76"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("179.194.72.61"),
System.Net.IPAddress.Parse("111.86.14.147"),
System.Net.IPAddress.Parse("17.126.211.132"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 134,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("212.237.106.66"),
System.Net.IPAddress.Parse("28.184.220.205"),
System.Net.IPAddress.Parse("3.114.209.35"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("215.179.199.131"),
System.Net.IPAddress.Parse("33.200.182.145"),
System.Net.IPAddress.Parse("182.131.73.206"),
},
},
            new IPAddressinetArray1M
{
    Id = 138,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("208.232.249.112"),
System.Net.IPAddress.Parse("179.250.164.89"),
System.Net.IPAddress.Parse("243.190.181.208"),
System.Net.IPAddress.Parse("140.218.227.19"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 75,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("155.207.138.84"),
System.Net.IPAddress.Parse("36.79.167.32"),
System.Net.IPAddress.Parse("247.45.213.13"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("195.2.72.96"),
System.Net.IPAddress.Parse("31.139.158.205"),
System.Net.IPAddress.Parse("174.163.169.34"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 140,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("28.172.90.160"),
System.Net.IPAddress.Parse("85.34.74.249"),
System.Net.IPAddress.Parse("159.163.231.1"),
System.Net.IPAddress.Parse("121.249.88.192"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 145,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("51.86.201.211"),
System.Net.IPAddress.Parse("196.18.36.86"),
System.Net.IPAddress.Parse("68.42.92.240"),
System.Net.IPAddress.Parse("232.123.0.185"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 77,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("170.220.254.3"),
System.Net.IPAddress.Parse("175.169.19.154"),
System.Net.IPAddress.Parse("109.40.224.101"),
System.Net.IPAddress.Parse("40.48.24.4"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("170.127.80.137"),
System.Net.IPAddress.Parse("94.18.144.229"),
System.Net.IPAddress.Parse("3.220.161.81"),
System.Net.IPAddress.Parse("128.242.170.172"),
},
},
            new IPAddressinetArray1M
{
    Id = 146,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("63.5.42.121"),
System.Net.IPAddress.Parse("49.179.239.241"),
System.Net.IPAddress.Parse("96.10.84.238"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("160.38.151.39"),
System.Net.IPAddress.Parse("193.205.60.54"),
System.Net.IPAddress.Parse("236.93.154.231"),
System.Net.IPAddress.Parse("242.69.118.78"),
},
},
            new IPAddressinetArray1M
{
    Id = 152,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("224.238.58.215"),
System.Net.IPAddress.Parse("200.147.226.206"),
System.Net.IPAddress.Parse("181.83.160.162"),
System.Net.IPAddress.Parse("192.11.176.70"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 78,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("172.131.186.116"),
System.Net.IPAddress.Parse("232.187.9.192"),
System.Net.IPAddress.Parse("69.237.65.179"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("123.218.147.113"),
System.Net.IPAddress.Parse("211.173.209.106"),
System.Net.IPAddress.Parse("155.198.185.142"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("233.27.4.169"),
System.Net.IPAddress.Parse("101.82.28.152"),
System.Net.IPAddress.Parse("80.130.216.24"),
}));
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
System.Net.IPAddress.Parse("130.117.10.162"),
System.Net.IPAddress.Parse("228.28.68.132"),
System.Net.IPAddress.Parse("247.73.120.44"),
System.Net.IPAddress.Parse("137.165.172.173"),
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
System.Net.IPAddress.Parse("33.10.32.49"),
System.Net.IPAddress.Parse("104.143.60.238"),
System.Net.IPAddress.Parse("200.125.242.175"),
System.Net.IPAddress.Parse("133.78.179.121"),
}));
                nullable =  ((IIPAddressArrayinetArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("231.136.16.212"),
System.Net.IPAddress.Parse("247.219.19.48"),
System.Net.IPAddress.Parse("40.223.116.48"),
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[29], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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

                    if(resultIndex == 2)
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[29], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[29], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
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
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[28],_testData[29], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[1], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[2], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[3], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[4], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[5], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[6], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[7], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[8], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[9], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[10], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[24],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[25],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[26],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[27],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[28],_testData[29], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
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
                await ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 17, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[28],_testData[29], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 108, query1, 27, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                 ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 145, query1, 19, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[25],_testData[29], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 89, query1, 69, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[29], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 140, query1, 116, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[29], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 19, query1, 108, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[29], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 17, query1, 69, query2))
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
                 ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 24, query1, 138, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[29], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 27, 24))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[6], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[7], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[8], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[9], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[10], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[5], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[6], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[7], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[8], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[9], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[10], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[24],_testData[29], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatch(connection, 95, 126))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[29], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 77);
                var models = await ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
IPAddressinetArray1M.AssertModel(models[0],_testData[14], false);IPAddressinetArray1M.AssertModel(models[1],_testData[15], false);IPAddressinetArray1M.AssertModel(models[2],_testData[16], false);IPAddressinetArray1M.AssertModel(models[3],_testData[17], false);IPAddressinetArray1M.AssertModel(models[4],_testData[18], false);IPAddressinetArray1M.AssertModel(models[5],_testData[19], false);IPAddressinetArray1M.AssertModel(models[6],_testData[20], false);IPAddressinetArray1M.AssertModel(models[7],_testData[21], false);IPAddressinetArray1M.AssertModel(models[8],_testData[22], false);IPAddressinetArray1M.AssertModel(models[9],_testData[23], false);IPAddressinetArray1M.AssertModel(models[10],_testData[24], false);IPAddressinetArray1M.AssertModel(models[11],_testData[25], false);IPAddressinetArray1M.AssertModel(models[12],_testData[26], false);IPAddressinetArray1M.AssertModel(models[13],_testData[27], false);IPAddressinetArray1M.AssertModel(models[14],_testData[28], false);IPAddressinetArray1M.AssertModel(models[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 54);
                var models =  ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
IPAddressinetArray1M.AssertModel(models[0],_testData[10], false);IPAddressinetArray1M.AssertModel(models[1],_testData[11], false);IPAddressinetArray1M.AssertModel(models[2],_testData[12], false);IPAddressinetArray1M.AssertModel(models[3],_testData[13], false);IPAddressinetArray1M.AssertModel(models[4],_testData[14], false);IPAddressinetArray1M.AssertModel(models[5],_testData[15], false);IPAddressinetArray1M.AssertModel(models[6],_testData[16], false);IPAddressinetArray1M.AssertModel(models[7],_testData[17], false);IPAddressinetArray1M.AssertModel(models[8],_testData[18], false);IPAddressinetArray1M.AssertModel(models[9],_testData[19], false);IPAddressinetArray1M.AssertModel(models[10],_testData[20], false);IPAddressinetArray1M.AssertModel(models[11],_testData[21], false);IPAddressinetArray1M.AssertModel(models[12],_testData[22], false);IPAddressinetArray1M.AssertModel(models[13],_testData[23], false);IPAddressinetArray1M.AssertModel(models[14],_testData[24], false);IPAddressinetArray1M.AssertModel(models[15],_testData[25], false);IPAddressinetArray1M.AssertModel(models[16],_testData[26], false);IPAddressinetArray1M.AssertModel(models[17],_testData[27], false);IPAddressinetArray1M.AssertModel(models[18],_testData[28], false);IPAddressinetArray1M.AssertModel(models[19],_testData[29], false);
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
FROM public.binary_ipaddressinetarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(IPAddressinetArray1MIWA),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetArray1MIWA>(2);
                for (int i = 0; i < 6; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressArrayinetArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinetarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IIPAddressArrayinetArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<IPAddressinetArray1MIWA>(2);
                for (int i = 4; i < 10; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressArrayinetArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinetarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressArrayinetArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(actual, expect, false);
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

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetArray1MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IIPAddressArrayinetArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IIPAddressArrayinetArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<IPAddressinetArray1MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IIPAddressArrayinetArray)this).ImportModelInner(connection, importCollection);
                var models = ((IIPAddressArrayinetArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

