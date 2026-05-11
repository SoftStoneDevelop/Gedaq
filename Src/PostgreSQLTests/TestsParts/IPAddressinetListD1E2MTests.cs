

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
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("130.62.3.184"),

System.Net.IPAddress.Parse("128.217.122.221"),

System.Net.IPAddress.Parse("205.94.238.113"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("104.26.145.12"),

System.Net.IPAddress.Parse("203.156.119.8"),

System.Net.IPAddress.Parse("162.72.188.194"),

System.Net.IPAddress.Parse("113.59.163.242"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("168.101.208.20"),

System.Net.IPAddress.Parse("112.251.34.120"),

System.Net.IPAddress.Parse("125.3.21.151"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("25.72.41.213"),

System.Net.IPAddress.Parse("134.186.150.206"),

System.Net.IPAddress.Parse("173.132.227.83"),

System.Net.IPAddress.Parse("65.220.90.242"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("147.134.131.202"),

System.Net.IPAddress.Parse("40.72.204.252"),

System.Net.IPAddress.Parse("230.181.252.59"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("20.40.127.80"),

System.Net.IPAddress.Parse("232.75.231.211"),

System.Net.IPAddress.Parse("236.120.6.62"),

System.Net.IPAddress.Parse("249.5.35.141"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("113.139.171.162"),

System.Net.IPAddress.Parse("249.145.35.18"),

System.Net.IPAddress.Parse("136.196.219.58"),

System.Net.IPAddress.Parse("0.116.212.128"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("79.127.120.146"),

System.Net.IPAddress.Parse("75.146.30.208"),

System.Net.IPAddress.Parse("239.31.72.105"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("235.75.180.202"),

System.Net.IPAddress.Parse("25.28.118.45"),

System.Net.IPAddress.Parse("54.174.137.231"),

System.Net.IPAddress.Parse("108.115.240.176"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("141.218.136.117"),

System.Net.IPAddress.Parse("56.145.238.194"),

System.Net.IPAddress.Parse("42.40.38.82"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("73.134.188.104"),

System.Net.IPAddress.Parse("48.178.253.24"),

System.Net.IPAddress.Parse("85.69.235.131"),

System.Net.IPAddress.Parse("145.20.246.65"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("19.86.97.115"),

System.Net.IPAddress.Parse("241.95.224.253"),

System.Net.IPAddress.Parse("35.218.105.20"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("73.75.252.47"),

System.Net.IPAddress.Parse("148.217.204.176"),

System.Net.IPAddress.Parse("141.224.241.57"),

System.Net.IPAddress.Parse("225.52.3.205"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("222.146.80.127"),

System.Net.IPAddress.Parse("234.29.219.155"),

System.Net.IPAddress.Parse("209.229.140.80"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("135.40.127.114"),

System.Net.IPAddress.Parse("64.175.172.147"),

System.Net.IPAddress.Parse("254.159.41.224"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("95.47.126.143"),

System.Net.IPAddress.Parse("96.54.26.241"),

System.Net.IPAddress.Parse("155.155.86.152"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("197.95.167.208"),

System.Net.IPAddress.Parse("237.247.104.42"),

System.Net.IPAddress.Parse("228.186.180.12"),

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
System.Net.IPAddress.Parse("148.242.92.94"),

System.Net.IPAddress.Parse("12.184.19.25"),

System.Net.IPAddress.Parse("221.109.50.202"),

System.Net.IPAddress.Parse("171.208.227.227"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("220.243.151.87"),

System.Net.IPAddress.Parse("17.47.19.77"),

System.Net.IPAddress.Parse("129.125.114.160"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("7.136.64.149"),

System.Net.IPAddress.Parse("77.26.118.139"),

System.Net.IPAddress.Parse("58.229.12.108"),

System.Net.IPAddress.Parse("147.53.13.25"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("203.16.151.88"),

System.Net.IPAddress.Parse("28.232.135.175"),

System.Net.IPAddress.Parse("176.3.167.22"),

System.Net.IPAddress.Parse("73.249.43.80"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.50.0.59"),

System.Net.IPAddress.Parse("69.92.49.180"),

System.Net.IPAddress.Parse("145.85.142.243"),

System.Net.IPAddress.Parse("147.1.68.165"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("32.151.62.88"),

System.Net.IPAddress.Parse("147.173.23.49"),

System.Net.IPAddress.Parse("2.86.239.154"),

System.Net.IPAddress.Parse("158.186.87.69"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("163.81.81.227"),

System.Net.IPAddress.Parse("151.213.45.97"),

System.Net.IPAddress.Parse("201.52.149.197"),

System.Net.IPAddress.Parse("118.195.245.140"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("92.10.165.48"),

System.Net.IPAddress.Parse("167.125.144.228"),

System.Net.IPAddress.Parse("79.73.147.190"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("9.17.173.158"),

System.Net.IPAddress.Parse("232.17.100.194"),

System.Net.IPAddress.Parse("8.231.210.143"),

System.Net.IPAddress.Parse("45.92.203.110"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("24.126.62.43"),

System.Net.IPAddress.Parse("31.173.177.176"),

System.Net.IPAddress.Parse("160.218.133.187"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("215.65.188.49"),

System.Net.IPAddress.Parse("12.28.203.91"),

System.Net.IPAddress.Parse("212.30.118.15"),

System.Net.IPAddress.Parse("203.206.231.167"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("217.120.197.139"),

System.Net.IPAddress.Parse("226.28.11.181"),

System.Net.IPAddress.Parse("79.181.8.108"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("199.7.233.159"),

System.Net.IPAddress.Parse("186.208.101.136"),

System.Net.IPAddress.Parse("226.200.167.238"),

System.Net.IPAddress.Parse("211.184.192.193"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("156.37.33.23"),

System.Net.IPAddress.Parse("124.10.127.10"),

System.Net.IPAddress.Parse("156.177.252.36"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("102.188.65.59"),

System.Net.IPAddress.Parse("132.59.70.211"),

System.Net.IPAddress.Parse("183.118.192.70"),

System.Net.IPAddress.Parse("207.100.220.157"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("98.238.79.248"),

System.Net.IPAddress.Parse("155.251.218.54"),

System.Net.IPAddress.Parse("168.87.27.39"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("164.132.7.34"),

System.Net.IPAddress.Parse("24.240.105.211"),

System.Net.IPAddress.Parse("45.15.192.199"),

System.Net.IPAddress.Parse("74.101.240.155"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("183.39.236.158"),

System.Net.IPAddress.Parse("144.140.232.189"),

System.Net.IPAddress.Parse("206.173.87.165"),

System.Net.IPAddress.Parse("5.182.68.75"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("3.9.91.80"),

System.Net.IPAddress.Parse("138.202.37.242"),

System.Net.IPAddress.Parse("212.1.89.175"),

System.Net.IPAddress.Parse("108.249.80.55"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("108.161.253.205"),

System.Net.IPAddress.Parse("164.72.244.102"),

System.Net.IPAddress.Parse("35.193.21.40"),

System.Net.IPAddress.Parse("54.129.190.37"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("127.56.232.205"),

System.Net.IPAddress.Parse("7.123.148.65"),

System.Net.IPAddress.Parse("14.5.177.165"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("207.88.49.169"),

System.Net.IPAddress.Parse("76.89.233.143"),

System.Net.IPAddress.Parse("236.151.11.3"),

System.Net.IPAddress.Parse("60.208.121.157"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("42.32.147.223"),

System.Net.IPAddress.Parse("57.3.215.48"),

System.Net.IPAddress.Parse("159.193.114.69"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("232.125.55.37"),

System.Net.IPAddress.Parse("239.253.116.7"),

System.Net.IPAddress.Parse("158.154.231.9"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("103.56.186.151"),

System.Net.IPAddress.Parse("247.230.103.236"),

System.Net.IPAddress.Parse("46.209.72.114"),

System.Net.IPAddress.Parse("191.252.155.202"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("59.194.107.62"),

System.Net.IPAddress.Parse("156.81.18.28"),

System.Net.IPAddress.Parse("160.60.5.244"),

System.Net.IPAddress.Parse("62.75.252.159"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("249.238.102.227"),

System.Net.IPAddress.Parse("184.99.132.107"),

System.Net.IPAddress.Parse("110.236.161.10"),

System.Net.IPAddress.Parse("58.24.173.146"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("131.197.139.159"),

System.Net.IPAddress.Parse("221.218.90.0"),

System.Net.IPAddress.Parse("49.7.146.140"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("217.25.136.133"),

System.Net.IPAddress.Parse("28.154.113.64"),

System.Net.IPAddress.Parse("222.142.197.120"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("212.208.1.4"),

System.Net.IPAddress.Parse("192.62.26.180"),

System.Net.IPAddress.Parse("45.108.84.144"),

System.Net.IPAddress.Parse("19.188.228.143"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("185.86.116.215"),

System.Net.IPAddress.Parse("129.123.201.7"),

System.Net.IPAddress.Parse("233.151.41.204"),

System.Net.IPAddress.Parse("22.231.177.212"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("175.205.213.125"),

System.Net.IPAddress.Parse("125.4.231.21"),

System.Net.IPAddress.Parse("158.188.146.42"),

System.Net.IPAddress.Parse("21.56.24.215"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("154.187.207.134"),

System.Net.IPAddress.Parse("177.214.1.229"),

System.Net.IPAddress.Parse("57.1.39.73"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("96.213.217.93"),

System.Net.IPAddress.Parse("66.141.98.151"),

System.Net.IPAddress.Parse("35.157.197.169"),

System.Net.IPAddress.Parse("211.1.143.17"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("75.40.1.217"),

System.Net.IPAddress.Parse("237.230.177.61"),

System.Net.IPAddress.Parse("216.124.103.251"),

System.Net.IPAddress.Parse("161.76.151.182"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("46.19.197.96"),

System.Net.IPAddress.Parse("190.238.136.109"),

System.Net.IPAddress.Parse("244.223.195.77"),

System.Net.IPAddress.Parse("249.42.242.41"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("169.184.6.54"),

System.Net.IPAddress.Parse("211.36.210.22"),

System.Net.IPAddress.Parse("102.230.151.200"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("132.82.253.125"),

System.Net.IPAddress.Parse("194.218.203.236"),

System.Net.IPAddress.Parse("18.179.100.179"),

System.Net.IPAddress.Parse("203.106.243.196"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("75.188.165.23"),

System.Net.IPAddress.Parse("212.231.35.18"),

System.Net.IPAddress.Parse("66.154.56.164"),

System.Net.IPAddress.Parse("40.98.237.171"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("127.2.30.41"),

System.Net.IPAddress.Parse("25.67.245.193"),

System.Net.IPAddress.Parse("193.4.241.199"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("13.185.93.69"),

System.Net.IPAddress.Parse("146.30.234.22"),

System.Net.IPAddress.Parse("242.220.182.38"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("232.58.233.51"),

System.Net.IPAddress.Parse("46.193.159.130"),

System.Net.IPAddress.Parse("205.41.174.68"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("68.10.3.34"),

System.Net.IPAddress.Parse("243.227.138.66"),

System.Net.IPAddress.Parse("6.71.9.5"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("173.135.176.242"),

System.Net.IPAddress.Parse("160.239.139.20"),

System.Net.IPAddress.Parse("10.217.130.212"),

System.Net.IPAddress.Parse("224.228.220.17"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("140.125.115.176"),

System.Net.IPAddress.Parse("174.148.66.221"),

System.Net.IPAddress.Parse("28.149.194.86"),

System.Net.IPAddress.Parse("125.171.170.64"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("66.16.176.108"),

System.Net.IPAddress.Parse("142.99.95.64"),

System.Net.IPAddress.Parse("112.150.91.0"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("75.156.3.78"),

System.Net.IPAddress.Parse("112.76.83.1"),

System.Net.IPAddress.Parse("199.159.48.180"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("16.183.54.24"),

System.Net.IPAddress.Parse("117.211.86.160"),

System.Net.IPAddress.Parse("91.129.148.128"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("235.210.107.232"),

System.Net.IPAddress.Parse("106.48.23.30"),

System.Net.IPAddress.Parse("228.166.38.20"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("163.171.17.239"),

System.Net.IPAddress.Parse("152.93.248.210"),

System.Net.IPAddress.Parse("130.33.7.244"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("28.128.168.160"),

System.Net.IPAddress.Parse("132.210.77.17"),

System.Net.IPAddress.Parse("34.242.247.3"),

System.Net.IPAddress.Parse("209.241.82.24"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("10.78.1.166"),

System.Net.IPAddress.Parse("23.78.214.35"),

System.Net.IPAddress.Parse("71.218.31.162"),

System.Net.IPAddress.Parse("172.156.125.175"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 183,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("70.130.157.105"),

System.Net.IPAddress.Parse("186.134.64.153"),

System.Net.IPAddress.Parse("11.30.109.81"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("27.30.241.212"),

System.Net.IPAddress.Parse("200.110.243.58"),

System.Net.IPAddress.Parse("88.182.139.172"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("4.57.69.105"),

System.Net.IPAddress.Parse("93.194.132.122"),

System.Net.IPAddress.Parse("249.46.123.88"),

System.Net.IPAddress.Parse("6.93.141.188"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 185,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("10.19.113.188"),

System.Net.IPAddress.Parse("86.157.220.135"),

System.Net.IPAddress.Parse("77.13.82.224"),

System.Net.IPAddress.Parse("142.67.57.164"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("2.169.177.17"),

System.Net.IPAddress.Parse("141.130.175.136"),

System.Net.IPAddress.Parse("56.213.123.203"),

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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[30],_testData[34], false);
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
                parametr1.Value = 158;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 180;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[3], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[16],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[17],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[18],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[19],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[20],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[21],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[22],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[23],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[24],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[25],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[26],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[27],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[28],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[29],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[30],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[22],_testData[34], false);
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
                parametr1.Value = 166;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[19], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[20], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[14],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[8], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[9], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[10], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[11], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[12], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[13], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[14], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[15], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[16], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[17], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[18], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[19], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[20], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[14],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[15],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[16],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[17],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[18],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[19],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[20],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[21],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[22],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[23],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[24],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[25],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[26],_testData[34], false);
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
                await ((IIPAddressListinetListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 53, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                await ((IIPAddressListinetListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 25, query1, 134, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
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
                 ((IIPAddressListinetListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 77, query1, 158, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[34], false);
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
                 ((IIPAddressListinetListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 139, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressListinetListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 87, query1, 6, query2))
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
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[33],_testData[34], false);
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
                await ((IIPAddressListinetListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 46, query1, 77, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[19],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressListinetListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 158, query1, 25, query2))
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
                 ((IIPAddressListinetListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 83, query1, 125, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 36, 33))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[8], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[9], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[10], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[11], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[12], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[13], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[14], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[15], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[16], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[17], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[18], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[19], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[20], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[14],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[15],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[16],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[17],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[18],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[19],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[20],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[21],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[22],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[23],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[24],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[25],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[7], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[8], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[9], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[10], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[11], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[12], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[13], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[14], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[15], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[16], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[17], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[18], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[19], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[20], false);
                        IPAddressinetListD1E2M.AssertModel(models[14],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[15],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[16],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[17],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[18],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[19],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[20],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[21],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[22],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[23],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[24],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[25],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[26],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[27],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelBatch(connection, 104, 6))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[19], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[20], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[14],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                ((IIPAddressListinetListD1)this).SetDbConnectionSelectModelParametrs(cmd, 36);
                var models = await ((IIPAddressListinetListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                IPAddressinetListD1E2M.AssertModel(models[0],_testData[8], false);
                IPAddressinetListD1E2M.AssertModel(models[1],_testData[9], false);
                IPAddressinetListD1E2M.AssertModel(models[2],_testData[10], false);
                IPAddressinetListD1E2M.AssertModel(models[3],_testData[11], false);
                IPAddressinetListD1E2M.AssertModel(models[4],_testData[12], false);
                IPAddressinetListD1E2M.AssertModel(models[5],_testData[13], false);
                IPAddressinetListD1E2M.AssertModel(models[6],_testData[14], false);
                IPAddressinetListD1E2M.AssertModel(models[7],_testData[15], false);
                IPAddressinetListD1E2M.AssertModel(models[8],_testData[16], false);
                IPAddressinetListD1E2M.AssertModel(models[9],_testData[17], false);
                IPAddressinetListD1E2M.AssertModel(models[10],_testData[18], false);
                IPAddressinetListD1E2M.AssertModel(models[11],_testData[19], false);
                IPAddressinetListD1E2M.AssertModel(models[12],_testData[20], false);
                IPAddressinetListD1E2M.AssertModel(models[13],_testData[21], false);
                IPAddressinetListD1E2M.AssertModel(models[14],_testData[22], false);
                IPAddressinetListD1E2M.AssertModel(models[15],_testData[23], false);
                IPAddressinetListD1E2M.AssertModel(models[16],_testData[24], false);
                IPAddressinetListD1E2M.AssertModel(models[17],_testData[25], false);
                IPAddressinetListD1E2M.AssertModel(models[18],_testData[26], false);
                IPAddressinetListD1E2M.AssertModel(models[19],_testData[27], false);
                IPAddressinetListD1E2M.AssertModel(models[20],_testData[28], false);
                IPAddressinetListD1E2M.AssertModel(models[21],_testData[29], false);
                IPAddressinetListD1E2M.AssertModel(models[22],_testData[30], false);
                IPAddressinetListD1E2M.AssertModel(models[23],_testData[31], false);
                IPAddressinetListD1E2M.AssertModel(models[24],_testData[32], false);
                IPAddressinetListD1E2M.AssertModel(models[25],_testData[33], false);
                IPAddressinetListD1E2M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressListinetListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressListinetListD1)this).SetDbConnectionSelectModelParametrs(cmd, 166);
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

