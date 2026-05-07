

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
    Id = 6,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("62.232.241.251"),
System.Net.IPAddress.Parse("41.66.55.49"),
System.Net.IPAddress.Parse("65.54.242.121"),
System.Net.IPAddress.Parse("84.159.88.195"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 12,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("180.147.235.251"),
System.Net.IPAddress.Parse("163.105.89.232"),
System.Net.IPAddress.Parse("15.142.41.253"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 5,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("159.143.180.212"),
System.Net.IPAddress.Parse("104.0.199.148"),
System.Net.IPAddress.Parse("12.88.144.93"),
System.Net.IPAddress.Parse("39.232.138.101"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("144.82.222.147"),
System.Net.IPAddress.Parse("43.4.165.197"),
System.Net.IPAddress.Parse("193.3.28.130"),
System.Net.IPAddress.Parse("239.236.215.237"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 16,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("60.66.186.28"),
System.Net.IPAddress.Parse("96.91.51.113"),
System.Net.IPAddress.Parse("20.249.246.19"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 19,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("11.136.179.233"),
System.Net.IPAddress.Parse("123.202.38.154"),
System.Net.IPAddress.Parse("224.251.160.124"),
System.Net.IPAddress.Parse("72.225.75.238"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 14,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("169.243.84.232"),
System.Net.IPAddress.Parse("248.229.33.90"),
System.Net.IPAddress.Parse("59.140.93.248"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("215.70.202.128"),
System.Net.IPAddress.Parse("125.151.9.84"),
System.Net.IPAddress.Parse("204.213.251.45"),
System.Net.IPAddress.Parse("194.176.200.147"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 26,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("182.232.6.19"),
System.Net.IPAddress.Parse("152.98.148.61"),
System.Net.IPAddress.Parse("76.91.214.47"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 34,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("83.148.231.252"),
System.Net.IPAddress.Parse("151.206.157.197"),
System.Net.IPAddress.Parse("218.94.20.169"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 18,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("203.97.166.152"),
System.Net.IPAddress.Parse("10.6.8.82"),
System.Net.IPAddress.Parse("70.56.26.171"),
System.Net.IPAddress.Parse("118.62.164.143"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("57.130.102.117"),
System.Net.IPAddress.Parse("78.129.124.199"),
System.Net.IPAddress.Parse("172.170.203.161"),
},
},
            new IPAddressinetArray1M
{
    Id = 39,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("78.134.165.248"),
System.Net.IPAddress.Parse("184.148.3.147"),
System.Net.IPAddress.Parse("166.80.135.155"),
System.Net.IPAddress.Parse("210.236.20.178"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("103.15.250.208"),
System.Net.IPAddress.Parse("181.48.75.127"),
System.Net.IPAddress.Parse("55.142.59.230"),
System.Net.IPAddress.Parse("148.244.15.214"),
},
},
            new IPAddressinetArray1M
{
    Id = 46,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("98.49.212.81"),
System.Net.IPAddress.Parse("240.159.138.26"),
System.Net.IPAddress.Parse("95.114.98.136"),
System.Net.IPAddress.Parse("232.90.186.223"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 23,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("197.183.55.193"),
System.Net.IPAddress.Parse("233.63.149.253"),
System.Net.IPAddress.Parse("21.115.21.103"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("133.238.239.66"),
System.Net.IPAddress.Parse("234.215.80.71"),
System.Net.IPAddress.Parse("72.70.141.166"),
System.Net.IPAddress.Parse("159.21.206.96"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 49,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("216.73.238.165"),
System.Net.IPAddress.Parse("41.74.2.8"),
System.Net.IPAddress.Parse("61.241.220.48"),
System.Net.IPAddress.Parse("78.78.17.21"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("236.230.7.179"),
System.Net.IPAddress.Parse("157.68.13.174"),
System.Net.IPAddress.Parse("215.36.204.161"),
},
},
            new IPAddressinetArray1M
{
    Id = 57,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("231.5.83.26"),
System.Net.IPAddress.Parse("39.84.235.79"),
System.Net.IPAddress.Parse("86.216.249.112"),
System.Net.IPAddress.Parse("253.183.184.181"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 24,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("10.108.51.102"),
System.Net.IPAddress.Parse("3.9.248.254"),
System.Net.IPAddress.Parse("54.149.37.151"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("147.138.194.195"),
System.Net.IPAddress.Parse("23.66.235.47"),
System.Net.IPAddress.Parse("32.70.203.209"),
System.Net.IPAddress.Parse("184.170.28.24"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 59,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("253.110.245.69"),
System.Net.IPAddress.Parse("94.176.100.213"),
System.Net.IPAddress.Parse("123.201.220.56"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("200.137.57.142"),
System.Net.IPAddress.Parse("240.30.156.89"),
System.Net.IPAddress.Parse("60.116.103.205"),
System.Net.IPAddress.Parse("186.98.37.220"),
},
},
            new IPAddressinetArray1M
{
    Id = 68,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("155.180.222.216"),
System.Net.IPAddress.Parse("217.220.158.104"),
System.Net.IPAddress.Parse("21.217.138.221"),
System.Net.IPAddress.Parse("45.80.28.166"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 25,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("113.14.22.142"),
System.Net.IPAddress.Parse("248.10.220.112"),
System.Net.IPAddress.Parse("221.40.188.243"),
System.Net.IPAddress.Parse("127.27.244.108"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("20.12.166.248"),
System.Net.IPAddress.Parse("165.232.84.91"),
System.Net.IPAddress.Parse("169.123.60.8"),
System.Net.IPAddress.Parse("248.208.44.190"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 72,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("98.202.189.158"),
System.Net.IPAddress.Parse("42.240.160.198"),
System.Net.IPAddress.Parse("191.251.84.178"),
System.Net.IPAddress.Parse("68.82.121.221"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 80,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("27.147.246.144"),
System.Net.IPAddress.Parse("7.45.152.166"),
System.Net.IPAddress.Parse("150.161.42.177"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 34,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("22.217.85.52"),
System.Net.IPAddress.Parse("18.155.248.239"),
System.Net.IPAddress.Parse("82.171.224.99"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 84,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("177.47.0.33"),
System.Net.IPAddress.Parse("76.31.175.37"),
System.Net.IPAddress.Parse("56.106.242.83"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 88,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("197.8.250.44"),
System.Net.IPAddress.Parse("116.215.94.216"),
System.Net.IPAddress.Parse("153.53.16.143"),
System.Net.IPAddress.Parse("93.63.232.52"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 38,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("106.87.58.20"),
System.Net.IPAddress.Parse("223.73.192.68"),
System.Net.IPAddress.Parse("216.31.252.176"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("53.143.84.114"),
System.Net.IPAddress.Parse("58.248.168.131"),
System.Net.IPAddress.Parse("197.39.13.68"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 91,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("214.149.106.37"),
System.Net.IPAddress.Parse("9.127.204.184"),
System.Net.IPAddress.Parse("189.228.68.22"),
System.Net.IPAddress.Parse("109.20.72.138"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 95,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("35.111.53.89"),
System.Net.IPAddress.Parse("231.200.184.193"),
System.Net.IPAddress.Parse("12.29.6.125"),
System.Net.IPAddress.Parse("98.242.145.2"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 40,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("44.210.214.136"),
System.Net.IPAddress.Parse("146.215.197.33"),
System.Net.IPAddress.Parse("236.2.78.239"),
System.Net.IPAddress.Parse("107.2.86.7"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("30.65.21.182"),
System.Net.IPAddress.Parse("96.182.145.105"),
System.Net.IPAddress.Parse("83.217.176.153"),
System.Net.IPAddress.Parse("147.241.116.104"),
},
},
            new IPAddressinetArray1M
{
    Id = 101,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("26.126.49.51"),
System.Net.IPAddress.Parse("25.220.101.155"),
System.Net.IPAddress.Parse("172.209.246.100"),
System.Net.IPAddress.Parse("162.127.200.248"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 108,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("57.220.103.4"),
System.Net.IPAddress.Parse("123.125.26.211"),
System.Net.IPAddress.Parse("233.11.248.147"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 45,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("89.210.115.228"),
System.Net.IPAddress.Parse("70.157.142.218"),
System.Net.IPAddress.Parse("225.46.178.219"),
System.Net.IPAddress.Parse("93.99.87.5"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("122.84.72.156"),
System.Net.IPAddress.Parse("157.178.6.212"),
System.Net.IPAddress.Parse("97.229.90.206"),
System.Net.IPAddress.Parse("183.55.221.51"),
},
},
            new IPAddressinetArray1M
{
    Id = 110,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("169.103.240.116"),
System.Net.IPAddress.Parse("225.124.11.241"),
System.Net.IPAddress.Parse("45.11.55.176"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 115,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("221.47.195.191"),
System.Net.IPAddress.Parse("239.233.142.170"),
System.Net.IPAddress.Parse("224.130.174.46"),
System.Net.IPAddress.Parse("54.217.218.102"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 46,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("193.5.113.68"),
System.Net.IPAddress.Parse("186.117.167.29"),
System.Net.IPAddress.Parse("246.132.3.48"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 120,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("226.205.19.180"),
System.Net.IPAddress.Parse("129.56.10.234"),
System.Net.IPAddress.Parse("221.147.111.98"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 121,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("17.165.121.53"),
System.Net.IPAddress.Parse("236.151.172.28"),
System.Net.IPAddress.Parse("32.35.125.6"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 50,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("152.223.130.98"),
System.Net.IPAddress.Parse("44.242.24.19"),
System.Net.IPAddress.Parse("114.91.9.220"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("150.176.187.187"),
System.Net.IPAddress.Parse("167.85.28.67"),
System.Net.IPAddress.Parse("111.75.217.142"),
System.Net.IPAddress.Parse("8.87.199.102"),
},
},
            new IPAddressinetArray1M
{
    Id = 124,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("39.92.208.108"),
System.Net.IPAddress.Parse("66.100.89.252"),
System.Net.IPAddress.Parse("137.200.211.156"),
System.Net.IPAddress.Parse("195.207.187.11"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("213.31.213.13"),
System.Net.IPAddress.Parse("66.175.68.138"),
System.Net.IPAddress.Parse("208.208.6.218"),
System.Net.IPAddress.Parse("28.227.145.134"),
},
},
            new IPAddressinetArray1M
{
    Id = 129,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("7.249.68.194"),
System.Net.IPAddress.Parse("132.205.121.207"),
System.Net.IPAddress.Parse("102.238.178.64"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 59,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("214.237.83.168"),
System.Net.IPAddress.Parse("237.126.115.167"),
System.Net.IPAddress.Parse("190.73.11.15"),
System.Net.IPAddress.Parse("210.170.149.30"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("11.91.138.65"),
System.Net.IPAddress.Parse("65.201.5.148"),
System.Net.IPAddress.Parse("50.98.48.241"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 131,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("59.115.149.13"),
System.Net.IPAddress.Parse("176.113.18.153"),
System.Net.IPAddress.Parse("76.10.185.103"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("253.83.80.245"),
System.Net.IPAddress.Parse("220.205.163.159"),
System.Net.IPAddress.Parse("134.238.155.91"),
},
},
            new IPAddressinetArray1M
{
    Id = 136,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.248.193.72"),
System.Net.IPAddress.Parse("63.9.78.248"),
System.Net.IPAddress.Parse("236.5.173.105"),
System.Net.IPAddress.Parse("168.237.36.143"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 62,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("9.20.86.86"),
System.Net.IPAddress.Parse("50.215.244.97"),
System.Net.IPAddress.Parse("87.28.67.76"),
System.Net.IPAddress.Parse("120.57.16.166"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("226.185.84.134"),
System.Net.IPAddress.Parse("97.167.70.77"),
System.Net.IPAddress.Parse("71.47.158.250"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 139,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("11.112.238.3"),
System.Net.IPAddress.Parse("161.92.202.38"),
System.Net.IPAddress.Parse("208.152.165.56"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("154.201.239.26"),
System.Net.IPAddress.Parse("0.208.33.82"),
System.Net.IPAddress.Parse("221.236.236.169"),
},
},
            new IPAddressinetArray1M
{
    Id = 141,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("211.121.64.33"),
System.Net.IPAddress.Parse("141.23.73.119"),
System.Net.IPAddress.Parse("209.49.222.37"),
System.Net.IPAddress.Parse("137.32.68.76"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 69,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("200.196.179.65"),
System.Net.IPAddress.Parse("190.156.5.30"),
System.Net.IPAddress.Parse("189.70.69.108"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("65.214.68.96"),
System.Net.IPAddress.Parse("204.193.172.132"),
System.Net.IPAddress.Parse("182.86.229.123"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.4.15.73"),
System.Net.IPAddress.Parse("86.69.57.67"),
System.Net.IPAddress.Parse("179.20.133.10"),
System.Net.IPAddress.Parse("162.199.172.25"),
},
},
            new IPAddressinetArray1M
{
    Id = 147,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("241.2.35.84"),
System.Net.IPAddress.Parse("33.220.69.2"),
System.Net.IPAddress.Parse("104.233.143.2"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("90.241.233.63"),
System.Net.IPAddress.Parse("127.143.136.55"),
System.Net.IPAddress.Parse("144.111.58.246"),
System.Net.IPAddress.Parse("195.143.117.114"),
},
},
            new IPAddressinetArray1M
{
    Id = 149,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("214.182.220.251"),
System.Net.IPAddress.Parse("126.250.165.17"),
System.Net.IPAddress.Parse("224.199.193.200"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 72,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("108.164.147.48"),
System.Net.IPAddress.Parse("183.253.72.146"),
System.Net.IPAddress.Parse("203.142.77.87"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("158.7.194.187"),
System.Net.IPAddress.Parse("178.194.40.82"),
System.Net.IPAddress.Parse("211.4.56.11"),
System.Net.IPAddress.Parse("221.253.149.148"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 151,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.89.6.248"),
System.Net.IPAddress.Parse("121.245.5.155"),
System.Net.IPAddress.Parse("79.42.68.117"),
System.Net.IPAddress.Parse("96.90.170.130"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 152,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("233.15.133.178"),
System.Net.IPAddress.Parse("106.200.39.99"),
System.Net.IPAddress.Parse("206.186.68.92"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 78,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("93.20.57.140"),
System.Net.IPAddress.Parse("91.104.150.83"),
System.Net.IPAddress.Parse("37.41.217.156"),
System.Net.IPAddress.Parse("85.44.215.94"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("66.15.29.55"),
System.Net.IPAddress.Parse("136.58.243.110"),
System.Net.IPAddress.Parse("77.227.202.204"),
System.Net.IPAddress.Parse("237.66.61.145"),
},
},
            new IPAddressinetArray1M
{
    Id = 161,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("133.115.127.166"),
System.Net.IPAddress.Parse("194.234.140.211"),
System.Net.IPAddress.Parse("218.249.210.65"),
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("57.130.102.117"),
System.Net.IPAddress.Parse("78.129.124.199"),
System.Net.IPAddress.Parse("172.170.203.161"),
}));
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
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("103.15.250.208"),
System.Net.IPAddress.Parse("181.48.75.127"),
System.Net.IPAddress.Parse("55.142.59.230"),
System.Net.IPAddress.Parse("148.244.15.214"),
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
System.Net.IPAddress.Parse("236.230.7.179"),
System.Net.IPAddress.Parse("157.68.13.174"),
System.Net.IPAddress.Parse("215.36.204.161"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("200.137.57.142"),
System.Net.IPAddress.Parse("240.30.156.89"),
System.Net.IPAddress.Parse("60.116.103.205"),
System.Net.IPAddress.Parse("186.98.37.220"),
}));
                nullable = await ((IIPAddressArrayinetArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[34], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
                parametr2.Value = 124;
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[34], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[1], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[2], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[3], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[4], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[5], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[6], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[7], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[8], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[9], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[10], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[24],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[25],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[26],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[27],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[28],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[29],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[30],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[31],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[32],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[33],_testData[34], false);
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
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[7], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[8], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[9], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[10], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[24],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[25],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[26],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[27],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 139, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[33],_testData[34], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 151, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 131, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[34], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 136, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[32],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 115, query1, 59, query2))
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[34], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 115, query1, 141, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 84, query1, 139, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[34], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 12, query1, 121, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 46, 12))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[8], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[9], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[10], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[24],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[25],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[2], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[3], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[4], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[5], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[6], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[7], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[8], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[9], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[10], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[24],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[25],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[26],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[27],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[28],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[29],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[30],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[31],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[32],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatch(connection, 16, 95))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[3], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[4], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[5], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[6], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[7], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[8], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[9], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[10], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[24],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[25],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[26],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[27],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[28],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[29],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[30],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[34], false);
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
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 151);
                var models = await ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                IPAddressinetArray1M.AssertModel(models[0],_testData[33], false);
                IPAddressinetArray1M.AssertModel(models[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 6);
                var models =  ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                IPAddressinetArray1M.AssertModel(models[0],_testData[1], false);
                IPAddressinetArray1M.AssertModel(models[1],_testData[2], false);
                IPAddressinetArray1M.AssertModel(models[2],_testData[3], false);
                IPAddressinetArray1M.AssertModel(models[3],_testData[4], false);
                IPAddressinetArray1M.AssertModel(models[4],_testData[5], false);
                IPAddressinetArray1M.AssertModel(models[5],_testData[6], false);
                IPAddressinetArray1M.AssertModel(models[6],_testData[7], false);
                IPAddressinetArray1M.AssertModel(models[7],_testData[8], false);
                IPAddressinetArray1M.AssertModel(models[8],_testData[9], false);
                IPAddressinetArray1M.AssertModel(models[9],_testData[10], false);
                IPAddressinetArray1M.AssertModel(models[10],_testData[11], false);
                IPAddressinetArray1M.AssertModel(models[11],_testData[12], false);
                IPAddressinetArray1M.AssertModel(models[12],_testData[13], false);
                IPAddressinetArray1M.AssertModel(models[13],_testData[14], false);
                IPAddressinetArray1M.AssertModel(models[14],_testData[15], false);
                IPAddressinetArray1M.AssertModel(models[15],_testData[16], false);
                IPAddressinetArray1M.AssertModel(models[16],_testData[17], false);
                IPAddressinetArray1M.AssertModel(models[17],_testData[18], false);
                IPAddressinetArray1M.AssertModel(models[18],_testData[19], false);
                IPAddressinetArray1M.AssertModel(models[19],_testData[20], false);
                IPAddressinetArray1M.AssertModel(models[20],_testData[21], false);
                IPAddressinetArray1M.AssertModel(models[21],_testData[22], false);
                IPAddressinetArray1M.AssertModel(models[22],_testData[23], false);
                IPAddressinetArray1M.AssertModel(models[23],_testData[24], false);
                IPAddressinetArray1M.AssertModel(models[24],_testData[25], false);
                IPAddressinetArray1M.AssertModel(models[25],_testData[26], false);
                IPAddressinetArray1M.AssertModel(models[26],_testData[27], false);
                IPAddressinetArray1M.AssertModel(models[27],_testData[28], false);
                IPAddressinetArray1M.AssertModel(models[28],_testData[29], false);
                IPAddressinetArray1M.AssertModel(models[29],_testData[30], false);
                IPAddressinetArray1M.AssertModel(models[30],_testData[31], false);
                IPAddressinetArray1M.AssertModel(models[31],_testData[32], false);
                IPAddressinetArray1M.AssertModel(models[32],_testData[33], false);
                IPAddressinetArray1M.AssertModel(models[33],_testData[34], false);
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

