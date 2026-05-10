

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
    internal partial interface IIPAddressArrayIPv4Array
    {
    }
    
    internal partial class IPAddressArrayIPv4Array : IIPAddressArrayIPv4Array
    {


#region TestData

        private readonly IPAddressIPv4Array1M[] _testData = new IPAddressIPv4Array1M[]
        {
            new IPAddressIPv4Array1M
{
    Id = 6,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("21.94.69.138"),
System.Net.IPAddress.Parse("218.76.94.66"),
System.Net.IPAddress.Parse("248.110.123.47"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 4,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("132.218.145.20"),
System.Net.IPAddress.Parse("60.76.171.118"),
System.Net.IPAddress.Parse("225.251.37.152"),
System.Net.IPAddress.Parse("19.238.59.27"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4Array1M
{
    Id = 11,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("224.152.223.115"),
System.Net.IPAddress.Parse("64.229.88.235"),
System.Net.IPAddress.Parse("165.31.234.24"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 10,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("95.11.44.238"),
System.Net.IPAddress.Parse("97.142.154.196"),
System.Net.IPAddress.Parse("81.120.190.185"),
System.Net.IPAddress.Parse("186.145.196.39"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("244.51.250.170"),
System.Net.IPAddress.Parse("166.167.44.56"),
System.Net.IPAddress.Parse("36.173.180.251"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("95.246.65.137"),
System.Net.IPAddress.Parse("179.14.11.169"),
System.Net.IPAddress.Parse("211.203.58.180"),
System.Net.IPAddress.Parse("2.93.9.53"),
},
},
            new IPAddressIPv4Array1M
{
    Id = 14,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("62.186.39.244"),
System.Net.IPAddress.Parse("105.15.200.77"),
System.Net.IPAddress.Parse("160.118.247.212"),
System.Net.IPAddress.Parse("132.62.219.133"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 16,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("175.17.155.101"),
System.Net.IPAddress.Parse("224.241.215.34"),
System.Net.IPAddress.Parse("239.195.209.247"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4Array1M
{
    Id = 22,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("224.154.134.183"),
System.Net.IPAddress.Parse("111.76.136.35"),
System.Net.IPAddress.Parse("66.142.100.205"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 21,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("206.237.181.109"),
System.Net.IPAddress.Parse("75.33.192.189"),
System.Net.IPAddress.Parse("49.113.137.73"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4Array1M
{
    Id = 26,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("152.123.163.106"),
System.Net.IPAddress.Parse("200.10.173.250"),
System.Net.IPAddress.Parse("18.113.125.166"),
System.Net.IPAddress.Parse("165.219.224.100"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 27,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.24.11.222"),
System.Net.IPAddress.Parse("88.229.184.54"),
System.Net.IPAddress.Parse("243.228.150.124"),
System.Net.IPAddress.Parse("1.176.208.177"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4Array1M
{
    Id = 31,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("181.72.38.195"),
System.Net.IPAddress.Parse("215.81.66.66"),
System.Net.IPAddress.Parse("121.55.234.107"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 36,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("114.83.214.19"),
System.Net.IPAddress.Parse("121.235.225.177"),
System.Net.IPAddress.Parse("116.142.79.24"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("142.176.193.100"),
System.Net.IPAddress.Parse("236.165.194.239"),
System.Net.IPAddress.Parse("75.113.217.33"),
System.Net.IPAddress.Parse("243.234.190.184"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("202.109.71.26"),
System.Net.IPAddress.Parse("18.84.1.31"),
System.Net.IPAddress.Parse("202.134.47.179"),
},
},
            new IPAddressIPv4Array1M
{
    Id = 37,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("41.44.20.110"),
System.Net.IPAddress.Parse("217.16.199.118"),
System.Net.IPAddress.Parse("135.21.41.29"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 38,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("46.231.146.226"),
System.Net.IPAddress.Parse("184.254.130.234"),
System.Net.IPAddress.Parse("209.144.68.244"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4Array1M
{
    Id = 46,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("57.190.220.13"),
System.Net.IPAddress.Parse("252.40.59.103"),
System.Net.IPAddress.Parse("232.107.170.197"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 40,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("66.195.127.203"),
System.Net.IPAddress.Parse("167.162.127.11"),
System.Net.IPAddress.Parse("190.178.116.242"),
System.Net.IPAddress.Parse("234.165.73.54"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("74.199.63.190"),
System.Net.IPAddress.Parse("179.211.63.23"),
System.Net.IPAddress.Parse("199.223.155.219"),
},
},
    NullableValue = null,
},
            new IPAddressIPv4Array1M
{
    Id = 49,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("76.103.40.158"),
System.Net.IPAddress.Parse("44.52.1.151"),
System.Net.IPAddress.Parse("246.134.135.37"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 43,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("225.47.60.132"),
System.Net.IPAddress.Parse("84.39.216.11"),
System.Net.IPAddress.Parse("117.3.155.63"),
System.Net.IPAddress.Parse("99.66.206.93"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("136.87.105.7"),
System.Net.IPAddress.Parse("139.159.231.56"),
System.Net.IPAddress.Parse("13.116.179.14"),
},
},
            new IPAddressIPv4Array1M
{
    Id = 57,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("119.75.251.131"),
System.Net.IPAddress.Parse("36.160.23.28"),
System.Net.IPAddress.Parse("206.151.219.68"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 48,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("132.27.132.74"),
System.Net.IPAddress.Parse("78.239.137.222"),
System.Net.IPAddress.Parse("9.136.94.159"),
System.Net.IPAddress.Parse("185.180.13.146"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("60.206.192.177"),
System.Net.IPAddress.Parse("92.143.242.46"),
System.Net.IPAddress.Parse("239.178.6.103"),
},
},
    NullableValue = null,
},
            new IPAddressIPv4Array1M
{
    Id = 58,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("106.193.68.191"),
System.Net.IPAddress.Parse("81.116.139.193"),
System.Net.IPAddress.Parse("38.175.182.9"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 55,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("157.112.34.65"),
System.Net.IPAddress.Parse("33.63.36.154"),
System.Net.IPAddress.Parse("72.106.119.237"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4Array1M
{
    Id = 67,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("187.18.199.146"),
System.Net.IPAddress.Parse("174.20.248.39"),
System.Net.IPAddress.Parse("197.250.19.169"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 56,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("229.85.187.231"),
System.Net.IPAddress.Parse("149.228.21.53"),
System.Net.IPAddress.Parse("222.217.178.250"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.172.202.102"),
System.Net.IPAddress.Parse("141.204.100.26"),
System.Net.IPAddress.Parse("18.239.244.54"),
},
},
    NullableValue = null,
},
            new IPAddressIPv4Array1M
{
    Id = 69,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("58.132.248.230"),
System.Net.IPAddress.Parse("50.185.197.49"),
System.Net.IPAddress.Parse("25.254.125.73"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 61,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("62.247.80.106"),
System.Net.IPAddress.Parse("166.116.90.132"),
System.Net.IPAddress.Parse("189.87.64.59"),
System.Net.IPAddress.Parse("211.35.63.51"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("175.76.126.235"),
System.Net.IPAddress.Parse("96.84.152.209"),
System.Net.IPAddress.Parse("82.159.136.150"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("21.128.222.23"),
System.Net.IPAddress.Parse("6.48.137.228"),
System.Net.IPAddress.Parse("52.179.172.216"),
},
},
            new IPAddressIPv4Array1M
{
    Id = 71,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("253.101.87.208"),
System.Net.IPAddress.Parse("39.165.60.44"),
System.Net.IPAddress.Parse("183.26.34.108"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 69,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("86.22.35.68"),
System.Net.IPAddress.Parse("111.189.6.232"),
System.Net.IPAddress.Parse("37.154.196.105"),
System.Net.IPAddress.Parse("53.13.74.77"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("118.19.41.103"),
System.Net.IPAddress.Parse("13.23.93.107"),
System.Net.IPAddress.Parse("235.126.82.124"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("202.9.124.101"),
System.Net.IPAddress.Parse("115.152.13.38"),
System.Net.IPAddress.Parse("206.94.103.201"),
System.Net.IPAddress.Parse("21.52.201.17"),
},
},
            new IPAddressIPv4Array1M
{
    Id = 72,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("120.88.50.137"),
System.Net.IPAddress.Parse("107.222.53.250"),
System.Net.IPAddress.Parse("114.203.64.86"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 71,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("129.165.114.75"),
System.Net.IPAddress.Parse("251.242.99.3"),
System.Net.IPAddress.Parse("69.56.129.40"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4Array1M
{
    Id = 79,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("24.184.149.175"),
System.Net.IPAddress.Parse("104.75.200.115"),
System.Net.IPAddress.Parse("216.82.206.114"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 77,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("189.216.62.218"),
System.Net.IPAddress.Parse("118.179.168.169"),
System.Net.IPAddress.Parse("189.31.250.197"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("88.18.229.157"),
System.Net.IPAddress.Parse("37.47.26.196"),
System.Net.IPAddress.Parse("214.82.160.132"),
System.Net.IPAddress.Parse("8.53.82.171"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("243.106.126.116"),
System.Net.IPAddress.Parse("57.170.179.187"),
System.Net.IPAddress.Parse("7.64.209.241"),
System.Net.IPAddress.Parse("27.87.31.179"),
},
},
            new IPAddressIPv4Array1M
{
    Id = 81,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("21.17.32.67"),
System.Net.IPAddress.Parse("178.187.213.76"),
System.Net.IPAddress.Parse("70.170.137.187"),
System.Net.IPAddress.Parse("119.253.1.183"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 86,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("120.7.110.185"),
System.Net.IPAddress.Parse("233.232.219.211"),
System.Net.IPAddress.Parse("243.18.84.143"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("100.20.109.70"),
System.Net.IPAddress.Parse("19.46.121.79"),
System.Net.IPAddress.Parse("143.46.19.150"),
},
},
            new IPAddressIPv4Array1M
{
    Id = 86,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("19.206.241.126"),
System.Net.IPAddress.Parse("17.125.159.243"),
System.Net.IPAddress.Parse("31.158.122.127"),
System.Net.IPAddress.Parse("152.28.200.25"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 87,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("68.5.188.152"),
System.Net.IPAddress.Parse("205.44.200.205"),
System.Net.IPAddress.Parse("207.247.142.161"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("176.225.122.242"),
System.Net.IPAddress.Parse("246.123.233.117"),
System.Net.IPAddress.Parse("176.113.94.166"),
System.Net.IPAddress.Parse("155.171.130.232"),
},
},
            new IPAddressIPv4Array1M
{
    Id = 91,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("159.110.233.153"),
System.Net.IPAddress.Parse("163.20.223.165"),
System.Net.IPAddress.Parse("61.165.200.24"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 96,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("56.240.174.184"),
System.Net.IPAddress.Parse("183.89.102.29"),
System.Net.IPAddress.Parse("74.178.61.4"),
System.Net.IPAddress.Parse("85.140.226.45"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4Array1M
{
    Id = 94,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("158.97.67.0"),
System.Net.IPAddress.Parse("254.121.135.122"),
System.Net.IPAddress.Parse("16.146.47.237"),
System.Net.IPAddress.Parse("137.130.206.79"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 105,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("199.48.211.71"),
System.Net.IPAddress.Parse("195.171.137.91"),
System.Net.IPAddress.Parse("203.75.148.29"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4Array1M
{
    Id = 100,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("249.1.16.139"),
System.Net.IPAddress.Parse("198.172.1.195"),
System.Net.IPAddress.Parse("23.167.60.107"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 107,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("4.150.18.198"),
System.Net.IPAddress.Parse("72.121.18.45"),
System.Net.IPAddress.Parse("222.208.3.247"),
System.Net.IPAddress.Parse("218.39.173.199"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("134.252.133.225"),
System.Net.IPAddress.Parse("190.54.15.114"),
System.Net.IPAddress.Parse("187.123.88.29"),
},
},
            new IPAddressIPv4Array1M
{
    Id = 105,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("201.157.157.58"),
System.Net.IPAddress.Parse("125.86.251.141"),
System.Net.IPAddress.Parse("158.193.36.201"),
System.Net.IPAddress.Parse("65.43.249.184"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 114,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("139.47.36.231"),
System.Net.IPAddress.Parse("223.182.54.85"),
System.Net.IPAddress.Parse("15.163.200.183"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("227.61.201.16"),
System.Net.IPAddress.Parse("210.9.5.94"),
System.Net.IPAddress.Parse("64.23.107.252"),
System.Net.IPAddress.Parse("83.114.52.153"),
},
},
    NullableValue = null,
},
            new IPAddressIPv4Array1M
{
    Id = 107,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("50.90.164.47"),
System.Net.IPAddress.Parse("57.123.77.247"),
System.Net.IPAddress.Parse("180.153.167.126"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 119,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("93.50.56.73"),
System.Net.IPAddress.Parse("203.95.38.148"),
System.Net.IPAddress.Parse("233.124.237.194"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4Array1M
{
    Id = 115,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("92.162.65.134"),
System.Net.IPAddress.Parse("22.234.182.58"),
System.Net.IPAddress.Parse("8.168.36.2"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 121,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("200.166.213.139"),
System.Net.IPAddress.Parse("187.58.176.154"),
System.Net.IPAddress.Parse("187.147.33.171"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("68.127.171.126"),
System.Net.IPAddress.Parse("33.32.195.112"),
System.Net.IPAddress.Parse("143.70.124.19"),
System.Net.IPAddress.Parse("201.235.38.153"),
},
},
            new IPAddressIPv4Array1M
{
    Id = 123,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("21.190.11.131"),
System.Net.IPAddress.Parse("72.209.202.171"),
System.Net.IPAddress.Parse("114.224.34.29"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 122,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("179.187.88.91"),
System.Net.IPAddress.Parse("56.64.113.195"),
System.Net.IPAddress.Parse("199.149.241.230"),
System.Net.IPAddress.Parse("221.217.3.83"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("123.48.43.175"),
System.Net.IPAddress.Parse("232.39.210.247"),
System.Net.IPAddress.Parse("192.70.184.114"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("116.198.89.81"),
System.Net.IPAddress.Parse("248.224.164.215"),
System.Net.IPAddress.Parse("129.205.19.35"),
System.Net.IPAddress.Parse("40.137.39.151"),
},
},
            new IPAddressIPv4Array1M
{
    Id = 127,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("9.101.173.197"),
System.Net.IPAddress.Parse("0.19.123.160"),
System.Net.IPAddress.Parse("74.98.174.215"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 127,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("89.115.12.68"),
System.Net.IPAddress.Parse("173.174.174.165"),
System.Net.IPAddress.Parse("8.159.18.237"),
System.Net.IPAddress.Parse("90.254.231.203"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("187.193.160.134"),
System.Net.IPAddress.Parse("24.245.107.77"),
System.Net.IPAddress.Parse("77.158.53.40"),
System.Net.IPAddress.Parse("245.166.223.209"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("161.178.12.47"),
System.Net.IPAddress.Parse("78.54.244.145"),
System.Net.IPAddress.Parse("253.253.21.67"),
},
},
            new IPAddressIPv4Array1M
{
    Id = 135,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("79.163.101.30"),
System.Net.IPAddress.Parse("231.70.110.200"),
System.Net.IPAddress.Parse("80.129.134.17"),
System.Net.IPAddress.Parse("252.1.92.192"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 134,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("60.49.188.23"),
System.Net.IPAddress.Parse("147.143.44.185"),
System.Net.IPAddress.Parse("141.40.187.2"),
System.Net.IPAddress.Parse("83.83.212.229"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("206.171.231.39"),
System.Net.IPAddress.Parse("96.253.182.87"),
System.Net.IPAddress.Parse("217.187.137.142"),
System.Net.IPAddress.Parse("6.15.190.63"),
},
},
            new IPAddressIPv4Array1M
{
    Id = 138,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("105.79.156.157"),
System.Net.IPAddress.Parse("248.205.71.46"),
System.Net.IPAddress.Parse("88.246.166.147"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 141,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("63.252.29.108"),
System.Net.IPAddress.Parse("7.153.209.154"),
System.Net.IPAddress.Parse("53.106.39.9"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("104.157.53.186"),
System.Net.IPAddress.Parse("166.0.155.20"),
System.Net.IPAddress.Parse("234.247.17.149"),
System.Net.IPAddress.Parse("116.77.179.111"),
},
},
            new IPAddressIPv4Array1M
{
    Id = 143,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("125.246.211.121"),
System.Net.IPAddress.Parse("18.110.155.55"),
System.Net.IPAddress.Parse("0.6.55.165"),
System.Net.IPAddress.Parse("168.75.242.117"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 147,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("54.47.64.2"),
System.Net.IPAddress.Parse("245.230.25.142"),
System.Net.IPAddress.Parse("149.118.213.209"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("126.176.63.85"),
System.Net.IPAddress.Parse("54.70.60.182"),
System.Net.IPAddress.Parse("48.143.209.69"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("12.142.57.156"),
System.Net.IPAddress.Parse("215.245.51.39"),
System.Net.IPAddress.Parse("5.54.22.71"),
System.Net.IPAddress.Parse("238.213.21.60"),
},
},
            new IPAddressIPv4Array1M
{
    Id = 144,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("198.4.77.172"),
System.Net.IPAddress.Parse("210.117.223.68"),
System.Net.IPAddress.Parse("85.130.51.220"),
System.Net.IPAddress.Parse("62.246.213.216"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 152,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("231.208.121.201"),
System.Net.IPAddress.Parse("232.111.62.202"),
System.Net.IPAddress.Parse("155.239.245.170"),
System.Net.IPAddress.Parse("72.68.56.177"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4Array1M
{
    Id = 151,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("57.201.93.1"),
System.Net.IPAddress.Parse("41.50.116.95"),
System.Net.IPAddress.Parse("81.159.32.241"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 158,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("123.241.110.205"),
System.Net.IPAddress.Parse("156.253.193.160"),
System.Net.IPAddress.Parse("3.19.73.1"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4Array1M
{
    Id = 155,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("250.91.37.115"),
System.Net.IPAddress.Parse("222.134.18.183"),
System.Net.IPAddress.Parse("118.9.173.99"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 162,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("70.102.94.154"),
System.Net.IPAddress.Parse("23.170.232.142"),
System.Net.IPAddress.Parse("176.146.205.81"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4Array1M
{
    Id = 159,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("175.55.208.161"),
System.Net.IPAddress.Parse("84.23.37.17"),
System.Net.IPAddress.Parse("163.211.118.39"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 169,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.37.239.193"),
System.Net.IPAddress.Parse("92.75.160.29"),
System.Net.IPAddress.Parse("221.52.197.77"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("227.67.109.244"),
System.Net.IPAddress.Parse("200.87.155.162"),
System.Net.IPAddress.Parse("61.117.119.26"),
},
},
    NullableValue = null,
},
            new IPAddressIPv4Array1M
{
    Id = 163,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("26.144.157.119"),
System.Net.IPAddress.Parse("20.207.246.90"),
System.Net.IPAddress.Parse("132.189.159.101"),
System.Net.IPAddress.Parse("188.158.14.88"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 172,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("35.113.116.178"),
System.Net.IPAddress.Parse("215.60.5.225"),
System.Net.IPAddress.Parse("3.186.161.3"),
System.Net.IPAddress.Parse("96.170.191.175"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("25.143.69.237"),
System.Net.IPAddress.Parse("68.108.21.180"),
System.Net.IPAddress.Parse("90.28.248.125"),
},
},
    NullableValue = null,
},
            new IPAddressIPv4Array1M
{
    Id = 167,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("50.72.73.192"),
System.Net.IPAddress.Parse("92.3.14.171"),
System.Net.IPAddress.Parse("57.148.181.97"),
},
    ModelInner = new IPAddressIPv4Array1MI
{
    Id = 181,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("128.118.217.105"),
System.Net.IPAddress.Parse("207.28.190.23"),
System.Net.IPAddress.Parse("118.99.84.223"),
System.Net.IPAddress.Parse("96.194.122.33"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("85.170.13.123"),
System.Net.IPAddress.Parse("1.223.109.101"),
System.Net.IPAddress.Parse("168.132.164.221"),
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.ipaddressipv4array1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:IPv4[]}, 
    {mi_id:Int32},
    {mi_value:IPv4[]}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayIPv4Array)),
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
                    await ((IIPAddressArrayIPv4Array)this).InsertModelDbConnectionAsync(
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
                     ((IIPAddressArrayIPv4Array)this).InsertModelDbConnection(
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
FROM gedaqtests.ipaddressipv4array1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(IPAddressIPv4Array1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayIPv4Array)),
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
                    var models = await ((IIPAddressArrayIPv4Array)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    IPAddressIPv4Array1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IIPAddressArrayIPv4Array)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    IPAddressIPv4Array1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

