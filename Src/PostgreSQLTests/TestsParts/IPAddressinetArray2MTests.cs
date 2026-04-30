

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
System.Net.IPAddress.Parse("63.57.69.181"),

System.Net.IPAddress.Parse("169.43.78.59"),

System.Net.IPAddress.Parse("164.35.36.18"),

System.Net.IPAddress.Parse("99.46.238.240"),

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
System.Net.IPAddress.Parse("110.166.127.123"),

System.Net.IPAddress.Parse("221.203.20.232"),

System.Net.IPAddress.Parse("212.188.211.41"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("69.160.22.239"),

System.Net.IPAddress.Parse("102.185.114.36"),

System.Net.IPAddress.Parse("60.155.228.203"),

System.Net.IPAddress.Parse("126.35.27.173"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("204.88.206.185"),

System.Net.IPAddress.Parse("92.122.223.63"),

System.Net.IPAddress.Parse("103.48.126.168"),

System.Net.IPAddress.Parse("35.180.107.213"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("129.109.146.217"),

System.Net.IPAddress.Parse("212.115.193.33"),

System.Net.IPAddress.Parse("8.151.153.14"),

},
},
            new IPAddressinetArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("15.123.107.10"),

System.Net.IPAddress.Parse("11.123.42.243"),

System.Net.IPAddress.Parse("96.243.135.62"),

System.Net.IPAddress.Parse("15.84.175.180"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("113.52.163.189"),

System.Net.IPAddress.Parse("93.10.217.254"),

System.Net.IPAddress.Parse("62.136.94.241"),

},
},
            new IPAddressinetArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("222.29.193.206"),

System.Net.IPAddress.Parse("81.225.80.18"),

