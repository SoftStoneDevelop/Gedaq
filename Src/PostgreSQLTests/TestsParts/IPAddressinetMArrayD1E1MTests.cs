

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
    internal partial interface IIPAddressMArrayinetMArrayD1
    {
    }
    
    internal partial class IPAddressMArrayinetMArrayD1 : IIPAddressMArrayinetMArrayD1
    {


#region TestData

        private readonly IPAddressinetMArrayD1E1M[] _testData = new IPAddressinetMArrayD1E1M[]
        {
            new IPAddressinetMArrayD1E1M
{
    Id = 5,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("22.81.22.37"),
System.Net.IPAddress.Parse("9.245.141.194"),
System.Net.IPAddress.Parse("191.78.184.128"),
System.Net.IPAddress.Parse("248.221.31.192"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("139.221.32.161"),
System.Net.IPAddress.Parse("52.221.175.68"),
System.Net.IPAddress.Parse("152.113.221.204"),
},
},
            new IPAddressinetMArrayD1E1M
{
    Id = 8,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("162.62.44.110"),
System.Net.IPAddress.Parse("136.112.156.36"),
System.Net.IPAddress.Parse("242.26.116.186"),
},
    ModelInner = new IPAddressinetMArrayD11MI
{
    Id = 8,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("228.102.118.48"),
System.Net.IPAddress.Parse("80.189.197.246"),
System.Net.IPAddress.Parse("39.105.116.138"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMArrayD1E1M
{
    Id = 9,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("223.81.198.42"),
System.Net.IPAddress.Parse("212.32.158.221"),
System.Net.IPAddress.Parse("128.59.184.61"),
System.Net.IPAddress.Parse("108.51.216.79"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMArrayD1E1M
{
    Id = 18,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("244.170.219.51"),
System.Net.IPAddress.Parse("147.32.101.188"),
System.Net.IPAddress.Parse("129.107.68.168"),
},
    ModelInner = new IPAddressinetMArrayD11MI
{
    Id = 16,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("204.194.208.54"),
System.Net.IPAddress.Parse("84.224.65.200"),
System.Net.IPAddress.Parse("130.168.251.7"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("53.12.30.51"),
System.Net.IPAddress.Parse("161.154.98.201"),
System.Net.IPAddress.Parse("92.121.224.208"),
System.Net.IPAddress.Parse("39.145.183.154"),
},
},
            new IPAddressinetMArrayD1E1M
{
    Id = 24,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("117.160.169.30"),
System.Net.IPAddress.Parse("250.80.173.104"),
System.Net.IPAddress.Parse("174.48.175.9"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMArrayD1E1M
{
    Id = 28,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("4.95.19.190"),
System.Net.IPAddress.Parse("155.157.184.77"),
System.Net.IPAddress.Parse("219.133.57.110"),
System.Net.IPAddress.Parse("20.90.197.128"),
},
    ModelInner = new IPAddressinetMArrayD11MI
{
    Id = 21,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("54.59.52.71"),
System.Net.IPAddress.Parse("145.119.0.61"),
System.Net.IPAddress.Parse("180.32.56.142"),
System.Net.IPAddress.Parse("10.250.29.254"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("140.104.5.196"),
System.Net.IPAddress.Parse("183.148.86.122"),
System.Net.IPAddress.Parse("180.217.57.142"),
System.Net.IPAddress.Parse("151.90.156.143"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("30.10.169.13"),
System.Net.IPAddress.Parse("23.124.243.189"),
System.Net.IPAddress.Parse("225.170.58.79"),
System.Net.IPAddress.Parse("41.187.43.109"),
},
},
            new IPAddressinetMArrayD1E1M
{
    Id = 33,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("232.122.8.68"),
System.Net.IPAddress.Parse("92.51.60.85"),
System.Net.IPAddress.Parse("152.50.80.63"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.53.129.230"),
System.Net.IPAddress.Parse("147.2.209.128"),
System.Net.IPAddress.Parse("69.114.105.229"),
},
},
            new IPAddressinetMArrayD1E1M
{
    Id = 40,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("13.65.70.221"),
System.Net.IPAddress.Parse("23.43.214.230"),
System.Net.IPAddress.Parse("219.77.14.62"),
System.Net.IPAddress.Parse("198.49.39.104"),
},
    ModelInner = new IPAddressinetMArrayD11MI
{
    Id = 22,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("105.118.32.34"),
System.Net.IPAddress.Parse("218.214.141.244"),
System.Net.IPAddress.Parse("33.251.180.133"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("63.202.1.105"),
System.Net.IPAddress.Parse("176.203.233.168"),
System.Net.IPAddress.Parse("16.127.172.13"),
},
},
            new IPAddressinetMArrayD1E1M
{
    Id = 47,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("227.68.45.45"),
System.Net.IPAddress.Parse("179.232.224.187"),
System.Net.IPAddress.Parse("156.200.7.8"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("14.51.112.149"),
System.Net.IPAddress.Parse("252.140.115.231"),
System.Net.IPAddress.Parse("185.56.79.172"),
System.Net.IPAddress.Parse("190.45.11.125"),
},
},
            new IPAddressinetMArrayD1E1M
{
    Id = 55,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("34.58.193.30"),
System.Net.IPAddress.Parse("46.86.43.160"),
System.Net.IPAddress.Parse("19.226.170.67"),
},
    ModelInner = new IPAddressinetMArrayD11MI
{
    Id = 24,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("242.200.245.174"),
System.Net.IPAddress.Parse("150.7.228.23"),
System.Net.IPAddress.Parse("114.190.186.177"),
System.Net.IPAddress.Parse("203.42.27.116"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMArrayD1E1M
{
    Id = 63,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("93.158.150.103"),
System.Net.IPAddress.Parse("22.199.133.102"),
System.Net.IPAddress.Parse("51.225.30.137"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("218.12.245.73"),
System.Net.IPAddress.Parse("52.183.30.14"),
System.Net.IPAddress.Parse("124.46.158.220"),
System.Net.IPAddress.Parse("103.151.129.0"),
},
},
            new IPAddressinetMArrayD1E1M
{
    Id = 68,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("103.30.119.213"),
System.Net.IPAddress.Parse("23.28.251.1"),
System.Net.IPAddress.Parse("6.70.10.47"),
},
    ModelInner = new IPAddressinetMArrayD11MI
{
    Id = 32,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("61.109.116.55"),
System.Net.IPAddress.Parse("133.142.33.125"),
System.Net.IPAddress.Parse("138.155.81.135"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("253.84.135.9"),
System.Net.IPAddress.Parse("74.84.169.232"),
System.Net.IPAddress.Parse("132.182.41.207"),
System.Net.IPAddress.Parse("55.156.205.16"),
},
},
    NullableValue = null,
},
            new IPAddressinetMArrayD1E1M
{
    Id = 71,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("162.103.6.188"),
System.Net.IPAddress.Parse("152.78.74.21"),
System.Net.IPAddress.Parse("198.22.58.179"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMArrayD1E1M
{
    Id = 76,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("119.5.148.221"),
System.Net.IPAddress.Parse("228.48.171.72"),
System.Net.IPAddress.Parse("209.80.218.130"),
System.Net.IPAddress.Parse("209.216.238.153"),
},
    ModelInner = new IPAddressinetMArrayD11MI
{
    Id = 34,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("124.85.115.222"),
System.Net.IPAddress.Parse("158.29.75.91"),
System.Net.IPAddress.Parse("187.69.41.120"),
System.Net.IPAddress.Parse("7.70.195.200"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("15.243.241.29"),
System.Net.IPAddress.Parse("240.185.64.36"),
System.Net.IPAddress.Parse("200.41.50.196"),
System.Net.IPAddress.Parse("230.1.128.9"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("224.126.187.115"),
System.Net.IPAddress.Parse("152.228.55.160"),
System.Net.IPAddress.Parse("33.42.200.178"),
System.Net.IPAddress.Parse("49.70.102.114"),
},
},
            new IPAddressinetMArrayD1E1M
{
    Id = 81,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("171.192.224.181"),
System.Net.IPAddress.Parse("196.133.3.227"),
System.Net.IPAddress.Parse("203.182.92.19"),
System.Net.IPAddress.Parse("126.3.44.60"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMArrayD1E1M
{
    Id = 89,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("33.16.227.228"),
System.Net.IPAddress.Parse("43.17.43.104"),
System.Net.IPAddress.Parse("208.84.223.54"),
},
    ModelInner = new IPAddressinetMArrayD11MI
{
    Id = 36,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("205.87.55.33"),
System.Net.IPAddress.Parse("0.105.238.10"),
System.Net.IPAddress.Parse("100.59.26.167"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("233.80.10.204"),
System.Net.IPAddress.Parse("182.16.86.111"),
System.Net.IPAddress.Parse("22.122.50.182"),
System.Net.IPAddress.Parse("137.114.86.125"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("73.3.204.110"),
System.Net.IPAddress.Parse("84.73.97.3"),
System.Net.IPAddress.Parse("44.8.149.67"),
},
},
            new IPAddressinetMArrayD1E1M
{
    Id = 93,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("44.21.17.14"),
System.Net.IPAddress.Parse("105.42.144.68"),
System.Net.IPAddress.Parse("175.89.254.244"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("132.2.129.251"),
System.Net.IPAddress.Parse("20.226.99.103"),
System.Net.IPAddress.Parse("18.227.92.136"),
},
},
            new IPAddressinetMArrayD1E1M
{
    Id = 97,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("204.17.229.49"),
System.Net.IPAddress.Parse("125.37.206.0"),
System.Net.IPAddress.Parse("67.239.162.234"),
},
    ModelInner = new IPAddressinetMArrayD11MI
{
    Id = 43,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("167.65.89.11"),
System.Net.IPAddress.Parse("125.209.251.40"),
System.Net.IPAddress.Parse("12.172.107.230"),
System.Net.IPAddress.Parse("93.58.147.40"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("186.162.105.162"),
System.Net.IPAddress.Parse("254.110.139.0"),
System.Net.IPAddress.Parse("71.181.243.189"),
System.Net.IPAddress.Parse("77.108.188.236"),
},
},
            new IPAddressinetMArrayD1E1M
{
    Id = 101,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("150.101.233.125"),
System.Net.IPAddress.Parse("205.100.17.64"),
System.Net.IPAddress.Parse("244.242.81.17"),
System.Net.IPAddress.Parse("14.146.26.4"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("240.132.74.221"),
System.Net.IPAddress.Parse("48.53.37.158"),
System.Net.IPAddress.Parse("99.214.194.96"),
System.Net.IPAddress.Parse("227.188.60.102"),
},
},
            new IPAddressinetMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("76.236.29.127"),
System.Net.IPAddress.Parse("169.50.126.42"),
System.Net.IPAddress.Parse("17.166.118.8"),
},
    ModelInner = new IPAddressinetMArrayD11MI
{
    Id = 52,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("206.45.19.2"),
System.Net.IPAddress.Parse("33.86.161.143"),
System.Net.IPAddress.Parse("107.185.147.213"),
System.Net.IPAddress.Parse("30.200.5.139"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("229.52.171.90"),
System.Net.IPAddress.Parse("70.168.191.77"),
System.Net.IPAddress.Parse("114.17.33.188"),
System.Net.IPAddress.Parse("145.199.69.211"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("143.7.77.73"),
System.Net.IPAddress.Parse("254.215.43.204"),
System.Net.IPAddress.Parse("151.227.210.227"),
System.Net.IPAddress.Parse("204.130.77.98"),
},
},
            new IPAddressinetMArrayD1E1M
{
    Id = 106,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("91.228.242.62"),
System.Net.IPAddress.Parse("248.140.26.252"),
System.Net.IPAddress.Parse("136.150.50.162"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("136.103.5.82"),
System.Net.IPAddress.Parse("244.4.85.157"),
System.Net.IPAddress.Parse("73.14.92.140"),
},
},
            new IPAddressinetMArrayD1E1M
{
    Id = 112,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("229.245.133.35"),
System.Net.IPAddress.Parse("161.253.138.31"),
System.Net.IPAddress.Parse("3.64.215.78"),
},
    ModelInner = new IPAddressinetMArrayD11MI
{
    Id = 57,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.55.104.81"),
System.Net.IPAddress.Parse("196.48.49.186"),
System.Net.IPAddress.Parse("132.94.179.139"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("221.34.153.40"),
System.Net.IPAddress.Parse("95.6.183.49"),
System.Net.IPAddress.Parse("164.132.47.76"),
System.Net.IPAddress.Parse("68.51.217.3"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("139.66.146.83"),
System.Net.IPAddress.Parse("144.143.79.206"),
System.Net.IPAddress.Parse("187.239.40.113"),
},
},
            new IPAddressinetMArrayD1E1M
{
    Id = 113,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("74.8.23.133"),
System.Net.IPAddress.Parse("198.85.198.192"),
System.Net.IPAddress.Parse("16.226.5.184"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMArrayD1E1M
{
    Id = 117,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("220.217.235.205"),
System.Net.IPAddress.Parse("105.123.172.174"),
System.Net.IPAddress.Parse("254.25.175.175"),
},
    ModelInner = new IPAddressinetMArrayD11MI
{
    Id = 62,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("229.165.51.92"),
System.Net.IPAddress.Parse("59.130.11.102"),
System.Net.IPAddress.Parse("122.19.176.167"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("96.197.214.214"),
System.Net.IPAddress.Parse("248.236.15.188"),
System.Net.IPAddress.Parse("160.15.95.121"),
},
},
    NullableValue = null,
},
            new IPAddressinetMArrayD1E1M
{
    Id = 122,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("231.132.181.246"),
System.Net.IPAddress.Parse("24.160.205.225"),
System.Net.IPAddress.Parse("15.91.186.147"),
System.Net.IPAddress.Parse("174.37.182.11"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("168.23.236.34"),
System.Net.IPAddress.Parse("3.103.8.31"),
System.Net.IPAddress.Parse("57.212.198.178"),
},
},
            new IPAddressinetMArrayD1E1M
{
    Id = 128,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("121.241.177.29"),
System.Net.IPAddress.Parse("206.229.51.21"),
System.Net.IPAddress.Parse("209.27.53.227"),
},
    ModelInner = new IPAddressinetMArrayD11MI
{
    Id = 65,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("226.226.23.11"),
System.Net.IPAddress.Parse("77.16.187.8"),
System.Net.IPAddress.Parse("177.79.157.87"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMArrayD1E1M
{
    Id = 130,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("211.32.41.88"),
System.Net.IPAddress.Parse("135.23.211.80"),
System.Net.IPAddress.Parse("7.7.32.164"),
System.Net.IPAddress.Parse("235.23.154.174"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("92.238.98.31"),
System.Net.IPAddress.Parse("57.40.96.5"),
System.Net.IPAddress.Parse("195.148.119.143"),
},
},
            new IPAddressinetMArrayD1E1M
{
    Id = 131,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("107.133.86.229"),
System.Net.IPAddress.Parse("157.115.164.44"),
System.Net.IPAddress.Parse("62.220.41.55"),
System.Net.IPAddress.Parse("76.211.226.29"),
},
    ModelInner = new IPAddressinetMArrayD11MI
{
    Id = 74,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("132.23.162.232"),
System.Net.IPAddress.Parse("218.243.224.85"),
System.Net.IPAddress.Parse("170.232.165.11"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("34.153.30.241"),
System.Net.IPAddress.Parse("140.4.56.187"),
System.Net.IPAddress.Parse("99.135.191.220"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("204.2.135.89"),
System.Net.IPAddress.Parse("254.169.56.137"),
System.Net.IPAddress.Parse("95.219.57.26"),
System.Net.IPAddress.Parse("217.122.212.251"),
},
},
            new IPAddressinetMArrayD1E1M
{
    Id = 133,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("18.46.186.60"),
System.Net.IPAddress.Parse("208.70.111.142"),
System.Net.IPAddress.Parse("10.220.213.184"),
System.Net.IPAddress.Parse("193.212.138.150"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("14.113.128.82"),
System.Net.IPAddress.Parse("39.113.212.221"),
System.Net.IPAddress.Parse("144.134.193.166"),
},
},
            new IPAddressinetMArrayD1E1M
{
    Id = 136,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("98.50.234.203"),
System.Net.IPAddress.Parse("248.246.9.215"),
System.Net.IPAddress.Parse("17.2.173.107"),
System.Net.IPAddress.Parse("33.25.67.254"),
},
    ModelInner = new IPAddressinetMArrayD11MI
{
    Id = 78,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("164.155.136.156"),
System.Net.IPAddress.Parse("64.52.160.162"),
System.Net.IPAddress.Parse("209.115.90.243"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMArrayD1E1M
{
    Id = 137,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("131.111.212.46"),
System.Net.IPAddress.Parse("96.164.102.92"),
System.Net.IPAddress.Parse("164.180.11.174"),
System.Net.IPAddress.Parse("221.86.185.13"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("105.224.202.167"),
System.Net.IPAddress.Parse("151.225.5.24"),
System.Net.IPAddress.Parse("45.42.45.199"),
},
},
            new IPAddressinetMArrayD1E1M
{
    Id = 138,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("170.235.254.28"),
System.Net.IPAddress.Parse("110.238.94.226"),
System.Net.IPAddress.Parse("123.120.212.122"),
System.Net.IPAddress.Parse("179.168.130.194"),
},
    ModelInner = new IPAddressinetMArrayD11MI
{
    Id = 87,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("118.214.11.32"),
System.Net.IPAddress.Parse("206.124.111.254"),
System.Net.IPAddress.Parse("148.143.154.1"),
System.Net.IPAddress.Parse("41.152.247.218"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMArrayD1E1M
{
    Id = 140,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("202.153.26.97"),
System.Net.IPAddress.Parse("241.81.91.27"),
System.Net.IPAddress.Parse("253.132.241.248"),
System.Net.IPAddress.Parse("223.117.172.74"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetMArrayD1E1M
{
    Id = 149,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("75.75.139.111"),
System.Net.IPAddress.Parse("249.43.10.216"),
System.Net.IPAddress.Parse("89.161.229.96"),
System.Net.IPAddress.Parse("250.5.48.210"),
},
    ModelInner = new IPAddressinetMArrayD11MI
{
    Id = 92,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("236.242.248.179"),
System.Net.IPAddress.Parse("232.119.2.64"),
System.Net.IPAddress.Parse("196.78.152.53"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetMArrayD1E1M
{
    Id = 153,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("146.15.164.234"),
System.Net.IPAddress.Parse("100.115.146.58"),
System.Net.IPAddress.Parse("11.39.121.72"),
System.Net.IPAddress.Parse("82.36.53.101"),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmarrayd11mi(
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
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
INSERT INTO public.ipaddressinetmarrayd11mi(
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
            queryMapTypes: [typeof(IPAddressinetMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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

                changedRows =  ((IIPAddressMArrayinetMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IIPAddressMArrayinetMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IIPAddressMArrayinetMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IIPAddressMArrayinetMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmarrayd1e1m(
	id,
    value,
    nullablevalue,
    ipaddressinetmarrayd11mi_id
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
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)), 
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
                methodParametrName: "ipaddressinetmarrayd11mi_id", 
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
                changedRows =  ((IIPAddressMArrayinetMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IIPAddressMArrayinetMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmarrayd1e1m(
	id,
    value,
    nullablevalue,
    ipaddressinetmarrayd11mi_id
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
    ipaddressinetmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(IPAddressinetMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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

                    nullable =  ((IIPAddressMArrayinetMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable =  ((IIPAddressMArrayinetMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("30.10.169.13"),
System.Net.IPAddress.Parse("23.124.243.189"),
System.Net.IPAddress.Parse("225.170.58.79"),
System.Net.IPAddress.Parse("41.187.43.109"),
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

                    nullable = await ((IIPAddressMArrayinetMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.53.129.230"),
System.Net.IPAddress.Parse("147.2.209.128"),
System.Net.IPAddress.Parse("69.114.105.229"),
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

                    nullable = await ((IIPAddressMArrayinetMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("63.202.1.105"),
System.Net.IPAddress.Parse("176.203.233.168"),
System.Net.IPAddress.Parse("16.127.172.13"),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetmarrayd1e1m(
	id,
    value,
    nullablevalue,
    ipaddressinetmarrayd11mi_id
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
    ipaddressinetmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(IPAddressinetMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
                methodParametrName: "ipaddressinetmarrayd11mi_id", 
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
                nullable =  ((IIPAddressMArrayinetMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("14.51.112.149"),
System.Net.IPAddress.Parse("252.140.115.231"),
System.Net.IPAddress.Parse("185.56.79.172"),
System.Net.IPAddress.Parse("190.45.11.125"),
}));
                nullable =  ((IIPAddressMArrayinetMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((IIPAddressMArrayinetMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("218.12.245.73"),
System.Net.IPAddress.Parse("52.183.30.14"),
System.Net.IPAddress.Parse("124.46.158.220"),
System.Net.IPAddress.Parse("103.151.129.0"),
}));
                nullable = await ((IIPAddressMArrayinetMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetMArrayD1E1M> models = null;

                models =  ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetMArrayD1E1M> models = null;

                models = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IIPAddressMArrayinetMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetMArrayD1E1M), typeof(FlatIPAddressinetMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var models2 = new List<FlatIPAddressinetMArrayD1E1M>();
                await ((IIPAddressMArrayinetMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var models2 = new List<FlatIPAddressinetMArrayD1E1M>();
                ((IIPAddressMArrayinetMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IIPAddressMArrayinetMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IIPAddressMArrayinetMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmarrayd1e1m m
LEFT JOIN public.ipaddressinetmarrayd11mi mi ON mi.id = m.ipaddressinetmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinetMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
                var models = await ((IIPAddressMArrayinetMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IIPAddressMArrayinetMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetMArrayD1E1M), typeof(FlatIPAddressinetMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var models2 = new List<FlatIPAddressinetMArrayD1E1M>();
                await ((IIPAddressMArrayinetMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var models2 = new List<FlatIPAddressinetMArrayD1E1M>();
                ((IIPAddressMArrayinetMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IIPAddressMArrayinetMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressMArrayinetMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmarrayd1e1m m
LEFT JOIN public.ipaddressinetmarrayd11mi mi ON mi.id = m.ipaddressinetmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(IPAddressinetMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
                var models = await ((IIPAddressMArrayinetMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IIPAddressMArrayinetMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetMArrayD1E1M), typeof(FlatIPAddressinetMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var models2 = new List<FlatIPAddressinetMArrayD1E1M>();
                await((IIPAddressMArrayinetMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
FROM public.ipaddressinetmarrayd1e1m m
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var firstItems2 = new List<FlatIPAddressinetMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var secondItems2 = new List<FlatIPAddressinetMArrayD1E1M>();
                await ((IIPAddressMArrayinetMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
FROM public.ipaddressinetmarrayd1e1m m
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var firstItems2 = new List<FlatIPAddressinetMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                await ((IIPAddressMArrayinetMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var models2 = new List<FlatIPAddressinetMArrayD1E1M>();
                ((IIPAddressMArrayinetMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
FROM public.ipaddressinetmarrayd1e1m m
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var firstItems2 = new List<FlatIPAddressinetMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var secondItems2 = new List<FlatIPAddressinetMArrayD1E1M>();
                 ((IIPAddressMArrayinetMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
FROM public.ipaddressinetmarrayd1e1m m
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var firstItems2 = new List<FlatIPAddressinetMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                 ((IIPAddressMArrayinetMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IIPAddressMArrayinetMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetmarrayd1e1m m
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressMArrayinetMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetmarrayd1e1m m
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var secondItems2 = new List<FlatIPAddressinetMArrayD1E1M>();
                await ((IIPAddressMArrayinetMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IIPAddressMArrayinetMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 89;
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
FROM public.ipaddressinetmarrayd1e1m m
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressMArrayinetMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinetmarrayd1e1m m
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var secondItems2 = new List<FlatIPAddressinetMArrayD1E1M>();
                 ((IIPAddressMArrayinetMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.ipaddressinetmarrayd1e1m m
LEFT JOIN public.ipaddressinetmarrayd11mi mi ON mi.id = m.ipaddressinetmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinetMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
                var models = await((IIPAddressMArrayinetMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressMArrayinetMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[15],_testData[34], false);
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
                var models = ((IIPAddressMArrayinetMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressMArrayinetMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetMArrayD1E1M), typeof(FlatIPAddressinetMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var models2 = new List<FlatIPAddressinetMArrayD1E1M>();
                await((IIPAddressMArrayinetMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetmarrayd1e1m m
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var firstItems2 = new List<FlatIPAddressinetMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var secondItems2 = new List<FlatIPAddressinetMArrayD1E1M>();
                await ((IIPAddressMArrayinetMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 8, query1, 24, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.ipaddressinetmarrayd1e1m m
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var firstItems2 = new List<FlatIPAddressinetMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                await ((IIPAddressMArrayinetMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 71, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var models2 = new List<FlatIPAddressinetMArrayD1E1M>();
                ((IIPAddressMArrayinetMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinetmarrayd1e1m m
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var firstItems2 = new List<FlatIPAddressinetMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var secondItems2 = new List<FlatIPAddressinetMArrayD1E1M>();
                 ((IIPAddressMArrayinetMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 28, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.ipaddressinetmarrayd1e1m m
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var firstItems2 = new List<FlatIPAddressinetMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                 ((IIPAddressMArrayinetMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 97, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IIPAddressMArrayinetMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmarrayd1e1m m
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressMArrayinetMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 97, query1, 117, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
FROM public.ipaddressinetmarrayd1e1m m
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var secondItems2 = new List<FlatIPAddressinetMArrayD1E1M>();
                await ((IIPAddressMArrayinetMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 140, query1, 68, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressMArrayinetMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinetmarrayd1e1m m
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressMArrayinetMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 138, query1, 40, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
FROM public.ipaddressinetmarrayd1e1m m
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
FROM public.ipaddressinetmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var secondItems1 = new List<FlatIPAddressinetMArrayD1E1M>();
                var secondItems2 = new List<FlatIPAddressinetMArrayD1E1M>();
                 ((IIPAddressMArrayinetMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 9, query1, 136, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatIPAddressinetMArrayD1E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.ipaddressinetmarrayd1e1m m
LEFT JOIN public.ipaddressinetmarrayd11mi mi ON mi.id = m.ipaddressinetmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(IPAddressinetMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
                var models = await((IIPAddressMArrayinetMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IIPAddressMArrayinetMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 71, 68))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[22],_testData[34], false);
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
                var models = ((IIPAddressMArrayinetMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IIPAddressMArrayinetMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 133, 5))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        IPAddressinetMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
                await using var cmd = await ((IIPAddressMArrayinetMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IIPAddressMArrayinetMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 112);
                var models = await ((IIPAddressMArrayinetMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                IPAddressinetMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                IPAddressinetMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                IPAddressinetMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                IPAddressinetMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                IPAddressinetMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                IPAddressinetMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                IPAddressinetMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                IPAddressinetMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                IPAddressinetMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                IPAddressinetMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                IPAddressinetMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                IPAddressinetMArrayD1E1M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressMArrayinetMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressMArrayinetMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 140);
                var models =  ((IIPAddressMArrayinetMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                IPAddressinetMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                IPAddressinetMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
FROM public.binary_ipaddressinetmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(IPAddressinetMArrayD11MIWA),
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
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMArrayD11MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressMArrayinetMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinetmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IIPAddressMArrayinetMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMArrayD11MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressMArrayinetMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinetmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressMArrayinetMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(IPAddressinetMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMArrayD11MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressMArrayinetMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinetmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IIPAddressMArrayinetMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMArrayD11MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressMArrayinetMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinetmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressMArrayinetMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetmarrayd11mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(IPAddressinetMArrayD11MI),
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
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMArrayD11MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IIPAddressMArrayinetMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IIPAddressMArrayinetMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMArrayD11MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMArrayD11MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IIPAddressMArrayinetMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IIPAddressMArrayinetMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMArrayD11MI.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinetmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(IPAddressinetMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMArrayD11MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressMArrayinetMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IIPAddressMArrayinetMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMArrayD11MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressMArrayinetMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IIPAddressMArrayinetMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetMArrayD11MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
ipaddressinetmarrayd11mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(IPAddressinetMArrayD1E1M),
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
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1))]
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
FROM public.binary_ipaddressinetmarrayd1e1m m
LEFT JOIN public.binary_ipaddressinetmarrayd11mi mi ON mi.id = m.ipaddressinetmarrayd11mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(IPAddressinetMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IIPAddressMArrayinetMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IIPAddressMArrayinetMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    IPAddressinetMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IIPAddressMArrayinetMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IIPAddressMArrayinetMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    IPAddressinetMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    ipaddressinetmarrayd11mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(IPAddressinetMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
                var models =  ((IIPAddressMArrayinetMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    IPAddressinetMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressMArrayinetMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    IPAddressinetMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD11MIWA), typeof(IPAddressinetMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
                var models1 = new List<IPAddressinetMArrayD11MIWA>();
                var models2 = new List<IPAddressinetMArrayD11MIWA>();
                await ((IIPAddressMArrayinetMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetMArrayD11MIWA>();
                var models2 = new List<IPAddressinetMArrayD11MIWA>();
                ((IIPAddressMArrayinetMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
                var models = await ((IIPAddressMArrayinetMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_ipaddressinetmarrayd11mi
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
                    IPAddressinetMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressMArrayinetMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_ipaddressinetmarrayd11mi
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
                    IPAddressinetMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD11MIWA), typeof(IPAddressinetMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1))]
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
                var models1 = new List<IPAddressinetMArrayD11MIWA>();
                var models2 = new List<IPAddressinetMArrayD11MIWA>();
                await ((IIPAddressMArrayinetMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetMArrayD11MIWA>();
                var models2 = new List<IPAddressinetMArrayD11MIWA>();
                ((IIPAddressMArrayinetMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinetmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1))]
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
                var models = await ((IIPAddressMArrayinetMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_ipaddressinetmarrayd11mi
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
                    IPAddressinetMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressMArrayinetMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_ipaddressinetmarrayd11mi
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
                    IPAddressinetMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_ipaddressinetmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD11MI), typeof(IPAddressinetMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
                var models1 = new List<IPAddressinetMArrayD11MI>();
                var models2 = new List<IPAddressinetMArrayD11MI>();
                await ((IIPAddressMArrayinetMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMArrayD11MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetMArrayD11MI>();
                var models2 = new List<IPAddressinetMArrayD11MI>();
                ((IIPAddressMArrayinetMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMArrayD11MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetmarrayd11mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1)),
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
                var models = await ((IIPAddressMArrayinetMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetMArrayD11MI.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressMArrayinetMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetMArrayD11MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_ipaddressinetmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD11MIWA), typeof(IPAddressinetMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1))]
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
                var models1 = new List<IPAddressinetMArrayD11MIWA>();
                var models2 = new List<IPAddressinetMArrayD11MIWA>();
                await ((IIPAddressMArrayinetMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetMArrayD11MIWA>();
                var models2 = new List<IPAddressinetMArrayD11MIWA>();
                ((IIPAddressMArrayinetMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetmarrayd11mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(IPAddressinetMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressMArrayinetMArrayD1))]
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
                var models = await ((IIPAddressMArrayinetMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressMArrayinetMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

