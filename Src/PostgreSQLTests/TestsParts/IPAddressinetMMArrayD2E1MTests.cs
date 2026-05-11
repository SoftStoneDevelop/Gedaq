

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
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("75.59.4.57"), System.Net.IPAddress.Parse("69.131.98.231"), }, { System.Net.IPAddress.Parse("156.155.60.11"), System.Net.IPAddress.Parse("42.125.206.26"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 11,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("146.216.253.170"), System.Net.IPAddress.Parse("129.154.227.236"), }, { System.Net.IPAddress.Parse("55.160.155.115"), System.Net.IPAddress.Parse("109.140.51.134"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 2,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("169.77.90.108"), System.Net.IPAddress.Parse("109.161.235.253"), }, { System.Net.IPAddress.Parse("248.55.193.47"), System.Net.IPAddress.Parse("172.124.93.228"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 16,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("84.95.188.69"), System.Net.IPAddress.Parse("200.249.4.198"), }, { System.Net.IPAddress.Parse("33.20.3.182"), System.Net.IPAddress.Parse("16.36.78.213"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 22,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("0.17.205.213"), System.Net.IPAddress.Parse("145.173.162.22"), }, { System.Net.IPAddress.Parse("166.121.140.177"), System.Net.IPAddress.Parse("194.62.5.241"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 11,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("240.93.136.174"), System.Net.IPAddress.Parse("68.171.148.1"), }, { System.Net.IPAddress.Parse("42.204.37.233"), System.Net.IPAddress.Parse("215.92.34.174"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("1.67.135.26"), System.Net.IPAddress.Parse("171.16.17.30"), }, { System.Net.IPAddress.Parse("58.91.12.152"), System.Net.IPAddress.Parse("103.97.72.234"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("196.147.5.136"), System.Net.IPAddress.Parse("234.122.142.61"), }, { System.Net.IPAddress.Parse("100.92.186.199"), System.Net.IPAddress.Parse("217.146.10.116"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 27,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("28.199.114.249"), System.Net.IPAddress.Parse("85.87.117.165"), }, { System.Net.IPAddress.Parse("170.241.114.1"), System.Net.IPAddress.Parse("224.5.103.32"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 33,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("25.128.93.168"), System.Net.IPAddress.Parse("87.126.126.16"), }, { System.Net.IPAddress.Parse("133.147.128.85"), System.Net.IPAddress.Parse("112.244.154.34"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 19,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("168.15.79.62"), System.Net.IPAddress.Parse("5.18.58.30"), }, { System.Net.IPAddress.Parse("156.160.139.17"), System.Net.IPAddress.Parse("202.234.123.154"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("220.172.49.235"), System.Net.IPAddress.Parse("15.72.123.218"), }, { System.Net.IPAddress.Parse("114.177.11.75"), System.Net.IPAddress.Parse("129.69.91.29"), }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 37,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("54.138.166.213"), System.Net.IPAddress.Parse("18.229.223.82"), }, { System.Net.IPAddress.Parse("123.186.206.158"), System.Net.IPAddress.Parse("146.112.23.147"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("189.161.83.206"), System.Net.IPAddress.Parse("102.166.101.82"), }, { System.Net.IPAddress.Parse("197.3.22.115"), System.Net.IPAddress.Parse("60.182.128.146"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 40,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("177.51.33.130"), System.Net.IPAddress.Parse("226.209.152.122"), }, { System.Net.IPAddress.Parse("39.246.143.70"), System.Net.IPAddress.Parse("0.35.201.191"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 27,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("39.244.20.133"), System.Net.IPAddress.Parse("135.1.134.84"), }, { System.Net.IPAddress.Parse("35.93.54.235"), System.Net.IPAddress.Parse("4.242.24.83"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("188.231.142.250"), System.Net.IPAddress.Parse("16.40.47.136"), }, { System.Net.IPAddress.Parse("69.95.225.92"), System.Net.IPAddress.Parse("28.208.3.96"), }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 48,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("242.138.175.129"), System.Net.IPAddress.Parse("88.81.228.105"), }, { System.Net.IPAddress.Parse("217.104.253.102"), System.Net.IPAddress.Parse("96.51.217.8"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("153.95.217.174"), System.Net.IPAddress.Parse("137.103.100.35"), }, { System.Net.IPAddress.Parse("244.107.91.199"), System.Net.IPAddress.Parse("22.223.194.127"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 51,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("39.91.148.222"), System.Net.IPAddress.Parse("182.92.252.121"), }, { System.Net.IPAddress.Parse("62.50.215.143"), System.Net.IPAddress.Parse("15.39.249.157"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 30,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("22.8.126.29"), System.Net.IPAddress.Parse("247.247.133.154"), }, { System.Net.IPAddress.Parse("37.109.126.179"), System.Net.IPAddress.Parse("108.65.83.114"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 55,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("226.233.20.205"), System.Net.IPAddress.Parse("35.132.72.21"), }, { System.Net.IPAddress.Parse("237.242.49.132"), System.Net.IPAddress.Parse("211.190.1.224"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 61,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("78.143.211.177"), System.Net.IPAddress.Parse("171.184.123.181"), }, { System.Net.IPAddress.Parse("87.186.241.83"), System.Net.IPAddress.Parse("232.148.77.237"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 37,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("236.70.31.130"), System.Net.IPAddress.Parse("104.101.5.2"), }, { System.Net.IPAddress.Parse("6.22.77.230"), System.Net.IPAddress.Parse("233.218.245.44"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("86.240.177.107"), System.Net.IPAddress.Parse("85.127.10.42"), }, { System.Net.IPAddress.Parse("195.110.197.111"), System.Net.IPAddress.Parse("200.243.198.35"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("237.191.161.254"), System.Net.IPAddress.Parse("33.116.168.65"), }, { System.Net.IPAddress.Parse("107.132.155.239"), System.Net.IPAddress.Parse("116.167.216.38"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 64,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("217.74.103.247"), System.Net.IPAddress.Parse("62.129.87.61"), }, { System.Net.IPAddress.Parse("185.44.243.218"), System.Net.IPAddress.Parse("246.193.60.254"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("50.176.132.33"), System.Net.IPAddress.Parse("23.154.44.159"), }, { System.Net.IPAddress.Parse("250.0.230.241"), System.Net.IPAddress.Parse("250.47.60.103"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 70,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("11.239.10.178"), System.Net.IPAddress.Parse("133.85.231.101"), }, { System.Net.IPAddress.Parse("218.99.164.171"), System.Net.IPAddress.Parse("224.221.43.141"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 44,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("224.10.190.30"), System.Net.IPAddress.Parse("143.146.75.164"), }, { System.Net.IPAddress.Parse("213.141.199.76"), System.Net.IPAddress.Parse("152.60.153.213"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("22.27.3.236"), System.Net.IPAddress.Parse("35.202.44.126"), }, { System.Net.IPAddress.Parse("106.27.99.43"), System.Net.IPAddress.Parse("137.116.46.63"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("230.196.135.22"), System.Net.IPAddress.Parse("192.100.2.74"), }, { System.Net.IPAddress.Parse("231.25.182.251"), System.Net.IPAddress.Parse("177.195.178.246"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 77,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("108.93.249.169"), System.Net.IPAddress.Parse("237.122.30.104"), }, { System.Net.IPAddress.Parse("180.132.40.231"), System.Net.IPAddress.Parse("238.87.226.97"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 80,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("15.182.133.226"), System.Net.IPAddress.Parse("248.138.75.9"), }, { System.Net.IPAddress.Parse("226.203.189.185"), System.Net.IPAddress.Parse("35.238.19.237"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 50,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("242.10.40.191"), System.Net.IPAddress.Parse("75.151.155.253"), }, { System.Net.IPAddress.Parse("157.229.67.106"), System.Net.IPAddress.Parse("64.238.195.231"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 89,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("147.153.253.165"), System.Net.IPAddress.Parse("87.137.33.115"), }, { System.Net.IPAddress.Parse("135.122.19.215"), System.Net.IPAddress.Parse("200.41.182.171"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 97,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("170.34.164.162"), System.Net.IPAddress.Parse("237.174.63.120"), }, { System.Net.IPAddress.Parse("13.82.174.61"), System.Net.IPAddress.Parse("32.233.3.25"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 57,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("65.145.165.146"), System.Net.IPAddress.Parse("152.36.103.125"), }, { System.Net.IPAddress.Parse("121.180.17.154"), System.Net.IPAddress.Parse("90.61.116.181"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("170.3.182.116"), System.Net.IPAddress.Parse("44.129.130.246"), }, { System.Net.IPAddress.Parse("227.47.108.161"), System.Net.IPAddress.Parse("218.232.39.6"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 99,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("96.192.151.74"), System.Net.IPAddress.Parse("35.49.210.13"), }, { System.Net.IPAddress.Parse("99.219.33.143"), System.Net.IPAddress.Parse("158.174.216.136"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("100.164.135.227"), System.Net.IPAddress.Parse("49.201.208.202"), }, { System.Net.IPAddress.Parse("40.154.124.178"), System.Net.IPAddress.Parse("177.120.87.133"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 107,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("6.45.206.153"), System.Net.IPAddress.Parse("205.142.236.134"), }, { System.Net.IPAddress.Parse("3.246.177.225"), System.Net.IPAddress.Parse("55.128.30.52"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 63,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("39.213.10.239"), System.Net.IPAddress.Parse("250.189.207.213"), }, { System.Net.IPAddress.Parse("22.72.25.50"), System.Net.IPAddress.Parse("89.22.147.225"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("88.187.151.213"), System.Net.IPAddress.Parse("124.27.85.160"), }, { System.Net.IPAddress.Parse("166.55.22.1"), System.Net.IPAddress.Parse("58.177.129.189"), }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 116,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("13.113.247.182"), System.Net.IPAddress.Parse("154.90.62.193"), }, { System.Net.IPAddress.Parse("91.57.7.147"), System.Net.IPAddress.Parse("142.214.174.64"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 120,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("79.163.120.141"), System.Net.IPAddress.Parse("189.166.200.105"), }, { System.Net.IPAddress.Parse("238.241.7.194"), System.Net.IPAddress.Parse("90.193.30.106"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 65,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("217.232.54.73"), System.Net.IPAddress.Parse("36.7.1.254"), }, { System.Net.IPAddress.Parse("108.132.95.22"), System.Net.IPAddress.Parse("81.86.208.108"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 122,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("134.238.180.154"), System.Net.IPAddress.Parse("202.211.46.73"), }, { System.Net.IPAddress.Parse("62.37.65.100"), System.Net.IPAddress.Parse("82.67.218.49"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 127,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("174.130.177.31"), System.Net.IPAddress.Parse("151.45.192.131"), }, { System.Net.IPAddress.Parse("212.9.206.244"), System.Net.IPAddress.Parse("53.233.222.188"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 74,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("190.55.208.3"), System.Net.IPAddress.Parse("129.75.123.158"), }, { System.Net.IPAddress.Parse("182.184.227.17"), System.Net.IPAddress.Parse("232.73.23.61"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("85.210.226.165"), System.Net.IPAddress.Parse("56.151.86.151"), }, { System.Net.IPAddress.Parse("7.151.168.18"), System.Net.IPAddress.Parse("220.136.113.224"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 129,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("176.122.16.174"), System.Net.IPAddress.Parse("127.46.242.190"), }, { System.Net.IPAddress.Parse("74.49.34.43"), System.Net.IPAddress.Parse("59.70.196.123"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 130,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("99.213.219.79"), System.Net.IPAddress.Parse("24.203.17.176"), }, { System.Net.IPAddress.Parse("68.111.64.136"), System.Net.IPAddress.Parse("124.3.189.213"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 78,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("245.117.100.251"), System.Net.IPAddress.Parse("197.120.236.92"), }, { System.Net.IPAddress.Parse("30.68.238.215"), System.Net.IPAddress.Parse("134.159.62.120"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("224.53.124.206"), System.Net.IPAddress.Parse("26.66.97.128"), }, { System.Net.IPAddress.Parse("80.160.82.131"), System.Net.IPAddress.Parse("163.169.54.61"), }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 137,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("49.16.220.208"), System.Net.IPAddress.Parse("213.15.189.33"), }, { System.Net.IPAddress.Parse("243.78.39.170"), System.Net.IPAddress.Parse("38.165.13.159"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 144,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("212.191.211.76"), System.Net.IPAddress.Parse("120.33.170.12"), }, { System.Net.IPAddress.Parse("210.9.202.37"), System.Net.IPAddress.Parse("216.64.156.124"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 79,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("166.154.47.223"), System.Net.IPAddress.Parse("28.128.89.136"), }, { System.Net.IPAddress.Parse("210.128.55.90"), System.Net.IPAddress.Parse("114.188.126.213"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("18.67.85.10"), System.Net.IPAddress.Parse("180.217.247.13"), }, { System.Net.IPAddress.Parse("189.180.189.84"), System.Net.IPAddress.Parse("160.40.68.239"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("236.24.178.242"), System.Net.IPAddress.Parse("190.161.181.23"), }, { System.Net.IPAddress.Parse("87.216.102.75"), System.Net.IPAddress.Parse("84.169.70.19"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 146,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("232.187.173.130"), System.Net.IPAddress.Parse("51.51.36.192"), }, { System.Net.IPAddress.Parse("77.87.89.2"), System.Net.IPAddress.Parse("219.37.137.249"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("97.197.185.51"), System.Net.IPAddress.Parse("230.50.0.254"), }, { System.Net.IPAddress.Parse("185.213.189.96"), System.Net.IPAddress.Parse("120.31.197.223"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 149,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("3.93.243.56"), System.Net.IPAddress.Parse("250.124.191.146"), }, { System.Net.IPAddress.Parse("108.16.114.135"), System.Net.IPAddress.Parse("52.65.27.246"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 85,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("141.231.86.45"), System.Net.IPAddress.Parse("177.222.57.56"), }, { System.Net.IPAddress.Parse("55.216.131.6"), System.Net.IPAddress.Parse("25.61.185.114"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("97.33.66.104"), System.Net.IPAddress.Parse("73.59.33.199"), }, { System.Net.IPAddress.Parse("187.132.226.146"), System.Net.IPAddress.Parse("177.51.217.221"), }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 153,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("61.76.89.119"), System.Net.IPAddress.Parse("88.50.82.75"), }, { System.Net.IPAddress.Parse("188.117.64.206"), System.Net.IPAddress.Parse("176.63.50.144"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 155,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("139.39.50.213"), System.Net.IPAddress.Parse("63.146.95.26"), }, { System.Net.IPAddress.Parse("151.48.246.221"), System.Net.IPAddress.Parse("107.243.52.39"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 92,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("146.108.45.81"), System.Net.IPAddress.Parse("238.63.93.66"), }, { System.Net.IPAddress.Parse("18.135.16.133"), System.Net.IPAddress.Parse("158.58.21.77"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("174.179.16.86"), System.Net.IPAddress.Parse("74.111.116.114"), }, { System.Net.IPAddress.Parse("160.155.185.141"), System.Net.IPAddress.Parse("39.122.217.189"), }, },
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 164,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("68.174.247.132"), System.Net.IPAddress.Parse("95.73.203.223"), }, { System.Net.IPAddress.Parse("39.216.191.176"), System.Net.IPAddress.Parse("218.69.224.17"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 168,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("74.133.222.242"), System.Net.IPAddress.Parse("199.141.146.20"), }, { System.Net.IPAddress.Parse("208.58.143.103"), System.Net.IPAddress.Parse("218.89.67.116"), }, },
    ModelInner = new IPAddressinetMMArrayD2E1MI
{
    Id = 98,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("207.169.125.122"), System.Net.IPAddress.Parse("12.131.61.102"), }, { System.Net.IPAddress.Parse("135.48.135.158"), System.Net.IPAddress.Parse("213.160.93.114"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD2E1M
{
    Id = 175,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("135.1.66.87"), System.Net.IPAddress.Parse("186.231.152.199"), }, { System.Net.IPAddress.Parse("186.86.60.229"), System.Net.IPAddress.Parse("135.188.182.188"), }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("75.73.184.150"), System.Net.IPAddress.Parse("211.253.80.63"), }, { System.Net.IPAddress.Parse("67.63.23.43"), System.Net.IPAddress.Parse("34.126.138.203"), }, },
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("189.161.83.206"), System.Net.IPAddress.Parse("102.166.101.82"), }, { System.Net.IPAddress.Parse("197.3.22.115"), System.Net.IPAddress.Parse("60.182.128.146"), }, }));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("153.95.217.174"), System.Net.IPAddress.Parse("137.103.100.35"), }, { System.Net.IPAddress.Parse("244.107.91.199"), System.Net.IPAddress.Parse("22.223.194.127"), }, }));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("237.191.161.254"), System.Net.IPAddress.Parse("33.116.168.65"), }, { System.Net.IPAddress.Parse("107.132.155.239"), System.Net.IPAddress.Parse("116.167.216.38"), }, }));
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[22],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
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
                parametr1.Value = 16;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        IPAddressinetMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
                await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 97, query1, 164, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[34], false);
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
                await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 137, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                 ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 146, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[24],_testData[34], false);
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
                 ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 16, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 130, query1, 107, query2))
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
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
                await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 9, query1, 80, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 61, query1, 127, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
                 ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 70, query1, 153, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatIPAddressinetMMArrayD2E1M.AssertModel(secondItems2[3],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 89, 80))
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
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 16, 127))
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IIPAddressMArrayinetMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IIPAddressMArrayinetMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 80);
                var models = await ((IIPAddressMArrayinetMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressMArrayinetMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressMArrayinetMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 33);
                var models =  ((IIPAddressMArrayinetMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                IPAddressinetMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                IPAddressinetMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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

