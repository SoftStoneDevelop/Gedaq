

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
    internal partial interface IIPAddressMArrayinetMMArrayD3
    {
    }
    
    internal partial class IPAddressMArrayinetMMArrayD3 : IIPAddressMArrayinetMMArrayD3
    {


#region TestData

        private readonly IPAddressinetMMArrayD3E1M[] _testData = new IPAddressinetMMArrayD3E1M[]
        {
            new IPAddressinetMMArrayD3E1M
{
    Id = 9,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("193.184.201.230"), System.Net.IPAddress.Parse("7.178.205.243"), System.Net.IPAddress.Parse("136.89.147.189"), }, { System.Net.IPAddress.Parse("57.247.27.104"), System.Net.IPAddress.Parse("219.25.213.169"), System.Net.IPAddress.Parse("215.124.49.84"), }, { System.Net.IPAddress.Parse("164.27.245.70"), System.Net.IPAddress.Parse("251.192.62.157"), System.Net.IPAddress.Parse("74.190.228.26"), }, }, { { System.Net.IPAddress.Parse("61.92.18.162"), System.Net.IPAddress.Parse("62.230.214.249"), System.Net.IPAddress.Parse("21.154.57.22"), }, { System.Net.IPAddress.Parse("168.124.57.166"), System.Net.IPAddress.Parse("61.149.43.64"), System.Net.IPAddress.Parse("157.140.240.228"), }, { System.Net.IPAddress.Parse("197.121.190.86"), System.Net.IPAddress.Parse("189.96.133.214"), System.Net.IPAddress.Parse("188.224.177.135"), }, }, { { System.Net.IPAddress.Parse("177.84.210.244"), System.Net.IPAddress.Parse("212.117.202.227"), System.Net.IPAddress.Parse("79.52.208.99"), }, { System.Net.IPAddress.Parse("227.87.162.103"), System.Net.IPAddress.Parse("62.226.95.121"), System.Net.IPAddress.Parse("179.206.105.234"), }, { System.Net.IPAddress.Parse("55.85.170.198"), System.Net.IPAddress.Parse("12.212.174.82"), System.Net.IPAddress.Parse("183.239.69.97"), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("150.71.99.64"), System.Net.IPAddress.Parse("51.253.42.104"), System.Net.IPAddress.Parse("198.12.130.191"), }, { System.Net.IPAddress.Parse("125.14.224.217"), System.Net.IPAddress.Parse("77.182.203.216"), System.Net.IPAddress.Parse("30.97.235.202"), }, { System.Net.IPAddress.Parse("228.24.147.30"), System.Net.IPAddress.Parse("112.49.141.90"), System.Net.IPAddress.Parse("91.42.72.225"), }, }, { { System.Net.IPAddress.Parse("10.227.116.179"), System.Net.IPAddress.Parse("156.146.19.63"), System.Net.IPAddress.Parse("69.167.160.118"), }, { System.Net.IPAddress.Parse("158.158.26.168"), System.Net.IPAddress.Parse("207.218.81.126"), System.Net.IPAddress.Parse("88.68.138.186"), }, { System.Net.IPAddress.Parse("216.152.215.136"), System.Net.IPAddress.Parse("194.160.67.70"), System.Net.IPAddress.Parse("154.17.57.224"), }, }, { { System.Net.IPAddress.Parse("100.191.98.12"), System.Net.IPAddress.Parse("177.188.8.41"), System.Net.IPAddress.Parse("99.111.23.142"), }, { System.Net.IPAddress.Parse("169.151.93.26"), System.Net.IPAddress.Parse("89.12.187.221"), System.Net.IPAddress.Parse("128.157.197.183"), }, { System.Net.IPAddress.Parse("22.133.67.201"), System.Net.IPAddress.Parse("38.61.94.113"), System.Net.IPAddress.Parse("103.162.174.215"), }, }, },
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 18,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("168.68.194.98"), System.Net.IPAddress.Parse("128.148.111.164"), System.Net.IPAddress.Parse("243.38.83.156"), }, { System.Net.IPAddress.Parse("211.54.36.76"), System.Net.IPAddress.Parse("38.115.166.173"), System.Net.IPAddress.Parse("222.197.33.64"), }, { System.Net.IPAddress.Parse("222.196.85.29"), System.Net.IPAddress.Parse("131.130.150.148"), System.Net.IPAddress.Parse("220.250.88.34"), }, }, { { System.Net.IPAddress.Parse("131.112.188.69"), System.Net.IPAddress.Parse("71.234.27.35"), System.Net.IPAddress.Parse("20.25.222.140"), }, { System.Net.IPAddress.Parse("251.45.218.4"), System.Net.IPAddress.Parse("173.223.52.165"), System.Net.IPAddress.Parse("110.156.218.253"), }, { System.Net.IPAddress.Parse("220.206.227.4"), System.Net.IPAddress.Parse("132.4.104.137"), System.Net.IPAddress.Parse("115.179.58.168"), }, }, { { System.Net.IPAddress.Parse("242.231.125.67"), System.Net.IPAddress.Parse("29.39.25.240"), System.Net.IPAddress.Parse("6.87.195.212"), }, { System.Net.IPAddress.Parse("145.39.90.14"), System.Net.IPAddress.Parse("210.17.139.116"), System.Net.IPAddress.Parse("110.37.116.141"), }, { System.Net.IPAddress.Parse("202.46.89.227"), System.Net.IPAddress.Parse("47.245.18.81"), System.Net.IPAddress.Parse("234.55.85.234"), }, }, },
    ModelInner = new IPAddressinetMMArrayD3E1MI
{
    Id = 6,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("98.176.194.52"), System.Net.IPAddress.Parse("75.55.236.40"), System.Net.IPAddress.Parse("204.120.166.105"), }, { System.Net.IPAddress.Parse("233.140.196.95"), System.Net.IPAddress.Parse("177.101.233.2"), System.Net.IPAddress.Parse("91.19.124.123"), }, { System.Net.IPAddress.Parse("45.216.232.195"), System.Net.IPAddress.Parse("71.53.156.12"), System.Net.IPAddress.Parse("198.47.18.108"), }, }, { { System.Net.IPAddress.Parse("190.201.150.250"), System.Net.IPAddress.Parse("76.200.191.121"), System.Net.IPAddress.Parse("232.142.233.11"), }, { System.Net.IPAddress.Parse("97.115.14.122"), System.Net.IPAddress.Parse("69.44.240.66"), System.Net.IPAddress.Parse("71.17.122.119"), }, { System.Net.IPAddress.Parse("128.199.17.21"), System.Net.IPAddress.Parse("122.169.241.172"), System.Net.IPAddress.Parse("219.39.193.229"), }, }, { { System.Net.IPAddress.Parse("82.10.14.90"), System.Net.IPAddress.Parse("90.125.187.9"), System.Net.IPAddress.Parse("1.149.7.20"), }, { System.Net.IPAddress.Parse("36.81.55.59"), System.Net.IPAddress.Parse("3.70.232.57"), System.Net.IPAddress.Parse("215.33.54.110"), }, { System.Net.IPAddress.Parse("100.17.25.81"), System.Net.IPAddress.Parse("176.25.14.102"), System.Net.IPAddress.Parse("251.85.238.236"), }, }, },
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("18.83.154.170"), System.Net.IPAddress.Parse("23.202.205.153"), System.Net.IPAddress.Parse("67.91.143.189"), }, { System.Net.IPAddress.Parse("120.243.215.187"), System.Net.IPAddress.Parse("3.157.4.169"), System.Net.IPAddress.Parse("180.70.160.191"), }, { System.Net.IPAddress.Parse("10.80.134.168"), System.Net.IPAddress.Parse("88.238.156.88"), System.Net.IPAddress.Parse("210.242.20.11"), }, }, { { System.Net.IPAddress.Parse("75.245.130.11"), System.Net.IPAddress.Parse("215.177.175.120"), System.Net.IPAddress.Parse("83.21.253.58"), }, { System.Net.IPAddress.Parse("132.58.222.191"), System.Net.IPAddress.Parse("191.29.44.32"), System.Net.IPAddress.Parse("198.8.27.68"), }, { System.Net.IPAddress.Parse("35.7.171.147"), System.Net.IPAddress.Parse("153.130.182.226"), System.Net.IPAddress.Parse("227.117.2.116"), }, }, { { System.Net.IPAddress.Parse("165.139.40.69"), System.Net.IPAddress.Parse("58.15.168.120"), System.Net.IPAddress.Parse("93.14.239.49"), }, { System.Net.IPAddress.Parse("137.208.6.129"), System.Net.IPAddress.Parse("136.217.154.199"), System.Net.IPAddress.Parse("149.173.75.77"), }, { System.Net.IPAddress.Parse("83.220.234.8"), System.Net.IPAddress.Parse("33.160.52.131"), System.Net.IPAddress.Parse("117.246.74.187"), }, }, },
},
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("189.107.244.234"), System.Net.IPAddress.Parse("236.33.177.42"), System.Net.IPAddress.Parse("187.72.78.119"), }, { System.Net.IPAddress.Parse("96.157.31.116"), System.Net.IPAddress.Parse("214.15.208.147"), System.Net.IPAddress.Parse("209.54.242.116"), }, { System.Net.IPAddress.Parse("67.33.195.223"), System.Net.IPAddress.Parse("132.238.103.99"), System.Net.IPAddress.Parse("5.233.51.115"), }, }, { { System.Net.IPAddress.Parse("167.153.229.126"), System.Net.IPAddress.Parse("172.210.132.121"), System.Net.IPAddress.Parse("70.127.178.71"), }, { System.Net.IPAddress.Parse("122.85.214.56"), System.Net.IPAddress.Parse("49.245.222.11"), System.Net.IPAddress.Parse("131.212.120.136"), }, { System.Net.IPAddress.Parse("176.99.167.193"), System.Net.IPAddress.Parse("42.21.6.65"), System.Net.IPAddress.Parse("19.197.199.174"), }, }, { { System.Net.IPAddress.Parse("236.69.84.106"), System.Net.IPAddress.Parse("14.37.92.84"), System.Net.IPAddress.Parse("70.247.196.131"), }, { System.Net.IPAddress.Parse("179.184.190.239"), System.Net.IPAddress.Parse("170.145.224.135"), System.Net.IPAddress.Parse("216.0.177.12"), }, { System.Net.IPAddress.Parse("177.29.143.206"), System.Net.IPAddress.Parse("109.106.97.44"), System.Net.IPAddress.Parse("193.202.232.28"), }, }, },
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 23,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("63.208.235.43"), System.Net.IPAddress.Parse("122.85.208.64"), System.Net.IPAddress.Parse("226.20.18.91"), }, { System.Net.IPAddress.Parse("236.248.172.134"), System.Net.IPAddress.Parse("148.101.117.55"), System.Net.IPAddress.Parse("244.60.116.108"), }, { System.Net.IPAddress.Parse("197.50.139.101"), System.Net.IPAddress.Parse("132.228.123.123"), System.Net.IPAddress.Parse("2.223.86.66"), }, }, { { System.Net.IPAddress.Parse("169.25.106.249"), System.Net.IPAddress.Parse("129.169.236.65"), System.Net.IPAddress.Parse("17.17.189.65"), }, { System.Net.IPAddress.Parse("218.88.189.178"), System.Net.IPAddress.Parse("240.236.138.139"), System.Net.IPAddress.Parse("119.28.52.178"), }, { System.Net.IPAddress.Parse("29.41.146.76"), System.Net.IPAddress.Parse("252.48.61.197"), System.Net.IPAddress.Parse("228.189.81.17"), }, }, { { System.Net.IPAddress.Parse("113.68.61.141"), System.Net.IPAddress.Parse("159.83.31.237"), System.Net.IPAddress.Parse("210.191.178.97"), }, { System.Net.IPAddress.Parse("141.80.44.233"), System.Net.IPAddress.Parse("13.57.200.225"), System.Net.IPAddress.Parse("213.33.140.84"), }, { System.Net.IPAddress.Parse("80.140.46.145"), System.Net.IPAddress.Parse("192.75.120.64"), System.Net.IPAddress.Parse("207.138.12.41"), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 26,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("139.40.25.179"), System.Net.IPAddress.Parse("59.239.80.95"), System.Net.IPAddress.Parse("20.83.17.130"), }, { System.Net.IPAddress.Parse("149.62.20.69"), System.Net.IPAddress.Parse("55.41.99.130"), System.Net.IPAddress.Parse("40.151.225.84"), }, { System.Net.IPAddress.Parse("73.109.56.195"), System.Net.IPAddress.Parse("183.60.142.2"), System.Net.IPAddress.Parse("56.253.118.207"), }, }, { { System.Net.IPAddress.Parse("26.23.194.140"), System.Net.IPAddress.Parse("162.95.189.240"), System.Net.IPAddress.Parse("189.80.186.143"), }, { System.Net.IPAddress.Parse("22.6.188.227"), System.Net.IPAddress.Parse("223.186.228.207"), System.Net.IPAddress.Parse("24.227.177.179"), }, { System.Net.IPAddress.Parse("113.3.205.109"), System.Net.IPAddress.Parse("129.113.19.1"), System.Net.IPAddress.Parse("229.202.141.72"), }, }, { { System.Net.IPAddress.Parse("106.43.83.213"), System.Net.IPAddress.Parse("252.75.15.80"), System.Net.IPAddress.Parse("59.65.153.39"), }, { System.Net.IPAddress.Parse("140.210.212.44"), System.Net.IPAddress.Parse("139.251.193.177"), System.Net.IPAddress.Parse("178.85.7.159"), }, { System.Net.IPAddress.Parse("22.113.182.98"), System.Net.IPAddress.Parse("138.122.125.169"), System.Net.IPAddress.Parse("110.94.181.230"), }, }, },
    ModelInner = new IPAddressinetMMArrayD3E1MI
{
    Id = 8,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("164.55.176.63"), System.Net.IPAddress.Parse("39.115.54.7"), System.Net.IPAddress.Parse("79.54.166.160"), }, { System.Net.IPAddress.Parse("237.196.223.36"), System.Net.IPAddress.Parse("179.8.216.3"), System.Net.IPAddress.Parse("52.192.129.210"), }, { System.Net.IPAddress.Parse("34.183.2.237"), System.Net.IPAddress.Parse("144.213.139.228"), System.Net.IPAddress.Parse("151.71.18.43"), }, }, { { System.Net.IPAddress.Parse("112.19.6.197"), System.Net.IPAddress.Parse("194.241.143.93"), System.Net.IPAddress.Parse("135.147.83.149"), }, { System.Net.IPAddress.Parse("188.15.223.58"), System.Net.IPAddress.Parse("0.247.228.0"), System.Net.IPAddress.Parse("162.99.49.236"), }, { System.Net.IPAddress.Parse("69.229.242.6"), System.Net.IPAddress.Parse("199.168.209.226"), System.Net.IPAddress.Parse("173.75.120.167"), }, }, { { System.Net.IPAddress.Parse("235.9.228.73"), System.Net.IPAddress.Parse("136.15.177.201"), System.Net.IPAddress.Parse("231.90.11.210"), }, { System.Net.IPAddress.Parse("129.182.232.234"), System.Net.IPAddress.Parse("123.203.233.181"), System.Net.IPAddress.Parse("182.245.65.109"), }, { System.Net.IPAddress.Parse("147.243.207.39"), System.Net.IPAddress.Parse("177.209.222.209"), System.Net.IPAddress.Parse("245.73.77.38"), }, }, },
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("241.91.26.171"), System.Net.IPAddress.Parse("36.35.174.3"), System.Net.IPAddress.Parse("1.197.109.47"), }, { System.Net.IPAddress.Parse("105.72.27.38"), System.Net.IPAddress.Parse("196.148.248.41"), System.Net.IPAddress.Parse("17.30.99.13"), }, { System.Net.IPAddress.Parse("139.79.158.71"), System.Net.IPAddress.Parse("182.211.170.48"), System.Net.IPAddress.Parse("195.206.35.21"), }, }, { { System.Net.IPAddress.Parse("71.197.13.27"), System.Net.IPAddress.Parse("116.231.224.166"), System.Net.IPAddress.Parse("23.199.22.55"), }, { System.Net.IPAddress.Parse("3.74.218.35"), System.Net.IPAddress.Parse("43.111.92.133"), System.Net.IPAddress.Parse("145.126.216.213"), }, { System.Net.IPAddress.Parse("208.78.121.46"), System.Net.IPAddress.Parse("26.111.248.24"), System.Net.IPAddress.Parse("116.13.13.76"), }, }, { { System.Net.IPAddress.Parse("162.185.1.237"), System.Net.IPAddress.Parse("198.140.246.38"), System.Net.IPAddress.Parse("150.50.46.197"), }, { System.Net.IPAddress.Parse("16.145.21.110"), System.Net.IPAddress.Parse("101.196.36.2"), System.Net.IPAddress.Parse("0.8.27.136"), }, { System.Net.IPAddress.Parse("177.196.58.69"), System.Net.IPAddress.Parse("25.163.139.23"), System.Net.IPAddress.Parse("6.170.57.169"), }, }, },
},
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("208.70.156.241"), System.Net.IPAddress.Parse("30.64.69.190"), System.Net.IPAddress.Parse("238.172.45.51"), }, { System.Net.IPAddress.Parse("126.210.239.190"), System.Net.IPAddress.Parse("221.208.138.187"), System.Net.IPAddress.Parse("155.86.128.203"), }, { System.Net.IPAddress.Parse("82.1.208.53"), System.Net.IPAddress.Parse("198.129.180.49"), System.Net.IPAddress.Parse("87.78.14.132"), }, }, { { System.Net.IPAddress.Parse("170.185.106.214"), System.Net.IPAddress.Parse("238.212.26.239"), System.Net.IPAddress.Parse("53.21.17.16"), }, { System.Net.IPAddress.Parse("83.66.204.218"), System.Net.IPAddress.Parse("139.130.89.65"), System.Net.IPAddress.Parse("219.250.109.215"), }, { System.Net.IPAddress.Parse("141.95.248.218"), System.Net.IPAddress.Parse("146.28.201.227"), System.Net.IPAddress.Parse("135.122.146.188"), }, }, { { System.Net.IPAddress.Parse("173.244.196.241"), System.Net.IPAddress.Parse("30.158.139.221"), System.Net.IPAddress.Parse("112.156.221.191"), }, { System.Net.IPAddress.Parse("84.132.140.111"), System.Net.IPAddress.Parse("239.215.89.34"), System.Net.IPAddress.Parse("70.104.113.31"), }, { System.Net.IPAddress.Parse("60.99.80.201"), System.Net.IPAddress.Parse("64.182.25.109"), System.Net.IPAddress.Parse("187.150.174.114"), }, }, },
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 32,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("216.167.47.112"), System.Net.IPAddress.Parse("185.164.137.45"), System.Net.IPAddress.Parse("25.102.15.167"), }, { System.Net.IPAddress.Parse("124.55.95.166"), System.Net.IPAddress.Parse("138.30.163.42"), System.Net.IPAddress.Parse("191.140.69.137"), }, { System.Net.IPAddress.Parse("22.202.104.184"), System.Net.IPAddress.Parse("18.183.104.11"), System.Net.IPAddress.Parse("16.124.25.112"), }, }, { { System.Net.IPAddress.Parse("166.191.17.110"), System.Net.IPAddress.Parse("158.127.205.122"), System.Net.IPAddress.Parse("144.137.174.83"), }, { System.Net.IPAddress.Parse("45.161.65.56"), System.Net.IPAddress.Parse("123.244.179.173"), System.Net.IPAddress.Parse("50.56.213.151"), }, { System.Net.IPAddress.Parse("193.185.39.187"), System.Net.IPAddress.Parse("80.196.225.240"), System.Net.IPAddress.Parse("148.181.159.112"), }, }, { { System.Net.IPAddress.Parse("214.124.159.104"), System.Net.IPAddress.Parse("81.120.26.233"), System.Net.IPAddress.Parse("246.99.150.73"), }, { System.Net.IPAddress.Parse("167.76.136.188"), System.Net.IPAddress.Parse("16.30.246.56"), System.Net.IPAddress.Parse("150.244.20.184"), }, { System.Net.IPAddress.Parse("120.164.165.139"), System.Net.IPAddress.Parse("219.161.136.236"), System.Net.IPAddress.Parse("63.5.1.108"), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 36,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("44.239.60.64"), System.Net.IPAddress.Parse("15.27.101.235"), System.Net.IPAddress.Parse("247.55.247.177"), }, { System.Net.IPAddress.Parse("31.13.226.203"), System.Net.IPAddress.Parse("176.4.237.96"), System.Net.IPAddress.Parse("242.245.99.67"), }, { System.Net.IPAddress.Parse("53.134.24.68"), System.Net.IPAddress.Parse("217.32.157.99"), System.Net.IPAddress.Parse("115.253.197.82"), }, }, { { System.Net.IPAddress.Parse("155.181.211.107"), System.Net.IPAddress.Parse("176.52.52.19"), System.Net.IPAddress.Parse("61.208.12.113"), }, { System.Net.IPAddress.Parse("163.19.109.33"), System.Net.IPAddress.Parse("215.65.67.215"), System.Net.IPAddress.Parse("2.235.166.120"), }, { System.Net.IPAddress.Parse("57.251.12.148"), System.Net.IPAddress.Parse("190.116.210.109"), System.Net.IPAddress.Parse("37.131.74.248"), }, }, { { System.Net.IPAddress.Parse("65.240.25.6"), System.Net.IPAddress.Parse("60.203.211.9"), System.Net.IPAddress.Parse("156.21.188.125"), }, { System.Net.IPAddress.Parse("244.50.249.147"), System.Net.IPAddress.Parse("197.235.6.152"), System.Net.IPAddress.Parse("19.5.53.242"), }, { System.Net.IPAddress.Parse("144.4.36.66"), System.Net.IPAddress.Parse("185.165.120.51"), System.Net.IPAddress.Parse("217.111.245.199"), }, }, },
    ModelInner = new IPAddressinetMMArrayD3E1MI
{
    Id = 11,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("248.9.54.212"), System.Net.IPAddress.Parse("61.32.210.201"), System.Net.IPAddress.Parse("82.60.241.26"), }, { System.Net.IPAddress.Parse("33.235.143.177"), System.Net.IPAddress.Parse("4.176.241.109"), System.Net.IPAddress.Parse("102.98.181.89"), }, { System.Net.IPAddress.Parse("128.23.58.153"), System.Net.IPAddress.Parse("151.140.171.7"), System.Net.IPAddress.Parse("95.216.247.233"), }, }, { { System.Net.IPAddress.Parse("18.91.116.178"), System.Net.IPAddress.Parse("29.50.94.175"), System.Net.IPAddress.Parse("182.70.150.50"), }, { System.Net.IPAddress.Parse("133.239.23.31"), System.Net.IPAddress.Parse("152.103.22.91"), System.Net.IPAddress.Parse("81.77.227.237"), }, { System.Net.IPAddress.Parse("248.215.88.8"), System.Net.IPAddress.Parse("199.198.31.68"), System.Net.IPAddress.Parse("245.111.133.91"), }, }, { { System.Net.IPAddress.Parse("106.111.221.117"), System.Net.IPAddress.Parse("193.64.189.161"), System.Net.IPAddress.Parse("199.157.11.197"), }, { System.Net.IPAddress.Parse("30.93.69.195"), System.Net.IPAddress.Parse("136.32.33.101"), System.Net.IPAddress.Parse("142.104.138.60"), }, { System.Net.IPAddress.Parse("237.199.42.217"), System.Net.IPAddress.Parse("99.242.213.42"), System.Net.IPAddress.Parse("126.61.204.53"), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("18.198.43.75"), System.Net.IPAddress.Parse("140.166.190.113"), System.Net.IPAddress.Parse("81.32.120.185"), }, { System.Net.IPAddress.Parse("179.183.127.86"), System.Net.IPAddress.Parse("67.99.109.53"), System.Net.IPAddress.Parse("237.140.182.197"), }, { System.Net.IPAddress.Parse("186.153.91.160"), System.Net.IPAddress.Parse("140.175.73.152"), System.Net.IPAddress.Parse("147.231.70.235"), }, }, { { System.Net.IPAddress.Parse("8.61.169.226"), System.Net.IPAddress.Parse("180.16.205.135"), System.Net.IPAddress.Parse("11.86.116.37"), }, { System.Net.IPAddress.Parse("154.103.93.4"), System.Net.IPAddress.Parse("130.209.67.37"), System.Net.IPAddress.Parse("172.37.157.172"), }, { System.Net.IPAddress.Parse("220.129.215.19"), System.Net.IPAddress.Parse("144.215.1.231"), System.Net.IPAddress.Parse("125.40.189.130"), }, }, { { System.Net.IPAddress.Parse("50.152.160.213"), System.Net.IPAddress.Parse("91.118.162.191"), System.Net.IPAddress.Parse("216.146.0.165"), }, { System.Net.IPAddress.Parse("82.252.153.110"), System.Net.IPAddress.Parse("182.220.155.84"), System.Net.IPAddress.Parse("208.118.220.231"), }, { System.Net.IPAddress.Parse("90.159.141.183"), System.Net.IPAddress.Parse("46.196.96.48"), System.Net.IPAddress.Parse("25.174.56.238"), }, }, },
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 42,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("173.114.225.154"), System.Net.IPAddress.Parse("45.123.136.116"), System.Net.IPAddress.Parse("212.3.220.9"), }, { System.Net.IPAddress.Parse("111.94.153.208"), System.Net.IPAddress.Parse("50.149.154.141"), System.Net.IPAddress.Parse("30.113.142.155"), }, { System.Net.IPAddress.Parse("178.237.219.123"), System.Net.IPAddress.Parse("49.12.239.134"), System.Net.IPAddress.Parse("238.175.93.205"), }, }, { { System.Net.IPAddress.Parse("205.171.74.247"), System.Net.IPAddress.Parse("194.141.93.73"), System.Net.IPAddress.Parse("215.131.225.26"), }, { System.Net.IPAddress.Parse("220.183.224.138"), System.Net.IPAddress.Parse("197.253.57.149"), System.Net.IPAddress.Parse("30.61.169.94"), }, { System.Net.IPAddress.Parse("122.87.200.36"), System.Net.IPAddress.Parse("236.177.189.249"), System.Net.IPAddress.Parse("155.200.7.142"), }, }, { { System.Net.IPAddress.Parse("182.56.71.74"), System.Net.IPAddress.Parse("38.211.219.213"), System.Net.IPAddress.Parse("208.54.254.7"), }, { System.Net.IPAddress.Parse("88.23.62.235"), System.Net.IPAddress.Parse("166.237.136.196"), System.Net.IPAddress.Parse("200.149.152.118"), }, { System.Net.IPAddress.Parse("114.49.121.6"), System.Net.IPAddress.Parse("23.136.189.211"), System.Net.IPAddress.Parse("6.33.95.169"), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 46,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("190.241.216.37"), System.Net.IPAddress.Parse("44.135.158.2"), System.Net.IPAddress.Parse("99.202.246.95"), }, { System.Net.IPAddress.Parse("94.172.224.97"), System.Net.IPAddress.Parse("13.81.237.204"), System.Net.IPAddress.Parse("94.216.52.103"), }, { System.Net.IPAddress.Parse("117.3.125.253"), System.Net.IPAddress.Parse("103.96.37.85"), System.Net.IPAddress.Parse("198.87.162.142"), }, }, { { System.Net.IPAddress.Parse("7.50.77.41"), System.Net.IPAddress.Parse("215.79.198.231"), System.Net.IPAddress.Parse("138.175.32.253"), }, { System.Net.IPAddress.Parse("155.162.185.152"), System.Net.IPAddress.Parse("7.244.0.187"), System.Net.IPAddress.Parse("77.94.169.26"), }, { System.Net.IPAddress.Parse("212.96.190.105"), System.Net.IPAddress.Parse("86.58.29.68"), System.Net.IPAddress.Parse("114.203.48.173"), }, }, { { System.Net.IPAddress.Parse("118.242.171.191"), System.Net.IPAddress.Parse("88.51.89.137"), System.Net.IPAddress.Parse("238.145.198.167"), }, { System.Net.IPAddress.Parse("250.170.137.80"), System.Net.IPAddress.Parse("251.203.105.78"), System.Net.IPAddress.Parse("170.83.186.153"), }, { System.Net.IPAddress.Parse("82.73.46.117"), System.Net.IPAddress.Parse("126.250.38.146"), System.Net.IPAddress.Parse("110.1.110.113"), }, }, },
    ModelInner = new IPAddressinetMMArrayD3E1MI
{
    Id = 20,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("164.226.85.36"), System.Net.IPAddress.Parse("43.77.174.96"), System.Net.IPAddress.Parse("86.27.227.207"), }, { System.Net.IPAddress.Parse("242.134.121.128"), System.Net.IPAddress.Parse("237.19.252.94"), System.Net.IPAddress.Parse("218.75.119.194"), }, { System.Net.IPAddress.Parse("166.166.240.78"), System.Net.IPAddress.Parse("158.135.212.237"), System.Net.IPAddress.Parse("70.104.232.223"), }, }, { { System.Net.IPAddress.Parse("26.98.135.165"), System.Net.IPAddress.Parse("102.247.140.206"), System.Net.IPAddress.Parse("251.203.238.48"), }, { System.Net.IPAddress.Parse("53.32.165.147"), System.Net.IPAddress.Parse("251.37.224.71"), System.Net.IPAddress.Parse("82.137.148.83"), }, { System.Net.IPAddress.Parse("147.196.245.127"), System.Net.IPAddress.Parse("151.61.241.190"), System.Net.IPAddress.Parse("182.148.7.216"), }, }, { { System.Net.IPAddress.Parse("0.91.27.9"), System.Net.IPAddress.Parse("86.189.162.230"), System.Net.IPAddress.Parse("81.246.67.53"), }, { System.Net.IPAddress.Parse("185.56.225.253"), System.Net.IPAddress.Parse("239.31.151.236"), System.Net.IPAddress.Parse("86.232.184.212"), }, { System.Net.IPAddress.Parse("49.111.11.156"), System.Net.IPAddress.Parse("104.217.25.137"), System.Net.IPAddress.Parse("79.109.235.111"), }, }, },
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("68.80.200.138"), System.Net.IPAddress.Parse("46.98.168.34"), System.Net.IPAddress.Parse("13.24.100.172"), }, { System.Net.IPAddress.Parse("99.170.159.115"), System.Net.IPAddress.Parse("109.167.123.133"), System.Net.IPAddress.Parse("227.33.236.170"), }, { System.Net.IPAddress.Parse("45.13.191.24"), System.Net.IPAddress.Parse("154.35.186.82"), System.Net.IPAddress.Parse("40.185.37.216"), }, }, { { System.Net.IPAddress.Parse("173.22.14.166"), System.Net.IPAddress.Parse("245.28.148.83"), System.Net.IPAddress.Parse("158.99.16.124"), }, { System.Net.IPAddress.Parse("60.162.248.9"), System.Net.IPAddress.Parse("135.22.215.184"), System.Net.IPAddress.Parse("224.7.14.210"), }, { System.Net.IPAddress.Parse("103.92.138.236"), System.Net.IPAddress.Parse("80.94.249.245"), System.Net.IPAddress.Parse("73.89.210.71"), }, }, { { System.Net.IPAddress.Parse("168.10.23.101"), System.Net.IPAddress.Parse("59.63.191.38"), System.Net.IPAddress.Parse("113.156.154.58"), }, { System.Net.IPAddress.Parse("67.75.247.29"), System.Net.IPAddress.Parse("189.178.64.24"), System.Net.IPAddress.Parse("232.94.122.34"), }, { System.Net.IPAddress.Parse("222.249.111.199"), System.Net.IPAddress.Parse("212.22.236.64"), System.Net.IPAddress.Parse("26.130.155.132"), }, }, },
},
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("132.33.221.102"), System.Net.IPAddress.Parse("215.105.224.66"), System.Net.IPAddress.Parse("62.55.10.52"), }, { System.Net.IPAddress.Parse("168.69.84.40"), System.Net.IPAddress.Parse("207.32.65.155"), System.Net.IPAddress.Parse("51.145.159.147"), }, { System.Net.IPAddress.Parse("31.85.230.149"), System.Net.IPAddress.Parse("124.130.63.186"), System.Net.IPAddress.Parse("26.95.178.194"), }, }, { { System.Net.IPAddress.Parse("185.73.224.51"), System.Net.IPAddress.Parse("18.63.136.152"), System.Net.IPAddress.Parse("69.163.180.42"), }, { System.Net.IPAddress.Parse("73.107.34.160"), System.Net.IPAddress.Parse("53.146.227.148"), System.Net.IPAddress.Parse("161.2.214.231"), }, { System.Net.IPAddress.Parse("53.127.166.115"), System.Net.IPAddress.Parse("59.178.173.239"), System.Net.IPAddress.Parse("73.243.33.217"), }, }, { { System.Net.IPAddress.Parse("205.245.53.113"), System.Net.IPAddress.Parse("238.35.252.90"), System.Net.IPAddress.Parse("96.233.54.56"), }, { System.Net.IPAddress.Parse("136.81.93.146"), System.Net.IPAddress.Parse("71.181.102.194"), System.Net.IPAddress.Parse("38.137.139.146"), }, { System.Net.IPAddress.Parse("19.94.194.30"), System.Net.IPAddress.Parse("143.139.156.225"), System.Net.IPAddress.Parse("102.221.118.168"), }, }, },
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 52,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("43.97.211.108"), System.Net.IPAddress.Parse("129.220.106.194"), System.Net.IPAddress.Parse("179.152.219.247"), }, { System.Net.IPAddress.Parse("188.124.60.14"), System.Net.IPAddress.Parse("99.200.39.116"), System.Net.IPAddress.Parse("103.209.201.157"), }, { System.Net.IPAddress.Parse("192.204.189.244"), System.Net.IPAddress.Parse("220.165.43.85"), System.Net.IPAddress.Parse("89.214.224.156"), }, }, { { System.Net.IPAddress.Parse("91.31.203.98"), System.Net.IPAddress.Parse("2.214.165.18"), System.Net.IPAddress.Parse("192.41.244.48"), }, { System.Net.IPAddress.Parse("189.172.15.135"), System.Net.IPAddress.Parse("83.69.160.179"), System.Net.IPAddress.Parse("10.62.37.173"), }, { System.Net.IPAddress.Parse("200.236.178.38"), System.Net.IPAddress.Parse("112.32.235.244"), System.Net.IPAddress.Parse("102.73.188.47"), }, }, { { System.Net.IPAddress.Parse("4.194.118.202"), System.Net.IPAddress.Parse("186.173.8.253"), System.Net.IPAddress.Parse("13.107.141.181"), }, { System.Net.IPAddress.Parse("105.249.42.140"), System.Net.IPAddress.Parse("36.156.214.213"), System.Net.IPAddress.Parse("29.13.104.108"), }, { System.Net.IPAddress.Parse("87.60.112.41"), System.Net.IPAddress.Parse("205.206.129.39"), System.Net.IPAddress.Parse("129.53.179.243"), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 57,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("64.164.169.137"), System.Net.IPAddress.Parse("248.150.165.134"), System.Net.IPAddress.Parse("30.110.219.30"), }, { System.Net.IPAddress.Parse("175.170.41.119"), System.Net.IPAddress.Parse("221.58.135.185"), System.Net.IPAddress.Parse("194.35.137.45"), }, { System.Net.IPAddress.Parse("114.50.54.47"), System.Net.IPAddress.Parse("34.252.56.6"), System.Net.IPAddress.Parse("250.146.92.165"), }, }, { { System.Net.IPAddress.Parse("23.23.214.220"), System.Net.IPAddress.Parse("49.159.227.120"), System.Net.IPAddress.Parse("1.2.172.219"), }, { System.Net.IPAddress.Parse("15.118.73.208"), System.Net.IPAddress.Parse("209.178.30.132"), System.Net.IPAddress.Parse("90.10.123.46"), }, { System.Net.IPAddress.Parse("139.253.129.76"), System.Net.IPAddress.Parse("158.43.239.35"), System.Net.IPAddress.Parse("244.164.50.228"), }, }, { { System.Net.IPAddress.Parse("93.241.201.229"), System.Net.IPAddress.Parse("148.190.35.34"), System.Net.IPAddress.Parse("224.230.14.0"), }, { System.Net.IPAddress.Parse("41.223.150.236"), System.Net.IPAddress.Parse("96.220.22.113"), System.Net.IPAddress.Parse("47.129.34.162"), }, { System.Net.IPAddress.Parse("136.134.36.132"), System.Net.IPAddress.Parse("150.252.141.156"), System.Net.IPAddress.Parse("105.35.123.157"), }, }, },
    ModelInner = new IPAddressinetMMArrayD3E1MI
{
    Id = 21,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("176.237.147.204"), System.Net.IPAddress.Parse("112.60.9.143"), System.Net.IPAddress.Parse("15.174.89.105"), }, { System.Net.IPAddress.Parse("230.106.179.101"), System.Net.IPAddress.Parse("212.50.231.241"), System.Net.IPAddress.Parse("137.194.161.6"), }, { System.Net.IPAddress.Parse("108.47.200.178"), System.Net.IPAddress.Parse("192.121.83.207"), System.Net.IPAddress.Parse("55.209.188.74"), }, }, { { System.Net.IPAddress.Parse("33.162.122.204"), System.Net.IPAddress.Parse("56.195.114.67"), System.Net.IPAddress.Parse("107.105.251.217"), }, { System.Net.IPAddress.Parse("211.205.10.231"), System.Net.IPAddress.Parse("3.37.135.25"), System.Net.IPAddress.Parse("108.170.176.44"), }, { System.Net.IPAddress.Parse("86.191.191.35"), System.Net.IPAddress.Parse("126.108.233.250"), System.Net.IPAddress.Parse("17.247.45.71"), }, }, { { System.Net.IPAddress.Parse("212.199.7.132"), System.Net.IPAddress.Parse("26.126.166.48"), System.Net.IPAddress.Parse("239.240.26.111"), }, { System.Net.IPAddress.Parse("96.171.31.8"), System.Net.IPAddress.Parse("49.13.251.178"), System.Net.IPAddress.Parse("220.163.14.132"), }, { System.Net.IPAddress.Parse("43.23.79.206"), System.Net.IPAddress.Parse("59.30.31.203"), System.Net.IPAddress.Parse("124.198.241.217"), }, }, },
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("108.136.18.184"), System.Net.IPAddress.Parse("213.102.52.252"), System.Net.IPAddress.Parse("8.174.35.240"), }, { System.Net.IPAddress.Parse("71.233.224.136"), System.Net.IPAddress.Parse("254.250.24.12"), System.Net.IPAddress.Parse("10.252.75.35"), }, { System.Net.IPAddress.Parse("197.22.216.110"), System.Net.IPAddress.Parse("5.133.95.131"), System.Net.IPAddress.Parse("232.179.104.116"), }, }, { { System.Net.IPAddress.Parse("68.242.29.248"), System.Net.IPAddress.Parse("221.15.127.14"), System.Net.IPAddress.Parse("178.49.249.37"), }, { System.Net.IPAddress.Parse("170.95.234.150"), System.Net.IPAddress.Parse("131.10.142.251"), System.Net.IPAddress.Parse("85.78.6.58"), }, { System.Net.IPAddress.Parse("193.182.177.105"), System.Net.IPAddress.Parse("87.52.66.107"), System.Net.IPAddress.Parse("61.200.158.37"), }, }, { { System.Net.IPAddress.Parse("4.229.31.172"), System.Net.IPAddress.Parse("85.142.161.78"), System.Net.IPAddress.Parse("110.129.230.203"), }, { System.Net.IPAddress.Parse("1.27.60.190"), System.Net.IPAddress.Parse("194.72.103.96"), System.Net.IPAddress.Parse("132.167.238.78"), }, { System.Net.IPAddress.Parse("182.42.118.67"), System.Net.IPAddress.Parse("133.254.99.183"), System.Net.IPAddress.Parse("78.118.206.182"), }, }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 61,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("222.28.2.219"), System.Net.IPAddress.Parse("27.196.100.150"), System.Net.IPAddress.Parse("82.119.250.95"), }, { System.Net.IPAddress.Parse("105.25.140.10"), System.Net.IPAddress.Parse("101.90.78.23"), System.Net.IPAddress.Parse("147.204.4.79"), }, { System.Net.IPAddress.Parse("139.14.239.196"), System.Net.IPAddress.Parse("95.104.191.190"), System.Net.IPAddress.Parse("235.3.215.177"), }, }, { { System.Net.IPAddress.Parse("150.70.11.49"), System.Net.IPAddress.Parse("160.62.191.61"), System.Net.IPAddress.Parse("146.118.16.109"), }, { System.Net.IPAddress.Parse("5.161.39.198"), System.Net.IPAddress.Parse("5.53.155.141"), System.Net.IPAddress.Parse("13.250.158.0"), }, { System.Net.IPAddress.Parse("102.239.128.25"), System.Net.IPAddress.Parse("250.92.39.142"), System.Net.IPAddress.Parse("228.56.123.28"), }, }, { { System.Net.IPAddress.Parse("227.136.48.113"), System.Net.IPAddress.Parse("100.57.180.219"), System.Net.IPAddress.Parse("192.53.167.40"), }, { System.Net.IPAddress.Parse("103.57.120.131"), System.Net.IPAddress.Parse("50.104.123.155"), System.Net.IPAddress.Parse("133.30.23.15"), }, { System.Net.IPAddress.Parse("130.122.51.1"), System.Net.IPAddress.Parse("81.136.237.227"), System.Net.IPAddress.Parse("117.183.20.23"), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 66,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("42.169.243.36"), System.Net.IPAddress.Parse("87.142.129.220"), System.Net.IPAddress.Parse("107.209.120.48"), }, { System.Net.IPAddress.Parse("122.11.54.90"), System.Net.IPAddress.Parse("208.131.240.86"), System.Net.IPAddress.Parse("107.197.83.147"), }, { System.Net.IPAddress.Parse("240.20.142.83"), System.Net.IPAddress.Parse("127.42.112.36"), System.Net.IPAddress.Parse("2.44.52.75"), }, }, { { System.Net.IPAddress.Parse("237.53.182.161"), System.Net.IPAddress.Parse("194.173.219.64"), System.Net.IPAddress.Parse("248.169.18.138"), }, { System.Net.IPAddress.Parse("248.157.10.142"), System.Net.IPAddress.Parse("69.110.74.32"), System.Net.IPAddress.Parse("85.45.56.85"), }, { System.Net.IPAddress.Parse("217.184.236.224"), System.Net.IPAddress.Parse("26.111.0.14"), System.Net.IPAddress.Parse("103.247.196.177"), }, }, { { System.Net.IPAddress.Parse("211.92.173.112"), System.Net.IPAddress.Parse("250.91.105.179"), System.Net.IPAddress.Parse("2.58.147.63"), }, { System.Net.IPAddress.Parse("153.220.172.66"), System.Net.IPAddress.Parse("162.166.105.7"), System.Net.IPAddress.Parse("247.223.251.225"), }, { System.Net.IPAddress.Parse("38.20.116.69"), System.Net.IPAddress.Parse("100.212.238.82"), System.Net.IPAddress.Parse("113.107.220.76"), }, }, },
    ModelInner = new IPAddressinetMMArrayD3E1MI
{
    Id = 28,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("243.1.4.17"), System.Net.IPAddress.Parse("128.163.146.7"), System.Net.IPAddress.Parse("157.31.212.127"), }, { System.Net.IPAddress.Parse("125.114.37.127"), System.Net.IPAddress.Parse("173.95.163.231"), System.Net.IPAddress.Parse("140.225.161.112"), }, { System.Net.IPAddress.Parse("155.78.159.177"), System.Net.IPAddress.Parse("43.0.43.165"), System.Net.IPAddress.Parse("189.170.192.207"), }, }, { { System.Net.IPAddress.Parse("5.92.193.239"), System.Net.IPAddress.Parse("240.54.118.24"), System.Net.IPAddress.Parse("25.24.55.218"), }, { System.Net.IPAddress.Parse("16.119.32.152"), System.Net.IPAddress.Parse("103.43.137.133"), System.Net.IPAddress.Parse("205.120.219.139"), }, { System.Net.IPAddress.Parse("66.117.114.25"), System.Net.IPAddress.Parse("25.213.246.89"), System.Net.IPAddress.Parse("168.3.236.1"), }, }, { { System.Net.IPAddress.Parse("48.69.131.8"), System.Net.IPAddress.Parse("226.182.17.127"), System.Net.IPAddress.Parse("162.77.103.164"), }, { System.Net.IPAddress.Parse("242.252.246.172"), System.Net.IPAddress.Parse("59.87.120.47"), System.Net.IPAddress.Parse("77.68.93.208"), }, { System.Net.IPAddress.Parse("108.83.22.221"), System.Net.IPAddress.Parse("119.43.229.61"), System.Net.IPAddress.Parse("7.24.232.30"), }, }, },
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("98.151.46.229"), System.Net.IPAddress.Parse("28.150.158.73"), System.Net.IPAddress.Parse("154.121.57.230"), }, { System.Net.IPAddress.Parse("170.58.22.94"), System.Net.IPAddress.Parse("106.207.41.219"), System.Net.IPAddress.Parse("81.185.8.168"), }, { System.Net.IPAddress.Parse("233.242.214.231"), System.Net.IPAddress.Parse("55.15.137.188"), System.Net.IPAddress.Parse("241.87.51.30"), }, }, { { System.Net.IPAddress.Parse("92.20.75.209"), System.Net.IPAddress.Parse("107.83.189.74"), System.Net.IPAddress.Parse("9.146.157.42"), }, { System.Net.IPAddress.Parse("92.57.142.17"), System.Net.IPAddress.Parse("192.122.173.56"), System.Net.IPAddress.Parse("111.144.15.198"), }, { System.Net.IPAddress.Parse("147.83.220.1"), System.Net.IPAddress.Parse("139.222.171.56"), System.Net.IPAddress.Parse("7.29.186.244"), }, }, { { System.Net.IPAddress.Parse("7.167.1.45"), System.Net.IPAddress.Parse("238.88.231.95"), System.Net.IPAddress.Parse("194.47.42.200"), }, { System.Net.IPAddress.Parse("163.231.226.83"), System.Net.IPAddress.Parse("114.58.98.230"), System.Net.IPAddress.Parse("240.59.51.117"), }, { System.Net.IPAddress.Parse("245.142.124.18"), System.Net.IPAddress.Parse("143.189.169.110"), System.Net.IPAddress.Parse("157.181.9.24"), }, }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 71,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("48.140.88.99"), System.Net.IPAddress.Parse("49.217.245.189"), System.Net.IPAddress.Parse("153.90.233.250"), }, { System.Net.IPAddress.Parse("55.193.151.232"), System.Net.IPAddress.Parse("162.195.143.221"), System.Net.IPAddress.Parse("80.75.117.223"), }, { System.Net.IPAddress.Parse("95.153.0.66"), System.Net.IPAddress.Parse("194.212.235.9"), System.Net.IPAddress.Parse("170.170.202.160"), }, }, { { System.Net.IPAddress.Parse("229.248.237.249"), System.Net.IPAddress.Parse("207.23.50.163"), System.Net.IPAddress.Parse("169.96.95.150"), }, { System.Net.IPAddress.Parse("158.19.150.22"), System.Net.IPAddress.Parse("83.140.185.102"), System.Net.IPAddress.Parse("75.72.187.9"), }, { System.Net.IPAddress.Parse("9.58.32.0"), System.Net.IPAddress.Parse("180.237.29.204"), System.Net.IPAddress.Parse("110.65.130.186"), }, }, { { System.Net.IPAddress.Parse("234.16.43.207"), System.Net.IPAddress.Parse("168.193.75.187"), System.Net.IPAddress.Parse("83.139.131.191"), }, { System.Net.IPAddress.Parse("16.203.73.136"), System.Net.IPAddress.Parse("22.218.195.224"), System.Net.IPAddress.Parse("170.160.198.161"), }, { System.Net.IPAddress.Parse("157.247.36.249"), System.Net.IPAddress.Parse("237.11.218.114"), System.Net.IPAddress.Parse("40.249.138.60"), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 73,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("140.48.114.155"), System.Net.IPAddress.Parse("147.53.14.45"), System.Net.IPAddress.Parse("252.226.46.223"), }, { System.Net.IPAddress.Parse("76.19.194.154"), System.Net.IPAddress.Parse("99.117.244.111"), System.Net.IPAddress.Parse("254.105.37.103"), }, { System.Net.IPAddress.Parse("2.150.96.3"), System.Net.IPAddress.Parse("123.26.244.44"), System.Net.IPAddress.Parse("147.3.113.72"), }, }, { { System.Net.IPAddress.Parse("167.148.237.110"), System.Net.IPAddress.Parse("247.90.190.206"), System.Net.IPAddress.Parse("4.237.98.31"), }, { System.Net.IPAddress.Parse("0.124.247.52"), System.Net.IPAddress.Parse("90.86.215.16"), System.Net.IPAddress.Parse("149.129.251.174"), }, { System.Net.IPAddress.Parse("153.108.135.49"), System.Net.IPAddress.Parse("181.142.213.102"), System.Net.IPAddress.Parse("159.19.186.214"), }, }, { { System.Net.IPAddress.Parse("97.97.214.202"), System.Net.IPAddress.Parse("34.201.23.182"), System.Net.IPAddress.Parse("15.18.55.75"), }, { System.Net.IPAddress.Parse("160.107.49.118"), System.Net.IPAddress.Parse("233.253.82.93"), System.Net.IPAddress.Parse("192.195.196.90"), }, { System.Net.IPAddress.Parse("179.135.0.216"), System.Net.IPAddress.Parse("110.85.153.59"), System.Net.IPAddress.Parse("135.73.5.22"), }, }, },
    ModelInner = new IPAddressinetMMArrayD3E1MI
{
    Id = 31,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("94.113.95.170"), System.Net.IPAddress.Parse("58.247.124.216"), System.Net.IPAddress.Parse("202.197.156.2"), }, { System.Net.IPAddress.Parse("70.90.254.92"), System.Net.IPAddress.Parse("86.114.235.111"), System.Net.IPAddress.Parse("94.155.80.154"), }, { System.Net.IPAddress.Parse("49.26.94.38"), System.Net.IPAddress.Parse("151.136.108.200"), System.Net.IPAddress.Parse("239.113.72.236"), }, }, { { System.Net.IPAddress.Parse("94.245.221.107"), System.Net.IPAddress.Parse("180.41.159.23"), System.Net.IPAddress.Parse("6.203.16.13"), }, { System.Net.IPAddress.Parse("219.228.12.160"), System.Net.IPAddress.Parse("158.163.228.105"), System.Net.IPAddress.Parse("229.177.4.253"), }, { System.Net.IPAddress.Parse("96.58.151.34"), System.Net.IPAddress.Parse("124.36.78.162"), System.Net.IPAddress.Parse("163.174.254.202"), }, }, { { System.Net.IPAddress.Parse("106.213.246.28"), System.Net.IPAddress.Parse("69.109.156.61"), System.Net.IPAddress.Parse("50.171.193.77"), }, { System.Net.IPAddress.Parse("0.78.121.248"), System.Net.IPAddress.Parse("235.36.140.193"), System.Net.IPAddress.Parse("200.235.92.125"), }, { System.Net.IPAddress.Parse("126.226.231.221"), System.Net.IPAddress.Parse("150.203.174.205"), System.Net.IPAddress.Parse("26.192.148.149"), }, }, },
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("122.126.199.173"), System.Net.IPAddress.Parse("38.132.200.3"), System.Net.IPAddress.Parse("198.94.9.20"), }, { System.Net.IPAddress.Parse("135.226.150.253"), System.Net.IPAddress.Parse("162.41.72.225"), System.Net.IPAddress.Parse("162.190.212.110"), }, { System.Net.IPAddress.Parse("222.236.155.31"), System.Net.IPAddress.Parse("163.79.206.47"), System.Net.IPAddress.Parse("211.86.200.13"), }, }, { { System.Net.IPAddress.Parse("136.174.29.213"), System.Net.IPAddress.Parse("16.35.248.63"), System.Net.IPAddress.Parse("208.238.47.117"), }, { System.Net.IPAddress.Parse("107.229.211.250"), System.Net.IPAddress.Parse("152.206.214.33"), System.Net.IPAddress.Parse("203.67.163.85"), }, { System.Net.IPAddress.Parse("211.67.10.206"), System.Net.IPAddress.Parse("162.244.29.48"), System.Net.IPAddress.Parse("112.132.76.21"), }, }, { { System.Net.IPAddress.Parse("68.4.171.115"), System.Net.IPAddress.Parse("59.195.203.15"), System.Net.IPAddress.Parse("220.222.142.105"), }, { System.Net.IPAddress.Parse("61.246.253.125"), System.Net.IPAddress.Parse("202.112.174.193"), System.Net.IPAddress.Parse("124.119.170.39"), }, { System.Net.IPAddress.Parse("85.71.83.112"), System.Net.IPAddress.Parse("106.200.110.211"), System.Net.IPAddress.Parse("184.224.84.164"), }, }, },
},
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("209.198.0.116"), System.Net.IPAddress.Parse("31.43.197.98"), System.Net.IPAddress.Parse("183.135.224.220"), }, { System.Net.IPAddress.Parse("95.118.62.39"), System.Net.IPAddress.Parse("209.174.60.133"), System.Net.IPAddress.Parse("48.53.130.20"), }, { System.Net.IPAddress.Parse("189.185.97.131"), System.Net.IPAddress.Parse("91.21.31.166"), System.Net.IPAddress.Parse("188.117.217.28"), }, }, { { System.Net.IPAddress.Parse("67.197.63.96"), System.Net.IPAddress.Parse("28.186.187.55"), System.Net.IPAddress.Parse("246.29.158.21"), }, { System.Net.IPAddress.Parse("228.224.252.254"), System.Net.IPAddress.Parse("143.205.59.98"), System.Net.IPAddress.Parse("209.87.123.66"), }, { System.Net.IPAddress.Parse("138.104.39.208"), System.Net.IPAddress.Parse("115.235.40.243"), System.Net.IPAddress.Parse("14.104.225.36"), }, }, { { System.Net.IPAddress.Parse("160.250.133.224"), System.Net.IPAddress.Parse("8.140.158.122"), System.Net.IPAddress.Parse("93.34.151.170"), }, { System.Net.IPAddress.Parse("181.184.133.30"), System.Net.IPAddress.Parse("103.62.74.24"), System.Net.IPAddress.Parse("179.204.53.203"), }, { System.Net.IPAddress.Parse("130.143.28.183"), System.Net.IPAddress.Parse("158.229.18.143"), System.Net.IPAddress.Parse("103.55.50.251"), }, }, },
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 77,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("133.6.87.251"), System.Net.IPAddress.Parse("230.254.120.237"), System.Net.IPAddress.Parse("195.198.222.173"), }, { System.Net.IPAddress.Parse("147.79.31.182"), System.Net.IPAddress.Parse("98.158.103.115"), System.Net.IPAddress.Parse("242.109.190.208"), }, { System.Net.IPAddress.Parse("138.17.150.60"), System.Net.IPAddress.Parse("34.226.199.131"), System.Net.IPAddress.Parse("90.250.89.4"), }, }, { { System.Net.IPAddress.Parse("101.233.163.160"), System.Net.IPAddress.Parse("148.23.221.45"), System.Net.IPAddress.Parse("180.221.191.236"), }, { System.Net.IPAddress.Parse("72.190.231.195"), System.Net.IPAddress.Parse("69.235.41.133"), System.Net.IPAddress.Parse("58.215.15.250"), }, { System.Net.IPAddress.Parse("156.100.54.90"), System.Net.IPAddress.Parse("15.165.212.179"), System.Net.IPAddress.Parse("192.126.154.33"), }, }, { { System.Net.IPAddress.Parse("128.214.61.125"), System.Net.IPAddress.Parse("145.53.61.176"), System.Net.IPAddress.Parse("21.5.107.177"), }, { System.Net.IPAddress.Parse("67.45.166.141"), System.Net.IPAddress.Parse("180.36.104.198"), System.Net.IPAddress.Parse("190.48.110.83"), }, { System.Net.IPAddress.Parse("253.21.250.138"), System.Net.IPAddress.Parse("65.88.227.69"), System.Net.IPAddress.Parse("246.133.147.76"), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("91.227.142.46"), System.Net.IPAddress.Parse("150.24.52.24"), System.Net.IPAddress.Parse("91.3.81.248"), }, { System.Net.IPAddress.Parse("52.243.3.86"), System.Net.IPAddress.Parse("96.172.52.175"), System.Net.IPAddress.Parse("250.169.58.244"), }, { System.Net.IPAddress.Parse("145.230.107.164"), System.Net.IPAddress.Parse("145.177.127.235"), System.Net.IPAddress.Parse("185.234.127.2"), }, }, { { System.Net.IPAddress.Parse("206.231.155.118"), System.Net.IPAddress.Parse("110.70.82.220"), System.Net.IPAddress.Parse("147.204.162.174"), }, { System.Net.IPAddress.Parse("13.139.50.123"), System.Net.IPAddress.Parse("88.245.127.148"), System.Net.IPAddress.Parse("191.218.126.89"), }, { System.Net.IPAddress.Parse("182.83.13.97"), System.Net.IPAddress.Parse("51.216.173.190"), System.Net.IPAddress.Parse("223.148.152.122"), }, }, { { System.Net.IPAddress.Parse("121.100.169.134"), System.Net.IPAddress.Parse("125.168.92.154"), System.Net.IPAddress.Parse("42.115.0.172"), }, { System.Net.IPAddress.Parse("161.84.167.161"), System.Net.IPAddress.Parse("43.155.115.43"), System.Net.IPAddress.Parse("25.7.29.242"), }, { System.Net.IPAddress.Parse("185.26.73.145"), System.Net.IPAddress.Parse("125.26.89.4"), System.Net.IPAddress.Parse("83.220.21.3"), }, }, },
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 84,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("218.73.158.6"), System.Net.IPAddress.Parse("185.207.192.63"), System.Net.IPAddress.Parse("72.236.149.206"), }, { System.Net.IPAddress.Parse("32.56.31.139"), System.Net.IPAddress.Parse("100.173.76.147"), System.Net.IPAddress.Parse("10.96.39.251"), }, { System.Net.IPAddress.Parse("173.64.136.211"), System.Net.IPAddress.Parse("138.9.186.88"), System.Net.IPAddress.Parse("204.22.75.7"), }, }, { { System.Net.IPAddress.Parse("190.239.12.153"), System.Net.IPAddress.Parse("24.243.174.181"), System.Net.IPAddress.Parse("83.180.242.175"), }, { System.Net.IPAddress.Parse("45.224.24.17"), System.Net.IPAddress.Parse("153.131.152.169"), System.Net.IPAddress.Parse("47.200.194.129"), }, { System.Net.IPAddress.Parse("93.89.19.12"), System.Net.IPAddress.Parse("254.95.0.188"), System.Net.IPAddress.Parse("98.88.7.253"), }, }, { { System.Net.IPAddress.Parse("211.146.141.221"), System.Net.IPAddress.Parse("254.140.217.167"), System.Net.IPAddress.Parse("174.147.157.193"), }, { System.Net.IPAddress.Parse("16.5.225.185"), System.Net.IPAddress.Parse("28.233.213.114"), System.Net.IPAddress.Parse("199.56.20.12"), }, { System.Net.IPAddress.Parse("4.52.15.108"), System.Net.IPAddress.Parse("231.253.164.114"), System.Net.IPAddress.Parse("223.174.94.159"), }, }, },
    ModelInner = new IPAddressinetMMArrayD3E1MI
{
    Id = 40,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("114.185.248.80"), System.Net.IPAddress.Parse("111.180.96.214"), System.Net.IPAddress.Parse("117.58.58.60"), }, { System.Net.IPAddress.Parse("251.19.43.218"), System.Net.IPAddress.Parse("79.210.114.115"), System.Net.IPAddress.Parse("1.82.233.0"), }, { System.Net.IPAddress.Parse("175.20.123.105"), System.Net.IPAddress.Parse("123.172.244.173"), System.Net.IPAddress.Parse("75.80.150.232"), }, }, { { System.Net.IPAddress.Parse("74.253.142.70"), System.Net.IPAddress.Parse("148.70.32.193"), System.Net.IPAddress.Parse("104.23.221.52"), }, { System.Net.IPAddress.Parse("129.132.1.230"), System.Net.IPAddress.Parse("3.105.140.33"), System.Net.IPAddress.Parse("246.178.16.71"), }, { System.Net.IPAddress.Parse("247.249.208.211"), System.Net.IPAddress.Parse("70.238.233.124"), System.Net.IPAddress.Parse("15.30.108.180"), }, }, { { System.Net.IPAddress.Parse("33.101.248.33"), System.Net.IPAddress.Parse("227.69.176.185"), System.Net.IPAddress.Parse("145.73.252.210"), }, { System.Net.IPAddress.Parse("211.129.111.203"), System.Net.IPAddress.Parse("30.134.165.68"), System.Net.IPAddress.Parse("239.237.49.125"), }, { System.Net.IPAddress.Parse("156.7.170.166"), System.Net.IPAddress.Parse("28.127.64.172"), System.Net.IPAddress.Parse("95.221.72.232"), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("20.148.16.248"), System.Net.IPAddress.Parse("225.245.218.80"), System.Net.IPAddress.Parse("21.161.64.190"), }, { System.Net.IPAddress.Parse("112.49.46.215"), System.Net.IPAddress.Parse("79.92.248.239"), System.Net.IPAddress.Parse("26.19.119.63"), }, { System.Net.IPAddress.Parse("100.71.12.47"), System.Net.IPAddress.Parse("149.161.154.173"), System.Net.IPAddress.Parse("110.32.202.129"), }, }, { { System.Net.IPAddress.Parse("174.13.128.203"), System.Net.IPAddress.Parse("185.147.157.32"), System.Net.IPAddress.Parse("138.188.213.152"), }, { System.Net.IPAddress.Parse("148.17.200.46"), System.Net.IPAddress.Parse("14.71.47.21"), System.Net.IPAddress.Parse("191.168.125.49"), }, { System.Net.IPAddress.Parse("49.70.237.101"), System.Net.IPAddress.Parse("248.129.135.203"), System.Net.IPAddress.Parse("237.16.1.228"), }, }, { { System.Net.IPAddress.Parse("188.163.10.249"), System.Net.IPAddress.Parse("142.111.51.221"), System.Net.IPAddress.Parse("241.129.101.203"), }, { System.Net.IPAddress.Parse("24.231.91.38"), System.Net.IPAddress.Parse("247.47.252.234"), System.Net.IPAddress.Parse("210.225.222.61"), }, { System.Net.IPAddress.Parse("211.196.53.129"), System.Net.IPAddress.Parse("11.91.131.237"), System.Net.IPAddress.Parse("45.211.177.81"), }, }, },
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 87,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("94.54.11.122"), System.Net.IPAddress.Parse("222.90.183.70"), System.Net.IPAddress.Parse("154.60.21.76"), }, { System.Net.IPAddress.Parse("106.141.52.167"), System.Net.IPAddress.Parse("123.241.84.45"), System.Net.IPAddress.Parse("122.35.135.240"), }, { System.Net.IPAddress.Parse("35.111.180.143"), System.Net.IPAddress.Parse("29.244.139.188"), System.Net.IPAddress.Parse("169.25.53.29"), }, }, { { System.Net.IPAddress.Parse("179.240.58.164"), System.Net.IPAddress.Parse("94.100.252.172"), System.Net.IPAddress.Parse("233.36.89.128"), }, { System.Net.IPAddress.Parse("151.125.173.115"), System.Net.IPAddress.Parse("111.121.123.129"), System.Net.IPAddress.Parse("25.202.148.229"), }, { System.Net.IPAddress.Parse("237.210.49.36"), System.Net.IPAddress.Parse("20.81.223.152"), System.Net.IPAddress.Parse("150.161.87.134"), }, }, { { System.Net.IPAddress.Parse("133.48.218.34"), System.Net.IPAddress.Parse("176.152.111.111"), System.Net.IPAddress.Parse("202.117.204.56"), }, { System.Net.IPAddress.Parse("27.242.173.106"), System.Net.IPAddress.Parse("175.156.213.228"), System.Net.IPAddress.Parse("164.135.217.250"), }, { System.Net.IPAddress.Parse("202.95.172.46"), System.Net.IPAddress.Parse("111.139.237.9"), System.Net.IPAddress.Parse("94.206.226.112"), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 88,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("44.88.28.114"), System.Net.IPAddress.Parse("187.230.201.147"), System.Net.IPAddress.Parse("66.125.188.237"), }, { System.Net.IPAddress.Parse("185.226.22.165"), System.Net.IPAddress.Parse("145.15.50.169"), System.Net.IPAddress.Parse("221.102.94.201"), }, { System.Net.IPAddress.Parse("217.211.206.12"), System.Net.IPAddress.Parse("81.89.243.41"), System.Net.IPAddress.Parse("203.155.184.245"), }, }, { { System.Net.IPAddress.Parse("12.229.210.184"), System.Net.IPAddress.Parse("97.184.2.245"), System.Net.IPAddress.Parse("38.11.118.63"), }, { System.Net.IPAddress.Parse("213.243.111.123"), System.Net.IPAddress.Parse("108.248.128.208"), System.Net.IPAddress.Parse("151.190.96.14"), }, { System.Net.IPAddress.Parse("140.124.193.126"), System.Net.IPAddress.Parse("29.211.57.185"), System.Net.IPAddress.Parse("151.111.228.24"), }, }, { { System.Net.IPAddress.Parse("94.50.64.140"), System.Net.IPAddress.Parse("84.222.225.210"), System.Net.IPAddress.Parse("218.234.111.144"), }, { System.Net.IPAddress.Parse("157.135.223.3"), System.Net.IPAddress.Parse("110.80.131.32"), System.Net.IPAddress.Parse("190.51.4.122"), }, { System.Net.IPAddress.Parse("101.226.139.147"), System.Net.IPAddress.Parse("224.191.186.8"), System.Net.IPAddress.Parse("226.77.108.30"), }, }, },
    ModelInner = new IPAddressinetMMArrayD3E1MI
{
    Id = 42,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("218.189.121.89"), System.Net.IPAddress.Parse("109.98.248.171"), System.Net.IPAddress.Parse("84.68.163.225"), }, { System.Net.IPAddress.Parse("84.91.51.240"), System.Net.IPAddress.Parse("136.141.8.149"), System.Net.IPAddress.Parse("24.228.158.155"), }, { System.Net.IPAddress.Parse("157.159.44.178"), System.Net.IPAddress.Parse("51.148.162.69"), System.Net.IPAddress.Parse("205.16.13.33"), }, }, { { System.Net.IPAddress.Parse("204.181.2.28"), System.Net.IPAddress.Parse("58.22.149.224"), System.Net.IPAddress.Parse("52.79.52.184"), }, { System.Net.IPAddress.Parse("74.129.178.178"), System.Net.IPAddress.Parse("90.105.97.249"), System.Net.IPAddress.Parse("87.22.145.63"), }, { System.Net.IPAddress.Parse("58.28.15.242"), System.Net.IPAddress.Parse("99.101.184.88"), System.Net.IPAddress.Parse("106.117.253.94"), }, }, { { System.Net.IPAddress.Parse("13.207.7.72"), System.Net.IPAddress.Parse("40.128.0.144"), System.Net.IPAddress.Parse("71.109.131.111"), }, { System.Net.IPAddress.Parse("52.66.107.107"), System.Net.IPAddress.Parse("197.88.151.78"), System.Net.IPAddress.Parse("80.253.201.150"), }, { System.Net.IPAddress.Parse("224.121.62.64"), System.Net.IPAddress.Parse("55.149.5.171"), System.Net.IPAddress.Parse("244.115.218.52"), }, }, },
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("93.180.32.6"), System.Net.IPAddress.Parse("103.246.33.85"), System.Net.IPAddress.Parse("155.213.224.93"), }, { System.Net.IPAddress.Parse("102.39.133.165"), System.Net.IPAddress.Parse("192.214.122.16"), System.Net.IPAddress.Parse("2.2.142.196"), }, { System.Net.IPAddress.Parse("71.187.186.237"), System.Net.IPAddress.Parse("117.149.135.10"), System.Net.IPAddress.Parse("83.225.127.17"), }, }, { { System.Net.IPAddress.Parse("37.226.154.251"), System.Net.IPAddress.Parse("140.11.198.191"), System.Net.IPAddress.Parse("229.240.164.239"), }, { System.Net.IPAddress.Parse("209.134.70.58"), System.Net.IPAddress.Parse("160.65.80.3"), System.Net.IPAddress.Parse("205.89.90.35"), }, { System.Net.IPAddress.Parse("184.231.99.200"), System.Net.IPAddress.Parse("120.100.81.156"), System.Net.IPAddress.Parse("141.94.39.227"), }, }, { { System.Net.IPAddress.Parse("82.194.157.45"), System.Net.IPAddress.Parse("195.115.182.140"), System.Net.IPAddress.Parse("40.140.102.200"), }, { System.Net.IPAddress.Parse("28.31.188.217"), System.Net.IPAddress.Parse("5.54.179.152"), System.Net.IPAddress.Parse("134.33.117.41"), }, { System.Net.IPAddress.Parse("14.179.111.195"), System.Net.IPAddress.Parse("230.39.74.111"), System.Net.IPAddress.Parse("136.94.64.3"), }, }, },
},
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("44.23.98.72"), System.Net.IPAddress.Parse("175.116.218.3"), System.Net.IPAddress.Parse("35.116.29.207"), }, { System.Net.IPAddress.Parse("109.28.198.126"), System.Net.IPAddress.Parse("204.69.64.63"), System.Net.IPAddress.Parse("81.220.107.51"), }, { System.Net.IPAddress.Parse("51.65.21.35"), System.Net.IPAddress.Parse("184.214.248.221"), System.Net.IPAddress.Parse("212.26.102.32"), }, }, { { System.Net.IPAddress.Parse("234.117.108.241"), System.Net.IPAddress.Parse("101.102.237.221"), System.Net.IPAddress.Parse("153.165.1.3"), }, { System.Net.IPAddress.Parse("51.195.200.1"), System.Net.IPAddress.Parse("248.248.96.146"), System.Net.IPAddress.Parse("218.142.5.100"), }, { System.Net.IPAddress.Parse("141.199.68.126"), System.Net.IPAddress.Parse("161.141.173.16"), System.Net.IPAddress.Parse("60.149.107.225"), }, }, { { System.Net.IPAddress.Parse("181.88.90.108"), System.Net.IPAddress.Parse("244.117.82.197"), System.Net.IPAddress.Parse("193.73.73.127"), }, { System.Net.IPAddress.Parse("82.166.13.52"), System.Net.IPAddress.Parse("89.29.245.60"), System.Net.IPAddress.Parse("77.64.86.143"), }, { System.Net.IPAddress.Parse("124.159.192.96"), System.Net.IPAddress.Parse("68.66.53.120"), System.Net.IPAddress.Parse("158.157.38.25"), }, }, },
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 97,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("69.74.169.191"), System.Net.IPAddress.Parse("219.38.223.200"), System.Net.IPAddress.Parse("180.17.2.103"), }, { System.Net.IPAddress.Parse("213.107.182.193"), System.Net.IPAddress.Parse("246.13.81.176"), System.Net.IPAddress.Parse("215.30.148.94"), }, { System.Net.IPAddress.Parse("56.179.161.191"), System.Net.IPAddress.Parse("155.43.215.29"), System.Net.IPAddress.Parse("33.106.13.97"), }, }, { { System.Net.IPAddress.Parse("131.143.128.145"), System.Net.IPAddress.Parse("156.164.240.61"), System.Net.IPAddress.Parse("190.54.191.80"), }, { System.Net.IPAddress.Parse("183.226.193.45"), System.Net.IPAddress.Parse("69.201.183.199"), System.Net.IPAddress.Parse("233.124.5.251"), }, { System.Net.IPAddress.Parse("115.97.59.15"), System.Net.IPAddress.Parse("30.189.223.92"), System.Net.IPAddress.Parse("150.80.201.231"), }, }, { { System.Net.IPAddress.Parse("11.126.70.114"), System.Net.IPAddress.Parse("179.197.220.172"), System.Net.IPAddress.Parse("197.98.85.172"), }, { System.Net.IPAddress.Parse("252.10.169.10"), System.Net.IPAddress.Parse("172.34.188.204"), System.Net.IPAddress.Parse("227.15.122.170"), }, { System.Net.IPAddress.Parse("125.16.189.192"), System.Net.IPAddress.Parse("221.249.194.2"), System.Net.IPAddress.Parse("83.50.231.220"), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 105,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("10.55.249.22"), System.Net.IPAddress.Parse("99.23.107.51"), System.Net.IPAddress.Parse("10.234.87.93"), }, { System.Net.IPAddress.Parse("67.12.123.92"), System.Net.IPAddress.Parse("195.117.38.61"), System.Net.IPAddress.Parse("64.136.2.247"), }, { System.Net.IPAddress.Parse("111.215.247.119"), System.Net.IPAddress.Parse("70.89.79.165"), System.Net.IPAddress.Parse("58.112.33.202"), }, }, { { System.Net.IPAddress.Parse("154.102.161.44"), System.Net.IPAddress.Parse("245.39.93.81"), System.Net.IPAddress.Parse("221.44.114.29"), }, { System.Net.IPAddress.Parse("186.128.64.55"), System.Net.IPAddress.Parse("156.167.89.252"), System.Net.IPAddress.Parse("186.184.99.155"), }, { System.Net.IPAddress.Parse("225.62.38.98"), System.Net.IPAddress.Parse("238.2.247.44"), System.Net.IPAddress.Parse("38.73.236.200"), }, }, { { System.Net.IPAddress.Parse("105.182.88.21"), System.Net.IPAddress.Parse("17.36.242.237"), System.Net.IPAddress.Parse("236.89.78.210"), }, { System.Net.IPAddress.Parse("172.234.83.63"), System.Net.IPAddress.Parse("151.39.62.148"), System.Net.IPAddress.Parse("171.71.192.218"), }, { System.Net.IPAddress.Parse("176.98.118.60"), System.Net.IPAddress.Parse("226.7.139.41"), System.Net.IPAddress.Parse("179.47.233.81"), }, }, },
    ModelInner = new IPAddressinetMMArrayD3E1MI
{
    Id = 51,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("34.155.208.224"), System.Net.IPAddress.Parse("215.56.105.59"), System.Net.IPAddress.Parse("77.220.185.239"), }, { System.Net.IPAddress.Parse("20.18.221.208"), System.Net.IPAddress.Parse("70.26.101.103"), System.Net.IPAddress.Parse("67.199.239.196"), }, { System.Net.IPAddress.Parse("115.14.207.59"), System.Net.IPAddress.Parse("136.77.65.91"), System.Net.IPAddress.Parse("196.209.105.162"), }, }, { { System.Net.IPAddress.Parse("190.197.36.171"), System.Net.IPAddress.Parse("226.234.153.166"), System.Net.IPAddress.Parse("130.35.214.20"), }, { System.Net.IPAddress.Parse("56.243.116.30"), System.Net.IPAddress.Parse("0.114.154.152"), System.Net.IPAddress.Parse("106.29.97.86"), }, { System.Net.IPAddress.Parse("34.96.178.137"), System.Net.IPAddress.Parse("163.93.73.96"), System.Net.IPAddress.Parse("160.45.25.119"), }, }, { { System.Net.IPAddress.Parse("225.187.7.140"), System.Net.IPAddress.Parse("45.217.232.137"), System.Net.IPAddress.Parse("246.108.115.168"), }, { System.Net.IPAddress.Parse("148.76.111.248"), System.Net.IPAddress.Parse("40.181.250.163"), System.Net.IPAddress.Parse("186.36.81.105"), }, { System.Net.IPAddress.Parse("33.175.27.133"), System.Net.IPAddress.Parse("120.25.151.111"), System.Net.IPAddress.Parse("117.52.180.200"), }, }, },
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("85.238.137.32"), System.Net.IPAddress.Parse("21.98.217.34"), System.Net.IPAddress.Parse("84.41.54.111"), }, { System.Net.IPAddress.Parse("227.206.217.245"), System.Net.IPAddress.Parse("242.117.45.40"), System.Net.IPAddress.Parse("68.118.37.203"), }, { System.Net.IPAddress.Parse("206.98.5.221"), System.Net.IPAddress.Parse("42.51.241.129"), System.Net.IPAddress.Parse("11.122.28.13"), }, }, { { System.Net.IPAddress.Parse("58.59.182.13"), System.Net.IPAddress.Parse("134.226.4.249"), System.Net.IPAddress.Parse("70.142.26.38"), }, { System.Net.IPAddress.Parse("244.156.43.88"), System.Net.IPAddress.Parse("225.37.66.233"), System.Net.IPAddress.Parse("205.157.158.217"), }, { System.Net.IPAddress.Parse("207.46.110.42"), System.Net.IPAddress.Parse("190.122.25.134"), System.Net.IPAddress.Parse("118.146.13.96"), }, }, { { System.Net.IPAddress.Parse("161.238.40.164"), System.Net.IPAddress.Parse("190.36.151.53"), System.Net.IPAddress.Parse("124.30.144.114"), }, { System.Net.IPAddress.Parse("13.196.12.127"), System.Net.IPAddress.Parse("239.77.50.153"), System.Net.IPAddress.Parse("123.44.179.19"), }, { System.Net.IPAddress.Parse("241.13.93.103"), System.Net.IPAddress.Parse("202.113.116.184"), System.Net.IPAddress.Parse("50.108.167.48"), }, }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 110,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("79.148.108.71"), System.Net.IPAddress.Parse("172.112.119.94"), System.Net.IPAddress.Parse("112.222.129.149"), }, { System.Net.IPAddress.Parse("203.254.67.251"), System.Net.IPAddress.Parse("55.124.74.252"), System.Net.IPAddress.Parse("206.69.1.150"), }, { System.Net.IPAddress.Parse("103.93.63.165"), System.Net.IPAddress.Parse("152.233.249.228"), System.Net.IPAddress.Parse("110.150.53.80"), }, }, { { System.Net.IPAddress.Parse("0.15.177.208"), System.Net.IPAddress.Parse("61.188.41.162"), System.Net.IPAddress.Parse("105.251.241.41"), }, { System.Net.IPAddress.Parse("164.154.83.109"), System.Net.IPAddress.Parse("96.251.42.144"), System.Net.IPAddress.Parse("40.185.41.30"), }, { System.Net.IPAddress.Parse("196.219.23.212"), System.Net.IPAddress.Parse("43.162.232.154"), System.Net.IPAddress.Parse("64.71.25.79"), }, }, { { System.Net.IPAddress.Parse("95.163.144.212"), System.Net.IPAddress.Parse("152.94.242.154"), System.Net.IPAddress.Parse("33.164.253.158"), }, { System.Net.IPAddress.Parse("13.66.171.185"), System.Net.IPAddress.Parse("231.213.140.99"), System.Net.IPAddress.Parse("229.139.171.239"), }, { System.Net.IPAddress.Parse("86.100.1.122"), System.Net.IPAddress.Parse("77.90.76.202"), System.Net.IPAddress.Parse("211.204.76.45"), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("8.27.248.103"), System.Net.IPAddress.Parse("214.50.185.17"), System.Net.IPAddress.Parse("221.115.94.237"), }, { System.Net.IPAddress.Parse("101.68.60.80"), System.Net.IPAddress.Parse("84.24.233.11"), System.Net.IPAddress.Parse("103.204.29.195"), }, { System.Net.IPAddress.Parse("99.218.145.108"), System.Net.IPAddress.Parse("49.43.94.168"), System.Net.IPAddress.Parse("159.21.176.85"), }, }, { { System.Net.IPAddress.Parse("190.54.52.231"), System.Net.IPAddress.Parse("138.29.135.27"), System.Net.IPAddress.Parse("99.14.224.180"), }, { System.Net.IPAddress.Parse("21.239.154.211"), System.Net.IPAddress.Parse("36.38.184.7"), System.Net.IPAddress.Parse("132.90.218.219"), }, { System.Net.IPAddress.Parse("100.40.166.206"), System.Net.IPAddress.Parse("192.97.245.20"), System.Net.IPAddress.Parse("173.182.177.160"), }, }, { { System.Net.IPAddress.Parse("152.7.59.196"), System.Net.IPAddress.Parse("116.39.134.223"), System.Net.IPAddress.Parse("183.201.156.176"), }, { System.Net.IPAddress.Parse("41.144.48.66"), System.Net.IPAddress.Parse("60.12.162.209"), System.Net.IPAddress.Parse("95.137.38.37"), }, { System.Net.IPAddress.Parse("29.18.67.191"), System.Net.IPAddress.Parse("36.154.177.0"), System.Net.IPAddress.Parse("97.119.86.5"), }, }, },
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 111,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("42.168.137.238"), System.Net.IPAddress.Parse("76.112.182.25"), System.Net.IPAddress.Parse("84.246.238.118"), }, { System.Net.IPAddress.Parse("73.34.52.20"), System.Net.IPAddress.Parse("27.92.81.245"), System.Net.IPAddress.Parse("52.176.135.47"), }, { System.Net.IPAddress.Parse("188.79.0.232"), System.Net.IPAddress.Parse("8.129.154.124"), System.Net.IPAddress.Parse("87.97.218.78"), }, }, { { System.Net.IPAddress.Parse("6.67.51.60"), System.Net.IPAddress.Parse("74.141.113.223"), System.Net.IPAddress.Parse("103.167.78.199"), }, { System.Net.IPAddress.Parse("174.29.141.159"), System.Net.IPAddress.Parse("233.162.191.187"), System.Net.IPAddress.Parse("116.202.133.42"), }, { System.Net.IPAddress.Parse("77.136.178.195"), System.Net.IPAddress.Parse("107.99.136.81"), System.Net.IPAddress.Parse("52.244.209.195"), }, }, { { System.Net.IPAddress.Parse("128.39.118.61"), System.Net.IPAddress.Parse("136.170.7.104"), System.Net.IPAddress.Parse("112.204.30.142"), }, { System.Net.IPAddress.Parse("165.63.101.217"), System.Net.IPAddress.Parse("126.110.30.23"), System.Net.IPAddress.Parse("93.205.79.228"), }, { System.Net.IPAddress.Parse("34.93.95.88"), System.Net.IPAddress.Parse("189.203.221.114"), System.Net.IPAddress.Parse("234.119.164.223"), }, }, },
    ModelInner = new IPAddressinetMMArrayD3E1MI
{
    Id = 53,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("218.88.96.247"), System.Net.IPAddress.Parse("34.58.58.25"), System.Net.IPAddress.Parse("105.23.87.150"), }, { System.Net.IPAddress.Parse("233.75.54.127"), System.Net.IPAddress.Parse("98.158.33.99"), System.Net.IPAddress.Parse("228.6.201.146"), }, { System.Net.IPAddress.Parse("209.48.5.17"), System.Net.IPAddress.Parse("27.242.19.96"), System.Net.IPAddress.Parse("226.126.169.64"), }, }, { { System.Net.IPAddress.Parse("114.193.224.251"), System.Net.IPAddress.Parse("71.198.83.148"), System.Net.IPAddress.Parse("75.142.119.238"), }, { System.Net.IPAddress.Parse("232.225.61.162"), System.Net.IPAddress.Parse("193.148.80.3"), System.Net.IPAddress.Parse("252.36.166.173"), }, { System.Net.IPAddress.Parse("150.131.159.143"), System.Net.IPAddress.Parse("9.85.79.130"), System.Net.IPAddress.Parse("94.203.16.221"), }, }, { { System.Net.IPAddress.Parse("106.254.213.113"), System.Net.IPAddress.Parse("182.204.196.109"), System.Net.IPAddress.Parse("114.252.27.161"), }, { System.Net.IPAddress.Parse("138.170.146.196"), System.Net.IPAddress.Parse("44.153.51.108"), System.Net.IPAddress.Parse("89.87.83.48"), }, { System.Net.IPAddress.Parse("19.247.53.52"), System.Net.IPAddress.Parse("43.98.156.158"), System.Net.IPAddress.Parse("103.198.32.101"), }, }, },
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("98.199.180.184"), System.Net.IPAddress.Parse("179.160.86.54"), System.Net.IPAddress.Parse("134.62.159.7"), }, { System.Net.IPAddress.Parse("3.112.203.131"), System.Net.IPAddress.Parse("175.203.75.0"), System.Net.IPAddress.Parse("120.235.168.103"), }, { System.Net.IPAddress.Parse("93.191.227.55"), System.Net.IPAddress.Parse("171.136.198.190"), System.Net.IPAddress.Parse("103.5.175.118"), }, }, { { System.Net.IPAddress.Parse("177.53.26.117"), System.Net.IPAddress.Parse("116.243.162.219"), System.Net.IPAddress.Parse("167.75.243.239"), }, { System.Net.IPAddress.Parse("248.75.163.2"), System.Net.IPAddress.Parse("102.209.242.83"), System.Net.IPAddress.Parse("201.227.134.148"), }, { System.Net.IPAddress.Parse("101.129.63.115"), System.Net.IPAddress.Parse("173.162.144.30"), System.Net.IPAddress.Parse("175.172.15.212"), }, }, { { System.Net.IPAddress.Parse("224.172.67.189"), System.Net.IPAddress.Parse("89.238.154.220"), System.Net.IPAddress.Parse("223.170.118.180"), }, { System.Net.IPAddress.Parse("246.125.100.212"), System.Net.IPAddress.Parse("114.59.21.115"), System.Net.IPAddress.Parse("75.56.241.126"), }, { System.Net.IPAddress.Parse("15.7.253.5"), System.Net.IPAddress.Parse("53.12.233.180"), System.Net.IPAddress.Parse("52.19.128.24"), }, }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 119,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("111.110.129.161"), System.Net.IPAddress.Parse("61.85.111.224"), System.Net.IPAddress.Parse("104.49.182.27"), }, { System.Net.IPAddress.Parse("230.34.155.127"), System.Net.IPAddress.Parse("54.83.212.38"), System.Net.IPAddress.Parse("232.216.136.210"), }, { System.Net.IPAddress.Parse("28.186.68.210"), System.Net.IPAddress.Parse("141.239.204.96"), System.Net.IPAddress.Parse("19.197.213.241"), }, }, { { System.Net.IPAddress.Parse("184.171.36.44"), System.Net.IPAddress.Parse("206.104.89.11"), System.Net.IPAddress.Parse("152.187.120.29"), }, { System.Net.IPAddress.Parse("190.171.211.233"), System.Net.IPAddress.Parse("111.63.167.41"), System.Net.IPAddress.Parse("85.40.16.109"), }, { System.Net.IPAddress.Parse("152.80.8.234"), System.Net.IPAddress.Parse("175.84.151.10"), System.Net.IPAddress.Parse("104.2.238.58"), }, }, { { System.Net.IPAddress.Parse("106.185.23.37"), System.Net.IPAddress.Parse("149.89.181.65"), System.Net.IPAddress.Parse("179.85.208.12"), }, { System.Net.IPAddress.Parse("213.231.85.209"), System.Net.IPAddress.Parse("170.16.134.170"), System.Net.IPAddress.Parse("72.91.204.207"), }, { System.Net.IPAddress.Parse("194.22.164.164"), System.Net.IPAddress.Parse("246.103.106.12"), System.Net.IPAddress.Parse("209.204.94.253"), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("204.56.172.232"), System.Net.IPAddress.Parse("161.196.232.248"), System.Net.IPAddress.Parse("160.73.43.61"), }, { System.Net.IPAddress.Parse("24.102.226.5"), System.Net.IPAddress.Parse("73.203.98.65"), System.Net.IPAddress.Parse("103.53.248.182"), }, { System.Net.IPAddress.Parse("144.98.240.248"), System.Net.IPAddress.Parse("125.48.16.148"), System.Net.IPAddress.Parse("202.110.237.178"), }, }, { { System.Net.IPAddress.Parse("160.192.102.6"), System.Net.IPAddress.Parse("80.183.82.40"), System.Net.IPAddress.Parse("226.163.29.64"), }, { System.Net.IPAddress.Parse("225.96.188.196"), System.Net.IPAddress.Parse("35.154.2.103"), System.Net.IPAddress.Parse("99.199.240.29"), }, { System.Net.IPAddress.Parse("193.194.110.156"), System.Net.IPAddress.Parse("55.233.236.139"), System.Net.IPAddress.Parse("201.18.57.103"), }, }, { { System.Net.IPAddress.Parse("197.166.10.27"), System.Net.IPAddress.Parse("19.116.102.239"), System.Net.IPAddress.Parse("135.37.213.191"), }, { System.Net.IPAddress.Parse("6.161.42.189"), System.Net.IPAddress.Parse("111.129.244.102"), System.Net.IPAddress.Parse("162.243.216.43"), }, { System.Net.IPAddress.Parse("208.116.79.253"), System.Net.IPAddress.Parse("232.254.16.156"), System.Net.IPAddress.Parse("74.113.220.22"), }, }, },
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 121,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("79.224.149.94"), System.Net.IPAddress.Parse("187.43.205.200"), System.Net.IPAddress.Parse("165.148.217.222"), }, { System.Net.IPAddress.Parse("161.198.14.156"), System.Net.IPAddress.Parse("32.125.121.162"), System.Net.IPAddress.Parse("15.237.199.14"), }, { System.Net.IPAddress.Parse("195.51.188.248"), System.Net.IPAddress.Parse("237.148.85.3"), System.Net.IPAddress.Parse("233.10.78.98"), }, }, { { System.Net.IPAddress.Parse("186.33.241.127"), System.Net.IPAddress.Parse("140.192.22.253"), System.Net.IPAddress.Parse("178.11.44.90"), }, { System.Net.IPAddress.Parse("222.124.131.70"), System.Net.IPAddress.Parse("225.109.176.178"), System.Net.IPAddress.Parse("194.26.84.241"), }, { System.Net.IPAddress.Parse("219.232.235.213"), System.Net.IPAddress.Parse("240.29.17.150"), System.Net.IPAddress.Parse("225.215.21.78"), }, }, { { System.Net.IPAddress.Parse("110.135.212.180"), System.Net.IPAddress.Parse("20.217.4.75"), System.Net.IPAddress.Parse("249.68.37.97"), }, { System.Net.IPAddress.Parse("161.178.168.50"), System.Net.IPAddress.Parse("139.61.65.119"), System.Net.IPAddress.Parse("170.109.174.2"), }, { System.Net.IPAddress.Parse("91.77.141.57"), System.Net.IPAddress.Parse("254.105.189.11"), System.Net.IPAddress.Parse("187.149.95.245"), }, }, },
    ModelInner = new IPAddressinetMMArrayD3E1MI
{
    Id = 58,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("254.26.178.22"), System.Net.IPAddress.Parse("44.29.179.108"), System.Net.IPAddress.Parse("182.253.57.131"), }, { System.Net.IPAddress.Parse("55.128.115.148"), System.Net.IPAddress.Parse("247.225.34.177"), System.Net.IPAddress.Parse("25.8.90.150"), }, { System.Net.IPAddress.Parse("24.232.66.130"), System.Net.IPAddress.Parse("178.9.115.118"), System.Net.IPAddress.Parse("212.236.205.20"), }, }, { { System.Net.IPAddress.Parse("184.8.69.70"), System.Net.IPAddress.Parse("161.17.213.26"), System.Net.IPAddress.Parse("48.172.225.112"), }, { System.Net.IPAddress.Parse("137.201.193.151"), System.Net.IPAddress.Parse("59.97.51.32"), System.Net.IPAddress.Parse("105.49.172.246"), }, { System.Net.IPAddress.Parse("97.213.157.209"), System.Net.IPAddress.Parse("28.186.92.250"), System.Net.IPAddress.Parse("92.174.18.114"), }, }, { { System.Net.IPAddress.Parse("32.226.178.37"), System.Net.IPAddress.Parse("185.45.51.177"), System.Net.IPAddress.Parse("254.15.224.114"), }, { System.Net.IPAddress.Parse("49.121.122.167"), System.Net.IPAddress.Parse("108.141.47.183"), System.Net.IPAddress.Parse("109.150.168.36"), }, { System.Net.IPAddress.Parse("191.74.151.19"), System.Net.IPAddress.Parse("238.215.4.68"), System.Net.IPAddress.Parse("172.228.142.21"), }, }, },
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("187.9.209.211"), System.Net.IPAddress.Parse("121.247.5.111"), System.Net.IPAddress.Parse("102.129.4.140"), }, { System.Net.IPAddress.Parse("3.33.97.12"), System.Net.IPAddress.Parse("108.235.212.186"), System.Net.IPAddress.Parse("197.198.178.191"), }, { System.Net.IPAddress.Parse("124.189.220.228"), System.Net.IPAddress.Parse("94.16.62.222"), System.Net.IPAddress.Parse("93.205.89.37"), }, }, { { System.Net.IPAddress.Parse("162.41.60.105"), System.Net.IPAddress.Parse("69.231.139.13"), System.Net.IPAddress.Parse("78.174.236.144"), }, { System.Net.IPAddress.Parse("22.109.14.66"), System.Net.IPAddress.Parse("138.1.249.125"), System.Net.IPAddress.Parse("223.198.64.101"), }, { System.Net.IPAddress.Parse("228.133.137.142"), System.Net.IPAddress.Parse("111.161.15.235"), System.Net.IPAddress.Parse("34.196.49.25"), }, }, { { System.Net.IPAddress.Parse("40.224.77.75"), System.Net.IPAddress.Parse("161.62.195.105"), System.Net.IPAddress.Parse("192.156.251.103"), }, { System.Net.IPAddress.Parse("219.25.12.40"), System.Net.IPAddress.Parse("110.121.186.29"), System.Net.IPAddress.Parse("166.131.89.55"), }, { System.Net.IPAddress.Parse("185.206.11.127"), System.Net.IPAddress.Parse("193.131.134.131"), System.Net.IPAddress.Parse("108.28.125.88"), }, }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 127,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("70.153.154.190"), System.Net.IPAddress.Parse("41.138.237.189"), System.Net.IPAddress.Parse("118.113.105.129"), }, { System.Net.IPAddress.Parse("54.131.111.243"), System.Net.IPAddress.Parse("137.173.201.91"), System.Net.IPAddress.Parse("113.153.111.158"), }, { System.Net.IPAddress.Parse("239.39.164.18"), System.Net.IPAddress.Parse("65.173.70.162"), System.Net.IPAddress.Parse("122.91.14.50"), }, }, { { System.Net.IPAddress.Parse("25.54.201.112"), System.Net.IPAddress.Parse("238.240.218.8"), System.Net.IPAddress.Parse("123.181.203.178"), }, { System.Net.IPAddress.Parse("134.114.143.1"), System.Net.IPAddress.Parse("183.185.176.203"), System.Net.IPAddress.Parse("251.151.60.195"), }, { System.Net.IPAddress.Parse("63.144.89.99"), System.Net.IPAddress.Parse("97.143.140.117"), System.Net.IPAddress.Parse("221.181.215.25"), }, }, { { System.Net.IPAddress.Parse("28.113.19.57"), System.Net.IPAddress.Parse("55.182.173.31"), System.Net.IPAddress.Parse("234.159.1.61"), }, { System.Net.IPAddress.Parse("68.14.204.44"), System.Net.IPAddress.Parse("16.39.254.188"), System.Net.IPAddress.Parse("185.71.90.132"), }, { System.Net.IPAddress.Parse("122.134.209.249"), System.Net.IPAddress.Parse("158.74.103.236"), System.Net.IPAddress.Parse("58.144.253.12"), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 136,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("242.251.26.89"), System.Net.IPAddress.Parse("207.92.155.209"), System.Net.IPAddress.Parse("45.246.8.43"), }, { System.Net.IPAddress.Parse("209.77.30.189"), System.Net.IPAddress.Parse("117.159.78.249"), System.Net.IPAddress.Parse("40.201.76.9"), }, { System.Net.IPAddress.Parse("171.70.102.55"), System.Net.IPAddress.Parse("60.164.168.2"), System.Net.IPAddress.Parse("128.133.156.123"), }, }, { { System.Net.IPAddress.Parse("91.156.71.115"), System.Net.IPAddress.Parse("121.42.234.182"), System.Net.IPAddress.Parse("212.173.139.73"), }, { System.Net.IPAddress.Parse("127.171.88.50"), System.Net.IPAddress.Parse("203.107.231.196"), System.Net.IPAddress.Parse("201.81.223.113"), }, { System.Net.IPAddress.Parse("46.245.82.2"), System.Net.IPAddress.Parse("141.192.52.102"), System.Net.IPAddress.Parse("59.108.111.106"), }, }, { { System.Net.IPAddress.Parse("240.152.109.135"), System.Net.IPAddress.Parse("232.17.81.7"), System.Net.IPAddress.Parse("157.161.38.32"), }, { System.Net.IPAddress.Parse("52.224.94.30"), System.Net.IPAddress.Parse("207.210.160.117"), System.Net.IPAddress.Parse("76.96.228.135"), }, { System.Net.IPAddress.Parse("127.219.176.185"), System.Net.IPAddress.Parse("55.69.76.112"), System.Net.IPAddress.Parse("2.175.239.99"), }, }, },
    ModelInner = new IPAddressinetMMArrayD3E1MI
{
    Id = 62,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("241.124.47.241"), System.Net.IPAddress.Parse("30.112.10.81"), System.Net.IPAddress.Parse("73.117.69.209"), }, { System.Net.IPAddress.Parse("209.229.214.99"), System.Net.IPAddress.Parse("149.69.10.23"), System.Net.IPAddress.Parse("169.50.162.56"), }, { System.Net.IPAddress.Parse("171.250.166.161"), System.Net.IPAddress.Parse("198.159.192.158"), System.Net.IPAddress.Parse("144.190.228.166"), }, }, { { System.Net.IPAddress.Parse("22.151.184.32"), System.Net.IPAddress.Parse("74.177.3.162"), System.Net.IPAddress.Parse("229.61.2.211"), }, { System.Net.IPAddress.Parse("204.93.168.211"), System.Net.IPAddress.Parse("182.239.212.144"), System.Net.IPAddress.Parse("198.190.114.214"), }, { System.Net.IPAddress.Parse("135.153.148.151"), System.Net.IPAddress.Parse("47.120.197.168"), System.Net.IPAddress.Parse("171.175.199.191"), }, }, { { System.Net.IPAddress.Parse("143.14.55.85"), System.Net.IPAddress.Parse("233.147.242.189"), System.Net.IPAddress.Parse("211.75.100.162"), }, { System.Net.IPAddress.Parse("193.63.217.93"), System.Net.IPAddress.Parse("224.107.221.84"), System.Net.IPAddress.Parse("104.169.43.145"), }, { System.Net.IPAddress.Parse("124.33.157.55"), System.Net.IPAddress.Parse("187.150.77.156"), System.Net.IPAddress.Parse("238.184.1.217"), }, }, },
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("235.198.107.172"), System.Net.IPAddress.Parse("53.74.94.224"), System.Net.IPAddress.Parse("70.44.33.117"), }, { System.Net.IPAddress.Parse("144.32.142.161"), System.Net.IPAddress.Parse("43.196.98.237"), System.Net.IPAddress.Parse("45.38.102.45"), }, { System.Net.IPAddress.Parse("239.210.5.99"), System.Net.IPAddress.Parse("87.247.33.49"), System.Net.IPAddress.Parse("106.176.215.131"), }, }, { { System.Net.IPAddress.Parse("213.75.7.244"), System.Net.IPAddress.Parse("24.132.163.97"), System.Net.IPAddress.Parse("21.145.82.109"), }, { System.Net.IPAddress.Parse("180.41.161.183"), System.Net.IPAddress.Parse("63.92.89.224"), System.Net.IPAddress.Parse("115.191.16.194"), }, { System.Net.IPAddress.Parse("76.159.87.101"), System.Net.IPAddress.Parse("152.214.224.39"), System.Net.IPAddress.Parse("138.114.163.42"), }, }, { { System.Net.IPAddress.Parse("176.26.167.221"), System.Net.IPAddress.Parse("64.190.109.199"), System.Net.IPAddress.Parse("3.131.137.47"), }, { System.Net.IPAddress.Parse("140.53.254.65"), System.Net.IPAddress.Parse("34.220.149.31"), System.Net.IPAddress.Parse("206.121.28.200"), }, { System.Net.IPAddress.Parse("158.133.147.1"), System.Net.IPAddress.Parse("207.248.130.209"), System.Net.IPAddress.Parse("144.178.203.230"), }, }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 142,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("174.204.123.24"), System.Net.IPAddress.Parse("208.199.9.102"), System.Net.IPAddress.Parse("222.92.100.39"), }, { System.Net.IPAddress.Parse("224.185.193.17"), System.Net.IPAddress.Parse("189.94.11.183"), System.Net.IPAddress.Parse("249.82.226.200"), }, { System.Net.IPAddress.Parse("203.55.75.84"), System.Net.IPAddress.Parse("37.36.84.93"), System.Net.IPAddress.Parse("16.112.28.196"), }, }, { { System.Net.IPAddress.Parse("46.125.145.184"), System.Net.IPAddress.Parse("208.162.217.244"), System.Net.IPAddress.Parse("4.44.226.215"), }, { System.Net.IPAddress.Parse("68.208.160.116"), System.Net.IPAddress.Parse("193.153.97.206"), System.Net.IPAddress.Parse("22.56.87.186"), }, { System.Net.IPAddress.Parse("202.222.74.9"), System.Net.IPAddress.Parse("225.152.107.73"), System.Net.IPAddress.Parse("88.118.42.212"), }, }, { { System.Net.IPAddress.Parse("239.195.64.34"), System.Net.IPAddress.Parse("186.186.228.34"), System.Net.IPAddress.Parse("51.221.148.58"), }, { System.Net.IPAddress.Parse("174.8.234.130"), System.Net.IPAddress.Parse("146.141.137.62"), System.Net.IPAddress.Parse("186.247.223.197"), }, { System.Net.IPAddress.Parse("241.243.189.52"), System.Net.IPAddress.Parse("4.108.73.48"), System.Net.IPAddress.Parse("162.220.50.247"), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("32.149.224.27"), System.Net.IPAddress.Parse("68.214.27.212"), System.Net.IPAddress.Parse("145.238.186.61"), }, { System.Net.IPAddress.Parse("39.69.41.56"), System.Net.IPAddress.Parse("222.243.94.146"), System.Net.IPAddress.Parse("51.244.111.146"), }, { System.Net.IPAddress.Parse("104.32.197.19"), System.Net.IPAddress.Parse("36.238.208.225"), System.Net.IPAddress.Parse("92.182.66.81"), }, }, { { System.Net.IPAddress.Parse("186.23.18.79"), System.Net.IPAddress.Parse("44.135.127.232"), System.Net.IPAddress.Parse("68.56.98.224"), }, { System.Net.IPAddress.Parse("74.152.99.134"), System.Net.IPAddress.Parse("114.116.140.209"), System.Net.IPAddress.Parse("43.76.60.121"), }, { System.Net.IPAddress.Parse("229.13.114.106"), System.Net.IPAddress.Parse("15.115.209.91"), System.Net.IPAddress.Parse("117.168.123.136"), }, }, { { System.Net.IPAddress.Parse("181.71.219.35"), System.Net.IPAddress.Parse("234.194.248.79"), System.Net.IPAddress.Parse("168.90.194.127"), }, { System.Net.IPAddress.Parse("184.230.169.163"), System.Net.IPAddress.Parse("246.51.106.29"), System.Net.IPAddress.Parse("243.11.166.247"), }, { System.Net.IPAddress.Parse("78.129.167.185"), System.Net.IPAddress.Parse("37.57.200.187"), System.Net.IPAddress.Parse("74.176.69.86"), }, }, },
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 151,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("16.21.100.188"), System.Net.IPAddress.Parse("141.164.228.202"), System.Net.IPAddress.Parse("79.235.240.58"), }, { System.Net.IPAddress.Parse("58.71.222.65"), System.Net.IPAddress.Parse("194.229.132.22"), System.Net.IPAddress.Parse("111.112.154.185"), }, { System.Net.IPAddress.Parse("240.123.50.250"), System.Net.IPAddress.Parse("24.18.229.81"), System.Net.IPAddress.Parse("137.161.214.231"), }, }, { { System.Net.IPAddress.Parse("62.153.114.62"), System.Net.IPAddress.Parse("148.90.241.26"), System.Net.IPAddress.Parse("14.218.101.8"), }, { System.Net.IPAddress.Parse("110.127.164.250"), System.Net.IPAddress.Parse("123.41.188.199"), System.Net.IPAddress.Parse("126.64.41.22"), }, { System.Net.IPAddress.Parse("226.55.210.222"), System.Net.IPAddress.Parse("242.187.196.116"), System.Net.IPAddress.Parse("56.2.75.147"), }, }, { { System.Net.IPAddress.Parse("17.216.247.180"), System.Net.IPAddress.Parse("79.220.194.158"), System.Net.IPAddress.Parse("48.169.8.73"), }, { System.Net.IPAddress.Parse("140.22.16.51"), System.Net.IPAddress.Parse("116.110.209.91"), System.Net.IPAddress.Parse("180.29.13.223"), }, { System.Net.IPAddress.Parse("36.212.158.141"), System.Net.IPAddress.Parse("37.164.134.53"), System.Net.IPAddress.Parse("200.46.61.113"), }, }, },
    ModelInner = new IPAddressinetMMArrayD3E1MI
{
    Id = 63,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("76.207.89.238"), System.Net.IPAddress.Parse("128.75.12.184"), System.Net.IPAddress.Parse("188.117.223.188"), }, { System.Net.IPAddress.Parse("169.150.247.17"), System.Net.IPAddress.Parse("238.243.90.91"), System.Net.IPAddress.Parse("84.240.41.224"), }, { System.Net.IPAddress.Parse("44.138.159.216"), System.Net.IPAddress.Parse("97.113.243.71"), System.Net.IPAddress.Parse("170.56.47.172"), }, }, { { System.Net.IPAddress.Parse("188.187.76.106"), System.Net.IPAddress.Parse("145.23.94.183"), System.Net.IPAddress.Parse("123.60.236.55"), }, { System.Net.IPAddress.Parse("126.145.254.247"), System.Net.IPAddress.Parse("111.238.252.111"), System.Net.IPAddress.Parse("96.175.190.169"), }, { System.Net.IPAddress.Parse("152.64.78.82"), System.Net.IPAddress.Parse("28.178.144.119"), System.Net.IPAddress.Parse("213.32.240.133"), }, }, { { System.Net.IPAddress.Parse("66.39.222.222"), System.Net.IPAddress.Parse("152.162.54.51"), System.Net.IPAddress.Parse("156.170.61.206"), }, { System.Net.IPAddress.Parse("233.121.74.100"), System.Net.IPAddress.Parse("114.99.37.126"), System.Net.IPAddress.Parse("23.120.213.200"), }, { System.Net.IPAddress.Parse("68.49.185.108"), System.Net.IPAddress.Parse("150.20.202.115"), System.Net.IPAddress.Parse("131.127.101.54"), }, }, },
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("222.233.70.179"), System.Net.IPAddress.Parse("77.104.178.239"), System.Net.IPAddress.Parse("127.137.102.26"), }, { System.Net.IPAddress.Parse("159.163.188.51"), System.Net.IPAddress.Parse("133.69.134.92"), System.Net.IPAddress.Parse("90.27.228.225"), }, { System.Net.IPAddress.Parse("84.149.137.188"), System.Net.IPAddress.Parse("141.161.220.78"), System.Net.IPAddress.Parse("48.60.169.235"), }, }, { { System.Net.IPAddress.Parse("252.82.80.143"), System.Net.IPAddress.Parse("106.87.80.53"), System.Net.IPAddress.Parse("38.79.142.128"), }, { System.Net.IPAddress.Parse("196.233.139.199"), System.Net.IPAddress.Parse("17.199.210.142"), System.Net.IPAddress.Parse("146.96.39.70"), }, { System.Net.IPAddress.Parse("233.181.98.148"), System.Net.IPAddress.Parse("159.205.8.179"), System.Net.IPAddress.Parse("75.222.144.67"), }, }, { { System.Net.IPAddress.Parse("49.144.7.240"), System.Net.IPAddress.Parse("226.140.62.15"), System.Net.IPAddress.Parse("61.2.203.224"), }, { System.Net.IPAddress.Parse("250.73.149.141"), System.Net.IPAddress.Parse("14.126.221.83"), System.Net.IPAddress.Parse("128.50.191.12"), }, { System.Net.IPAddress.Parse("149.247.48.120"), System.Net.IPAddress.Parse("57.200.17.64"), System.Net.IPAddress.Parse("206.132.73.114"), }, }, },
},
    NullableValue = null,
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 159,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("33.163.163.14"), System.Net.IPAddress.Parse("58.94.160.188"), System.Net.IPAddress.Parse("172.46.3.136"), }, { System.Net.IPAddress.Parse("175.199.40.225"), System.Net.IPAddress.Parse("245.131.64.174"), System.Net.IPAddress.Parse("217.176.172.85"), }, { System.Net.IPAddress.Parse("38.196.170.100"), System.Net.IPAddress.Parse("0.45.254.30"), System.Net.IPAddress.Parse("112.163.169.9"), }, }, { { System.Net.IPAddress.Parse("56.8.67.37"), System.Net.IPAddress.Parse("131.235.58.230"), System.Net.IPAddress.Parse("227.239.64.128"), }, { System.Net.IPAddress.Parse("71.24.206.34"), System.Net.IPAddress.Parse("143.35.205.145"), System.Net.IPAddress.Parse("35.39.99.127"), }, { System.Net.IPAddress.Parse("69.133.21.174"), System.Net.IPAddress.Parse("13.239.96.32"), System.Net.IPAddress.Parse("8.126.249.153"), }, }, { { System.Net.IPAddress.Parse("27.115.163.91"), System.Net.IPAddress.Parse("75.45.192.246"), System.Net.IPAddress.Parse("50.44.78.87"), }, { System.Net.IPAddress.Parse("76.192.13.157"), System.Net.IPAddress.Parse("146.63.62.108"), System.Net.IPAddress.Parse("245.85.116.230"), }, { System.Net.IPAddress.Parse("141.111.174.254"), System.Net.IPAddress.Parse("90.109.53.66"), System.Net.IPAddress.Parse("185.185.194.77"), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("213.59.108.35"), System.Net.IPAddress.Parse("68.246.122.133"), System.Net.IPAddress.Parse("117.82.138.192"), }, { System.Net.IPAddress.Parse("226.158.235.198"), System.Net.IPAddress.Parse("26.189.80.134"), System.Net.IPAddress.Parse("36.100.161.238"), }, { System.Net.IPAddress.Parse("162.172.153.199"), System.Net.IPAddress.Parse("206.73.188.178"), System.Net.IPAddress.Parse("63.128.189.65"), }, }, { { System.Net.IPAddress.Parse("168.78.225.100"), System.Net.IPAddress.Parse("188.178.73.37"), System.Net.IPAddress.Parse("232.115.90.107"), }, { System.Net.IPAddress.Parse("215.3.70.20"), System.Net.IPAddress.Parse("216.185.217.223"), System.Net.IPAddress.Parse("189.52.162.11"), }, { System.Net.IPAddress.Parse("206.115.248.29"), System.Net.IPAddress.Parse("173.161.15.197"), System.Net.IPAddress.Parse("91.217.54.154"), }, }, { { System.Net.IPAddress.Parse("188.72.237.201"), System.Net.IPAddress.Parse("216.6.6.205"), System.Net.IPAddress.Parse("26.239.135.174"), }, { System.Net.IPAddress.Parse("43.153.6.98"), System.Net.IPAddress.Parse("141.233.222.79"), System.Net.IPAddress.Parse("36.194.193.142"), }, { System.Net.IPAddress.Parse("239.52.231.8"), System.Net.IPAddress.Parse("165.64.36.98"), System.Net.IPAddress.Parse("242.20.195.76"), }, }, },
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 160,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("89.234.221.186"), System.Net.IPAddress.Parse("225.190.125.104"), System.Net.IPAddress.Parse("250.38.231.94"), }, { System.Net.IPAddress.Parse("84.192.93.148"), System.Net.IPAddress.Parse("19.35.149.30"), System.Net.IPAddress.Parse("15.170.79.118"), }, { System.Net.IPAddress.Parse("229.60.231.78"), System.Net.IPAddress.Parse("143.227.84.192"), System.Net.IPAddress.Parse("58.224.47.7"), }, }, { { System.Net.IPAddress.Parse("125.21.138.53"), System.Net.IPAddress.Parse("17.3.152.199"), System.Net.IPAddress.Parse("100.249.198.97"), }, { System.Net.IPAddress.Parse("142.117.229.11"), System.Net.IPAddress.Parse("26.232.145.98"), System.Net.IPAddress.Parse("37.212.62.55"), }, { System.Net.IPAddress.Parse("6.93.165.96"), System.Net.IPAddress.Parse("204.241.6.105"), System.Net.IPAddress.Parse("33.132.183.90"), }, }, { { System.Net.IPAddress.Parse("47.40.152.66"), System.Net.IPAddress.Parse("184.113.243.173"), System.Net.IPAddress.Parse("102.146.131.42"), }, { System.Net.IPAddress.Parse("240.180.171.240"), System.Net.IPAddress.Parse("89.111.167.253"), System.Net.IPAddress.Parse("251.84.152.41"), }, { System.Net.IPAddress.Parse("185.56.182.95"), System.Net.IPAddress.Parse("28.20.176.13"), System.Net.IPAddress.Parse("172.13.109.131"), }, }, },
    ModelInner = new IPAddressinetMMArrayD3E1MI
{
    Id = 66,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("41.173.125.76"), System.Net.IPAddress.Parse("153.242.190.103"), System.Net.IPAddress.Parse("218.253.22.184"), }, { System.Net.IPAddress.Parse("64.250.46.195"), System.Net.IPAddress.Parse("241.230.193.191"), System.Net.IPAddress.Parse("45.69.205.130"), }, { System.Net.IPAddress.Parse("121.113.76.43"), System.Net.IPAddress.Parse("233.217.58.240"), System.Net.IPAddress.Parse("164.162.197.242"), }, }, { { System.Net.IPAddress.Parse("18.118.169.123"), System.Net.IPAddress.Parse("103.58.96.26"), System.Net.IPAddress.Parse("124.192.102.199"), }, { System.Net.IPAddress.Parse("201.12.158.216"), System.Net.IPAddress.Parse("142.148.119.166"), System.Net.IPAddress.Parse("185.247.176.71"), }, { System.Net.IPAddress.Parse("144.165.28.102"), System.Net.IPAddress.Parse("196.176.135.3"), System.Net.IPAddress.Parse("143.25.80.20"), }, }, { { System.Net.IPAddress.Parse("238.98.97.69"), System.Net.IPAddress.Parse("72.233.1.156"), System.Net.IPAddress.Parse("44.30.170.119"), }, { System.Net.IPAddress.Parse("202.217.202.226"), System.Net.IPAddress.Parse("33.75.9.151"), System.Net.IPAddress.Parse("201.23.105.245"), }, { System.Net.IPAddress.Parse("105.25.170.73"), System.Net.IPAddress.Parse("53.82.48.181"), System.Net.IPAddress.Parse("193.188.95.185"), }, }, },
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("183.6.107.61"), System.Net.IPAddress.Parse("207.77.104.186"), System.Net.IPAddress.Parse("171.150.27.28"), }, { System.Net.IPAddress.Parse("237.69.69.38"), System.Net.IPAddress.Parse("30.139.74.152"), System.Net.IPAddress.Parse("219.224.224.42"), }, { System.Net.IPAddress.Parse("148.57.158.167"), System.Net.IPAddress.Parse("75.104.246.224"), System.Net.IPAddress.Parse("199.6.27.195"), }, }, { { System.Net.IPAddress.Parse("229.73.219.234"), System.Net.IPAddress.Parse("187.17.169.208"), System.Net.IPAddress.Parse("84.207.126.36"), }, { System.Net.IPAddress.Parse("168.209.18.193"), System.Net.IPAddress.Parse("222.34.210.93"), System.Net.IPAddress.Parse("36.63.191.23"), }, { System.Net.IPAddress.Parse("204.169.191.23"), System.Net.IPAddress.Parse("186.23.168.79"), System.Net.IPAddress.Parse("37.156.88.27"), }, }, { { System.Net.IPAddress.Parse("28.72.200.122"), System.Net.IPAddress.Parse("3.168.242.104"), System.Net.IPAddress.Parse("14.158.117.108"), }, { System.Net.IPAddress.Parse("137.153.113.47"), System.Net.IPAddress.Parse("209.19.57.82"), System.Net.IPAddress.Parse("170.149.234.154"), }, { System.Net.IPAddress.Parse("171.165.209.185"), System.Net.IPAddress.Parse("144.39.219.27"), System.Net.IPAddress.Parse("191.244.149.167"), }, }, },
},
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("91.67.247.230"), System.Net.IPAddress.Parse("90.228.121.158"), System.Net.IPAddress.Parse("52.222.209.216"), }, { System.Net.IPAddress.Parse("127.93.164.77"), System.Net.IPAddress.Parse("177.32.110.236"), System.Net.IPAddress.Parse("211.60.104.56"), }, { System.Net.IPAddress.Parse("56.245.117.120"), System.Net.IPAddress.Parse("21.239.108.98"), System.Net.IPAddress.Parse("192.194.193.64"), }, }, { { System.Net.IPAddress.Parse("92.51.185.168"), System.Net.IPAddress.Parse("197.21.95.202"), System.Net.IPAddress.Parse("197.12.152.142"), }, { System.Net.IPAddress.Parse("158.58.16.228"), System.Net.IPAddress.Parse("211.182.215.172"), System.Net.IPAddress.Parse("154.39.166.208"), }, { System.Net.IPAddress.Parse("8.33.162.21"), System.Net.IPAddress.Parse("159.60.185.5"), System.Net.IPAddress.Parse("246.128.70.90"), }, }, { { System.Net.IPAddress.Parse("229.13.139.139"), System.Net.IPAddress.Parse("57.116.135.249"), System.Net.IPAddress.Parse("48.176.87.222"), }, { System.Net.IPAddress.Parse("197.199.169.164"), System.Net.IPAddress.Parse("175.87.252.164"), System.Net.IPAddress.Parse("172.171.216.168"), }, { System.Net.IPAddress.Parse("181.196.96.242"), System.Net.IPAddress.Parse("248.141.203.25"), System.Net.IPAddress.Parse("97.140.216.1"), }, }, },
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 161,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("253.75.250.250"), System.Net.IPAddress.Parse("25.94.66.104"), System.Net.IPAddress.Parse("229.37.39.28"), }, { System.Net.IPAddress.Parse("47.158.166.137"), System.Net.IPAddress.Parse("203.182.81.49"), System.Net.IPAddress.Parse("100.158.226.9"), }, { System.Net.IPAddress.Parse("16.8.138.17"), System.Net.IPAddress.Parse("135.9.17.15"), System.Net.IPAddress.Parse("97.21.103.102"), }, }, { { System.Net.IPAddress.Parse("66.35.148.63"), System.Net.IPAddress.Parse("249.100.182.91"), System.Net.IPAddress.Parse("22.190.249.234"), }, { System.Net.IPAddress.Parse("168.11.129.127"), System.Net.IPAddress.Parse("109.188.57.195"), System.Net.IPAddress.Parse("230.153.213.134"), }, { System.Net.IPAddress.Parse("84.155.245.157"), System.Net.IPAddress.Parse("26.52.18.143"), System.Net.IPAddress.Parse("80.42.109.133"), }, }, { { System.Net.IPAddress.Parse("168.253.207.11"), System.Net.IPAddress.Parse("194.10.79.236"), System.Net.IPAddress.Parse("38.65.125.46"), }, { System.Net.IPAddress.Parse("218.77.171.192"), System.Net.IPAddress.Parse("217.246.129.38"), System.Net.IPAddress.Parse("11.213.230.9"), }, { System.Net.IPAddress.Parse("63.233.174.146"), System.Net.IPAddress.Parse("142.41.3.13"), System.Net.IPAddress.Parse("35.34.248.178"), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("247.52.73.230"), System.Net.IPAddress.Parse("44.254.110.15"), System.Net.IPAddress.Parse("231.192.90.53"), }, { System.Net.IPAddress.Parse("89.248.158.253"), System.Net.IPAddress.Parse("170.20.199.179"), System.Net.IPAddress.Parse("158.107.214.73"), }, { System.Net.IPAddress.Parse("31.196.0.145"), System.Net.IPAddress.Parse("167.33.13.249"), System.Net.IPAddress.Parse("136.228.119.26"), }, }, { { System.Net.IPAddress.Parse("125.90.250.6"), System.Net.IPAddress.Parse("183.160.57.56"), System.Net.IPAddress.Parse("178.91.52.106"), }, { System.Net.IPAddress.Parse("251.112.217.26"), System.Net.IPAddress.Parse("145.191.66.57"), System.Net.IPAddress.Parse("38.67.187.10"), }, { System.Net.IPAddress.Parse("89.188.99.19"), System.Net.IPAddress.Parse("37.77.4.6"), System.Net.IPAddress.Parse("162.38.61.46"), }, }, { { System.Net.IPAddress.Parse("29.200.75.248"), System.Net.IPAddress.Parse("218.111.129.42"), System.Net.IPAddress.Parse("50.222.53.69"), }, { System.Net.IPAddress.Parse("129.118.201.234"), System.Net.IPAddress.Parse("44.84.71.180"), System.Net.IPAddress.Parse("194.158.76.207"), }, { System.Net.IPAddress.Parse("200.137.131.88"), System.Net.IPAddress.Parse("241.8.185.62"), System.Net.IPAddress.Parse("95.1.32.187"), }, }, },
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 170,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("232.174.252.98"), System.Net.IPAddress.Parse("156.195.11.241"), System.Net.IPAddress.Parse("62.98.208.201"), }, { System.Net.IPAddress.Parse("151.89.143.233"), System.Net.IPAddress.Parse("11.40.2.160"), System.Net.IPAddress.Parse("116.245.219.218"), }, { System.Net.IPAddress.Parse("103.192.125.207"), System.Net.IPAddress.Parse("202.131.87.222"), System.Net.IPAddress.Parse("167.116.174.208"), }, }, { { System.Net.IPAddress.Parse("182.176.129.5"), System.Net.IPAddress.Parse("210.31.113.219"), System.Net.IPAddress.Parse("176.88.162.241"), }, { System.Net.IPAddress.Parse("27.197.194.230"), System.Net.IPAddress.Parse("62.223.132.185"), System.Net.IPAddress.Parse("4.48.168.215"), }, { System.Net.IPAddress.Parse("32.254.217.55"), System.Net.IPAddress.Parse("52.134.124.195"), System.Net.IPAddress.Parse("155.219.60.127"), }, }, { { System.Net.IPAddress.Parse("6.40.228.85"), System.Net.IPAddress.Parse("236.184.204.127"), System.Net.IPAddress.Parse("38.166.22.211"), }, { System.Net.IPAddress.Parse("208.21.231.70"), System.Net.IPAddress.Parse("112.218.198.213"), System.Net.IPAddress.Parse("145.149.117.60"), }, { System.Net.IPAddress.Parse("234.185.57.52"), System.Net.IPAddress.Parse("60.68.106.95"), System.Net.IPAddress.Parse("167.200.67.174"), }, }, },
    ModelInner = new IPAddressinetMMArrayD3E1MI
{
    Id = 72,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("7.252.75.138"), System.Net.IPAddress.Parse("62.43.200.68"), System.Net.IPAddress.Parse("102.145.197.245"), }, { System.Net.IPAddress.Parse("45.235.118.90"), System.Net.IPAddress.Parse("7.125.214.246"), System.Net.IPAddress.Parse("112.248.108.111"), }, { System.Net.IPAddress.Parse("105.196.41.54"), System.Net.IPAddress.Parse("243.222.10.120"), System.Net.IPAddress.Parse("2.251.99.211"), }, }, { { System.Net.IPAddress.Parse("235.204.111.47"), System.Net.IPAddress.Parse("73.94.129.204"), System.Net.IPAddress.Parse("170.91.187.224"), }, { System.Net.IPAddress.Parse("164.19.128.52"), System.Net.IPAddress.Parse("62.135.145.168"), System.Net.IPAddress.Parse("250.202.60.170"), }, { System.Net.IPAddress.Parse("132.91.247.128"), System.Net.IPAddress.Parse("30.62.177.101"), System.Net.IPAddress.Parse("138.105.135.189"), }, }, { { System.Net.IPAddress.Parse("30.250.60.97"), System.Net.IPAddress.Parse("189.122.23.181"), System.Net.IPAddress.Parse("228.248.204.119"), }, { System.Net.IPAddress.Parse("172.140.124.249"), System.Net.IPAddress.Parse("197.77.45.118"), System.Net.IPAddress.Parse("40.225.192.28"), }, { System.Net.IPAddress.Parse("187.134.102.36"), System.Net.IPAddress.Parse("199.238.192.105"), System.Net.IPAddress.Parse("178.174.64.222"), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("145.251.122.134"), System.Net.IPAddress.Parse("105.113.65.111"), System.Net.IPAddress.Parse("62.8.57.11"), }, { System.Net.IPAddress.Parse("234.173.228.58"), System.Net.IPAddress.Parse("135.27.175.41"), System.Net.IPAddress.Parse("210.183.201.168"), }, { System.Net.IPAddress.Parse("191.175.100.201"), System.Net.IPAddress.Parse("238.200.124.253"), System.Net.IPAddress.Parse("234.90.174.12"), }, }, { { System.Net.IPAddress.Parse("72.95.72.214"), System.Net.IPAddress.Parse("245.96.181.91"), System.Net.IPAddress.Parse("71.73.91.57"), }, { System.Net.IPAddress.Parse("217.224.16.76"), System.Net.IPAddress.Parse("236.92.90.155"), System.Net.IPAddress.Parse("244.152.62.116"), }, { System.Net.IPAddress.Parse("116.162.22.187"), System.Net.IPAddress.Parse("74.54.53.104"), System.Net.IPAddress.Parse("100.184.98.200"), }, }, { { System.Net.IPAddress.Parse("221.149.214.60"), System.Net.IPAddress.Parse("214.154.140.150"), System.Net.IPAddress.Parse("39.73.118.245"), }, { System.Net.IPAddress.Parse("145.229.53.201"), System.Net.IPAddress.Parse("128.221.211.227"), System.Net.IPAddress.Parse("101.151.179.66"), }, { System.Net.IPAddress.Parse("89.156.117.142"), System.Net.IPAddress.Parse("107.46.245.45"), System.Net.IPAddress.Parse("129.134.218.251"), }, }, },
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 173,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("16.71.123.14"), System.Net.IPAddress.Parse("174.124.87.240"), System.Net.IPAddress.Parse("136.14.226.166"), }, { System.Net.IPAddress.Parse("250.63.49.176"), System.Net.IPAddress.Parse("129.61.234.146"), System.Net.IPAddress.Parse("190.12.212.36"), }, { System.Net.IPAddress.Parse("71.202.98.163"), System.Net.IPAddress.Parse("211.202.46.17"), System.Net.IPAddress.Parse("0.141.178.0"), }, }, { { System.Net.IPAddress.Parse("34.164.254.93"), System.Net.IPAddress.Parse("17.63.53.69"), System.Net.IPAddress.Parse("173.124.40.203"), }, { System.Net.IPAddress.Parse("61.57.112.65"), System.Net.IPAddress.Parse("160.61.103.9"), System.Net.IPAddress.Parse("69.229.47.85"), }, { System.Net.IPAddress.Parse("232.28.212.63"), System.Net.IPAddress.Parse("146.27.67.62"), System.Net.IPAddress.Parse("199.19.150.129"), }, }, { { System.Net.IPAddress.Parse("251.207.65.21"), System.Net.IPAddress.Parse("4.243.83.57"), System.Net.IPAddress.Parse("222.156.203.122"), }, { System.Net.IPAddress.Parse("4.60.146.53"), System.Net.IPAddress.Parse("43.217.95.49"), System.Net.IPAddress.Parse("135.154.3.207"), }, { System.Net.IPAddress.Parse("200.226.104.74"), System.Net.IPAddress.Parse("25.140.6.166"), System.Net.IPAddress.Parse("57.231.250.191"), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 176,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("1.127.184.150"), System.Net.IPAddress.Parse("58.170.122.184"), System.Net.IPAddress.Parse("198.84.8.166"), }, { System.Net.IPAddress.Parse("241.30.147.70"), System.Net.IPAddress.Parse("223.194.161.221"), System.Net.IPAddress.Parse("224.58.225.76"), }, { System.Net.IPAddress.Parse("201.209.49.192"), System.Net.IPAddress.Parse("233.29.45.124"), System.Net.IPAddress.Parse("98.178.82.189"), }, }, { { System.Net.IPAddress.Parse("163.106.136.194"), System.Net.IPAddress.Parse("188.202.235.244"), System.Net.IPAddress.Parse("163.134.212.44"), }, { System.Net.IPAddress.Parse("86.95.180.109"), System.Net.IPAddress.Parse("96.210.111.222"), System.Net.IPAddress.Parse("35.99.253.247"), }, { System.Net.IPAddress.Parse("38.55.109.48"), System.Net.IPAddress.Parse("176.88.6.245"), System.Net.IPAddress.Parse("0.124.29.13"), }, }, { { System.Net.IPAddress.Parse("198.95.144.166"), System.Net.IPAddress.Parse("124.159.84.7"), System.Net.IPAddress.Parse("56.230.40.80"), }, { System.Net.IPAddress.Parse("0.239.243.50"), System.Net.IPAddress.Parse("240.133.63.33"), System.Net.IPAddress.Parse("201.183.124.146"), }, { System.Net.IPAddress.Parse("112.164.119.98"), System.Net.IPAddress.Parse("246.204.222.54"), System.Net.IPAddress.Parse("150.219.142.3"), }, }, },
    ModelInner = new IPAddressinetMMArrayD3E1MI
{
    Id = 75,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("97.239.171.154"), System.Net.IPAddress.Parse("27.42.10.173"), System.Net.IPAddress.Parse("2.103.222.37"), }, { System.Net.IPAddress.Parse("237.62.38.196"), System.Net.IPAddress.Parse("131.102.169.11"), System.Net.IPAddress.Parse("246.174.18.87"), }, { System.Net.IPAddress.Parse("98.54.21.17"), System.Net.IPAddress.Parse("108.74.104.16"), System.Net.IPAddress.Parse("216.151.19.53"), }, }, { { System.Net.IPAddress.Parse("124.40.34.105"), System.Net.IPAddress.Parse("105.163.38.16"), System.Net.IPAddress.Parse("19.69.164.249"), }, { System.Net.IPAddress.Parse("221.54.208.122"), System.Net.IPAddress.Parse("169.113.62.227"), System.Net.IPAddress.Parse("200.160.126.213"), }, { System.Net.IPAddress.Parse("142.49.219.138"), System.Net.IPAddress.Parse("89.212.40.158"), System.Net.IPAddress.Parse("44.111.230.110"), }, }, { { System.Net.IPAddress.Parse("109.0.105.222"), System.Net.IPAddress.Parse("130.249.20.212"), System.Net.IPAddress.Parse("19.53.118.138"), }, { System.Net.IPAddress.Parse("142.100.235.10"), System.Net.IPAddress.Parse("203.178.188.237"), System.Net.IPAddress.Parse("141.246.184.115"), }, { System.Net.IPAddress.Parse("126.227.193.210"), System.Net.IPAddress.Parse("14.132.139.169"), System.Net.IPAddress.Parse("237.84.32.1"), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("144.247.6.126"), System.Net.IPAddress.Parse("0.156.154.190"), System.Net.IPAddress.Parse("82.117.63.148"), }, { System.Net.IPAddress.Parse("6.59.133.137"), System.Net.IPAddress.Parse("13.155.118.141"), System.Net.IPAddress.Parse("55.53.41.109"), }, { System.Net.IPAddress.Parse("125.134.60.212"), System.Net.IPAddress.Parse("2.63.15.83"), System.Net.IPAddress.Parse("215.128.158.173"), }, }, { { System.Net.IPAddress.Parse("4.17.56.183"), System.Net.IPAddress.Parse("193.117.70.139"), System.Net.IPAddress.Parse("170.232.168.78"), }, { System.Net.IPAddress.Parse("226.81.128.137"), System.Net.IPAddress.Parse("40.40.48.237"), System.Net.IPAddress.Parse("126.88.118.205"), }, { System.Net.IPAddress.Parse("146.77.123.254"), System.Net.IPAddress.Parse("65.36.38.107"), System.Net.IPAddress.Parse("60.104.227.198"), }, }, { { System.Net.IPAddress.Parse("238.36.150.63"), System.Net.IPAddress.Parse("25.82.106.109"), System.Net.IPAddress.Parse("36.193.56.22"), }, { System.Net.IPAddress.Parse("231.54.56.45"), System.Net.IPAddress.Parse("222.149.39.141"), System.Net.IPAddress.Parse("195.207.191.62"), }, { System.Net.IPAddress.Parse("151.90.192.97"), System.Net.IPAddress.Parse("27.61.132.31"), System.Net.IPAddress.Parse("96.199.110.248"), }, }, },
},
            new IPAddressinetMMArrayD3E1M
{
    Id = 180,
    Value = 
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("60.187.150.238"), System.Net.IPAddress.Parse("186.113.192.192"), System.Net.IPAddress.Parse("249.60.213.179"), }, { System.Net.IPAddress.Parse("242.133.9.234"), System.Net.IPAddress.Parse("206.114.228.79"), System.Net.IPAddress.Parse("142.10.170.52"), }, { System.Net.IPAddress.Parse("146.212.55.73"), System.Net.IPAddress.Parse("233.41.149.146"), System.Net.IPAddress.Parse("126.41.121.132"), }, }, { { System.Net.IPAddress.Parse("64.68.135.209"), System.Net.IPAddress.Parse("136.184.74.63"), System.Net.IPAddress.Parse("5.10.181.242"), }, { System.Net.IPAddress.Parse("76.90.105.179"), System.Net.IPAddress.Parse("133.44.147.2"), System.Net.IPAddress.Parse("126.170.57.243"), }, { System.Net.IPAddress.Parse("69.138.159.50"), System.Net.IPAddress.Parse("67.75.185.24"), System.Net.IPAddress.Parse("227.132.12.234"), }, }, { { System.Net.IPAddress.Parse("62.241.190.54"), System.Net.IPAddress.Parse("152.149.39.92"), System.Net.IPAddress.Parse("182.228.107.204"), }, { System.Net.IPAddress.Parse("39.214.125.90"), System.Net.IPAddress.Parse("51.226.45.152"), System.Net.IPAddress.Parse("139.242.248.18"), }, { System.Net.IPAddress.Parse("195.10.237.45"), System.Net.IPAddress.Parse("93.20.250.139"), System.Net.IPAddress.Parse("224.72.199.145"), }, }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmmarrayd3e1mi(
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmmarrayd3e1mi(
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
            queryMapTypes: [typeof(IPAddressinetMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,,]), 
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

                changedRows =  ((IIPAddressMArrayinetMMArrayD3)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IIPAddressMArrayinetMMArrayD3)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IIPAddressMArrayinetMMArrayD3)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IIPAddressMArrayinetMMArrayD3)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    ipaddressinetmmarrayd3e1mi_id
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "ipaddressinetmmarrayd3e1mi_id", 
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
                changedRows =  ((IIPAddressMArrayinetMMArrayD3)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IIPAddressMArrayinetMMArrayD3)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    ipaddressinetmmarrayd3e1mi_id
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
    ipaddressinetmmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(IPAddressinetMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
                System.Net.IPAddress[,,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[,,]>();
                    ((NpgsqlParameter<System.Net.IPAddress[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[,,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((IIPAddressMArrayinetMMArrayD3)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[,,]>();
                    ((NpgsqlParameter<System.Net.IPAddress[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[,,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((IIPAddressMArrayinetMMArrayD3)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("18.198.43.75"), System.Net.IPAddress.Parse("140.166.190.113"), System.Net.IPAddress.Parse("81.32.120.185"), }, { System.Net.IPAddress.Parse("179.183.127.86"), System.Net.IPAddress.Parse("67.99.109.53"), System.Net.IPAddress.Parse("237.140.182.197"), }, { System.Net.IPAddress.Parse("186.153.91.160"), System.Net.IPAddress.Parse("140.175.73.152"), System.Net.IPAddress.Parse("147.231.70.235"), }, }, { { System.Net.IPAddress.Parse("8.61.169.226"), System.Net.IPAddress.Parse("180.16.205.135"), System.Net.IPAddress.Parse("11.86.116.37"), }, { System.Net.IPAddress.Parse("154.103.93.4"), System.Net.IPAddress.Parse("130.209.67.37"), System.Net.IPAddress.Parse("172.37.157.172"), }, { System.Net.IPAddress.Parse("220.129.215.19"), System.Net.IPAddress.Parse("144.215.1.231"), System.Net.IPAddress.Parse("125.40.189.130"), }, }, { { System.Net.IPAddress.Parse("50.152.160.213"), System.Net.IPAddress.Parse("91.118.162.191"), System.Net.IPAddress.Parse("216.146.0.165"), }, { System.Net.IPAddress.Parse("82.252.153.110"), System.Net.IPAddress.Parse("182.220.155.84"), System.Net.IPAddress.Parse("208.118.220.231"), }, { System.Net.IPAddress.Parse("90.159.141.183"), System.Net.IPAddress.Parse("46.196.96.48"), System.Net.IPAddress.Parse("25.174.56.238"), }, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Net.IPAddress[,,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[,,]>();
                    ((NpgsqlParameter<System.Net.IPAddress[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[,,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((IIPAddressMArrayinetMMArrayD3)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[,,]>();
                    ((NpgsqlParameter<System.Net.IPAddress[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[,,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((IIPAddressMArrayinetMMArrayD3)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[,,] { { { System.Net.IPAddress.Parse("132.33.221.102"), System.Net.IPAddress.Parse("215.105.224.66"), System.Net.IPAddress.Parse("62.55.10.52"), }, { System.Net.IPAddress.Parse("168.69.84.40"), System.Net.IPAddress.Parse("207.32.65.155"), System.Net.IPAddress.Parse("51.145.159.147"), }, { System.Net.IPAddress.Parse("31.85.230.149"), System.Net.IPAddress.Parse("124.130.63.186"), System.Net.IPAddress.Parse("26.95.178.194"), }, }, { { System.Net.IPAddress.Parse("185.73.224.51"), System.Net.IPAddress.Parse("18.63.136.152"), System.Net.IPAddress.Parse("69.163.180.42"), }, { System.Net.IPAddress.Parse("73.107.34.160"), System.Net.IPAddress.Parse("53.146.227.148"), System.Net.IPAddress.Parse("161.2.214.231"), }, { System.Net.IPAddress.Parse("53.127.166.115"), System.Net.IPAddress.Parse("59.178.173.239"), System.Net.IPAddress.Parse("73.243.33.217"), }, }, { { System.Net.IPAddress.Parse("205.245.53.113"), System.Net.IPAddress.Parse("238.35.252.90"), System.Net.IPAddress.Parse("96.233.54.56"), }, { System.Net.IPAddress.Parse("136.81.93.146"), System.Net.IPAddress.Parse("71.181.102.194"), System.Net.IPAddress.Parse("38.137.139.146"), }, { System.Net.IPAddress.Parse("19.94.194.30"), System.Net.IPAddress.Parse("143.139.156.225"), System.Net.IPAddress.Parse("102.221.118.168"), }, }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    ipaddressinetmmarrayd3e1mi_id
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
    ipaddressinetmmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(IPAddressinetMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "ipaddressinetmmarrayd3e1mi_id", 
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
                System.Net.IPAddress[,,] nullable = null;
                nullable =  ((IIPAddressMArrayinetMMArrayD3)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IIPAddressMArrayinetMMArrayD3)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Net.IPAddress[,,] nullable = null;
                nullable = await ((IIPAddressMArrayinetMMArrayD3)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IIPAddressMArrayinetMMArrayD3)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetMMArrayD3E1M> models = null;

                models =  ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetMMArrayD3E1M> models = null;

                models = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IIPAddressMArrayinetMMArrayD3)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD3E1M), typeof(FlatIPAddressinetMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                await ((IIPAddressMArrayinetMMArrayD3)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                ((IIPAddressMArrayinetMMArrayD3)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IIPAddressMArrayinetMMArrayD3)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IIPAddressMArrayinetMMArrayD3)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd3e1m m
LEFT JOIN public.ipaddressinetmmarrayd3e1mi mi ON mi.id = m.ipaddressinetmmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinetMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
                var models = await ((IIPAddressMArrayinetMMArrayD3)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IIPAddressMArrayinetMMArrayD3)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD3E1M), typeof(FlatIPAddressinetMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                await ((IIPAddressMArrayinetMMArrayD3)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                ((IIPAddressMArrayinetMMArrayD3)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IIPAddressMArrayinetMMArrayD3)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressMArrayinetMMArrayD3)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd3e1m m
LEFT JOIN public.ipaddressinetmmarrayd3e1mi mi ON mi.id = m.ipaddressinetmmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(IPAddressinetMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
                var models = await ((IIPAddressMArrayinetMMArrayD3)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IIPAddressMArrayinetMMArrayD3)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD3E1M), typeof(FlatIPAddressinetMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                await((IIPAddressMArrayinetMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 142;
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
FROM public.ipaddressinetmmarrayd3e1m m
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                await ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
FROM public.ipaddressinetmmarrayd3e1m m
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                await ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
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
FROM public.ipaddressinetmmarrayd3e1m m
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                 ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
FROM public.ipaddressinetmmarrayd3e1m m
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                 ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IIPAddressMArrayinetMMArrayD3)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 170;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetmmarrayd3e1m m
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[1],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[4], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[1],_testData[5], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[2],_testData[6], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[3],_testData[7], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[4],_testData[8], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[5],_testData[9], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[6],_testData[10], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[7],_testData[11], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[8],_testData[12], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[9],_testData[13], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[10],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[11],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[12],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[13],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[14],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[15],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[16],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[17],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[18],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[19],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[20],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[21],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[22],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[23],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[24],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[25],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[26],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[27],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[28],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[29],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetmmarrayd3e1m m
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                await ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 73;
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
FROM public.ipaddressinetmmarrayd3e1m m
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[1],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[2],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[3],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[4],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[5],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[6],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[7],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[8],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[9],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[10],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[11],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[12],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[13],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[14],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[15],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[16],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[17],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[18],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[19],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[1], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[1],_testData[2], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[2],_testData[3], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[3],_testData[4], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[4],_testData[5], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[5],_testData[6], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[6],_testData[7], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[7],_testData[8], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[8],_testData[9], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[9],_testData[10], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[10],_testData[11], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[11],_testData[12], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[12],_testData[13], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[13],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[14],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[15],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[16],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[17],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[18],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[19],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[20],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[21],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[22],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[23],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[24],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[25],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[26],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[27],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[28],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[29],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[30],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[31],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[32],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetmmarrayd3e1m m
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                 ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd3e1m m
LEFT JOIN public.ipaddressinetmmarrayd3e1mi mi ON mi.id = m.ipaddressinetmmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinetMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
                var models = await((IIPAddressMArrayinetMMArrayD3)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[30], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[1],_testData[31], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[2],_testData[32], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[3],_testData[33], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[14], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[1],_testData[15], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[2],_testData[16], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[3],_testData[17], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[4],_testData[18], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[5],_testData[19], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[6],_testData[20], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[7],_testData[21], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[8],_testData[22], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[9],_testData[23], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[10],_testData[24], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[11],_testData[25], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[12],_testData[26], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[13],_testData[27], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[14],_testData[28], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[15],_testData[29], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[16],_testData[30], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[17],_testData[31], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[18],_testData[32], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[19],_testData[33], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[20],_testData[34], false);
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
                var models = ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[21], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[1],_testData[22], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[2],_testData[23], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[3],_testData[24], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[4],_testData[25], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[5],_testData[26], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[6],_testData[27], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[7],_testData[28], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[8],_testData[29], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[9],_testData[30], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[10],_testData[31], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[11],_testData[32], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[12],_testData[33], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[25], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[1],_testData[26], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[2],_testData[27], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[3],_testData[28], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[4],_testData[29], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[5],_testData[30], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[6],_testData[31], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[7],_testData[32], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[8],_testData[33], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD3E1M), typeof(FlatIPAddressinetMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                await((IIPAddressMArrayinetMMArrayD3)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd3e1m m
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                await ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 61, query1, 97, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd3e1m m
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                await ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 127, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var models2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd3e1m m
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                 ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 73, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd3e1m m
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var firstItems2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                 ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatch(connection, 18, query1, 170, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IIPAddressMArrayinetMMArrayD3)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd3e1m m
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 73, query1, 127, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[1],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[2],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[3],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[4],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[5],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[6],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[7],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[8],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[9],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[10],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[11],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[12],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[13],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[14],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[15],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[16],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[17],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[18],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[19],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[1],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[2],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[3],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[4],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[5],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[6],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[7],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[8],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[9],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd3e1m m
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                await ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 97, query1, 23, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmmarrayd3e1m m
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatch(connection, 84, query1, 173, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[1],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[2],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[3],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[4],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[5],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[6],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[7],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[8],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[9],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[10],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[11],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[12],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[13],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[14],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[15],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[16],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[17],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(models[1],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd3e1m m
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
FROM public.ipaddressinetmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var secondItems1 = new List<FlatIPAddressinetMMArrayD3E1M>();
                var secondItems2 = new List<FlatIPAddressinetMMArrayD3E1M>();
                 ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionDynQuerySelectModelBatch(connection, 97, query1, 66, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatIPAddressinetMMArrayD3E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.ipaddressinetmmarrayd3e1m m
LEFT JOIN public.ipaddressinetmmarrayd3e1mi mi ON mi.id = m.ipaddressinetmmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(IPAddressinetMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
                var models = await((IIPAddressMArrayinetMMArrayD3)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionSTSelectModelBatchAsync(connection, 84, 42))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[16], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[1],_testData[17], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[2],_testData[18], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[3],_testData[19], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[4],_testData[20], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[5],_testData[21], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[6],_testData[22], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[7],_testData[23], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[8],_testData[24], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[9],_testData[25], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[10],_testData[26], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[11],_testData[27], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[12],_testData[28], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[13],_testData[29], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[14],_testData[30], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[15],_testData[31], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[16],_testData[32], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[17],_testData[33], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[7], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[1],_testData[8], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[2],_testData[9], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[3],_testData[10], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[4],_testData[11], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[5],_testData[12], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[6],_testData[13], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[7],_testData[14], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[8],_testData[15], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[9],_testData[16], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[10],_testData[17], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[11],_testData[18], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[12],_testData[19], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[13],_testData[20], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[14],_testData[21], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[15],_testData[22], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[16],_testData[23], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[17],_testData[24], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[18],_testData[25], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[19],_testData[26], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[20],_testData[27], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[21],_testData[28], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[22],_testData[29], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[23],_testData[30], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[24],_testData[31], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[25],_testData[32], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[26],_testData[33], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[27],_testData[34], false);
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
                var models = ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IIPAddressMArrayinetMMArrayD3)this).DbConnectionSTSelectModelBatch(connection, 110, 161))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[21], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[1],_testData[22], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[2],_testData[23], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[3],_testData[24], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[4],_testData[25], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[5],_testData[26], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[6],_testData[27], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[7],_testData[28], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[8],_testData[29], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[9],_testData[30], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[10],_testData[31], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[11],_testData[32], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[12],_testData[33], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[31], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[1],_testData[32], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[2],_testData[33], false);
                        IPAddressinetMMArrayD3E1M.AssertModel(models[3],_testData[34], false);
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
                await using var cmd = await ((IIPAddressMArrayinetMMArrayD3)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IIPAddressMArrayinetMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 121);
                var models = await ((IIPAddressMArrayinetMMArrayD3)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[24], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[1],_testData[25], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[2],_testData[26], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[3],_testData[27], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[4],_testData[28], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[5],_testData[29], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[6],_testData[30], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[7],_testData[31], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[8],_testData[32], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[9],_testData[33], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressMArrayinetMMArrayD3)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressMArrayinetMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 66);
                var models =  ((IIPAddressMArrayinetMMArrayD3)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                IPAddressinetMMArrayD3E1M.AssertModel(models[0],_testData[12], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[1],_testData[13], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[2],_testData[14], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[3],_testData[15], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[4],_testData[16], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[5],_testData[17], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[6],_testData[18], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[7],_testData[19], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[8],_testData[20], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[9],_testData[21], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[10],_testData[22], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[11],_testData[23], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[12],_testData[24], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[13],_testData[25], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[14],_testData[26], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[15],_testData[27], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[16],_testData[28], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[17],_testData[29], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[18],_testData[30], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[19],_testData[31], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[20],_testData[32], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[21],_testData[33], false);
                IPAddressinetMMArrayD3E1M.AssertModel(models[22],_testData[34], false);
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
FROM public.binary_ipaddressinetmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(IPAddressinetMMArrayD3E1MIWA),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMMArrayD3E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressMArrayinetMMArrayD3)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinetmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IIPAddressMArrayinetMMArrayD3)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMMArrayD3E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressMArrayinetMMArrayD3)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinetmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressMArrayinetMMArrayD3)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(IPAddressinetMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMMArrayD3E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressMArrayinetMMArrayD3)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinetmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IIPAddressMArrayinetMMArrayD3)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMMArrayD3E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressMArrayinetMMArrayD3)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinetmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressMArrayinetMMArrayD3)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetmmarrayd3e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(IPAddressinetMMArrayD3E1MI),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMMArrayD3E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IIPAddressMArrayinetMMArrayD3)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IIPAddressMArrayinetMMArrayD3)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMMArrayD3E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IIPAddressMArrayinetMMArrayD3)this).WAImportModelInner(connection, importCollection);
                var models = ((IIPAddressMArrayinetMMArrayD3)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(IPAddressinetMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMMArrayD3E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressMArrayinetMMArrayD3)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IIPAddressMArrayinetMMArrayD3)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMMArrayD3E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressMArrayinetMMArrayD3)this).ImportModelInner(connection, importCollection);
                var models = ((IIPAddressMArrayinetMMArrayD3)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetmmarrayd3e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
ipaddressinetmmarrayd3e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(IPAddressinetMMArrayD3E1M),
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
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3))]
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
FROM public.binary_ipaddressinetmmarrayd3e1m m
LEFT JOIN public.binary_ipaddressinetmmarrayd3e1mi mi ON mi.id = m.ipaddressinetmmarrayd3e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(IPAddressinetMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMMArrayD3E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IIPAddressMArrayinetMMArrayD3)this).ImportModelAsync(connection, importCollection);
                var models = await ((IIPAddressMArrayinetMMArrayD3)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    IPAddressinetMMArrayD3E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMMArrayD3E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IIPAddressMArrayinetMMArrayD3)this).ImportModel(connection, importCollection);
                var models = ((IIPAddressMArrayinetMMArrayD3)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    IPAddressinetMMArrayD3E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetmmarrayd3e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    ipaddressinetmmarrayd3e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(IPAddressinetMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
                var models =  ((IIPAddressMArrayinetMMArrayD3)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    IPAddressinetMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressMArrayinetMMArrayD3)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    IPAddressinetMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD3E1MIWA), typeof(IPAddressinetMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
                var models1 = new List<IPAddressinetMMArrayD3E1MIWA>();
                var models2 = new List<IPAddressinetMMArrayD3E1MIWA>();
                await ((IIPAddressMArrayinetMMArrayD3)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetMMArrayD3E1MIWA>();
                var models2 = new List<IPAddressinetMMArrayD3E1MIWA>();
                ((IIPAddressMArrayinetMMArrayD3)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
                var models = await ((IIPAddressMArrayinetMMArrayD3)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_ipaddressinetmmarrayd3e1mi
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
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressMArrayinetMMArrayD3)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_ipaddressinetmmarrayd3e1mi
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
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD3E1MIWA), typeof(IPAddressinetMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3))]
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
                var models1 = new List<IPAddressinetMMArrayD3E1MIWA>();
                var models2 = new List<IPAddressinetMMArrayD3E1MIWA>();
                await ((IIPAddressMArrayinetMMArrayD3)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetMMArrayD3E1MIWA>();
                var models2 = new List<IPAddressinetMMArrayD3E1MIWA>();
                ((IIPAddressMArrayinetMMArrayD3)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3))]
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
                var models = await ((IIPAddressMArrayinetMMArrayD3)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_ipaddressinetmmarrayd3e1mi
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
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressMArrayinetMMArrayD3)this).DynQueryExportModelInner(connection, @"
COPY public.binary_ipaddressinetmmarrayd3e1mi
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
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_ipaddressinetmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD3E1MI), typeof(IPAddressinetMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
                var models1 = new List<IPAddressinetMMArrayD3E1MI>();
                var models2 = new List<IPAddressinetMMArrayD3E1MI>();
                await ((IIPAddressMArrayinetMMArrayD3)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetMMArrayD3E1MI>();
                var models2 = new List<IPAddressinetMMArrayD3E1MI>();
                ((IIPAddressMArrayinetMMArrayD3)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetmmarrayd3e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3)),
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
                var models = await ((IIPAddressMArrayinetMMArrayD3)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressMArrayinetMMArrayD3)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_ipaddressinetmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD3E1MIWA), typeof(IPAddressinetMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3))]
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
                var models1 = new List<IPAddressinetMMArrayD3E1MIWA>();
                var models2 = new List<IPAddressinetMMArrayD3E1MIWA>();
                await ((IIPAddressMArrayinetMMArrayD3)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetMMArrayD3E1MIWA>();
                var models2 = new List<IPAddressinetMMArrayD3E1MIWA>();
                ((IIPAddressMArrayinetMMArrayD3)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetmmarrayd3e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMMArrayD3))]
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
                var models = await ((IIPAddressMArrayinetMMArrayD3)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressMArrayinetMMArrayD3)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

