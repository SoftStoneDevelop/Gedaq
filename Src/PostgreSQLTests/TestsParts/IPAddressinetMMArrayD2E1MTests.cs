

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
    internal partial interface IIPAddressMArrayinetMMArrayD2
    {
    }
    
    internal partial class IPAddressMArrayinetMMArrayD2 : IIPAddressMArrayinetMMArrayD2
    {


#region TestData

        private readonly IPAddressinetMMArrayD2E1M[] _testData = new IPAddressinetMMArrayD2E1M[]
        {
            new IPAddressinetMMArrayD2E1M
{
    Id = 1,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("141.202.229.245"), System.Net.IPAddress.Parse("237.216.132.227"), }, { System.Net.IPAddress.Parse("97.0.69.41"), System.Net.IPAddress.Parse("43.9.166.3"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 7,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("43.5.213.77"), System.Net.IPAddress.Parse("134.143.34.56"), }, { System.Net.IPAddress.Parse("154.69.15.207"), System.Net.IPAddress.Parse("248.63.36.73"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 2,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("172.56.107.69"), System.Net.IPAddress.Parse("175.29.147.82"), }, { System.Net.IPAddress.Parse("117.53.182.228"), System.Net.IPAddress.Parse("41.77.185.54"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("150.22.45.24"), System.Net.IPAddress.Parse("144.112.142.152"), }, { System.Net.IPAddress.Parse("203.230.174.209"), System.Net.IPAddress.Parse("104.163.243.208"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("1.82.228.73"), System.Net.IPAddress.Parse("154.158.230.140"), }, { System.Net.IPAddress.Parse("251.217.39.208"), System.Net.IPAddress.Parse("243.229.111.157"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 10,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("185.103.25.172"), System.Net.IPAddress.Parse("25.12.0.249"), }, { System.Net.IPAddress.Parse("80.41.222.194"), System.Net.IPAddress.Parse("122.5.187.243"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 19,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("174.141.23.157"), System.Net.IPAddress.Parse("71.188.20.242"), }, { System.Net.IPAddress.Parse("187.18.239.189"), System.Net.IPAddress.Parse("175.184.130.120"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("65.108.97.16"), System.Net.IPAddress.Parse("11.23.64.166"), }, { System.Net.IPAddress.Parse("43.180.113.231"), System.Net.IPAddress.Parse("56.254.90.25"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("195.25.122.139"), System.Net.IPAddress.Parse("232.160.166.142"), }, { System.Net.IPAddress.Parse("206.125.67.240"), System.Net.IPAddress.Parse("220.107.135.23"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 25,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("174.253.130.212"), System.Net.IPAddress.Parse("127.55.120.183"), }, { System.Net.IPAddress.Parse("92.1.2.63"), System.Net.IPAddress.Parse("151.65.7.242"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("190.117.163.190"), System.Net.IPAddress.Parse("72.219.96.49"), }, { System.Net.IPAddress.Parse("124.10.219.149"), System.Net.IPAddress.Parse("170.251.67.110"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 26,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("172.218.19.113"), System.Net.IPAddress.Parse("14.196.72.55"), }, { System.Net.IPAddress.Parse("18.243.133.190"), System.Net.IPAddress.Parse("214.167.182.85"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 15,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("134.227.195.125"), System.Net.IPAddress.Parse("54.175.88.149"), }, { System.Net.IPAddress.Parse("81.200.34.162"), System.Net.IPAddress.Parse("246.12.54.181"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 28,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("39.110.95.172"), System.Net.IPAddress.Parse("183.24.167.245"), }, { System.Net.IPAddress.Parse("178.142.77.17"), System.Net.IPAddress.Parse("123.121.78.244"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 29,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("130.183.177.236"), System.Net.IPAddress.Parse("241.36.95.173"), }, { System.Net.IPAddress.Parse("225.188.184.114"), System.Net.IPAddress.Parse("232.29.110.210"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 16,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("56.13.95.110"), System.Net.IPAddress.Parse("205.155.38.72"), }, { System.Net.IPAddress.Parse("222.153.238.57"), System.Net.IPAddress.Parse("123.88.122.254"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("61.243.63.155"), System.Net.IPAddress.Parse("180.186.109.131"), }, { System.Net.IPAddress.Parse("16.164.121.53"), System.Net.IPAddress.Parse("113.67.82.123"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("56.132.16.235"), System.Net.IPAddress.Parse("142.175.173.184"), }, { System.Net.IPAddress.Parse("233.206.97.235"), System.Net.IPAddress.Parse("245.53.158.156"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 30,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("8.72.232.189"), System.Net.IPAddress.Parse("249.240.76.93"), }, { System.Net.IPAddress.Parse("161.241.181.163"), System.Net.IPAddress.Parse("39.144.142.66"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 38,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("123.94.146.177"), System.Net.IPAddress.Parse("35.163.120.155"), }, { System.Net.IPAddress.Parse("131.207.77.139"), System.Net.IPAddress.Parse("173.61.241.107"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 17,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("217.48.47.160"), System.Net.IPAddress.Parse("42.107.242.111"), }, { System.Net.IPAddress.Parse("170.1.72.124"), System.Net.IPAddress.Parse("199.61.52.149"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("146.3.132.100"), System.Net.IPAddress.Parse("117.67.227.109"), }, { System.Net.IPAddress.Parse("77.211.208.75"), System.Net.IPAddress.Parse("158.13.40.192"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("212.90.29.132"), System.Net.IPAddress.Parse("106.60.116.209"), }, { System.Net.IPAddress.Parse("68.140.131.121"), System.Net.IPAddress.Parse("109.169.100.121"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 43,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("102.100.124.183"), System.Net.IPAddress.Parse("250.220.5.114"), }, { System.Net.IPAddress.Parse("138.160.139.101"), System.Net.IPAddress.Parse("217.189.194.130"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 51,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("37.27.214.187"), System.Net.IPAddress.Parse("88.18.174.62"), }, { System.Net.IPAddress.Parse("80.211.2.244"), System.Net.IPAddress.Parse("163.237.166.225"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 19,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("140.251.177.67"), System.Net.IPAddress.Parse("109.21.108.246"), }, { System.Net.IPAddress.Parse("125.19.21.94"), System.Net.IPAddress.Parse("0.201.174.204"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 57,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("52.136.130.149"), System.Net.IPAddress.Parse("249.227.57.17"), }, { System.Net.IPAddress.Parse("73.108.23.34"), System.Net.IPAddress.Parse("66.42.5.159"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("159.239.172.180"), System.Net.IPAddress.Parse("41.252.12.132"), }, { System.Net.IPAddress.Parse("20.101.62.17"), System.Net.IPAddress.Parse("31.43.136.209"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 59,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("235.181.135.137"), System.Net.IPAddress.Parse("161.147.221.28"), }, { System.Net.IPAddress.Parse("81.82.248.178"), System.Net.IPAddress.Parse("167.47.60.132"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 22,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("232.176.80.151"), System.Net.IPAddress.Parse("241.3.84.92"), }, { System.Net.IPAddress.Parse("70.171.99.116"), System.Net.IPAddress.Parse("175.1.10.92"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("156.177.39.140"), System.Net.IPAddress.Parse("242.223.60.130"), }, { System.Net.IPAddress.Parse("138.119.60.10"), System.Net.IPAddress.Parse("143.86.227.94"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 65,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("25.224.157.247"), System.Net.IPAddress.Parse("21.237.133.110"), }, { System.Net.IPAddress.Parse("17.140.201.119"), System.Net.IPAddress.Parse("241.246.160.5"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("120.182.145.104"), System.Net.IPAddress.Parse("161.63.45.151"), }, { System.Net.IPAddress.Parse("194.211.19.233"), System.Net.IPAddress.Parse("250.137.192.60"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 69,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("210.35.83.195"), System.Net.IPAddress.Parse("7.116.53.144"), }, { System.Net.IPAddress.Parse("142.129.172.58"), System.Net.IPAddress.Parse("43.136.71.39"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 25,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("234.11.79.7"), System.Net.IPAddress.Parse("154.20.221.155"), }, { System.Net.IPAddress.Parse("130.242.213.57"), System.Net.IPAddress.Parse("55.63.241.23"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("11.172.208.219"), System.Net.IPAddress.Parse("124.20.168.240"), }, { System.Net.IPAddress.Parse("53.157.92.141"), System.Net.IPAddress.Parse("202.213.151.247"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 73,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("233.241.220.22"), System.Net.IPAddress.Parse("215.67.179.169"), }, { System.Net.IPAddress.Parse("46.149.163.100"), System.Net.IPAddress.Parse("63.189.200.41"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 79,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("128.136.75.175"), System.Net.IPAddress.Parse("132.158.223.130"), }, { System.Net.IPAddress.Parse("92.98.52.95"), System.Net.IPAddress.Parse("138.28.170.232"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 30,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("75.91.83.116"), System.Net.IPAddress.Parse("63.176.141.54"), }, { System.Net.IPAddress.Parse("173.158.25.158"), System.Net.IPAddress.Parse("169.173.65.94"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 80,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("36.152.29.164"), System.Net.IPAddress.Parse("41.166.178.181"), }, { System.Net.IPAddress.Parse("122.89.81.13"), System.Net.IPAddress.Parse("245.116.162.83"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("187.211.150.22"), System.Net.IPAddress.Parse("62.31.223.144"), }, { System.Net.IPAddress.Parse("59.132.216.194"), System.Net.IPAddress.Parse("248.146.253.209"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 84,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("56.226.61.234"), System.Net.IPAddress.Parse("64.89.236.182"), }, { System.Net.IPAddress.Parse("226.2.7.126"), System.Net.IPAddress.Parse("30.9.218.10"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 38,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("40.205.246.202"), System.Net.IPAddress.Parse("61.220.250.21"), }, { System.Net.IPAddress.Parse("172.30.92.117"), System.Net.IPAddress.Parse("238.142.196.26"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 86,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("164.70.217.75"), System.Net.IPAddress.Parse("235.190.170.100"), }, { System.Net.IPAddress.Parse("154.219.186.84"), System.Net.IPAddress.Parse("204.156.32.164"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 93,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("79.43.90.51"), System.Net.IPAddress.Parse("127.82.223.206"), }, { System.Net.IPAddress.Parse("191.35.13.208"), System.Net.IPAddress.Parse("25.112.222.176"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 39,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("78.100.49.167"), System.Net.IPAddress.Parse("248.188.73.134"), }, { System.Net.IPAddress.Parse("18.48.3.114"), System.Net.IPAddress.Parse("57.31.175.0"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("95.199.31.1"), System.Net.IPAddress.Parse("108.157.233.28"), }, { System.Net.IPAddress.Parse("54.179.122.122"), System.Net.IPAddress.Parse("199.188.52.146"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("99.172.91.120"), System.Net.IPAddress.Parse("126.69.239.207"), }, { System.Net.IPAddress.Parse("213.93.245.2"), System.Net.IPAddress.Parse("198.157.164.216"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 96,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("34.96.23.24"), System.Net.IPAddress.Parse("219.166.20.56"), }, { System.Net.IPAddress.Parse("161.225.4.61"), System.Net.IPAddress.Parse("28.23.113.172"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 104,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("221.139.0.222"), System.Net.IPAddress.Parse("77.25.51.53"), }, { System.Net.IPAddress.Parse("100.228.188.226"), System.Net.IPAddress.Parse("143.66.233.162"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 44,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("105.77.94.48"), System.Net.IPAddress.Parse("206.194.37.63"), }, { System.Net.IPAddress.Parse("114.141.59.184"), System.Net.IPAddress.Parse("118.27.123.104"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 105,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("251.10.95.102"), System.Net.IPAddress.Parse("235.134.249.198"), }, { System.Net.IPAddress.Parse("134.3.4.242"), System.Net.IPAddress.Parse("194.58.135.21"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 112,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("44.110.141.8"), System.Net.IPAddress.Parse("165.111.202.81"), }, { System.Net.IPAddress.Parse("156.90.176.219"), System.Net.IPAddress.Parse("185.111.93.55"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 51,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("46.4.246.51"), System.Net.IPAddress.Parse("212.205.125.24"), }, { System.Net.IPAddress.Parse("75.205.165.48"), System.Net.IPAddress.Parse("234.8.105.149"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("53.38.52.167"), System.Net.IPAddress.Parse("59.127.237.62"), }, { System.Net.IPAddress.Parse("2.234.144.114"), System.Net.IPAddress.Parse("191.67.131.206"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("158.42.182.25"), System.Net.IPAddress.Parse("2.95.30.97"), }, { System.Net.IPAddress.Parse("115.21.211.152"), System.Net.IPAddress.Parse("186.182.177.151"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 113,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("200.104.100.0"), System.Net.IPAddress.Parse("11.123.220.40"), }, { System.Net.IPAddress.Parse("180.192.133.122"), System.Net.IPAddress.Parse("207.186.125.248"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 116,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("163.230.227.131"), System.Net.IPAddress.Parse("254.232.66.193"), }, { System.Net.IPAddress.Parse("131.48.140.214"), System.Net.IPAddress.Parse("185.36.7.130"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 58,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("108.88.99.83"), System.Net.IPAddress.Parse("180.250.0.45"), }, { System.Net.IPAddress.Parse("167.72.12.118"), System.Net.IPAddress.Parse("16.240.198.39"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 120,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("121.160.37.195"), System.Net.IPAddress.Parse("7.125.180.79"), }, { System.Net.IPAddress.Parse("133.92.95.95"), System.Net.IPAddress.Parse("209.128.58.65"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("249.214.95.241"), System.Net.IPAddress.Parse("8.172.240.102"), }, { System.Net.IPAddress.Parse("138.71.161.203"), System.Net.IPAddress.Parse("42.245.216.69"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 125,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("197.215.248.133"), System.Net.IPAddress.Parse("93.104.150.175"), }, { System.Net.IPAddress.Parse("11.232.221.15"), System.Net.IPAddress.Parse("99.62.60.232"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 66,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("217.139.0.86"), System.Net.IPAddress.Parse("177.156.35.153"), }, { System.Net.IPAddress.Parse("20.252.1.91"), System.Net.IPAddress.Parse("81.79.7.27"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("187.224.25.212"), System.Net.IPAddress.Parse("233.231.61.88"), }, { System.Net.IPAddress.Parse("150.57.83.250"), System.Net.IPAddress.Parse("10.117.253.163"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 133,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("65.32.176.113"), System.Net.IPAddress.Parse("190.187.106.23"), }, { System.Net.IPAddress.Parse("198.67.3.174"), System.Net.IPAddress.Parse("34.103.208.194"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("62.233.249.22"), System.Net.IPAddress.Parse("220.21.148.245"), }, { System.Net.IPAddress.Parse("62.243.77.249"), System.Net.IPAddress.Parse("155.146.148.206"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 136,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("89.30.126.248"), System.Net.IPAddress.Parse("246.233.56.144"), }, { System.Net.IPAddress.Parse("95.221.113.251"), System.Net.IPAddress.Parse("194.155.210.107"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 68,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("136.5.67.74"), System.Net.IPAddress.Parse("40.64.108.179"), }, { System.Net.IPAddress.Parse("84.227.205.159"), System.Net.IPAddress.Parse("14.213.188.230"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("239.84.11.170"), System.Net.IPAddress.Parse("118.70.68.186"), }, { System.Net.IPAddress.Parse("138.81.228.238"), System.Net.IPAddress.Parse("171.115.85.144"), }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 143,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("74.77.228.163"), System.Net.IPAddress.Parse("93.206.92.105"), }, { System.Net.IPAddress.Parse("164.162.219.57"), System.Net.IPAddress.Parse("8.253.74.118"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 148,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("100.126.58.120"), System.Net.IPAddress.Parse("28.201.162.80"), }, { System.Net.IPAddress.Parse("13.67.124.204"), System.Net.IPAddress.Parse("225.62.240.74"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 69,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("203.108.248.26"), System.Net.IPAddress.Parse("143.146.30.240"), }, { System.Net.IPAddress.Parse("60.130.41.191"), System.Net.IPAddress.Parse("221.95.180.214"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 154,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("57.241.212.224"), System.Net.IPAddress.Parse("74.114.175.102"), }, { System.Net.IPAddress.Parse("126.243.179.56"), System.Net.IPAddress.Parse("233.116.204.60"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("167.36.198.98"), System.Net.IPAddress.Parse("159.171.191.13"), }, { System.Net.IPAddress.Parse("39.75.226.29"), System.Net.IPAddress.Parse("235.75.181.20"), }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmmarrayd2e1mi(
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmmarrayd2e1mi(
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
            queryMapTypes: [typeof(IPAddressinetMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,]), 
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

                changedRows =  ((IIPAddressMArrayinetMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IIPAddressMArrayinetMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IIPAddressMArrayinetMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IIPAddressMArrayinetMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    ipaddressinetmmarrayd2e1mi_id
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "ipaddressinetmmarrayd2e1mi_id", 
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
                changedRows =  ((IIPAddressMArrayinetMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IIPAddressMArrayinetMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    ipaddressinetmmarrayd2e1mi_id
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
    ipaddressinetmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(IPAddressinetMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
                System.Net.IPAddress[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[,]>();
                    ((NpgsqlParameter<System.Net.IPAddress[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((IIPAddressMArrayinetMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("190.117.163.190"), System.Net.IPAddress.Parse("72.219.96.49"), }, { System.Net.IPAddress.Parse("124.10.219.149"), System.Net.IPAddress.Parse("170.251.67.110"), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[,]>();
                    ((NpgsqlParameter<System.Net.IPAddress[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((IIPAddressMArrayinetMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Net.IPAddress[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[,]>();
                    ((NpgsqlParameter<System.Net.IPAddress[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((IIPAddressMArrayinetMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[,]>();
                    ((NpgsqlParameter<System.Net.IPAddress[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((IIPAddressMArrayinetMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("56.132.16.235"), System.Net.IPAddress.Parse("142.175.173.184"), }, { System.Net.IPAddress.Parse("233.206.97.235"), System.Net.IPAddress.Parse("245.53.158.156"), }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    ipaddressinetmmarrayd2e1mi_id
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
    ipaddressinetmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(IPAddressinetMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "ipaddressinetmmarrayd2e1mi_id", 
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
                System.Net.IPAddress[,] nullable = null;
                nullable =  ((IIPAddressMArrayinetMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IIPAddressMArrayinetMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("212.90.29.132"), System.Net.IPAddress.Parse("106.60.116.209"), }, { System.Net.IPAddress.Parse("68.140.131.121"), System.Net.IPAddress.Parse("109.169.100.121"), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Net.IPAddress[,] nullable = null;
                nullable = await ((IIPAddressMArrayinetMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IIPAddressMArrayinetMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetMMArrayD2E1M> models = null;

                models =  ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetMMArrayD2E1M> models = null;

                models = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IIPAddressMArrayinetMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD2E1M), typeof(FlatIPAddressinetMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                await ((IIPAddressMArrayinetMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                ((IIPAddressMArrayinetMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IIPAddressMArrayinetMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IIPAddressMArrayinetMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd2e1m m
LEFT JOIN public.ipaddressinetmmarrayd2e1mi mi ON mi.id = m.ipaddressinetmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinetMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
                var models = await ((IIPAddressMArrayinetMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IIPAddressMArrayinetMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD2E1M), typeof(FlatIPAddressinetMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                await ((IIPAddressMArrayinetMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                ((IIPAddressMArrayinetMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IIPAddressMArrayinetMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressMArrayinetMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd2e1m m
LEFT JOIN public.ipaddressinetmmarrayd2e1mi mi ON mi.id = m.ipaddressinetmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(IPAddressinetMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
                var models = await ((IIPAddressMArrayinetMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IIPAddressMArrayinetMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD2E1M), typeof(FlatIPAddressinetMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                await((IIPAddressMArrayinetMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
FROM public.ipaddressinetmmarrayd2e1m m
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 73;
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
FROM public.ipaddressinetmmarrayd2e1m m
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
FROM public.ipaddressinetmmarrayd2e1m m
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                 ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
FROM public.ipaddressinetmmarrayd2e1m m
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                 ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IIPAddressMArrayinetMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetmmarrayd2e1m m
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetmmarrayd2e1m m
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetmmarrayd2e1m m
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetmmarrayd2e1m m
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                 ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd2e1m m
LEFT JOIN public.ipaddressinetmmarrayd2e1mi mi ON mi.id = m.ipaddressinetmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinetMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
                var models = await((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
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
                var models = ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD2E1M), typeof(FlatIPAddressinetMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                await((IIPAddressMArrayinetMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd2e1m m
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 93, query1, 59, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd2e1m m
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 120, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd2e1m m
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                 ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 69, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd2e1m m
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                 ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 113, query1, 29, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IIPAddressMArrayinetMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd2e1m m
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 73, query1, 112, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd2e1m m
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 93, query1, 51, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd2e1m m
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 133, query1, 79, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd2e1m m
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
FROM public.ipaddressinetmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD2E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD2E1M>();
                 ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 112, query1, 79, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd2e1m m
LEFT JOIN public.ipaddressinetmmarrayd2e1mi mi ON mi.id = m.ipaddressinetmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(IPAddressinetMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
                var models = await((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 73, 143))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
                var models = ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 69, 84))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
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
                await using var cmd = await ((IIPAddressMArrayinetMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IIPAddressMArrayinetMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 116);
                var models = await ((IIPAddressMArrayinetMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressMArrayinetMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressMArrayinetMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 96);
                var models =  ((IIPAddressMArrayinetMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
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
FROM public.binary_ipaddressinetmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(IPAddressinetMMArrayD2E1MIWA),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressMArrayinetMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinetmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IIPAddressMArrayinetMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressMArrayinetMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinetmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressMArrayinetMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(IPAddressinetMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressMArrayinetMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinetmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IIPAddressMArrayinetMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressMArrayinetMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinetmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressMArrayinetMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(IPAddressinetMMArrayD2E1MI),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IIPAddressMArrayinetMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IIPAddressMArrayinetMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IIPAddressMArrayinetMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IIPAddressMArrayinetMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(IPAddressinetMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressMArrayinetMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IIPAddressMArrayinetMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressMArrayinetMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IIPAddressMArrayinetMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
ipaddressinetmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(IPAddressinetMMArrayD2E1M),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2))]
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
FROM public.binary_ipaddressinetmmarrayd2e1m m
LEFT JOIN public.binary_ipaddressinetmmarrayd2e1mi mi ON mi.id = m.ipaddressinetmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(IPAddressinetMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IIPAddressMArrayinetMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IIPAddressMArrayinetMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    IPAddressinetMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IIPAddressMArrayinetMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IIPAddressMArrayinetMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    IPAddressinetMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    ipaddressinetmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(IPAddressinetMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
                var models =  ((IIPAddressMArrayinetMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    IPAddressinetMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressMArrayinetMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    IPAddressinetMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD2E1MIWA), typeof(IPAddressinetMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
                var models1 = new List<IPAddressinetMMArrayD2E1MIWA>();
                var models2 = new List<IPAddressinetMMArrayD2E1MIWA>();
                await ((IIPAddressMArrayinetMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetMMArrayD2E1MIWA>();
                var models2 = new List<IPAddressinetMMArrayD2E1MIWA>();
                ((IIPAddressMArrayinetMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
                var models = await ((IIPAddressMArrayinetMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_ipaddressinetmmarrayd2e1mi
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
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressMArrayinetMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_ipaddressinetmmarrayd2e1mi
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
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD2E1MIWA), typeof(IPAddressinetMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2))]
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
                var models1 = new List<IPAddressinetMMArrayD2E1MIWA>();
                var models2 = new List<IPAddressinetMMArrayD2E1MIWA>();
                await ((IIPAddressMArrayinetMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetMMArrayD2E1MIWA>();
                var models2 = new List<IPAddressinetMMArrayD2E1MIWA>();
                ((IIPAddressMArrayinetMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2))]
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
                var models = await ((IIPAddressMArrayinetMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_ipaddressinetmmarrayd2e1mi
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
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressMArrayinetMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_ipaddressinetmmarrayd2e1mi
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
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_ipaddressinetmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD2E1MI), typeof(IPAddressinetMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
                var models1 = new List<IPAddressinetMMArrayD2E1MI>();
                var models2 = new List<IPAddressinetMMArrayD2E1MI>();
                await ((IIPAddressMArrayinetMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetMMArrayD2E1MI>();
                var models2 = new List<IPAddressinetMMArrayD2E1MI>();
                ((IIPAddressMArrayinetMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2)),
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
                var models = await ((IIPAddressMArrayinetMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressMArrayinetMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_ipaddressinetmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD2E1MIWA), typeof(IPAddressinetMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2))]
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
                var models1 = new List<IPAddressinetMMArrayD2E1MIWA>();
                var models2 = new List<IPAddressinetMMArrayD2E1MIWA>();
                await ((IIPAddressMArrayinetMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetMMArrayD2E1MIWA>();
                var models2 = new List<IPAddressinetMMArrayD2E1MIWA>();
                ((IIPAddressMArrayinetMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD2))]
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
                var models = await ((IIPAddressMArrayinetMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressMArrayinetMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

