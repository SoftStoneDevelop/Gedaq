

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
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("207.216.252.123"),

System.Net.IPAddress.Parse("44.108.36.36"),

System.Net.IPAddress.Parse("27.236.170.248"),

System.Net.IPAddress.Parse("253.56.31.181"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("140.146.54.24"),

System.Net.IPAddress.Parse("237.226.115.159"),

System.Net.IPAddress.Parse("84.114.176.37"),

System.Net.IPAddress.Parse("142.140.161.104"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("35.172.252.227"),

System.Net.IPAddress.Parse("100.185.93.96"),

System.Net.IPAddress.Parse("160.215.124.52"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("159.47.150.145"),

System.Net.IPAddress.Parse("173.3.207.134"),

System.Net.IPAddress.Parse("168.39.81.104"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("155.201.212.27"),

System.Net.IPAddress.Parse("188.1.100.23"),

System.Net.IPAddress.Parse("165.60.141.183"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("82.144.10.249"),

System.Net.IPAddress.Parse("161.77.140.64"),

System.Net.IPAddress.Parse("99.168.240.212"),

System.Net.IPAddress.Parse("166.223.144.158"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("162.146.123.176"),

System.Net.IPAddress.Parse("95.246.76.80"),

System.Net.IPAddress.Parse("126.139.2.113"),

System.Net.IPAddress.Parse("171.116.248.19"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("154.19.134.175"),

System.Net.IPAddress.Parse("221.237.112.72"),

System.Net.IPAddress.Parse("43.192.70.92"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("69.51.49.193"),

System.Net.IPAddress.Parse("194.13.205.35"),

System.Net.IPAddress.Parse("250.174.213.157"),

System.Net.IPAddress.Parse("2.36.74.34"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("204.11.182.111"),

System.Net.IPAddress.Parse("64.34.92.168"),

System.Net.IPAddress.Parse("152.105.18.246"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("144.153.77.16"),

System.Net.IPAddress.Parse("67.26.148.65"),

System.Net.IPAddress.Parse("107.97.54.112"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("14.0.120.16"),

System.Net.IPAddress.Parse("0.236.163.49"),

System.Net.IPAddress.Parse("6.235.200.34"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("196.0.167.232"),

System.Net.IPAddress.Parse("215.113.12.103"),

System.Net.IPAddress.Parse("42.201.3.198"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("140.117.86.15"),

System.Net.IPAddress.Parse("60.115.203.241"),

System.Net.IPAddress.Parse("241.226.221.103"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("154.253.242.44"),

System.Net.IPAddress.Parse("174.192.134.208"),

System.Net.IPAddress.Parse("229.174.12.164"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("100.77.46.104"),

System.Net.IPAddress.Parse("119.105.186.217"),

System.Net.IPAddress.Parse("24.9.230.207"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("56.153.222.243"),

System.Net.IPAddress.Parse("164.245.85.54"),

System.Net.IPAddress.Parse("165.44.20.199"),

System.Net.IPAddress.Parse("202.130.250.90"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("22.97.63.247"),

System.Net.IPAddress.Parse("48.177.172.93"),

System.Net.IPAddress.Parse("244.90.33.197"),

System.Net.IPAddress.Parse("141.97.29.131"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("29.215.81.197"),

System.Net.IPAddress.Parse("82.189.41.204"),

System.Net.IPAddress.Parse("171.241.126.198"),

System.Net.IPAddress.Parse("200.91.207.55"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("232.178.184.24"),

System.Net.IPAddress.Parse("55.202.195.197"),

System.Net.IPAddress.Parse("72.47.239.242"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("203.150.77.205"),

System.Net.IPAddress.Parse("173.125.105.63"),

System.Net.IPAddress.Parse("183.219.69.7"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("99.148.159.174"),

System.Net.IPAddress.Parse("57.58.66.29"),

System.Net.IPAddress.Parse("242.223.175.174"),

System.Net.IPAddress.Parse("89.173.144.117"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("86.236.172.179"),

System.Net.IPAddress.Parse("186.190.118.52"),

System.Net.IPAddress.Parse("165.75.24.233"),

System.Net.IPAddress.Parse("197.106.174.38"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("98.125.152.99"),

System.Net.IPAddress.Parse("225.111.119.79"),

System.Net.IPAddress.Parse("101.64.189.126"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("199.45.180.203"),

System.Net.IPAddress.Parse("68.150.20.16"),

System.Net.IPAddress.Parse("5.158.66.231"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("35.35.104.11"),

System.Net.IPAddress.Parse("234.47.39.50"),

System.Net.IPAddress.Parse("240.96.250.180"),

System.Net.IPAddress.Parse("122.86.142.27"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("131.26.132.73"),

System.Net.IPAddress.Parse("65.157.203.8"),

System.Net.IPAddress.Parse("200.108.228.40"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("105.126.48.185"),

System.Net.IPAddress.Parse("188.215.164.173"),

System.Net.IPAddress.Parse("90.196.236.10"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("167.30.236.146"),

System.Net.IPAddress.Parse("179.25.86.230"),

System.Net.IPAddress.Parse("246.93.15.128"),

System.Net.IPAddress.Parse("83.64.151.119"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("210.58.63.203"),

System.Net.IPAddress.Parse("74.173.183.200"),

System.Net.IPAddress.Parse("37.175.81.38"),

System.Net.IPAddress.Parse("252.165.53.205"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("66.50.46.226"),

System.Net.IPAddress.Parse("57.9.211.224"),

System.Net.IPAddress.Parse("53.13.79.127"),

System.Net.IPAddress.Parse("163.32.107.8"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("254.82.192.110"),

System.Net.IPAddress.Parse("2.45.249.185"),

System.Net.IPAddress.Parse("161.12.31.4"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("72.226.247.37"),

System.Net.IPAddress.Parse("222.64.63.74"),

System.Net.IPAddress.Parse("19.116.129.248"),

System.Net.IPAddress.Parse("60.140.59.119"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("31.44.41.78"),

System.Net.IPAddress.Parse("220.140.125.143"),

System.Net.IPAddress.Parse("214.246.45.25"),

System.Net.IPAddress.Parse("91.112.19.80"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("31.158.88.211"),

System.Net.IPAddress.Parse("183.186.236.201"),

System.Net.IPAddress.Parse("214.102.233.109"),

System.Net.IPAddress.Parse("193.225.68.69"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("92.87.58.63"),

System.Net.IPAddress.Parse("71.219.238.24"),

System.Net.IPAddress.Parse("41.207.30.181"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("66.92.88.3"),

System.Net.IPAddress.Parse("61.23.81.154"),

System.Net.IPAddress.Parse("111.181.104.186"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("154.24.118.141"),

System.Net.IPAddress.Parse("170.158.43.147"),

System.Net.IPAddress.Parse("103.66.247.48"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("167.63.161.162"),

System.Net.IPAddress.Parse("86.180.140.49"),

System.Net.IPAddress.Parse("50.250.73.243"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("251.136.185.192"),

System.Net.IPAddress.Parse("253.225.149.106"),

System.Net.IPAddress.Parse("152.229.13.250"),

System.Net.IPAddress.Parse("252.179.228.24"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("118.62.218.194"),

System.Net.IPAddress.Parse("22.116.108.237"),

System.Net.IPAddress.Parse("196.167.30.138"),

System.Net.IPAddress.Parse("65.151.49.210"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("83.196.22.169"),

System.Net.IPAddress.Parse("171.200.11.112"),

System.Net.IPAddress.Parse("37.204.203.210"),

System.Net.IPAddress.Parse("65.167.14.72"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("34.197.78.30"),

System.Net.IPAddress.Parse("166.76.147.73"),

System.Net.IPAddress.Parse("241.125.102.31"),

System.Net.IPAddress.Parse("83.229.84.131"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("201.239.177.91"),

System.Net.IPAddress.Parse("94.226.136.111"),

System.Net.IPAddress.Parse("32.223.83.105"),

System.Net.IPAddress.Parse("176.186.239.24"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("246.77.30.198"),

System.Net.IPAddress.Parse("242.9.150.174"),

System.Net.IPAddress.Parse("65.124.113.189"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("204.32.85.135"),

System.Net.IPAddress.Parse("176.147.9.169"),

System.Net.IPAddress.Parse("119.151.139.200"),

System.Net.IPAddress.Parse("91.162.193.216"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("184.216.242.142"),

System.Net.IPAddress.Parse("138.170.121.246"),

System.Net.IPAddress.Parse("70.176.8.110"),

System.Net.IPAddress.Parse("128.87.40.203"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("109.64.144.58"),

System.Net.IPAddress.Parse("153.254.239.133"),

System.Net.IPAddress.Parse("225.237.212.44"),

System.Net.IPAddress.Parse("192.238.29.85"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("221.78.168.203"),

System.Net.IPAddress.Parse("95.243.81.6"),

System.Net.IPAddress.Parse("180.79.125.188"),

System.Net.IPAddress.Parse("32.120.228.162"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("107.167.1.59"),

System.Net.IPAddress.Parse("159.139.25.81"),

System.Net.IPAddress.Parse("125.110.97.16"),

System.Net.IPAddress.Parse("16.20.13.48"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("111.17.207.5"),

System.Net.IPAddress.Parse("135.4.202.10"),

System.Net.IPAddress.Parse("114.118.119.16"),

System.Net.IPAddress.Parse("193.185.204.15"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("1.133.217.54"),

System.Net.IPAddress.Parse("54.40.149.85"),

System.Net.IPAddress.Parse("155.149.97.8"),

System.Net.IPAddress.Parse("197.91.128.198"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("155.58.25.216"),

System.Net.IPAddress.Parse("13.68.68.52"),

System.Net.IPAddress.Parse("83.97.67.167"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("96.164.223.91"),

System.Net.IPAddress.Parse("44.90.181.116"),

System.Net.IPAddress.Parse("73.184.236.2"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("146.231.129.222"),

System.Net.IPAddress.Parse("40.104.28.167"),

System.Net.IPAddress.Parse("226.26.179.188"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("156.254.151.13"),

System.Net.IPAddress.Parse("207.83.227.68"),

System.Net.IPAddress.Parse("152.5.233.43"),

System.Net.IPAddress.Parse("180.234.195.149"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("89.82.247.40"),

System.Net.IPAddress.Parse("155.205.248.171"),

System.Net.IPAddress.Parse("214.103.17.7"),

System.Net.IPAddress.Parse("242.195.92.155"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("26.134.188.229"),

System.Net.IPAddress.Parse("107.160.252.46"),

System.Net.IPAddress.Parse("202.105.248.215"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("72.198.196.49"),

System.Net.IPAddress.Parse("181.26.202.185"),

System.Net.IPAddress.Parse("57.91.251.85"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("25.53.156.54"),

System.Net.IPAddress.Parse("245.167.207.85"),

System.Net.IPAddress.Parse("165.195.67.14"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("209.81.129.86"),

System.Net.IPAddress.Parse("3.73.36.140"),

System.Net.IPAddress.Parse("138.216.74.120"),

System.Net.IPAddress.Parse("98.194.12.178"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("69.89.133.150"),

System.Net.IPAddress.Parse("138.248.218.218"),

System.Net.IPAddress.Parse("243.123.81.124"),

System.Net.IPAddress.Parse("183.150.38.162"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("109.214.87.55"),

System.Net.IPAddress.Parse("105.100.3.237"),

System.Net.IPAddress.Parse("202.141.212.222"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("57.176.203.131"),

System.Net.IPAddress.Parse("5.89.85.218"),

System.Net.IPAddress.Parse("35.32.179.28"),

System.Net.IPAddress.Parse("210.144.197.10"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("11.197.139.9"),

System.Net.IPAddress.Parse("245.18.3.202"),

System.Net.IPAddress.Parse("244.75.85.8"),

System.Net.IPAddress.Parse("203.165.234.128"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("21.70.155.153"),

System.Net.IPAddress.Parse("198.50.200.11"),

System.Net.IPAddress.Parse("180.3.33.234"),

System.Net.IPAddress.Parse("149.174.254.93"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.244.149.17"),

System.Net.IPAddress.Parse("150.134.48.113"),

System.Net.IPAddress.Parse("46.90.233.224"),

System.Net.IPAddress.Parse("15.62.45.35"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("207.172.190.185"),

System.Net.IPAddress.Parse("219.226.64.88"),

System.Net.IPAddress.Parse("7.112.63.145"),

System.Net.IPAddress.Parse("165.140.157.52"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("94.162.225.167"),

System.Net.IPAddress.Parse("185.250.49.37"),

System.Net.IPAddress.Parse("36.29.164.179"),

System.Net.IPAddress.Parse("41.235.124.251"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("247.129.17.0"),

System.Net.IPAddress.Parse("98.55.193.200"),

System.Net.IPAddress.Parse("46.206.245.147"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("108.160.74.94"),

System.Net.IPAddress.Parse("38.95.211.81"),

System.Net.IPAddress.Parse("107.171.158.222"),

System.Net.IPAddress.Parse("56.38.41.36"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("78.134.18.141"),

System.Net.IPAddress.Parse("61.92.167.136"),

System.Net.IPAddress.Parse("16.205.72.153"),

System.Net.IPAddress.Parse("179.188.11.184"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("76.211.69.204"),

System.Net.IPAddress.Parse("12.133.8.145"),

System.Net.IPAddress.Parse("3.34.91.14"),

System.Net.IPAddress.Parse("130.111.189.96"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("231.185.247.171"),

System.Net.IPAddress.Parse("248.1.167.21"),

System.Net.IPAddress.Parse("106.252.133.34"),

System.Net.IPAddress.Parse("227.29.202.155"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 182,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("60.176.59.64"),

System.Net.IPAddress.Parse("86.235.92.64"),

System.Net.IPAddress.Parse("223.32.123.189"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("140.63.144.23"),

System.Net.IPAddress.Parse("100.1.224.197"),

System.Net.IPAddress.Parse("135.233.20.210"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 183,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("67.166.237.248"),

System.Net.IPAddress.Parse("70.73.213.138"),

System.Net.IPAddress.Parse("188.235.195.213"),

System.Net.IPAddress.Parse("51.93.157.19"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("0.209.79.156"),

System.Net.IPAddress.Parse("138.130.154.209"),

System.Net.IPAddress.Parse("54.87.25.22"),

System.Net.IPAddress.Parse("203.147.114.229"),

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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
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
                parametr2.Value = 125;
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[16],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[17],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
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
                parametr1.Value = 88;
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
                foreach(var batchResult in  ((IIPAddressListinetListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[16],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[17],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(32));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[3], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[4], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[5], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[6], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[7], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[8], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[9], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[10], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[11], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[12], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[13], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[14], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[15], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[16], false);
                        IPAddressinetListD1E2M.AssertModel(models[14],_testData[17], false);
                        IPAddressinetListD1E2M.AssertModel(models[15],_testData[18], false);
                        IPAddressinetListD1E2M.AssertModel(models[16],_testData[19], false);
                        IPAddressinetListD1E2M.AssertModel(models[17],_testData[20], false);
                        IPAddressinetListD1E2M.AssertModel(models[18],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[19],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[20],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[21],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[22],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[23],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[24],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[25],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[26],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[27],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[28],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[29],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[30],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[16], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[17], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[18], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[19], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[20], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[14],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[15],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[16],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[17],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[18],_testData[34], false);
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
                await ((IIPAddressListinetListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 125, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[23],_testData[34], false);
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
                await ((IIPAddressListinetListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 141, query1, 53, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
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
                 ((IIPAddressListinetListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 132, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IIPAddressListinetListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 74, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressListinetListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 5, query1, 45, query2))
                {
                    if(++resultIndex == 1)
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
                await ((IIPAddressListinetListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 15, query1, 40, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressListinetListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 162, query1, 120, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[34], false);
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
                 ((IIPAddressListinetListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 136, query1, 141, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 125, 106))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelBatch(connection, 129, 63))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[12], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[13], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[14], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[15], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[16], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[17], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[18], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[19], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[20], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[14],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[15],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[16],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[17],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[18],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[19],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[20],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[21],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[22],_testData[34], false);
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
                ((IIPAddressListinetListD1)this).SetDbConnectionSelectModelParametrs(cmd, 152);
                var models = await ((IIPAddressListinetListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                IPAddressinetListD1E2M.AssertModel(models[0],_testData[29], false);
                IPAddressinetListD1E2M.AssertModel(models[1],_testData[30], false);
                IPAddressinetListD1E2M.AssertModel(models[2],_testData[31], false);
                IPAddressinetListD1E2M.AssertModel(models[3],_testData[32], false);
                IPAddressinetListD1E2M.AssertModel(models[4],_testData[33], false);
                IPAddressinetListD1E2M.AssertModel(models[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressListinetListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressListinetListD1)this).SetDbConnectionSelectModelParametrs(cmd, 120);
                var models =  ((IIPAddressListinetListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

