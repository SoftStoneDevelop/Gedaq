

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("158.213.156.230"),

System.Net.IPAddress.Parse("8.160.244.116"),

System.Net.IPAddress.Parse("20.145.158.188"),

System.Net.IPAddress.Parse("134.237.167.226"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("74.213.223.222"),

System.Net.IPAddress.Parse("216.200.138.134"),

System.Net.IPAddress.Parse("1.114.94.193"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("215.66.80.78"),

System.Net.IPAddress.Parse("20.234.58.235"),

System.Net.IPAddress.Parse("221.169.73.78"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.14.58.176"),

System.Net.IPAddress.Parse("125.19.58.124"),

System.Net.IPAddress.Parse("160.28.91.126"),

System.Net.IPAddress.Parse("80.181.21.70"),

},
},
            new IPAddressinetArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("62.101.86.107"),

System.Net.IPAddress.Parse("34.11.242.213"),

System.Net.IPAddress.Parse("150.249.179.68"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("36.33.137.171"),

System.Net.IPAddress.Parse("144.219.201.103"),

System.Net.IPAddress.Parse("19.147.182.227"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("231.161.234.156"),

System.Net.IPAddress.Parse("160.11.167.221"),

System.Net.IPAddress.Parse("54.161.157.212"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("114.161.119.93"),

System.Net.IPAddress.Parse("202.21.180.173"),

System.Net.IPAddress.Parse("187.215.160.179"),

},
},
            new IPAddressinetArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("242.138.90.177"),

System.Net.IPAddress.Parse("197.139.253.93"),

System.Net.IPAddress.Parse("40.83.77.63"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("74.193.140.235"),

System.Net.IPAddress.Parse("3.153.46.235"),

System.Net.IPAddress.Parse("140.226.76.97"),

System.Net.IPAddress.Parse("126.31.10.51"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("254.21.156.174"),

System.Net.IPAddress.Parse("111.137.173.33"),

System.Net.IPAddress.Parse("86.59.29.216"),

System.Net.IPAddress.Parse("86.207.179.234"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("140.40.108.17"),

System.Net.IPAddress.Parse("140.61.186.69"),

System.Net.IPAddress.Parse("15.14.244.48"),

},
},
            new IPAddressinetArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("210.0.156.4"),

System.Net.IPAddress.Parse("174.217.208.114"),

System.Net.IPAddress.Parse("58.183.170.32"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("5.4.95.232"),

System.Net.IPAddress.Parse("42.151.149.215"),

System.Net.IPAddress.Parse("93.15.36.170"),

System.Net.IPAddress.Parse("77.36.20.117"),

},
},
            new IPAddressinetArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("206.55.48.119"),

System.Net.IPAddress.Parse("227.97.90.242"),

System.Net.IPAddress.Parse("53.233.197.77"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("29.194.107.139"),

System.Net.IPAddress.Parse("44.134.194.17"),

System.Net.IPAddress.Parse("95.137.25.26"),

System.Net.IPAddress.Parse("42.211.20.85"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("215.134.202.180"),

System.Net.IPAddress.Parse("238.13.109.105"),

System.Net.IPAddress.Parse("79.223.246.62"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("209.109.216.77"),

System.Net.IPAddress.Parse("157.159.56.241"),

System.Net.IPAddress.Parse("26.83.47.138"),

},
},
            new IPAddressinetArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.117.241.103"),

System.Net.IPAddress.Parse("22.242.231.223"),

System.Net.IPAddress.Parse("136.147.112.1"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("97.37.145.73"),

System.Net.IPAddress.Parse("73.137.240.184"),

System.Net.IPAddress.Parse("117.106.228.96"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("185.44.155.35"),

System.Net.IPAddress.Parse("189.211.88.168"),

System.Net.IPAddress.Parse("38.4.201.117"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.149.114.17"),

System.Net.IPAddress.Parse("101.3.21.93"),

System.Net.IPAddress.Parse("196.192.142.75"),

System.Net.IPAddress.Parse("79.174.218.232"),

},
},
            new IPAddressinetArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("219.235.73.54"),

System.Net.IPAddress.Parse("141.67.227.221"),

System.Net.IPAddress.Parse("132.83.118.123"),

System.Net.IPAddress.Parse("219.228.65.136"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("149.151.246.130"),

System.Net.IPAddress.Parse("101.191.140.64"),

System.Net.IPAddress.Parse("187.129.98.70"),

System.Net.IPAddress.Parse("6.70.180.28"),

},
},
            new IPAddressinetArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("207.2.72.41"),

System.Net.IPAddress.Parse("54.187.48.168"),

System.Net.IPAddress.Parse("245.78.75.179"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("182.115.251.232"),

System.Net.IPAddress.Parse("113.18.122.162"),

System.Net.IPAddress.Parse("56.48.44.86"),

System.Net.IPAddress.Parse("201.166.34.25"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("152.22.49.240"),

System.Net.IPAddress.Parse("162.132.90.172"),

System.Net.IPAddress.Parse("88.84.164.213"),

System.Net.IPAddress.Parse("182.55.8.228"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("29.145.31.234"),

System.Net.IPAddress.Parse("71.113.148.145"),

System.Net.IPAddress.Parse("122.199.162.4"),

},
},
            new IPAddressinetArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("102.67.54.224"),

System.Net.IPAddress.Parse("24.37.183.23"),

System.Net.IPAddress.Parse("185.171.98.166"),

System.Net.IPAddress.Parse("25.145.55.2"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("38.8.6.15"),

System.Net.IPAddress.Parse("6.180.201.253"),

System.Net.IPAddress.Parse("158.244.197.234"),

System.Net.IPAddress.Parse("185.60.154.183"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("35.85.91.144"),

System.Net.IPAddress.Parse("100.69.176.225"),

System.Net.IPAddress.Parse("234.197.38.54"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("196.171.204.184"),

System.Net.IPAddress.Parse("60.74.168.53"),

System.Net.IPAddress.Parse("212.47.137.94"),

System.Net.IPAddress.Parse("73.5.101.126"),

},
},
            new IPAddressinetArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("129.153.81.163"),

System.Net.IPAddress.Parse("218.45.142.83"),

System.Net.IPAddress.Parse("57.12.41.188"),

System.Net.IPAddress.Parse("76.39.32.254"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("198.161.10.199"),

System.Net.IPAddress.Parse("30.79.216.154"),

System.Net.IPAddress.Parse("123.210.77.205"),

System.Net.IPAddress.Parse("251.173.176.6"),

},
},
            new IPAddressinetArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("215.151.212.233"),

System.Net.IPAddress.Parse("206.93.103.100"),

System.Net.IPAddress.Parse("206.60.116.241"),

System.Net.IPAddress.Parse("107.226.219.105"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("197.157.2.32"),

System.Net.IPAddress.Parse("196.131.199.75"),

System.Net.IPAddress.Parse("235.36.138.223"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("235.67.209.216"),

System.Net.IPAddress.Parse("73.32.235.124"),

System.Net.IPAddress.Parse("38.207.157.123"),

System.Net.IPAddress.Parse("170.205.89.247"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("194.107.30.158"),

System.Net.IPAddress.Parse("229.42.120.100"),

System.Net.IPAddress.Parse("247.196.42.157"),

System.Net.IPAddress.Parse("115.144.15.252"),

},
},
            new IPAddressinetArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("27.163.83.144"),

System.Net.IPAddress.Parse("64.198.55.197"),

System.Net.IPAddress.Parse("233.82.108.145"),

System.Net.IPAddress.Parse("116.181.206.173"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("19.169.118.64"),

System.Net.IPAddress.Parse("169.160.223.63"),

System.Net.IPAddress.Parse("159.37.55.202"),

System.Net.IPAddress.Parse("170.164.213.131"),

},
},
            new IPAddressinetArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("33.113.73.1"),

System.Net.IPAddress.Parse("168.237.187.239"),

System.Net.IPAddress.Parse("213.81.101.155"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("177.35.23.162"),

System.Net.IPAddress.Parse("136.220.125.180"),

System.Net.IPAddress.Parse("179.77.216.161"),

System.Net.IPAddress.Parse("229.96.0.84"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("74.128.121.106"),

System.Net.IPAddress.Parse("215.152.23.244"),

System.Net.IPAddress.Parse("129.205.193.85"),

System.Net.IPAddress.Parse("64.117.5.37"),

},
},
            new IPAddressinetArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("253.231.72.57"),

System.Net.IPAddress.Parse("84.7.198.126"),

System.Net.IPAddress.Parse("13.19.157.110"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("69.147.44.10"),

System.Net.IPAddress.Parse("66.165.157.15"),

System.Net.IPAddress.Parse("142.160.100.25"),

System.Net.IPAddress.Parse("132.15.184.61"),

},
},
            new IPAddressinetArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("56.250.86.35"),

System.Net.IPAddress.Parse("59.207.112.212"),

System.Net.IPAddress.Parse("223.233.56.74"),

System.Net.IPAddress.Parse("134.3.16.4"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("107.137.74.134"),

System.Net.IPAddress.Parse("234.167.192.126"),

System.Net.IPAddress.Parse("63.30.191.244"),

System.Net.IPAddress.Parse("43.11.135.21"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("158.115.152.54"),

System.Net.IPAddress.Parse("24.25.64.138"),

System.Net.IPAddress.Parse("238.248.106.111"),

System.Net.IPAddress.Parse("17.17.89.49"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("50.238.240.67"),

System.Net.IPAddress.Parse("147.101.204.210"),

System.Net.IPAddress.Parse("226.80.52.90"),

System.Net.IPAddress.Parse("51.130.36.116"),

},
},
            new IPAddressinetArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("58.185.133.179"),

System.Net.IPAddress.Parse("66.152.226.110"),

System.Net.IPAddress.Parse("102.191.244.166"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("213.32.59.95"),

System.Net.IPAddress.Parse("178.79.103.241"),

System.Net.IPAddress.Parse("252.5.230.231"),

System.Net.IPAddress.Parse("253.238.231.7"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("96.89.62.40"),

System.Net.IPAddress.Parse("85.244.220.241"),

System.Net.IPAddress.Parse("88.132.86.177"),

System.Net.IPAddress.Parse("225.86.118.46"),

},
},
            new IPAddressinetArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("226.10.81.158"),

System.Net.IPAddress.Parse("119.127.192.229"),

System.Net.IPAddress.Parse("185.17.123.4"),

System.Net.IPAddress.Parse("32.58.191.144"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("191.231.158.216"),

System.Net.IPAddress.Parse("101.185.235.179"),

System.Net.IPAddress.Parse("199.223.7.104"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("13.6.26.91"),

System.Net.IPAddress.Parse("141.246.156.254"),

System.Net.IPAddress.Parse("25.150.172.188"),

System.Net.IPAddress.Parse("226.135.49.57"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("98.193.227.4"),

System.Net.IPAddress.Parse("86.156.190.209"),

System.Net.IPAddress.Parse("89.56.131.210"),

System.Net.IPAddress.Parse("198.31.202.112"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("140.41.174.147"),

System.Net.IPAddress.Parse("109.128.122.186"),

System.Net.IPAddress.Parse("16.100.183.26"),

System.Net.IPAddress.Parse("153.26.174.199"),

},
},
            new IPAddressinetArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("12.78.231.82"),

System.Net.IPAddress.Parse("246.168.246.74"),

System.Net.IPAddress.Parse("210.131.96.135"),

System.Net.IPAddress.Parse("71.3.118.66"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("107.245.115.88"),

System.Net.IPAddress.Parse("61.165.187.135"),

System.Net.IPAddress.Parse("34.102.55.38"),

System.Net.IPAddress.Parse("32.105.250.201"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("156.72.246.108"),

System.Net.IPAddress.Parse("41.108.150.37"),

System.Net.IPAddress.Parse("56.9.52.23"),

},
},
            new IPAddressinetArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("135.113.120.56"),

System.Net.IPAddress.Parse("21.187.94.219"),

System.Net.IPAddress.Parse("248.39.58.151"),

System.Net.IPAddress.Parse("6.15.153.43"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("226.84.157.26"),

System.Net.IPAddress.Parse("225.185.182.181"),

System.Net.IPAddress.Parse("240.13.63.188"),

},
},
            new IPAddressinetArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("236.51.73.93"),

System.Net.IPAddress.Parse("251.61.39.166"),

System.Net.IPAddress.Parse("163.200.141.150"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("139.158.209.2"),

System.Net.IPAddress.Parse("71.224.6.229"),

System.Net.IPAddress.Parse("174.220.73.84"),

System.Net.IPAddress.Parse("41.9.226.236"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("246.231.102.81"),

System.Net.IPAddress.Parse("208.96.77.130"),

System.Net.IPAddress.Parse("159.109.203.241"),

System.Net.IPAddress.Parse("130.127.231.218"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("133.170.177.225"),

System.Net.IPAddress.Parse("78.96.130.33"),

System.Net.IPAddress.Parse("130.60.99.132"),

System.Net.IPAddress.Parse("109.91.225.254"),

},
},
            new IPAddressinetArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("228.243.177.95"),

System.Net.IPAddress.Parse("4.0.63.247"),

System.Net.IPAddress.Parse("110.189.216.94"),

System.Net.IPAddress.Parse("46.97.132.213"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("35.247.214.74"),

System.Net.IPAddress.Parse("79.84.108.25"),

System.Net.IPAddress.Parse("153.11.161.232"),

System.Net.IPAddress.Parse("254.145.115.24"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("242.68.175.6"),

System.Net.IPAddress.Parse("162.179.4.159"),

System.Net.IPAddress.Parse("44.162.124.36"),

},
},
    NullableValue = null,
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[29], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[29], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[29], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[29], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[8], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[9], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[10], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[11], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[12], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[13], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[14], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[15], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[16], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[17], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[18], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[19], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[14],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[15],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[16],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[17],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[18],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[19],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[20],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[2], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[3], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[4], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[5], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[6], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[7], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[8], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[9], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[10], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[11], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[12], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[13], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[14], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[15], false);
                        IPAddressinetArray2M.AssertModel(models[14],_testData[16], false);
                        IPAddressinetArray2M.AssertModel(models[15],_testData[17], false);
                        IPAddressinetArray2M.AssertModel(models[16],_testData[18], false);
                        IPAddressinetArray2M.AssertModel(models[17],_testData[19], false);
                        IPAddressinetArray2M.AssertModel(models[18],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[19],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[20],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[21],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[22],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[23],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[24],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[25],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[26],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[27],_testData[29], false);
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
                await ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 106, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                await ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 58, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[29], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 118, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 59, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[29], false);
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 53, query1, 61, query2))
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[29], false);
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
                await ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 106, query1, 70, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[29], false);
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 106, query1, 91, query2))
                {
                    if(++resultIndex == 1)
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
                 ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 37, query1, 64, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[29], false);
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 17, 61))
                {
                    if(++resultIndex == 1)
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatch(connection, 58, 59))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[14], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[15], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[16], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[17], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[18], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[19], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[14],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[15], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[16], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[17], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[18], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[19], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[14],_testData[29], false);
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
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 70);
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
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 17);
                var models =  ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
