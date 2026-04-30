

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
    internal partial interface IIPAddressListinetArray
    {
    }
    
    internal partial class IPAddressListinetArray : IIPAddressListinetArray
    {


#region TestData

        private readonly IPAddressinetArray2M[] _testData = new IPAddressinetArray2M[]
        {
            new IPAddressinetArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("244.105.216.96"),

System.Net.IPAddress.Parse("6.221.165.232"),

System.Net.IPAddress.Parse("221.128.228.88"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("83.185.160.240"),

System.Net.IPAddress.Parse("59.248.9.60"),

System.Net.IPAddress.Parse("24.214.44.174"),

System.Net.IPAddress.Parse("164.132.52.32"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("208.60.210.218"),

System.Net.IPAddress.Parse("96.66.251.125"),

System.Net.IPAddress.Parse("177.39.27.99"),

System.Net.IPAddress.Parse("187.111.222.63"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("195.25.167.47"),

System.Net.IPAddress.Parse("22.226.62.236"),

System.Net.IPAddress.Parse("88.201.106.197"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("245.159.124.14"),

System.Net.IPAddress.Parse("60.133.161.225"),

System.Net.IPAddress.Parse("226.213.27.203"),

System.Net.IPAddress.Parse("174.235.72.229"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("65.163.37.24"),

System.Net.IPAddress.Parse("231.225.82.145"),

System.Net.IPAddress.Parse("159.58.42.183"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("89.106.100.172"),

System.Net.IPAddress.Parse("217.243.68.131"),

System.Net.IPAddress.Parse("169.83.42.222"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("10.21.25.76"),

System.Net.IPAddress.Parse("157.154.172.192"),

System.Net.IPAddress.Parse("109.71.149.20"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("61.180.103.254"),

System.Net.IPAddress.Parse("143.238.39.207"),

System.Net.IPAddress.Parse("141.68.236.45"),

System.Net.IPAddress.Parse("219.133.110.254"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("116.8.46.49"),

System.Net.IPAddress.Parse("44.149.58.88"),

System.Net.IPAddress.Parse("69.139.65.172"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("182.78.194.168"),

System.Net.IPAddress.Parse("76.16.69.102"),

System.Net.IPAddress.Parse("143.237.31.211"),

System.Net.IPAddress.Parse("192.98.201.180"),

},
},
            new IPAddressinetArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("224.240.163.200"),

System.Net.IPAddress.Parse("150.110.126.172"),

System.Net.IPAddress.Parse("185.10.37.95"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.139.61.16"),

System.Net.IPAddress.Parse("116.17.185.77"),

System.Net.IPAddress.Parse("126.51.181.43"),

System.Net.IPAddress.Parse("19.29.46.163"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("124.123.140.21"),

System.Net.IPAddress.Parse("161.34.218.7"),

System.Net.IPAddress.Parse("161.21.90.24"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("131.243.9.6"),

System.Net.IPAddress.Parse("213.169.183.23"),

System.Net.IPAddress.Parse("106.202.153.248"),

System.Net.IPAddress.Parse("148.119.164.10"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("214.150.208.178"),

System.Net.IPAddress.Parse("161.4.202.23"),

System.Net.IPAddress.Parse("233.15.94.244"),

System.Net.IPAddress.Parse("22.216.207.188"),

},
},
            new IPAddressinetArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("195.222.17.235"),

System.Net.IPAddress.Parse("164.10.108.6"),

System.Net.IPAddress.Parse("229.137.41.220"),

System.Net.IPAddress.Parse("250.28.77.156"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("71.12.28.2"),

System.Net.IPAddress.Parse("157.138.3.219"),

System.Net.IPAddress.Parse("80.162.18.150"),

System.Net.IPAddress.Parse("38.83.220.124"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("234.168.224.5"),

System.Net.IPAddress.Parse("241.47.64.163"),

System.Net.IPAddress.Parse("181.240.179.58"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("60.28.76.154"),

System.Net.IPAddress.Parse("152.221.66.222"),

System.Net.IPAddress.Parse("248.228.210.27"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("237.4.5.114"),

System.Net.IPAddress.Parse("246.52.131.19"),

System.Net.IPAddress.Parse("190.217.214.124"),

System.Net.IPAddress.Parse("188.75.25.24"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("188.135.157.27"),

System.Net.IPAddress.Parse("21.228.160.231"),

System.Net.IPAddress.Parse("202.6.189.155"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("66.212.105.239"),

System.Net.IPAddress.Parse("20.253.238.27"),

System.Net.IPAddress.Parse("249.202.192.36"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("175.107.126.26"),

System.Net.IPAddress.Parse("6.12.0.221"),

System.Net.IPAddress.Parse("96.173.196.85"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("69.77.119.218"),

System.Net.IPAddress.Parse("36.195.246.104"),

System.Net.IPAddress.Parse("109.11.150.196"),

System.Net.IPAddress.Parse("110.135.25.102"),

},
},
            new IPAddressinetArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("191.108.189.238"),

System.Net.IPAddress.Parse("179.11.211.23"),

System.Net.IPAddress.Parse("240.160.95.90"),

System.Net.IPAddress.Parse("1.3.209.190"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("43.41.241.127"),

System.Net.IPAddress.Parse("45.157.75.75"),

System.Net.IPAddress.Parse("23.51.194.13"),

System.Net.IPAddress.Parse("129.235.226.49"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("14.138.71.171"),

System.Net.IPAddress.Parse("49.194.165.44"),

System.Net.IPAddress.Parse("21.204.237.229"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("203.42.236.239"),

System.Net.IPAddress.Parse("153.144.60.116"),

System.Net.IPAddress.Parse("251.252.35.52"),

},
},
            new IPAddressinetArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("104.62.60.181"),

System.Net.IPAddress.Parse("235.20.183.227"),

System.Net.IPAddress.Parse("17.201.69.114"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("58.173.117.182"),

System.Net.IPAddress.Parse("111.210.242.235"),

System.Net.IPAddress.Parse("101.127.37.138"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("61.51.184.126"),

System.Net.IPAddress.Parse("139.107.182.114"),

System.Net.IPAddress.Parse("21.225.81.199"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("95.199.27.241"),

System.Net.IPAddress.Parse("18.224.47.153"),

System.Net.IPAddress.Parse("77.30.210.108"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("222.112.2.128"),

System.Net.IPAddress.Parse("74.223.36.155"),

System.Net.IPAddress.Parse("224.236.222.72"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("96.61.241.151"),

System.Net.IPAddress.Parse("170.14.23.68"),

System.Net.IPAddress.Parse("27.99.9.144"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("43.143.2.167"),

System.Net.IPAddress.Parse("211.74.25.103"),

System.Net.IPAddress.Parse("220.226.184.211"),

System.Net.IPAddress.Parse("200.33.199.203"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("7.214.13.244"),

System.Net.IPAddress.Parse("187.31.6.124"),

System.Net.IPAddress.Parse("185.94.45.11"),

System.Net.IPAddress.Parse("243.194.72.45"),

},
},
            new IPAddressinetArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("189.137.141.113"),

System.Net.IPAddress.Parse("4.240.112.68"),

System.Net.IPAddress.Parse("71.187.120.238"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("70.33.182.65"),

System.Net.IPAddress.Parse("185.23.254.233"),

System.Net.IPAddress.Parse("86.68.224.151"),

},
},
            new IPAddressinetArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("170.90.100.59"),

System.Net.IPAddress.Parse("23.157.10.139"),

System.Net.IPAddress.Parse("5.73.188.249"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("27.209.61.85"),

System.Net.IPAddress.Parse("31.219.246.199"),

System.Net.IPAddress.Parse("213.123.219.173"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("241.238.18.201"),

System.Net.IPAddress.Parse("10.177.67.126"),

System.Net.IPAddress.Parse("203.216.65.36"),

System.Net.IPAddress.Parse("228.248.4.171"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("74.38.4.116"),

System.Net.IPAddress.Parse("130.149.76.54"),

System.Net.IPAddress.Parse("9.200.198.155"),

System.Net.IPAddress.Parse("219.18.15.87"),

},
},
            new IPAddressinetArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("36.109.32.152"),

System.Net.IPAddress.Parse("102.219.128.132"),

System.Net.IPAddress.Parse("189.204.138.254"),

System.Net.IPAddress.Parse("52.26.231.218"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("108.125.111.65"),

System.Net.IPAddress.Parse("82.83.47.97"),

System.Net.IPAddress.Parse("130.119.64.85"),

System.Net.IPAddress.Parse("195.81.78.84"),

},
},
            new IPAddressinetArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("17.23.176.5"),

System.Net.IPAddress.Parse("237.239.160.170"),

System.Net.IPAddress.Parse("153.58.34.187"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("191.247.136.13"),

System.Net.IPAddress.Parse("92.107.126.68"),

System.Net.IPAddress.Parse("182.174.55.178"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("48.222.121.218"),

System.Net.IPAddress.Parse("78.72.206.45"),

System.Net.IPAddress.Parse("203.25.62.201"),

System.Net.IPAddress.Parse("44.8.150.234"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.102.229.109"),

System.Net.IPAddress.Parse("247.170.138.100"),

System.Net.IPAddress.Parse("229.99.57.195"),

System.Net.IPAddress.Parse("178.26.147.1"),

},
},
            new IPAddressinetArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("205.234.21.2"),

System.Net.IPAddress.Parse("221.148.107.214"),

System.Net.IPAddress.Parse("240.7.230.72"),

System.Net.IPAddress.Parse("254.90.161.119"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("85.223.153.121"),

System.Net.IPAddress.Parse("110.109.177.60"),

System.Net.IPAddress.Parse("171.233.60.145"),

System.Net.IPAddress.Parse("91.126.63.149"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("141.199.96.43"),

System.Net.IPAddress.Parse("196.12.191.231"),

System.Net.IPAddress.Parse("29.109.241.157"),

},
},
            new IPAddressinetArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("106.83.159.35"),

System.Net.IPAddress.Parse("162.134.252.170"),

System.Net.IPAddress.Parse("30.30.61.174"),

System.Net.IPAddress.Parse("138.186.194.81"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("205.40.91.16"),

System.Net.IPAddress.Parse("144.88.115.228"),

System.Net.IPAddress.Parse("187.36.161.5"),

},
},
            new IPAddressinetArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("246.231.11.226"),

System.Net.IPAddress.Parse("124.177.180.185"),

System.Net.IPAddress.Parse("214.247.163.157"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("23.6.173.126"),

System.Net.IPAddress.Parse("198.156.67.18"),

System.Net.IPAddress.Parse("178.178.213.131"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("198.199.240.10"),

System.Net.IPAddress.Parse("201.3.80.77"),

System.Net.IPAddress.Parse("51.214.22.53"),

System.Net.IPAddress.Parse("251.145.196.213"),

},
},
            new IPAddressinetArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("172.97.145.117"),

System.Net.IPAddress.Parse("87.167.55.199"),

System.Net.IPAddress.Parse("20.69.198.178"),

System.Net.IPAddress.Parse("171.184.161.186"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("210.107.190.53"),

System.Net.IPAddress.Parse("46.7.17.191"),

System.Net.IPAddress.Parse("141.11.65.217"),

},
},
            new IPAddressinetArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("251.6.115.153"),

System.Net.IPAddress.Parse("167.89.83.129"),

System.Net.IPAddress.Parse("181.105.154.193"),

System.Net.IPAddress.Parse("207.152.140.56"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("8.82.100.198"),

System.Net.IPAddress.Parse("241.30.95.186"),

System.Net.IPAddress.Parse("17.139.20.126"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("77.152.137.72"),

System.Net.IPAddress.Parse("112.62.151.206"),

System.Net.IPAddress.Parse("139.1.84.254"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("185.132.76.37"),

System.Net.IPAddress.Parse("173.243.10.222"),

System.Net.IPAddress.Parse("21.243.225.34"),

},
},
            new IPAddressinetArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("37.183.13.72"),

System.Net.IPAddress.Parse("229.143.125.170"),

System.Net.IPAddress.Parse("176.155.195.185"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("98.75.54.232"),

System.Net.IPAddress.Parse("105.147.186.6"),

System.Net.IPAddress.Parse("207.27.45.237"),

System.Net.IPAddress.Parse("133.61.20.82"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("178.69.121.113"),

System.Net.IPAddress.Parse("8.79.167.93"),

System.Net.IPAddress.Parse("236.8.212.244"),

System.Net.IPAddress.Parse("195.167.124.186"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("34.215.231.215"),

System.Net.IPAddress.Parse("187.21.187.178"),

System.Net.IPAddress.Parse("81.94.95.42"),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray2mi(
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
            asPartInterface: typeof(IIPAddressListinetArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Net.IPAddress>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Net.IPAddress>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray2mi(
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
            queryMapTypes: [typeof(IPAddressinetArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Net.IPAddress>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Net.IPAddress>), 
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

                changedRows =  ((IIPAddressListinetArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IIPAddressListinetArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IIPAddressListinetArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressListinetArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IIPAddressListinetArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IIPAddressListinetArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IIPAddressListinetArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IIPAddressListinetArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IIPAddressListinetArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IIPAddressListinetArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IIPAddressListinetArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IIPAddressListinetArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IIPAddressListinetArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IIPAddressListinetArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IIPAddressListinetArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray2m(
	id,
    value,
    nullablevalue,
    ipaddressinetarray2mi_id
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
            asPartInterface: typeof(IIPAddressListinetArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Net.IPAddress>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Net.IPAddress>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "ipaddressinetarray2mi_id", 
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
                changedRows =  ((IIPAddressListinetArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IIPAddressListinetArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IIPAddressListinetArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IIPAddressListinetArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray2m(
	id,
    value,
    nullablevalue,
    ipaddressinetarray2mi_id
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
    ipaddressinetarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(IPAddressinetArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray2m(
	id,
    value,
    nullablevalue,
    ipaddressinetarray2mi_id
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
    ipaddressinetarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(IPAddressinetArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Net.IPAddress>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Net.IPAddress>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "ipaddressinetarray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetArray2M> models = null;

                models =  ((IIPAddressListinetArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IIPAddressListinetArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IIPAddressListinetArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IIPAddressListinetArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetArray2M> models = null;

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetArray2M), typeof(FlatIPAddressinetArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
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
FROM public.ipaddressinetarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinetArray2M>();
                var models2 = new List<FlatIPAddressinetArray2M>();
                await ((IIPAddressListinetArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinetArray2M>();
                var models2 = new List<FlatIPAddressinetArray2M>();
                ((IIPAddressListinetArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
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
FROM public.ipaddressinetarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IIPAddressListinetArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IIPAddressListinetArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray2m m
LEFT JOIN public.ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinetArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
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
                var models = await ((IIPAddressListinetArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IIPAddressListinetArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetArray2M), typeof(FlatIPAddressinetArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
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
FROM public.ipaddressinetarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetArray2M>();
                var models2 = new List<FlatIPAddressinetArray2M>();
                await ((IIPAddressListinetArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetArray2M>();
                var models2 = new List<FlatIPAddressinetArray2M>();
                ((IIPAddressListinetArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
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
FROM public.ipaddressinetarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IIPAddressListinetArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressListinetArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray2m m
LEFT JOIN public.ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(IPAddressinetArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
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
                var models = await ((IIPAddressListinetArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IIPAddressListinetArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetArray2M), typeof(FlatIPAddressinetArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
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
            asPartInterface: typeof(IIPAddressListinetArray)),
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinetArray2M>();
                var models2 = new List<FlatIPAddressinetArray2M>();
                await((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
FROM public.ipaddressinetarray2m m
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray2M>();
                var firstItems2 = new List<FlatIPAddressinetArray2M>();
                var secondItems1 = new List<FlatIPAddressinetArray2M>();
                var secondItems2 = new List<FlatIPAddressinetArray2M>();
                await ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
FROM public.ipaddressinetarray2m m
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray2M>();
                var firstItems2 = new List<FlatIPAddressinetArray2M>();
                var secondItems1 = new List<FlatIPAddressinetArray2M>();
                await ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[28],_testData[29], false);
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinetArray2M>();
                var models2 = new List<FlatIPAddressinetArray2M>();
                ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
FROM public.ipaddressinetarray2m m
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray2M>();
                var firstItems2 = new List<FlatIPAddressinetArray2M>();
                var secondItems1 = new List<FlatIPAddressinetArray2M>();
                var secondItems2 = new List<FlatIPAddressinetArray2M>();
                 ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
FROM public.ipaddressinetarray2m m
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray2M>();
                var firstItems2 = new List<FlatIPAddressinetArray2M>();
                var secondItems1 = new List<FlatIPAddressinetArray2M>();
                 ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
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
            asPartInterface: typeof(IIPAddressListinetArray)),
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray2m m
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[1], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[2], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(models[15],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(models[16],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(models[17],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(models[18],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[19],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[20],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[21],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[22],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[23],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[24],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[25],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[26],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[27],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[29], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray2m m
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray2M>();
                var secondItems1 = new List<FlatIPAddressinetArray2M>();
                var secondItems2 = new List<FlatIPAddressinetArray2M>();
                await ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray2m m
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[15],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[16],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[17],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[18],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[19],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[20],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[21],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[22],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[23],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray2m m
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray2M>();
                var secondItems1 = new List<FlatIPAddressinetArray2M>();
                var secondItems2 = new List<FlatIPAddressinetArray2M>();
                 ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.ipaddressinetarray2m m
LEFT JOIN public.ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinetArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
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
                var models = await((IIPAddressListinetArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[11], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[12], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[13], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[14], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[15], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[16], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[17], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[18], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[19], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[14],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[15],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[16],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[17],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[12], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[13], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[14], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[15], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[16], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[17], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[18], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[19], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[14],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[15],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[16],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[17],_testData[29], false);
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
                var models = ((IIPAddressListinetArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[7], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[8], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[9], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[10], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[11], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[12], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[13], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[14], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[15], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[16], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[17], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[18], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[19], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[14],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[15],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[16],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[17],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[18],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[19],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[20],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[21],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetArray2M), typeof(FlatIPAddressinetArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
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
            asPartInterface: typeof(IIPAddressListinetArray)),
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
            asPartInterface: typeof(IIPAddressListinetArray)),
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetArray2M>();
                var models2 = new List<FlatIPAddressinetArray2M>();
                await((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetarray2m m
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray2M>();
                var firstItems2 = new List<FlatIPAddressinetArray2M>();
                var secondItems1 = new List<FlatIPAddressinetArray2M>();
                var secondItems2 = new List<FlatIPAddressinetArray2M>();
                await ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 32, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[23],_testData[29], false);
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
FROM public.ipaddressinetarray2m m
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray2M>();
                var firstItems2 = new List<FlatIPAddressinetArray2M>();
                var secondItems1 = new List<FlatIPAddressinetArray2M>();
                await ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 13, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[29], false);
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetArray2M>();
                var models2 = new List<FlatIPAddressinetArray2M>();
                ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetarray2m m
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray2M>();
                var firstItems2 = new List<FlatIPAddressinetArray2M>();
                var secondItems1 = new List<FlatIPAddressinetArray2M>();
                var secondItems2 = new List<FlatIPAddressinetArray2M>();
                 ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 58, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[29], false);
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
FROM public.ipaddressinetarray2m m
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray2M>();
                var firstItems2 = new List<FlatIPAddressinetArray2M>();
                var secondItems1 = new List<FlatIPAddressinetArray2M>();
                 ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 21, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
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
            asPartInterface: typeof(IIPAddressListinetArray)),
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
            asPartInterface: typeof(IIPAddressListinetArray)),
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray2m m
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 61, query1, 118, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[15],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[29], false);
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
FROM public.ipaddressinetarray2m m
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray2M>();
                var secondItems1 = new List<FlatIPAddressinetArray2M>();
                var secondItems2 = new List<FlatIPAddressinetArray2M>();
                await ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 21, query1, 118, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray2m m
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 114, query1, 95, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[29], false);
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
FROM public.ipaddressinetarray2m m
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
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray2M>();
                var secondItems1 = new List<FlatIPAddressinetArray2M>();
                var secondItems2 = new List<FlatIPAddressinetArray2M>();
                 ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 71, query1, 135, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[29], false);
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
FROM public.ipaddressinetarray2m m
LEFT JOIN public.ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(IPAddressinetArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
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
            asPartInterface: typeof(IIPAddressListinetArray)),
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
                var models = await((IIPAddressListinetArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 95, 61))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[13], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[14], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[15], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[16], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[17], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[18], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[19], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[14],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[15],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[16],_testData[29], false);
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
                var models = ((IIPAddressListinetArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatch(connection, 21, 13))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[4], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[5], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[6], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[7], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[8], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[9], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[10], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[11], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[12], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[13], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[14], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[15], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[16], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[17], false);
                        IPAddressinetArray2M.AssertModel(models[14],_testData[18], false);
                        IPAddressinetArray2M.AssertModel(models[15],_testData[19], false);
                        IPAddressinetArray2M.AssertModel(models[16],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[17],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[18],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[19],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[20],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[21],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[22],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[23],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[24],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[3], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[4], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[5], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[6], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[7], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[8], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[9], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[10], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[11], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[12], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[13], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[14], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[15], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[16], false);
                        IPAddressinetArray2M.AssertModel(models[14],_testData[17], false);
                        IPAddressinetArray2M.AssertModel(models[15],_testData[18], false);
                        IPAddressinetArray2M.AssertModel(models[16],_testData[19], false);
                        IPAddressinetArray2M.AssertModel(models[17],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[18],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[19],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[20],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[21],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[22],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[23],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[24],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[25],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[26],_testData[29], false);
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
                await using var cmd = await ((IIPAddressListinetArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 13);
                var models = await ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
IPAddressinetArray2M.AssertModel(models[0],_testData[3], false);IPAddressinetArray2M.AssertModel(models[1],_testData[4], false);IPAddressinetArray2M.AssertModel(models[2],_testData[5], false);IPAddressinetArray2M.AssertModel(models[3],_testData[6], false);IPAddressinetArray2M.AssertModel(models[4],_testData[7], false);IPAddressinetArray2M.AssertModel(models[5],_testData[8], false);IPAddressinetArray2M.AssertModel(models[6],_testData[9], false);IPAddressinetArray2M.AssertModel(models[7],_testData[10], false);IPAddressinetArray2M.AssertModel(models[8],_testData[11], false);IPAddressinetArray2M.AssertModel(models[9],_testData[12], false);IPAddressinetArray2M.AssertModel(models[10],_testData[13], false);IPAddressinetArray2M.AssertModel(models[11],_testData[14], false);IPAddressinetArray2M.AssertModel(models[12],_testData[15], false);IPAddressinetArray2M.AssertModel(models[13],_testData[16], false);IPAddressinetArray2M.AssertModel(models[14],_testData[17], false);IPAddressinetArray2M.AssertModel(models[15],_testData[18], false);IPAddressinetArray2M.AssertModel(models[16],_testData[19], false);IPAddressinetArray2M.AssertModel(models[17],_testData[20], false);IPAddressinetArray2M.AssertModel(models[18],_testData[21], false);IPAddressinetArray2M.AssertModel(models[19],_testData[22], false);IPAddressinetArray2M.AssertModel(models[20],_testData[23], false);IPAddressinetArray2M.AssertModel(models[21],_testData[24], false);IPAddressinetArray2M.AssertModel(models[22],_testData[25], false);IPAddressinetArray2M.AssertModel(models[23],_testData[26], false);IPAddressinetArray2M.AssertModel(models[24],_testData[27], false);IPAddressinetArray2M.AssertModel(models[25],_testData[28], false);IPAddressinetArray2M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressListinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 49);
                var models =  ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
IPAddressinetArray2M.AssertModel(models[0],_testData[9], false);IPAddressinetArray2M.AssertModel(models[1],_testData[10], false);IPAddressinetArray2M.AssertModel(models[2],_testData[11], false);IPAddressinetArray2M.AssertModel(models[3],_testData[12], false);IPAddressinetArray2M.AssertModel(models[4],_testData[13], false);IPAddressinetArray2M.AssertModel(models[5],_testData[14], false);IPAddressinetArray2M.AssertModel(models[6],_testData[15], false);IPAddressinetArray2M.AssertModel(models[7],_testData[16], false);IPAddressinetArray2M.AssertModel(models[8],_testData[17], false);IPAddressinetArray2M.AssertModel(models[9],_testData[18], false);IPAddressinetArray2M.AssertModel(models[10],_testData[19], false);IPAddressinetArray2M.AssertModel(models[11],_testData[20], false);IPAddressinetArray2M.AssertModel(models[12],_testData[21], false);IPAddressinetArray2M.AssertModel(models[13],_testData[22], false);IPAddressinetArray2M.AssertModel(models[14],_testData[23], false);IPAddressinetArray2M.AssertModel(models[15],_testData[24], false);IPAddressinetArray2M.AssertModel(models[16],_testData[25], false);IPAddressinetArray2M.AssertModel(models[17],_testData[26], false);IPAddressinetArray2M.AssertModel(models[18],_testData[27], false);IPAddressinetArray2M.AssertModel(models[19],_testData[28], false);IPAddressinetArray2M.AssertModel(models[20],_testData[29], false);
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
FROM public.binary_ipaddressinetarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(IPAddressinetArray2MI),
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
            asPartInterface: typeof(IIPAddressListinetArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<IPAddressinetArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IIPAddressListinetArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinetarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressListinetArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray2MI.AssertModel(actual, expect, false);
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
                await ((IIPAddressListinetArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinetarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((IIPAddressListinetArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(IPAddressinetArray2MI),
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
            asPartInterface: typeof(IIPAddressListinetArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<IPAddressinetArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IIPAddressListinetArray)this).ImportModelInner(connection, importCollection);
                var models = ((IIPAddressListinetArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray2MI.AssertModel(actual, expect, false);
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
                await ((IIPAddressListinetArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IIPAddressListinetArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
ipaddressinetarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(IPAddressinetArray2M),
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
            asPartInterface: typeof(IIPAddressListinetArray))]
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
FROM public.binary_ipaddressinetarray2m m
LEFT JOIN public.binary_ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(IPAddressinetArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<IPAddressinetArray2M>(15);

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
                ((IIPAddressListinetArray)this).ImportModel(connection, importCollection);
                var models = ((IIPAddressListinetArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                IPAddressinetArray2M.AssertModel(models[0],_testData[0], false);
                IPAddressinetArray2M.AssertModel(models[1],_testData[1], false);
                IPAddressinetArray2M.AssertModel(models[2],_testData[2], false);
                IPAddressinetArray2M.AssertModel(models[3],_testData[3], false);
                IPAddressinetArray2M.AssertModel(models[4],_testData[4], false);
                IPAddressinetArray2M.AssertModel(models[5],_testData[5], false);
                IPAddressinetArray2M.AssertModel(models[6],_testData[6], false);
                IPAddressinetArray2M.AssertModel(models[7],_testData[7], false);
                IPAddressinetArray2M.AssertModel(models[8],_testData[8], false);
                IPAddressinetArray2M.AssertModel(models[9],_testData[9], false);
                IPAddressinetArray2M.AssertModel(models[10],_testData[10], false);
                IPAddressinetArray2M.AssertModel(models[11],_testData[11], false);
                IPAddressinetArray2M.AssertModel(models[12],_testData[12], false);
                IPAddressinetArray2M.AssertModel(models[13],_testData[13], false);
                IPAddressinetArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IIPAddressListinetArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IIPAddressListinetArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                IPAddressinetArray2M.AssertModel(models[0],_testData[0], false);
                IPAddressinetArray2M.AssertModel(models[1],_testData[1], false);
                IPAddressinetArray2M.AssertModel(models[2],_testData[2], false);
                IPAddressinetArray2M.AssertModel(models[3],_testData[3], false);
                IPAddressinetArray2M.AssertModel(models[4],_testData[4], false);
                IPAddressinetArray2M.AssertModel(models[5],_testData[5], false);
                IPAddressinetArray2M.AssertModel(models[6],_testData[6], false);
                IPAddressinetArray2M.AssertModel(models[7],_testData[7], false);
                IPAddressinetArray2M.AssertModel(models[8],_testData[8], false);
                IPAddressinetArray2M.AssertModel(models[9],_testData[9], false);
                IPAddressinetArray2M.AssertModel(models[10],_testData[10], false);
                IPAddressinetArray2M.AssertModel(models[11],_testData[11], false);
                IPAddressinetArray2M.AssertModel(models[12],_testData[12], false);
                IPAddressinetArray2M.AssertModel(models[13],_testData[13], false);
                IPAddressinetArray2M.AssertModel(models[14],_testData[14], false);
                IPAddressinetArray2M.AssertModel(models[15],_testData[15], false);
                IPAddressinetArray2M.AssertModel(models[16],_testData[16], false);
                IPAddressinetArray2M.AssertModel(models[17],_testData[17], false);
                IPAddressinetArray2M.AssertModel(models[18],_testData[18], false);
                IPAddressinetArray2M.AssertModel(models[19],_testData[19], false);
                IPAddressinetArray2M.AssertModel(models[20],_testData[20], false);
                IPAddressinetArray2M.AssertModel(models[21],_testData[21], false);
                IPAddressinetArray2M.AssertModel(models[22],_testData[22], false);
                IPAddressinetArray2M.AssertModel(models[23],_testData[23], false);
                IPAddressinetArray2M.AssertModel(models[24],_testData[24], false);
                IPAddressinetArray2M.AssertModel(models[25],_testData[25], false);
                IPAddressinetArray2M.AssertModel(models[26],_testData[26], false);
                IPAddressinetArray2M.AssertModel(models[27],_testData[27], false);
                IPAddressinetArray2M.AssertModel(models[28],_testData[28], false);
                IPAddressinetArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    ipaddressinetarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(IPAddressinetArray2M)],
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
            asPartInterface: typeof(IIPAddressListinetArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IIPAddressListinetArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    IPAddressinetArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressListinetArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    IPAddressinetArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray2MI)],
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
            asPartInterface: typeof(IIPAddressListinetArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IIPAddressListinetArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressListinetArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

