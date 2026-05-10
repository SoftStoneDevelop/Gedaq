

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
    Id = 4,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("241.34.131.159"),
System.Net.IPAddress.Parse("254.44.178.59"),
System.Net.IPAddress.Parse("49.107.140.250"),
System.Net.IPAddress.Parse("124.31.126.187"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("41.68.72.95"),
System.Net.IPAddress.Parse("180.199.4.200"),
System.Net.IPAddress.Parse("114.72.229.69"),
System.Net.IPAddress.Parse("81.237.117.81"),
},
},
            new IPAddressinetArray1M
{
    Id = 7,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("62.182.29.173"),
System.Net.IPAddress.Parse("223.116.56.207"),
System.Net.IPAddress.Parse("75.245.49.112"),
System.Net.IPAddress.Parse("239.154.37.19"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 9,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.30.251.71"),
System.Net.IPAddress.Parse("145.250.165.64"),
System.Net.IPAddress.Parse("170.61.127.42"),
System.Net.IPAddress.Parse("86.83.156.157"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 12,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("73.156.18.220"),
System.Net.IPAddress.Parse("20.170.137.144"),
System.Net.IPAddress.Parse("197.34.73.85"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 18,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("71.230.71.6"),
System.Net.IPAddress.Parse("94.55.222.28"),
System.Net.IPAddress.Parse("233.236.86.157"),
System.Net.IPAddress.Parse("15.126.93.91"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 13,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("51.188.237.80"),
System.Net.IPAddress.Parse("203.209.167.163"),
System.Net.IPAddress.Parse("174.173.153.135"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("109.196.194.240"),
System.Net.IPAddress.Parse("26.80.167.96"),
System.Net.IPAddress.Parse("111.68.217.0"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("149.124.123.244"),
System.Net.IPAddress.Parse("144.233.76.93"),
System.Net.IPAddress.Parse("160.27.97.72"),
},
},
            new IPAddressinetArray1M
{
    Id = 22,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("214.135.48.172"),
System.Net.IPAddress.Parse("202.164.245.141"),
System.Net.IPAddress.Parse("119.22.180.117"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 24,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("37.26.8.126"),
System.Net.IPAddress.Parse("86.169.37.80"),
System.Net.IPAddress.Parse("60.13.35.62"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 17,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.242.189.47"),
System.Net.IPAddress.Parse("139.60.74.195"),
System.Net.IPAddress.Parse("99.151.233.176"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("215.137.97.167"),
System.Net.IPAddress.Parse("211.166.123.82"),
System.Net.IPAddress.Parse("194.152.219.251"),
System.Net.IPAddress.Parse("126.200.129.102"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("231.1.19.230"),
System.Net.IPAddress.Parse("52.212.123.157"),
System.Net.IPAddress.Parse("246.82.139.173"),
System.Net.IPAddress.Parse("25.77.121.43"),
},
},
            new IPAddressinetArray1M
{
    Id = 32,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("49.74.83.225"),
System.Net.IPAddress.Parse("28.171.37.84"),
System.Net.IPAddress.Parse("64.110.171.49"),
System.Net.IPAddress.Parse("53.145.65.221"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("252.59.173.115"),
System.Net.IPAddress.Parse("193.117.169.40"),
System.Net.IPAddress.Parse("171.68.195.109"),
System.Net.IPAddress.Parse("11.202.156.2"),
},
},
            new IPAddressinetArray1M
{
    Id = 40,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("74.192.168.239"),
System.Net.IPAddress.Parse("88.87.245.88"),
System.Net.IPAddress.Parse("6.140.123.155"),
System.Net.IPAddress.Parse("82.61.144.149"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 24,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("154.90.221.95"),
System.Net.IPAddress.Parse("142.47.240.90"),
System.Net.IPAddress.Parse("16.162.23.137"),
System.Net.IPAddress.Parse("43.42.82.194"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 43,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("173.104.185.135"),
System.Net.IPAddress.Parse("234.24.207.222"),
System.Net.IPAddress.Parse("159.86.99.247"),
System.Net.IPAddress.Parse("236.121.64.57"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("120.97.210.159"),
System.Net.IPAddress.Parse("83.54.148.214"),
System.Net.IPAddress.Parse("157.48.228.220"),
System.Net.IPAddress.Parse("193.102.101.31"),
},
},
            new IPAddressinetArray1M
{
    Id = 50,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("227.124.172.221"),
System.Net.IPAddress.Parse("78.11.233.210"),
System.Net.IPAddress.Parse("142.110.82.87"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 28,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("69.248.113.17"),
System.Net.IPAddress.Parse("159.107.27.72"),
System.Net.IPAddress.Parse("194.185.31.120"),
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
System.Net.IPAddress.Parse("72.81.21.54"),
System.Net.IPAddress.Parse("234.169.254.225"),
System.Net.IPAddress.Parse("187.98.231.125"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.141.250.170"),
System.Net.IPAddress.Parse("8.83.227.71"),
System.Net.IPAddress.Parse("182.160.201.189"),
},
},
            new IPAddressinetArray1M
{
    Id = 62,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("80.151.126.102"),
System.Net.IPAddress.Parse("215.230.225.90"),
System.Net.IPAddress.Parse("83.8.253.125"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 35,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("51.53.188.74"),
System.Net.IPAddress.Parse("134.211.194.105"),
System.Net.IPAddress.Parse("147.181.90.132"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("165.185.240.248"),
System.Net.IPAddress.Parse("38.82.45.129"),
System.Net.IPAddress.Parse("51.237.183.133"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("182.168.216.91"),
System.Net.IPAddress.Parse("239.111.194.108"),
System.Net.IPAddress.Parse("104.98.230.35"),
System.Net.IPAddress.Parse("149.25.37.196"),
},
},
            new IPAddressinetArray1M
{
    Id = 66,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("47.143.238.181"),
System.Net.IPAddress.Parse("124.230.6.160"),
System.Net.IPAddress.Parse("242.80.5.233"),
System.Net.IPAddress.Parse("249.117.84.148"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("73.0.5.70"),
System.Net.IPAddress.Parse("50.102.224.206"),
System.Net.IPAddress.Parse("32.168.189.234"),
System.Net.IPAddress.Parse("58.86.150.251"),
},
},
            new IPAddressinetArray1M
{
    Id = 69,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("57.180.14.120"),
System.Net.IPAddress.Parse("214.14.7.251"),
System.Net.IPAddress.Parse("74.121.144.133"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 41,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("115.29.214.198"),
System.Net.IPAddress.Parse("178.67.214.10"),
System.Net.IPAddress.Parse("42.88.51.32"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 70,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("14.37.210.131"),
System.Net.IPAddress.Parse("94.66.116.59"),
System.Net.IPAddress.Parse("4.178.10.160"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("84.74.1.116"),
System.Net.IPAddress.Parse("101.2.189.23"),
System.Net.IPAddress.Parse("207.108.222.103"),
},
},
            new IPAddressinetArray1M
{
    Id = 73,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("182.120.13.140"),
System.Net.IPAddress.Parse("221.85.214.42"),
System.Net.IPAddress.Parse("109.125.208.79"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 50,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("47.115.184.123"),
System.Net.IPAddress.Parse("127.183.105.50"),
System.Net.IPAddress.Parse("235.105.23.119"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("161.101.145.209"),
System.Net.IPAddress.Parse("178.148.90.109"),
System.Net.IPAddress.Parse("73.114.17.15"),
System.Net.IPAddress.Parse("26.27.83.247"),
},
},
            new IPAddressinetArray1M
{
    Id = 78,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("140.91.135.49"),
System.Net.IPAddress.Parse("159.17.104.72"),
System.Net.IPAddress.Parse("39.105.167.202"),
System.Net.IPAddress.Parse("103.75.3.187"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("131.133.240.93"),
System.Net.IPAddress.Parse("146.160.187.124"),
System.Net.IPAddress.Parse("84.231.32.161"),
System.Net.IPAddress.Parse("129.241.90.225"),
},
},
            new IPAddressinetArray1M
{
    Id = 80,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("128.101.124.170"),
System.Net.IPAddress.Parse("45.204.90.124"),
System.Net.IPAddress.Parse("67.112.238.22"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 59,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("23.178.31.128"),
System.Net.IPAddress.Parse("240.41.62.163"),
System.Net.IPAddress.Parse("91.70.113.96"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("117.214.203.45"),
System.Net.IPAddress.Parse("132.66.95.189"),
System.Net.IPAddress.Parse("205.200.192.69"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("83.125.198.79"),
System.Net.IPAddress.Parse("9.110.45.181"),
System.Net.IPAddress.Parse("162.56.77.228"),
},
},
            new IPAddressinetArray1M
{
    Id = 86,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("210.147.109.203"),
System.Net.IPAddress.Parse("133.35.104.226"),
System.Net.IPAddress.Parse("160.62.55.42"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("203.175.132.120"),
System.Net.IPAddress.Parse("67.97.60.83"),
System.Net.IPAddress.Parse("67.215.224.82"),
System.Net.IPAddress.Parse("105.67.37.237"),
},
},
            new IPAddressinetArray1M
{
    Id = 94,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("17.166.236.88"),
System.Net.IPAddress.Parse("175.83.62.220"),
System.Net.IPAddress.Parse("131.168.185.251"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 61,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("122.228.13.138"),
System.Net.IPAddress.Parse("209.189.57.165"),
System.Net.IPAddress.Parse("86.143.102.166"),
System.Net.IPAddress.Parse("66.174.209.148"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.60.19.110"),
System.Net.IPAddress.Parse("164.224.57.186"),
System.Net.IPAddress.Parse("9.53.142.176"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 99,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("196.63.64.214"),
System.Net.IPAddress.Parse("25.112.196.209"),
System.Net.IPAddress.Parse("203.53.29.211"),
System.Net.IPAddress.Parse("168.186.193.44"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("0.156.77.41"),
System.Net.IPAddress.Parse("85.211.73.112"),
System.Net.IPAddress.Parse("165.44.172.118"),
},
},
            new IPAddressinetArray1M
{
    Id = 108,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("93.100.206.91"),
System.Net.IPAddress.Parse("250.186.172.98"),
System.Net.IPAddress.Parse("6.99.74.240"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 63,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("8.234.253.26"),
System.Net.IPAddress.Parse("94.155.107.158"),
System.Net.IPAddress.Parse("185.195.198.32"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 112,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("98.38.119.221"),
System.Net.IPAddress.Parse("249.159.98.238"),
System.Net.IPAddress.Parse("56.246.100.121"),
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
System.Net.IPAddress.Parse("110.74.177.27"),
System.Net.IPAddress.Parse("55.87.58.228"),
System.Net.IPAddress.Parse("213.87.121.251"),
System.Net.IPAddress.Parse("126.224.114.153"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 69,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("33.8.87.247"),
System.Net.IPAddress.Parse("84.128.230.205"),
System.Net.IPAddress.Parse("166.27.69.195"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 117,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("119.95.109.28"),
System.Net.IPAddress.Parse("237.42.59.105"),
System.Net.IPAddress.Parse("40.114.8.76"),
System.Net.IPAddress.Parse("179.114.230.4"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("243.8.86.183"),
System.Net.IPAddress.Parse("208.132.217.232"),
System.Net.IPAddress.Parse("131.201.202.186"),
System.Net.IPAddress.Parse("145.50.221.94"),
},
},
            new IPAddressinetArray1M
{
    Id = 122,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("108.101.48.42"),
System.Net.IPAddress.Parse("9.14.192.21"),
System.Net.IPAddress.Parse("147.107.14.29"),
System.Net.IPAddress.Parse("118.173.102.246"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 74,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("239.227.13.214"),
System.Net.IPAddress.Parse("169.160.172.43"),
System.Net.IPAddress.Parse("79.129.175.56"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.228.103.177"),
System.Net.IPAddress.Parse("147.222.152.62"),
System.Net.IPAddress.Parse("226.125.214.167"),
System.Net.IPAddress.Parse("5.27.28.85"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 125,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("72.29.44.154"),
System.Net.IPAddress.Parse("222.28.104.99"),
System.Net.IPAddress.Parse("138.199.13.97"),
System.Net.IPAddress.Parse("233.123.176.234"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 132,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("138.219.104.246"),
System.Net.IPAddress.Parse("162.131.23.175"),
System.Net.IPAddress.Parse("26.246.7.241"),
System.Net.IPAddress.Parse("27.233.187.220"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 81,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("101.116.64.100"),
System.Net.IPAddress.Parse("55.236.87.14"),
System.Net.IPAddress.Parse("237.137.48.54"),
System.Net.IPAddress.Parse("221.104.207.41"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("231.73.163.192"),
System.Net.IPAddress.Parse("25.144.117.79"),
System.Net.IPAddress.Parse("125.227.238.37"),
},
},
            new IPAddressinetArray1M
{
    Id = 138,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("74.109.156.44"),
System.Net.IPAddress.Parse("108.131.48.181"),
System.Net.IPAddress.Parse("211.41.242.184"),
System.Net.IPAddress.Parse("242.56.113.178"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 142,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("186.22.244.220"),
System.Net.IPAddress.Parse("151.237.122.144"),
System.Net.IPAddress.Parse("122.111.244.33"),
System.Net.IPAddress.Parse("40.118.212.73"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 90,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("129.39.167.28"),
System.Net.IPAddress.Parse("199.102.115.29"),
System.Net.IPAddress.Parse("120.77.136.244"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 148,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("235.182.27.110"),
System.Net.IPAddress.Parse("141.113.221.249"),
System.Net.IPAddress.Parse("211.218.16.185"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 156,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("154.67.183.27"),
System.Net.IPAddress.Parse("126.204.65.161"),
System.Net.IPAddress.Parse("65.30.219.81"),
System.Net.IPAddress.Parse("206.139.159.216"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 96,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("105.236.55.158"),
System.Net.IPAddress.Parse("138.253.4.109"),
System.Net.IPAddress.Parse("189.107.71.236"),
System.Net.IPAddress.Parse("3.36.27.19"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("241.2.140.195"),
System.Net.IPAddress.Parse("106.90.101.233"),
System.Net.IPAddress.Parse("47.56.245.208"),
System.Net.IPAddress.Parse("236.46.224.73"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 164,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("148.136.138.182"),
System.Net.IPAddress.Parse("201.238.129.97"),
System.Net.IPAddress.Parse("166.49.40.109"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 165,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("186.164.105.236"),
System.Net.IPAddress.Parse("56.249.147.199"),
System.Net.IPAddress.Parse("164.45.184.220"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 102,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("83.240.83.12"),
System.Net.IPAddress.Parse("89.22.187.227"),
System.Net.IPAddress.Parse("144.192.180.79"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.133.215.241"),
System.Net.IPAddress.Parse("189.189.41.225"),
System.Net.IPAddress.Parse("88.219.51.36"),
},
},
            new IPAddressinetArray1M
{
    Id = 167,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.34.77.200"),
System.Net.IPAddress.Parse("138.250.131.104"),
System.Net.IPAddress.Parse("218.254.105.53"),
System.Net.IPAddress.Parse("217.124.76.72"),
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
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("231.1.19.230"),
System.Net.IPAddress.Parse("52.212.123.157"),
System.Net.IPAddress.Parse("246.82.139.173"),
System.Net.IPAddress.Parse("25.77.121.43"),
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
System.Net.IPAddress.Parse("252.59.173.115"),
System.Net.IPAddress.Parse("193.117.169.40"),
System.Net.IPAddress.Parse("171.68.195.109"),
System.Net.IPAddress.Parse("11.202.156.2"),
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
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("120.97.210.159"),
System.Net.IPAddress.Parse("83.54.148.214"),
System.Net.IPAddress.Parse("157.48.228.220"),
System.Net.IPAddress.Parse("193.102.101.31"),
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
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.141.250.170"),
System.Net.IPAddress.Parse("8.83.227.71"),
System.Net.IPAddress.Parse("182.160.201.189"),
}));
                nullable = await ((IIPAddressArrayinetArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("182.168.216.91"),
System.Net.IPAddress.Parse("239.111.194.108"),
System.Net.IPAddress.Parse("104.98.230.35"),
System.Net.IPAddress.Parse("149.25.37.196"),
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[34], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[29],_testData[34], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
                parametr1.Value = 80;
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[34], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 156, query1, 164, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 62, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[34], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 7, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 73, query1, 73, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 12, query1, 132, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[24],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[25],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[26],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[27],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[28],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[29],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[30],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 50, query1, 80, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 40, query1, 117, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[24],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[25],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[26],_testData[34], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 132, query1, 69, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[20],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 94, 94))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatch(connection, 73, 50))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[10], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[24],_testData[34], false);
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
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 112);
                var models = await ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                IPAddressinetArray1M.AssertModel(models[0],_testData[23], false);
                IPAddressinetArray1M.AssertModel(models[1],_testData[24], false);
                IPAddressinetArray1M.AssertModel(models[2],_testData[25], false);
                IPAddressinetArray1M.AssertModel(models[3],_testData[26], false);
                IPAddressinetArray1M.AssertModel(models[4],_testData[27], false);
                IPAddressinetArray1M.AssertModel(models[5],_testData[28], false);
                IPAddressinetArray1M.AssertModel(models[6],_testData[29], false);
                IPAddressinetArray1M.AssertModel(models[7],_testData[30], false);
                IPAddressinetArray1M.AssertModel(models[8],_testData[31], false);
                IPAddressinetArray1M.AssertModel(models[9],_testData[32], false);
                IPAddressinetArray1M.AssertModel(models[10],_testData[33], false);
                IPAddressinetArray1M.AssertModel(models[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 66);
                var models =  ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

