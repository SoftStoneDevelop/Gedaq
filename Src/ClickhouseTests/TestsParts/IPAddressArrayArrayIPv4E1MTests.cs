

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
    internal partial interface IIPAddressMArrayArrayArrayIPv4
    {
    }
    
    internal partial class IPAddressMArrayArrayArrayIPv4 : IIPAddressMArrayArrayArrayIPv4
    {


#region TestData

        private readonly IPAddressArrayArrayIPv4E1M[] _testData = new IPAddressArrayArrayIPv4E1M[]
        {
            new IPAddressArrayArrayIPv4E1M
{
    Id = 9,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("174.214.99.103"),
System.Net.IPAddress.Parse("103.244.47.56"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 1,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("127.161.61.47"),
System.Net.IPAddress.Parse("101.224.69.151"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("34.161.67.254"),
System.Net.IPAddress.Parse("18.249.155.222"), } },
},
    NullableValue = null,
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 13,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("117.32.223.195"),
System.Net.IPAddress.Parse("18.178.165.0"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 4,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("162.1.20.193"),
System.Net.IPAddress.Parse("154.205.198.155"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("1.165.161.90"),
System.Net.IPAddress.Parse("166.243.24.59"), } },
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("165.198.112.206"),
System.Net.IPAddress.Parse("25.147.106.253"), } },
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 22,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("226.160.106.250"),
System.Net.IPAddress.Parse("184.27.45.160"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 13,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("11.42.56.36"),
System.Net.IPAddress.Parse("158.63.208.171"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 23,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("85.70.213.133"),
System.Net.IPAddress.Parse("212.75.167.153"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 18,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("144.75.221.158"),
System.Net.IPAddress.Parse("87.177.105.177"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("245.167.169.254"),
System.Net.IPAddress.Parse("176.113.106.179"), } },
},
    NullableValue = null,
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 31,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("198.111.73.239"),
System.Net.IPAddress.Parse("43.150.44.213"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 19,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("144.37.127.97"),
System.Net.IPAddress.Parse("0.55.173.219"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("131.61.47.118"),
System.Net.IPAddress.Parse("93.142.26.98"), } },
},
    NullableValue = null,
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 38,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("125.127.109.199"),
System.Net.IPAddress.Parse("34.69.89.167"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 28,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("47.141.182.250"),
System.Net.IPAddress.Parse("12.57.132.206"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("40.97.49.150"),
System.Net.IPAddress.Parse("228.235.59.74"), } },
},
    NullableValue = null,
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 45,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("95.138.214.89"),
System.Net.IPAddress.Parse("164.185.132.64"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 35,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("93.237.247.98"),
System.Net.IPAddress.Parse("121.127.33.157"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("0.8.101.13"),
System.Net.IPAddress.Parse("88.154.150.169"), } },
},
    NullableValue = null,
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 47,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("96.199.171.165"),
System.Net.IPAddress.Parse("137.161.97.15"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 41,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("239.165.212.206"),
System.Net.IPAddress.Parse("53.102.189.9"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("11.67.207.91"),
System.Net.IPAddress.Parse("26.82.201.49"), } },
},
    NullableValue = null,
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 56,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("32.54.143.127"),
System.Net.IPAddress.Parse("26.21.199.48"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 48,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("222.69.138.173"),
System.Net.IPAddress.Parse("9.148.139.65"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 60,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("119.114.160.235"),
System.Net.IPAddress.Parse("1.233.15.113"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 56,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("44.162.97.80"),
System.Net.IPAddress.Parse("115.21.211.163"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("211.75.69.83"),
System.Net.IPAddress.Parse("30.92.192.227"), } },
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("35.217.159.71"),
System.Net.IPAddress.Parse("101.63.232.206"), } },
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 61,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("61.98.42.235"),
System.Net.IPAddress.Parse("224.156.20.164"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 59,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("41.230.131.138"),
System.Net.IPAddress.Parse("181.211.128.55"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("174.106.232.25"),
System.Net.IPAddress.Parse("233.197.76.63"), } },
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 64,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("173.203.83.14"),
System.Net.IPAddress.Parse("181.143.146.15"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 66,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("166.247.23.33"),
System.Net.IPAddress.Parse("119.159.101.50"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 72,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("176.211.229.69"),
System.Net.IPAddress.Parse("252.54.188.99"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 73,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("2.226.246.205"),
System.Net.IPAddress.Parse("209.118.16.101"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("191.14.102.202"),
System.Net.IPAddress.Parse("133.13.85.153"), } },
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("16.97.105.142"),
System.Net.IPAddress.Parse("181.166.37.85"), } },
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 75,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("183.221.24.57"),
System.Net.IPAddress.Parse("101.137.234.221"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 76,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("28.7.47.124"),
System.Net.IPAddress.Parse("136.82.148.188"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("22.89.137.195"),
System.Net.IPAddress.Parse("150.159.212.21"), } },
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 81,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("135.236.146.215"),
System.Net.IPAddress.Parse("79.0.16.11"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 82,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("190.47.55.99"),
System.Net.IPAddress.Parse("192.60.7.28"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("54.17.248.136"),
System.Net.IPAddress.Parse("132.68.204.159"), } },
},
    NullableValue = null,
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 88,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("107.162.150.234"),
System.Net.IPAddress.Parse("210.26.50.93"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 87,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("118.107.210.88"),
System.Net.IPAddress.Parse("73.45.140.81"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("146.185.17.8"),
System.Net.IPAddress.Parse("90.203.93.82"), } },
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 95,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("242.17.82.125"),
System.Net.IPAddress.Parse("190.102.25.173"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 95,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("40.181.53.159"),
System.Net.IPAddress.Parse("134.15.194.129"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("205.80.131.125"),
System.Net.IPAddress.Parse("219.161.205.41"), } },
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 98,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("163.209.154.26"),
System.Net.IPAddress.Parse("161.253.67.115"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 102,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("66.231.182.185"),
System.Net.IPAddress.Parse("54.196.128.154"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 101,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("30.21.114.27"),
System.Net.IPAddress.Parse("172.120.28.169"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 111,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("9.227.35.226"),
System.Net.IPAddress.Parse("223.249.235.8"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("194.83.142.29"),
System.Net.IPAddress.Parse("224.108.1.142"), } },
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 105,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("103.63.209.16"),
System.Net.IPAddress.Parse("217.209.166.213"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 115,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("7.188.131.38"),
System.Net.IPAddress.Parse("240.231.40.105"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("34.171.155.204"),
System.Net.IPAddress.Parse("179.208.109.25"), } },
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("184.52.98.116"),
System.Net.IPAddress.Parse("155.106.181.87"), } },
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 108,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("89.156.19.222"),
System.Net.IPAddress.Parse("247.172.168.124"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 116,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("1.45.56.240"),
System.Net.IPAddress.Parse("17.87.249.39"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("219.141.60.91"),
System.Net.IPAddress.Parse("136.69.36.240"), } },
},
    NullableValue = null,
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 117,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("57.162.68.207"),
System.Net.IPAddress.Parse("24.87.125.132"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 119,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("182.85.32.212"),
System.Net.IPAddress.Parse("82.35.2.145"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("9.169.198.71"),
System.Net.IPAddress.Parse("46.89.145.37"), } },
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("40.249.160.145"),
System.Net.IPAddress.Parse("213.131.104.77"), } },
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 126,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("56.66.108.59"),
System.Net.IPAddress.Parse("53.223.209.104"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 124,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("247.153.217.127"),
System.Net.IPAddress.Parse("250.67.35.46"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("74.155.102.168"),
System.Net.IPAddress.Parse("146.4.52.145"), } },
},
    NullableValue = null,
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 132,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("161.185.185.96"),
System.Net.IPAddress.Parse("64.91.211.11"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 129,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("215.248.178.199"),
System.Net.IPAddress.Parse("223.131.83.60"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("209.254.198.165"),
System.Net.IPAddress.Parse("165.20.144.77"), } },
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("198.192.85.108"),
System.Net.IPAddress.Parse("202.24.123.172"), } },
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 141,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("45.20.144.32"),
System.Net.IPAddress.Parse("132.197.89.165"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 137,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("208.56.164.154"),
System.Net.IPAddress.Parse("27.158.224.5"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("85.103.0.126"),
System.Net.IPAddress.Parse("100.38.7.217"), } },
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 144,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("17.201.194.133"),
System.Net.IPAddress.Parse("118.106.48.150"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 144,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("110.175.250.12"),
System.Net.IPAddress.Parse("111.104.41.0"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("187.20.139.227"),
System.Net.IPAddress.Parse("13.158.206.229"), } },
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 149,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("245.210.14.121"),
System.Net.IPAddress.Parse("176.65.5.211"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 147,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("242.3.153.16"),
System.Net.IPAddress.Parse("119.112.133.160"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("41.209.147.254"),
System.Net.IPAddress.Parse("23.208.218.27"), } },
},
    NullableValue = null,
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 153,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("20.16.3.51"),
System.Net.IPAddress.Parse("228.132.35.161"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 150,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("231.26.58.68"),
System.Net.IPAddress.Parse("40.24.81.153"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("208.187.129.237"),
System.Net.IPAddress.Parse("48.43.89.36"), } },
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 156,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("38.51.220.22"),
System.Net.IPAddress.Parse("154.173.22.117"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 159,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("202.78.249.253"),
System.Net.IPAddress.Parse("114.172.202.215"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("150.51.57.94"),
System.Net.IPAddress.Parse("163.150.12.182"), } },
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("138.127.236.230"),
System.Net.IPAddress.Parse("13.159.59.211"), } },
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 164,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("194.224.109.2"),
System.Net.IPAddress.Parse("194.192.119.152"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 161,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("223.75.111.108"),
System.Net.IPAddress.Parse("108.226.42.158"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("16.191.128.2"),
System.Net.IPAddress.Parse("199.223.67.95"), } },
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("103.4.85.16"),
System.Net.IPAddress.Parse("157.176.118.3"), } },
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 170,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("12.57.148.213"),
System.Net.IPAddress.Parse("102.146.165.188"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 167,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("146.199.32.245"),
System.Net.IPAddress.Parse("151.126.240.90"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("243.70.254.107"),
System.Net.IPAddress.Parse("33.121.208.16"), } },
},
    NullableValue = null,
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 179,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("69.184.18.181"),
System.Net.IPAddress.Parse("141.204.31.9"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 175,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("88.227.112.219"),
System.Net.IPAddress.Parse("20.55.236.62"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("193.83.85.241"),
System.Net.IPAddress.Parse("133.149.132.217"), } },
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 180,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("11.214.94.67"),
System.Net.IPAddress.Parse("145.231.172.109"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 180,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("190.168.248.129"),
System.Net.IPAddress.Parse("66.7.251.97"), } },
    NullableValue = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("79.73.212.18"),
