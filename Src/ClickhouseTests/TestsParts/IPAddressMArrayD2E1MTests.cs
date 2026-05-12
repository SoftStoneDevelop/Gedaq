

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
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("49.101.196.195"), System.Net.IPAddress.Parse("3.41.192.186"), }, { System.Net.IPAddress.Parse("101.52.231.192"), System.Net.IPAddress.Parse("167.98.17.61"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 6,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("252.52.101.65"), System.Net.IPAddress.Parse("252.7.76.55"), }, { System.Net.IPAddress.Parse("145.109.212.107"), System.Net.IPAddress.Parse("208.100.251.144"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("9.165.218.112"), System.Net.IPAddress.Parse("157.109.202.167"), }, { System.Net.IPAddress.Parse("181.21.202.29"), System.Net.IPAddress.Parse("38.84.161.217"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("83.158.194.176"), System.Net.IPAddress.Parse("163.121.117.191"), }, { System.Net.IPAddress.Parse("64.17.230.12"), System.Net.IPAddress.Parse("65.7.108.151"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 10,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("163.77.43.87"), System.Net.IPAddress.Parse("139.197.151.53"), }, { System.Net.IPAddress.Parse("151.19.107.237"), System.Net.IPAddress.Parse("12.54.50.208"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 10,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("218.208.17.42"), System.Net.IPAddress.Parse("53.215.247.41"), }, { System.Net.IPAddress.Parse("66.1.128.207"), System.Net.IPAddress.Parse("249.94.185.227"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("248.45.72.213"), System.Net.IPAddress.Parse("43.81.16.227"), }, { System.Net.IPAddress.Parse("239.129.87.9"), System.Net.IPAddress.Parse("222.203.234.27"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("100.7.105.219"), System.Net.IPAddress.Parse("97.32.177.134"), }, { System.Net.IPAddress.Parse("66.247.179.24"), System.Net.IPAddress.Parse("133.118.50.229"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 14,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("11.75.209.32"), System.Net.IPAddress.Parse("235.123.52.134"), }, { System.Net.IPAddress.Parse("213.75.237.81"), System.Net.IPAddress.Parse("234.196.211.25"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 11,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("178.6.113.23"), System.Net.IPAddress.Parse("140.51.109.239"), }, { System.Net.IPAddress.Parse("99.6.239.122"), System.Net.IPAddress.Parse("250.178.218.205"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("40.161.188.159"), System.Net.IPAddress.Parse("230.237.224.117"), }, { System.Net.IPAddress.Parse("118.195.55.19"), System.Net.IPAddress.Parse("9.130.188.97"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("239.148.10.139"), System.Net.IPAddress.Parse("218.5.15.210"), }, { System.Net.IPAddress.Parse("17.113.214.9"), System.Net.IPAddress.Parse("107.254.194.98"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 23,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("186.117.209.129"), System.Net.IPAddress.Parse("233.40.181.77"), }, { System.Net.IPAddress.Parse("64.191.204.62"), System.Net.IPAddress.Parse("174.57.82.79"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 13,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("203.127.201.201"), System.Net.IPAddress.Parse("70.227.141.8"), }, { System.Net.IPAddress.Parse("0.242.1.34"), System.Net.IPAddress.Parse("138.122.144.187"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("98.230.7.195"), System.Net.IPAddress.Parse("47.145.69.48"), }, { System.Net.IPAddress.Parse("20.142.22.197"), System.Net.IPAddress.Parse("200.3.151.101"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 31,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("30.200.61.249"), System.Net.IPAddress.Parse("41.27.122.75"), }, { System.Net.IPAddress.Parse("224.215.232.228"), System.Net.IPAddress.Parse("84.250.12.112"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 18,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("204.225.149.43"), System.Net.IPAddress.Parse("26.179.191.99"), }, { System.Net.IPAddress.Parse("94.140.139.20"), System.Net.IPAddress.Parse("216.6.112.245"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("109.208.124.80"), System.Net.IPAddress.Parse("35.106.27.59"), }, { System.Net.IPAddress.Parse("27.71.248.128"), System.Net.IPAddress.Parse("218.242.243.188"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("90.60.100.186"), System.Net.IPAddress.Parse("201.194.115.129"), }, { System.Net.IPAddress.Parse("223.47.197.173"), System.Net.IPAddress.Parse("46.24.103.31"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 37,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("194.114.90.154"), System.Net.IPAddress.Parse("217.10.204.135"), }, { System.Net.IPAddress.Parse("113.46.88.152"), System.Net.IPAddress.Parse("43.127.222.27"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("89.47.18.162"), System.Net.IPAddress.Parse("74.23.24.225"), }, { System.Net.IPAddress.Parse("73.98.226.29"), System.Net.IPAddress.Parse("184.50.68.164"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("246.249.155.201"), System.Net.IPAddress.Parse("236.150.115.114"), }, { System.Net.IPAddress.Parse("188.210.56.184"), System.Net.IPAddress.Parse("214.117.32.21"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 45,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("191.206.15.236"), System.Net.IPAddress.Parse("251.30.91.109"), }, { System.Net.IPAddress.Parse("133.93.218.198"), System.Net.IPAddress.Parse("100.96.41.115"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 25,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("71.19.201.252"), System.Net.IPAddress.Parse("170.168.248.193"), }, { System.Net.IPAddress.Parse("237.116.31.101"), System.Net.IPAddress.Parse("112.72.117.205"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("224.172.13.180"), System.Net.IPAddress.Parse("167.173.57.8"), }, { System.Net.IPAddress.Parse("174.36.222.9"), System.Net.IPAddress.Parse("4.102.19.18"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 46,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("9.198.103.87"), System.Net.IPAddress.Parse("221.52.225.89"), }, { System.Net.IPAddress.Parse("121.37.133.223"), System.Net.IPAddress.Parse("149.65.147.92"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 27,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("50.64.24.143"), System.Net.IPAddress.Parse("12.8.230.10"), }, { System.Net.IPAddress.Parse("51.179.144.198"), System.Net.IPAddress.Parse("33.172.205.75"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("85.101.111.136"), System.Net.IPAddress.Parse("104.85.189.199"), }, { System.Net.IPAddress.Parse("0.227.46.211"), System.Net.IPAddress.Parse("235.40.236.162"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 55,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("217.27.146.168"), System.Net.IPAddress.Parse("117.42.173.205"), }, { System.Net.IPAddress.Parse("201.143.116.69"), System.Net.IPAddress.Parse("141.245.150.162"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 32,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("7.194.54.242"), System.Net.IPAddress.Parse("249.106.160.17"), }, { System.Net.IPAddress.Parse("125.106.211.152"), System.Net.IPAddress.Parse("233.213.87.142"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("8.219.27.140"), System.Net.IPAddress.Parse("203.65.85.167"), }, { System.Net.IPAddress.Parse("230.135.237.113"), System.Net.IPAddress.Parse("251.87.159.172"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 57,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("12.233.41.11"), System.Net.IPAddress.Parse("254.249.153.117"), }, { System.Net.IPAddress.Parse("143.212.201.26"), System.Net.IPAddress.Parse("94.132.215.19"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 37,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("129.7.112.214"), System.Net.IPAddress.Parse("52.140.0.31"), }, { System.Net.IPAddress.Parse("23.214.105.44"), System.Net.IPAddress.Parse("187.231.138.249"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 63,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("254.218.166.205"), System.Net.IPAddress.Parse("2.23.96.133"), }, { System.Net.IPAddress.Parse("49.191.33.133"), System.Net.IPAddress.Parse("89.139.133.129"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 44,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("134.99.114.93"), System.Net.IPAddress.Parse("9.95.167.117"), }, { System.Net.IPAddress.Parse("32.96.176.66"), System.Net.IPAddress.Parse("78.246.191.112"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("159.77.160.173"), System.Net.IPAddress.Parse("60.102.50.252"), }, { System.Net.IPAddress.Parse("245.8.182.24"), System.Net.IPAddress.Parse("118.234.22.8"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 70,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("122.63.129.250"), System.Net.IPAddress.Parse("247.76.66.21"), }, { System.Net.IPAddress.Parse("63.50.200.32"), System.Net.IPAddress.Parse("135.106.230.154"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 45,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("129.244.56.34"), System.Net.IPAddress.Parse("224.122.24.3"), }, { System.Net.IPAddress.Parse("22.230.205.218"), System.Net.IPAddress.Parse("202.31.86.127"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("31.167.193.120"), System.Net.IPAddress.Parse("93.243.123.157"), }, { System.Net.IPAddress.Parse("14.42.62.110"), System.Net.IPAddress.Parse("175.175.210.11"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 76,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("55.151.60.111"), System.Net.IPAddress.Parse("86.9.224.129"), }, { System.Net.IPAddress.Parse("151.248.103.137"), System.Net.IPAddress.Parse("205.41.21.234"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 47,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("241.219.244.141"), System.Net.IPAddress.Parse("60.184.209.168"), }, { System.Net.IPAddress.Parse("205.154.25.183"), System.Net.IPAddress.Parse("142.1.80.78"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("104.18.106.253"), System.Net.IPAddress.Parse("90.30.201.156"), }, { System.Net.IPAddress.Parse("60.55.176.140"), System.Net.IPAddress.Parse("48.237.241.203"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("44.172.153.161"), System.Net.IPAddress.Parse("128.34.148.249"), }, { System.Net.IPAddress.Parse("121.63.42.61"), System.Net.IPAddress.Parse("220.188.172.215"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 79,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("166.207.94.52"), System.Net.IPAddress.Parse("72.40.121.18"), }, { System.Net.IPAddress.Parse("153.178.168.157"), System.Net.IPAddress.Parse("41.250.140.37"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("185.23.222.194"), System.Net.IPAddress.Parse("64.201.15.112"), }, { System.Net.IPAddress.Parse("164.13.112.72"), System.Net.IPAddress.Parse("199.86.138.181"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("96.88.158.210"), System.Net.IPAddress.Parse("172.6.45.57"), }, { System.Net.IPAddress.Parse("92.108.157.123"), System.Net.IPAddress.Parse("146.96.133.24"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("14.102.243.204"), System.Net.IPAddress.Parse("186.116.4.65"), }, { System.Net.IPAddress.Parse("90.227.117.107"), System.Net.IPAddress.Parse("202.54.41.246"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 81,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("12.119.67.20"), System.Net.IPAddress.Parse("65.95.95.75"), }, { System.Net.IPAddress.Parse("57.241.144.74"), System.Net.IPAddress.Parse("157.180.109.158"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 59,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("183.242.139.32"), System.Net.IPAddress.Parse("22.152.160.169"), }, { System.Net.IPAddress.Parse("197.126.179.178"), System.Net.IPAddress.Parse("66.108.163.229"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("172.127.55.147"), System.Net.IPAddress.Parse("54.23.65.32"), }, { System.Net.IPAddress.Parse("249.6.71.48"), System.Net.IPAddress.Parse("78.133.41.112"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("28.33.22.46"), System.Net.IPAddress.Parse("170.2.46.41"), }, { System.Net.IPAddress.Parse("93.145.44.135"), System.Net.IPAddress.Parse("253.104.123.190"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 88,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("28.185.61.3"), System.Net.IPAddress.Parse("106.155.120.135"), }, { System.Net.IPAddress.Parse("97.170.26.141"), System.Net.IPAddress.Parse("30.129.74.108"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 64,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("149.42.5.160"), System.Net.IPAddress.Parse("174.79.128.93"), }, { System.Net.IPAddress.Parse("70.211.239.192"), System.Net.IPAddress.Parse("205.127.15.152"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 90,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("32.208.232.185"), System.Net.IPAddress.Parse("45.250.16.110"), }, { System.Net.IPAddress.Parse("108.85.4.7"), System.Net.IPAddress.Parse("11.56.200.165"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 71,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("134.184.138.211"), System.Net.IPAddress.Parse("108.58.219.116"), }, { System.Net.IPAddress.Parse("164.61.204.174"), System.Net.IPAddress.Parse("130.213.12.78"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("250.148.154.77"), System.Net.IPAddress.Parse("78.210.121.44"), }, { System.Net.IPAddress.Parse("25.64.170.66"), System.Net.IPAddress.Parse("252.102.31.187"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 94,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("185.1.34.165"), System.Net.IPAddress.Parse("171.225.135.114"), }, { System.Net.IPAddress.Parse("118.251.249.62"), System.Net.IPAddress.Parse("72.220.9.199"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 77,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("163.120.148.64"), System.Net.IPAddress.Parse("221.127.180.58"), }, { System.Net.IPAddress.Parse("9.70.118.21"), System.Net.IPAddress.Parse("168.29.159.10"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("234.145.35.97"), System.Net.IPAddress.Parse("7.73.208.48"), }, { System.Net.IPAddress.Parse("235.125.41.129"), System.Net.IPAddress.Parse("64.55.210.96"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 95,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("220.3.108.183"), System.Net.IPAddress.Parse("45.68.228.108"), }, { System.Net.IPAddress.Parse("175.132.26.169"), System.Net.IPAddress.Parse("183.243.92.90"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 83,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("68.175.141.1"), System.Net.IPAddress.Parse("22.14.179.210"), }, { System.Net.IPAddress.Parse("169.193.42.46"), System.Net.IPAddress.Parse("171.18.84.32"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("242.182.179.168"), System.Net.IPAddress.Parse("47.246.242.124"), }, { System.Net.IPAddress.Parse("47.100.250.231"), System.Net.IPAddress.Parse("161.76.244.49"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 100,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("124.51.246.42"), System.Net.IPAddress.Parse("153.199.148.54"), }, { System.Net.IPAddress.Parse("169.147.231.84"), System.Net.IPAddress.Parse("118.245.181.35"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 84,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("230.157.164.55"), System.Net.IPAddress.Parse("177.120.129.108"), }, { System.Net.IPAddress.Parse("1.174.45.63"), System.Net.IPAddress.Parse("249.144.75.139"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("41.223.42.234"), System.Net.IPAddress.Parse("50.95.97.28"), }, { System.Net.IPAddress.Parse("88.82.234.166"), System.Net.IPAddress.Parse("153.232.19.83"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 102,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("229.80.22.81"), System.Net.IPAddress.Parse("173.212.104.26"), }, { System.Net.IPAddress.Parse("94.208.224.234"), System.Net.IPAddress.Parse("73.68.253.199"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 93,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("106.204.148.169"), System.Net.IPAddress.Parse("251.126.162.93"), }, { System.Net.IPAddress.Parse("188.85.64.211"), System.Net.IPAddress.Parse("229.128.110.135"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("45.99.165.15"), System.Net.IPAddress.Parse("204.134.134.43"), }, { System.Net.IPAddress.Parse("157.23.247.203"), System.Net.IPAddress.Parse("176.169.184.53"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("233.229.40.199"), System.Net.IPAddress.Parse("63.8.244.158"), }, { System.Net.IPAddress.Parse("43.226.186.251"), System.Net.IPAddress.Parse("212.157.142.247"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 106,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("199.149.171.228"), System.Net.IPAddress.Parse("84.204.158.127"), }, { System.Net.IPAddress.Parse("179.125.19.202"), System.Net.IPAddress.Parse("159.17.15.89"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 102,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("52.251.155.111"), System.Net.IPAddress.Parse("201.72.229.90"), }, { System.Net.IPAddress.Parse("49.69.117.217"), System.Net.IPAddress.Parse("59.79.124.160"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 114,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("82.179.87.172"), System.Net.IPAddress.Parse("31.34.247.125"), }, { System.Net.IPAddress.Parse("137.150.43.45"), System.Net.IPAddress.Parse("87.125.57.98"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 103,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("17.15.42.143"), System.Net.IPAddress.Parse("45.105.203.73"), }, { System.Net.IPAddress.Parse("193.249.137.57"), System.Net.IPAddress.Parse("221.32.68.228"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("44.148.254.166"), System.Net.IPAddress.Parse("232.124.63.39"), }, { System.Net.IPAddress.Parse("217.205.188.165"), System.Net.IPAddress.Parse("150.92.4.33"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 116,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("178.156.209.194"), System.Net.IPAddress.Parse("170.237.249.61"), }, { System.Net.IPAddress.Parse("96.189.221.205"), System.Net.IPAddress.Parse("44.73.126.252"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 106,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("76.0.247.158"), System.Net.IPAddress.Parse("121.49.161.210"), }, { System.Net.IPAddress.Parse("99.4.83.223"), System.Net.IPAddress.Parse("163.28.18.228"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("137.121.85.249"), System.Net.IPAddress.Parse("180.133.143.180"), }, { System.Net.IPAddress.Parse("226.172.207.218"), System.Net.IPAddress.Parse("137.29.79.41"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 123,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("232.183.136.92"), System.Net.IPAddress.Parse("208.243.103.126"), }, { System.Net.IPAddress.Parse("106.83.63.27"), System.Net.IPAddress.Parse("2.66.86.63"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 111,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("239.4.147.34"), System.Net.IPAddress.Parse("170.105.15.40"), }, { System.Net.IPAddress.Parse("219.153.66.175"), System.Net.IPAddress.Parse("248.93.186.147"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("164.84.119.186"), System.Net.IPAddress.Parse("158.233.86.73"), }, { System.Net.IPAddress.Parse("222.86.93.21"), System.Net.IPAddress.Parse("60.5.70.47"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("123.30.243.123"), System.Net.IPAddress.Parse("148.231.120.143"), }, { System.Net.IPAddress.Parse("68.32.114.233"), System.Net.IPAddress.Parse("83.174.35.208"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 124,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("163.176.103.131"), System.Net.IPAddress.Parse("253.99.68.237"), }, { System.Net.IPAddress.Parse("207.168.184.13"), System.Net.IPAddress.Parse("36.227.104.245"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 113,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("89.179.25.229"), System.Net.IPAddress.Parse("169.119.58.186"), }, { System.Net.IPAddress.Parse("28.177.120.237"), System.Net.IPAddress.Parse("58.198.115.200"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 130,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("32.220.72.12"), System.Net.IPAddress.Parse("173.4.157.235"), }, { System.Net.IPAddress.Parse("108.243.164.236"), System.Net.IPAddress.Parse("13.67.244.253"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 119,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("233.48.83.59"), System.Net.IPAddress.Parse("19.231.227.51"), }, { System.Net.IPAddress.Parse("84.77.235.78"), System.Net.IPAddress.Parse("62.119.64.53"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 135,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("145.190.55.21"), System.Net.IPAddress.Parse("72.189.63.149"), }, { System.Net.IPAddress.Parse("196.69.179.230"), System.Net.IPAddress.Parse("189.150.4.87"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 121,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("9.207.143.148"), System.Net.IPAddress.Parse("164.206.5.30"), }, { System.Net.IPAddress.Parse("184.85.231.231"), System.Net.IPAddress.Parse("189.76.19.56"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("133.249.170.93"), System.Net.IPAddress.Parse("213.212.161.182"), }, { System.Net.IPAddress.Parse("102.121.244.200"), System.Net.IPAddress.Parse("247.19.20.170"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 143,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("139.151.243.39"), System.Net.IPAddress.Parse("237.144.69.203"), }, { System.Net.IPAddress.Parse("14.227.107.133"), System.Net.IPAddress.Parse("86.125.112.136"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 124,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("44.128.178.109"), System.Net.IPAddress.Parse("171.175.24.229"), }, { System.Net.IPAddress.Parse("48.231.162.44"), System.Net.IPAddress.Parse("11.151.234.227"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("148.1.105.136"), System.Net.IPAddress.Parse("11.197.103.29"), }, { System.Net.IPAddress.Parse("131.83.240.123"), System.Net.IPAddress.Parse("0.233.1.217"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 152,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("106.6.42.175"), System.Net.IPAddress.Parse("198.34.142.232"), }, { System.Net.IPAddress.Parse("3.117.253.114"), System.Net.IPAddress.Parse("9.40.65.140"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 132,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("44.117.95.207"), System.Net.IPAddress.Parse("184.65.251.70"), }, { System.Net.IPAddress.Parse("148.47.124.58"), System.Net.IPAddress.Parse("193.229.153.54"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("220.43.225.112"), System.Net.IPAddress.Parse("27.252.240.208"), }, { System.Net.IPAddress.Parse("115.49.207.214"), System.Net.IPAddress.Parse("217.233.84.25"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 156,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("177.39.75.22"), System.Net.IPAddress.Parse("5.58.179.203"), }, { System.Net.IPAddress.Parse("94.246.53.16"), System.Net.IPAddress.Parse("71.156.122.214"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 137,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("113.56.150.92"), System.Net.IPAddress.Parse("16.230.63.38"), }, { System.Net.IPAddress.Parse("49.115.228.158"), System.Net.IPAddress.Parse("106.183.131.8"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 162,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("45.191.30.161"), System.Net.IPAddress.Parse("136.138.204.116"), }, { System.Net.IPAddress.Parse("236.71.219.58"), System.Net.IPAddress.Parse("140.209.228.165"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 144,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("220.159.200.143"), System.Net.IPAddress.Parse("176.64.20.233"), }, { System.Net.IPAddress.Parse("236.53.56.111"), System.Net.IPAddress.Parse("158.115.72.183"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("223.117.224.0"), System.Net.IPAddress.Parse("154.224.184.89"), }, { System.Net.IPAddress.Parse("212.82.33.198"), System.Net.IPAddress.Parse("243.44.8.221"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 164,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("182.134.105.219"), System.Net.IPAddress.Parse("254.219.96.196"), }, { System.Net.IPAddress.Parse("250.166.109.170"), System.Net.IPAddress.Parse("223.71.197.221"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 153,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("199.156.254.34"), System.Net.IPAddress.Parse("218.187.191.197"), }, { System.Net.IPAddress.Parse("5.107.142.79"), System.Net.IPAddress.Parse("198.49.146.147"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("87.100.43.169"), System.Net.IPAddress.Parse("134.106.215.5"), }, { System.Net.IPAddress.Parse("143.139.252.170"), System.Net.IPAddress.Parse("143.44.57.143"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 170,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("123.73.103.98"), System.Net.IPAddress.Parse("197.137.21.183"), }, { System.Net.IPAddress.Parse("146.104.226.210"), System.Net.IPAddress.Parse("112.127.47.203"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 154,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("140.40.216.70"), System.Net.IPAddress.Parse("99.128.60.28"), }, { System.Net.IPAddress.Parse("7.148.59.28"), System.Net.IPAddress.Parse("242.163.134.127"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("128.38.80.100"), System.Net.IPAddress.Parse("7.228.136.179"), }, { System.Net.IPAddress.Parse("111.179.103.124"), System.Net.IPAddress.Parse("171.253.29.37"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 178,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("118.208.1.28"), System.Net.IPAddress.Parse("116.233.173.162"), }, { System.Net.IPAddress.Parse("57.241.71.202"), System.Net.IPAddress.Parse("143.214.205.100"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 160,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("4.51.254.31"), System.Net.IPAddress.Parse("247.56.59.1"), }, { System.Net.IPAddress.Parse("9.240.175.141"), System.Net.IPAddress.Parse("6.86.202.35"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("89.109.70.70"), System.Net.IPAddress.Parse("224.200.101.53"), }, { System.Net.IPAddress.Parse("118.250.158.244"), System.Net.IPAddress.Parse("174.252.89.176"), }, },
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

