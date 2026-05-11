

using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IIPAddressMArrayMArrayD1
    {
    }
    
    internal partial class IPAddressMArrayMArrayD1 : IIPAddressMArrayMArrayD1
    {


#region TestData

        private readonly IPAddressMArrayD1E1M[] _testData = new IPAddressMArrayD1E1M[]
        {
            new IPAddressMArrayD1E1M
{
    Id = 5,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("115.34.204.232"),
System.Net.IPAddress.Parse("249.70.177.134"),
System.Net.IPAddress.Parse("126.40.201.218"),
System.Net.IPAddress.Parse("6.135.118.62"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 1,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("104.165.14.240"),
System.Net.IPAddress.Parse("247.143.241.12"),
System.Net.IPAddress.Parse("213.79.208.170"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("43.39.235.28"),
System.Net.IPAddress.Parse("44.92.166.166"),
System.Net.IPAddress.Parse("166.129.142.74"),
System.Net.IPAddress.Parse("20.155.155.152"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 13,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("48.51.248.220"),
System.Net.IPAddress.Parse("133.134.78.37"),
System.Net.IPAddress.Parse("186.97.183.64"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 6,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("179.70.203.126"),
System.Net.IPAddress.Parse("229.191.250.236"),
System.Net.IPAddress.Parse("117.122.26.74"),
System.Net.IPAddress.Parse("183.27.121.91"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 20,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("82.154.77.166"),
System.Net.IPAddress.Parse("181.190.179.197"),
System.Net.IPAddress.Parse("238.50.239.210"),
System.Net.IPAddress.Parse("198.98.31.92"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 10,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("101.11.69.210"),
System.Net.IPAddress.Parse("146.27.211.115"),
System.Net.IPAddress.Parse("171.65.81.126"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("193.203.44.1"),
System.Net.IPAddress.Parse("145.112.236.214"),
System.Net.IPAddress.Parse("202.0.160.4"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 23,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("82.202.58.240"),
System.Net.IPAddress.Parse("64.66.197.62"),
System.Net.IPAddress.Parse("238.105.105.201"),
System.Net.IPAddress.Parse("67.231.196.195"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 18,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("183.130.91.147"),
System.Net.IPAddress.Parse("231.7.222.53"),
System.Net.IPAddress.Parse("10.234.91.86"),
System.Net.IPAddress.Parse("50.156.103.64"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 31,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("124.114.148.136"),
System.Net.IPAddress.Parse("239.137.21.93"),
System.Net.IPAddress.Parse("209.188.58.107"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 21,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.183.159.86"),
System.Net.IPAddress.Parse("30.214.43.112"),
System.Net.IPAddress.Parse("169.24.103.34"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("231.68.99.158"),
System.Net.IPAddress.Parse("193.84.100.242"),
System.Net.IPAddress.Parse("21.182.132.235"),
System.Net.IPAddress.Parse("31.163.45.61"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 38,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("137.16.123.169"),
System.Net.IPAddress.Parse("223.82.206.64"),
System.Net.IPAddress.Parse("94.212.106.161"),
System.Net.IPAddress.Parse("136.137.252.67"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("25.120.88.18"),
System.Net.IPAddress.Parse("118.103.108.33"),
System.Net.IPAddress.Parse("69.196.153.248"),
System.Net.IPAddress.Parse("231.101.27.191"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("196.241.39.188"),
System.Net.IPAddress.Parse("253.85.120.158"),
System.Net.IPAddress.Parse("197.130.129.253"),
System.Net.IPAddress.Parse("198.90.251.4"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 47,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("162.141.254.124"),
System.Net.IPAddress.Parse("163.249.239.68"),
System.Net.IPAddress.Parse("26.182.87.148"),
System.Net.IPAddress.Parse("170.249.187.90"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 39,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("236.15.218.9"),
System.Net.IPAddress.Parse("84.231.233.156"),
System.Net.IPAddress.Parse("169.215.48.150"),
System.Net.IPAddress.Parse("23.159.177.81"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 53,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("122.179.95.148"),
System.Net.IPAddress.Parse("232.208.119.111"),
System.Net.IPAddress.Parse("164.0.177.113"),
System.Net.IPAddress.Parse("187.19.41.235"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("53.201.110.192"),
System.Net.IPAddress.Parse("243.206.128.0"),
System.Net.IPAddress.Parse("112.162.189.240"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("104.50.67.167"),
System.Net.IPAddress.Parse("180.201.228.156"),
System.Net.IPAddress.Parse("153.174.17.200"),
System.Net.IPAddress.Parse("181.184.59.45"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 60,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("17.170.139.70"),
System.Net.IPAddress.Parse("61.168.112.132"),
System.Net.IPAddress.Parse("207.93.244.10"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 54,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("239.126.61.196"),
System.Net.IPAddress.Parse("21.154.52.104"),
System.Net.IPAddress.Parse("122.57.242.128"),
System.Net.IPAddress.Parse("0.32.198.229"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 68,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("254.68.136.71"),
System.Net.IPAddress.Parse("139.113.143.141"),
System.Net.IPAddress.Parse("24.238.140.41"),
System.Net.IPAddress.Parse("15.148.143.144"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 56,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("230.140.251.87"),
System.Net.IPAddress.Parse("122.4.196.87"),
System.Net.IPAddress.Parse("193.151.154.235"),
System.Net.IPAddress.Parse("252.131.160.167"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 77,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("187.24.118.151"),
System.Net.IPAddress.Parse("218.218.177.68"),
System.Net.IPAddress.Parse("234.65.19.121"),
System.Net.IPAddress.Parse("46.113.227.23"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 59,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("116.117.74.143"),
System.Net.IPAddress.Parse("79.99.201.224"),
System.Net.IPAddress.Parse("59.228.156.78"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("82.20.116.53"),
System.Net.IPAddress.Parse("237.186.54.246"),
System.Net.IPAddress.Parse("222.135.53.2"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 85,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("177.242.226.78"),
System.Net.IPAddress.Parse("217.59.251.198"),
System.Net.IPAddress.Parse("31.233.139.167"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 65,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("159.74.3.32"),
System.Net.IPAddress.Parse("15.237.205.88"),
System.Net.IPAddress.Parse("205.179.169.71"),
System.Net.IPAddress.Parse("193.16.42.246"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 89,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("13.27.136.143"),
System.Net.IPAddress.Parse("156.130.73.130"),
System.Net.IPAddress.Parse("26.22.82.139"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 72,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("51.189.53.110"),
System.Net.IPAddress.Parse("181.196.65.252"),
System.Net.IPAddress.Parse("208.137.216.153"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("157.56.246.214"),
System.Net.IPAddress.Parse("120.191.175.119"),
System.Net.IPAddress.Parse("12.206.92.239"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 90,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("28.169.241.118"),
System.Net.IPAddress.Parse("35.12.27.11"),
System.Net.IPAddress.Parse("21.158.8.4"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 73,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("149.61.130.254"),
System.Net.IPAddress.Parse("48.73.38.44"),
System.Net.IPAddress.Parse("114.190.244.137"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("158.140.191.34"),
System.Net.IPAddress.Parse("10.241.123.63"),
System.Net.IPAddress.Parse("74.86.174.29"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("185.55.167.229"),
System.Net.IPAddress.Parse("98.76.98.21"),
System.Net.IPAddress.Parse("113.112.21.193"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 99,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("11.131.252.161"),
System.Net.IPAddress.Parse("166.164.54.212"),
System.Net.IPAddress.Parse("190.15.130.27"),
System.Net.IPAddress.Parse("84.32.62.235"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 78,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("37.124.47.165"),
System.Net.IPAddress.Parse("175.169.63.247"),
System.Net.IPAddress.Parse("154.144.177.90"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("55.43.197.117"),
System.Net.IPAddress.Parse("103.189.10.196"),
System.Net.IPAddress.Parse("16.76.105.112"),
System.Net.IPAddress.Parse("33.125.201.223"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 108,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("14.226.254.108"),
System.Net.IPAddress.Parse("212.179.141.201"),
System.Net.IPAddress.Parse("234.210.61.155"),
System.Net.IPAddress.Parse("199.34.122.121"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 81,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("252.218.37.36"),
System.Net.IPAddress.Parse("81.115.136.107"),
System.Net.IPAddress.Parse("191.135.89.180"),
System.Net.IPAddress.Parse("16.184.208.202"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 109,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("241.47.158.115"),
System.Net.IPAddress.Parse("149.113.227.57"),
System.Net.IPAddress.Parse("228.101.53.249"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("60.66.50.60"),
System.Net.IPAddress.Parse("118.114.113.104"),
System.Net.IPAddress.Parse("128.154.179.113"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 115,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.56.72.1"),
System.Net.IPAddress.Parse("16.38.90.205"),
System.Net.IPAddress.Parse("120.86.126.117"),
System.Net.IPAddress.Parse("89.106.151.100"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 88,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("202.194.227.36"),
System.Net.IPAddress.Parse("164.87.149.237"),
System.Net.IPAddress.Parse("136.68.76.9"),
System.Net.IPAddress.Parse("62.171.141.178"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("184.26.44.149"),
System.Net.IPAddress.Parse("228.226.200.116"),
System.Net.IPAddress.Parse("59.145.223.54"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 119,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("212.197.130.203"),
System.Net.IPAddress.Parse("156.150.234.226"),
System.Net.IPAddress.Parse("47.91.5.234"),
System.Net.IPAddress.Parse("145.10.84.33"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 96,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("26.31.229.0"),
System.Net.IPAddress.Parse("57.140.190.110"),
System.Net.IPAddress.Parse("248.214.30.138"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 124,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("180.106.74.235"),
System.Net.IPAddress.Parse("18.215.138.98"),
System.Net.IPAddress.Parse("230.114.120.222"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 100,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("49.99.99.155"),
System.Net.IPAddress.Parse("203.189.86.151"),
System.Net.IPAddress.Parse("205.59.226.115"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("4.222.238.166"),
System.Net.IPAddress.Parse("68.45.125.180"),
System.Net.IPAddress.Parse("122.18.188.196"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 131,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("216.190.123.109"),
System.Net.IPAddress.Parse("240.46.190.176"),
System.Net.IPAddress.Parse("151.81.164.212"),
System.Net.IPAddress.Parse("234.241.55.111"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 108,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("51.75.43.213"),
System.Net.IPAddress.Parse("122.240.106.220"),
System.Net.IPAddress.Parse("149.89.213.42"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("193.5.108.42"),
System.Net.IPAddress.Parse("210.133.147.126"),
System.Net.IPAddress.Parse("24.177.176.231"),
System.Net.IPAddress.Parse("89.87.50.5"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 132,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("171.30.96.196"),
System.Net.IPAddress.Parse("185.77.229.215"),
System.Net.IPAddress.Parse("249.184.47.102"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 116,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("51.199.151.156"),
System.Net.IPAddress.Parse("67.188.212.16"),
System.Net.IPAddress.Parse("251.164.142.136"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("120.219.232.73"),
System.Net.IPAddress.Parse("13.28.135.194"),
System.Net.IPAddress.Parse("67.5.214.177"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("42.12.53.28"),
System.Net.IPAddress.Parse("206.33.248.90"),
System.Net.IPAddress.Parse("71.46.95.114"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 136,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("95.217.68.141"),
System.Net.IPAddress.Parse("172.68.44.145"),
System.Net.IPAddress.Parse("51.97.141.243"),
System.Net.IPAddress.Parse("158.55.216.43"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 121,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("5.74.163.68"),
System.Net.IPAddress.Parse("229.193.58.137"),
System.Net.IPAddress.Parse("148.178.122.143"),
System.Net.IPAddress.Parse("252.101.153.138"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("44.231.122.23"),
System.Net.IPAddress.Parse("77.18.187.10"),
System.Net.IPAddress.Parse("196.197.173.83"),
System.Net.IPAddress.Parse("91.2.135.27"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 138,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("226.72.60.139"),
System.Net.IPAddress.Parse("118.82.147.173"),
System.Net.IPAddress.Parse("104.100.28.240"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 127,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("253.33.144.66"),
System.Net.IPAddress.Parse("105.113.113.104"),
System.Net.IPAddress.Parse("146.48.81.131"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.209.51.11"),
System.Net.IPAddress.Parse("51.173.209.38"),
System.Net.IPAddress.Parse("132.49.36.206"),
System.Net.IPAddress.Parse("44.17.140.52"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 142,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("107.225.97.192"),
System.Net.IPAddress.Parse("114.226.27.62"),
System.Net.IPAddress.Parse("84.69.101.208"),
System.Net.IPAddress.Parse("189.246.166.59"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 131,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("175.94.20.211"),
System.Net.IPAddress.Parse("241.254.231.102"),
System.Net.IPAddress.Parse("44.229.136.114"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 150,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("254.15.107.206"),
System.Net.IPAddress.Parse("44.167.242.201"),
System.Net.IPAddress.Parse("166.122.152.207"),
System.Net.IPAddress.Parse("96.111.166.100"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 134,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("127.212.229.240"),
System.Net.IPAddress.Parse("174.213.214.13"),
System.Net.IPAddress.Parse("55.13.114.190"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("218.101.4.98"),
System.Net.IPAddress.Parse("12.97.125.112"),
System.Net.IPAddress.Parse("71.205.21.149"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 158,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("231.99.185.142"),
System.Net.IPAddress.Parse("61.183.99.169"),
System.Net.IPAddress.Parse("246.243.80.22"),
System.Net.IPAddress.Parse("155.37.143.44"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 141,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.14.228.109"),
System.Net.IPAddress.Parse("131.33.41.138"),
System.Net.IPAddress.Parse("142.157.30.79"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("165.34.109.207"),
System.Net.IPAddress.Parse("140.100.241.81"),
System.Net.IPAddress.Parse("156.74.147.158"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 159,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("16.34.240.55"),
System.Net.IPAddress.Parse("139.89.113.230"),
System.Net.IPAddress.Parse("121.209.132.170"),
System.Net.IPAddress.Parse("23.237.30.82"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 146,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("176.216.199.178"),
System.Net.IPAddress.Parse("175.158.156.217"),
System.Net.IPAddress.Parse("208.116.93.142"),
System.Net.IPAddress.Parse("88.1.241.76"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 162,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("136.138.207.94"),
System.Net.IPAddress.Parse("198.214.9.73"),
System.Net.IPAddress.Parse("77.190.52.18"),
System.Net.IPAddress.Parse("148.202.185.52"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 149,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("170.222.235.186"),
System.Net.IPAddress.Parse("4.205.180.40"),
System.Net.IPAddress.Parse("110.8.190.173"),
System.Net.IPAddress.Parse("224.81.166.135"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("0.130.150.25"),
System.Net.IPAddress.Parse("86.249.176.149"),
System.Net.IPAddress.Parse("113.1.30.23"),
System.Net.IPAddress.Parse("246.55.171.207"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 167,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("170.29.205.27"),
System.Net.IPAddress.Parse("81.148.64.127"),
System.Net.IPAddress.Parse("226.20.169.162"),
System.Net.IPAddress.Parse("214.105.18.129"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 154,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("96.49.164.161"),
System.Net.IPAddress.Parse("219.203.180.229"),
System.Net.IPAddress.Parse("198.89.82.109"),
System.Net.IPAddress.Parse("196.176.166.194"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("252.44.25.234"),
System.Net.IPAddress.Parse("4.79.225.239"),
System.Net.IPAddress.Parse("193.177.126.108"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("78.0.186.153"),
System.Net.IPAddress.Parse("109.249.195.189"),
System.Net.IPAddress.Parse("67.12.61.108"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 168,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("182.213.48.254"),
System.Net.IPAddress.Parse("22.117.197.29"),
System.Net.IPAddress.Parse("28.57.205.249"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 157,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("65.41.72.19"),
System.Net.IPAddress.Parse("248.211.7.216"),
System.Net.IPAddress.Parse("170.246.204.56"),
System.Net.IPAddress.Parse("102.238.99.210"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("84.26.254.206"),
System.Net.IPAddress.Parse("100.115.55.210"),
System.Net.IPAddress.Parse("200.91.16.27"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("203.177.80.138"),
System.Net.IPAddress.Parse("88.45.144.42"),
System.Net.IPAddress.Parse("238.34.201.210"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 169,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("222.91.11.55"),
System.Net.IPAddress.Parse("5.197.78.23"),
System.Net.IPAddress.Parse("111.35.187.232"),
System.Net.IPAddress.Parse("79.180.221.55"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 165,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("141.140.162.35"),
System.Net.IPAddress.Parse("166.22.54.177"),
System.Net.IPAddress.Parse("21.106.181.6"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("1.198.187.47"),
System.Net.IPAddress.Parse("7.1.252.55"),
System.Net.IPAddress.Parse("2.95.91.148"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("33.10.205.118"),
System.Net.IPAddress.Parse("42.108.241.95"),
System.Net.IPAddress.Parse("110.144.112.249"),
System.Net.IPAddress.Parse("242.176.236.58"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 172,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.17.51.65"),
System.Net.IPAddress.Parse("72.137.8.120"),
System.Net.IPAddress.Parse("178.35.54.44"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 174,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("52.122.211.223"),
System.Net.IPAddress.Parse("95.32.249.126"),
System.Net.IPAddress.Parse("252.79.200.54"),
System.Net.IPAddress.Parse("106.113.247.97"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("180.176.220.166"),
System.Net.IPAddress.Parse("4.9.98.167"),
System.Net.IPAddress.Parse("20.252.106.152"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.212.64.36"),
System.Net.IPAddress.Parse("8.102.206.89"),
System.Net.IPAddress.Parse("99.60.58.195"),
System.Net.IPAddress.Parse("46.190.204.173"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 175,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("115.14.19.36"),
System.Net.IPAddress.Parse("73.86.152.230"),
System.Net.IPAddress.Parse("156.33.190.68"),
System.Net.IPAddress.Parse("156.233.21.77"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 183,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("233.14.202.134"),
System.Net.IPAddress.Parse("87.235.76.75"),
System.Net.IPAddress.Parse("176.34.109.0"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("85.162.166.96"),
System.Net.IPAddress.Parse("161.166.116.78"),
System.Net.IPAddress.Parse("21.224.35.142"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 180,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("4.124.47.107"),
System.Net.IPAddress.Parse("185.3.154.91"),
System.Net.IPAddress.Parse("208.76.194.195"),
System.Net.IPAddress.Parse("40.90.197.232"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 190,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("116.39.22.70"),
System.Net.IPAddress.Parse("110.158.106.242"),
System.Net.IPAddress.Parse("203.145.94.116"),
System.Net.IPAddress.Parse("126.250.87.231"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.249.96.29"),
System.Net.IPAddress.Parse("89.240.32.204"),
System.Net.IPAddress.Parse("159.39.140.82"),
System.Net.IPAddress.Parse("160.155.104.228"),
},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.ipaddressmarrayd1e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(IPv4)}, 
    {mi_id:Int32},
    {mi_value:Array(IPv4)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]), 
                parametrName: "mi_value", 
                methodParametrName: "mi_Value")]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 2; i++)
                {
                    await ((IIPAddressMArrayMArrayD1)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 35; i++)
                {
                     ((IIPAddressMArrayMArrayD1)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT
	m_id AS id,
    m_value AS value,
~StartInner::ModelInner:id~
~Reinterpret::id~
    mi_id,
~Reinterpret::value~
    mi_value
~EndInner::ModelInner~
FROM gedaqtests.ipaddressmarrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(IPAddressMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_id")]
        public void SelectModelDbConnectionConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models = await ((IIPAddressMArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    IPAddressMArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models =  ((IIPAddressMArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    IPAddressMArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

