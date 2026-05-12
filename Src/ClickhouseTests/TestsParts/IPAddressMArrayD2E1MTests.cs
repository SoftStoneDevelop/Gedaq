

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
    Id = 3,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("190.198.186.6"), System.Net.IPAddress.Parse("185.104.234.235"), }, { System.Net.IPAddress.Parse("123.250.246.141"), System.Net.IPAddress.Parse("122.221.13.168"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 2,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("64.190.45.153"), System.Net.IPAddress.Parse("123.101.58.62"), }, { System.Net.IPAddress.Parse("212.196.39.190"), System.Net.IPAddress.Parse("33.118.68.98"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("145.26.154.13"), System.Net.IPAddress.Parse("28.169.61.179"), }, { System.Net.IPAddress.Parse("182.11.59.104"), System.Net.IPAddress.Parse("101.231.2.173"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("164.174.62.200"), System.Net.IPAddress.Parse("120.49.194.149"), }, { System.Net.IPAddress.Parse("102.71.58.149"), System.Net.IPAddress.Parse("178.110.17.237"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 11,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("30.221.128.221"), System.Net.IPAddress.Parse("174.163.104.135"), }, { System.Net.IPAddress.Parse("239.29.4.51"), System.Net.IPAddress.Parse("103.14.212.187"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 9,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("117.161.132.133"), System.Net.IPAddress.Parse("41.178.183.126"), }, { System.Net.IPAddress.Parse("142.107.221.8"), System.Net.IPAddress.Parse("230.66.92.215"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("13.211.244.174"), System.Net.IPAddress.Parse("78.204.186.38"), }, { System.Net.IPAddress.Parse("19.125.169.101"), System.Net.IPAddress.Parse("157.204.52.23"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("91.2.118.27"), System.Net.IPAddress.Parse("224.80.158.175"), }, { System.Net.IPAddress.Parse("105.142.96.250"), System.Net.IPAddress.Parse("182.143.211.123"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 16,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("254.203.247.85"), System.Net.IPAddress.Parse("191.78.102.96"), }, { System.Net.IPAddress.Parse("95.172.180.158"), System.Net.IPAddress.Parse("50.65.41.39"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 13,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("253.120.36.105"), System.Net.IPAddress.Parse("160.240.199.162"), }, { System.Net.IPAddress.Parse("191.176.232.192"), System.Net.IPAddress.Parse("82.148.205.175"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 25,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("109.209.252.226"), System.Net.IPAddress.Parse("210.227.214.22"), }, { System.Net.IPAddress.Parse("225.144.5.116"), System.Net.IPAddress.Parse("95.221.73.138"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 15,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("246.159.250.43"), System.Net.IPAddress.Parse("103.135.134.78"), }, { System.Net.IPAddress.Parse("14.2.27.132"), System.Net.IPAddress.Parse("75.97.196.62"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("167.161.106.111"), System.Net.IPAddress.Parse("253.229.110.186"), }, { System.Net.IPAddress.Parse("39.235.76.224"), System.Net.IPAddress.Parse("174.228.72.48"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 34,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("251.41.63.184"), System.Net.IPAddress.Parse("24.98.81.243"), }, { System.Net.IPAddress.Parse("178.125.205.208"), System.Net.IPAddress.Parse("176.88.185.10"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 17,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("143.105.171.55"), System.Net.IPAddress.Parse("144.160.48.212"), }, { System.Net.IPAddress.Parse("185.127.170.27"), System.Net.IPAddress.Parse("173.198.219.229"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 39,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("70.93.20.13"), System.Net.IPAddress.Parse("228.221.171.233"), }, { System.Net.IPAddress.Parse("196.66.232.156"), System.Net.IPAddress.Parse("247.89.157.240"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 22,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("93.1.63.11"), System.Net.IPAddress.Parse("154.251.178.61"), }, { System.Net.IPAddress.Parse("179.78.207.163"), System.Net.IPAddress.Parse("228.189.164.2"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("203.142.50.174"), System.Net.IPAddress.Parse("245.153.189.251"), }, { System.Net.IPAddress.Parse("5.48.19.208"), System.Net.IPAddress.Parse("99.39.17.128"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 44,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("100.74.0.245"), System.Net.IPAddress.Parse("74.102.91.40"), }, { System.Net.IPAddress.Parse("52.188.42.11"), System.Net.IPAddress.Parse("224.17.251.10"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 28,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("228.160.142.89"), System.Net.IPAddress.Parse("242.108.50.220"), }, { System.Net.IPAddress.Parse("155.73.95.92"), System.Net.IPAddress.Parse("11.147.161.177"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("155.186.145.36"), System.Net.IPAddress.Parse("8.232.177.99"), }, { System.Net.IPAddress.Parse("18.65.183.50"), System.Net.IPAddress.Parse("193.226.84.241"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 47,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("145.118.116.209"), System.Net.IPAddress.Parse("93.193.36.247"), }, { System.Net.IPAddress.Parse("87.38.137.200"), System.Net.IPAddress.Parse("126.67.252.8"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 32,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("72.145.206.210"), System.Net.IPAddress.Parse("80.2.72.0"), }, { System.Net.IPAddress.Parse("137.197.237.28"), System.Net.IPAddress.Parse("131.169.245.158"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("141.91.84.201"), System.Net.IPAddress.Parse("40.114.133.34"), }, { System.Net.IPAddress.Parse("48.88.90.209"), System.Net.IPAddress.Parse("120.112.97.198"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 54,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("138.157.5.194"), System.Net.IPAddress.Parse("169.114.165.229"), }, { System.Net.IPAddress.Parse("170.18.176.137"), System.Net.IPAddress.Parse("183.168.73.216"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 36,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("173.108.21.156"), System.Net.IPAddress.Parse("7.122.67.48"), }, { System.Net.IPAddress.Parse("102.119.128.51"), System.Net.IPAddress.Parse("17.237.127.221"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("100.18.123.63"), System.Net.IPAddress.Parse("146.176.81.17"), }, { System.Net.IPAddress.Parse("214.232.26.15"), System.Net.IPAddress.Parse("49.137.118.234"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 62,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("157.218.24.159"), System.Net.IPAddress.Parse("215.185.208.170"), }, { System.Net.IPAddress.Parse("152.68.49.230"), System.Net.IPAddress.Parse("216.12.148.158"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 45,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("62.177.105.226"), System.Net.IPAddress.Parse("16.42.140.16"), }, { System.Net.IPAddress.Parse("70.174.123.227"), System.Net.IPAddress.Parse("201.240.76.119"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("6.51.161.103"), System.Net.IPAddress.Parse("178.9.19.253"), }, { System.Net.IPAddress.Parse("161.92.131.132"), System.Net.IPAddress.Parse("217.129.119.201"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 66,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("80.7.210.152"), System.Net.IPAddress.Parse("234.214.247.213"), }, { System.Net.IPAddress.Parse("222.179.72.120"), System.Net.IPAddress.Parse("173.156.224.5"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 53,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("254.1.210.187"), System.Net.IPAddress.Parse("131.125.168.228"), }, { System.Net.IPAddress.Parse("79.27.155.99"), System.Net.IPAddress.Parse("211.105.84.109"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 69,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("241.36.218.158"), System.Net.IPAddress.Parse("14.2.39.174"), }, { System.Net.IPAddress.Parse("117.200.17.134"), System.Net.IPAddress.Parse("172.229.154.23"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 61,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("190.94.88.115"), System.Net.IPAddress.Parse("121.129.111.94"), }, { System.Net.IPAddress.Parse("125.162.121.62"), System.Net.IPAddress.Parse("158.33.189.56"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("115.108.85.161"), System.Net.IPAddress.Parse("240.229.29.191"), }, { System.Net.IPAddress.Parse("64.98.253.139"), System.Net.IPAddress.Parse("212.132.6.124"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 77,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("10.113.159.184"), System.Net.IPAddress.Parse("143.156.34.20"), }, { System.Net.IPAddress.Parse("32.198.207.29"), System.Net.IPAddress.Parse("119.192.241.81"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 66,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("84.196.154.173"), System.Net.IPAddress.Parse("145.231.243.235"), }, { System.Net.IPAddress.Parse("198.137.239.229"), System.Net.IPAddress.Parse("87.155.173.159"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("199.218.112.135"), System.Net.IPAddress.Parse("254.147.140.169"), }, { System.Net.IPAddress.Parse("144.110.39.115"), System.Net.IPAddress.Parse("77.48.245.215"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("103.112.222.56"), System.Net.IPAddress.Parse("114.57.50.194"), }, { System.Net.IPAddress.Parse("81.138.105.53"), System.Net.IPAddress.Parse("20.162.228.214"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 82,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("187.208.24.239"), System.Net.IPAddress.Parse("187.176.129.214"), }, { System.Net.IPAddress.Parse("168.53.110.63"), System.Net.IPAddress.Parse("162.192.129.130"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 74,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("25.115.129.241"), System.Net.IPAddress.Parse("30.144.137.32"), }, { System.Net.IPAddress.Parse("228.139.93.75"), System.Net.IPAddress.Parse("237.118.123.153"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 83,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("81.209.187.252"), System.Net.IPAddress.Parse("56.185.133.60"), }, { System.Net.IPAddress.Parse("136.238.192.171"), System.Net.IPAddress.Parse("65.16.78.10"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 82,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("232.214.222.185"), System.Net.IPAddress.Parse("61.199.21.7"), }, { System.Net.IPAddress.Parse("52.107.119.30"), System.Net.IPAddress.Parse("158.181.85.54"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("217.53.160.239"), System.Net.IPAddress.Parse("63.160.92.28"), }, { System.Net.IPAddress.Parse("103.77.147.90"), System.Net.IPAddress.Parse("220.19.72.166"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 87,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("175.169.164.235"), System.Net.IPAddress.Parse("90.2.179.202"), }, { System.Net.IPAddress.Parse("114.110.133.87"), System.Net.IPAddress.Parse("152.216.201.54"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 86,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("219.161.12.188"), System.Net.IPAddress.Parse("231.77.245.31"), }, { System.Net.IPAddress.Parse("75.85.5.88"), System.Net.IPAddress.Parse("81.201.58.162"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("149.141.147.203"), System.Net.IPAddress.Parse("106.162.100.210"), }, { System.Net.IPAddress.Parse("106.36.165.52"), System.Net.IPAddress.Parse("57.223.123.128"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 91,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("57.139.133.145"), System.Net.IPAddress.Parse("36.244.48.149"), }, { System.Net.IPAddress.Parse("83.172.165.33"), System.Net.IPAddress.Parse("8.185.178.29"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 87,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("68.56.253.175"), System.Net.IPAddress.Parse("229.93.106.126"), }, { System.Net.IPAddress.Parse("126.82.137.102"), System.Net.IPAddress.Parse("152.172.165.243"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("120.224.184.186"), System.Net.IPAddress.Parse("9.20.137.246"), }, { System.Net.IPAddress.Parse("212.36.178.132"), System.Net.IPAddress.Parse("10.208.97.164"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("192.99.16.63"), System.Net.IPAddress.Parse("73.240.140.132"), }, { System.Net.IPAddress.Parse("87.211.19.135"), System.Net.IPAddress.Parse("149.108.37.54"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 98,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("105.112.104.20"), System.Net.IPAddress.Parse("232.184.96.127"), }, { System.Net.IPAddress.Parse("10.177.114.60"), System.Net.IPAddress.Parse("51.62.45.196"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 93,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("116.222.128.140"), System.Net.IPAddress.Parse("1.85.129.34"), }, { System.Net.IPAddress.Parse("77.193.226.72"), System.Net.IPAddress.Parse("62.43.137.200"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("176.154.80.234"), System.Net.IPAddress.Parse("71.116.191.62"), }, { System.Net.IPAddress.Parse("240.55.193.38"), System.Net.IPAddress.Parse("81.156.115.188"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("142.79.68.58"), System.Net.IPAddress.Parse("229.180.137.12"), }, { System.Net.IPAddress.Parse("193.214.216.254"), System.Net.IPAddress.Parse("245.56.164.155"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 99,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("92.214.84.200"), System.Net.IPAddress.Parse("187.10.78.169"), }, { System.Net.IPAddress.Parse("38.180.230.243"), System.Net.IPAddress.Parse("207.238.219.114"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 95,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("251.21.125.88"), System.Net.IPAddress.Parse("82.240.45.60"), }, { System.Net.IPAddress.Parse("105.153.58.26"), System.Net.IPAddress.Parse("57.145.223.63"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("190.3.238.150"), System.Net.IPAddress.Parse("235.230.192.85"), }, { System.Net.IPAddress.Parse("253.172.58.5"), System.Net.IPAddress.Parse("141.243.85.73"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("53.189.93.246"), System.Net.IPAddress.Parse("162.89.119.249"), }, { System.Net.IPAddress.Parse("57.70.136.140"), System.Net.IPAddress.Parse("156.144.253.124"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 103,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("8.123.153.110"), System.Net.IPAddress.Parse("1.158.26.220"), }, { System.Net.IPAddress.Parse("72.30.148.100"), System.Net.IPAddress.Parse("76.104.165.163"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 102,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("82.119.48.134"), System.Net.IPAddress.Parse("14.56.198.234"), }, { System.Net.IPAddress.Parse("140.254.179.102"), System.Net.IPAddress.Parse("209.168.162.56"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 107,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("45.222.182.80"), System.Net.IPAddress.Parse("190.202.149.116"), }, { System.Net.IPAddress.Parse("46.40.138.19"), System.Net.IPAddress.Parse("81.148.65.122"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 108,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("47.81.201.129"), System.Net.IPAddress.Parse("114.200.111.66"), }, { System.Net.IPAddress.Parse("110.66.28.242"), System.Net.IPAddress.Parse("190.18.57.108"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("210.231.8.174"), System.Net.IPAddress.Parse("190.241.139.124"), }, { System.Net.IPAddress.Parse("198.99.33.240"), System.Net.IPAddress.Parse("214.11.233.189"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 109,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("152.60.231.204"), System.Net.IPAddress.Parse("219.221.112.29"), }, { System.Net.IPAddress.Parse("161.237.250.234"), System.Net.IPAddress.Parse("171.240.225.215"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 110,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("216.221.237.171"), System.Net.IPAddress.Parse("68.41.167.144"), }, { System.Net.IPAddress.Parse("163.132.65.141"), System.Net.IPAddress.Parse("66.136.152.48"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("80.69.60.117"), System.Net.IPAddress.Parse("232.40.160.48"), }, { System.Net.IPAddress.Parse("166.78.159.141"), System.Net.IPAddress.Parse("107.154.205.183"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 117,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("46.203.116.44"), System.Net.IPAddress.Parse("14.103.91.74"), }, { System.Net.IPAddress.Parse("179.179.230.46"), System.Net.IPAddress.Parse("227.101.74.217"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 119,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("42.123.132.66"), System.Net.IPAddress.Parse("45.144.223.241"), }, { System.Net.IPAddress.Parse("171.27.81.54"), System.Net.IPAddress.Parse("228.243.168.9"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 118,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("36.49.93.166"), System.Net.IPAddress.Parse("201.39.210.114"), }, { System.Net.IPAddress.Parse("73.228.208.2"), System.Net.IPAddress.Parse("201.83.246.197"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 126,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("89.169.69.225"), System.Net.IPAddress.Parse("25.194.167.168"), }, { System.Net.IPAddress.Parse("174.226.152.166"), System.Net.IPAddress.Parse("56.11.45.144"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("239.116.241.222"), System.Net.IPAddress.Parse("250.123.97.149"), }, { System.Net.IPAddress.Parse("240.64.47.202"), System.Net.IPAddress.Parse("134.233.155.138"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 127,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("138.54.105.53"), System.Net.IPAddress.Parse("35.23.158.221"), }, { System.Net.IPAddress.Parse("153.73.18.117"), System.Net.IPAddress.Parse("83.32.237.97"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 133,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("39.3.229.152"), System.Net.IPAddress.Parse("243.153.97.239"), }, { System.Net.IPAddress.Parse("175.95.1.7"), System.Net.IPAddress.Parse("216.22.126.107"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("140.226.244.51"), System.Net.IPAddress.Parse("174.68.112.127"), }, { System.Net.IPAddress.Parse("102.112.154.161"), System.Net.IPAddress.Parse("133.167.182.21"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 129,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("159.238.212.71"), System.Net.IPAddress.Parse("146.164.163.153"), }, { System.Net.IPAddress.Parse("124.216.153.66"), System.Net.IPAddress.Parse("86.224.213.44"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 139,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("202.207.19.187"), System.Net.IPAddress.Parse("78.147.119.179"), }, { System.Net.IPAddress.Parse("87.191.234.174"), System.Net.IPAddress.Parse("49.119.209.111"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("118.62.48.192"), System.Net.IPAddress.Parse("140.126.81.193"), }, { System.Net.IPAddress.Parse("225.178.60.74"), System.Net.IPAddress.Parse("24.40.100.50"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 131,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("237.113.250.46"), System.Net.IPAddress.Parse("85.112.206.142"), }, { System.Net.IPAddress.Parse("35.90.195.242"), System.Net.IPAddress.Parse("147.99.240.121"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 141,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("84.227.204.126"), System.Net.IPAddress.Parse("79.173.142.107"), }, { System.Net.IPAddress.Parse("243.200.166.206"), System.Net.IPAddress.Parse("134.31.166.148"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 134,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("231.111.8.49"), System.Net.IPAddress.Parse("52.76.69.16"), }, { System.Net.IPAddress.Parse("165.131.200.4"), System.Net.IPAddress.Parse("98.205.83.115"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 144,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("151.95.101.104"), System.Net.IPAddress.Parse("239.51.63.75"), }, { System.Net.IPAddress.Parse("142.196.93.121"), System.Net.IPAddress.Parse("134.133.232.177"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 137,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("94.54.55.152"), System.Net.IPAddress.Parse("60.222.246.110"), }, { System.Net.IPAddress.Parse("102.190.27.237"), System.Net.IPAddress.Parse("141.217.65.227"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 150,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("140.191.215.5"), System.Net.IPAddress.Parse("198.77.21.1"), }, { System.Net.IPAddress.Parse("89.233.216.41"), System.Net.IPAddress.Parse("33.50.46.54"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 144,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("245.143.75.107"), System.Net.IPAddress.Parse("119.123.69.71"), }, { System.Net.IPAddress.Parse("43.180.70.203"), System.Net.IPAddress.Parse("222.155.155.109"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 158,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("235.156.23.199"), System.Net.IPAddress.Parse("132.81.160.112"), }, { System.Net.IPAddress.Parse("104.81.95.42"), System.Net.IPAddress.Parse("21.106.196.213"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("155.212.212.197"), System.Net.IPAddress.Parse("47.160.18.249"), }, { System.Net.IPAddress.Parse("216.157.78.160"), System.Net.IPAddress.Parse("183.181.72.93"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 150,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("106.144.100.168"), System.Net.IPAddress.Parse("10.192.33.252"), }, { System.Net.IPAddress.Parse("227.157.66.46"), System.Net.IPAddress.Parse("75.63.188.47"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 163,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("237.241.18.6"), System.Net.IPAddress.Parse("13.87.151.8"), }, { System.Net.IPAddress.Parse("134.219.124.213"), System.Net.IPAddress.Parse("131.205.45.98"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("55.93.86.46"), System.Net.IPAddress.Parse("30.213.26.107"), }, { System.Net.IPAddress.Parse("167.171.95.46"), System.Net.IPAddress.Parse("230.193.111.70"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 155,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("80.97.180.226"), System.Net.IPAddress.Parse("71.208.161.68"), }, { System.Net.IPAddress.Parse("5.80.42.229"), System.Net.IPAddress.Parse("217.22.196.236"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 171,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("218.108.139.4"), System.Net.IPAddress.Parse("206.224.193.219"), }, { System.Net.IPAddress.Parse("194.233.16.15"), System.Net.IPAddress.Parse("132.115.208.54"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("67.38.96.169"), System.Net.IPAddress.Parse("118.192.84.87"), }, { System.Net.IPAddress.Parse("230.81.214.233"), System.Net.IPAddress.Parse("60.240.14.202"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 158,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("104.64.143.222"), System.Net.IPAddress.Parse("213.219.108.64"), }, { System.Net.IPAddress.Parse("33.240.131.80"), System.Net.IPAddress.Parse("164.115.104.83"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 175,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("205.21.211.80"), System.Net.IPAddress.Parse("81.80.218.204"), }, { System.Net.IPAddress.Parse("31.65.12.177"), System.Net.IPAddress.Parse("226.230.48.193"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("196.6.173.189"), System.Net.IPAddress.Parse("52.194.105.197"), }, { System.Net.IPAddress.Parse("241.38.73.75"), System.Net.IPAddress.Parse("76.195.43.176"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 165,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("71.178.50.247"), System.Net.IPAddress.Parse("177.163.47.95"), }, { System.Net.IPAddress.Parse("71.183.201.69"), System.Net.IPAddress.Parse("28.142.148.9"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 182,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("74.220.204.1"), System.Net.IPAddress.Parse("17.172.247.234"), }, { System.Net.IPAddress.Parse("211.145.3.13"), System.Net.IPAddress.Parse("145.134.117.183"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("167.153.178.253"), System.Net.IPAddress.Parse("84.78.52.54"), }, { System.Net.IPAddress.Parse("75.11.130.175"), System.Net.IPAddress.Parse("218.89.96.51"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 167,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("67.234.205.64"), System.Net.IPAddress.Parse("190.67.104.33"), }, { System.Net.IPAddress.Parse("52.189.104.248"), System.Net.IPAddress.Parse("65.116.131.82"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 185,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("101.2.186.6"), System.Net.IPAddress.Parse("134.187.187.40"), }, { System.Net.IPAddress.Parse("212.110.246.161"), System.Net.IPAddress.Parse("207.23.230.31"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("14.54.1.79"), System.Net.IPAddress.Parse("53.10.195.48"), }, { System.Net.IPAddress.Parse("55.131.95.44"), System.Net.IPAddress.Parse("107.161.13.28"), }, },
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

