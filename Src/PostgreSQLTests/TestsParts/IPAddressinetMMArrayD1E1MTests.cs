

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
    Id = 4,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("66.187.156.176"),
System.Net.IPAddress.Parse("207.239.172.30"),
System.Net.IPAddress.Parse("188.22.148.81"),
System.Net.IPAddress.Parse("42.2.73.166"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 13,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("92.32.44.127"),
System.Net.IPAddress.Parse("66.57.61.16"),
System.Net.IPAddress.Parse("148.48.67.114"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 2,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("133.38.140.125"),
System.Net.IPAddress.Parse("10.16.154.114"),
System.Net.IPAddress.Parse("237.247.123.98"),
System.Net.IPAddress.Parse("128.186.110.35"),
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
System.Net.IPAddress.Parse("107.161.99.254"),
System.Net.IPAddress.Parse("36.49.29.164"),
System.Net.IPAddress.Parse("143.203.197.59"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("202.28.162.59"),
System.Net.IPAddress.Parse("47.208.209.233"),
System.Net.IPAddress.Parse("96.53.172.209"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 19,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("250.89.207.146"),
System.Net.IPAddress.Parse("114.173.54.60"),
System.Net.IPAddress.Parse("29.195.166.148"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 11,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("12.133.109.219"),
System.Net.IPAddress.Parse("195.228.111.155"),
System.Net.IPAddress.Parse("48.139.184.43"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("53.153.102.145"),
System.Net.IPAddress.Parse("168.7.149.22"),
System.Net.IPAddress.Parse("26.148.215.172"),
System.Net.IPAddress.Parse("187.183.140.189"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 22,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("155.176.54.118"),
System.Net.IPAddress.Parse("75.20.224.253"),
System.Net.IPAddress.Parse("172.241.71.240"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 30,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("78.17.203.66"),
System.Net.IPAddress.Parse("86.46.225.54"),
System.Net.IPAddress.Parse("42.194.183.23"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 19,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("121.181.202.179"),
System.Net.IPAddress.Parse("112.45.238.157"),
System.Net.IPAddress.Parse("36.164.242.152"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("53.220.200.168"),
System.Net.IPAddress.Parse("6.244.14.196"),
System.Net.IPAddress.Parse("62.174.168.137"),
System.Net.IPAddress.Parse("37.154.80.84"),
},
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 34,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.240.136.248"),
System.Net.IPAddress.Parse("160.54.231.210"),
System.Net.IPAddress.Parse("121.46.2.2"),
System.Net.IPAddress.Parse("161.167.110.150"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 35,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("155.202.189.151"),
System.Net.IPAddress.Parse("86.204.194.216"),
System.Net.IPAddress.Parse("115.101.73.28"),
System.Net.IPAddress.Parse("66.143.127.4"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("203.235.92.151"),
System.Net.IPAddress.Parse("8.117.125.86"),
System.Net.IPAddress.Parse("108.30.133.186"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 43,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("210.34.226.90"),
System.Net.IPAddress.Parse("58.254.230.13"),
System.Net.IPAddress.Parse("12.221.170.205"),
System.Net.IPAddress.Parse("239.74.22.163"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 49,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("115.228.162.234"),
System.Net.IPAddress.Parse("53.153.96.222"),
System.Net.IPAddress.Parse("69.70.153.248"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 25,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("224.183.64.60"),
System.Net.IPAddress.Parse("140.119.188.109"),
System.Net.IPAddress.Parse("140.14.189.56"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 53,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("31.38.171.242"),
System.Net.IPAddress.Parse("117.23.50.59"),
System.Net.IPAddress.Parse("115.234.93.163"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("19.117.186.219"),
System.Net.IPAddress.Parse("39.75.222.222"),
System.Net.IPAddress.Parse("244.252.40.152"),
System.Net.IPAddress.Parse("55.212.230.15"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 59,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("6.230.164.117"),
System.Net.IPAddress.Parse("246.207.104.221"),
System.Net.IPAddress.Parse("85.65.194.209"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("177.37.246.70"),
System.Net.IPAddress.Parse("220.230.65.235"),
System.Net.IPAddress.Parse("19.114.116.54"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 68,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("112.195.161.250"),
System.Net.IPAddress.Parse("177.7.222.20"),
System.Net.IPAddress.Parse("233.76.8.201"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("245.225.209.8"),
System.Net.IPAddress.Parse("102.88.22.221"),
System.Net.IPAddress.Parse("1.53.112.227"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 74,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("174.177.117.77"),
System.Net.IPAddress.Parse("165.142.38.148"),
System.Net.IPAddress.Parse("146.229.212.178"),
System.Net.IPAddress.Parse("220.43.128.142"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 33,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("12.20.165.81"),
System.Net.IPAddress.Parse("240.245.101.239"),
System.Net.IPAddress.Parse("12.46.132.166"),
System.Net.IPAddress.Parse("24.210.46.102"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 83,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("36.81.111.187"),
System.Net.IPAddress.Parse("19.105.151.52"),
System.Net.IPAddress.Parse("235.130.11.3"),
System.Net.IPAddress.Parse("234.229.48.171"),
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
System.Net.IPAddress.Parse("232.46.53.66"),
System.Net.IPAddress.Parse("153.231.98.137"),
System.Net.IPAddress.Parse("12.69.181.17"),
System.Net.IPAddress.Parse("57.47.218.79"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 41,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("139.149.27.189"),
System.Net.IPAddress.Parse("150.121.128.16"),
System.Net.IPAddress.Parse("138.56.234.65"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 89,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("62.80.222.239"),
System.Net.IPAddress.Parse("125.150.111.0"),
System.Net.IPAddress.Parse("251.151.144.221"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 91,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("109.114.37.176"),
System.Net.IPAddress.Parse("108.98.251.170"),
System.Net.IPAddress.Parse("231.157.16.187"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 50,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("177.106.143.160"),
System.Net.IPAddress.Parse("185.148.195.243"),
System.Net.IPAddress.Parse("249.0.187.33"),
System.Net.IPAddress.Parse("96.79.102.247"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("36.181.247.233"),
System.Net.IPAddress.Parse("136.224.13.41"),
System.Net.IPAddress.Parse("29.143.188.68"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("173.70.195.171"),
System.Net.IPAddress.Parse("40.70.171.104"),
System.Net.IPAddress.Parse("92.61.198.73"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 100,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("226.172.116.115"),
System.Net.IPAddress.Parse("165.158.15.143"),
System.Net.IPAddress.Parse("82.186.17.209"),
System.Net.IPAddress.Parse("154.120.35.24"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("69.60.196.12"),
System.Net.IPAddress.Parse("99.51.137.56"),
System.Net.IPAddress.Parse("229.81.183.133"),
System.Net.IPAddress.Parse("135.83.207.97"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 104,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("43.68.56.220"),
System.Net.IPAddress.Parse("172.56.191.196"),
System.Net.IPAddress.Parse("78.10.168.35"),
System.Net.IPAddress.Parse("54.227.142.139"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("137.172.0.51"),
System.Net.IPAddress.Parse("141.16.27.239"),
System.Net.IPAddress.Parse("107.138.107.128"),
System.Net.IPAddress.Parse("250.93.76.222"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("40.13.251.45"),
System.Net.IPAddress.Parse("60.114.127.186"),
System.Net.IPAddress.Parse("215.138.174.66"),
System.Net.IPAddress.Parse("247.233.194.217"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("22.124.212.235"),
System.Net.IPAddress.Parse("249.83.205.208"),
System.Net.IPAddress.Parse("163.121.76.243"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 112,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("249.85.87.205"),
System.Net.IPAddress.Parse("27.126.22.124"),
System.Net.IPAddress.Parse("40.5.119.242"),
System.Net.IPAddress.Parse("44.73.8.14"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 114,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("158.250.197.88"),
System.Net.IPAddress.Parse("209.252.11.101"),
System.Net.IPAddress.Parse("153.220.72.20"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("32.201.76.13"),
System.Net.IPAddress.Parse("131.75.63.233"),
System.Net.IPAddress.Parse("58.246.82.134"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("228.143.102.117"),
System.Net.IPAddress.Parse("113.40.221.184"),
System.Net.IPAddress.Parse("248.98.174.142"),
System.Net.IPAddress.Parse("64.104.248.151"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 116,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("140.98.188.113"),
System.Net.IPAddress.Parse("89.225.184.39"),
System.Net.IPAddress.Parse("28.204.63.236"),
System.Net.IPAddress.Parse("183.153.172.82"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 120,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("178.14.178.36"),
System.Net.IPAddress.Parse("162.242.161.94"),
System.Net.IPAddress.Parse("101.246.109.207"),
System.Net.IPAddress.Parse("170.21.227.154"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 65,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("142.211.236.179"),
System.Net.IPAddress.Parse("146.127.79.94"),
System.Net.IPAddress.Parse("0.77.67.44"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("61.102.224.235"),
System.Net.IPAddress.Parse("37.23.185.19"),
System.Net.IPAddress.Parse("76.32.144.27"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("152.122.109.202"),
System.Net.IPAddress.Parse("120.50.53.33"),
System.Net.IPAddress.Parse("180.155.51.240"),
System.Net.IPAddress.Parse("115.127.34.160"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 128,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("184.224.82.54"),
System.Net.IPAddress.Parse("253.46.175.116"),
System.Net.IPAddress.Parse("168.184.89.247"),
System.Net.IPAddress.Parse("186.101.221.2"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("37.56.133.156"),
System.Net.IPAddress.Parse("85.41.188.226"),
System.Net.IPAddress.Parse("56.21.89.209"),
System.Net.IPAddress.Parse("103.36.185.82"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 131,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("149.96.143.27"),
System.Net.IPAddress.Parse("191.101.247.91"),
System.Net.IPAddress.Parse("19.109.119.123"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 70,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("102.139.10.245"),
System.Net.IPAddress.Parse("219.173.200.141"),
System.Net.IPAddress.Parse("220.4.234.68"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("223.137.158.24"),
System.Net.IPAddress.Parse("220.150.98.216"),
System.Net.IPAddress.Parse("19.210.127.172"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("189.138.89.2"),
System.Net.IPAddress.Parse("162.9.134.18"),
System.Net.IPAddress.Parse("252.246.222.24"),
System.Net.IPAddress.Parse("55.117.120.168"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 132,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("76.80.116.197"),
System.Net.IPAddress.Parse("200.242.25.102"),
System.Net.IPAddress.Parse("10.78.172.95"),
System.Net.IPAddress.Parse("197.108.234.55"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.14.195.27"),
System.Net.IPAddress.Parse("244.96.245.32"),
System.Net.IPAddress.Parse("42.133.246.46"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 141,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("142.179.50.147"),
System.Net.IPAddress.Parse("252.160.38.238"),
System.Net.IPAddress.Parse("233.101.229.189"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("146.252.188.115"),
System.Net.IPAddress.Parse("196.92.162.195"),
System.Net.IPAddress.Parse("170.43.248.193"),
System.Net.IPAddress.Parse("106.148.35.43"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("40.87.229.145"),
System.Net.IPAddress.Parse("17.62.185.214"),
System.Net.IPAddress.Parse("191.94.36.35"),
System.Net.IPAddress.Parse("210.32.102.150"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 150,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("116.80.195.197"),
System.Net.IPAddress.Parse("41.83.144.11"),
System.Net.IPAddress.Parse("199.1.196.17"),
System.Net.IPAddress.Parse("208.73.203.19"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 153,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("212.123.42.254"),
System.Net.IPAddress.Parse("99.190.30.43"),
System.Net.IPAddress.Parse("140.197.222.174"),
System.Net.IPAddress.Parse("73.198.250.229"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 75,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("9.161.254.13"),
System.Net.IPAddress.Parse("86.86.9.25"),
System.Net.IPAddress.Parse("28.162.89.130"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("31.138.145.198"),
System.Net.IPAddress.Parse("38.202.147.231"),
System.Net.IPAddress.Parse("66.137.175.164"),
System.Net.IPAddress.Parse("180.122.216.203"),
},
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 161,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("108.163.190.140"),
System.Net.IPAddress.Parse("254.135.213.109"),
System.Net.IPAddress.Parse("148.147.237.118"),
System.Net.IPAddress.Parse("55.139.221.81"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 167,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("90.82.179.254"),
System.Net.IPAddress.Parse("33.110.52.180"),
System.Net.IPAddress.Parse("108.34.51.155"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("192.13.87.74"),
System.Net.IPAddress.Parse("88.84.183.72"),
System.Net.IPAddress.Parse("254.18.83.58"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("163.209.74.18"),
System.Net.IPAddress.Parse("212.180.179.254"),
System.Net.IPAddress.Parse("17.136.186.149"),
System.Net.IPAddress.Parse("30.164.44.21"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 173,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("27.139.119.251"),
System.Net.IPAddress.Parse("135.121.188.119"),
System.Net.IPAddress.Parse("181.90.221.251"),
System.Net.IPAddress.Parse("162.17.78.225"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("249.11.78.46"),
System.Net.IPAddress.Parse("56.126.123.68"),
System.Net.IPAddress.Parse("115.57.98.16"),
System.Net.IPAddress.Parse("107.71.145.94"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 174,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("212.120.251.103"),
System.Net.IPAddress.Parse("186.225.63.122"),
System.Net.IPAddress.Parse("73.126.188.134"),
System.Net.IPAddress.Parse("134.235.177.187"),
},
    ModelInner = new IPAddressinetMMArrayD1E1MI
{
    Id = 87,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("167.14.170.108"),
System.Net.IPAddress.Parse("92.14.111.173"),
System.Net.IPAddress.Parse("169.4.99.2"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("14.247.141.59"),
System.Net.IPAddress.Parse("237.58.222.89"),
System.Net.IPAddress.Parse("21.45.27.235"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("119.251.248.236"),
System.Net.IPAddress.Parse("72.101.94.209"),
System.Net.IPAddress.Parse("23.33.105.209"),
System.Net.IPAddress.Parse("40.124.118.223"),
},
},
            new IPAddressinetMMArrayD1E1M
{
    Id = 179,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("200.65.116.85"),
System.Net.IPAddress.Parse("73.4.86.122"),
System.Net.IPAddress.Parse("66.64.147.116"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("19.117.186.219"),
System.Net.IPAddress.Parse("39.75.222.222"),
System.Net.IPAddress.Parse("244.252.40.152"),
System.Net.IPAddress.Parse("55.212.230.15"),
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
                parametr2.Value = 167;
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
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
                parametr1.Value = 131;
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[17],_testData[34], false);
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
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 89, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
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
                await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 112, query1, 173, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
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
                 ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 49, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[14],_testData[34], false);
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
                 ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 17, query1, 83, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 68, query1, 13, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
                await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 68, query1, 161, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 173, query1, 34, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
                 ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 120, query1, 112, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatIPAddressinetMMArrayD1E1M.AssertModel(secondItems2[13],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 49, 141))
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
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 83, 112))
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        IPAddressinetMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        IPAddressinetMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
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
                ((IIPAddressMArrayinetMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 131);
                var models = await ((IIPAddressMArrayinetMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressMArrayinetMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressMArrayinetMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 34);
                var models =  ((IIPAddressMArrayinetMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

