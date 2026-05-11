

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
    Id = 9,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("122.96.232.78"),
System.Net.IPAddress.Parse("158.175.204.163"),
System.Net.IPAddress.Parse("65.118.242.201"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 6,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("212.125.217.35"),
System.Net.IPAddress.Parse("52.126.203.100"),
System.Net.IPAddress.Parse("223.161.102.48"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("210.164.227.203"),
System.Net.IPAddress.Parse("138.120.247.150"),
System.Net.IPAddress.Parse("49.93.109.206"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("252.199.137.1"),
System.Net.IPAddress.Parse("86.17.70.227"),
System.Net.IPAddress.Parse("240.70.12.196"),
System.Net.IPAddress.Parse("77.213.60.37"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 11,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("164.241.196.234"),
System.Net.IPAddress.Parse("230.102.74.238"),
System.Net.IPAddress.Parse("186.12.192.228"),
System.Net.IPAddress.Parse("64.143.107.28"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 13,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("5.213.73.101"),
System.Net.IPAddress.Parse("72.84.250.21"),
System.Net.IPAddress.Parse("180.167.172.103"),
System.Net.IPAddress.Parse("232.111.228.138"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("155.34.86.205"),
System.Net.IPAddress.Parse("155.40.5.245"),
System.Net.IPAddress.Parse("104.181.169.239"),
System.Net.IPAddress.Parse("64.14.114.39"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 19,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("219.125.41.175"),
System.Net.IPAddress.Parse("164.94.61.12"),
System.Net.IPAddress.Parse("230.116.135.187"),
System.Net.IPAddress.Parse("146.43.238.87"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 14,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("140.88.13.224"),
System.Net.IPAddress.Parse("15.75.221.142"),
System.Net.IPAddress.Parse("166.62.233.187"),
System.Net.IPAddress.Parse("114.101.31.49"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("232.254.249.64"),
System.Net.IPAddress.Parse("138.233.198.135"),
System.Net.IPAddress.Parse("15.147.69.139"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 24,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("159.252.126.21"),
System.Net.IPAddress.Parse("93.44.46.48"),
System.Net.IPAddress.Parse("178.144.123.244"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 16,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("11.219.172.128"),
System.Net.IPAddress.Parse("147.55.146.228"),
System.Net.IPAddress.Parse("86.249.86.165"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("210.160.170.197"),
System.Net.IPAddress.Parse("251.169.213.50"),
System.Net.IPAddress.Parse("22.93.208.2"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 28,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("74.176.215.129"),
System.Net.IPAddress.Parse("32.183.216.88"),
System.Net.IPAddress.Parse("169.24.250.128"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 20,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("49.92.66.57"),
System.Net.IPAddress.Parse("98.150.108.115"),
System.Net.IPAddress.Parse("90.48.201.192"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("166.248.54.174"),
System.Net.IPAddress.Parse("192.188.134.112"),
System.Net.IPAddress.Parse("93.83.61.231"),
System.Net.IPAddress.Parse("168.246.114.249"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("108.68.153.223"),
System.Net.IPAddress.Parse("250.173.166.31"),
System.Net.IPAddress.Parse("166.232.221.43"),
System.Net.IPAddress.Parse("66.218.187.77"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 34,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("116.23.116.131"),
System.Net.IPAddress.Parse("100.188.108.34"),
System.Net.IPAddress.Parse("61.154.79.230"),
System.Net.IPAddress.Parse("34.42.115.50"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 27,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("226.173.24.192"),
System.Net.IPAddress.Parse("130.207.46.193"),
System.Net.IPAddress.Parse("235.251.159.102"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("61.235.36.150"),
System.Net.IPAddress.Parse("21.253.142.76"),
System.Net.IPAddress.Parse("39.130.94.189"),
System.Net.IPAddress.Parse("2.66.244.20"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("75.175.224.220"),
System.Net.IPAddress.Parse("175.178.225.120"),
System.Net.IPAddress.Parse("227.9.222.75"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 41,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("18.183.177.80"),
System.Net.IPAddress.Parse("233.209.99.220"),
System.Net.IPAddress.Parse("196.174.209.119"),
System.Net.IPAddress.Parse("189.161.127.17"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("233.50.64.66"),
System.Net.IPAddress.Parse("112.185.220.185"),
System.Net.IPAddress.Parse("87.137.90.204"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("162.17.88.254"),
System.Net.IPAddress.Parse("1.75.135.101"),
System.Net.IPAddress.Parse("232.65.221.176"),
System.Net.IPAddress.Parse("113.70.194.78"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 47,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("215.55.247.236"),
System.Net.IPAddress.Parse("56.21.93.217"),
System.Net.IPAddress.Parse("78.210.215.42"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 31,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("235.245.177.54"),
System.Net.IPAddress.Parse("25.134.122.237"),
System.Net.IPAddress.Parse("97.97.1.100"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("178.206.63.188"),
System.Net.IPAddress.Parse("80.10.202.73"),
System.Net.IPAddress.Parse("53.156.244.150"),
System.Net.IPAddress.Parse("207.24.194.183"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 56,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("9.135.227.23"),
System.Net.IPAddress.Parse("222.111.63.172"),
System.Net.IPAddress.Parse("155.98.32.228"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 36,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("67.250.71.245"),
System.Net.IPAddress.Parse("17.76.58.127"),
System.Net.IPAddress.Parse("92.59.234.0"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("99.153.191.27"),
System.Net.IPAddress.Parse("42.59.246.51"),
System.Net.IPAddress.Parse("206.21.99.69"),
System.Net.IPAddress.Parse("219.209.160.224"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 61,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("147.39.68.231"),
System.Net.IPAddress.Parse("139.196.94.242"),
System.Net.IPAddress.Parse("19.72.99.1"),
System.Net.IPAddress.Parse("198.219.246.227"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("143.99.152.254"),
System.Net.IPAddress.Parse("112.177.207.222"),
System.Net.IPAddress.Parse("190.205.203.139"),
System.Net.IPAddress.Parse("139.144.220.58"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("245.106.23.158"),
System.Net.IPAddress.Parse("147.116.167.199"),
System.Net.IPAddress.Parse("147.87.75.162"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 70,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("75.195.131.177"),
System.Net.IPAddress.Parse("251.82.94.228"),
System.Net.IPAddress.Parse("207.204.221.125"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 46,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("37.18.242.150"),
System.Net.IPAddress.Parse("68.47.221.104"),
System.Net.IPAddress.Parse("18.38.213.176"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("14.174.36.148"),
System.Net.IPAddress.Parse("207.99.3.203"),
System.Net.IPAddress.Parse("97.247.98.183"),
System.Net.IPAddress.Parse("132.225.174.141"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 78,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("172.98.98.250"),
System.Net.IPAddress.Parse("117.116.230.73"),
System.Net.IPAddress.Parse("112.221.112.112"),
System.Net.IPAddress.Parse("37.213.62.61"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("110.119.157.193"),
System.Net.IPAddress.Parse("80.147.84.243"),
System.Net.IPAddress.Parse("127.170.75.62"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("127.173.213.251"),
System.Net.IPAddress.Parse("203.245.23.103"),
System.Net.IPAddress.Parse("161.211.20.25"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("48.133.29.134"),
System.Net.IPAddress.Parse("148.135.173.2"),
System.Net.IPAddress.Parse("214.248.216.246"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 81,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("15.163.37.106"),
System.Net.IPAddress.Parse("141.38.98.171"),
System.Net.IPAddress.Parse("159.234.75.104"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 56,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("35.113.147.72"),
System.Net.IPAddress.Parse("112.125.81.163"),
System.Net.IPAddress.Parse("141.2.187.129"),
System.Net.IPAddress.Parse("233.203.178.33"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 82,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("177.76.246.123"),
System.Net.IPAddress.Parse("226.3.219.169"),
System.Net.IPAddress.Parse("221.17.146.170"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 65,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("197.142.133.44"),
System.Net.IPAddress.Parse("134.6.116.159"),
System.Net.IPAddress.Parse("180.82.211.116"),
System.Net.IPAddress.Parse("81.189.137.107"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("22.93.233.132"),
System.Net.IPAddress.Parse("39.235.44.119"),
System.Net.IPAddress.Parse("80.237.62.22"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 87,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("80.151.61.9"),
System.Net.IPAddress.Parse("31.186.70.200"),
System.Net.IPAddress.Parse("251.140.251.78"),
System.Net.IPAddress.Parse("181.11.21.204"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 71,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("40.49.195.151"),
System.Net.IPAddress.Parse("108.161.35.120"),
System.Net.IPAddress.Parse("10.88.250.170"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 91,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("56.247.147.117"),
System.Net.IPAddress.Parse("153.96.127.90"),
System.Net.IPAddress.Parse("190.99.202.188"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 80,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("112.223.244.220"),
System.Net.IPAddress.Parse("80.226.203.138"),
System.Net.IPAddress.Parse("70.203.41.182"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 93,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("152.45.129.103"),
System.Net.IPAddress.Parse("77.76.64.230"),
System.Net.IPAddress.Parse("118.167.214.219"),
System.Net.IPAddress.Parse("31.161.112.194"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 87,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("164.128.209.202"),
System.Net.IPAddress.Parse("207.90.123.224"),
System.Net.IPAddress.Parse("165.183.34.77"),
System.Net.IPAddress.Parse("29.154.248.149"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 99,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("42.96.169.233"),
System.Net.IPAddress.Parse("159.199.109.249"),
System.Net.IPAddress.Parse("229.220.55.152"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 89,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("74.242.231.96"),
System.Net.IPAddress.Parse("137.136.56.214"),
System.Net.IPAddress.Parse("177.218.145.73"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("176.208.202.246"),
System.Net.IPAddress.Parse("49.202.219.32"),
System.Net.IPAddress.Parse("190.131.102.97"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("112.52.165.248"),
System.Net.IPAddress.Parse("54.134.93.115"),
System.Net.IPAddress.Parse("196.164.157.119"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 97,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("218.112.207.164"),
System.Net.IPAddress.Parse("74.83.131.7"),
System.Net.IPAddress.Parse("179.152.82.178"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("22.57.95.52"),
System.Net.IPAddress.Parse("46.100.117.107"),
System.Net.IPAddress.Parse("91.224.99.184"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 112,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("53.66.107.13"),
System.Net.IPAddress.Parse("208.158.40.252"),
System.Net.IPAddress.Parse("168.4.180.232"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 102,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.232.233.28"),
System.Net.IPAddress.Parse("145.246.86.49"),
System.Net.IPAddress.Parse("128.174.99.123"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("45.123.94.240"),
System.Net.IPAddress.Parse("14.170.188.166"),
System.Net.IPAddress.Parse("14.236.201.75"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 121,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("226.244.170.38"),
System.Net.IPAddress.Parse("179.131.31.115"),
System.Net.IPAddress.Parse("202.189.112.87"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 103,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.143.79.199"),
System.Net.IPAddress.Parse("189.215.185.4"),
System.Net.IPAddress.Parse("215.44.42.70"),
System.Net.IPAddress.Parse("224.158.203.179"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 130,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("82.94.197.2"),
System.Net.IPAddress.Parse("185.203.87.13"),
System.Net.IPAddress.Parse("26.205.1.52"),
System.Net.IPAddress.Parse("142.107.74.79"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 108,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("104.120.86.78"),
System.Net.IPAddress.Parse("21.178.217.32"),
System.Net.IPAddress.Parse("118.1.87.72"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 136,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("95.71.220.123"),
System.Net.IPAddress.Parse("74.143.228.14"),
System.Net.IPAddress.Parse("213.202.121.152"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 111,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("13.9.2.114"),
System.Net.IPAddress.Parse("142.72.75.40"),
System.Net.IPAddress.Parse("116.55.161.180"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 137,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("186.36.36.203"),
System.Net.IPAddress.Parse("107.44.173.223"),
System.Net.IPAddress.Parse("104.189.81.146"),
System.Net.IPAddress.Parse("19.78.225.190"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 115,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.177.137.18"),
System.Net.IPAddress.Parse("15.78.59.11"),
System.Net.IPAddress.Parse("154.112.38.138"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 142,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("197.84.84.139"),
System.Net.IPAddress.Parse("85.165.175.13"),
System.Net.IPAddress.Parse("235.1.160.242"),
System.Net.IPAddress.Parse("232.92.17.153"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 119,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("72.139.117.158"),
System.Net.IPAddress.Parse("29.141.1.124"),
System.Net.IPAddress.Parse("1.167.55.19"),
System.Net.IPAddress.Parse("226.249.26.60"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("182.210.66.215"),
System.Net.IPAddress.Parse("157.254.156.127"),
System.Net.IPAddress.Parse("158.80.123.101"),
System.Net.IPAddress.Parse("99.164.155.105"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 149,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("219.180.131.56"),
System.Net.IPAddress.Parse("123.151.60.141"),
System.Net.IPAddress.Parse("114.196.232.241"),
System.Net.IPAddress.Parse("108.70.148.126"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 124,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("102.132.224.160"),
System.Net.IPAddress.Parse("102.1.219.13"),
System.Net.IPAddress.Parse("22.230.107.52"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("177.159.16.147"),
System.Net.IPAddress.Parse("55.72.111.102"),
System.Net.IPAddress.Parse("191.139.171.211"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 150,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("78.223.247.37"),
System.Net.IPAddress.Parse("112.23.78.163"),
System.Net.IPAddress.Parse("245.4.108.248"),
System.Net.IPAddress.Parse("104.178.108.253"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 129,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("8.65.122.114"),
System.Net.IPAddress.Parse("26.171.149.135"),
System.Net.IPAddress.Parse("109.236.225.93"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 151,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("249.254.13.82"),
System.Net.IPAddress.Parse("162.243.203.90"),
System.Net.IPAddress.Parse("167.90.249.17"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 135,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("8.122.161.103"),
System.Net.IPAddress.Parse("24.131.250.41"),
System.Net.IPAddress.Parse("115.170.3.62"),
System.Net.IPAddress.Parse("159.222.160.85"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("137.80.54.28"),
System.Net.IPAddress.Parse("114.1.245.112"),
System.Net.IPAddress.Parse("193.148.41.135"),
System.Net.IPAddress.Parse("188.17.226.53"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 155,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("164.214.75.20"),
System.Net.IPAddress.Parse("178.36.81.234"),
System.Net.IPAddress.Parse("231.49.30.143"),
System.Net.IPAddress.Parse("91.72.20.97"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 137,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("126.160.106.105"),
System.Net.IPAddress.Parse("93.28.131.197"),
System.Net.IPAddress.Parse("246.56.157.13"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("165.35.127.173"),
System.Net.IPAddress.Parse("77.1.140.210"),
System.Net.IPAddress.Parse("205.190.82.175"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 162,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("39.237.142.190"),
System.Net.IPAddress.Parse("239.40.207.134"),
System.Net.IPAddress.Parse("185.64.242.236"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 143,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("42.2.133.60"),
System.Net.IPAddress.Parse("84.16.66.15"),
System.Net.IPAddress.Parse("246.179.190.66"),
System.Net.IPAddress.Parse("205.3.77.251"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("62.157.60.75"),
System.Net.IPAddress.Parse("184.61.174.121"),
System.Net.IPAddress.Parse("80.13.19.198"),
System.Net.IPAddress.Parse("69.6.235.104"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 170,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("96.49.241.223"),
System.Net.IPAddress.Parse("58.7.60.135"),
System.Net.IPAddress.Parse("185.251.112.0"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 145,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("115.71.217.134"),
System.Net.IPAddress.Parse("49.230.34.111"),
System.Net.IPAddress.Parse("217.112.107.217"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("75.31.10.77"),
System.Net.IPAddress.Parse("153.9.201.93"),
System.Net.IPAddress.Parse("40.145.49.124"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 172,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("112.110.214.26"),
System.Net.IPAddress.Parse("186.212.56.77"),
System.Net.IPAddress.Parse("182.78.123.126"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 154,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("214.10.179.84"),
System.Net.IPAddress.Parse("197.128.46.95"),
System.Net.IPAddress.Parse("162.254.138.49"),
System.Net.IPAddress.Parse("38.18.1.210"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 180,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("167.131.177.207"),
System.Net.IPAddress.Parse("69.159.210.117"),
System.Net.IPAddress.Parse("203.169.104.116"),
System.Net.IPAddress.Parse("19.141.246.65"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 160,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("189.40.57.154"),
System.Net.IPAddress.Parse("72.138.85.249"),
System.Net.IPAddress.Parse("207.141.153.123"),
System.Net.IPAddress.Parse("156.27.121.145"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("79.38.194.89"),
System.Net.IPAddress.Parse("254.16.64.207"),
System.Net.IPAddress.Parse("72.64.129.133"),
System.Net.IPAddress.Parse("178.162.5.54"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("249.234.133.131"),
System.Net.IPAddress.Parse("156.210.157.16"),
System.Net.IPAddress.Parse("249.191.5.151"),
System.Net.IPAddress.Parse("142.93.33.196"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 184,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("174.239.182.162"),
System.Net.IPAddress.Parse("205.99.220.4"),
System.Net.IPAddress.Parse("216.10.78.219"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 169,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("158.238.41.149"),
System.Net.IPAddress.Parse("213.108.92.16"),
System.Net.IPAddress.Parse("65.220.85.40"),
System.Net.IPAddress.Parse("218.88.131.133"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("27.124.90.174"),
System.Net.IPAddress.Parse("128.19.162.70"),
System.Net.IPAddress.Parse("147.163.188.57"),
System.Net.IPAddress.Parse("8.233.90.137"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 192,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("94.115.21.67"),
System.Net.IPAddress.Parse("142.192.139.125"),
System.Net.IPAddress.Parse("239.156.193.158"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 170,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("161.153.197.11"),
System.Net.IPAddress.Parse("101.85.146.121"),
System.Net.IPAddress.Parse("8.6.252.86"),
System.Net.IPAddress.Parse("139.195.242.99"),
},
    NullableValue = null,
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

