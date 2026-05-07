

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
System.Net.IPAddress.Parse("85.142.132.31"),

System.Net.IPAddress.Parse("201.226.60.4"),

System.Net.IPAddress.Parse("34.175.91.204"),

System.Net.IPAddress.Parse("179.71.166.31"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("48.196.112.180"),

System.Net.IPAddress.Parse("138.174.42.243"),

System.Net.IPAddress.Parse("146.99.167.74"),

System.Net.IPAddress.Parse("133.16.232.171"),

},
},
            new IPAddressinetArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("203.36.106.221"),

System.Net.IPAddress.Parse("172.76.104.28"),

System.Net.IPAddress.Parse("252.235.149.126"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("46.0.46.69"),

System.Net.IPAddress.Parse("73.14.39.20"),

System.Net.IPAddress.Parse("7.31.126.228"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("199.122.230.72"),

System.Net.IPAddress.Parse("120.24.143.19"),

System.Net.IPAddress.Parse("60.246.101.7"),

},
},
            new IPAddressinetArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("174.88.78.107"),

System.Net.IPAddress.Parse("236.69.106.148"),

System.Net.IPAddress.Parse("95.30.80.88"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("135.138.161.172"),

System.Net.IPAddress.Parse("104.139.74.150"),

System.Net.IPAddress.Parse("106.163.215.87"),

System.Net.IPAddress.Parse("120.166.110.27"),

},
},
            new IPAddressinetArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("108.115.58.146"),

System.Net.IPAddress.Parse("148.55.236.14"),

System.Net.IPAddress.Parse("48.111.64.228"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("180.220.240.133"),

System.Net.IPAddress.Parse("167.168.154.160"),

System.Net.IPAddress.Parse("240.14.167.167"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("161.45.193.222"),

System.Net.IPAddress.Parse("232.22.197.224"),

System.Net.IPAddress.Parse("25.115.123.245"),

},
},
            new IPAddressinetArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("236.61.169.211"),

System.Net.IPAddress.Parse("179.215.92.88"),

System.Net.IPAddress.Parse("192.55.12.201"),

