

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
    internal partial interface IIPAddressArrayArrayIPv4
    {
    }
    
    internal partial class IPAddressArrayArrayIPv4 : IIPAddressArrayArrayIPv4
    {


#region TestData

        private readonly IPAddressArrayIPv41M[] _testData = new IPAddressArrayIPv41M[]
        {
            new IPAddressArrayIPv41M
{
    Id = 6,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("11.31.186.141"),
System.Net.IPAddress.Parse("72.32.81.52"),
System.Net.IPAddress.Parse("184.94.123.233"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 7,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("110.167.103.45"),
System.Net.IPAddress.Parse("70.8.170.80"),
System.Net.IPAddress.Parse("58.78.135.118"),
System.Net.IPAddress.Parse("70.202.128.69"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("67.13.140.210"),
System.Net.IPAddress.Parse("26.162.98.253"),
System.Net.IPAddress.Parse("64.9.243.187"),
System.Net.IPAddress.Parse("173.176.86.141"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("242.168.37.245"),
System.Net.IPAddress.Parse("231.86.198.205"),
System.Net.IPAddress.Parse("243.143.181.36"),
System.Net.IPAddress.Parse("201.24.237.247"),
},
},
            new IPAddressArrayIPv41M
{
    Id = 8,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("4.55.197.31"),
System.Net.IPAddress.Parse("50.125.153.215"),
System.Net.IPAddress.Parse("248.158.86.124"),
System.Net.IPAddress.Parse("105.184.157.173"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 9,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("219.193.12.236"),
System.Net.IPAddress.Parse("193.104.131.241"),
System.Net.IPAddress.Parse("87.192.165.157"),
System.Net.IPAddress.Parse("58.244.220.68"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayIPv41M
{
    Id = 9,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("65.39.55.102"),
System.Net.IPAddress.Parse("120.108.19.122"),
System.Net.IPAddress.Parse("206.188.208.59"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 16,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("193.186.186.154"),
System.Net.IPAddress.Parse("13.115.29.100"),
System.Net.IPAddress.Parse("120.239.166.213"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayIPv41M
{
    Id = 14,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("200.120.103.235"),
System.Net.IPAddress.Parse("66.66.191.250"),
System.Net.IPAddress.Parse("132.83.232.120"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 21,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("93.184.72.69"),
System.Net.IPAddress.Parse("121.60.74.71"),
System.Net.IPAddress.Parse("195.254.94.250"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("137.247.152.160"),
System.Net.IPAddress.Parse("51.43.250.56"),
System.Net.IPAddress.Parse("15.75.154.84"),
},
},
            new IPAddressArrayIPv41M
{
    Id = 16,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("23.166.91.64"),
System.Net.IPAddress.Parse("106.10.241.113"),
System.Net.IPAddress.Parse("4.70.61.181"),
System.Net.IPAddress.Parse("66.24.148.201"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 27,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("131.174.152.30"),
System.Net.IPAddress.Parse("101.62.206.223"),
System.Net.IPAddress.Parse("216.212.159.219"),
System.Net.IPAddress.Parse("87.51.167.186"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("13.166.200.246"),
System.Net.IPAddress.Parse("250.84.49.220"),
System.Net.IPAddress.Parse("14.35.169.32"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("3.143.243.101"),
System.Net.IPAddress.Parse("209.90.254.160"),
System.Net.IPAddress.Parse("5.18.47.117"),
},
},
            new IPAddressArrayIPv41M
{
    Id = 24,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("93.141.236.233"),
System.Net.IPAddress.Parse("207.233.159.134"),
System.Net.IPAddress.Parse("181.229.44.84"),
System.Net.IPAddress.Parse("208.185.200.188"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 36,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("39.65.56.234"),
System.Net.IPAddress.Parse("250.122.248.40"),
System.Net.IPAddress.Parse("74.6.173.55"),
System.Net.IPAddress.Parse("55.33.85.217"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("244.38.94.229"),
System.Net.IPAddress.Parse("28.87.9.248"),
System.Net.IPAddress.Parse("205.97.84.224"),
System.Net.IPAddress.Parse("238.110.245.14"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("227.139.128.180"),
System.Net.IPAddress.Parse("5.106.202.220"),
System.Net.IPAddress.Parse("185.200.143.79"),
System.Net.IPAddress.Parse("163.16.166.161"),
},
},
            new IPAddressArrayIPv41M
{
    Id = 29,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("159.11.202.47"),
System.Net.IPAddress.Parse("122.209.127.172"),
System.Net.IPAddress.Parse("154.129.68.50"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 40,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("187.79.90.11"),
System.Net.IPAddress.Parse("140.210.129.41"),
System.Net.IPAddress.Parse("173.212.5.204"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayIPv41M
{
    Id = 36,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("230.170.52.123"),
System.Net.IPAddress.Parse("64.28.24.18"),
System.Net.IPAddress.Parse("6.210.80.10"),
System.Net.IPAddress.Parse("42.121.104.202"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 44,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("247.104.246.9"),
System.Net.IPAddress.Parse("226.217.121.210"),
System.Net.IPAddress.Parse("37.54.19.5"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("99.230.115.230"),
System.Net.IPAddress.Parse("103.164.189.227"),
System.Net.IPAddress.Parse("71.197.78.70"),
System.Net.IPAddress.Parse("182.250.199.194"),
},
},
    NullableValue = null,
},
            new IPAddressArrayIPv41M
{
    Id = 38,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("81.131.146.43"),
System.Net.IPAddress.Parse("220.149.211.217"),
System.Net.IPAddress.Parse("111.67.50.59"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 47,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("189.238.190.95"),
System.Net.IPAddress.Parse("27.58.166.15"),
System.Net.IPAddress.Parse("221.226.149.148"),
System.Net.IPAddress.Parse("184.0.252.30"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("207.170.157.210"),
System.Net.IPAddress.Parse("241.36.37.94"),
System.Net.IPAddress.Parse("10.242.185.231"),
},
},
            new IPAddressArrayIPv41M
{
    Id = 44,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("59.64.231.137"),
System.Net.IPAddress.Parse("153.235.85.79"),
System.Net.IPAddress.Parse("97.27.20.109"),
System.Net.IPAddress.Parse("235.155.167.62"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 55,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("161.54.178.49"),
System.Net.IPAddress.Parse("34.66.176.124"),
System.Net.IPAddress.Parse("236.94.201.4"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("32.224.158.10"),
System.Net.IPAddress.Parse("165.156.99.103"),
System.Net.IPAddress.Parse("191.27.252.197"),
System.Net.IPAddress.Parse("65.173.247.89"),
},
},
            new IPAddressArrayIPv41M
{
    Id = 46,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("82.80.1.80"),
System.Net.IPAddress.Parse("206.100.161.32"),
System.Net.IPAddress.Parse("85.164.32.105"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 58,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("195.140.138.231"),
System.Net.IPAddress.Parse("62.137.148.23"),
System.Net.IPAddress.Parse("128.184.136.218"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("219.35.97.228"),
System.Net.IPAddress.Parse("86.248.72.207"),
System.Net.IPAddress.Parse("199.94.177.222"),
},
},
            new IPAddressArrayIPv41M
{
    Id = 47,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("43.164.29.194"),
System.Net.IPAddress.Parse("4.250.229.39"),
System.Net.IPAddress.Parse("247.212.219.126"),
System.Net.IPAddress.Parse("107.157.147.188"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 66,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("51.149.131.215"),
System.Net.IPAddress.Parse("97.158.141.0"),
System.Net.IPAddress.Parse("53.122.47.187"),
System.Net.IPAddress.Parse("104.67.199.151"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("112.85.97.9"),
System.Net.IPAddress.Parse("18.10.134.53"),
System.Net.IPAddress.Parse("5.192.184.16"),
},
},
    NullableValue = null,
},
            new IPAddressArrayIPv41M
{
    Id = 53,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("175.208.230.71"),
System.Net.IPAddress.Parse("88.103.156.60"),
System.Net.IPAddress.Parse("201.247.4.73"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 69,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("11.232.87.179"),
System.Net.IPAddress.Parse("34.150.78.116"),
System.Net.IPAddress.Parse("3.154.190.130"),
System.Net.IPAddress.Parse("81.118.137.53"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("241.116.96.228"),
System.Net.IPAddress.Parse("3.213.9.11"),
System.Net.IPAddress.Parse("198.80.22.242"),
System.Net.IPAddress.Parse("239.53.118.26"),
},
},
            new IPAddressArrayIPv41M
{
    Id = 59,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("149.29.108.189"),
System.Net.IPAddress.Parse("220.202.237.76"),
System.Net.IPAddress.Parse("148.225.50.106"),
System.Net.IPAddress.Parse("240.173.70.58"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 73,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.204.61.225"),
System.Net.IPAddress.Parse("246.39.97.158"),
System.Net.IPAddress.Parse("189.96.40.134"),
System.Net.IPAddress.Parse("57.198.107.96"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.198.20.83"),
System.Net.IPAddress.Parse("121.151.236.221"),
System.Net.IPAddress.Parse("138.195.108.31"),
},
},
    NullableValue = null,
},
            new IPAddressArrayIPv41M
{
    Id = 63,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("44.232.157.41"),
System.Net.IPAddress.Parse("107.119.34.156"),
System.Net.IPAddress.Parse("100.73.15.198"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 79,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.196.29.91"),
System.Net.IPAddress.Parse("83.92.139.236"),
System.Net.IPAddress.Parse("93.102.252.185"),
System.Net.IPAddress.Parse("211.182.27.134"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("34.3.139.119"),
System.Net.IPAddress.Parse("240.240.106.188"),
System.Net.IPAddress.Parse("44.220.93.241"),
System.Net.IPAddress.Parse("1.73.207.252"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("31.245.9.53"),
System.Net.IPAddress.Parse("202.64.204.67"),
System.Net.IPAddress.Parse("102.207.38.75"),
},
},
            new IPAddressArrayIPv41M
{
    Id = 69,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("109.18.197.229"),
System.Net.IPAddress.Parse("26.168.105.17"),
System.Net.IPAddress.Parse("211.54.121.247"),
System.Net.IPAddress.Parse("100.215.104.254"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 88,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("104.246.191.114"),
System.Net.IPAddress.Parse("82.243.95.233"),
System.Net.IPAddress.Parse("93.217.247.80"),
System.Net.IPAddress.Parse("83.39.247.172"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("95.91.8.112"),
System.Net.IPAddress.Parse("158.11.153.74"),
System.Net.IPAddress.Parse("205.212.125.137"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.94.99.93"),
System.Net.IPAddress.Parse("160.14.21.55"),
System.Net.IPAddress.Parse("3.125.111.50"),
System.Net.IPAddress.Parse("199.88.134.52"),
},
},
            new IPAddressArrayIPv41M
{
    Id = 72,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.81.43.241"),
System.Net.IPAddress.Parse("44.177.111.222"),
System.Net.IPAddress.Parse("122.158.204.206"),
System.Net.IPAddress.Parse("23.52.185.28"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 94,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("66.10.157.182"),
System.Net.IPAddress.Parse("122.5.248.230"),
System.Net.IPAddress.Parse("33.155.25.131"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayIPv41M
{
    Id = 80,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("179.182.34.15"),
System.Net.IPAddress.Parse("157.82.165.186"),
System.Net.IPAddress.Parse("183.45.13.52"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 103,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("175.81.114.76"),
System.Net.IPAddress.Parse("102.170.246.1"),
System.Net.IPAddress.Parse("67.171.105.91"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("212.199.160.208"),
System.Net.IPAddress.Parse("236.137.102.102"),
System.Net.IPAddress.Parse("157.32.242.208"),
System.Net.IPAddress.Parse("183.36.230.159"),
},
},
    NullableValue = null,
},
            new IPAddressArrayIPv41M
{
    Id = 89,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("123.151.59.235"),
System.Net.IPAddress.Parse("53.187.229.95"),
System.Net.IPAddress.Parse("211.54.76.117"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 105,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("52.84.62.38"),
System.Net.IPAddress.Parse("200.236.186.145"),
System.Net.IPAddress.Parse("71.229.11.31"),
System.Net.IPAddress.Parse("15.154.107.60"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("138.15.213.116"),
System.Net.IPAddress.Parse("96.39.197.216"),
System.Net.IPAddress.Parse("45.200.142.161"),
},
},
            new IPAddressArrayIPv41M
{
    Id = 95,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("47.105.191.21"),
System.Net.IPAddress.Parse("146.54.90.95"),
System.Net.IPAddress.Parse("115.70.174.161"),
System.Net.IPAddress.Parse("113.102.245.195"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 107,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("85.226.16.198"),
System.Net.IPAddress.Parse("128.28.12.196"),
System.Net.IPAddress.Parse("84.0.94.131"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("84.64.220.113"),
System.Net.IPAddress.Parse("209.248.142.127"),
System.Net.IPAddress.Parse("25.176.221.90"),
},
},
    NullableValue = null,
},
            new IPAddressArrayIPv41M
{
    Id = 98,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("51.210.24.99"),
System.Net.IPAddress.Parse("94.36.62.253"),
System.Net.IPAddress.Parse("44.229.105.84"),
System.Net.IPAddress.Parse("231.59.157.164"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 111,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("34.224.192.117"),
System.Net.IPAddress.Parse("126.97.161.76"),
System.Net.IPAddress.Parse("12.226.123.213"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("121.246.150.228"),
System.Net.IPAddress.Parse("32.192.197.195"),
System.Net.IPAddress.Parse("150.204.113.132"),
},
},
            new IPAddressArrayIPv41M
{
    Id = 103,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.177.183.3"),
System.Net.IPAddress.Parse("235.9.221.15"),
System.Net.IPAddress.Parse("5.221.96.147"),
System.Net.IPAddress.Parse("238.171.30.78"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 116,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("38.41.168.163"),
System.Net.IPAddress.Parse("246.63.163.164"),
System.Net.IPAddress.Parse("120.210.74.153"),
System.Net.IPAddress.Parse("167.242.224.136"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayIPv41M
{
    Id = 109,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("20.182.213.118"),
System.Net.IPAddress.Parse("82.48.146.72"),
System.Net.IPAddress.Parse("1.209.17.196"),
System.Net.IPAddress.Parse("123.33.129.2"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 117,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.66.195.139"),
System.Net.IPAddress.Parse("143.25.111.71"),
System.Net.IPAddress.Parse("195.238.2.134"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("230.67.72.2"),
System.Net.IPAddress.Parse("178.58.127.101"),
System.Net.IPAddress.Parse("70.194.233.200"),
},
},
    NullableValue = null,
},
            new IPAddressArrayIPv41M
{
    Id = 116,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("99.94.93.141"),
System.Net.IPAddress.Parse("232.143.10.77"),
System.Net.IPAddress.Parse("187.243.129.134"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 122,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("117.145.217.19"),
System.Net.IPAddress.Parse("111.140.250.196"),
System.Net.IPAddress.Parse("69.148.58.123"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("119.141.62.89"),
System.Net.IPAddress.Parse("144.28.186.243"),
System.Net.IPAddress.Parse("191.39.189.43"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("10.136.191.207"),
System.Net.IPAddress.Parse("142.155.126.54"),
System.Net.IPAddress.Parse("45.221.29.93"),
System.Net.IPAddress.Parse("205.82.205.1"),
},
},
            new IPAddressArrayIPv41M
{
    Id = 124,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("117.136.103.50"),
System.Net.IPAddress.Parse("86.0.69.109"),
System.Net.IPAddress.Parse("150.31.156.18"),
System.Net.IPAddress.Parse("6.189.173.109"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 130,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("74.193.65.244"),
System.Net.IPAddress.Parse("230.177.35.41"),
System.Net.IPAddress.Parse("83.178.226.139"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("207.25.46.131"),
System.Net.IPAddress.Parse("173.81.107.179"),
System.Net.IPAddress.Parse("152.15.144.206"),
System.Net.IPAddress.Parse("225.26.103.218"),
},
},
            new IPAddressArrayIPv41M
{
    Id = 131,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("95.135.45.112"),
System.Net.IPAddress.Parse("189.24.91.60"),
System.Net.IPAddress.Parse("46.70.230.208"),
System.Net.IPAddress.Parse("101.221.65.119"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 131,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("176.135.21.163"),
System.Net.IPAddress.Parse("50.20.77.228"),
System.Net.IPAddress.Parse("73.227.92.34"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("253.146.103.114"),
System.Net.IPAddress.Parse("48.207.203.92"),
System.Net.IPAddress.Parse("235.105.53.229"),
System.Net.IPAddress.Parse("18.229.69.200"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("63.190.187.235"),
System.Net.IPAddress.Parse("65.254.26.87"),
System.Net.IPAddress.Parse("219.95.214.175"),
},
},
            new IPAddressArrayIPv41M
{
    Id = 135,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("210.26.209.60"),
System.Net.IPAddress.Parse("12.92.100.20"),
System.Net.IPAddress.Parse("172.117.242.29"),
System.Net.IPAddress.Parse("0.9.147.149"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 134,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("189.12.253.219"),
System.Net.IPAddress.Parse("102.80.24.36"),
System.Net.IPAddress.Parse("61.223.24.96"),
System.Net.IPAddress.Parse("48.180.230.167"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayIPv41M
{
    Id = 142,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("161.246.60.250"),
System.Net.IPAddress.Parse("167.158.101.65"),
System.Net.IPAddress.Parse("192.161.218.89"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 143,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("209.100.84.45"),
System.Net.IPAddress.Parse("201.243.5.253"),
System.Net.IPAddress.Parse("101.183.206.50"),
System.Net.IPAddress.Parse("69.226.27.82"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("50.166.109.22"),
System.Net.IPAddress.Parse("208.188.50.16"),
System.Net.IPAddress.Parse("195.133.90.97"),
},
},
    NullableValue = null,
},
            new IPAddressArrayIPv41M
{
    Id = 151,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("151.184.134.22"),
System.Net.IPAddress.Parse("144.149.221.40"),
System.Net.IPAddress.Parse("171.63.8.86"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 152,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("172.55.69.113"),
System.Net.IPAddress.Parse("250.43.210.190"),
System.Net.IPAddress.Parse("67.120.252.120"),
System.Net.IPAddress.Parse("155.72.181.233"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayIPv41M
{
    Id = 159,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("180.100.166.143"),
System.Net.IPAddress.Parse("22.168.64.156"),
System.Net.IPAddress.Parse("97.115.61.71"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 154,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.66.60.175"),
System.Net.IPAddress.Parse("236.59.87.141"),
System.Net.IPAddress.Parse("171.192.138.117"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayIPv41M
{
    Id = 166,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("224.232.143.82"),
System.Net.IPAddress.Parse("210.4.6.61"),
System.Net.IPAddress.Parse("10.72.145.180"),
System.Net.IPAddress.Parse("206.60.82.158"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 155,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("213.144.203.68"),
System.Net.IPAddress.Parse("251.135.245.44"),
System.Net.IPAddress.Parse("93.211.159.221"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayIPv41M
{
    Id = 168,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("191.65.144.225"),
System.Net.IPAddress.Parse("94.10.76.197"),
System.Net.IPAddress.Parse("252.17.3.189"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 161,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("36.148.117.236"),
System.Net.IPAddress.Parse("225.124.118.105"),
System.Net.IPAddress.Parse("162.192.79.43"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.254.54.201"),
System.Net.IPAddress.Parse("111.211.219.19"),
System.Net.IPAddress.Parse("29.13.96.189"),
System.Net.IPAddress.Parse("65.15.254.241"),
},
},
            new IPAddressArrayIPv41M
{
    Id = 176,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("95.124.125.209"),
System.Net.IPAddress.Parse("204.99.125.108"),
System.Net.IPAddress.Parse("246.57.44.102"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 169,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("120.165.58.22"),
System.Net.IPAddress.Parse("225.173.120.206"),
System.Net.IPAddress.Parse("111.242.98.214"),
System.Net.IPAddress.Parse("84.230.89.209"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("51.160.92.75"),
System.Net.IPAddress.Parse("90.242.246.85"),
System.Net.IPAddress.Parse("58.19.29.1"),
System.Net.IPAddress.Parse("6.112.215.109"),
},
},
    NullableValue = null,
},
            new IPAddressArrayIPv41M
{
    Id = 182,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("95.172.15.207"),
System.Net.IPAddress.Parse("168.22.222.73"),
System.Net.IPAddress.Parse("24.114.201.56"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 171,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("28.107.227.204"),
System.Net.IPAddress.Parse("159.137.27.222"),
System.Net.IPAddress.Parse("244.235.105.234"),
System.Net.IPAddress.Parse("168.206.159.193"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("245.25.162.20"),
System.Net.IPAddress.Parse("112.53.53.131"),
System.Net.IPAddress.Parse("102.11.40.81"),
System.Net.IPAddress.Parse("90.128.249.19"),
},
},
            new IPAddressArrayIPv41M
{
    Id = 184,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("28.89.4.2"),
System.Net.IPAddress.Parse("170.42.155.114"),
System.Net.IPAddress.Parse("6.123.50.55"),
System.Net.IPAddress.Parse("70.251.187.0"),
},
    ModelInner = new IPAddressArrayIPv41MI
{
    Id = 179,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("249.93.131.138"),
System.Net.IPAddress.Parse("176.209.177.95"),
System.Net.IPAddress.Parse("161.42.75.224"),
System.Net.IPAddress.Parse("119.49.19.171"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("78.2.245.59"),
System.Net.IPAddress.Parse("118.201.181.171"),
System.Net.IPAddress.Parse("194.240.216.70"),
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.ipaddressarrayipv41m(
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
            asPartInterface: typeof(IIPAddressArrayArrayIPv4)),
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
                    await ((IIPAddressArrayArrayIPv4)this).InsertModelDbConnectionAsync(
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
                     ((IIPAddressArrayArrayIPv4)this).InsertModelDbConnection(
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
FROM gedaqtests.ipaddressarrayipv41m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(IPAddressArrayIPv41M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayArrayIPv4)),
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
                    var models = await ((IIPAddressArrayArrayIPv4)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    IPAddressArrayIPv41M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IIPAddressArrayArrayIPv4)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    IPAddressArrayIPv41M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

