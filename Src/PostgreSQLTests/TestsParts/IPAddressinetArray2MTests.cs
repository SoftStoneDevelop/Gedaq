

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
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("207.192.164.189"),

System.Net.IPAddress.Parse("164.235.174.53"),

System.Net.IPAddress.Parse("203.115.129.4"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.7.101.155"),

System.Net.IPAddress.Parse("219.19.182.117"),

System.Net.IPAddress.Parse("21.53.3.113"),

System.Net.IPAddress.Parse("161.144.91.120"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("247.222.9.241"),

System.Net.IPAddress.Parse("181.224.32.247"),

System.Net.IPAddress.Parse("238.28.23.75"),

System.Net.IPAddress.Parse("207.98.16.218"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("100.69.135.187"),

System.Net.IPAddress.Parse("162.200.252.233"),

System.Net.IPAddress.Parse("93.62.254.63"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("5.253.188.165"),

System.Net.IPAddress.Parse("186.48.209.131"),

System.Net.IPAddress.Parse("212.179.118.100"),

System.Net.IPAddress.Parse("235.232.136.40"),

},
},
            new IPAddressinetArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("245.58.196.115"),

System.Net.IPAddress.Parse("207.151.218.125"),

System.Net.IPAddress.Parse("173.32.71.87"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("133.98.139.170"),

System.Net.IPAddress.Parse("35.49.188.224"),

System.Net.IPAddress.Parse("111.147.217.49"),

System.Net.IPAddress.Parse("231.200.160.189"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("0.13.159.94"),

System.Net.IPAddress.Parse("104.236.20.222"),

System.Net.IPAddress.Parse("168.184.121.65"),

System.Net.IPAddress.Parse("196.156.137.174"),

},
},
            new IPAddressinetArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("203.94.59.215"),

System.Net.IPAddress.Parse("155.235.39.49"),

System.Net.IPAddress.Parse("230.124.76.30"),

System.Net.IPAddress.Parse("167.159.108.127"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("117.192.67.233"),

System.Net.IPAddress.Parse("81.14.40.88"),

System.Net.IPAddress.Parse("31.201.41.5"),

System.Net.IPAddress.Parse("149.130.55.232"),

},
},
            new IPAddressinetArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("238.227.79.197"),

System.Net.IPAddress.Parse("154.23.65.150"),

System.Net.IPAddress.Parse("247.57.88.20"),

System.Net.IPAddress.Parse("42.220.9.86"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("152.175.152.11"),

System.Net.IPAddress.Parse("138.82.144.165"),

System.Net.IPAddress.Parse("106.129.90.80"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("159.62.20.52"),

System.Net.IPAddress.Parse("61.139.253.226"),

System.Net.IPAddress.Parse("205.34.243.164"),

System.Net.IPAddress.Parse("228.38.107.156"),

},
},
            new IPAddressinetArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("238.249.158.238"),

System.Net.IPAddress.Parse("119.35.104.203"),

System.Net.IPAddress.Parse("209.231.190.197"),

System.Net.IPAddress.Parse("138.39.128.235"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("127.42.18.191"),

System.Net.IPAddress.Parse("165.152.232.248"),

System.Net.IPAddress.Parse("170.89.195.12"),

},
},
            new IPAddressinetArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("84.209.234.8"),

System.Net.IPAddress.Parse("227.216.169.215"),

