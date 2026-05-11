

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
    Id = 7,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("93.239.1.226"), System.Net.IPAddress.Parse("10.230.85.199"), }, { System.Net.IPAddress.Parse("211.246.234.90"), System.Net.IPAddress.Parse("20.49.18.22"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 7,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("224.47.17.22"), System.Net.IPAddress.Parse("61.92.152.72"), }, { System.Net.IPAddress.Parse("43.171.36.198"), System.Net.IPAddress.Parse("56.58.110.97"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 13,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("128.23.227.142"), System.Net.IPAddress.Parse("127.89.182.196"), }, { System.Net.IPAddress.Parse("41.240.113.113"), System.Net.IPAddress.Parse("1.57.177.172"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 14,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("147.181.36.84"), System.Net.IPAddress.Parse("67.242.160.31"), }, { System.Net.IPAddress.Parse("59.92.125.105"), System.Net.IPAddress.Parse("63.216.204.137"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("100.137.81.113"), System.Net.IPAddress.Parse("251.212.69.128"), }, { System.Net.IPAddress.Parse("36.228.254.77"), System.Net.IPAddress.Parse("172.28.8.23"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("13.128.221.109"), System.Net.IPAddress.Parse("222.97.151.173"), }, { System.Net.IPAddress.Parse("18.173.105.96"), System.Net.IPAddress.Parse("239.79.184.252"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 18,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("80.235.14.45"), System.Net.IPAddress.Parse("14.64.117.156"), }, { System.Net.IPAddress.Parse("76.69.181.89"), System.Net.IPAddress.Parse("86.53.151.253"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 17,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("47.95.178.93"), System.Net.IPAddress.Parse("168.151.233.243"), }, { System.Net.IPAddress.Parse("61.244.114.164"), System.Net.IPAddress.Parse("192.69.32.46"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("100.29.120.189"), System.Net.IPAddress.Parse("25.39.14.55"), }, { System.Net.IPAddress.Parse("146.58.120.33"), System.Net.IPAddress.Parse("91.231.45.82"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 25,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("92.25.66.187"), System.Net.IPAddress.Parse("85.99.31.204"), }, { System.Net.IPAddress.Parse("151.225.181.178"), System.Net.IPAddress.Parse("252.118.219.3"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 18,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("200.137.63.73"), System.Net.IPAddress.Parse("4.243.239.118"), }, { System.Net.IPAddress.Parse("239.13.100.194"), System.Net.IPAddress.Parse("117.146.176.19"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("189.229.246.226"), System.Net.IPAddress.Parse("0.249.50.57"), }, { System.Net.IPAddress.Parse("170.193.129.1"), System.Net.IPAddress.Parse("22.156.37.126"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 32,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("231.174.185.2"), System.Net.IPAddress.Parse("211.108.125.26"), }, { System.Net.IPAddress.Parse("194.81.68.78"), System.Net.IPAddress.Parse("219.226.90.240"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 20,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("18.42.129.9"), System.Net.IPAddress.Parse("73.5.92.219"), }, { System.Net.IPAddress.Parse("17.95.115.168"), System.Net.IPAddress.Parse("81.132.31.215"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("155.171.21.112"), System.Net.IPAddress.Parse("157.123.47.84"), }, { System.Net.IPAddress.Parse("159.204.40.123"), System.Net.IPAddress.Parse("63.184.19.144"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 41,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("160.76.118.142"), System.Net.IPAddress.Parse("209.215.231.240"), }, { System.Net.IPAddress.Parse("122.196.200.66"), System.Net.IPAddress.Parse("2.121.240.229"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 21,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("196.60.189.123"), System.Net.IPAddress.Parse("109.65.113.134"), }, { System.Net.IPAddress.Parse("89.48.89.228"), System.Net.IPAddress.Parse("234.24.219.55"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("16.180.167.41"), System.Net.IPAddress.Parse("208.72.96.4"), }, { System.Net.IPAddress.Parse("166.237.20.136"), System.Net.IPAddress.Parse("28.111.242.63"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 46,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("204.76.193.177"), System.Net.IPAddress.Parse("221.221.115.113"), }, { System.Net.IPAddress.Parse("202.138.4.95"), System.Net.IPAddress.Parse("196.240.192.165"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("44.177.243.174"), System.Net.IPAddress.Parse("142.130.193.252"), }, { System.Net.IPAddress.Parse("197.81.117.119"), System.Net.IPAddress.Parse("229.214.124.185"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("146.156.88.230"), System.Net.IPAddress.Parse("110.134.66.221"), }, { System.Net.IPAddress.Parse("169.214.190.1"), System.Net.IPAddress.Parse("139.149.68.145"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("36.164.146.0"), System.Net.IPAddress.Parse("42.106.223.167"), }, { System.Net.IPAddress.Parse("9.84.131.134"), System.Net.IPAddress.Parse("222.197.74.195"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 50,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("17.203.223.231"), System.Net.IPAddress.Parse("204.141.227.157"), }, { System.Net.IPAddress.Parse("169.217.58.173"), System.Net.IPAddress.Parse("173.85.3.79"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 31,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("59.140.132.136"), System.Net.IPAddress.Parse("232.44.163.43"), }, { System.Net.IPAddress.Parse("96.177.250.221"), System.Net.IPAddress.Parse("155.50.136.17"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("43.229.55.219"), System.Net.IPAddress.Parse("65.196.4.173"), }, { System.Net.IPAddress.Parse("173.161.220.115"), System.Net.IPAddress.Parse("144.110.181.167"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("14.105.46.176"), System.Net.IPAddress.Parse("18.8.112.49"), }, { System.Net.IPAddress.Parse("48.37.95.154"), System.Net.IPAddress.Parse("153.122.134.214"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 56,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("240.162.117.54"), System.Net.IPAddress.Parse("238.61.138.63"), }, { System.Net.IPAddress.Parse("197.59.201.37"), System.Net.IPAddress.Parse("80.218.168.25"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 33,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("146.61.228.200"), System.Net.IPAddress.Parse("49.216.125.49"), }, { System.Net.IPAddress.Parse("187.61.5.116"), System.Net.IPAddress.Parse("215.98.170.114"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("70.238.145.173"), System.Net.IPAddress.Parse("123.129.159.138"), }, { System.Net.IPAddress.Parse("155.82.24.254"), System.Net.IPAddress.Parse("108.115.22.36"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 65,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("10.0.1.175"), System.Net.IPAddress.Parse("6.203.186.193"), }, { System.Net.IPAddress.Parse("232.9.185.237"), System.Net.IPAddress.Parse("179.112.186.254"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 39,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("193.18.65.253"), System.Net.IPAddress.Parse("79.167.187.66"), }, { System.Net.IPAddress.Parse("138.160.183.237"), System.Net.IPAddress.Parse("73.218.23.152"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("107.43.78.134"), System.Net.IPAddress.Parse("233.233.103.177"), }, { System.Net.IPAddress.Parse("183.142.54.53"), System.Net.IPAddress.Parse("13.54.204.96"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 67,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("155.83.203.20"), System.Net.IPAddress.Parse("37.4.13.163"), }, { System.Net.IPAddress.Parse("90.234.184.92"), System.Net.IPAddress.Parse("48.225.102.15"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 43,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("178.115.2.55"), System.Net.IPAddress.Parse("80.176.165.214"), }, { System.Net.IPAddress.Parse("164.169.24.244"), System.Net.IPAddress.Parse("98.152.197.115"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("60.162.106.196"), System.Net.IPAddress.Parse("38.164.0.165"), }, { System.Net.IPAddress.Parse("238.191.71.71"), System.Net.IPAddress.Parse("24.241.146.21"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 74,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("250.35.160.165"), System.Net.IPAddress.Parse("113.251.169.86"), }, { System.Net.IPAddress.Parse("2.23.186.218"), System.Net.IPAddress.Parse("231.87.13.147"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 51,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("107.163.77.44"), System.Net.IPAddress.Parse("155.224.214.237"), }, { System.Net.IPAddress.Parse("222.202.67.135"), System.Net.IPAddress.Parse("232.138.35.124"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 82,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("2.38.1.19"), System.Net.IPAddress.Parse("180.30.132.242"), }, { System.Net.IPAddress.Parse("95.98.51.194"), System.Net.IPAddress.Parse("159.204.179.47"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 58,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("28.58.108.227"), System.Net.IPAddress.Parse("218.47.253.8"), }, { System.Net.IPAddress.Parse("184.242.212.136"), System.Net.IPAddress.Parse("62.125.230.105"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("48.1.2.20"), System.Net.IPAddress.Parse("133.51.205.58"), }, { System.Net.IPAddress.Parse("157.7.70.69"), System.Net.IPAddress.Parse("210.1.173.38"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 87,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("230.217.60.81"), System.Net.IPAddress.Parse("63.188.18.1"), }, { System.Net.IPAddress.Parse("198.208.16.117"), System.Net.IPAddress.Parse("8.100.49.57"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 67,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("179.207.240.57"), System.Net.IPAddress.Parse("110.128.145.3"), }, { System.Net.IPAddress.Parse("247.57.176.230"), System.Net.IPAddress.Parse("45.73.207.143"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("63.47.135.231"), System.Net.IPAddress.Parse("202.93.28.151"), }, { System.Net.IPAddress.Parse("207.85.28.163"), System.Net.IPAddress.Parse("74.14.80.18"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 95,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("67.48.238.115"), System.Net.IPAddress.Parse("97.211.156.83"), }, { System.Net.IPAddress.Parse("190.150.81.132"), System.Net.IPAddress.Parse("226.214.69.99"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 69,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("194.117.10.185"), System.Net.IPAddress.Parse("48.80.190.164"), }, { System.Net.IPAddress.Parse("116.46.108.124"), System.Net.IPAddress.Parse("50.193.221.50"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("28.80.69.14"), System.Net.IPAddress.Parse("36.85.145.189"), }, { System.Net.IPAddress.Parse("79.110.78.195"), System.Net.IPAddress.Parse("83.63.11.232"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("241.210.114.163"), System.Net.IPAddress.Parse("92.135.12.156"), }, { System.Net.IPAddress.Parse("59.173.119.102"), System.Net.IPAddress.Parse("251.172.3.63"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 104,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("72.194.142.198"), System.Net.IPAddress.Parse("31.228.64.120"), }, { System.Net.IPAddress.Parse("163.176.101.40"), System.Net.IPAddress.Parse("63.219.156.29"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 76,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("199.68.195.194"), System.Net.IPAddress.Parse("124.65.250.6"), }, { System.Net.IPAddress.Parse("74.235.103.224"), System.Net.IPAddress.Parse("93.46.73.34"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("116.181.88.112"), System.Net.IPAddress.Parse("33.65.160.210"), }, { System.Net.IPAddress.Parse("250.55.249.60"), System.Net.IPAddress.Parse("218.234.171.66"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 109,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("44.36.113.251"), System.Net.IPAddress.Parse("87.238.229.186"), }, { System.Net.IPAddress.Parse("198.125.81.121"), System.Net.IPAddress.Parse("128.213.117.150"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 84,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("73.4.190.81"), System.Net.IPAddress.Parse("137.197.28.157"), }, { System.Net.IPAddress.Parse("207.124.153.214"), System.Net.IPAddress.Parse("174.41.23.248"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("169.171.239.37"), System.Net.IPAddress.Parse("113.28.193.224"), }, { System.Net.IPAddress.Parse("213.4.45.19"), System.Net.IPAddress.Parse("134.73.185.107"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 113,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("142.182.88.95"), System.Net.IPAddress.Parse("64.116.252.137"), }, { System.Net.IPAddress.Parse("21.117.95.239"), System.Net.IPAddress.Parse("107.172.1.115"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 89,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("57.124.190.53"), System.Net.IPAddress.Parse("119.217.159.252"), }, { System.Net.IPAddress.Parse("160.53.96.169"), System.Net.IPAddress.Parse("177.118.158.69"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("199.182.80.234"), System.Net.IPAddress.Parse("210.32.52.155"), }, { System.Net.IPAddress.Parse("78.72.93.197"), System.Net.IPAddress.Parse("141.242.252.228"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 116,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("118.250.175.19"), System.Net.IPAddress.Parse("84.10.1.249"), }, { System.Net.IPAddress.Parse("78.23.236.252"), System.Net.IPAddress.Parse("208.30.31.86"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 94,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("184.201.223.214"), System.Net.IPAddress.Parse("234.95.243.219"), }, { System.Net.IPAddress.Parse("27.132.35.52"), System.Net.IPAddress.Parse("43.45.40.66"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("184.143.254.134"), System.Net.IPAddress.Parse("245.134.159.149"), }, { System.Net.IPAddress.Parse("225.16.74.8"), System.Net.IPAddress.Parse("129.159.127.76"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("97.90.208.83"), System.Net.IPAddress.Parse("158.54.131.170"), }, { System.Net.IPAddress.Parse("105.110.14.204"), System.Net.IPAddress.Parse("247.224.233.81"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 124,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("186.9.89.239"), System.Net.IPAddress.Parse("152.32.102.86"), }, { System.Net.IPAddress.Parse("74.103.79.101"), System.Net.IPAddress.Parse("127.0.31.17"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 103,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("217.112.150.62"), System.Net.IPAddress.Parse("2.16.41.25"), }, { System.Net.IPAddress.Parse("115.186.34.118"), System.Net.IPAddress.Parse("95.1.90.16"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("31.143.83.224"), System.Net.IPAddress.Parse("77.70.226.120"), }, { System.Net.IPAddress.Parse("168.200.37.139"), System.Net.IPAddress.Parse("141.220.105.0"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("199.50.156.219"), System.Net.IPAddress.Parse("228.218.85.90"), }, { System.Net.IPAddress.Parse("99.161.225.217"), System.Net.IPAddress.Parse("212.244.121.89"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 127,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("86.14.45.195"), System.Net.IPAddress.Parse("71.140.32.68"), }, { System.Net.IPAddress.Parse("116.194.61.77"), System.Net.IPAddress.Parse("194.184.93.134"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 111,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("38.182.177.5"), System.Net.IPAddress.Parse("121.162.215.30"), }, { System.Net.IPAddress.Parse("93.106.67.208"), System.Net.IPAddress.Parse("236.249.65.23"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("204.148.130.15"), System.Net.IPAddress.Parse("133.112.36.112"), }, { System.Net.IPAddress.Parse("164.9.48.206"), System.Net.IPAddress.Parse("221.214.156.111"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("120.61.25.146"), System.Net.IPAddress.Parse("49.247.70.8"), }, { System.Net.IPAddress.Parse("69.177.139.180"), System.Net.IPAddress.Parse("111.25.78.182"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 130,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("189.47.153.217"), System.Net.IPAddress.Parse("245.14.251.230"), }, { System.Net.IPAddress.Parse("55.123.141.184"), System.Net.IPAddress.Parse("244.80.205.102"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 116,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("41.103.16.175"), System.Net.IPAddress.Parse("195.78.129.7"), }, { System.Net.IPAddress.Parse("234.208.96.118"), System.Net.IPAddress.Parse("73.83.240.56"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("233.56.162.164"), System.Net.IPAddress.Parse("135.46.188.168"), }, { System.Net.IPAddress.Parse("27.113.57.134"), System.Net.IPAddress.Parse("87.107.45.121"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("124.235.138.236"), System.Net.IPAddress.Parse("76.186.152.8"), }, { System.Net.IPAddress.Parse("48.221.34.38"), System.Net.IPAddress.Parse("187.134.49.114"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 133,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("100.113.28.105"), System.Net.IPAddress.Parse("139.117.103.70"), }, { System.Net.IPAddress.Parse("157.130.18.194"), System.Net.IPAddress.Parse("208.72.149.73"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 124,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("53.107.14.236"), System.Net.IPAddress.Parse("197.202.199.230"), }, { System.Net.IPAddress.Parse("162.180.254.115"), System.Net.IPAddress.Parse("243.21.196.242"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("161.9.9.238"), System.Net.IPAddress.Parse("154.72.152.230"), }, { System.Net.IPAddress.Parse("23.21.86.132"), System.Net.IPAddress.Parse("98.155.142.74"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("110.159.131.44"), System.Net.IPAddress.Parse("21.30.127.26"), }, { System.Net.IPAddress.Parse("109.4.9.144"), System.Net.IPAddress.Parse("16.174.4.229"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 134,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("41.62.103.17"), System.Net.IPAddress.Parse("228.198.145.166"), }, { System.Net.IPAddress.Parse("0.195.167.145"), System.Net.IPAddress.Parse("163.7.163.177"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 127,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("82.180.138.179"), System.Net.IPAddress.Parse("189.170.93.181"), }, { System.Net.IPAddress.Parse("10.117.178.250"), System.Net.IPAddress.Parse("55.40.88.99"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("47.125.199.151"), System.Net.IPAddress.Parse("231.183.244.111"), }, { System.Net.IPAddress.Parse("243.136.59.39"), System.Net.IPAddress.Parse("184.108.241.218"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 137,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("6.8.171.176"), System.Net.IPAddress.Parse("104.32.44.17"), }, { System.Net.IPAddress.Parse("199.109.5.103"), System.Net.IPAddress.Parse("5.146.74.102"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 131,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("72.31.248.71"), System.Net.IPAddress.Parse("144.101.82.68"), }, { System.Net.IPAddress.Parse("52.18.62.118"), System.Net.IPAddress.Parse("68.197.35.114"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("181.214.7.144"), System.Net.IPAddress.Parse("72.99.254.189"), }, { System.Net.IPAddress.Parse("215.83.224.29"), System.Net.IPAddress.Parse("75.172.88.178"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("248.15.21.34"), System.Net.IPAddress.Parse("18.128.52.197"), }, { System.Net.IPAddress.Parse("7.146.178.231"), System.Net.IPAddress.Parse("70.191.162.165"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 146,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("40.118.10.177"), System.Net.IPAddress.Parse("99.201.10.231"), }, { System.Net.IPAddress.Parse("195.215.27.156"), System.Net.IPAddress.Parse("180.182.42.161"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 136,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("146.135.32.202"), System.Net.IPAddress.Parse("56.188.41.39"), }, { System.Net.IPAddress.Parse("214.253.96.147"), System.Net.IPAddress.Parse("161.57.59.248"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("96.24.237.225"), System.Net.IPAddress.Parse("74.102.32.178"), }, { System.Net.IPAddress.Parse("114.84.181.173"), System.Net.IPAddress.Parse("170.33.92.184"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("248.243.114.194"), System.Net.IPAddress.Parse("165.131.65.146"), }, { System.Net.IPAddress.Parse("54.113.202.27"), System.Net.IPAddress.Parse("18.201.87.216"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 153,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("44.224.7.57"), System.Net.IPAddress.Parse("136.215.99.79"), }, { System.Net.IPAddress.Parse("36.170.235.254"), System.Net.IPAddress.Parse("245.233.52.205"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 144,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("9.80.84.235"), System.Net.IPAddress.Parse("204.128.184.126"), }, { System.Net.IPAddress.Parse("152.148.184.209"), System.Net.IPAddress.Parse("79.68.44.209"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("2.138.43.190"), System.Net.IPAddress.Parse("224.56.97.54"), }, { System.Net.IPAddress.Parse("237.104.119.183"), System.Net.IPAddress.Parse("183.234.121.67"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("110.50.161.252"), System.Net.IPAddress.Parse("87.251.112.4"), }, { System.Net.IPAddress.Parse("137.229.22.31"), System.Net.IPAddress.Parse("46.40.20.125"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 161,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("13.110.183.94"), System.Net.IPAddress.Parse("192.49.20.163"), }, { System.Net.IPAddress.Parse("205.141.161.62"), System.Net.IPAddress.Parse("234.36.163.170"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 151,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("99.75.138.180"), System.Net.IPAddress.Parse("14.86.139.42"), }, { System.Net.IPAddress.Parse("126.47.120.121"), System.Net.IPAddress.Parse("129.224.50.237"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 162,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("212.27.178.38"), System.Net.IPAddress.Parse("211.50.4.57"), }, { System.Net.IPAddress.Parse("249.55.164.76"), System.Net.IPAddress.Parse("227.43.186.6"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 160,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("107.233.252.206"), System.Net.IPAddress.Parse("84.199.244.164"), }, { System.Net.IPAddress.Parse("243.46.30.103"), System.Net.IPAddress.Parse("161.198.12.171"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 167,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("217.122.234.43"), System.Net.IPAddress.Parse("163.181.243.120"), }, { System.Net.IPAddress.Parse("143.209.72.14"), System.Net.IPAddress.Parse("242.51.85.39"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 162,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("152.209.83.43"), System.Net.IPAddress.Parse("99.185.236.47"), }, { System.Net.IPAddress.Parse("252.143.85.46"), System.Net.IPAddress.Parse("108.29.188.81"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("95.78.66.124"), System.Net.IPAddress.Parse("25.125.12.222"), }, { System.Net.IPAddress.Parse("131.93.84.67"), System.Net.IPAddress.Parse("48.14.202.89"), }, },
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 172,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("107.172.81.100"), System.Net.IPAddress.Parse("197.84.25.124"), }, { System.Net.IPAddress.Parse("54.159.145.190"), System.Net.IPAddress.Parse("209.164.125.56"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 171,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("54.50.100.252"), System.Net.IPAddress.Parse("29.146.150.238"), }, { System.Net.IPAddress.Parse("105.6.187.129"), System.Net.IPAddress.Parse("231.209.160.210"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("228.133.26.190"), System.Net.IPAddress.Parse("64.102.141.159"), }, { System.Net.IPAddress.Parse("171.68.85.117"), System.Net.IPAddress.Parse("49.103.151.57"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 180,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("156.217.45.254"), System.Net.IPAddress.Parse("157.108.99.200"), }, { System.Net.IPAddress.Parse("206.78.120.47"), System.Net.IPAddress.Parse("113.148.165.122"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 173,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("166.84.18.175"), System.Net.IPAddress.Parse("109.7.222.22"), }, { System.Net.IPAddress.Parse("171.210.21.198"), System.Net.IPAddress.Parse("162.217.119.119"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("150.124.240.81"), System.Net.IPAddress.Parse("64.125.212.53"), }, { System.Net.IPAddress.Parse("106.153.139.112"), System.Net.IPAddress.Parse("225.240.252.149"), }, },
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("93.40.200.5"), System.Net.IPAddress.Parse("220.211.172.170"), }, { System.Net.IPAddress.Parse("90.36.193.81"), System.Net.IPAddress.Parse("241.105.166.47"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 186,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("28.68.160.170"), System.Net.IPAddress.Parse("171.2.18.52"), }, { System.Net.IPAddress.Parse("29.168.3.170"), System.Net.IPAddress.Parse("246.16.65.148"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 182,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("197.212.34.145"), System.Net.IPAddress.Parse("80.104.17.93"), }, { System.Net.IPAddress.Parse("216.245.67.213"), System.Net.IPAddress.Parse("107.132.121.183"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD2E1M
{
    Id = 191,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("121.154.42.188"), System.Net.IPAddress.Parse("88.202.238.37"), }, { System.Net.IPAddress.Parse("10.41.104.218"), System.Net.IPAddress.Parse("205.31.161.101"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 189,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("98.202.28.146"), System.Net.IPAddress.Parse("174.221.61.9"), }, { System.Net.IPAddress.Parse("10.63.234.207"), System.Net.IPAddress.Parse("72.129.1.211"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("8.227.176.243"), System.Net.IPAddress.Parse("88.180.108.28"), }, { System.Net.IPAddress.Parse("230.52.129.19"), System.Net.IPAddress.Parse("247.56.48.238"), }, },
},
            new IPAddressMArrayD2E1M
{
    Id = 198,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("209.10.184.249"), System.Net.IPAddress.Parse("97.48.92.211"), }, { System.Net.IPAddress.Parse("251.194.93.96"), System.Net.IPAddress.Parse("162.241.138.215"), }, },
    ModelInner = new IPAddressMArrayD2E1MI
{
    Id = 190,
    Value = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("208.153.10.88"), System.Net.IPAddress.Parse("56.204.4.43"), }, { System.Net.IPAddress.Parse("217.251.246.150"), System.Net.IPAddress.Parse("80.170.98.84"), }, },
    NullableValue = 
new System.Net.IPAddress[,] { { System.Net.IPAddress.Parse("180.216.68.5"), System.Net.IPAddress.Parse("203.41.193.240"), }, { System.Net.IPAddress.Parse("180.158.195.151"), System.Net.IPAddress.Parse("252.132.15.216"), }, },
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

