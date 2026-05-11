

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
System.Net.IPAddress.Parse("39.114.13.114"),

System.Net.IPAddress.Parse("243.157.110.54"),

System.Net.IPAddress.Parse("25.92.237.178"),

System.Net.IPAddress.Parse("125.105.36.133"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("195.185.9.209"),

System.Net.IPAddress.Parse("190.91.134.87"),

System.Net.IPAddress.Parse("152.76.58.15"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("36.53.106.29"),

System.Net.IPAddress.Parse("170.1.1.206"),

System.Net.IPAddress.Parse("212.86.106.232"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("124.103.26.152"),

System.Net.IPAddress.Parse("217.234.230.149"),

System.Net.IPAddress.Parse("136.213.4.136"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("85.201.181.32"),

System.Net.IPAddress.Parse("31.137.182.44"),

System.Net.IPAddress.Parse("236.176.184.149"),

System.Net.IPAddress.Parse("183.40.151.131"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("231.8.186.44"),

System.Net.IPAddress.Parse("204.42.161.1"),

System.Net.IPAddress.Parse("97.97.158.1"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("206.123.13.180"),

System.Net.IPAddress.Parse("237.138.86.136"),

System.Net.IPAddress.Parse("152.248.185.176"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("252.166.40.22"),

System.Net.IPAddress.Parse("13.210.194.76"),

System.Net.IPAddress.Parse("167.236.134.21"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("139.151.4.138"),

System.Net.IPAddress.Parse("177.179.75.19"),

System.Net.IPAddress.Parse("76.214.43.239"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("192.36.234.46"),

System.Net.IPAddress.Parse("119.66.109.23"),

System.Net.IPAddress.Parse("220.81.118.226"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("57.50.15.1"),

System.Net.IPAddress.Parse("58.111.180.80"),

System.Net.IPAddress.Parse("177.105.21.143"),

System.Net.IPAddress.Parse("172.241.118.33"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("210.201.82.218"),

System.Net.IPAddress.Parse("173.128.55.155"),

System.Net.IPAddress.Parse("66.73.148.204"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("58.192.179.213"),

System.Net.IPAddress.Parse("63.197.41.155"),

System.Net.IPAddress.Parse("58.62.141.27"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("186.179.207.224"),

System.Net.IPAddress.Parse("138.198.96.43"),

System.Net.IPAddress.Parse("250.201.118.202"),

System.Net.IPAddress.Parse("158.79.63.102"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("133.10.202.4"),

System.Net.IPAddress.Parse("215.30.126.249"),

System.Net.IPAddress.Parse("81.211.39.157"),

System.Net.IPAddress.Parse("23.93.199.252"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("60.138.92.28"),

System.Net.IPAddress.Parse("41.175.17.105"),

System.Net.IPAddress.Parse("7.61.42.43"),

System.Net.IPAddress.Parse("7.101.45.100"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("22.169.103.82"),

System.Net.IPAddress.Parse("107.56.29.132"),

System.Net.IPAddress.Parse("33.2.59.214"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("92.243.152.122"),

System.Net.IPAddress.Parse("214.21.90.166"),

System.Net.IPAddress.Parse("155.31.139.152"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("91.204.161.19"),

System.Net.IPAddress.Parse("128.206.134.94"),

System.Net.IPAddress.Parse("1.50.67.165"),

System.Net.IPAddress.Parse("204.139.30.109"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("199.241.34.13"),

System.Net.IPAddress.Parse("66.210.85.145"),

System.Net.IPAddress.Parse("241.110.41.227"),

System.Net.IPAddress.Parse("58.121.54.85"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("74.171.91.114"),

System.Net.IPAddress.Parse("215.253.84.165"),

System.Net.IPAddress.Parse("56.155.161.156"),

System.Net.IPAddress.Parse("186.104.28.76"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("30.103.177.225"),

System.Net.IPAddress.Parse("140.1.226.145"),

System.Net.IPAddress.Parse("232.212.224.106"),

System.Net.IPAddress.Parse("150.119.103.216"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("116.109.187.87"),

System.Net.IPAddress.Parse("8.114.162.78"),

System.Net.IPAddress.Parse("146.83.123.200"),

System.Net.IPAddress.Parse("47.175.250.231"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("205.173.169.27"),

System.Net.IPAddress.Parse("36.254.78.109"),

System.Net.IPAddress.Parse("248.198.159.78"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("227.200.8.10"),

System.Net.IPAddress.Parse("172.232.118.101"),

System.Net.IPAddress.Parse("19.117.194.37"),

System.Net.IPAddress.Parse("131.42.134.48"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("154.248.83.50"),

System.Net.IPAddress.Parse("1.108.148.211"),

System.Net.IPAddress.Parse("116.137.188.23"),

System.Net.IPAddress.Parse("107.194.188.149"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("115.89.238.2"),

System.Net.IPAddress.Parse("240.163.148.245"),

System.Net.IPAddress.Parse("117.35.65.227"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("85.184.114.240"),

System.Net.IPAddress.Parse("126.216.165.49"),

System.Net.IPAddress.Parse("34.65.237.158"),

System.Net.IPAddress.Parse("21.3.14.193"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("166.91.180.161"),

System.Net.IPAddress.Parse("166.75.23.54"),

System.Net.IPAddress.Parse("88.252.153.241"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("188.188.68.254"),

System.Net.IPAddress.Parse("194.176.52.89"),

System.Net.IPAddress.Parse("216.192.18.22"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("121.166.241.190"),

System.Net.IPAddress.Parse("84.106.188.44"),

System.Net.IPAddress.Parse("171.41.21.225"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("88.151.17.3"),

System.Net.IPAddress.Parse("198.195.234.82"),

System.Net.IPAddress.Parse("197.140.19.150"),

System.Net.IPAddress.Parse("130.84.115.149"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("221.60.150.72"),

System.Net.IPAddress.Parse("130.12.85.162"),

System.Net.IPAddress.Parse("233.10.206.36"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("23.27.210.134"),

System.Net.IPAddress.Parse("113.83.96.138"),

System.Net.IPAddress.Parse("195.215.214.198"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.164.109.205"),

System.Net.IPAddress.Parse("158.153.166.137"),

System.Net.IPAddress.Parse("115.5.148.1"),

System.Net.IPAddress.Parse("70.26.138.68"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("222.244.11.166"),

System.Net.IPAddress.Parse("34.96.131.233"),

System.Net.IPAddress.Parse("142.108.124.159"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("180.216.163.26"),

System.Net.IPAddress.Parse("235.120.227.27"),

System.Net.IPAddress.Parse("213.82.108.179"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("160.120.19.84"),

System.Net.IPAddress.Parse("179.87.132.243"),

System.Net.IPAddress.Parse("47.17.108.217"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("179.30.147.44"),

System.Net.IPAddress.Parse("34.248.33.53"),

System.Net.IPAddress.Parse("236.7.217.196"),

System.Net.IPAddress.Parse("232.173.44.77"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("81.242.59.159"),

System.Net.IPAddress.Parse("177.114.94.144"),

System.Net.IPAddress.Parse("123.169.63.143"),

System.Net.IPAddress.Parse("123.1.234.144"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("119.207.66.89"),

System.Net.IPAddress.Parse("1.222.11.181"),

System.Net.IPAddress.Parse("168.1.200.2"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("223.70.59.207"),

System.Net.IPAddress.Parse("41.200.96.103"),

System.Net.IPAddress.Parse("74.181.245.217"),

System.Net.IPAddress.Parse("116.0.177.89"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("216.45.99.202"),

System.Net.IPAddress.Parse("140.69.232.214"),

System.Net.IPAddress.Parse("211.105.231.26"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("71.126.147.253"),

System.Net.IPAddress.Parse("205.3.49.232"),

System.Net.IPAddress.Parse("46.36.34.155"),

System.Net.IPAddress.Parse("135.20.151.208"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("123.83.254.167"),

System.Net.IPAddress.Parse("152.86.55.109"),

System.Net.IPAddress.Parse("229.105.195.146"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("218.4.33.190"),

System.Net.IPAddress.Parse("101.90.6.195"),

System.Net.IPAddress.Parse("109.138.253.77"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("105.16.190.24"),

System.Net.IPAddress.Parse("133.142.44.9"),

System.Net.IPAddress.Parse("101.0.146.201"),

System.Net.IPAddress.Parse("173.117.117.78"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("38.23.0.140"),

System.Net.IPAddress.Parse("235.209.49.89"),

System.Net.IPAddress.Parse("43.7.247.143"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("12.25.102.216"),

System.Net.IPAddress.Parse("17.73.153.76"),

System.Net.IPAddress.Parse("174.56.100.246"),

System.Net.IPAddress.Parse("239.46.160.254"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("5.26.202.137"),

System.Net.IPAddress.Parse("1.73.224.77"),

System.Net.IPAddress.Parse("110.3.49.46"),

System.Net.IPAddress.Parse("132.115.135.0"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("236.19.103.53"),

System.Net.IPAddress.Parse("145.174.123.89"),

System.Net.IPAddress.Parse("43.13.223.72"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("53.202.246.110"),

System.Net.IPAddress.Parse("94.104.98.61"),

System.Net.IPAddress.Parse("200.156.46.236"),

System.Net.IPAddress.Parse("218.41.3.27"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("185.223.77.74"),

System.Net.IPAddress.Parse("9.61.28.218"),

System.Net.IPAddress.Parse("253.17.171.166"),

System.Net.IPAddress.Parse("43.162.185.130"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("4.67.103.30"),

System.Net.IPAddress.Parse("169.100.234.218"),

System.Net.IPAddress.Parse("141.196.14.28"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("139.65.157.86"),

System.Net.IPAddress.Parse("57.10.212.167"),

System.Net.IPAddress.Parse("62.203.100.60"),

System.Net.IPAddress.Parse("244.22.176.232"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("198.243.27.193"),

System.Net.IPAddress.Parse("254.186.236.75"),

System.Net.IPAddress.Parse("61.219.131.117"),

System.Net.IPAddress.Parse("157.26.143.38"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("183.35.204.234"),

System.Net.IPAddress.Parse("247.198.247.209"),

System.Net.IPAddress.Parse("196.88.240.100"),

System.Net.IPAddress.Parse("38.36.66.87"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("50.52.74.163"),

System.Net.IPAddress.Parse("82.9.139.214"),

System.Net.IPAddress.Parse("52.146.126.73"),

System.Net.IPAddress.Parse("59.81.241.45"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("180.155.24.205"),

System.Net.IPAddress.Parse("31.80.79.85"),

System.Net.IPAddress.Parse("235.39.41.78"),

System.Net.IPAddress.Parse("204.115.75.62"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("30.102.118.149"),

System.Net.IPAddress.Parse("114.196.200.146"),

System.Net.IPAddress.Parse("38.38.36.16"),

System.Net.IPAddress.Parse("207.48.217.116"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("235.36.146.109"),

System.Net.IPAddress.Parse("28.90.250.33"),

System.Net.IPAddress.Parse("82.206.136.155"),

System.Net.IPAddress.Parse("145.162.112.199"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("249.27.164.222"),

System.Net.IPAddress.Parse("181.250.240.235"),

System.Net.IPAddress.Parse("18.72.182.227"),

System.Net.IPAddress.Parse("27.91.180.142"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("236.119.95.196"),

System.Net.IPAddress.Parse("126.54.30.196"),

System.Net.IPAddress.Parse("100.221.226.110"),

System.Net.IPAddress.Parse("36.86.33.110"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("177.225.20.164"),

System.Net.IPAddress.Parse("176.86.84.249"),

System.Net.IPAddress.Parse("169.237.218.30"),

System.Net.IPAddress.Parse("35.121.159.136"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("137.83.223.112"),

System.Net.IPAddress.Parse("138.207.67.119"),

System.Net.IPAddress.Parse("147.142.81.20"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("220.188.166.181"),

System.Net.IPAddress.Parse("127.86.112.111"),

System.Net.IPAddress.Parse("219.213.89.115"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("162.116.204.252"),

System.Net.IPAddress.Parse("228.253.240.60"),

System.Net.IPAddress.Parse("201.38.208.253"),

System.Net.IPAddress.Parse("232.149.82.200"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("134.143.158.236"),

System.Net.IPAddress.Parse("139.103.97.126"),

System.Net.IPAddress.Parse("252.65.48.224"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("137.62.243.145"),

System.Net.IPAddress.Parse("24.57.84.152"),

System.Net.IPAddress.Parse("14.146.137.62"),

System.Net.IPAddress.Parse("69.97.40.58"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 182,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("149.42.83.11"),

System.Net.IPAddress.Parse("18.109.157.144"),

System.Net.IPAddress.Parse("157.249.80.192"),

System.Net.IPAddress.Parse("228.8.162.1"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("221.29.58.143"),

System.Net.IPAddress.Parse("80.111.26.140"),

System.Net.IPAddress.Parse("71.91.25.119"),

System.Net.IPAddress.Parse("65.224.152.135"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 184,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("62.193.144.198"),

System.Net.IPAddress.Parse("4.111.113.153"),

System.Net.IPAddress.Parse("225.115.227.106"),

System.Net.IPAddress.Parse("11.155.253.218"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 189,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("96.62.191.171"),

System.Net.IPAddress.Parse("62.73.237.29"),

System.Net.IPAddress.Parse("194.92.108.62"),

System.Net.IPAddress.Parse("92.46.239.74"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("0.196.68.117"),

System.Net.IPAddress.Parse("222.95.45.158"),

System.Net.IPAddress.Parse("8.225.234.108"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("243.15.125.162"),

System.Net.IPAddress.Parse("228.55.89.209"),

System.Net.IPAddress.Parse("200.190.93.105"),

System.Net.IPAddress.Parse("137.69.224.35"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("11.162.202.21"),

System.Net.IPAddress.Parse("19.91.72.179"),

System.Net.IPAddress.Parse("172.44.22.11"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 195,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("203.91.247.121"),

System.Net.IPAddress.Parse("0.139.143.134"),

System.Net.IPAddress.Parse("142.182.10.94"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("60.74.70.120"),

System.Net.IPAddress.Parse("229.123.218.150"),

System.Net.IPAddress.Parse("77.131.44.214"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 196,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("150.211.14.218"),

System.Net.IPAddress.Parse("161.103.167.200"),

System.Net.IPAddress.Parse("180.179.172.115"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("115.207.238.126"),

System.Net.IPAddress.Parse("212.237.31.30"),

System.Net.IPAddress.Parse("224.81.176.85"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("235.110.103.252"),

System.Net.IPAddress.Parse("4.62.73.44"),

System.Net.IPAddress.Parse("19.85.165.108"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 202,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("1.11.196.197"),

System.Net.IPAddress.Parse("153.42.53.132"),

System.Net.IPAddress.Parse("248.116.46.68"),

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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
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
                parametr1.Value = 184;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 35;
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[16],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[17],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[18],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[19],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
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
                parametr1.Value = 153;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr2.Value = 33;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[29],_testData[34], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 189;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[18], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[19], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[20], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[14],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[15],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 171;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 189;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[34], false);
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
                await ((IIPAddressListinetListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 11, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[32],_testData[34], false);
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
                await ((IIPAddressListinetListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 71, query1, 163, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[23],_testData[34], false);
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
                 ((IIPAddressListinetListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 131, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[24],_testData[34], false);
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
                 ((IIPAddressListinetListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 33, query1, 148, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressListinetListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 141, query1, 81, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IIPAddressListinetListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 178, query1, 71, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressListinetListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 5, query1, 84, query2))
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[16],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[17],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[18],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[19],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[20],_testData[34], false);
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
                 ((IIPAddressListinetListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 129, query1, 38, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in await ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 56, 182))
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
                foreach(var batchResult in  ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelBatch(connection, 109, 81))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[17], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[18], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[19], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[20], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[14],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[15],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[16],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[13], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[14], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[15], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[16], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[17], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[18], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[19], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[20], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[14],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[15],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[16],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[17],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[18],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[19],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[20],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[21],_testData[34], false);
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
                ((IIPAddressListinetListD1)this).SetDbConnectionSelectModelParametrs(cmd, 148);
                var models = await ((IIPAddressListinetListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressListinetListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressListinetListD1)this).SetDbConnectionSelectModelParametrs(cmd, 33);
                var models =  ((IIPAddressListinetListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

