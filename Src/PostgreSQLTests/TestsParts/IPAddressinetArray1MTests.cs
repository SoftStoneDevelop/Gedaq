

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
    internal partial interface IIPAddressArrayinetArray
    {
    }
    
    internal partial class IPAddressArrayinetArray : IIPAddressArrayinetArray
    {


#region TestData

        private readonly IPAddressinetArray1M[] _testData = new IPAddressinetArray1M[]
        {
            new IPAddressinetArray1M
{
    Id = 7,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("74.32.206.2"),
System.Net.IPAddress.Parse("110.93.43.95"),
System.Net.IPAddress.Parse("66.100.32.40"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 11,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("56.39.101.72"),
System.Net.IPAddress.Parse("99.35.213.208"),
System.Net.IPAddress.Parse("199.206.221.31"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 8,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("101.127.149.117"),
System.Net.IPAddress.Parse("82.51.206.11"),
System.Net.IPAddress.Parse("25.44.2.159"),
System.Net.IPAddress.Parse("48.221.144.217"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("56.115.65.233"),
System.Net.IPAddress.Parse("183.85.157.160"),
System.Net.IPAddress.Parse("15.183.34.42"),
System.Net.IPAddress.Parse("126.27.214.203"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("136.118.152.88"),
System.Net.IPAddress.Parse("140.74.233.138"),
System.Net.IPAddress.Parse("102.44.146.36"),
System.Net.IPAddress.Parse("169.158.24.158"),
},
},
            new IPAddressinetArray1M
{
    Id = 15,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("127.233.28.40"),
System.Net.IPAddress.Parse("139.223.115.250"),
System.Net.IPAddress.Parse("78.4.21.244"),
System.Net.IPAddress.Parse("57.61.36.178"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 24,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("141.35.227.87"),
System.Net.IPAddress.Parse("89.206.227.66"),
System.Net.IPAddress.Parse("248.127.85.203"),
System.Net.IPAddress.Parse("101.61.91.104"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 13,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("30.178.246.155"),
System.Net.IPAddress.Parse("75.151.182.171"),
System.Net.IPAddress.Parse("71.28.238.92"),
System.Net.IPAddress.Parse("92.59.18.122"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("245.148.149.108"),
System.Net.IPAddress.Parse("250.143.95.104"),
System.Net.IPAddress.Parse("103.208.56.114"),
},
},
            new IPAddressinetArray1M
{
    Id = 26,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("109.228.24.221"),
System.Net.IPAddress.Parse("30.235.229.141"),
System.Net.IPAddress.Parse("94.247.38.210"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("215.19.188.240"),
System.Net.IPAddress.Parse("95.34.87.87"),
System.Net.IPAddress.Parse("197.93.21.14"),
System.Net.IPAddress.Parse("217.132.26.57"),
},
},
            new IPAddressinetArray1M
{
    Id = 27,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("225.91.22.8"),
System.Net.IPAddress.Parse("33.207.237.176"),
System.Net.IPAddress.Parse("79.199.87.164"),
System.Net.IPAddress.Parse("154.179.184.159"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 22,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("57.106.111.177"),
System.Net.IPAddress.Parse("213.251.253.188"),
System.Net.IPAddress.Parse("173.101.67.182"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("184.166.243.234"),
System.Net.IPAddress.Parse("86.206.164.207"),
System.Net.IPAddress.Parse("71.60.96.16"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 35,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.114.41.114"),
System.Net.IPAddress.Parse("96.22.117.218"),
System.Net.IPAddress.Parse("66.55.131.64"),
System.Net.IPAddress.Parse("193.160.232.152"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("88.176.182.214"),
System.Net.IPAddress.Parse("76.78.183.129"),
System.Net.IPAddress.Parse("105.211.126.126"),
},
},
            new IPAddressinetArray1M
{
    Id = 43,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("216.221.187.15"),
System.Net.IPAddress.Parse("130.1.112.70"),
System.Net.IPAddress.Parse("121.207.212.221"),
System.Net.IPAddress.Parse("191.55.69.10"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 30,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("90.67.174.82"),
System.Net.IPAddress.Parse("154.161.77.108"),
System.Net.IPAddress.Parse("40.177.211.185"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("136.230.4.171"),
System.Net.IPAddress.Parse("69.84.221.7"),
System.Net.IPAddress.Parse("6.213.72.1"),
System.Net.IPAddress.Parse("201.253.155.26"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 44,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("133.82.169.180"),
System.Net.IPAddress.Parse("51.213.143.162"),
System.Net.IPAddress.Parse("234.111.214.115"),
System.Net.IPAddress.Parse("82.14.207.248"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("169.178.209.184"),
System.Net.IPAddress.Parse("138.251.163.34"),
System.Net.IPAddress.Parse("196.56.154.11"),
},
},
            new IPAddressinetArray1M
{
    Id = 49,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("186.150.153.217"),
System.Net.IPAddress.Parse("184.252.160.174"),
System.Net.IPAddress.Parse("15.249.97.79"),
System.Net.IPAddress.Parse("138.216.87.15"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 38,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("109.132.211.119"),
System.Net.IPAddress.Parse("137.38.236.6"),
System.Net.IPAddress.Parse("240.52.129.201"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 56,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("215.119.132.114"),
System.Net.IPAddress.Parse("222.235.105.216"),
System.Net.IPAddress.Parse("129.197.94.88"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 64,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("159.89.92.97"),
System.Net.IPAddress.Parse("52.29.214.131"),
System.Net.IPAddress.Parse("223.142.61.21"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 41,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("103.72.232.80"),
System.Net.IPAddress.Parse("121.51.89.148"),
System.Net.IPAddress.Parse("22.209.12.218"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("31.147.104.182"),
System.Net.IPAddress.Parse("62.96.30.243"),
System.Net.IPAddress.Parse("65.247.74.52"),
System.Net.IPAddress.Parse("78.71.0.83"),
},
},
            new IPAddressinetArray1M
{
    Id = 65,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("69.126.166.85"),
System.Net.IPAddress.Parse("132.78.2.29"),
System.Net.IPAddress.Parse("201.137.193.7"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 69,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("225.42.74.216"),
System.Net.IPAddress.Parse("77.95.40.200"),
System.Net.IPAddress.Parse("12.38.141.16"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 47,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("74.19.252.122"),
System.Net.IPAddress.Parse("2.163.239.229"),
System.Net.IPAddress.Parse("53.165.250.135"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("53.69.20.200"),
System.Net.IPAddress.Parse("96.43.249.47"),
System.Net.IPAddress.Parse("13.182.156.30"),
System.Net.IPAddress.Parse("143.139.246.99"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("186.251.222.144"),
System.Net.IPAddress.Parse("19.213.220.251"),
System.Net.IPAddress.Parse("34.203.47.111"),
System.Net.IPAddress.Parse("248.192.74.181"),
},
},
            new IPAddressinetArray1M
{
    Id = 78,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("145.16.227.138"),
System.Net.IPAddress.Parse("59.239.9.180"),
System.Net.IPAddress.Parse("151.98.0.165"),
System.Net.IPAddress.Parse("195.221.53.175"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 83,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.57.230.44"),
System.Net.IPAddress.Parse("54.24.54.149"),
System.Net.IPAddress.Parse("114.218.171.150"),
System.Net.IPAddress.Parse("219.155.17.38"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 55,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("30.147.60.235"),
System.Net.IPAddress.Parse("219.185.135.102"),
System.Net.IPAddress.Parse("193.228.102.160"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 85,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("235.212.76.101"),
System.Net.IPAddress.Parse("151.248.0.220"),
System.Net.IPAddress.Parse("114.102.174.91"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 92,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("31.195.30.126"),
System.Net.IPAddress.Parse("46.239.48.135"),
System.Net.IPAddress.Parse("143.187.175.82"),
System.Net.IPAddress.Parse("74.247.85.64"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 59,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("225.89.65.12"),
System.Net.IPAddress.Parse("218.199.81.185"),
System.Net.IPAddress.Parse("201.101.59.128"),
System.Net.IPAddress.Parse("193.52.174.75"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("50.109.41.28"),
System.Net.IPAddress.Parse("187.12.49.140"),
System.Net.IPAddress.Parse("120.124.127.137"),
System.Net.IPAddress.Parse("41.11.41.139"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 95,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("90.22.242.222"),
System.Net.IPAddress.Parse("62.43.200.139"),
System.Net.IPAddress.Parse("181.137.12.162"),
System.Net.IPAddress.Parse("58.241.209.244"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 102,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("185.29.25.37"),
System.Net.IPAddress.Parse("164.188.19.178"),
System.Net.IPAddress.Parse("150.89.144.143"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 68,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("103.10.71.61"),
System.Net.IPAddress.Parse("138.120.152.110"),
System.Net.IPAddress.Parse("33.181.207.122"),
System.Net.IPAddress.Parse("4.103.235.217"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 110,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.130.149.162"),
System.Net.IPAddress.Parse("31.212.237.80"),
System.Net.IPAddress.Parse("37.111.221.164"),
System.Net.IPAddress.Parse("188.199.111.185"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 114,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("15.237.161.94"),
System.Net.IPAddress.Parse("123.36.136.122"),
System.Net.IPAddress.Parse("14.193.224.45"),
System.Net.IPAddress.Parse("31.208.166.147"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 70,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("132.210.54.182"),
System.Net.IPAddress.Parse("41.2.208.227"),
System.Net.IPAddress.Parse("148.246.164.165"),
System.Net.IPAddress.Parse("191.133.85.237"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("30.1.57.217"),
System.Net.IPAddress.Parse("25.84.180.106"),
System.Net.IPAddress.Parse("102.212.163.196"),
System.Net.IPAddress.Parse("161.46.189.144"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 123,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("145.11.39.116"),
System.Net.IPAddress.Parse("165.148.44.25"),
System.Net.IPAddress.Parse("178.196.244.201"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 128,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("105.117.105.178"),
System.Net.IPAddress.Parse("25.33.159.168"),
System.Net.IPAddress.Parse("17.139.165.87"),
System.Net.IPAddress.Parse("192.124.192.15"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 71,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("122.79.213.28"),
System.Net.IPAddress.Parse("21.118.217.59"),
System.Net.IPAddress.Parse("238.57.145.148"),
System.Net.IPAddress.Parse("175.238.34.51"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("237.78.165.225"),
System.Net.IPAddress.Parse("62.193.231.247"),
System.Net.IPAddress.Parse("157.208.41.74"),
System.Net.IPAddress.Parse("242.222.151.61"),
},
},
            new IPAddressinetArray1M
{
    Id = 136,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("90.5.192.224"),
System.Net.IPAddress.Parse("48.45.63.118"),
System.Net.IPAddress.Parse("203.132.78.77"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("203.62.119.51"),
System.Net.IPAddress.Parse("146.223.107.187"),
System.Net.IPAddress.Parse("149.132.142.6"),
},
},
            new IPAddressinetArray1M
{
    Id = 138,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("202.182.26.142"),
System.Net.IPAddress.Parse("20.159.19.195"),
System.Net.IPAddress.Parse("206.62.182.244"),
System.Net.IPAddress.Parse("147.186.188.98"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 78,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("119.22.140.67"),
System.Net.IPAddress.Parse("130.8.45.25"),
System.Net.IPAddress.Parse("194.128.236.167"),
System.Net.IPAddress.Parse("25.78.6.62"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("221.132.114.230"),
System.Net.IPAddress.Parse("109.51.34.53"),
System.Net.IPAddress.Parse("181.160.70.177"),
System.Net.IPAddress.Parse("220.26.7.249"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("57.75.167.245"),
System.Net.IPAddress.Parse("159.60.176.221"),
System.Net.IPAddress.Parse("86.111.155.208"),
System.Net.IPAddress.Parse("138.248.44.248"),
},
},
            new IPAddressinetArray1M
{
    Id = 141,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.93.158.17"),
System.Net.IPAddress.Parse("230.222.165.35"),
System.Net.IPAddress.Parse("6.78.11.104"),
System.Net.IPAddress.Parse("75.201.182.38"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 146,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("221.167.14.130"),
System.Net.IPAddress.Parse("25.2.200.20"),
System.Net.IPAddress.Parse("207.250.153.174"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 80,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("208.28.20.188"),
System.Net.IPAddress.Parse("57.220.157.69"),
System.Net.IPAddress.Parse("69.31.166.227"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("128.227.95.31"),
System.Net.IPAddress.Parse("219.200.109.220"),
System.Net.IPAddress.Parse("10.145.22.152"),
System.Net.IPAddress.Parse("75.124.84.48"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("149.95.57.5"),
System.Net.IPAddress.Parse("48.170.13.0"),
System.Net.IPAddress.Parse("231.62.97.178"),
},
},
            new IPAddressinetArray1M
{
    Id = 147,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.203.239.209"),
System.Net.IPAddress.Parse("140.35.212.131"),
System.Net.IPAddress.Parse("191.216.216.26"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 155,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("178.5.92.13"),
System.Net.IPAddress.Parse("239.82.129.208"),
System.Net.IPAddress.Parse("228.169.54.92"),
System.Net.IPAddress.Parse("118.106.11.186"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 87,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("192.85.53.58"),
System.Net.IPAddress.Parse("130.126.125.52"),
System.Net.IPAddress.Parse("120.179.122.136"),
System.Net.IPAddress.Parse("244.207.28.222"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("172.142.15.219"),
System.Net.IPAddress.Parse("243.50.82.104"),
System.Net.IPAddress.Parse("199.156.172.231"),
System.Net.IPAddress.Parse("186.194.89.180"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("128.80.34.247"),
System.Net.IPAddress.Parse("96.172.149.247"),
System.Net.IPAddress.Parse("96.74.42.209"),
},
},
            new IPAddressinetArray1M
{
    Id = 157,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("89.246.181.128"),
System.Net.IPAddress.Parse("96.111.40.106"),
System.Net.IPAddress.Parse("180.159.95.138"),
System.Net.IPAddress.Parse("112.149.119.187"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("196.234.135.97"),
System.Net.IPAddress.Parse("248.151.254.33"),
System.Net.IPAddress.Parse("21.161.59.199"),
},
},
            new IPAddressinetArray1M
{
    Id = 159,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.168.200.186"),
System.Net.IPAddress.Parse("101.151.66.235"),
System.Net.IPAddress.Parse("161.167.219.75"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 90,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("21.232.24.47"),
System.Net.IPAddress.Parse("192.146.86.37"),
System.Net.IPAddress.Parse("174.0.5.49"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("106.98.117.204"),
System.Net.IPAddress.Parse("247.170.95.92"),
System.Net.IPAddress.Parse("190.14.173.177"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("222.211.170.249"),
System.Net.IPAddress.Parse("141.218.235.42"),
System.Net.IPAddress.Parse("198.236.127.60"),
},
},
            new IPAddressinetArray1M
{
    Id = 160,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("97.52.186.228"),
System.Net.IPAddress.Parse("82.36.165.107"),
System.Net.IPAddress.Parse("76.3.69.240"),
System.Net.IPAddress.Parse("169.111.174.151"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.179.134.205"),
System.Net.IPAddress.Parse("207.173.30.68"),
System.Net.IPAddress.Parse("145.193.96.106"),
},
},
            new IPAddressinetArray1M
{
    Id = 165,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("179.214.18.137"),
System.Net.IPAddress.Parse("6.115.147.129"),
System.Net.IPAddress.Parse("242.231.58.60"),
System.Net.IPAddress.Parse("93.231.234.253"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 96,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("153.180.97.210"),
System.Net.IPAddress.Parse("251.224.144.161"),
System.Net.IPAddress.Parse("108.213.200.248"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("166.175.168.251"),
System.Net.IPAddress.Parse("73.23.33.208"),
System.Net.IPAddress.Parse("209.22.60.159"),
System.Net.IPAddress.Parse("40.128.152.8"),
},
},
            new IPAddressinetArray1M
{
    Id = 169,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("101.132.1.205"),
System.Net.IPAddress.Parse("252.62.204.49"),
System.Net.IPAddress.Parse("5.8.198.194"),
System.Net.IPAddress.Parse("226.109.90.195"),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray1mi(
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray1mi(
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
            queryMapTypes: [typeof(IPAddressinetArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]), 
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

                changedRows =  ((IIPAddressArrayinetArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IIPAddressArrayinetArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IIPAddressArrayinetArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressArrayinetArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IIPAddressArrayinetArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IIPAddressArrayinetArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray1m(
	id,
    value,
    nullablevalue,
    ipaddressinetarray1mi_id
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
            asPartInterface: typeof(IIPAddressArrayinetArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "ipaddressinetarray1mi_id", 
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
                changedRows =  ((IIPAddressArrayinetArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IIPAddressArrayinetArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IIPAddressArrayinetArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IIPAddressArrayinetArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray1m(
	id,
    value,
    nullablevalue,
    ipaddressinetarray1mi_id
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
    ipaddressinetarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                System.Net.IPAddress[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[]>();
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((IIPAddressArrayinetArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("215.19.188.240"),
System.Net.IPAddress.Parse("95.34.87.87"),
System.Net.IPAddress.Parse("197.93.21.14"),
System.Net.IPAddress.Parse("217.132.26.57"),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[]>();
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((IIPAddressArrayinetArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Net.IPAddress[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[]>();
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((IIPAddressArrayinetArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("88.176.182.214"),
System.Net.IPAddress.Parse("76.78.183.129"),
System.Net.IPAddress.Parse("105.211.126.126"),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress[]>();
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483624);
                    ((NpgsqlParameter<System.Net.IPAddress[]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((IIPAddressArrayinetArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray1m(
	id,
    value,
    nullablevalue,
    ipaddressinetarray1mi_id
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
    ipaddressinetarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "ipaddressinetarray1mi_id", 
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
                System.Net.IPAddress[] nullable = null;
                nullable =  ((IIPAddressArrayinetArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("169.178.209.184"),
System.Net.IPAddress.Parse("138.251.163.34"),
System.Net.IPAddress.Parse("196.56.154.11"),
}));
                nullable =  ((IIPAddressArrayinetArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Net.IPAddress[] nullable = null;
                nullable = await ((IIPAddressArrayinetArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IIPAddressArrayinetArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("31.147.104.182"),
System.Net.IPAddress.Parse("62.96.30.243"),
System.Net.IPAddress.Parse("65.247.74.52"),
System.Net.IPAddress.Parse("78.71.0.83"),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetArray1M> models = null;

                models =  ((IIPAddressArrayinetArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IIPAddressArrayinetArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IIPAddressArrayinetArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IIPAddressArrayinetArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetArray1M> models = null;

                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M), typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                ((IIPAddressArrayinetArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IIPAddressArrayinetArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IIPAddressArrayinetArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                var models = await ((IIPAddressArrayinetArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IIPAddressArrayinetArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M), typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                ((IIPAddressArrayinetArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IIPAddressArrayinetArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressArrayinetArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                var models = await ((IIPAddressArrayinetArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IIPAddressArrayinetArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M), typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                await((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                 ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                 ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[24],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[25],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[26],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[27],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                 ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.ipaddressinetarray1m m
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                var models = await((IIPAddressArrayinetArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[34], false);
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
                var models = ((IIPAddressArrayinetArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[5], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[6], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[7], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[8], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[9], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[10], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[24],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[25],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[26],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[27],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[28],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M), typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                await((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 44, query1, 159, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 64, query1, 136, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetArray1M>();
                var models2 = new List<FlatIPAddressinetArray1M>();
                ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                 ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 64, query1, 123, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var firstItems2 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                 ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 35, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 114, query1, 102, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[34], false);
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 141, query1, 157, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 155, query1, 159, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[34], false);
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
FROM public.ipaddressinetarray1m m
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
FROM public.ipaddressinetarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems1 = new List<FlatIPAddressinetArray1M>();
                var secondItems2 = new List<FlatIPAddressinetArray1M>();
                 ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 128, query1, 147, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.ipaddressinetarray1m m
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                var models = await((IIPAddressArrayinetArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 27, 27))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[6], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[7], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[8], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[9], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[10], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[24],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[25],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[26],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[27],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[6], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[7], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[8], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[9], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[10], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[24],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[25],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[26],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[27],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[28],_testData[34], false);
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
                var models = ((IIPAddressArrayinetArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatch(connection, 146, 114))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[34], false);
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
                await using var cmd = await ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 56);
                var models = await ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
IPAddressinetArray1M.AssertModel(models[0],_testData[11], false);IPAddressinetArray1M.AssertModel(models[1],_testData[12], false);IPAddressinetArray1M.AssertModel(models[2],_testData[13], false);IPAddressinetArray1M.AssertModel(models[3],_testData[14], false);IPAddressinetArray1M.AssertModel(models[4],_testData[15], false);IPAddressinetArray1M.AssertModel(models[5],_testData[16], false);IPAddressinetArray1M.AssertModel(models[6],_testData[17], false);IPAddressinetArray1M.AssertModel(models[7],_testData[18], false);IPAddressinetArray1M.AssertModel(models[8],_testData[19], false);IPAddressinetArray1M.AssertModel(models[9],_testData[20], false);IPAddressinetArray1M.AssertModel(models[10],_testData[21], false);IPAddressinetArray1M.AssertModel(models[11],_testData[22], false);IPAddressinetArray1M.AssertModel(models[12],_testData[23], false);IPAddressinetArray1M.AssertModel(models[13],_testData[24], false);IPAddressinetArray1M.AssertModel(models[14],_testData[25], false);IPAddressinetArray1M.AssertModel(models[15],_testData[26], false);IPAddressinetArray1M.AssertModel(models[16],_testData[27], false);IPAddressinetArray1M.AssertModel(models[17],_testData[28], false);IPAddressinetArray1M.AssertModel(models[18],_testData[29], false);IPAddressinetArray1M.AssertModel(models[19],_testData[30], false);IPAddressinetArray1M.AssertModel(models[20],_testData[31], false);IPAddressinetArray1M.AssertModel(models[21],_testData[32], false);IPAddressinetArray1M.AssertModel(models[22],_testData[33], false);IPAddressinetArray1M.AssertModel(models[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 69);
                var models =  ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
IPAddressinetArray1M.AssertModel(models[0],_testData[14], false);IPAddressinetArray1M.AssertModel(models[1],_testData[15], false);IPAddressinetArray1M.AssertModel(models[2],_testData[16], false);IPAddressinetArray1M.AssertModel(models[3],_testData[17], false);IPAddressinetArray1M.AssertModel(models[4],_testData[18], false);IPAddressinetArray1M.AssertModel(models[5],_testData[19], false);IPAddressinetArray1M.AssertModel(models[6],_testData[20], false);IPAddressinetArray1M.AssertModel(models[7],_testData[21], false);IPAddressinetArray1M.AssertModel(models[8],_testData[22], false);IPAddressinetArray1M.AssertModel(models[9],_testData[23], false);IPAddressinetArray1M.AssertModel(models[10],_testData[24], false);IPAddressinetArray1M.AssertModel(models[11],_testData[25], false);IPAddressinetArray1M.AssertModel(models[12],_testData[26], false);IPAddressinetArray1M.AssertModel(models[13],_testData[27], false);IPAddressinetArray1M.AssertModel(models[14],_testData[28], false);IPAddressinetArray1M.AssertModel(models[15],_testData[29], false);IPAddressinetArray1M.AssertModel(models[16],_testData[30], false);IPAddressinetArray1M.AssertModel(models[17],_testData[31], false);IPAddressinetArray1M.AssertModel(models[18],_testData[32], false);IPAddressinetArray1M.AssertModel(models[19],_testData[33], false);IPAddressinetArray1M.AssertModel(models[20],_testData[34], false);
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
FROM public.binary_ipaddressinetarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(IPAddressinetArray1MIWA),
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
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressArrayinetArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinetarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IIPAddressArrayinetArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressArrayinetArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinetarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressArrayinetArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(IPAddressinetArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressArrayinetArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinetarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IIPAddressArrayinetArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressArrayinetArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinetarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressArrayinetArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(IPAddressinetArray1MI),
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
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IIPAddressArrayinetArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IIPAddressArrayinetArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IIPAddressArrayinetArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IIPAddressArrayinetArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(IPAddressinetArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressArrayinetArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IIPAddressArrayinetArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressArrayinetArray)this).ImportModelInner(connection, importCollection);
                var models = ((IIPAddressArrayinetArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
ipaddressinetarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(IPAddressinetArray1M),
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
            asPartInterface: typeof(IIPAddressArrayinetArray))]
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
FROM public.binary_ipaddressinetarray1m m
LEFT JOIN public.binary_ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IIPAddressArrayinetArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IIPAddressArrayinetArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    IPAddressinetArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IIPAddressArrayinetArray)this).ImportModel(connection, importCollection);
                var models = ((IIPAddressArrayinetArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    IPAddressinetArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    ipaddressinetarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(IPAddressinetArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                var models =  ((IIPAddressArrayinetArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    IPAddressinetArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressArrayinetArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    IPAddressinetArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MIWA), typeof(IPAddressinetArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                var models1 = new List<IPAddressinetArray1MIWA>();
                var models2 = new List<IPAddressinetArray1MIWA>();
                await ((IIPAddressArrayinetArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetArray1MIWA>();
                var models2 = new List<IPAddressinetArray1MIWA>();
                ((IIPAddressArrayinetArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                var models = await ((IIPAddressArrayinetArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_ipaddressinetarray1mi
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
                    IPAddressinetArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressArrayinetArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_ipaddressinetarray1mi
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
                    IPAddressinetArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MIWA), typeof(IPAddressinetArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
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
                var models1 = new List<IPAddressinetArray1MIWA>();
                var models2 = new List<IPAddressinetArray1MIWA>();
                await ((IIPAddressArrayinetArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetArray1MIWA>();
                var models2 = new List<IPAddressinetArray1MIWA>();
                ((IIPAddressArrayinetArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
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
                var models = await ((IIPAddressArrayinetArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_ipaddressinetarray1mi
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
                    IPAddressinetArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressArrayinetArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_ipaddressinetarray1mi
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
                    IPAddressinetArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_ipaddressinetarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MI), typeof(IPAddressinetArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                var models1 = new List<IPAddressinetArray1MI>();
                var models2 = new List<IPAddressinetArray1MI>();
                await ((IIPAddressArrayinetArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetArray1MI>();
                var models2 = new List<IPAddressinetArray1MI>();
                ((IIPAddressArrayinetArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)),
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
                var models = await ((IIPAddressArrayinetArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressArrayinetArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_ipaddressinetarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MIWA), typeof(IPAddressinetArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
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
                var models1 = new List<IPAddressinetArray1MIWA>();
                var models2 = new List<IPAddressinetArray1MIWA>();
                await ((IIPAddressArrayinetArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetArray1MIWA>();
                var models2 = new List<IPAddressinetArray1MIWA>();
                ((IIPAddressArrayinetArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(IPAddressinetArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray))]
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
                var models = await ((IIPAddressArrayinetArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressArrayinetArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

