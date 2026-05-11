

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
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("135.138.86.190"),

System.Net.IPAddress.Parse("101.201.143.176"),

System.Net.IPAddress.Parse("232.23.251.121"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("36.58.233.122"),

System.Net.IPAddress.Parse("183.12.119.106"),

System.Net.IPAddress.Parse("221.73.164.39"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("223.188.52.150"),

System.Net.IPAddress.Parse("44.164.232.13"),

System.Net.IPAddress.Parse("163.111.126.192"),

System.Net.IPAddress.Parse("60.75.180.193"),

},
    ModelInner = new IPAddressinetListD12MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("69.177.60.190"),

System.Net.IPAddress.Parse("31.24.22.115"),

System.Net.IPAddress.Parse("148.27.15.199"),

System.Net.IPAddress.Parse("113.85.248.107"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("177.216.170.33"),

System.Net.IPAddress.Parse("127.126.217.111"),

System.Net.IPAddress.Parse("222.223.212.231"),

System.Net.IPAddress.Parse("34.225.6.229"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("78.248.165.235"),

System.Net.IPAddress.Parse("224.39.215.112"),

System.Net.IPAddress.Parse("150.11.144.175"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("55.221.25.177"),

System.Net.IPAddress.Parse("211.248.58.108"),

System.Net.IPAddress.Parse("41.17.225.108"),

System.Net.IPAddress.Parse("161.37.64.220"),

},
    ModelInner = new IPAddressinetListD12MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("198.56.218.233"),

System.Net.IPAddress.Parse("115.62.55.119"),

System.Net.IPAddress.Parse("147.110.226.206"),

System.Net.IPAddress.Parse("95.243.51.106"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("221.238.142.181"),

System.Net.IPAddress.Parse("75.236.49.201"),

System.Net.IPAddress.Parse("32.94.216.69"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("248.226.129.230"),

System.Net.IPAddress.Parse("182.30.100.115"),

System.Net.IPAddress.Parse("178.111.153.31"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("138.222.226.156"),

System.Net.IPAddress.Parse("80.138.93.96"),

System.Net.IPAddress.Parse("225.55.71.222"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("54.4.11.46"),

System.Net.IPAddress.Parse("92.184.161.227"),

System.Net.IPAddress.Parse("184.180.22.59"),

},
    ModelInner = new IPAddressinetListD12MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("177.156.45.157"),

System.Net.IPAddress.Parse("162.163.218.254"),

System.Net.IPAddress.Parse("119.128.196.64"),

System.Net.IPAddress.Parse("46.186.240.16"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("161.65.65.60"),

System.Net.IPAddress.Parse("141.35.46.118"),

System.Net.IPAddress.Parse("124.2.147.173"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("204.104.243.202"),

System.Net.IPAddress.Parse("78.216.174.191"),

System.Net.IPAddress.Parse("228.105.37.204"),

},
    ModelInner = new IPAddressinetListD12MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("131.172.75.14"),

System.Net.IPAddress.Parse("176.108.250.37"),

System.Net.IPAddress.Parse("103.6.175.123"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("113.117.166.160"),

System.Net.IPAddress.Parse("190.207.67.168"),

System.Net.IPAddress.Parse("59.246.251.100"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("129.94.47.108"),

System.Net.IPAddress.Parse("12.86.7.245"),

System.Net.IPAddress.Parse("176.59.187.214"),

System.Net.IPAddress.Parse("20.57.201.63"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("238.251.168.179"),

System.Net.IPAddress.Parse("83.116.154.45"),

System.Net.IPAddress.Parse("85.23.158.88"),

System.Net.IPAddress.Parse("175.199.194.205"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("174.151.219.14"),

System.Net.IPAddress.Parse("18.219.84.136"),

System.Net.IPAddress.Parse("216.64.195.207"),

System.Net.IPAddress.Parse("90.191.197.167"),

},
    ModelInner = new IPAddressinetListD12MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("225.249.227.167"),

System.Net.IPAddress.Parse("146.64.214.222"),

System.Net.IPAddress.Parse("74.134.164.116"),

System.Net.IPAddress.Parse("100.85.2.254"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("164.79.236.234"),

System.Net.IPAddress.Parse("131.188.142.152"),

System.Net.IPAddress.Parse("131.130.220.127"),

System.Net.IPAddress.Parse("212.63.89.169"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.126.119.219"),

System.Net.IPAddress.Parse("109.228.198.29"),

System.Net.IPAddress.Parse("51.81.104.155"),

System.Net.IPAddress.Parse("102.118.101.229"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("120.31.84.3"),

System.Net.IPAddress.Parse("143.103.211.246"),

System.Net.IPAddress.Parse("144.173.206.65"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("92.79.58.116"),

System.Net.IPAddress.Parse("15.167.73.51"),

System.Net.IPAddress.Parse("78.9.190.68"),

System.Net.IPAddress.Parse("12.243.154.251"),

},
    ModelInner = new IPAddressinetListD12MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("30.134.112.47"),

System.Net.IPAddress.Parse("0.79.207.134"),

System.Net.IPAddress.Parse("64.137.234.224"),

System.Net.IPAddress.Parse("96.208.11.171"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("212.127.220.102"),

System.Net.IPAddress.Parse("88.196.202.24"),

System.Net.IPAddress.Parse("154.138.209.9"),

System.Net.IPAddress.Parse("177.205.135.135"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("19.117.65.201"),

System.Net.IPAddress.Parse("16.243.21.136"),

System.Net.IPAddress.Parse("59.62.221.241"),

System.Net.IPAddress.Parse("129.16.9.153"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("208.189.1.179"),

System.Net.IPAddress.Parse("118.243.218.204"),

System.Net.IPAddress.Parse("77.24.76.0"),

System.Net.IPAddress.Parse("207.168.144.211"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("220.169.244.170"),

System.Net.IPAddress.Parse("95.210.131.214"),

System.Net.IPAddress.Parse("61.86.138.35"),

System.Net.IPAddress.Parse("13.154.171.149"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("236.149.188.90"),

System.Net.IPAddress.Parse("84.191.234.220"),

System.Net.IPAddress.Parse("121.213.245.180"),

},
    ModelInner = new IPAddressinetListD12MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("30.106.135.125"),

System.Net.IPAddress.Parse("183.19.249.80"),

System.Net.IPAddress.Parse("127.17.150.70"),

System.Net.IPAddress.Parse("86.12.67.170"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("220.8.156.191"),

System.Net.IPAddress.Parse("195.201.123.144"),

System.Net.IPAddress.Parse("163.202.254.98"),

System.Net.IPAddress.Parse("25.17.9.65"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("238.150.219.147"),

System.Net.IPAddress.Parse("175.97.105.86"),

System.Net.IPAddress.Parse("201.72.29.249"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("124.244.22.58"),

System.Net.IPAddress.Parse("192.160.121.24"),

System.Net.IPAddress.Parse("57.147.45.25"),

},
    ModelInner = new IPAddressinetListD12MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("158.112.31.225"),

System.Net.IPAddress.Parse("85.39.39.198"),

System.Net.IPAddress.Parse("195.171.190.74"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("149.231.154.36"),

System.Net.IPAddress.Parse("70.60.63.90"),

System.Net.IPAddress.Parse("81.14.166.121"),

System.Net.IPAddress.Parse("126.46.103.130"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("229.188.104.31"),

System.Net.IPAddress.Parse("111.90.174.37"),

System.Net.IPAddress.Parse("161.52.6.253"),

System.Net.IPAddress.Parse("33.136.57.133"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("184.97.211.214"),

System.Net.IPAddress.Parse("174.112.13.125"),

System.Net.IPAddress.Parse("72.153.150.78"),

System.Net.IPAddress.Parse("247.142.148.206"),

},
    ModelInner = new IPAddressinetListD12MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("59.104.249.169"),

System.Net.IPAddress.Parse("245.139.248.191"),

System.Net.IPAddress.Parse("110.209.246.92"),

System.Net.IPAddress.Parse("123.138.25.1"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("156.65.70.134"),

System.Net.IPAddress.Parse("126.140.17.19"),

System.Net.IPAddress.Parse("43.248.150.58"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("21.174.12.248"),

System.Net.IPAddress.Parse("186.207.154.5"),

System.Net.IPAddress.Parse("234.26.110.241"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("197.118.8.168"),

System.Net.IPAddress.Parse("142.108.21.80"),

System.Net.IPAddress.Parse("40.190.34.72"),

System.Net.IPAddress.Parse("109.243.191.81"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("189.233.131.16"),

System.Net.IPAddress.Parse("2.216.96.198"),

System.Net.IPAddress.Parse("151.150.222.120"),

System.Net.IPAddress.Parse("38.29.118.158"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("72.181.106.58"),

System.Net.IPAddress.Parse("94.240.32.153"),

System.Net.IPAddress.Parse("93.253.236.199"),

},
    ModelInner = new IPAddressinetListD12MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("13.12.136.139"),

System.Net.IPAddress.Parse("73.18.84.153"),

System.Net.IPAddress.Parse("184.190.99.242"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("235.227.28.57"),

System.Net.IPAddress.Parse("72.68.194.64"),

System.Net.IPAddress.Parse("35.130.105.84"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("246.21.193.119"),

System.Net.IPAddress.Parse("212.111.240.230"),

System.Net.IPAddress.Parse("97.40.0.202"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("26.173.18.239"),

System.Net.IPAddress.Parse("50.61.80.80"),

System.Net.IPAddress.Parse("12.138.75.239"),

System.Net.IPAddress.Parse("222.36.27.39"),

},
    ModelInner = new IPAddressinetListD12MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("91.84.199.80"),

System.Net.IPAddress.Parse("23.82.186.87"),

System.Net.IPAddress.Parse("229.52.53.81"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("208.245.212.218"),

System.Net.IPAddress.Parse("56.238.2.217"),

System.Net.IPAddress.Parse("17.79.2.246"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("99.197.192.12"),

System.Net.IPAddress.Parse("79.207.250.126"),

System.Net.IPAddress.Parse("43.244.183.137"),

System.Net.IPAddress.Parse("118.30.170.232"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("27.224.47.127"),

System.Net.IPAddress.Parse("41.24.48.121"),

System.Net.IPAddress.Parse("121.138.6.22"),

System.Net.IPAddress.Parse("113.75.248.0"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("179.110.183.63"),

System.Net.IPAddress.Parse("113.219.72.249"),

System.Net.IPAddress.Parse("59.139.112.13"),

},
    ModelInner = new IPAddressinetListD12MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("24.96.250.73"),

System.Net.IPAddress.Parse("165.79.145.124"),

System.Net.IPAddress.Parse("116.153.185.186"),

System.Net.IPAddress.Parse("73.120.6.237"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("187.64.66.0"),

System.Net.IPAddress.Parse("203.114.145.222"),

System.Net.IPAddress.Parse("61.225.108.165"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.55.112.60"),

System.Net.IPAddress.Parse("150.196.45.111"),

System.Net.IPAddress.Parse("168.10.52.78"),

System.Net.IPAddress.Parse("234.51.15.135"),

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
System.Net.IPAddress.Parse("40.27.163.26"),

System.Net.IPAddress.Parse("91.223.130.78"),

System.Net.IPAddress.Parse("217.109.80.194"),

System.Net.IPAddress.Parse("43.173.145.126"),

},
    ModelInner = new IPAddressinetListD12MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("240.39.52.68"),

System.Net.IPAddress.Parse("111.247.95.120"),

System.Net.IPAddress.Parse("97.209.217.105"),

System.Net.IPAddress.Parse("188.243.3.173"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("230.240.186.57"),

System.Net.IPAddress.Parse("22.137.111.21"),

System.Net.IPAddress.Parse("115.227.13.17"),

System.Net.IPAddress.Parse("174.83.133.129"),

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
System.Net.IPAddress.Parse("66.98.245.169"),

System.Net.IPAddress.Parse("22.251.198.26"),

System.Net.IPAddress.Parse("41.159.72.64"),

System.Net.IPAddress.Parse("216.241.128.177"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("46.11.23.8"),

System.Net.IPAddress.Parse("34.204.190.221"),

System.Net.IPAddress.Parse("119.235.58.147"),

},
    ModelInner = new IPAddressinetListD12MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("79.96.99.140"),

System.Net.IPAddress.Parse("33.29.188.19"),

System.Net.IPAddress.Parse("199.78.32.234"),

System.Net.IPAddress.Parse("0.194.13.81"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("231.228.119.33"),

System.Net.IPAddress.Parse("71.62.83.108"),

System.Net.IPAddress.Parse("217.72.135.245"),

System.Net.IPAddress.Parse("225.170.215.211"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("168.218.161.236"),

System.Net.IPAddress.Parse("48.73.71.228"),

System.Net.IPAddress.Parse("9.227.182.209"),

},
    ModelInner = new IPAddressinetListD12MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("39.21.190.163"),

System.Net.IPAddress.Parse("177.109.213.65"),

System.Net.IPAddress.Parse("132.184.250.156"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("133.82.219.16"),

System.Net.IPAddress.Parse("247.199.223.18"),

System.Net.IPAddress.Parse("194.5.77.140"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("60.226.201.200"),

System.Net.IPAddress.Parse("19.246.206.135"),

System.Net.IPAddress.Parse("163.189.3.220"),

System.Net.IPAddress.Parse("184.168.114.14"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("27.14.199.94"),

System.Net.IPAddress.Parse("19.247.107.155"),

System.Net.IPAddress.Parse("248.158.163.231"),

},
    ModelInner = new IPAddressinetListD12MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("119.155.87.181"),

System.Net.IPAddress.Parse("121.191.44.135"),

System.Net.IPAddress.Parse("88.80.173.68"),

System.Net.IPAddress.Parse("166.218.236.137"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("12.93.171.26"),

System.Net.IPAddress.Parse("56.49.50.130"),

System.Net.IPAddress.Parse("59.68.183.201"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("99.198.243.180"),

System.Net.IPAddress.Parse("176.131.215.195"),

System.Net.IPAddress.Parse("84.239.127.75"),

System.Net.IPAddress.Parse("66.1.42.114"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("98.60.147.242"),

System.Net.IPAddress.Parse("143.33.118.117"),

System.Net.IPAddress.Parse("69.221.216.214"),

System.Net.IPAddress.Parse("1.187.81.121"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 176,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("252.218.6.31"),

System.Net.IPAddress.Parse("203.223.166.54"),

System.Net.IPAddress.Parse("45.144.60.242"),

},
    ModelInner = new IPAddressinetListD12MI
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("118.42.210.131"),

System.Net.IPAddress.Parse("35.155.158.190"),

System.Net.IPAddress.Parse("91.74.4.18"),

System.Net.IPAddress.Parse("177.181.77.136"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("53.173.110.250"),

System.Net.IPAddress.Parse("182.146.171.131"),

System.Net.IPAddress.Parse("193.86.140.57"),

System.Net.IPAddress.Parse("96.185.48.181"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("67.90.56.50"),

System.Net.IPAddress.Parse("41.180.121.124"),

System.Net.IPAddress.Parse("131.3.81.184"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 181,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("39.28.86.74"),

System.Net.IPAddress.Parse("28.181.244.1"),

System.Net.IPAddress.Parse("59.43.138.253"),

System.Net.IPAddress.Parse("188.67.201.179"),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetlistd12mi(
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
INSERT INTO public.ipaddressinetlistd12mi(
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
            queryMapTypes: [typeof(IPAddressinetListD12MI)],
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
    ipaddressinetlistd12mi_id
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
                methodParametrName: "ipaddressinetlistd12mi_id", 
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
    ipaddressinetlistd12mi_id
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
    ipaddressinetlistd12mi_id,
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
    ipaddressinetlistd12mi_id
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
    ipaddressinetlistd12mi_id,
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
                methodParametrName: "ipaddressinetlistd12mi_id", 
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
LEFT JOIN public.ipaddressinetlistd12mi mi ON mi.id = m.ipaddressinetlistd12mi_id
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
LEFT JOIN public.ipaddressinetlistd12mi mi ON mi.id = m.ipaddressinetlistd12mi_id
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 71;
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[16],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[17],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[18],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[19],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[20],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[21],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[22],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[23],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[24],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 124;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
LEFT JOIN public.ipaddressinetlistd12mi mi ON mi.id = m.ipaddressinetlistd12mi_id
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
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[14], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[15], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[16], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[17], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[18], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[19], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[20], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[14],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[15],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[16],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[17],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[18],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[19],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
                await ((IIPAddressListinetListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 95, query1, 152, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
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
                await ((IIPAddressListinetListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 159, query1, 92, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
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
                 ((IIPAddressListinetListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 137, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[34], false);
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
                 ((IIPAddressListinetListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 11, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                foreach(var batchResult in await ((IIPAddressListinetListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 41, query1, 4, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                await ((IIPAddressListinetListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 141, query1, 152, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressListinetListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 155, query1, 34, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[28],_testData[34], false);
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
                 ((IIPAddressListinetListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 4, query1, 90, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[17],_testData[34], false);
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
LEFT JOIN public.ipaddressinetlistd12mi mi ON mi.id = m.ipaddressinetlistd12mi_id
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
                foreach(var batchResult in await ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 61, 57))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[11], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[12], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[13], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[14], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[15], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[16], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[17], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[18], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[19], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[20], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[14],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[15],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[16],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[17],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[18],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[19],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[20],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[21],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[22],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[23],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelBatch(connection, 85, 57))
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[11], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[12], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[13], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[14], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[15], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[16], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[17], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[18], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[19], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[20], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[14],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[15],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[16],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[17],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[18],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[19],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[20],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[21],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[22],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[23],_testData[34], false);
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
                ((IIPAddressListinetListD1)this).SetDbConnectionSelectModelParametrs(cmd, 155);
                var models = await ((IIPAddressListinetListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                IPAddressinetListD1E2M.AssertModel(models[0],_testData[30], false);
                IPAddressinetListD1E2M.AssertModel(models[1],_testData[31], false);
                IPAddressinetListD1E2M.AssertModel(models[2],_testData[32], false);
                IPAddressinetListD1E2M.AssertModel(models[3],_testData[33], false);
                IPAddressinetListD1E2M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressListinetListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressListinetListD1)this).SetDbConnectionSelectModelParametrs(cmd, 110);
                var models =  ((IIPAddressListinetListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                IPAddressinetListD1E2M.AssertModel(models[0],_testData[21], false);
                IPAddressinetListD1E2M.AssertModel(models[1],_testData[22], false);
                IPAddressinetListD1E2M.AssertModel(models[2],_testData[23], false);
                IPAddressinetListD1E2M.AssertModel(models[3],_testData[24], false);
                IPAddressinetListD1E2M.AssertModel(models[4],_testData[25], false);
                IPAddressinetListD1E2M.AssertModel(models[5],_testData[26], false);
                IPAddressinetListD1E2M.AssertModel(models[6],_testData[27], false);
                IPAddressinetListD1E2M.AssertModel(models[7],_testData[28], false);
                IPAddressinetListD1E2M.AssertModel(models[8],_testData[29], false);
                IPAddressinetListD1E2M.AssertModel(models[9],_testData[30], false);
                IPAddressinetListD1E2M.AssertModel(models[10],_testData[31], false);
                IPAddressinetListD1E2M.AssertModel(models[11],_testData[32], false);
                IPAddressinetListD1E2M.AssertModel(models[12],_testData[33], false);
                IPAddressinetListD1E2M.AssertModel(models[13],_testData[34], false);
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
FROM public.binary_ipaddressinetlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD12MIWA)],
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
            queryMapType: typeof(IPAddressinetListD12MIWA),
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
                var importCollection = new List<IPAddressinetListD12MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressListinetListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinetlistd12mi
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
                    IPAddressinetListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetListD12MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressListinetListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinetlistd12mi
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
                    IPAddressinetListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD12MIWA)],
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
            queryMapType: typeof(IPAddressinetListD12MIWA),
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
                var importCollection = new List<IPAddressinetListD12MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressListinetListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinetlistd12mi
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
                    IPAddressinetListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetListD12MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressListinetListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinetlistd12mi
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
                    IPAddressinetListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD12MI)],
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
COPY public.binary_ipaddressinetlistd12mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(IPAddressinetListD12MI),
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
                var importCollection = new List<IPAddressinetListD12MI>(2);
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
                    IPAddressinetListD12MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetListD12MI>(2);
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
                    IPAddressinetListD12MI.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD12MIWA)],
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
COPY public.binary_ipaddressinetlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(IPAddressinetListD12MIWA),
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
                var importCollection = new List<IPAddressinetListD12MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetListD12MIWA
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
                    IPAddressinetListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetListD12MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetListD12MIWA
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
                    IPAddressinetListD12MIWA.AssertModel(actual, expect, false);
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
ipaddressinetlistd12mi_id,
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
LEFT JOIN public.binary_ipaddressinetlistd12mi mi ON mi.id = m.ipaddressinetlistd12mi_id
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
    ipaddressinetlistd12mi_id,
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
            queryMapTypes: [typeof(IPAddressinetListD12MIWA), typeof(IPAddressinetListD12MIWA)],
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
                var models1 = new List<IPAddressinetListD12MIWA>();
                var models2 = new List<IPAddressinetListD12MIWA>();
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
    FROM public.binary_ipaddressinetlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetListD12MIWA>();
                var models2 = new List<IPAddressinetListD12MIWA>();
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
    FROM public.binary_ipaddressinetlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD12MIWA)],
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
COPY public.binary_ipaddressinetlistd12mi
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
                    IPAddressinetListD12MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_ipaddressinetlistd12mi
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
                    IPAddressinetListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD12MIWA), typeof(IPAddressinetListD12MIWA)],
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
                var models1 = new List<IPAddressinetListD12MIWA>();
                var models2 = new List<IPAddressinetListD12MIWA>();
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
    FROM public.binary_ipaddressinetlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetListD12MIWA>();
                var models2 = new List<IPAddressinetListD12MIWA>();
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
    FROM public.binary_ipaddressinetlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD12MIWA)],
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
COPY public.binary_ipaddressinetlistd12mi
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
                    IPAddressinetListD12MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_ipaddressinetlistd12mi
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
                    IPAddressinetListD12MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_ipaddressinetlistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD12MI), typeof(IPAddressinetListD12MI)],
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
                var models1 = new List<IPAddressinetListD12MI>();
                var models2 = new List<IPAddressinetListD12MI>();
                await ((IIPAddressListinetListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetListD12MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetListD12MI>();
                var models2 = new List<IPAddressinetListD12MI>();
                ((IIPAddressListinetListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetListD12MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetlistd12mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD12MI)],
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
                    IPAddressinetListD12MI.AssertModel(model, expectedModel, false);
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
                    IPAddressinetListD12MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_ipaddressinetlistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD12MIWA), typeof(IPAddressinetListD12MIWA)],
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
                var models1 = new List<IPAddressinetListD12MIWA>();
                var models2 = new List<IPAddressinetListD12MIWA>();
                await ((IIPAddressListinetListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetListD12MIWA>();
                var models2 = new List<IPAddressinetListD12MIWA>();
                ((IIPAddressListinetListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetlistd12mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(IPAddressinetListD12MIWA)],
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
                    IPAddressinetListD12MIWA.AssertModel(model, expectedModel, false);
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
                    IPAddressinetListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

