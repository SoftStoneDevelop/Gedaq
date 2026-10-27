

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
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("126.9.138.234"), System.Net.IPAddress.Parse("69.213.203.46"), }, { System.Net.IPAddress.Parse("94.48.2.242"), System.Net.IPAddress.Parse("47.210.161.127"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 3,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("78.93.219.121"), System.Net.IPAddress.Parse("58.127.244.33"), }, { System.Net.IPAddress.Parse("189.219.14.117"), System.Net.IPAddress.Parse("145.24.224.243"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("55.240.180.7"), System.Net.IPAddress.Parse("48.93.110.214"), }, { System.Net.IPAddress.Parse("159.237.225.21"), System.Net.IPAddress.Parse("11.42.91.110"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("67.149.28.7"), System.Net.IPAddress.Parse("191.180.210.55"), }, { System.Net.IPAddress.Parse("231.137.106.112"), System.Net.IPAddress.Parse("217.99.116.138"), }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 8,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("198.103.147.208"), System.Net.IPAddress.Parse("107.80.28.149"), }, { System.Net.IPAddress.Parse("234.207.52.139"), System.Net.IPAddress.Parse("131.186.196.13"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 9,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("222.92.118.249"), System.Net.IPAddress.Parse("124.6.162.167"), }, { System.Net.IPAddress.Parse("33.165.191.41"), System.Net.IPAddress.Parse("38.179.211.151"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 17,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("131.136.100.254"), System.Net.IPAddress.Parse("230.75.48.95"), }, { System.Net.IPAddress.Parse("146.80.130.214"), System.Net.IPAddress.Parse("18.179.213.195"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("6.250.1.209"), System.Net.IPAddress.Parse("36.233.223.205"), }, { System.Net.IPAddress.Parse("38.215.128.18"), System.Net.IPAddress.Parse("202.87.211.179"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 15,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("104.167.124.187"), System.Net.IPAddress.Parse("195.7.225.19"), }, { System.Net.IPAddress.Parse("108.188.126.249"), System.Net.IPAddress.Parse("130.105.155.214"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("126.207.232.248"), System.Net.IPAddress.Parse("243.186.145.211"), }, { System.Net.IPAddress.Parse("150.59.66.51"), System.Net.IPAddress.Parse("73.63.196.186"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 22,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("140.248.139.96"), System.Net.IPAddress.Parse("232.30.137.140"), }, { System.Net.IPAddress.Parse("99.143.12.218"), System.Net.IPAddress.Parse("143.141.152.219"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 22,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("176.18.15.42"), System.Net.IPAddress.Parse("130.82.34.9"), }, { System.Net.IPAddress.Parse("236.58.61.71"), System.Net.IPAddress.Parse("3.44.25.113"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("222.57.139.221"), System.Net.IPAddress.Parse("213.104.150.20"), }, { System.Net.IPAddress.Parse("171.103.241.118"), System.Net.IPAddress.Parse("115.120.63.18"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 25,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("7.7.215.246"), System.Net.IPAddress.Parse("199.146.186.107"), }, { System.Net.IPAddress.Parse("48.45.172.133"), System.Net.IPAddress.Parse("57.23.211.189"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("98.209.123.77"), System.Net.IPAddress.Parse("84.252.32.125"), }, { System.Net.IPAddress.Parse("201.154.238.167"), System.Net.IPAddress.Parse("6.53.186.46"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 28,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("199.30.142.139"), System.Net.IPAddress.Parse("214.76.170.45"), }, { System.Net.IPAddress.Parse("74.23.89.167"), System.Net.IPAddress.Parse("135.220.240.231"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 30,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("126.116.94.111"), System.Net.IPAddress.Parse("31.176.12.24"), }, { System.Net.IPAddress.Parse("46.221.133.72"), System.Net.IPAddress.Parse("227.212.166.150"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("225.100.192.87"), System.Net.IPAddress.Parse("235.97.21.56"), }, { System.Net.IPAddress.Parse("37.128.233.118"), System.Net.IPAddress.Parse("103.21.183.172"), }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 33,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("59.169.50.62"), System.Net.IPAddress.Parse("61.216.57.132"), }, { System.Net.IPAddress.Parse("230.89.129.218"), System.Net.IPAddress.Parse("126.85.163.80"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 38,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("147.120.147.115"), System.Net.IPAddress.Parse("27.153.193.209"), }, { System.Net.IPAddress.Parse("125.7.86.252"), System.Net.IPAddress.Parse("35.24.226.55"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 34,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("39.119.89.177"), System.Net.IPAddress.Parse("241.71.127.138"), }, { System.Net.IPAddress.Parse("244.144.110.84"), System.Net.IPAddress.Parse("56.226.85.111"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 42,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("251.44.142.173"), System.Net.IPAddress.Parse("199.246.159.253"), }, { System.Net.IPAddress.Parse("227.138.23.85"), System.Net.IPAddress.Parse("236.235.70.14"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 51,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("133.235.212.238"), System.Net.IPAddress.Parse("145.44.223.60"), }, { System.Net.IPAddress.Parse("115.209.232.155"), System.Net.IPAddress.Parse("21.216.29.39"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 41,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("149.119.56.43"), System.Net.IPAddress.Parse("36.237.74.188"), }, { System.Net.IPAddress.Parse("98.62.188.50"), System.Net.IPAddress.Parse("116.234.191.153"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("139.73.18.51"), System.Net.IPAddress.Parse("8.149.5.94"), }, { System.Net.IPAddress.Parse("149.144.180.241"), System.Net.IPAddress.Parse("28.103.205.4"), }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 55,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("174.122.235.159"), System.Net.IPAddress.Parse("119.75.79.80"), }, { System.Net.IPAddress.Parse("203.90.118.107"), System.Net.IPAddress.Parse("124.245.61.52"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("3.170.148.40"), System.Net.IPAddress.Parse("174.62.102.77"), }, { System.Net.IPAddress.Parse("88.52.215.8"), System.Net.IPAddress.Parse("149.147.23.103"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 57,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("217.122.139.33"), System.Net.IPAddress.Parse("139.93.219.235"), }, { System.Net.IPAddress.Parse("148.151.22.186"), System.Net.IPAddress.Parse("67.3.83.145"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 47,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("103.203.118.96"), System.Net.IPAddress.Parse("57.250.33.76"), }, { System.Net.IPAddress.Parse("101.217.200.149"), System.Net.IPAddress.Parse("231.187.213.163"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("245.76.240.178"), System.Net.IPAddress.Parse("77.205.232.183"), }, { System.Net.IPAddress.Parse("2.149.174.227"), System.Net.IPAddress.Parse("14.189.240.1"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("146.1.162.140"), System.Net.IPAddress.Parse("23.232.77.230"), }, { System.Net.IPAddress.Parse("52.106.247.190"), System.Net.IPAddress.Parse("209.233.2.57"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 61,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("242.176.175.206"), System.Net.IPAddress.Parse("115.244.219.68"), }, { System.Net.IPAddress.Parse("241.145.141.233"), System.Net.IPAddress.Parse("222.40.49.108"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 65,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("102.252.194.236"), System.Net.IPAddress.Parse("159.202.242.225"), }, { System.Net.IPAddress.Parse("136.158.116.75"), System.Net.IPAddress.Parse("76.1.44.117"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("245.205.224.2"), System.Net.IPAddress.Parse("123.215.29.152"), }, { System.Net.IPAddress.Parse("183.186.90.244"), System.Net.IPAddress.Parse("187.1.141.182"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 72,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("12.150.15.241"), System.Net.IPAddress.Parse("57.144.215.186"), }, { System.Net.IPAddress.Parse("183.102.4.195"), System.Net.IPAddress.Parse("64.188.126.202"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("126.105.115.28"), System.Net.IPAddress.Parse("234.142.201.182"), }, { System.Net.IPAddress.Parse("120.89.85.91"), System.Net.IPAddress.Parse("9.2.213.193"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 73,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("42.84.80.143"), System.Net.IPAddress.Parse("203.250.216.193"), }, { System.Net.IPAddress.Parse("171.74.234.168"), System.Net.IPAddress.Parse("230.115.95.31"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 53,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("183.118.142.6"), System.Net.IPAddress.Parse("47.80.229.191"), }, { System.Net.IPAddress.Parse("59.143.233.82"), System.Net.IPAddress.Parse("80.201.97.126"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 74,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("61.212.4.167"), System.Net.IPAddress.Parse("17.75.138.161"), }, { System.Net.IPAddress.Parse("205.123.179.190"), System.Net.IPAddress.Parse("246.133.30.149"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("237.219.28.167"), System.Net.IPAddress.Parse("120.75.218.22"), }, { System.Net.IPAddress.Parse("67.206.64.127"), System.Net.IPAddress.Parse("176.47.98.186"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 82,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("144.176.96.20"), System.Net.IPAddress.Parse("198.73.19.152"), }, { System.Net.IPAddress.Parse("217.105.83.13"), System.Net.IPAddress.Parse("202.62.130.144"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 62,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("190.12.211.53"), System.Net.IPAddress.Parse("156.56.124.248"), }, { System.Net.IPAddress.Parse("166.227.63.252"), System.Net.IPAddress.Parse("3.101.80.43"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("48.17.121.176"), System.Net.IPAddress.Parse("58.254.169.170"), }, { System.Net.IPAddress.Parse("246.209.93.79"), System.Net.IPAddress.Parse("136.157.112.219"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 88,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("15.218.108.174"), System.Net.IPAddress.Parse("164.79.20.125"), }, { System.Net.IPAddress.Parse("139.107.128.179"), System.Net.IPAddress.Parse("64.165.158.102"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 96,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("184.66.214.68"), System.Net.IPAddress.Parse("196.197.116.86"), }, { System.Net.IPAddress.Parse("151.161.184.139"), System.Net.IPAddress.Parse("230.64.48.110"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("170.252.189.224"), System.Net.IPAddress.Parse("214.146.230.79"), }, { System.Net.IPAddress.Parse("147.152.169.213"), System.Net.IPAddress.Parse("131.185.226.30"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 97,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("128.213.173.185"), System.Net.IPAddress.Parse("142.201.53.211"), }, { System.Net.IPAddress.Parse("161.169.209.191"), System.Net.IPAddress.Parse("96.0.127.162"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 106,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("19.162.9.210"), System.Net.IPAddress.Parse("247.25.63.27"), }, { System.Net.IPAddress.Parse("24.82.2.0"), System.Net.IPAddress.Parse("203.118.98.201"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 71,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("205.72.61.148"), System.Net.IPAddress.Parse("173.220.2.246"), }, { System.Net.IPAddress.Parse("205.94.77.54"), System.Net.IPAddress.Parse("238.138.68.85"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("197.142.208.31"), System.Net.IPAddress.Parse("24.195.105.174"), }, { System.Net.IPAddress.Parse("119.172.172.71"), System.Net.IPAddress.Parse("185.237.82.205"), }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 113,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("76.146.187.2"), System.Net.IPAddress.Parse("229.211.166.172"), }, { System.Net.IPAddress.Parse("253.7.201.221"), System.Net.IPAddress.Parse("182.63.226.254"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("173.244.138.96"), System.Net.IPAddress.Parse("100.35.68.101"), }, { System.Net.IPAddress.Parse("80.127.62.163"), System.Net.IPAddress.Parse("19.186.103.122"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 122,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("187.65.169.251"), System.Net.IPAddress.Parse("59.206.47.128"), }, { System.Net.IPAddress.Parse("202.135.18.66"), System.Net.IPAddress.Parse("131.252.193.244"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 79,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("75.207.98.188"), System.Net.IPAddress.Parse("176.139.202.125"), }, { System.Net.IPAddress.Parse("239.131.124.151"), System.Net.IPAddress.Parse("193.176.76.179"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("69.116.213.177"), System.Net.IPAddress.Parse("119.51.197.155"), }, { System.Net.IPAddress.Parse("217.86.88.96"), System.Net.IPAddress.Parse("81.85.53.233"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 123,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("232.189.68.186"), System.Net.IPAddress.Parse("153.92.72.121"), }, { System.Net.IPAddress.Parse("72.190.146.71"), System.Net.IPAddress.Parse("152.45.143.123"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 130,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("99.141.107.209"), System.Net.IPAddress.Parse("235.50.10.17"), }, { System.Net.IPAddress.Parse("47.228.101.81"), System.Net.IPAddress.Parse("192.78.248.98"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 85,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("35.142.232.58"), System.Net.IPAddress.Parse("83.131.14.239"), }, { System.Net.IPAddress.Parse("27.4.116.140"), System.Net.IPAddress.Parse("216.134.106.239"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 135,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("145.150.236.230"), System.Net.IPAddress.Parse("72.117.41.112"), }, { System.Net.IPAddress.Parse("21.209.146.194"), System.Net.IPAddress.Parse("180.31.32.153"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 137,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("108.66.51.5"), System.Net.IPAddress.Parse("100.165.126.82"), }, { System.Net.IPAddress.Parse("186.210.190.225"), System.Net.IPAddress.Parse("223.251.160.222"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 86,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("195.169.79.71"), System.Net.IPAddress.Parse("100.183.115.45"), }, { System.Net.IPAddress.Parse("226.89.69.42"), System.Net.IPAddress.Parse("6.135.76.13"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("242.239.184.25"), System.Net.IPAddress.Parse("180.127.209.120"), }, { System.Net.IPAddress.Parse("6.187.212.158"), System.Net.IPAddress.Parse("112.71.105.193"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 144,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("239.175.6.101"), System.Net.IPAddress.Parse("207.85.113.20"), }, { System.Net.IPAddress.Parse("43.130.156.3"), System.Net.IPAddress.Parse("98.174.174.125"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("32.38.34.162"), System.Net.IPAddress.Parse("252.61.177.44"), }, { System.Net.IPAddress.Parse("12.87.202.233"), System.Net.IPAddress.Parse("171.34.103.31"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 149,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("85.228.196.134"), System.Net.IPAddress.Parse("12.71.240.67"), }, { System.Net.IPAddress.Parse("200.124.69.43"), System.Net.IPAddress.Parse("192.178.124.154"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 87,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("236.15.231.121"), System.Net.IPAddress.Parse("232.192.16.41"), }, { System.Net.IPAddress.Parse("53.29.141.27"), System.Net.IPAddress.Parse("173.117.38.186"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("199.220.174.91"), System.Net.IPAddress.Parse("117.156.124.20"), }, { System.Net.IPAddress.Parse("198.129.220.178"), System.Net.IPAddress.Parse("150.78.230.252"), }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 156,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("143.160.178.87"), System.Net.IPAddress.Parse("166.22.214.135"), }, { System.Net.IPAddress.Parse("119.5.253.55"), System.Net.IPAddress.Parse("198.228.125.69"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("65.251.68.102"), System.Net.IPAddress.Parse("166.44.234.187"), }, { System.Net.IPAddress.Parse("249.65.205.113"), System.Net.IPAddress.Parse("42.84.5.55"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 161,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("252.90.247.207"), System.Net.IPAddress.Parse("95.35.25.11"), }, { System.Net.IPAddress.Parse("129.89.116.220"), System.Net.IPAddress.Parse("0.178.5.28"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 96,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("203.183.151.224"), System.Net.IPAddress.Parse("94.45.40.228"), }, { System.Net.IPAddress.Parse("64.98.247.112"), System.Net.IPAddress.Parse("177.238.184.238"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("236.72.189.225"), System.Net.IPAddress.Parse("220.44.30.3"), }, { System.Net.IPAddress.Parse("142.76.29.66"), System.Net.IPAddress.Parse("249.71.86.171"), }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 163,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("54.164.154.7"), System.Net.IPAddress.Parse("214.23.181.139"), }, { System.Net.IPAddress.Parse("233.158.161.210"), System.Net.IPAddress.Parse("208.14.161.179"), }, },
    ModelInner = null,
    NullableValue = null,
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
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("126.207.232.248"), System.Net.IPAddress.Parse("243.186.145.211"), }, { System.Net.IPAddress.Parse("150.59.66.51"), System.Net.IPAddress.Parse("73.63.196.186"), }, }));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("222.57.139.221"), System.Net.IPAddress.Parse("213.104.150.20"), }, { System.Net.IPAddress.Parse("171.103.241.118"), System.Net.IPAddress.Parse("115.120.63.18"), }, }));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("98.209.123.77"), System.Net.IPAddress.Parse("84.252.32.125"), }, { System.Net.IPAddress.Parse("201.154.238.167"), System.Net.IPAddress.Parse("6.53.186.46"), }, }));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[16],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
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
                parametr1.Value = 73;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[28],_testData[34], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[27],_testData[34], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 123, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
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
                await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 137, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
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
                 ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 22, query1, 149, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[34], false);
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
                 ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 123, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 74, query1, 137, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
                await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 15, query1, 22, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[28],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 122, query1, 57, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
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
                 ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 9, query1, 1, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 33, 122))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 38, 3))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
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
                ((IIPAddressMArrayinetMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 135);
                var models = await ((IIPAddressMArrayinetMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressMArrayinetMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressMArrayinetMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 25);
                var models =  ((IIPAddressMArrayinetMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
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