IPAddressinetArray2M.AssertModel(models[0],_testData[3], false);IPAddressinetArray2M.AssertModel(models[1],_testData[4], false);IPAddressinetArray2M.AssertModel(models[2],_testData[5], false);IPAddressinetArray2M.AssertModel(models[3],_testData[6], false);IPAddressinetArray2M.AssertModel(models[4],_testData[7], false);IPAddressinetArray2M.AssertModel(models[5],_testData[8], false);IPAddressinetArray2M.AssertModel(models[6],_testData[9], false);IPAddressinetArray2M.AssertModel(models[7],_testData[10], false);IPAddressinetArray2M.AssertModel(models[8],_testData[11], false);IPAddressinetArray2M.AssertModel(models[9],_testData[12], false);IPAddressinetArray2M.AssertModel(models[10],_testData[13], false);IPAddressinetArray2M.AssertModel(models[11],_testData[14], false);IPAddressinetArray2M.AssertModel(models[12],_testData[15], false);IPAddressinetArray2M.AssertModel(models[13],_testData[16], false);IPAddressinetArray2M.AssertModel(models[14],_testData[17], false);IPAddressinetArray2M.AssertModel(models[15],_testData[18], false);IPAddressinetArray2M.AssertModel(models[16],_testData[19], false);IPAddressinetArray2M.AssertModel(models[17],_testData[20], false);IPAddressinetArray2M.AssertModel(models[18],_testData[21], false);IPAddressinetArray2M.AssertModel(models[19],_testData[22], false);IPAddressinetArray2M.AssertModel(models[20],_testData[23], false);IPAddressinetArray2M.AssertModel(models[21],_testData[24], false);IPAddressinetArray2M.AssertModel(models[22],_testData[25], false);IPAddressinetArray2M.AssertModel(models[23],_testData[26], false);IPAddressinetArray2M.AssertModel(models[24],_testData[27], false);IPAddressinetArray2M.AssertModel(models[25],_testData[28], false);IPAddressinetArray2M.AssertModel(models[26],_testData[29], false);
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

