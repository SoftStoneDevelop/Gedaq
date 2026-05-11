

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
System.Net.IPAddress.Parse("47.1.229.167"),
System.Net.IPAddress.Parse("185.99.142.109"),
System.Net.IPAddress.Parse("102.197.137.154"),
System.Net.IPAddress.Parse("163.219.127.247"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 11,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("210.50.51.136"),
System.Net.IPAddress.Parse("218.177.109.44"),
System.Net.IPAddress.Parse("207.187.78.235"),
System.Net.IPAddress.Parse("230.131.25.36"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 1,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("219.234.176.60"),
System.Net.IPAddress.Parse("139.239.54.229"),
System.Net.IPAddress.Parse("78.218.9.198"),
System.Net.IPAddress.Parse("170.206.174.207"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("202.18.16.221"),
System.Net.IPAddress.Parse("206.88.17.43"),
System.Net.IPAddress.Parse("229.76.58.37"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("198.99.135.93"),
System.Net.IPAddress.Parse("40.233.18.247"),
System.Net.IPAddress.Parse("204.130.115.115"),
System.Net.IPAddress.Parse("198.148.138.30"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 19,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("159.121.173.214"),
System.Net.IPAddress.Parse("106.38.105.7"),
System.Net.IPAddress.Parse("27.235.184.167"),
System.Net.IPAddress.Parse("236.213.71.154"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 28,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("213.240.7.218"),
System.Net.IPAddress.Parse("237.191.118.26"),
System.Net.IPAddress.Parse("83.160.128.193"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 8,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.72.222.184"),
System.Net.IPAddress.Parse("236.194.56.103"),
System.Net.IPAddress.Parse("109.105.238.163"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 29,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("252.145.168.236"),
System.Net.IPAddress.Parse("48.0.45.3"),
System.Net.IPAddress.Parse("123.53.27.222"),
System.Net.IPAddress.Parse("145.231.194.25"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 35,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("50.100.98.21"),
System.Net.IPAddress.Parse("28.192.16.91"),
System.Net.IPAddress.Parse("96.89.143.111"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("119.196.26.140"),
System.Net.IPAddress.Parse("211.167.104.185"),
System.Net.IPAddress.Parse("242.161.53.194"),
System.Net.IPAddress.Parse("225.111.36.245"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.129.159.203"),
System.Net.IPAddress.Parse("60.10.24.80"),
System.Net.IPAddress.Parse("0.4.126.143"),
System.Net.IPAddress.Parse("44.170.123.67"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("141.133.222.114"),
System.Net.IPAddress.Parse("103.176.229.60"),
System.Net.IPAddress.Parse("59.203.102.226"),
System.Net.IPAddress.Parse("176.160.38.161"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 37,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("84.126.123.139"),
System.Net.IPAddress.Parse("4.102.34.40"),
System.Net.IPAddress.Parse("7.44.38.20"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("208.103.24.87"),
System.Net.IPAddress.Parse("101.136.227.111"),
System.Net.IPAddress.Parse("110.69.192.217"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 38,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("183.56.77.31"),
System.Net.IPAddress.Parse("140.239.51.138"),
System.Net.IPAddress.Parse("111.98.209.67"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("66.250.58.195"),
System.Net.IPAddress.Parse("11.42.197.252"),
System.Net.IPAddress.Parse("198.184.68.187"),
System.Net.IPAddress.Parse("55.124.146.196"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("86.33.26.130"),
System.Net.IPAddress.Parse("173.136.167.156"),
System.Net.IPAddress.Parse("160.76.109.23"),
},
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 47,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("43.233.13.221"),
System.Net.IPAddress.Parse("83.30.37.109"),
System.Net.IPAddress.Parse("58.36.242.129"),
System.Net.IPAddress.Parse("176.168.94.194"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("212.110.121.38"),
System.Net.IPAddress.Parse("161.172.230.182"),
System.Net.IPAddress.Parse("227.56.215.129"),
System.Net.IPAddress.Parse("52.93.46.137"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 53,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("15.45.26.177"),
System.Net.IPAddress.Parse("36.57.65.29"),
System.Net.IPAddress.Parse("169.136.225.127"),
System.Net.IPAddress.Parse("10.175.154.0"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 24,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("103.247.142.202"),
System.Net.IPAddress.Parse("104.108.219.145"),
System.Net.IPAddress.Parse("251.64.73.172"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 62,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("100.104.205.79"),
System.Net.IPAddress.Parse("166.215.174.92"),
System.Net.IPAddress.Parse("81.193.34.11"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("149.50.55.43"),
System.Net.IPAddress.Parse("14.153.65.80"),
System.Net.IPAddress.Parse("71.84.131.243"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 66,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("121.141.215.197"),
System.Net.IPAddress.Parse("57.216.77.164"),
System.Net.IPAddress.Parse("15.148.194.250"),
System.Net.IPAddress.Parse("213.202.236.12"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("112.8.205.179"),
System.Net.IPAddress.Parse("206.119.233.152"),
System.Net.IPAddress.Parse("104.75.129.11"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("234.37.222.55"),
System.Net.IPAddress.Parse("172.58.236.253"),
System.Net.IPAddress.Parse("144.61.14.103"),
},
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 71,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("150.231.223.15"),
System.Net.IPAddress.Parse("107.201.211.251"),
System.Net.IPAddress.Parse("230.188.123.36"),
System.Net.IPAddress.Parse("221.225.32.142"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("144.48.53.155"),
System.Net.IPAddress.Parse("135.193.71.149"),
System.Net.IPAddress.Parse("132.234.103.60"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 73,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("144.111.170.206"),
System.Net.IPAddress.Parse("73.202.111.126"),
System.Net.IPAddress.Parse("250.75.126.174"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 34,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("51.0.229.51"),
System.Net.IPAddress.Parse("246.107.56.157"),
System.Net.IPAddress.Parse("242.138.89.228"),
System.Net.IPAddress.Parse("247.211.248.239"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("214.39.169.202"),
System.Net.IPAddress.Parse("146.132.85.75"),
System.Net.IPAddress.Parse("73.160.23.66"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("142.219.156.92"),
System.Net.IPAddress.Parse("2.163.165.113"),
System.Net.IPAddress.Parse("134.233.107.157"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 79,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("248.73.225.126"),
System.Net.IPAddress.Parse("185.217.238.113"),
System.Net.IPAddress.Parse("67.44.76.6"),
System.Net.IPAddress.Parse("54.248.89.70"),
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
System.Net.IPAddress.Parse("5.61.249.233"),
System.Net.IPAddress.Parse("182.162.50.171"),
System.Net.IPAddress.Parse("25.158.12.172"),
System.Net.IPAddress.Parse("183.125.189.4"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 43,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("96.247.111.200"),
System.Net.IPAddress.Parse("127.146.242.126"),
System.Net.IPAddress.Parse("84.122.252.148"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("70.19.146.200"),
System.Net.IPAddress.Parse("39.196.246.87"),
System.Net.IPAddress.Parse("250.152.199.168"),
System.Net.IPAddress.Parse("19.106.183.67"),
},
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 92,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("246.164.95.120"),
System.Net.IPAddress.Parse("54.142.201.235"),
System.Net.IPAddress.Parse("163.36.204.8"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 94,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("164.165.230.43"),
System.Net.IPAddress.Parse("179.113.227.185"),
System.Net.IPAddress.Parse("64.247.168.63"),
System.Net.IPAddress.Parse("84.247.33.174"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("227.96.47.170"),
System.Net.IPAddress.Parse("243.111.36.72"),
System.Net.IPAddress.Parse("254.197.30.112"),
System.Net.IPAddress.Parse("249.211.225.245"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 103,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("30.87.135.132"),
System.Net.IPAddress.Parse("6.141.213.193"),
System.Net.IPAddress.Parse("76.28.88.100"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("106.33.250.56"),
System.Net.IPAddress.Parse("66.134.87.138"),
System.Net.IPAddress.Parse("251.225.120.137"),
System.Net.IPAddress.Parse("138.23.30.187"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 57,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("227.62.204.198"),
System.Net.IPAddress.Parse("161.110.8.196"),
System.Net.IPAddress.Parse("253.202.114.230"),
System.Net.IPAddress.Parse("85.59.39.154"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("32.165.76.181"),
System.Net.IPAddress.Parse("42.167.210.226"),
System.Net.IPAddress.Parse("196.16.246.6"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("188.198.30.245"),
System.Net.IPAddress.Parse("102.85.184.174"),
System.Net.IPAddress.Parse("161.174.137.143"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 106,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("152.246.147.97"),
System.Net.IPAddress.Parse("44.74.142.26"),
System.Net.IPAddress.Parse("214.41.220.181"),
System.Net.IPAddress.Parse("100.48.244.178"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("58.248.196.20"),
System.Net.IPAddress.Parse("81.86.123.169"),
System.Net.IPAddress.Parse("164.3.207.161"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 115,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("184.166.225.248"),
System.Net.IPAddress.Parse("246.223.218.203"),
System.Net.IPAddress.Parse("61.177.232.7"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 60,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("218.162.177.75"),
System.Net.IPAddress.Parse("238.19.94.121"),
System.Net.IPAddress.Parse("194.161.223.231"),
System.Net.IPAddress.Parse("21.96.167.66"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("31.32.20.39"),
System.Net.IPAddress.Parse("183.85.17.43"),
System.Net.IPAddress.Parse("82.66.111.168"),
System.Net.IPAddress.Parse("46.40.254.92"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 119,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("122.240.246.182"),
System.Net.IPAddress.Parse("2.16.26.141"),
System.Net.IPAddress.Parse("83.195.98.227"),
System.Net.IPAddress.Parse("197.118.145.48"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 126,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("8.163.118.152"),
System.Net.IPAddress.Parse("117.252.199.198"),
System.Net.IPAddress.Parse("169.137.125.164"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 68,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("197.201.90.71"),
System.Net.IPAddress.Parse("142.181.29.171"),
System.Net.IPAddress.Parse("164.210.186.253"),
System.Net.IPAddress.Parse("126.82.162.152"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("13.113.186.173"),
System.Net.IPAddress.Parse("202.33.155.161"),
System.Net.IPAddress.Parse("18.170.134.68"),
System.Net.IPAddress.Parse("88.134.149.48"),
},
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 129,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("131.160.108.69"),
System.Net.IPAddress.Parse("8.248.97.174"),
System.Net.IPAddress.Parse("113.75.4.4"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("84.134.31.221"),
System.Net.IPAddress.Parse("199.158.168.192"),
System.Net.IPAddress.Parse("249.187.26.26"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 138,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("70.56.93.102"),
System.Net.IPAddress.Parse("171.203.97.52"),
System.Net.IPAddress.Parse("32.232.157.72"),
System.Net.IPAddress.Parse("42.63.71.180"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 70,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("52.128.174.12"),
System.Net.IPAddress.Parse("204.52.40.185"),
System.Net.IPAddress.Parse("180.51.129.22"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("204.98.185.137"),
System.Net.IPAddress.Parse("152.50.226.247"),
System.Net.IPAddress.Parse("185.82.234.3"),
System.Net.IPAddress.Parse("208.144.17.215"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("133.74.183.198"),
System.Net.IPAddress.Parse("11.72.232.1"),
System.Net.IPAddress.Parse("172.165.147.123"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 145,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("90.206.227.91"),
System.Net.IPAddress.Parse("162.132.114.67"),
System.Net.IPAddress.Parse("61.100.153.13"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 151,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("134.87.58.134"),
System.Net.IPAddress.Parse("90.84.123.246"),
System.Net.IPAddress.Parse("129.138.19.198"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 78,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("225.149.50.211"),
System.Net.IPAddress.Parse("164.251.27.216"),
System.Net.IPAddress.Parse("249.103.173.62"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 160,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("246.139.203.150"),
System.Net.IPAddress.Parse("147.201.10.157"),
System.Net.IPAddress.Parse("130.213.158.202"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("237.137.83.49"),
System.Net.IPAddress.Parse("247.112.51.95"),
System.Net.IPAddress.Parse("142.87.91.219"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 161,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("109.12.49.56"),
System.Net.IPAddress.Parse("32.145.183.244"),
System.Net.IPAddress.Parse("135.132.160.173"),
System.Net.IPAddress.Parse("235.169.126.18"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 85,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("226.64.94.205"),
System.Net.IPAddress.Parse("36.181.194.80"),
System.Net.IPAddress.Parse("44.64.112.39"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("23.24.133.26"),
System.Net.IPAddress.Parse("205.229.28.106"),
System.Net.IPAddress.Parse("56.94.127.76"),
System.Net.IPAddress.Parse("199.87.96.9"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 169,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("209.210.24.2"),
System.Net.IPAddress.Parse("49.197.184.164"),
System.Net.IPAddress.Parse("190.106.123.175"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 170,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.15.80.136"),
System.Net.IPAddress.Parse("36.202.159.126"),
System.Net.IPAddress.Parse("150.111.167.240"),
System.Net.IPAddress.Parse("238.174.186.41"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 92,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("238.79.15.184"),
System.Net.IPAddress.Parse("25.206.43.0"),
System.Net.IPAddress.Parse("232.71.254.217"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 173,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("37.238.214.129"),
System.Net.IPAddress.Parse("152.129.93.162"),
System.Net.IPAddress.Parse("169.170.235.33"),
System.Net.IPAddress.Parse("127.79.243.227"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 181,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("44.216.113.129"),
System.Net.IPAddress.Parse("223.94.145.2"),
System.Net.IPAddress.Parse("221.94.178.192"),
System.Net.IPAddress.Parse("39.160.195.151"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 95,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("172.38.49.63"),
System.Net.IPAddress.Parse("167.251.21.43"),
System.Net.IPAddress.Parse("247.121.94.231"),
System.Net.IPAddress.Parse("29.211.172.67"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 190,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("204.167.177.28"),
System.Net.IPAddress.Parse("86.52.214.150"),
System.Net.IPAddress.Parse("137.245.214.176"),
System.Net.IPAddress.Parse("149.188.74.79"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("95.169.37.10"),
System.Net.IPAddress.Parse("66.232.165.77"),
System.Net.IPAddress.Parse("205.200.103.133"),
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
System.Net.IPAddress.Parse("141.133.222.114"),
System.Net.IPAddress.Parse("103.176.229.60"),
System.Net.IPAddress.Parse("59.203.102.226"),
System.Net.IPAddress.Parse("176.160.38.161"),
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
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("208.103.24.87"),
System.Net.IPAddress.Parse("101.136.227.111"),
System.Net.IPAddress.Parse("110.69.192.217"),
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
System.Net.IPAddress.Parse("212.110.121.38"),
System.Net.IPAddress.Parse("161.172.230.182"),
System.Net.IPAddress.Parse("227.56.215.129"),
System.Net.IPAddress.Parse("52.93.46.137"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("149.50.55.43"),
System.Net.IPAddress.Parse("14.153.65.80"),
System.Net.IPAddress.Parse("71.84.131.243"),
}));
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 173;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 170;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 160;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[20],_testData[34], false);
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
                parametr1.Value = 173;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 173;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
                await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 103, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[26],_testData[34], false);
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
                await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 106, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
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
                 ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 160, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 87, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 66, query1, 19, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 161, query1, 151, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 37, query1, 87, query2))
                {
                    if(++resultIndex == 1)
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
                 ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 119, query1, 47, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 161, 87))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 62, 173))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
                ((IIPAddressMArrayinetMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 37);
                var models = await ((IIPAddressMArrayinetMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                IPAddressinetMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressMArrayinetMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressMArrayinetMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 73);
                var models =  ((IIPAddressMArrayinetMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