System.Net.IPAddress.Parse("157.110.219.90"), } },
},
    NullableValue = null,
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 181,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("227.66.15.77"),
System.Net.IPAddress.Parse("252.248.134.171"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 189,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("90.157.141.57"),
System.Net.IPAddress.Parse("232.89.14.87"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressArrayArrayIPv4E1M
{
    Id = 186,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("80.46.135.159"),
System.Net.IPAddress.Parse("43.139.116.25"), } },
    ModelInner = new IPAddressArrayArrayIPv41MI
{
    Id = 198,
    Value = 
new System.Net.IPAddress[,] { {
System.Net.IPAddress.Parse("178.3.123.1"),
System.Net.IPAddress.Parse("142.182.43.99"), } },
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
INSERT INTO gedaqtests.ipaddressarrayarrayipv4e1m(
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
            asPartInterface: typeof(IIPAddressMArrayArrayArrayIPv4)),
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
                    await ((IIPAddressMArrayArrayArrayIPv4)this).InsertModelDbConnectionAsync(
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
                     ((IIPAddressMArrayArrayArrayIPv4)this).InsertModelDbConnection(
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
FROM gedaqtests.ipaddressarrayarrayipv4e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(IPAddressArrayArrayIPv4E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayArrayArrayIPv4)),
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
                    var models = await ((IIPAddressMArrayArrayArrayIPv4)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    IPAddressArrayArrayIPv4E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IIPAddressMArrayArrayArrayIPv4)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    IPAddressArrayArrayIPv4E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

