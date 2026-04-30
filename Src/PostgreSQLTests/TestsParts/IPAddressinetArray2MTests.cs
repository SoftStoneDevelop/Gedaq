

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
System.Net.IPAddress.Parse("223.103.95.168"),

System.Net.IPAddress.Parse("96.123.167.73"),

System.Net.IPAddress.Parse("38.251.181.209"),

System.Net.IPAddress.Parse("237.191.148.41"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("33.120.247.121"),

System.Net.IPAddress.Parse("173.80.114.227"),

System.Net.IPAddress.Parse("223.63.79.168"),

System.Net.IPAddress.Parse("60.120.61.224"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("105.234.56.141"),

System.Net.IPAddress.Parse("14.70.74.112"),

System.Net.IPAddress.Parse("141.69.208.199"),

System.Net.IPAddress.Parse("164.40.224.180"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("32.49.202.230"),

System.Net.IPAddress.Parse("139.92.6.173"),

System.Net.IPAddress.Parse("178.30.87.253"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("253.142.58.93"),

System.Net.IPAddress.Parse("151.231.159.26"),

System.Net.IPAddress.Parse("4.85.47.4"),

},
},
            new IPAddressinetArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("148.120.183.254"),

System.Net.IPAddress.Parse("198.150.218.96"),

System.Net.IPAddress.Parse("44.169.110.72"),

System.Net.IPAddress.Parse("131.89.93.122"),

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
System.Net.IPAddress.Parse("111.206.69.16"),

System.Net.IPAddress.Parse("225.98.115.140"),

System.Net.IPAddress.Parse("207.198.20.247"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("42.119.128.71"),

System.Net.IPAddress.Parse("218.110.251.234"),

System.Net.IPAddress.Parse("186.215.85.58"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("199.48.55.141"),

System.Net.IPAddress.Parse("117.115.53.237"),

System.Net.IPAddress.Parse("247.195.146.65"),

System.Net.IPAddress.Parse("137.55.141.134"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("198.82.183.71"),

System.Net.IPAddress.Parse("204.202.197.79"),

System.Net.IPAddress.Parse("11.0.195.232"),

System.Net.IPAddress.Parse("57.105.35.232"),

},
},
            new IPAddressinetArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("144.80.70.50"),

System.Net.IPAddress.Parse("44.72.209.59"),

System.Net.IPAddress.Parse("37.215.236.164"),

System.Net.IPAddress.Parse("27.221.141.166"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("223.50.33.147"),

System.Net.IPAddress.Parse("108.19.133.193"),

System.Net.IPAddress.Parse("27.190.112.40"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("32.179.224.228"),

System.Net.IPAddress.Parse("241.118.13.54"),

System.Net.IPAddress.Parse("91.130.128.136"),

System.Net.IPAddress.Parse("144.57.119.220"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("201.147.58.128"),

System.Net.IPAddress.Parse("108.101.143.245"),

System.Net.IPAddress.Parse("181.219.78.19"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("130.123.213.53"),

System.Net.IPAddress.Parse("215.213.109.166"),

System.Net.IPAddress.Parse("140.53.46.32"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("66.138.220.163"),

System.Net.IPAddress.Parse("204.147.173.19"),

System.Net.IPAddress.Parse("139.157.66.96"),

System.Net.IPAddress.Parse("133.253.169.166"),

},
},
            new IPAddressinetArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("100.170.17.188"),

System.Net.IPAddress.Parse("46.252.203.47"),

System.Net.IPAddress.Parse("144.207.94.225"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("198.85.0.49"),

System.Net.IPAddress.Parse("101.118.19.215"),

System.Net.IPAddress.Parse("48.91.167.106"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("134.175.215.67"),

System.Net.IPAddress.Parse("88.24.92.234"),

System.Net.IPAddress.Parse("154.18.233.197"),

System.Net.IPAddress.Parse("137.68.103.79"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("85.31.120.110"),

System.Net.IPAddress.Parse("144.191.4.89"),

System.Net.IPAddress.Parse("152.206.197.12"),

System.Net.IPAddress.Parse("106.173.152.157"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("45.12.232.45"),

System.Net.IPAddress.Parse("252.8.165.91"),

System.Net.IPAddress.Parse("160.227.46.144"),

System.Net.IPAddress.Parse("175.251.139.237"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("130.191.181.90"),

System.Net.IPAddress.Parse("197.239.114.166"),

System.Net.IPAddress.Parse("34.128.1.179"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("94.152.182.9"),

System.Net.IPAddress.Parse("197.118.215.91"),

System.Net.IPAddress.Parse("148.179.159.110"),

},
},
            new IPAddressinetArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("147.224.92.3"),

System.Net.IPAddress.Parse("169.40.247.68"),

System.Net.IPAddress.Parse("173.218.250.58"),

System.Net.IPAddress.Parse("181.166.49.208"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("23.249.195.15"),

System.Net.IPAddress.Parse("162.98.92.122"),

System.Net.IPAddress.Parse("54.149.211.78"),

System.Net.IPAddress.Parse("74.208.193.8"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("122.81.162.146"),

System.Net.IPAddress.Parse("2.142.130.249"),

System.Net.IPAddress.Parse("238.55.88.144"),

System.Net.IPAddress.Parse("153.187.26.83"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("202.5.182.39"),

System.Net.IPAddress.Parse("206.85.235.44"),

System.Net.IPAddress.Parse("21.101.179.153"),

System.Net.IPAddress.Parse("173.191.55.183"),

},
},
            new IPAddressinetArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("62.16.66.103"),

System.Net.IPAddress.Parse("178.130.94.96"),

System.Net.IPAddress.Parse("183.30.250.231"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("126.158.70.173"),

System.Net.IPAddress.Parse("52.212.12.21"),

System.Net.IPAddress.Parse("56.60.43.200"),

System.Net.IPAddress.Parse("69.154.164.139"),

},
},
            new IPAddressinetArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("44.28.192.219"),

System.Net.IPAddress.Parse("72.208.141.110"),

System.Net.IPAddress.Parse("13.49.168.39"),

System.Net.IPAddress.Parse("76.31.38.210"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("160.77.128.123"),

System.Net.IPAddress.Parse("241.9.192.99"),

System.Net.IPAddress.Parse("241.13.155.32"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("240.64.156.27"),

System.Net.IPAddress.Parse("239.210.61.132"),

System.Net.IPAddress.Parse("117.90.6.75"),

System.Net.IPAddress.Parse("202.91.49.78"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("120.210.250.79"),

System.Net.IPAddress.Parse("175.118.251.251"),

System.Net.IPAddress.Parse("124.55.227.184"),

System.Net.IPAddress.Parse("16.171.143.23"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("195.147.228.99"),

System.Net.IPAddress.Parse("51.139.135.8"),

System.Net.IPAddress.Parse("180.199.40.190"),

System.Net.IPAddress.Parse("240.200.229.227"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("49.130.136.12"),

System.Net.IPAddress.Parse("21.158.201.252"),

System.Net.IPAddress.Parse("94.107.90.134"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("15.174.219.210"),

System.Net.IPAddress.Parse("168.158.196.104"),

System.Net.IPAddress.Parse("217.233.125.110"),

System.Net.IPAddress.Parse("203.192.20.81"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("247.236.65.54"),

System.Net.IPAddress.Parse("94.95.204.68"),

System.Net.IPAddress.Parse("149.97.16.246"),

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
System.Net.IPAddress.Parse("205.244.104.46"),

System.Net.IPAddress.Parse("133.3.11.237"),

System.Net.IPAddress.Parse("226.184.172.62"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("117.229.181.237"),

System.Net.IPAddress.Parse("196.76.110.225"),

System.Net.IPAddress.Parse("88.121.86.245"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("205.222.68.237"),

System.Net.IPAddress.Parse("43.94.124.179"),

System.Net.IPAddress.Parse("169.210.108.225"),

System.Net.IPAddress.Parse("218.161.165.134"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("1.134.26.121"),

System.Net.IPAddress.Parse("200.81.156.216"),

System.Net.IPAddress.Parse("66.74.225.225"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("72.4.143.91"),

System.Net.IPAddress.Parse("113.133.132.63"),

System.Net.IPAddress.Parse("39.59.91.191"),

},
},
            new IPAddressinetArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("5.186.251.141"),

System.Net.IPAddress.Parse("161.216.192.198"),

System.Net.IPAddress.Parse("187.231.247.126"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("55.19.40.82"),

System.Net.IPAddress.Parse("8.127.14.71"),

System.Net.IPAddress.Parse("222.21.82.166"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("72.254.13.177"),

System.Net.IPAddress.Parse("195.158.21.114"),

System.Net.IPAddress.Parse("69.132.149.205"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("93.121.250.183"),

System.Net.IPAddress.Parse("191.33.246.152"),

System.Net.IPAddress.Parse("241.224.121.63"),

},
},
            new IPAddressinetArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("93.2.95.19"),

System.Net.IPAddress.Parse("152.31.80.101"),

System.Net.IPAddress.Parse("53.219.63.12"),

System.Net.IPAddress.Parse("57.88.77.159"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("54.179.245.79"),

System.Net.IPAddress.Parse("146.119.86.177"),

System.Net.IPAddress.Parse("193.191.171.27"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("215.219.246.151"),

System.Net.IPAddress.Parse("68.17.117.220"),

System.Net.IPAddress.Parse("15.170.225.76"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("232.66.245.133"),

System.Net.IPAddress.Parse("55.182.120.229"),

System.Net.IPAddress.Parse("162.126.24.195"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("247.181.4.38"),

System.Net.IPAddress.Parse("245.224.79.163"),

System.Net.IPAddress.Parse("211.178.187.201"),

},
},
            new IPAddressinetArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("27.146.116.211"),

System.Net.IPAddress.Parse("239.139.187.197"),

System.Net.IPAddress.Parse("100.53.159.33"),

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
System.Net.IPAddress.Parse("38.135.158.12"),

System.Net.IPAddress.Parse("33.200.243.207"),

System.Net.IPAddress.Parse("217.215.83.1"),

System.Net.IPAddress.Parse("33.25.113.219"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("65.229.154.220"),

System.Net.IPAddress.Parse("63.60.186.102"),

System.Net.IPAddress.Parse("50.145.168.54"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("100.112.51.24"),

System.Net.IPAddress.Parse("2.108.166.113"),

System.Net.IPAddress.Parse("122.167.24.222"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("179.194.155.112"),

System.Net.IPAddress.Parse("200.45.10.125"),

System.Net.IPAddress.Parse("144.109.176.170"),

System.Net.IPAddress.Parse("10.145.107.232"),

},
},
            new IPAddressinetArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("214.198.178.212"),

System.Net.IPAddress.Parse("250.28.37.52"),

System.Net.IPAddress.Parse("48.168.54.143"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("224.41.177.100"),

System.Net.IPAddress.Parse("48.48.141.159"),

System.Net.IPAddress.Parse("246.195.142.125"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("231.5.41.94"),

System.Net.IPAddress.Parse("2.226.160.87"),

System.Net.IPAddress.Parse("74.56.30.124"),

System.Net.IPAddress.Parse("11.239.32.115"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("2.153.232.104"),

System.Net.IPAddress.Parse("229.7.215.138"),

System.Net.IPAddress.Parse("24.181.116.128"),

System.Net.IPAddress.Parse("73.73.225.40"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("179.108.252.34"),

System.Net.IPAddress.Parse("243.207.71.250"),

System.Net.IPAddress.Parse("6.185.185.180"),

System.Net.IPAddress.Parse("58.246.140.120"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("31.214.159.235"),

System.Net.IPAddress.Parse("51.250.57.73"),

System.Net.IPAddress.Parse("121.24.243.184"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("178.39.232.191"),

System.Net.IPAddress.Parse("207.127.142.51"),

System.Net.IPAddress.Parse("11.141.239.193"),

System.Net.IPAddress.Parse("84.3.196.237"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("236.89.225.3"),

System.Net.IPAddress.Parse("46.128.118.6"),

System.Net.IPAddress.Parse("43.239.55.120"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("22.235.181.250"),

System.Net.IPAddress.Parse("172.173.66.185"),

System.Net.IPAddress.Parse("64.140.0.156"),

System.Net.IPAddress.Parse("98.162.135.37"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("201.233.161.14"),

System.Net.IPAddress.Parse("213.237.30.113"),

System.Net.IPAddress.Parse("70.152.58.112"),

System.Net.IPAddress.Parse("142.247.162.174"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("75.16.21.137"),

System.Net.IPAddress.Parse("227.185.134.179"),

System.Net.IPAddress.Parse("148.252.80.144"),

System.Net.IPAddress.Parse("32.174.68.146"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("237.248.107.126"),

System.Net.IPAddress.Parse("140.20.6.25"),

System.Net.IPAddress.Parse("89.86.141.170"),

System.Net.IPAddress.Parse("163.140.233.26"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("72.100.237.9"),

System.Net.IPAddress.Parse("43.4.150.43"),

System.Net.IPAddress.Parse("134.39.34.6"),

System.Net.IPAddress.Parse("236.169.155.246"),

},
},
            new IPAddressinetArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("74.106.61.88"),

System.Net.IPAddress.Parse("105.126.109.200"),

System.Net.IPAddress.Parse("128.11.25.192"),

System.Net.IPAddress.Parse("187.175.135.188"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("175.154.42.110"),

System.Net.IPAddress.Parse("27.96.77.234"),

System.Net.IPAddress.Parse("20.57.146.84"),

System.Net.IPAddress.Parse("231.165.123.29"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.36.177.39"),

System.Net.IPAddress.Parse("205.87.182.252"),

System.Net.IPAddress.Parse("149.75.9.205"),

System.Net.IPAddress.Parse("22.26.88.45"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("180.40.95.201"),

System.Net.IPAddress.Parse("117.123.153.193"),

System.Net.IPAddress.Parse("7.192.37.109"),

System.Net.IPAddress.Parse("88.110.57.159"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("82.21.7.217"),

System.Net.IPAddress.Parse("118.227.238.150"),

System.Net.IPAddress.Parse("5.2.219.24"),

System.Net.IPAddress.Parse("164.25.153.230"),

},
},
            new IPAddressinetArray2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("208.17.82.109"),

System.Net.IPAddress.Parse("232.21.98.213"),

System.Net.IPAddress.Parse("5.200.48.143"),

System.Net.IPAddress.Parse("46.138.8.153"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 184,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("78.106.142.228"),

System.Net.IPAddress.Parse("210.92.182.139"),

System.Net.IPAddress.Parse("86.118.154.107"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("222.140.72.153"),

System.Net.IPAddress.Parse("100.110.164.163"),

System.Net.IPAddress.Parse("237.221.217.149"),

System.Net.IPAddress.Parse("120.55.45.151"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 187,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("163.112.233.35"),

System.Net.IPAddress.Parse("234.122.244.254"),

System.Net.IPAddress.Parse("138.159.10.177"),

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
                parametr1.Value = 140;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[27],_testData[34], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[33],_testData[34], false);
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
                parametr1.Value = 177;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[34], false);
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
                parametr2.Value = 122;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[30],_testData[34], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
                        Assert.That(models, Has.Count.EqualTo(19));

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
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[15],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[16],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[17],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[31],_testData[34], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

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
                        IPAddressinetArray2M.AssertModel(models[16],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[17],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[18],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[19],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[20],_testData[34], false);
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
                await ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 87, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[34], false);
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
                await ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 50, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[34], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 16, query1, 148, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 154, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 20, query1, 154, query2))
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[34], false);
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
                await ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 168, query1, 44, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 20, query1, 50, query2))
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
                 ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 43, query1, 87, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 43, 63))
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
                        Assert.That(models, Has.Count.EqualTo(21));

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
                        IPAddressinetArray2M.AssertModel(models[16],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[17],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[18],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[19],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[20],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatch(connection, 177, 148))
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[29], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[34], false);
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
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 87);
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
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 26);
                var models =  ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(31));
IPAddressinetArray2M.AssertModel(models[0],_testData[4], false);IPAddressinetArray2M.AssertModel(models[1],_testData[5], false);IPAddressinetArray2M.AssertModel(models[2],_testData[6], false);IPAddressinetArray2M.AssertModel(models[3],_testData[7], false);IPAddressinetArray2M.AssertModel(models[4],_testData[8], false);IPAddressinetArray2M.AssertModel(models[5],_testData[9], false);IPAddressinetArray2M.AssertModel(models[6],_testData[10], false);IPAddressinetArray2M.AssertModel(models[7],_testData[11], false);IPAddressinetArray2M.AssertModel(models[8],_testData[12], false);IPAddressinetArray2M.AssertModel(models[9],_testData[13], false);IPAddressinetArray2M.AssertModel(models[10],_testData[14], false);IPAddressinetArray2M.AssertModel(models[11],_testData[15], false);IPAddressinetArray2M.AssertModel(models[12],_testData[16], false);IPAddressinetArray2M.AssertModel(models[13],_testData[17], false);IPAddressinetArray2M.AssertModel(models[14],_testData[18], false);IPAddressinetArray2M.AssertModel(models[15],_testData[19], false);IPAddressinetArray2M.AssertModel(models[16],_testData[20], false);IPAddressinetArray2M.AssertModel(models[17],_testData[21], false);IPAddressinetArray2M.AssertModel(models[18],_testData[22], false);IPAddressinetArray2M.AssertModel(models[19],_testData[23], false);IPAddressinetArray2M.AssertModel(models[20],_testData[24], false);IPAddressinetArray2M.AssertModel(models[21],_testData[25], false);IPAddressinetArray2M.AssertModel(models[22],_testData[26], false);IPAddressinetArray2M.AssertModel(models[23],_testData[27], false);IPAddressinetArray2M.AssertModel(models[24],_testData[28], false);IPAddressinetArray2M.AssertModel(models[25],_testData[29], false);IPAddressinetArray2M.AssertModel(models[26],_testData[30], false);IPAddressinetArray2M.AssertModel(models[27],_testData[31], false);IPAddressinetArray2M.AssertModel(models[28],_testData[32], false);IPAddressinetArray2M.AssertModel(models[29],_testData[33], false);IPAddressinetArray2M.AssertModel(models[30],_testData[34], false);
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
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray2MIWA), typeof(IPAddressinetArray2MIWA)],
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

