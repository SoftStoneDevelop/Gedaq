

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
    internal partial interface IIPAddressMArrayMArrayD2
    {
    }
    
    internal partial class IPAddressMArrayMArrayD2 : IIPAddressMArrayMArrayD2
    {


#region TestData

        private readonly IPAddressMArrayD2E1M[] _testData = new IPAddressMArrayD2E1M[]
        {
            new IPAddressMArrayD2E1M
{
    Id = 1,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("120.188.160.7"),
System.Net.IPAddress.Parse("160.232.240.154"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("127.35.240.154"),
System.Net.IPAddress.Parse("97.30.24.132"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("170.242.126.172"),
System.Net.IPAddress.Parse("149.6.168.101"), } },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 3,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("128.151.69.233"),
System.Net.IPAddress.Parse("129.227.69.28"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 11,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("16.145.230.15"),
System.Net.IPAddress.Parse("84.193.54.80"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("93.32.82.39"),
System.Net.IPAddress.Parse("68.136.204.115"), } },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 8,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("190.110.202.167"),
System.Net.IPAddress.Parse("110.50.41.176"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 17,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("46.218.46.87"),
System.Net.IPAddress.Parse("250.80.129.182"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("68.81.215.249"),
System.Net.IPAddress.Parse("2.91.57.134"), } },
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("174.241.227.129"),
System.Net.IPAddress.Parse("200.241.137.174"), } },
},
            new IPAddressMArrayD2E1M
{
    Id = 9,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("123.194.212.143"),
System.Net.IPAddress.Parse("172.241.186.169"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("101.217.208.26"),
System.Net.IPAddress.Parse("38.186.90.200"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("130.141.109.8"),
System.Net.IPAddress.Parse("240.114.211.94"), } },
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("181.177.96.125"),
System.Net.IPAddress.Parse("97.42.170.229"), } },
},
            new IPAddressMArrayD2E1M
{
    Id = 15,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("118.19.237.137"),
System.Net.IPAddress.Parse("125.217.127.249"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 27,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("230.243.70.161"),
System.Net.IPAddress.Parse("170.20.58.227"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("227.109.186.78"),
System.Net.IPAddress.Parse("10.92.41.47"), } },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 17,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("249.49.43.12"),
System.Net.IPAddress.Parse("145.166.50.93"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 34,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("150.6.147.243"),
System.Net.IPAddress.Parse("31.181.137.88"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("69.174.155.113"),
System.Net.IPAddress.Parse("146.89.2.191"), } },
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("187.246.161.168"),
System.Net.IPAddress.Parse("149.38.168.205"), } },
},
            new IPAddressMArrayD2E1M
{
    Id = 19,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("83.156.201.85"),
System.Net.IPAddress.Parse("15.216.249.101"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 35,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("164.100.86.177"),
System.Net.IPAddress.Parse("114.27.108.54"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("121.116.155.87"),
System.Net.IPAddress.Parse("209.75.77.4"), } },
},
            new IPAddressMArrayD2E1M
{
    Id = 23,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("70.5.94.231"),
System.Net.IPAddress.Parse("10.27.252.243"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 44,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("133.128.152.218"),
System.Net.IPAddress.Parse("222.16.91.189"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("63.207.134.33"),
System.Net.IPAddress.Parse("124.186.60.239"), } },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 27,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("127.146.33.133"),
System.Net.IPAddress.Parse("34.238.190.62"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 53,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("68.127.20.79"),
System.Net.IPAddress.Parse("248.172.254.168"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("87.68.91.155"),
System.Net.IPAddress.Parse("251.108.234.102"), } },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 30,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("52.140.196.226"),
System.Net.IPAddress.Parse("43.114.173.211"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 54,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("97.76.253.193"),
System.Net.IPAddress.Parse("181.171.93.153"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 36,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("193.83.76.173"),
System.Net.IPAddress.Parse("196.46.24.175"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 61,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("24.2.25.99"),
System.Net.IPAddress.Parse("114.133.60.216"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("87.190.81.29"),
System.Net.IPAddress.Parse("3.127.242.246"), } },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 41,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("183.136.84.134"),
System.Net.IPAddress.Parse("92.11.243.94"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 68,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("245.128.97.97"),
System.Net.IPAddress.Parse("44.177.152.113"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("208.159.30.73"),
System.Net.IPAddress.Parse("232.31.194.63"), } },
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("163.97.45.75"),
System.Net.IPAddress.Parse("166.126.116.54"), } },
},
            new IPAddressMArrayD2E1M
{
    Id = 47,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("48.115.92.62"),
System.Net.IPAddress.Parse("197.121.180.159"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 74,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("241.250.250.142"),
System.Net.IPAddress.Parse("179.38.107.192"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("231.145.125.82"),
System.Net.IPAddress.Parse("116.241.92.226"), } },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 55,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("211.146.211.211"),
System.Net.IPAddress.Parse("188.100.40.232"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 79,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("32.190.156.33"),
System.Net.IPAddress.Parse("136.250.171.133"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("94.63.137.195"),
System.Net.IPAddress.Parse("210.240.9.177"), } },
},
            new IPAddressMArrayD2E1M
{
    Id = 62,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("145.203.213.224"),
System.Net.IPAddress.Parse("114.130.159.147"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 80,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("118.40.56.194"),
System.Net.IPAddress.Parse("119.122.80.43"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("191.197.57.24"),
System.Net.IPAddress.Parse("126.66.92.147"), } },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 63,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("123.153.235.211"),
System.Net.IPAddress.Parse("246.39.171.176"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 87,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("57.83.14.4"),
System.Net.IPAddress.Parse("138.42.60.97"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 72,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("45.219.24.26"),
System.Net.IPAddress.Parse("167.122.224.23"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 96,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("164.208.147.50"),
System.Net.IPAddress.Parse("224.8.60.139"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("96.145.73.115"),
System.Net.IPAddress.Parse("85.25.210.161"), } },
},
            new IPAddressMArrayD2E1M
{
    Id = 77,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("173.207.160.65"),
System.Net.IPAddress.Parse("178.115.223.166"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 103,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("129.191.108.200"),
System.Net.IPAddress.Parse("137.33.136.247"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("51.240.38.191"),
System.Net.IPAddress.Parse("40.147.105.12"), } },
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("48.124.233.208"),
System.Net.IPAddress.Parse("58.83.223.246"), } },
},
            new IPAddressMArrayD2E1M
{
    Id = 84,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("192.217.54.22"),
System.Net.IPAddress.Parse("47.82.59.65"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 105,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("30.7.101.101"),
System.Net.IPAddress.Parse("232.235.146.173"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("90.226.173.179"),
System.Net.IPAddress.Parse("250.140.67.178"), } },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 92,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("2.26.76.65"),
System.Net.IPAddress.Parse("145.32.157.173"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 107,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("148.237.26.93"),
System.Net.IPAddress.Parse("6.189.148.98"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 100,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("221.111.153.176"),
System.Net.IPAddress.Parse("178.58.55.209"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 115,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("168.29.243.252"),
System.Net.IPAddress.Parse("64.146.124.109"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 107,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("27.113.130.41"),
System.Net.IPAddress.Parse("145.68.41.230"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 123,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("81.19.28.102"),
System.Net.IPAddress.Parse("69.144.75.39"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("170.171.138.84"),
System.Net.IPAddress.Parse("147.189.131.43"), } },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 111,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("166.108.134.154"),
System.Net.IPAddress.Parse("188.186.171.198"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 131,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("43.17.16.128"),
System.Net.IPAddress.Parse("63.193.131.73"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 119,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("81.239.98.7"),
System.Net.IPAddress.Parse("11.115.133.92"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 137,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("176.138.30.94"),
System.Net.IPAddress.Parse("116.106.184.56"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("156.68.223.22"),
System.Net.IPAddress.Parse("132.82.218.85"), } },
},
            new IPAddressMArrayD2E1M
{
    Id = 128,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("141.20.168.41"),
System.Net.IPAddress.Parse("231.78.86.201"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 138,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("40.210.108.13"),
System.Net.IPAddress.Parse("50.23.35.52"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("149.136.214.81"),
System.Net.IPAddress.Parse("128.179.244.52"), } },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 129,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("13.177.173.71"),
System.Net.IPAddress.Parse("231.168.149.220"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 140,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("81.172.146.3"),
System.Net.IPAddress.Parse("45.113.188.117"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("145.163.77.71"),
System.Net.IPAddress.Parse("224.210.55.91"), } },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 130,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("208.58.63.184"),
System.Net.IPAddress.Parse("245.168.167.21"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 148,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("2.243.42.120"),
System.Net.IPAddress.Parse("175.216.220.37"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("241.35.93.128"),
System.Net.IPAddress.Parse("157.157.233.212"), } },
},
            new IPAddressMArrayD2E1M
{
    Id = 135,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("16.206.215.100"),
System.Net.IPAddress.Parse("221.103.166.93"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 150,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("34.123.23.155"),
System.Net.IPAddress.Parse("5.222.193.44"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("51.25.184.5"),
System.Net.IPAddress.Parse("166.21.72.188"), } },
},
            new IPAddressMArrayD2E1M
{
    Id = 140,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("17.233.123.117"),
System.Net.IPAddress.Parse("46.100.132.191"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 155,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("194.146.248.180"),
System.Net.IPAddress.Parse("59.196.154.49"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("18.59.63.95"),
System.Net.IPAddress.Parse("252.35.168.181"), } },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 141,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("36.222.163.127"),
System.Net.IPAddress.Parse("34.34.197.154"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 161,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("161.138.153.183"),
System.Net.IPAddress.Parse("233.210.111.4"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("5.176.82.253"),
System.Net.IPAddress.Parse("106.199.212.105"), } },
},
            new IPAddressMArrayD2E1M
{
    Id = 144,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("127.197.187.112"),
System.Net.IPAddress.Parse("97.23.11.56"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 166,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("227.200.59.131"),
System.Net.IPAddress.Parse("240.24.246.239"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("101.118.4.87"),
System.Net.IPAddress.Parse("87.224.180.133"), } },
},
            new IPAddressMArrayD2E1M
{
    Id = 150,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("214.83.147.123"),
System.Net.IPAddress.Parse("191.107.171.85"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 167,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("166.4.90.109"),
System.Net.IPAddress.Parse("239.200.141.45"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("95.138.204.75"),
System.Net.IPAddress.Parse("40.208.27.41"), } },
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("246.190.177.65"),
System.Net.IPAddress.Parse("51.60.189.161"), } },
},
            new IPAddressMArrayD2E1M
{
    Id = 159,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("7.69.9.140"),
System.Net.IPAddress.Parse("204.155.157.200"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 175,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("81.215.210.111"),
System.Net.IPAddress.Parse("162.149.204.62"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("40.208.58.143"),
System.Net.IPAddress.Parse("115.234.218.250"), } },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 165,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("154.202.36.200"),
System.Net.IPAddress.Parse("157.45.200.145"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 178,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("241.196.71.17"),
System.Net.IPAddress.Parse("178.4.69.35"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 171,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("168.44.2.113"),
System.Net.IPAddress.Parse("187.234.119.202"), } },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 184,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("147.225.182.67"),
System.Net.IPAddress.Parse("175.245.125.59"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("195.59.138.113"),
System.Net.IPAddress.Parse("102.59.34.231"), } },
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.ipaddressmarrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(IPv4))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(IPv4))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,]), 
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
                    await ((IIPAddressMArrayMArrayD2)this).InsertModelDbConnectionAsync(
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
                     ((IIPAddressMArrayMArrayD2)this).InsertModelDbConnection(
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
FROM gedaqtests.ipaddressmarrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(IPAddressMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayMArrayD2)),
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
                    var models = await ((IIPAddressMArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    IPAddressMArrayD2E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IIPAddressMArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    IPAddressMArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

