

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
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("213.183.35.6"),

System.Net.IPAddress.Parse("71.192.88.224"),

System.Net.IPAddress.Parse("114.101.181.54"),

System.Net.IPAddress.Parse("50.26.176.204"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("195.176.185.216"),

System.Net.IPAddress.Parse("37.115.174.59"),

System.Net.IPAddress.Parse("227.36.59.222"),

},
},
            new IPAddressinetArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("72.148.20.127"),

System.Net.IPAddress.Parse("14.49.117.109"),

System.Net.IPAddress.Parse("153.14.68.160"),

System.Net.IPAddress.Parse("30.187.83.68"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("134.18.145.82"),

System.Net.IPAddress.Parse("62.212.70.46"),

System.Net.IPAddress.Parse("141.109.125.228"),

System.Net.IPAddress.Parse("88.133.185.216"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("187.185.21.240"),

System.Net.IPAddress.Parse("62.75.13.13"),

System.Net.IPAddress.Parse("38.161.167.29"),

System.Net.IPAddress.Parse("116.47.195.23"),

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
System.Net.IPAddress.Parse("35.161.43.97"),

System.Net.IPAddress.Parse("194.111.184.38"),

System.Net.IPAddress.Parse("145.219.144.216"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("44.202.85.132"),

System.Net.IPAddress.Parse("202.64.120.114"),

System.Net.IPAddress.Parse("246.13.181.86"),

System.Net.IPAddress.Parse("89.215.24.226"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("76.165.243.189"),

System.Net.IPAddress.Parse("184.9.127.95"),

System.Net.IPAddress.Parse("108.128.208.242"),

System.Net.IPAddress.Parse("217.144.126.106"),

},
},
            new IPAddressinetArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("43.243.122.233"),

System.Net.IPAddress.Parse("245.72.206.144"),

System.Net.IPAddress.Parse("78.63.230.254"),

System.Net.IPAddress.Parse("139.27.99.86"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("143.209.118.81"),

System.Net.IPAddress.Parse("240.229.59.40"),

System.Net.IPAddress.Parse("130.124.37.88"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("130.201.151.248"),

System.Net.IPAddress.Parse("251.130.66.172"),

System.Net.IPAddress.Parse("145.219.223.142"),

System.Net.IPAddress.Parse("178.120.79.101"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("208.135.230.172"),

System.Net.IPAddress.Parse("87.39.186.43"),

System.Net.IPAddress.Parse("197.166.227.135"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("133.64.242.176"),

System.Net.IPAddress.Parse("44.244.186.113"),

System.Net.IPAddress.Parse("3.87.72.19"),

System.Net.IPAddress.Parse("112.43.233.66"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("205.93.222.11"),

System.Net.IPAddress.Parse("109.230.56.88"),

System.Net.IPAddress.Parse("74.84.247.154"),

},
},
            new IPAddressinetArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("82.240.214.13"),

System.Net.IPAddress.Parse("237.254.141.45"),

System.Net.IPAddress.Parse("80.119.245.224"),

System.Net.IPAddress.Parse("71.111.91.121"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("248.10.201.79"),

System.Net.IPAddress.Parse("118.50.214.226"),

System.Net.IPAddress.Parse("187.217.213.213"),

System.Net.IPAddress.Parse("181.35.58.116"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("33.245.242.6"),

System.Net.IPAddress.Parse("70.121.164.87"),

System.Net.IPAddress.Parse("38.75.248.66"),

System.Net.IPAddress.Parse("233.86.198.24"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("195.147.119.143"),

System.Net.IPAddress.Parse("93.168.93.192"),

System.Net.IPAddress.Parse("165.143.116.201"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("240.17.107.165"),

System.Net.IPAddress.Parse("198.226.103.204"),

System.Net.IPAddress.Parse("123.172.233.153"),

System.Net.IPAddress.Parse("34.73.3.162"),

},
},
            new IPAddressinetArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("102.80.52.81"),

System.Net.IPAddress.Parse("38.85.35.48"),

System.Net.IPAddress.Parse("210.214.8.186"),

System.Net.IPAddress.Parse("172.80.225.216"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("243.56.79.29"),

System.Net.IPAddress.Parse("200.93.215.169"),

System.Net.IPAddress.Parse("84.106.126.134"),

System.Net.IPAddress.Parse("89.170.253.32"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("73.90.26.76"),

System.Net.IPAddress.Parse("8.74.187.145"),

System.Net.IPAddress.Parse("7.82.128.64"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("218.79.215.56"),

System.Net.IPAddress.Parse("67.75.245.64"),

System.Net.IPAddress.Parse("85.7.168.243"),

System.Net.IPAddress.Parse("246.203.140.198"),

},
},
            new IPAddressinetArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("94.87.39.189"),

System.Net.IPAddress.Parse("99.42.188.107"),

System.Net.IPAddress.Parse("174.78.230.221"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("62.249.63.119"),

System.Net.IPAddress.Parse("197.148.176.43"),

System.Net.IPAddress.Parse("3.147.60.51"),

},
},
            new IPAddressinetArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("175.86.220.249"),

System.Net.IPAddress.Parse("221.233.165.135"),

System.Net.IPAddress.Parse("134.198.207.53"),

System.Net.IPAddress.Parse("20.126.81.206"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("177.35.242.192"),

System.Net.IPAddress.Parse("114.42.44.120"),

System.Net.IPAddress.Parse("186.0.134.77"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("241.214.147.66"),

System.Net.IPAddress.Parse("51.23.178.193"),

System.Net.IPAddress.Parse("210.82.100.53"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("49.96.13.251"),

System.Net.IPAddress.Parse("113.5.164.72"),

System.Net.IPAddress.Parse("109.98.197.206"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("24.175.213.180"),

System.Net.IPAddress.Parse("111.118.154.89"),

System.Net.IPAddress.Parse("227.159.167.171"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("73.200.13.224"),

System.Net.IPAddress.Parse("27.129.207.137"),

System.Net.IPAddress.Parse("247.191.239.204"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("235.188.191.145"),

System.Net.IPAddress.Parse("221.233.219.156"),

System.Net.IPAddress.Parse("221.101.25.87"),

System.Net.IPAddress.Parse("52.199.217.140"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("169.140.99.183"),

System.Net.IPAddress.Parse("119.48.33.147"),

System.Net.IPAddress.Parse("207.109.226.37"),

System.Net.IPAddress.Parse("241.128.144.123"),

},
},
            new IPAddressinetArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("15.153.126.206"),

System.Net.IPAddress.Parse("163.93.49.134"),

System.Net.IPAddress.Parse("130.216.92.27"),

System.Net.IPAddress.Parse("41.20.4.224"),

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
System.Net.IPAddress.Parse("172.33.79.178"),

System.Net.IPAddress.Parse("8.245.175.243"),

System.Net.IPAddress.Parse("156.142.150.160"),

System.Net.IPAddress.Parse("233.98.39.33"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("31.227.219.47"),

System.Net.IPAddress.Parse("47.159.49.252"),

System.Net.IPAddress.Parse("24.200.76.120"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("12.134.28.217"),

System.Net.IPAddress.Parse("154.32.200.217"),

System.Net.IPAddress.Parse("198.41.247.73"),

System.Net.IPAddress.Parse("116.242.15.11"),

},
},
            new IPAddressinetArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("159.64.233.114"),

System.Net.IPAddress.Parse("223.79.20.188"),

System.Net.IPAddress.Parse("149.63.209.11"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("246.50.196.224"),

System.Net.IPAddress.Parse("222.167.237.40"),

System.Net.IPAddress.Parse("143.65.166.152"),

System.Net.IPAddress.Parse("211.196.227.203"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("93.40.198.43"),

System.Net.IPAddress.Parse("209.62.101.252"),

System.Net.IPAddress.Parse("40.37.6.184"),

System.Net.IPAddress.Parse("96.64.178.114"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("208.65.248.132"),

System.Net.IPAddress.Parse("232.183.191.219"),

System.Net.IPAddress.Parse("179.113.22.251"),

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
System.Net.IPAddress.Parse("16.101.208.173"),

System.Net.IPAddress.Parse("203.106.245.218"),

System.Net.IPAddress.Parse("219.130.163.29"),

System.Net.IPAddress.Parse("11.133.113.90"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("248.220.67.226"),

System.Net.IPAddress.Parse("191.210.187.6"),

System.Net.IPAddress.Parse("107.40.184.213"),

System.Net.IPAddress.Parse("91.184.129.218"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("3.111.226.227"),

System.Net.IPAddress.Parse("182.20.63.161"),

System.Net.IPAddress.Parse("73.32.5.135"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("162.245.4.129"),

System.Net.IPAddress.Parse("214.126.186.5"),

System.Net.IPAddress.Parse("101.244.135.250"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("39.128.141.218"),

System.Net.IPAddress.Parse("36.175.239.175"),

System.Net.IPAddress.Parse("29.94.126.99"),

System.Net.IPAddress.Parse("222.234.205.194"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("35.104.190.71"),

System.Net.IPAddress.Parse("46.172.147.29"),

System.Net.IPAddress.Parse("251.223.171.140"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("81.212.60.186"),

System.Net.IPAddress.Parse("66.69.214.101"),

System.Net.IPAddress.Parse("246.217.79.132"),

System.Net.IPAddress.Parse("62.131.209.44"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("253.218.146.95"),

System.Net.IPAddress.Parse("159.185.212.158"),

System.Net.IPAddress.Parse("6.94.27.226"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("61.88.79.93"),

System.Net.IPAddress.Parse("246.77.212.83"),

System.Net.IPAddress.Parse("4.86.83.45"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("122.36.54.22"),

System.Net.IPAddress.Parse("20.10.4.236"),

System.Net.IPAddress.Parse("23.235.136.207"),

System.Net.IPAddress.Parse("78.141.40.192"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("26.63.69.92"),

System.Net.IPAddress.Parse("159.152.99.93"),

System.Net.IPAddress.Parse("33.117.132.68"),

System.Net.IPAddress.Parse("28.193.90.55"),

},
},
            new IPAddressinetArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("72.52.189.111"),

System.Net.IPAddress.Parse("110.75.61.119"),

System.Net.IPAddress.Parse("86.7.168.22"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("79.246.205.189"),

System.Net.IPAddress.Parse("46.81.220.239"),

System.Net.IPAddress.Parse("234.96.165.185"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("112.154.141.230"),

System.Net.IPAddress.Parse("109.221.183.35"),

System.Net.IPAddress.Parse("103.120.120.145"),

System.Net.IPAddress.Parse("70.159.29.51"),

},
},
            new IPAddressinetArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("13.46.101.182"),

System.Net.IPAddress.Parse("234.10.85.213"),

System.Net.IPAddress.Parse("49.56.151.175"),

System.Net.IPAddress.Parse("184.117.243.227"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("174.54.15.222"),

System.Net.IPAddress.Parse("245.185.1.158"),

System.Net.IPAddress.Parse("73.89.59.25"),

System.Net.IPAddress.Parse("140.58.113.18"),

},
},
            new IPAddressinetArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("15.48.253.19"),

System.Net.IPAddress.Parse("209.32.44.121"),

System.Net.IPAddress.Parse("115.101.173.195"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("137.125.45.88"),

System.Net.IPAddress.Parse("143.46.7.108"),

System.Net.IPAddress.Parse("85.127.109.33"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("60.229.215.251"),

System.Net.IPAddress.Parse("243.47.98.163"),

System.Net.IPAddress.Parse("128.121.96.115"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("91.202.42.133"),

System.Net.IPAddress.Parse("20.215.138.177"),

System.Net.IPAddress.Parse("170.62.24.195"),

System.Net.IPAddress.Parse("138.244.197.194"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("16.127.151.57"),

System.Net.IPAddress.Parse("58.28.112.131"),

System.Net.IPAddress.Parse("253.145.228.134"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("114.210.189.20"),

System.Net.IPAddress.Parse("118.215.163.147"),

System.Net.IPAddress.Parse("124.8.245.165"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("235.143.144.20"),

System.Net.IPAddress.Parse("137.110.224.55"),

System.Net.IPAddress.Parse("173.30.94.119"),

System.Net.IPAddress.Parse("168.155.26.136"),

},
},
            new IPAddressinetArray2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("25.202.209.230"),

System.Net.IPAddress.Parse("165.211.74.4"),

System.Net.IPAddress.Parse("51.176.119.145"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("62.46.65.106"),

System.Net.IPAddress.Parse("190.81.84.199"),

System.Net.IPAddress.Parse("199.141.220.181"),

System.Net.IPAddress.Parse("69.170.199.148"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("87.136.85.82"),

System.Net.IPAddress.Parse("220.17.151.97"),

System.Net.IPAddress.Parse("71.68.188.65"),

System.Net.IPAddress.Parse("151.13.238.89"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("243.25.95.187"),

System.Net.IPAddress.Parse("235.148.163.64"),

System.Net.IPAddress.Parse("135.237.19.220"),

},
},
            new IPAddressinetArray2M
{
    Id = 176,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("124.238.254.237"),

System.Net.IPAddress.Parse("37.148.254.211"),

System.Net.IPAddress.Parse("208.217.236.133"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 181,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("78.57.62.50"),

System.Net.IPAddress.Parse("90.102.114.51"),

System.Net.IPAddress.Parse("80.104.55.31"),

System.Net.IPAddress.Parse("180.221.210.53"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("91.31.235.183"),

System.Net.IPAddress.Parse("102.103.154.17"),

System.Net.IPAddress.Parse("236.188.142.240"),

System.Net.IPAddress.Parse("215.157.44.60"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 190,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("41.20.134.131"),

System.Net.IPAddress.Parse("71.1.35.60"),

System.Net.IPAddress.Parse("220.102.231.61"),

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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                Assert.That(secondItems1, Has.Count.EqualTo(31));
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
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[30],_testData[34], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
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
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[32],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
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
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
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
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[29],_testData[34], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
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
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
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
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[33],_testData[34], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[29], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[29], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
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
                await ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 154, query1, 160, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[34], false);
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
                await ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 167, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[34], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 8, query1, 167, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 134, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 175, query1, 167, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[34], false);
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
                await ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 48, query1, 134, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
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
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
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
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 108, query1, 141, query2))
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[34], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 77, query1, 134, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
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
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 176, 45))
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatch(connection, 18, 167))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

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
                        IPAddressinetArray2M.AssertModel(models[26],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[27],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[28],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[29],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[30],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IIPAddressListinetArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 112);
                var models = await ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressListinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 12);
                var models =  ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

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
                IPAddressinetArray2M.AssertModel(models[27],_testData[30], false);
                IPAddressinetArray2M.AssertModel(models[28],_testData[31], false);
                IPAddressinetArray2M.AssertModel(models[29],_testData[32], false);
                IPAddressinetArray2M.AssertModel(models[30],_testData[33], false);
                IPAddressinetArray2M.AssertModel(models[31],_testData[34], false);
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

