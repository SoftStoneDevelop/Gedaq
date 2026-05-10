

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
    Id = 3,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("179.62.101.29"),
System.Net.IPAddress.Parse("203.138.183.13"),
System.Net.IPAddress.Parse("251.74.179.122"),
System.Net.IPAddress.Parse("14.5.10.26"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("62.154.115.82"),
System.Net.IPAddress.Parse("123.222.58.134"),
System.Net.IPAddress.Parse("121.219.157.243"),
System.Net.IPAddress.Parse("76.79.93.223"),
},
},
            new IPAddressinetArray1M
{
    Id = 5,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("22.77.244.251"),
System.Net.IPAddress.Parse("63.169.13.13"),
System.Net.IPAddress.Parse("107.162.71.13"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 9,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("95.243.198.186"),
System.Net.IPAddress.Parse("250.123.131.216"),
System.Net.IPAddress.Parse("157.231.252.149"),
System.Net.IPAddress.Parse("210.96.149.34"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 11,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("236.170.1.178"),
System.Net.IPAddress.Parse("194.53.121.178"),
System.Net.IPAddress.Parse("184.173.96.57"),
System.Net.IPAddress.Parse("98.44.229.68"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("67.235.178.42"),
System.Net.IPAddress.Parse("184.253.174.62"),
System.Net.IPAddress.Parse("190.87.206.229"),
System.Net.IPAddress.Parse("209.210.229.33"),
},
},
            new IPAddressinetArray1M
{
    Id = 17,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("100.102.184.219"),
System.Net.IPAddress.Parse("126.211.181.127"),
System.Net.IPAddress.Parse("250.234.77.40"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 18,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.171.152.162"),
System.Net.IPAddress.Parse("133.232.24.144"),
System.Net.IPAddress.Parse("77.169.86.115"),
System.Net.IPAddress.Parse("144.118.215.81"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("149.59.129.238"),
System.Net.IPAddress.Parse("73.166.224.30"),
System.Net.IPAddress.Parse("206.220.33.160"),
System.Net.IPAddress.Parse("102.7.227.172"),
},
},
            new IPAddressinetArray1M
{
    Id = 26,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("220.97.171.81"),
System.Net.IPAddress.Parse("142.71.205.45"),
System.Net.IPAddress.Parse("224.234.166.151"),
System.Net.IPAddress.Parse("222.112.78.235"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 35,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.162.234.196"),
System.Net.IPAddress.Parse("211.43.227.146"),
System.Net.IPAddress.Parse("162.199.231.91"),
System.Net.IPAddress.Parse("143.14.68.32"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 21,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("129.21.104.193"),
System.Net.IPAddress.Parse("195.7.211.159"),
System.Net.IPAddress.Parse("114.229.226.150"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("240.164.56.26"),
System.Net.IPAddress.Parse("39.131.200.227"),
System.Net.IPAddress.Parse("123.245.206.247"),
System.Net.IPAddress.Parse("69.154.233.16"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 41,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("15.194.167.14"),
System.Net.IPAddress.Parse("161.185.178.51"),
System.Net.IPAddress.Parse("30.174.105.209"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("152.147.15.50"),
System.Net.IPAddress.Parse("246.15.235.153"),
System.Net.IPAddress.Parse("63.172.185.250"),
System.Net.IPAddress.Parse("225.46.55.222"),
},
},
            new IPAddressinetArray1M
{
    Id = 44,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("81.19.97.98"),
System.Net.IPAddress.Parse("248.212.146.169"),
System.Net.IPAddress.Parse("153.51.207.9"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 29,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("187.199.246.40"),
System.Net.IPAddress.Parse("151.80.198.196"),
System.Net.IPAddress.Parse("241.84.129.58"),
System.Net.IPAddress.Parse("17.122.5.103"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("230.21.203.24"),
System.Net.IPAddress.Parse("174.46.214.47"),
System.Net.IPAddress.Parse("207.14.5.234"),
System.Net.IPAddress.Parse("225.216.179.67"),
},
},
            new IPAddressinetArray1M
{
    Id = 53,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("109.238.1.239"),
System.Net.IPAddress.Parse("122.152.214.149"),
System.Net.IPAddress.Parse("206.80.125.86"),
System.Net.IPAddress.Parse("142.166.36.251"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("234.237.153.200"),
System.Net.IPAddress.Parse("218.151.140.196"),
System.Net.IPAddress.Parse("215.41.153.97"),
},
},
            new IPAddressinetArray1M
{
    Id = 58,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("29.107.169.111"),
System.Net.IPAddress.Parse("219.18.158.186"),
System.Net.IPAddress.Parse("252.72.49.177"),
System.Net.IPAddress.Parse("134.189.131.214"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 31,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("138.206.37.43"),
System.Net.IPAddress.Parse("66.119.34.249"),
System.Net.IPAddress.Parse("24.229.160.198"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("133.3.67.25"),
System.Net.IPAddress.Parse("76.195.13.215"),
System.Net.IPAddress.Parse("158.12.246.157"),
System.Net.IPAddress.Parse("111.247.242.48"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("38.23.15.148"),
System.Net.IPAddress.Parse("137.161.131.49"),
System.Net.IPAddress.Parse("38.174.22.97"),
System.Net.IPAddress.Parse("250.45.216.49"),
},
},
            new IPAddressinetArray1M
{
    Id = 61,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("109.110.228.96"),
System.Net.IPAddress.Parse("153.57.228.80"),
System.Net.IPAddress.Parse("118.144.204.230"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 65,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("12.142.81.172"),
System.Net.IPAddress.Parse("235.153.188.88"),
System.Net.IPAddress.Parse("119.26.3.42"),
System.Net.IPAddress.Parse("149.90.143.160"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 32,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.216.122.222"),
System.Net.IPAddress.Parse("177.227.122.141"),
System.Net.IPAddress.Parse("115.253.137.37"),
System.Net.IPAddress.Parse("67.153.215.143"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("86.39.178.110"),
System.Net.IPAddress.Parse("121.209.223.82"),
System.Net.IPAddress.Parse("174.92.123.110"),
},
},
            new IPAddressinetArray1M
{
    Id = 70,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("4.249.221.37"),
System.Net.IPAddress.Parse("97.177.10.119"),
System.Net.IPAddress.Parse("101.133.44.95"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 71,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("4.239.151.15"),
System.Net.IPAddress.Parse("117.247.8.35"),
System.Net.IPAddress.Parse("121.231.95.221"),
System.Net.IPAddress.Parse("49.108.166.164"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 38,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("243.97.84.145"),
System.Net.IPAddress.Parse("155.44.113.20"),
System.Net.IPAddress.Parse("247.254.191.52"),
System.Net.IPAddress.Parse("131.0.171.40"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("223.58.22.183"),
System.Net.IPAddress.Parse("21.38.180.101"),
System.Net.IPAddress.Parse("43.138.185.227"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("139.157.61.238"),
System.Net.IPAddress.Parse("173.71.123.227"),
System.Net.IPAddress.Parse("223.189.237.176"),
System.Net.IPAddress.Parse("220.63.151.240"),
},
},
            new IPAddressinetArray1M
{
    Id = 73,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("117.245.92.95"),
System.Net.IPAddress.Parse("216.180.156.112"),
System.Net.IPAddress.Parse("217.85.91.202"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 74,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("47.0.5.183"),
System.Net.IPAddress.Parse("53.144.245.153"),
System.Net.IPAddress.Parse("5.167.227.92"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 42,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("217.53.171.129"),
System.Net.IPAddress.Parse("93.14.111.44"),
System.Net.IPAddress.Parse("227.121.193.198"),
System.Net.IPAddress.Parse("88.109.184.64"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("200.57.213.178"),
System.Net.IPAddress.Parse("176.50.199.104"),
System.Net.IPAddress.Parse("37.197.20.6"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("28.34.97.137"),
System.Net.IPAddress.Parse("4.26.99.173"),
System.Net.IPAddress.Parse("214.91.235.78"),
System.Net.IPAddress.Parse("52.114.14.61"),
},
},
            new IPAddressinetArray1M
{
    Id = 81,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("59.214.206.10"),
System.Net.IPAddress.Parse("89.237.83.231"),
System.Net.IPAddress.Parse("68.12.198.107"),
System.Net.IPAddress.Parse("57.71.221.94"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 82,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("142.129.2.253"),
System.Net.IPAddress.Parse("126.25.1.87"),
System.Net.IPAddress.Parse("130.120.97.72"),
System.Net.IPAddress.Parse("228.12.52.235"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 44,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("23.254.149.16"),
System.Net.IPAddress.Parse("180.49.46.185"),
System.Net.IPAddress.Parse("191.222.31.149"),
System.Net.IPAddress.Parse("15.23.11.51"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("253.58.26.72"),
System.Net.IPAddress.Parse("168.248.163.166"),
System.Net.IPAddress.Parse("41.5.10.239"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 90,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("53.60.13.114"),
System.Net.IPAddress.Parse("68.52.141.14"),
System.Net.IPAddress.Parse("134.166.61.116"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("190.133.38.199"),
System.Net.IPAddress.Parse("50.233.48.253"),
System.Net.IPAddress.Parse("21.205.107.27"),
},
},
            new IPAddressinetArray1M
{
    Id = 94,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("123.45.139.153"),
System.Net.IPAddress.Parse("200.204.23.126"),
System.Net.IPAddress.Parse("39.49.128.80"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 51,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("37.234.0.227"),
System.Net.IPAddress.Parse("153.84.217.128"),
System.Net.IPAddress.Parse("152.245.103.205"),
System.Net.IPAddress.Parse("245.57.101.174"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("167.195.57.134"),
System.Net.IPAddress.Parse("31.134.35.193"),
System.Net.IPAddress.Parse("86.108.13.142"),
System.Net.IPAddress.Parse("19.224.178.50"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 103,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.71.6.84"),
System.Net.IPAddress.Parse("126.78.118.103"),
System.Net.IPAddress.Parse("77.104.33.32"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("198.46.31.52"),
System.Net.IPAddress.Parse("112.242.118.174"),
System.Net.IPAddress.Parse("211.151.223.96"),
},
},
            new IPAddressinetArray1M
{
    Id = 109,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.78.137.101"),
System.Net.IPAddress.Parse("156.26.14.136"),
System.Net.IPAddress.Parse("175.39.185.112"),
System.Net.IPAddress.Parse("219.41.218.94"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 60,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("87.209.150.190"),
System.Net.IPAddress.Parse("31.52.234.35"),
System.Net.IPAddress.Parse("98.66.252.211"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("183.253.69.167"),
System.Net.IPAddress.Parse("208.58.99.147"),
System.Net.IPAddress.Parse("230.189.79.90"),
},
},
            new IPAddressinetArray1M
{
    Id = 114,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("35.179.45.116"),
System.Net.IPAddress.Parse("171.111.182.148"),
System.Net.IPAddress.Parse("77.226.71.70"),
System.Net.IPAddress.Parse("111.108.57.78"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 117,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("97.1.88.110"),
System.Net.IPAddress.Parse("12.74.192.39"),
System.Net.IPAddress.Parse("192.164.158.200"),
System.Net.IPAddress.Parse("68.50.19.141"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 69,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("154.230.189.137"),
System.Net.IPAddress.Parse("118.137.107.208"),
System.Net.IPAddress.Parse("47.196.254.148"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 125,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("30.216.156.16"),
System.Net.IPAddress.Parse("172.198.47.106"),
System.Net.IPAddress.Parse("184.12.91.114"),
System.Net.IPAddress.Parse("127.91.136.136"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 132,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.133.179.81"),
System.Net.IPAddress.Parse("85.99.202.204"),
System.Net.IPAddress.Parse("208.130.119.173"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 75,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("222.172.52.40"),
System.Net.IPAddress.Parse("20.237.188.236"),
System.Net.IPAddress.Parse("100.113.119.180"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("146.66.23.194"),
System.Net.IPAddress.Parse("10.63.95.191"),
System.Net.IPAddress.Parse("175.29.205.254"),
System.Net.IPAddress.Parse("13.29.139.99"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 134,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("181.180.32.241"),
System.Net.IPAddress.Parse("205.27.46.221"),
System.Net.IPAddress.Parse("95.116.224.56"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("210.112.173.211"),
System.Net.IPAddress.Parse("170.209.79.73"),
System.Net.IPAddress.Parse("245.115.179.8"),
},
},
            new IPAddressinetArray1M
{
    Id = 140,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.82.110.132"),
System.Net.IPAddress.Parse("215.110.52.226"),
System.Net.IPAddress.Parse("226.119.49.202"),
System.Net.IPAddress.Parse("182.73.144.10"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 76,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("38.25.127.203"),
System.Net.IPAddress.Parse("123.158.79.151"),
System.Net.IPAddress.Parse("233.181.151.62"),
System.Net.IPAddress.Parse("231.167.101.245"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("248.6.50.176"),
System.Net.IPAddress.Parse("121.132.135.1"),
System.Net.IPAddress.Parse("177.249.80.111"),
System.Net.IPAddress.Parse("53.166.147.53"),
},
},
            new IPAddressinetArray1M
{
    Id = 146,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("191.136.175.188"),
System.Net.IPAddress.Parse("211.50.156.205"),
System.Net.IPAddress.Parse("240.103.99.1"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("118.21.24.196"),
System.Net.IPAddress.Parse("216.110.16.18"),
System.Net.IPAddress.Parse("107.37.140.224"),
System.Net.IPAddress.Parse("153.121.36.28"),
},
},
            new IPAddressinetArray1M
{
    Id = 151,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("253.183.222.109"),
System.Net.IPAddress.Parse("41.226.124.208"),
System.Net.IPAddress.Parse("239.136.143.195"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 84,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.40.104.254"),
System.Net.IPAddress.Parse("196.124.126.114"),
System.Net.IPAddress.Parse("254.201.55.14"),
System.Net.IPAddress.Parse("173.135.1.136"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("147.96.221.4"),
System.Net.IPAddress.Parse("99.41.225.133"),
System.Net.IPAddress.Parse("15.217.13.116"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 158,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("68.141.216.110"),
System.Net.IPAddress.Parse("93.210.158.148"),
System.Net.IPAddress.Parse("128.182.164.187"),
System.Net.IPAddress.Parse("39.136.197.149"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("42.85.113.168"),
System.Net.IPAddress.Parse("55.217.140.62"),
System.Net.IPAddress.Parse("146.220.180.51"),
},
},
            new IPAddressinetArray1M
{
    Id = 162,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("163.34.122.210"),
System.Net.IPAddress.Parse("205.136.187.46"),
System.Net.IPAddress.Parse("55.230.82.30"),
System.Net.IPAddress.Parse("251.186.210.24"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 88,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("180.19.10.142"),
System.Net.IPAddress.Parse("1.248.67.22"),
System.Net.IPAddress.Parse("174.27.54.67"),
System.Net.IPAddress.Parse("124.115.89.157"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("207.22.208.86"),
System.Net.IPAddress.Parse("160.108.42.140"),
System.Net.IPAddress.Parse("112.22.81.94"),
},
},
            new IPAddressinetArray1M
{
    Id = 171,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("125.113.120.252"),
System.Net.IPAddress.Parse("156.142.46.208"),
System.Net.IPAddress.Parse("208.133.33.229"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("171.198.220.216"),
System.Net.IPAddress.Parse("197.65.10.109"),
System.Net.IPAddress.Parse("108.242.232.244"),
System.Net.IPAddress.Parse("194.214.145.120"),
},
},
            new IPAddressinetArray1M
{
    Id = 176,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("126.47.225.219"),
System.Net.IPAddress.Parse("155.134.187.19"),
System.Net.IPAddress.Parse("48.185.176.133"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 94,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("54.73.184.63"),
System.Net.IPAddress.Parse("121.246.221.101"),
System.Net.IPAddress.Parse("106.62.10.211"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("116.184.252.139"),
System.Net.IPAddress.Parse("214.102.193.153"),
System.Net.IPAddress.Parse("180.79.75.219"),
System.Net.IPAddress.Parse("130.130.236.186"),
},
},
            new IPAddressinetArray1M
{
    Id = 178,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("67.148.161.46"),
System.Net.IPAddress.Parse("207.130.206.97"),
System.Net.IPAddress.Parse("150.220.107.222"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("152.147.15.50"),
System.Net.IPAddress.Parse("246.15.235.153"),
System.Net.IPAddress.Parse("63.172.185.250"),
System.Net.IPAddress.Parse("225.46.55.222"),
}));
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
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("230.21.203.24"),
System.Net.IPAddress.Parse("174.46.214.47"),
System.Net.IPAddress.Parse("207.14.5.234"),
System.Net.IPAddress.Parse("225.216.179.67"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("234.237.153.200"),
System.Net.IPAddress.Parse("218.151.140.196"),
System.Net.IPAddress.Parse("215.41.153.97"),
}));
                nullable =  ((IIPAddressArrayinetArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("38.23.15.148"),
System.Net.IPAddress.Parse("137.161.131.49"),
System.Net.IPAddress.Parse("38.174.22.97"),
System.Net.IPAddress.Parse("250.45.216.49"),
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
System.Net.IPAddress.Parse("86.39.178.110"),
System.Net.IPAddress.Parse("121.209.223.82"),
System.Net.IPAddress.Parse("174.92.123.110"),
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
                parametr1.Value = 146;
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 140;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[31],_testData[34], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[33],_testData[34], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 158;
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[34], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[2], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[3], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[4], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[5], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[6], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[7], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[8], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[9], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[10], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[24],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[25],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[26],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[27],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[28],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[29],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[30],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[31],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[34], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 171, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[34], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 53, query1, 134, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[34], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 171, query1, 44, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 74, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 58, query1, 3, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 103, query1, 41, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[27],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 109, query1, 26, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[34], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 61, query1, 158, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 82, 94))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatch(connection, 70, 65))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 70);
                var models = await ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                IPAddressinetArray1M.AssertModel(models[0],_testData[13], false);
                IPAddressinetArray1M.AssertModel(models[1],_testData[14], false);
                IPAddressinetArray1M.AssertModel(models[2],_testData[15], false);
                IPAddressinetArray1M.AssertModel(models[3],_testData[16], false);
                IPAddressinetArray1M.AssertModel(models[4],_testData[17], false);
                IPAddressinetArray1M.AssertModel(models[5],_testData[18], false);
                IPAddressinetArray1M.AssertModel(models[6],_testData[19], false);
                IPAddressinetArray1M.AssertModel(models[7],_testData[20], false);
                IPAddressinetArray1M.AssertModel(models[8],_testData[21], false);
                IPAddressinetArray1M.AssertModel(models[9],_testData[22], false);
                IPAddressinetArray1M.AssertModel(models[10],_testData[23], false);
                IPAddressinetArray1M.AssertModel(models[11],_testData[24], false);
                IPAddressinetArray1M.AssertModel(models[12],_testData[25], false);
                IPAddressinetArray1M.AssertModel(models[13],_testData[26], false);
                IPAddressinetArray1M.AssertModel(models[14],_testData[27], false);
                IPAddressinetArray1M.AssertModel(models[15],_testData[28], false);
                IPAddressinetArray1M.AssertModel(models[16],_testData[29], false);
                IPAddressinetArray1M.AssertModel(models[17],_testData[30], false);
                IPAddressinetArray1M.AssertModel(models[18],_testData[31], false);
                IPAddressinetArray1M.AssertModel(models[19],_testData[32], false);
                IPAddressinetArray1M.AssertModel(models[20],_testData[33], false);
                IPAddressinetArray1M.AssertModel(models[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 158);
                var models =  ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                IPAddressinetArray1M.AssertModel(models[0],_testData[31], false);
                IPAddressinetArray1M.AssertModel(models[1],_testData[32], false);
                IPAddressinetArray1M.AssertModel(models[2],_testData[33], false);
                IPAddressinetArray1M.AssertModel(models[3],_testData[34], false);
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

