

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
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("28.246.64.124"),

System.Net.IPAddress.Parse("9.46.94.199"),

System.Net.IPAddress.Parse("208.244.137.114"),

System.Net.IPAddress.Parse("17.145.130.37"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("151.117.231.214"),

System.Net.IPAddress.Parse("138.177.43.102"),

System.Net.IPAddress.Parse("3.179.246.139"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("15.211.191.202"),

System.Net.IPAddress.Parse("192.177.89.102"),

System.Net.IPAddress.Parse("45.47.19.47"),

System.Net.IPAddress.Parse("147.51.146.234"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("193.250.184.156"),

System.Net.IPAddress.Parse("109.123.7.209"),

System.Net.IPAddress.Parse("150.122.54.164"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("143.210.241.254"),

System.Net.IPAddress.Parse("60.32.178.164"),

System.Net.IPAddress.Parse("140.97.62.176"),

System.Net.IPAddress.Parse("62.137.154.165"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("105.30.180.119"),

System.Net.IPAddress.Parse("4.31.139.178"),

System.Net.IPAddress.Parse("235.198.52.95"),

System.Net.IPAddress.Parse("245.222.233.107"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("178.90.108.249"),

System.Net.IPAddress.Parse("254.0.60.21"),

System.Net.IPAddress.Parse("214.96.194.15"),

},
},
            new IPAddressinetArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("174.44.151.85"),

System.Net.IPAddress.Parse("129.98.30.21"),

System.Net.IPAddress.Parse("77.144.19.254"),

System.Net.IPAddress.Parse("249.96.30.39"),

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
System.Net.IPAddress.Parse("247.70.225.189"),

System.Net.IPAddress.Parse("53.61.168.116"),

System.Net.IPAddress.Parse("21.62.16.68"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("191.153.163.240"),

System.Net.IPAddress.Parse("190.168.69.110"),

System.Net.IPAddress.Parse("33.179.161.29"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("190.162.177.37"),

System.Net.IPAddress.Parse("176.163.94.77"),

System.Net.IPAddress.Parse("134.157.12.157"),

System.Net.IPAddress.Parse("49.72.98.99"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("242.205.143.18"),

System.Net.IPAddress.Parse("7.44.7.101"),

System.Net.IPAddress.Parse("94.107.189.200"),

System.Net.IPAddress.Parse("246.223.43.61"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("234.150.174.229"),

System.Net.IPAddress.Parse("150.209.33.215"),

System.Net.IPAddress.Parse("174.206.198.30"),

System.Net.IPAddress.Parse("218.60.149.196"),

},
},
            new IPAddressinetArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("111.134.206.23"),

System.Net.IPAddress.Parse("15.162.47.203"),

System.Net.IPAddress.Parse("172.171.144.157"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("90.65.140.148"),

System.Net.IPAddress.Parse("106.99.106.180"),

System.Net.IPAddress.Parse("183.186.187.113"),

System.Net.IPAddress.Parse("252.3.151.186"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("134.121.155.219"),

System.Net.IPAddress.Parse("79.79.26.169"),

System.Net.IPAddress.Parse("141.212.176.236"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("204.155.59.54"),

System.Net.IPAddress.Parse("36.170.199.146"),

System.Net.IPAddress.Parse("179.165.249.86"),

System.Net.IPAddress.Parse("93.160.157.217"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("103.242.239.215"),

System.Net.IPAddress.Parse("27.235.187.113"),

System.Net.IPAddress.Parse("190.71.64.110"),

System.Net.IPAddress.Parse("80.194.111.7"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("247.142.77.196"),

System.Net.IPAddress.Parse("38.89.88.193"),

System.Net.IPAddress.Parse("224.139.135.75"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("239.221.25.79"),

System.Net.IPAddress.Parse("131.234.56.110"),

System.Net.IPAddress.Parse("104.183.190.159"),

System.Net.IPAddress.Parse("155.229.214.245"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("3.215.121.6"),

System.Net.IPAddress.Parse("23.58.90.18"),

System.Net.IPAddress.Parse("28.212.160.102"),

System.Net.IPAddress.Parse("202.186.142.104"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("200.111.150.117"),

System.Net.IPAddress.Parse("11.163.94.102"),

System.Net.IPAddress.Parse("79.207.216.224"),

},
},
            new IPAddressinetArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("28.102.69.42"),

System.Net.IPAddress.Parse("15.87.250.182"),

System.Net.IPAddress.Parse("184.48.229.139"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("162.66.110.17"),

System.Net.IPAddress.Parse("107.166.74.188"),

System.Net.IPAddress.Parse("225.194.164.162"),

System.Net.IPAddress.Parse("55.180.221.238"),

},
},
            new IPAddressinetArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("115.53.145.0"),

System.Net.IPAddress.Parse("1.195.176.236"),

System.Net.IPAddress.Parse("95.206.215.171"),

System.Net.IPAddress.Parse("79.130.181.181"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("185.149.170.40"),

System.Net.IPAddress.Parse("33.82.38.178"),

System.Net.IPAddress.Parse("225.90.187.64"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("73.90.140.225"),

System.Net.IPAddress.Parse("56.23.148.140"),

System.Net.IPAddress.Parse("42.121.254.86"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("70.193.190.187"),

System.Net.IPAddress.Parse("124.55.241.21"),

System.Net.IPAddress.Parse("111.177.238.33"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("222.138.223.148"),

System.Net.IPAddress.Parse("178.100.71.181"),

System.Net.IPAddress.Parse("70.34.33.86"),

},
},
            new IPAddressinetArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("51.18.24.61"),

System.Net.IPAddress.Parse("160.145.184.106"),

System.Net.IPAddress.Parse("88.18.171.78"),

System.Net.IPAddress.Parse("64.75.94.63"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("15.43.193.194"),

System.Net.IPAddress.Parse("216.213.88.239"),

System.Net.IPAddress.Parse("177.11.85.94"),

System.Net.IPAddress.Parse("87.81.207.174"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("171.198.247.14"),

System.Net.IPAddress.Parse("1.126.50.56"),

System.Net.IPAddress.Parse("246.21.196.3"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("125.47.243.66"),

System.Net.IPAddress.Parse("106.194.80.234"),

System.Net.IPAddress.Parse("150.118.142.33"),

},
},
            new IPAddressinetArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("20.85.92.87"),

System.Net.IPAddress.Parse("189.210.75.138"),

System.Net.IPAddress.Parse("110.72.139.161"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("41.228.173.23"),

System.Net.IPAddress.Parse("158.145.215.231"),

System.Net.IPAddress.Parse("30.44.77.252"),

System.Net.IPAddress.Parse("217.66.95.240"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("129.6.195.134"),

System.Net.IPAddress.Parse("248.202.35.106"),

System.Net.IPAddress.Parse("145.12.248.16"),

System.Net.IPAddress.Parse("145.107.203.211"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("20.87.144.121"),

System.Net.IPAddress.Parse("131.175.180.35"),

System.Net.IPAddress.Parse("116.174.157.68"),

},
},
            new IPAddressinetArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("71.12.237.41"),

System.Net.IPAddress.Parse("221.174.71.105"),

System.Net.IPAddress.Parse("35.223.200.20"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("185.49.67.239"),

System.Net.IPAddress.Parse("177.20.113.144"),

System.Net.IPAddress.Parse("3.160.81.24"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("136.107.191.235"),

System.Net.IPAddress.Parse("162.200.80.54"),

System.Net.IPAddress.Parse("200.237.140.180"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("72.205.171.108"),

System.Net.IPAddress.Parse("191.31.203.189"),

System.Net.IPAddress.Parse("107.248.114.78"),

},
},
            new IPAddressinetArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("247.48.13.129"),

System.Net.IPAddress.Parse("121.132.117.79"),

System.Net.IPAddress.Parse("242.191.250.181"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("90.145.19.188"),

System.Net.IPAddress.Parse("102.200.128.117"),

System.Net.IPAddress.Parse("64.206.64.194"),

System.Net.IPAddress.Parse("63.82.121.48"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("47.215.123.210"),

System.Net.IPAddress.Parse("213.242.244.215"),

System.Net.IPAddress.Parse("228.254.187.8"),

System.Net.IPAddress.Parse("58.201.241.11"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("132.92.223.214"),

System.Net.IPAddress.Parse("249.96.178.17"),

System.Net.IPAddress.Parse("215.83.73.23"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("117.140.229.144"),

System.Net.IPAddress.Parse("152.63.102.171"),

System.Net.IPAddress.Parse("58.189.231.205"),

},
},
            new IPAddressinetArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("155.112.110.205"),

System.Net.IPAddress.Parse("103.180.51.138"),

System.Net.IPAddress.Parse("41.194.48.86"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("182.104.187.228"),

System.Net.IPAddress.Parse("26.88.78.28"),

System.Net.IPAddress.Parse("99.19.11.190"),

System.Net.IPAddress.Parse("114.33.54.118"),

},
},
            new IPAddressinetArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("124.63.237.129"),

System.Net.IPAddress.Parse("172.253.68.72"),

System.Net.IPAddress.Parse("176.132.92.239"),

System.Net.IPAddress.Parse("230.250.70.218"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("176.110.33.154"),

System.Net.IPAddress.Parse("172.65.254.101"),

System.Net.IPAddress.Parse("145.199.144.249"),

System.Net.IPAddress.Parse("87.58.176.133"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("141.128.195.140"),

System.Net.IPAddress.Parse("119.223.53.35"),

System.Net.IPAddress.Parse("150.64.151.212"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("118.95.20.79"),

System.Net.IPAddress.Parse("188.98.13.253"),

System.Net.IPAddress.Parse("251.32.163.97"),

},
},
            new IPAddressinetArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("231.167.254.233"),

System.Net.IPAddress.Parse("173.44.5.246"),

System.Net.IPAddress.Parse("21.43.7.172"),

System.Net.IPAddress.Parse("193.114.96.166"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("0.181.78.46"),

System.Net.IPAddress.Parse("139.117.64.157"),

System.Net.IPAddress.Parse("68.77.71.124"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("34.58.105.108"),

System.Net.IPAddress.Parse("183.155.128.150"),

System.Net.IPAddress.Parse("144.254.66.221"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("65.193.134.178"),

System.Net.IPAddress.Parse("175.206.168.205"),

System.Net.IPAddress.Parse("198.140.244.4"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("25.125.208.115"),

System.Net.IPAddress.Parse("68.240.236.77"),

System.Net.IPAddress.Parse("221.187.205.217"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("167.90.62.4"),

System.Net.IPAddress.Parse("248.168.154.61"),

System.Net.IPAddress.Parse("132.180.148.160"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("186.195.169.113"),

System.Net.IPAddress.Parse("42.176.97.85"),

System.Net.IPAddress.Parse("45.150.95.51"),

System.Net.IPAddress.Parse("98.156.128.187"),

},
},
            new IPAddressinetArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("199.102.103.49"),

System.Net.IPAddress.Parse("13.248.235.51"),

System.Net.IPAddress.Parse("44.250.180.188"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("133.118.64.91"),

System.Net.IPAddress.Parse("131.165.171.170"),

System.Net.IPAddress.Parse("45.10.154.95"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("122.222.250.62"),

System.Net.IPAddress.Parse("0.74.108.77"),

System.Net.IPAddress.Parse("191.92.203.140"),

System.Net.IPAddress.Parse("249.178.160.89"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("199.70.80.13"),

System.Net.IPAddress.Parse("10.201.175.74"),

System.Net.IPAddress.Parse("161.210.45.248"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("164.61.136.171"),

System.Net.IPAddress.Parse("96.174.153.93"),

System.Net.IPAddress.Parse("76.232.157.56"),

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
                parametr1.Value = 111;
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[24],_testData[29], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[27],_testData[29], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[29], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[29], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(models[15],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(models[16],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[17],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[18],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[19],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[20],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[21],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[22],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[23],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[24],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[25],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[26],_testData[29], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[29], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[16], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[17], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[18], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[19], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[29], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                await ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 98, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[29], false);
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
                await ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 13, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[27],_testData[29], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 41, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[21],_testData[29], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 51, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[29], false);
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 51, query1, 92, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[15],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[16],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[17],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 59, query1, 123, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[29], false);
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 59, query1, 34, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                 ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 59, query1, 76, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[29], false);
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 98, 26))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[19], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatch(connection, 92, 21))
                {
                    if(++resultIndex == 1)
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
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 98);
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
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 46);
                var models =  ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
IPAddressinetArray2M.AssertModel(models[0],_testData[9], false);IPAddressinetArray2M.AssertModel(models[1],_testData[10], false);IPAddressinetArray2M.AssertModel(models[2],_testData[11], false);IPAddressinetArray2M.AssertModel(models[3],_testData[12], false);IPAddressinetArray2M.AssertModel(models[4],_testData[13], false);IPAddressinetArray2M.AssertModel(models[5],_testData[14], false);IPAddressinetArray2M.AssertModel(models[6],_testData[15], false);IPAddressinetArray2M.AssertModel(models[7],_testData[16], false);IPAddressinetArray2M.AssertModel(models[8],_testData[17], false);IPAddressinetArray2M.AssertModel(models[9],_testData[18], false);IPAddressinetArray2M.AssertModel(models[10],_testData[19], false);IPAddressinetArray2M.AssertModel(models[11],_testData[20], false);IPAddressinetArray2M.AssertModel(models[12],_testData[21], false);IPAddressinetArray2M.AssertModel(models[13],_testData[22], false);IPAddressinetArray2M.AssertModel(models[14],_testData[23], false);IPAddressinetArray2M.AssertModel(models[15],_testData[24], false);IPAddressinetArray2M.AssertModel(models[16],_testData[25], false);IPAddressinetArray2M.AssertModel(models[17],_testData[26], false);IPAddressinetArray2M.AssertModel(models[18],_testData[27], false);IPAddressinetArray2M.AssertModel(models[19],_testData[28], false);IPAddressinetArray2M.AssertModel(models[20],_testData[29], false);
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

