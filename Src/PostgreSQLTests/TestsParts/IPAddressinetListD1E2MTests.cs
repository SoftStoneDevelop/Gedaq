

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
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("98.140.36.183"),

System.Net.IPAddress.Parse("52.101.82.111"),

System.Net.IPAddress.Parse("40.113.224.13"),

System.Net.IPAddress.Parse("170.114.252.1"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("200.252.193.89"),

System.Net.IPAddress.Parse("250.220.55.164"),

System.Net.IPAddress.Parse("67.155.243.91"),

System.Net.IPAddress.Parse("221.148.92.90"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("99.139.194.226"),

System.Net.IPAddress.Parse("106.14.74.146"),

System.Net.IPAddress.Parse("209.79.220.231"),

System.Net.IPAddress.Parse("238.128.156.120"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("145.142.138.42"),

System.Net.IPAddress.Parse("37.193.220.125"),

System.Net.IPAddress.Parse("80.157.211.241"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("244.158.41.172"),

System.Net.IPAddress.Parse("182.105.23.169"),

System.Net.IPAddress.Parse("40.23.99.87"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("151.115.224.146"),

System.Net.IPAddress.Parse("178.148.52.9"),

System.Net.IPAddress.Parse("104.191.120.21"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("127.144.103.118"),

System.Net.IPAddress.Parse("247.12.112.3"),

System.Net.IPAddress.Parse("128.137.48.133"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("112.90.249.197"),

System.Net.IPAddress.Parse("187.184.217.197"),

System.Net.IPAddress.Parse("2.25.226.40"),

System.Net.IPAddress.Parse("174.120.198.248"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("15.241.97.181"),

System.Net.IPAddress.Parse("132.179.232.137"),

System.Net.IPAddress.Parse("120.78.205.180"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("234.235.123.140"),

System.Net.IPAddress.Parse("21.212.167.247"),

System.Net.IPAddress.Parse("240.246.143.193"),

System.Net.IPAddress.Parse("49.118.217.12"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("226.218.87.77"),

System.Net.IPAddress.Parse("247.218.41.124"),

System.Net.IPAddress.Parse("60.94.108.228"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("10.128.66.35"),

System.Net.IPAddress.Parse("249.205.225.142"),

System.Net.IPAddress.Parse("77.175.131.16"),

System.Net.IPAddress.Parse("89.214.81.129"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("1.67.25.24"),

System.Net.IPAddress.Parse("234.225.106.235"),

System.Net.IPAddress.Parse("228.110.171.102"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("9.174.56.185"),

System.Net.IPAddress.Parse("158.149.100.91"),

System.Net.IPAddress.Parse("244.252.24.135"),

System.Net.IPAddress.Parse("165.49.213.242"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("204.198.55.17"),

System.Net.IPAddress.Parse("22.39.29.157"),

System.Net.IPAddress.Parse("28.158.58.233"),

System.Net.IPAddress.Parse("227.65.72.237"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("193.5.147.103"),

System.Net.IPAddress.Parse("208.48.239.126"),

System.Net.IPAddress.Parse("112.109.37.207"),

System.Net.IPAddress.Parse("224.162.210.107"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("237.175.236.217"),

System.Net.IPAddress.Parse("112.169.40.37"),

System.Net.IPAddress.Parse("35.145.192.2"),

System.Net.IPAddress.Parse("198.40.99.25"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("26.130.120.103"),

System.Net.IPAddress.Parse("58.72.63.126"),

System.Net.IPAddress.Parse("155.242.225.50"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("47.67.191.135"),

System.Net.IPAddress.Parse("27.201.66.62"),

System.Net.IPAddress.Parse("177.33.186.184"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("4.249.37.250"),

System.Net.IPAddress.Parse("104.186.141.251"),

System.Net.IPAddress.Parse("0.184.92.83"),

System.Net.IPAddress.Parse("27.75.48.145"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("214.2.181.6"),

System.Net.IPAddress.Parse("127.231.181.186"),

System.Net.IPAddress.Parse("246.22.167.117"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("152.118.142.95"),

System.Net.IPAddress.Parse("230.145.129.6"),

System.Net.IPAddress.Parse("179.1.248.30"),

System.Net.IPAddress.Parse("210.49.4.245"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("79.235.45.138"),

System.Net.IPAddress.Parse("237.220.230.247"),

System.Net.IPAddress.Parse("168.74.236.30"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("27.123.102.22"),

System.Net.IPAddress.Parse("116.208.62.144"),

System.Net.IPAddress.Parse("19.17.245.134"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("234.111.142.207"),

System.Net.IPAddress.Parse("119.116.51.69"),

System.Net.IPAddress.Parse("191.74.79.9"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("216.182.243.43"),

System.Net.IPAddress.Parse("154.131.48.157"),

System.Net.IPAddress.Parse("238.80.127.170"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("26.94.195.94"),

System.Net.IPAddress.Parse("176.35.166.167"),

System.Net.IPAddress.Parse("201.133.30.183"),

System.Net.IPAddress.Parse("237.117.90.53"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("21.122.230.178"),

System.Net.IPAddress.Parse("124.37.84.239"),

System.Net.IPAddress.Parse("207.41.46.78"),

System.Net.IPAddress.Parse("174.242.182.79"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("64.85.188.118"),

System.Net.IPAddress.Parse("211.192.150.77"),

System.Net.IPAddress.Parse("208.244.48.46"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("241.228.144.153"),

System.Net.IPAddress.Parse("194.190.185.89"),

System.Net.IPAddress.Parse("128.212.119.225"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("222.211.220.107"),

System.Net.IPAddress.Parse("106.143.158.190"),

System.Net.IPAddress.Parse("133.130.176.191"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("17.140.120.132"),

System.Net.IPAddress.Parse("62.80.25.197"),

System.Net.IPAddress.Parse("24.249.234.70"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("229.51.162.191"),

System.Net.IPAddress.Parse("190.207.41.148"),

System.Net.IPAddress.Parse("33.142.181.180"),

System.Net.IPAddress.Parse("4.246.12.181"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("195.87.58.112"),

System.Net.IPAddress.Parse("194.232.249.11"),

System.Net.IPAddress.Parse("98.115.4.217"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("43.69.179.226"),

System.Net.IPAddress.Parse("25.159.57.156"),

System.Net.IPAddress.Parse("156.47.83.142"),

System.Net.IPAddress.Parse("101.133.17.43"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("96.91.205.146"),

System.Net.IPAddress.Parse("94.242.238.158"),

System.Net.IPAddress.Parse("168.139.253.54"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("179.90.13.176"),

System.Net.IPAddress.Parse("84.137.53.181"),

System.Net.IPAddress.Parse("84.137.202.76"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("158.169.60.10"),

System.Net.IPAddress.Parse("193.90.226.51"),

System.Net.IPAddress.Parse("35.176.54.206"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("162.24.229.133"),

System.Net.IPAddress.Parse("83.252.142.166"),

System.Net.IPAddress.Parse("184.58.23.189"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("132.64.101.157"),

System.Net.IPAddress.Parse("88.132.119.144"),

System.Net.IPAddress.Parse("101.61.17.198"),

System.Net.IPAddress.Parse("117.54.169.6"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("30.225.141.28"),

System.Net.IPAddress.Parse("19.142.87.52"),

System.Net.IPAddress.Parse("75.155.107.8"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("4.152.85.153"),

System.Net.IPAddress.Parse("206.207.90.28"),

System.Net.IPAddress.Parse("182.171.222.81"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("154.183.214.64"),

System.Net.IPAddress.Parse("27.116.129.17"),

System.Net.IPAddress.Parse("195.130.217.58"),

System.Net.IPAddress.Parse("27.247.175.191"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("86.52.124.218"),

System.Net.IPAddress.Parse("64.228.123.81"),

System.Net.IPAddress.Parse("192.75.173.206"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("78.224.110.34"),

System.Net.IPAddress.Parse("128.235.161.247"),

System.Net.IPAddress.Parse("207.162.150.250"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("164.58.50.244"),

System.Net.IPAddress.Parse("103.97.228.1"),

System.Net.IPAddress.Parse("227.234.19.9"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("99.176.177.228"),

System.Net.IPAddress.Parse("21.215.24.188"),

System.Net.IPAddress.Parse("3.143.183.156"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("69.176.73.91"),

System.Net.IPAddress.Parse("229.196.187.6"),

System.Net.IPAddress.Parse("112.174.217.170"),

System.Net.IPAddress.Parse("117.244.182.213"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("252.99.91.27"),

System.Net.IPAddress.Parse("183.40.39.65"),

System.Net.IPAddress.Parse("13.145.89.180"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("63.246.109.86"),

System.Net.IPAddress.Parse("236.104.83.180"),

System.Net.IPAddress.Parse("17.181.170.24"),

System.Net.IPAddress.Parse("151.96.100.124"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("62.123.61.13"),

System.Net.IPAddress.Parse("129.30.132.225"),

System.Net.IPAddress.Parse("73.218.152.1"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("214.57.242.3"),

System.Net.IPAddress.Parse("124.213.253.52"),

System.Net.IPAddress.Parse("103.228.68.22"),

System.Net.IPAddress.Parse("248.183.33.87"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("25.89.179.137"),

System.Net.IPAddress.Parse("128.232.234.58"),

System.Net.IPAddress.Parse("50.126.155.189"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("200.82.172.158"),

System.Net.IPAddress.Parse("47.170.247.22"),

System.Net.IPAddress.Parse("90.178.171.115"),

System.Net.IPAddress.Parse("99.52.196.9"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("58.225.68.132"),

System.Net.IPAddress.Parse("178.136.229.82"),

System.Net.IPAddress.Parse("179.139.200.164"),

System.Net.IPAddress.Parse("2.82.238.72"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("189.41.144.123"),

System.Net.IPAddress.Parse("245.9.115.219"),

System.Net.IPAddress.Parse("72.73.192.142"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("193.84.121.144"),

System.Net.IPAddress.Parse("250.3.245.126"),

System.Net.IPAddress.Parse("247.200.40.1"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("174.112.88.177"),

System.Net.IPAddress.Parse("199.33.30.5"),

System.Net.IPAddress.Parse("47.209.253.74"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("176.247.107.229"),

System.Net.IPAddress.Parse("159.107.152.206"),

System.Net.IPAddress.Parse("117.82.72.192"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("234.83.4.135"),

System.Net.IPAddress.Parse("158.68.156.226"),

System.Net.IPAddress.Parse("138.104.195.61"),

System.Net.IPAddress.Parse("132.0.65.142"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("200.245.198.100"),

System.Net.IPAddress.Parse("172.114.30.76"),

System.Net.IPAddress.Parse("205.182.24.164"),

System.Net.IPAddress.Parse("50.221.172.112"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("176.245.45.22"),

System.Net.IPAddress.Parse("108.217.241.32"),

System.Net.IPAddress.Parse("194.7.209.77"),

System.Net.IPAddress.Parse("70.109.74.229"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("193.96.32.135"),

System.Net.IPAddress.Parse("192.161.235.19"),

System.Net.IPAddress.Parse("173.93.213.5"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("159.30.33.238"),

System.Net.IPAddress.Parse("187.104.118.198"),

System.Net.IPAddress.Parse("237.65.5.202"),

System.Net.IPAddress.Parse("98.168.170.160"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("246.110.10.87"),

System.Net.IPAddress.Parse("120.42.220.114"),

System.Net.IPAddress.Parse("49.223.161.234"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("168.88.150.120"),

System.Net.IPAddress.Parse("194.45.225.105"),

System.Net.IPAddress.Parse("224.58.76.22"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("9.62.165.1"),

System.Net.IPAddress.Parse("1.62.155.108"),

System.Net.IPAddress.Parse("59.34.124.66"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("33.42.34.30"),

System.Net.IPAddress.Parse("120.50.62.72"),

System.Net.IPAddress.Parse("13.63.137.203"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("30.16.145.71"),

System.Net.IPAddress.Parse("107.28.146.6"),

System.Net.IPAddress.Parse("27.237.190.79"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("226.216.191.22"),

System.Net.IPAddress.Parse("191.86.22.8"),

System.Net.IPAddress.Parse("174.189.162.156"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("94.236.53.10"),

System.Net.IPAddress.Parse("119.96.246.62"),

System.Net.IPAddress.Parse("65.93.213.173"),

System.Net.IPAddress.Parse("106.230.103.130"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("110.144.3.109"),

System.Net.IPAddress.Parse("112.115.154.69"),

System.Net.IPAddress.Parse("114.230.73.153"),

System.Net.IPAddress.Parse("101.231.143.15"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("9.91.235.148"),

System.Net.IPAddress.Parse("207.7.80.235"),

System.Net.IPAddress.Parse("228.126.235.152"),

System.Net.IPAddress.Parse("90.95.228.225"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("152.224.114.232"),

System.Net.IPAddress.Parse("180.16.19.106"),

System.Net.IPAddress.Parse("138.207.196.221"),

System.Net.IPAddress.Parse("248.252.85.181"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("121.158.173.82"),

System.Net.IPAddress.Parse("246.35.34.222"),

System.Net.IPAddress.Parse("32.167.250.150"),

System.Net.IPAddress.Parse("156.138.108.203"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("46.135.246.205"),

System.Net.IPAddress.Parse("109.134.177.3"),

System.Net.IPAddress.Parse("78.130.52.222"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("253.50.227.165"),

System.Net.IPAddress.Parse("63.150.84.77"),

System.Net.IPAddress.Parse("157.171.107.188"),

System.Net.IPAddress.Parse("97.232.192.60"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 185,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("204.75.84.246"),

System.Net.IPAddress.Parse("147.157.135.140"),

System.Net.IPAddress.Parse("39.13.234.5"),

},
    ModelInner = null,
    NullableValue = null,
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[16],_testData[34], false);
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
                parametr2.Value = 45;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
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
                parametr1.Value = 30;
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[2], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[3], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[4], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[5], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[6], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[7], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[8], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[9], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[10], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[11], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[12], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[13], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[14], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[15], false);
                        IPAddressinetListD1E2M.AssertModel(models[14],_testData[16], false);
                        IPAddressinetListD1E2M.AssertModel(models[15],_testData[17], false);
                        IPAddressinetListD1E2M.AssertModel(models[16],_testData[18], false);
                        IPAddressinetListD1E2M.AssertModel(models[17],_testData[19], false);
                        IPAddressinetListD1E2M.AssertModel(models[18],_testData[20], false);
                        IPAddressinetListD1E2M.AssertModel(models[19],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[20],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[21],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[22],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[23],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[24],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[25],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[26],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[27],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[28],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[29],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[30],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[31],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                await ((IIPAddressListinetListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 144, query1, 144, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
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
                await ((IIPAddressListinetListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 96, query1, 113, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
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
                 ((IIPAddressListinetListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 121, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[34], false);
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
                 ((IIPAddressListinetListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 121, query1, 1, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressListinetListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 20, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[16],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[17],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[18],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[19],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[20],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[21],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[22],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[23],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[24],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[25],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[26],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[27],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[28],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[16],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[17],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[18],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[19],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[20],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[21],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[22],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[23],_testData[34], false);
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
                await ((IIPAddressListinetListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 1, query1, 121, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressListinetListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 94, query1, 45, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[16],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[17],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[18],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[19],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[20],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[21],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[22],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[23],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[24],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[25],_testData[34], false);
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
                 ((IIPAddressListinetListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 159, query1, 45, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[25],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 113, 159))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelBatch(connection, 1, 163))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[1], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[2], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[3], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[4], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[5], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[6], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[7], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[8], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[9], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[10], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[11], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[12], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[13], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[14], false);
                        IPAddressinetListD1E2M.AssertModel(models[14],_testData[15], false);
                        IPAddressinetListD1E2M.AssertModel(models[15],_testData[16], false);
                        IPAddressinetListD1E2M.AssertModel(models[16],_testData[17], false);
                        IPAddressinetListD1E2M.AssertModel(models[17],_testData[18], false);
                        IPAddressinetListD1E2M.AssertModel(models[18],_testData[19], false);
                        IPAddressinetListD1E2M.AssertModel(models[19],_testData[20], false);
                        IPAddressinetListD1E2M.AssertModel(models[20],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[21],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[22],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[23],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[24],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[25],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[26],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[27],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[28],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[29],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[30],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[31],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[32],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[34], false);
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
                ((IIPAddressListinetListD1)this).SetDbConnectionSelectModelParametrs(cmd, 54);
                var models = await ((IIPAddressListinetListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                IPAddressinetListD1E2M.AssertModel(models[0],_testData[11], false);
                IPAddressinetListD1E2M.AssertModel(models[1],_testData[12], false);
                IPAddressinetListD1E2M.AssertModel(models[2],_testData[13], false);
                IPAddressinetListD1E2M.AssertModel(models[3],_testData[14], false);
                IPAddressinetListD1E2M.AssertModel(models[4],_testData[15], false);
                IPAddressinetListD1E2M.AssertModel(models[5],_testData[16], false);
                IPAddressinetListD1E2M.AssertModel(models[6],_testData[17], false);
                IPAddressinetListD1E2M.AssertModel(models[7],_testData[18], false);
                IPAddressinetListD1E2M.AssertModel(models[8],_testData[19], false);
                IPAddressinetListD1E2M.AssertModel(models[9],_testData[20], false);
                IPAddressinetListD1E2M.AssertModel(models[10],_testData[21], false);
                IPAddressinetListD1E2M.AssertModel(models[11],_testData[22], false);
                IPAddressinetListD1E2M.AssertModel(models[12],_testData[23], false);
                IPAddressinetListD1E2M.AssertModel(models[13],_testData[24], false);
                IPAddressinetListD1E2M.AssertModel(models[14],_testData[25], false);
                IPAddressinetListD1E2M.AssertModel(models[15],_testData[26], false);
                IPAddressinetListD1E2M.AssertModel(models[16],_testData[27], false);
                IPAddressinetListD1E2M.AssertModel(models[17],_testData[28], false);
                IPAddressinetListD1E2M.AssertModel(models[18],_testData[29], false);
                IPAddressinetListD1E2M.AssertModel(models[19],_testData[30], false);
                IPAddressinetListD1E2M.AssertModel(models[20],_testData[31], false);
                IPAddressinetListD1E2M.AssertModel(models[21],_testData[32], false);
                IPAddressinetListD1E2M.AssertModel(models[22],_testData[33], false);
                IPAddressinetListD1E2M.AssertModel(models[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressListinetListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressListinetListD1)this).SetDbConnectionSelectModelParametrs(cmd, 175);
                var models =  ((IIPAddressListinetListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                IPAddressinetListD1E2M.AssertModel(models[0],_testData[33], false);
                IPAddressinetListD1E2M.AssertModel(models[1],_testData[34], false);
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

