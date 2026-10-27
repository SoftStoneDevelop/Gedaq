

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
    Id = 2,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("114.202.77.222"), System.Net.IPAddress.Parse("101.66.210.179"), }, { System.Net.IPAddress.Parse("205.23.29.100"), System.Net.IPAddress.Parse("6.99.218.163"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 9,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("144.4.203.252"), System.Net.IPAddress.Parse("81.64.6.185"), }, { System.Net.IPAddress.Parse("79.47.51.179"), System.Net.IPAddress.Parse("58.189.130.231"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("168.76.110.90"), System.Net.IPAddress.Parse("65.253.43.22"), }, { System.Net.IPAddress.Parse("200.137.144.237"), System.Net.IPAddress.Parse("48.229.159.61"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 7,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("131.199.116.150"), System.Net.IPAddress.Parse("55.170.224.159"), }, { System.Net.IPAddress.Parse("214.197.10.221"), System.Net.IPAddress.Parse("232.94.200.17"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 14,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("128.137.181.137"), System.Net.IPAddress.Parse("127.105.245.114"), }, { System.Net.IPAddress.Parse("54.1.45.177"), System.Net.IPAddress.Parse("16.145.206.90"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("33.149.170.28"), System.Net.IPAddress.Parse("211.50.2.219"), }, { System.Net.IPAddress.Parse("221.35.17.246"), System.Net.IPAddress.Parse("153.178.128.185"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 16,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("197.186.248.116"), System.Net.IPAddress.Parse("4.26.228.244"), }, { System.Net.IPAddress.Parse("166.147.245.55"), System.Net.IPAddress.Parse("167.58.215.234"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("56.226.202.62"), System.Net.IPAddress.Parse("52.22.157.9"), }, { System.Net.IPAddress.Parse("70.23.209.231"), System.Net.IPAddress.Parse("77.49.118.3"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("15.199.40.45"), System.Net.IPAddress.Parse("76.36.119.186"), }, { System.Net.IPAddress.Parse("1.209.99.76"), System.Net.IPAddress.Parse("40.244.247.203"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 23,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("199.67.190.81"), System.Net.IPAddress.Parse("168.64.251.247"), }, { System.Net.IPAddress.Parse("254.103.62.169"), System.Net.IPAddress.Parse("17.107.66.36"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 24,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("77.32.221.80"), System.Net.IPAddress.Parse("143.130.193.75"), }, { System.Net.IPAddress.Parse("109.184.35.26"), System.Net.IPAddress.Parse("186.18.104.4"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("82.123.34.4"), System.Net.IPAddress.Parse("87.236.55.31"), }, { System.Net.IPAddress.Parse("226.128.25.238"), System.Net.IPAddress.Parse("35.86.217.130"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 25,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("8.26.98.237"), System.Net.IPAddress.Parse("125.111.248.207"), }, { System.Net.IPAddress.Parse("50.70.61.127"), System.Net.IPAddress.Parse("80.206.233.245"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 31,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("153.222.137.60"), System.Net.IPAddress.Parse("141.169.25.41"), }, { System.Net.IPAddress.Parse("182.57.55.8"), System.Net.IPAddress.Parse("154.94.253.36"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("225.68.32.36"), System.Net.IPAddress.Parse("186.250.234.93"), }, { System.Net.IPAddress.Parse("244.72.180.136"), System.Net.IPAddress.Parse("141.132.195.2"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 28,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("177.163.97.204"), System.Net.IPAddress.Parse("118.10.136.129"), }, { System.Net.IPAddress.Parse("179.142.32.62"), System.Net.IPAddress.Parse("92.122.220.127"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 35,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("57.74.93.23"), System.Net.IPAddress.Parse("242.167.112.206"), }, { System.Net.IPAddress.Parse("1.112.175.72"), System.Net.IPAddress.Parse("73.253.38.50"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("253.205.78.147"), System.Net.IPAddress.Parse("214.249.133.211"), }, { System.Net.IPAddress.Parse("185.78.177.44"), System.Net.IPAddress.Parse("210.1.149.118"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 36,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("119.156.235.51"), System.Net.IPAddress.Parse("132.34.158.160"), }, { System.Net.IPAddress.Parse("236.109.184.254"), System.Net.IPAddress.Parse("0.61.99.62"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 42,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("30.196.70.201"), System.Net.IPAddress.Parse("247.182.172.159"), }, { System.Net.IPAddress.Parse("145.190.29.203"), System.Net.IPAddress.Parse("130.69.73.148"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("59.196.35.241"), System.Net.IPAddress.Parse("217.19.67.148"), }, { System.Net.IPAddress.Parse("200.229.216.194"), System.Net.IPAddress.Parse("75.5.163.130"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 43,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("214.51.198.23"), System.Net.IPAddress.Parse("171.159.16.32"), }, { System.Net.IPAddress.Parse("169.139.3.66"), System.Net.IPAddress.Parse("219.2.191.47"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 45,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("16.108.97.224"), System.Net.IPAddress.Parse("36.99.104.218"), }, { System.Net.IPAddress.Parse("12.203.163.35"), System.Net.IPAddress.Parse("63.29.101.177"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 50,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("39.202.74.70"), System.Net.IPAddress.Parse("169.60.70.179"), }, { System.Net.IPAddress.Parse("146.93.109.116"), System.Net.IPAddress.Parse("243.65.43.246"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 51,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("80.6.151.163"), System.Net.IPAddress.Parse("94.226.61.98"), }, { System.Net.IPAddress.Parse("98.135.45.237"), System.Net.IPAddress.Parse("80.25.174.231"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("218.43.15.189"), System.Net.IPAddress.Parse("115.166.131.237"), }, { System.Net.IPAddress.Parse("247.72.244.241"), System.Net.IPAddress.Parse("133.173.187.178"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("99.67.47.42"), System.Net.IPAddress.Parse("128.134.49.187"), }, { System.Net.IPAddress.Parse("225.64.139.27"), System.Net.IPAddress.Parse("233.238.209.205"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 59,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("20.251.78.231"), System.Net.IPAddress.Parse("40.21.60.234"), }, { System.Net.IPAddress.Parse("187.5.2.44"), System.Net.IPAddress.Parse("241.56.222.208"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 59,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("225.237.14.31"), System.Net.IPAddress.Parse("215.43.12.99"), }, { System.Net.IPAddress.Parse("141.161.11.183"), System.Net.IPAddress.Parse("194.75.48.233"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("224.174.207.8"), System.Net.IPAddress.Parse("163.249.38.211"), }, { System.Net.IPAddress.Parse("80.6.84.16"), System.Net.IPAddress.Parse("9.128.73.121"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("186.224.4.88"), System.Net.IPAddress.Parse("83.123.143.248"), }, { System.Net.IPAddress.Parse("55.237.107.134"), System.Net.IPAddress.Parse("44.203.118.173"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 65,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("44.220.128.32"), System.Net.IPAddress.Parse("67.16.223.247"), }, { System.Net.IPAddress.Parse("163.157.191.112"), System.Net.IPAddress.Parse("107.232.119.32"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 65,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("171.110.43.124"), System.Net.IPAddress.Parse("89.173.69.179"), }, { System.Net.IPAddress.Parse("68.158.238.130"), System.Net.IPAddress.Parse("140.186.74.207"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("201.102.124.147"), System.Net.IPAddress.Parse("29.40.169.186"), }, { System.Net.IPAddress.Parse("229.224.166.98"), System.Net.IPAddress.Parse("13.175.241.73"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("1.152.93.133"), System.Net.IPAddress.Parse("37.136.143.219"), }, { System.Net.IPAddress.Parse("156.241.155.203"), System.Net.IPAddress.Parse("196.212.15.136"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 69,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("228.242.31.25"), System.Net.IPAddress.Parse("51.30.38.233"), }, { System.Net.IPAddress.Parse("143.173.222.221"), System.Net.IPAddress.Parse("150.232.12.194"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 74,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("198.147.167.177"), System.Net.IPAddress.Parse("81.188.173.230"), }, { System.Net.IPAddress.Parse("206.154.162.224"), System.Net.IPAddress.Parse("84.163.120.76"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("252.63.238.164"), System.Net.IPAddress.Parse("136.4.248.111"), }, { System.Net.IPAddress.Parse("75.196.112.110"), System.Net.IPAddress.Parse("28.174.206.117"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 71,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("229.168.233.20"), System.Net.IPAddress.Parse("229.215.35.74"), }, { System.Net.IPAddress.Parse("158.39.250.184"), System.Net.IPAddress.Parse("105.197.166.151"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 80,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("223.122.102.238"), System.Net.IPAddress.Parse("200.91.213.205"), }, { System.Net.IPAddress.Parse("141.246.222.135"), System.Net.IPAddress.Parse("201.47.82.9"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("210.183.183.182"), System.Net.IPAddress.Parse("84.151.141.109"), }, { System.Net.IPAddress.Parse("73.117.202.185"), System.Net.IPAddress.Parse("101.211.112.131"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 74,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("206.112.9.211"), System.Net.IPAddress.Parse("21.241.134.212"), }, { System.Net.IPAddress.Parse("135.83.144.167"), System.Net.IPAddress.Parse("232.207.3.209"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 85,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("175.63.126.197"), System.Net.IPAddress.Parse("188.89.164.125"), }, { System.Net.IPAddress.Parse("48.57.180.40"), System.Net.IPAddress.Parse("79.61.146.217"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("169.149.33.82"), System.Net.IPAddress.Parse("46.211.168.2"), }, { System.Net.IPAddress.Parse("213.101.121.123"), System.Net.IPAddress.Parse("154.243.192.241"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 81,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("97.124.45.22"), System.Net.IPAddress.Parse("152.28.182.51"), }, { System.Net.IPAddress.Parse("11.69.147.148"), System.Net.IPAddress.Parse("64.215.142.148"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 87,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("13.70.36.165"), System.Net.IPAddress.Parse("206.247.122.119"), }, { System.Net.IPAddress.Parse("143.185.164.170"), System.Net.IPAddress.Parse("234.219.246.73"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("5.72.110.62"), System.Net.IPAddress.Parse("84.202.241.223"), }, { System.Net.IPAddress.Parse("252.40.100.198"), System.Net.IPAddress.Parse("235.86.105.193"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 86,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("147.0.40.187"), System.Net.IPAddress.Parse("199.66.59.141"), }, { System.Net.IPAddress.Parse("236.50.82.188"), System.Net.IPAddress.Parse("36.72.239.155"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 94,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("64.135.95.239"), System.Net.IPAddress.Parse("124.145.42.62"), }, { System.Net.IPAddress.Parse("234.28.166.138"), System.Net.IPAddress.Parse("58.238.196.237"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("77.79.232.195"), System.Net.IPAddress.Parse("98.141.37.4"), }, { System.Net.IPAddress.Parse("72.213.181.28"), System.Net.IPAddress.Parse("102.136.174.202"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("170.157.74.140"), System.Net.IPAddress.Parse("20.50.201.46"), }, { System.Net.IPAddress.Parse("22.243.254.129"), System.Net.IPAddress.Parse("146.145.36.75"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 89,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("78.22.53.175"), System.Net.IPAddress.Parse("245.135.162.167"), }, { System.Net.IPAddress.Parse("155.10.44.55"), System.Net.IPAddress.Parse("58.154.112.173"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 100,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("187.159.133.237"), System.Net.IPAddress.Parse("14.111.32.114"), }, { System.Net.IPAddress.Parse("93.31.47.231"), System.Net.IPAddress.Parse("162.196.164.205"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("150.159.194.50"), System.Net.IPAddress.Parse("236.125.106.243"), }, { System.Net.IPAddress.Parse("92.71.153.114"), System.Net.IPAddress.Parse("24.26.26.252"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("220.93.203.147"), System.Net.IPAddress.Parse("238.163.120.4"), }, { System.Net.IPAddress.Parse("77.42.180.188"), System.Net.IPAddress.Parse("24.242.243.5"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 94,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("134.124.114.20"), System.Net.IPAddress.Parse("243.107.95.85"), }, { System.Net.IPAddress.Parse("19.11.2.19"), System.Net.IPAddress.Parse("22.199.216.5"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 101,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("141.182.210.205"), System.Net.IPAddress.Parse("83.21.117.161"), }, { System.Net.IPAddress.Parse("155.61.53.93"), System.Net.IPAddress.Parse("112.90.64.241"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("198.120.37.141"), System.Net.IPAddress.Parse("134.65.219.178"), }, { System.Net.IPAddress.Parse("58.75.115.104"), System.Net.IPAddress.Parse("13.117.143.172"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 101,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("66.156.23.100"), System.Net.IPAddress.Parse("147.114.65.102"), }, { System.Net.IPAddress.Parse("53.96.93.222"), System.Net.IPAddress.Parse("241.4.215.165"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 104,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("60.41.95.251"), System.Net.IPAddress.Parse("207.125.38.181"), }, { System.Net.IPAddress.Parse("192.146.20.32"), System.Net.IPAddress.Parse("89.48.64.251"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("143.74.77.137"), System.Net.IPAddress.Parse("168.199.99.183"), }, { System.Net.IPAddress.Parse("134.25.198.13"), System.Net.IPAddress.Parse("110.66.13.154"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 103,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("50.26.31.118"), System.Net.IPAddress.Parse("147.229.120.240"), }, { System.Net.IPAddress.Parse("29.123.13.190"), System.Net.IPAddress.Parse("115.156.34.52"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 107,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("108.23.46.99"), System.Net.IPAddress.Parse("224.149.29.16"), }, { System.Net.IPAddress.Parse("138.129.24.143"), System.Net.IPAddress.Parse("171.79.234.197"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("132.151.141.232"), System.Net.IPAddress.Parse("162.241.115.233"), }, { System.Net.IPAddress.Parse("253.122.198.78"), System.Net.IPAddress.Parse("111.212.120.166"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 109,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("147.81.94.238"), System.Net.IPAddress.Parse("56.147.24.0"), }, { System.Net.IPAddress.Parse("254.209.188.198"), System.Net.IPAddress.Parse("108.23.235.112"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 110,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("172.113.212.176"), System.Net.IPAddress.Parse("45.202.34.173"), }, { System.Net.IPAddress.Parse("80.5.119.138"), System.Net.IPAddress.Parse("42.149.165.76"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("44.106.108.21"), System.Net.IPAddress.Parse("191.138.38.97"), }, { System.Net.IPAddress.Parse("235.132.231.102"), System.Net.IPAddress.Parse("146.27.121.36"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 110,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("180.160.99.121"), System.Net.IPAddress.Parse("63.5.63.118"), }, { System.Net.IPAddress.Parse("86.203.188.72"), System.Net.IPAddress.Parse("113.139.34.30"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 114,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("239.157.90.90"), System.Net.IPAddress.Parse("10.144.195.74"), }, { System.Net.IPAddress.Parse("128.131.14.233"), System.Net.IPAddress.Parse("143.110.234.22"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("114.225.47.114"), System.Net.IPAddress.Parse("90.209.81.162"), }, { System.Net.IPAddress.Parse("179.62.195.95"), System.Net.IPAddress.Parse("212.164.220.141"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 113,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("104.148.46.132"), System.Net.IPAddress.Parse("240.210.0.229"), }, { System.Net.IPAddress.Parse("237.49.160.206"), System.Net.IPAddress.Parse("201.166.136.28"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 120,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("107.103.247.39"), System.Net.IPAddress.Parse("151.155.229.56"), }, { System.Net.IPAddress.Parse("85.194.250.239"), System.Net.IPAddress.Parse("67.86.120.237"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("247.164.167.17"), System.Net.IPAddress.Parse("183.40.43.173"), }, { System.Net.IPAddress.Parse("125.249.247.46"), System.Net.IPAddress.Parse("205.151.182.150"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("138.254.186.71"), System.Net.IPAddress.Parse("119.77.115.185"), }, { System.Net.IPAddress.Parse("11.183.132.92"), System.Net.IPAddress.Parse("19.0.206.6"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 119,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("147.72.26.23"), System.Net.IPAddress.Parse("244.96.11.140"), }, { System.Net.IPAddress.Parse("122.169.102.132"), System.Net.IPAddress.Parse("117.76.192.148"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 122,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("251.221.125.6"), System.Net.IPAddress.Parse("184.160.236.62"), }, { System.Net.IPAddress.Parse("114.234.89.224"), System.Net.IPAddress.Parse("57.190.232.194"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("158.193.172.29"), System.Net.IPAddress.Parse("215.231.120.205"), }, { System.Net.IPAddress.Parse("102.111.210.89"), System.Net.IPAddress.Parse("15.135.234.4"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 122,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("204.47.73.17"), System.Net.IPAddress.Parse("221.25.141.236"), }, { System.Net.IPAddress.Parse("24.227.33.90"), System.Net.IPAddress.Parse("37.82.6.49"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 128,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("108.188.32.96"), System.Net.IPAddress.Parse("44.232.49.168"), }, { System.Net.IPAddress.Parse("225.7.92.121"), System.Net.IPAddress.Parse("34.104.75.170"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("11.37.238.2"), System.Net.IPAddress.Parse("6.22.211.233"), }, { System.Net.IPAddress.Parse("207.23.250.155"), System.Net.IPAddress.Parse("233.104.211.190"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("65.34.64.211"), System.Net.IPAddress.Parse("30.204.167.132"), }, { System.Net.IPAddress.Parse("12.249.115.123"), System.Net.IPAddress.Parse("38.112.219.135"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 126,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("213.6.64.59"), System.Net.IPAddress.Parse("101.164.18.2"), }, { System.Net.IPAddress.Parse("138.62.62.143"), System.Net.IPAddress.Parse("235.137.139.24"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 134,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("164.69.158.232"), System.Net.IPAddress.Parse("155.161.27.13"), }, { System.Net.IPAddress.Parse("25.242.75.124"), System.Net.IPAddress.Parse("245.148.78.47"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 135,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("50.80.17.40"), System.Net.IPAddress.Parse("122.173.186.206"), }, { System.Net.IPAddress.Parse("20.18.231.192"), System.Net.IPAddress.Parse("111.169.103.192"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 136,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("70.28.9.66"), System.Net.IPAddress.Parse("238.10.172.52"), }, { System.Net.IPAddress.Parse("33.168.49.236"), System.Net.IPAddress.Parse("229.151.220.168"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("182.182.46.127"), System.Net.IPAddress.Parse("98.197.140.114"), }, { System.Net.IPAddress.Parse("200.115.42.93"), System.Net.IPAddress.Parse("218.92.118.26"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 141,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("188.186.156.176"), System.Net.IPAddress.Parse("70.214.195.143"), }, { System.Net.IPAddress.Parse("85.216.112.243"), System.Net.IPAddress.Parse("209.228.105.78"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 138,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("142.104.234.21"), System.Net.IPAddress.Parse("65.85.112.174"), }, { System.Net.IPAddress.Parse("27.212.104.223"), System.Net.IPAddress.Parse("46.56.190.242"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 142,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("192.190.241.87"), System.Net.IPAddress.Parse("223.164.181.8"), }, { System.Net.IPAddress.Parse("11.107.129.205"), System.Net.IPAddress.Parse("43.254.150.254"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 144,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("37.147.20.109"), System.Net.IPAddress.Parse("204.241.225.178"), }, { System.Net.IPAddress.Parse("132.32.163.117"), System.Net.IPAddress.Parse("254.194.252.93"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("14.33.36.249"), System.Net.IPAddress.Parse("122.231.218.240"), }, { System.Net.IPAddress.Parse("226.206.221.51"), System.Net.IPAddress.Parse("120.58.70.176"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 149,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("197.246.106.103"), System.Net.IPAddress.Parse("187.217.110.45"), }, { System.Net.IPAddress.Parse("69.154.6.186"), System.Net.IPAddress.Parse("72.125.157.113"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 150,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("165.161.105.30"), System.Net.IPAddress.Parse("76.117.202.65"), }, { System.Net.IPAddress.Parse("21.107.31.173"), System.Net.IPAddress.Parse("221.249.108.239"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("44.149.237.66"), System.Net.IPAddress.Parse("195.170.164.151"), }, { System.Net.IPAddress.Parse("26.225.241.197"), System.Net.IPAddress.Parse("85.42.121.196"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("26.224.13.242"), System.Net.IPAddress.Parse("235.111.5.7"), }, { System.Net.IPAddress.Parse("169.181.224.66"), System.Net.IPAddress.Parse("113.78.241.254"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 153,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("96.74.1.0"), System.Net.IPAddress.Parse("195.26.11.220"), }, { System.Net.IPAddress.Parse("206.169.197.32"), System.Net.IPAddress.Parse("37.177.100.164"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 153,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("73.68.137.215"), System.Net.IPAddress.Parse("206.80.168.27"), }, { System.Net.IPAddress.Parse("51.165.97.118"), System.Net.IPAddress.Parse("246.135.141.163"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("215.157.220.110"), System.Net.IPAddress.Parse("143.49.136.189"), }, { System.Net.IPAddress.Parse("14.191.242.79"), System.Net.IPAddress.Parse("108.44.58.179"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("77.59.210.75"), System.Net.IPAddress.Parse("133.202.180.215"), }, { System.Net.IPAddress.Parse("179.25.49.85"), System.Net.IPAddress.Parse("248.9.179.239"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 161,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("200.59.235.100"), System.Net.IPAddress.Parse("66.69.211.182"), }, { System.Net.IPAddress.Parse("27.121.101.146"), System.Net.IPAddress.Parse("60.246.231.51"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 158,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("173.204.207.61"), System.Net.IPAddress.Parse("65.31.66.43"), }, { System.Net.IPAddress.Parse("182.108.226.142"), System.Net.IPAddress.Parse("231.108.157.173"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 170,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("85.93.53.28"), System.Net.IPAddress.Parse("12.145.21.181"), }, { System.Net.IPAddress.Parse("8.210.222.48"), System.Net.IPAddress.Parse("221.197.242.96"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 165,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("211.145.136.225"), System.Net.IPAddress.Parse("102.152.161.55"), }, { System.Net.IPAddress.Parse("170.73.99.108"), System.Net.IPAddress.Parse("85.157.68.126"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("101.30.180.227"), System.Net.IPAddress.Parse("62.42.243.204"), }, { System.Net.IPAddress.Parse("77.38.236.198"), System.Net.IPAddress.Parse("182.170.92.108"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 172,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("33.65.100.60"), System.Net.IPAddress.Parse("175.33.229.3"), }, { System.Net.IPAddress.Parse("163.78.148.11"), System.Net.IPAddress.Parse("45.148.240.85"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 173,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("24.150.101.141"), System.Net.IPAddress.Parse("44.188.104.56"), }, { System.Net.IPAddress.Parse("65.142.85.67"), System.Net.IPAddress.Parse("209.170.128.233"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("144.10.36.9"), System.Net.IPAddress.Parse("252.61.171.22"), }, { System.Net.IPAddress.Parse("12.204.202.81"), System.Net.IPAddress.Parse("146.237.23.112"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 174,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("28.158.118.222"), System.Net.IPAddress.Parse("17.27.175.230"), }, { System.Net.IPAddress.Parse("137.9.173.180"), System.Net.IPAddress.Parse("172.119.245.38"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 179,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("141.34.183.77"), System.Net.IPAddress.Parse("230.110.118.187"), }, { System.Net.IPAddress.Parse("166.8.7.17"), System.Net.IPAddress.Parse("47.235.24.51"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("34.197.177.187"), System.Net.IPAddress.Parse("228.98.226.221"), }, { System.Net.IPAddress.Parse("213.167.127.73"), System.Net.IPAddress.Parse("61.59.159.126"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("17.189.28.6"), System.Net.IPAddress.Parse("141.64.61.155"), }, { System.Net.IPAddress.Parse("176.208.223.51"), System.Net.IPAddress.Parse("108.130.10.125"), }, },
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

