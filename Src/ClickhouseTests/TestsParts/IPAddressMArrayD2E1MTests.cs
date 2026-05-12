

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
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("143.252.205.251"), System.Net.IPAddress.Parse("107.251.19.171"), }, { System.Net.IPAddress.Parse("116.155.216.60"), System.Net.IPAddress.Parse("205.203.232.192"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 1,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("19.43.110.145"), System.Net.IPAddress.Parse("152.103.39.93"), }, { System.Net.IPAddress.Parse("89.0.205.224"), System.Net.IPAddress.Parse("139.36.144.187"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("3.133.98.229"), System.Net.IPAddress.Parse("254.40.197.110"), }, { System.Net.IPAddress.Parse("120.140.171.224"), System.Net.IPAddress.Parse("73.83.19.130"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 3,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("33.218.95.6"), System.Net.IPAddress.Parse("208.22.11.68"), }, { System.Net.IPAddress.Parse("214.122.86.190"), System.Net.IPAddress.Parse("205.133.63.162"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 6,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("76.133.180.134"), System.Net.IPAddress.Parse("26.144.156.26"), }, { System.Net.IPAddress.Parse("18.54.98.139"), System.Net.IPAddress.Parse("74.140.124.205"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 4,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("96.123.251.216"), System.Net.IPAddress.Parse("12.175.240.116"), }, { System.Net.IPAddress.Parse("1.243.35.65"), System.Net.IPAddress.Parse("183.49.140.127"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 10,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("31.105.19.106"), System.Net.IPAddress.Parse("15.131.57.28"), }, { System.Net.IPAddress.Parse("133.54.168.110"), System.Net.IPAddress.Parse("188.94.213.7"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("7.84.90.191"), System.Net.IPAddress.Parse("31.186.252.156"), }, { System.Net.IPAddress.Parse("21.102.84.210"), System.Net.IPAddress.Parse("124.77.76.175"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 9,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("82.40.157.66"), System.Net.IPAddress.Parse("223.97.181.63"), }, { System.Net.IPAddress.Parse("137.238.152.7"), System.Net.IPAddress.Parse("231.8.90.127"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 15,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("186.95.26.94"), System.Net.IPAddress.Parse("200.138.226.237"), }, { System.Net.IPAddress.Parse("75.114.89.65"), System.Net.IPAddress.Parse("172.104.241.115"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 18,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("246.23.1.160"), System.Net.IPAddress.Parse("12.221.4.245"), }, { System.Net.IPAddress.Parse("25.155.231.63"), System.Net.IPAddress.Parse("214.8.60.70"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 21,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("186.71.72.40"), System.Net.IPAddress.Parse("172.161.179.106"), }, { System.Net.IPAddress.Parse("154.150.163.181"), System.Net.IPAddress.Parse("233.21.4.5"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("207.5.212.70"), System.Net.IPAddress.Parse("79.126.6.234"), }, { System.Net.IPAddress.Parse("216.168.52.67"), System.Net.IPAddress.Parse("150.16.185.19"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 21,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("79.240.195.31"), System.Net.IPAddress.Parse("14.206.150.45"), }, { System.Net.IPAddress.Parse("48.141.83.189"), System.Net.IPAddress.Parse("68.109.251.134"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 30,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("50.187.89.199"), System.Net.IPAddress.Parse("147.96.167.39"), }, { System.Net.IPAddress.Parse("31.231.171.209"), System.Net.IPAddress.Parse("101.143.21.11"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 29,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("247.129.156.174"), System.Net.IPAddress.Parse("73.164.73.147"), }, { System.Net.IPAddress.Parse("70.142.148.65"), System.Net.IPAddress.Parse("40.39.134.199"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 32,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("242.130.40.252"), System.Net.IPAddress.Parse("154.80.137.134"), }, { System.Net.IPAddress.Parse("14.139.248.224"), System.Net.IPAddress.Parse("125.197.241.7"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("104.184.97.180"), System.Net.IPAddress.Parse("158.122.187.27"), }, { System.Net.IPAddress.Parse("135.93.83.223"), System.Net.IPAddress.Parse("249.53.203.63"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 36,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("78.36.150.13"), System.Net.IPAddress.Parse("222.108.26.148"), }, { System.Net.IPAddress.Parse("210.162.180.74"), System.Net.IPAddress.Parse("47.140.143.221"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 40,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("170.29.22.222"), System.Net.IPAddress.Parse("224.170.100.132"), }, { System.Net.IPAddress.Parse("227.113.11.187"), System.Net.IPAddress.Parse("105.85.70.237"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("33.11.115.17"), System.Net.IPAddress.Parse("141.139.14.3"), }, { System.Net.IPAddress.Parse("198.163.239.249"), System.Net.IPAddress.Parse("169.75.156.146"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("249.128.63.72"), System.Net.IPAddress.Parse("59.247.209.128"), }, { System.Net.IPAddress.Parse("105.138.167.141"), System.Net.IPAddress.Parse("76.195.88.39"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 45,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("155.171.156.209"), System.Net.IPAddress.Parse("54.33.90.174"), }, { System.Net.IPAddress.Parse("80.27.145.180"), System.Net.IPAddress.Parse("190.254.136.147"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 47,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("196.201.188.43"), System.Net.IPAddress.Parse("224.235.67.164"), }, { System.Net.IPAddress.Parse("88.18.50.19"), System.Net.IPAddress.Parse("167.76.96.65"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("123.68.91.24"), System.Net.IPAddress.Parse("31.16.215.191"), }, { System.Net.IPAddress.Parse("139.66.196.103"), System.Net.IPAddress.Parse("240.109.99.25"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("243.99.252.164"), System.Net.IPAddress.Parse("167.217.177.187"), }, { System.Net.IPAddress.Parse("86.205.47.211"), System.Net.IPAddress.Parse("242.223.48.202"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 49,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("78.214.196.169"), System.Net.IPAddress.Parse("177.228.189.12"), }, { System.Net.IPAddress.Parse("44.165.40.185"), System.Net.IPAddress.Parse("160.117.59.82"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("176.1.42.190"), System.Net.IPAddress.Parse("107.52.156.144"), }, { System.Net.IPAddress.Parse("156.227.38.29"), System.Net.IPAddress.Parse("51.122.93.152"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("164.240.174.200"), System.Net.IPAddress.Parse("207.225.204.41"), }, { System.Net.IPAddress.Parse("40.99.236.191"), System.Net.IPAddress.Parse("211.121.250.236"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 55,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("103.16.175.75"), System.Net.IPAddress.Parse("242.203.168.186"), }, { System.Net.IPAddress.Parse("3.242.99.66"), System.Net.IPAddress.Parse("0.74.191.170"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 56,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("242.38.240.72"), System.Net.IPAddress.Parse("47.51.158.92"), }, { System.Net.IPAddress.Parse("56.191.75.116"), System.Net.IPAddress.Parse("181.105.217.67"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("146.185.237.226"), System.Net.IPAddress.Parse("9.241.141.142"), }, { System.Net.IPAddress.Parse("97.74.45.134"), System.Net.IPAddress.Parse("224.221.123.92"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 57,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("206.180.6.206"), System.Net.IPAddress.Parse("58.193.235.8"), }, { System.Net.IPAddress.Parse("239.179.5.127"), System.Net.IPAddress.Parse("108.191.48.159"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 60,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("148.250.74.203"), System.Net.IPAddress.Parse("231.231.187.106"), }, { System.Net.IPAddress.Parse("127.42.252.199"), System.Net.IPAddress.Parse("245.97.6.238"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 60,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("89.138.35.7"), System.Net.IPAddress.Parse("126.7.39.107"), }, { System.Net.IPAddress.Parse("106.159.26.217"), System.Net.IPAddress.Parse("100.70.221.245"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 61,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("138.58.129.97"), System.Net.IPAddress.Parse("82.79.241.73"), }, { System.Net.IPAddress.Parse("78.169.43.146"), System.Net.IPAddress.Parse("146.82.11.2"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("186.123.172.71"), System.Net.IPAddress.Parse("212.178.233.183"), }, { System.Net.IPAddress.Parse("217.117.27.146"), System.Net.IPAddress.Parse("6.195.4.143"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("229.33.49.198"), System.Net.IPAddress.Parse("175.189.241.146"), }, { System.Net.IPAddress.Parse("114.244.204.226"), System.Net.IPAddress.Parse("221.72.59.73"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 66,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("87.96.14.24"), System.Net.IPAddress.Parse("231.146.148.249"), }, { System.Net.IPAddress.Parse("224.95.208.202"), System.Net.IPAddress.Parse("162.50.67.27"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 68,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("187.125.235.182"), System.Net.IPAddress.Parse("167.30.155.103"), }, { System.Net.IPAddress.Parse("132.250.186.108"), System.Net.IPAddress.Parse("176.222.249.106"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 68,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("30.167.110.123"), System.Net.IPAddress.Parse("121.21.13.14"), }, { System.Net.IPAddress.Parse("63.175.48.119"), System.Net.IPAddress.Parse("0.157.192.252"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 69,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("222.63.52.99"), System.Net.IPAddress.Parse("143.17.159.125"), }, { System.Net.IPAddress.Parse("215.56.32.119"), System.Net.IPAddress.Parse("70.110.220.62"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 77,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("4.137.135.212"), System.Net.IPAddress.Parse("250.27.167.83"), }, { System.Net.IPAddress.Parse("126.30.93.12"), System.Net.IPAddress.Parse("59.47.128.70"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 75,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("155.75.104.129"), System.Net.IPAddress.Parse("130.22.25.200"), }, { System.Net.IPAddress.Parse("18.17.39.250"), System.Net.IPAddress.Parse("28.25.164.59"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("222.165.72.113"), System.Net.IPAddress.Parse("156.128.25.198"), }, { System.Net.IPAddress.Parse("116.196.220.67"), System.Net.IPAddress.Parse("162.114.81.37"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("196.46.194.95"), System.Net.IPAddress.Parse("210.226.243.168"), }, { System.Net.IPAddress.Parse("94.80.125.125"), System.Net.IPAddress.Parse("71.145.100.233"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 81,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("18.212.108.85"), System.Net.IPAddress.Parse("246.190.39.164"), }, { System.Net.IPAddress.Parse("36.165.8.137"), System.Net.IPAddress.Parse("49.155.171.43"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 82,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("239.99.172.160"), System.Net.IPAddress.Parse("222.233.53.233"), }, { System.Net.IPAddress.Parse("22.3.178.157"), System.Net.IPAddress.Parse("98.12.10.14"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("23.208.46.192"), System.Net.IPAddress.Parse("92.199.11.51"), }, { System.Net.IPAddress.Parse("204.166.181.178"), System.Net.IPAddress.Parse("85.240.104.133"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 84,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("116.119.227.222"), System.Net.IPAddress.Parse("191.129.227.143"), }, { System.Net.IPAddress.Parse("248.241.21.132"), System.Net.IPAddress.Parse("116.45.186.36"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 86,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("135.126.253.240"), System.Net.IPAddress.Parse("237.251.30.83"), }, { System.Net.IPAddress.Parse("195.129.228.51"), System.Net.IPAddress.Parse("91.84.36.74"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("94.231.128.173"), System.Net.IPAddress.Parse("142.59.226.7"), }, { System.Net.IPAddress.Parse("49.149.164.176"), System.Net.IPAddress.Parse("183.94.88.210"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 90,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("103.41.44.146"), System.Net.IPAddress.Parse("141.7.158.142"), }, { System.Net.IPAddress.Parse("159.34.63.91"), System.Net.IPAddress.Parse("140.18.143.90"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 92,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("186.51.236.87"), System.Net.IPAddress.Parse("159.26.96.241"), }, { System.Net.IPAddress.Parse("171.19.165.114"), System.Net.IPAddress.Parse("221.103.213.181"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 92,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("234.99.189.46"), System.Net.IPAddress.Parse("154.236.162.193"), }, { System.Net.IPAddress.Parse("14.122.155.68"), System.Net.IPAddress.Parse("231.106.18.150"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 100,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("233.151.165.188"), System.Net.IPAddress.Parse("92.167.10.6"), }, { System.Net.IPAddress.Parse("174.105.57.72"), System.Net.IPAddress.Parse("233.83.75.221"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("189.138.59.43"), System.Net.IPAddress.Parse("180.202.100.172"), }, { System.Net.IPAddress.Parse("50.230.175.132"), System.Net.IPAddress.Parse("116.89.68.75"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("67.50.20.102"), System.Net.IPAddress.Parse("235.55.33.46"), }, { System.Net.IPAddress.Parse("36.178.120.223"), System.Net.IPAddress.Parse("21.24.226.99"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 99,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("160.226.103.109"), System.Net.IPAddress.Parse("25.16.18.150"), }, { System.Net.IPAddress.Parse("238.230.12.224"), System.Net.IPAddress.Parse("193.28.226.16"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 101,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("54.107.181.188"), System.Net.IPAddress.Parse("106.12.23.161"), }, { System.Net.IPAddress.Parse("189.216.232.127"), System.Net.IPAddress.Parse("113.178.250.225"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("195.42.78.56"), System.Net.IPAddress.Parse("110.148.10.92"), }, { System.Net.IPAddress.Parse("66.232.237.121"), System.Net.IPAddress.Parse("145.211.4.177"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 102,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("31.103.20.29"), System.Net.IPAddress.Parse("59.165.14.32"), }, { System.Net.IPAddress.Parse("166.175.210.60"), System.Net.IPAddress.Parse("29.6.94.95"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 105,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("17.16.161.139"), System.Net.IPAddress.Parse("3.200.6.86"), }, { System.Net.IPAddress.Parse("76.228.119.191"), System.Net.IPAddress.Parse("203.215.70.175"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("191.222.55.81"), System.Net.IPAddress.Parse("113.155.0.138"), }, { System.Net.IPAddress.Parse("26.158.44.98"), System.Net.IPAddress.Parse("104.100.243.59"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("118.31.107.150"), System.Net.IPAddress.Parse("14.218.234.133"), }, { System.Net.IPAddress.Parse("182.212.145.31"), System.Net.IPAddress.Parse("182.228.80.46"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 103,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("39.105.79.105"), System.Net.IPAddress.Parse("246.195.238.220"), }, { System.Net.IPAddress.Parse("200.182.68.175"), System.Net.IPAddress.Parse("126.177.130.188"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 114,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("176.83.238.170"), System.Net.IPAddress.Parse("231.239.232.187"), }, { System.Net.IPAddress.Parse("193.181.182.25"), System.Net.IPAddress.Parse("238.23.192.197"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("38.18.113.141"), System.Net.IPAddress.Parse("165.119.39.243"), }, { System.Net.IPAddress.Parse("52.187.69.36"), System.Net.IPAddress.Parse("29.183.12.248"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("58.225.75.237"), System.Net.IPAddress.Parse("19.152.111.7"), }, { System.Net.IPAddress.Parse("47.244.132.214"), System.Net.IPAddress.Parse("85.160.118.12"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 111,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("26.40.153.233"), System.Net.IPAddress.Parse("131.203.149.47"), }, { System.Net.IPAddress.Parse("1.65.145.149"), System.Net.IPAddress.Parse("221.146.82.93"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 120,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("97.8.209.6"), System.Net.IPAddress.Parse("199.49.205.3"), }, { System.Net.IPAddress.Parse("64.120.96.41"), System.Net.IPAddress.Parse("66.168.235.79"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 119,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("15.61.217.181"), System.Net.IPAddress.Parse("205.17.199.236"), }, { System.Net.IPAddress.Parse("22.60.16.103"), System.Net.IPAddress.Parse("93.165.65.96"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 123,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("247.123.23.134"), System.Net.IPAddress.Parse("71.47.139.248"), }, { System.Net.IPAddress.Parse("244.175.24.170"), System.Net.IPAddress.Parse("154.156.246.254"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("158.204.254.8"), System.Net.IPAddress.Parse("9.228.26.221"), }, { System.Net.IPAddress.Parse("248.239.197.210"), System.Net.IPAddress.Parse("232.176.137.134"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 127,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("157.225.57.89"), System.Net.IPAddress.Parse("200.203.253.23"), }, { System.Net.IPAddress.Parse("176.43.111.252"), System.Net.IPAddress.Parse("56.76.30.139"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 124,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("199.96.222.57"), System.Net.IPAddress.Parse("154.31.141.52"), }, { System.Net.IPAddress.Parse("47.139.216.62"), System.Net.IPAddress.Parse("62.163.105.9"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("94.76.254.143"), System.Net.IPAddress.Parse("32.174.121.206"), }, { System.Net.IPAddress.Parse("178.211.68.126"), System.Net.IPAddress.Parse("8.197.226.202"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 129,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("92.3.63.170"), System.Net.IPAddress.Parse("172.73.149.78"), }, { System.Net.IPAddress.Parse("169.172.88.153"), System.Net.IPAddress.Parse("176.156.64.43"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 126,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("238.254.185.227"), System.Net.IPAddress.Parse("214.118.212.132"), }, { System.Net.IPAddress.Parse("140.49.148.240"), System.Net.IPAddress.Parse("33.29.249.96"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("151.193.58.222"), System.Net.IPAddress.Parse("186.3.250.135"), }, { System.Net.IPAddress.Parse("222.13.30.119"), System.Net.IPAddress.Parse("133.209.5.105"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 137,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("79.216.64.71"), System.Net.IPAddress.Parse("119.132.228.32"), }, { System.Net.IPAddress.Parse("240.18.199.32"), System.Net.IPAddress.Parse("210.202.35.241"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 130,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("65.195.58.196"), System.Net.IPAddress.Parse("211.191.90.173"), }, { System.Net.IPAddress.Parse("19.177.64.176"), System.Net.IPAddress.Parse("1.239.13.154"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 138,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("75.230.219.46"), System.Net.IPAddress.Parse("85.64.225.103"), }, { System.Net.IPAddress.Parse("131.238.136.204"), System.Net.IPAddress.Parse("114.20.82.111"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 134,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("102.84.127.5"), System.Net.IPAddress.Parse("222.230.63.77"), }, { System.Net.IPAddress.Parse("14.198.136.39"), System.Net.IPAddress.Parse("245.73.129.58"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("168.189.210.236"), System.Net.IPAddress.Parse("221.222.13.99"), }, { System.Net.IPAddress.Parse("32.188.107.118"), System.Net.IPAddress.Parse("68.81.219.222"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 143,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("222.68.234.217"), System.Net.IPAddress.Parse("59.212.49.153"), }, { System.Net.IPAddress.Parse("123.196.163.126"), System.Net.IPAddress.Parse("10.170.209.119"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 135,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("252.106.50.103"), System.Net.IPAddress.Parse("158.49.248.80"), }, { System.Net.IPAddress.Parse("124.7.175.182"), System.Net.IPAddress.Parse("247.116.231.89"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("112.4.229.201"), System.Net.IPAddress.Parse("237.207.187.215"), }, { System.Net.IPAddress.Parse("38.61.191.218"), System.Net.IPAddress.Parse("102.180.92.160"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("153.22.74.33"), System.Net.IPAddress.Parse("72.145.85.162"), }, { System.Net.IPAddress.Parse("83.166.241.130"), System.Net.IPAddress.Parse("239.132.57.102"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 144,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("231.82.68.215"), System.Net.IPAddress.Parse("8.102.86.101"), }, { System.Net.IPAddress.Parse("200.74.34.11"), System.Net.IPAddress.Parse("251.159.254.69"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 141,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("160.63.171.38"), System.Net.IPAddress.Parse("140.126.40.160"), }, { System.Net.IPAddress.Parse("29.195.43.108"), System.Net.IPAddress.Parse("173.117.49.205"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("177.166.182.212"), System.Net.IPAddress.Parse("94.69.132.171"), }, { System.Net.IPAddress.Parse("250.73.213.141"), System.Net.IPAddress.Parse("180.156.86.141"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 153,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("74.187.232.0"), System.Net.IPAddress.Parse("85.37.65.57"), }, { System.Net.IPAddress.Parse("168.183.5.230"), System.Net.IPAddress.Parse("239.100.193.193"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 150,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("116.98.243.246"), System.Net.IPAddress.Parse("159.143.252.215"), }, { System.Net.IPAddress.Parse("89.144.173.80"), System.Net.IPAddress.Parse("5.59.68.53"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 154,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("40.154.141.244"), System.Net.IPAddress.Parse("33.175.134.216"), }, { System.Net.IPAddress.Parse("16.209.136.165"), System.Net.IPAddress.Parse("41.64.94.186"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 153,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("28.28.207.0"), System.Net.IPAddress.Parse("167.105.25.184"), }, { System.Net.IPAddress.Parse("25.9.102.77"), System.Net.IPAddress.Parse("244.239.14.120"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("108.54.206.162"), System.Net.IPAddress.Parse("252.28.42.92"), }, { System.Net.IPAddress.Parse("63.95.51.72"), System.Net.IPAddress.Parse("28.192.67.187"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 157,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("133.192.78.47"), System.Net.IPAddress.Parse("248.227.214.21"), }, { System.Net.IPAddress.Parse("214.227.193.59"), System.Net.IPAddress.Parse("94.143.69.97"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 159,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("172.161.91.50"), System.Net.IPAddress.Parse("132.24.210.87"), }, { System.Net.IPAddress.Parse("127.219.62.66"), System.Net.IPAddress.Parse("64.190.224.208"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 164,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("110.46.240.20"), System.Net.IPAddress.Parse("70.241.174.28"), }, { System.Net.IPAddress.Parse("6.106.192.48"), System.Net.IPAddress.Parse("78.56.97.103"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 160,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("91.27.208.21"), System.Net.IPAddress.Parse("157.31.219.185"), }, { System.Net.IPAddress.Parse("187.173.227.245"), System.Net.IPAddress.Parse("4.98.208.11"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("169.188.0.88"), System.Net.IPAddress.Parse("180.163.221.146"), }, { System.Net.IPAddress.Parse("200.250.232.197"), System.Net.IPAddress.Parse("243.112.236.42"), }, },
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

