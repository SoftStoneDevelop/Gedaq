

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("173.222.128.32"),

System.Net.IPAddress.Parse("156.127.33.33"),

System.Net.IPAddress.Parse("37.175.190.99"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("220.250.102.210"),

System.Net.IPAddress.Parse("105.44.72.99"),

System.Net.IPAddress.Parse("231.195.197.111"),

System.Net.IPAddress.Parse("41.18.3.204"),

},
},
            new IPAddressinetArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("236.115.56.233"),

System.Net.IPAddress.Parse("99.58.67.16"),

System.Net.IPAddress.Parse("147.155.40.153"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("27.206.2.239"),

System.Net.IPAddress.Parse("228.50.55.126"),

System.Net.IPAddress.Parse("45.215.56.158"),

System.Net.IPAddress.Parse("193.251.188.83"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("154.248.69.125"),

System.Net.IPAddress.Parse("77.131.52.183"),

System.Net.IPAddress.Parse("144.224.5.183"),

System.Net.IPAddress.Parse("136.159.251.132"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("221.66.59.55"),

System.Net.IPAddress.Parse("73.139.52.13"),

System.Net.IPAddress.Parse("181.236.127.198"),

},
},
            new IPAddressinetArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("253.31.96.248"),

System.Net.IPAddress.Parse("16.56.90.13"),

System.Net.IPAddress.Parse("151.16.141.38"),

System.Net.IPAddress.Parse("18.177.222.142"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("213.21.222.48"),

System.Net.IPAddress.Parse("82.94.97.118"),

System.Net.IPAddress.Parse("235.94.35.18"),

},
},
            new IPAddressinetArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("168.13.67.87"),

System.Net.IPAddress.Parse("180.27.79.29"),

System.Net.IPAddress.Parse("104.139.34.77"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("163.143.99.181"),

System.Net.IPAddress.Parse("81.180.72.93"),

System.Net.IPAddress.Parse("204.248.84.133"),

System.Net.IPAddress.Parse("57.206.125.193"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("85.95.87.162"),

System.Net.IPAddress.Parse("150.183.21.184"),

System.Net.IPAddress.Parse("45.83.182.115"),

},
},
            new IPAddressinetArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("126.49.160.36"),

System.Net.IPAddress.Parse("12.216.203.214"),

System.Net.IPAddress.Parse("29.226.21.58"),

System.Net.IPAddress.Parse("211.218.163.67"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("39.141.185.213"),

System.Net.IPAddress.Parse("79.16.6.207"),

System.Net.IPAddress.Parse("194.62.183.110"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("13.122.136.219"),

System.Net.IPAddress.Parse("97.7.52.193"),

System.Net.IPAddress.Parse("212.18.139.143"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("92.61.143.215"),

System.Net.IPAddress.Parse("135.196.93.126"),

System.Net.IPAddress.Parse("15.49.121.111"),

},
},
            new IPAddressinetArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("171.81.43.221"),

System.Net.IPAddress.Parse("155.29.38.217"),

System.Net.IPAddress.Parse("148.140.234.30"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("98.78.219.210"),

System.Net.IPAddress.Parse("169.161.3.54"),

System.Net.IPAddress.Parse("79.200.203.253"),

},
},
            new IPAddressinetArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("13.118.87.86"),

System.Net.IPAddress.Parse("68.43.186.21"),

System.Net.IPAddress.Parse("27.106.225.86"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("202.40.45.36"),

System.Net.IPAddress.Parse("141.19.41.234"),

System.Net.IPAddress.Parse("151.69.225.61"),

System.Net.IPAddress.Parse("153.91.159.166"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("107.79.171.232"),

System.Net.IPAddress.Parse("180.239.202.182"),

System.Net.IPAddress.Parse("201.229.95.36"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("95.58.38.207"),

System.Net.IPAddress.Parse("229.221.132.214"),

System.Net.IPAddress.Parse("70.215.130.103"),

},
},
            new IPAddressinetArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("111.5.55.158"),

System.Net.IPAddress.Parse("139.96.193.210"),

System.Net.IPAddress.Parse("118.101.140.248"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("80.51.43.10"),

System.Net.IPAddress.Parse("117.252.81.158"),

System.Net.IPAddress.Parse("191.179.235.33"),

System.Net.IPAddress.Parse("61.60.123.235"),

},
},
            new IPAddressinetArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("247.90.100.173"),

System.Net.IPAddress.Parse("183.26.134.195"),

System.Net.IPAddress.Parse("143.217.242.94"),

System.Net.IPAddress.Parse("4.89.226.241"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("217.196.8.60"),

System.Net.IPAddress.Parse("231.196.40.145"),

System.Net.IPAddress.Parse("136.84.15.2"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("37.4.91.145"),

System.Net.IPAddress.Parse("250.108.125.240"),

System.Net.IPAddress.Parse("6.182.207.57"),

System.Net.IPAddress.Parse("221.194.22.186"),

},
},
            new IPAddressinetArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("226.169.146.38"),

