

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
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("69.18.175.105"),
System.Net.IPAddress.Parse("89.60.95.18"),
System.Net.IPAddress.Parse("155.169.188.141"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("30.210.146.136"),
System.Net.IPAddress.Parse("142.14.184.18"),
System.Net.IPAddress.Parse("116.95.127.36"),
},
},
            new IPAddressinetArray1M
{
    Id = 10,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("33.17.201.64"),
System.Net.IPAddress.Parse("225.219.204.113"),
System.Net.IPAddress.Parse("110.36.146.148"),
System.Net.IPAddress.Parse("190.76.116.202"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 6,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("168.184.68.4"),
System.Net.IPAddress.Parse("239.233.111.30"),
System.Net.IPAddress.Parse("207.162.192.225"),
System.Net.IPAddress.Parse("77.20.180.141"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("166.241.230.94"),
System.Net.IPAddress.Parse("48.123.228.218"),
System.Net.IPAddress.Parse("192.216.128.145"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("186.193.94.149"),
System.Net.IPAddress.Parse("130.6.206.71"),
System.Net.IPAddress.Parse("119.40.109.16"),
},
},
            new IPAddressinetArray1M
{
    Id = 11,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("132.244.145.117"),
System.Net.IPAddress.Parse("65.171.24.28"),
System.Net.IPAddress.Parse("59.111.20.197"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("172.70.120.90"),
System.Net.IPAddress.Parse("50.140.90.4"),
System.Net.IPAddress.Parse("40.138.89.2"),
},
},
            new IPAddressinetArray1M
{
    Id = 18,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("31.137.0.54"),
System.Net.IPAddress.Parse("4.36.107.4"),
System.Net.IPAddress.Parse("119.241.232.45"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 15,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("22.134.74.176"),
System.Net.IPAddress.Parse("198.66.17.45"),
System.Net.IPAddress.Parse("75.69.30.20"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("140.84.237.120"),
System.Net.IPAddress.Parse("253.246.28.91"),
System.Net.IPAddress.Parse("125.146.125.119"),
System.Net.IPAddress.Parse("51.2.124.42"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 19,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("28.231.196.92"),
System.Net.IPAddress.Parse("103.28.43.51"),
System.Net.IPAddress.Parse("63.206.123.197"),
System.Net.IPAddress.Parse("109.229.129.252"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 28,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("89.151.65.176"),
System.Net.IPAddress.Parse("13.217.187.220"),
System.Net.IPAddress.Parse("62.90.100.72"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 20,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("170.112.153.123"),
System.Net.IPAddress.Parse("180.138.179.8"),
System.Net.IPAddress.Parse("142.109.55.118"),
System.Net.IPAddress.Parse("26.212.84.40"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("74.3.84.28"),
System.Net.IPAddress.Parse("235.152.122.44"),
System.Net.IPAddress.Parse("89.49.153.216"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("65.182.70.244"),
System.Net.IPAddress.Parse("102.165.13.143"),
System.Net.IPAddress.Parse("33.174.84.187"),
},
},
            new IPAddressinetArray1M
{
    Id = 34,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("85.40.66.188"),
System.Net.IPAddress.Parse("175.189.43.59"),
System.Net.IPAddress.Parse("58.202.166.102"),
System.Net.IPAddress.Parse("157.201.36.36"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("29.71.185.238"),
System.Net.IPAddress.Parse("233.177.127.190"),
System.Net.IPAddress.Parse("153.150.238.193"),
System.Net.IPAddress.Parse("84.193.40.73"),
},
},
            new IPAddressinetArray1M
{
    Id = 35,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("84.102.67.86"),
System.Net.IPAddress.Parse("242.197.231.27"),
System.Net.IPAddress.Parse("55.45.174.160"),
System.Net.IPAddress.Parse("23.253.194.233"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 24,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("167.67.9.197"),
System.Net.IPAddress.Parse("107.234.177.22"),
System.Net.IPAddress.Parse("130.23.25.247"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 43,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("3.84.16.61"),
System.Net.IPAddress.Parse("80.116.115.9"),
System.Net.IPAddress.Parse("75.177.103.243"),
System.Net.IPAddress.Parse("117.250.37.193"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 45,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("5.25.209.146"),
System.Net.IPAddress.Parse("90.227.103.156"),
System.Net.IPAddress.Parse("22.175.85.183"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 30,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("127.64.135.74"),
System.Net.IPAddress.Parse("223.104.244.57"),
System.Net.IPAddress.Parse("123.243.116.131"),
System.Net.IPAddress.Parse("241.148.86.163"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("253.12.104.90"),
System.Net.IPAddress.Parse("229.209.64.208"),
System.Net.IPAddress.Parse("40.200.141.3"),
System.Net.IPAddress.Parse("208.135.135.49"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("232.11.246.205"),
System.Net.IPAddress.Parse("254.78.223.50"),
System.Net.IPAddress.Parse("20.201.48.49"),
System.Net.IPAddress.Parse("2.144.69.56"),
},
},
            new IPAddressinetArray1M
{
    Id = 46,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("194.195.19.89"),
System.Net.IPAddress.Parse("186.249.94.122"),
System.Net.IPAddress.Parse("5.150.210.120"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 53,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("225.195.190.101"),
System.Net.IPAddress.Parse("22.96.101.84"),
System.Net.IPAddress.Parse("233.171.164.198"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 31,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("93.190.12.188"),
System.Net.IPAddress.Parse("64.119.78.91"),
System.Net.IPAddress.Parse("104.58.217.32"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("91.187.134.104"),
System.Net.IPAddress.Parse("240.69.186.49"),
System.Net.IPAddress.Parse("149.242.247.138"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 58,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("14.46.230.62"),
System.Net.IPAddress.Parse("59.16.112.45"),
System.Net.IPAddress.Parse("223.224.98.179"),
System.Net.IPAddress.Parse("46.38.111.161"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("119.190.20.64"),
System.Net.IPAddress.Parse("82.57.128.229"),
System.Net.IPAddress.Parse("8.247.144.2"),
System.Net.IPAddress.Parse("121.174.174.108"),
},
},
            new IPAddressinetArray1M
{
    Id = 60,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("22.175.88.125"),
System.Net.IPAddress.Parse("183.168.236.82"),
System.Net.IPAddress.Parse("13.90.220.16"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 34,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("25.193.138.224"),
System.Net.IPAddress.Parse("227.94.112.209"),
System.Net.IPAddress.Parse("100.4.117.219"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("219.230.149.73"),
System.Net.IPAddress.Parse("51.121.241.13"),
System.Net.IPAddress.Parse("177.70.40.94"),
System.Net.IPAddress.Parse("182.119.84.247"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("156.206.179.175"),
System.Net.IPAddress.Parse("212.67.219.129"),
System.Net.IPAddress.Parse("244.252.36.195"),
System.Net.IPAddress.Parse("85.192.234.160"),
},
},
            new IPAddressinetArray1M
{
    Id = 64,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("34.170.131.227"),
System.Net.IPAddress.Parse("159.164.194.95"),
System.Net.IPAddress.Parse("97.253.37.60"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("215.39.51.66"),
System.Net.IPAddress.Parse("32.70.247.224"),
System.Net.IPAddress.Parse("111.40.34.166"),
System.Net.IPAddress.Parse("166.90.252.19"),
},
},
            new IPAddressinetArray1M
{
    Id = 69,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("218.48.13.187"),
System.Net.IPAddress.Parse("30.108.184.143"),
System.Net.IPAddress.Parse("116.189.105.225"),
System.Net.IPAddress.Parse("167.223.193.50"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 38,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("101.82.250.99"),
System.Net.IPAddress.Parse("45.169.38.89"),
System.Net.IPAddress.Parse("35.195.75.129"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("150.82.143.240"),
System.Net.IPAddress.Parse("226.38.71.214"),
System.Net.IPAddress.Parse("65.249.150.18"),
System.Net.IPAddress.Parse("195.235.121.13"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 77,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("5.113.9.132"),
System.Net.IPAddress.Parse("86.122.219.122"),
System.Net.IPAddress.Parse("177.136.49.21"),
System.Net.IPAddress.Parse("217.8.90.173"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 80,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.148.188.5"),
System.Net.IPAddress.Parse("97.174.158.194"),
System.Net.IPAddress.Parse("200.166.135.178"),
System.Net.IPAddress.Parse("228.161.249.168"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 43,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("69.223.182.124"),
System.Net.IPAddress.Parse("223.57.94.6"),
System.Net.IPAddress.Parse("237.110.202.243"),
System.Net.IPAddress.Parse("201.11.135.42"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("42.252.12.200"),
System.Net.IPAddress.Parse("173.37.237.242"),
System.Net.IPAddress.Parse("6.145.135.228"),
},
},
            new IPAddressinetArray1M
{
    Id = 87,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("24.230.58.24"),
System.Net.IPAddress.Parse("92.204.18.164"),
System.Net.IPAddress.Parse("48.74.6.13"),
System.Net.IPAddress.Parse("105.182.232.104"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("158.72.139.220"),
System.Net.IPAddress.Parse("67.182.252.57"),
System.Net.IPAddress.Parse("66.153.62.6"),
System.Net.IPAddress.Parse("89.41.66.20"),
},
},
            new IPAddressinetArray1M
{
    Id = 93,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("166.9.14.9"),
System.Net.IPAddress.Parse("93.60.65.138"),
System.Net.IPAddress.Parse("229.104.130.221"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 48,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("36.72.10.30"),
System.Net.IPAddress.Parse("22.102.15.154"),
System.Net.IPAddress.Parse("127.228.192.132"),
System.Net.IPAddress.Parse("93.92.164.24"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.25.185.116"),
System.Net.IPAddress.Parse("230.135.128.138"),
System.Net.IPAddress.Parse("213.188.220.133"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 95,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("156.151.206.137"),
System.Net.IPAddress.Parse("140.112.62.77"),
System.Net.IPAddress.Parse("124.15.147.158"),
System.Net.IPAddress.Parse("28.41.184.91"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("119.42.96.2"),
System.Net.IPAddress.Parse("39.51.233.143"),
System.Net.IPAddress.Parse("213.30.173.57"),
},
},
            new IPAddressinetArray1M
{
    Id = 98,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("46.98.212.154"),
System.Net.IPAddress.Parse("21.187.173.37"),
System.Net.IPAddress.Parse("133.41.214.102"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 55,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("56.224.250.49"),
System.Net.IPAddress.Parse("252.134.213.97"),
System.Net.IPAddress.Parse("22.133.51.12"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("140.133.59.166"),
System.Net.IPAddress.Parse("242.92.217.221"),
System.Net.IPAddress.Parse("57.235.221.227"),
System.Net.IPAddress.Parse("235.138.91.35"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 105,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("186.178.144.191"),
System.Net.IPAddress.Parse("24.24.203.169"),
System.Net.IPAddress.Parse("211.195.142.62"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 108,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("26.18.191.43"),
System.Net.IPAddress.Parse("230.232.196.227"),
System.Net.IPAddress.Parse("6.118.48.8"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 59,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("103.21.89.188"),
System.Net.IPAddress.Parse("252.91.186.19"),
System.Net.IPAddress.Parse("28.91.33.38"),
System.Net.IPAddress.Parse("41.208.104.67"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("92.84.183.10"),
System.Net.IPAddress.Parse("215.129.60.237"),
System.Net.IPAddress.Parse("184.247.195.35"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 115,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("232.147.116.215"),
System.Net.IPAddress.Parse("158.153.214.159"),
System.Net.IPAddress.Parse("119.175.203.179"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("149.144.224.97"),
System.Net.IPAddress.Parse("207.161.172.102"),
System.Net.IPAddress.Parse("189.215.206.248"),
},
},
            new IPAddressinetArray1M
{
    Id = 121,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("120.85.179.62"),
System.Net.IPAddress.Parse("112.50.75.119"),
System.Net.IPAddress.Parse("158.229.53.195"),
System.Net.IPAddress.Parse("68.156.190.11"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 65,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("156.79.166.179"),
System.Net.IPAddress.Parse("109.203.96.209"),
System.Net.IPAddress.Parse("74.134.112.135"),
System.Net.IPAddress.Parse("37.86.133.196"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("35.163.5.64"),
System.Net.IPAddress.Parse("53.4.166.42"),
System.Net.IPAddress.Parse("8.86.20.39"),
System.Net.IPAddress.Parse("110.109.41.176"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("95.217.113.159"),
System.Net.IPAddress.Parse("6.234.119.232"),
System.Net.IPAddress.Parse("141.139.55.90"),
System.Net.IPAddress.Parse("134.15.237.38"),
},
},
            new IPAddressinetArray1M
{
    Id = 127,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("220.70.91.154"),
System.Net.IPAddress.Parse("32.198.241.230"),
System.Net.IPAddress.Parse("2.217.157.246"),
System.Net.IPAddress.Parse("73.16.155.26"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 131,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("138.76.250.177"),
System.Net.IPAddress.Parse("10.60.143.70"),
System.Net.IPAddress.Parse("230.79.246.55"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 66,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("181.21.179.106"),
System.Net.IPAddress.Parse("54.22.164.155"),
System.Net.IPAddress.Parse("22.48.53.90"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("213.11.37.104"),
System.Net.IPAddress.Parse("27.144.14.209"),
System.Net.IPAddress.Parse("97.68.203.250"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 132,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("65.241.246.82"),
System.Net.IPAddress.Parse("62.172.191.78"),
System.Net.IPAddress.Parse("59.18.92.182"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 136,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("247.135.88.61"),
System.Net.IPAddress.Parse("90.224.146.164"),
System.Net.IPAddress.Parse("21.80.217.154"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 73,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("204.50.49.55"),
System.Net.IPAddress.Parse("189.168.75.94"),
System.Net.IPAddress.Parse("238.116.54.247"),
System.Net.IPAddress.Parse("227.232.40.167"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("193.219.231.105"),
System.Net.IPAddress.Parse("119.54.57.206"),
System.Net.IPAddress.Parse("25.100.53.123"),
System.Net.IPAddress.Parse("159.224.241.127"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("65.182.70.244"),
System.Net.IPAddress.Parse("102.165.13.143"),
System.Net.IPAddress.Parse("33.174.84.187"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("29.71.185.238"),
System.Net.IPAddress.Parse("233.177.127.190"),
System.Net.IPAddress.Parse("153.150.238.193"),
System.Net.IPAddress.Parse("84.193.40.73"),
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
                Assert.That(nullable, Is.Null);
                nullable =  ((IIPAddressArrayinetArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("232.11.246.205"),
System.Net.IPAddress.Parse("254.78.223.50"),
System.Net.IPAddress.Parse("20.201.48.49"),
System.Net.IPAddress.Parse("2.144.69.56"),
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
                        Assert.That(models, Has.Count.EqualTo(28));
FlatIPAddressinetArray1M.AssertModel(models[0],_testData[2], false);FlatIPAddressinetArray1M.AssertModel(models[1],_testData[3], false);FlatIPAddressinetArray1M.AssertModel(models[2],_testData[4], false);FlatIPAddressinetArray1M.AssertModel(models[3],_testData[5], false);FlatIPAddressinetArray1M.AssertModel(models[4],_testData[6], false);FlatIPAddressinetArray1M.AssertModel(models[5],_testData[7], false);FlatIPAddressinetArray1M.AssertModel(models[6],_testData[8], false);FlatIPAddressinetArray1M.AssertModel(models[7],_testData[9], false);FlatIPAddressinetArray1M.AssertModel(models[8],_testData[10], false);FlatIPAddressinetArray1M.AssertModel(models[9],_testData[11], false);FlatIPAddressinetArray1M.AssertModel(models[10],_testData[12], false);FlatIPAddressinetArray1M.AssertModel(models[11],_testData[13], false);FlatIPAddressinetArray1M.AssertModel(models[12],_testData[14], false);FlatIPAddressinetArray1M.AssertModel(models[13],_testData[15], false);FlatIPAddressinetArray1M.AssertModel(models[14],_testData[16], false);FlatIPAddressinetArray1M.AssertModel(models[15],_testData[17], false);FlatIPAddressinetArray1M.AssertModel(models[16],_testData[18], false);FlatIPAddressinetArray1M.AssertModel(models[17],_testData[19], false);FlatIPAddressinetArray1M.AssertModel(models[18],_testData[20], false);FlatIPAddressinetArray1M.AssertModel(models[19],_testData[21], false);FlatIPAddressinetArray1M.AssertModel(models[20],_testData[22], false);FlatIPAddressinetArray1M.AssertModel(models[21],_testData[23], false);FlatIPAddressinetArray1M.AssertModel(models[22],_testData[24], false);FlatIPAddressinetArray1M.AssertModel(models[23],_testData[25], false);FlatIPAddressinetArray1M.AssertModel(models[24],_testData[26], false);FlatIPAddressinetArray1M.AssertModel(models[25],_testData[27], false);FlatIPAddressinetArray1M.AssertModel(models[26],_testData[28], false);FlatIPAddressinetArray1M.AssertModel(models[27],_testData[29], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                        Assert.That(models, Has.Count.EqualTo(12));
FlatIPAddressinetArray1M.AssertModel(models[0],_testData[18], false);FlatIPAddressinetArray1M.AssertModel(models[1],_testData[19], false);FlatIPAddressinetArray1M.AssertModel(models[2],_testData[20], false);FlatIPAddressinetArray1M.AssertModel(models[3],_testData[21], false);FlatIPAddressinetArray1M.AssertModel(models[4],_testData[22], false);FlatIPAddressinetArray1M.AssertModel(models[5],_testData[23], false);FlatIPAddressinetArray1M.AssertModel(models[6],_testData[24], false);FlatIPAddressinetArray1M.AssertModel(models[7],_testData[25], false);FlatIPAddressinetArray1M.AssertModel(models[8],_testData[26], false);FlatIPAddressinetArray1M.AssertModel(models[9],_testData[27], false);FlatIPAddressinetArray1M.AssertModel(models[10],_testData[28], false);FlatIPAddressinetArray1M.AssertModel(models[11],_testData[29], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(10));
IPAddressinetArray1M.AssertModel(models[0],_testData[20], false);IPAddressinetArray1M.AssertModel(models[1],_testData[21], false);IPAddressinetArray1M.AssertModel(models[2],_testData[22], false);IPAddressinetArray1M.AssertModel(models[3],_testData[23], false);IPAddressinetArray1M.AssertModel(models[4],_testData[24], false);IPAddressinetArray1M.AssertModel(models[5],_testData[25], false);IPAddressinetArray1M.AssertModel(models[6],_testData[26], false);IPAddressinetArray1M.AssertModel(models[7],_testData[27], false);IPAddressinetArray1M.AssertModel(models[8],_testData[28], false);IPAddressinetArray1M.AssertModel(models[9],_testData[29], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
IPAddressinetArray1M.AssertModel(models[0],_testData[23], false);IPAddressinetArray1M.AssertModel(models[1],_testData[24], false);IPAddressinetArray1M.AssertModel(models[2],_testData[25], false);IPAddressinetArray1M.AssertModel(models[3],_testData[26], false);IPAddressinetArray1M.AssertModel(models[4],_testData[27], false);IPAddressinetArray1M.AssertModel(models[5],_testData[28], false);IPAddressinetArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
IPAddressinetArray1M.AssertModel(models[0],_testData[23], false);IPAddressinetArray1M.AssertModel(models[1],_testData[24], false);IPAddressinetArray1M.AssertModel(models[2],_testData[25], false);IPAddressinetArray1M.AssertModel(models[3],_testData[26], false);IPAddressinetArray1M.AssertModel(models[4],_testData[27], false);IPAddressinetArray1M.AssertModel(models[5],_testData[28], false);IPAddressinetArray1M.AssertModel(models[6],_testData[29], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 34, query1, 69, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatIPAddressinetArray1M.AssertModel(models[0],_testData[7], false);FlatIPAddressinetArray1M.AssertModel(models[1],_testData[8], false);FlatIPAddressinetArray1M.AssertModel(models[2],_testData[9], false);FlatIPAddressinetArray1M.AssertModel(models[3],_testData[10], false);FlatIPAddressinetArray1M.AssertModel(models[4],_testData[11], false);FlatIPAddressinetArray1M.AssertModel(models[5],_testData[12], false);FlatIPAddressinetArray1M.AssertModel(models[6],_testData[13], false);FlatIPAddressinetArray1M.AssertModel(models[7],_testData[14], false);FlatIPAddressinetArray1M.AssertModel(models[8],_testData[15], false);FlatIPAddressinetArray1M.AssertModel(models[9],_testData[16], false);FlatIPAddressinetArray1M.AssertModel(models[10],_testData[17], false);FlatIPAddressinetArray1M.AssertModel(models[11],_testData[18], false);FlatIPAddressinetArray1M.AssertModel(models[12],_testData[19], false);FlatIPAddressinetArray1M.AssertModel(models[13],_testData[20], false);FlatIPAddressinetArray1M.AssertModel(models[14],_testData[21], false);FlatIPAddressinetArray1M.AssertModel(models[15],_testData[22], false);FlatIPAddressinetArray1M.AssertModel(models[16],_testData[23], false);FlatIPAddressinetArray1M.AssertModel(models[17],_testData[24], false);FlatIPAddressinetArray1M.AssertModel(models[18],_testData[25], false);FlatIPAddressinetArray1M.AssertModel(models[19],_testData[26], false);FlatIPAddressinetArray1M.AssertModel(models[20],_testData[27], false);FlatIPAddressinetArray1M.AssertModel(models[21],_testData[28], false);FlatIPAddressinetArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatIPAddressinetArray1M.AssertModel(models[0],_testData[16], false);FlatIPAddressinetArray1M.AssertModel(models[1],_testData[17], false);FlatIPAddressinetArray1M.AssertModel(models[2],_testData[18], false);FlatIPAddressinetArray1M.AssertModel(models[3],_testData[19], false);FlatIPAddressinetArray1M.AssertModel(models[4],_testData[20], false);FlatIPAddressinetArray1M.AssertModel(models[5],_testData[21], false);FlatIPAddressinetArray1M.AssertModel(models[6],_testData[22], false);FlatIPAddressinetArray1M.AssertModel(models[7],_testData[23], false);FlatIPAddressinetArray1M.AssertModel(models[8],_testData[24], false);FlatIPAddressinetArray1M.AssertModel(models[9],_testData[25], false);FlatIPAddressinetArray1M.AssertModel(models[10],_testData[26], false);FlatIPAddressinetArray1M.AssertModel(models[11],_testData[27], false);FlatIPAddressinetArray1M.AssertModel(models[12],_testData[28], false);FlatIPAddressinetArray1M.AssertModel(models[13],_testData[29], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 60, query1, 80, query2))
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSelectModelBatchAsync(connection, 11, 93))
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
                        Assert.That(models, Has.Count.EqualTo(10));
IPAddressinetArray1M.AssertModel(models[0],_testData[20], false);IPAddressinetArray1M.AssertModel(models[1],_testData[21], false);IPAddressinetArray1M.AssertModel(models[2],_testData[22], false);IPAddressinetArray1M.AssertModel(models[3],_testData[23], false);IPAddressinetArray1M.AssertModel(models[4],_testData[24], false);IPAddressinetArray1M.AssertModel(models[5],_testData[25], false);IPAddressinetArray1M.AssertModel(models[6],_testData[26], false);IPAddressinetArray1M.AssertModel(models[7],_testData[27], false);IPAddressinetArray1M.AssertModel(models[8],_testData[28], false);IPAddressinetArray1M.AssertModel(models[9],_testData[29], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSelectModelBatch(connection, 10, 10))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
IPAddressinetArray1M.AssertModel(models[0],_testData[2], false);IPAddressinetArray1M.AssertModel(models[1],_testData[3], false);IPAddressinetArray1M.AssertModel(models[2],_testData[4], false);IPAddressinetArray1M.AssertModel(models[3],_testData[5], false);IPAddressinetArray1M.AssertModel(models[4],_testData[6], false);IPAddressinetArray1M.AssertModel(models[5],_testData[7], false);IPAddressinetArray1M.AssertModel(models[6],_testData[8], false);IPAddressinetArray1M.AssertModel(models[7],_testData[9], false);IPAddressinetArray1M.AssertModel(models[8],_testData[10], false);IPAddressinetArray1M.AssertModel(models[9],_testData[11], false);IPAddressinetArray1M.AssertModel(models[10],_testData[12], false);IPAddressinetArray1M.AssertModel(models[11],_testData[13], false);IPAddressinetArray1M.AssertModel(models[12],_testData[14], false);IPAddressinetArray1M.AssertModel(models[13],_testData[15], false);IPAddressinetArray1M.AssertModel(models[14],_testData[16], false);IPAddressinetArray1M.AssertModel(models[15],_testData[17], false);IPAddressinetArray1M.AssertModel(models[16],_testData[18], false);IPAddressinetArray1M.AssertModel(models[17],_testData[19], false);IPAddressinetArray1M.AssertModel(models[18],_testData[20], false);IPAddressinetArray1M.AssertModel(models[19],_testData[21], false);IPAddressinetArray1M.AssertModel(models[20],_testData[22], false);IPAddressinetArray1M.AssertModel(models[21],_testData[23], false);IPAddressinetArray1M.AssertModel(models[22],_testData[24], false);IPAddressinetArray1M.AssertModel(models[23],_testData[25], false);IPAddressinetArray1M.AssertModel(models[24],_testData[26], false);IPAddressinetArray1M.AssertModel(models[25],_testData[27], false);IPAddressinetArray1M.AssertModel(models[26],_testData[28], false);IPAddressinetArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
IPAddressinetArray1M.AssertModel(models[0],_testData[2], false);IPAddressinetArray1M.AssertModel(models[1],_testData[3], false);IPAddressinetArray1M.AssertModel(models[2],_testData[4], false);IPAddressinetArray1M.AssertModel(models[3],_testData[5], false);IPAddressinetArray1M.AssertModel(models[4],_testData[6], false);IPAddressinetArray1M.AssertModel(models[5],_testData[7], false);IPAddressinetArray1M.AssertModel(models[6],_testData[8], false);IPAddressinetArray1M.AssertModel(models[7],_testData[9], false);IPAddressinetArray1M.AssertModel(models[8],_testData[10], false);IPAddressinetArray1M.AssertModel(models[9],_testData[11], false);IPAddressinetArray1M.AssertModel(models[10],_testData[12], false);IPAddressinetArray1M.AssertModel(models[11],_testData[13], false);IPAddressinetArray1M.AssertModel(models[12],_testData[14], false);IPAddressinetArray1M.AssertModel(models[13],_testData[15], false);IPAddressinetArray1M.AssertModel(models[14],_testData[16], false);IPAddressinetArray1M.AssertModel(models[15],_testData[17], false);IPAddressinetArray1M.AssertModel(models[16],_testData[18], false);IPAddressinetArray1M.AssertModel(models[17],_testData[19], false);IPAddressinetArray1M.AssertModel(models[18],_testData[20], false);IPAddressinetArray1M.AssertModel(models[19],_testData[21], false);IPAddressinetArray1M.AssertModel(models[20],_testData[22], false);IPAddressinetArray1M.AssertModel(models[21],_testData[23], false);IPAddressinetArray1M.AssertModel(models[22],_testData[24], false);IPAddressinetArray1M.AssertModel(models[23],_testData[25], false);IPAddressinetArray1M.AssertModel(models[24],_testData[26], false);IPAddressinetArray1M.AssertModel(models[25],_testData[27], false);IPAddressinetArray1M.AssertModel(models[26],_testData[28], false);IPAddressinetArray1M.AssertModel(models[27],_testData[29], false);
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
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 11);
                var models = await ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
IPAddressinetArray1M.AssertModel(models[0],_testData[3], false);IPAddressinetArray1M.AssertModel(models[1],_testData[4], false);IPAddressinetArray1M.AssertModel(models[2],_testData[5], false);IPAddressinetArray1M.AssertModel(models[3],_testData[6], false);IPAddressinetArray1M.AssertModel(models[4],_testData[7], false);IPAddressinetArray1M.AssertModel(models[5],_testData[8], false);IPAddressinetArray1M.AssertModel(models[6],_testData[9], false);IPAddressinetArray1M.AssertModel(models[7],_testData[10], false);IPAddressinetArray1M.AssertModel(models[8],_testData[11], false);IPAddressinetArray1M.AssertModel(models[9],_testData[12], false);IPAddressinetArray1M.AssertModel(models[10],_testData[13], false);IPAddressinetArray1M.AssertModel(models[11],_testData[14], false);IPAddressinetArray1M.AssertModel(models[12],_testData[15], false);IPAddressinetArray1M.AssertModel(models[13],_testData[16], false);IPAddressinetArray1M.AssertModel(models[14],_testData[17], false);IPAddressinetArray1M.AssertModel(models[15],_testData[18], false);IPAddressinetArray1M.AssertModel(models[16],_testData[19], false);IPAddressinetArray1M.AssertModel(models[17],_testData[20], false);IPAddressinetArray1M.AssertModel(models[18],_testData[21], false);IPAddressinetArray1M.AssertModel(models[19],_testData[22], false);IPAddressinetArray1M.AssertModel(models[20],_testData[23], false);IPAddressinetArray1M.AssertModel(models[21],_testData[24], false);IPAddressinetArray1M.AssertModel(models[22],_testData[25], false);IPAddressinetArray1M.AssertModel(models[23],_testData[26], false);IPAddressinetArray1M.AssertModel(models[24],_testData[27], false);IPAddressinetArray1M.AssertModel(models[25],_testData[28], false);IPAddressinetArray1M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 77);
                var models =  ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
IPAddressinetArray1M.AssertModel(models[0],_testData[17], false);IPAddressinetArray1M.AssertModel(models[1],_testData[18], false);IPAddressinetArray1M.AssertModel(models[2],_testData[19], false);IPAddressinetArray1M.AssertModel(models[3],_testData[20], false);IPAddressinetArray1M.AssertModel(models[4],_testData[21], false);IPAddressinetArray1M.AssertModel(models[5],_testData[22], false);IPAddressinetArray1M.AssertModel(models[6],_testData[23], false);IPAddressinetArray1M.AssertModel(models[7],_testData[24], false);IPAddressinetArray1M.AssertModel(models[8],_testData[25], false);IPAddressinetArray1M.AssertModel(models[9],_testData[26], false);IPAddressinetArray1M.AssertModel(models[10],_testData[27], false);IPAddressinetArray1M.AssertModel(models[11],_testData[28], false);IPAddressinetArray1M.AssertModel(models[12],_testData[29], false);
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

