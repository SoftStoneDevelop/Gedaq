

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
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("167.171.136.130"),

System.Net.IPAddress.Parse("211.109.144.165"),

System.Net.IPAddress.Parse("65.21.55.129"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("229.204.212.118"),

System.Net.IPAddress.Parse("32.228.135.33"),

System.Net.IPAddress.Parse("28.121.151.108"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("193.63.229.12"),

System.Net.IPAddress.Parse("160.38.174.36"),

System.Net.IPAddress.Parse("169.166.71.100"),

System.Net.IPAddress.Parse("219.37.192.145"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("93.91.109.68"),

System.Net.IPAddress.Parse("183.5.225.35"),

System.Net.IPAddress.Parse("24.140.116.19"),

System.Net.IPAddress.Parse("218.156.86.156"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("196.174.140.181"),

System.Net.IPAddress.Parse("122.122.13.99"),

System.Net.IPAddress.Parse("151.20.9.54"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("12.61.181.181"),

System.Net.IPAddress.Parse("195.171.194.14"),

System.Net.IPAddress.Parse("196.175.94.107"),

System.Net.IPAddress.Parse("223.209.131.174"),

},
},
            new IPAddressinetArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("61.250.108.158"),

System.Net.IPAddress.Parse("218.50.206.156"),

System.Net.IPAddress.Parse("182.228.137.159"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("51.189.92.130"),

System.Net.IPAddress.Parse("16.0.182.9"),

System.Net.IPAddress.Parse("122.134.238.53"),

System.Net.IPAddress.Parse("210.127.214.12"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("154.35.148.184"),

System.Net.IPAddress.Parse("79.56.64.141"),

System.Net.IPAddress.Parse("4.233.137.223"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("119.12.197.225"),

System.Net.IPAddress.Parse("234.27.174.157"),

System.Net.IPAddress.Parse("81.236.103.91"),

},
},
            new IPAddressinetArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("123.143.234.83"),

System.Net.IPAddress.Parse("53.27.89.8"),

System.Net.IPAddress.Parse("246.253.120.241"),

System.Net.IPAddress.Parse("159.131.98.147"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.60.159.99"),

System.Net.IPAddress.Parse("92.60.91.10"),

System.Net.IPAddress.Parse("232.89.94.96"),

System.Net.IPAddress.Parse("73.80.182.109"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("164.156.95.200"),

System.Net.IPAddress.Parse("190.62.89.66"),

System.Net.IPAddress.Parse("1.161.82.207"),

System.Net.IPAddress.Parse("116.50.143.179"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("245.158.206.97"),

System.Net.IPAddress.Parse("25.191.37.210"),

System.Net.IPAddress.Parse("125.2.103.163"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("147.48.166.49"),

System.Net.IPAddress.Parse("210.55.100.197"),

System.Net.IPAddress.Parse("195.94.21.224"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("172.111.162.163"),

System.Net.IPAddress.Parse("252.42.155.63"),

System.Net.IPAddress.Parse("0.5.118.225"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("191.122.39.42"),

System.Net.IPAddress.Parse("150.245.74.49"),

System.Net.IPAddress.Parse("24.73.192.159"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("219.233.192.63"),

System.Net.IPAddress.Parse("223.141.204.156"),

System.Net.IPAddress.Parse("237.197.238.150"),

System.Net.IPAddress.Parse("69.254.94.132"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("151.176.11.21"),

System.Net.IPAddress.Parse("58.11.30.136"),

System.Net.IPAddress.Parse("106.42.12.122"),

System.Net.IPAddress.Parse("223.2.41.87"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("96.5.55.214"),

System.Net.IPAddress.Parse("251.77.137.119"),

System.Net.IPAddress.Parse("231.46.13.130"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("227.167.250.222"),

System.Net.IPAddress.Parse("49.138.161.151"),

System.Net.IPAddress.Parse("156.27.40.77"),

System.Net.IPAddress.Parse("214.82.233.197"),

},
},
            new IPAddressinetArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("249.137.105.113"),

System.Net.IPAddress.Parse("20.146.118.125"),

System.Net.IPAddress.Parse("168.82.212.123"),

System.Net.IPAddress.Parse("244.16.40.15"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("220.205.108.233"),

System.Net.IPAddress.Parse("115.98.244.228"),

System.Net.IPAddress.Parse("46.224.147.62"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("60.63.142.162"),

System.Net.IPAddress.Parse("38.123.16.50"),

System.Net.IPAddress.Parse("198.171.123.228"),

System.Net.IPAddress.Parse("184.79.107.153"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("189.124.15.221"),

System.Net.IPAddress.Parse("98.177.107.205"),

System.Net.IPAddress.Parse("160.81.205.167"),

},
},
            new IPAddressinetArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("54.186.213.214"),

System.Net.IPAddress.Parse("8.160.245.47"),

System.Net.IPAddress.Parse("182.60.233.183"),

System.Net.IPAddress.Parse("33.6.1.199"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("167.246.92.116"),

System.Net.IPAddress.Parse("211.7.32.241"),

System.Net.IPAddress.Parse("146.246.54.235"),

},
},
            new IPAddressinetArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("56.181.93.178"),

System.Net.IPAddress.Parse("117.77.2.174"),

System.Net.IPAddress.Parse("0.96.25.176"),

System.Net.IPAddress.Parse("83.34.83.18"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("54.149.89.18"),

System.Net.IPAddress.Parse("110.156.233.95"),

System.Net.IPAddress.Parse("61.218.171.117"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("172.168.36.15"),

System.Net.IPAddress.Parse("11.124.10.250"),

System.Net.IPAddress.Parse("128.198.211.180"),

System.Net.IPAddress.Parse("8.154.97.219"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("203.200.196.159"),

System.Net.IPAddress.Parse("69.29.66.199"),

System.Net.IPAddress.Parse("82.203.47.107"),

System.Net.IPAddress.Parse("207.167.34.91"),

},
},
            new IPAddressinetArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("182.235.46.93"),

System.Net.IPAddress.Parse("192.39.73.109"),

System.Net.IPAddress.Parse("204.122.203.202"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("135.243.66.159"),

System.Net.IPAddress.Parse("168.80.105.139"),

System.Net.IPAddress.Parse("253.70.94.226"),

System.Net.IPAddress.Parse("154.155.234.247"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("27.61.145.38"),

System.Net.IPAddress.Parse("49.5.168.226"),

System.Net.IPAddress.Parse("115.14.163.0"),

},
},
            new IPAddressinetArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("134.128.59.189"),

System.Net.IPAddress.Parse("21.102.208.217"),

System.Net.IPAddress.Parse("235.80.249.140"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("60.91.250.227"),

System.Net.IPAddress.Parse("62.171.10.148"),

System.Net.IPAddress.Parse("212.13.111.195"),

System.Net.IPAddress.Parse("75.170.112.180"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("36.72.79.111"),

System.Net.IPAddress.Parse("104.160.50.97"),

System.Net.IPAddress.Parse("158.212.15.54"),

System.Net.IPAddress.Parse("208.4.218.233"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("214.119.235.203"),

System.Net.IPAddress.Parse("190.125.203.105"),

System.Net.IPAddress.Parse("52.128.110.196"),

System.Net.IPAddress.Parse("86.188.229.87"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("47.158.217.73"),

System.Net.IPAddress.Parse("241.31.59.172"),

System.Net.IPAddress.Parse("237.86.214.28"),

System.Net.IPAddress.Parse("125.147.220.201"),

},
},
            new IPAddressinetArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("82.71.4.201"),

System.Net.IPAddress.Parse("65.119.136.191"),

System.Net.IPAddress.Parse("119.116.228.190"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("133.17.75.173"),

System.Net.IPAddress.Parse("81.93.28.200"),

System.Net.IPAddress.Parse("232.202.25.192"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("51.76.198.251"),

System.Net.IPAddress.Parse("41.246.157.234"),

System.Net.IPAddress.Parse("32.42.160.89"),

System.Net.IPAddress.Parse("128.62.110.103"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("1.248.38.97"),

System.Net.IPAddress.Parse("31.254.154.41"),

System.Net.IPAddress.Parse("172.41.244.201"),

},
},
            new IPAddressinetArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("99.42.121.70"),

System.Net.IPAddress.Parse("165.235.66.71"),

System.Net.IPAddress.Parse("239.135.48.25"),

System.Net.IPAddress.Parse("137.115.253.232"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("95.24.18.53"),

System.Net.IPAddress.Parse("201.241.235.19"),

System.Net.IPAddress.Parse("4.119.11.72"),

},
},
            new IPAddressinetArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("133.168.148.239"),

System.Net.IPAddress.Parse("184.57.63.57"),

System.Net.IPAddress.Parse("175.157.115.124"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("43.131.104.83"),

System.Net.IPAddress.Parse("215.115.36.200"),

System.Net.IPAddress.Parse("19.164.11.104"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("2.153.229.14"),

System.Net.IPAddress.Parse("146.163.135.20"),

System.Net.IPAddress.Parse("29.86.104.151"),

System.Net.IPAddress.Parse("187.240.145.87"),

},
},
            new IPAddressinetArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("14.28.175.128"),

System.Net.IPAddress.Parse("129.231.177.111"),

System.Net.IPAddress.Parse("59.194.239.113"),

System.Net.IPAddress.Parse("185.16.163.220"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("155.51.141.82"),

System.Net.IPAddress.Parse("153.218.8.180"),

System.Net.IPAddress.Parse("184.18.150.54"),

},
},
            new IPAddressinetArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("250.66.101.118"),

System.Net.IPAddress.Parse("169.113.202.5"),

System.Net.IPAddress.Parse("60.254.46.14"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("60.143.135.59"),

System.Net.IPAddress.Parse("153.130.166.214"),

System.Net.IPAddress.Parse("35.42.129.88"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("188.78.226.57"),

System.Net.IPAddress.Parse("174.70.29.24"),

System.Net.IPAddress.Parse("115.23.26.74"),

System.Net.IPAddress.Parse("176.3.243.47"),

},
},
            new IPAddressinetArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("150.61.155.88"),

System.Net.IPAddress.Parse("26.62.238.102"),

System.Net.IPAddress.Parse("29.71.169.195"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("46.66.74.2"),

System.Net.IPAddress.Parse("104.225.30.193"),

System.Net.IPAddress.Parse("98.210.23.82"),

System.Net.IPAddress.Parse("164.13.157.169"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("207.240.94.199"),

System.Net.IPAddress.Parse("62.114.32.30"),

System.Net.IPAddress.Parse("251.188.30.48"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("6.34.195.51"),

System.Net.IPAddress.Parse("28.212.215.96"),

System.Net.IPAddress.Parse("117.228.152.248"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("146.102.97.67"),

System.Net.IPAddress.Parse("159.132.26.30"),

System.Net.IPAddress.Parse("154.108.115.182"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("127.110.101.226"),

System.Net.IPAddress.Parse("137.45.109.253"),

System.Net.IPAddress.Parse("208.157.149.81"),

},
},
            new IPAddressinetArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("21.136.193.223"),

System.Net.IPAddress.Parse("42.163.44.227"),

System.Net.IPAddress.Parse("226.65.195.160"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("160.83.231.196"),

System.Net.IPAddress.Parse("54.89.61.63"),

System.Net.IPAddress.Parse("64.56.245.69"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("34.104.126.103"),

System.Net.IPAddress.Parse("59.148.131.246"),

System.Net.IPAddress.Parse("151.173.239.149"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("145.236.113.7"),

System.Net.IPAddress.Parse("159.178.64.198"),

System.Net.IPAddress.Parse("24.99.178.250"),

},
},
            new IPAddressinetArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("85.219.137.204"),

System.Net.IPAddress.Parse("114.14.115.68"),

System.Net.IPAddress.Parse("203.117.230.121"),

System.Net.IPAddress.Parse("23.242.107.88"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("61.63.130.5"),

System.Net.IPAddress.Parse("197.142.76.67"),

System.Net.IPAddress.Parse("142.171.86.28"),

System.Net.IPAddress.Parse("252.83.115.247"),

},
},
            new IPAddressinetArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("98.0.245.160"),

System.Net.IPAddress.Parse("218.166.125.163"),

System.Net.IPAddress.Parse("58.60.67.202"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("157.90.44.228"),

System.Net.IPAddress.Parse("81.51.139.116"),

System.Net.IPAddress.Parse("46.248.187.223"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("100.184.155.34"),

System.Net.IPAddress.Parse("39.43.8.122"),

System.Net.IPAddress.Parse("152.40.143.9"),

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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[30], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[28],_testData[30], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[2], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(models[15],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(models[16],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(models[17],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[18],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[19],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[20],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[21],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[22],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[23],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[24],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[25],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[26],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[27],_testData[29], false);
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
                parametr1.Value = 75;
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[30], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[15],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[16],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[17],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[18],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[19],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[20],_testData[29], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[30], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                int resultIndex = 0;
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
                await ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 93, query1, 69, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[30], false);
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
                await ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 135, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 40, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[30], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 105, query1, 25, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[25],_testData[29], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 35, query1, 122, query2))
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[29], false);
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
                await ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 25, query1, 23, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[26],_testData[30], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 52, query1, 122, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[15],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[16],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[17],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[18],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[29], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 75, query1, 66, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[30], false);
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 81, 23))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[17], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[18], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[19], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[29], false);
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatch(connection, 52, 35))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[10], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[11], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[12], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[13], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[14], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[15], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[16], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[17], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[18], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[19], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[14],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[15],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[16],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[17],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[18],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[6], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[7], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[8], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[9], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[10], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[11], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[12], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[13], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[14], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[15], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[16], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[17], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[18], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[19], false);
                        IPAddressinetArray2M.AssertModel(models[14],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[15],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[16],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[17],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[18],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[19],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[20],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[21],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[22],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[23],_testData[29], false);
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
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 93);
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
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 114);
                var models =  ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
IPAddressinetArray2M.AssertModel(models[0],_testData[23], false);IPAddressinetArray2M.AssertModel(models[1],_testData[24], false);IPAddressinetArray2M.AssertModel(models[2],_testData[25], false);IPAddressinetArray2M.AssertModel(models[3],_testData[26], false);IPAddressinetArray2M.AssertModel(models[4],_testData[27], false);IPAddressinetArray2M.AssertModel(models[5],_testData[28], false);IPAddressinetArray2M.AssertModel(models[6],_testData[29], false);
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