System.Net.IPAddress.Parse("247.73.199.252"),

System.Net.IPAddress.Parse("64.124.95.220"),

System.Net.IPAddress.Parse("74.162.132.0"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("165.25.141.180"),

System.Net.IPAddress.Parse("202.242.32.7"),

System.Net.IPAddress.Parse("237.135.194.160"),

System.Net.IPAddress.Parse("117.155.37.23"),

},
},
            new IPAddressinetArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("203.219.94.6"),

System.Net.IPAddress.Parse("161.5.54.185"),

System.Net.IPAddress.Parse("181.211.115.10"),

System.Net.IPAddress.Parse("70.60.240.121"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("23.162.235.17"),

System.Net.IPAddress.Parse("227.19.226.172"),

System.Net.IPAddress.Parse("223.159.57.4"),

System.Net.IPAddress.Parse("161.112.59.8"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("106.126.194.17"),

System.Net.IPAddress.Parse("193.18.9.159"),

System.Net.IPAddress.Parse("198.94.149.74"),

System.Net.IPAddress.Parse("103.142.129.166"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("187.207.193.126"),

System.Net.IPAddress.Parse("108.32.76.19"),

System.Net.IPAddress.Parse("154.135.81.242"),

System.Net.IPAddress.Parse("234.18.166.144"),

},
},
            new IPAddressinetArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("96.66.156.219"),

System.Net.IPAddress.Parse("179.21.61.23"),

System.Net.IPAddress.Parse("193.130.170.243"),

System.Net.IPAddress.Parse("31.232.28.20"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("112.65.6.202"),

System.Net.IPAddress.Parse("173.128.44.84"),

System.Net.IPAddress.Parse("237.158.110.165"),

System.Net.IPAddress.Parse("21.218.117.47"),

},
},
            new IPAddressinetArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("190.81.186.51"),

System.Net.IPAddress.Parse("101.36.100.222"),

System.Net.IPAddress.Parse("56.26.168.16"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("107.11.49.112"),

System.Net.IPAddress.Parse("81.7.148.225"),

System.Net.IPAddress.Parse("28.153.48.238"),

System.Net.IPAddress.Parse("103.42.52.170"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("194.56.249.178"),

System.Net.IPAddress.Parse("177.0.234.116"),

System.Net.IPAddress.Parse("109.243.96.100"),

},
},
            new IPAddressinetArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("216.19.172.254"),

System.Net.IPAddress.Parse("250.14.1.13"),

System.Net.IPAddress.Parse("113.165.45.22"),

System.Net.IPAddress.Parse("248.126.110.213"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("47.108.235.232"),

System.Net.IPAddress.Parse("144.199.249.154"),

System.Net.IPAddress.Parse("253.135.71.212"),

},
},
            new IPAddressinetArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("245.62.146.195"),

System.Net.IPAddress.Parse("188.128.247.63"),

System.Net.IPAddress.Parse("212.98.176.175"),

System.Net.IPAddress.Parse("37.172.205.61"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("213.243.219.93"),

System.Net.IPAddress.Parse("166.193.232.73"),

System.Net.IPAddress.Parse("54.14.67.200"),

System.Net.IPAddress.Parse("176.126.21.179"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("63.198.238.88"),

System.Net.IPAddress.Parse("218.40.62.138"),

System.Net.IPAddress.Parse("5.4.228.213"),

},
},
            new IPAddressinetArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("63.191.170.71"),

System.Net.IPAddress.Parse("107.71.64.103"),

