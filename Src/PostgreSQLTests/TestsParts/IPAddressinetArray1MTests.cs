

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
    internal partial interface IIPAddressArrayinetArray
    {
    }
    
    internal partial class IPAddressArrayinetArray : IIPAddressArrayinetArray
    {


#region TestData

        private readonly IPAddressinetArray1M[] _testData = new IPAddressinetArray1M[]
        {
            new IPAddressinetArray1M
{
    Id = 4,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("202.67.99.132"),
System.Net.IPAddress.Parse("96.237.52.8"),
System.Net.IPAddress.Parse("133.235.41.90"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 12,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("76.167.134.18"),
System.Net.IPAddress.Parse("47.164.198.226"),
System.Net.IPAddress.Parse("248.162.252.218"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 5,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("68.158.170.172"),
System.Net.IPAddress.Parse("170.1.116.54"),
System.Net.IPAddress.Parse("1.136.99.180"),
System.Net.IPAddress.Parse("118.36.74.20"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("25.171.31.204"),
System.Net.IPAddress.Parse("120.122.66.233"),
System.Net.IPAddress.Parse("140.3.234.247"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("2.104.81.233"),
System.Net.IPAddress.Parse("74.222.103.218"),
System.Net.IPAddress.Parse("129.191.2.120"),
},
},
            new IPAddressinetArray1M
{
    Id = 16,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("66.241.122.54"),
System.Net.IPAddress.Parse("206.139.4.37"),
System.Net.IPAddress.Parse("63.244.223.173"),
System.Net.IPAddress.Parse("158.101.39.216"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.157.216.210"),
System.Net.IPAddress.Parse("90.25.243.222"),
System.Net.IPAddress.Parse("16.98.194.92"),
System.Net.IPAddress.Parse("237.190.101.158"),
},
},
            new IPAddressinetArray1M
{
    Id = 17,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("125.178.3.178"),
System.Net.IPAddress.Parse("152.53.137.96"),
System.Net.IPAddress.Parse("149.128.35.198"),
System.Net.IPAddress.Parse("183.142.7.10"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 9,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("144.134.80.69"),
System.Net.IPAddress.Parse("72.44.235.32"),
System.Net.IPAddress.Parse("253.150.200.12"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 22,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("69.242.90.251"),
System.Net.IPAddress.Parse("120.163.229.236"),
System.Net.IPAddress.Parse("24.92.123.178"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 27,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("30.95.176.104"),
System.Net.IPAddress.Parse("27.143.2.204"),
System.Net.IPAddress.Parse("149.154.101.10"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 13,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.144.171.4"),
System.Net.IPAddress.Parse("114.29.125.254"),
System.Net.IPAddress.Parse("177.234.177.207"),
System.Net.IPAddress.Parse("76.101.215.132"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("4.21.86.173"),
System.Net.IPAddress.Parse("148.205.17.142"),
System.Net.IPAddress.Parse("63.59.223.149"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 32,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("149.133.1.237"),
System.Net.IPAddress.Parse("158.195.182.178"),
System.Net.IPAddress.Parse("191.97.57.149"),
System.Net.IPAddress.Parse("20.203.89.234"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 35,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("216.185.225.97"),
System.Net.IPAddress.Parse("51.55.191.194"),
System.Net.IPAddress.Parse("85.138.58.224"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 22,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("239.101.44.102"),
System.Net.IPAddress.Parse("82.201.227.72"),
System.Net.IPAddress.Parse("158.235.108.236"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("3.185.170.244"),
System.Net.IPAddress.Parse("191.245.246.86"),
System.Net.IPAddress.Parse("143.103.124.237"),
},
},
            new IPAddressinetArray1M
{
    Id = 44,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("147.210.249.172"),
System.Net.IPAddress.Parse("139.151.112.92"),
System.Net.IPAddress.Parse("69.32.210.169"),
System.Net.IPAddress.Parse("25.243.246.47"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 46,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("25.166.232.93"),
System.Net.IPAddress.Parse("142.41.233.47"),
System.Net.IPAddress.Parse("247.158.237.211"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 25,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("183.50.119.33"),
System.Net.IPAddress.Parse("45.198.2.88"),
System.Net.IPAddress.Parse("62.162.203.163"),
System.Net.IPAddress.Parse("157.1.127.56"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("213.64.145.136"),
System.Net.IPAddress.Parse("165.122.115.110"),
System.Net.IPAddress.Parse("184.196.66.3"),
System.Net.IPAddress.Parse("40.43.39.55"),
},
},
            new IPAddressinetArray1M
{
    Id = 51,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("41.61.63.60"),
System.Net.IPAddress.Parse("107.111.123.92"),
System.Net.IPAddress.Parse("220.104.249.211"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("183.247.101.29"),
System.Net.IPAddress.Parse("128.232.0.203"),
System.Net.IPAddress.Parse("145.82.205.231"),
},
},
            new IPAddressinetArray1M
{
    Id = 57,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("141.155.224.211"),
System.Net.IPAddress.Parse("57.127.243.50"),
System.Net.IPAddress.Parse("156.138.224.115"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 33,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("127.144.27.27"),
System.Net.IPAddress.Parse("217.69.85.63"),
System.Net.IPAddress.Parse("47.192.228.158"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("36.206.174.113"),
System.Net.IPAddress.Parse("215.62.13.184"),
System.Net.IPAddress.Parse("146.35.2.129"),
System.Net.IPAddress.Parse("102.238.127.137"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("197.77.181.76"),
System.Net.IPAddress.Parse("132.36.237.37"),
System.Net.IPAddress.Parse("246.118.32.123"),
},
},
            new IPAddressinetArray1M
{
    Id = 63,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("4.220.153.19"),
System.Net.IPAddress.Parse("228.56.62.0"),
System.Net.IPAddress.Parse("144.43.102.171"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("68.135.28.224"),
System.Net.IPAddress.Parse("125.6.56.113"),
System.Net.IPAddress.Parse("120.78.127.253"),
},
},
            new IPAddressinetArray1M
{
    Id = 70,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("41.118.173.189"),
System.Net.IPAddress.Parse("103.30.150.22"),
System.Net.IPAddress.Parse("9.163.56.30"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 35,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("233.165.153.21"),
System.Net.IPAddress.Parse("232.236.84.184"),
System.Net.IPAddress.Parse("64.14.57.77"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("147.16.44.171"),
System.Net.IPAddress.Parse("20.141.74.105"),
System.Net.IPAddress.Parse("152.91.237.251"),
},
},
            new IPAddressinetArray1M
{
    Id = 78,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("191.76.218.114"),
System.Net.IPAddress.Parse("254.49.130.14"),
System.Net.IPAddress.Parse("129.179.184.155"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("179.181.82.153"),
System.Net.IPAddress.Parse("140.65.78.167"),
System.Net.IPAddress.Parse("196.128.52.178"),
},
},
            new IPAddressinetArray1M
{
    Id = 87,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("23.242.183.216"),
System.Net.IPAddress.Parse("48.13.175.49"),
System.Net.IPAddress.Parse("183.145.139.114"),
System.Net.IPAddress.Parse("20.246.80.90"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 44,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("8.13.244.100"),
System.Net.IPAddress.Parse("166.181.155.227"),
System.Net.IPAddress.Parse("248.82.100.107"),
System.Net.IPAddress.Parse("163.77.213.203"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("171.240.191.43"),
System.Net.IPAddress.Parse("22.81.250.5"),
System.Net.IPAddress.Parse("177.92.140.67"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("191.162.116.65"),
System.Net.IPAddress.Parse("154.0.124.32"),
System.Net.IPAddress.Parse("84.203.92.223"),
System.Net.IPAddress.Parse("19.163.79.46"),
},
},
            new IPAddressinetArray1M
{
    Id = 89,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("92.194.175.121"),
System.Net.IPAddress.Parse("108.2.138.73"),
System.Net.IPAddress.Parse("122.105.121.199"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 97,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("81.58.113.36"),
System.Net.IPAddress.Parse("27.204.159.82"),
System.Net.IPAddress.Parse("31.88.171.147"),
System.Net.IPAddress.Parse("253.195.250.182"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 52,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("153.195.202.53"),
System.Net.IPAddress.Parse("3.22.184.115"),
System.Net.IPAddress.Parse("241.100.33.25"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 106,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("140.126.247.93"),
System.Net.IPAddress.Parse("85.21.12.5"),
System.Net.IPAddress.Parse("13.180.10.137"),
System.Net.IPAddress.Parse("12.250.219.119"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 108,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("47.91.107.122"),
System.Net.IPAddress.Parse("205.210.75.230"),
System.Net.IPAddress.Parse("44.202.212.41"),
System.Net.IPAddress.Parse("209.159.24.55"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 58,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("154.101.192.142"),
System.Net.IPAddress.Parse("29.109.66.5"),
System.Net.IPAddress.Parse("150.0.157.68"),
System.Net.IPAddress.Parse("244.2.153.207"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("186.214.204.38"),
System.Net.IPAddress.Parse("40.35.28.0"),
System.Net.IPAddress.Parse("70.47.130.43"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("74.71.250.253"),
System.Net.IPAddress.Parse("20.67.162.75"),
System.Net.IPAddress.Parse("231.166.128.199"),
},
},
            new IPAddressinetArray1M
{
    Id = 112,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("251.126.100.164"),
System.Net.IPAddress.Parse("205.194.190.104"),
System.Net.IPAddress.Parse("71.228.2.156"),
System.Net.IPAddress.Parse("4.214.11.37"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.171.249.190"),
System.Net.IPAddress.Parse("210.94.239.145"),
System.Net.IPAddress.Parse("179.218.88.119"),
},
},
            new IPAddressinetArray1M
{
    Id = 119,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("109.23.247.86"),
System.Net.IPAddress.Parse("217.38.227.244"),
System.Net.IPAddress.Parse("30.94.217.22"),
System.Net.IPAddress.Parse("208.124.231.156"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 60,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("149.45.220.73"),
System.Net.IPAddress.Parse("186.116.117.200"),
System.Net.IPAddress.Parse("78.200.105.122"),
System.Net.IPAddress.Parse("33.187.206.233"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("217.114.126.152"),
System.Net.IPAddress.Parse("129.77.220.161"),
System.Net.IPAddress.Parse("110.174.47.95"),
System.Net.IPAddress.Parse("39.218.245.27"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 124,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("131.225.165.230"),
System.Net.IPAddress.Parse("19.241.185.55"),
System.Net.IPAddress.Parse("156.148.182.221"),
System.Net.IPAddress.Parse("106.124.101.116"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 131,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("142.76.212.15"),
System.Net.IPAddress.Parse("199.41.84.112"),
System.Net.IPAddress.Parse("188.136.194.185"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 68,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("133.72.11.3"),
System.Net.IPAddress.Parse("126.74.15.87"),
System.Net.IPAddress.Parse("170.220.12.251"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("174.121.222.129"),
System.Net.IPAddress.Parse("166.136.90.59"),
System.Net.IPAddress.Parse("99.61.91.208"),
System.Net.IPAddress.Parse("90.148.169.250"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("76.134.74.146"),
System.Net.IPAddress.Parse("185.240.31.107"),
System.Net.IPAddress.Parse("138.125.73.210"),
System.Net.IPAddress.Parse("95.162.36.231"),
},
},
            new IPAddressinetArray1M
{
    Id = 137,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("18.180.163.155"),
System.Net.IPAddress.Parse("149.192.35.13"),
System.Net.IPAddress.Parse("93.123.179.222"),
System.Net.IPAddress.Parse("30.221.196.209"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("208.201.224.118"),
System.Net.IPAddress.Parse("34.85.50.168"),
System.Net.IPAddress.Parse("187.49.65.254"),
System.Net.IPAddress.Parse("175.234.132.120"),
},
},
            new IPAddressinetArray1M
{
    Id = 146,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("129.117.192.253"),
System.Net.IPAddress.Parse("195.200.137.47"),
System.Net.IPAddress.Parse("218.99.157.233"),
System.Net.IPAddress.Parse("188.156.98.151"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 72,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.101.163.128"),
System.Net.IPAddress.Parse("0.153.236.60"),
System.Net.IPAddress.Parse("85.163.135.216"),
System.Net.IPAddress.Parse("47.205.18.254"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("227.254.2.140"),
System.Net.IPAddress.Parse("215.131.53.219"),
System.Net.IPAddress.Parse("195.16.36.216"),
System.Net.IPAddress.Parse("110.18.87.90"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 153,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("26.138.193.70"),
System.Net.IPAddress.Parse("119.209.228.37"),
System.Net.IPAddress.Parse("3.82.151.238"),
System.Net.IPAddress.Parse("41.198.145.42"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("252.148.63.89"),
System.Net.IPAddress.Parse("110.173.135.26"),
System.Net.IPAddress.Parse("126.237.184.159"),
System.Net.IPAddress.Parse("249.133.241.141"),
},
},
            new IPAddressinetArray1M
{
    Id = 162,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("32.189.38.152"),
System.Net.IPAddress.Parse("200.64.240.157"),
System.Net.IPAddress.Parse("61.142.40.76"),
System.Net.IPAddress.Parse("1.154.117.174"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 73,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("215.194.110.101"),
System.Net.IPAddress.Parse("11.55.32.197"),
System.Net.IPAddress.Parse("226.220.2.252"),
System.Net.IPAddress.Parse("108.175.161.137"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 163,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.196.113.200"),
System.Net.IPAddress.Parse("19.196.8.97"),
System.Net.IPAddress.Parse("88.134.69.228"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.79.119.142"),
System.Net.IPAddress.Parse("113.213.215.121"),
System.Net.IPAddress.Parse("183.253.130.123"),
System.Net.IPAddress.Parse("136.166.12.86"),
},
},
            new IPAddressinetArray1M
{
    Id = 166,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("100.9.237.181"),
System.Net.IPAddress.Parse("199.154.102.208"),
System.Net.IPAddress.Parse("117.123.63.74"),
System.Net.IPAddress.Parse("27.232.198.16"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 81,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("33.110.136.48"),
System.Net.IPAddress.Parse("246.53.159.161"),
System.Net.IPAddress.Parse("222.203.53.224"),
System.Net.IPAddress.Parse("148.212.53.105"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("22.176.100.41"),
System.Net.IPAddress.Parse("28.82.13.232"),
System.Net.IPAddress.Parse("156.1.162.75"),
System.Net.IPAddress.Parse("3.113.52.82"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("193.209.55.143"),
System.Net.IPAddress.Parse("58.108.172.122"),
System.Net.IPAddress.Parse("212.138.97.17"),
},
},
            new IPAddressinetArray1M
{
    Id = 169,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("103.192.51.235"),
System.Net.IPAddress.Parse("70.155.241.224"),
System.Net.IPAddress.Parse("25.148.49.84"),
System.Net.IPAddress.Parse("13.120.17.50"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 178,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("10.171.29.121"),
System.Net.IPAddress.Parse("48.18.188.44"),
System.Net.IPAddress.Parse("23.220.13.151"),
System.Net.IPAddress.Parse("146.131.175.66"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 82,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("81.248.210.164"),
System.Net.IPAddress.Parse("224.220.22.2"),
System.Net.IPAddress.Parse("164.50.88.141"),
System.Net.IPAddress.Parse("128.213.233.200"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 183,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("189.88.225.231"),
System.Net.IPAddress.Parse("218.181.158.132"),
System.Net.IPAddress.Parse("175.53.110.153"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("9.167.7.133"),
System.Net.IPAddress.Parse("59.0.87.2"),
System.Net.IPAddress.Parse("215.71.252.4"),
System.Net.IPAddress.Parse("216.157.153.122"),
},
},
            new IPAddressinetArray1M
{
    Id = 188,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("60.9.222.224"),
System.Net.IPAddress.Parse("137.145.222.204"),
System.Net.IPAddress.Parse("124.91.154.61"),
System.Net.IPAddress.Parse("6.246.137.173"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 91,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("176.133.215.107"),
System.Net.IPAddress.Parse("241.169.113.47"),
System.Net.IPAddress.Parse("18.190.108.142"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("195.25.87.0"),
System.Net.IPAddress.Parse("100.179.0.252"),
System.Net.IPAddress.Parse("202.149.64.131"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 191,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("52.182.24.196"),
System.Net.IPAddress.Parse("54.192.216.65"),
System.Net.IPAddress.Parse("178.205.82.97"),
System.Net.IPAddress.Parse("172.101.57.55"),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray1mi(
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray1mi(
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
            queryMapTypes: [typeof(IPAddressinetArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]), 
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

                changedRows =  ((IIPAddressArrayinetArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IIPAddressArrayinetArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IIPAddressArrayinetArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressArrayinetArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IIPAddressArrayinetArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IIPAddressArrayinetArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray1m(
	id,
    value,
    nullablevalue,
    ipaddressinetarray1mi_id
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
            asPartInterface: typeof(IIPAddressArrayinetArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "ipaddressinetarray1mi_id", 
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
                changedRows =  ((IIPAddressArrayinetArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IIPAddressArrayinetArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IIPAddressArrayinetArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IIPAddressArrayinetArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray1m(
	id,
    value,
    nullablevalue,
    ipaddressinetarray1mi_id
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
    ipaddressinetarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Net.IPAddress[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[]>();
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IIPAddressArrayinetArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[]>();
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IIPAddressArrayinetArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Net.IPAddress[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[]>();
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IIPAddressArrayinetArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[]>();
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IIPAddressArrayinetArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("3.185.170.244"),
System.Net.IPAddress.Parse("191.245.246.86"),
System.Net.IPAddress.Parse("143.103.124.237"),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray1m(
	id,
    value,
    nullablevalue,
    ipaddressinetarray1mi_id
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
    ipaddressinetarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "ipaddressinetarray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Net.IPAddress[] nullable = null;
                nullable =  ((IIPAddressArrayinetArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IIPAddressArrayinetArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("213.64.145.136"),
System.Net.IPAddress.Parse("165.122.115.110"),
System.Net.IPAddress.Parse("184.196.66.3"),
System.Net.IPAddress.Parse("40.43.39.55"),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Net.IPAddress[] nullable = null;
                nullable = await ((IIPAddressArrayinetArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("183.247.101.29"),
System.Net.IPAddress.Parse("128.232.0.203"),
System.Net.IPAddress.Parse("145.82.205.231"),
}));
                nullable = await ((IIPAddressArrayinetArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("197.77.181.76"),
System.Net.IPAddress.Parse("132.36.237.37"),
System.Net.IPAddress.Parse("246.118.32.123"),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetArray1M> models = null;

                models =  ((IIPAddressArrayinetArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IIPAddressArrayinetArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IIPAddressArrayinetArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IIPAddressArrayinetArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetArray1M> models = null;

                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M), typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                ((IIPAddressArrayinetArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IIPAddressArrayinetArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IIPAddressArrayinetArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                var models = await ((IIPAddressArrayinetArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IIPAddressArrayinetArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M), typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                ((IIPAddressArrayinetArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IIPAddressArrayinetArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressArrayinetArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                var models = await ((IIPAddressArrayinetArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IIPAddressArrayinetArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M), typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                await((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 183;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                 ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                 ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 166;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[24],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[25],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[26],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[27],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[28],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                 ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.ipaddressinetarray1m m
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                var models = await((IIPAddressArrayinetArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[3], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[4], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[5], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[6], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[7], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[8], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[9], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[10], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[24],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[25],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[26],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[27],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[28],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[29],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[30],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[34], false);
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
                var models = ((IIPAddressArrayinetArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[6], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[7], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[8], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[9], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[10], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[24],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[25],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[26],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[27],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[7], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[8], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[9], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[10], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[24],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[25],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[26],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M), typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                await((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 17, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 16, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[34], false);
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                 ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 146, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                 ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 108, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 17, query1, 124, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[24],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[25],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[26],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[27],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[28],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[29],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[34], false);
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 108, query1, 166, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 183, query1, 63, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[34], false);
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                 ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 169, query1, 97, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.ipaddressinetarray1m m
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                var models = await((IIPAddressArrayinetArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 124, 78))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[34], false);
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
                var models = ((IIPAddressArrayinetArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatch(connection, 57, 51))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[34], false);
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
                await using var cmd = await ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 169);
                var models = await ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
IPAddressinetArray1M.AssertModel(models[0],_testData[31], false);IPAddressinetArray1M.AssertModel(models[1],_testData[32], false);IPAddressinetArray1M.AssertModel(models[2],_testData[33], false);IPAddressinetArray1M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 166);
                var models =  ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
IPAddressinetArray1M.AssertModel(models[0],_testData[30], false);IPAddressinetArray1M.AssertModel(models[1],_testData[31], false);IPAddressinetArray1M.AssertModel(models[2],_testData[32], false);IPAddressinetArray1M.AssertModel(models[3],_testData[33], false);IPAddressinetArray1M.AssertModel(models[4],_testData[34], false);
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
FROM public.binary_ipaddressinetarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(IPAddressinetArray1MIWA),
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
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressArrayinetArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinetarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IIPAddressArrayinetArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressArrayinetArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinetarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressArrayinetArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(IPAddressinetArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressArrayinetArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinetarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IIPAddressArrayinetArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressArrayinetArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinetarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressArrayinetArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(IPAddressinetArray1MI),
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
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IIPAddressArrayinetArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IIPAddressArrayinetArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IIPAddressArrayinetArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IIPAddressArrayinetArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(IPAddressinetArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressArrayinetArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IIPAddressArrayinetArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressArrayinetArray)this).ImportModelInner(connection, importCollection);
                var models = ((IIPAddressArrayinetArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
ipaddressinetarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(IPAddressinetArray1M),
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
            asPartInterface: typeof(IIPAddressArrayinetArray))]
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
FROM public.binary_ipaddressinetarray1m m
LEFT JOIN public.binary_ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IIPAddressArrayinetArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IIPAddressArrayinetArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    IPAddressinetArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IIPAddressArrayinetArray)this).ImportModel(connection, importCollection);
                var models = ((IIPAddressArrayinetArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    IPAddressinetArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    ipaddressinetarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
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
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IIPAddressArrayinetArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    IPAddressinetArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressArrayinetArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    IPAddressinetArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MIWA), typeof(IPAddressinetArray1MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                var models1 = new List<IPAddressinetArray1MIWA>();
                var models2 = new List<IPAddressinetArray1MIWA>();
                await ((IIPAddressArrayinetArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetArray1MIWA>();
                var models2 = new List<IPAddressinetArray1MIWA>();
                ((IIPAddressArrayinetArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                var models = await ((IIPAddressArrayinetArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_ipaddressinetarray1mi
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
                    IPAddressinetArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressArrayinetArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_ipaddressinetarray1mi
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
                    IPAddressinetArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MIWA), typeof(IPAddressinetArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
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
                var models1 = new List<IPAddressinetArray1MIWA>();
                var models2 = new List<IPAddressinetArray1MIWA>();
                await ((IIPAddressArrayinetArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetArray1MIWA>();
                var models2 = new List<IPAddressinetArray1MIWA>();
                ((IIPAddressArrayinetArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
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
                var models = await ((IIPAddressArrayinetArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_ipaddressinetarray1mi
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
                    IPAddressinetArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressArrayinetArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_ipaddressinetarray1mi
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
                    IPAddressinetArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_ipaddressinetarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MI), typeof(IPAddressinetArray1MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                var models1 = new List<IPAddressinetArray1MI>();
                var models2 = new List<IPAddressinetArray1MI>();
                await ((IIPAddressArrayinetArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetArray1MI>();
                var models2 = new List<IPAddressinetArray1MI>();
                ((IIPAddressArrayinetArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                var models = await ((IIPAddressArrayinetArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressArrayinetArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_ipaddressinetarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MIWA), typeof(IPAddressinetArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
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
                var models1 = new List<IPAddressinetArray1MIWA>();
                var models2 = new List<IPAddressinetArray1MIWA>();
                await ((IIPAddressArrayinetArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetArray1MIWA>();
                var models2 = new List<IPAddressinetArray1MIWA>();
                ((IIPAddressArrayinetArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
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
                var models = await ((IIPAddressArrayinetArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressArrayinetArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