System.Net.IPAddress.Parse("105.33.54.253"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("130.140.58.200"),

System.Net.IPAddress.Parse("23.176.31.136"),

System.Net.IPAddress.Parse("64.3.187.146"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("34.96.88.127"),

System.Net.IPAddress.Parse("82.148.94.231"),

System.Net.IPAddress.Parse("196.92.7.113"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("200.115.159.207"),

System.Net.IPAddress.Parse("196.221.109.198"),

System.Net.IPAddress.Parse("212.203.114.145"),

System.Net.IPAddress.Parse("238.102.176.128"),

},
},
            new IPAddressinetArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("145.31.66.101"),

System.Net.IPAddress.Parse("106.125.142.210"),

System.Net.IPAddress.Parse("235.123.226.56"),

System.Net.IPAddress.Parse("230.174.139.250"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("148.249.21.92"),

System.Net.IPAddress.Parse("176.83.59.145"),

System.Net.IPAddress.Parse("62.5.110.164"),

System.Net.IPAddress.Parse("226.74.16.95"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("138.215.152.17"),

System.Net.IPAddress.Parse("159.149.214.139"),

System.Net.IPAddress.Parse("163.73.10.143"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("153.87.227.221"),

System.Net.IPAddress.Parse("130.213.40.186"),

System.Net.IPAddress.Parse("107.142.36.172"),

System.Net.IPAddress.Parse("146.101.94.155"),

},
},
            new IPAddressinetArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("55.28.1.240"),

System.Net.IPAddress.Parse("37.204.193.57"),

System.Net.IPAddress.Parse("142.203.198.21"),

System.Net.IPAddress.Parse("179.244.18.44"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("19.79.185.115"),

System.Net.IPAddress.Parse("217.183.181.68"),

System.Net.IPAddress.Parse("236.56.21.79"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("18.99.253.191"),

System.Net.IPAddress.Parse("221.104.150.181"),

System.Net.IPAddress.Parse("162.236.8.190"),

System.Net.IPAddress.Parse("145.108.161.154"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("217.61.207.91"),

System.Net.IPAddress.Parse("93.65.107.27"),

System.Net.IPAddress.Parse("170.176.194.205"),

System.Net.IPAddress.Parse("87.104.222.55"),

},
},
            new IPAddressinetArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("14.154.17.31"),

System.Net.IPAddress.Parse("220.243.85.127"),

System.Net.IPAddress.Parse("212.167.70.193"),

System.Net.IPAddress.Parse("252.252.237.131"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("154.118.190.23"),

System.Net.IPAddress.Parse("232.20.229.80"),

System.Net.IPAddress.Parse("120.48.63.70"),

System.Net.IPAddress.Parse("102.8.215.60"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("77.112.52.16"),

System.Net.IPAddress.Parse("150.62.24.85"),

System.Net.IPAddress.Parse("66.196.74.188"),

System.Net.IPAddress.Parse("38.34.80.97"),

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
System.Net.IPAddress.Parse("54.169.13.149"),

System.Net.IPAddress.Parse("161.77.182.81"),

System.Net.IPAddress.Parse("86.213.252.111"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("15.156.206.100"),

System.Net.IPAddress.Parse("101.24.242.129"),

System.Net.IPAddress.Parse("116.206.12.63"),

},
},
            new IPAddressinetArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("129.205.106.194"),

System.Net.IPAddress.Parse("101.95.34.125"),

System.Net.IPAddress.Parse("54.155.46.115"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("115.70.18.180"),

System.Net.IPAddress.Parse("112.124.59.195"),

System.Net.IPAddress.Parse("161.115.196.44"),

System.Net.IPAddress.Parse("94.108.175.126"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("28.51.34.135"),

System.Net.IPAddress.Parse("116.123.197.25"),

System.Net.IPAddress.Parse("147.78.62.190"),

System.Net.IPAddress.Parse("7.131.225.133"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("133.98.254.112"),

System.Net.IPAddress.Parse("121.36.63.61"),

System.Net.IPAddress.Parse("184.17.107.132"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("13.170.31.157"),

System.Net.IPAddress.Parse("200.101.69.135"),

System.Net.IPAddress.Parse("140.15.72.250"),

System.Net.IPAddress.Parse("55.168.61.230"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("190.81.226.89"),

System.Net.IPAddress.Parse("194.157.102.54"),

System.Net.IPAddress.Parse("14.223.19.113"),

System.Net.IPAddress.Parse("128.115.248.122"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("75.60.30.73"),

System.Net.IPAddress.Parse("202.228.171.47"),

System.Net.IPAddress.Parse("73.15.147.65"),

},
},
            new IPAddressinetArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("6.233.213.120"),

System.Net.IPAddress.Parse("203.89.0.61"),

System.Net.IPAddress.Parse("97.24.49.205"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("189.247.227.53"),

System.Net.IPAddress.Parse("94.50.225.57"),

System.Net.IPAddress.Parse("82.22.179.18"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("193.163.139.122"),

System.Net.IPAddress.Parse("10.85.2.51"),

System.Net.IPAddress.Parse("114.115.39.57"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("8.90.90.174"),

System.Net.IPAddress.Parse("53.45.232.112"),

System.Net.IPAddress.Parse("51.227.106.92"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("181.31.194.235"),

System.Net.IPAddress.Parse("208.89.29.112"),

System.Net.IPAddress.Parse("190.38.217.216"),

System.Net.IPAddress.Parse("80.55.135.42"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("126.189.37.141"),

System.Net.IPAddress.Parse("104.72.153.253"),

System.Net.IPAddress.Parse("201.149.119.67"),

System.Net.IPAddress.Parse("251.160.219.128"),

},
},
            new IPAddressinetArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("210.125.96.10"),

System.Net.IPAddress.Parse("161.109.234.11"),

System.Net.IPAddress.Parse("122.99.25.253"),

System.Net.IPAddress.Parse("89.96.81.156"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("21.72.182.83"),

System.Net.IPAddress.Parse("85.94.151.73"),

System.Net.IPAddress.Parse("236.191.119.197"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("107.49.216.24"),

System.Net.IPAddress.Parse("154.239.56.113"),

System.Net.IPAddress.Parse("111.74.216.152"),

System.Net.IPAddress.Parse("222.15.195.234"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("121.146.211.166"),

System.Net.IPAddress.Parse("117.30.232.40"),

System.Net.IPAddress.Parse("60.126.156.138"),

System.Net.IPAddress.Parse("135.102.54.241"),

},
},
            new IPAddressinetArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("2.145.199.32"),

System.Net.IPAddress.Parse("25.15.197.136"),

System.Net.IPAddress.Parse("25.21.238.251"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("142.4.69.224"),

System.Net.IPAddress.Parse("251.2.157.167"),

System.Net.IPAddress.Parse("97.222.245.161"),

System.Net.IPAddress.Parse("42.163.169.217"),

},
},
            new IPAddressinetArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("59.43.189.78"),

System.Net.IPAddress.Parse("10.107.60.13"),

System.Net.IPAddress.Parse("108.197.239.34"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("153.12.228.212"),

System.Net.IPAddress.Parse("86.66.211.182"),

System.Net.IPAddress.Parse("125.222.86.187"),

System.Net.IPAddress.Parse("98.178.116.195"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.72.244.177"),

System.Net.IPAddress.Parse("160.234.136.226"),

System.Net.IPAddress.Parse("194.9.78.205"),

System.Net.IPAddress.Parse("180.232.145.135"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("167.142.108.56"),

System.Net.IPAddress.Parse("14.58.197.63"),

System.Net.IPAddress.Parse("166.210.205.20"),

},
},
            new IPAddressinetArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("194.253.17.153"),

System.Net.IPAddress.Parse("27.229.249.25"),

System.Net.IPAddress.Parse("203.224.85.170"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("53.180.223.187"),

System.Net.IPAddress.Parse("115.171.233.85"),

System.Net.IPAddress.Parse("77.151.179.55"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("116.0.14.162"),

System.Net.IPAddress.Parse("202.62.167.70"),

System.Net.IPAddress.Parse("101.142.118.101"),

System.Net.IPAddress.Parse("220.123.57.179"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("169.156.85.87"),

System.Net.IPAddress.Parse("6.160.17.237"),

System.Net.IPAddress.Parse("159.92.211.134"),

},
},
            new IPAddressinetArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("32.102.31.89"),

System.Net.IPAddress.Parse("91.247.52.63"),

System.Net.IPAddress.Parse("35.17.84.22"),

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
System.Net.IPAddress.Parse("91.31.179.113"),

System.Net.IPAddress.Parse("187.228.185.213"),

System.Net.IPAddress.Parse("53.245.44.73"),

System.Net.IPAddress.Parse("4.147.98.91"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("82.125.74.108"),

System.Net.IPAddress.Parse("121.133.115.146"),

System.Net.IPAddress.Parse("60.183.1.44"),

System.Net.IPAddress.Parse("67.178.7.116"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("85.123.36.151"),

System.Net.IPAddress.Parse("251.130.9.238"),

System.Net.IPAddress.Parse("86.69.42.128"),

},
},
            new IPAddressinetArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("14.193.119.22"),

System.Net.IPAddress.Parse("163.216.27.150"),

System.Net.IPAddress.Parse("65.106.101.12"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("94.176.80.94"),

System.Net.IPAddress.Parse("180.101.192.203"),

System.Net.IPAddress.Parse("104.129.170.86"),

System.Net.IPAddress.Parse("206.13.61.48"),

},
},
            new IPAddressinetArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("164.73.206.69"),

System.Net.IPAddress.Parse("153.51.97.66"),

System.Net.IPAddress.Parse("48.10.214.166"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("201.138.76.132"),

System.Net.IPAddress.Parse("20.228.36.11"),

System.Net.IPAddress.Parse("118.111.162.30"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("62.209.19.118"),

System.Net.IPAddress.Parse("45.84.78.118"),

System.Net.IPAddress.Parse("53.63.9.15"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("43.237.154.197"),

System.Net.IPAddress.Parse("85.150.77.108"),

System.Net.IPAddress.Parse("82.148.40.223"),

System.Net.IPAddress.Parse("181.44.173.253"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("51.119.203.166"),

System.Net.IPAddress.Parse("228.47.66.228"),

System.Net.IPAddress.Parse("3.158.112.73"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("28.179.4.244"),

System.Net.IPAddress.Parse("121.251.131.96"),

System.Net.IPAddress.Parse("2.99.50.164"),

System.Net.IPAddress.Parse("183.79.104.208"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("13.217.69.16"),

System.Net.IPAddress.Parse("42.156.41.108"),

System.Net.IPAddress.Parse("14.156.232.249"),

System.Net.IPAddress.Parse("86.40.198.194"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("226.202.15.71"),

System.Net.IPAddress.Parse("44.249.118.190"),

System.Net.IPAddress.Parse("184.50.116.155"),

},
},
            new IPAddressinetArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("28.89.212.134"),

System.Net.IPAddress.Parse("143.48.12.21"),

System.Net.IPAddress.Parse("187.163.219.48"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("2.190.133.199"),

System.Net.IPAddress.Parse("97.95.196.20"),

System.Net.IPAddress.Parse("80.152.67.240"),

System.Net.IPAddress.Parse("166.65.143.215"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("168.88.161.115"),

System.Net.IPAddress.Parse("47.114.222.84"),

System.Net.IPAddress.Parse("71.67.215.14"),

System.Net.IPAddress.Parse("148.41.10.51"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 176,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("239.219.152.194"),

System.Net.IPAddress.Parse("43.79.177.127"),

System.Net.IPAddress.Parse("220.212.112.67"),

System.Net.IPAddress.Parse("71.173.214.135"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("125.37.173.242"),

System.Net.IPAddress.Parse("157.11.76.222"),

System.Net.IPAddress.Parse("4.198.68.225"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 185,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("1.190.100.222"),

System.Net.IPAddress.Parse("71.207.200.25"),

System.Net.IPAddress.Parse("69.249.70.184"),

System.Net.IPAddress.Parse("102.220.45.238"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("44.117.101.182"),

System.Net.IPAddress.Parse("27.103.235.87"),

System.Net.IPAddress.Parse("131.100.39.12"),

System.Net.IPAddress.Parse("107.36.139.76"),

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
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
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
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
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
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
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
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[34], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
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
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[27],_testData[34], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(models[15],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[16],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[17],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[18],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(models[15],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[16],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[17],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[18],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

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
                        IPAddressinetArray2M.AssertModel(models[28],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[29],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[30],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[31],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

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
                        IPAddressinetArray2M.AssertModel(models[24],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[25],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[26],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[27],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

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
                        IPAddressinetArray2M.AssertModel(models[14],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[15],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[16],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[17],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[18],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 34, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
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
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
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
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[23],_testData[34], false);
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
                await ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 27, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
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
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
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
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[26],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 65, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[34], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 22, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[31],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 111, query1, 51, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                        FlatIPAddressinetArray2M.AssertModel(models[20],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[21],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[22],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[23],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[24],_testData[34], false);
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
                await ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 56, query1, 98, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
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
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
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
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 13, query1, 27, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

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
                        FlatIPAddressinetArray2M.AssertModel(models[28],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[29],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[30],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[31],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

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
                        FlatIPAddressinetArray2M.AssertModel(models[26],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[27],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[28],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[29],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[30],_testData[34], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 87, query1, 5, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
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
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[33],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 34, 40))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatch(connection, 106, 127))
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
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 111);
                var models = await ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
IPAddressinetArray2M.AssertModel(models[0],_testData[20], false);IPAddressinetArray2M.AssertModel(models[1],_testData[21], false);IPAddressinetArray2M.AssertModel(models[2],_testData[22], false);IPAddressinetArray2M.AssertModel(models[3],_testData[23], false);IPAddressinetArray2M.AssertModel(models[4],_testData[24], false);IPAddressinetArray2M.AssertModel(models[5],_testData[25], false);IPAddressinetArray2M.AssertModel(models[6],_testData[26], false);IPAddressinetArray2M.AssertModel(models[7],_testData[27], false);IPAddressinetArray2M.AssertModel(models[8],_testData[28], false);IPAddressinetArray2M.AssertModel(models[9],_testData[29], false);IPAddressinetArray2M.AssertModel(models[10],_testData[30], false);IPAddressinetArray2M.AssertModel(models[11],_testData[31], false);IPAddressinetArray2M.AssertModel(models[12],_testData[32], false);IPAddressinetArray2M.AssertModel(models[13],_testData[33], false);IPAddressinetArray2M.AssertModel(models[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressListinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 96);
                var models =  ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
IPAddressinetArray2M.AssertModel(models[0],_testData[17], false);IPAddressinetArray2M.AssertModel(models[1],_testData[18], false);IPAddressinetArray2M.AssertModel(models[2],_testData[19], false);IPAddressinetArray2M.AssertModel(models[3],_testData[20], false);IPAddressinetArray2M.AssertModel(models[4],_testData[21], false);IPAddressinetArray2M.AssertModel(models[5],_testData[22], false);IPAddressinetArray2M.AssertModel(models[6],_testData[23], false);IPAddressinetArray2M.AssertModel(models[7],_testData[24], false);IPAddressinetArray2M.AssertModel(models[8],_testData[25], false);IPAddressinetArray2M.AssertModel(models[9],_testData[26], false);IPAddressinetArray2M.AssertModel(models[10],_testData[27], false);IPAddressinetArray2M.AssertModel(models[11],_testData[28], false);IPAddressinetArray2M.AssertModel(models[12],_testData[29], false);IPAddressinetArray2M.AssertModel(models[13],_testData[30], false);IPAddressinetArray2M.AssertModel(models[14],_testData[31], false);IPAddressinetArray2M.AssertModel(models[15],_testData[32], false);IPAddressinetArray2M.AssertModel(models[16],_testData[33], false);IPAddressinetArray2M.AssertModel(models[17],_testData[34], false);
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
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray2MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressListinetArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_ipaddressinetarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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
                var models = ((IIPAddressListinetArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_ipaddressinetarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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

        [Test, Order(13)]
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

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IIPAddressListinetArray)this).ExportModelInner(connection).ToList();
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

