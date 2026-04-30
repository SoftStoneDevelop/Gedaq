

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
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("137.160.206.19"),

System.Net.IPAddress.Parse("137.164.132.79"),

System.Net.IPAddress.Parse("83.24.106.129"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("149.132.144.143"),

System.Net.IPAddress.Parse("96.217.226.81"),

System.Net.IPAddress.Parse("32.1.202.23"),

System.Net.IPAddress.Parse("151.67.3.32"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("89.122.222.225"),

System.Net.IPAddress.Parse("151.195.170.91"),

System.Net.IPAddress.Parse("147.109.6.13"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("76.68.239.155"),

System.Net.IPAddress.Parse("121.101.117.212"),

System.Net.IPAddress.Parse("130.46.241.215"),

},
},
            new IPAddressinetArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("17.109.210.38"),

System.Net.IPAddress.Parse("171.92.11.168"),

System.Net.IPAddress.Parse("132.42.41.181"),

System.Net.IPAddress.Parse("196.158.165.161"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("118.66.101.121"),

System.Net.IPAddress.Parse("176.171.5.50"),

System.Net.IPAddress.Parse("71.123.109.4"),

System.Net.IPAddress.Parse("115.134.70.208"),

},
},
            new IPAddressinetArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("117.115.18.147"),

System.Net.IPAddress.Parse("226.156.240.145"),

System.Net.IPAddress.Parse("109.65.47.114"),

