

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
    internal partial interface IIPAddressMArrayinetMMArrayD1
    {
    }
    
    internal partial class IPAddressMArrayinetMMArrayD1 : IIPAddressMArrayinetMMArrayD1
    {


#region TestData

        private readonly IPAddressinetMMArrayD1E1M[] _testData = new IPAddressinetMMArrayD1E1M[]
        {
            new IPAddressinetMMArrayD1E1M
{
    Id = 5,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("28.166.95.210"),
System.Net.IPAddress.Parse("8.160.240.16"),
System.Net.IPAddress.Parse("30.152.63.217"),
System.Net.IPAddress.Parse("78.242.3.164"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("84.136.199.143"),
System.Net.IPAddress.Parse("201.249.74.190"),
System.Net.IPAddress.Parse("61.100.8.233"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 12,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.37.150.0"),
System.Net.IPAddress.Parse("235.212.203.207"),
System.Net.IPAddress.Parse("107.187.38.61"),
System.Net.IPAddress.Parse("113.205.126.121"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 6,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("58.212.154.182"),
System.Net.IPAddress.Parse("146.158.241.37"),
System.Net.IPAddress.Parse("152.86.164.95"),
System.Net.IPAddress.Parse("220.116.252.111"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("226.232.126.225"),
System.Net.IPAddress.Parse("67.16.184.180"),
System.Net.IPAddress.Parse("201.134.94.57"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("81.69.184.58"),
System.Net.IPAddress.Parse("75.210.15.85"),
System.Net.IPAddress.Parse("227.112.232.224"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 17,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("250.242.31.88"),
System.Net.IPAddress.Parse("246.231.79.146"),
System.Net.IPAddress.Parse("118.39.174.190"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("68.188.144.21"),
System.Net.IPAddress.Parse("6.119.219.43"),
System.Net.IPAddress.Parse("93.123.251.239"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 25,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("130.196.6.35"),
System.Net.IPAddress.Parse("31.135.194.172"),
System.Net.IPAddress.Parse("175.33.43.117"),
System.Net.IPAddress.Parse("13.154.63.238"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 13,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("79.181.110.235"),
System.Net.IPAddress.Parse("88.69.221.87"),
System.Net.IPAddress.Parse("80.54.137.238"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("173.184.8.18"),
System.Net.IPAddress.Parse("2.126.252.245"),
System.Net.IPAddress.Parse("178.113.49.137"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 32,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("51.218.223.91"),
System.Net.IPAddress.Parse("96.78.190.118"),
System.Net.IPAddress.Parse("42.141.115.234"),
System.Net.IPAddress.Parse("186.173.152.25"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("42.21.75.118"),
System.Net.IPAddress.Parse("231.61.61.246"),
System.Net.IPAddress.Parse("213.135.21.109"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 37,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("127.165.77.25"),
System.Net.IPAddress.Parse("21.246.125.132"),
System.Net.IPAddress.Parse("109.71.20.210"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 14,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("197.188.26.52"),
System.Net.IPAddress.Parse("83.55.36.213"),
System.Net.IPAddress.Parse("251.118.15.240"),
System.Net.IPAddress.Parse("2.120.46.147"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("192.222.78.159"),
System.Net.IPAddress.Parse("3.207.54.230"),
System.Net.IPAddress.Parse("171.209.254.204"),
System.Net.IPAddress.Parse("198.115.205.253"),
},
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 41,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("177.182.90.37"),
System.Net.IPAddress.Parse("102.51.138.4"),
System.Net.IPAddress.Parse("63.236.217.222"),
System.Net.IPAddress.Parse("50.207.107.26"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 50,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.240.211.30"),
System.Net.IPAddress.Parse("152.153.167.156"),
System.Net.IPAddress.Parse("74.185.11.9"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 20,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("154.65.161.3"),
System.Net.IPAddress.Parse("178.247.109.254"),
System.Net.IPAddress.Parse("30.166.89.9"),
System.Net.IPAddress.Parse("113.231.83.52"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 53,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("212.249.39.199"),
System.Net.IPAddress.Parse("160.73.187.238"),
System.Net.IPAddress.Parse("40.196.192.212"),
System.Net.IPAddress.Parse("41.135.59.226"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("126.248.88.21"),
System.Net.IPAddress.Parse("220.164.159.224"),
System.Net.IPAddress.Parse("205.240.166.181"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 54,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("48.20.81.98"),
System.Net.IPAddress.Parse("214.201.79.12"),
System.Net.IPAddress.Parse("237.249.217.46"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 23,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("67.161.131.219"),
System.Net.IPAddress.Parse("129.73.153.189"),
System.Net.IPAddress.Parse("203.154.91.131"),
System.Net.IPAddress.Parse("159.248.121.185"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("206.222.146.189"),
System.Net.IPAddress.Parse("83.254.24.226"),
System.Net.IPAddress.Parse("198.63.92.127"),
System.Net.IPAddress.Parse("48.66.67.5"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("13.31.147.165"),
System.Net.IPAddress.Parse("101.7.64.99"),
System.Net.IPAddress.Parse("22.187.171.136"),
System.Net.IPAddress.Parse("143.138.24.76"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 62,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("201.190.129.234"),
System.Net.IPAddress.Parse("129.1.99.102"),
System.Net.IPAddress.Parse("166.22.96.190"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 63,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("47.113.27.175"),
System.Net.IPAddress.Parse("181.120.143.229"),
System.Net.IPAddress.Parse("35.3.204.62"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 26,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("238.58.66.88"),
System.Net.IPAddress.Parse("37.15.199.120"),
System.Net.IPAddress.Parse("111.210.34.120"),
System.Net.IPAddress.Parse("183.131.175.182"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 67,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("89.80.44.123"),
System.Net.IPAddress.Parse("120.55.240.242"),
System.Net.IPAddress.Parse("97.120.49.119"),
System.Net.IPAddress.Parse("174.225.170.166"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("43.18.207.164"),
System.Net.IPAddress.Parse("183.19.208.77"),
System.Net.IPAddress.Parse("88.196.221.178"),
System.Net.IPAddress.Parse("25.171.164.206"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 73,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("246.115.212.165"),
System.Net.IPAddress.Parse("155.192.198.62"),
System.Net.IPAddress.Parse("202.27.157.207"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 35,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("224.41.250.107"),
System.Net.IPAddress.Parse("61.71.47.252"),
System.Net.IPAddress.Parse("248.197.61.131"),
System.Net.IPAddress.Parse("112.117.240.169"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("107.86.201.93"),
System.Net.IPAddress.Parse("190.30.229.185"),
System.Net.IPAddress.Parse("115.174.106.108"),
System.Net.IPAddress.Parse("84.215.221.183"),
},
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 79,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("251.8.214.77"),
System.Net.IPAddress.Parse("156.208.206.129"),
System.Net.IPAddress.Parse("13.105.85.76"),
System.Net.IPAddress.Parse("115.228.148.139"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("239.1.148.227"),
System.Net.IPAddress.Parse("162.135.119.112"),
System.Net.IPAddress.Parse("23.120.229.118"),
System.Net.IPAddress.Parse("5.2.144.239"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 81,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("85.121.146.47"),
System.Net.IPAddress.Parse("135.31.27.170"),
System.Net.IPAddress.Parse("99.156.100.216"),
System.Net.IPAddress.Parse("92.251.243.40"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 40,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("108.32.105.200"),
System.Net.IPAddress.Parse("130.228.227.32"),
System.Net.IPAddress.Parse("95.231.120.130"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("182.230.241.5"),
System.Net.IPAddress.Parse("144.16.75.12"),
System.Net.IPAddress.Parse("227.243.169.212"),
System.Net.IPAddress.Parse("15.45.39.99"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("240.121.217.17"),
System.Net.IPAddress.Parse("46.15.51.31"),
System.Net.IPAddress.Parse("72.164.122.95"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 86,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("61.220.152.48"),
System.Net.IPAddress.Parse("2.171.163.250"),
System.Net.IPAddress.Parse("76.78.34.177"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 88,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("51.221.99.198"),
System.Net.IPAddress.Parse("54.68.215.87"),
System.Net.IPAddress.Parse("136.218.104.76"),
System.Net.IPAddress.Parse("81.172.197.73"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 41,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("162.55.77.28"),
System.Net.IPAddress.Parse("123.12.23.232"),
System.Net.IPAddress.Parse("102.66.229.123"),
System.Net.IPAddress.Parse("199.176.20.78"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 97,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.96.240.227"),
System.Net.IPAddress.Parse("37.126.139.211"),
System.Net.IPAddress.Parse("53.244.71.254"),
System.Net.IPAddress.Parse("97.191.114.124"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 104,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("30.99.248.104"),
System.Net.IPAddress.Parse("214.90.231.231"),
System.Net.IPAddress.Parse("70.74.98.253"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 50,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("95.192.62.226"),
System.Net.IPAddress.Parse("221.210.122.71"),
System.Net.IPAddress.Parse("97.117.116.154"),
System.Net.IPAddress.Parse("229.189.2.32"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("12.81.218.220"),
System.Net.IPAddress.Parse("196.9.207.14"),
System.Net.IPAddress.Parse("156.247.133.137"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 111,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("17.210.65.91"),
System.Net.IPAddress.Parse("54.237.231.244"),
System.Net.IPAddress.Parse("102.123.115.223"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 114,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("242.85.55.20"),
System.Net.IPAddress.Parse("1.190.0.153"),
System.Net.IPAddress.Parse("140.158.247.30"),
System.Net.IPAddress.Parse("139.205.171.20"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 59,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("81.115.65.14"),
System.Net.IPAddress.Parse("158.225.162.178"),
System.Net.IPAddress.Parse("248.217.116.108"),
System.Net.IPAddress.Parse("232.114.34.246"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 123,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("171.114.109.44"),
System.Net.IPAddress.Parse("112.197.169.3"),
System.Net.IPAddress.Parse("97.229.146.76"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 128,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("148.38.181.163"),
System.Net.IPAddress.Parse("174.185.179.161"),
System.Net.IPAddress.Parse("112.102.109.17"),
System.Net.IPAddress.Parse("174.248.160.241"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 62,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("136.252.38.94"),
System.Net.IPAddress.Parse("84.29.218.254"),
System.Net.IPAddress.Parse("103.187.37.218"),
System.Net.IPAddress.Parse("89.47.65.3"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 134,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("227.179.141.124"),
System.Net.IPAddress.Parse("107.54.90.49"),
System.Net.IPAddress.Parse("238.76.27.62"),
System.Net.IPAddress.Parse("43.72.143.28"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("42.219.129.75"),
System.Net.IPAddress.Parse("27.219.247.160"),
System.Net.IPAddress.Parse("56.99.115.139"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 141,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("182.116.75.89"),
System.Net.IPAddress.Parse("51.42.139.3"),
System.Net.IPAddress.Parse("201.43.96.155"),
System.Net.IPAddress.Parse("144.253.154.97"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 64,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("145.125.76.218"),
System.Net.IPAddress.Parse("3.40.54.44"),
System.Net.IPAddress.Parse("200.251.46.114"),
System.Net.IPAddress.Parse("253.145.21.108"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("151.173.226.152"),
System.Net.IPAddress.Parse("144.74.112.156"),
System.Net.IPAddress.Parse("88.126.37.99"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 145,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("33.213.132.28"),
System.Net.IPAddress.Parse("199.71.210.93"),
System.Net.IPAddress.Parse("165.151.123.174"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("229.6.112.102"),
System.Net.IPAddress.Parse("222.1.8.192"),
System.Net.IPAddress.Parse("17.184.103.154"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 154,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("200.165.188.134"),
System.Net.IPAddress.Parse("3.160.186.26"),
System.Net.IPAddress.Parse("173.153.177.57"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 65,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("233.108.5.32"),
System.Net.IPAddress.Parse("63.182.186.108"),
System.Net.IPAddress.Parse("173.61.181.64"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.189.224.144"),
System.Net.IPAddress.Parse("243.72.6.5"),
System.Net.IPAddress.Parse("32.149.26.78"),
},
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 157,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("33.217.167.83"),
System.Net.IPAddress.Parse("244.166.221.242"),
System.Net.IPAddress.Parse("63.94.165.254"),
System.Net.IPAddress.Parse("200.134.22.43"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 161,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("116.156.102.13"),
System.Net.IPAddress.Parse("155.235.135.16"),
System.Net.IPAddress.Parse("51.85.56.246"),
System.Net.IPAddress.Parse("67.48.60.97"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 67,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("84.99.33.130"),
System.Net.IPAddress.Parse("120.201.19.213"),
System.Net.IPAddress.Parse("95.209.161.41"),
System.Net.IPAddress.Parse("194.231.192.176"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("149.47.194.169"),
System.Net.IPAddress.Parse("16.197.60.150"),
System.Net.IPAddress.Parse("193.95.58.213"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 169,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("30.146.51.108"),
System.Net.IPAddress.Parse("26.126.242.106"),
System.Net.IPAddress.Parse("95.22.250.193"),
System.Net.IPAddress.Parse("7.132.241.166"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("252.27.4.241"),
System.Net.IPAddress.Parse("171.89.167.175"),
System.Net.IPAddress.Parse("106.36.104.178"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 172,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("136.107.5.145"),
System.Net.IPAddress.Parse("7.31.242.104"),
System.Net.IPAddress.Parse("50.200.232.73"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 68,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("142.23.159.46"),
System.Net.IPAddress.Parse("231.140.96.153"),
System.Net.IPAddress.Parse("67.25.145.86"),
System.Net.IPAddress.Parse("247.188.117.181"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("73.57.205.84"),
System.Net.IPAddress.Parse("134.52.235.75"),
System.Net.IPAddress.Parse("142.43.208.167"),
System.Net.IPAddress.Parse("129.5.29.79"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.249.158.215"),
System.Net.IPAddress.Parse("25.188.69.2"),
System.Net.IPAddress.Parse("21.228.176.154"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 179,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("78.171.79.244"),
System.Net.IPAddress.Parse("91.90.247.40"),
System.Net.IPAddress.Parse("137.26.128.107"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("164.74.216.55"),
System.Net.IPAddress.Parse("69.236.204.27"),
System.Net.IPAddress.Parse("41.211.3.197"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 185,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("128.221.206.92"),
System.Net.IPAddress.Parse("3.198.13.248"),
System.Net.IPAddress.Parse("79.76.111.195"),
System.Net.IPAddress.Parse("225.75.51.156"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 71,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.189.155.184"),
System.Net.IPAddress.Parse("198.8.212.141"),
System.Net.IPAddress.Parse("34.249.61.46"),
System.Net.IPAddress.Parse("191.88.109.185"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("182.210.158.34"),
System.Net.IPAddress.Parse("29.171.52.164"),
System.Net.IPAddress.Parse("41.195.205.56"),
System.Net.IPAddress.Parse("34.122.109.202"),
},
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 189,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.96.153.122"),
System.Net.IPAddress.Parse("111.225.19.180"),
System.Net.IPAddress.Parse("83.153.64.201"),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmmarrayd1e1mi(
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
INSERT INTO public.ipaddressinetmmarrayd1e1mi(
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
            queryMapTypes: [typeof(IPAddressinetMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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

                changedRows =  ((IIPAddressMArrayinetMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IIPAddressMArrayinetMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IIPAddressMArrayinetMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IIPAddressMArrayinetMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    ipaddressinetmmarrayd1e1mi_id
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)), 
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
                methodParametrName: "ipaddressinetmmarrayd1e1mi_id", 
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
                changedRows =  ((IIPAddressMArrayinetMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IIPAddressMArrayinetMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    ipaddressinetmmarrayd1e1mi_id
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
    ipaddressinetmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(IPAddressinetMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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

                    nullable =  ((IIPAddressMArrayinetMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("42.21.75.118"),
System.Net.IPAddress.Parse("231.61.61.246"),
System.Net.IPAddress.Parse("213.135.21.109"),
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

                    nullable =  ((IIPAddressMArrayinetMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((IIPAddressMArrayinetMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
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

                    nullable = await ((IIPAddressMArrayinetMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    ipaddressinetmmarrayd1e1mi_id
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
    ipaddressinetmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(IPAddressinetMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
                methodParametrName: "ipaddressinetmmarrayd1e1mi_id", 
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
                nullable =  ((IIPAddressMArrayinetMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("126.248.88.21"),
System.Net.IPAddress.Parse("220.164.159.224"),
System.Net.IPAddress.Parse("205.240.166.181"),
}));
                nullable =  ((IIPAddressMArrayinetMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("13.31.147.165"),
System.Net.IPAddress.Parse("101.7.64.99"),
System.Net.IPAddress.Parse("22.187.171.136"),
System.Net.IPAddress.Parse("143.138.24.76"),
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
                nullable = await ((IIPAddressMArrayinetMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IIPAddressMArrayinetMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetMMArrayD1E1M> models = null;

                models =  ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetMMArrayD1E1M> models = null;

                models = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IIPAddressMArrayinetMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD1E1M), typeof(FlatIPAddressinetMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                await ((IIPAddressMArrayinetMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                ((IIPAddressMArrayinetMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IIPAddressMArrayinetMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IIPAddressMArrayinetMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd1e1m m
LEFT JOIN public.ipaddressinetmmarrayd1e1mi mi ON mi.id = m.ipaddressinetmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinetMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
                var models = await ((IIPAddressMArrayinetMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IIPAddressMArrayinetMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD1E1M), typeof(FlatIPAddressinetMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                await ((IIPAddressMArrayinetMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                ((IIPAddressMArrayinetMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IIPAddressMArrayinetMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressMArrayinetMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd1e1m m
LEFT JOIN public.ipaddressinetmmarrayd1e1mi mi ON mi.id = m.ipaddressinetmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(IPAddressinetMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
                var models = await ((IIPAddressMArrayinetMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IIPAddressMArrayinetMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD1E1M), typeof(FlatIPAddressinetMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                await((IIPAddressMArrayinetMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
FROM public.ipaddressinetmmarrayd1e1m m
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
FROM public.ipaddressinetmmarrayd1e1m m
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 12;
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
FROM public.ipaddressinetmmarrayd1e1m m
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                 ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 172;
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
FROM public.ipaddressinetmmarrayd1e1m m
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                 ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IIPAddressMArrayinetMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetmmarrayd1e1m m
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetmmarrayd1e1m m
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetmmarrayd1e1m m
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetmmarrayd1e1m m
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                 ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd1e1m m
LEFT JOIN public.ipaddressinetmmarrayd1e1mi mi ON mi.id = m.ipaddressinetmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinetMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
                var models = await((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
                var models = ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD1E1M), typeof(FlatIPAddressinetMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                await((IIPAddressMArrayinetMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd1e1m m
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 157, query1, 97, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd1e1m m
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 63, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd1e1m m
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                 ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 81, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd1e1m m
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                 ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 128, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IIPAddressMArrayinetMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd1e1m m
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 32, query1, 88, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd1e1m m
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 5, query1, 179, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd1e1m m
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 17, query1, 179, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd1e1m m
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
FROM public.ipaddressinetmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD1E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD1E1M>();
                 ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 63, query1, 41, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd1e1m m
LEFT JOIN public.ipaddressinetmmarrayd1e1mi mi ON mi.id = m.ipaddressinetmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(IPAddressinetMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
                var models = await((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 63, 141))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                var models = ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 154, 134))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
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
                await using var cmd = await ((IIPAddressMArrayinetMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IIPAddressMArrayinetMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 161);
                var models = await ((IIPAddressMArrayinetMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressMArrayinetMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressMArrayinetMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 161);
                var models =  ((IIPAddressMArrayinetMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
FROM public.binary_ipaddressinetmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(IPAddressinetMMArrayD1E1MIWA),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressMArrayinetMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinetmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IIPAddressMArrayinetMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressMArrayinetMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinetmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressMArrayinetMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(IPAddressinetMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressMArrayinetMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinetmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IIPAddressMArrayinetMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressMArrayinetMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinetmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressMArrayinetMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(IPAddressinetMMArrayD1E1MI),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IIPAddressMArrayinetMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IIPAddressMArrayinetMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IIPAddressMArrayinetMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IIPAddressMArrayinetMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(IPAddressinetMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressMArrayinetMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IIPAddressMArrayinetMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressMArrayinetMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IIPAddressMArrayinetMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
ipaddressinetmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(IPAddressinetMMArrayD1E1M),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1))]
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
FROM public.binary_ipaddressinetmmarrayd1e1m m
LEFT JOIN public.binary_ipaddressinetmmarrayd1e1mi mi ON mi.id = m.ipaddressinetmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(IPAddressinetMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IIPAddressMArrayinetMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IIPAddressMArrayinetMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    IPAddressinetMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IIPAddressMArrayinetMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IIPAddressMArrayinetMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    IPAddressinetMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    ipaddressinetmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(IPAddressinetMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
                var models =  ((IIPAddressMArrayinetMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    IPAddressinetMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressMArrayinetMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    IPAddressinetMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD1E1MIWA), typeof(IPAddressinetMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
                var models1 = new List<IPAddressinetMMArrayD1E1MIWA>();
                var models2 = new List<IPAddressinetMMArrayD1E1MIWA>();
                await ((IIPAddressMArrayinetMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetMMArrayD1E1MIWA>();
                var models2 = new List<IPAddressinetMMArrayD1E1MIWA>();
                ((IIPAddressMArrayinetMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
                var models = await ((IIPAddressMArrayinetMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_ipaddressinetmmarrayd1e1mi
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
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressMArrayinetMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_ipaddressinetmmarrayd1e1mi
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
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD1E1MIWA), typeof(IPAddressinetMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1))]
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
                var models1 = new List<IPAddressinetMMArrayD1E1MIWA>();
                var models2 = new List<IPAddressinetMMArrayD1E1MIWA>();
                await ((IIPAddressMArrayinetMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetMMArrayD1E1MIWA>();
                var models2 = new List<IPAddressinetMMArrayD1E1MIWA>();
                ((IIPAddressMArrayinetMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1))]
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
                var models = await ((IIPAddressMArrayinetMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_ipaddressinetmmarrayd1e1mi
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
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressMArrayinetMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_ipaddressinetmmarrayd1e1mi
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
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_ipaddressinetmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD1E1MI), typeof(IPAddressinetMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
                var models1 = new List<IPAddressinetMMArrayD1E1MI>();
                var models2 = new List<IPAddressinetMMArrayD1E1MI>();
                await ((IIPAddressMArrayinetMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetMMArrayD1E1MI>();
                var models2 = new List<IPAddressinetMMArrayD1E1MI>();
                ((IIPAddressMArrayinetMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1)),
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
                var models = await ((IIPAddressMArrayinetMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressMArrayinetMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_ipaddressinetmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD1E1MIWA), typeof(IPAddressinetMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1))]
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
                var models1 = new List<IPAddressinetMMArrayD1E1MIWA>();
                var models2 = new List<IPAddressinetMMArrayD1E1MIWA>();
                await ((IIPAddressMArrayinetMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetMMArrayD1E1MIWA>();
                var models2 = new List<IPAddressinetMMArrayD1E1MIWA>();
                ((IIPAddressMArrayinetMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD1))]
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
                var models = await ((IIPAddressMArrayinetMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressMArrayinetMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

