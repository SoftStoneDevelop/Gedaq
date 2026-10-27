

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
    Id = 3,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("55.11.228.170"),
System.Net.IPAddress.Parse("111.55.35.224"),
System.Net.IPAddress.Parse("152.97.56.190"),
System.Net.IPAddress.Parse("31.142.7.51"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("200.89.183.26"),
System.Net.IPAddress.Parse("214.99.101.110"),
System.Net.IPAddress.Parse("128.121.180.97"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 6,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("129.48.156.148"),
System.Net.IPAddress.Parse("133.219.209.30"),
System.Net.IPAddress.Parse("126.186.238.183"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 6,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("253.129.113.7"),
System.Net.IPAddress.Parse("160.174.179.60"),
System.Net.IPAddress.Parse("177.195.120.116"),
System.Net.IPAddress.Parse("88.234.147.23"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("161.90.193.219"),
System.Net.IPAddress.Parse("251.238.55.89"),
System.Net.IPAddress.Parse("6.40.10.101"),
System.Net.IPAddress.Parse("223.123.135.248"),
},
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 15,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("237.213.157.11"),
System.Net.IPAddress.Parse("82.238.210.101"),
System.Net.IPAddress.Parse("250.116.242.204"),
System.Net.IPAddress.Parse("57.67.141.92"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.53.62.20"),
System.Net.IPAddress.Parse("94.36.151.179"),
System.Net.IPAddress.Parse("61.66.166.233"),
System.Net.IPAddress.Parse("198.113.254.204"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 18,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("201.5.245.217"),
System.Net.IPAddress.Parse("158.143.216.159"),
System.Net.IPAddress.Parse("234.240.162.62"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 7,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("213.100.181.4"),
System.Net.IPAddress.Parse("193.164.21.39"),
System.Net.IPAddress.Parse("173.130.73.111"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 27,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("33.79.240.190"),
System.Net.IPAddress.Parse("209.36.72.3"),
System.Net.IPAddress.Parse("91.38.156.83"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 30,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("139.182.58.66"),
System.Net.IPAddress.Parse("241.199.47.194"),
System.Net.IPAddress.Parse("52.20.114.146"),
System.Net.IPAddress.Parse("109.123.211.96"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 8,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("1.34.171.92"),
System.Net.IPAddress.Parse("238.243.93.234"),
System.Net.IPAddress.Parse("219.111.231.149"),
System.Net.IPAddress.Parse("129.71.150.14"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("194.232.225.201"),
System.Net.IPAddress.Parse("240.18.43.77"),
System.Net.IPAddress.Parse("147.231.92.191"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("159.171.56.95"),
System.Net.IPAddress.Parse("99.105.213.159"),
System.Net.IPAddress.Parse("228.219.108.126"),
System.Net.IPAddress.Parse("24.67.96.39"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 32,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("123.166.66.247"),
System.Net.IPAddress.Parse("2.208.3.151"),
System.Net.IPAddress.Parse("106.225.111.220"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("140.49.65.25"),
System.Net.IPAddress.Parse("172.159.42.166"),
System.Net.IPAddress.Parse("13.189.171.31"),
System.Net.IPAddress.Parse("237.179.156.201"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 41,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("250.35.252.145"),
System.Net.IPAddress.Parse("252.165.134.223"),
System.Net.IPAddress.Parse("8.170.145.239"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 16,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.4.169.96"),
System.Net.IPAddress.Parse("243.133.106.69"),
System.Net.IPAddress.Parse("230.100.214.61"),
System.Net.IPAddress.Parse("127.171.60.209"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("145.209.245.58"),
System.Net.IPAddress.Parse("171.245.67.191"),
System.Net.IPAddress.Parse("23.128.54.229"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("131.4.195.16"),
System.Net.IPAddress.Parse("81.56.151.40"),
System.Net.IPAddress.Parse("73.66.234.25"),
System.Net.IPAddress.Parse("80.144.144.94"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 50,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("138.68.160.170"),
System.Net.IPAddress.Parse("231.60.57.171"),
System.Net.IPAddress.Parse("49.4.22.252"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 56,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("247.42.22.227"),
System.Net.IPAddress.Parse("184.89.220.41"),
System.Net.IPAddress.Parse("61.198.4.106"),
System.Net.IPAddress.Parse("173.184.187.235"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 18,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.126.198.111"),
System.Net.IPAddress.Parse("152.225.100.215"),
System.Net.IPAddress.Parse("68.215.112.9"),
System.Net.IPAddress.Parse("128.16.37.65"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.230.207.169"),
System.Net.IPAddress.Parse("1.17.121.198"),
System.Net.IPAddress.Parse("7.121.239.238"),
System.Net.IPAddress.Parse("73.246.65.160"),
},
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 64,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("152.58.251.31"),
System.Net.IPAddress.Parse("207.173.123.254"),
System.Net.IPAddress.Parse("132.78.160.234"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 73,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("241.103.81.240"),
System.Net.IPAddress.Parse("141.226.178.209"),
System.Net.IPAddress.Parse("30.160.165.164"),
System.Net.IPAddress.Parse("142.159.79.231"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 23,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("238.98.208.65"),
System.Net.IPAddress.Parse("52.155.160.248"),
System.Net.IPAddress.Parse("98.197.6.113"),
System.Net.IPAddress.Parse("43.15.100.174"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.5.44.6"),
System.Net.IPAddress.Parse("21.93.140.57"),
System.Net.IPAddress.Parse("241.110.192.223"),
},
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("238.9.154.172"),
System.Net.IPAddress.Parse("31.163.98.28"),
System.Net.IPAddress.Parse("176.95.32.125"),
System.Net.IPAddress.Parse("30.220.38.57"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("83.131.226.235"),
System.Net.IPAddress.Parse("185.111.191.234"),
System.Net.IPAddress.Parse("81.75.26.199"),
System.Net.IPAddress.Parse("108.221.156.36"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 87,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("36.1.254.212"),
System.Net.IPAddress.Parse("29.18.141.189"),
System.Net.IPAddress.Parse("201.126.43.167"),
System.Net.IPAddress.Parse("129.61.141.34"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("241.38.11.198"),
System.Net.IPAddress.Parse("166.249.8.138"),
System.Net.IPAddress.Parse("174.30.69.26"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("106.191.5.47"),
System.Net.IPAddress.Parse("251.144.194.4"),
System.Net.IPAddress.Parse("58.250.253.197"),
},
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 96,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("254.160.41.193"),
System.Net.IPAddress.Parse("131.128.156.17"),
System.Net.IPAddress.Parse("44.164.135.12"),
System.Net.IPAddress.Parse("43.137.104.118"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("180.141.235.123"),
System.Net.IPAddress.Parse("215.239.174.232"),
System.Net.IPAddress.Parse("86.233.2.100"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("176.201.237.15"),
System.Net.IPAddress.Parse("35.133.17.222"),
System.Net.IPAddress.Parse("53.132.228.56"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("224.195.92.3"),
System.Net.IPAddress.Parse("146.113.31.171"),
System.Net.IPAddress.Parse("162.184.131.109"),
System.Net.IPAddress.Parse("250.67.205.148"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("249.107.194.241"),
System.Net.IPAddress.Parse("46.113.212.17"),
System.Net.IPAddress.Parse("78.231.207.96"),
System.Net.IPAddress.Parse("93.46.12.134"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 112,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("248.66.199.178"),
System.Net.IPAddress.Parse("187.176.96.163"),
System.Net.IPAddress.Parse("211.13.50.39"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("23.252.208.214"),
System.Net.IPAddress.Parse("223.96.217.168"),
System.Net.IPAddress.Parse("65.210.213.241"),
System.Net.IPAddress.Parse("100.15.176.119"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 113,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("137.89.72.45"),
System.Net.IPAddress.Parse("72.86.124.19"),
System.Net.IPAddress.Parse("59.78.65.216"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 33,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("140.164.143.173"),
System.Net.IPAddress.Parse("33.77.64.110"),
System.Net.IPAddress.Parse("118.183.54.230"),
System.Net.IPAddress.Parse("70.62.149.128"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("198.223.233.95"),
System.Net.IPAddress.Parse("167.80.68.232"),
System.Net.IPAddress.Parse("239.139.51.86"),
System.Net.IPAddress.Parse("215.136.152.119"),
},
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 116,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("229.216.133.254"),
System.Net.IPAddress.Parse("124.166.18.234"),
System.Net.IPAddress.Parse("209.102.233.219"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 117,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("191.147.33.37"),
System.Net.IPAddress.Parse("20.0.60.124"),
System.Net.IPAddress.Parse("131.55.232.248"),
System.Net.IPAddress.Parse("171.77.196.7"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 40,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("110.226.233.124"),
System.Net.IPAddress.Parse("193.24.78.122"),
System.Net.IPAddress.Parse("22.250.69.67"),
System.Net.IPAddress.Parse("200.138.180.170"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("50.172.115.163"),
System.Net.IPAddress.Parse("41.131.196.64"),
System.Net.IPAddress.Parse("77.112.241.224"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("171.109.147.36"),
System.Net.IPAddress.Parse("82.80.200.68"),
System.Net.IPAddress.Parse("48.200.241.204"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 119,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("23.151.115.102"),
System.Net.IPAddress.Parse("101.246.20.84"),
System.Net.IPAddress.Parse("127.192.83.190"),
System.Net.IPAddress.Parse("8.195.47.192"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("110.164.95.158"),
System.Net.IPAddress.Parse("56.74.173.212"),
System.Net.IPAddress.Parse("212.237.89.254"),
System.Net.IPAddress.Parse("41.130.0.95"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 120,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("250.227.203.77"),
System.Net.IPAddress.Parse("54.18.6.99"),
System.Net.IPAddress.Parse("234.219.176.15"),
System.Net.IPAddress.Parse("133.22.151.237"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 46,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("136.42.59.179"),
System.Net.IPAddress.Parse("149.155.190.132"),
System.Net.IPAddress.Parse("227.249.139.149"),
System.Net.IPAddress.Parse("238.163.132.141"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("108.143.239.200"),
System.Net.IPAddress.Parse("220.190.198.159"),
System.Net.IPAddress.Parse("147.84.146.252"),
System.Net.IPAddress.Parse("42.184.126.110"),
},
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 129,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("217.222.103.254"),
System.Net.IPAddress.Parse("7.135.190.47"),
System.Net.IPAddress.Parse("83.236.69.116"),
System.Net.IPAddress.Parse("212.11.181.144"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 134,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("52.50.115.118"),
System.Net.IPAddress.Parse("17.105.210.230"),
System.Net.IPAddress.Parse("98.64.141.188"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 55,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("103.129.53.15"),
System.Net.IPAddress.Parse("237.182.58.167"),
System.Net.IPAddress.Parse("96.159.162.107"),
System.Net.IPAddress.Parse("111.108.191.63"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 143,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("156.232.189.152"),
System.Net.IPAddress.Parse("196.246.198.68"),
System.Net.IPAddress.Parse("40.82.143.182"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("47.100.179.15"),
System.Net.IPAddress.Parse("13.156.238.4"),
System.Net.IPAddress.Parse("244.178.109.40"),
System.Net.IPAddress.Parse("178.157.159.86"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 148,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("192.253.240.233"),
System.Net.IPAddress.Parse("251.64.61.96"),
System.Net.IPAddress.Parse("205.207.99.32"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 60,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("33.205.174.105"),
System.Net.IPAddress.Parse("248.89.109.221"),
System.Net.IPAddress.Parse("70.217.29.81"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("96.5.240.215"),
System.Net.IPAddress.Parse("121.92.49.98"),
System.Net.IPAddress.Parse("153.138.50.182"),
System.Net.IPAddress.Parse("108.29.136.77"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("92.192.58.42"),
System.Net.IPAddress.Parse("76.244.230.80"),
System.Net.IPAddress.Parse("31.219.248.125"),
System.Net.IPAddress.Parse("235.132.5.33"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 157,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("165.161.29.49"),
System.Net.IPAddress.Parse("79.115.29.135"),
System.Net.IPAddress.Parse("41.176.218.55"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 165,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("251.203.183.238"),
System.Net.IPAddress.Parse("119.113.51.215"),
System.Net.IPAddress.Parse("113.104.241.86"),
System.Net.IPAddress.Parse("117.31.156.171"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 65,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("34.34.11.151"),
System.Net.IPAddress.Parse("15.123.29.13"),
System.Net.IPAddress.Parse("180.79.31.147"),
System.Net.IPAddress.Parse("164.37.249.232"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("25.249.17.120"),
System.Net.IPAddress.Parse("88.49.211.79"),
System.Net.IPAddress.Parse("162.176.188.169"),
System.Net.IPAddress.Parse("88.46.74.142"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 168,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("145.219.10.174"),
System.Net.IPAddress.Parse("26.239.80.246"),
System.Net.IPAddress.Parse("109.78.169.113"),
System.Net.IPAddress.Parse("31.121.88.211"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("74.232.209.124"),
System.Net.IPAddress.Parse("50.100.13.76"),
System.Net.IPAddress.Parse("92.190.227.89"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 172,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("86.106.71.87"),
System.Net.IPAddress.Parse("6.233.103.147"),
System.Net.IPAddress.Parse("95.158.4.162"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("222.175.56.128"),
System.Net.IPAddress.Parse("152.0.19.1"),
System.Net.IPAddress.Parse("252.148.231.21"),
System.Net.IPAddress.Parse("68.213.130.117"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 178,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("73.45.100.138"),
System.Net.IPAddress.Parse("106.174.224.231"),
System.Net.IPAddress.Parse("139.186.174.198"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 184,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("196.116.61.33"),
System.Net.IPAddress.Parse("150.198.95.156"),
System.Net.IPAddress.Parse("11.144.67.95"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 76,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("4.40.157.173"),
System.Net.IPAddress.Parse("84.5.91.242"),
System.Net.IPAddress.Parse("9.227.42.179"),
System.Net.IPAddress.Parse("43.61.28.170"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("136.151.231.238"),
System.Net.IPAddress.Parse("203.16.115.204"),
System.Net.IPAddress.Parse("23.241.248.169"),
System.Net.IPAddress.Parse("176.236.132.164"),
},
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 187,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("50.163.181.172"),
System.Net.IPAddress.Parse("59.193.218.104"),
System.Net.IPAddress.Parse("22.56.104.163"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 194,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("177.7.254.87"),
System.Net.IPAddress.Parse("192.61.250.226"),
System.Net.IPAddress.Parse("252.194.104.217"),
System.Net.IPAddress.Parse("19.24.81.35"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 85,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("104.250.138.205"),
System.Net.IPAddress.Parse("53.206.209.115"),
System.Net.IPAddress.Parse("73.42.140.69"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("38.37.238.109"),
System.Net.IPAddress.Parse("45.108.31.92"),
System.Net.IPAddress.Parse("189.250.248.182"),
System.Net.IPAddress.Parse("53.179.183.123"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("104.78.101.108"),
System.Net.IPAddress.Parse("5.13.75.252"),
System.Net.IPAddress.Parse("248.166.219.218"),
System.Net.IPAddress.Parse("31.12.91.199"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 202,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("1.36.192.218"),
System.Net.IPAddress.Parse("118.245.94.218"),
System.Net.IPAddress.Parse("222.214.48.213"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("128.22.112.181"),
System.Net.IPAddress.Parse("127.229.183.4"),
System.Net.IPAddress.Parse("238.172.205.50"),
},
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

                    nullable =  ((IIPAddressMArrayinetMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("159.171.56.95"),
System.Net.IPAddress.Parse("99.105.213.159"),
System.Net.IPAddress.Parse("228.219.108.126"),
System.Net.IPAddress.Parse("24.67.96.39"),
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

                    nullable = await ((IIPAddressMArrayinetMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("140.49.65.25"),
System.Net.IPAddress.Parse("172.159.42.166"),
System.Net.IPAddress.Parse("13.189.171.31"),
System.Net.IPAddress.Parse("237.179.156.201"),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("131.4.195.16"),
System.Net.IPAddress.Parse("81.56.151.40"),
System.Net.IPAddress.Parse("73.66.234.25"),
System.Net.IPAddress.Parse("80.144.144.94"),
}));
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
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 165;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 184;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 172;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
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
                parametr1.Value = 165;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 168;
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[29],_testData[34], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
                await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 15, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[31],_testData[34], false);
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
                await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 3, query1, 184, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
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
                 ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 116, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
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
                 ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 148, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 117, query1, 143, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 18, query1, 148, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 134, query1, 134, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
                 ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 116, query1, 18, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 178, 134))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 105, 148))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IIPAddressMArrayinetMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IIPAddressMArrayinetMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 187);
                var models = await ((IIPAddressMArrayinetMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressMArrayinetMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressMArrayinetMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 187);
                var models =  ((IIPAddressMArrayinetMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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