System.Net.IPAddress.Parse("111.138.93.246"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("40.108.64.2"),

System.Net.IPAddress.Parse("163.155.54.140"),

System.Net.IPAddress.Parse("215.175.135.149"),

System.Net.IPAddress.Parse("250.185.73.34"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("79.231.222.129"),

System.Net.IPAddress.Parse("159.132.230.196"),

System.Net.IPAddress.Parse("142.206.231.106"),

System.Net.IPAddress.Parse("17.74.38.181"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("173.251.21.137"),

System.Net.IPAddress.Parse("171.99.179.3"),

System.Net.IPAddress.Parse("82.216.10.127"),

},
},
            new IPAddressinetArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("150.98.145.41"),

System.Net.IPAddress.Parse("59.8.88.136"),

System.Net.IPAddress.Parse("178.133.61.215"),

System.Net.IPAddress.Parse("179.78.26.175"),

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
System.Net.IPAddress.Parse("13.135.89.205"),

System.Net.IPAddress.Parse("62.198.9.223"),

System.Net.IPAddress.Parse("147.19.223.180"),

System.Net.IPAddress.Parse("139.170.105.143"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("158.10.91.52"),

System.Net.IPAddress.Parse("149.229.155.57"),

System.Net.IPAddress.Parse("66.225.125.64"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("140.172.96.89"),

System.Net.IPAddress.Parse("59.183.178.234"),

System.Net.IPAddress.Parse("65.220.0.26"),

System.Net.IPAddress.Parse("233.144.157.18"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("102.206.17.101"),

System.Net.IPAddress.Parse("81.149.204.200"),

System.Net.IPAddress.Parse("103.139.233.184"),

System.Net.IPAddress.Parse("48.112.164.162"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("111.221.3.168"),

System.Net.IPAddress.Parse("216.251.34.174"),

System.Net.IPAddress.Parse("145.234.32.52"),

System.Net.IPAddress.Parse("223.238.63.235"),

},
},
            new IPAddressinetArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("184.177.96.52"),

System.Net.IPAddress.Parse("191.99.61.187"),

System.Net.IPAddress.Parse("134.12.176.124"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("81.224.95.8"),

System.Net.IPAddress.Parse("244.63.74.225"),

System.Net.IPAddress.Parse("58.227.109.91"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("188.59.231.192"),

System.Net.IPAddress.Parse("117.79.181.35"),

System.Net.IPAddress.Parse("80.178.251.222"),

System.Net.IPAddress.Parse("142.148.169.110"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("176.251.119.91"),

System.Net.IPAddress.Parse("72.209.219.86"),

System.Net.IPAddress.Parse("59.175.133.207"),

System.Net.IPAddress.Parse("223.217.216.205"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("177.36.31.108"),

System.Net.IPAddress.Parse("112.89.210.59"),

System.Net.IPAddress.Parse("244.245.116.135"),

},
},
            new IPAddressinetArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("104.212.233.201"),

System.Net.IPAddress.Parse("209.185.110.187"),

System.Net.IPAddress.Parse("80.92.77.92"),

System.Net.IPAddress.Parse("168.160.202.109"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("215.8.46.101"),

System.Net.IPAddress.Parse("145.71.105.84"),

System.Net.IPAddress.Parse("114.113.88.196"),

System.Net.IPAddress.Parse("103.112.49.20"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("45.100.51.68"),

System.Net.IPAddress.Parse("101.101.169.33"),

System.Net.IPAddress.Parse("216.5.98.218"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("36.95.222.103"),

System.Net.IPAddress.Parse("159.5.96.184"),

System.Net.IPAddress.Parse("135.147.3.178"),

System.Net.IPAddress.Parse("199.190.13.234"),

},
},
            new IPAddressinetArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("209.168.141.227"),

System.Net.IPAddress.Parse("59.55.146.67"),

System.Net.IPAddress.Parse("235.211.108.233"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("25.166.80.188"),

System.Net.IPAddress.Parse("236.169.227.14"),

System.Net.IPAddress.Parse("222.71.170.143"),

System.Net.IPAddress.Parse("233.130.46.75"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("152.89.209.62"),

System.Net.IPAddress.Parse("3.231.68.125"),

System.Net.IPAddress.Parse("5.130.23.19"),

System.Net.IPAddress.Parse("247.148.75.82"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("227.26.161.49"),

System.Net.IPAddress.Parse("142.11.84.147"),

System.Net.IPAddress.Parse("167.44.78.152"),

System.Net.IPAddress.Parse("136.13.179.114"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("113.234.135.14"),

System.Net.IPAddress.Parse("99.57.37.19"),

System.Net.IPAddress.Parse("165.125.221.234"),

System.Net.IPAddress.Parse("250.154.226.156"),

},
},
            new IPAddressinetArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("103.67.141.81"),

System.Net.IPAddress.Parse("21.61.60.78"),

System.Net.IPAddress.Parse("129.235.133.145"),

System.Net.IPAddress.Parse("190.21.52.221"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("155.98.168.235"),

System.Net.IPAddress.Parse("223.150.183.163"),

System.Net.IPAddress.Parse("50.146.141.163"),

System.Net.IPAddress.Parse("236.121.226.160"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("40.249.113.67"),

System.Net.IPAddress.Parse("191.26.192.216"),

System.Net.IPAddress.Parse("217.131.147.197"),

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
System.Net.IPAddress.Parse("237.63.31.212"),

System.Net.IPAddress.Parse("216.26.208.82"),

System.Net.IPAddress.Parse("120.228.177.178"),

System.Net.IPAddress.Parse("69.52.236.61"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("140.202.15.19"),

System.Net.IPAddress.Parse("106.74.10.186"),

System.Net.IPAddress.Parse("32.44.206.40"),

System.Net.IPAddress.Parse("34.225.76.118"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("193.248.131.200"),

System.Net.IPAddress.Parse("220.86.215.27"),

System.Net.IPAddress.Parse("214.58.112.102"),

System.Net.IPAddress.Parse("244.119.222.130"),

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
System.Net.IPAddress.Parse("52.17.142.152"),

System.Net.IPAddress.Parse("95.70.176.136"),

System.Net.IPAddress.Parse("243.140.117.84"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("112.166.245.47"),

System.Net.IPAddress.Parse("0.134.3.143"),

System.Net.IPAddress.Parse("151.78.97.84"),

System.Net.IPAddress.Parse("34.45.57.61"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("249.39.58.124"),

System.Net.IPAddress.Parse("16.119.71.63"),

System.Net.IPAddress.Parse("217.98.79.47"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("104.133.93.251"),

System.Net.IPAddress.Parse("95.71.26.7"),

System.Net.IPAddress.Parse("100.247.59.90"),

},
},
            new IPAddressinetArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("229.189.78.169"),

System.Net.IPAddress.Parse("50.206.77.97"),

System.Net.IPAddress.Parse("203.192.128.67"),

System.Net.IPAddress.Parse("179.0.184.2"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("38.52.249.10"),

System.Net.IPAddress.Parse("13.186.177.135"),

System.Net.IPAddress.Parse("130.86.38.230"),

},
},
            new IPAddressinetArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.9.214.62"),

System.Net.IPAddress.Parse("35.229.204.192"),

System.Net.IPAddress.Parse("199.28.170.6"),

System.Net.IPAddress.Parse("172.99.123.127"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("110.195.107.73"),

System.Net.IPAddress.Parse("121.49.123.246"),

System.Net.IPAddress.Parse("123.43.92.222"),

System.Net.IPAddress.Parse("125.211.101.248"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("106.226.142.172"),

System.Net.IPAddress.Parse("70.26.157.83"),

System.Net.IPAddress.Parse("79.209.82.43"),

},
},
            new IPAddressinetArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("16.206.252.155"),

System.Net.IPAddress.Parse("232.129.38.232"),

System.Net.IPAddress.Parse("182.146.218.139"),

System.Net.IPAddress.Parse("171.65.130.2"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("243.106.99.241"),

System.Net.IPAddress.Parse("84.227.250.236"),

System.Net.IPAddress.Parse("3.44.163.163"),

System.Net.IPAddress.Parse("28.46.82.212"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("155.84.17.20"),

System.Net.IPAddress.Parse("93.161.164.21"),

System.Net.IPAddress.Parse("64.199.229.220"),

System.Net.IPAddress.Parse("102.33.16.50"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("19.135.7.116"),

System.Net.IPAddress.Parse("169.189.162.99"),

System.Net.IPAddress.Parse("95.81.205.196"),

System.Net.IPAddress.Parse("57.196.86.84"),

},
},
            new IPAddressinetArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("91.164.141.45"),

System.Net.IPAddress.Parse("97.59.188.228"),

System.Net.IPAddress.Parse("11.1.74.131"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("106.242.135.16"),

System.Net.IPAddress.Parse("150.77.86.159"),

System.Net.IPAddress.Parse("135.53.249.76"),

System.Net.IPAddress.Parse("51.200.167.52"),

},
},
            new IPAddressinetArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("253.207.81.117"),

System.Net.IPAddress.Parse("65.141.15.50"),

System.Net.IPAddress.Parse("253.199.84.205"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("221.115.87.155"),

System.Net.IPAddress.Parse("137.97.49.149"),

System.Net.IPAddress.Parse("6.140.132.35"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("156.248.91.4"),

System.Net.IPAddress.Parse("160.38.109.70"),

System.Net.IPAddress.Parse("68.164.132.6"),

System.Net.IPAddress.Parse("64.183.14.58"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("87.216.75.127"),

System.Net.IPAddress.Parse("241.62.201.73"),

System.Net.IPAddress.Parse("70.165.250.187"),

System.Net.IPAddress.Parse("90.69.116.148"),

},
},
            new IPAddressinetArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("144.193.252.83"),

System.Net.IPAddress.Parse("159.236.159.43"),

System.Net.IPAddress.Parse("18.158.11.37"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("55.12.235.84"),

System.Net.IPAddress.Parse("52.145.83.110"),

System.Net.IPAddress.Parse("121.8.233.82"),

System.Net.IPAddress.Parse("164.89.159.83"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("107.240.132.77"),

System.Net.IPAddress.Parse("163.37.177.150"),

System.Net.IPAddress.Parse("254.148.151.98"),

System.Net.IPAddress.Parse("146.232.134.99"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("189.89.186.221"),

System.Net.IPAddress.Parse("201.167.88.4"),

System.Net.IPAddress.Parse("179.85.179.205"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("230.10.233.106"),

System.Net.IPAddress.Parse("228.22.205.155"),

System.Net.IPAddress.Parse("108.32.178.13"),

},
},
            new IPAddressinetArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("112.32.147.107"),

System.Net.IPAddress.Parse("204.29.199.133"),

System.Net.IPAddress.Parse("182.76.194.220"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("118.58.243.46"),

System.Net.IPAddress.Parse("82.94.249.212"),

System.Net.IPAddress.Parse("1.80.133.116"),

System.Net.IPAddress.Parse("68.94.39.245"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("171.163.197.54"),

System.Net.IPAddress.Parse("142.92.83.156"),

System.Net.IPAddress.Parse("52.230.175.29"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("159.106.123.82"),

System.Net.IPAddress.Parse("132.197.107.32"),

System.Net.IPAddress.Parse("30.153.65.29"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("210.29.214.227"),

System.Net.IPAddress.Parse("123.183.214.37"),

System.Net.IPAddress.Parse("22.192.237.18"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("121.173.129.165"),

System.Net.IPAddress.Parse("103.231.174.245"),

System.Net.IPAddress.Parse("25.49.90.129"),

},
},
            new IPAddressinetArray2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("43.74.15.132"),

System.Net.IPAddress.Parse("104.184.45.204"),

System.Net.IPAddress.Parse("132.178.251.36"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("36.245.109.246"),

System.Net.IPAddress.Parse("71.25.65.92"),

System.Net.IPAddress.Parse("10.119.139.149"),

System.Net.IPAddress.Parse("19.185.196.62"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("194.233.245.106"),

System.Net.IPAddress.Parse("200.212.98.228"),

System.Net.IPAddress.Parse("251.31.29.111"),

System.Net.IPAddress.Parse("19.164.222.156"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("151.171.121.15"),

System.Net.IPAddress.Parse("162.203.31.80"),

System.Net.IPAddress.Parse("98.96.99.161"),

System.Net.IPAddress.Parse("181.26.230.206"),

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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[34], false);
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
                parametr1.Value = 165;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 165;
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[34], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 111;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[34], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[34], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                await ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 45, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
                await ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 131, query1, 139, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[34], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 142, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 160, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 79, query1, 9, query2))
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
                await ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 6, query1, 151, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 63, query1, 68, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[15],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[16],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[17],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(models[18],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[19],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[20],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[21],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 97, query1, 9, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 71, 6))
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatch(connection, 142, 165))
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        IPAddressinetArray2M.AssertModel(models[0],_testData[33], false);
                        IPAddressinetArray2M.AssertModel(models[1],_testData[34], false);
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
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 35);
                var models = await ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressListinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 51);
                var models =  ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                IPAddressinetArray2M.AssertModel(models[0],_testData[10], false);
                IPAddressinetArray2M.AssertModel(models[1],_testData[11], false);
                IPAddressinetArray2M.AssertModel(models[2],_testData[12], false);
                IPAddressinetArray2M.AssertModel(models[3],_testData[13], false);
                IPAddressinetArray2M.AssertModel(models[4],_testData[14], false);
                IPAddressinetArray2M.AssertModel(models[5],_testData[15], false);
                IPAddressinetArray2M.AssertModel(models[6],_testData[16], false);
                IPAddressinetArray2M.AssertModel(models[7],_testData[17], false);
                IPAddressinetArray2M.AssertModel(models[8],_testData[18], false);
                IPAddressinetArray2M.AssertModel(models[9],_testData[19], false);
                IPAddressinetArray2M.AssertModel(models[10],_testData[20], false);
                IPAddressinetArray2M.AssertModel(models[11],_testData[21], false);
                IPAddressinetArray2M.AssertModel(models[12],_testData[22], false);
                IPAddressinetArray2M.AssertModel(models[13],_testData[23], false);
                IPAddressinetArray2M.AssertModel(models[14],_testData[24], false);
                IPAddressinetArray2M.AssertModel(models[15],_testData[25], false);
                IPAddressinetArray2M.AssertModel(models[16],_testData[26], false);
                IPAddressinetArray2M.AssertModel(models[17],_testData[27], false);
                IPAddressinetArray2M.AssertModel(models[18],_testData[28], false);
                IPAddressinetArray2M.AssertModel(models[19],_testData[29], false);
                IPAddressinetArray2M.AssertModel(models[20],_testData[30], false);
                IPAddressinetArray2M.AssertModel(models[21],_testData[31], false);
                IPAddressinetArray2M.AssertModel(models[22],_testData[32], false);
                IPAddressinetArray2M.AssertModel(models[23],_testData[33], false);
                IPAddressinetArray2M.AssertModel(models[24],_testData[34], false);
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

