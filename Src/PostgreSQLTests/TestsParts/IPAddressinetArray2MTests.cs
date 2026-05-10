

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
System.Net.IPAddress.Parse("94.159.136.185"),

System.Net.IPAddress.Parse("213.42.65.157"),

System.Net.IPAddress.Parse("202.0.132.88"),

System.Net.IPAddress.Parse("183.76.154.211"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("223.59.29.181"),

System.Net.IPAddress.Parse("190.29.204.175"),

System.Net.IPAddress.Parse("74.196.104.198"),

},
},
            new IPAddressinetArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("214.106.161.38"),

System.Net.IPAddress.Parse("248.11.117.6"),

System.Net.IPAddress.Parse("251.121.76.242"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("2.74.30.49"),

System.Net.IPAddress.Parse("248.99.252.147"),

System.Net.IPAddress.Parse("23.228.157.125"),

System.Net.IPAddress.Parse("203.180.153.230"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("151.212.77.224"),

System.Net.IPAddress.Parse("54.107.54.253"),

System.Net.IPAddress.Parse("253.160.45.59"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("152.73.237.18"),

System.Net.IPAddress.Parse("219.96.5.157"),

System.Net.IPAddress.Parse("141.133.67.195"),

System.Net.IPAddress.Parse("214.8.38.188"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("120.111.35.230"),

System.Net.IPAddress.Parse("111.231.64.187"),

System.Net.IPAddress.Parse("92.116.166.223"),

System.Net.IPAddress.Parse("232.49.79.30"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("246.99.229.222"),

System.Net.IPAddress.Parse("143.185.254.106"),

System.Net.IPAddress.Parse("78.29.66.132"),

System.Net.IPAddress.Parse("13.13.33.222"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("51.177.20.120"),

System.Net.IPAddress.Parse("197.92.31.135"),

System.Net.IPAddress.Parse("130.209.148.193"),

System.Net.IPAddress.Parse("159.50.63.234"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("174.225.210.221"),

System.Net.IPAddress.Parse("180.10.140.152"),

System.Net.IPAddress.Parse("128.213.29.71"),

System.Net.IPAddress.Parse("233.68.123.153"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("231.10.88.206"),

System.Net.IPAddress.Parse("249.95.217.120"),

System.Net.IPAddress.Parse("194.13.179.7"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("177.171.180.156"),

System.Net.IPAddress.Parse("149.99.253.144"),

System.Net.IPAddress.Parse("171.239.80.185"),

System.Net.IPAddress.Parse("199.94.147.54"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("128.35.14.241"),

System.Net.IPAddress.Parse("173.99.178.211"),

System.Net.IPAddress.Parse("120.162.227.213"),

System.Net.IPAddress.Parse("146.161.18.137"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("113.157.211.77"),

System.Net.IPAddress.Parse("20.13.192.10"),

System.Net.IPAddress.Parse("43.81.147.33"),

},
},
            new IPAddressinetArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("170.254.43.119"),

System.Net.IPAddress.Parse("103.25.87.206"),

System.Net.IPAddress.Parse("159.137.8.79"),

System.Net.IPAddress.Parse("59.208.18.245"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("18.172.184.65"),

System.Net.IPAddress.Parse("54.129.165.142"),

System.Net.IPAddress.Parse("185.75.99.34"),

System.Net.IPAddress.Parse("212.1.209.231"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("32.217.211.192"),

System.Net.IPAddress.Parse("112.190.100.167"),

System.Net.IPAddress.Parse("126.118.201.37"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("132.19.163.39"),

System.Net.IPAddress.Parse("216.159.179.101"),

System.Net.IPAddress.Parse("130.33.85.15"),

System.Net.IPAddress.Parse("254.94.71.166"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("34.124.102.58"),

System.Net.IPAddress.Parse("63.211.232.27"),

System.Net.IPAddress.Parse("119.242.13.191"),

},
},
            new IPAddressinetArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("183.19.201.142"),

System.Net.IPAddress.Parse("78.32.109.129"),

System.Net.IPAddress.Parse("229.30.193.8"),

System.Net.IPAddress.Parse("172.221.170.164"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("31.135.224.196"),

System.Net.IPAddress.Parse("128.67.98.85"),

System.Net.IPAddress.Parse("58.7.164.157"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("111.96.120.148"),

System.Net.IPAddress.Parse("62.202.147.3"),

System.Net.IPAddress.Parse("205.231.208.221"),

System.Net.IPAddress.Parse("18.81.84.35"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("83.222.254.186"),

System.Net.IPAddress.Parse("182.121.47.207"),

System.Net.IPAddress.Parse("25.245.128.115"),

System.Net.IPAddress.Parse("144.249.41.113"),

},
},
            new IPAddressinetArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("199.70.47.138"),

System.Net.IPAddress.Parse("7.22.0.232"),

System.Net.IPAddress.Parse("112.243.110.49"),

System.Net.IPAddress.Parse("153.104.34.12"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("252.86.174.82"),

System.Net.IPAddress.Parse("209.8.159.165"),

System.Net.IPAddress.Parse("4.210.152.121"),

},
},
            new IPAddressinetArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("155.22.89.85"),

System.Net.IPAddress.Parse("48.164.115.85"),

System.Net.IPAddress.Parse("43.241.129.131"),

System.Net.IPAddress.Parse("232.194.122.19"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("165.5.228.134"),

System.Net.IPAddress.Parse("79.31.190.175"),

System.Net.IPAddress.Parse("13.234.10.190"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("156.195.236.153"),

System.Net.IPAddress.Parse("29.15.32.157"),

System.Net.IPAddress.Parse("245.153.11.196"),

},
},
            new IPAddressinetArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("173.40.200.254"),

System.Net.IPAddress.Parse("211.227.86.187"),

System.Net.IPAddress.Parse("252.127.236.198"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("104.164.124.121"),

System.Net.IPAddress.Parse("128.77.213.113"),

System.Net.IPAddress.Parse("233.97.119.232"),

System.Net.IPAddress.Parse("61.206.120.183"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("15.222.129.196"),

System.Net.IPAddress.Parse("25.70.195.77"),

System.Net.IPAddress.Parse("117.53.115.244"),

System.Net.IPAddress.Parse("27.235.227.64"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("13.15.63.21"),

System.Net.IPAddress.Parse("149.222.226.19"),

System.Net.IPAddress.Parse("2.2.229.202"),

System.Net.IPAddress.Parse("131.83.4.221"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("28.106.135.227"),

System.Net.IPAddress.Parse("247.7.113.6"),

System.Net.IPAddress.Parse("223.241.59.27"),

},
},
            new IPAddressinetArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("129.54.21.85"),

System.Net.IPAddress.Parse("78.122.38.251"),

System.Net.IPAddress.Parse("102.27.190.223"),

System.Net.IPAddress.Parse("240.124.203.163"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("135.2.4.254"),

System.Net.IPAddress.Parse("181.216.34.254"),

System.Net.IPAddress.Parse("102.120.143.155"),

},
},
            new IPAddressinetArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("248.249.205.253"),

System.Net.IPAddress.Parse("225.226.89.200"),

System.Net.IPAddress.Parse("13.196.185.214"),

System.Net.IPAddress.Parse("107.228.244.252"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("157.239.195.135"),

System.Net.IPAddress.Parse("201.54.43.154"),

System.Net.IPAddress.Parse("60.168.45.50"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("216.233.117.188"),

System.Net.IPAddress.Parse("100.77.138.150"),

System.Net.IPAddress.Parse("219.151.15.77"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("200.172.43.64"),

System.Net.IPAddress.Parse("55.152.211.246"),

System.Net.IPAddress.Parse("130.40.151.39"),

},
},
            new IPAddressinetArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("237.115.221.116"),

System.Net.IPAddress.Parse("194.13.26.93"),

System.Net.IPAddress.Parse("41.52.83.253"),

System.Net.IPAddress.Parse("116.41.139.53"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("82.141.80.108"),

System.Net.IPAddress.Parse("93.36.14.175"),

System.Net.IPAddress.Parse("115.216.216.50"),

System.Net.IPAddress.Parse("239.184.155.209"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("4.78.53.163"),

System.Net.IPAddress.Parse("70.184.177.91"),

System.Net.IPAddress.Parse("186.173.235.179"),

System.Net.IPAddress.Parse("57.166.10.70"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("101.189.9.40"),

System.Net.IPAddress.Parse("254.31.76.101"),

System.Net.IPAddress.Parse("163.160.92.113"),

System.Net.IPAddress.Parse("104.245.141.76"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("71.72.4.155"),

System.Net.IPAddress.Parse("154.121.181.168"),

System.Net.IPAddress.Parse("40.180.70.106"),

System.Net.IPAddress.Parse("170.101.25.88"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("172.115.177.243"),

System.Net.IPAddress.Parse("64.251.126.169"),

System.Net.IPAddress.Parse("219.219.93.133"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("251.211.164.136"),

System.Net.IPAddress.Parse("111.45.252.182"),

System.Net.IPAddress.Parse("22.243.214.56"),

System.Net.IPAddress.Parse("234.112.176.203"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("228.31.185.89"),

System.Net.IPAddress.Parse("133.243.71.189"),

System.Net.IPAddress.Parse("249.167.65.8"),

},
},
            new IPAddressinetArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("74.109.10.28"),

System.Net.IPAddress.Parse("190.180.215.158"),

System.Net.IPAddress.Parse("105.29.127.76"),

System.Net.IPAddress.Parse("138.96.252.50"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("249.69.156.211"),

System.Net.IPAddress.Parse("193.244.249.205"),

System.Net.IPAddress.Parse("169.23.53.157"),

System.Net.IPAddress.Parse("37.97.212.73"),

},
},
            new IPAddressinetArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("197.13.49.188"),

System.Net.IPAddress.Parse("74.231.220.69"),

System.Net.IPAddress.Parse("118.155.208.112"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("90.194.47.185"),

System.Net.IPAddress.Parse("151.74.173.214"),

System.Net.IPAddress.Parse("191.114.32.95"),

System.Net.IPAddress.Parse("181.245.121.107"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("45.151.146.95"),

System.Net.IPAddress.Parse("132.158.86.105"),

System.Net.IPAddress.Parse("13.50.108.207"),

System.Net.IPAddress.Parse("3.63.100.103"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("137.220.235.195"),

System.Net.IPAddress.Parse("187.169.229.204"),

System.Net.IPAddress.Parse("138.165.23.219"),

System.Net.IPAddress.Parse("243.164.197.228"),

},
},
            new IPAddressinetArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("80.111.149.57"),

System.Net.IPAddress.Parse("101.36.254.144"),

System.Net.IPAddress.Parse("122.80.120.40"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("149.121.100.229"),

System.Net.IPAddress.Parse("133.57.196.44"),

System.Net.IPAddress.Parse("87.48.36.229"),

},
},
            new IPAddressinetArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("76.28.251.131"),

System.Net.IPAddress.Parse("158.53.203.247"),

System.Net.IPAddress.Parse("176.153.200.253"),

System.Net.IPAddress.Parse("144.120.197.0"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("80.217.248.33"),

System.Net.IPAddress.Parse("21.35.156.169"),

System.Net.IPAddress.Parse("101.123.242.36"),

System.Net.IPAddress.Parse("174.80.156.145"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("199.29.157.161"),

System.Net.IPAddress.Parse("76.119.122.173"),

System.Net.IPAddress.Parse("64.178.83.106"),

System.Net.IPAddress.Parse("227.187.94.242"),

},
},
            new IPAddressinetArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("121.143.166.172"),

System.Net.IPAddress.Parse("83.242.117.142"),

System.Net.IPAddress.Parse("250.225.58.165"),

System.Net.IPAddress.Parse("54.126.194.225"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("206.47.27.230"),

System.Net.IPAddress.Parse("2.34.114.98"),

System.Net.IPAddress.Parse("12.90.146.101"),

System.Net.IPAddress.Parse("44.71.235.219"),

},
},
            new IPAddressinetArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("162.76.106.251"),

System.Net.IPAddress.Parse("160.193.1.250"),

System.Net.IPAddress.Parse("230.90.20.236"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("165.34.21.173"),

System.Net.IPAddress.Parse("251.95.158.13"),

System.Net.IPAddress.Parse("179.62.164.107"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("149.47.83.193"),

System.Net.IPAddress.Parse("250.212.236.206"),

System.Net.IPAddress.Parse("52.36.254.209"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("221.96.88.223"),

System.Net.IPAddress.Parse("70.104.182.109"),

System.Net.IPAddress.Parse("100.105.196.195"),

System.Net.IPAddress.Parse("136.174.103.214"),

},
},
            new IPAddressinetArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("170.238.39.122"),

System.Net.IPAddress.Parse("183.21.27.113"),

System.Net.IPAddress.Parse("34.101.114.237"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("118.109.88.159"),

System.Net.IPAddress.Parse("39.168.249.64"),

System.Net.IPAddress.Parse("228.223.123.165"),

},
},
            new IPAddressinetArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("144.30.65.62"),

System.Net.IPAddress.Parse("178.89.77.137"),

System.Net.IPAddress.Parse("126.212.245.182"),

System.Net.IPAddress.Parse("92.103.181.113"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("207.169.205.39"),

System.Net.IPAddress.Parse("110.118.182.8"),

System.Net.IPAddress.Parse("53.173.5.147"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("189.52.103.84"),

System.Net.IPAddress.Parse("80.68.133.180"),

System.Net.IPAddress.Parse("178.239.90.0"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("169.1.126.54"),

System.Net.IPAddress.Parse("148.83.243.204"),

System.Net.IPAddress.Parse("63.1.162.99"),

System.Net.IPAddress.Parse("37.34.193.228"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("143.205.240.153"),

System.Net.IPAddress.Parse("159.67.59.146"),

System.Net.IPAddress.Parse("72.191.197.240"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("234.18.229.56"),

System.Net.IPAddress.Parse("63.158.196.224"),

System.Net.IPAddress.Parse("81.163.17.121"),

System.Net.IPAddress.Parse("175.42.149.5"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("130.227.63.162"),

System.Net.IPAddress.Parse("137.12.131.18"),

System.Net.IPAddress.Parse("151.12.119.196"),

System.Net.IPAddress.Parse("223.129.26.11"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("114.80.74.201"),

System.Net.IPAddress.Parse("212.0.155.13"),

System.Net.IPAddress.Parse("168.227.112.71"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("16.167.3.155"),

System.Net.IPAddress.Parse("146.95.56.169"),

System.Net.IPAddress.Parse("192.70.67.42"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("70.216.2.219"),

System.Net.IPAddress.Parse("71.47.79.179"),

System.Net.IPAddress.Parse("158.34.13.33"),

System.Net.IPAddress.Parse("225.150.213.163"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("244.156.10.202"),

System.Net.IPAddress.Parse("112.71.251.230"),

System.Net.IPAddress.Parse("220.154.91.119"),

},
},
            new IPAddressinetArray2M
{
    Id = 181,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("61.79.63.89"),

System.Net.IPAddress.Parse("51.125.51.74"),

System.Net.IPAddress.Parse("100.122.59.239"),

},
    ModelInner = new IPAddressinetArray2MI
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("100.103.8.133"),

System.Net.IPAddress.Parse("223.199.187.210"),

System.Net.IPAddress.Parse("67.155.226.8"),

System.Net.IPAddress.Parse("84.122.193.77"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("234.233.118.34"),

System.Net.IPAddress.Parse("190.83.145.90"),

System.Net.IPAddress.Parse("225.78.140.131"),

System.Net.IPAddress.Parse("250.208.222.6"),

},
},
    NullableValue = null,
},
            new IPAddressinetArray2M
{
    Id = 190,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("29.24.240.175"),

System.Net.IPAddress.Parse("160.147.28.118"),

System.Net.IPAddress.Parse("237.201.61.72"),

System.Net.IPAddress.Parse("93.95.72.112"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("110.17.50.55"),

System.Net.IPAddress.Parse("186.124.13.150"),

System.Net.IPAddress.Parse("37.136.189.83"),

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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[34], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 170;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[23],_testData[34], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
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
                parametr2.Value = 79;
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 175;
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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
                await ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 145, query1, 161, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                await ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 125, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                 ((IIPAddressListinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 111, query1, 75, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(firstItems2[15],_testData[34], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 140, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[18],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 105, query1, 96, query2))
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
                await ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 130, query1, 87, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 116, query1, 49, query2))
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatIPAddressinetArray2M.AssertModel(models[0],_testData[6], false);
                        FlatIPAddressinetArray2M.AssertModel(models[1],_testData[7], false);
                        FlatIPAddressinetArray2M.AssertModel(models[2],_testData[8], false);
                        FlatIPAddressinetArray2M.AssertModel(models[3],_testData[9], false);
                        FlatIPAddressinetArray2M.AssertModel(models[4],_testData[10], false);
                        FlatIPAddressinetArray2M.AssertModel(models[5],_testData[11], false);
                        FlatIPAddressinetArray2M.AssertModel(models[6],_testData[12], false);
                        FlatIPAddressinetArray2M.AssertModel(models[7],_testData[13], false);
                        FlatIPAddressinetArray2M.AssertModel(models[8],_testData[14], false);
                        FlatIPAddressinetArray2M.AssertModel(models[9],_testData[15], false);
                        FlatIPAddressinetArray2M.AssertModel(models[10],_testData[16], false);
                        FlatIPAddressinetArray2M.AssertModel(models[11],_testData[17], false);
                        FlatIPAddressinetArray2M.AssertModel(models[12],_testData[18], false);
                        FlatIPAddressinetArray2M.AssertModel(models[13],_testData[19], false);
                        FlatIPAddressinetArray2M.AssertModel(models[14],_testData[20], false);
                        FlatIPAddressinetArray2M.AssertModel(models[15],_testData[21], false);
                        FlatIPAddressinetArray2M.AssertModel(models[16],_testData[22], false);
                        FlatIPAddressinetArray2M.AssertModel(models[17],_testData[23], false);
                        FlatIPAddressinetArray2M.AssertModel(models[18],_testData[24], false);
                        FlatIPAddressinetArray2M.AssertModel(models[19],_testData[25], false);
                        FlatIPAddressinetArray2M.AssertModel(models[20],_testData[26], false);
                        FlatIPAddressinetArray2M.AssertModel(models[21],_testData[27], false);
                        FlatIPAddressinetArray2M.AssertModel(models[22],_testData[28], false);
                        FlatIPAddressinetArray2M.AssertModel(models[23],_testData[29], false);
                        FlatIPAddressinetArray2M.AssertModel(models[24],_testData[30], false);
                        FlatIPAddressinetArray2M.AssertModel(models[25],_testData[31], false);
                        FlatIPAddressinetArray2M.AssertModel(models[26],_testData[32], false);
                        FlatIPAddressinetArray2M.AssertModel(models[27],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(models[28],_testData[34], false);
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
                 ((IIPAddressListinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 130, query1, 175, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatIPAddressinetArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 130, 75))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IIPAddressListinetArray)this).DbConnectionSTSelectModelBatch(connection, 57, 111))
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
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 137);
                var models = await ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressListinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 18);
                var models =  ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

