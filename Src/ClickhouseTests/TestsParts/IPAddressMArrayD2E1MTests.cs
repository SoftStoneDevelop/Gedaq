

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
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("131.234.235.34"), System.Net.IPAddress.Parse("61.53.12.178"), }, { System.Net.IPAddress.Parse("39.218.73.210"), System.Net.IPAddress.Parse("134.233.71.51"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 7,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("74.159.72.17"), System.Net.IPAddress.Parse("80.91.157.198"), }, { System.Net.IPAddress.Parse("19.114.144.65"), System.Net.IPAddress.Parse("223.11.192.180"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("48.146.113.197"), System.Net.IPAddress.Parse("253.246.198.23"), }, { System.Net.IPAddress.Parse("129.132.153.231"), System.Net.IPAddress.Parse("35.133.160.229"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 5,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("218.232.223.17"), System.Net.IPAddress.Parse("99.241.132.153"), }, { System.Net.IPAddress.Parse("17.210.161.67"), System.Net.IPAddress.Parse("71.61.4.250"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 12,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("10.24.191.162"), System.Net.IPAddress.Parse("119.87.152.151"), }, { System.Net.IPAddress.Parse("77.98.24.189"), System.Net.IPAddress.Parse("18.183.184.193"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("1.206.206.105"), System.Net.IPAddress.Parse("235.176.78.155"), }, { System.Net.IPAddress.Parse("209.237.104.33"), System.Net.IPAddress.Parse("242.238.216.229"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 8,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("194.65.42.252"), System.Net.IPAddress.Parse("97.41.6.29"), }, { System.Net.IPAddress.Parse("157.168.183.233"), System.Net.IPAddress.Parse("89.48.224.118"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 13,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("190.118.64.78"), System.Net.IPAddress.Parse("116.77.92.4"), }, { System.Net.IPAddress.Parse("163.51.33.182"), System.Net.IPAddress.Parse("9.90.116.88"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("162.249.127.72"), System.Net.IPAddress.Parse("232.130.220.26"), }, { System.Net.IPAddress.Parse("211.146.85.207"), System.Net.IPAddress.Parse("162.32.158.181"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("156.107.189.18"), System.Net.IPAddress.Parse("58.234.56.153"), }, { System.Net.IPAddress.Parse("86.63.64.35"), System.Net.IPAddress.Parse("249.93.34.24"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 12,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("233.201.144.203"), System.Net.IPAddress.Parse("244.122.120.22"), }, { System.Net.IPAddress.Parse("15.30.157.164"), System.Net.IPAddress.Parse("247.21.8.18"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 18,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("183.1.17.86"), System.Net.IPAddress.Parse("135.176.117.46"), }, { System.Net.IPAddress.Parse("76.133.211.204"), System.Net.IPAddress.Parse("86.45.165.156"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 15,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("232.184.12.109"), System.Net.IPAddress.Parse("20.53.45.250"), }, { System.Net.IPAddress.Parse("140.45.244.145"), System.Net.IPAddress.Parse("234.38.177.4"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("27.120.57.87"), System.Net.IPAddress.Parse("13.123.237.140"), }, { System.Net.IPAddress.Parse("162.4.165.23"), System.Net.IPAddress.Parse("157.138.28.8"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("14.90.20.170"), System.Net.IPAddress.Parse("101.174.208.219"), }, { System.Net.IPAddress.Parse("135.104.121.198"), System.Net.IPAddress.Parse("222.178.45.64"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 23,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("148.27.104.155"), System.Net.IPAddress.Parse("59.249.104.175"), }, { System.Net.IPAddress.Parse("189.138.112.49"), System.Net.IPAddress.Parse("137.162.105.95"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 27,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("83.124.197.162"), System.Net.IPAddress.Parse("35.54.195.132"), }, { System.Net.IPAddress.Parse("18.32.42.107"), System.Net.IPAddress.Parse("123.72.188.21"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("220.52.171.65"), System.Net.IPAddress.Parse("9.240.193.66"), }, { System.Net.IPAddress.Parse("105.209.128.215"), System.Net.IPAddress.Parse("103.241.235.20"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 32,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("184.36.14.85"), System.Net.IPAddress.Parse("7.19.174.219"), }, { System.Net.IPAddress.Parse("167.65.216.96"), System.Net.IPAddress.Parse("153.33.172.49"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 32,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("141.186.120.199"), System.Net.IPAddress.Parse("147.180.227.53"), }, { System.Net.IPAddress.Parse("130.220.81.254"), System.Net.IPAddress.Parse("191.70.189.142"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("14.121.242.27"), System.Net.IPAddress.Parse("6.39.43.187"), }, { System.Net.IPAddress.Parse("250.101.155.3"), System.Net.IPAddress.Parse("230.103.65.137"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 36,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("50.174.205.181"), System.Net.IPAddress.Parse("156.62.39.60"), }, { System.Net.IPAddress.Parse("20.248.2.141"), System.Net.IPAddress.Parse("86.66.191.110"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 41,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("121.132.205.100"), System.Net.IPAddress.Parse("207.215.227.0"), }, { System.Net.IPAddress.Parse("126.154.14.101"), System.Net.IPAddress.Parse("216.67.6.248"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("187.218.17.36"), System.Net.IPAddress.Parse("238.124.205.57"), }, { System.Net.IPAddress.Parse("121.58.65.45"), System.Net.IPAddress.Parse("70.15.17.213"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 38,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("253.249.72.199"), System.Net.IPAddress.Parse("83.220.25.248"), }, { System.Net.IPAddress.Parse("24.211.32.155"), System.Net.IPAddress.Parse("53.59.27.85"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 44,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("167.133.236.33"), System.Net.IPAddress.Parse("170.227.180.85"), }, { System.Net.IPAddress.Parse("49.85.109.169"), System.Net.IPAddress.Parse("77.32.246.89"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("107.128.252.240"), System.Net.IPAddress.Parse("80.82.187.124"), }, { System.Net.IPAddress.Parse("139.199.124.39"), System.Net.IPAddress.Parse("149.248.173.40"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 43,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("223.252.116.88"), System.Net.IPAddress.Parse("55.222.107.167"), }, { System.Net.IPAddress.Parse("91.144.42.150"), System.Net.IPAddress.Parse("228.76.140.100"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 50,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("163.131.233.20"), System.Net.IPAddress.Parse("124.180.154.90"), }, { System.Net.IPAddress.Parse("31.250.244.180"), System.Net.IPAddress.Parse("48.37.52.140"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 44,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("58.115.41.77"), System.Net.IPAddress.Parse("55.188.5.125"), }, { System.Net.IPAddress.Parse("25.194.115.236"), System.Net.IPAddress.Parse("217.82.65.181"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 57,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("73.101.180.156"), System.Net.IPAddress.Parse("143.113.229.120"), }, { System.Net.IPAddress.Parse("252.215.23.39"), System.Net.IPAddress.Parse("51.125.140.213"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 52,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("10.74.106.250"), System.Net.IPAddress.Parse("201.37.212.144"), }, { System.Net.IPAddress.Parse("25.59.69.207"), System.Net.IPAddress.Parse("174.197.132.219"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 66,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("184.143.75.123"), System.Net.IPAddress.Parse("0.39.10.204"), }, { System.Net.IPAddress.Parse("164.21.98.156"), System.Net.IPAddress.Parse("244.88.212.202"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("20.248.105.14"), System.Net.IPAddress.Parse("225.22.232.51"), }, { System.Net.IPAddress.Parse("157.49.50.88"), System.Net.IPAddress.Parse("91.118.228.151"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 53,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("54.81.122.189"), System.Net.IPAddress.Parse("26.119.249.8"), }, { System.Net.IPAddress.Parse("52.43.63.165"), System.Net.IPAddress.Parse("128.203.222.45"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 75,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("51.130.70.158"), System.Net.IPAddress.Parse("55.84.170.203"), }, { System.Net.IPAddress.Parse("162.221.145.50"), System.Net.IPAddress.Parse("212.111.151.54"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("198.82.128.226"), System.Net.IPAddress.Parse("100.183.248.87"), }, { System.Net.IPAddress.Parse("244.222.157.127"), System.Net.IPAddress.Parse("14.239.132.254"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 61,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("102.112.212.241"), System.Net.IPAddress.Parse("71.92.33.121"), }, { System.Net.IPAddress.Parse("198.196.101.235"), System.Net.IPAddress.Parse("89.114.59.128"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 83,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("222.178.100.81"), System.Net.IPAddress.Parse("219.210.248.219"), }, { System.Net.IPAddress.Parse("106.96.213.218"), System.Net.IPAddress.Parse("104.134.159.75"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("21.175.166.10"), System.Net.IPAddress.Parse("228.250.147.102"), }, { System.Net.IPAddress.Parse("124.253.46.138"), System.Net.IPAddress.Parse("108.129.62.237"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 62,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("246.249.239.143"), System.Net.IPAddress.Parse("87.101.123.80"), }, { System.Net.IPAddress.Parse("178.203.140.149"), System.Net.IPAddress.Parse("75.24.22.177"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 84,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("94.119.79.27"), System.Net.IPAddress.Parse("206.88.188.116"), }, { System.Net.IPAddress.Parse("19.30.78.91"), System.Net.IPAddress.Parse("212.152.206.38"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("200.105.97.213"), System.Net.IPAddress.Parse("186.181.31.217"), }, { System.Net.IPAddress.Parse("221.209.211.177"), System.Net.IPAddress.Parse("47.138.205.154"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 64,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("74.131.91.253"), System.Net.IPAddress.Parse("137.44.15.235"), }, { System.Net.IPAddress.Parse("8.88.158.161"), System.Net.IPAddress.Parse("242.113.137.20"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 88,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("96.33.57.99"), System.Net.IPAddress.Parse("21.174.8.156"), }, { System.Net.IPAddress.Parse("54.92.178.147"), System.Net.IPAddress.Parse("215.233.147.51"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("157.117.116.88"), System.Net.IPAddress.Parse("99.90.188.23"), }, { System.Net.IPAddress.Parse("203.231.212.147"), System.Net.IPAddress.Parse("69.172.214.191"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 67,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("168.61.230.120"), System.Net.IPAddress.Parse("6.32.112.14"), }, { System.Net.IPAddress.Parse("191.14.73.138"), System.Net.IPAddress.Parse("68.164.173.3"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 91,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("146.44.71.127"), System.Net.IPAddress.Parse("117.123.136.249"), }, { System.Net.IPAddress.Parse("53.33.206.17"), System.Net.IPAddress.Parse("95.188.18.78"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("46.199.14.114"), System.Net.IPAddress.Parse("192.99.141.187"), }, { System.Net.IPAddress.Parse("17.105.182.26"), System.Net.IPAddress.Parse("128.78.72.107"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("184.147.116.19"), System.Net.IPAddress.Parse("234.216.85.111"), }, { System.Net.IPAddress.Parse("150.6.85.79"), System.Net.IPAddress.Parse("103.81.42.243"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 72,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("191.64.150.160"), System.Net.IPAddress.Parse("40.45.172.222"), }, { System.Net.IPAddress.Parse("83.246.146.241"), System.Net.IPAddress.Parse("109.159.27.252"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 97,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("226.33.201.78"), System.Net.IPAddress.Parse("99.138.30.171"), }, { System.Net.IPAddress.Parse("17.111.184.68"), System.Net.IPAddress.Parse("93.26.173.129"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 81,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("0.197.153.250"), System.Net.IPAddress.Parse("118.66.116.161"), }, { System.Net.IPAddress.Parse("182.124.17.139"), System.Net.IPAddress.Parse("9.12.96.27"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 104,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("27.145.160.48"), System.Net.IPAddress.Parse("202.100.136.36"), }, { System.Net.IPAddress.Parse("134.223.98.102"), System.Net.IPAddress.Parse("117.94.204.152"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("70.117.64.158"), System.Net.IPAddress.Parse("26.66.164.166"), }, { System.Net.IPAddress.Parse("157.147.149.40"), System.Net.IPAddress.Parse("27.81.249.129"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("191.15.29.51"), System.Net.IPAddress.Parse("143.8.113.63"), }, { System.Net.IPAddress.Parse("158.9.73.187"), System.Net.IPAddress.Parse("127.238.1.58"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 84,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("145.5.243.208"), System.Net.IPAddress.Parse("52.38.151.42"), }, { System.Net.IPAddress.Parse("73.153.253.233"), System.Net.IPAddress.Parse("74.236.178.63"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 105,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("90.24.221.203"), System.Net.IPAddress.Parse("119.37.218.194"), }, { System.Net.IPAddress.Parse("5.65.207.135"), System.Net.IPAddress.Parse("142.212.186.97"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("198.61.151.63"), System.Net.IPAddress.Parse("54.173.170.186"), }, { System.Net.IPAddress.Parse("183.71.253.102"), System.Net.IPAddress.Parse("158.111.210.43"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 92,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("71.69.25.24"), System.Net.IPAddress.Parse("67.172.118.230"), }, { System.Net.IPAddress.Parse("231.174.250.235"), System.Net.IPAddress.Parse("229.152.55.123"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 111,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("72.93.163.251"), System.Net.IPAddress.Parse("58.34.115.174"), }, { System.Net.IPAddress.Parse("204.173.69.10"), System.Net.IPAddress.Parse("197.23.31.27"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("14.240.20.9"), System.Net.IPAddress.Parse("181.252.141.2"), }, { System.Net.IPAddress.Parse("252.193.217.173"), System.Net.IPAddress.Parse("242.197.230.106"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 100,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("23.235.102.103"), System.Net.IPAddress.Parse("43.82.198.226"), }, { System.Net.IPAddress.Parse("45.15.100.160"), System.Net.IPAddress.Parse("168.18.47.226"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 116,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("225.66.228.123"), System.Net.IPAddress.Parse("60.13.54.234"), }, { System.Net.IPAddress.Parse("98.90.8.119"), System.Net.IPAddress.Parse("110.173.244.20"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("86.88.3.233"), System.Net.IPAddress.Parse("37.90.49.42"), }, { System.Net.IPAddress.Parse("102.235.191.188"), System.Net.IPAddress.Parse("121.108.216.41"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 107,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("88.227.114.222"), System.Net.IPAddress.Parse("41.205.199.211"), }, { System.Net.IPAddress.Parse("21.161.27.78"), System.Net.IPAddress.Parse("5.90.44.213"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 119,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("88.64.54.203"), System.Net.IPAddress.Parse("242.101.142.49"), }, { System.Net.IPAddress.Parse("230.50.137.168"), System.Net.IPAddress.Parse("115.207.94.120"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("137.151.169.216"), System.Net.IPAddress.Parse("185.138.68.141"), }, { System.Net.IPAddress.Parse("71.141.68.111"), System.Net.IPAddress.Parse("33.54.189.5"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 111,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("214.223.215.122"), System.Net.IPAddress.Parse("94.192.83.155"), }, { System.Net.IPAddress.Parse("113.26.153.184"), System.Net.IPAddress.Parse("148.205.11.126"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 126,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("143.158.30.48"), System.Net.IPAddress.Parse("29.141.225.181"), }, { System.Net.IPAddress.Parse("206.183.69.145"), System.Net.IPAddress.Parse("49.126.145.118"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("90.251.222.200"), System.Net.IPAddress.Parse("237.178.184.143"), }, { System.Net.IPAddress.Parse("80.75.162.126"), System.Net.IPAddress.Parse("110.135.25.58"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 119,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("135.212.244.17"), System.Net.IPAddress.Parse("49.147.11.46"), }, { System.Net.IPAddress.Parse("115.70.164.54"), System.Net.IPAddress.Parse("159.108.250.94"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 134,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("87.112.131.109"), System.Net.IPAddress.Parse("35.190.245.232"), }, { System.Net.IPAddress.Parse("197.84.80.90"), System.Net.IPAddress.Parse("66.33.96.205"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("188.234.159.229"), System.Net.IPAddress.Parse("219.81.69.87"), }, { System.Net.IPAddress.Parse("167.144.49.35"), System.Net.IPAddress.Parse("104.72.47.174"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 120,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("44.102.112.163"), System.Net.IPAddress.Parse("17.138.243.197"), }, { System.Net.IPAddress.Parse("46.119.1.14"), System.Net.IPAddress.Parse("254.96.160.186"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 141,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("56.188.7.173"), System.Net.IPAddress.Parse("88.62.60.251"), }, { System.Net.IPAddress.Parse("45.49.207.124"), System.Net.IPAddress.Parse("16.90.75.203"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("246.254.124.133"), System.Net.IPAddress.Parse("64.81.165.121"), }, { System.Net.IPAddress.Parse("167.236.220.231"), System.Net.IPAddress.Parse("93.115.55.218"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 128,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("178.232.74.194"), System.Net.IPAddress.Parse("48.151.226.105"), }, { System.Net.IPAddress.Parse("22.98.62.230"), System.Net.IPAddress.Parse("115.77.114.83"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 144,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("45.4.167.158"), System.Net.IPAddress.Parse("31.113.237.194"), }, { System.Net.IPAddress.Parse("238.123.170.191"), System.Net.IPAddress.Parse("219.152.192.28"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("47.238.104.101"), System.Net.IPAddress.Parse("198.168.173.30"), }, { System.Net.IPAddress.Parse("233.202.252.153"), System.Net.IPAddress.Parse("19.7.100.190"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 135,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("184.27.172.116"), System.Net.IPAddress.Parse("174.33.189.135"), }, { System.Net.IPAddress.Parse("248.138.70.240"), System.Net.IPAddress.Parse("233.144.216.201"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 147,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("101.108.223.21"), System.Net.IPAddress.Parse("228.186.53.170"), }, { System.Net.IPAddress.Parse("165.177.155.174"), System.Net.IPAddress.Parse("235.27.11.154"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("170.111.110.162"), System.Net.IPAddress.Parse("1.235.137.234"), }, { System.Net.IPAddress.Parse("106.242.136.8"), System.Net.IPAddress.Parse("241.133.154.66"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 137,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("52.112.182.249"), System.Net.IPAddress.Parse("39.70.197.90"), }, { System.Net.IPAddress.Parse("193.253.52.96"), System.Net.IPAddress.Parse("248.58.86.129"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 151,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("241.210.14.135"), System.Net.IPAddress.Parse("114.61.183.25"), }, { System.Net.IPAddress.Parse("44.57.87.66"), System.Net.IPAddress.Parse("234.11.38.191"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 139,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("181.132.187.25"), System.Net.IPAddress.Parse("126.68.190.22"), }, { System.Net.IPAddress.Parse("253.139.106.131"), System.Net.IPAddress.Parse("156.127.112.18"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 159,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("192.243.29.155"), System.Net.IPAddress.Parse("103.19.94.214"), }, { System.Net.IPAddress.Parse("175.242.172.69"), System.Net.IPAddress.Parse("128.191.167.234"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("53.160.61.140"), System.Net.IPAddress.Parse("162.184.176.197"), }, { System.Net.IPAddress.Parse("105.181.37.254"), System.Net.IPAddress.Parse("232.187.10.215"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 145,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("226.41.79.9"), System.Net.IPAddress.Parse("124.211.193.244"), }, { System.Net.IPAddress.Parse("217.132.10.186"), System.Net.IPAddress.Parse("124.168.254.212"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 163,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("38.204.248.1"), System.Net.IPAddress.Parse("40.240.117.175"), }, { System.Net.IPAddress.Parse("163.114.59.79"), System.Net.IPAddress.Parse("231.115.108.246"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("253.43.147.226"), System.Net.IPAddress.Parse("171.213.243.138"), }, { System.Net.IPAddress.Parse("45.40.6.140"), System.Net.IPAddress.Parse("211.131.155.111"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 150,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("209.126.196.239"), System.Net.IPAddress.Parse("239.192.73.83"), }, { System.Net.IPAddress.Parse("19.217.104.181"), System.Net.IPAddress.Parse("104.252.198.54"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 165,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("119.1.9.143"), System.Net.IPAddress.Parse("187.42.222.76"), }, { System.Net.IPAddress.Parse("64.6.11.87"), System.Net.IPAddress.Parse("78.184.53.166"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("112.226.35.110"), System.Net.IPAddress.Parse("201.155.119.91"), }, { System.Net.IPAddress.Parse("182.245.221.53"), System.Net.IPAddress.Parse("214.222.53.233"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("246.236.216.159"), System.Net.IPAddress.Parse("91.43.219.35"), }, { System.Net.IPAddress.Parse("1.187.70.171"), System.Net.IPAddress.Parse("35.215.62.122"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 153,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("147.19.88.5"), System.Net.IPAddress.Parse("33.205.198.44"), }, { System.Net.IPAddress.Parse("54.130.154.133"), System.Net.IPAddress.Parse("135.4.102.241"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 169,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("148.207.24.158"), System.Net.IPAddress.Parse("121.126.126.42"), }, { System.Net.IPAddress.Parse("248.7.141.175"), System.Net.IPAddress.Parse("68.9.100.145"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("191.31.61.175"), System.Net.IPAddress.Parse("175.79.170.212"), }, { System.Net.IPAddress.Parse("96.117.15.31"), System.Net.IPAddress.Parse("90.78.145.137"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 154,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("31.192.114.29"), System.Net.IPAddress.Parse("134.227.60.51"), }, { System.Net.IPAddress.Parse("162.170.26.220"), System.Net.IPAddress.Parse("206.14.214.2"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 174,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("219.204.134.228"), System.Net.IPAddress.Parse("32.201.209.194"), }, { System.Net.IPAddress.Parse("55.28.89.77"), System.Net.IPAddress.Parse("110.245.180.213"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("241.3.98.64"), System.Net.IPAddress.Parse("5.73.100.157"), }, { System.Net.IPAddress.Parse("10.148.218.114"), System.Net.IPAddress.Parse("133.56.73.170"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 155,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("7.220.95.102"), System.Net.IPAddress.Parse("56.222.110.129"), }, { System.Net.IPAddress.Parse("74.164.77.198"), System.Net.IPAddress.Parse("87.230.122.66"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 175,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("137.92.135.76"), System.Net.IPAddress.Parse("100.90.229.219"), }, { System.Net.IPAddress.Parse("86.116.150.16"), System.Net.IPAddress.Parse("212.55.169.85"), }, },
    NullableValue = null,
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

