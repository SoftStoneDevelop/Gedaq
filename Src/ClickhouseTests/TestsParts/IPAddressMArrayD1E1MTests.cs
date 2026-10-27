

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
    Id = 1,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("228.149.175.161"),
System.Net.IPAddress.Parse("19.221.207.101"),
System.Net.IPAddress.Parse("106.97.70.186"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 7,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("166.111.22.239"),
System.Net.IPAddress.Parse("161.13.59.202"),
System.Net.IPAddress.Parse("138.63.126.181"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("226.103.201.6"),
System.Net.IPAddress.Parse("194.117.146.170"),
System.Net.IPAddress.Parse("252.239.155.32"),
System.Net.IPAddress.Parse("219.248.201.143"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("216.233.102.1"),
System.Net.IPAddress.Parse("55.22.223.31"),
System.Net.IPAddress.Parse("54.89.236.182"),
System.Net.IPAddress.Parse("198.45.170.166"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 4,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("14.16.115.83"),
System.Net.IPAddress.Parse("7.146.40.75"),
System.Net.IPAddress.Parse("205.175.12.252"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 13,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("143.110.157.191"),
System.Net.IPAddress.Parse("20.252.80.175"),
System.Net.IPAddress.Parse("125.59.184.171"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.165.62.169"),
System.Net.IPAddress.Parse("54.109.202.15"),
System.Net.IPAddress.Parse("3.243.253.243"),
System.Net.IPAddress.Parse("70.193.20.101"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("183.41.209.148"),
System.Net.IPAddress.Parse("179.157.181.113"),
System.Net.IPAddress.Parse("146.74.198.159"),
System.Net.IPAddress.Parse("170.183.70.128"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 5,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("189.89.61.179"),
System.Net.IPAddress.Parse("186.122.62.125"),
System.Net.IPAddress.Parse("95.130.163.242"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 16,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("207.17.226.214"),
System.Net.IPAddress.Parse("169.144.169.205"),
System.Net.IPAddress.Parse("153.136.42.171"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("4.131.18.194"),
System.Net.IPAddress.Parse("55.134.214.214"),
System.Net.IPAddress.Parse("252.202.7.168"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 7,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("227.70.9.110"),
System.Net.IPAddress.Parse("207.201.1.154"),
System.Net.IPAddress.Parse("169.240.76.107"),
System.Net.IPAddress.Parse("99.115.124.142"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("240.39.102.27"),
System.Net.IPAddress.Parse("122.123.4.150"),
System.Net.IPAddress.Parse("43.82.202.83"),
System.Net.IPAddress.Parse("244.30.81.66"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 9,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("190.34.119.30"),
System.Net.IPAddress.Parse("106.121.191.186"),
System.Net.IPAddress.Parse("139.79.180.13"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 31,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("232.0.85.246"),
System.Net.IPAddress.Parse("4.177.33.149"),
System.Net.IPAddress.Parse("254.76.10.15"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("27.120.158.66"),
System.Net.IPAddress.Parse("254.9.61.122"),
System.Net.IPAddress.Parse("12.69.73.13"),
System.Net.IPAddress.Parse("0.90.51.247"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("24.212.169.204"),
System.Net.IPAddress.Parse("249.129.179.18"),
System.Net.IPAddress.Parse("103.244.192.35"),
System.Net.IPAddress.Parse("125.92.7.3"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 10,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("120.178.220.176"),
System.Net.IPAddress.Parse("52.128.65.29"),
System.Net.IPAddress.Parse("176.233.65.254"),
System.Net.IPAddress.Parse("131.105.219.186"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("173.66.134.58"),
System.Net.IPAddress.Parse("98.95.78.127"),
System.Net.IPAddress.Parse("123.239.38.60"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("148.138.236.187"),
System.Net.IPAddress.Parse("8.155.10.153"),
System.Net.IPAddress.Parse("4.239.62.189"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("204.2.111.40"),
System.Net.IPAddress.Parse("185.35.83.11"),
System.Net.IPAddress.Parse("229.96.230.102"),
System.Net.IPAddress.Parse("71.247.208.116"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 19,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("166.27.187.234"),
System.Net.IPAddress.Parse("113.242.213.117"),
System.Net.IPAddress.Parse("140.66.111.82"),
System.Net.IPAddress.Parse("157.44.122.193"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 38,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("175.42.106.44"),
System.Net.IPAddress.Parse("226.175.123.64"),
System.Net.IPAddress.Parse("66.176.134.5"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("33.126.68.154"),
System.Net.IPAddress.Parse("195.62.179.138"),
System.Net.IPAddress.Parse("2.175.130.35"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 25,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("85.167.201.219"),
System.Net.IPAddress.Parse("223.133.203.205"),
System.Net.IPAddress.Parse("94.236.203.113"),
System.Net.IPAddress.Parse("67.73.248.40"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 40,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("3.3.133.209"),
System.Net.IPAddress.Parse("79.4.202.55"),
System.Net.IPAddress.Parse("119.115.185.31"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("179.176.39.227"),
System.Net.IPAddress.Parse("11.195.219.76"),
System.Net.IPAddress.Parse("208.238.106.63"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 33,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("194.122.79.142"),
System.Net.IPAddress.Parse("181.113.89.50"),
System.Net.IPAddress.Parse("171.143.76.78"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.56.143.39"),
System.Net.IPAddress.Parse("80.7.195.69"),
System.Net.IPAddress.Parse("250.254.85.116"),
System.Net.IPAddress.Parse("13.243.183.175"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("93.164.253.124"),
System.Net.IPAddress.Parse("42.7.121.11"),
System.Net.IPAddress.Parse("31.82.118.69"),
System.Net.IPAddress.Parse("92.158.196.196"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 34,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("181.230.138.138"),
System.Net.IPAddress.Parse("254.101.83.187"),
System.Net.IPAddress.Parse("41.173.19.60"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("136.37.224.64"),
System.Net.IPAddress.Parse("52.106.206.43"),
System.Net.IPAddress.Parse("22.87.143.52"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("78.31.242.123"),
System.Net.IPAddress.Parse("172.15.29.182"),
System.Net.IPAddress.Parse("55.119.48.197"),
System.Net.IPAddress.Parse("28.179.230.251"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 40,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("164.195.209.115"),
System.Net.IPAddress.Parse("52.124.245.31"),
System.Net.IPAddress.Parse("254.213.26.51"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("45.23.182.61"),
System.Net.IPAddress.Parse("11.209.215.198"),
System.Net.IPAddress.Parse("119.116.20.197"),
System.Net.IPAddress.Parse("159.249.4.151"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 48,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("78.199.16.210"),
System.Net.IPAddress.Parse("192.220.144.54"),
System.Net.IPAddress.Parse("25.107.153.187"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 67,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("75.147.65.84"),
System.Net.IPAddress.Parse("217.24.131.112"),
System.Net.IPAddress.Parse("23.160.148.233"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 54,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("10.82.35.212"),
System.Net.IPAddress.Parse("125.211.109.178"),
System.Net.IPAddress.Parse("153.8.153.80"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.99.42.141"),
System.Net.IPAddress.Parse("209.140.208.106"),
System.Net.IPAddress.Parse("219.137.215.98"),
System.Net.IPAddress.Parse("246.59.199.237"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("63.147.215.50"),
System.Net.IPAddress.Parse("188.19.122.96"),
System.Net.IPAddress.Parse("143.27.33.198"),
System.Net.IPAddress.Parse("112.9.121.88"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 56,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("110.213.18.80"),
System.Net.IPAddress.Parse("27.178.202.28"),
System.Net.IPAddress.Parse("20.235.184.22"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 79,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("100.42.3.232"),
System.Net.IPAddress.Parse("205.170.163.41"),
System.Net.IPAddress.Parse("173.235.245.43"),
System.Net.IPAddress.Parse("239.89.59.153"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("46.145.196.80"),
System.Net.IPAddress.Parse("66.205.47.251"),
System.Net.IPAddress.Parse("121.56.72.7"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.231.229.10"),
System.Net.IPAddress.Parse("0.212.233.217"),
System.Net.IPAddress.Parse("244.87.127.153"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 57,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("168.129.175.216"),
System.Net.IPAddress.Parse("81.240.203.212"),
System.Net.IPAddress.Parse("97.114.165.167"),
System.Net.IPAddress.Parse("167.75.91.233"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 81,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("184.22.110.34"),
System.Net.IPAddress.Parse("192.3.102.233"),
System.Net.IPAddress.Parse("7.147.0.178"),
System.Net.IPAddress.Parse("45.52.171.235"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 66,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("126.33.85.1"),
System.Net.IPAddress.Parse("202.106.15.114"),
System.Net.IPAddress.Parse("50.129.243.75"),
System.Net.IPAddress.Parse("110.114.3.119"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 90,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("228.55.53.18"),
System.Net.IPAddress.Parse("181.87.15.101"),
System.Net.IPAddress.Parse("182.76.211.117"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("50.169.185.183"),
System.Net.IPAddress.Parse("188.240.149.14"),
System.Net.IPAddress.Parse("238.35.41.160"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("245.200.175.217"),
System.Net.IPAddress.Parse("231.62.201.73"),
System.Net.IPAddress.Parse("132.167.5.73"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 68,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("168.61.208.249"),
System.Net.IPAddress.Parse("159.175.143.251"),
System.Net.IPAddress.Parse("245.191.164.25"),
System.Net.IPAddress.Parse("100.80.91.149"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 96,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("133.170.1.33"),
System.Net.IPAddress.Parse("140.121.99.74"),
System.Net.IPAddress.Parse("168.138.115.37"),
System.Net.IPAddress.Parse("134.40.22.128"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("217.238.47.112"),
System.Net.IPAddress.Parse("205.24.51.37"),
System.Net.IPAddress.Parse("179.34.134.238"),
System.Net.IPAddress.Parse("79.235.149.184"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 75,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("33.151.128.20"),
System.Net.IPAddress.Parse("11.197.244.225"),
System.Net.IPAddress.Parse("79.93.240.60"),
System.Net.IPAddress.Parse("72.43.177.221"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 100,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("170.61.115.111"),
System.Net.IPAddress.Parse("67.151.82.97"),
System.Net.IPAddress.Parse("244.137.234.189"),
System.Net.IPAddress.Parse("67.22.176.245"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 77,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("173.247.143.105"),
System.Net.IPAddress.Parse("184.201.17.238"),
System.Net.IPAddress.Parse("100.68.223.80"),
System.Net.IPAddress.Parse("145.44.96.173"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 109,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.124.104.115"),
System.Net.IPAddress.Parse("213.23.180.135"),
System.Net.IPAddress.Parse("228.4.167.179"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("232.194.117.230"),
System.Net.IPAddress.Parse("137.200.224.63"),
System.Net.IPAddress.Parse("105.120.241.1"),
System.Net.IPAddress.Parse("61.100.124.226"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("18.78.174.14"),
System.Net.IPAddress.Parse("74.223.194.24"),
System.Net.IPAddress.Parse("26.153.233.75"),
System.Net.IPAddress.Parse("248.65.209.56"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("106.112.86.154"),
System.Net.IPAddress.Parse("43.3.190.210"),
System.Net.IPAddress.Parse("113.20.151.138"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 114,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("127.210.86.161"),
System.Net.IPAddress.Parse("70.171.95.13"),
System.Net.IPAddress.Parse("185.211.106.164"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.167.221.251"),
System.Net.IPAddress.Parse("96.181.207.26"),
System.Net.IPAddress.Parse("171.218.69.88"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 88,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("140.245.106.105"),
System.Net.IPAddress.Parse("162.80.58.149"),
System.Net.IPAddress.Parse("136.148.203.171"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 117,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("145.64.242.224"),
System.Net.IPAddress.Parse("100.145.217.133"),
System.Net.IPAddress.Parse("126.31.157.231"),
System.Net.IPAddress.Parse("219.205.219.204"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("99.35.202.157"),
System.Net.IPAddress.Parse("88.81.45.144"),
System.Net.IPAddress.Parse("16.85.103.97"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 95,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("124.197.238.43"),
System.Net.IPAddress.Parse("12.211.24.126"),
System.Net.IPAddress.Parse("26.234.183.113"),
System.Net.IPAddress.Parse("50.225.234.150"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 125,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("228.240.151.214"),
System.Net.IPAddress.Parse("37.203.63.233"),
System.Net.IPAddress.Parse("112.144.76.234"),
System.Net.IPAddress.Parse("144.71.197.140"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("245.54.123.211"),
System.Net.IPAddress.Parse("136.57.150.31"),
System.Net.IPAddress.Parse("165.109.54.116"),
System.Net.IPAddress.Parse("110.232.96.133"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("243.208.252.193"),
System.Net.IPAddress.Parse("132.70.62.92"),
System.Net.IPAddress.Parse("43.33.185.27"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 98,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("61.110.78.65"),
System.Net.IPAddress.Parse("212.242.104.233"),
System.Net.IPAddress.Parse("207.13.210.3"),
System.Net.IPAddress.Parse("99.73.60.217"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 127,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("177.221.97.149"),
System.Net.IPAddress.Parse("4.43.95.101"),
System.Net.IPAddress.Parse("41.163.103.177"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("63.162.200.112"),
System.Net.IPAddress.Parse("205.83.153.102"),
System.Net.IPAddress.Parse("152.156.93.119"),
System.Net.IPAddress.Parse("67.71.112.57"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("233.194.150.166"),
System.Net.IPAddress.Parse("63.129.156.222"),
System.Net.IPAddress.Parse("138.204.100.152"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 102,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("216.41.180.176"),
System.Net.IPAddress.Parse("249.26.247.254"),
System.Net.IPAddress.Parse("86.188.142.242"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 135,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("170.195.24.230"),
System.Net.IPAddress.Parse("115.32.86.137"),
System.Net.IPAddress.Parse("209.194.216.133"),
System.Net.IPAddress.Parse("54.25.143.248"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("171.178.222.239"),
System.Net.IPAddress.Parse("217.225.148.227"),
System.Net.IPAddress.Parse("128.165.194.144"),
System.Net.IPAddress.Parse("160.118.28.247"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 106,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("231.28.57.108"),
System.Net.IPAddress.Parse("39.7.205.203"),
System.Net.IPAddress.Parse("187.58.50.112"),
System.Net.IPAddress.Parse("85.179.197.146"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 144,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("185.41.142.66"),
System.Net.IPAddress.Parse("127.39.166.146"),
System.Net.IPAddress.Parse("97.228.138.160"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("60.243.16.211"),
System.Net.IPAddress.Parse("22.203.7.160"),
System.Net.IPAddress.Parse("80.55.252.80"),
System.Net.IPAddress.Parse("176.176.75.178"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("198.28.135.135"),
System.Net.IPAddress.Parse("20.118.214.95"),
System.Net.IPAddress.Parse("1.166.6.182"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 107,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("221.88.82.61"),
System.Net.IPAddress.Parse("221.118.245.15"),
System.Net.IPAddress.Parse("31.245.239.122"),
System.Net.IPAddress.Parse("140.151.197.114"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 148,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("172.104.170.187"),
System.Net.IPAddress.Parse("101.159.152.85"),
System.Net.IPAddress.Parse("0.50.135.117"),
System.Net.IPAddress.Parse("179.56.238.209"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("184.247.12.2"),
System.Net.IPAddress.Parse("61.58.189.109"),
System.Net.IPAddress.Parse("207.251.60.77"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.70.210.213"),
System.Net.IPAddress.Parse("31.132.82.49"),
System.Net.IPAddress.Parse("78.184.225.236"),
System.Net.IPAddress.Parse("163.5.89.144"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 112,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("153.185.254.45"),
System.Net.IPAddress.Parse("222.103.220.221"),
System.Net.IPAddress.Parse("116.147.106.254"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 155,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("119.254.190.82"),
System.Net.IPAddress.Parse("56.141.148.84"),
System.Net.IPAddress.Parse("184.218.27.111"),
System.Net.IPAddress.Parse("92.79.199.141"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("168.63.237.51"),
System.Net.IPAddress.Parse("217.96.63.231"),
System.Net.IPAddress.Parse("110.197.188.102"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 116,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("253.116.122.209"),
System.Net.IPAddress.Parse("239.36.89.140"),
System.Net.IPAddress.Parse("14.18.199.100"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 164,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("99.51.95.87"),
System.Net.IPAddress.Parse("192.185.145.235"),
System.Net.IPAddress.Parse("9.216.201.86"),
System.Net.IPAddress.Parse("167.114.224.174"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 121,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("49.212.133.182"),
System.Net.IPAddress.Parse("220.43.102.113"),
System.Net.IPAddress.Parse("190.63.99.248"),
System.Net.IPAddress.Parse("113.73.217.160"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 170,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("174.24.89.243"),
System.Net.IPAddress.Parse("60.164.208.33"),
System.Net.IPAddress.Parse("83.193.15.43"),
System.Net.IPAddress.Parse("45.39.6.143"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("169.52.39.214"),
System.Net.IPAddress.Parse("6.12.206.120"),
System.Net.IPAddress.Parse("116.69.169.9"),
System.Net.IPAddress.Parse("187.51.30.253"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("235.45.77.133"),
System.Net.IPAddress.Parse("143.123.15.27"),
System.Net.IPAddress.Parse("93.75.168.101"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 126,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("32.42.148.72"),
System.Net.IPAddress.Parse("163.250.223.113"),
System.Net.IPAddress.Parse("74.219.167.35"),
System.Net.IPAddress.Parse("132.171.117.164"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 176,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("53.148.140.44"),
System.Net.IPAddress.Parse("38.194.109.80"),
System.Net.IPAddress.Parse("27.186.64.63"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 134,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("198.163.47.71"),
System.Net.IPAddress.Parse("5.177.96.93"),
System.Net.IPAddress.Parse("162.79.198.214"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 183,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("90.144.176.124"),
System.Net.IPAddress.Parse("1.52.172.13"),
System.Net.IPAddress.Parse("213.163.106.237"),
System.Net.IPAddress.Parse("64.86.174.12"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("247.13.236.144"),
System.Net.IPAddress.Parse("64.14.194.196"),
System.Net.IPAddress.Parse("76.157.242.138"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 139,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("130.124.250.132"),
System.Net.IPAddress.Parse("222.142.228.239"),
System.Net.IPAddress.Parse("120.83.154.51"),
System.Net.IPAddress.Parse("13.20.59.164"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 185,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("126.91.26.124"),
System.Net.IPAddress.Parse("205.183.167.178"),
System.Net.IPAddress.Parse("88.111.38.84"),
System.Net.IPAddress.Parse("58.82.210.176"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("147.163.89.242"),
System.Net.IPAddress.Parse("145.65.63.157"),
System.Net.IPAddress.Parse("44.87.68.92"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 140,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("223.123.230.244"),
System.Net.IPAddress.Parse("232.1.73.14"),
System.Net.IPAddress.Parse("56.90.2.135"),
System.Net.IPAddress.Parse("80.78.111.43"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 192,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("135.39.67.23"),
System.Net.IPAddress.Parse("231.133.212.134"),
System.Net.IPAddress.Parse("44.23.226.98"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("173.247.187.71"),
System.Net.IPAddress.Parse("252.111.220.1"),
System.Net.IPAddress.Parse("51.8.190.69"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 141,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("47.238.91.27"),
System.Net.IPAddress.Parse("59.197.13.228"),
System.Net.IPAddress.Parse("111.60.9.18"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 198,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("247.113.47.203"),
System.Net.IPAddress.Parse("19.89.103.207"),
System.Net.IPAddress.Parse("214.88.40.152"),
System.Net.IPAddress.Parse("167.89.225.131"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("121.239.83.235"),
System.Net.IPAddress.Parse("99.8.134.252"),
System.Net.IPAddress.Parse("202.112.77.21"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 147,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("219.229.137.76"),
System.Net.IPAddress.Parse("142.92.65.79"),
System.Net.IPAddress.Parse("245.15.86.56"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 202,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("163.223.217.196"),
System.Net.IPAddress.Parse("140.42.82.242"),
System.Net.IPAddress.Parse("89.68.129.185"),
System.Net.IPAddress.Parse("49.157.30.102"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("27.9.159.99"),
System.Net.IPAddress.Parse("76.236.193.91"),
System.Net.IPAddress.Parse("189.121.185.69"),
System.Net.IPAddress.Parse("157.208.9.251"),
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