System.Net.IPAddress.Parse("199.66.178.243"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("47.211.143.226"),

System.Net.IPAddress.Parse("86.115.237.243"),

System.Net.IPAddress.Parse("92.158.219.250"),

System.Net.IPAddress.Parse("252.206.7.21"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("33.159.11.235"),

System.Net.IPAddress.Parse("170.231.48.205"),

System.Net.IPAddress.Parse("26.236.1.155"),

System.Net.IPAddress.Parse("162.90.57.38"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("230.127.205.248"),

System.Net.IPAddress.Parse("142.148.142.159"),

System.Net.IPAddress.Parse("22.23.35.103"),

System.Net.IPAddress.Parse("119.251.139.5"),

},
},
            new IPAddressinetArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("124.25.48.237"),

System.Net.IPAddress.Parse("241.192.8.174"),

System.Net.IPAddress.Parse("96.91.123.55"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("167.216.197.95"),

System.Net.IPAddress.Parse("60.113.140.27"),

System.Net.IPAddress.Parse("63.230.5.199"),

System.Net.IPAddress.Parse("123.25.39.27"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("129.57.193.251"),

System.Net.IPAddress.Parse("174.173.226.5"),

System.Net.IPAddress.Parse("153.99.171.242"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("200.37.97.15"),

System.Net.IPAddress.Parse("97.40.169.240"),

System.Net.IPAddress.Parse("188.211.34.11"),

System.Net.IPAddress.Parse("195.162.251.22"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("253.4.106.72"),

System.Net.IPAddress.Parse("49.202.19.100"),

System.Net.IPAddress.Parse("114.237.247.147"),

},
},
            new IPAddressinetArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("187.209.41.212"),

System.Net.IPAddress.Parse("204.82.147.127"),

System.Net.IPAddress.Parse("49.48.202.13"),

System.Net.IPAddress.Parse("12.29.177.197"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("214.39.60.124"),

System.Net.IPAddress.Parse("218.216.4.17"),

System.Net.IPAddress.Parse("36.119.56.185"),

System.Net.IPAddress.Parse("119.187.153.190"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("57.84.216.189"),

System.Net.IPAddress.Parse("41.169.29.117"),

System.Net.IPAddress.Parse("10.161.21.207"),

System.Net.IPAddress.Parse("161.38.32.58"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("224.208.87.49"),

System.Net.IPAddress.Parse("159.82.191.242"),

System.Net.IPAddress.Parse("186.252.94.125"),

System.Net.IPAddress.Parse("141.138.61.159"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("143.63.166.184"),

System.Net.IPAddress.Parse("102.82.211.8"),

System.Net.IPAddress.Parse("43.228.233.89"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("218.75.215.128"),

System.Net.IPAddress.Parse("122.233.14.132"),

System.Net.IPAddress.Parse("114.4.114.81"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.48.208.7"),

System.Net.IPAddress.Parse("94.243.25.4"),

System.Net.IPAddress.Parse("55.182.83.97"),

System.Net.IPAddress.Parse("136.168.124.63"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("198.13.83.196"),

System.Net.IPAddress.Parse("55.0.236.47"),

System.Net.IPAddress.Parse("251.166.74.185"),

},
},
            new IPAddressinetArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.121.159.64"),

System.Net.IPAddress.Parse("169.23.124.149"),

System.Net.IPAddress.Parse("13.102.177.206"),

System.Net.IPAddress.Parse("168.135.51.184"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("191.0.175.7"),

System.Net.IPAddress.Parse("202.214.164.204"),

System.Net.IPAddress.Parse("6.0.88.51"),

System.Net.IPAddress.Parse("23.39.127.84"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("42.118.217.200"),

System.Net.IPAddress.Parse("159.162.115.240"),

System.Net.IPAddress.Parse("184.146.201.95"),

System.Net.IPAddress.Parse("233.185.251.248"),

},
},
            new IPAddressinetArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("43.21.187.79"),

System.Net.IPAddress.Parse("100.19.131.94"),

System.Net.IPAddress.Parse("193.39.62.80"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("109.73.67.25"),

System.Net.IPAddress.Parse("70.18.61.234"),

System.Net.IPAddress.Parse("183.117.21.124"),

},
},
            new IPAddressinetArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("77.65.166.38"),

System.Net.IPAddress.Parse("243.153.55.146"),

System.Net.IPAddress.Parse("80.20.136.37"),

System.Net.IPAddress.Parse("32.246.27.14"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("50.206.38.179"),

System.Net.IPAddress.Parse("41.180.204.233"),

System.Net.IPAddress.Parse("19.202.190.193"),

System.Net.IPAddress.Parse("20.222.254.185"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("41.239.126.214"),

System.Net.IPAddress.Parse("63.84.193.143"),

System.Net.IPAddress.Parse("175.245.21.67"),

},
},
            new IPAddressinetArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("110.68.201.137"),

System.Net.IPAddress.Parse("243.123.173.152"),

System.Net.IPAddress.Parse("148.39.94.96"),

System.Net.IPAddress.Parse("150.77.75.232"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("53.39.110.52"),

System.Net.IPAddress.Parse("43.196.178.83"),

System.Net.IPAddress.Parse("123.98.48.238"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("189.49.225.142"),

System.Net.IPAddress.Parse("183.25.54.74"),

System.Net.IPAddress.Parse("42.65.144.97"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("243.143.199.24"),

System.Net.IPAddress.Parse("145.222.226.186"),

System.Net.IPAddress.Parse("22.13.28.205"),

System.Net.IPAddress.Parse("217.230.160.119"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("42.122.113.135"),

System.Net.IPAddress.Parse("157.119.233.120"),

System.Net.IPAddress.Parse("154.188.220.125"),

System.Net.IPAddress.Parse("207.198.47.229"),

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
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
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

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatIPAddressinetArray2M.AssertModel(models[0],_testData[1], false);FlatIPAddressinetArray2M.AssertModel(models[1],_testData[2], false);FlatIPAddressinetArray2M.AssertModel(models[2],_testData[3], false);FlatIPAddressinetArray2M.AssertModel(models[3],_testData[4], false);FlatIPAddressinetArray2M.AssertModel(models[4],_testData[5], false);FlatIPAddressinetArray2M.AssertModel(models[5],_testData[6], false);FlatIPAddressinetArray2M.AssertModel(models[6],_testData[7], false);FlatIPAddressinetArray2M.AssertModel(models[7],_testData[8], false);FlatIPAddressinetArray2M.AssertModel(models[8],_testData[9], false);FlatIPAddressinetArray2M.AssertModel(models[9],_testData[10], false);FlatIPAddressinetArray2M.AssertModel(models[10],_testData[11], false);FlatIPAddressinetArray2M.AssertModel(models[11],_testData[12], false);FlatIPAddressinetArray2M.AssertModel(models[12],_testData[13], false);FlatIPAddressinetArray2M.AssertModel(models[13],_testData[14], false);FlatIPAddressinetArray2M.AssertModel(models[14],_testData[15], false);FlatIPAddressinetArray2M.AssertModel(models[15],_testData[16], false);FlatIPAddressinetArray2M.AssertModel(models[16],_testData[17], false);FlatIPAddressinetArray2M.AssertModel(models[17],_testData[18], false);FlatIPAddressinetArray2M.AssertModel(models[18],_testData[19], false);FlatIPAddressinetArray2M.AssertModel(models[19],_testData[20], false);FlatIPAddressinetArray2M.AssertModel(models[20],_testData[21], false);FlatIPAddressinetArray2M.AssertModel(models[21],_testData[22], false);FlatIPAddressinetArray2M.AssertModel(models[22],_testData[23], false);FlatIPAddressinetArray2M.AssertModel(models[23],_testData[24], false);FlatIPAddressinetArray2M.AssertModel(models[24],_testData[25], false);FlatIPAddressinetArray2M.AssertModel(models[25],_testData[26], false);FlatIPAddressinetArray2M.AssertModel(models[26],_testData[27], false);FlatIPAddressinetArray2M.AssertModel(models[27],_testData[28], false);FlatIPAddressinetArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatIPAddressinetArray2M.AssertModel(models[0],_testData[6], false);FlatIPAddressinetArray2M.AssertModel(models[1],_testData[7], false);FlatIPAddressinetArray2M.AssertModel(models[2],_testData[8], false);FlatIPAddressinetArray2M.AssertModel(models[3],_testData[9], false);FlatIPAddressinetArray2M.AssertModel(models[4],_testData[10], false);FlatIPAddressinetArray2M.AssertModel(models[5],_testData[11], false);FlatIPAddressinetArray2M.AssertModel(models[6],_testData[12], false);FlatIPAddressinetArray2M.AssertModel(models[7],_testData[13], false);FlatIPAddressinetArray2M.AssertModel(models[8],_testData[14], false);FlatIPAddressinetArray2M.AssertModel(models[9],_testData[15], false);FlatIPAddressinetArray2M.AssertModel(models[10],_testData[16], false);FlatIPAddressinetArray2M.AssertModel(models[11],_testData[17], false);FlatIPAddressinetArray2M.AssertModel(models[12],_testData[18], false);FlatIPAddressinetArray2M.AssertModel(models[13],_testData[19], false);FlatIPAddressinetArray2M.AssertModel(models[14],_testData[20], false);FlatIPAddressinetArray2M.AssertModel(models[15],_testData[21], false);FlatIPAddressinetArray2M.AssertModel(models[16],_testData[22], false);FlatIPAddressinetArray2M.AssertModel(models[17],_testData[23], false);FlatIPAddressinetArray2M.AssertModel(models[18],_testData[24], false);FlatIPAddressinetArray2M.AssertModel(models[19],_testData[25], false);FlatIPAddressinetArray2M.AssertModel(models[20],_testData[26], false);FlatIPAddressinetArray2M.AssertModel(models[21],_testData[27], false);FlatIPAddressinetArray2M.AssertModel(models[22],_testData[28], false);FlatIPAddressinetArray2M.AssertModel(models[23],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatIPAddressinetArray2M.AssertModel(models[0],_testData[20], false);FlatIPAddressinetArray2M.AssertModel(models[1],_testData[21], false);FlatIPAddressinetArray2M.AssertModel(models[2],_testData[22], false);FlatIPAddressinetArray2M.AssertModel(models[3],_testData[23], false);FlatIPAddressinetArray2M.AssertModel(models[4],_testData[24], false);FlatIPAddressinetArray2M.AssertModel(models[5],_testData[25], false);FlatIPAddressinetArray2M.AssertModel(models[6],_testData[26], false);FlatIPAddressinetArray2M.AssertModel(models[7],_testData[27], false);FlatIPAddressinetArray2M.AssertModel(models[8],_testData[28], false);FlatIPAddressinetArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatIPAddressinetArray2M.AssertModel(models[0],_testData[3], false);FlatIPAddressinetArray2M.AssertModel(models[1],_testData[4], false);FlatIPAddressinetArray2M.AssertModel(models[2],_testData[5], false);FlatIPAddressinetArray2M.AssertModel(models[3],_testData[6], false);FlatIPAddressinetArray2M.AssertModel(models[4],_testData[7], false);FlatIPAddressinetArray2M.AssertModel(models[5],_testData[8], false);FlatIPAddressinetArray2M.AssertModel(models[6],_testData[9], false);FlatIPAddressinetArray2M.AssertModel(models[7],_testData[10], false);FlatIPAddressinetArray2M.AssertModel(models[8],_testData[11], false);FlatIPAddressinetArray2M.AssertModel(models[9],_testData[12], false);FlatIPAddressinetArray2M.AssertModel(models[10],_testData[13], false);FlatIPAddressinetArray2M.AssertModel(models[11],_testData[14], false);FlatIPAddressinetArray2M.AssertModel(models[12],_testData[15], false);FlatIPAddressinetArray2M.AssertModel(models[13],_testData[16], false);FlatIPAddressinetArray2M.AssertModel(models[14],_testData[17], false);FlatIPAddressinetArray2M.AssertModel(models[15],_testData[18], false);FlatIPAddressinetArray2M.AssertModel(models[16],_testData[19], false);FlatIPAddressinetArray2M.AssertModel(models[17],_testData[20], false);FlatIPAddressinetArray2M.AssertModel(models[18],_testData[21], false);FlatIPAddressinetArray2M.AssertModel(models[19],_testData[22], false);FlatIPAddressinetArray2M.AssertModel(models[20],_testData[23], false);FlatIPAddressinetArray2M.AssertModel(models[21],_testData[24], false);FlatIPAddressinetArray2M.AssertModel(models[22],_testData[25], false);FlatIPAddressinetArray2M.AssertModel(models[23],_testData[26], false);FlatIPAddressinetArray2M.AssertModel(models[24],_testData[27], false);FlatIPAddressinetArray2M.AssertModel(models[25],_testData[28], false);FlatIPAddressinetArray2M.AssertModel(models[26],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
                var models = await((IIPAddressListinetArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    IPAddressinetArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
IPAddressinetArray2M.AssertModel(models[0],_testData[13], false);IPAddressinetArray2M.AssertModel(models[1],_testData[14], false);IPAddressinetArray2M.AssertModel(models[2],_testData[15], false);IPAddressinetArray2M.AssertModel(models[3],_testData[16], false);IPAddressinetArray2M.AssertModel(models[4],_testData[17], false);IPAddressinetArray2M.AssertModel(models[5],_testData[18], false);IPAddressinetArray2M.AssertModel(models[6],_testData[19], false);IPAddressinetArray2M.AssertModel(models[7],_testData[20], false);IPAddressinetArray2M.AssertModel(models[8],_testData[21], false);IPAddressinetArray2M.AssertModel(models[9],_testData[22], false);IPAddressinetArray2M.AssertModel(models[10],_testData[23], false);IPAddressinetArray2M.AssertModel(models[11],_testData[24], false);IPAddressinetArray2M.AssertModel(models[12],_testData[25], false);IPAddressinetArray2M.AssertModel(models[13],_testData[26], false);IPAddressinetArray2M.AssertModel(models[14],_testData[27], false);IPAddressinetArray2M.AssertModel(models[15],_testData[28], false);IPAddressinetArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
IPAddressinetArray2M.AssertModel(models[0],_testData[6], false);IPAddressinetArray2M.AssertModel(models[1],_testData[7], false);IPAddressinetArray2M.AssertModel(models[2],_testData[8], false);IPAddressinetArray2M.AssertModel(models[3],_testData[9], false);IPAddressinetArray2M.AssertModel(models[4],_testData[10], false);IPAddressinetArray2M.AssertModel(models[5],_testData[11], false);IPAddressinetArray2M.AssertModel(models[6],_testData[12], false);IPAddressinetArray2M.AssertModel(models[7],_testData[13], false);IPAddressinetArray2M.AssertModel(models[8],_testData[14], false);IPAddressinetArray2M.AssertModel(models[9],_testData[15], false);IPAddressinetArray2M.AssertModel(models[10],_testData[16], false);IPAddressinetArray2M.AssertModel(models[11],_testData[17], false);IPAddressinetArray2M.AssertModel(models[12],_testData[18], false);IPAddressinetArray2M.AssertModel(models[13],_testData[19], false);IPAddressinetArray2M.AssertModel(models[14],_testData[20], false);IPAddressinetArray2M.AssertModel(models[15],_testData[21], false);IPAddressinetArray2M.AssertModel(models[16],_testData[22], false);IPAddressinetArray2M.AssertModel(models[17],_testData[23], false);IPAddressinetArray2M.AssertModel(models[18],_testData[24], false);IPAddressinetArray2M.AssertModel(models[19],_testData[25], false);IPAddressinetArray2M.AssertModel(models[20],_testData[26], false);IPAddressinetArray2M.AssertModel(models[21],_testData[27], false);IPAddressinetArray2M.AssertModel(models[22],_testData[28], false);IPAddressinetArray2M.AssertModel(models[23],_testData[29], false);
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
        public async Task DbConnectionSelectModelDynParBatchTest()
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
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
IPAddressinetArray2M.AssertModel(models[0],_testData[4], false);IPAddressinetArray2M.AssertModel(models[1],_testData[5], false);IPAddressinetArray2M.AssertModel(models[2],_testData[6], false);IPAddressinetArray2M.AssertModel(models[3],_testData[7], false);IPAddressinetArray2M.AssertModel(models[4],_testData[8], false);IPAddressinetArray2M.AssertModel(models[5],_testData[9], false);IPAddressinetArray2M.AssertModel(models[6],_testData[10], false);IPAddressinetArray2M.AssertModel(models[7],_testData[11], false);IPAddressinetArray2M.AssertModel(models[8],_testData[12], false);IPAddressinetArray2M.AssertModel(models[9],_testData[13], false);IPAddressinetArray2M.AssertModel(models[10],_testData[14], false);IPAddressinetArray2M.AssertModel(models[11],_testData[15], false);IPAddressinetArray2M.AssertModel(models[12],_testData[16], false);IPAddressinetArray2M.AssertModel(models[13],_testData[17], false);IPAddressinetArray2M.AssertModel(models[14],_testData[18], false);IPAddressinetArray2M.AssertModel(models[15],_testData[19], false);IPAddressinetArray2M.AssertModel(models[16],_testData[20], false);IPAddressinetArray2M.AssertModel(models[17],_testData[21], false);IPAddressinetArray2M.AssertModel(models[18],_testData[22], false);IPAddressinetArray2M.AssertModel(models[19],_testData[23], false);IPAddressinetArray2M.AssertModel(models[20],_testData[24], false);IPAddressinetArray2M.AssertModel(models[21],_testData[25], false);IPAddressinetArray2M.AssertModel(models[22],_testData[26], false);IPAddressinetArray2M.AssertModel(models[23],_testData[27], false);IPAddressinetArray2M.AssertModel(models[24],_testData[28], false);IPAddressinetArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
IPAddressinetArray2M.AssertModel(models[0],_testData[17], false);IPAddressinetArray2M.AssertModel(models[1],_testData[18], false);IPAddressinetArray2M.AssertModel(models[2],_testData[19], false);IPAddressinetArray2M.AssertModel(models[3],_testData[20], false);IPAddressinetArray2M.AssertModel(models[4],_testData[21], false);IPAddressinetArray2M.AssertModel(models[5],_testData[22], false);IPAddressinetArray2M.AssertModel(models[6],_testData[23], false);IPAddressinetArray2M.AssertModel(models[7],_testData[24], false);IPAddressinetArray2M.AssertModel(models[8],_testData[25], false);IPAddressinetArray2M.AssertModel(models[9],_testData[26], false);IPAddressinetArray2M.AssertModel(models[10],_testData[27], false);IPAddressinetArray2M.AssertModel(models[11],_testData[28], false);IPAddressinetArray2M.AssertModel(models[12],_testData[29], false);
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

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 51, query1, 137, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatIPAddressinetArray2M.AssertModel(models[0],_testData[8], false);FlatIPAddressinetArray2M.AssertModel(models[1],_testData[9], false);FlatIPAddressinetArray2M.AssertModel(models[2],_testData[10], false);FlatIPAddressinetArray2M.AssertModel(models[3],_testData[11], false);FlatIPAddressinetArray2M.AssertModel(models[4],_testData[12], false);FlatIPAddressinetArray2M.AssertModel(models[5],_testData[13], false);FlatIPAddressinetArray2M.AssertModel(models[6],_testData[14], false);FlatIPAddressinetArray2M.AssertModel(models[7],_testData[15], false);FlatIPAddressinetArray2M.AssertModel(models[8],_testData[16], false);FlatIPAddressinetArray2M.AssertModel(models[9],_testData[17], false);FlatIPAddressinetArray2M.AssertModel(models[10],_testData[18], false);FlatIPAddressinetArray2M.AssertModel(models[11],_testData[19], false);FlatIPAddressinetArray2M.AssertModel(models[12],_testData[20], false);FlatIPAddressinetArray2M.AssertModel(models[13],_testData[21], false);FlatIPAddressinetArray2M.AssertModel(models[14],_testData[22], false);FlatIPAddressinetArray2M.AssertModel(models[15],_testData[23], false);FlatIPAddressinetArray2M.AssertModel(models[16],_testData[24], false);FlatIPAddressinetArray2M.AssertModel(models[17],_testData[25], false);FlatIPAddressinetArray2M.AssertModel(models[18],_testData[26], false);FlatIPAddressinetArray2M.AssertModel(models[19],_testData[27], false);FlatIPAddressinetArray2M.AssertModel(models[20],_testData[28], false);FlatIPAddressinetArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatIPAddressinetArray2M.AssertModel(models[0],_testData[24], false);FlatIPAddressinetArray2M.AssertModel(models[1],_testData[25], false);FlatIPAddressinetArray2M.AssertModel(models[2],_testData[26], false);FlatIPAddressinetArray2M.AssertModel(models[3],_testData[27], false);FlatIPAddressinetArray2M.AssertModel(models[4],_testData[28], false);FlatIPAddressinetArray2M.AssertModel(models[5],_testData[29], false);
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
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 146, query1, 28, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatIPAddressinetArray2M.AssertModel(models[0],_testData[26], false);FlatIPAddressinetArray2M.AssertModel(models[1],_testData[27], false);FlatIPAddressinetArray2M.AssertModel(models[2],_testData[28], false);FlatIPAddressinetArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatIPAddressinetArray2M.AssertModel(models[0],_testData[5], false);FlatIPAddressinetArray2M.AssertModel(models[1],_testData[6], false);FlatIPAddressinetArray2M.AssertModel(models[2],_testData[7], false);FlatIPAddressinetArray2M.AssertModel(models[3],_testData[8], false);FlatIPAddressinetArray2M.AssertModel(models[4],_testData[9], false);FlatIPAddressinetArray2M.AssertModel(models[5],_testData[10], false);FlatIPAddressinetArray2M.AssertModel(models[6],_testData[11], false);FlatIPAddressinetArray2M.AssertModel(models[7],_testData[12], false);FlatIPAddressinetArray2M.AssertModel(models[8],_testData[13], false);FlatIPAddressinetArray2M.AssertModel(models[9],_testData[14], false);FlatIPAddressinetArray2M.AssertModel(models[10],_testData[15], false);FlatIPAddressinetArray2M.AssertModel(models[11],_testData[16], false);FlatIPAddressinetArray2M.AssertModel(models[12],_testData[17], false);FlatIPAddressinetArray2M.AssertModel(models[13],_testData[18], false);FlatIPAddressinetArray2M.AssertModel(models[14],_testData[19], false);FlatIPAddressinetArray2M.AssertModel(models[15],_testData[20], false);FlatIPAddressinetArray2M.AssertModel(models[16],_testData[21], false);FlatIPAddressinetArray2M.AssertModel(models[17],_testData[22], false);FlatIPAddressinetArray2M.AssertModel(models[18],_testData[23], false);FlatIPAddressinetArray2M.AssertModel(models[19],_testData[24], false);FlatIPAddressinetArray2M.AssertModel(models[20],_testData[25], false);FlatIPAddressinetArray2M.AssertModel(models[21],_testData[26], false);FlatIPAddressinetArray2M.AssertModel(models[22],_testData[27], false);FlatIPAddressinetArray2M.AssertModel(models[23],_testData[28], false);FlatIPAddressinetArray2M.AssertModel(models[24],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
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
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSelectModelBatchAsync(connection, 160, 88))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
IPAddressinetArray2M.AssertModel(models[0],_testData[28], false);IPAddressinetArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
IPAddressinetArray2M.AssertModel(models[0],_testData[15], false);IPAddressinetArray2M.AssertModel(models[1],_testData[16], false);IPAddressinetArray2M.AssertModel(models[2],_testData[17], false);IPAddressinetArray2M.AssertModel(models[3],_testData[18], false);IPAddressinetArray2M.AssertModel(models[4],_testData[19], false);IPAddressinetArray2M.AssertModel(models[5],_testData[20], false);IPAddressinetArray2M.AssertModel(models[6],_testData[21], false);IPAddressinetArray2M.AssertModel(models[7],_testData[22], false);IPAddressinetArray2M.AssertModel(models[8],_testData[23], false);IPAddressinetArray2M.AssertModel(models[9],_testData[24], false);IPAddressinetArray2M.AssertModel(models[10],_testData[25], false);IPAddressinetArray2M.AssertModel(models[11],_testData[26], false);IPAddressinetArray2M.AssertModel(models[12],_testData[27], false);IPAddressinetArray2M.AssertModel(models[13],_testData[28], false);IPAddressinetArray2M.AssertModel(models[14],_testData[29], false);
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
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSelectModelBatch(connection, 128, 160))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
IPAddressinetArray2M.AssertModel(models[0],_testData[22], false);IPAddressinetArray2M.AssertModel(models[1],_testData[23], false);IPAddressinetArray2M.AssertModel(models[2],_testData[24], false);IPAddressinetArray2M.AssertModel(models[3],_testData[25], false);IPAddressinetArray2M.AssertModel(models[4],_testData[26], false);IPAddressinetArray2M.AssertModel(models[5],_testData[27], false);IPAddressinetArray2M.AssertModel(models[6],_testData[28], false);IPAddressinetArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
IPAddressinetArray2M.AssertModel(models[0],_testData[28], false);IPAddressinetArray2M.AssertModel(models[1],_testData[29], false);
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
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 12);
                var models = await ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
IPAddressinetArray2M.AssertModel(models[0],_testData[3], false);IPAddressinetArray2M.AssertModel(models[1],_testData[4], false);IPAddressinetArray2M.AssertModel(models[2],_testData[5], false);IPAddressinetArray2M.AssertModel(models[3],_testData[6], false);IPAddressinetArray2M.AssertModel(models[4],_testData[7], false);IPAddressinetArray2M.AssertModel(models[5],_testData[8], false);IPAddressinetArray2M.AssertModel(models[6],_testData[9], false);IPAddressinetArray2M.AssertModel(models[7],_testData[10], false);IPAddressinetArray2M.AssertModel(models[8],_testData[11], false);IPAddressinetArray2M.AssertModel(models[9],_testData[12], false);IPAddressinetArray2M.AssertModel(models[10],_testData[13], false);IPAddressinetArray2M.AssertModel(models[11],_testData[14], false);IPAddressinetArray2M.AssertModel(models[12],_testData[15], false);IPAddressinetArray2M.AssertModel(models[13],_testData[16], false);IPAddressinetArray2M.AssertModel(models[14],_testData[17], false);IPAddressinetArray2M.AssertModel(models[15],_testData[18], false);IPAddressinetArray2M.AssertModel(models[16],_testData[19], false);IPAddressinetArray2M.AssertModel(models[17],_testData[20], false);IPAddressinetArray2M.AssertModel(models[18],_testData[21], false);IPAddressinetArray2M.AssertModel(models[19],_testData[22], false);IPAddressinetArray2M.AssertModel(models[20],_testData[23], false);IPAddressinetArray2M.AssertModel(models[21],_testData[24], false);IPAddressinetArray2M.AssertModel(models[22],_testData[25], false);IPAddressinetArray2M.AssertModel(models[23],_testData[26], false);IPAddressinetArray2M.AssertModel(models[24],_testData[27], false);IPAddressinetArray2M.AssertModel(models[25],_testData[28], false);IPAddressinetArray2M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressListinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 28);
                var models =  ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
IPAddressinetArray2M.AssertModel(models[0],_testData[5], false);IPAddressinetArray2M.AssertModel(models[1],_testData[6], false);IPAddressinetArray2M.AssertModel(models[2],_testData[7], false);IPAddressinetArray2M.AssertModel(models[3],_testData[8], false);IPAddressinetArray2M.AssertModel(models[4],_testData[9], false);IPAddressinetArray2M.AssertModel(models[5],_testData[10], false);IPAddressinetArray2M.AssertModel(models[6],_testData[11], false);IPAddressinetArray2M.AssertModel(models[7],_testData[12], false);IPAddressinetArray2M.AssertModel(models[8],_testData[13], false);IPAddressinetArray2M.AssertModel(models[9],_testData[14], false);IPAddressinetArray2M.AssertModel(models[10],_testData[15], false);IPAddressinetArray2M.AssertModel(models[11],_testData[16], false);IPAddressinetArray2M.AssertModel(models[12],_testData[17], false);IPAddressinetArray2M.AssertModel(models[13],_testData[18], false);IPAddressinetArray2M.AssertModel(models[14],_testData[19], false);IPAddressinetArray2M.AssertModel(models[15],_testData[20], false);IPAddressinetArray2M.AssertModel(models[16],_testData[21], false);IPAddressinetArray2M.AssertModel(models[17],_testData[22], false);IPAddressinetArray2M.AssertModel(models[18],_testData[23], false);IPAddressinetArray2M.AssertModel(models[19],_testData[24], false);IPAddressinetArray2M.AssertModel(models[20],_testData[25], false);IPAddressinetArray2M.AssertModel(models[21],_testData[26], false);IPAddressinetArray2M.AssertModel(models[22],_testData[27], false);IPAddressinetArray2M.AssertModel(models[23],_testData[28], false);IPAddressinetArray2M.AssertModel(models[24],_testData[29], false);
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