System.Net.IPAddress.Parse("95.10.130.152"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("118.36.1.150"),

System.Net.IPAddress.Parse("186.86.163.205"),

System.Net.IPAddress.Parse("220.136.53.211"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("112.66.128.189"),

System.Net.IPAddress.Parse("204.111.7.96"),

System.Net.IPAddress.Parse("127.60.204.22"),

System.Net.IPAddress.Parse("238.249.213.148"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("251.68.66.150"),

System.Net.IPAddress.Parse("93.217.242.44"),

System.Net.IPAddress.Parse("31.189.247.176"),

System.Net.IPAddress.Parse("71.82.236.168"),

},
},
            new IPAddressinetArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("73.122.249.80"),

System.Net.IPAddress.Parse("209.126.181.145"),

System.Net.IPAddress.Parse("7.45.74.237"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("79.11.197.168"),

System.Net.IPAddress.Parse("90.34.162.15"),

System.Net.IPAddress.Parse("223.172.5.137"),

System.Net.IPAddress.Parse("38.250.84.12"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("184.212.247.178"),

System.Net.IPAddress.Parse("91.12.14.38"),

System.Net.IPAddress.Parse("85.62.66.100"),

System.Net.IPAddress.Parse("3.162.111.10"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("95.240.248.80"),

System.Net.IPAddress.Parse("168.35.57.5"),

System.Net.IPAddress.Parse("215.175.126.7"),

System.Net.IPAddress.Parse("219.68.95.245"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("98.208.167.123"),

System.Net.IPAddress.Parse("157.199.250.109"),

System.Net.IPAddress.Parse("5.133.207.105"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("74.196.231.231"),

System.Net.IPAddress.Parse("38.55.82.35"),

System.Net.IPAddress.Parse("230.14.188.245"),

},
},
            new IPAddressinetArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("234.9.248.46"),

System.Net.IPAddress.Parse("213.87.128.232"),

System.Net.IPAddress.Parse("139.42.0.163"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("91.154.252.174"),

System.Net.IPAddress.Parse("17.169.217.197"),

System.Net.IPAddress.Parse("44.53.215.246"),

System.Net.IPAddress.Parse("116.215.38.164"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("116.169.176.109"),

System.Net.IPAddress.Parse("188.141.127.108"),

System.Net.IPAddress.Parse("196.85.141.191"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("144.185.70.42"),

System.Net.IPAddress.Parse("26.216.222.38"),

System.Net.IPAddress.Parse("180.1.229.170"),

System.Net.IPAddress.Parse("72.182.92.114"),

},
},
            new IPAddressinetArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("65.146.119.26"),

System.Net.IPAddress.Parse("187.16.132.231"),

System.Net.IPAddress.Parse("132.192.72.239"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("149.3.79.192"),

System.Net.IPAddress.Parse("189.250.53.181"),

System.Net.IPAddress.Parse("49.242.57.98"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("116.79.160.209"),

System.Net.IPAddress.Parse("147.4.245.213"),

System.Net.IPAddress.Parse("148.220.240.149"),

System.Net.IPAddress.Parse("193.121.206.142"),

},
},
            new IPAddressinetArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("11.217.233.100"),

System.Net.IPAddress.Parse("32.57.74.172"),

System.Net.IPAddress.Parse("57.93.126.37"),

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
System.Net.IPAddress.Parse("175.229.195.173"),

System.Net.IPAddress.Parse("234.122.244.228"),

System.Net.IPAddress.Parse("85.31.107.34"),

System.Net.IPAddress.Parse("117.13.0.70"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("37.218.236.53"),

System.Net.IPAddress.Parse("176.90.184.132"),

System.Net.IPAddress.Parse("43.81.25.14"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("5.66.29.165"),

System.Net.IPAddress.Parse("88.105.46.58"),

System.Net.IPAddress.Parse("170.100.13.202"),

System.Net.IPAddress.Parse("194.168.203.169"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("189.34.93.114"),

System.Net.IPAddress.Parse("81.52.136.58"),

System.Net.IPAddress.Parse("242.47.180.116"),

System.Net.IPAddress.Parse("168.180.91.164"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("65.7.82.26"),

System.Net.IPAddress.Parse("229.37.244.161"),

System.Net.IPAddress.Parse("70.174.136.181"),

System.Net.IPAddress.Parse("193.249.104.213"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("70.51.43.51"),

System.Net.IPAddress.Parse("72.22.73.116"),

System.Net.IPAddress.Parse("114.229.142.213"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("210.84.82.102"),

System.Net.IPAddress.Parse("61.247.59.162"),

System.Net.IPAddress.Parse("6.152.51.86"),

},
},
            new IPAddressinetArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("90.194.31.212"),

System.Net.IPAddress.Parse("52.102.167.120"),

System.Net.IPAddress.Parse("245.58.5.172"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("151.123.240.124"),

System.Net.IPAddress.Parse("228.54.170.247"),

System.Net.IPAddress.Parse("218.250.188.103"),

System.Net.IPAddress.Parse("35.98.87.115"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("64.34.222.119"),

System.Net.IPAddress.Parse("124.119.29.217"),

System.Net.IPAddress.Parse("18.92.50.98"),

System.Net.IPAddress.Parse("40.138.154.227"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("2.20.72.116"),

System.Net.IPAddress.Parse("85.174.123.41"),

System.Net.IPAddress.Parse("145.8.50.94"),

System.Net.IPAddress.Parse("20.42.138.237"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("110.48.30.131"),

System.Net.IPAddress.Parse("217.23.187.135"),

System.Net.IPAddress.Parse("151.241.84.160"),

System.Net.IPAddress.Parse("139.141.124.5"),

},
},
            new IPAddressinetArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("119.98.139.31"),

System.Net.IPAddress.Parse("156.56.66.174"),

System.Net.IPAddress.Parse("199.81.99.204"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("153.95.204.48"),

System.Net.IPAddress.Parse("145.120.220.165"),

System.Net.IPAddress.Parse("134.27.8.195"),

System.Net.IPAddress.Parse("227.148.112.172"),

},
},
            new IPAddressinetArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("52.99.172.26"),

System.Net.IPAddress.Parse("198.110.205.180"),

System.Net.IPAddress.Parse("165.107.253.97"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("97.134.180.146"),

System.Net.IPAddress.Parse("63.234.218.137"),

System.Net.IPAddress.Parse("142.81.69.112"),

System.Net.IPAddress.Parse("237.91.114.66"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("37.45.127.194"),

System.Net.IPAddress.Parse("160.236.198.77"),

System.Net.IPAddress.Parse("28.1.74.232"),

System.Net.IPAddress.Parse("57.185.33.174"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("144.46.63.2"),

System.Net.IPAddress.Parse("194.93.27.15"),

System.Net.IPAddress.Parse("178.97.216.26"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("159.21.219.8"),

System.Net.IPAddress.Parse("206.130.120.82"),

System.Net.IPAddress.Parse("74.167.17.123"),

System.Net.IPAddress.Parse("158.18.43.211"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("116.73.48.159"),

System.Net.IPAddress.Parse("106.162.17.254"),

System.Net.IPAddress.Parse("224.189.85.147"),

System.Net.IPAddress.Parse("120.42.102.62"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("209.43.122.168"),

System.Net.IPAddress.Parse("183.212.244.61"),

System.Net.IPAddress.Parse("21.88.137.54"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("40.208.199.164"),

System.Net.IPAddress.Parse("18.157.44.26"),

System.Net.IPAddress.Parse("20.157.199.149"),

System.Net.IPAddress.Parse("202.128.5.233"),

},
},
            new IPAddressinetArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("193.64.44.157"),

System.Net.IPAddress.Parse("199.180.181.213"),

System.Net.IPAddress.Parse("219.4.27.160"),

System.Net.IPAddress.Parse("123.212.57.216"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("58.138.155.164"),

System.Net.IPAddress.Parse("234.237.155.99"),

System.Net.IPAddress.Parse("130.46.106.120"),

System.Net.IPAddress.Parse("248.189.151.154"),

},
},
            new IPAddressinetArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("106.64.132.84"),

System.Net.IPAddress.Parse("188.46.147.248"),

System.Net.IPAddress.Parse("17.35.250.213"),

System.Net.IPAddress.Parse("43.120.208.31"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("128.214.235.1"),

System.Net.IPAddress.Parse("145.23.146.112"),

System.Net.IPAddress.Parse("217.31.35.106"),

System.Net.IPAddress.Parse("9.75.250.120"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("46.185.141.88"),

System.Net.IPAddress.Parse("241.99.242.200"),

System.Net.IPAddress.Parse("162.134.12.12"),

System.Net.IPAddress.Parse("234.247.40.175"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("164.12.238.129"),

System.Net.IPAddress.Parse("0.178.34.222"),

System.Net.IPAddress.Parse("196.34.144.150"),

System.Net.IPAddress.Parse("18.109.81.70"),

},
},
            new IPAddressinetArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("120.159.4.204"),

System.Net.IPAddress.Parse("65.167.18.53"),

System.Net.IPAddress.Parse("162.18.221.243"),

System.Net.IPAddress.Parse("148.180.12.52"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("167.120.236.95"),

System.Net.IPAddress.Parse("214.152.172.81"),

System.Net.IPAddress.Parse("23.196.75.113"),

System.Net.IPAddress.Parse("23.17.219.199"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("210.131.199.19"),

System.Net.IPAddress.Parse("205.85.59.201"),

System.Net.IPAddress.Parse("24.36.223.138"),

System.Net.IPAddress.Parse("137.230.209.72"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("34.128.212.16"),

System.Net.IPAddress.Parse("94.81.71.49"),

System.Net.IPAddress.Parse("222.95.11.63"),

},
},
            new IPAddressinetArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("112.72.174.48"),

System.Net.IPAddress.Parse("193.212.147.136"),

System.Net.IPAddress.Parse("214.141.92.106"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("107.192.97.9"),

System.Net.IPAddress.Parse("210.169.23.25"),

System.Net.IPAddress.Parse("240.140.151.247"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("28.113.1.180"),

System.Net.IPAddress.Parse("158.200.146.134"),

System.Net.IPAddress.Parse("196.113.79.160"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("75.246.155.203"),

System.Net.IPAddress.Parse("9.127.6.114"),

System.Net.IPAddress.Parse("82.175.163.244"),

System.Net.IPAddress.Parse("91.227.241.227"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("199.80.244.80"),

System.Net.IPAddress.Parse("185.229.127.160"),

System.Net.IPAddress.Parse("51.102.123.245"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("2.235.115.225"),

System.Net.IPAddress.Parse("221.9.2.98"),

System.Net.IPAddress.Parse("211.51.142.240"),

},
},
            new IPAddressinetArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("71.179.235.234"),

System.Net.IPAddress.Parse("117.224.182.172"),

System.Net.IPAddress.Parse("145.29.52.165"),

System.Net.IPAddress.Parse("44.233.45.248"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("145.40.130.195"),

System.Net.IPAddress.Parse("65.179.11.167"),

System.Net.IPAddress.Parse("158.198.137.0"),

System.Net.IPAddress.Parse("184.190.69.43"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("47.253.102.164"),

System.Net.IPAddress.Parse("179.11.166.169"),

System.Net.IPAddress.Parse("147.121.168.162"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("29.173.5.145"),

System.Net.IPAddress.Parse("241.211.67.65"),

System.Net.IPAddress.Parse("46.122.184.8"),

},
},
            new IPAddressinetArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("163.226.222.0"),

System.Net.IPAddress.Parse("155.11.179.106"),

System.Net.IPAddress.Parse("30.236.6.31"),

System.Net.IPAddress.Parse("136.108.191.155"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("149.11.199.138"),

System.Net.IPAddress.Parse("174.63.8.134"),

System.Net.IPAddress.Parse("209.3.20.39"),

System.Net.IPAddress.Parse("19.164.186.214"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("201.167.0.93"),

System.Net.IPAddress.Parse("141.53.197.144"),

System.Net.IPAddress.Parse("75.2.38.30"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("55.34.144.113"),

System.Net.IPAddress.Parse("89.44.130.67"),

System.Net.IPAddress.Parse("55.27.18.111"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("29.135.138.142"),

System.Net.IPAddress.Parse("171.21.225.0"),

System.Net.IPAddress.Parse("101.209.229.54"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("129.242.64.38"),

System.Net.IPAddress.Parse("33.100.236.181"),

System.Net.IPAddress.Parse("179.197.155.5"),

System.Net.IPAddress.Parse("37.33.209.252"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("209.109.252.74"),

System.Net.IPAddress.Parse("199.34.139.246"),

System.Net.IPAddress.Parse("241.0.204.175"),

System.Net.IPAddress.Parse("104.186.24.173"),

},
},
            new IPAddressinetArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("44.130.59.209"),

System.Net.IPAddress.Parse("186.88.76.209"),

System.Net.IPAddress.Parse("80.83.249.70"),

},
    ModelInner = null,
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

                id = await ((IIPAddressListinetArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IIPAddressListinetArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray2M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 153;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
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
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 86;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
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
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
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
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
                        FlatIPAddressinetArray2M.AssertModel(models[24],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[25],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[26],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[27],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

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
                        FlatIPAddressinetArray2M.AssertModel(models[25],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[26],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[27],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[28],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
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
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
                        Assert.That(models, Has.Count.EqualTo(17));

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
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[15],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

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
                        IPAddressinetArray2M.AssertModel(models[10],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

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
                        IPAddressinetArray2M.AssertModel(models[23],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[24],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[25],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[26],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[27],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
                        IPAddressinetArray2M.AssertModel(models[11],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[14],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

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
                        IPAddressinetArray2M.AssertModel(models[12],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[14],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[15],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[16],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
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
                await ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 42, query1, 153, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
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
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[34], false);
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
                await ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 86, query1, 148, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 74, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
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
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[34], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 118, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
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
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[31],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 57, query1, 117, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        FlatIPAddressinetArray2M.AssertModel(models[18],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[19],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[20],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[21],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[34], false);
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
                await ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 26, query1, 111, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
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
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
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
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 23, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

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
                        FlatIPAddressinetArray2M.AssertModel(models[27],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[28],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[29],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[30],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

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
                        FlatIPAddressinetArray2M.AssertModel(models[19],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[20],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[21],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[22],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[23],_testData[34], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 86, query1, 148, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 118, 132))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[29], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[29], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatch(connection, 25, 125))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[5], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[6], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[7], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[8], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[9], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[10], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[11], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[12], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[13], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[14], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[15], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[16], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[17], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[18], false);
                        IPAddressinetArray2M.AssertModel(models[14],_testData[19], false);
                        IPAddressinetArray2M.AssertModel(models[15],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[16],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[17],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[18],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[19],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[20],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[21],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[22],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[23],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[24],_testData[29], false);
                        IPAddressinetArray2M.AssertModel(models[25],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[26],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[27],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[28],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[29], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[34], false);
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
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 42);
                var models = await ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

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
                IPAddressinetArray2M.AssertModel(models[22],_testData[30], false);
                IPAddressinetArray2M.AssertModel(models[23],_testData[31], false);
                IPAddressinetArray2M.AssertModel(models[24],_testData[32], false);
                IPAddressinetArray2M.AssertModel(models[25],_testData[33], false);
                IPAddressinetArray2M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressListinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 136);
                var models =  ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                IPAddressinetArray2M.AssertModel(models[0],_testData[28], false);
                IPAddressinetArray2M.AssertModel(models[1],_testData[29], false);
                IPAddressinetArray2M.AssertModel(models[2],_testData[30], false);
                IPAddressinetArray2M.AssertModel(models[3],_testData[31], false);
                IPAddressinetArray2M.AssertModel(models[4],_testData[32], false);
                IPAddressinetArray2M.AssertModel(models[5],_testData[33], false);
                IPAddressinetArray2M.AssertModel(models[6],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
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

                await ((IIPAddressListinetArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinetarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IIPAddressListinetArray)this).DynQueryWASelectImportModelInnerAsync(connection);
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

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<IPAddressinetArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
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

                ((IIPAddressListinetArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinetarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressListinetArray)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IIPAddressListinetArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<IPAddressinetArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressListinetArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IIPAddressListinetArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IIPAddressListinetArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<IPAddressinetArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IIPAddressListinetArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IIPAddressListinetArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(IPAddressinetArray2MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(IPAddressinetArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((IIPAddressListinetArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IIPAddressListinetArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<IPAddressinetArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((IIPAddressListinetArray)this).ImportModelInner(connection, importCollection);
                var models = ((IIPAddressListinetArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IIPAddressListinetArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IIPAddressListinetArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    IPAddressinetArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(10)]
        public  void ImportModelTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<IPAddressinetArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IIPAddressListinetArray)this).ImportModel(connection, importCollection);
                var models = ((IIPAddressListinetArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    IPAddressinetArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
            })]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray2MIWA), typeof(IPAddressinetArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
            })]
        private void MMDynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<IPAddressinetArray2MIWA>();
                var models2 = new List<IPAddressinetArray2MIWA>();
                await ((IIPAddressListinetArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<IPAddressinetArray2MIWA>();
                var models2 = new List<IPAddressinetArray2MIWA>();
                ((IIPAddressListinetArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
            })]
        private void DynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IIPAddressListinetArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_ipaddressinetarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IIPAddressListinetArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_ipaddressinetarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray2MIWA), typeof(IPAddressinetArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray))]
        private void MMDynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<IPAddressinetArray2MIWA>();
                var models2 = new List<IPAddressinetArray2MIWA>();
                await ((IIPAddressListinetArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<IPAddressinetArray2MIWA>();
                var models2 = new List<IPAddressinetArray2MIWA>();
                ((IIPAddressListinetArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IIPAddressListinetArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_ipaddressinetarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IIPAddressListinetArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_ipaddressinetarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray2MI), typeof(IPAddressinetArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
            })]
        private void MMWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<IPAddressinetArray2MI>();
                var models2 = new List<IPAddressinetArray2MI>();
                await ((IIPAddressListinetArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<IPAddressinetArray2MI>();
                var models2 = new List<IPAddressinetArray2MI>();
                ((IIPAddressListinetArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
            })]
        private void WAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task WAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IIPAddressListinetArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IIPAddressListinetArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray2MIWA), typeof(IPAddressinetArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray))]
        private void MMExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<IPAddressinetArray2MIWA>();
                var models2 = new List<IPAddressinetArray2MIWA>();
                await ((IIPAddressListinetArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<IPAddressinetArray2MIWA>();
                var models2 = new List<IPAddressinetArray2MIWA>();
                ((IIPAddressListinetArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IIPAddressListinetArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IIPAddressListinetArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

