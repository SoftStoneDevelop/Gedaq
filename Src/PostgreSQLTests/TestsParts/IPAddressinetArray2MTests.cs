

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
System.Net.IPAddress.Parse("46.80.41.22"),

System.Net.IPAddress.Parse("147.57.242.13"),

System.Net.IPAddress.Parse("181.40.212.158"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("38.149.99.30"),

System.Net.IPAddress.Parse("44.246.197.35"),

System.Net.IPAddress.Parse("108.145.156.154"),

System.Net.IPAddress.Parse("129.145.212.145"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("25.86.225.62"),

System.Net.IPAddress.Parse("199.248.17.66"),

System.Net.IPAddress.Parse("99.225.111.135"),

System.Net.IPAddress.Parse("142.65.151.49"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("7.1.227.162"),

System.Net.IPAddress.Parse("108.203.213.198"),

System.Net.IPAddress.Parse("71.224.170.100"),

System.Net.IPAddress.Parse("148.19.65.59"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("13.54.63.202"),

System.Net.IPAddress.Parse("126.238.110.93"),

System.Net.IPAddress.Parse("169.79.8.25"),

System.Net.IPAddress.Parse("117.89.53.68"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("120.64.121.63"),

System.Net.IPAddress.Parse("94.97.246.250"),

System.Net.IPAddress.Parse("239.190.49.160"),

},
},
            new IPAddressinetArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("164.114.51.213"),

System.Net.IPAddress.Parse("81.6.101.188"),

System.Net.IPAddress.Parse("102.202.31.225"),

System.Net.IPAddress.Parse("44.170.72.176"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("63.115.100.244"),

System.Net.IPAddress.Parse("119.120.219.116"),

System.Net.IPAddress.Parse("153.196.147.226"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("244.46.119.209"),

System.Net.IPAddress.Parse("40.235.29.152"),

System.Net.IPAddress.Parse("49.208.143.190"),

System.Net.IPAddress.Parse("207.57.9.18"),

},
},
            new IPAddressinetArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("102.235.142.206"),

System.Net.IPAddress.Parse("72.39.38.76"),

System.Net.IPAddress.Parse("187.138.174.204"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("161.34.26.48"),

System.Net.IPAddress.Parse("177.246.115.158"),

System.Net.IPAddress.Parse("180.105.168.183"),

System.Net.IPAddress.Parse("159.203.61.182"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("198.179.157.136"),

System.Net.IPAddress.Parse("90.26.167.140"),

System.Net.IPAddress.Parse("154.159.28.78"),

System.Net.IPAddress.Parse("196.239.114.18"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("40.193.166.161"),

System.Net.IPAddress.Parse("114.181.173.215"),

System.Net.IPAddress.Parse("81.239.136.22"),

System.Net.IPAddress.Parse("138.166.53.21"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("235.72.247.55"),

System.Net.IPAddress.Parse("5.21.35.39"),

System.Net.IPAddress.Parse("177.193.152.58"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.90.69.181"),

System.Net.IPAddress.Parse("15.184.137.60"),

System.Net.IPAddress.Parse("103.61.94.110"),

System.Net.IPAddress.Parse("131.12.143.51"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("192.179.90.146"),

System.Net.IPAddress.Parse("168.232.29.93"),

System.Net.IPAddress.Parse("176.253.215.160"),

System.Net.IPAddress.Parse("80.252.45.21"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("113.52.95.115"),

System.Net.IPAddress.Parse("26.59.44.188"),

System.Net.IPAddress.Parse("28.82.242.101"),

System.Net.IPAddress.Parse("100.92.227.6"),

},
},
            new IPAddressinetArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("82.229.52.86"),

System.Net.IPAddress.Parse("200.35.88.227"),

System.Net.IPAddress.Parse("154.129.94.26"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("92.99.21.150"),

System.Net.IPAddress.Parse("242.131.220.104"),

System.Net.IPAddress.Parse("115.29.8.56"),

System.Net.IPAddress.Parse("156.121.178.118"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("203.140.11.179"),

System.Net.IPAddress.Parse("153.224.151.167"),

System.Net.IPAddress.Parse("228.175.60.107"),

System.Net.IPAddress.Parse("223.160.220.76"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("217.68.227.26"),

System.Net.IPAddress.Parse("20.166.215.10"),

System.Net.IPAddress.Parse("94.233.195.35"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("102.195.236.136"),

System.Net.IPAddress.Parse("170.218.49.224"),

System.Net.IPAddress.Parse("238.188.174.178"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("117.120.150.30"),

System.Net.IPAddress.Parse("23.17.60.46"),

System.Net.IPAddress.Parse("53.115.84.152"),

System.Net.IPAddress.Parse("6.192.36.137"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("6.129.38.144"),

System.Net.IPAddress.Parse("223.148.72.24"),

System.Net.IPAddress.Parse("138.189.23.146"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("126.142.53.20"),

System.Net.IPAddress.Parse("169.55.189.100"),

System.Net.IPAddress.Parse("180.155.206.133"),

System.Net.IPAddress.Parse("180.134.27.193"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("30.114.250.200"),

System.Net.IPAddress.Parse("22.204.61.180"),

System.Net.IPAddress.Parse("23.134.237.68"),

System.Net.IPAddress.Parse("209.137.93.37"),

},
},
            new IPAddressinetArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("146.26.117.88"),

System.Net.IPAddress.Parse("54.3.157.217"),

System.Net.IPAddress.Parse("231.187.128.17"),

System.Net.IPAddress.Parse("207.187.88.105"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("41.16.234.239"),

System.Net.IPAddress.Parse("7.190.92.223"),

System.Net.IPAddress.Parse("211.48.19.20"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("191.143.133.116"),

System.Net.IPAddress.Parse("235.13.74.92"),

System.Net.IPAddress.Parse("23.220.146.211"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("142.238.95.223"),

System.Net.IPAddress.Parse("232.105.215.34"),

System.Net.IPAddress.Parse("187.98.144.108"),

System.Net.IPAddress.Parse("62.171.30.217"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("198.54.174.79"),

System.Net.IPAddress.Parse("204.116.156.11"),

System.Net.IPAddress.Parse("172.15.10.243"),

System.Net.IPAddress.Parse("138.51.161.193"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("23.39.85.247"),

System.Net.IPAddress.Parse("6.181.101.103"),

System.Net.IPAddress.Parse("59.238.45.136"),

},
},
            new IPAddressinetArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("147.139.170.183"),

System.Net.IPAddress.Parse("51.118.43.38"),

System.Net.IPAddress.Parse("8.78.119.108"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("47.239.105.82"),

System.Net.IPAddress.Parse("21.226.205.125"),

System.Net.IPAddress.Parse("158.240.76.222"),

},
},
            new IPAddressinetArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("150.133.153.217"),

System.Net.IPAddress.Parse("36.217.74.195"),

System.Net.IPAddress.Parse("143.76.205.110"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("23.22.33.1"),

System.Net.IPAddress.Parse("74.63.67.69"),

System.Net.IPAddress.Parse("54.92.68.215"),

System.Net.IPAddress.Parse("11.124.44.142"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("59.57.40.178"),

System.Net.IPAddress.Parse("108.206.113.245"),

System.Net.IPAddress.Parse("247.5.110.28"),

System.Net.IPAddress.Parse("240.33.41.60"),

},
},
            new IPAddressinetArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("208.209.113.39"),

System.Net.IPAddress.Parse("170.152.135.243"),

System.Net.IPAddress.Parse("213.172.32.123"),

System.Net.IPAddress.Parse("203.104.36.96"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("172.72.214.137"),

System.Net.IPAddress.Parse("8.235.40.205"),

System.Net.IPAddress.Parse("99.131.18.97"),

},
},
            new IPAddressinetArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.176.157.224"),

System.Net.IPAddress.Parse("127.146.135.212"),

System.Net.IPAddress.Parse("9.193.9.121"),

System.Net.IPAddress.Parse("108.193.235.177"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("230.199.223.129"),

System.Net.IPAddress.Parse("168.34.74.103"),

System.Net.IPAddress.Parse("242.249.50.90"),

System.Net.IPAddress.Parse("101.103.125.167"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("44.159.41.35"),

System.Net.IPAddress.Parse("239.38.163.163"),

System.Net.IPAddress.Parse("20.79.67.191"),

},
},
            new IPAddressinetArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("240.77.170.194"),

System.Net.IPAddress.Parse("252.162.103.171"),

System.Net.IPAddress.Parse("40.210.237.177"),

System.Net.IPAddress.Parse("117.89.30.104"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("29.249.74.220"),

System.Net.IPAddress.Parse("132.232.228.68"),

System.Net.IPAddress.Parse("38.195.194.65"),

System.Net.IPAddress.Parse("236.13.161.28"),

},
},
            new IPAddressinetArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("135.89.180.13"),

System.Net.IPAddress.Parse("73.57.252.31"),

System.Net.IPAddress.Parse("125.236.130.137"),

System.Net.IPAddress.Parse("232.163.105.93"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("226.188.43.235"),

System.Net.IPAddress.Parse("246.139.224.232"),

System.Net.IPAddress.Parse("179.90.238.33"),

System.Net.IPAddress.Parse("67.155.20.89"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("202.50.224.136"),

System.Net.IPAddress.Parse("162.164.38.80"),

System.Net.IPAddress.Parse("3.187.118.138"),

},
},
            new IPAddressinetArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("254.55.157.222"),

System.Net.IPAddress.Parse("70.143.239.120"),

System.Net.IPAddress.Parse("183.89.34.13"),

System.Net.IPAddress.Parse("20.139.154.134"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("184.176.136.2"),

System.Net.IPAddress.Parse("114.254.216.114"),

System.Net.IPAddress.Parse("114.169.34.179"),

System.Net.IPAddress.Parse("120.133.173.173"),

},
},
            new IPAddressinetArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("117.207.167.121"),

System.Net.IPAddress.Parse("107.36.2.42"),

System.Net.IPAddress.Parse("198.116.9.252"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("185.63.24.137"),

System.Net.IPAddress.Parse("2.50.150.225"),

System.Net.IPAddress.Parse("62.163.25.99"),

System.Net.IPAddress.Parse("241.125.11.243"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("179.245.12.107"),

System.Net.IPAddress.Parse("22.159.167.62"),

System.Net.IPAddress.Parse("0.183.61.186"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("212.12.84.211"),

System.Net.IPAddress.Parse("153.142.148.33"),

System.Net.IPAddress.Parse("27.220.123.93"),

System.Net.IPAddress.Parse("138.125.223.149"),

},
},
            new IPAddressinetArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("166.210.254.243"),

System.Net.IPAddress.Parse("17.20.236.124"),

System.Net.IPAddress.Parse("32.48.116.253"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("102.29.11.178"),

System.Net.IPAddress.Parse("22.200.131.96"),

System.Net.IPAddress.Parse("109.250.50.190"),

System.Net.IPAddress.Parse("220.38.242.40"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("223.91.241.203"),

System.Net.IPAddress.Parse("236.161.225.235"),

System.Net.IPAddress.Parse("106.96.100.97"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("124.57.9.196"),

System.Net.IPAddress.Parse("69.167.162.149"),

System.Net.IPAddress.Parse("191.17.109.97"),

System.Net.IPAddress.Parse("232.158.43.121"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("112.30.225.145"),

System.Net.IPAddress.Parse("211.156.127.44"),

System.Net.IPAddress.Parse("181.97.96.62"),

},
},
            new IPAddressinetArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("86.225.92.83"),

System.Net.IPAddress.Parse("192.230.214.67"),

System.Net.IPAddress.Parse("174.238.250.92"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("30.171.102.253"),

System.Net.IPAddress.Parse("56.61.172.171"),

System.Net.IPAddress.Parse("82.145.5.95"),

},
},
            new IPAddressinetArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("27.110.117.132"),

System.Net.IPAddress.Parse("227.235.114.46"),

System.Net.IPAddress.Parse("191.226.216.93"),

System.Net.IPAddress.Parse("184.85.241.104"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("121.128.70.241"),

System.Net.IPAddress.Parse("197.51.76.39"),

System.Net.IPAddress.Parse("102.102.41.184"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("59.88.32.148"),

System.Net.IPAddress.Parse("171.205.174.245"),

System.Net.IPAddress.Parse("104.160.171.127"),

System.Net.IPAddress.Parse("37.206.246.63"),

},
},
            new IPAddressinetArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("16.238.123.143"),

System.Net.IPAddress.Parse("122.130.7.8"),

System.Net.IPAddress.Parse("218.92.199.121"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("54.172.93.206"),

System.Net.IPAddress.Parse("127.30.186.209"),

System.Net.IPAddress.Parse("164.42.15.192"),

System.Net.IPAddress.Parse("43.14.28.220"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("3.213.232.200"),

System.Net.IPAddress.Parse("240.146.243.188"),

System.Net.IPAddress.Parse("183.66.234.240"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("8.3.238.28"),

System.Net.IPAddress.Parse("232.55.23.218"),

System.Net.IPAddress.Parse("137.145.140.185"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("250.144.37.39"),

System.Net.IPAddress.Parse("45.120.243.238"),

System.Net.IPAddress.Parse("210.22.133.173"),

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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetArray2M)],
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
LEFT JOIN public.ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
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
LEFT JOIN public.ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IIPAddressListinetArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((IIPAddressListinetArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetArray2M)],
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
LEFT JOIN public.ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
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
LEFT JOIN public.ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IIPAddressListinetArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((IIPAddressListinetArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray2m m
LEFT JOIN public.ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
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
LEFT JOIN public.ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatIPAddressinetArray2M.AssertModel(models[0],_testData[1], false);FlatIPAddressinetArray2M.AssertModel(models[1],_testData[2], false);FlatIPAddressinetArray2M.AssertModel(models[2],_testData[3], false);FlatIPAddressinetArray2M.AssertModel(models[3],_testData[4], false);FlatIPAddressinetArray2M.AssertModel(models[4],_testData[5], false);FlatIPAddressinetArray2M.AssertModel(models[5],_testData[6], false);FlatIPAddressinetArray2M.AssertModel(models[6],_testData[7], false);FlatIPAddressinetArray2M.AssertModel(models[7],_testData[8], false);FlatIPAddressinetArray2M.AssertModel(models[8],_testData[9], false);FlatIPAddressinetArray2M.AssertModel(models[9],_testData[10], false);FlatIPAddressinetArray2M.AssertModel(models[10],_testData[11], false);FlatIPAddressinetArray2M.AssertModel(models[11],_testData[12], false);FlatIPAddressinetArray2M.AssertModel(models[12],_testData[13], false);FlatIPAddressinetArray2M.AssertModel(models[13],_testData[14], false);FlatIPAddressinetArray2M.AssertModel(models[14],_testData[15], false);FlatIPAddressinetArray2M.AssertModel(models[15],_testData[16], false);FlatIPAddressinetArray2M.AssertModel(models[16],_testData[17], false);FlatIPAddressinetArray2M.AssertModel(models[17],_testData[18], false);FlatIPAddressinetArray2M.AssertModel(models[18],_testData[19], false);FlatIPAddressinetArray2M.AssertModel(models[19],_testData[20], false);FlatIPAddressinetArray2M.AssertModel(models[20],_testData[21], false);FlatIPAddressinetArray2M.AssertModel(models[21],_testData[22], false);FlatIPAddressinetArray2M.AssertModel(models[22],_testData[23], false);FlatIPAddressinetArray2M.AssertModel(models[23],_testData[24], false);FlatIPAddressinetArray2M.AssertModel(models[24],_testData[25], false);FlatIPAddressinetArray2M.AssertModel(models[25],_testData[26], false);FlatIPAddressinetArray2M.AssertModel(models[26],_testData[27], false);FlatIPAddressinetArray2M.AssertModel(models[27],_testData[28], false);FlatIPAddressinetArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatIPAddressinetArray2M.AssertModel(models[0],_testData[14], false);FlatIPAddressinetArray2M.AssertModel(models[1],_testData[15], false);FlatIPAddressinetArray2M.AssertModel(models[2],_testData[16], false);FlatIPAddressinetArray2M.AssertModel(models[3],_testData[17], false);FlatIPAddressinetArray2M.AssertModel(models[4],_testData[18], false);FlatIPAddressinetArray2M.AssertModel(models[5],_testData[19], false);FlatIPAddressinetArray2M.AssertModel(models[6],_testData[20], false);FlatIPAddressinetArray2M.AssertModel(models[7],_testData[21], false);FlatIPAddressinetArray2M.AssertModel(models[8],_testData[22], false);FlatIPAddressinetArray2M.AssertModel(models[9],_testData[23], false);FlatIPAddressinetArray2M.AssertModel(models[10],_testData[24], false);FlatIPAddressinetArray2M.AssertModel(models[11],_testData[25], false);FlatIPAddressinetArray2M.AssertModel(models[12],_testData[26], false);FlatIPAddressinetArray2M.AssertModel(models[13],_testData[27], false);FlatIPAddressinetArray2M.AssertModel(models[14],_testData[28], false);FlatIPAddressinetArray2M.AssertModel(models[15],_testData[29], false);
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
FROM public.ipaddressinetarray2m m
LEFT JOIN public.ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray2m m
LEFT JOIN public.ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
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
LEFT JOIN public.ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatIPAddressinetArray2M.AssertModel(models[0],_testData[10], false);FlatIPAddressinetArray2M.AssertModel(models[1],_testData[11], false);FlatIPAddressinetArray2M.AssertModel(models[2],_testData[12], false);FlatIPAddressinetArray2M.AssertModel(models[3],_testData[13], false);FlatIPAddressinetArray2M.AssertModel(models[4],_testData[14], false);FlatIPAddressinetArray2M.AssertModel(models[5],_testData[15], false);FlatIPAddressinetArray2M.AssertModel(models[6],_testData[16], false);FlatIPAddressinetArray2M.AssertModel(models[7],_testData[17], false);FlatIPAddressinetArray2M.AssertModel(models[8],_testData[18], false);FlatIPAddressinetArray2M.AssertModel(models[9],_testData[19], false);FlatIPAddressinetArray2M.AssertModel(models[10],_testData[20], false);FlatIPAddressinetArray2M.AssertModel(models[11],_testData[21], false);FlatIPAddressinetArray2M.AssertModel(models[12],_testData[22], false);FlatIPAddressinetArray2M.AssertModel(models[13],_testData[23], false);FlatIPAddressinetArray2M.AssertModel(models[14],_testData[24], false);FlatIPAddressinetArray2M.AssertModel(models[15],_testData[25], false);FlatIPAddressinetArray2M.AssertModel(models[16],_testData[26], false);FlatIPAddressinetArray2M.AssertModel(models[17],_testData[27], false);FlatIPAddressinetArray2M.AssertModel(models[18],_testData[28], false);FlatIPAddressinetArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatIPAddressinetArray2M.AssertModel(models[0],_testData[4], false);FlatIPAddressinetArray2M.AssertModel(models[1],_testData[5], false);FlatIPAddressinetArray2M.AssertModel(models[2],_testData[6], false);FlatIPAddressinetArray2M.AssertModel(models[3],_testData[7], false);FlatIPAddressinetArray2M.AssertModel(models[4],_testData[8], false);FlatIPAddressinetArray2M.AssertModel(models[5],_testData[9], false);FlatIPAddressinetArray2M.AssertModel(models[6],_testData[10], false);FlatIPAddressinetArray2M.AssertModel(models[7],_testData[11], false);FlatIPAddressinetArray2M.AssertModel(models[8],_testData[12], false);FlatIPAddressinetArray2M.AssertModel(models[9],_testData[13], false);FlatIPAddressinetArray2M.AssertModel(models[10],_testData[14], false);FlatIPAddressinetArray2M.AssertModel(models[11],_testData[15], false);FlatIPAddressinetArray2M.AssertModel(models[12],_testData[16], false);FlatIPAddressinetArray2M.AssertModel(models[13],_testData[17], false);FlatIPAddressinetArray2M.AssertModel(models[14],_testData[18], false);FlatIPAddressinetArray2M.AssertModel(models[15],_testData[19], false);FlatIPAddressinetArray2M.AssertModel(models[16],_testData[20], false);FlatIPAddressinetArray2M.AssertModel(models[17],_testData[21], false);FlatIPAddressinetArray2M.AssertModel(models[18],_testData[22], false);FlatIPAddressinetArray2M.AssertModel(models[19],_testData[23], false);FlatIPAddressinetArray2M.AssertModel(models[20],_testData[24], false);FlatIPAddressinetArray2M.AssertModel(models[21],_testData[25], false);FlatIPAddressinetArray2M.AssertModel(models[22],_testData[26], false);FlatIPAddressinetArray2M.AssertModel(models[23],_testData[27], false);FlatIPAddressinetArray2M.AssertModel(models[24],_testData[28], false);FlatIPAddressinetArray2M.AssertModel(models[25],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((IIPAddressListinetArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
IPAddressinetArray2M.AssertModel(models[0],_testData[17], false);IPAddressinetArray2M.AssertModel(models[1],_testData[18], false);IPAddressinetArray2M.AssertModel(models[2],_testData[19], false);IPAddressinetArray2M.AssertModel(models[3],_testData[20], false);IPAddressinetArray2M.AssertModel(models[4],_testData[21], false);IPAddressinetArray2M.AssertModel(models[5],_testData[22], false);IPAddressinetArray2M.AssertModel(models[6],_testData[23], false);IPAddressinetArray2M.AssertModel(models[7],_testData[24], false);IPAddressinetArray2M.AssertModel(models[8],_testData[25], false);IPAddressinetArray2M.AssertModel(models[9],_testData[26], false);IPAddressinetArray2M.AssertModel(models[10],_testData[27], false);IPAddressinetArray2M.AssertModel(models[11],_testData[28], false);IPAddressinetArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
IPAddressinetArray2M.AssertModel(models[0],_testData[23], false);IPAddressinetArray2M.AssertModel(models[1],_testData[24], false);IPAddressinetArray2M.AssertModel(models[2],_testData[25], false);IPAddressinetArray2M.AssertModel(models[3],_testData[26], false);IPAddressinetArray2M.AssertModel(models[4],_testData[27], false);IPAddressinetArray2M.AssertModel(models[5],_testData[28], false);IPAddressinetArray2M.AssertModel(models[6],_testData[29], false);
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

                var models =  ((IIPAddressListinetArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
IPAddressinetArray2M.AssertModel(models[0],_testData[11], false);IPAddressinetArray2M.AssertModel(models[1],_testData[12], false);IPAddressinetArray2M.AssertModel(models[2],_testData[13], false);IPAddressinetArray2M.AssertModel(models[3],_testData[14], false);IPAddressinetArray2M.AssertModel(models[4],_testData[15], false);IPAddressinetArray2M.AssertModel(models[5],_testData[16], false);IPAddressinetArray2M.AssertModel(models[6],_testData[17], false);IPAddressinetArray2M.AssertModel(models[7],_testData[18], false);IPAddressinetArray2M.AssertModel(models[8],_testData[19], false);IPAddressinetArray2M.AssertModel(models[9],_testData[20], false);IPAddressinetArray2M.AssertModel(models[10],_testData[21], false);IPAddressinetArray2M.AssertModel(models[11],_testData[22], false);IPAddressinetArray2M.AssertModel(models[12],_testData[23], false);IPAddressinetArray2M.AssertModel(models[13],_testData[24], false);IPAddressinetArray2M.AssertModel(models[14],_testData[25], false);IPAddressinetArray2M.AssertModel(models[15],_testData[26], false);IPAddressinetArray2M.AssertModel(models[16],_testData[27], false);IPAddressinetArray2M.AssertModel(models[17],_testData[28], false);IPAddressinetArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
IPAddressinetArray2M.AssertModel(models[0],_testData[9], false);IPAddressinetArray2M.AssertModel(models[1],_testData[10], false);IPAddressinetArray2M.AssertModel(models[2],_testData[11], false);IPAddressinetArray2M.AssertModel(models[3],_testData[12], false);IPAddressinetArray2M.AssertModel(models[4],_testData[13], false);IPAddressinetArray2M.AssertModel(models[5],_testData[14], false);IPAddressinetArray2M.AssertModel(models[6],_testData[15], false);IPAddressinetArray2M.AssertModel(models[7],_testData[16], false);IPAddressinetArray2M.AssertModel(models[8],_testData[17], false);IPAddressinetArray2M.AssertModel(models[9],_testData[18], false);IPAddressinetArray2M.AssertModel(models[10],_testData[19], false);IPAddressinetArray2M.AssertModel(models[11],_testData[20], false);IPAddressinetArray2M.AssertModel(models[12],_testData[21], false);IPAddressinetArray2M.AssertModel(models[13],_testData[22], false);IPAddressinetArray2M.AssertModel(models[14],_testData[23], false);IPAddressinetArray2M.AssertModel(models[15],_testData[24], false);IPAddressinetArray2M.AssertModel(models[16],_testData[25], false);IPAddressinetArray2M.AssertModel(models[17],_testData[26], false);IPAddressinetArray2M.AssertModel(models[18],_testData[27], false);IPAddressinetArray2M.AssertModel(models[19],_testData[28], false);IPAddressinetArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray2m m
LEFT JOIN public.ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
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
LEFT JOIN public.ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 81, query1, 22, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatIPAddressinetArray2M.AssertModel(models[0],_testData[19], false);FlatIPAddressinetArray2M.AssertModel(models[1],_testData[20], false);FlatIPAddressinetArray2M.AssertModel(models[2],_testData[21], false);FlatIPAddressinetArray2M.AssertModel(models[3],_testData[22], false);FlatIPAddressinetArray2M.AssertModel(models[4],_testData[23], false);FlatIPAddressinetArray2M.AssertModel(models[5],_testData[24], false);FlatIPAddressinetArray2M.AssertModel(models[6],_testData[25], false);FlatIPAddressinetArray2M.AssertModel(models[7],_testData[26], false);FlatIPAddressinetArray2M.AssertModel(models[8],_testData[27], false);FlatIPAddressinetArray2M.AssertModel(models[9],_testData[28], false);FlatIPAddressinetArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatIPAddressinetArray2M.AssertModel(models[0],_testData[4], false);FlatIPAddressinetArray2M.AssertModel(models[1],_testData[5], false);FlatIPAddressinetArray2M.AssertModel(models[2],_testData[6], false);FlatIPAddressinetArray2M.AssertModel(models[3],_testData[7], false);FlatIPAddressinetArray2M.AssertModel(models[4],_testData[8], false);FlatIPAddressinetArray2M.AssertModel(models[5],_testData[9], false);FlatIPAddressinetArray2M.AssertModel(models[6],_testData[10], false);FlatIPAddressinetArray2M.AssertModel(models[7],_testData[11], false);FlatIPAddressinetArray2M.AssertModel(models[8],_testData[12], false);FlatIPAddressinetArray2M.AssertModel(models[9],_testData[13], false);FlatIPAddressinetArray2M.AssertModel(models[10],_testData[14], false);FlatIPAddressinetArray2M.AssertModel(models[11],_testData[15], false);FlatIPAddressinetArray2M.AssertModel(models[12],_testData[16], false);FlatIPAddressinetArray2M.AssertModel(models[13],_testData[17], false);FlatIPAddressinetArray2M.AssertModel(models[14],_testData[18], false);FlatIPAddressinetArray2M.AssertModel(models[15],_testData[19], false);FlatIPAddressinetArray2M.AssertModel(models[16],_testData[20], false);FlatIPAddressinetArray2M.AssertModel(models[17],_testData[21], false);FlatIPAddressinetArray2M.AssertModel(models[18],_testData[22], false);FlatIPAddressinetArray2M.AssertModel(models[19],_testData[23], false);FlatIPAddressinetArray2M.AssertModel(models[20],_testData[24], false);FlatIPAddressinetArray2M.AssertModel(models[21],_testData[25], false);FlatIPAddressinetArray2M.AssertModel(models[22],_testData[26], false);FlatIPAddressinetArray2M.AssertModel(models[23],_testData[27], false);FlatIPAddressinetArray2M.AssertModel(models[24],_testData[28], false);FlatIPAddressinetArray2M.AssertModel(models[25],_testData[29], false);
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
FROM public.ipaddressinetarray2m m
LEFT JOIN public.ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray2m m
LEFT JOIN public.ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
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
LEFT JOIN public.ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 30, query1, 83, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatIPAddressinetArray2M.AssertModel(models[0],_testData[6], false);FlatIPAddressinetArray2M.AssertModel(models[1],_testData[7], false);FlatIPAddressinetArray2M.AssertModel(models[2],_testData[8], false);FlatIPAddressinetArray2M.AssertModel(models[3],_testData[9], false);FlatIPAddressinetArray2M.AssertModel(models[4],_testData[10], false);FlatIPAddressinetArray2M.AssertModel(models[5],_testData[11], false);FlatIPAddressinetArray2M.AssertModel(models[6],_testData[12], false);FlatIPAddressinetArray2M.AssertModel(models[7],_testData[13], false);FlatIPAddressinetArray2M.AssertModel(models[8],_testData[14], false);FlatIPAddressinetArray2M.AssertModel(models[9],_testData[15], false);FlatIPAddressinetArray2M.AssertModel(models[10],_testData[16], false);FlatIPAddressinetArray2M.AssertModel(models[11],_testData[17], false);FlatIPAddressinetArray2M.AssertModel(models[12],_testData[18], false);FlatIPAddressinetArray2M.AssertModel(models[13],_testData[19], false);FlatIPAddressinetArray2M.AssertModel(models[14],_testData[20], false);FlatIPAddressinetArray2M.AssertModel(models[15],_testData[21], false);FlatIPAddressinetArray2M.AssertModel(models[16],_testData[22], false);FlatIPAddressinetArray2M.AssertModel(models[17],_testData[23], false);FlatIPAddressinetArray2M.AssertModel(models[18],_testData[24], false);FlatIPAddressinetArray2M.AssertModel(models[19],_testData[25], false);FlatIPAddressinetArray2M.AssertModel(models[20],_testData[26], false);FlatIPAddressinetArray2M.AssertModel(models[21],_testData[27], false);FlatIPAddressinetArray2M.AssertModel(models[22],_testData[28], false);FlatIPAddressinetArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatIPAddressinetArray2M.AssertModel(models[0],_testData[20], false);FlatIPAddressinetArray2M.AssertModel(models[1],_testData[21], false);FlatIPAddressinetArray2M.AssertModel(models[2],_testData[22], false);FlatIPAddressinetArray2M.AssertModel(models[3],_testData[23], false);FlatIPAddressinetArray2M.AssertModel(models[4],_testData[24], false);FlatIPAddressinetArray2M.AssertModel(models[5],_testData[25], false);FlatIPAddressinetArray2M.AssertModel(models[6],_testData[26], false);FlatIPAddressinetArray2M.AssertModel(models[7],_testData[27], false);FlatIPAddressinetArray2M.AssertModel(models[8],_testData[28], false);FlatIPAddressinetArray2M.AssertModel(models[9],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressListinetArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSelectModelBatchAsync(connection, 97, 70))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
IPAddressinetArray2M.AssertModel(models[0],_testData[24], false);IPAddressinetArray2M.AssertModel(models[1],_testData[25], false);IPAddressinetArray2M.AssertModel(models[2],_testData[26], false);IPAddressinetArray2M.AssertModel(models[3],_testData[27], false);IPAddressinetArray2M.AssertModel(models[4],_testData[28], false);IPAddressinetArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
IPAddressinetArray2M.AssertModel(models[0],_testData[16], false);IPAddressinetArray2M.AssertModel(models[1],_testData[17], false);IPAddressinetArray2M.AssertModel(models[2],_testData[18], false);IPAddressinetArray2M.AssertModel(models[3],_testData[19], false);IPAddressinetArray2M.AssertModel(models[4],_testData[20], false);IPAddressinetArray2M.AssertModel(models[5],_testData[21], false);IPAddressinetArray2M.AssertModel(models[6],_testData[22], false);IPAddressinetArray2M.AssertModel(models[7],_testData[23], false);IPAddressinetArray2M.AssertModel(models[8],_testData[24], false);IPAddressinetArray2M.AssertModel(models[9],_testData[25], false);IPAddressinetArray2M.AssertModel(models[10],_testData[26], false);IPAddressinetArray2M.AssertModel(models[11],_testData[27], false);IPAddressinetArray2M.AssertModel(models[12],_testData[28], false);IPAddressinetArray2M.AssertModel(models[13],_testData[29], false);
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
                var models =  ((IIPAddressListinetArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSelectModelBatch(connection, 81, 37))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
IPAddressinetArray2M.AssertModel(models[0],_testData[19], false);IPAddressinetArray2M.AssertModel(models[1],_testData[20], false);IPAddressinetArray2M.AssertModel(models[2],_testData[21], false);IPAddressinetArray2M.AssertModel(models[3],_testData[22], false);IPAddressinetArray2M.AssertModel(models[4],_testData[23], false);IPAddressinetArray2M.AssertModel(models[5],_testData[24], false);IPAddressinetArray2M.AssertModel(models[6],_testData[25], false);IPAddressinetArray2M.AssertModel(models[7],_testData[26], false);IPAddressinetArray2M.AssertModel(models[8],_testData[27], false);IPAddressinetArray2M.AssertModel(models[9],_testData[28], false);IPAddressinetArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
IPAddressinetArray2M.AssertModel(models[0],_testData[9], false);IPAddressinetArray2M.AssertModel(models[1],_testData[10], false);IPAddressinetArray2M.AssertModel(models[2],_testData[11], false);IPAddressinetArray2M.AssertModel(models[3],_testData[12], false);IPAddressinetArray2M.AssertModel(models[4],_testData[13], false);IPAddressinetArray2M.AssertModel(models[5],_testData[14], false);IPAddressinetArray2M.AssertModel(models[6],_testData[15], false);IPAddressinetArray2M.AssertModel(models[7],_testData[16], false);IPAddressinetArray2M.AssertModel(models[8],_testData[17], false);IPAddressinetArray2M.AssertModel(models[9],_testData[18], false);IPAddressinetArray2M.AssertModel(models[10],_testData[19], false);IPAddressinetArray2M.AssertModel(models[11],_testData[20], false);IPAddressinetArray2M.AssertModel(models[12],_testData[21], false);IPAddressinetArray2M.AssertModel(models[13],_testData[22], false);IPAddressinetArray2M.AssertModel(models[14],_testData[23], false);IPAddressinetArray2M.AssertModel(models[15],_testData[24], false);IPAddressinetArray2M.AssertModel(models[16],_testData[25], false);IPAddressinetArray2M.AssertModel(models[17],_testData[26], false);IPAddressinetArray2M.AssertModel(models[18],_testData[27], false);IPAddressinetArray2M.AssertModel(models[19],_testData[28], false);IPAddressinetArray2M.AssertModel(models[20],_testData[29], false);
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
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 81);
                var models = await ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
IPAddressinetArray2M.AssertModel(models[0],_testData[19], false);IPAddressinetArray2M.AssertModel(models[1],_testData[20], false);IPAddressinetArray2M.AssertModel(models[2],_testData[21], false);IPAddressinetArray2M.AssertModel(models[3],_testData[22], false);IPAddressinetArray2M.AssertModel(models[4],_testData[23], false);IPAddressinetArray2M.AssertModel(models[5],_testData[24], false);IPAddressinetArray2M.AssertModel(models[6],_testData[25], false);IPAddressinetArray2M.AssertModel(models[7],_testData[26], false);IPAddressinetArray2M.AssertModel(models[8],_testData[27], false);IPAddressinetArray2M.AssertModel(models[9],_testData[28], false);IPAddressinetArray2M.AssertModel(models[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressListinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 63);
                var models =  ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
IPAddressinetArray2M.AssertModel(models[0],_testData[14], false);IPAddressinetArray2M.AssertModel(models[1],_testData[15], false);IPAddressinetArray2M.AssertModel(models[2],_testData[16], false);IPAddressinetArray2M.AssertModel(models[3],_testData[17], false);IPAddressinetArray2M.AssertModel(models[4],_testData[18], false);IPAddressinetArray2M.AssertModel(models[5],_testData[19], false);IPAddressinetArray2M.AssertModel(models[6],_testData[20], false);IPAddressinetArray2M.AssertModel(models[7],_testData[21], false);IPAddressinetArray2M.AssertModel(models[8],_testData[22], false);IPAddressinetArray2M.AssertModel(models[9],_testData[23], false);IPAddressinetArray2M.AssertModel(models[10],_testData[24], false);IPAddressinetArray2M.AssertModel(models[11],_testData[25], false);IPAddressinetArray2M.AssertModel(models[12],_testData[26], false);IPAddressinetArray2M.AssertModel(models[13],_testData[27], false);IPAddressinetArray2M.AssertModel(models[14],_testData[28], false);IPAddressinetArray2M.AssertModel(models[15],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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

