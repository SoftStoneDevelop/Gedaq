

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
System.Net.IPAddress.Parse("21.70.133.6"),
System.Net.IPAddress.Parse("251.209.187.107"),
System.Net.IPAddress.Parse("154.162.201.70"),
System.Net.IPAddress.Parse("15.198.69.30"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("82.250.128.40"),
System.Net.IPAddress.Parse("90.206.150.4"),
System.Net.IPAddress.Parse("13.175.47.17"),
System.Net.IPAddress.Parse("30.113.181.251"),
},
},
            new IPAddressinetArray1M
{
    Id = 13,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("216.241.153.169"),
System.Net.IPAddress.Parse("96.109.193.187"),
System.Net.IPAddress.Parse("244.253.211.145"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 8,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("127.14.130.251"),
System.Net.IPAddress.Parse("207.65.103.192"),
System.Net.IPAddress.Parse("245.180.16.156"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("167.220.100.89"),
System.Net.IPAddress.Parse("157.115.193.46"),
System.Net.IPAddress.Parse("22.167.201.226"),
System.Net.IPAddress.Parse("111.99.7.12"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("183.74.231.203"),
System.Net.IPAddress.Parse("170.14.200.79"),
System.Net.IPAddress.Parse("104.101.72.252"),
System.Net.IPAddress.Parse("63.244.92.202"),
},
},
            new IPAddressinetArray1M
{
    Id = 15,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("14.130.88.251"),
System.Net.IPAddress.Parse("31.22.211.174"),
System.Net.IPAddress.Parse("244.203.186.201"),
System.Net.IPAddress.Parse("80.31.227.226"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 21,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.145.242.63"),
System.Net.IPAddress.Parse("252.187.111.212"),
System.Net.IPAddress.Parse("153.84.143.195"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 10,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("62.100.16.67"),
System.Net.IPAddress.Parse("143.50.230.42"),
System.Net.IPAddress.Parse("125.116.250.109"),
System.Net.IPAddress.Parse("92.208.188.66"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("175.202.150.22"),
System.Net.IPAddress.Parse("239.33.174.126"),
System.Net.IPAddress.Parse("102.80.164.169"),
System.Net.IPAddress.Parse("86.55.59.151"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 28,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("0.164.57.103"),
System.Net.IPAddress.Parse("13.234.1.36"),
System.Net.IPAddress.Parse("49.188.51.189"),
System.Net.IPAddress.Parse("81.166.69.142"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("74.113.156.244"),
System.Net.IPAddress.Parse("40.237.254.88"),
System.Net.IPAddress.Parse("215.230.132.64"),
},
},
            new IPAddressinetArray1M
{
    Id = 34,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("17.187.67.70"),
System.Net.IPAddress.Parse("58.13.195.143"),
System.Net.IPAddress.Parse("232.56.206.141"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 12,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("115.117.197.72"),
System.Net.IPAddress.Parse("47.205.145.92"),
System.Net.IPAddress.Parse("121.195.70.74"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("195.224.186.194"),
System.Net.IPAddress.Parse("172.111.154.205"),
System.Net.IPAddress.Parse("132.80.25.212"),
System.Net.IPAddress.Parse("107.91.187.224"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 38,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("136.212.1.137"),
System.Net.IPAddress.Parse("150.2.160.151"),
System.Net.IPAddress.Parse("38.90.11.137"),
System.Net.IPAddress.Parse("148.133.204.141"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("105.156.205.131"),
System.Net.IPAddress.Parse("41.29.224.200"),
System.Net.IPAddress.Parse("124.89.122.47"),
System.Net.IPAddress.Parse("40.28.179.79"),
},
},
            new IPAddressinetArray1M
{
    Id = 39,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("86.60.140.24"),
System.Net.IPAddress.Parse("232.230.99.43"),
System.Net.IPAddress.Parse("0.38.136.90"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 19,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("58.173.198.184"),
System.Net.IPAddress.Parse("76.119.183.37"),
System.Net.IPAddress.Parse("113.236.186.114"),
System.Net.IPAddress.Parse("182.64.47.113"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("51.13.159.83"),
System.Net.IPAddress.Parse("89.127.145.213"),
System.Net.IPAddress.Parse("245.84.7.175"),
},
},
            new IPAddressinetArray1M
{
    Id = 40,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("248.114.216.254"),
System.Net.IPAddress.Parse("149.143.214.91"),
System.Net.IPAddress.Parse("113.34.26.95"),
System.Net.IPAddress.Parse("24.23.23.180"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 41,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("78.119.228.31"),
System.Net.IPAddress.Parse("135.40.42.155"),
System.Net.IPAddress.Parse("36.182.120.249"),
System.Net.IPAddress.Parse("123.139.141.137"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 26,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("157.85.10.91"),
System.Net.IPAddress.Parse("67.77.139.222"),
System.Net.IPAddress.Parse("11.240.10.171"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("6.218.161.169"),
System.Net.IPAddress.Parse("158.176.83.41"),
System.Net.IPAddress.Parse("76.120.242.118"),
System.Net.IPAddress.Parse("141.172.138.226"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("176.168.127.43"),
System.Net.IPAddress.Parse("19.31.203.71"),
System.Net.IPAddress.Parse("161.221.21.182"),
},
},
            new IPAddressinetArray1M
{
    Id = 48,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("240.72.252.46"),
System.Net.IPAddress.Parse("69.208.221.242"),
System.Net.IPAddress.Parse("193.112.4.107"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("206.206.137.244"),
System.Net.IPAddress.Parse("80.198.221.145"),
System.Net.IPAddress.Parse("232.66.213.90"),
},
},
            new IPAddressinetArray1M
{
    Id = 53,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("126.150.250.179"),
System.Net.IPAddress.Parse("215.197.26.244"),
System.Net.IPAddress.Parse("54.57.218.69"),
System.Net.IPAddress.Parse("84.206.54.251"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 35,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("177.175.146.210"),
System.Net.IPAddress.Parse("252.112.50.233"),
System.Net.IPAddress.Parse("194.7.46.61"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("12.48.241.10"),
System.Net.IPAddress.Parse("62.225.18.75"),
System.Net.IPAddress.Parse("187.245.47.113"),
System.Net.IPAddress.Parse("171.111.131.127"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 58,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("62.129.155.160"),
System.Net.IPAddress.Parse("236.14.118.244"),
System.Net.IPAddress.Parse("239.159.118.184"),
System.Net.IPAddress.Parse("131.169.154.24"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("240.117.66.183"),
System.Net.IPAddress.Parse("51.37.32.31"),
System.Net.IPAddress.Parse("75.169.224.111"),
},
},
            new IPAddressinetArray1M
{
    Id = 65,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("241.33.4.172"),
System.Net.IPAddress.Parse("174.65.93.236"),
System.Net.IPAddress.Parse("153.87.239.216"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 43,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("247.183.120.112"),
System.Net.IPAddress.Parse("170.202.233.120"),
System.Net.IPAddress.Parse("234.68.126.35"),
System.Net.IPAddress.Parse("68.74.169.150"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 71,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("218.94.164.154"),
System.Net.IPAddress.Parse("28.233.211.66"),
System.Net.IPAddress.Parse("230.20.136.84"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 77,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("90.128.249.245"),
System.Net.IPAddress.Parse("136.202.14.239"),
System.Net.IPAddress.Parse("239.169.193.208"),
System.Net.IPAddress.Parse("55.47.5.252"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 47,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("227.224.40.203"),
System.Net.IPAddress.Parse("189.209.195.132"),
System.Net.IPAddress.Parse("66.21.129.18"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("62.102.247.130"),
System.Net.IPAddress.Parse("250.205.69.51"),
System.Net.IPAddress.Parse("36.26.248.247"),
System.Net.IPAddress.Parse("200.25.250.140"),
},
},
            new IPAddressinetArray1M
{
    Id = 86,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("158.43.158.139"),
System.Net.IPAddress.Parse("93.177.6.181"),
System.Net.IPAddress.Parse("221.56.242.40"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("71.182.123.202"),
System.Net.IPAddress.Parse("42.242.78.187"),
System.Net.IPAddress.Parse("217.126.78.174"),
},
},
            new IPAddressinetArray1M
{
    Id = 88,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("33.64.48.109"),
System.Net.IPAddress.Parse("74.170.124.110"),
System.Net.IPAddress.Parse("74.220.3.119"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 48,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("45.114.204.69"),
System.Net.IPAddress.Parse("97.201.11.165"),
System.Net.IPAddress.Parse("228.83.231.53"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("122.64.166.236"),
System.Net.IPAddress.Parse("197.173.226.224"),
System.Net.IPAddress.Parse("16.208.232.21"),
System.Net.IPAddress.Parse("34.182.89.25"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 93,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("202.118.32.153"),
System.Net.IPAddress.Parse("117.211.246.117"),
System.Net.IPAddress.Parse("231.189.38.42"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("236.110.211.250"),
System.Net.IPAddress.Parse("2.250.244.217"),
System.Net.IPAddress.Parse("172.239.238.31"),
},
},
            new IPAddressinetArray1M
{
    Id = 102,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("148.228.169.30"),
System.Net.IPAddress.Parse("29.70.151.231"),
System.Net.IPAddress.Parse("136.62.233.148"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 49,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("6.184.209.206"),
System.Net.IPAddress.Parse("146.170.13.84"),
System.Net.IPAddress.Parse("124.11.241.88"),
System.Net.IPAddress.Parse("100.53.38.193"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("161.248.73.4"),
System.Net.IPAddress.Parse("252.12.192.127"),
System.Net.IPAddress.Parse("207.36.169.219"),
System.Net.IPAddress.Parse("248.134.49.58"),
},
},
            new IPAddressinetArray1M
{
    Id = 103,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("123.219.201.97"),
System.Net.IPAddress.Parse("215.60.152.16"),
System.Net.IPAddress.Parse("17.172.89.133"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 111,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("173.9.231.76"),
System.Net.IPAddress.Parse("59.27.36.35"),
System.Net.IPAddress.Parse("248.64.94.203"),
System.Net.IPAddress.Parse("5.37.174.26"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 53,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("55.116.158.174"),
System.Net.IPAddress.Parse("64.211.2.96"),
System.Net.IPAddress.Parse("252.111.150.32"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("253.251.200.228"),
System.Net.IPAddress.Parse("107.181.73.154"),
System.Net.IPAddress.Parse("189.234.134.107"),
System.Net.IPAddress.Parse("225.236.252.204"),
},
},
            new IPAddressinetArray1M
{
    Id = 113,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("89.45.164.79"),
System.Net.IPAddress.Parse("171.221.213.159"),
System.Net.IPAddress.Parse("218.230.174.84"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("93.70.71.123"),
System.Net.IPAddress.Parse("196.192.203.211"),
System.Net.IPAddress.Parse("156.165.42.122"),
},
},
            new IPAddressinetArray1M
{
    Id = 116,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("56.225.116.167"),
System.Net.IPAddress.Parse("143.168.131.12"),
System.Net.IPAddress.Parse("76.98.234.89"),
System.Net.IPAddress.Parse("238.14.29.104"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 55,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("47.199.21.45"),
System.Net.IPAddress.Parse("99.56.6.145"),
System.Net.IPAddress.Parse("199.127.194.111"),
System.Net.IPAddress.Parse("151.155.154.201"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 124,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("109.191.14.70"),
System.Net.IPAddress.Parse("55.179.135.236"),
System.Net.IPAddress.Parse("73.21.250.177"),
System.Net.IPAddress.Parse("12.160.9.152"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 129,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("183.49.31.231"),
System.Net.IPAddress.Parse("129.5.92.103"),
System.Net.IPAddress.Parse("143.63.116.253"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 58,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("49.35.100.248"),
System.Net.IPAddress.Parse("77.133.46.20"),
System.Net.IPAddress.Parse("73.216.2.164"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("145.84.250.236"),
System.Net.IPAddress.Parse("39.114.96.111"),
System.Net.IPAddress.Parse("81.9.134.124"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 132,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("0.47.43.36"),
System.Net.IPAddress.Parse("23.86.31.240"),
System.Net.IPAddress.Parse("23.57.119.43"),
System.Net.IPAddress.Parse("227.49.32.71"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 141,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("198.81.220.41"),
System.Net.IPAddress.Parse("202.27.60.197"),
System.Net.IPAddress.Parse("7.187.127.54"),
System.Net.IPAddress.Parse("91.215.198.197"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 62,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("225.98.48.8"),
System.Net.IPAddress.Parse("71.65.191.90"),
System.Net.IPAddress.Parse("216.173.112.54"),
System.Net.IPAddress.Parse("14.124.227.5"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 144,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("169.219.157.37"),
System.Net.IPAddress.Parse("101.17.37.86"),
System.Net.IPAddress.Parse("56.44.153.213"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 151,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("50.177.100.38"),
System.Net.IPAddress.Parse("156.232.147.253"),
System.Net.IPAddress.Parse("76.194.102.47"),
System.Net.IPAddress.Parse("90.167.9.239"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 69,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("199.30.176.91"),
System.Net.IPAddress.Parse("169.58.228.216"),
System.Net.IPAddress.Parse("54.114.208.43"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("26.180.79.32"),
System.Net.IPAddress.Parse("137.129.142.96"),
System.Net.IPAddress.Parse("103.9.49.147"),
System.Net.IPAddress.Parse("86.197.94.223"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 154,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("78.41.159.220"),
System.Net.IPAddress.Parse("122.209.118.12"),
System.Net.IPAddress.Parse("88.123.200.207"),
System.Net.IPAddress.Parse("15.4.171.102"),
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
System.Net.IPAddress.Parse("245.90.142.111"),
System.Net.IPAddress.Parse("74.140.200.36"),
System.Net.IPAddress.Parse("231.112.165.251"),
System.Net.IPAddress.Parse("46.104.233.100"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 77,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("205.139.83.235"),
System.Net.IPAddress.Parse("144.103.86.48"),
System.Net.IPAddress.Parse("250.8.101.205"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("225.29.216.92"),
System.Net.IPAddress.Parse("230.25.241.98"),
System.Net.IPAddress.Parse("191.42.45.187"),
System.Net.IPAddress.Parse("81.178.59.161"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 157,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("239.10.246.53"),
System.Net.IPAddress.Parse("203.36.65.130"),
System.Net.IPAddress.Parse("161.143.74.95"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 165,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("145.94.28.94"),
System.Net.IPAddress.Parse("94.186.201.3"),
System.Net.IPAddress.Parse("151.24.110.142"),
System.Net.IPAddress.Parse("116.164.18.128"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 86,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("149.40.163.74"),
System.Net.IPAddress.Parse("3.82.219.138"),
System.Net.IPAddress.Parse("155.4.105.166"),
System.Net.IPAddress.Parse("35.95.135.181"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 166,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("56.119.75.152"),
System.Net.IPAddress.Parse("172.202.250.204"),
System.Net.IPAddress.Parse("43.241.224.177"),
System.Net.IPAddress.Parse("13.66.210.202"),
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
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("74.113.156.244"),
System.Net.IPAddress.Parse("40.237.254.88"),
System.Net.IPAddress.Parse("215.230.132.64"),
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
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("105.156.205.131"),
System.Net.IPAddress.Parse("41.29.224.200"),
System.Net.IPAddress.Parse("124.89.122.47"),
System.Net.IPAddress.Parse("40.28.179.79"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("51.13.159.83"),
System.Net.IPAddress.Parse("89.127.145.213"),
System.Net.IPAddress.Parse("245.84.7.175"),
}));
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
                Assert.That(nullable, Is.Null);
                nullable =  ((IIPAddressArrayinetArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("176.168.127.43"),
System.Net.IPAddress.Parse("19.31.203.71"),
System.Net.IPAddress.Parse("161.221.21.182"),
}));
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
System.Net.IPAddress.Parse("206.206.137.244"),
System.Net.IPAddress.Parse("80.198.221.145"),
System.Net.IPAddress.Parse("232.66.213.90"),
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[34], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[34], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[34], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[24],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[25],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[26],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[27],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[28],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[29],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[30],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[31],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[34], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[34], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 4, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[34], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 157, query1, 144, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[34], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 141, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[34], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 13, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 48, query1, 41, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[24],_testData[34], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 41, query1, 151, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 34, query1, 111, query2))
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
                 ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 28, query1, 103, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 48, 21))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[4], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[5], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[6], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[7], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[8], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[9], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[10], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[24],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[25],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[26],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[27],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[28],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[29],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[30],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatch(connection, 113, 48))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[11], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[12], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[13], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[14], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[20],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[21],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[22],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[23],_testData[34], false);
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
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 38);
                var models = await ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 93);
                var models =  ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

