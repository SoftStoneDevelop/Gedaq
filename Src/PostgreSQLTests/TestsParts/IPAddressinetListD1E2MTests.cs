

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
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("92.219.129.96"),

System.Net.IPAddress.Parse("162.209.48.207"),

System.Net.IPAddress.Parse("209.46.198.44"),

System.Net.IPAddress.Parse("98.73.129.111"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("100.154.2.45"),

System.Net.IPAddress.Parse("123.251.158.220"),

System.Net.IPAddress.Parse("134.54.92.148"),

System.Net.IPAddress.Parse("95.183.222.68"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("224.179.38.236"),

System.Net.IPAddress.Parse("241.253.178.71"),

System.Net.IPAddress.Parse("99.18.19.184"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("176.170.74.237"),

System.Net.IPAddress.Parse("110.89.198.136"),

System.Net.IPAddress.Parse("208.124.173.76"),

System.Net.IPAddress.Parse("223.78.147.32"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("158.197.74.84"),

System.Net.IPAddress.Parse("205.79.200.182"),

System.Net.IPAddress.Parse("209.80.178.166"),

System.Net.IPAddress.Parse("175.36.176.30"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("137.180.229.119"),

System.Net.IPAddress.Parse("62.73.100.68"),

System.Net.IPAddress.Parse("159.200.209.158"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("210.45.61.201"),

System.Net.IPAddress.Parse("46.173.22.126"),

System.Net.IPAddress.Parse("130.0.187.132"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("54.112.48.213"),

System.Net.IPAddress.Parse("111.204.2.171"),

System.Net.IPAddress.Parse("94.200.61.184"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("63.25.56.103"),

System.Net.IPAddress.Parse("134.216.224.221"),

System.Net.IPAddress.Parse("1.197.223.96"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("10.110.220.185"),

System.Net.IPAddress.Parse("128.10.103.57"),

System.Net.IPAddress.Parse("26.179.5.39"),

System.Net.IPAddress.Parse("220.122.122.56"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("199.169.151.34"),

System.Net.IPAddress.Parse("112.126.184.100"),

System.Net.IPAddress.Parse("29.143.121.107"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("158.176.95.119"),

System.Net.IPAddress.Parse("210.111.170.254"),

System.Net.IPAddress.Parse("211.145.222.21"),

System.Net.IPAddress.Parse("154.215.134.117"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("55.210.135.236"),

System.Net.IPAddress.Parse("202.20.220.188"),

System.Net.IPAddress.Parse("163.29.208.208"),

System.Net.IPAddress.Parse("122.55.214.210"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("224.178.57.26"),

System.Net.IPAddress.Parse("92.111.123.190"),

System.Net.IPAddress.Parse("243.92.142.84"),

System.Net.IPAddress.Parse("186.82.98.244"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("208.231.204.31"),

System.Net.IPAddress.Parse("105.85.189.246"),

System.Net.IPAddress.Parse("170.92.246.110"),

System.Net.IPAddress.Parse("203.8.19.219"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("15.200.187.145"),

System.Net.IPAddress.Parse("68.242.20.211"),

System.Net.IPAddress.Parse("17.115.170.249"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("105.53.63.55"),

System.Net.IPAddress.Parse("143.116.141.31"),

System.Net.IPAddress.Parse("205.248.146.203"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("34.81.16.94"),

System.Net.IPAddress.Parse("190.132.8.166"),

System.Net.IPAddress.Parse("154.136.132.200"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("93.49.218.115"),

System.Net.IPAddress.Parse("136.183.204.50"),

System.Net.IPAddress.Parse("73.128.42.141"),

System.Net.IPAddress.Parse("71.171.120.237"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("164.37.186.101"),

System.Net.IPAddress.Parse("187.81.194.186"),

System.Net.IPAddress.Parse("68.99.159.135"),

System.Net.IPAddress.Parse("213.205.74.92"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("182.225.27.160"),

System.Net.IPAddress.Parse("95.166.163.167"),

System.Net.IPAddress.Parse("54.92.189.149"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("31.10.140.143"),

System.Net.IPAddress.Parse("140.163.138.25"),

System.Net.IPAddress.Parse("199.141.35.171"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("7.250.124.128"),

System.Net.IPAddress.Parse("46.187.237.84"),

System.Net.IPAddress.Parse("80.56.202.237"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("182.154.90.220"),

System.Net.IPAddress.Parse("93.103.157.104"),

System.Net.IPAddress.Parse("223.190.75.123"),

System.Net.IPAddress.Parse("193.245.168.56"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("96.48.234.42"),

System.Net.IPAddress.Parse("139.193.13.17"),

System.Net.IPAddress.Parse("27.55.228.187"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("140.147.51.20"),

System.Net.IPAddress.Parse("134.7.173.18"),

System.Net.IPAddress.Parse("32.142.139.88"),

System.Net.IPAddress.Parse("220.168.253.207"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("148.27.82.170"),

System.Net.IPAddress.Parse("202.110.154.56"),

System.Net.IPAddress.Parse("169.56.85.204"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("166.154.147.57"),

System.Net.IPAddress.Parse("58.163.2.110"),

System.Net.IPAddress.Parse("25.78.226.253"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("78.239.91.170"),

System.Net.IPAddress.Parse("130.114.215.13"),

System.Net.IPAddress.Parse("6.172.45.116"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("155.65.129.103"),

System.Net.IPAddress.Parse("253.153.84.208"),

System.Net.IPAddress.Parse("186.119.122.122"),

System.Net.IPAddress.Parse("238.168.192.192"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("252.94.100.196"),

System.Net.IPAddress.Parse("191.181.156.124"),

System.Net.IPAddress.Parse("119.245.74.110"),

System.Net.IPAddress.Parse("172.82.235.38"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("120.87.0.238"),

System.Net.IPAddress.Parse("84.151.208.170"),

System.Net.IPAddress.Parse("108.145.204.182"),

System.Net.IPAddress.Parse("245.12.127.209"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("104.76.45.175"),

System.Net.IPAddress.Parse("7.107.61.249"),

System.Net.IPAddress.Parse("186.223.181.128"),

System.Net.IPAddress.Parse("81.158.105.6"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("164.181.157.61"),

System.Net.IPAddress.Parse("30.82.26.34"),

System.Net.IPAddress.Parse("230.198.13.123"),

System.Net.IPAddress.Parse("232.34.144.120"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("37.131.79.80"),

System.Net.IPAddress.Parse("179.94.54.89"),

System.Net.IPAddress.Parse("171.133.5.140"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("111.153.107.197"),

System.Net.IPAddress.Parse("211.50.71.203"),

System.Net.IPAddress.Parse("249.171.34.235"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("148.44.34.15"),

System.Net.IPAddress.Parse("169.185.102.32"),

System.Net.IPAddress.Parse("93.52.96.225"),

System.Net.IPAddress.Parse("222.149.71.243"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("158.215.40.22"),

System.Net.IPAddress.Parse("71.201.244.187"),

System.Net.IPAddress.Parse("144.64.203.19"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("222.173.164.172"),

System.Net.IPAddress.Parse("9.107.2.133"),

System.Net.IPAddress.Parse("153.174.178.103"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("138.177.74.113"),

System.Net.IPAddress.Parse("4.18.48.34"),

System.Net.IPAddress.Parse("223.83.98.112"),

System.Net.IPAddress.Parse("99.254.43.133"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("104.204.179.173"),

System.Net.IPAddress.Parse("107.122.254.226"),

System.Net.IPAddress.Parse("55.13.248.216"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("244.51.147.175"),

System.Net.IPAddress.Parse("182.162.214.232"),

System.Net.IPAddress.Parse("26.39.221.31"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("93.246.196.34"),

System.Net.IPAddress.Parse("83.23.29.177"),

System.Net.IPAddress.Parse("224.78.234.74"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("138.215.175.113"),

System.Net.IPAddress.Parse("87.146.130.128"),

System.Net.IPAddress.Parse("167.53.143.85"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("156.251.222.90"),

System.Net.IPAddress.Parse("108.41.64.201"),

System.Net.IPAddress.Parse("229.247.207.220"),

System.Net.IPAddress.Parse("166.191.96.71"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("28.195.165.120"),

System.Net.IPAddress.Parse("180.90.180.95"),

System.Net.IPAddress.Parse("59.164.197.248"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("221.12.123.89"),

System.Net.IPAddress.Parse("89.37.209.31"),

System.Net.IPAddress.Parse("182.157.100.147"),

System.Net.IPAddress.Parse("244.48.81.184"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("67.83.80.72"),

System.Net.IPAddress.Parse("116.230.147.35"),

System.Net.IPAddress.Parse("27.120.104.178"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("239.44.127.81"),

System.Net.IPAddress.Parse("8.32.183.162"),

System.Net.IPAddress.Parse("37.79.132.119"),

System.Net.IPAddress.Parse("50.51.213.173"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("239.133.143.21"),

System.Net.IPAddress.Parse("147.219.224.222"),

System.Net.IPAddress.Parse("190.22.231.172"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("163.161.216.23"),

System.Net.IPAddress.Parse("169.198.217.2"),

System.Net.IPAddress.Parse("128.228.214.196"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("197.69.14.185"),

System.Net.IPAddress.Parse("235.184.61.187"),

System.Net.IPAddress.Parse("235.18.138.245"),

System.Net.IPAddress.Parse("139.84.98.163"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("197.73.21.217"),

System.Net.IPAddress.Parse("203.11.114.160"),

System.Net.IPAddress.Parse("133.119.173.19"),

System.Net.IPAddress.Parse("189.46.216.118"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("135.219.64.131"),

System.Net.IPAddress.Parse("175.174.153.5"),

System.Net.IPAddress.Parse("30.98.35.217"),

System.Net.IPAddress.Parse("92.220.165.210"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("218.11.140.104"),

System.Net.IPAddress.Parse("167.182.94.90"),

System.Net.IPAddress.Parse("80.41.136.132"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("228.179.218.106"),

System.Net.IPAddress.Parse("144.194.183.31"),

System.Net.IPAddress.Parse("220.197.15.179"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("218.90.31.195"),

System.Net.IPAddress.Parse("189.164.13.220"),

System.Net.IPAddress.Parse("55.36.115.41"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("14.78.167.186"),

System.Net.IPAddress.Parse("223.142.17.190"),

System.Net.IPAddress.Parse("118.23.32.6"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("146.107.223.254"),

System.Net.IPAddress.Parse("185.200.29.108"),

System.Net.IPAddress.Parse("8.118.129.92"),

System.Net.IPAddress.Parse("172.64.37.199"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("105.191.112.120"),

System.Net.IPAddress.Parse("228.169.252.231"),

System.Net.IPAddress.Parse("15.38.214.99"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("184.165.100.176"),

System.Net.IPAddress.Parse("109.110.187.189"),

System.Net.IPAddress.Parse("116.194.191.135"),

System.Net.IPAddress.Parse("57.183.80.83"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("222.49.178.0"),

System.Net.IPAddress.Parse("127.207.242.222"),

System.Net.IPAddress.Parse("108.146.184.21"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("139.50.171.174"),

System.Net.IPAddress.Parse("9.232.71.116"),

System.Net.IPAddress.Parse("70.148.207.5"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("250.104.17.12"),

System.Net.IPAddress.Parse("132.246.3.207"),

System.Net.IPAddress.Parse("166.145.198.191"),

System.Net.IPAddress.Parse("175.171.217.43"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("128.154.225.126"),

System.Net.IPAddress.Parse("94.84.232.201"),

System.Net.IPAddress.Parse("26.239.207.193"),

System.Net.IPAddress.Parse("192.65.140.139"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("60.145.12.1"),

System.Net.IPAddress.Parse("150.186.201.77"),

System.Net.IPAddress.Parse("184.231.211.127"),

System.Net.IPAddress.Parse("239.82.50.229"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("38.130.54.73"),

System.Net.IPAddress.Parse("157.168.131.98"),

System.Net.IPAddress.Parse("72.115.244.15"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("155.29.87.125"),

System.Net.IPAddress.Parse("111.149.10.31"),

System.Net.IPAddress.Parse("107.124.210.190"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("126.81.25.127"),

System.Net.IPAddress.Parse("0.58.211.3"),

System.Net.IPAddress.Parse("79.55.73.53"),

System.Net.IPAddress.Parse("68.240.122.14"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("34.206.51.160"),

System.Net.IPAddress.Parse("117.97.5.233"),

System.Net.IPAddress.Parse("115.166.176.69"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("107.225.11.86"),

System.Net.IPAddress.Parse("248.2.187.221"),

System.Net.IPAddress.Parse("244.31.119.7"),

System.Net.IPAddress.Parse("43.199.231.195"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("22.128.30.209"),

System.Net.IPAddress.Parse("123.177.192.187"),

System.Net.IPAddress.Parse("217.88.30.11"),

System.Net.IPAddress.Parse("77.79.52.239"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("139.79.6.59"),

System.Net.IPAddress.Parse("126.219.23.101"),

System.Net.IPAddress.Parse("29.37.32.53"),

},
},
            new IPAddressinetListD1E2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("8.43.181.81"),

System.Net.IPAddress.Parse("194.65.55.41"),

System.Net.IPAddress.Parse("40.68.66.228"),

System.Net.IPAddress.Parse("19.226.51.189"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("89.133.105.194"),

System.Net.IPAddress.Parse("27.147.210.166"),

System.Net.IPAddress.Parse("225.101.27.48"),

System.Net.IPAddress.Parse("243.139.73.50"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("94.39.253.89"),

System.Net.IPAddress.Parse("236.48.104.228"),

System.Net.IPAddress.Parse("6.132.244.58"),

System.Net.IPAddress.Parse("134.251.95.74"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("156.105.67.60"),

System.Net.IPAddress.Parse("105.185.37.24"),

System.Net.IPAddress.Parse("37.146.18.253"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("180.174.243.164"),

System.Net.IPAddress.Parse("60.146.93.20"),

System.Net.IPAddress.Parse("192.30.53.29"),

System.Net.IPAddress.Parse("216.100.71.189"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("223.130.174.12"),

System.Net.IPAddress.Parse("95.216.59.167"),

System.Net.IPAddress.Parse("136.6.242.151"),

System.Net.IPAddress.Parse("62.127.90.40"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("27.95.14.102"),

System.Net.IPAddress.Parse("15.102.138.153"),

System.Net.IPAddress.Parse("202.111.181.250"),

},
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("213.100.196.49"),

System.Net.IPAddress.Parse("75.27.1.16"),

System.Net.IPAddress.Parse("12.133.36.229"),

},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("87.235.241.22"),

System.Net.IPAddress.Parse("232.130.19.224"),

System.Net.IPAddress.Parse("47.235.119.199"),

System.Net.IPAddress.Parse("59.81.72.204"),

},
    ModelInner = new IPAddressinetListD1E2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("108.188.47.189"),

System.Net.IPAddress.Parse("121.0.96.33"),

System.Net.IPAddress.Parse("104.225.86.211"),

System.Net.IPAddress.Parse("225.253.221.38"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetListD1E2M
{
    Id = 185,
    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("87.90.251.26"),

System.Net.IPAddress.Parse("185.193.85.218"),

System.Net.IPAddress.Parse("217.40.187.212"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("244.45.47.84"),

System.Net.IPAddress.Parse("214.107.40.239"),

System.Net.IPAddress.Parse("128.110.10.73"),

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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
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
                parametr2.Value = 112;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[34], false);
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
                parametr1.Value = 8;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 67;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
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
                parametr1.Value = 65;
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[26],_testData[34], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[1], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[2], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[3], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[4], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[5], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[6], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[7], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[8], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[9], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[10], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[11], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[12], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[13], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[14], false);
                        IPAddressinetListD1E2M.AssertModel(models[14],_testData[15], false);
                        IPAddressinetListD1E2M.AssertModel(models[15],_testData[16], false);
                        IPAddressinetListD1E2M.AssertModel(models[16],_testData[17], false);
                        IPAddressinetListD1E2M.AssertModel(models[17],_testData[18], false);
                        IPAddressinetListD1E2M.AssertModel(models[18],_testData[19], false);
                        IPAddressinetListD1E2M.AssertModel(models[19],_testData[20], false);
                        IPAddressinetListD1E2M.AssertModel(models[20],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[21],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[22],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[23],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[24],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[25],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[26],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[27],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[28],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[29],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[30],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[31],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[32],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[8], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[9], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[10], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[11], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[12], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[13], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[14], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[15], false);
                        IPAddressinetListD1E2M.AssertModel(models[8],_testData[16], false);
                        IPAddressinetListD1E2M.AssertModel(models[9],_testData[17], false);
                        IPAddressinetListD1E2M.AssertModel(models[10],_testData[18], false);
                        IPAddressinetListD1E2M.AssertModel(models[11],_testData[19], false);
                        IPAddressinetListD1E2M.AssertModel(models[12],_testData[20], false);
                        IPAddressinetListD1E2M.AssertModel(models[13],_testData[21], false);
                        IPAddressinetListD1E2M.AssertModel(models[14],_testData[22], false);
                        IPAddressinetListD1E2M.AssertModel(models[15],_testData[23], false);
                        IPAddressinetListD1E2M.AssertModel(models[16],_testData[24], false);
                        IPAddressinetListD1E2M.AssertModel(models[17],_testData[25], false);
                        IPAddressinetListD1E2M.AssertModel(models[18],_testData[26], false);
                        IPAddressinetListD1E2M.AssertModel(models[19],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[20],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[21],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[22],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[23],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[24],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[25],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                await ((IIPAddressListinetListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 24, query1, 161, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[34], false);
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
                await ((IIPAddressListinetListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 44, query1, 161, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
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
                 ((IIPAddressListinetListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 78, query1, 148, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
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
                 ((IIPAddressListinetListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 8, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressListinetListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 99, query1, 95, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[15],_testData[34], false);
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
                await ((IIPAddressListinetListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 65, query1, 135, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressListinetListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 78, query1, 99, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatIPAddressinetListD1E2M.AssertModel(models[0],_testData[20], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[1],_testData[21], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[2],_testData[22], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[3],_testData[23], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[4],_testData[24], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[5],_testData[25], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[6],_testData[26], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[7],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[8],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[9],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[10],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[11],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[12],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[13],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(models[14],_testData[34], false);
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
                 ((IIPAddressListinetListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 139, query1, 113, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatIPAddressinetListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 139, 72))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[27], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[28], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[6],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[7],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressListinetListD1)this).DbConnectionSTSelectModelBatch(connection, 24, 152))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        IPAddressinetListD1E2M.AssertModel(models[0],_testData[29], false);
                        IPAddressinetListD1E2M.AssertModel(models[1],_testData[30], false);
                        IPAddressinetListD1E2M.AssertModel(models[2],_testData[31], false);
                        IPAddressinetListD1E2M.AssertModel(models[3],_testData[32], false);
                        IPAddressinetListD1E2M.AssertModel(models[4],_testData[33], false);
                        IPAddressinetListD1E2M.AssertModel(models[5],_testData[34], false);
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
                ((IIPAddressListinetListD1)this).SetDbConnectionSelectModelParametrs(cmd, 135);
                var models = await ((IIPAddressListinetListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressListinetListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressListinetListD1)this).SetDbConnectionSelectModelParametrs(cmd, 72);
                var models =  ((IIPAddressListinetListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

