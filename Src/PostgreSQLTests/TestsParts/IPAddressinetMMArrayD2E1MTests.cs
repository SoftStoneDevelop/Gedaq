

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
    Id = 9,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("171.162.127.233"), System.Net.IPAddress.Parse("9.8.108.89"), }, { System.Net.IPAddress.Parse("37.190.209.60"), System.Net.IPAddress.Parse("93.123.133.139"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("75.248.66.110"), System.Net.IPAddress.Parse("12.129.110.193"), }, { System.Net.IPAddress.Parse("46.188.247.195"), System.Net.IPAddress.Parse("18.106.173.220"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 13,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("245.129.46.242"), System.Net.IPAddress.Parse("130.182.135.213"), }, { System.Net.IPAddress.Parse("224.25.129.202"), System.Net.IPAddress.Parse("227.196.138.87"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 7,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("73.70.39.91"), System.Net.IPAddress.Parse("97.57.183.204"), }, { System.Net.IPAddress.Parse("218.119.34.139"), System.Net.IPAddress.Parse("68.216.152.148"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("98.112.1.184"), System.Net.IPAddress.Parse("235.237.60.36"), }, { System.Net.IPAddress.Parse("152.5.160.67"), System.Net.IPAddress.Parse("195.148.187.202"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("3.16.100.203"), System.Net.IPAddress.Parse("67.132.136.244"), }, { System.Net.IPAddress.Parse("168.215.96.83"), System.Net.IPAddress.Parse("41.156.51.154"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 15,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("211.105.98.230"), System.Net.IPAddress.Parse("34.155.160.39"), }, { System.Net.IPAddress.Parse("230.16.22.51"), System.Net.IPAddress.Parse("42.113.232.18"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("184.30.40.185"), System.Net.IPAddress.Parse("235.252.216.165"), }, { System.Net.IPAddress.Parse("116.246.65.114"), System.Net.IPAddress.Parse("156.212.21.209"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 20,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("254.63.17.87"), System.Net.IPAddress.Parse("227.37.185.187"), }, { System.Net.IPAddress.Parse("92.2.119.153"), System.Net.IPAddress.Parse("14.20.105.9"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 10,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("143.247.154.142"), System.Net.IPAddress.Parse("203.244.60.141"), }, { System.Net.IPAddress.Parse("97.174.84.173"), System.Net.IPAddress.Parse("229.76.146.127"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 29,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("155.66.195.172"), System.Net.IPAddress.Parse("206.129.66.238"), }, { System.Net.IPAddress.Parse("33.134.141.120"), System.Net.IPAddress.Parse("10.182.10.15"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("251.232.107.106"), System.Net.IPAddress.Parse("89.109.69.115"), }, { System.Net.IPAddress.Parse("205.93.233.47"), System.Net.IPAddress.Parse("113.154.59.55"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 31,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("60.215.194.175"), System.Net.IPAddress.Parse("116.14.82.44"), }, { System.Net.IPAddress.Parse("44.236.21.98"), System.Net.IPAddress.Parse("59.200.5.164"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 14,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("0.177.187.61"), System.Net.IPAddress.Parse("37.33.189.139"), }, { System.Net.IPAddress.Parse("177.237.118.13"), System.Net.IPAddress.Parse("98.175.219.222"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("51.220.45.217"), System.Net.IPAddress.Parse("68.224.81.84"), }, { System.Net.IPAddress.Parse("215.51.95.64"), System.Net.IPAddress.Parse("173.84.123.58"), }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 36,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("78.164.228.15"), System.Net.IPAddress.Parse("196.28.152.56"), }, { System.Net.IPAddress.Parse("162.197.113.184"), System.Net.IPAddress.Parse("245.233.99.55"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 41,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("109.95.217.248"), System.Net.IPAddress.Parse("237.181.234.124"), }, { System.Net.IPAddress.Parse("136.134.0.68"), System.Net.IPAddress.Parse("80.118.31.248"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 17,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("235.212.128.44"), System.Net.IPAddress.Parse("201.82.136.123"), }, { System.Net.IPAddress.Parse("198.125.63.49"), System.Net.IPAddress.Parse("240.154.171.242"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("205.225.143.30"), System.Net.IPAddress.Parse("155.35.15.205"), }, { System.Net.IPAddress.Parse("133.48.162.52"), System.Net.IPAddress.Parse("139.42.243.217"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 42,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("0.56.125.205"), System.Net.IPAddress.Parse("150.146.113.141"), }, { System.Net.IPAddress.Parse("79.179.250.70"), System.Net.IPAddress.Parse("123.139.118.71"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 44,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("127.56.85.237"), System.Net.IPAddress.Parse("59.206.98.235"), }, { System.Net.IPAddress.Parse("153.177.189.38"), System.Net.IPAddress.Parse("22.236.74.77"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 18,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("103.237.141.42"), System.Net.IPAddress.Parse("142.86.138.109"), }, { System.Net.IPAddress.Parse("65.212.98.20"), System.Net.IPAddress.Parse("143.17.35.91"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("74.249.37.123"), System.Net.IPAddress.Parse("121.185.193.2"), }, { System.Net.IPAddress.Parse("91.227.68.153"), System.Net.IPAddress.Parse("249.66.105.86"), }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 52,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("43.141.20.189"), System.Net.IPAddress.Parse("69.200.30.122"), }, { System.Net.IPAddress.Parse("244.246.51.212"), System.Net.IPAddress.Parse("11.80.109.112"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("213.0.215.121"), System.Net.IPAddress.Parse("171.54.81.185"), }, { System.Net.IPAddress.Parse("236.177.216.61"), System.Net.IPAddress.Parse("91.171.242.120"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 58,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("170.23.62.91"), System.Net.IPAddress.Parse("112.47.152.9"), }, { System.Net.IPAddress.Parse("243.229.203.159"), System.Net.IPAddress.Parse("235.17.131.39"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 21,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("3.170.220.122"), System.Net.IPAddress.Parse("253.68.134.244"), }, { System.Net.IPAddress.Parse("203.236.217.142"), System.Net.IPAddress.Parse("49.57.41.191"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("73.82.174.87"), System.Net.IPAddress.Parse("112.141.245.133"), }, { System.Net.IPAddress.Parse("36.118.80.179"), System.Net.IPAddress.Parse("85.121.170.151"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("2.6.35.228"), System.Net.IPAddress.Parse("28.142.249.41"), }, { System.Net.IPAddress.Parse("171.103.152.201"), System.Net.IPAddress.Parse("16.44.119.211"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 63,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("138.33.109.50"), System.Net.IPAddress.Parse("98.180.132.81"), }, { System.Net.IPAddress.Parse("248.167.11.126"), System.Net.IPAddress.Parse("199.139.106.173"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 66,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("26.91.185.123"), System.Net.IPAddress.Parse("175.26.58.90"), }, { System.Net.IPAddress.Parse("230.140.13.33"), System.Net.IPAddress.Parse("166.139.80.180"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("50.137.15.228"), System.Net.IPAddress.Parse("118.192.169.52"), }, { System.Net.IPAddress.Parse("253.114.121.139"), System.Net.IPAddress.Parse("223.158.98.78"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("13.130.69.91"), System.Net.IPAddress.Parse("137.6.199.62"), }, { System.Net.IPAddress.Parse("198.176.195.240"), System.Net.IPAddress.Parse("25.132.91.222"), }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 74,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("16.143.23.108"), System.Net.IPAddress.Parse("78.254.26.80"), }, { System.Net.IPAddress.Parse("250.94.224.157"), System.Net.IPAddress.Parse("159.198.45.40"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("129.180.128.237"), System.Net.IPAddress.Parse("111.119.75.193"), }, { System.Net.IPAddress.Parse("106.115.157.13"), System.Net.IPAddress.Parse("21.170.76.61"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 81,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("59.60.56.140"), System.Net.IPAddress.Parse("150.77.48.41"), }, { System.Net.IPAddress.Parse("2.14.96.32"), System.Net.IPAddress.Parse("118.213.154.58"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 25,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("248.25.161.143"), System.Net.IPAddress.Parse("3.6.0.105"), }, { System.Net.IPAddress.Parse("137.37.193.55"), System.Net.IPAddress.Parse("82.195.186.223"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 82,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("64.62.112.123"), System.Net.IPAddress.Parse("149.23.115.210"), }, { System.Net.IPAddress.Parse("13.21.225.139"), System.Net.IPAddress.Parse("118.117.80.113"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("14.73.154.204"), System.Net.IPAddress.Parse("36.47.183.28"), }, { System.Net.IPAddress.Parse("116.167.87.86"), System.Net.IPAddress.Parse("94.118.225.67"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 89,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("45.210.166.246"), System.Net.IPAddress.Parse("192.55.113.37"), }, { System.Net.IPAddress.Parse("172.18.153.241"), System.Net.IPAddress.Parse("232.15.121.220"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 33,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("49.200.25.173"), System.Net.IPAddress.Parse("104.5.62.32"), }, { System.Net.IPAddress.Parse("162.228.223.77"), System.Net.IPAddress.Parse("65.230.195.19"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("201.169.59.67"), System.Net.IPAddress.Parse("181.98.203.128"), }, { System.Net.IPAddress.Parse("101.46.90.201"), System.Net.IPAddress.Parse("218.85.3.48"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 98,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("232.138.163.110"), System.Net.IPAddress.Parse("113.144.159.21"), }, { System.Net.IPAddress.Parse("79.44.140.34"), System.Net.IPAddress.Parse("201.192.187.237"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("151.236.13.148"), System.Net.IPAddress.Parse("227.162.150.238"), }, { System.Net.IPAddress.Parse("83.181.240.178"), System.Net.IPAddress.Parse("249.34.212.153"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 103,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("102.19.192.97"), System.Net.IPAddress.Parse("36.205.125.54"), }, { System.Net.IPAddress.Parse("58.56.105.74"), System.Net.IPAddress.Parse("168.225.245.158"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 42,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("57.8.95.193"), System.Net.IPAddress.Parse("69.171.47.185"), }, { System.Net.IPAddress.Parse("194.234.74.73"), System.Net.IPAddress.Parse("173.29.166.144"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("51.154.176.63"), System.Net.IPAddress.Parse("52.124.92.160"), }, { System.Net.IPAddress.Parse("17.132.254.73"), System.Net.IPAddress.Parse("175.208.86.68"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 107,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("16.225.180.35"), System.Net.IPAddress.Parse("6.21.143.227"), }, { System.Net.IPAddress.Parse("70.244.15.117"), System.Net.IPAddress.Parse("240.39.25.1"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 111,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("149.117.87.143"), System.Net.IPAddress.Parse("46.252.247.178"), }, { System.Net.IPAddress.Parse("9.57.230.254"), System.Net.IPAddress.Parse("190.30.254.154"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 45,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("101.169.237.138"), System.Net.IPAddress.Parse("10.175.121.46"), }, { System.Net.IPAddress.Parse("223.15.17.115"), System.Net.IPAddress.Parse("148.116.206.118"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("37.141.236.13"), System.Net.IPAddress.Parse("111.167.142.133"), }, { System.Net.IPAddress.Parse("168.192.105.146"), System.Net.IPAddress.Parse("198.254.41.157"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 113,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("164.14.106.41"), System.Net.IPAddress.Parse("60.111.245.168"), }, { System.Net.IPAddress.Parse("24.130.25.65"), System.Net.IPAddress.Parse("61.163.78.245"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 121,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("49.76.59.147"), System.Net.IPAddress.Parse("5.177.15.12"), }, { System.Net.IPAddress.Parse("1.30.108.165"), System.Net.IPAddress.Parse("5.41.21.25"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 46,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("57.135.142.92"), System.Net.IPAddress.Parse("178.164.248.4"), }, { System.Net.IPAddress.Parse("144.207.219.127"), System.Net.IPAddress.Parse("131.201.197.235"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("129.207.198.42"), System.Net.IPAddress.Parse("48.120.6.226"), }, { System.Net.IPAddress.Parse("198.113.103.117"), System.Net.IPAddress.Parse("103.94.3.49"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("226.62.146.206"), System.Net.IPAddress.Parse("228.209.126.95"), }, { System.Net.IPAddress.Parse("165.245.129.84"), System.Net.IPAddress.Parse("38.3.53.67"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 126,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("144.15.106.92"), System.Net.IPAddress.Parse("211.45.209.73"), }, { System.Net.IPAddress.Parse("134.156.67.67"), System.Net.IPAddress.Parse("110.159.9.206"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 127,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("217.175.81.57"), System.Net.IPAddress.Parse("32.195.1.175"), }, { System.Net.IPAddress.Parse("206.88.133.98"), System.Net.IPAddress.Parse("145.165.140.41"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 53,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("203.160.38.4"), System.Net.IPAddress.Parse("69.81.137.22"), }, { System.Net.IPAddress.Parse("247.74.151.238"), System.Net.IPAddress.Parse("205.58.4.32"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("146.66.108.75"), System.Net.IPAddress.Parse("46.45.52.225"), }, { System.Net.IPAddress.Parse("142.187.248.167"), System.Net.IPAddress.Parse("165.81.223.204"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 132,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("206.130.225.60"), System.Net.IPAddress.Parse("185.131.244.147"), }, { System.Net.IPAddress.Parse("123.240.83.242"), System.Net.IPAddress.Parse("118.122.105.110"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 136,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("3.74.232.185"), System.Net.IPAddress.Parse("154.233.172.227"), }, { System.Net.IPAddress.Parse("241.55.116.212"), System.Net.IPAddress.Parse("207.42.193.105"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("182.32.130.57"), System.Net.IPAddress.Parse("190.194.55.52"), }, { System.Net.IPAddress.Parse("20.75.11.245"), System.Net.IPAddress.Parse("128.118.164.62"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("84.204.236.6"), System.Net.IPAddress.Parse("119.135.228.55"), }, { System.Net.IPAddress.Parse("104.121.164.122"), System.Net.IPAddress.Parse("60.48.30.151"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 144,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("113.53.68.142"), System.Net.IPAddress.Parse("249.25.150.122"), }, { System.Net.IPAddress.Parse("87.44.187.48"), System.Net.IPAddress.Parse("17.103.93.30"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("119.125.146.227"), System.Net.IPAddress.Parse("43.241.215.23"), }, { System.Net.IPAddress.Parse("89.84.222.154"), System.Net.IPAddress.Parse("39.77.246.143"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 150,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("19.183.87.190"), System.Net.IPAddress.Parse("111.188.140.246"), }, { System.Net.IPAddress.Parse("110.220.45.189"), System.Net.IPAddress.Parse("217.32.6.6"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 59,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("195.78.189.165"), System.Net.IPAddress.Parse("66.2.226.244"), }, { System.Net.IPAddress.Parse("42.40.117.114"), System.Net.IPAddress.Parse("107.60.242.28"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("47.106.206.183"), System.Net.IPAddress.Parse("222.101.226.159"), }, { System.Net.IPAddress.Parse("31.136.121.221"), System.Net.IPAddress.Parse("142.195.4.152"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 153,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("43.70.13.135"), System.Net.IPAddress.Parse("178.183.151.236"), }, { System.Net.IPAddress.Parse("154.175.207.71"), System.Net.IPAddress.Parse("111.35.121.180"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("113.164.34.223"), System.Net.IPAddress.Parse("152.32.200.84"), }, { System.Net.IPAddress.Parse("187.123.251.60"), System.Net.IPAddress.Parse("48.69.174.28"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 162,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("187.143.228.25"), System.Net.IPAddress.Parse("135.84.96.66"), }, { System.Net.IPAddress.Parse("51.113.242.30"), System.Net.IPAddress.Parse("158.167.201.11"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 68,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("48.146.199.81"), System.Net.IPAddress.Parse("139.65.250.40"), }, { System.Net.IPAddress.Parse("26.156.224.36"), System.Net.IPAddress.Parse("164.127.142.58"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("147.203.204.68"), System.Net.IPAddress.Parse("80.104.66.59"), }, { System.Net.IPAddress.Parse("28.210.117.233"), System.Net.IPAddress.Parse("111.144.36.90"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("179.73.211.49"), System.Net.IPAddress.Parse("231.119.195.19"), }, { System.Net.IPAddress.Parse("244.148.139.227"), System.Net.IPAddress.Parse("207.60.155.252"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 164,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("134.190.159.112"), System.Net.IPAddress.Parse("13.39.24.144"), }, { System.Net.IPAddress.Parse("188.159.52.19"), System.Net.IPAddress.Parse("158.199.72.251"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 172,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("182.5.234.52"), System.Net.IPAddress.Parse("229.57.136.40"), }, { System.Net.IPAddress.Parse("95.147.148.21"), System.Net.IPAddress.Parse("234.67.124.11"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 69,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("117.254.245.32"), System.Net.IPAddress.Parse("69.109.249.39"), }, { System.Net.IPAddress.Parse("116.50.16.251"), System.Net.IPAddress.Parse("142.81.167.58"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("104.212.163.85"), System.Net.IPAddress.Parse("50.78.221.137"), }, { System.Net.IPAddress.Parse("12.102.232.97"), System.Net.IPAddress.Parse("249.98.63.34"), }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 179,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("193.138.88.62"), System.Net.IPAddress.Parse("195.33.100.66"), }, { System.Net.IPAddress.Parse("32.88.35.153"), System.Net.IPAddress.Parse("226.100.124.178"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("140.211.64.8"), System.Net.IPAddress.Parse("80.245.115.61"), }, { System.Net.IPAddress.Parse("93.226.184.244"), System.Net.IPAddress.Parse("76.167.24.137"), }, },
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
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("251.232.107.106"), System.Net.IPAddress.Parse("89.109.69.115"), }, { System.Net.IPAddress.Parse("205.93.233.47"), System.Net.IPAddress.Parse("113.154.59.55"), }, }));
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
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("205.225.143.30"), System.Net.IPAddress.Parse("155.35.15.205"), }, { System.Net.IPAddress.Parse("133.48.162.52"), System.Net.IPAddress.Parse("139.42.243.217"), }, }));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("213.0.215.121"), System.Net.IPAddress.Parse("171.54.81.185"), }, { System.Net.IPAddress.Parse("236.177.216.61"), System.Net.IPAddress.Parse("91.171.242.120"), }, }));
                nullable = await ((IIPAddressMArrayinetMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("2.6.35.228"), System.Net.IPAddress.Parse("28.142.249.41"), }, { System.Net.IPAddress.Parse("171.103.152.201"), System.Net.IPAddress.Parse("16.44.119.211"), }, }));
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[18],_testData[34], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
                        Assert.That(models, Has.Count.EqualTo(34));

                        IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
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
                await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 127, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
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
                await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 41, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
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
                 ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 63, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 136, query1, 13, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 132, query1, 66, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
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
                await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 150, query1, 98, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[15],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 121, query1, 63, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
                 ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 42, query1, 13, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 36, 13))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 107, 42))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                ((IIPAddressMArrayinetMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 52);
                var models = await ((IIPAddressMArrayinetMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressMArrayinetMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressMArrayinetMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 74);
                var models =  ((IIPAddressMArrayinetMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
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

