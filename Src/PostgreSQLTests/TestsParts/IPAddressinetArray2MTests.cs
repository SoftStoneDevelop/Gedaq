

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
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("22.240.57.93"),

System.Net.IPAddress.Parse("215.86.60.107"),

System.Net.IPAddress.Parse("153.159.129.102"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("65.128.130.60"),

System.Net.IPAddress.Parse("234.161.24.214"),

System.Net.IPAddress.Parse("222.83.47.158"),

},
},
            new IPAddressinetArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("162.199.170.243"),

System.Net.IPAddress.Parse("224.212.127.227"),

System.Net.IPAddress.Parse("249.121.57.165"),

System.Net.IPAddress.Parse("144.208.95.231"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("96.1.19.85"),

System.Net.IPAddress.Parse("150.19.111.218"),

System.Net.IPAddress.Parse("45.227.5.30"),

System.Net.IPAddress.Parse("106.39.25.64"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("100.177.138.109"),

System.Net.IPAddress.Parse("175.161.72.213"),

System.Net.IPAddress.Parse("108.30.77.166"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("59.169.193.34"),

System.Net.IPAddress.Parse("111.128.14.20"),

System.Net.IPAddress.Parse("31.8.124.38"),

System.Net.IPAddress.Parse("60.132.232.112"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("248.28.32.33"),

System.Net.IPAddress.Parse("214.46.130.181"),

System.Net.IPAddress.Parse("185.228.124.195"),

System.Net.IPAddress.Parse("220.137.185.37"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("16.43.186.16"),

System.Net.IPAddress.Parse("164.160.185.41"),

System.Net.IPAddress.Parse("151.82.53.180"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("47.41.89.207"),

System.Net.IPAddress.Parse("121.227.28.5"),

System.Net.IPAddress.Parse("201.225.57.23"),

},
},
            new IPAddressinetArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("142.236.103.185"),

System.Net.IPAddress.Parse("32.217.65.14"),

System.Net.IPAddress.Parse("158.118.112.156"),

System.Net.IPAddress.Parse("3.87.197.108"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("123.13.78.23"),

System.Net.IPAddress.Parse("37.75.68.234"),

System.Net.IPAddress.Parse("57.115.59.47"),

},
},
            new IPAddressinetArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("49.100.85.156"),

System.Net.IPAddress.Parse("238.214.86.249"),

System.Net.IPAddress.Parse("231.60.110.65"),

System.Net.IPAddress.Parse("207.198.209.57"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("245.157.30.112"),

System.Net.IPAddress.Parse("105.50.80.112"),

System.Net.IPAddress.Parse("115.161.176.27"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("120.79.127.46"),

System.Net.IPAddress.Parse("215.31.35.48"),

System.Net.IPAddress.Parse("250.18.98.57"),

System.Net.IPAddress.Parse("144.136.174.137"),

},
},
            new IPAddressinetArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("234.20.185.197"),

System.Net.IPAddress.Parse("17.185.185.94"),

System.Net.IPAddress.Parse("79.215.157.184"),

System.Net.IPAddress.Parse("159.69.24.200"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("239.159.134.48"),

System.Net.IPAddress.Parse("95.119.9.106"),

System.Net.IPAddress.Parse("184.167.42.81"),

},
},
            new IPAddressinetArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("237.168.190.71"),

System.Net.IPAddress.Parse("129.226.62.30"),

System.Net.IPAddress.Parse("131.155.230.196"),

System.Net.IPAddress.Parse("5.175.244.49"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("115.84.164.18"),

System.Net.IPAddress.Parse("212.100.219.13"),

System.Net.IPAddress.Parse("45.81.49.136"),

System.Net.IPAddress.Parse("119.118.122.90"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("231.220.94.178"),

System.Net.IPAddress.Parse("225.154.43.71"),

System.Net.IPAddress.Parse("61.43.44.65"),

System.Net.IPAddress.Parse("16.204.12.125"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("174.183.72.191"),

System.Net.IPAddress.Parse("137.205.225.29"),

System.Net.IPAddress.Parse("219.190.231.119"),

System.Net.IPAddress.Parse("94.56.109.148"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("105.240.198.114"),

System.Net.IPAddress.Parse("145.253.200.150"),

System.Net.IPAddress.Parse("221.28.39.33"),

System.Net.IPAddress.Parse("163.118.251.32"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("29.206.242.76"),

System.Net.IPAddress.Parse("117.87.68.103"),

System.Net.IPAddress.Parse("43.228.56.164"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("152.6.53.149"),

System.Net.IPAddress.Parse("96.149.251.102"),

System.Net.IPAddress.Parse("132.211.69.63"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("63.230.154.9"),

System.Net.IPAddress.Parse("113.21.23.203"),

System.Net.IPAddress.Parse("222.79.253.75"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("202.133.47.98"),

System.Net.IPAddress.Parse("164.224.41.193"),

System.Net.IPAddress.Parse("237.165.94.146"),

System.Net.IPAddress.Parse("138.31.78.146"),

},
},
            new IPAddressinetArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("229.109.161.53"),

System.Net.IPAddress.Parse("78.185.180.123"),

System.Net.IPAddress.Parse("123.254.134.28"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("69.126.173.234"),

System.Net.IPAddress.Parse("182.141.231.45"),

System.Net.IPAddress.Parse("143.72.89.12"),

System.Net.IPAddress.Parse("244.202.25.124"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("237.204.59.70"),

System.Net.IPAddress.Parse("14.194.155.137"),

System.Net.IPAddress.Parse("3.0.108.122"),

System.Net.IPAddress.Parse("109.20.180.247"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("153.59.29.115"),

System.Net.IPAddress.Parse("176.230.132.123"),

System.Net.IPAddress.Parse("228.210.140.115"),

System.Net.IPAddress.Parse("20.119.58.4"),

},
},
            new IPAddressinetArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("226.208.85.146"),

System.Net.IPAddress.Parse("162.135.62.113"),

System.Net.IPAddress.Parse("6.236.73.204"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("219.43.238.232"),

System.Net.IPAddress.Parse("142.167.34.119"),

System.Net.IPAddress.Parse("171.15.134.162"),

System.Net.IPAddress.Parse("121.217.188.113"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("203.11.225.131"),

System.Net.IPAddress.Parse("69.249.214.238"),

System.Net.IPAddress.Parse("145.4.78.154"),

System.Net.IPAddress.Parse("60.148.254.94"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("140.181.37.140"),

System.Net.IPAddress.Parse("158.121.118.103"),

System.Net.IPAddress.Parse("13.125.236.221"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("202.106.116.6"),

System.Net.IPAddress.Parse("83.169.77.229"),

System.Net.IPAddress.Parse("178.13.185.147"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("35.85.65.200"),

System.Net.IPAddress.Parse("248.139.90.131"),

System.Net.IPAddress.Parse("83.98.104.109"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("180.122.137.178"),

System.Net.IPAddress.Parse("79.206.87.22"),

System.Net.IPAddress.Parse("223.84.111.89"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("49.139.162.219"),

System.Net.IPAddress.Parse("210.198.250.78"),

System.Net.IPAddress.Parse("132.38.5.206"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("115.11.136.85"),

System.Net.IPAddress.Parse("163.234.166.242"),

System.Net.IPAddress.Parse("164.56.249.182"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("153.35.241.48"),

System.Net.IPAddress.Parse("132.86.96.95"),

System.Net.IPAddress.Parse("84.240.244.160"),

System.Net.IPAddress.Parse("251.96.135.205"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("174.102.159.230"),

System.Net.IPAddress.Parse("66.208.159.37"),

System.Net.IPAddress.Parse("111.165.184.217"),

},
},
            new IPAddressinetArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("141.238.20.137"),

System.Net.IPAddress.Parse("175.198.25.136"),

System.Net.IPAddress.Parse("112.128.118.85"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("42.174.6.104"),

System.Net.IPAddress.Parse("80.59.43.95"),

System.Net.IPAddress.Parse("186.246.133.194"),

System.Net.IPAddress.Parse("26.129.22.192"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("249.238.14.74"),

System.Net.IPAddress.Parse("175.252.147.22"),

System.Net.IPAddress.Parse("176.236.214.149"),

System.Net.IPAddress.Parse("254.49.105.43"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("98.184.111.235"),

System.Net.IPAddress.Parse("49.165.235.9"),

System.Net.IPAddress.Parse("10.242.53.81"),

System.Net.IPAddress.Parse("85.78.161.81"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("134.227.169.230"),

System.Net.IPAddress.Parse("74.127.177.35"),

System.Net.IPAddress.Parse("15.209.60.169"),

System.Net.IPAddress.Parse("45.86.115.172"),

},
},
            new IPAddressinetArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("245.182.51.234"),

System.Net.IPAddress.Parse("28.164.71.9"),

System.Net.IPAddress.Parse("102.173.143.151"),

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
System.Net.IPAddress.Parse("240.10.49.57"),

System.Net.IPAddress.Parse("175.14.110.226"),

System.Net.IPAddress.Parse("182.119.58.249"),

System.Net.IPAddress.Parse("240.17.212.24"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("226.187.87.180"),

System.Net.IPAddress.Parse("14.186.28.50"),

System.Net.IPAddress.Parse("246.115.178.223"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("171.76.78.26"),

System.Net.IPAddress.Parse("167.65.252.149"),

System.Net.IPAddress.Parse("26.192.107.1"),

System.Net.IPAddress.Parse("195.237.64.78"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("214.134.146.244"),

System.Net.IPAddress.Parse("37.35.81.240"),

System.Net.IPAddress.Parse("246.224.77.19"),

System.Net.IPAddress.Parse("207.200.68.202"),

},
},
            new IPAddressinetArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.118.84.122"),

System.Net.IPAddress.Parse("75.151.118.162"),

System.Net.IPAddress.Parse("178.77.83.185"),

System.Net.IPAddress.Parse("44.108.24.196"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("58.231.171.72"),

System.Net.IPAddress.Parse("12.206.93.115"),

System.Net.IPAddress.Parse("242.15.192.203"),

},
},
            new IPAddressinetArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("59.199.106.62"),

System.Net.IPAddress.Parse("224.136.236.75"),

System.Net.IPAddress.Parse("170.173.221.201"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("86.24.153.149"),

System.Net.IPAddress.Parse("139.142.211.86"),

System.Net.IPAddress.Parse("228.135.198.124"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("130.209.184.218"),

System.Net.IPAddress.Parse("134.56.168.216"),

System.Net.IPAddress.Parse("11.252.25.53"),

System.Net.IPAddress.Parse("45.91.158.90"),

},
},
            new IPAddressinetArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("149.238.170.252"),

System.Net.IPAddress.Parse("63.97.178.51"),

System.Net.IPAddress.Parse("208.206.44.123"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("109.207.236.207"),

System.Net.IPAddress.Parse("206.36.224.16"),

System.Net.IPAddress.Parse("126.218.6.68"),

System.Net.IPAddress.Parse("188.218.19.206"),

},
},
            new IPAddressinetArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("99.24.248.101"),

System.Net.IPAddress.Parse("210.26.194.216"),

System.Net.IPAddress.Parse("29.50.196.17"),

System.Net.IPAddress.Parse("37.86.61.146"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("148.97.21.106"),

System.Net.IPAddress.Parse("238.207.176.50"),

System.Net.IPAddress.Parse("191.93.233.176"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.116.149.79"),

System.Net.IPAddress.Parse("68.219.218.119"),

System.Net.IPAddress.Parse("195.228.135.133"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("49.86.147.60"),

System.Net.IPAddress.Parse("56.94.189.202"),

System.Net.IPAddress.Parse("56.114.37.106"),

},
},
            new IPAddressinetArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("83.3.68.168"),

System.Net.IPAddress.Parse("156.249.115.47"),

System.Net.IPAddress.Parse("113.171.248.18"),

System.Net.IPAddress.Parse("28.107.204.24"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("225.27.168.126"),

System.Net.IPAddress.Parse("142.94.156.126"),

System.Net.IPAddress.Parse("246.200.181.18"),

System.Net.IPAddress.Parse("95.227.139.147"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("209.176.164.2"),

System.Net.IPAddress.Parse("187.53.112.21"),

System.Net.IPAddress.Parse("22.29.11.198"),

System.Net.IPAddress.Parse("43.58.217.52"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("30.63.26.61"),

System.Net.IPAddress.Parse("28.87.218.250"),

System.Net.IPAddress.Parse("234.120.176.239"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("46.79.109.62"),

System.Net.IPAddress.Parse("67.66.66.123"),

System.Net.IPAddress.Parse("231.243.41.181"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("236.72.55.197"),

System.Net.IPAddress.Parse("16.106.249.175"),

System.Net.IPAddress.Parse("140.122.179.172"),

System.Net.IPAddress.Parse("63.86.128.192"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("219.100.93.185"),

System.Net.IPAddress.Parse("32.252.143.71"),

System.Net.IPAddress.Parse("148.145.146.48"),

System.Net.IPAddress.Parse("28.133.121.131"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("245.155.224.231"),

System.Net.IPAddress.Parse("214.18.123.20"),

System.Net.IPAddress.Parse("213.88.60.26"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("38.10.13.111"),

System.Net.IPAddress.Parse("39.20.137.9"),

System.Net.IPAddress.Parse("115.182.193.172"),

System.Net.IPAddress.Parse("104.194.208.215"),

},
},
            new IPAddressinetArray2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("111.25.171.64"),

System.Net.IPAddress.Parse("71.224.150.206"),

System.Net.IPAddress.Parse("235.46.8.118"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("170.88.47.247"),

System.Net.IPAddress.Parse("171.127.71.46"),

System.Net.IPAddress.Parse("209.233.100.130"),

},
},
            new IPAddressinetArray2M
{
    Id = 183,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("226.41.199.194"),

System.Net.IPAddress.Parse("183.13.44.53"),

System.Net.IPAddress.Parse("174.188.70.8"),

System.Net.IPAddress.Parse("161.205.115.43"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("212.243.106.12"),

System.Net.IPAddress.Parse("193.225.135.100"),

System.Net.IPAddress.Parse("49.221.10.84"),

System.Net.IPAddress.Parse("18.79.90.126"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("228.173.106.244"),

System.Net.IPAddress.Parse("51.108.242.158"),

System.Net.IPAddress.Parse("203.145.199.156"),

},
},
            new IPAddressinetArray2M
{
    Id = 189,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("89.160.232.16"),

System.Net.IPAddress.Parse("57.96.215.3"),

System.Net.IPAddress.Parse("252.197.115.85"),

System.Net.IPAddress.Parse("37.107.220.58"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 190,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("45.87.5.61"),

System.Net.IPAddress.Parse("52.28.160.165"),

System.Net.IPAddress.Parse("13.175.148.223"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("243.21.78.171"),

System.Net.IPAddress.Parse("97.138.116.231"),

System.Net.IPAddress.Parse("142.151.54.181"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("39.198.82.254"),

System.Net.IPAddress.Parse("70.175.216.6"),

System.Net.IPAddress.Parse("57.215.63.80"),

System.Net.IPAddress.Parse("190.187.155.226"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("55.154.164.12"),

System.Net.IPAddress.Parse("66.35.130.200"),

System.Net.IPAddress.Parse("25.139.54.117"),

System.Net.IPAddress.Parse("185.143.111.150"),

},
},
            new IPAddressinetArray2M
{
    Id = 193,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("83.70.124.177"),

System.Net.IPAddress.Parse("117.1.3.86"),

System.Net.IPAddress.Parse("53.4.82.206"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("213.200.30.149"),

System.Net.IPAddress.Parse("45.15.54.51"),

System.Net.IPAddress.Parse("133.196.142.87"),

System.Net.IPAddress.Parse("104.146.73.154"),

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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[28],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[32],_testData[34], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
                parametr1.Value = 94;
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
                parametr1.Value = 183;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(34));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[1], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[2], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[3], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[4], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[5], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[6], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[7], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[8], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[9], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[10], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[11], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[12], false);
                        IPAddressinetArray2M.AssertModel(models[12],_testData[13], false);
                        IPAddressinetArray2M.AssertModel(models[13],_testData[14], false);
                        IPAddressinetArray2M.AssertModel(models[14],_testData[15], false);
                        IPAddressinetArray2M.AssertModel(models[15],_testData[16], false);
                        IPAddressinetArray2M.AssertModel(models[16],_testData[17], false);
                        IPAddressinetArray2M.AssertModel(models[17],_testData[18], false);
                        IPAddressinetArray2M.AssertModel(models[18],_testData[19], false);
                        IPAddressinetArray2M.AssertModel(models[19],_testData[20], false);
                        IPAddressinetArray2M.AssertModel(models[20],_testData[21], false);
                        IPAddressinetArray2M.AssertModel(models[21],_testData[22], false);
                        IPAddressinetArray2M.AssertModel(models[22],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[23],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[24],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[25],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[26],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[27],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[28],_testData[29], false);
                        IPAddressinetArray2M.AssertModel(models[29],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[30],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[31],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[32],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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
                await ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 164, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
                await ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 124, query1, 146, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[34], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 26, query1, 177, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[28],_testData[34], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 47, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[24],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 164, query1, 124, query2))
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
                await ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 86, query1, 4, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[32],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 111, query1, 71, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[15],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(models[16],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[17],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[18],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[19],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[20],_testData[34], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 69, query1, 56, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 164, 103))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatch(connection, 124, 12))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[23], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[24], false);
                        IPAddressinetArray2M.AssertModel(models[2],_testData[25], false);
                        IPAddressinetArray2M.AssertModel(models[3],_testData[26], false);
                        IPAddressinetArray2M.AssertModel(models[4],_testData[27], false);
                        IPAddressinetArray2M.AssertModel(models[5],_testData[28], false);
                        IPAddressinetArray2M.AssertModel(models[6],_testData[29], false);
                        IPAddressinetArray2M.AssertModel(models[7],_testData[30], false);
                        IPAddressinetArray2M.AssertModel(models[8],_testData[31], false);
                        IPAddressinetArray2M.AssertModel(models[9],_testData[32], false);
                        IPAddressinetArray2M.AssertModel(models[10],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 1);
                var models = await ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                IPAddressinetArray2M.AssertModel(models[0],_testData[1], false);
                IPAddressinetArray2M.AssertModel(models[1],_testData[2], false);
                IPAddressinetArray2M.AssertModel(models[2],_testData[3], false);
                IPAddressinetArray2M.AssertModel(models[3],_testData[4], false);
                IPAddressinetArray2M.AssertModel(models[4],_testData[5], false);
                IPAddressinetArray2M.AssertModel(models[5],_testData[6], false);
                IPAddressinetArray2M.AssertModel(models[6],_testData[7], false);
                IPAddressinetArray2M.AssertModel(models[7],_testData[8], false);
                IPAddressinetArray2M.AssertModel(models[8],_testData[9], false);
                IPAddressinetArray2M.AssertModel(models[9],_testData[10], false);
                IPAddressinetArray2M.AssertModel(models[10],_testData[11], false);
                IPAddressinetArray2M.AssertModel(models[11],_testData[12], false);
                IPAddressinetArray2M.AssertModel(models[12],_testData[13], false);
                IPAddressinetArray2M.AssertModel(models[13],_testData[14], false);
                IPAddressinetArray2M.AssertModel(models[14],_testData[15], false);
                IPAddressinetArray2M.AssertModel(models[15],_testData[16], false);
                IPAddressinetArray2M.AssertModel(models[16],_testData[17], false);
                IPAddressinetArray2M.AssertModel(models[17],_testData[18], false);
                IPAddressinetArray2M.AssertModel(models[18],_testData[19], false);
                IPAddressinetArray2M.AssertModel(models[19],_testData[20], false);
                IPAddressinetArray2M.AssertModel(models[20],_testData[21], false);
                IPAddressinetArray2M.AssertModel(models[21],_testData[22], false);
                IPAddressinetArray2M.AssertModel(models[22],_testData[23], false);
                IPAddressinetArray2M.AssertModel(models[23],_testData[24], false);
                IPAddressinetArray2M.AssertModel(models[24],_testData[25], false);
                IPAddressinetArray2M.AssertModel(models[25],_testData[26], false);
                IPAddressinetArray2M.AssertModel(models[26],_testData[27], false);
                IPAddressinetArray2M.AssertModel(models[27],_testData[28], false);
                IPAddressinetArray2M.AssertModel(models[28],_testData[29], false);
                IPAddressinetArray2M.AssertModel(models[29],_testData[30], false);
                IPAddressinetArray2M.AssertModel(models[30],_testData[31], false);
                IPAddressinetArray2M.AssertModel(models[31],_testData[32], false);
                IPAddressinetArray2M.AssertModel(models[32],_testData[33], false);
                IPAddressinetArray2M.AssertModel(models[33],_testData[34], false);
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

