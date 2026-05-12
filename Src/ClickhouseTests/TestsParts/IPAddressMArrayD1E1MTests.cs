

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
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("60.113.104.172"),
System.Net.IPAddress.Parse("118.9.191.201"),
System.Net.IPAddress.Parse("188.148.25.33"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 3,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("98.194.90.114"),
System.Net.IPAddress.Parse("217.15.38.60"),
System.Net.IPAddress.Parse("152.217.55.14"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("248.223.132.112"),
System.Net.IPAddress.Parse("57.57.156.28"),
System.Net.IPAddress.Parse("110.176.74.206"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 9,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("234.249.194.4"),
System.Net.IPAddress.Parse("181.64.162.163"),
System.Net.IPAddress.Parse("135.116.9.185"),
System.Net.IPAddress.Parse("133.219.105.102"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("47.248.167.219"),
System.Net.IPAddress.Parse("183.249.208.74"),
System.Net.IPAddress.Parse("216.101.197.141"),
System.Net.IPAddress.Parse("115.194.93.139"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("60.71.210.6"),
System.Net.IPAddress.Parse("22.212.141.250"),
System.Net.IPAddress.Parse("120.192.130.221"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 16,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("242.204.0.100"),
System.Net.IPAddress.Parse("240.108.40.56"),
System.Net.IPAddress.Parse("165.109.187.201"),
System.Net.IPAddress.Parse("55.14.189.145"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("149.89.65.220"),
System.Net.IPAddress.Parse("184.163.2.183"),
System.Net.IPAddress.Parse("153.132.162.227"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 22,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("104.222.69.125"),
System.Net.IPAddress.Parse("76.247.51.228"),
System.Net.IPAddress.Parse("178.168.187.35"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 17,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("236.1.198.42"),
System.Net.IPAddress.Parse("82.253.125.202"),
System.Net.IPAddress.Parse("158.67.1.84"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("32.214.10.251"),
System.Net.IPAddress.Parse("229.99.133.104"),
System.Net.IPAddress.Parse("96.113.192.208"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 24,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("94.165.146.65"),
System.Net.IPAddress.Parse("186.100.131.226"),
System.Net.IPAddress.Parse("211.206.8.67"),
System.Net.IPAddress.Parse("109.43.102.22"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 26,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("23.60.66.63"),
System.Net.IPAddress.Parse("27.231.53.142"),
System.Net.IPAddress.Parse("155.90.180.137"),
System.Net.IPAddress.Parse("39.65.14.144"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("97.0.75.99"),
System.Net.IPAddress.Parse("89.16.155.228"),
System.Net.IPAddress.Parse("111.61.250.120"),
System.Net.IPAddress.Parse("77.47.229.16"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("226.40.219.22"),
System.Net.IPAddress.Parse("68.169.238.200"),
System.Net.IPAddress.Parse("149.204.113.47"),
System.Net.IPAddress.Parse("34.35.106.55"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 25,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("227.189.114.175"),
System.Net.IPAddress.Parse("31.17.63.215"),
System.Net.IPAddress.Parse("188.45.124.125"),
System.Net.IPAddress.Parse("52.89.58.9"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("100.82.200.122"),
System.Net.IPAddress.Parse("126.120.72.48"),
System.Net.IPAddress.Parse("42.50.147.92"),
System.Net.IPAddress.Parse("86.127.142.130"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("27.227.162.3"),
System.Net.IPAddress.Parse("144.254.179.196"),
System.Net.IPAddress.Parse("102.58.84.254"),
System.Net.IPAddress.Parse("213.147.147.120"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 29,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("29.86.33.247"),
System.Net.IPAddress.Parse("75.51.47.232"),
System.Net.IPAddress.Parse("170.54.95.103"),
System.Net.IPAddress.Parse("240.6.191.77"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 33,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("237.88.153.29"),
System.Net.IPAddress.Parse("246.192.208.71"),
System.Net.IPAddress.Parse("185.199.157.117"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("213.229.86.108"),
System.Net.IPAddress.Parse("96.7.49.172"),
System.Net.IPAddress.Parse("122.81.116.24"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 38,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("119.65.41.236"),
System.Net.IPAddress.Parse("132.248.59.40"),
System.Net.IPAddress.Parse("4.93.107.73"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 38,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("239.186.30.177"),
System.Net.IPAddress.Parse("187.202.36.241"),
System.Net.IPAddress.Parse("133.11.227.103"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("41.131.39.146"),
System.Net.IPAddress.Parse("63.35.138.222"),
System.Net.IPAddress.Parse("170.23.52.80"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 45,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("114.148.109.78"),
System.Net.IPAddress.Parse("108.143.252.143"),
System.Net.IPAddress.Parse("218.37.7.168"),
System.Net.IPAddress.Parse("55.57.250.87"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 47,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("74.144.173.117"),
System.Net.IPAddress.Parse("196.115.38.57"),
System.Net.IPAddress.Parse("118.141.191.73"),
System.Net.IPAddress.Parse("124.20.2.37"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("90.96.108.197"),
System.Net.IPAddress.Parse("47.69.191.138"),
System.Net.IPAddress.Parse("113.37.86.110"),
System.Net.IPAddress.Parse("41.170.130.6"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 50,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("124.145.70.90"),
System.Net.IPAddress.Parse("203.223.16.229"),
System.Net.IPAddress.Parse("61.114.34.188"),
System.Net.IPAddress.Parse("198.78.232.103"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 48,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("165.101.100.55"),
System.Net.IPAddress.Parse("186.101.64.118"),
System.Net.IPAddress.Parse("253.27.37.33"),
System.Net.IPAddress.Parse("121.7.134.54"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 53,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("246.24.33.60"),
System.Net.IPAddress.Parse("6.96.149.60"),
System.Net.IPAddress.Parse("240.250.159.41"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 56,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("239.166.46.217"),
System.Net.IPAddress.Parse("178.59.180.44"),
System.Net.IPAddress.Parse("156.188.171.126"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("249.170.49.237"),
System.Net.IPAddress.Parse("217.213.51.64"),
System.Net.IPAddress.Parse("240.235.88.37"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 60,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("147.213.113.45"),
System.Net.IPAddress.Parse("155.121.244.199"),
System.Net.IPAddress.Parse("132.93.95.63"),
System.Net.IPAddress.Parse("120.11.97.33"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 59,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.7.153.188"),
System.Net.IPAddress.Parse("78.105.163.111"),
System.Net.IPAddress.Parse("85.125.63.70"),
System.Net.IPAddress.Parse("102.243.176.242"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("233.231.89.72"),
System.Net.IPAddress.Parse("114.175.221.54"),
System.Net.IPAddress.Parse("95.103.151.23"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("156.21.13.153"),
System.Net.IPAddress.Parse("154.192.201.102"),
System.Net.IPAddress.Parse("47.52.214.239"),
System.Net.IPAddress.Parse("8.49.18.165"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 62,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("96.18.98.141"),
System.Net.IPAddress.Parse("23.83.223.73"),
System.Net.IPAddress.Parse("43.6.101.73"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 63,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("43.97.138.154"),
System.Net.IPAddress.Parse("218.79.55.203"),
System.Net.IPAddress.Parse("193.170.57.160"),
System.Net.IPAddress.Parse("75.58.59.206"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 71,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("48.161.47.48"),
System.Net.IPAddress.Parse("180.78.230.150"),
System.Net.IPAddress.Parse("133.187.103.133"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 72,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.45.117.86"),
System.Net.IPAddress.Parse("74.116.24.234"),
System.Net.IPAddress.Parse("183.73.250.190"),
System.Net.IPAddress.Parse("118.141.34.80"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("131.12.114.151"),
System.Net.IPAddress.Parse("56.139.191.122"),
System.Net.IPAddress.Parse("83.152.72.148"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("136.36.207.42"),
System.Net.IPAddress.Parse("184.176.239.191"),
System.Net.IPAddress.Parse("83.169.6.252"),
System.Net.IPAddress.Parse("58.129.181.70"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 80,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("103.227.48.220"),
System.Net.IPAddress.Parse("169.236.238.27"),
System.Net.IPAddress.Parse("230.112.254.223"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.104.204.100"),
System.Net.IPAddress.Parse("142.147.31.108"),
System.Net.IPAddress.Parse("93.156.220.188"),
System.Net.IPAddress.Parse("234.113.77.35"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("21.77.63.235"),
System.Net.IPAddress.Parse("177.240.122.222"),
System.Net.IPAddress.Parse("140.83.157.158"),
System.Net.IPAddress.Parse("206.36.200.141"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 85,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("70.95.162.102"),
System.Net.IPAddress.Parse("49.214.202.4"),
System.Net.IPAddress.Parse("154.85.189.173"),
System.Net.IPAddress.Parse("169.6.112.162"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 87,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.199.89.54"),
System.Net.IPAddress.Parse("244.241.37.1"),
System.Net.IPAddress.Parse("148.108.174.77"),
System.Net.IPAddress.Parse("224.244.206.244"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 88,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("175.113.18.104"),
System.Net.IPAddress.Parse("118.72.37.37"),
System.Net.IPAddress.Parse("214.141.207.9"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 92,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("80.49.250.49"),
System.Net.IPAddress.Parse("96.157.221.126"),
System.Net.IPAddress.Parse("100.209.62.89"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 92,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("242.29.190.57"),
System.Net.IPAddress.Parse("190.146.144.124"),
System.Net.IPAddress.Parse("89.147.65.4"),
System.Net.IPAddress.Parse("61.56.69.124"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 101,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("98.201.26.252"),
System.Net.IPAddress.Parse("152.120.16.39"),
System.Net.IPAddress.Parse("81.63.180.99"),
System.Net.IPAddress.Parse("233.123.62.109"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("176.101.245.35"),
System.Net.IPAddress.Parse("78.124.6.82"),
System.Net.IPAddress.Parse("99.190.251.58"),
System.Net.IPAddress.Parse("197.184.158.136"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 95,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("99.8.129.169"),
System.Net.IPAddress.Parse("76.67.145.134"),
System.Net.IPAddress.Parse("48.119.11.207"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 102,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("63.97.95.3"),
System.Net.IPAddress.Parse("87.214.114.160"),
System.Net.IPAddress.Parse("91.43.205.131"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("14.221.229.138"),
System.Net.IPAddress.Parse("218.65.107.252"),
System.Net.IPAddress.Parse("33.14.141.33"),
System.Net.IPAddress.Parse("113.64.71.80"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("16.26.137.100"),
System.Net.IPAddress.Parse("243.197.126.36"),
System.Net.IPAddress.Parse("207.182.92.113"),
System.Net.IPAddress.Parse("206.19.183.224"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 104,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("192.85.122.15"),
System.Net.IPAddress.Parse("162.233.17.32"),
System.Net.IPAddress.Parse("49.188.154.251"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 109,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("18.159.214.193"),
System.Net.IPAddress.Parse("2.166.119.101"),
System.Net.IPAddress.Parse("177.89.53.28"),
System.Net.IPAddress.Parse("203.139.220.44"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 109,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("169.132.219.103"),
System.Net.IPAddress.Parse("132.171.16.84"),
System.Net.IPAddress.Parse("27.246.162.183"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 114,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("123.43.142.0"),
System.Net.IPAddress.Parse("9.115.194.165"),
System.Net.IPAddress.Parse("85.109.247.210"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 113,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("227.125.254.206"),
System.Net.IPAddress.Parse("134.254.145.208"),
System.Net.IPAddress.Parse("244.100.35.184"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 120,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("159.182.244.70"),
System.Net.IPAddress.Parse("6.79.193.21"),
System.Net.IPAddress.Parse("51.59.207.230"),
System.Net.IPAddress.Parse("16.32.154.160"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 122,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("111.125.43.131"),
System.Net.IPAddress.Parse("13.30.129.146"),
System.Net.IPAddress.Parse("212.107.185.232"),
System.Net.IPAddress.Parse("53.64.151.102"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 122,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("110.140.97.185"),
System.Net.IPAddress.Parse("235.61.161.173"),
System.Net.IPAddress.Parse("125.193.232.148"),
System.Net.IPAddress.Parse("63.154.180.88"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("219.149.147.57"),
System.Net.IPAddress.Parse("41.70.232.221"),
System.Net.IPAddress.Parse("234.132.150.95"),
System.Net.IPAddress.Parse("220.201.114.240"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("108.91.141.231"),
System.Net.IPAddress.Parse("74.206.185.222"),
System.Net.IPAddress.Parse("3.9.71.229"),
System.Net.IPAddress.Parse("21.208.125.11"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 127,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("92.199.124.223"),
System.Net.IPAddress.Parse("209.159.148.174"),
System.Net.IPAddress.Parse("36.39.190.22"),
System.Net.IPAddress.Parse("244.66.235.3"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 128,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("3.209.197.214"),
System.Net.IPAddress.Parse("149.61.140.248"),
System.Net.IPAddress.Parse("181.153.189.130"),
System.Net.IPAddress.Parse("97.98.22.56"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 130,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("33.176.167.60"),
System.Net.IPAddress.Parse("97.153.158.37"),
System.Net.IPAddress.Parse("162.109.135.29"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 137,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("68.233.144.13"),
System.Net.IPAddress.Parse("41.67.155.40"),
System.Net.IPAddress.Parse("106.220.84.162"),
System.Net.IPAddress.Parse("237.91.72.88"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("241.85.90.70"),
System.Net.IPAddress.Parse("171.182.242.188"),
System.Net.IPAddress.Parse("166.209.141.66"),
System.Net.IPAddress.Parse("191.17.207.23"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 137,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("60.195.215.92"),
System.Net.IPAddress.Parse("219.20.147.21"),
System.Net.IPAddress.Parse("51.236.54.110"),
System.Net.IPAddress.Parse("85.128.143.226"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 138,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("9.92.204.77"),
System.Net.IPAddress.Parse("221.56.195.186"),
System.Net.IPAddress.Parse("3.214.217.114"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("25.189.162.20"),
System.Net.IPAddress.Parse("36.143.122.214"),
System.Net.IPAddress.Parse("130.211.45.193"),
System.Net.IPAddress.Parse("8.31.121.201"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 138,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("247.26.82.217"),
System.Net.IPAddress.Parse("60.89.81.193"),
System.Net.IPAddress.Parse("124.135.217.126"),
System.Net.IPAddress.Parse("190.204.116.21"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 140,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("141.51.106.80"),
System.Net.IPAddress.Parse("26.198.197.78"),
System.Net.IPAddress.Parse("119.190.212.47"),
System.Net.IPAddress.Parse("121.31.9.65"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("234.42.0.130"),
System.Net.IPAddress.Parse("234.81.176.38"),
System.Net.IPAddress.Parse("13.215.64.103"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("152.72.62.67"),
System.Net.IPAddress.Parse("212.176.187.216"),
System.Net.IPAddress.Parse("133.204.151.205"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 143,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("169.1.208.86"),
System.Net.IPAddress.Parse("109.70.254.167"),
System.Net.IPAddress.Parse("43.27.209.183"),
System.Net.IPAddress.Parse("72.222.90.75"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 143,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("231.154.99.22"),
System.Net.IPAddress.Parse("231.46.21.214"),
System.Net.IPAddress.Parse("231.86.162.31"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 144,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("11.172.101.152"),
System.Net.IPAddress.Parse("195.184.49.249"),
System.Net.IPAddress.Parse("205.89.72.38"),
System.Net.IPAddress.Parse("48.30.207.95"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 151,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("98.80.175.109"),
System.Net.IPAddress.Parse("81.196.241.227"),
System.Net.IPAddress.Parse("106.119.107.58"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("191.161.12.80"),
System.Net.IPAddress.Parse("133.209.48.189"),
System.Net.IPAddress.Parse("139.235.101.243"),
System.Net.IPAddress.Parse("208.6.49.95"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("228.58.20.146"),
System.Net.IPAddress.Parse("160.200.240.241"),
System.Net.IPAddress.Parse("119.151.4.51"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 153,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("237.201.18.79"),
System.Net.IPAddress.Parse("214.253.219.240"),
System.Net.IPAddress.Parse("104.204.100.87"),
System.Net.IPAddress.Parse("211.202.36.193"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 152,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("137.39.189.117"),
System.Net.IPAddress.Parse("144.54.37.229"),
System.Net.IPAddress.Parse("182.26.131.95"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("220.172.33.104"),
System.Net.IPAddress.Parse("2.197.160.129"),
System.Net.IPAddress.Parse("64.112.109.180"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 160,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("28.129.175.173"),
System.Net.IPAddress.Parse("188.66.43.58"),
System.Net.IPAddress.Parse("251.164.116.41"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 160,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("200.150.216.165"),
System.Net.IPAddress.Parse("136.222.67.74"),
System.Net.IPAddress.Parse("102.166.161.85"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("81.102.11.24"),
System.Net.IPAddress.Parse("155.160.115.168"),
System.Net.IPAddress.Parse("184.5.29.24"),
System.Net.IPAddress.Parse("187.215.208.11"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 163,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("198.191.25.238"),
System.Net.IPAddress.Parse("199.38.105.181"),
System.Net.IPAddress.Parse("190.93.116.245"),
System.Net.IPAddress.Parse("193.127.51.191"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 165,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("90.193.101.246"),
System.Net.IPAddress.Parse("86.139.91.227"),
System.Net.IPAddress.Parse("99.168.57.102"),
System.Net.IPAddress.Parse("107.3.99.49"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("248.228.126.130"),
System.Net.IPAddress.Parse("117.71.8.197"),
System.Net.IPAddress.Parse("128.13.137.19"),
System.Net.IPAddress.Parse("236.238.51.15"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 168,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("176.61.37.25"),
System.Net.IPAddress.Parse("15.15.189.239"),
System.Net.IPAddress.Parse("180.75.127.69"),
System.Net.IPAddress.Parse("120.62.187.131"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 168,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("219.45.113.40"),
System.Net.IPAddress.Parse("132.4.180.34"),
System.Net.IPAddress.Parse("39.110.45.112"),
System.Net.IPAddress.Parse("146.22.187.1"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("244.184.74.164"),
System.Net.IPAddress.Parse("67.13.146.100"),
System.Net.IPAddress.Parse("206.237.131.146"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("212.128.239.202"),
System.Net.IPAddress.Parse("36.64.193.178"),
System.Net.IPAddress.Parse("146.76.149.166"),
},
},
            new IPAddressMArrayD1E1M
{
    Id = 171,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("41.135.137.98"),
System.Net.IPAddress.Parse("32.223.193.76"),
System.Net.IPAddress.Parse("39.207.26.234"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 172,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("142.65.222.140"),
System.Net.IPAddress.Parse("10.52.113.229"),
System.Net.IPAddress.Parse("11.22.29.234"),
System.Net.IPAddress.Parse("233.190.205.201"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("13.35.34.181"),
System.Net.IPAddress.Parse("46.77.166.237"),
System.Net.IPAddress.Parse("197.39.33.204"),
},
},
    NullableValue = null,
},
            new IPAddressMArrayD1E1M
{
    Id = 179,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("96.170.81.6"),
System.Net.IPAddress.Parse("169.82.88.164"),
System.Net.IPAddress.Parse("12.3.193.244"),
System.Net.IPAddress.Parse("145.221.20.93"),
},
    ModelInner = new IPAddressMArrayD1E1MI
{
    Id = 181,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("115.28.53.83"),
System.Net.IPAddress.Parse("153.47.143.12"),
System.Net.IPAddress.Parse("45.239.92.103"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("149.138.147.154"),
System.Net.IPAddress.Parse("25.205.238.70"),
System.Net.IPAddress.Parse("142.9.241.233"),
System.Net.IPAddress.Parse("120.109.163.26"),
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