System.Net.IPAddress.Parse("55.178.152.246"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("110.145.229.223"),

System.Net.IPAddress.Parse("130.191.48.20"),

System.Net.IPAddress.Parse("28.199.48.115"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("40.156.254.198"),

System.Net.IPAddress.Parse("0.51.176.93"),

System.Net.IPAddress.Parse("172.85.173.213"),

System.Net.IPAddress.Parse("229.10.100.0"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("93.159.189.196"),

System.Net.IPAddress.Parse("220.68.115.91"),

System.Net.IPAddress.Parse("166.127.68.89"),

System.Net.IPAddress.Parse("149.208.45.131"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("207.218.46.134"),

System.Net.IPAddress.Parse("142.227.36.242"),

System.Net.IPAddress.Parse("206.4.131.27"),

System.Net.IPAddress.Parse("246.254.206.231"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("252.103.55.39"),

System.Net.IPAddress.Parse("91.65.29.33"),

System.Net.IPAddress.Parse("119.216.70.161"),

System.Net.IPAddress.Parse("77.183.72.248"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("196.146.43.202"),

System.Net.IPAddress.Parse("97.22.131.121"),

System.Net.IPAddress.Parse("167.213.47.86"),

System.Net.IPAddress.Parse("46.44.12.131"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("143.0.63.234"),

System.Net.IPAddress.Parse("150.196.19.107"),

System.Net.IPAddress.Parse("1.18.76.181"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("213.108.107.147"),

System.Net.IPAddress.Parse("144.53.63.187"),

System.Net.IPAddress.Parse("105.251.187.172"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("177.81.51.61"),

System.Net.IPAddress.Parse("81.51.146.191"),

System.Net.IPAddress.Parse("52.195.142.249"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("1.249.203.232"),

System.Net.IPAddress.Parse("63.108.142.87"),

System.Net.IPAddress.Parse("180.13.220.45"),

System.Net.IPAddress.Parse("33.44.58.230"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("65.165.24.185"),

System.Net.IPAddress.Parse("241.213.105.187"),

System.Net.IPAddress.Parse("191.86.110.20"),

},
},
            new IPAddressinetArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("179.68.191.63"),

System.Net.IPAddress.Parse("174.116.95.39"),

System.Net.IPAddress.Parse("41.184.86.161"),

System.Net.IPAddress.Parse("131.97.107.74"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("76.241.98.30"),

System.Net.IPAddress.Parse("104.0.201.5"),

System.Net.IPAddress.Parse("204.116.250.181"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("189.130.211.165"),

System.Net.IPAddress.Parse("25.92.217.108"),

System.Net.IPAddress.Parse("143.109.94.199"),

System.Net.IPAddress.Parse("84.10.106.49"),

},
},
            new IPAddressinetArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("242.114.236.167"),

System.Net.IPAddress.Parse("15.126.240.69"),

System.Net.IPAddress.Parse("188.220.76.245"),

System.Net.IPAddress.Parse("148.62.29.207"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("81.31.35.58"),

System.Net.IPAddress.Parse("2.16.8.247"),

System.Net.IPAddress.Parse("171.85.190.167"),

System.Net.IPAddress.Parse("215.20.171.62"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("155.175.123.116"),

System.Net.IPAddress.Parse("38.119.237.92"),

System.Net.IPAddress.Parse("203.134.161.85"),

System.Net.IPAddress.Parse("215.120.7.53"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("164.185.160.62"),

System.Net.IPAddress.Parse("186.216.88.134"),

System.Net.IPAddress.Parse("211.245.32.191"),

System.Net.IPAddress.Parse("12.46.107.228"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("233.26.221.184"),

System.Net.IPAddress.Parse("115.190.188.205"),

System.Net.IPAddress.Parse("167.91.185.113"),

System.Net.IPAddress.Parse("52.154.86.246"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("176.76.217.168"),

System.Net.IPAddress.Parse("25.73.143.16"),

System.Net.IPAddress.Parse("84.124.18.229"),

System.Net.IPAddress.Parse("213.58.211.40"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("100.34.61.50"),

System.Net.IPAddress.Parse("51.99.190.116"),

System.Net.IPAddress.Parse("212.131.18.72"),

System.Net.IPAddress.Parse("35.174.11.107"),

},
},
            new IPAddressinetArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("145.95.245.170"),

System.Net.IPAddress.Parse("116.224.252.46"),

System.Net.IPAddress.Parse("6.23.114.91"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("240.7.170.56"),

System.Net.IPAddress.Parse("158.98.156.201"),

System.Net.IPAddress.Parse("226.116.79.201"),

System.Net.IPAddress.Parse("138.0.113.152"),

},
},
            new IPAddressinetArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("100.156.215.58"),

System.Net.IPAddress.Parse("128.35.69.62"),

System.Net.IPAddress.Parse("163.207.49.21"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("96.142.146.50"),

System.Net.IPAddress.Parse("235.42.89.141"),

System.Net.IPAddress.Parse("116.179.241.91"),

System.Net.IPAddress.Parse("51.189.81.248"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("18.211.23.208"),

System.Net.IPAddress.Parse("62.45.112.38"),

System.Net.IPAddress.Parse("155.49.224.151"),

},
},
            new IPAddressinetArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("124.237.88.153"),

System.Net.IPAddress.Parse("157.230.171.191"),

System.Net.IPAddress.Parse("25.242.35.154"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("34.216.239.103"),

System.Net.IPAddress.Parse("174.110.105.101"),

System.Net.IPAddress.Parse("109.47.199.109"),

},
},
            new IPAddressinetArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("157.102.139.141"),

System.Net.IPAddress.Parse("60.10.23.38"),

System.Net.IPAddress.Parse("68.120.169.83"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("144.160.133.33"),

System.Net.IPAddress.Parse("135.245.194.9"),

System.Net.IPAddress.Parse("160.152.36.119"),

System.Net.IPAddress.Parse("189.162.133.39"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("24.147.211.11"),

System.Net.IPAddress.Parse("142.162.228.228"),

System.Net.IPAddress.Parse("3.219.222.237"),

System.Net.IPAddress.Parse("126.12.168.182"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("54.195.23.26"),

System.Net.IPAddress.Parse("91.133.130.91"),

System.Net.IPAddress.Parse("184.31.118.182"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("235.11.108.140"),

System.Net.IPAddress.Parse("207.228.82.91"),

System.Net.IPAddress.Parse("151.173.247.47"),

System.Net.IPAddress.Parse("54.178.251.67"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("135.175.100.75"),

System.Net.IPAddress.Parse("136.212.242.71"),

System.Net.IPAddress.Parse("20.171.196.117"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("215.174.146.62"),

System.Net.IPAddress.Parse("221.181.29.10"),

System.Net.IPAddress.Parse("11.9.119.7"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.242.68.77"),

System.Net.IPAddress.Parse("173.232.50.211"),

System.Net.IPAddress.Parse("27.193.129.10"),

System.Net.IPAddress.Parse("76.240.0.177"),

},
},
            new IPAddressinetArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("208.218.208.17"),

System.Net.IPAddress.Parse("71.239.224.136"),

System.Net.IPAddress.Parse("121.202.224.111"),

System.Net.IPAddress.Parse("236.87.37.132"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("76.20.127.78"),

System.Net.IPAddress.Parse("125.54.40.62"),

System.Net.IPAddress.Parse("38.60.132.229"),

System.Net.IPAddress.Parse("23.18.131.61"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("112.69.170.156"),

System.Net.IPAddress.Parse("47.207.178.22"),

System.Net.IPAddress.Parse("87.240.152.221"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("115.112.132.111"),

System.Net.IPAddress.Parse("76.254.210.43"),

System.Net.IPAddress.Parse("244.241.195.194"),

System.Net.IPAddress.Parse("3.72.246.162"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("250.161.41.164"),

System.Net.IPAddress.Parse("181.111.168.198"),

System.Net.IPAddress.Parse("87.56.161.149"),

System.Net.IPAddress.Parse("225.80.223.99"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("165.49.143.125"),

System.Net.IPAddress.Parse("241.76.126.221"),

System.Net.IPAddress.Parse("121.242.220.21"),

},
},
            new IPAddressinetArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("227.151.97.141"),

System.Net.IPAddress.Parse("202.252.87.11"),

System.Net.IPAddress.Parse("164.153.19.48"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("189.45.193.210"),

System.Net.IPAddress.Parse("40.98.19.22"),

System.Net.IPAddress.Parse("45.185.100.199"),

System.Net.IPAddress.Parse("20.174.9.27"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("221.5.103.96"),

System.Net.IPAddress.Parse("1.246.132.233"),

System.Net.IPAddress.Parse("73.215.9.102"),

System.Net.IPAddress.Parse("213.110.247.160"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("140.130.104.197"),

System.Net.IPAddress.Parse("150.238.211.125"),

System.Net.IPAddress.Parse("46.244.108.189"),

System.Net.IPAddress.Parse("146.223.231.45"),

},
},
            new IPAddressinetArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("21.2.61.144"),

System.Net.IPAddress.Parse("91.151.45.190"),

System.Net.IPAddress.Parse("222.167.37.60"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("179.218.149.57"),

System.Net.IPAddress.Parse("37.76.25.171"),

System.Net.IPAddress.Parse("231.148.235.187"),

System.Net.IPAddress.Parse("226.208.147.92"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("106.175.147.79"),

System.Net.IPAddress.Parse("193.155.101.12"),

System.Net.IPAddress.Parse("171.144.7.223"),

System.Net.IPAddress.Parse("55.168.234.191"),

},
},
            new IPAddressinetArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("233.138.120.168"),

System.Net.IPAddress.Parse("55.29.92.115"),

System.Net.IPAddress.Parse("177.242.87.155"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("82.15.199.231"),

System.Net.IPAddress.Parse("196.120.148.248"),

System.Net.IPAddress.Parse("242.3.222.4"),

System.Net.IPAddress.Parse("247.142.37.55"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.206.14.201"),

System.Net.IPAddress.Parse("65.78.96.199"),

System.Net.IPAddress.Parse("197.236.64.223"),

System.Net.IPAddress.Parse("164.51.253.208"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("47.95.200.141"),

System.Net.IPAddress.Parse("49.215.89.30"),

System.Net.IPAddress.Parse("148.154.180.107"),

System.Net.IPAddress.Parse("211.123.7.33"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.59.158.251"),

System.Net.IPAddress.Parse("217.175.40.30"),

System.Net.IPAddress.Parse("112.191.129.181"),

System.Net.IPAddress.Parse("151.6.251.210"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("89.246.149.229"),

System.Net.IPAddress.Parse("214.15.232.196"),

System.Net.IPAddress.Parse("183.81.41.63"),

System.Net.IPAddress.Parse("89.136.138.247"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("6.24.80.40"),

System.Net.IPAddress.Parse("194.11.20.80"),

System.Net.IPAddress.Parse("254.94.32.147"),

System.Net.IPAddress.Parse("248.89.174.151"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("171.197.246.69"),

System.Net.IPAddress.Parse("71.239.47.222"),

System.Net.IPAddress.Parse("121.126.183.198"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("174.181.251.39"),

System.Net.IPAddress.Parse("188.183.5.173"),

System.Net.IPAddress.Parse("58.105.203.12"),

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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[29], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[24],_testData[29], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[29], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(models[15],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[16],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[17],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[18],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[19],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[20],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[21],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[22],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[23],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[24],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[25],_testData[29], false);
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
                parametr1.Value = 24;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[22],_testData[29], false);
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
                parametr1.Value = 24;
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[15],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[16],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[17],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[18],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[19],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[20],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[21],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[22],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[15],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[16],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[17],_testData[29], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[26],_testData[29], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[18], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[19], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[29], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 61, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[29], false);
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
                await ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 24, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[29], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 24, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[29], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 144, query1, 44, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[29], false);
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 144, query1, 111, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[29], false);
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
                await ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 61, query1, 118, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[29], false);
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 85, query1, 16, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(models[15],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[16],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[17],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[18],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[19],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[20],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[21],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[22],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[23],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[24],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[25],_testData[29], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 128, query1, 44, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[29], false);
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 51, 103))
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatch(connection, 109, 3))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[1], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[2], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[3], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[4], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[5], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[6], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[7], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[8], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[9], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[10], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[11], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[12], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[13], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[14], false);
                        IPAddressinetArray2M.AssertModel(models[14],_testData[15], false);
                        IPAddressinetArray2M.AssertModel(models[15],_testData[16], false);
                        IPAddressinetArray2M.AssertModel(models[16],_testData[17], false);
                        IPAddressinetArray2M.AssertModel(models[17],_testData[18], false);
                        IPAddressinetArray2M.AssertModel(models[18],_testData[19], false);
                        IPAddressinetArray2M.AssertModel(models[19],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[20],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[21],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[22],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[23],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[24],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[25],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[26],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[27],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[28],_testData[29], false);
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
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 91);
                var models = await ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
IPAddressinetArray2M.AssertModel(models[0],_testData[18], false);IPAddressinetArray2M.AssertModel(models[1],_testData[19], false);IPAddressinetArray2M.AssertModel(models[2],_testData[20], false);IPAddressinetArray2M.AssertModel(models[3],_testData[21], false);IPAddressinetArray2M.AssertModel(models[4],_testData[22], false);IPAddressinetArray2M.AssertModel(models[5],_testData[23], false);IPAddressinetArray2M.AssertModel(models[6],_testData[24], false);IPAddressinetArray2M.AssertModel(models[7],_testData[25], false);IPAddressinetArray2M.AssertModel(models[8],_testData[26], false);IPAddressinetArray2M.AssertModel(models[9],_testData[27], false);IPAddressinetArray2M.AssertModel(models[10],_testData[28], false);IPAddressinetArray2M.AssertModel(models[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressListinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 144);
                var models =  ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
IPAddressinetArray2M.AssertModel(models[0],_testData[28], false);IPAddressinetArray2M.AssertModel(models[1],_testData[29], false);
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
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(IPAddressinetArray2MIWA),
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
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetArray2MIWA>(2);
                for (int i = 0; i < 6; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressListinetArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinetarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IIPAddressListinetArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetArray2MIWA>(2);
                for (int i = 4; i < 10; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressListinetArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinetarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressListinetArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray2MIWA.AssertModel(actual, expect, false);
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
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetArray2MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IIPAddressListinetArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IIPAddressListinetArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetArray2MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IIPAddressListinetArray)this).ImportModelInner(connection, importCollection);
                var models = ((IIPAddressListinetArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

