

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
    Id = 7,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("214.142.139.187"),
System.Net.IPAddress.Parse("234.78.147.29"),
System.Net.IPAddress.Parse("195.121.252.99"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("232.253.17.4"),
System.Net.IPAddress.Parse("34.91.221.237"),
System.Net.IPAddress.Parse("236.117.1.176"),
},
},
            new IPAddressinetArray1M
{
    Id = 14,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("140.160.55.234"),
System.Net.IPAddress.Parse("155.14.62.185"),
System.Net.IPAddress.Parse("40.192.203.152"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 7,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("146.159.78.54"),
System.Net.IPAddress.Parse("92.115.195.248"),
System.Net.IPAddress.Parse("89.0.141.22"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("33.4.47.177"),
System.Net.IPAddress.Parse("72.203.100.106"),
System.Net.IPAddress.Parse("134.167.162.188"),
System.Net.IPAddress.Parse("102.91.65.116"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("167.244.139.57"),
System.Net.IPAddress.Parse("119.42.12.166"),
System.Net.IPAddress.Parse("192.154.94.195"),
},
},
            new IPAddressinetArray1M
{
    Id = 20,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("173.107.64.22"),
System.Net.IPAddress.Parse("43.189.94.78"),
System.Net.IPAddress.Parse("220.147.68.79"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("57.209.230.248"),
System.Net.IPAddress.Parse("44.225.246.186"),
System.Net.IPAddress.Parse("43.188.162.252"),
System.Net.IPAddress.Parse("161.238.171.62"),
},
},
            new IPAddressinetArray1M
{
    Id = 29,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("83.88.208.54"),
System.Net.IPAddress.Parse("177.19.125.66"),
System.Net.IPAddress.Parse("184.242.130.48"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 10,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("74.134.158.163"),
System.Net.IPAddress.Parse("250.41.73.81"),
System.Net.IPAddress.Parse("54.112.234.201"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("219.111.89.49"),
System.Net.IPAddress.Parse("137.102.116.91"),
System.Net.IPAddress.Parse("126.186.174.10"),
},
},
            new IPAddressinetArray1M
{
    Id = 30,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("207.132.100.179"),
System.Net.IPAddress.Parse("191.171.217.114"),
System.Net.IPAddress.Parse("129.62.225.153"),
System.Net.IPAddress.Parse("92.2.99.55"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 33,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("181.135.243.72"),
System.Net.IPAddress.Parse("35.25.24.140"),
System.Net.IPAddress.Parse("73.227.179.232"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 14,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("107.228.146.207"),
System.Net.IPAddress.Parse("70.35.199.126"),
System.Net.IPAddress.Parse("96.191.195.172"),
System.Net.IPAddress.Parse("117.191.54.97"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("163.232.10.113"),
System.Net.IPAddress.Parse("12.171.128.81"),
System.Net.IPAddress.Parse("17.57.109.248"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("21.151.160.143"),
System.Net.IPAddress.Parse("223.95.204.113"),
System.Net.IPAddress.Parse("27.160.185.49"),
System.Net.IPAddress.Parse("249.127.119.139"),
},
},
            new IPAddressinetArray1M
{
    Id = 34,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("204.181.189.137"),
System.Net.IPAddress.Parse("10.234.125.251"),
System.Net.IPAddress.Parse("151.108.32.32"),
System.Net.IPAddress.Parse("128.70.77.67"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 39,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("176.44.217.117"),
System.Net.IPAddress.Parse("222.96.43.135"),
System.Net.IPAddress.Parse("1.191.40.147"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 15,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("0.202.241.30"),
System.Net.IPAddress.Parse("158.191.228.15"),
System.Net.IPAddress.Parse("72.79.33.218"),
System.Net.IPAddress.Parse("237.182.226.187"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("92.43.219.173"),
System.Net.IPAddress.Parse("80.95.236.223"),
System.Net.IPAddress.Parse("10.7.111.40"),
System.Net.IPAddress.Parse("18.158.61.227"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 40,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("116.211.102.105"),
System.Net.IPAddress.Parse("127.27.13.225"),
System.Net.IPAddress.Parse("77.201.196.227"),
System.Net.IPAddress.Parse("244.141.61.201"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("70.97.244.53"),
System.Net.IPAddress.Parse("152.55.11.171"),
System.Net.IPAddress.Parse("168.76.141.242"),
System.Net.IPAddress.Parse("72.5.59.81"),
},
},
            new IPAddressinetArray1M
{
    Id = 48,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("223.177.64.208"),
System.Net.IPAddress.Parse("30.97.14.205"),
System.Net.IPAddress.Parse("108.228.16.254"),
System.Net.IPAddress.Parse("99.12.86.157"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 19,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("57.80.220.248"),
System.Net.IPAddress.Parse("131.186.28.6"),
System.Net.IPAddress.Parse("195.77.223.22"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 52,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("58.138.191.59"),
System.Net.IPAddress.Parse("183.128.85.153"),
System.Net.IPAddress.Parse("68.19.20.203"),
System.Net.IPAddress.Parse("37.49.16.245"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 53,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("164.8.138.77"),
System.Net.IPAddress.Parse("142.66.162.153"),
System.Net.IPAddress.Parse("101.81.177.200"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 22,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("102.19.109.225"),
System.Net.IPAddress.Parse("47.46.191.168"),
System.Net.IPAddress.Parse("175.3.245.141"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 58,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("43.193.4.232"),
System.Net.IPAddress.Parse("149.132.246.56"),
System.Net.IPAddress.Parse("198.134.20.218"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("202.64.141.46"),
System.Net.IPAddress.Parse("214.89.241.125"),
System.Net.IPAddress.Parse("32.114.154.123"),
},
},
            new IPAddressinetArray1M
{
    Id = 61,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("223.237.69.39"),
System.Net.IPAddress.Parse("181.90.244.165"),
System.Net.IPAddress.Parse("22.199.71.33"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 26,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("161.208.214.135"),
System.Net.IPAddress.Parse("152.5.83.161"),
System.Net.IPAddress.Parse("37.176.97.228"),
System.Net.IPAddress.Parse("193.129.117.51"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("78.159.28.171"),
System.Net.IPAddress.Parse("141.129.111.128"),
System.Net.IPAddress.Parse("9.44.102.171"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 62,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("189.106.157.192"),
System.Net.IPAddress.Parse("248.22.230.238"),
System.Net.IPAddress.Parse("185.123.147.67"),
System.Net.IPAddress.Parse("173.141.195.129"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("170.74.46.160"),
System.Net.IPAddress.Parse("44.27.181.42"),
System.Net.IPAddress.Parse("63.86.141.168"),
System.Net.IPAddress.Parse("71.86.140.172"),
},
},
            new IPAddressinetArray1M
{
    Id = 65,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("143.184.35.224"),
System.Net.IPAddress.Parse("15.200.117.73"),
System.Net.IPAddress.Parse("249.150.73.101"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 35,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("55.97.63.178"),
System.Net.IPAddress.Parse("139.242.6.9"),
System.Net.IPAddress.Parse("67.204.41.125"),
System.Net.IPAddress.Parse("101.54.145.113"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("190.66.161.28"),
System.Net.IPAddress.Parse("212.222.226.87"),
System.Net.IPAddress.Parse("142.211.119.226"),
System.Net.IPAddress.Parse("119.229.29.74"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 71,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("129.225.105.78"),
System.Net.IPAddress.Parse("249.34.175.210"),
System.Net.IPAddress.Parse("28.76.160.153"),
System.Net.IPAddress.Parse("165.235.98.110"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 79,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("118.237.84.7"),
System.Net.IPAddress.Parse("84.79.194.159"),
System.Net.IPAddress.Parse("203.186.92.206"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 43,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("55.160.18.253"),
System.Net.IPAddress.Parse("199.247.116.90"),
System.Net.IPAddress.Parse("73.72.93.159"),
System.Net.IPAddress.Parse("250.212.123.83"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("239.136.252.203"),
System.Net.IPAddress.Parse("168.71.122.82"),
System.Net.IPAddress.Parse("4.89.106.226"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 86,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("224.67.220.79"),
System.Net.IPAddress.Parse("236.205.120.65"),
System.Net.IPAddress.Parse("214.59.84.119"),
System.Net.IPAddress.Parse("143.93.198.18"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 93,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("9.154.194.154"),
System.Net.IPAddress.Parse("60.17.19.79"),
System.Net.IPAddress.Parse("96.238.136.139"),
System.Net.IPAddress.Parse("35.79.47.188"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 52,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("247.132.71.15"),
System.Net.IPAddress.Parse("135.202.181.83"),
System.Net.IPAddress.Parse("226.54.22.10"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("232.140.213.239"),
System.Net.IPAddress.Parse("92.152.111.97"),
System.Net.IPAddress.Parse("118.29.111.111"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.143.185.245"),
System.Net.IPAddress.Parse("151.198.144.161"),
System.Net.IPAddress.Parse("186.166.149.138"),
System.Net.IPAddress.Parse("87.207.240.6"),
},
},
            new IPAddressinetArray1M
{
    Id = 100,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("8.41.83.225"),
System.Net.IPAddress.Parse("240.232.71.18"),
System.Net.IPAddress.Parse("250.74.96.45"),
System.Net.IPAddress.Parse("22.190.206.78"),
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
System.Net.IPAddress.Parse("10.126.35.71"),
System.Net.IPAddress.Parse("137.175.119.136"),
System.Net.IPAddress.Parse("16.106.41.187"),
System.Net.IPAddress.Parse("210.157.100.9"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 59,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("73.114.74.118"),
System.Net.IPAddress.Parse("167.17.172.107"),
System.Net.IPAddress.Parse("173.201.29.77"),
System.Net.IPAddress.Parse("120.157.106.150"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("54.108.78.134"),
System.Net.IPAddress.Parse("242.117.227.49"),
System.Net.IPAddress.Parse("104.233.192.245"),
System.Net.IPAddress.Parse("241.190.9.29"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 105,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("95.86.83.253"),
System.Net.IPAddress.Parse("239.190.30.126"),
System.Net.IPAddress.Parse("105.154.107.150"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 109,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("253.114.204.147"),
System.Net.IPAddress.Parse("59.33.116.108"),
System.Net.IPAddress.Parse("154.220.99.229"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 62,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("207.232.210.157"),
System.Net.IPAddress.Parse("86.175.83.8"),
System.Net.IPAddress.Parse("174.39.176.48"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("228.115.71.84"),
System.Net.IPAddress.Parse("65.3.32.151"),
System.Net.IPAddress.Parse("50.246.188.98"),
System.Net.IPAddress.Parse("166.142.194.229"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("173.83.216.140"),
System.Net.IPAddress.Parse("42.105.0.181"),
System.Net.IPAddress.Parse("79.144.27.250"),
},
},
            new IPAddressinetArray1M
{
    Id = 110,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("26.40.40.65"),
System.Net.IPAddress.Parse("217.104.19.227"),
System.Net.IPAddress.Parse("242.17.192.205"),
System.Net.IPAddress.Parse("120.150.20.244"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 112,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("158.181.249.216"),
System.Net.IPAddress.Parse("35.243.8.127"),
System.Net.IPAddress.Parse("97.70.98.145"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 66,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("136.32.36.235"),
System.Net.IPAddress.Parse("188.186.35.227"),
System.Net.IPAddress.Parse("118.154.85.141"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("125.165.80.64"),
System.Net.IPAddress.Parse("176.87.118.175"),
System.Net.IPAddress.Parse("63.228.70.155"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 118,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("237.230.111.241"),
System.Net.IPAddress.Parse("112.138.171.154"),
System.Net.IPAddress.Parse("239.209.156.169"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 122,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("9.248.146.34"),
System.Net.IPAddress.Parse("216.18.142.184"),
System.Net.IPAddress.Parse("171.115.125.194"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 70,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("160.195.251.199"),
System.Net.IPAddress.Parse("123.163.39.46"),
System.Net.IPAddress.Parse("89.228.29.208"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 126,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("224.177.168.225"),
System.Net.IPAddress.Parse("181.61.148.89"),
System.Net.IPAddress.Parse("150.118.245.90"),
System.Net.IPAddress.Parse("108.63.108.165"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 128,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("240.123.0.185"),
System.Net.IPAddress.Parse("31.201.75.152"),
System.Net.IPAddress.Parse("218.192.73.62"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 79,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("197.92.20.31"),
System.Net.IPAddress.Parse("179.9.203.150"),
System.Net.IPAddress.Parse("242.122.136.115"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 132,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("135.133.190.75"),
System.Net.IPAddress.Parse("33.195.60.114"),
System.Net.IPAddress.Parse("210.159.71.156"),
System.Net.IPAddress.Parse("7.75.174.238"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("130.238.25.113"),
System.Net.IPAddress.Parse("27.198.102.84"),
System.Net.IPAddress.Parse("196.233.158.214"),
System.Net.IPAddress.Parse("245.247.173.134"),
},
},
            new IPAddressinetArray1M
{
    Id = 133,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("136.208.247.197"),
System.Net.IPAddress.Parse("249.64.126.49"),
System.Net.IPAddress.Parse("182.145.70.37"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 84,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("203.35.222.146"),
System.Net.IPAddress.Parse("36.134.66.27"),
System.Net.IPAddress.Parse("4.242.30.120"),
System.Net.IPAddress.Parse("234.25.84.252"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("91.21.27.145"),
System.Net.IPAddress.Parse("133.245.141.67"),
System.Net.IPAddress.Parse("42.51.11.13"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("210.14.72.218"),
System.Net.IPAddress.Parse("227.141.7.213"),
System.Net.IPAddress.Parse("242.218.73.57"),
System.Net.IPAddress.Parse("174.214.224.20"),
},
},
            new IPAddressinetArray1M
{
    Id = 139,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("84.68.35.207"),
System.Net.IPAddress.Parse("181.71.36.172"),
System.Net.IPAddress.Parse("92.248.218.42"),
System.Net.IPAddress.Parse("36.231.116.76"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("154.191.185.146"),
System.Net.IPAddress.Parse("200.244.188.154"),
System.Net.IPAddress.Parse("166.131.230.204"),
System.Net.IPAddress.Parse("208.43.168.29"),
},
},
            new IPAddressinetArray1M
{
    Id = 148,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("210.222.244.238"),
System.Net.IPAddress.Parse("43.122.53.243"),
System.Net.IPAddress.Parse("237.64.247.213"),
System.Net.IPAddress.Parse("96.72.99.191"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 85,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("53.232.150.5"),
System.Net.IPAddress.Parse("11.181.152.90"),
System.Net.IPAddress.Parse("144.166.87.245"),
System.Net.IPAddress.Parse("102.183.239.3"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 156,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("230.180.177.200"),
System.Net.IPAddress.Parse("231.166.242.8"),
System.Net.IPAddress.Parse("200.83.127.145"),
System.Net.IPAddress.Parse("175.186.33.169"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("168.244.33.73"),
System.Net.IPAddress.Parse("74.185.110.203"),
System.Net.IPAddress.Parse("44.181.166.154"),
System.Net.IPAddress.Parse("54.223.159.146"),
},
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("21.151.160.143"),
System.Net.IPAddress.Parse("223.95.204.113"),
System.Net.IPAddress.Parse("27.160.185.49"),
System.Net.IPAddress.Parse("249.127.119.139"),
}));
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
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("70.97.244.53"),
System.Net.IPAddress.Parse("152.55.11.171"),
System.Net.IPAddress.Parse("168.76.141.242"),
System.Net.IPAddress.Parse("72.5.59.81"),
}));
                nullable =  ((IIPAddressArrayinetArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[34], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[26],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[34], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[34], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[34], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 128, query1, 139, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 14, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                 ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 7, query1, 139, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 86, query1, 105, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 105, query1, 40, query2))
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
                await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 122, query1, 65, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 7, query1, 103, query2))
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
                 ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 122, query1, 109, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 79, 133))
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatch(connection, 62, 34))
                {
                    if(++resultIndex == 1)
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

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 39);
                var models = await ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                IPAddressinetArray1M.AssertModel(models[0],_testData[8], false);
                IPAddressinetArray1M.AssertModel(models[1],_testData[9], false);
                IPAddressinetArray1M.AssertModel(models[2],_testData[10], false);
                IPAddressinetArray1M.AssertModel(models[3],_testData[11], false);
                IPAddressinetArray1M.AssertModel(models[4],_testData[12], false);
                IPAddressinetArray1M.AssertModel(models[5],_testData[13], false);
                IPAddressinetArray1M.AssertModel(models[6],_testData[14], false);
                IPAddressinetArray1M.AssertModel(models[7],_testData[15], false);
                IPAddressinetArray1M.AssertModel(models[8],_testData[16], false);
                IPAddressinetArray1M.AssertModel(models[9],_testData[17], false);
                IPAddressinetArray1M.AssertModel(models[10],_testData[18], false);
                IPAddressinetArray1M.AssertModel(models[11],_testData[19], false);
                IPAddressinetArray1M.AssertModel(models[12],_testData[20], false);
                IPAddressinetArray1M.AssertModel(models[13],_testData[21], false);
                IPAddressinetArray1M.AssertModel(models[14],_testData[22], false);
                IPAddressinetArray1M.AssertModel(models[15],_testData[23], false);
                IPAddressinetArray1M.AssertModel(models[16],_testData[24], false);
                IPAddressinetArray1M.AssertModel(models[17],_testData[25], false);
                IPAddressinetArray1M.AssertModel(models[18],_testData[26], false);
                IPAddressinetArray1M.AssertModel(models[19],_testData[27], false);
                IPAddressinetArray1M.AssertModel(models[20],_testData[28], false);
                IPAddressinetArray1M.AssertModel(models[21],_testData[29], false);
                IPAddressinetArray1M.AssertModel(models[22],_testData[30], false);
                IPAddressinetArray1M.AssertModel(models[23],_testData[31], false);
                IPAddressinetArray1M.AssertModel(models[24],_testData[32], false);
                IPAddressinetArray1M.AssertModel(models[25],_testData[33], false);
                IPAddressinetArray1M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 14);
                var models =  ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

