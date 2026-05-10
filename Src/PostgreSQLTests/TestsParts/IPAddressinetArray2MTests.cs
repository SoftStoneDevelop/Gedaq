

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
System.Net.IPAddress.Parse("36.172.111.200"),

System.Net.IPAddress.Parse("144.28.173.4"),

System.Net.IPAddress.Parse("106.161.194.168"),

System.Net.IPAddress.Parse("2.18.69.245"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("8.126.80.10"),

System.Net.IPAddress.Parse("15.6.127.193"),

System.Net.IPAddress.Parse("29.208.209.156"),

},
},
            new IPAddressinetArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("35.179.192.48"),

System.Net.IPAddress.Parse("248.58.93.2"),

System.Net.IPAddress.Parse("235.78.207.67"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("22.24.132.37"),

System.Net.IPAddress.Parse("248.113.251.37"),

System.Net.IPAddress.Parse("31.33.13.46"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("215.126.49.217"),

System.Net.IPAddress.Parse("231.181.108.67"),

System.Net.IPAddress.Parse("194.32.91.222"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("10.159.22.48"),

System.Net.IPAddress.Parse("135.22.13.247"),

System.Net.IPAddress.Parse("196.196.39.183"),

System.Net.IPAddress.Parse("240.33.34.223"),

},
},
            new IPAddressinetArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("11.106.137.167"),

System.Net.IPAddress.Parse("56.156.96.182"),

System.Net.IPAddress.Parse("251.133.170.166"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("56.6.181.152"),

System.Net.IPAddress.Parse("164.72.164.155"),

System.Net.IPAddress.Parse("138.219.99.148"),

System.Net.IPAddress.Parse("156.180.86.154"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("205.139.234.25"),

System.Net.IPAddress.Parse("189.178.41.67"),

System.Net.IPAddress.Parse("188.229.218.143"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("11.107.22.202"),

System.Net.IPAddress.Parse("153.148.27.214"),

System.Net.IPAddress.Parse("14.37.238.75"),

System.Net.IPAddress.Parse("34.107.55.159"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("27.20.164.175"),

System.Net.IPAddress.Parse("208.108.236.241"),

System.Net.IPAddress.Parse("175.227.174.61"),

System.Net.IPAddress.Parse("250.102.111.155"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("209.240.191.30"),

System.Net.IPAddress.Parse("109.103.3.168"),

System.Net.IPAddress.Parse("117.150.58.130"),

System.Net.IPAddress.Parse("128.184.139.61"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("211.68.205.60"),

System.Net.IPAddress.Parse("8.226.152.179"),

System.Net.IPAddress.Parse("183.63.105.190"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("3.60.109.199"),

System.Net.IPAddress.Parse("70.190.232.88"),

System.Net.IPAddress.Parse("68.111.154.182"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("161.216.7.17"),

System.Net.IPAddress.Parse("1.56.167.96"),

System.Net.IPAddress.Parse("88.253.158.9"),

System.Net.IPAddress.Parse("240.111.66.19"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("129.224.250.189"),

System.Net.IPAddress.Parse("121.152.140.141"),

System.Net.IPAddress.Parse("89.180.19.129"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("136.99.245.52"),

System.Net.IPAddress.Parse("226.214.200.77"),

System.Net.IPAddress.Parse("50.246.138.71"),

System.Net.IPAddress.Parse("2.184.226.119"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("61.179.227.22"),

System.Net.IPAddress.Parse("110.185.150.232"),

System.Net.IPAddress.Parse("127.60.33.6"),

System.Net.IPAddress.Parse("163.106.171.121"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("217.193.211.202"),

System.Net.IPAddress.Parse("100.205.31.194"),

System.Net.IPAddress.Parse("215.121.213.25"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("174.194.183.165"),

System.Net.IPAddress.Parse("245.60.27.169"),

System.Net.IPAddress.Parse("187.108.112.194"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("147.165.221.70"),

System.Net.IPAddress.Parse("180.123.151.97"),

System.Net.IPAddress.Parse("158.233.182.2"),

System.Net.IPAddress.Parse("161.47.128.79"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("42.77.176.231"),

System.Net.IPAddress.Parse("91.231.55.226"),

System.Net.IPAddress.Parse("152.50.13.203"),

System.Net.IPAddress.Parse("224.218.86.158"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("77.60.249.248"),

System.Net.IPAddress.Parse("222.101.218.86"),

System.Net.IPAddress.Parse("115.83.59.39"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("119.148.23.43"),

System.Net.IPAddress.Parse("36.26.35.172"),

System.Net.IPAddress.Parse("123.236.166.219"),

},
},
            new IPAddressinetArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("185.34.80.81"),

System.Net.IPAddress.Parse("54.245.124.154"),

System.Net.IPAddress.Parse("101.48.129.42"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("231.104.37.251"),

System.Net.IPAddress.Parse("45.28.219.156"),

System.Net.IPAddress.Parse("36.62.18.114"),

},
},
            new IPAddressinetArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("46.243.142.79"),

System.Net.IPAddress.Parse("88.128.246.69"),

System.Net.IPAddress.Parse("92.238.171.177"),

System.Net.IPAddress.Parse("174.167.5.92"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("246.237.148.60"),

System.Net.IPAddress.Parse("207.240.183.177"),

System.Net.IPAddress.Parse("129.156.31.202"),

System.Net.IPAddress.Parse("166.227.92.205"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("107.128.171.232"),

System.Net.IPAddress.Parse("226.37.126.14"),

System.Net.IPAddress.Parse("187.2.183.157"),

System.Net.IPAddress.Parse("161.100.53.84"),

},
},
            new IPAddressinetArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("80.67.39.211"),

System.Net.IPAddress.Parse("20.148.184.192"),

System.Net.IPAddress.Parse("98.241.206.174"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("62.185.79.152"),

System.Net.IPAddress.Parse("114.39.117.89"),

System.Net.IPAddress.Parse("201.92.105.105"),

System.Net.IPAddress.Parse("175.191.243.114"),

},
},
            new IPAddressinetArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("67.82.227.186"),

System.Net.IPAddress.Parse("19.83.74.233"),

System.Net.IPAddress.Parse("21.83.195.42"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("45.174.203.35"),

System.Net.IPAddress.Parse("140.65.217.249"),

System.Net.IPAddress.Parse("116.90.133.183"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("233.44.180.102"),

System.Net.IPAddress.Parse("177.72.137.153"),

System.Net.IPAddress.Parse("85.172.105.185"),

System.Net.IPAddress.Parse("81.199.216.191"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("169.68.119.82"),

System.Net.IPAddress.Parse("149.166.114.120"),

System.Net.IPAddress.Parse("20.84.20.230"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("86.159.52.63"),

System.Net.IPAddress.Parse("106.207.174.30"),

System.Net.IPAddress.Parse("65.122.238.26"),

System.Net.IPAddress.Parse("91.217.17.7"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("175.185.117.120"),

System.Net.IPAddress.Parse("35.30.97.213"),

System.Net.IPAddress.Parse("31.181.72.173"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("25.173.140.99"),

System.Net.IPAddress.Parse("175.224.241.132"),

System.Net.IPAddress.Parse("26.201.73.3"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("62.36.14.36"),

System.Net.IPAddress.Parse("201.216.151.205"),

System.Net.IPAddress.Parse("14.93.107.90"),

System.Net.IPAddress.Parse("136.59.160.20"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("182.133.69.132"),

System.Net.IPAddress.Parse("240.59.114.245"),

System.Net.IPAddress.Parse("210.254.87.249"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("104.152.246.168"),

System.Net.IPAddress.Parse("51.56.241.171"),

System.Net.IPAddress.Parse("21.177.10.30"),

System.Net.IPAddress.Parse("181.205.253.185"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("217.106.254.18"),

System.Net.IPAddress.Parse("25.100.146.82"),

System.Net.IPAddress.Parse("222.247.129.68"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("121.82.193.234"),

System.Net.IPAddress.Parse("246.96.233.55"),

System.Net.IPAddress.Parse("97.205.62.232"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("130.172.17.7"),

System.Net.IPAddress.Parse("232.111.27.30"),

System.Net.IPAddress.Parse("157.184.89.2"),

System.Net.IPAddress.Parse("49.14.48.129"),

},
},
            new IPAddressinetArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("125.63.248.62"),

System.Net.IPAddress.Parse("134.135.240.60"),

System.Net.IPAddress.Parse("7.21.102.51"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("43.61.171.51"),

System.Net.IPAddress.Parse("50.243.60.248"),

System.Net.IPAddress.Parse("83.149.37.152"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("177.174.155.15"),

System.Net.IPAddress.Parse("33.123.145.112"),

System.Net.IPAddress.Parse("95.202.66.0"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("0.169.208.118"),

System.Net.IPAddress.Parse("67.182.76.138"),

System.Net.IPAddress.Parse("248.97.198.73"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("148.20.131.175"),

System.Net.IPAddress.Parse("142.87.184.85"),

System.Net.IPAddress.Parse("165.109.68.124"),

},
},
            new IPAddressinetArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("51.252.142.192"),

System.Net.IPAddress.Parse("76.137.47.18"),

System.Net.IPAddress.Parse("216.146.140.181"),

System.Net.IPAddress.Parse("219.107.251.76"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("22.249.213.231"),

System.Net.IPAddress.Parse("71.15.78.83"),

System.Net.IPAddress.Parse("55.203.210.213"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("114.202.209.250"),

System.Net.IPAddress.Parse("29.158.17.169"),

System.Net.IPAddress.Parse("74.24.117.211"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("153.90.4.79"),

System.Net.IPAddress.Parse("162.9.201.129"),

System.Net.IPAddress.Parse("127.40.223.34"),

},
},
            new IPAddressinetArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("9.96.174.44"),

System.Net.IPAddress.Parse("208.125.147.135"),

System.Net.IPAddress.Parse("209.12.109.6"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("218.71.42.28"),

System.Net.IPAddress.Parse("206.140.222.107"),

System.Net.IPAddress.Parse("244.13.162.96"),

System.Net.IPAddress.Parse("88.166.104.13"),

},
},
            new IPAddressinetArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("201.208.29.4"),

System.Net.IPAddress.Parse("19.98.42.127"),

System.Net.IPAddress.Parse("46.12.84.253"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("151.194.21.69"),

System.Net.IPAddress.Parse("161.21.2.10"),

System.Net.IPAddress.Parse("91.46.103.41"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("66.62.33.214"),

System.Net.IPAddress.Parse("158.24.25.225"),

System.Net.IPAddress.Parse("137.200.170.232"),

System.Net.IPAddress.Parse("192.221.28.135"),

},
},
            new IPAddressinetArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("115.162.10.140"),

System.Net.IPAddress.Parse("2.25.196.180"),

System.Net.IPAddress.Parse("163.70.143.72"),

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
System.Net.IPAddress.Parse("215.149.121.195"),

System.Net.IPAddress.Parse("150.76.252.40"),

System.Net.IPAddress.Parse("88.191.191.49"),

System.Net.IPAddress.Parse("179.62.147.123"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("85.239.101.225"),

System.Net.IPAddress.Parse("187.242.169.80"),

System.Net.IPAddress.Parse("180.242.91.172"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("107.236.252.180"),

System.Net.IPAddress.Parse("253.82.40.49"),

System.Net.IPAddress.Parse("147.142.97.76"),

System.Net.IPAddress.Parse("108.0.242.197"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("18.197.19.228"),

System.Net.IPAddress.Parse("14.115.210.21"),

System.Net.IPAddress.Parse("9.88.161.173"),

},
},
            new IPAddressinetArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("36.182.228.238"),

System.Net.IPAddress.Parse("221.171.31.94"),

System.Net.IPAddress.Parse("133.142.122.89"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("217.220.123.184"),

System.Net.IPAddress.Parse("218.99.92.154"),

System.Net.IPAddress.Parse("131.41.33.185"),

System.Net.IPAddress.Parse("145.233.6.156"),

},
},
            new IPAddressinetArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("204.48.143.222"),

System.Net.IPAddress.Parse("115.180.189.58"),

System.Net.IPAddress.Parse("36.26.34.234"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("192.222.169.138"),

System.Net.IPAddress.Parse("162.127.168.162"),

System.Net.IPAddress.Parse("118.12.14.92"),

System.Net.IPAddress.Parse("198.141.160.40"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("1.27.201.125"),

System.Net.IPAddress.Parse("88.34.248.144"),

System.Net.IPAddress.Parse("103.83.229.177"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("100.153.250.176"),

System.Net.IPAddress.Parse("7.113.112.73"),

System.Net.IPAddress.Parse("37.40.69.160"),

},
},
            new IPAddressinetArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("197.143.241.64"),

System.Net.IPAddress.Parse("64.37.248.69"),

System.Net.IPAddress.Parse("54.190.10.239"),

System.Net.IPAddress.Parse("80.142.180.105"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("245.36.153.112"),

System.Net.IPAddress.Parse("230.99.233.112"),

System.Net.IPAddress.Parse("73.185.14.48"),

System.Net.IPAddress.Parse("126.118.225.96"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("26.117.168.129"),

System.Net.IPAddress.Parse("238.76.35.153"),

System.Net.IPAddress.Parse("61.5.75.38"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("206.233.246.109"),

System.Net.IPAddress.Parse("75.175.35.172"),

System.Net.IPAddress.Parse("244.95.194.241"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("85.229.220.142"),

System.Net.IPAddress.Parse("13.183.239.65"),

System.Net.IPAddress.Parse("132.63.36.210"),

System.Net.IPAddress.Parse("215.160.46.73"),

},
},
            new IPAddressinetArray2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.215.253.199"),

System.Net.IPAddress.Parse("165.66.208.65"),

System.Net.IPAddress.Parse("2.16.16.47"),

System.Net.IPAddress.Parse("214.38.42.63"),

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
                parametr2.Value = 57;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[34], false);
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
                parametr1.Value = 52;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 15;
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[34], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
                        Assert.That(models, Has.Count.EqualTo(22));

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
                        FlatIPAddressinetArray2M.AssertModel(models[17],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[18],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[19],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[20],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[15],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[16],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[17],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[18],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[19],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[20],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[21],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(models[22],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[23],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[24],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[25],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
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
                        Assert.That(models, Has.Count.EqualTo(34));

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
                        FlatIPAddressinetArray2M.AssertModel(models[29],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[30],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[31],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[32],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[34], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[11], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[12], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[13], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[14], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[15], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[16], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[17], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[18], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[19], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[14],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[15],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[16],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[17],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[18],_testData[29], false);
                        IPAddressinetArray2M.AssertModel(models[19],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[20],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[21],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[22],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[12], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[13], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[14], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[15], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[16], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[17], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[18], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[19], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[14],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[15],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[16],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[17],_testData[29], false);
                        IPAddressinetArray2M.AssertModel(models[18],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[19],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[20],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[21],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[34], false);
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
                await ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 85, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[34], false);
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
                await ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 37, query1, 107, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[34], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 15, query1, 97, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 156, query1, 107, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 151, query1, 45, query2))
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[15],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[16],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[17],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[18],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[19],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[20],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[21],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(models[22],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[23],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[24],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[25],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[26],_testData[34], false);
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
                await ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 101, query1, 45, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 52, query1, 9, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        FlatIPAddressinetArray2M.AssertModel(models[21],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[22],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[23],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[24],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

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
                        FlatIPAddressinetArray2M.AssertModel(models[29],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[30],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[31],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[32],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[33],_testData[34], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 89, query1, 29, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[28],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 52, 11))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[9], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[10], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[11], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[12], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[13], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[14], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[15], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[16], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[17], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[18], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[19], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[14],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[15],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[16],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[17],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[18],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[19],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[20],_testData[29], false);
                        IPAddressinetArray2M.AssertModel(models[21],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[22],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[23],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[24],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[25],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatch(connection, 90, 109))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

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
                        IPAddressinetArray2M.AssertModel(models[13],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[14],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[15],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[16],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[29], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[34], false);
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
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 67);
                var models = await ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                IPAddressinetArray2M.AssertModel(models[0],_testData[12], false);
                IPAddressinetArray2M.AssertModel(models[1],_testData[13], false);
                IPAddressinetArray2M.AssertModel(models[2],_testData[14], false);
                IPAddressinetArray2M.AssertModel(models[3],_testData[15], false);
                IPAddressinetArray2M.AssertModel(models[4],_testData[16], false);
                IPAddressinetArray2M.AssertModel(models[5],_testData[17], false);
                IPAddressinetArray2M.AssertModel(models[6],_testData[18], false);
                IPAddressinetArray2M.AssertModel(models[7],_testData[19], false);
                IPAddressinetArray2M.AssertModel(models[8],_testData[20], false);
                IPAddressinetArray2M.AssertModel(models[9],_testData[21], false);
                IPAddressinetArray2M.AssertModel(models[10],_testData[22], false);
                IPAddressinetArray2M.AssertModel(models[11],_testData[23], false);
                IPAddressinetArray2M.AssertModel(models[12],_testData[24], false);
                IPAddressinetArray2M.AssertModel(models[13],_testData[25], false);
                IPAddressinetArray2M.AssertModel(models[14],_testData[26], false);
                IPAddressinetArray2M.AssertModel(models[15],_testData[27], false);
                IPAddressinetArray2M.AssertModel(models[16],_testData[28], false);
                IPAddressinetArray2M.AssertModel(models[17],_testData[29], false);
                IPAddressinetArray2M.AssertModel(models[18],_testData[30], false);
                IPAddressinetArray2M.AssertModel(models[19],_testData[31], false);
                IPAddressinetArray2M.AssertModel(models[20],_testData[32], false);
                IPAddressinetArray2M.AssertModel(models[21],_testData[33], false);
                IPAddressinetArray2M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressListinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 90);
                var models =  ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

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
                IPAddressinetArray2M.AssertModel(models[13],_testData[30], false);
                IPAddressinetArray2M.AssertModel(models[14],_testData[31], false);
                IPAddressinetArray2M.AssertModel(models[15],_testData[32], false);
                IPAddressinetArray2M.AssertModel(models[16],_testData[33], false);
                IPAddressinetArray2M.AssertModel(models[17],_testData[34], false);
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

