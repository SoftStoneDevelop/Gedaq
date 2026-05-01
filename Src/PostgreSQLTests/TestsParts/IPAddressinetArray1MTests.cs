

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
    Id = 8,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("126.212.96.152"),
System.Net.IPAddress.Parse("222.36.129.32"),
System.Net.IPAddress.Parse("198.178.217.116"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 10,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("234.107.208.17"),
System.Net.IPAddress.Parse("4.76.27.231"),
System.Net.IPAddress.Parse("222.201.226.118"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 5,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("169.40.87.119"),
System.Net.IPAddress.Parse("252.50.172.128"),
System.Net.IPAddress.Parse("133.89.239.233"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("210.46.93.193"),
System.Net.IPAddress.Parse("16.202.201.208"),
System.Net.IPAddress.Parse("169.161.139.186"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("149.153.219.42"),
System.Net.IPAddress.Parse("231.30.245.254"),
System.Net.IPAddress.Parse("129.191.149.242"),
},
},
            new IPAddressinetArray1M
{
    Id = 15,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("200.174.182.168"),
System.Net.IPAddress.Parse("5.16.156.131"),
System.Net.IPAddress.Parse("238.21.194.125"),
System.Net.IPAddress.Parse("138.114.60.213"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 20,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("14.106.10.103"),
System.Net.IPAddress.Parse("82.112.58.203"),
System.Net.IPAddress.Parse("126.168.53.30"),
System.Net.IPAddress.Parse("166.253.182.121"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 8,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("85.203.195.40"),
System.Net.IPAddress.Parse("137.172.28.227"),
System.Net.IPAddress.Parse("111.126.182.41"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("75.108.111.245"),
System.Net.IPAddress.Parse("217.9.158.161"),
System.Net.IPAddress.Parse("118.36.164.69"),
},
},
            new IPAddressinetArray1M
{
    Id = 22,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("179.38.29.163"),
System.Net.IPAddress.Parse("189.174.214.93"),
System.Net.IPAddress.Parse("32.48.118.139"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("94.205.241.91"),
System.Net.IPAddress.Parse("105.135.142.223"),
System.Net.IPAddress.Parse("237.82.51.14"),
},
},
            new IPAddressinetArray1M
{
    Id = 31,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("142.214.230.138"),
System.Net.IPAddress.Parse("200.101.163.250"),
System.Net.IPAddress.Parse("12.194.253.99"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 17,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("92.47.161.37"),
System.Net.IPAddress.Parse("17.105.227.155"),
System.Net.IPAddress.Parse("236.216.195.30"),
System.Net.IPAddress.Parse("143.3.248.2"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("126.213.0.78"),
System.Net.IPAddress.Parse("72.230.202.17"),
System.Net.IPAddress.Parse("232.174.251.134"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 34,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("162.252.245.53"),
System.Net.IPAddress.Parse("150.98.127.9"),
System.Net.IPAddress.Parse("75.99.7.234"),
System.Net.IPAddress.Parse("107.140.68.88"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 40,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("68.158.254.173"),
System.Net.IPAddress.Parse("107.98.192.132"),
System.Net.IPAddress.Parse("222.195.139.99"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 24,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("173.190.165.6"),
System.Net.IPAddress.Parse("126.44.51.61"),
System.Net.IPAddress.Parse("0.85.221.57"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("229.229.37.206"),
System.Net.IPAddress.Parse("179.137.226.222"),
System.Net.IPAddress.Parse("203.80.152.14"),
System.Net.IPAddress.Parse("36.190.24.123"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 44,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("138.95.59.131"),
System.Net.IPAddress.Parse("104.155.174.116"),
System.Net.IPAddress.Parse("253.180.12.10"),
System.Net.IPAddress.Parse("233.12.233.66"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("234.34.26.91"),
System.Net.IPAddress.Parse("166.149.41.235"),
System.Net.IPAddress.Parse("56.250.193.246"),
},
},
            new IPAddressinetArray1M
{
    Id = 50,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("199.50.198.166"),
System.Net.IPAddress.Parse("37.179.53.151"),
System.Net.IPAddress.Parse("199.16.6.13"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 25,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("133.235.92.31"),
System.Net.IPAddress.Parse("66.42.70.77"),
System.Net.IPAddress.Parse("202.134.185.40"),
System.Net.IPAddress.Parse("148.195.192.145"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("193.235.16.147"),
System.Net.IPAddress.Parse("112.148.36.49"),
System.Net.IPAddress.Parse("4.15.161.230"),
},
},
            new IPAddressinetArray1M
{
    Id = 55,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("246.19.75.170"),
System.Net.IPAddress.Parse("164.74.249.160"),
System.Net.IPAddress.Parse("204.175.176.140"),
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
System.Net.IPAddress.Parse("236.154.192.27"),
System.Net.IPAddress.Parse("199.96.178.247"),
System.Net.IPAddress.Parse("161.242.190.50"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 31,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("138.59.240.241"),
System.Net.IPAddress.Parse("22.12.57.242"),
System.Net.IPAddress.Parse("205.4.241.250"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("14.157.199.62"),
System.Net.IPAddress.Parse("100.95.14.162"),
System.Net.IPAddress.Parse("159.112.227.200"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("250.249.68.127"),
System.Net.IPAddress.Parse("133.123.0.160"),
System.Net.IPAddress.Parse("251.68.22.96"),
System.Net.IPAddress.Parse("240.149.193.24"),
},
},
            new IPAddressinetArray1M
{
    Id = 61,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("117.245.252.45"),
System.Net.IPAddress.Parse("30.117.161.209"),
System.Net.IPAddress.Parse("174.176.102.167"),
System.Net.IPAddress.Parse("109.37.244.30"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 66,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("113.219.153.34"),
System.Net.IPAddress.Parse("245.223.134.200"),
System.Net.IPAddress.Parse("174.197.185.126"),
System.Net.IPAddress.Parse("103.246.228.189"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 34,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("215.102.72.57"),
System.Net.IPAddress.Parse("186.192.238.89"),
System.Net.IPAddress.Parse("210.207.236.245"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("149.112.129.57"),
System.Net.IPAddress.Parse("145.119.40.227"),
System.Net.IPAddress.Parse("173.254.126.15"),
System.Net.IPAddress.Parse("243.195.80.199"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("42.28.4.76"),
System.Net.IPAddress.Parse("136.172.211.74"),
System.Net.IPAddress.Parse("189.121.72.217"),
},
},
            new IPAddressinetArray1M
{
    Id = 71,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("231.25.215.189"),
System.Net.IPAddress.Parse("78.93.108.106"),
System.Net.IPAddress.Parse("193.146.36.199"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("16.37.198.107"),
System.Net.IPAddress.Parse("234.61.242.212"),
System.Net.IPAddress.Parse("80.20.51.223"),
System.Net.IPAddress.Parse("114.159.229.125"),
},
},
            new IPAddressinetArray1M
{
    Id = 79,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("253.102.198.193"),
System.Net.IPAddress.Parse("170.254.111.78"),
System.Net.IPAddress.Parse("219.12.144.187"),
System.Net.IPAddress.Parse("39.115.23.179"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 38,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("147.170.123.108"),
System.Net.IPAddress.Parse("111.53.160.188"),
System.Net.IPAddress.Parse("229.198.10.81"),
System.Net.IPAddress.Parse("212.252.59.204"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("154.231.154.231"),
System.Net.IPAddress.Parse("13.126.136.202"),
System.Net.IPAddress.Parse("8.75.50.10"),
System.Net.IPAddress.Parse("107.193.39.185"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 82,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("27.205.137.178"),
System.Net.IPAddress.Parse("105.218.18.125"),
System.Net.IPAddress.Parse("126.37.21.239"),
System.Net.IPAddress.Parse("134.170.14.69"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("29.135.241.211"),
System.Net.IPAddress.Parse("16.21.144.199"),
System.Net.IPAddress.Parse("58.86.141.109"),
System.Net.IPAddress.Parse("92.237.92.10"),
},
},
            new IPAddressinetArray1M
{
    Id = 91,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("16.223.96.3"),
System.Net.IPAddress.Parse("120.144.232.155"),
System.Net.IPAddress.Parse("193.207.35.124"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 39,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("229.86.248.13"),
System.Net.IPAddress.Parse("5.38.13.206"),
System.Net.IPAddress.Parse("81.169.66.179"),
System.Net.IPAddress.Parse("47.175.158.128"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("100.163.216.219"),
System.Net.IPAddress.Parse("181.254.249.167"),
System.Net.IPAddress.Parse("213.48.46.115"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 97,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.142.174.227"),
System.Net.IPAddress.Parse("151.161.140.102"),
System.Net.IPAddress.Parse("175.214.150.246"),
System.Net.IPAddress.Parse("223.165.178.33"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.175.173.42"),
System.Net.IPAddress.Parse("185.11.242.108"),
System.Net.IPAddress.Parse("219.93.242.154"),
System.Net.IPAddress.Parse("199.148.239.236"),
},
},
            new IPAddressinetArray1M
{
    Id = 98,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("177.234.34.40"),
System.Net.IPAddress.Parse("33.82.247.35"),
System.Net.IPAddress.Parse("69.54.250.88"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 44,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("141.133.75.114"),
System.Net.IPAddress.Parse("221.175.186.121"),
System.Net.IPAddress.Parse("100.127.35.115"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("32.173.238.69"),
System.Net.IPAddress.Parse("222.198.222.163"),
System.Net.IPAddress.Parse("117.123.34.216"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 99,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("53.137.70.227"),
System.Net.IPAddress.Parse("118.32.48.35"),
System.Net.IPAddress.Parse("46.199.97.221"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 103,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("38.45.86.167"),
System.Net.IPAddress.Parse("208.72.172.106"),
System.Net.IPAddress.Parse("111.194.155.107"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 53,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("151.117.222.110"),
System.Net.IPAddress.Parse("72.187.104.33"),
System.Net.IPAddress.Parse("132.118.199.144"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("175.251.75.100"),
System.Net.IPAddress.Parse("247.151.8.211"),
System.Net.IPAddress.Parse("74.194.45.218"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 111,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.31.155.74"),
System.Net.IPAddress.Parse("159.155.3.45"),
System.Net.IPAddress.Parse("184.8.194.41"),
System.Net.IPAddress.Parse("58.166.132.156"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("45.130.190.254"),
System.Net.IPAddress.Parse("225.111.137.5"),
System.Net.IPAddress.Parse("171.226.146.97"),
},
},
            new IPAddressinetArray1M
{
    Id = 117,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("134.153.34.24"),
System.Net.IPAddress.Parse("90.250.223.139"),
System.Net.IPAddress.Parse("167.214.33.32"),
System.Net.IPAddress.Parse("100.9.180.106"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 61,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("73.145.187.5"),
System.Net.IPAddress.Parse("38.67.96.191"),
System.Net.IPAddress.Parse("228.230.236.189"),
System.Net.IPAddress.Parse("125.172.44.62"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("118.221.174.144"),
System.Net.IPAddress.Parse("212.247.97.185"),
System.Net.IPAddress.Parse("180.10.30.88"),
System.Net.IPAddress.Parse("198.156.69.190"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.252.110.87"),
System.Net.IPAddress.Parse("134.219.104.182"),
System.Net.IPAddress.Parse("200.113.138.159"),
System.Net.IPAddress.Parse("250.240.208.233"),
},
},
            new IPAddressinetArray1M
{
    Id = 124,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("82.186.92.158"),
System.Net.IPAddress.Parse("205.2.116.190"),
System.Net.IPAddress.Parse("72.152.238.105"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("191.99.98.130"),
System.Net.IPAddress.Parse("48.91.124.129"),
System.Net.IPAddress.Parse("218.37.49.198"),
System.Net.IPAddress.Parse("78.65.84.129"),
},
},
            new IPAddressinetArray1M
{
    Id = 125,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("249.109.243.218"),
System.Net.IPAddress.Parse("158.199.59.219"),
System.Net.IPAddress.Parse("9.164.204.248"),
System.Net.IPAddress.Parse("38.147.232.213"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 62,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("25.112.217.117"),
System.Net.IPAddress.Parse("130.217.100.203"),
System.Net.IPAddress.Parse("66.89.140.89"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("72.250.226.247"),
System.Net.IPAddress.Parse("78.72.249.106"),
System.Net.IPAddress.Parse("232.69.13.48"),
System.Net.IPAddress.Parse("92.41.36.203"),
},
},
            new IPAddressinetArray1M
{
    Id = 131,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("209.51.27.68"),
System.Net.IPAddress.Parse("45.251.212.151"),
System.Net.IPAddress.Parse("58.82.245.92"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 135,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("72.244.66.210"),
System.Net.IPAddress.Parse("55.100.62.100"),
System.Net.IPAddress.Parse("54.218.215.189"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 67,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("248.39.92.183"),
System.Net.IPAddress.Parse("137.181.44.33"),
System.Net.IPAddress.Parse("23.193.201.77"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("198.20.221.106"),
System.Net.IPAddress.Parse("222.127.223.117"),
System.Net.IPAddress.Parse("223.225.180.7"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 140,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("159.16.85.41"),
System.Net.IPAddress.Parse("191.175.215.56"),
System.Net.IPAddress.Parse("111.36.184.233"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 142,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("97.207.153.53"),
System.Net.IPAddress.Parse("16.161.8.155"),
System.Net.IPAddress.Parse("5.226.18.181"),
System.Net.IPAddress.Parse("116.77.245.49"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 68,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("112.15.187.32"),
System.Net.IPAddress.Parse("241.125.127.199"),
System.Net.IPAddress.Parse("38.11.167.198"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("141.172.29.196"),
System.Net.IPAddress.Parse("49.59.238.140"),
System.Net.IPAddress.Parse("102.234.70.95"),
},
},
            new IPAddressinetArray1M
{
    Id = 148,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("9.120.165.144"),
System.Net.IPAddress.Parse("150.210.248.14"),
System.Net.IPAddress.Parse("1.81.234.155"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("105.102.194.168"),
System.Net.IPAddress.Parse("52.215.120.219"),
System.Net.IPAddress.Parse("65.142.250.217"),
System.Net.IPAddress.Parse("235.105.117.107"),
},
},
            new IPAddressinetArray1M
{
    Id = 150,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("132.195.164.135"),
System.Net.IPAddress.Parse("215.123.2.85"),
System.Net.IPAddress.Parse("32.93.208.60"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 69,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("115.71.21.126"),
System.Net.IPAddress.Parse("28.240.226.11"),
System.Net.IPAddress.Parse("114.250.40.135"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("178.155.62.195"),
System.Net.IPAddress.Parse("164.74.133.70"),
System.Net.IPAddress.Parse("124.23.8.145"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("110.95.202.207"),
System.Net.IPAddress.Parse("202.149.44.97"),
System.Net.IPAddress.Parse("203.132.66.42"),
},
},
            new IPAddressinetArray1M
{
    Id = 152,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("116.160.88.191"),
System.Net.IPAddress.Parse("61.143.23.2"),
System.Net.IPAddress.Parse("175.179.175.23"),
System.Net.IPAddress.Parse("67.220.89.172"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 155,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("236.227.122.160"),
System.Net.IPAddress.Parse("198.105.121.171"),
System.Net.IPAddress.Parse("204.148.193.68"),
System.Net.IPAddress.Parse("152.16.248.212"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 76,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("143.109.54.134"),
System.Net.IPAddress.Parse("34.115.241.243"),
System.Net.IPAddress.Parse("76.122.114.158"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("135.171.141.26"),
System.Net.IPAddress.Parse("243.243.36.39"),
System.Net.IPAddress.Parse("20.71.49.239"),
},
},
            new IPAddressinetArray1M
{
    Id = 164,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("192.13.116.75"),
System.Net.IPAddress.Parse("181.167.245.91"),
System.Net.IPAddress.Parse("174.149.167.23"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("94.205.241.91"),
System.Net.IPAddress.Parse("105.135.142.223"),
System.Net.IPAddress.Parse("237.82.51.14"),
}));
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
                Assert.That(nullable, Is.Null);
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
System.Net.IPAddress.Parse("234.34.26.91"),
System.Net.IPAddress.Parse("166.149.41.235"),
System.Net.IPAddress.Parse("56.250.193.246"),
}));
                nullable =  ((IIPAddressArrayinetArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("193.235.16.147"),
System.Net.IPAddress.Parse("112.148.36.49"),
System.Net.IPAddress.Parse("4.15.161.230"),
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
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("250.249.68.127"),
System.Net.IPAddress.Parse("133.123.0.160"),
System.Net.IPAddress.Parse("251.68.22.96"),
System.Net.IPAddress.Parse("240.149.193.24"),
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[32],_testData[34], false);
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
                parametr1.Value = 125;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[34], false);
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
                parametr1.Value = 111;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[34], false);
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
                parametr2.Value = 91;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[34], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[24],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[25],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                await ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 103, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[34], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 148, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[29],_testData[34], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 57, query1, 97, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 152, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 125, query1, 135, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[34], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 15, query1, 57, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 20, query1, 20, query2))
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
                 ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 131, query1, 150, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 148, 71))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatch(connection, 111, 57))
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
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 15);
                var models = await ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 125);
                var models =  ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                IPAddressinetArray1M.AssertModel(models[0],_testData[26], false);
                IPAddressinetArray1M.AssertModel(models[1],_testData[27], false);
                IPAddressinetArray1M.AssertModel(models[2],_testData[28], false);
                IPAddressinetArray1M.AssertModel(models[3],_testData[29], false);
                IPAddressinetArray1M.AssertModel(models[4],_testData[30], false);
                IPAddressinetArray1M.AssertModel(models[5],_testData[31], false);
                IPAddressinetArray1M.AssertModel(models[6],_testData[32], false);
                IPAddressinetArray1M.AssertModel(models[7],_testData[33], false);
                IPAddressinetArray1M.AssertModel(models[8],_testData[34], false);
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

