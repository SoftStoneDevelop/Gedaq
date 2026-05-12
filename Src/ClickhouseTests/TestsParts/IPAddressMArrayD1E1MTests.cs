

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
    Id = 4,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("36.146.53.92"),
System.Net.IPAddress.Parse("24.218.33.158"),
System.Net.IPAddress.Parse("117.225.91.184"),
System.Net.IPAddress.Parse("116.161.245.114"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 8,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("63.28.26.56"),
System.Net.IPAddress.Parse("17.36.52.25"),
System.Net.IPAddress.Parse("78.15.48.215"),
System.Net.IPAddress.Parse("70.34.15.193"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("134.126.84.201"),
System.Net.IPAddress.Parse("147.177.249.72"),
System.Net.IPAddress.Parse("67.247.226.230"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 13,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("15.234.87.117"),
System.Net.IPAddress.Parse("73.65.121.233"),
System.Net.IPAddress.Parse("160.126.143.67"),
System.Net.IPAddress.Parse("137.210.67.116"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 11,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("241.113.146.171"),
System.Net.IPAddress.Parse("51.214.138.23"),
System.Net.IPAddress.Parse("249.189.203.233"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("61.49.34.10"),
System.Net.IPAddress.Parse("64.142.161.105"),
System.Net.IPAddress.Parse("5.39.164.165"),
System.Net.IPAddress.Parse("133.68.141.75"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 14,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("249.224.13.226"),
System.Net.IPAddress.Parse("192.65.117.25"),
System.Net.IPAddress.Parse("250.228.77.143"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("210.186.123.151"),
System.Net.IPAddress.Parse("209.179.84.149"),
System.Net.IPAddress.Parse("6.8.211.38"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("81.25.75.133"),
System.Net.IPAddress.Parse("42.197.28.26"),
System.Net.IPAddress.Parse("7.109.123.135"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("158.115.88.9"),
System.Net.IPAddress.Parse("149.252.226.160"),
System.Net.IPAddress.Parse("25.200.54.72"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 23,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("151.202.147.196"),
System.Net.IPAddress.Parse("92.213.147.18"),
System.Net.IPAddress.Parse("194.24.204.253"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 16,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("57.81.116.178"),
System.Net.IPAddress.Parse("0.6.13.183"),
System.Net.IPAddress.Parse("250.246.164.175"),
System.Net.IPAddress.Parse("162.44.112.71"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("159.57.134.31"),
System.Net.IPAddress.Parse("196.186.38.138"),
System.Net.IPAddress.Parse("119.247.9.218"),
System.Net.IPAddress.Parse("113.215.48.122"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 31,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("100.93.74.114"),
System.Net.IPAddress.Parse("217.36.243.150"),
System.Net.IPAddress.Parse("118.81.65.243"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 23,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("149.190.235.53"),
System.Net.IPAddress.Parse("138.78.90.203"),
System.Net.IPAddress.Parse("156.226.116.184"),
System.Net.IPAddress.Parse("84.48.132.211"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 35,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("55.47.0.166"),
System.Net.IPAddress.Parse("16.200.6.162"),
System.Net.IPAddress.Parse("106.164.82.11"),
System.Net.IPAddress.Parse("109.49.139.120"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("61.107.207.46"),
System.Net.IPAddress.Parse("245.215.18.161"),
System.Net.IPAddress.Parse("141.157.237.163"),
System.Net.IPAddress.Parse("1.106.105.223"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 36,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.54.65.34"),
System.Net.IPAddress.Parse("221.241.101.45"),
System.Net.IPAddress.Parse("150.55.61.245"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("140.132.188.146"),
System.Net.IPAddress.Parse("134.222.227.37"),
System.Net.IPAddress.Parse("184.42.205.228"),
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
System.Net.IPAddress.Parse("244.205.215.72"),
System.Net.IPAddress.Parse("184.169.199.93"),
System.Net.IPAddress.Parse("62.142.240.145"),
System.Net.IPAddress.Parse("0.62.206.14"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("248.131.73.14"),
System.Net.IPAddress.Parse("76.130.83.172"),
System.Net.IPAddress.Parse("154.115.254.43"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("236.9.216.155"),
System.Net.IPAddress.Parse("54.79.205.216"),
System.Net.IPAddress.Parse("33.225.74.103"),
System.Net.IPAddress.Parse("240.81.184.239"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("69.253.109.243"),
System.Net.IPAddress.Parse("42.239.67.37"),
System.Net.IPAddress.Parse("10.30.120.161"),
System.Net.IPAddress.Parse("35.106.2.236"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 43,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("171.224.247.116"),
System.Net.IPAddress.Parse("243.179.116.34"),
System.Net.IPAddress.Parse("38.98.141.243"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 44,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("245.205.17.85"),
System.Net.IPAddress.Parse("156.190.68.38"),
System.Net.IPAddress.Parse("78.0.140.171"),
System.Net.IPAddress.Parse("74.107.170.233"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("178.224.199.134"),
System.Net.IPAddress.Parse("2.151.93.223"),
System.Net.IPAddress.Parse("17.19.190.31"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 46,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("173.170.242.238"),
System.Net.IPAddress.Parse("182.238.56.14"),
System.Net.IPAddress.Parse("53.121.92.59"),
System.Net.IPAddress.Parse("19.164.161.97"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 47,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("209.144.167.216"),
System.Net.IPAddress.Parse("226.89.152.39"),
System.Net.IPAddress.Parse("44.69.153.182"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("195.15.204.133"),
System.Net.IPAddress.Parse("222.134.37.219"),
System.Net.IPAddress.Parse("57.194.43.179"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("223.194.82.180"),
System.Net.IPAddress.Parse("141.212.91.76"),
System.Net.IPAddress.Parse("203.127.239.136"),
System.Net.IPAddress.Parse("35.238.244.79"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 49,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("29.100.72.52"),
System.Net.IPAddress.Parse("129.66.144.236"),
System.Net.IPAddress.Parse("206.132.80.91"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 49,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("169.253.38.19"),
System.Net.IPAddress.Parse("170.9.214.25"),
System.Net.IPAddress.Parse("134.103.18.69"),
System.Net.IPAddress.Parse("47.176.201.32"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 53,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("204.161.144.183"),
System.Net.IPAddress.Parse("32.125.142.152"),
System.Net.IPAddress.Parse("53.27.208.140"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 56,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("225.99.140.34"),
System.Net.IPAddress.Parse("154.103.186.4"),
System.Net.IPAddress.Parse("105.233.104.235"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("5.79.96.246"),
System.Net.IPAddress.Parse("84.64.59.81"),
System.Net.IPAddress.Parse("68.93.85.14"),
System.Net.IPAddress.Parse("63.237.25.173"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 62,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.170.22.234"),
System.Net.IPAddress.Parse("22.192.132.19"),
System.Net.IPAddress.Parse("86.38.142.241"),
System.Net.IPAddress.Parse("163.11.215.29"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 59,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("247.164.127.178"),
System.Net.IPAddress.Parse("15.75.34.211"),
System.Net.IPAddress.Parse("14.144.12.106"),
System.Net.IPAddress.Parse("24.124.143.68"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 63,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("31.207.81.14"),
System.Net.IPAddress.Parse("235.76.228.101"),
System.Net.IPAddress.Parse("234.1.0.55"),
System.Net.IPAddress.Parse("222.144.189.167"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 63,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("117.51.219.19"),
System.Net.IPAddress.Parse("141.90.217.144"),
System.Net.IPAddress.Parse("150.194.44.7"),
System.Net.IPAddress.Parse("144.251.83.226"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.59.104.109"),
System.Net.IPAddress.Parse("229.12.222.39"),
System.Net.IPAddress.Parse("250.42.229.8"),
System.Net.IPAddress.Parse("186.90.134.132"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 71,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("90.39.187.48"),
System.Net.IPAddress.Parse("95.74.91.89"),
System.Net.IPAddress.Parse("60.115.126.242"),
System.Net.IPAddress.Parse("172.87.165.209"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 68,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("41.147.27.221"),
System.Net.IPAddress.Parse("73.138.43.42"),
System.Net.IPAddress.Parse("60.177.112.67"),
System.Net.IPAddress.Parse("95.172.191.8"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 78,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("84.53.208.24"),
System.Net.IPAddress.Parse("195.23.190.39"),
System.Net.IPAddress.Parse("226.22.133.28"),
System.Net.IPAddress.Parse("121.21.131.88"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 69,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("114.69.80.50"),
System.Net.IPAddress.Parse("133.153.21.228"),
System.Net.IPAddress.Parse("28.133.75.174"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("122.104.49.55"),
System.Net.IPAddress.Parse("88.117.67.35"),
System.Net.IPAddress.Parse("140.220.186.229"),
System.Net.IPAddress.Parse("183.230.160.58"),
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
System.Net.IPAddress.Parse("245.3.56.118"),
System.Net.IPAddress.Parse("72.119.184.201"),
System.Net.IPAddress.Parse("30.133.93.106"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 72,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("210.139.198.221"),
System.Net.IPAddress.Parse("175.5.167.4"),
System.Net.IPAddress.Parse("238.249.215.91"),
System.Net.IPAddress.Parse("188.213.170.248"),
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
System.Net.IPAddress.Parse("114.79.144.186"),
System.Net.IPAddress.Parse("241.41.125.114"),
System.Net.IPAddress.Parse("157.48.111.54"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 80,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("180.76.107.223"),
System.Net.IPAddress.Parse("137.70.0.10"),
System.Net.IPAddress.Parse("94.82.143.175"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("227.115.175.90"),
System.Net.IPAddress.Parse("159.133.75.218"),
System.Net.IPAddress.Parse("217.212.144.192"),
System.Net.IPAddress.Parse("80.125.237.53"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 96,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("216.110.113.249"),
System.Net.IPAddress.Parse("222.59.199.238"),
System.Net.IPAddress.Parse("129.92.192.75"),
System.Net.IPAddress.Parse("128.89.191.160"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 81,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("26.47.99.222"),
System.Net.IPAddress.Parse("23.24.123.73"),
System.Net.IPAddress.Parse("223.240.18.241"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("127.93.128.191"),
System.Net.IPAddress.Parse("54.68.126.194"),
System.Net.IPAddress.Parse("31.64.150.89"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("213.44.95.35"),
System.Net.IPAddress.Parse("137.5.142.120"),
System.Net.IPAddress.Parse("220.250.59.70"),
System.Net.IPAddress.Parse("91.3.245.209"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 90,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("84.166.83.111"),
System.Net.IPAddress.Parse("48.58.143.48"),
System.Net.IPAddress.Parse("243.33.46.82"),
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
System.Net.IPAddress.Parse("207.89.246.91"),
System.Net.IPAddress.Parse("154.147.78.151"),
System.Net.IPAddress.Parse("4.80.230.150"),
System.Net.IPAddress.Parse("137.153.245.54"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 98,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("173.62.106.181"),
System.Net.IPAddress.Parse("201.180.243.139"),
System.Net.IPAddress.Parse("131.59.211.220"),
System.Net.IPAddress.Parse("120.92.96.222"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("145.246.177.226"),
System.Net.IPAddress.Parse("59.6.43.35"),
System.Net.IPAddress.Parse("151.247.27.174"),
System.Net.IPAddress.Parse("1.104.115.166"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("44.72.203.145"),
System.Net.IPAddress.Parse("119.99.23.53"),
System.Net.IPAddress.Parse("192.237.42.240"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 120,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("236.153.37.203"),
System.Net.IPAddress.Parse("243.236.85.234"),
System.Net.IPAddress.Parse("22.15.220.143"),
System.Net.IPAddress.Parse("148.30.111.23"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 99,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("195.141.71.22"),
System.Net.IPAddress.Parse("119.254.18.115"),
System.Net.IPAddress.Parse("80.28.20.124"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 126,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("195.105.77.130"),
System.Net.IPAddress.Parse("211.167.193.2"),
System.Net.IPAddress.Parse("6.102.181.86"),
System.Net.IPAddress.Parse("245.25.234.18"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 105,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("126.26.51.106"),
System.Net.IPAddress.Parse("9.57.213.167"),
System.Net.IPAddress.Parse("15.188.68.63"),
System.Net.IPAddress.Parse("169.194.32.139"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("17.61.142.200"),
System.Net.IPAddress.Parse("166.75.81.161"),
System.Net.IPAddress.Parse("163.231.153.101"),
System.Net.IPAddress.Parse("19.144.43.180"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 135,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("2.65.124.202"),
System.Net.IPAddress.Parse("86.58.16.249"),
System.Net.IPAddress.Parse("231.87.38.92"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 114,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.205.214.13"),
System.Net.IPAddress.Parse("42.181.170.127"),
System.Net.IPAddress.Parse("33.6.80.133"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("198.182.200.160"),
System.Net.IPAddress.Parse("61.54.200.30"),
System.Net.IPAddress.Parse("79.193.228.228"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 143,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("48.148.77.242"),
System.Net.IPAddress.Parse("134.78.110.186"),
System.Net.IPAddress.Parse("185.166.162.100"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 119,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("94.33.175.179"),
System.Net.IPAddress.Parse("165.243.95.177"),
System.Net.IPAddress.Parse("106.64.105.111"),
System.Net.IPAddress.Parse("35.170.247.23"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("104.36.54.29"),
System.Net.IPAddress.Parse("32.71.72.127"),
System.Net.IPAddress.Parse("135.67.151.138"),
System.Net.IPAddress.Parse("220.5.253.21"),
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
System.Net.IPAddress.Parse("185.147.95.46"),
System.Net.IPAddress.Parse("236.132.98.210"),
System.Net.IPAddress.Parse("52.223.127.119"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 120,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("37.241.9.9"),
System.Net.IPAddress.Parse("242.200.174.85"),
System.Net.IPAddress.Parse("217.239.18.179"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("122.186.42.29"),
System.Net.IPAddress.Parse("211.203.171.97"),
System.Net.IPAddress.Parse("8.104.72.221"),
System.Net.IPAddress.Parse("141.36.163.199"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("177.28.48.159"),
System.Net.IPAddress.Parse("134.70.23.50"),
System.Net.IPAddress.Parse("161.202.98.45"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 153,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("94.28.124.199"),
System.Net.IPAddress.Parse("134.181.63.7"),
System.Net.IPAddress.Parse("175.152.79.177"),
System.Net.IPAddress.Parse("232.69.134.56"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 122,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("41.160.103.167"),
System.Net.IPAddress.Parse("38.99.184.193"),
System.Net.IPAddress.Parse("65.218.52.28"),
System.Net.IPAddress.Parse("128.146.162.174"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("89.240.36.75"),
System.Net.IPAddress.Parse("104.18.141.222"),
System.Net.IPAddress.Parse("11.26.115.156"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("199.163.79.134"),
System.Net.IPAddress.Parse("241.95.227.93"),
System.Net.IPAddress.Parse("54.6.250.90"),
System.Net.IPAddress.Parse("116.73.64.20"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 160,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("133.73.17.206"),
System.Net.IPAddress.Parse("77.26.34.203"),
System.Net.IPAddress.Parse("2.162.30.147"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 123,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("232.198.41.15"),
System.Net.IPAddress.Parse("23.127.99.232"),
System.Net.IPAddress.Parse("95.72.86.181"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.145.151.114"),
System.Net.IPAddress.Parse("247.80.53.84"),
System.Net.IPAddress.Parse("184.207.206.79"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("114.189.119.125"),
System.Net.IPAddress.Parse("179.220.241.137"),
System.Net.IPAddress.Parse("239.49.77.19"),
System.Net.IPAddress.Parse("168.227.65.187"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 161,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("24.182.170.3"),
System.Net.IPAddress.Parse("216.13.2.38"),
System.Net.IPAddress.Parse("134.93.0.169"),
System.Net.IPAddress.Parse("148.204.49.219"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 129,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("98.193.191.127"),
System.Net.IPAddress.Parse("170.220.7.238"),
System.Net.IPAddress.Parse("60.232.141.5"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("11.78.138.178"),
System.Net.IPAddress.Parse("211.100.73.68"),
System.Net.IPAddress.Parse("199.124.53.140"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("166.43.79.206"),
System.Net.IPAddress.Parse("121.223.217.206"),
System.Net.IPAddress.Parse("16.110.89.56"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 169,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("10.170.127.65"),
System.Net.IPAddress.Parse("228.67.135.151"),
System.Net.IPAddress.Parse("68.177.224.120"),
System.Net.IPAddress.Parse("212.26.122.5"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 130,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("43.175.195.218"),
System.Net.IPAddress.Parse("8.152.164.249"),
System.Net.IPAddress.Parse("219.121.174.47"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("64.80.143.97"),
System.Net.IPAddress.Parse("39.52.27.25"),
System.Net.IPAddress.Parse("116.21.56.45"),
System.Net.IPAddress.Parse("205.249.205.31"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 175,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("38.189.102.129"),
System.Net.IPAddress.Parse("239.232.230.207"),
System.Net.IPAddress.Parse("242.48.57.177"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 136,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("204.235.8.25"),
System.Net.IPAddress.Parse("234.118.96.102"),
System.Net.IPAddress.Parse("11.0.89.121"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("214.178.91.194"),
System.Net.IPAddress.Parse("129.253.58.53"),
System.Net.IPAddress.Parse("162.32.2.221"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 180,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("201.79.207.61"),
System.Net.IPAddress.Parse("150.118.100.46"),
System.Net.IPAddress.Parse("128.145.131.87"),
System.Net.IPAddress.Parse("30.21.75.179"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 143,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("172.100.8.105"),
System.Net.IPAddress.Parse("20.176.244.173"),
System.Net.IPAddress.Parse("215.75.85.124"),
System.Net.IPAddress.Parse("4.225.116.189"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("224.130.84.191"),
System.Net.IPAddress.Parse("136.21.119.54"),
System.Net.IPAddress.Parse("87.216.134.137"),
System.Net.IPAddress.Parse("249.16.32.151"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("238.196.37.106"),
System.Net.IPAddress.Parse("161.47.106.122"),
System.Net.IPAddress.Parse("8.2.76.246"),
System.Net.IPAddress.Parse("39.141.212.121"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 188,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("109.8.206.172"),
System.Net.IPAddress.Parse("71.60.127.8"),
System.Net.IPAddress.Parse("27.111.24.119"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 151,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("0.181.188.12"),
System.Net.IPAddress.Parse("209.80.97.243"),
System.Net.IPAddress.Parse("211.222.65.123"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("27.196.139.44"),
System.Net.IPAddress.Parse("166.249.190.166"),
System.Net.IPAddress.Parse("111.21.231.173"),
System.Net.IPAddress.Parse("100.151.232.74"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 192,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("252.117.189.245"),
System.Net.IPAddress.Parse("108.61.227.155"),
System.Net.IPAddress.Parse("220.243.217.130"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 159,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("47.22.91.181"),
System.Net.IPAddress.Parse("111.104.194.212"),
System.Net.IPAddress.Parse("238.123.250.106"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("114.182.44.122"),
System.Net.IPAddress.Parse("45.133.132.218"),
System.Net.IPAddress.Parse("124.206.120.108"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 197,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("149.136.22.149"),
System.Net.IPAddress.Parse("95.190.190.152"),
System.Net.IPAddress.Parse("240.185.116.87"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 164,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("178.29.56.185"),
System.Net.IPAddress.Parse("58.233.77.119"),
System.Net.IPAddress.Parse("233.69.102.33"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("74.209.115.35"),
System.Net.IPAddress.Parse("219.240.106.185"),
System.Net.IPAddress.Parse("179.241.182.117"),
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

