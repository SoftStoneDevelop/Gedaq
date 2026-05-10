

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
    Id = 9,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("225.122.115.172"),
System.Net.IPAddress.Parse("138.201.24.14"),
System.Net.IPAddress.Parse("250.153.53.76"),
System.Net.IPAddress.Parse("205.201.73.150"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("172.75.84.195"),
System.Net.IPAddress.Parse("60.25.137.206"),
System.Net.IPAddress.Parse("49.252.246.251"),
},
},
            new IPAddressinetArray1M
{
    Id = 16,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("193.45.34.142"),
System.Net.IPAddress.Parse("44.57.61.97"),
System.Net.IPAddress.Parse("247.88.94.216"),
System.Net.IPAddress.Parse("158.163.230.56"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 1,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("18.117.181.132"),
System.Net.IPAddress.Parse("74.226.54.5"),
System.Net.IPAddress.Parse("103.254.131.244"),
System.Net.IPAddress.Parse("192.109.106.213"),
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
System.Net.IPAddress.Parse("223.10.221.124"),
System.Net.IPAddress.Parse("187.146.227.34"),
System.Net.IPAddress.Parse("212.162.121.156"),
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
System.Net.IPAddress.Parse("107.83.250.97"),
System.Net.IPAddress.Parse("172.100.80.40"),
System.Net.IPAddress.Parse("218.236.230.41"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 5,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("104.83.72.227"),
System.Net.IPAddress.Parse("190.12.213.27"),
System.Net.IPAddress.Parse("40.250.234.64"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 32,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("159.80.77.149"),
System.Net.IPAddress.Parse("166.208.60.84"),
System.Net.IPAddress.Parse("66.42.140.225"),
System.Net.IPAddress.Parse("138.175.204.241"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 40,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("52.22.46.230"),
System.Net.IPAddress.Parse("180.143.15.16"),
System.Net.IPAddress.Parse("131.124.203.212"),
System.Net.IPAddress.Parse("175.203.196.232"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 6,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("191.8.14.241"),
System.Net.IPAddress.Parse("24.70.74.169"),
System.Net.IPAddress.Parse("222.52.194.50"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("96.140.36.194"),
System.Net.IPAddress.Parse("22.101.220.124"),
System.Net.IPAddress.Parse("153.25.143.252"),
System.Net.IPAddress.Parse("192.63.20.68"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 44,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("35.232.132.190"),
System.Net.IPAddress.Parse("204.112.122.89"),
System.Net.IPAddress.Parse("213.176.123.229"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 48,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("204.185.27.206"),
System.Net.IPAddress.Parse("44.197.133.191"),
System.Net.IPAddress.Parse("178.103.172.134"),
System.Net.IPAddress.Parse("94.46.139.160"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 11,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("178.195.160.177"),
System.Net.IPAddress.Parse("88.24.235.120"),
System.Net.IPAddress.Parse("186.69.248.66"),
System.Net.IPAddress.Parse("29.202.84.69"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("54.37.84.27"),
System.Net.IPAddress.Parse("151.195.61.83"),
System.Net.IPAddress.Parse("91.147.122.87"),
},
},
            new IPAddressinetArray1M
{
    Id = 52,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("248.142.198.196"),
System.Net.IPAddress.Parse("101.31.235.220"),
System.Net.IPAddress.Parse("91.146.65.80"),
System.Net.IPAddress.Parse("165.206.145.108"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 57,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("36.243.166.186"),
System.Net.IPAddress.Parse("190.23.190.28"),
System.Net.IPAddress.Parse("48.160.48.129"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 18,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("120.245.34.17"),
System.Net.IPAddress.Parse("34.47.26.49"),
System.Net.IPAddress.Parse("23.204.162.30"),
System.Net.IPAddress.Parse("115.13.118.195"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("29.135.30.126"),
System.Net.IPAddress.Parse("140.225.77.95"),
System.Net.IPAddress.Parse("55.120.56.231"),
System.Net.IPAddress.Parse("119.46.178.22"),
},
},
            new IPAddressinetArray1M
{
    Id = 60,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("60.90.8.11"),
System.Net.IPAddress.Parse("242.219.181.163"),
System.Net.IPAddress.Parse("1.172.113.55"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 64,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("209.6.60.49"),
System.Net.IPAddress.Parse("228.217.109.113"),
System.Net.IPAddress.Parse("88.218.72.172"),
System.Net.IPAddress.Parse("23.227.243.91"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 21,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("183.26.90.137"),
System.Net.IPAddress.Parse("75.42.156.143"),
System.Net.IPAddress.Parse("132.184.17.221"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("80.22.154.103"),
System.Net.IPAddress.Parse("35.17.134.7"),
System.Net.IPAddress.Parse("149.51.253.126"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("225.10.25.127"),
System.Net.IPAddress.Parse("230.220.55.33"),
System.Net.IPAddress.Parse("200.25.71.204"),
},
},
            new IPAddressinetArray1M
{
    Id = 71,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("242.96.245.33"),
System.Net.IPAddress.Parse("28.203.147.141"),
System.Net.IPAddress.Parse("186.4.5.193"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("67.172.62.123"),
System.Net.IPAddress.Parse("146.144.153.89"),
System.Net.IPAddress.Parse("131.32.111.169"),
},
},
            new IPAddressinetArray1M
{
    Id = 80,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("150.58.138.29"),
System.Net.IPAddress.Parse("35.148.142.227"),
System.Net.IPAddress.Parse("178.178.121.60"),
System.Net.IPAddress.Parse("32.240.112.93"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 29,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("247.252.235.88"),
System.Net.IPAddress.Parse("15.36.237.182"),
System.Net.IPAddress.Parse("41.130.209.32"),
System.Net.IPAddress.Parse("247.251.199.239"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("240.167.46.112"),
System.Net.IPAddress.Parse("96.212.209.254"),
System.Net.IPAddress.Parse("165.40.184.21"),
},
},
            new IPAddressinetArray1M
{
    Id = 84,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("78.73.209.193"),
System.Net.IPAddress.Parse("230.26.222.124"),
System.Net.IPAddress.Parse("209.111.243.24"),
System.Net.IPAddress.Parse("65.92.140.177"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("166.97.233.156"),
System.Net.IPAddress.Parse("78.112.51.43"),
System.Net.IPAddress.Parse("96.45.162.93"),
},
},
            new IPAddressinetArray1M
{
    Id = 90,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("73.187.95.93"),
System.Net.IPAddress.Parse("7.94.55.205"),
System.Net.IPAddress.Parse("17.99.226.144"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 31,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("0.61.227.251"),
System.Net.IPAddress.Parse("20.212.129.84"),
System.Net.IPAddress.Parse("209.163.37.77"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 99,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("149.85.42.45"),
System.Net.IPAddress.Parse("146.231.189.158"),
System.Net.IPAddress.Parse("97.236.118.155"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 103,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("88.197.41.224"),
System.Net.IPAddress.Parse("208.4.219.254"),
System.Net.IPAddress.Parse("202.127.85.225"),
System.Net.IPAddress.Parse("106.53.244.166"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 34,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("201.209.93.138"),
System.Net.IPAddress.Parse("46.18.185.1"),
System.Net.IPAddress.Parse("8.102.125.229"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("129.184.133.13"),
System.Net.IPAddress.Parse("185.38.18.110"),
System.Net.IPAddress.Parse("37.2.33.200"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 104,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("47.27.202.232"),
System.Net.IPAddress.Parse("83.174.74.70"),
System.Net.IPAddress.Parse("153.64.6.142"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("104.137.220.252"),
System.Net.IPAddress.Parse("159.61.52.167"),
System.Net.IPAddress.Parse("172.33.85.237"),
System.Net.IPAddress.Parse("97.210.210.160"),
},
},
            new IPAddressinetArray1M
{
    Id = 112,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("40.63.138.245"),
System.Net.IPAddress.Parse("5.53.19.22"),
System.Net.IPAddress.Parse("145.145.189.216"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 39,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("223.22.174.163"),
System.Net.IPAddress.Parse("115.35.196.232"),
System.Net.IPAddress.Parse("241.48.138.142"),
System.Net.IPAddress.Parse("114.129.253.3"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("190.197.161.19"),
System.Net.IPAddress.Parse("32.64.207.208"),
System.Net.IPAddress.Parse("128.152.63.89"),
System.Net.IPAddress.Parse("193.208.9.59"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("111.163.114.190"),
System.Net.IPAddress.Parse("27.218.200.128"),
System.Net.IPAddress.Parse("182.155.147.75"),
System.Net.IPAddress.Parse("177.32.34.205"),
},
},
            new IPAddressinetArray1M
{
    Id = 114,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("186.0.33.236"),
System.Net.IPAddress.Parse("48.21.11.56"),
System.Net.IPAddress.Parse("216.131.86.245"),
System.Net.IPAddress.Parse("40.42.226.248"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("210.11.82.132"),
System.Net.IPAddress.Parse("160.9.178.16"),
System.Net.IPAddress.Parse("95.46.97.37"),
System.Net.IPAddress.Parse("134.84.21.115"),
},
},
            new IPAddressinetArray1M
{
    Id = 120,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("76.213.31.247"),
System.Net.IPAddress.Parse("76.175.161.197"),
System.Net.IPAddress.Parse("162.123.34.181"),
System.Net.IPAddress.Parse("227.205.238.230"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 46,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("244.97.189.175"),
System.Net.IPAddress.Parse("79.250.66.3"),
System.Net.IPAddress.Parse("32.131.207.118"),
System.Net.IPAddress.Parse("109.234.87.198"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("146.181.222.5"),
System.Net.IPAddress.Parse("232.121.154.129"),
System.Net.IPAddress.Parse("88.134.231.100"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 127,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("230.204.23.135"),
System.Net.IPAddress.Parse("152.159.145.209"),
System.Net.IPAddress.Parse("44.166.16.210"),
System.Net.IPAddress.Parse("170.155.71.131"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 130,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("57.182.59.37"),
System.Net.IPAddress.Parse("115.236.216.21"),
System.Net.IPAddress.Parse("68.160.0.23"),
System.Net.IPAddress.Parse("219.79.153.185"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 47,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("236.202.203.240"),
System.Net.IPAddress.Parse("180.109.95.201"),
System.Net.IPAddress.Parse("243.87.157.83"),
System.Net.IPAddress.Parse("124.239.178.87"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("245.94.241.37"),
System.Net.IPAddress.Parse("117.252.3.211"),
System.Net.IPAddress.Parse("197.199.18.244"),
System.Net.IPAddress.Parse("186.132.98.47"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("234.58.205.43"),
System.Net.IPAddress.Parse("103.36.166.199"),
System.Net.IPAddress.Parse("87.154.20.82"),
},
},
            new IPAddressinetArray1M
{
    Id = 136,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("41.24.232.225"),
System.Net.IPAddress.Parse("100.138.38.162"),
System.Net.IPAddress.Parse("196.123.39.113"),
System.Net.IPAddress.Parse("194.0.252.18"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 137,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("43.63.11.242"),
System.Net.IPAddress.Parse("247.1.173.227"),
System.Net.IPAddress.Parse("240.77.106.88"),
System.Net.IPAddress.Parse("76.60.127.57"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 51,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("30.125.68.101"),
System.Net.IPAddress.Parse("217.140.200.153"),
System.Net.IPAddress.Parse("195.150.122.157"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("60.159.221.50"),
System.Net.IPAddress.Parse("204.147.251.158"),
System.Net.IPAddress.Parse("225.107.177.253"),
System.Net.IPAddress.Parse("137.163.21.221"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("220.158.115.245"),
System.Net.IPAddress.Parse("197.254.140.136"),
System.Net.IPAddress.Parse("193.145.58.89"),
System.Net.IPAddress.Parse("22.28.105.111"),
},
},
            new IPAddressinetArray1M
{
    Id = 138,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("87.168.187.132"),
System.Net.IPAddress.Parse("232.153.175.164"),
System.Net.IPAddress.Parse("229.217.211.204"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("226.250.240.247"),
System.Net.IPAddress.Parse("25.219.58.162"),
System.Net.IPAddress.Parse("133.195.99.63"),
},
},
            new IPAddressinetArray1M
{
    Id = 147,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("230.129.130.146"),
System.Net.IPAddress.Parse("124.57.76.197"),
System.Net.IPAddress.Parse("124.156.213.150"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 52,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("38.124.104.6"),
System.Net.IPAddress.Parse("8.120.131.66"),
System.Net.IPAddress.Parse("121.6.69.214"),
System.Net.IPAddress.Parse("234.233.92.60"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("136.193.106.127"),
System.Net.IPAddress.Parse("29.104.90.8"),
System.Net.IPAddress.Parse("126.241.110.21"),
System.Net.IPAddress.Parse("117.211.183.206"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("54.155.72.177"),
System.Net.IPAddress.Parse("217.106.101.32"),
System.Net.IPAddress.Parse("38.126.204.209"),
System.Net.IPAddress.Parse("130.229.185.230"),
},
},
            new IPAddressinetArray1M
{
    Id = 151,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("47.120.246.91"),
System.Net.IPAddress.Parse("223.60.115.184"),
System.Net.IPAddress.Parse("68.62.73.199"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("239.254.36.184"),
System.Net.IPAddress.Parse("165.145.21.236"),
System.Net.IPAddress.Parse("14.144.183.151"),
},
},
            new IPAddressinetArray1M
{
    Id = 159,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("155.135.100.122"),
System.Net.IPAddress.Parse("199.123.17.226"),
System.Net.IPAddress.Parse("143.8.99.186"),
System.Net.IPAddress.Parse("151.52.206.13"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 53,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("103.213.189.196"),
System.Net.IPAddress.Parse("21.140.210.51"),
System.Net.IPAddress.Parse("77.182.87.194"),
System.Net.IPAddress.Parse("127.95.35.199"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.230.247.18"),
System.Net.IPAddress.Parse("7.74.134.126"),
System.Net.IPAddress.Parse("131.30.19.194"),
System.Net.IPAddress.Parse("165.105.248.225"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("221.115.119.177"),
System.Net.IPAddress.Parse("188.38.172.25"),
System.Net.IPAddress.Parse("189.231.142.213"),
},
},
            new IPAddressinetArray1M
{
    Id = 163,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.24.113.61"),
System.Net.IPAddress.Parse("24.84.48.77"),
System.Net.IPAddress.Parse("116.180.193.62"),
System.Net.IPAddress.Parse("159.108.1.54"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("77.152.172.148"),
System.Net.IPAddress.Parse("244.84.193.177"),
System.Net.IPAddress.Parse("69.134.124.146"),
},
},
            new IPAddressinetArray1M
{
    Id = 168,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("236.180.131.76"),
System.Net.IPAddress.Parse("7.52.6.26"),
System.Net.IPAddress.Parse("31.149.132.254"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 54,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("43.65.112.15"),
System.Net.IPAddress.Parse("227.222.178.10"),
System.Net.IPAddress.Parse("254.178.8.152"),
System.Net.IPAddress.Parse("45.129.14.85"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("77.37.196.218"),
System.Net.IPAddress.Parse("41.58.193.150"),
System.Net.IPAddress.Parse("130.103.239.45"),
},
},
            new IPAddressinetArray1M
{
    Id = 173,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("84.79.124.185"),
System.Net.IPAddress.Parse("200.126.128.128"),
System.Net.IPAddress.Parse("221.39.128.75"),
System.Net.IPAddress.Parse("251.151.109.196"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 174,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("9.47.56.178"),
System.Net.IPAddress.Parse("193.27.104.56"),
System.Net.IPAddress.Parse("121.208.219.229"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 55,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("29.220.244.73"),
System.Net.IPAddress.Parse("43.16.122.16"),
System.Net.IPAddress.Parse("105.183.150.59"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("241.26.75.120"),
System.Net.IPAddress.Parse("197.95.96.182"),
System.Net.IPAddress.Parse("16.166.218.120"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 177,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("202.33.126.245"),
System.Net.IPAddress.Parse("234.131.50.143"),
System.Net.IPAddress.Parse("246.209.182.223"),
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
System.Net.IPAddress.Parse("54.37.84.27"),
System.Net.IPAddress.Parse("151.195.61.83"),
System.Net.IPAddress.Parse("91.147.122.87"),
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
System.Net.IPAddress.Parse("29.135.30.126"),
System.Net.IPAddress.Parse("140.225.77.95"),
System.Net.IPAddress.Parse("55.120.56.231"),
System.Net.IPAddress.Parse("119.46.178.22"),
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
                Assert.That(nullable, Is.Null);
                nullable = await ((IIPAddressArrayinetArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("225.10.25.127"),
System.Net.IPAddress.Parse("230.220.55.33"),
System.Net.IPAddress.Parse("200.25.71.204"),
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 159;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[24],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 163;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 151;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[34], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[24],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[25],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[26],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[27],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[28],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[29],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[30],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[31],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[24],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[25],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[34], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[28],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[29],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[30],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[31],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[32],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 163;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[5], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[6], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[7], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[8], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[9], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[10], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[24],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[25],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[26],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[27],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[28],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 138;
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[5], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[6], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[7], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[8], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[9], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[10], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[24],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[25],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[26],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[27],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[28],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[29],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 103, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[25],_testData[34], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 130, query1, 168, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 84, query1, 127, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[34], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 64, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 60, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[34], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 40, query1, 9, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[33],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 44, query1, 159, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[24],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[25],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[26],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[27],_testData[34], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 22, query1, 159, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[31],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 127, 151))
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatch(connection, 40, 168))
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[34], false);
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
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 147);
                var models = await ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                IPAddressinetArray1M.AssertModel(models[0],_testData[28], false);
                IPAddressinetArray1M.AssertModel(models[1],_testData[29], false);
                IPAddressinetArray1M.AssertModel(models[2],_testData[30], false);
                IPAddressinetArray1M.AssertModel(models[3],_testData[31], false);
                IPAddressinetArray1M.AssertModel(models[4],_testData[32], false);
                IPAddressinetArray1M.AssertModel(models[5],_testData[33], false);
                IPAddressinetArray1M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 90);
                var models =  ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                IPAddressinetArray1M.AssertModel(models[0],_testData[16], false);
                IPAddressinetArray1M.AssertModel(models[1],_testData[17], false);
                IPAddressinetArray1M.AssertModel(models[2],_testData[18], false);
                IPAddressinetArray1M.AssertModel(models[3],_testData[19], false);
                IPAddressinetArray1M.AssertModel(models[4],_testData[20], false);
                IPAddressinetArray1M.AssertModel(models[5],_testData[21], false);
                IPAddressinetArray1M.AssertModel(models[6],_testData[22], false);
                IPAddressinetArray1M.AssertModel(models[7],_testData[23], false);
                IPAddressinetArray1M.AssertModel(models[8],_testData[24], false);
                IPAddressinetArray1M.AssertModel(models[9],_testData[25], false);
                IPAddressinetArray1M.AssertModel(models[10],_testData[26], false);
                IPAddressinetArray1M.AssertModel(models[11],_testData[27], false);
                IPAddressinetArray1M.AssertModel(models[12],_testData[28], false);
                IPAddressinetArray1M.AssertModel(models[13],_testData[29], false);
                IPAddressinetArray1M.AssertModel(models[14],_testData[30], false);
                IPAddressinetArray1M.AssertModel(models[15],_testData[31], false);
                IPAddressinetArray1M.AssertModel(models[16],_testData[32], false);
                IPAddressinetArray1M.AssertModel(models[17],_testData[33], false);
                IPAddressinetArray1M.AssertModel(models[18],_testData[34], false);
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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

