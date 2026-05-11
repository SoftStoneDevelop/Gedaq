

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
    internal partial interface IIPAddressMArrayArrayIPv4
    {
    }
    
    internal partial class IPAddressMArrayArrayIPv4 : IIPAddressMArrayArrayIPv4
    {


#region TestData

        private readonly IPAddressArrayIPv4E1M[] _testData = new IPAddressArrayIPv4E1M[]
        {
            new IPAddressArrayIPv4E1M
{
    Id = 5,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("27.216.229.130"),
System.Net.IPAddress.Parse("215.117.92.51"),
System.Net.IPAddress.Parse("79.165.2.1"),
System.Net.IPAddress.Parse("124.182.22.11"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 2,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("222.117.104.173"),
System.Net.IPAddress.Parse("126.101.112.7"),
System.Net.IPAddress.Parse("18.192.109.139"),
System.Net.IPAddress.Parse("181.95.1.150"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("50.47.114.36"),
System.Net.IPAddress.Parse("149.240.105.211"),
System.Net.IPAddress.Parse("246.106.33.170"),
System.Net.IPAddress.Parse("181.217.31.7"),
},
},
    NullableValue = null,
},
            new IPAddressArrayIPv4E1M
{
    Id = 12,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("207.204.40.226"),
System.Net.IPAddress.Parse("54.208.225.37"),
System.Net.IPAddress.Parse("65.67.27.186"),
System.Net.IPAddress.Parse("126.199.207.203"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 9,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("196.142.143.182"),
System.Net.IPAddress.Parse("145.163.128.254"),
System.Net.IPAddress.Parse("193.122.87.248"),
System.Net.IPAddress.Parse("151.210.73.80"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayIPv4E1M
{
    Id = 14,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("198.119.64.189"),
System.Net.IPAddress.Parse("181.53.206.249"),
System.Net.IPAddress.Parse("75.220.71.198"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 14,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("207.154.192.73"),
System.Net.IPAddress.Parse("50.119.62.131"),
System.Net.IPAddress.Parse("48.253.118.155"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayIPv4E1M
{
    Id = 18,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("254.69.10.99"),
System.Net.IPAddress.Parse("228.170.145.229"),
System.Net.IPAddress.Parse("92.177.180.104"),
System.Net.IPAddress.Parse("99.185.227.83"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 18,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("138.170.115.207"),
System.Net.IPAddress.Parse("192.231.243.182"),
System.Net.IPAddress.Parse("232.114.210.215"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("160.43.227.162"),
System.Net.IPAddress.Parse("235.107.214.50"),
System.Net.IPAddress.Parse("166.52.252.55"),
System.Net.IPAddress.Parse("43.97.65.89"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("16.80.95.127"),
System.Net.IPAddress.Parse("108.42.245.249"),
System.Net.IPAddress.Parse("201.93.86.245"),
},
},
            new IPAddressArrayIPv4E1M
{
    Id = 23,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("35.182.246.177"),
System.Net.IPAddress.Parse("78.192.202.202"),
System.Net.IPAddress.Parse("224.5.86.152"),
System.Net.IPAddress.Parse("228.12.74.121"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 25,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("238.182.179.12"),
System.Net.IPAddress.Parse("102.60.67.197"),
System.Net.IPAddress.Parse("61.182.35.138"),
System.Net.IPAddress.Parse("107.160.94.16"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("89.11.215.180"),
System.Net.IPAddress.Parse("134.217.222.27"),
System.Net.IPAddress.Parse("132.190.38.159"),
},
},
            new IPAddressArrayIPv4E1M
{
    Id = 31,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("110.139.233.176"),
System.Net.IPAddress.Parse("135.108.150.153"),
System.Net.IPAddress.Parse("92.144.214.249"),
System.Net.IPAddress.Parse("234.148.82.197"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 32,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("227.132.180.212"),
System.Net.IPAddress.Parse("194.55.87.23"),
System.Net.IPAddress.Parse("27.173.113.48"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("184.82.83.138"),
System.Net.IPAddress.Parse("7.146.87.199"),
System.Net.IPAddress.Parse("98.57.177.183"),
},
},
            new IPAddressArrayIPv4E1M
{
    Id = 33,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("5.145.248.195"),
System.Net.IPAddress.Parse("60.98.254.229"),
System.Net.IPAddress.Parse("75.224.39.81"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 33,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("44.193.246.82"),
System.Net.IPAddress.Parse("105.46.100.132"),
System.Net.IPAddress.Parse("135.138.50.103"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("93.126.69.245"),
System.Net.IPAddress.Parse("128.43.167.40"),
System.Net.IPAddress.Parse("165.197.137.123"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("81.172.56.148"),
System.Net.IPAddress.Parse("227.72.115.4"),
System.Net.IPAddress.Parse("149.22.14.79"),
},
},
            new IPAddressArrayIPv4E1M
{
    Id = 42,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("132.118.196.146"),
System.Net.IPAddress.Parse("41.206.23.99"),
System.Net.IPAddress.Parse("232.38.21.22"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 41,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("225.176.165.196"),
System.Net.IPAddress.Parse("225.215.124.171"),
System.Net.IPAddress.Parse("19.72.173.50"),
System.Net.IPAddress.Parse("147.230.135.246"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("108.10.193.140"),
System.Net.IPAddress.Parse("71.240.51.157"),
System.Net.IPAddress.Parse("234.109.127.157"),
},
},
    NullableValue = null,
},
            new IPAddressArrayIPv4E1M
{
    Id = 47,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("146.235.121.238"),
System.Net.IPAddress.Parse("67.94.138.156"),
System.Net.IPAddress.Parse("142.9.111.158"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 42,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("32.29.183.215"),
System.Net.IPAddress.Parse("228.57.207.138"),
System.Net.IPAddress.Parse("157.99.98.93"),
System.Net.IPAddress.Parse("77.230.203.144"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("184.99.52.247"),
System.Net.IPAddress.Parse("230.129.253.15"),
System.Net.IPAddress.Parse("151.49.47.143"),
},
},
    NullableValue = null,
},
            new IPAddressArrayIPv4E1M
{
    Id = 51,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("186.108.191.136"),
System.Net.IPAddress.Parse("138.114.88.98"),
System.Net.IPAddress.Parse("37.209.96.83"),
System.Net.IPAddress.Parse("125.111.32.166"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 47,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("36.208.17.211"),
System.Net.IPAddress.Parse("53.166.65.178"),
System.Net.IPAddress.Parse("67.241.151.10"),
System.Net.IPAddress.Parse("91.96.20.180"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("129.177.114.170"),
System.Net.IPAddress.Parse("227.81.44.118"),
System.Net.IPAddress.Parse("173.90.102.16"),
},
},
            new IPAddressArrayIPv4E1M
{
    Id = 57,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("12.245.76.238"),
System.Net.IPAddress.Parse("234.74.89.102"),
System.Net.IPAddress.Parse("198.3.101.182"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 50,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("4.35.90.129"),
System.Net.IPAddress.Parse("96.176.138.248"),
System.Net.IPAddress.Parse("228.203.238.104"),
System.Net.IPAddress.Parse("177.99.120.45"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("234.209.68.111"),
System.Net.IPAddress.Parse("135.186.216.193"),
System.Net.IPAddress.Parse("126.94.192.190"),
System.Net.IPAddress.Parse("154.45.175.240"),
},
},
            new IPAddressArrayIPv4E1M
{
    Id = 64,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("54.130.124.73"),
System.Net.IPAddress.Parse("61.61.85.47"),
System.Net.IPAddress.Parse("123.227.0.19"),
System.Net.IPAddress.Parse("110.63.142.248"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 51,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("81.193.100.15"),
System.Net.IPAddress.Parse("123.168.105.253"),
System.Net.IPAddress.Parse("45.109.189.80"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayIPv4E1M
{
    Id = 68,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("189.165.49.212"),
System.Net.IPAddress.Parse("18.240.119.95"),
System.Net.IPAddress.Parse("18.116.249.16"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 56,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("52.224.58.172"),
System.Net.IPAddress.Parse("52.215.72.92"),
System.Net.IPAddress.Parse("247.232.227.223"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayIPv4E1M
{
    Id = 77,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("165.232.176.105"),
System.Net.IPAddress.Parse("77.196.65.186"),
System.Net.IPAddress.Parse("92.76.140.194"),
System.Net.IPAddress.Parse("235.82.55.151"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 61,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("12.90.58.70"),
System.Net.IPAddress.Parse("32.144.127.154"),
System.Net.IPAddress.Parse("181.249.232.234"),
System.Net.IPAddress.Parse("223.145.47.102"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayIPv4E1M
{
    Id = 86,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("232.121.126.128"),
System.Net.IPAddress.Parse("21.242.8.147"),
System.Net.IPAddress.Parse("130.214.226.63"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 67,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("212.127.189.195"),
System.Net.IPAddress.Parse("9.25.172.132"),
System.Net.IPAddress.Parse("62.222.100.29"),
System.Net.IPAddress.Parse("39.20.237.50"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("156.30.213.253"),
System.Net.IPAddress.Parse("127.215.46.89"),
System.Net.IPAddress.Parse("31.175.232.218"),
System.Net.IPAddress.Parse("40.209.166.233"),
},
},
    NullableValue = null,
},
            new IPAddressArrayIPv4E1M
{
    Id = 89,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("14.160.104.26"),
System.Net.IPAddress.Parse("53.25.244.91"),
System.Net.IPAddress.Parse("41.202.186.148"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 76,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("44.79.172.155"),
System.Net.IPAddress.Parse("34.115.93.100"),
System.Net.IPAddress.Parse("3.64.182.109"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("135.16.174.130"),
System.Net.IPAddress.Parse("220.82.143.206"),
System.Net.IPAddress.Parse("86.22.124.249"),
System.Net.IPAddress.Parse("77.130.105.195"),
},
},
    NullableValue = null,
},
            new IPAddressArrayIPv4E1M
{
    Id = 97,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("254.9.202.92"),
System.Net.IPAddress.Parse("139.193.11.142"),
System.Net.IPAddress.Parse("119.149.163.233"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 84,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("36.157.28.95"),
System.Net.IPAddress.Parse("96.40.140.60"),
System.Net.IPAddress.Parse("153.134.89.181"),
System.Net.IPAddress.Parse("113.16.46.85"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("173.150.74.196"),
System.Net.IPAddress.Parse("46.251.122.135"),
System.Net.IPAddress.Parse("102.120.199.97"),
System.Net.IPAddress.Parse("230.120.52.68"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("229.166.131.109"),
System.Net.IPAddress.Parse("31.231.59.219"),
System.Net.IPAddress.Parse("64.64.24.97"),
System.Net.IPAddress.Parse("84.195.43.247"),
},
},
            new IPAddressArrayIPv4E1M
{
    Id = 99,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("108.119.79.139"),
System.Net.IPAddress.Parse("188.201.112.0"),
System.Net.IPAddress.Parse("179.67.245.76"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 85,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("247.113.150.60"),
System.Net.IPAddress.Parse("103.232.76.217"),
System.Net.IPAddress.Parse("109.167.60.241"),
System.Net.IPAddress.Parse("37.97.137.49"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("14.243.159.164"),
System.Net.IPAddress.Parse("11.18.3.237"),
System.Net.IPAddress.Parse("104.6.108.122"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("118.199.128.37"),
System.Net.IPAddress.Parse("16.157.105.203"),
System.Net.IPAddress.Parse("66.248.141.42"),
System.Net.IPAddress.Parse("64.89.249.76"),
},
},
            new IPAddressArrayIPv4E1M
{
    Id = 103,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("166.176.60.44"),
System.Net.IPAddress.Parse("124.178.146.207"),
System.Net.IPAddress.Parse("29.60.252.70"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 94,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("36.110.245.139"),
System.Net.IPAddress.Parse("175.139.47.24"),
System.Net.IPAddress.Parse("90.56.63.40"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayIPv4E1M
{
    Id = 106,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("228.207.51.221"),
System.Net.IPAddress.Parse("54.150.194.206"),
System.Net.IPAddress.Parse("70.111.243.16"),
System.Net.IPAddress.Parse("85.23.2.68"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 95,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("41.183.171.175"),
System.Net.IPAddress.Parse("51.39.12.230"),
System.Net.IPAddress.Parse("120.70.173.90"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("103.244.65.5"),
System.Net.IPAddress.Parse("96.48.98.195"),
System.Net.IPAddress.Parse("189.42.248.183"),
},
},
    NullableValue = null,
},
            new IPAddressArrayIPv4E1M
{
    Id = 108,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("49.129.154.2"),
System.Net.IPAddress.Parse("230.117.113.176"),
System.Net.IPAddress.Parse("52.161.232.91"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 103,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("1.193.55.201"),
System.Net.IPAddress.Parse("100.171.101.161"),
System.Net.IPAddress.Parse("58.64.24.179"),
System.Net.IPAddress.Parse("249.238.207.209"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("45.33.192.195"),
System.Net.IPAddress.Parse("182.102.65.172"),
System.Net.IPAddress.Parse("174.245.19.249"),
System.Net.IPAddress.Parse("78.49.97.155"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("137.20.93.108"),
System.Net.IPAddress.Parse("180.253.114.4"),
System.Net.IPAddress.Parse("70.157.212.201"),
System.Net.IPAddress.Parse("172.97.88.173"),
},
},
            new IPAddressArrayIPv4E1M
{
    Id = 116,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("24.67.143.140"),
System.Net.IPAddress.Parse("197.205.70.224"),
System.Net.IPAddress.Parse("10.241.250.233"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 105,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("166.207.167.188"),
System.Net.IPAddress.Parse("162.73.211.151"),
System.Net.IPAddress.Parse("219.159.248.85"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayIPv4E1M
{
    Id = 125,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("132.67.157.144"),
System.Net.IPAddress.Parse("10.153.212.104"),
System.Net.IPAddress.Parse("248.148.203.169"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 106,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("180.97.210.30"),
System.Net.IPAddress.Parse("237.92.53.228"),
System.Net.IPAddress.Parse("33.164.5.97"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("28.123.2.30"),
System.Net.IPAddress.Parse("154.193.101.217"),
System.Net.IPAddress.Parse("71.18.119.199"),
System.Net.IPAddress.Parse("230.239.118.184"),
},
},
    NullableValue = null,
},
            new IPAddressArrayIPv4E1M
{
    Id = 131,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.231.141.161"),
System.Net.IPAddress.Parse("148.239.54.164"),
System.Net.IPAddress.Parse("187.154.134.230"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 111,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("74.187.112.26"),
System.Net.IPAddress.Parse("14.239.211.139"),
System.Net.IPAddress.Parse("6.44.249.214"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayIPv4E1M
{
    Id = 133,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("14.186.47.140"),
System.Net.IPAddress.Parse("182.253.138.177"),
System.Net.IPAddress.Parse("182.113.26.53"),
System.Net.IPAddress.Parse("229.82.0.21"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 112,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("204.121.213.114"),
System.Net.IPAddress.Parse("166.133.121.201"),
System.Net.IPAddress.Parse("165.252.98.134"),
System.Net.IPAddress.Parse("177.62.2.104"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("217.149.27.152"),
System.Net.IPAddress.Parse("48.59.115.34"),
System.Net.IPAddress.Parse("8.67.190.2"),
},
},
    NullableValue = null,
},
            new IPAddressArrayIPv4E1M
{
    Id = 134,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("110.237.136.93"),
System.Net.IPAddress.Parse("144.167.159.150"),
System.Net.IPAddress.Parse("158.147.53.96"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 113,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("67.176.38.174"),
System.Net.IPAddress.Parse("93.132.223.242"),
System.Net.IPAddress.Parse("223.137.16.149"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayIPv4E1M
{
    Id = 137,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("187.75.48.66"),
System.Net.IPAddress.Parse("224.171.137.94"),
System.Net.IPAddress.Parse("103.132.145.37"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 115,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("71.104.4.71"),
System.Net.IPAddress.Parse("87.235.81.233"),
System.Net.IPAddress.Parse("58.102.247.134"),
System.Net.IPAddress.Parse("41.154.175.169"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("97.125.69.219"),
System.Net.IPAddress.Parse("194.29.42.225"),
System.Net.IPAddress.Parse("91.202.109.21"),
System.Net.IPAddress.Parse("108.71.203.182"),
},
},
            new IPAddressArrayIPv4E1M
{
    Id = 141,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.49.172.98"),
System.Net.IPAddress.Parse("43.94.239.59"),
System.Net.IPAddress.Parse("52.169.175.11"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 118,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("152.0.217.158"),
System.Net.IPAddress.Parse("32.181.18.93"),
System.Net.IPAddress.Parse("76.224.224.136"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("127.175.49.216"),
System.Net.IPAddress.Parse("88.18.175.161"),
System.Net.IPAddress.Parse("140.102.212.55"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("181.86.73.153"),
System.Net.IPAddress.Parse("178.223.212.150"),
System.Net.IPAddress.Parse("89.201.245.197"),
System.Net.IPAddress.Parse("132.229.183.200"),
},
},
            new IPAddressArrayIPv4E1M
{
    Id = 145,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("88.86.239.232"),
System.Net.IPAddress.Parse("234.161.127.88"),
System.Net.IPAddress.Parse("104.52.57.95"),
System.Net.IPAddress.Parse("114.45.31.206"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 120,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("250.105.156.219"),
System.Net.IPAddress.Parse("226.170.227.183"),
System.Net.IPAddress.Parse("134.46.103.247"),
System.Net.IPAddress.Parse("182.228.25.167"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("104.182.157.12"),
System.Net.IPAddress.Parse("79.186.149.11"),
System.Net.IPAddress.Parse("4.68.131.96"),
System.Net.IPAddress.Parse("55.7.27.208"),
},
},
            new IPAddressArrayIPv4E1M
{
    Id = 151,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("239.3.64.142"),
System.Net.IPAddress.Parse("177.243.2.241"),
System.Net.IPAddress.Parse("147.231.24.99"),
System.Net.IPAddress.Parse("116.162.194.75"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 121,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("23.45.226.114"),
System.Net.IPAddress.Parse("2.224.228.220"),
System.Net.IPAddress.Parse("227.7.225.125"),
System.Net.IPAddress.Parse("104.5.181.216"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.107.121.5"),
System.Net.IPAddress.Parse("151.86.205.59"),
System.Net.IPAddress.Parse("4.141.126.39"),
},
},
            new IPAddressArrayIPv4E1M
{
    Id = 153,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("156.6.43.83"),
System.Net.IPAddress.Parse("155.204.118.254"),
System.Net.IPAddress.Parse("225.107.153.195"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 126,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("252.180.103.80"),
System.Net.IPAddress.Parse("225.145.116.32"),
System.Net.IPAddress.Parse("240.209.122.143"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("42.41.78.94"),
System.Net.IPAddress.Parse("43.182.159.64"),
System.Net.IPAddress.Parse("60.81.83.8"),
System.Net.IPAddress.Parse("205.231.220.15"),
},
},
    NullableValue = null,
},
            new IPAddressArrayIPv4E1M
{
    Id = 160,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("111.207.63.217"),
System.Net.IPAddress.Parse("196.17.47.194"),
System.Net.IPAddress.Parse("45.228.73.108"),
System.Net.IPAddress.Parse("94.249.88.46"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 130,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("75.52.183.93"),
System.Net.IPAddress.Parse("178.41.90.170"),
System.Net.IPAddress.Parse("140.126.203.161"),
System.Net.IPAddress.Parse("122.85.143.240"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayIPv4E1M
{
    Id = 168,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("204.143.240.26"),
System.Net.IPAddress.Parse("56.74.10.115"),
System.Net.IPAddress.Parse("213.223.148.27"),
System.Net.IPAddress.Parse("149.114.227.143"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 137,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("25.156.211.109"),
System.Net.IPAddress.Parse("212.163.210.136"),
System.Net.IPAddress.Parse("227.80.68.159"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayIPv4E1M
{
    Id = 175,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("144.109.76.2"),
System.Net.IPAddress.Parse("245.82.160.71"),
System.Net.IPAddress.Parse("197.78.218.36"),
System.Net.IPAddress.Parse("63.199.245.145"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 143,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("161.97.78.217"),
System.Net.IPAddress.Parse("90.224.19.1"),
System.Net.IPAddress.Parse("151.61.193.118"),
System.Net.IPAddress.Parse("100.64.69.39"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("210.179.254.115"),
System.Net.IPAddress.Parse("196.165.12.50"),
System.Net.IPAddress.Parse("77.129.31.39"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("32.137.65.82"),
System.Net.IPAddress.Parse("95.111.14.224"),
System.Net.IPAddress.Parse("220.130.170.115"),
},
},
            new IPAddressArrayIPv4E1M
{
    Id = 178,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("90.34.147.108"),
System.Net.IPAddress.Parse("240.39.173.2"),
System.Net.IPAddress.Parse("56.244.246.192"),
System.Net.IPAddress.Parse("195.209.234.128"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 146,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("28.171.158.145"),
System.Net.IPAddress.Parse("46.84.188.64"),
System.Net.IPAddress.Parse("199.77.42.207"),
System.Net.IPAddress.Parse("12.100.41.79"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("131.40.57.80"),
System.Net.IPAddress.Parse("239.184.58.88"),
System.Net.IPAddress.Parse("202.248.35.170"),
System.Net.IPAddress.Parse("43.41.76.159"),
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
INSERT INTO gedaqtests.ipaddressarrayipv4e1m(
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
            asPartInterface: typeof(IIPAddressMArrayArrayIPv4)),
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
                    await ((IIPAddressMArrayArrayIPv4)this).InsertModelDbConnectionAsync(
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
                     ((IIPAddressMArrayArrayIPv4)this).InsertModelDbConnection(
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
FROM gedaqtests.ipaddressarrayipv4e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(IPAddressArrayIPv4E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayArrayIPv4)),
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
                    var models = await ((IIPAddressMArrayArrayIPv4)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    IPAddressArrayIPv4E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IIPAddressMArrayArrayIPv4)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    IPAddressArrayIPv4E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

