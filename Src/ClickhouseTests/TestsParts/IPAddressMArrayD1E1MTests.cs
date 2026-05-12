

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
    internal partial interface IIPAddressMArrayMArrayD1
    {
    }
    
    internal partial class IPAddressMArrayMArrayD1 : IIPAddressMArrayMArrayD1
    {


#region TestData

        private readonly IPAddressMArrayD1E1M[] _testData = new IPAddressMArrayD1E1M[]
        {
            new IPAddressMArrayD1E1M
{
    Id = 7,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("181.65.68.234"),
System.Net.IPAddress.Parse("47.113.209.82"),
System.Net.IPAddress.Parse("35.15.154.0"),
System.Net.IPAddress.Parse("110.176.190.218"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 4,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("179.53.16.42"),
System.Net.IPAddress.Parse("162.130.176.239"),
System.Net.IPAddress.Parse("145.243.205.20"),
System.Net.IPAddress.Parse("163.199.57.121"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 13,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("154.177.138.59"),
System.Net.IPAddress.Parse("11.76.222.224"),
System.Net.IPAddress.Parse("248.39.156.186"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 11,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("163.158.149.179"),
System.Net.IPAddress.Parse("16.84.135.175"),
System.Net.IPAddress.Parse("136.245.72.252"),
System.Net.IPAddress.Parse("17.248.238.36"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("75.37.120.172"),
System.Net.IPAddress.Parse("158.153.250.159"),
System.Net.IPAddress.Parse("169.101.89.149"),
System.Net.IPAddress.Parse("61.218.99.135"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("37.100.219.67"),
System.Net.IPAddress.Parse("238.107.111.155"),
System.Net.IPAddress.Parse("12.119.54.53"),
System.Net.IPAddress.Parse("19.185.82.42"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 14,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("134.226.29.187"),
System.Net.IPAddress.Parse("125.87.153.137"),
System.Net.IPAddress.Parse("133.68.170.107"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("178.207.129.167"),
System.Net.IPAddress.Parse("70.97.245.70"),
System.Net.IPAddress.Parse("177.73.60.97"),
System.Net.IPAddress.Parse("237.110.47.62"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 23,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("19.48.25.168"),
System.Net.IPAddress.Parse("85.115.170.212"),
System.Net.IPAddress.Parse("38.148.252.31"),
System.Net.IPAddress.Parse("214.171.191.155"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 21,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("55.113.106.211"),
System.Net.IPAddress.Parse("151.178.54.209"),
System.Net.IPAddress.Parse("210.113.15.234"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("172.24.143.102"),
System.Net.IPAddress.Parse("30.117.149.106"),
System.Net.IPAddress.Parse("208.9.167.186"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 25,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("5.181.192.47"),
System.Net.IPAddress.Parse("204.37.244.19"),
System.Net.IPAddress.Parse("168.40.135.217"),
System.Net.IPAddress.Parse("102.101.212.64"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 24,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("186.59.183.251"),
System.Net.IPAddress.Parse("3.180.206.38"),
System.Net.IPAddress.Parse("172.119.180.7"),
System.Net.IPAddress.Parse("12.209.228.106"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("6.29.235.162"),
System.Net.IPAddress.Parse("219.165.235.103"),
System.Net.IPAddress.Parse("150.188.236.207"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("206.229.16.205"),
System.Net.IPAddress.Parse("143.168.118.243"),
System.Net.IPAddress.Parse("133.220.24.120"),
System.Net.IPAddress.Parse("139.168.80.22"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 30,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("213.53.135.173"),
System.Net.IPAddress.Parse("196.3.230.71"),
System.Net.IPAddress.Parse("217.228.104.1"),
System.Net.IPAddress.Parse("98.63.65.208"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.159.75.67"),
System.Net.IPAddress.Parse("180.105.63.227"),
System.Net.IPAddress.Parse("11.143.136.250"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("174.75.165.50"),
System.Net.IPAddress.Parse("72.22.46.53"),
System.Net.IPAddress.Parse("203.180.157.14"),
System.Net.IPAddress.Parse("120.31.68.211"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 39,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("10.195.189.92"),
System.Net.IPAddress.Parse("107.108.232.185"),
System.Net.IPAddress.Parse("87.25.47.154"),
System.Net.IPAddress.Parse("243.9.254.93"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 34,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("159.76.30.49"),
System.Net.IPAddress.Parse("230.195.15.117"),
System.Net.IPAddress.Parse("99.10.163.254"),
System.Net.IPAddress.Parse("127.51.167.165"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 40,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("242.196.46.229"),
System.Net.IPAddress.Parse("115.13.26.47"),
System.Net.IPAddress.Parse("176.139.73.88"),
System.Net.IPAddress.Parse("231.63.110.212"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 41,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("94.153.3.158"),
System.Net.IPAddress.Parse("148.49.193.180"),
System.Net.IPAddress.Parse("129.200.10.242"),
System.Net.IPAddress.Parse("250.180.201.93"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("126.135.122.142"),
System.Net.IPAddress.Parse("233.183.48.222"),
System.Net.IPAddress.Parse("115.102.57.88"),
System.Net.IPAddress.Parse("48.204.106.143"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("233.138.43.243"),
System.Net.IPAddress.Parse("199.53.45.127"),
System.Net.IPAddress.Parse("135.159.108.128"),
System.Net.IPAddress.Parse("200.140.254.31"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 47,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("63.108.80.53"),
System.Net.IPAddress.Parse("212.43.76.226"),
System.Net.IPAddress.Parse("243.79.186.237"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("34.171.126.142"),
System.Net.IPAddress.Parse("206.208.199.88"),
System.Net.IPAddress.Parse("222.180.52.131"),
System.Net.IPAddress.Parse("30.131.40.207"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("85.101.6.135"),
System.Net.IPAddress.Parse("241.25.179.238"),
System.Net.IPAddress.Parse("237.111.0.85"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 51,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("189.125.177.241"),
System.Net.IPAddress.Parse("73.202.109.101"),
System.Net.IPAddress.Parse("74.133.93.115"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 51,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("109.33.216.109"),
System.Net.IPAddress.Parse("116.64.81.224"),
System.Net.IPAddress.Parse("215.63.3.19"),
System.Net.IPAddress.Parse("144.159.84.162"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("201.223.128.38"),
System.Net.IPAddress.Parse("233.254.211.119"),
System.Net.IPAddress.Parse("55.100.235.212"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("155.205.114.51"),
System.Net.IPAddress.Parse("84.50.129.233"),
System.Net.IPAddress.Parse("231.203.210.29"),
System.Net.IPAddress.Parse("24.86.79.132"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 53,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("143.166.125.190"),
System.Net.IPAddress.Parse("95.214.2.177"),
System.Net.IPAddress.Parse("177.191.198.86"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 53,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("11.152.206.227"),
System.Net.IPAddress.Parse("1.220.145.75"),
System.Net.IPAddress.Parse("124.2.23.164"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("60.217.120.124"),
System.Net.IPAddress.Parse("136.27.18.100"),
System.Net.IPAddress.Parse("90.180.184.221"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 59,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("189.107.236.11"),
System.Net.IPAddress.Parse("219.211.163.232"),
System.Net.IPAddress.Parse("22.40.180.196"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 62,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("144.233.61.188"),
System.Net.IPAddress.Parse("247.160.143.33"),
System.Net.IPAddress.Parse("195.181.101.95"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("100.27.64.80"),
System.Net.IPAddress.Parse("65.253.242.6"),
System.Net.IPAddress.Parse("108.143.158.14"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("136.174.198.110"),
System.Net.IPAddress.Parse("190.107.228.12"),
System.Net.IPAddress.Parse("57.11.48.188"),
System.Net.IPAddress.Parse("251.186.160.161"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 66,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("195.72.48.215"),
System.Net.IPAddress.Parse("204.147.54.127"),
System.Net.IPAddress.Parse("155.32.224.171"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 65,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("112.126.24.86"),
System.Net.IPAddress.Parse("52.21.148.155"),
System.Net.IPAddress.Parse("6.75.161.134"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 74,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("194.16.27.147"),
System.Net.IPAddress.Parse("153.41.3.254"),
System.Net.IPAddress.Parse("187.75.183.115"),
System.Net.IPAddress.Parse("197.153.59.117"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 68,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("179.178.41.213"),
System.Net.IPAddress.Parse("20.146.71.179"),
System.Net.IPAddress.Parse("170.3.27.172"),
System.Net.IPAddress.Parse("108.231.97.178"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("73.63.48.65"),
System.Net.IPAddress.Parse("55.49.210.227"),
System.Net.IPAddress.Parse("164.236.245.5"),
System.Net.IPAddress.Parse("110.69.127.247"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 82,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("27.200.170.247"),
System.Net.IPAddress.Parse("247.102.85.23"),
System.Net.IPAddress.Parse("49.145.62.112"),
System.Net.IPAddress.Parse("108.6.42.237"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("206.55.148.234"),
System.Net.IPAddress.Parse("179.205.201.154"),
System.Net.IPAddress.Parse("157.195.71.9"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("168.183.186.24"),
System.Net.IPAddress.Parse("21.52.100.180"),
System.Net.IPAddress.Parse("122.112.94.13"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 88,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("183.69.53.196"),
System.Net.IPAddress.Parse("3.136.217.181"),
System.Net.IPAddress.Parse("92.145.203.158"),
System.Net.IPAddress.Parse("206.13.224.66"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 79,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("62.153.95.238"),
System.Net.IPAddress.Parse("73.116.3.213"),
System.Net.IPAddress.Parse("43.235.17.243"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("31.147.24.197"),
System.Net.IPAddress.Parse("83.163.89.14"),
System.Net.IPAddress.Parse("52.251.142.149"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 90,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("108.75.56.6"),
System.Net.IPAddress.Parse("67.247.81.73"),
System.Net.IPAddress.Parse("24.176.41.69"),
System.Net.IPAddress.Parse("4.42.156.229"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 87,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("98.59.250.70"),
System.Net.IPAddress.Parse("38.105.192.135"),
System.Net.IPAddress.Parse("230.158.166.219"),
System.Net.IPAddress.Parse("20.135.100.137"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 92,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("149.125.125.60"),
System.Net.IPAddress.Parse("158.232.137.219"),
System.Net.IPAddress.Parse("206.184.65.103"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 90,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("37.45.94.196"),
System.Net.IPAddress.Parse("100.24.239.122"),
System.Net.IPAddress.Parse("25.76.108.109"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 100,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("81.73.241.174"),
System.Net.IPAddress.Parse("122.68.134.254"),
System.Net.IPAddress.Parse("88.170.19.227"),
System.Net.IPAddress.Parse("146.77.236.149"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 98,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("145.226.102.96"),
System.Net.IPAddress.Parse("2.186.23.38"),
System.Net.IPAddress.Parse("43.114.68.127"),
System.Net.IPAddress.Parse("124.70.89.107"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("55.210.226.52"),
System.Net.IPAddress.Parse("74.66.102.237"),
System.Net.IPAddress.Parse("191.52.68.160"),
System.Net.IPAddress.Parse("22.42.158.48"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 101,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("193.69.63.90"),
System.Net.IPAddress.Parse("238.191.50.241"),
System.Net.IPAddress.Parse("73.176.253.13"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 112,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("110.52.148.9"),
System.Net.IPAddress.Parse("243.252.81.137"),
System.Net.IPAddress.Parse("8.113.94.222"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 102,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("33.80.20.147"),
System.Net.IPAddress.Parse("39.3.136.252"),
System.Net.IPAddress.Parse("78.130.33.188"),
System.Net.IPAddress.Parse("143.212.127.39"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("89.53.9.121"),
System.Net.IPAddress.Parse("74.229.107.246"),
System.Net.IPAddress.Parse("161.119.240.105"),
System.Net.IPAddress.Parse("154.216.129.96"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("229.189.94.73"),
System.Net.IPAddress.Parse("61.144.137.54"),
System.Net.IPAddress.Parse("196.92.200.103"),
System.Net.IPAddress.Parse("166.173.121.99"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 120,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("25.29.77.93"),
System.Net.IPAddress.Parse("80.87.187.59"),
System.Net.IPAddress.Parse("94.52.37.190"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 109,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("3.112.131.28"),
System.Net.IPAddress.Parse("26.69.2.169"),
System.Net.IPAddress.Parse("97.137.190.238"),
System.Net.IPAddress.Parse("84.6.173.234"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("244.146.87.138"),
System.Net.IPAddress.Parse("2.67.207.49"),
System.Net.IPAddress.Parse("133.73.115.176"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 127,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("45.124.101.37"),
System.Net.IPAddress.Parse("145.57.80.189"),
System.Net.IPAddress.Parse("38.125.211.118"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 110,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("186.210.114.182"),
System.Net.IPAddress.Parse("153.186.214.222"),
System.Net.IPAddress.Parse("144.195.45.221"),
System.Net.IPAddress.Parse("34.225.134.26"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("169.205.111.212"),
System.Net.IPAddress.Parse("54.96.208.111"),
System.Net.IPAddress.Parse("245.119.221.79"),
System.Net.IPAddress.Parse("223.206.237.23"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 128,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("98.116.168.163"),
System.Net.IPAddress.Parse("72.123.38.151"),
System.Net.IPAddress.Parse("165.206.138.38"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 114,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("201.62.97.76"),
System.Net.IPAddress.Parse("91.14.222.230"),
System.Net.IPAddress.Parse("147.205.236.211"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 130,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("214.174.74.1"),
System.Net.IPAddress.Parse("180.166.59.7"),
System.Net.IPAddress.Parse("188.66.42.83"),
System.Net.IPAddress.Parse("172.73.57.72"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 123,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("12.25.123.112"),
System.Net.IPAddress.Parse("251.207.34.56"),
System.Net.IPAddress.Parse("14.7.200.221"),
System.Net.IPAddress.Parse("107.150.22.225"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("165.56.78.138"),
System.Net.IPAddress.Parse("94.189.167.75"),
System.Net.IPAddress.Parse("29.109.75.10"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 138,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("23.146.115.108"),
System.Net.IPAddress.Parse("234.200.152.36"),
System.Net.IPAddress.Parse("114.150.32.245"),
System.Net.IPAddress.Parse("134.98.186.184"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 127,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("133.87.107.39"),
System.Net.IPAddress.Parse("160.121.194.182"),
System.Net.IPAddress.Parse("219.59.228.126"),
System.Net.IPAddress.Parse("117.220.212.169"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("223.253.221.165"),
System.Net.IPAddress.Parse("116.167.128.231"),
System.Net.IPAddress.Parse("67.248.0.35"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("69.213.211.133"),
System.Net.IPAddress.Parse("207.99.97.249"),
System.Net.IPAddress.Parse("199.140.77.219"),
System.Net.IPAddress.Parse("23.28.227.20"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 139,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("129.123.111.115"),
System.Net.IPAddress.Parse("130.112.63.101"),
System.Net.IPAddress.Parse("11.188.182.101"),
System.Net.IPAddress.Parse("58.163.180.11"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 130,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("125.175.107.122"),
System.Net.IPAddress.Parse("81.217.253.127"),
System.Net.IPAddress.Parse("176.236.84.89"),
System.Net.IPAddress.Parse("70.232.172.40"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("42.202.106.6"),
System.Net.IPAddress.Parse("43.64.208.107"),
System.Net.IPAddress.Parse("92.254.194.83"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 144,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("231.13.241.58"),
System.Net.IPAddress.Parse("176.105.236.246"),
System.Net.IPAddress.Parse("64.61.218.16"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 134,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("140.251.77.91"),
System.Net.IPAddress.Parse("87.172.227.167"),
System.Net.IPAddress.Parse("220.21.84.248"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("206.39.211.220"),
System.Net.IPAddress.Parse("172.65.200.93"),
System.Net.IPAddress.Parse("175.179.162.197"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 153,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("128.151.161.84"),
System.Net.IPAddress.Parse("30.32.63.108"),
System.Net.IPAddress.Parse("67.63.148.197"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 142,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("191.38.63.162"),
System.Net.IPAddress.Parse("167.10.210.146"),
System.Net.IPAddress.Parse("171.9.12.25"),
System.Net.IPAddress.Parse("247.187.180.61"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 158,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("179.74.57.111"),
System.Net.IPAddress.Parse("239.145.102.183"),
System.Net.IPAddress.Parse("173.129.61.182"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 148,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("197.186.160.132"),
System.Net.IPAddress.Parse("88.185.252.168"),
System.Net.IPAddress.Parse("77.210.254.243"),
System.Net.IPAddress.Parse("160.166.222.225"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("28.204.247.183"),
System.Net.IPAddress.Parse("8.168.69.21"),
System.Net.IPAddress.Parse("245.41.140.73"),
System.Net.IPAddress.Parse("7.78.121.104"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 160,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("232.118.92.186"),
System.Net.IPAddress.Parse("246.94.92.163"),
System.Net.IPAddress.Parse("219.23.125.152"),
System.Net.IPAddress.Parse("56.227.17.166"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 155,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("209.81.252.104"),
System.Net.IPAddress.Parse("230.205.202.221"),
System.Net.IPAddress.Parse("110.167.130.123"),
System.Net.IPAddress.Parse("109.252.170.18"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("96.223.207.80"),
System.Net.IPAddress.Parse("144.169.179.196"),
System.Net.IPAddress.Parse("217.18.71.37"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 168,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("78.150.202.30"),
System.Net.IPAddress.Parse("50.222.198.86"),
System.Net.IPAddress.Parse("112.85.164.143"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 156,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("69.114.203.218"),
System.Net.IPAddress.Parse("184.236.242.5"),
System.Net.IPAddress.Parse("45.162.182.237"),
System.Net.IPAddress.Parse("241.56.223.110"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 170,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("173.196.236.38"),
System.Net.IPAddress.Parse("114.93.117.228"),
System.Net.IPAddress.Parse("121.131.34.204"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 162,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("42.122.38.243"),
System.Net.IPAddress.Parse("206.26.149.193"),
System.Net.IPAddress.Parse("150.223.6.137"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("166.30.49.91"),
System.Net.IPAddress.Parse("19.21.147.44"),
System.Net.IPAddress.Parse("57.229.91.17"),
System.Net.IPAddress.Parse("38.113.109.53"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("240.231.56.242"),
System.Net.IPAddress.Parse("41.163.42.14"),
System.Net.IPAddress.Parse("226.243.222.113"),
System.Net.IPAddress.Parse("121.85.139.1"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 172,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("172.163.237.238"),
System.Net.IPAddress.Parse("254.118.157.82"),
System.Net.IPAddress.Parse("25.136.226.51"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 165,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("121.117.77.254"),
System.Net.IPAddress.Parse("156.45.157.253"),
System.Net.IPAddress.Parse("142.47.3.26"),
System.Net.IPAddress.Parse("238.30.228.183"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("108.189.174.177"),
System.Net.IPAddress.Parse("52.25.39.203"),
System.Net.IPAddress.Parse("163.213.220.58"),
System.Net.IPAddress.Parse("68.43.233.30"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 176,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("231.93.6.20"),
System.Net.IPAddress.Parse("113.11.120.32"),
System.Net.IPAddress.Parse("14.201.143.173"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 168,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("29.46.179.41"),
System.Net.IPAddress.Parse("94.111.39.253"),
System.Net.IPAddress.Parse("53.225.245.37"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("62.221.191.229"),
System.Net.IPAddress.Parse("127.165.236.73"),
System.Net.IPAddress.Parse("95.125.130.122"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("210.9.136.176"),
System.Net.IPAddress.Parse("139.159.63.143"),
System.Net.IPAddress.Parse("21.227.41.142"),
System.Net.IPAddress.Parse("109.191.199.220"),
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.ipaddressmarrayd1e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(IPv4)}, 
    {mi_id:Int32},
    {mi_value:Array(IPv4)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]), 
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
                    await ((IIPAddressMArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((IIPAddressMArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.ipaddressmarrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(IPAddressMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayMArrayD1)),
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
                    var models = await ((IIPAddressMArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    IPAddressMArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IIPAddressMArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    IPAddressMArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

