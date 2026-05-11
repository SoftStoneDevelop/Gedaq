

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
    Id = 9,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("36.210.156.193"),
System.Net.IPAddress.Parse("111.100.185.202"),
System.Net.IPAddress.Parse("153.138.60.96"),
System.Net.IPAddress.Parse("38.183.84.7"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 14,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("12.1.21.147"),
System.Net.IPAddress.Parse("204.241.21.41"),
System.Net.IPAddress.Parse("204.77.94.170"),
System.Net.IPAddress.Parse("88.120.211.1"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 1,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("73.116.136.222"),
System.Net.IPAddress.Parse("203.37.118.210"),
System.Net.IPAddress.Parse("125.39.249.69"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 17,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("17.240.216.210"),
System.Net.IPAddress.Parse("209.99.7.25"),
System.Net.IPAddress.Parse("35.9.32.6"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 21,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("96.54.108.38"),
System.Net.IPAddress.Parse("22.92.83.182"),
System.Net.IPAddress.Parse("206.109.88.2"),
System.Net.IPAddress.Parse("135.163.206.20"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("110.39.167.164"),
System.Net.IPAddress.Parse("141.92.94.231"),
System.Net.IPAddress.Parse("7.239.43.146"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 26,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("66.151.165.38"),
System.Net.IPAddress.Parse("37.191.1.140"),
System.Net.IPAddress.Parse("240.147.210.194"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("165.120.172.162"),
System.Net.IPAddress.Parse("79.16.224.246"),
System.Net.IPAddress.Parse("21.166.130.150"),
System.Net.IPAddress.Parse("162.79.180.56"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 30,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("62.32.73.103"),
System.Net.IPAddress.Parse("156.81.139.80"),
System.Net.IPAddress.Parse("74.190.144.229"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 14,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.168.33.107"),
System.Net.IPAddress.Parse("29.213.180.9"),
System.Net.IPAddress.Parse("12.167.94.228"),
System.Net.IPAddress.Parse("254.143.170.139"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 39,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("176.42.185.206"),
System.Net.IPAddress.Parse("97.72.202.85"),
System.Net.IPAddress.Parse("5.146.97.226"),
System.Net.IPAddress.Parse("53.161.185.199"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 40,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("36.12.76.59"),
System.Net.IPAddress.Parse("100.203.253.119"),
System.Net.IPAddress.Parse("57.101.70.222"),
System.Net.IPAddress.Parse("57.2.126.35"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("113.194.0.177"),
System.Net.IPAddress.Parse("126.65.202.210"),
System.Net.IPAddress.Parse("173.242.244.163"),
System.Net.IPAddress.Parse("139.69.240.93"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 46,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("230.197.8.26"),
System.Net.IPAddress.Parse("172.248.20.152"),
System.Net.IPAddress.Parse("140.39.114.116"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("30.89.138.198"),
System.Net.IPAddress.Parse("200.208.234.84"),
System.Net.IPAddress.Parse("100.106.107.64"),
System.Net.IPAddress.Parse("63.153.193.112"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 47,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("236.54.98.247"),
System.Net.IPAddress.Parse("169.61.248.136"),
System.Net.IPAddress.Parse("184.211.169.133"),
System.Net.IPAddress.Parse("144.230.43.12"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 23,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("76.198.69.196"),
System.Net.IPAddress.Parse("21.63.178.186"),
System.Net.IPAddress.Parse("22.85.96.163"),
System.Net.IPAddress.Parse("222.19.65.135"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("58.48.92.147"),
System.Net.IPAddress.Parse("197.72.63.62"),
System.Net.IPAddress.Parse("205.189.74.171"),
},
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 56,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("207.117.218.70"),
System.Net.IPAddress.Parse("227.163.174.232"),
System.Net.IPAddress.Parse("142.130.155.222"),
System.Net.IPAddress.Parse("46.148.148.66"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 65,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("70.39.131.210"),
System.Net.IPAddress.Parse("178.74.82.69"),
System.Net.IPAddress.Parse("196.121.232.57"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("103.51.48.65"),
System.Net.IPAddress.Parse("176.37.128.221"),
System.Net.IPAddress.Parse("7.181.72.115"),
System.Net.IPAddress.Parse("236.44.76.210"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.188.76.124"),
System.Net.IPAddress.Parse("222.108.207.127"),
System.Net.IPAddress.Parse("248.144.53.198"),
System.Net.IPAddress.Parse("99.184.38.155"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("139.203.225.192"),
System.Net.IPAddress.Parse("177.70.96.233"),
System.Net.IPAddress.Parse("74.92.117.72"),
System.Net.IPAddress.Parse("242.239.105.92"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 73,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.194.12.247"),
System.Net.IPAddress.Parse("249.200.252.18"),
System.Net.IPAddress.Parse("28.209.157.250"),
System.Net.IPAddress.Parse("81.104.235.128"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 75,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("35.42.249.216"),
System.Net.IPAddress.Parse("12.208.179.27"),
System.Net.IPAddress.Parse("54.88.219.115"),
System.Net.IPAddress.Parse("238.150.159.59"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 33,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("104.144.26.67"),
System.Net.IPAddress.Parse("152.233.0.68"),
System.Net.IPAddress.Parse("152.146.107.223"),
System.Net.IPAddress.Parse("38.191.42.30"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("51.107.96.122"),
System.Net.IPAddress.Parse("123.139.37.170"),
System.Net.IPAddress.Parse("168.95.19.206"),
System.Net.IPAddress.Parse("25.119.105.150"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("222.174.138.58"),
System.Net.IPAddress.Parse("227.22.183.123"),
System.Net.IPAddress.Parse("185.173.160.129"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 87,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("218.91.218.247"),
System.Net.IPAddress.Parse("149.19.38.214"),
System.Net.IPAddress.Parse("20.201.132.74"),
System.Net.IPAddress.Parse("234.206.232.102"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 34,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("235.118.73.170"),
System.Net.IPAddress.Parse("22.95.123.70"),
System.Net.IPAddress.Parse("21.195.47.178"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("147.178.192.211"),
System.Net.IPAddress.Parse("80.146.186.59"),
System.Net.IPAddress.Parse("234.116.173.84"),
System.Net.IPAddress.Parse("49.9.200.98"),
},
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 93,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("225.159.216.110"),
System.Net.IPAddress.Parse("91.168.177.196"),
System.Net.IPAddress.Parse("67.101.97.134"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("18.214.106.217"),
System.Net.IPAddress.Parse("253.220.92.219"),
System.Net.IPAddress.Parse("202.180.85.79"),
System.Net.IPAddress.Parse("243.20.37.188"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 98,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("84.111.75.29"),
System.Net.IPAddress.Parse("202.223.62.224"),
System.Net.IPAddress.Parse("190.130.250.55"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 41,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("7.201.19.156"),
System.Net.IPAddress.Parse("145.24.70.242"),
System.Net.IPAddress.Parse("89.216.69.130"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("28.69.223.128"),
System.Net.IPAddress.Parse("110.66.186.25"),
System.Net.IPAddress.Parse("215.176.148.26"),
System.Net.IPAddress.Parse("6.154.175.26"),
},
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 102,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("173.136.109.22"),
System.Net.IPAddress.Parse("35.221.53.79"),
System.Net.IPAddress.Parse("171.92.0.250"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 104,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("79.121.165.39"),
System.Net.IPAddress.Parse("109.106.31.207"),
System.Net.IPAddress.Parse("222.77.62.228"),
System.Net.IPAddress.Parse("68.170.241.150"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 49,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("167.164.232.11"),
System.Net.IPAddress.Parse("246.178.184.129"),
System.Net.IPAddress.Parse("40.237.205.129"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("66.223.207.175"),
System.Net.IPAddress.Parse("66.9.83.220"),
System.Net.IPAddress.Parse("87.224.74.216"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 112,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("187.80.163.238"),
System.Net.IPAddress.Parse("25.86.81.189"),
System.Net.IPAddress.Parse("242.124.180.220"),
System.Net.IPAddress.Parse("231.51.39.170"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 116,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("163.108.147.245"),
System.Net.IPAddress.Parse("31.130.172.149"),
System.Net.IPAddress.Parse("189.148.83.30"),
System.Net.IPAddress.Parse("224.142.92.101"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 54,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("196.224.55.212"),
System.Net.IPAddress.Parse("242.214.253.204"),
System.Net.IPAddress.Parse("47.99.97.187"),
System.Net.IPAddress.Parse("97.16.102.212"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("141.222.90.97"),
System.Net.IPAddress.Parse("116.240.118.248"),
System.Net.IPAddress.Parse("201.247.79.248"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("159.196.163.18"),
System.Net.IPAddress.Parse("178.188.252.190"),
System.Net.IPAddress.Parse("63.112.171.164"),
System.Net.IPAddress.Parse("43.190.99.98"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 125,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("194.131.0.16"),
System.Net.IPAddress.Parse("66.228.248.111"),
System.Net.IPAddress.Parse("38.235.89.9"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("94.18.158.204"),
System.Net.IPAddress.Parse("21.91.185.133"),
System.Net.IPAddress.Parse("82.57.183.29"),
System.Net.IPAddress.Parse("242.252.240.64"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 132,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("113.131.173.58"),
System.Net.IPAddress.Parse("223.226.141.78"),
System.Net.IPAddress.Parse("66.195.195.188"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("47.172.77.102"),
System.Net.IPAddress.Parse("152.65.124.50"),
System.Net.IPAddress.Parse("230.6.119.151"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("76.43.188.52"),
System.Net.IPAddress.Parse("166.50.74.246"),
System.Net.IPAddress.Parse("200.166.199.127"),
System.Net.IPAddress.Parse("145.109.113.39"),
},
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 140,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("216.114.201.250"),
System.Net.IPAddress.Parse("250.114.36.240"),
System.Net.IPAddress.Parse("4.182.228.182"),
System.Net.IPAddress.Parse("58.0.31.211"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("225.70.37.166"),
System.Net.IPAddress.Parse("67.122.199.140"),
System.Net.IPAddress.Parse("45.191.127.14"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 143,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("122.38.8.149"),
System.Net.IPAddress.Parse("45.28.253.67"),
System.Net.IPAddress.Parse("206.136.68.88"),
System.Net.IPAddress.Parse("160.131.231.36"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 59,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("156.61.150.188"),
System.Net.IPAddress.Parse("123.128.157.130"),
System.Net.IPAddress.Parse("151.247.62.190"),
System.Net.IPAddress.Parse("42.124.78.36"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("30.141.52.57"),
System.Net.IPAddress.Parse("226.155.67.34"),
System.Net.IPAddress.Parse("138.50.200.70"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.99.149.163"),
System.Net.IPAddress.Parse("14.79.147.16"),
System.Net.IPAddress.Parse("53.98.85.82"),
System.Net.IPAddress.Parse("210.137.122.199"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 152,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("239.102.110.192"),
System.Net.IPAddress.Parse("88.21.248.18"),
System.Net.IPAddress.Parse("7.167.207.244"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("252.48.61.109"),
System.Net.IPAddress.Parse("200.63.174.221"),
System.Net.IPAddress.Parse("158.229.212.143"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 154,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("130.5.22.19"),
System.Net.IPAddress.Parse("235.244.27.239"),
System.Net.IPAddress.Parse("227.176.196.227"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 62,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("67.82.147.36"),
System.Net.IPAddress.Parse("57.135.65.48"),
System.Net.IPAddress.Parse("241.230.22.217"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 161,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("130.53.213.145"),
System.Net.IPAddress.Parse("186.252.222.52"),
System.Net.IPAddress.Parse("31.204.67.183"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 169,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("8.210.60.148"),
System.Net.IPAddress.Parse("65.29.64.26"),
System.Net.IPAddress.Parse("244.22.18.238"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 65,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("5.24.130.29"),
System.Net.IPAddress.Parse("171.146.191.102"),
System.Net.IPAddress.Parse("132.240.171.22"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.208.219.253"),
System.Net.IPAddress.Parse("121.24.165.205"),
System.Net.IPAddress.Parse("81.36.61.28"),
System.Net.IPAddress.Parse("55.222.91.178"),
},
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 175,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("239.43.38.59"),
System.Net.IPAddress.Parse("221.226.58.202"),
System.Net.IPAddress.Parse("152.122.100.142"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 182,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("219.196.2.240"),
System.Net.IPAddress.Parse("105.8.130.23"),
System.Net.IPAddress.Parse("94.137.72.151"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 73,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("8.192.147.53"),
System.Net.IPAddress.Parse("196.71.205.194"),
System.Net.IPAddress.Parse("195.11.62.179"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("114.16.71.23"),
System.Net.IPAddress.Parse("122.175.86.62"),
System.Net.IPAddress.Parse("154.111.173.187"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 188,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("215.76.92.111"),
System.Net.IPAddress.Parse("115.6.152.86"),
System.Net.IPAddress.Parse("48.156.217.55"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 193,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("4.40.249.12"),
System.Net.IPAddress.Parse("173.52.60.7"),
System.Net.IPAddress.Parse("206.220.162.142"),
System.Net.IPAddress.Parse("102.72.213.194"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("123.128.211.81"),
System.Net.IPAddress.Parse("84.221.133.176"),
System.Net.IPAddress.Parse("131.91.170.30"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("67.20.5.208"),
System.Net.IPAddress.Parse("230.205.37.224"),
System.Net.IPAddress.Parse("92.35.61.75"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 195,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("224.72.118.241"),
System.Net.IPAddress.Parse("12.201.191.88"),
System.Net.IPAddress.Parse("57.202.115.147"),
System.Net.IPAddress.Parse("174.29.54.67"),
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
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("165.120.172.162"),
System.Net.IPAddress.Parse("79.16.224.246"),
System.Net.IPAddress.Parse("21.166.130.150"),
System.Net.IPAddress.Parse("162.79.180.56"),
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
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("30.89.138.198"),
System.Net.IPAddress.Parse("200.208.234.84"),
System.Net.IPAddress.Parse("100.106.107.64"),
System.Net.IPAddress.Parse("63.153.193.112"),
}));
                nullable =  ((IIPAddressMArrayinetMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((IIPAddressMArrayinetMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IIPAddressMArrayinetMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("139.203.225.192"),
System.Net.IPAddress.Parse("177.70.96.233"),
System.Net.IPAddress.Parse("74.92.117.72"),
System.Net.IPAddress.Parse("242.239.105.92"),
}));
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 188;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
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
                parametr1.Value = 182;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 188;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[24],_testData[34], false);
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
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
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
                await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 26, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[12],_testData[34], false);
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
                await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 39, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
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
                 ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 132, query1, 143, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
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
                 ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 161, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 152, query1, 14, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
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
                await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 140, query1, 175, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 112, query1, 46, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 104, query1, 56, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[23],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 47, 154))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 140, 154))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                ((IIPAddressMArrayinetMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 132);
                var models = await ((IIPAddressMArrayinetMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressMArrayinetMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressMArrayinetMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 17);
                var models =  ((IIPAddressMArrayinetMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
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

