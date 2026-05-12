

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
    internal partial interface IIPAddressListinetListD1
    {
    }
    
    internal partial class IPAddressListinetListD1 : IIPAddressListinetListD1
    {


#region TestData

        private readonly IPAddressinetListD1E2M[] _testData = new IPAddressinetListD1E2M[]
        {
            new IPAddressinetListD1E2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("198.88.218.158"),

System.Net.IPAddress.Parse("195.232.80.185"),

System.Net.IPAddress.Parse("221.236.134.59"),

System.Net.IPAddress.Parse("11.162.46.222"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("48.171.217.63"),

System.Net.IPAddress.Parse("183.146.134.135"),

System.Net.IPAddress.Parse("145.243.82.196"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("123.169.246.129"),

System.Net.IPAddress.Parse("253.33.136.206"),

System.Net.IPAddress.Parse("3.139.73.141"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("245.166.248.205"),

System.Net.IPAddress.Parse("17.191.34.28"),

System.Net.IPAddress.Parse("121.106.13.244"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("80.38.52.59"),

System.Net.IPAddress.Parse("140.253.165.18"),

System.Net.IPAddress.Parse("48.105.162.48"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("241.122.32.243"),

System.Net.IPAddress.Parse("131.178.179.123"),

System.Net.IPAddress.Parse("58.52.25.148"),

System.Net.IPAddress.Parse("87.207.213.119"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("13.248.237.166"),

System.Net.IPAddress.Parse("53.31.105.97"),

System.Net.IPAddress.Parse("121.216.100.60"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("220.242.149.150"),

System.Net.IPAddress.Parse("85.177.24.222"),

System.Net.IPAddress.Parse("112.205.149.24"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("190.241.145.96"),

System.Net.IPAddress.Parse("151.81.134.126"),

System.Net.IPAddress.Parse("219.24.65.203"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("113.38.78.173"),

System.Net.IPAddress.Parse("81.94.2.221"),

System.Net.IPAddress.Parse("149.175.113.122"),

System.Net.IPAddress.Parse("41.229.12.239"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.80.17.32"),

System.Net.IPAddress.Parse("247.75.12.63"),

System.Net.IPAddress.Parse("95.210.25.247"),

System.Net.IPAddress.Parse("192.103.63.49"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("130.42.55.206"),

System.Net.IPAddress.Parse("161.63.138.58"),

System.Net.IPAddress.Parse("249.6.154.31"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("30.67.142.26"),

System.Net.IPAddress.Parse("161.5.187.208"),

System.Net.IPAddress.Parse("140.159.87.46"),

System.Net.IPAddress.Parse("239.27.90.229"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("1.241.108.147"),

System.Net.IPAddress.Parse("98.40.222.186"),

System.Net.IPAddress.Parse("1.16.236.191"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("35.28.113.217"),

System.Net.IPAddress.Parse("167.24.213.236"),

System.Net.IPAddress.Parse("116.117.231.27"),

System.Net.IPAddress.Parse("245.95.20.154"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("30.78.172.155"),

System.Net.IPAddress.Parse("24.49.151.41"),

System.Net.IPAddress.Parse("60.138.78.225"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("248.60.7.174"),

System.Net.IPAddress.Parse("28.151.76.50"),

System.Net.IPAddress.Parse("243.158.164.44"),

System.Net.IPAddress.Parse("32.63.151.44"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("108.174.1.102"),

System.Net.IPAddress.Parse("72.104.127.17"),

System.Net.IPAddress.Parse("128.149.152.202"),

System.Net.IPAddress.Parse("159.142.169.179"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("73.81.83.96"),

System.Net.IPAddress.Parse("93.125.94.199"),

System.Net.IPAddress.Parse("191.239.177.226"),

System.Net.IPAddress.Parse("240.60.179.174"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("20.199.26.120"),

System.Net.IPAddress.Parse("157.113.142.186"),

System.Net.IPAddress.Parse("100.8.160.224"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("29.37.57.182"),

System.Net.IPAddress.Parse("25.136.87.191"),

System.Net.IPAddress.Parse("175.105.65.142"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.209.38.87"),

System.Net.IPAddress.Parse("22.213.239.98"),

System.Net.IPAddress.Parse("185.45.42.81"),

System.Net.IPAddress.Parse("143.12.225.230"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("97.129.91.176"),

System.Net.IPAddress.Parse("39.182.164.59"),

System.Net.IPAddress.Parse("27.36.60.117"),

System.Net.IPAddress.Parse("54.160.211.4"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("144.215.13.243"),

System.Net.IPAddress.Parse("44.43.129.76"),

System.Net.IPAddress.Parse("39.185.165.153"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("228.191.126.70"),

System.Net.IPAddress.Parse("158.31.199.131"),

System.Net.IPAddress.Parse("198.185.83.125"),

System.Net.IPAddress.Parse("70.52.145.61"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("121.237.182.38"),

System.Net.IPAddress.Parse("57.124.143.4"),

System.Net.IPAddress.Parse("30.189.180.69"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("207.51.172.44"),

System.Net.IPAddress.Parse("63.193.206.220"),

System.Net.IPAddress.Parse("88.106.52.160"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("226.238.238.166"),

System.Net.IPAddress.Parse("248.118.20.181"),

System.Net.IPAddress.Parse("90.15.105.170"),

System.Net.IPAddress.Parse("226.213.195.38"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("42.7.87.106"),

System.Net.IPAddress.Parse("192.104.245.58"),

System.Net.IPAddress.Parse("48.116.48.67"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("230.5.103.92"),

System.Net.IPAddress.Parse("106.232.35.193"),

System.Net.IPAddress.Parse("56.80.91.188"),

System.Net.IPAddress.Parse("108.231.95.236"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("102.178.81.87"),

System.Net.IPAddress.Parse("99.69.216.42"),

System.Net.IPAddress.Parse("42.76.130.117"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("94.61.192.66"),

System.Net.IPAddress.Parse("36.16.4.145"),

System.Net.IPAddress.Parse("77.53.112.29"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("197.221.190.204"),

System.Net.IPAddress.Parse("193.207.231.203"),

System.Net.IPAddress.Parse("74.191.32.57"),

System.Net.IPAddress.Parse("228.153.16.168"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("142.229.25.205"),

System.Net.IPAddress.Parse("229.89.139.18"),

System.Net.IPAddress.Parse("95.213.209.178"),

System.Net.IPAddress.Parse("184.6.140.155"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("28.247.155.98"),

System.Net.IPAddress.Parse("67.127.247.46"),

System.Net.IPAddress.Parse("36.189.167.109"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("100.49.209.207"),

System.Net.IPAddress.Parse("45.9.96.12"),

System.Net.IPAddress.Parse("130.33.22.110"),

System.Net.IPAddress.Parse("3.225.215.107"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("162.116.210.251"),

System.Net.IPAddress.Parse("230.116.101.92"),

System.Net.IPAddress.Parse("166.112.234.219"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("105.222.127.10"),

System.Net.IPAddress.Parse("114.61.113.222"),

System.Net.IPAddress.Parse("254.48.59.182"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("81.201.91.243"),

System.Net.IPAddress.Parse("197.48.186.212"),

System.Net.IPAddress.Parse("185.6.154.215"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("39.141.111.119"),

System.Net.IPAddress.Parse("163.0.86.247"),

System.Net.IPAddress.Parse("1.44.211.195"),

System.Net.IPAddress.Parse("16.56.108.81"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("91.248.154.87"),

System.Net.IPAddress.Parse("169.41.229.215"),

System.Net.IPAddress.Parse("51.9.5.118"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("111.59.35.29"),

System.Net.IPAddress.Parse("35.100.26.146"),

System.Net.IPAddress.Parse("19.249.139.137"),

System.Net.IPAddress.Parse("61.63.8.210"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("186.8.2.96"),

System.Net.IPAddress.Parse("6.158.167.177"),

System.Net.IPAddress.Parse("137.252.62.64"),

System.Net.IPAddress.Parse("77.108.24.39"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("127.114.249.116"),

System.Net.IPAddress.Parse("214.238.46.93"),

System.Net.IPAddress.Parse("201.189.196.29"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("208.57.67.110"),

System.Net.IPAddress.Parse("46.26.78.150"),

System.Net.IPAddress.Parse("144.243.173.251"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("146.172.143.103"),

System.Net.IPAddress.Parse("36.90.158.145"),

System.Net.IPAddress.Parse("169.0.157.95"),

System.Net.IPAddress.Parse("77.172.71.13"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("130.251.32.178"),

System.Net.IPAddress.Parse("187.89.72.124"),

System.Net.IPAddress.Parse("198.105.196.122"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("205.157.175.129"),

System.Net.IPAddress.Parse("24.159.132.73"),

System.Net.IPAddress.Parse("223.187.179.52"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("87.222.249.8"),

System.Net.IPAddress.Parse("174.57.78.134"),

System.Net.IPAddress.Parse("243.137.78.103"),

System.Net.IPAddress.Parse("245.172.139.50"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("243.217.164.110"),

System.Net.IPAddress.Parse("248.172.220.233"),

System.Net.IPAddress.Parse("175.52.33.153"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("234.14.131.224"),

System.Net.IPAddress.Parse("32.168.160.244"),

System.Net.IPAddress.Parse("157.89.222.100"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("205.62.225.35"),

System.Net.IPAddress.Parse("47.254.154.245"),

System.Net.IPAddress.Parse("220.205.212.95"),

System.Net.IPAddress.Parse("136.125.210.5"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("142.202.42.5"),

System.Net.IPAddress.Parse("61.99.247.194"),

System.Net.IPAddress.Parse("74.82.85.251"),

System.Net.IPAddress.Parse("0.198.144.149"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("91.45.30.198"),

System.Net.IPAddress.Parse("66.61.230.247"),

System.Net.IPAddress.Parse("76.0.132.104"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("153.186.187.106"),

System.Net.IPAddress.Parse("24.106.237.1"),

System.Net.IPAddress.Parse("252.151.29.5"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("246.70.150.232"),

System.Net.IPAddress.Parse("137.23.196.104"),

System.Net.IPAddress.Parse("83.16.247.27"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("73.221.193.13"),

System.Net.IPAddress.Parse("113.29.70.75"),

System.Net.IPAddress.Parse("247.167.92.157"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("120.73.55.46"),

System.Net.IPAddress.Parse("210.180.91.120"),

System.Net.IPAddress.Parse("122.36.38.116"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("132.92.117.33"),

System.Net.IPAddress.Parse("145.108.192.181"),

System.Net.IPAddress.Parse("183.154.163.44"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("146.8.217.230"),

System.Net.IPAddress.Parse("104.139.108.239"),

System.Net.IPAddress.Parse("232.181.223.15"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("206.66.36.9"),

System.Net.IPAddress.Parse("253.222.196.126"),

System.Net.IPAddress.Parse("214.200.208.115"),

System.Net.IPAddress.Parse("220.134.52.70"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("219.146.156.102"),

System.Net.IPAddress.Parse("47.102.200.133"),

System.Net.IPAddress.Parse("44.122.205.65"),

System.Net.IPAddress.Parse("227.233.212.185"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("43.155.243.153"),

System.Net.IPAddress.Parse("124.216.169.117"),

System.Net.IPAddress.Parse("134.116.209.251"),

System.Net.IPAddress.Parse("162.105.39.18"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("53.112.216.155"),

System.Net.IPAddress.Parse("46.239.148.85"),

System.Net.IPAddress.Parse("164.57.38.207"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("172.172.45.160"),

System.Net.IPAddress.Parse("14.42.215.68"),

System.Net.IPAddress.Parse("104.141.34.193"),

System.Net.IPAddress.Parse("152.110.64.229"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("51.16.208.10"),

System.Net.IPAddress.Parse("139.134.79.69"),

System.Net.IPAddress.Parse("25.133.244.144"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("197.171.127.106"),

System.Net.IPAddress.Parse("49.99.52.180"),

System.Net.IPAddress.Parse("175.199.236.89"),

System.Net.IPAddress.Parse("84.160.118.184"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("55.196.125.242"),

System.Net.IPAddress.Parse("208.69.138.45"),

System.Net.IPAddress.Parse("193.159.227.108"),

System.Net.IPAddress.Parse("44.166.113.10"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("231.156.209.211"),

System.Net.IPAddress.Parse("80.100.208.79"),

System.Net.IPAddress.Parse("119.159.14.208"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("9.196.147.222"),

System.Net.IPAddress.Parse("163.52.56.49"),

System.Net.IPAddress.Parse("142.23.1.100"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("152.250.227.145"),

System.Net.IPAddress.Parse("252.12.107.119"),

System.Net.IPAddress.Parse("89.121.205.183"),

System.Net.IPAddress.Parse("52.105.10.207"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("15.85.108.216"),

System.Net.IPAddress.Parse("161.135.167.4"),

System.Net.IPAddress.Parse("183.26.11.114"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("73.51.165.192"),

System.Net.IPAddress.Parse("149.196.93.59"),

System.Net.IPAddress.Parse("38.203.118.20"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("141.223.227.150"),

System.Net.IPAddress.Parse("3.245.58.131"),

System.Net.IPAddress.Parse("200.40.44.189"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("118.48.2.155"),

System.Net.IPAddress.Parse("203.4.26.137"),

System.Net.IPAddress.Parse("112.135.242.233"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("244.151.221.202"),

System.Net.IPAddress.Parse("122.225.29.123"),

System.Net.IPAddress.Parse("6.102.203.33"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("127.86.226.213"),

System.Net.IPAddress.Parse("37.87.241.225"),

System.Net.IPAddress.Parse("250.30.110.130"),

System.Net.IPAddress.Parse("244.228.229.172"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("226.54.96.20"),

System.Net.IPAddress.Parse("179.75.239.105"),

System.Net.IPAddress.Parse("132.66.33.147"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("126.206.1.234"),

System.Net.IPAddress.Parse("30.253.50.29"),

System.Net.IPAddress.Parse("190.147.42.251"),

System.Net.IPAddress.Parse("23.131.198.111"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("88.57.153.241"),

System.Net.IPAddress.Parse("72.107.124.222"),

System.Net.IPAddress.Parse("60.114.249.205"),

System.Net.IPAddress.Parse("72.30.166.218"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("7.199.37.79"),

System.Net.IPAddress.Parse("212.3.75.54"),

System.Net.IPAddress.Parse("85.7.184.227"),

System.Net.IPAddress.Parse("47.18.86.103"),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetlistd1e2mi(
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
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
INSERT INTO public.ipaddressinetlistd1e2mi(
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
            queryMapTypes: [typeof(IPAddressinetListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
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

                changedRows =  ((IIPAddressListinetListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IIPAddressListinetListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IIPAddressListinetListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressListinetListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IIPAddressListinetListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IIPAddressListinetListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IIPAddressListinetListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IIPAddressListinetListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IIPAddressListinetListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IIPAddressListinetListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IIPAddressListinetListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IIPAddressListinetListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IIPAddressListinetListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IIPAddressListinetListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IIPAddressListinetListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IIPAddressListinetListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IIPAddressListinetListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetlistd1e2m(
	id,
    value,
    nullablevalue,
    ipaddressinetlistd1e2mi_id
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
            asPartInterface: typeof(IIPAddressListinetListD1)), 
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
                methodParametrName: "ipaddressinetlistd1e2mi_id", 
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
                changedRows =  ((IIPAddressListinetListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IIPAddressListinetListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IIPAddressListinetListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IIPAddressListinetListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetlistd1e2m(
	id,
    value,
    nullablevalue,
    ipaddressinetlistd1e2mi_id
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
    ipaddressinetlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(IPAddressinetListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetlistd1e2m(
	id,
    value,
    nullablevalue,
    ipaddressinetlistd1e2mi_id
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
    ipaddressinetlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(IPAddressinetListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
                methodParametrName: "ipaddressinetlistd1e2mi_id", 
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
                List<IPAddressinetListD1E2M> models = null;

                models =  ((IIPAddressListinetListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IIPAddressListinetListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IIPAddressListinetListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IIPAddressListinetListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetListD1E2M> models = null;

                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IIPAddressListinetListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetListD1E2M), typeof(FlatIPAddressinetListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
FROM public.ipaddressinetlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinetListD1E2M>();
                var models2 = new List<FlatIPAddressinetListD1E2M>();
                await ((IIPAddressListinetListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinetListD1E2M>();
                var models2 = new List<FlatIPAddressinetListD1E2M>();
                ((IIPAddressListinetListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
FROM public.ipaddressinetlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IIPAddressListinetListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IIPAddressListinetListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetlistd1e2m m
LEFT JOIN public.ipaddressinetlistd1e2mi mi ON mi.id = m.ipaddressinetlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinetListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
                var models = await ((IIPAddressListinetListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IIPAddressListinetListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetListD1E2M), typeof(FlatIPAddressinetListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
FROM public.ipaddressinetlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetListD1E2M>();
                var models2 = new List<FlatIPAddressinetListD1E2M>();
                await ((IIPAddressListinetListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetListD1E2M>();
                var models2 = new List<FlatIPAddressinetListD1E2M>();
                ((IIPAddressListinetListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
FROM public.ipaddressinetlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IIPAddressListinetListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressListinetListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetlistd1e2m m
LEFT JOIN public.ipaddressinetlistd1e2mi mi ON mi.id = m.ipaddressinetlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(IPAddressinetListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
                var models = await ((IIPAddressListinetListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IIPAddressListinetListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetListD1E2M), typeof(FlatIPAddressinetListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinetListD1E2M>();
                var models2 = new List<FlatIPAddressinetListD1E2M>();
                await((IIPAddressListinetListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
FROM public.ipaddressinetlistd1e2m m
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetListD1E2M>();
                var firstItems2 = new List<FlatIPAddressinetListD1E2M>();
                var secondItems1 = new List<FlatIPAddressinetListD1E2M>();
                var secondItems2 = new List<FlatIPAddressinetListD1E2M>();
                await ((IIPAddressListinetListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
FROM public.ipaddressinetlistd1e2m m
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetListD1E2M>();
                var firstItems2 = new List<FlatIPAddressinetListD1E2M>();
                var secondItems1 = new List<FlatIPAddressinetListD1E2M>();
                await ((IIPAddressListinetListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinetListD1E2M>();
                var models2 = new List<FlatIPAddressinetListD1E2M>();
                ((IIPAddressListinetListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 89;
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
FROM public.ipaddressinetlistd1e2m m
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetListD1E2M>();
                var firstItems2 = new List<FlatIPAddressinetListD1E2M>();
                var secondItems1 = new List<FlatIPAddressinetListD1E2M>();
                var secondItems2 = new List<FlatIPAddressinetListD1E2M>();
                 ((IIPAddressListinetListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[14],_testData[34], false);
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
                parametr2.Value = 49;
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
FROM public.ipaddressinetlistd1e2m m
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetListD1E2M>();
                var firstItems2 = new List<FlatIPAddressinetListD1E2M>();
                var secondItems1 = new List<FlatIPAddressinetListD1E2M>();
                 ((IIPAddressListinetListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IIPAddressListinetListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetlistd1e2m m
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[16],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[17],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[18],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[19],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[20],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetlistd1e2m m
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetListD1E2M>();
                var secondItems1 = new List<FlatIPAddressinetListD1E2M>();
                var secondItems2 = new List<FlatIPAddressinetListD1E2M>();
                await ((IIPAddressListinetListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IIPAddressListinetListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetlistd1e2m m
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressListinetListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[16],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[17],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[18],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[19],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[20],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[21],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[22],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[23],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[24],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[25],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[26],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetlistd1e2m m
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetListD1E2M>();
                var secondItems1 = new List<FlatIPAddressinetListD1E2M>();
                var secondItems2 = new List<FlatIPAddressinetListD1E2M>();
                 ((IIPAddressListinetListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.ipaddressinetlistd1e2m m
LEFT JOIN public.ipaddressinetlistd1e2mi mi ON mi.id = m.ipaddressinetlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinetListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
                var models = await((IIPAddressListinetListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[14], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[15], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[16], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[17], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[18], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[19], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[20], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[14],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[15],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[16],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[17],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[18],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[19],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[34], false);
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
                var models = ((IIPAddressListinetListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[9], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[10], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[11], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[12], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[13], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[14], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[15], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[16], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[17], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[18], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[19], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[20], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[14],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[15],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[16],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[17],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[18],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[19],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[20],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[21],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[22],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[23],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[24],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetListD1E2M), typeof(FlatIPAddressinetListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetListD1E2M>();
                var models2 = new List<FlatIPAddressinetListD1E2M>();
                await((IIPAddressListinetListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetlistd1e2m m
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetListD1E2M>();
                var firstItems2 = new List<FlatIPAddressinetListD1E2M>();
                var secondItems1 = new List<FlatIPAddressinetListD1E2M>();
                var secondItems2 = new List<FlatIPAddressinetListD1E2M>();
                await ((IIPAddressListinetListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 34, query1, 19, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.ipaddressinetlistd1e2m m
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetListD1E2M>();
                var firstItems2 = new List<FlatIPAddressinetListD1E2M>();
                var secondItems1 = new List<FlatIPAddressinetListD1E2M>();
                await ((IIPAddressListinetListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 88, query1, 45, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetListD1E2M>();
                var models2 = new List<FlatIPAddressinetListD1E2M>();
                ((IIPAddressListinetListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetlistd1e2m m
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetListD1E2M>();
                var firstItems2 = new List<FlatIPAddressinetListD1E2M>();
                var secondItems1 = new List<FlatIPAddressinetListD1E2M>();
                var secondItems2 = new List<FlatIPAddressinetListD1E2M>();
                 ((IIPAddressListinetListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 94, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.ipaddressinetlistd1e2m m
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetListD1E2M>();
                var firstItems2 = new List<FlatIPAddressinetListD1E2M>();
                var secondItems1 = new List<FlatIPAddressinetListD1E2M>();
                 ((IIPAddressListinetListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 103, query1, 49, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IIPAddressListinetListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetlistd1e2m m
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 88, query1, 89, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[34], false);
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
FROM public.ipaddressinetlistd1e2m m
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetListD1E2M>();
                var secondItems1 = new List<FlatIPAddressinetListD1E2M>();
                var secondItems2 = new List<FlatIPAddressinetListD1E2M>();
                await ((IIPAddressListinetListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 72, query1, 118, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressListinetListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetlistd1e2m m
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressListinetListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 141, query1, 45, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[16],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[17],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[18],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[19],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[20],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[21],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[22],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[23],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[24],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[25],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[26],_testData[34], false);
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
FROM public.ipaddressinetlistd1e2m m
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
FROM public.ipaddressinetlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetListD1E2M>();
                var secondItems1 = new List<FlatIPAddressinetListD1E2M>();
                var secondItems2 = new List<FlatIPAddressinetListD1E2M>();
                 ((IIPAddressListinetListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 94, query1, 103, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.ipaddressinetlistd1e2m m
LEFT JOIN public.ipaddressinetlistd1e2mi mi ON mi.id = m.ipaddressinetlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(IPAddressinetListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
                var models = await((IIPAddressListinetListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 145, 141))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[34], false);
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
                var models = ((IIPAddressListinetListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelBatch(connection, 65, 27))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[14], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[15], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[16], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[17], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[18], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[19], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[20], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[14],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[15],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[16],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[17],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[18],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[19],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[5], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[6], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[7], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[8], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[9], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[10], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[11], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[12], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[13], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[14], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[15], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[16], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[17], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[18], false);
                        IPAddressinetListD1E2M.AssertModel(models[14],_testData[19], false);
                        IPAddressinetListD1E2M.AssertModel(models[15],_testData[20], false);
                        IPAddressinetListD1E2M.AssertModel(models[16],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[17],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[18],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[19],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[20],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[21],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[22],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[23],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[24],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[25],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[26],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[27],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[28],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[29],_testData[34], false);
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
                await using var cmd = await ((IIPAddressListinetListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IIPAddressListinetListD1)this).SetDbConnectionSelectModelParametrs(cmd, 100);
                var models = await ((IIPAddressListinetListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                IPAddressinetListD1E2M.AssertModel(models[0],_testData[22], false);
                IPAddressinetListD1E2M.AssertModel(models[1],_testData[23], false);
                IPAddressinetListD1E2M.AssertModel(models[2],_testData[24], false);
                IPAddressinetListD1E2M.AssertModel(models[3],_testData[25], false);
                IPAddressinetListD1E2M.AssertModel(models[4],_testData[26], false);
                IPAddressinetListD1E2M.AssertModel(models[5],_testData[27], false);
                IPAddressinetListD1E2M.AssertModel(models[6],_testData[28], false);
                IPAddressinetListD1E2M.AssertModel(models[7],_testData[29], false);
                IPAddressinetListD1E2M.AssertModel(models[8],_testData[30], false);
                IPAddressinetListD1E2M.AssertModel(models[9],_testData[31], false);
                IPAddressinetListD1E2M.AssertModel(models[10],_testData[32], false);
                IPAddressinetListD1E2M.AssertModel(models[11],_testData[33], false);
                IPAddressinetListD1E2M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressListinetListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressListinetListD1)this).SetDbConnectionSelectModelParametrs(cmd, 145);
                var models =  ((IIPAddressListinetListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                IPAddressinetListD1E2M.AssertModel(models[0],_testData[31], false);
                IPAddressinetListD1E2M.AssertModel(models[1],_testData[32], false);
                IPAddressinetListD1E2M.AssertModel(models[2],_testData[33], false);
                IPAddressinetListD1E2M.AssertModel(models[3],_testData[34], false);
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
FROM public.binary_ipaddressinetlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(IPAddressinetListD1E2MIWA),
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
            asPartInterface: typeof(IIPAddressListinetListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressListinetListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinetlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IIPAddressListinetListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressListinetListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinetlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressListinetListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(IPAddressinetListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressListinetListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinetlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IIPAddressListinetListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressListinetListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinetlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressListinetListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(IPAddressinetListD1E2MI),
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
            asPartInterface: typeof(IIPAddressListinetListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IIPAddressListinetListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IIPAddressListinetListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IIPAddressListinetListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IIPAddressListinetListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(IPAddressinetListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressListinetListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IIPAddressListinetListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressListinetListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IIPAddressListinetListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
ipaddressinetlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(IPAddressinetListD1E2M),
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
            asPartInterface: typeof(IIPAddressListinetListD1))]
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
FROM public.binary_ipaddressinetlistd1e2m m
LEFT JOIN public.binary_ipaddressinetlistd1e2mi mi ON mi.id = m.ipaddressinetlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(IPAddressinetListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IIPAddressListinetListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IIPAddressListinetListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    IPAddressinetListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IIPAddressListinetListD1)this).ImportModel(connection, importCollection);
                var models = ((IIPAddressListinetListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    IPAddressinetListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    ipaddressinetlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(IPAddressinetListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
                var models =  ((IIPAddressListinetListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    IPAddressinetListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressListinetListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    IPAddressinetListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD1E2MIWA), typeof(IPAddressinetListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
                var models1 = new List<IPAddressinetListD1E2MIWA>();
                var models2 = new List<IPAddressinetListD1E2MIWA>();
                await ((IIPAddressListinetListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetListD1E2MIWA>();
                var models2 = new List<IPAddressinetListD1E2MIWA>();
                ((IIPAddressListinetListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
                var models = await ((IIPAddressListinetListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_ipaddressinetlistd1e2mi
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
                    IPAddressinetListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressListinetListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_ipaddressinetlistd1e2mi
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
                    IPAddressinetListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD1E2MIWA), typeof(IPAddressinetListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1))]
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
                var models1 = new List<IPAddressinetListD1E2MIWA>();
                var models2 = new List<IPAddressinetListD1E2MIWA>();
                await ((IIPAddressListinetListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetListD1E2MIWA>();
                var models2 = new List<IPAddressinetListD1E2MIWA>();
                ((IIPAddressListinetListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1))]
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
                var models = await ((IIPAddressListinetListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_ipaddressinetlistd1e2mi
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
                    IPAddressinetListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressListinetListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_ipaddressinetlistd1e2mi
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
                    IPAddressinetListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_ipaddressinetlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD1E2MI), typeof(IPAddressinetListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
                var models1 = new List<IPAddressinetListD1E2MI>();
                var models2 = new List<IPAddressinetListD1E2MI>();
                await ((IIPAddressListinetListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetListD1E2MI>();
                var models2 = new List<IPAddressinetListD1E2MI>();
                ((IIPAddressListinetListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1)),
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
                var models = await ((IIPAddressListinetListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressListinetListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_ipaddressinetlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD1E2MIWA), typeof(IPAddressinetListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1))]
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
                var models1 = new List<IPAddressinetListD1E2MIWA>();
                var models2 = new List<IPAddressinetListD1E2MIWA>();
                await ((IIPAddressListinetListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetListD1E2MIWA>();
                var models2 = new List<IPAddressinetListD1E2MIWA>();
                ((IIPAddressListinetListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetListD1))]
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
                var models = await ((IIPAddressListinetListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressListinetListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

