

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
    Id = 6,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("194.35.33.232"),
System.Net.IPAddress.Parse("231.78.136.224"),
System.Net.IPAddress.Parse("226.137.36.187"),
System.Net.IPAddress.Parse("251.44.41.3"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 1,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("249.138.16.254"),
System.Net.IPAddress.Parse("110.124.18.245"),
System.Net.IPAddress.Parse("127.10.89.15"),
System.Net.IPAddress.Parse("207.17.87.177"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("30.146.11.251"),
System.Net.IPAddress.Parse("229.199.194.4"),
System.Net.IPAddress.Parse("135.46.123.112"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 11,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("198.70.129.14"),
System.Net.IPAddress.Parse("161.125.104.58"),
System.Net.IPAddress.Parse("164.176.171.251"),
System.Net.IPAddress.Parse("175.7.114.35"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 10,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("152.22.16.129"),
System.Net.IPAddress.Parse("27.105.65.213"),
System.Net.IPAddress.Parse("67.7.201.109"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 13,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("162.52.200.184"),
System.Net.IPAddress.Parse("159.228.237.229"),
System.Net.IPAddress.Parse("208.188.149.90"),
System.Net.IPAddress.Parse("191.119.111.34"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 14,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("161.243.121.105"),
System.Net.IPAddress.Parse("105.239.89.72"),
System.Net.IPAddress.Parse("164.181.217.254"),
System.Net.IPAddress.Parse("146.184.9.133"),
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
System.Net.IPAddress.Parse("70.188.134.154"),
System.Net.IPAddress.Parse("31.17.86.229"),
System.Net.IPAddress.Parse("160.162.126.28"),
System.Net.IPAddress.Parse("195.124.56.99"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("118.162.187.144"),
System.Net.IPAddress.Parse("90.238.43.173"),
System.Net.IPAddress.Parse("65.210.79.243"),
System.Net.IPAddress.Parse("99.18.187.118"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 26,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("203.129.74.92"),
System.Net.IPAddress.Parse("29.174.52.128"),
System.Net.IPAddress.Parse("63.106.41.154"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 21,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("120.94.54.163"),
System.Net.IPAddress.Parse("91.71.159.69"),
System.Net.IPAddress.Parse("140.142.219.19"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("208.107.17.75"),
System.Net.IPAddress.Parse("166.226.240.111"),
System.Net.IPAddress.Parse("99.183.232.14"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("92.128.47.202"),
System.Net.IPAddress.Parse("163.86.14.169"),
System.Net.IPAddress.Parse("21.143.46.203"),
System.Net.IPAddress.Parse("73.68.21.107"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 29,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("125.171.170.105"),
System.Net.IPAddress.Parse("162.21.196.119"),
System.Net.IPAddress.Parse("57.160.54.202"),
System.Net.IPAddress.Parse("237.139.230.231"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 28,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("88.99.73.148"),
System.Net.IPAddress.Parse("185.186.188.186"),
System.Net.IPAddress.Parse("198.195.152.138"),
System.Net.IPAddress.Parse("148.231.20.226"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("221.238.39.149"),
System.Net.IPAddress.Parse("185.128.39.14"),
System.Net.IPAddress.Parse("41.166.21.216"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 30,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("130.112.100.186"),
System.Net.IPAddress.Parse("169.129.172.213"),
System.Net.IPAddress.Parse("0.65.129.95"),
System.Net.IPAddress.Parse("174.227.47.186"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 34,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("235.242.83.236"),
System.Net.IPAddress.Parse("225.59.134.217"),
System.Net.IPAddress.Parse("108.199.99.212"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("137.15.98.182"),
System.Net.IPAddress.Parse("203.63.101.183"),
System.Net.IPAddress.Parse("59.216.175.117"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 36,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("11.234.243.116"),
System.Net.IPAddress.Parse("198.12.194.232"),
System.Net.IPAddress.Parse("204.17.158.55"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 41,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("104.52.67.113"),
System.Net.IPAddress.Parse("150.64.85.212"),
System.Net.IPAddress.Parse("235.98.110.25"),
System.Net.IPAddress.Parse("148.12.229.84"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("198.154.39.244"),
System.Net.IPAddress.Parse("128.168.211.64"),
System.Net.IPAddress.Parse("59.138.254.15"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 38,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("97.197.143.189"),
System.Net.IPAddress.Parse("37.65.47.41"),
System.Net.IPAddress.Parse("151.153.118.160"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("176.112.102.213"),
System.Net.IPAddress.Parse("231.13.235.165"),
System.Net.IPAddress.Parse("129.97.126.102"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("224.175.200.208"),
System.Net.IPAddress.Parse("165.43.29.211"),
System.Net.IPAddress.Parse("45.135.31.34"),
System.Net.IPAddress.Parse("90.157.252.122"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 40,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("188.210.246.200"),
System.Net.IPAddress.Parse("62.138.61.18"),
System.Net.IPAddress.Parse("189.43.146.19"),
System.Net.IPAddress.Parse("82.10.165.169"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 50,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("21.60.60.61"),
System.Net.IPAddress.Parse("53.233.89.26"),
System.Net.IPAddress.Parse("61.79.158.179"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 41,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("121.244.81.247"),
System.Net.IPAddress.Parse("79.75.194.63"),
System.Net.IPAddress.Parse("152.223.237.26"),
System.Net.IPAddress.Parse("116.217.53.13"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("63.171.8.160"),
System.Net.IPAddress.Parse("228.31.129.250"),
System.Net.IPAddress.Parse("213.109.243.136"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("20.197.148.253"),
System.Net.IPAddress.Parse("21.9.206.49"),
System.Net.IPAddress.Parse("189.45.249.64"),
System.Net.IPAddress.Parse("7.244.237.5"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 49,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("252.216.166.193"),
System.Net.IPAddress.Parse("69.64.223.121"),
System.Net.IPAddress.Parse("217.80.129.202"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 55,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("196.164.188.228"),
System.Net.IPAddress.Parse("34.23.131.158"),
System.Net.IPAddress.Parse("18.236.75.13"),
System.Net.IPAddress.Parse("208.227.158.72"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("95.138.129.46"),
System.Net.IPAddress.Parse("215.229.20.140"),
System.Net.IPAddress.Parse("234.44.166.86"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("252.31.64.7"),
System.Net.IPAddress.Parse("227.180.81.181"),
System.Net.IPAddress.Parse("33.83.74.216"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 56,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("129.5.132.157"),
System.Net.IPAddress.Parse("246.32.151.98"),
System.Net.IPAddress.Parse("249.44.206.27"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 56,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("114.68.161.173"),
System.Net.IPAddress.Parse("42.26.56.124"),
System.Net.IPAddress.Parse("67.38.240.142"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("58.17.87.118"),
System.Net.IPAddress.Parse("80.223.185.12"),
System.Net.IPAddress.Parse("236.77.75.145"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("7.247.128.122"),
System.Net.IPAddress.Parse("59.144.97.66"),
System.Net.IPAddress.Parse("212.252.177.29"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 64,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("236.170.58.214"),
System.Net.IPAddress.Parse("241.183.196.154"),
System.Net.IPAddress.Parse("54.155.241.208"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 60,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("61.220.94.132"),
System.Net.IPAddress.Parse("116.207.0.118"),
System.Net.IPAddress.Parse("88.25.76.84"),
System.Net.IPAddress.Parse("246.28.40.111"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("143.8.40.30"),
System.Net.IPAddress.Parse("93.33.50.98"),
System.Net.IPAddress.Parse("212.80.162.234"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 73,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("131.114.68.126"),
System.Net.IPAddress.Parse("129.161.192.109"),
System.Net.IPAddress.Parse("60.201.189.60"),
System.Net.IPAddress.Parse("175.116.34.251"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 66,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("79.5.229.247"),
System.Net.IPAddress.Parse("87.233.26.32"),
System.Net.IPAddress.Parse("146.56.224.68"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("37.196.31.91"),
System.Net.IPAddress.Parse("137.58.216.168"),
System.Net.IPAddress.Parse("191.154.155.45"),
System.Net.IPAddress.Parse("167.21.11.81"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("51.90.193.68"),
System.Net.IPAddress.Parse("223.78.44.159"),
System.Net.IPAddress.Parse("31.195.198.44"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("97.105.29.54"),
System.Net.IPAddress.Parse("0.126.222.200"),
System.Net.IPAddress.Parse("77.190.183.208"),
System.Net.IPAddress.Parse("209.147.92.55"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 71,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("66.202.72.82"),
System.Net.IPAddress.Parse("105.71.152.93"),
System.Net.IPAddress.Parse("251.197.231.210"),
System.Net.IPAddress.Parse("184.232.12.218"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 83,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("103.1.246.96"),
System.Net.IPAddress.Parse("189.186.253.116"),
System.Net.IPAddress.Parse("172.179.164.20"),
System.Net.IPAddress.Parse("253.75.186.233"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 75,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("225.236.90.187"),
System.Net.IPAddress.Parse("202.69.40.179"),
System.Net.IPAddress.Parse("61.93.207.233"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("160.75.71.6"),
System.Net.IPAddress.Parse("134.113.148.17"),
System.Net.IPAddress.Parse("181.120.23.134"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 90,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("31.136.136.36"),
System.Net.IPAddress.Parse("254.210.4.238"),
System.Net.IPAddress.Parse("135.172.83.140"),
System.Net.IPAddress.Parse("152.177.38.55"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 76,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("182.88.186.214"),
System.Net.IPAddress.Parse("99.71.158.50"),
System.Net.IPAddress.Parse("29.10.168.142"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 97,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("228.236.252.117"),
System.Net.IPAddress.Parse("198.132.166.183"),
System.Net.IPAddress.Parse("6.137.27.27"),
System.Net.IPAddress.Parse("178.73.91.64"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("144.86.68.250"),
System.Net.IPAddress.Parse("75.231.246.218"),
System.Net.IPAddress.Parse("105.171.183.88"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 99,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("150.101.253.26"),
System.Net.IPAddress.Parse("101.153.224.19"),
System.Net.IPAddress.Parse("89.147.172.172"),
System.Net.IPAddress.Parse("83.149.84.77"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("135.226.115.178"),
System.Net.IPAddress.Parse("240.25.1.235"),
System.Net.IPAddress.Parse("185.83.43.127"),
System.Net.IPAddress.Parse("13.15.215.84"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 107,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("120.223.243.42"),
System.Net.IPAddress.Parse("120.0.36.92"),
System.Net.IPAddress.Parse("211.240.48.212"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 89,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("25.111.251.83"),
System.Net.IPAddress.Parse("87.156.239.52"),
System.Net.IPAddress.Parse("77.26.190.114"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 114,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("239.184.177.135"),
System.Net.IPAddress.Parse("9.184.42.163"),
System.Net.IPAddress.Parse("64.34.71.206"),
System.Net.IPAddress.Parse("86.247.203.163"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 98,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("65.200.237.155"),
System.Net.IPAddress.Parse("64.50.115.151"),
System.Net.IPAddress.Parse("182.210.215.251"),
System.Net.IPAddress.Parse("50.114.41.228"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.139.3.30"),
System.Net.IPAddress.Parse("147.167.251.90"),
System.Net.IPAddress.Parse("77.42.123.253"),
System.Net.IPAddress.Parse("55.161.12.233"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("144.222.85.250"),
System.Net.IPAddress.Parse("140.176.30.86"),
System.Net.IPAddress.Parse("97.134.205.184"),
System.Net.IPAddress.Parse("38.219.108.154"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 115,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("104.59.63.149"),
System.Net.IPAddress.Parse("246.139.251.79"),
System.Net.IPAddress.Parse("231.220.160.170"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 106,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("189.179.84.185"),
System.Net.IPAddress.Parse("221.146.13.81"),
System.Net.IPAddress.Parse("66.50.149.110"),
System.Net.IPAddress.Parse("7.21.229.144"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("31.40.122.44"),
System.Net.IPAddress.Parse("135.78.177.83"),
System.Net.IPAddress.Parse("13.150.147.80"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 117,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("32.60.92.9"),
System.Net.IPAddress.Parse("146.32.248.160"),
System.Net.IPAddress.Parse("187.46.67.89"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 109,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("113.166.183.149"),
System.Net.IPAddress.Parse("194.62.182.154"),
System.Net.IPAddress.Parse("168.246.61.21"),
System.Net.IPAddress.Parse("134.29.5.134"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("15.91.154.33"),
System.Net.IPAddress.Parse("131.33.208.100"),
System.Net.IPAddress.Parse("204.55.96.45"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 122,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("100.220.156.119"),
System.Net.IPAddress.Parse("15.251.5.221"),
System.Net.IPAddress.Parse("131.218.169.235"),
System.Net.IPAddress.Parse("13.241.184.227"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 113,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("136.191.87.186"),
System.Net.IPAddress.Parse("130.76.80.5"),
System.Net.IPAddress.Parse("190.17.144.181"),
System.Net.IPAddress.Parse("226.136.220.239"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("68.40.250.25"),
System.Net.IPAddress.Parse("48.206.242.119"),
System.Net.IPAddress.Parse("176.41.28.198"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 129,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("225.64.26.246"),
System.Net.IPAddress.Parse("246.103.160.2"),
System.Net.IPAddress.Parse("199.20.180.0"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 116,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("8.223.35.227"),
System.Net.IPAddress.Parse("0.181.110.240"),
System.Net.IPAddress.Parse("196.230.4.56"),
System.Net.IPAddress.Parse("209.87.231.90"),
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
System.Net.IPAddress.Parse("227.213.122.146"),
System.Net.IPAddress.Parse("138.167.180.76"),
System.Net.IPAddress.Parse("164.137.155.225"),
System.Net.IPAddress.Parse("109.172.36.109"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 124,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("196.239.103.111"),
System.Net.IPAddress.Parse("208.28.118.84"),
System.Net.IPAddress.Parse("62.34.102.102"),
System.Net.IPAddress.Parse("85.164.145.205"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("187.244.240.18"),
System.Net.IPAddress.Parse("110.251.129.2"),
System.Net.IPAddress.Parse("103.80.234.53"),
System.Net.IPAddress.Parse("73.239.9.149"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 134,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("162.93.91.13"),
System.Net.IPAddress.Parse("225.27.54.98"),
System.Net.IPAddress.Parse("153.49.179.115"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 125,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("39.245.111.53"),
System.Net.IPAddress.Parse("185.30.87.148"),
System.Net.IPAddress.Parse("12.65.223.83"),
System.Net.IPAddress.Parse("19.183.87.112"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("193.217.138.41"),
System.Net.IPAddress.Parse("66.91.171.176"),
System.Net.IPAddress.Parse("162.71.3.168"),
System.Net.IPAddress.Parse("25.188.218.97"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 142,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("168.100.229.85"),
System.Net.IPAddress.Parse("148.75.205.68"),
System.Net.IPAddress.Parse("117.53.237.120"),
System.Net.IPAddress.Parse("251.183.228.152"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 127,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.149.87.58"),
System.Net.IPAddress.Parse("169.72.133.226"),
System.Net.IPAddress.Parse("219.85.249.173"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("141.213.192.52"),
System.Net.IPAddress.Parse("130.47.103.130"),
System.Net.IPAddress.Parse("202.62.54.250"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 144,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("180.29.60.82"),
System.Net.IPAddress.Parse("169.112.197.179"),
System.Net.IPAddress.Parse("131.122.234.59"),
System.Net.IPAddress.Parse("242.195.96.143"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 128,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("184.165.95.107"),
System.Net.IPAddress.Parse("40.190.34.123"),
System.Net.IPAddress.Parse("193.250.250.58"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("29.5.69.53"),
System.Net.IPAddress.Parse("14.102.113.47"),
System.Net.IPAddress.Parse("128.122.97.156"),
System.Net.IPAddress.Parse("7.51.201.220"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 150,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("152.126.121.163"),
System.Net.IPAddress.Parse("114.87.40.148"),
System.Net.IPAddress.Parse("41.99.160.139"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 135,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("15.21.234.245"),
System.Net.IPAddress.Parse("81.4.70.78"),
System.Net.IPAddress.Parse("28.246.127.225"),
System.Net.IPAddress.Parse("182.252.212.127"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("167.75.29.202"),
System.Net.IPAddress.Parse("52.40.188.155"),
System.Net.IPAddress.Parse("234.114.223.224"),
System.Net.IPAddress.Parse("195.87.78.228"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 158,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("114.18.12.155"),
System.Net.IPAddress.Parse("107.126.187.9"),
System.Net.IPAddress.Parse("180.29.69.105"),
System.Net.IPAddress.Parse("6.34.1.214"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 142,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("204.180.33.52"),
System.Net.IPAddress.Parse("108.68.134.45"),
System.Net.IPAddress.Parse("183.45.119.254"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("11.187.48.81"),
System.Net.IPAddress.Parse("10.180.93.105"),
System.Net.IPAddress.Parse("18.4.60.155"),
System.Net.IPAddress.Parse("56.199.143.174"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 160,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("213.251.219.196"),
System.Net.IPAddress.Parse("244.96.228.248"),
System.Net.IPAddress.Parse("147.110.150.200"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 145,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("171.207.239.8"),
System.Net.IPAddress.Parse("63.21.95.135"),
System.Net.IPAddress.Parse("185.210.24.4"),
System.Net.IPAddress.Parse("45.251.174.114"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("192.204.167.254"),
System.Net.IPAddress.Parse("191.4.252.137"),
System.Net.IPAddress.Parse("231.243.68.59"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 162,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("9.29.118.121"),
System.Net.IPAddress.Parse("237.99.87.164"),
System.Net.IPAddress.Parse("13.244.118.237"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 152,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("76.98.221.17"),
System.Net.IPAddress.Parse("254.249.126.83"),
System.Net.IPAddress.Parse("125.6.138.216"),
System.Net.IPAddress.Parse("70.212.254.254"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("159.11.130.12"),
System.Net.IPAddress.Parse("176.30.183.165"),
System.Net.IPAddress.Parse("237.209.155.42"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 165,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("239.33.61.173"),
System.Net.IPAddress.Parse("55.122.23.220"),
System.Net.IPAddress.Parse("27.87.169.14"),
System.Net.IPAddress.Parse("230.25.56.75"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 159,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("70.68.115.39"),
System.Net.IPAddress.Parse("58.59.121.205"),
System.Net.IPAddress.Parse("249.165.89.190"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.71.212.19"),
System.Net.IPAddress.Parse("69.0.45.165"),
System.Net.IPAddress.Parse("73.176.73.201"),
System.Net.IPAddress.Parse("114.83.29.66"),
},
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

