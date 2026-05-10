

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
    Id = 3,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("136.109.16.249"),
System.Net.IPAddress.Parse("142.2.60.159"),
System.Net.IPAddress.Parse("217.245.129.88"),
System.Net.IPAddress.Parse("99.50.208.170"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 6,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("223.88.144.248"),
System.Net.IPAddress.Parse("151.89.216.103"),
System.Net.IPAddress.Parse("154.101.4.21"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 9,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("13.135.55.76"),
System.Net.IPAddress.Parse("98.20.245.10"),
System.Net.IPAddress.Parse("171.5.173.13"),
System.Net.IPAddress.Parse("73.102.119.196"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("92.207.110.124"),
System.Net.IPAddress.Parse("58.186.198.197"),
System.Net.IPAddress.Parse("224.218.120.55"),
},
},
            new IPAddressinetArray1M
{
    Id = 10,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("118.93.173.10"),
System.Net.IPAddress.Parse("12.14.80.60"),
System.Net.IPAddress.Parse("152.198.196.17"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 17,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("201.96.226.13"),
System.Net.IPAddress.Parse("77.84.111.248"),
System.Net.IPAddress.Parse("162.162.188.167"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 18,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("121.235.71.143"),
System.Net.IPAddress.Parse("200.132.170.236"),
System.Net.IPAddress.Parse("181.194.187.84"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("33.2.207.135"),
System.Net.IPAddress.Parse("91.145.106.96"),
System.Net.IPAddress.Parse("92.242.127.185"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("33.248.89.97"),
System.Net.IPAddress.Parse("146.145.90.105"),
System.Net.IPAddress.Parse("91.176.213.94"),
},
},
            new IPAddressinetArray1M
{
    Id = 23,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("190.223.74.12"),
System.Net.IPAddress.Parse("21.74.99.145"),
System.Net.IPAddress.Parse("173.91.137.11"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("49.18.121.197"),
System.Net.IPAddress.Parse("32.227.228.43"),
System.Net.IPAddress.Parse("238.222.227.192"),
System.Net.IPAddress.Parse("205.109.27.111"),
},
},
            new IPAddressinetArray1M
{
    Id = 30,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("168.251.39.168"),
System.Net.IPAddress.Parse("130.204.174.227"),
System.Net.IPAddress.Parse("135.205.48.146"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 21,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("195.108.176.88"),
System.Net.IPAddress.Parse("87.130.151.204"),
System.Net.IPAddress.Parse("64.209.197.3"),
System.Net.IPAddress.Parse("18.2.171.91"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("46.67.121.5"),
System.Net.IPAddress.Parse("210.130.228.91"),
System.Net.IPAddress.Parse("159.143.110.106"),
},
},
            new IPAddressinetArray1M
{
    Id = 37,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("249.137.51.177"),
System.Net.IPAddress.Parse("0.119.200.203"),
System.Net.IPAddress.Parse("40.216.97.157"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("133.210.61.120"),
System.Net.IPAddress.Parse("209.108.114.25"),
System.Net.IPAddress.Parse("105.176.13.170"),
},
},
            new IPAddressinetArray1M
{
    Id = 43,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("250.162.4.249"),
System.Net.IPAddress.Parse("161.198.9.136"),
System.Net.IPAddress.Parse("198.185.86.110"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 28,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("133.24.109.241"),
System.Net.IPAddress.Parse("156.222.132.193"),
System.Net.IPAddress.Parse("229.144.54.111"),
System.Net.IPAddress.Parse("71.156.241.81"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("242.127.68.228"),
System.Net.IPAddress.Parse("48.128.31.81"),
System.Net.IPAddress.Parse("199.120.251.120"),
System.Net.IPAddress.Parse("248.64.24.218"),
},
},
            new IPAddressinetArray1M
{
    Id = 44,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("105.166.56.46"),
System.Net.IPAddress.Parse("242.135.175.112"),
System.Net.IPAddress.Parse("49.12.12.177"),
System.Net.IPAddress.Parse("104.234.237.127"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 46,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("114.99.145.11"),
System.Net.IPAddress.Parse("38.247.4.225"),
System.Net.IPAddress.Parse("121.82.24.130"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 36,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("222.145.248.132"),
System.Net.IPAddress.Parse("181.47.15.85"),
System.Net.IPAddress.Parse("228.167.32.66"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("74.217.26.108"),
System.Net.IPAddress.Parse("183.116.23.179"),
System.Net.IPAddress.Parse("162.140.64.97"),
},
},
            new IPAddressinetArray1M
{
    Id = 50,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("34.32.243.188"),
System.Net.IPAddress.Parse("73.229.153.104"),
System.Net.IPAddress.Parse("47.223.195.168"),
System.Net.IPAddress.Parse("36.90.56.100"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 55,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("239.53.4.141"),
System.Net.IPAddress.Parse("129.199.132.126"),
System.Net.IPAddress.Parse("144.58.123.188"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 44,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("13.105.113.251"),
System.Net.IPAddress.Parse("187.231.226.202"),
System.Net.IPAddress.Parse("251.242.130.108"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 63,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("75.211.236.82"),
System.Net.IPAddress.Parse("5.243.34.184"),
System.Net.IPAddress.Parse("193.28.219.185"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("217.173.105.218"),
System.Net.IPAddress.Parse("49.44.189.155"),
System.Net.IPAddress.Parse("22.23.134.232"),
System.Net.IPAddress.Parse("213.237.66.186"),
},
},
            new IPAddressinetArray1M
{
    Id = 65,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("51.39.6.45"),
System.Net.IPAddress.Parse("76.209.50.241"),
System.Net.IPAddress.Parse("133.79.242.41"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 53,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("42.43.124.59"),
System.Net.IPAddress.Parse("146.23.238.111"),
System.Net.IPAddress.Parse("45.229.241.36"),
System.Net.IPAddress.Parse("159.212.112.239"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 72,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("210.57.37.85"),
System.Net.IPAddress.Parse("31.229.142.81"),
System.Net.IPAddress.Parse("155.148.117.55"),
System.Net.IPAddress.Parse("133.189.99.122"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 81,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("93.154.20.109"),
System.Net.IPAddress.Parse("213.77.221.17"),
System.Net.IPAddress.Parse("184.50.211.208"),
System.Net.IPAddress.Parse("151.248.197.40"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 57,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.16.32.0"),
System.Net.IPAddress.Parse("70.155.224.212"),
System.Net.IPAddress.Parse("110.23.5.98"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 87,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("96.5.75.96"),
System.Net.IPAddress.Parse("31.44.0.220"),
System.Net.IPAddress.Parse("242.248.157.27"),
System.Net.IPAddress.Parse("223.250.127.208"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 95,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("102.106.214.210"),
System.Net.IPAddress.Parse("66.172.167.124"),
System.Net.IPAddress.Parse("89.193.145.121"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 61,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("130.231.53.63"),
System.Net.IPAddress.Parse("115.164.197.156"),
System.Net.IPAddress.Parse("188.187.225.36"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("20.142.57.207"),
System.Net.IPAddress.Parse("137.19.242.74"),
System.Net.IPAddress.Parse("2.183.250.25"),
System.Net.IPAddress.Parse("131.178.99.232"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("244.45.214.212"),
System.Net.IPAddress.Parse("43.96.68.50"),
System.Net.IPAddress.Parse("60.243.61.167"),
},
},
            new IPAddressinetArray1M
{
    Id = 102,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("81.246.230.10"),
System.Net.IPAddress.Parse("5.100.8.49"),
System.Net.IPAddress.Parse("254.250.253.104"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("233.90.172.194"),
System.Net.IPAddress.Parse("50.170.250.16"),
System.Net.IPAddress.Parse("215.130.94.132"),
},
},
            new IPAddressinetArray1M
{
    Id = 104,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("68.227.4.57"),
System.Net.IPAddress.Parse("182.117.45.48"),
System.Net.IPAddress.Parse("79.20.106.159"),
System.Net.IPAddress.Parse("163.113.200.156"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 64,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("47.157.169.184"),
System.Net.IPAddress.Parse("81.24.75.149"),
System.Net.IPAddress.Parse("207.124.243.14"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 106,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("19.224.73.117"),
System.Net.IPAddress.Parse("47.243.68.250"),
System.Net.IPAddress.Parse("147.131.15.146"),
System.Net.IPAddress.Parse("102.57.86.182"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("138.247.26.133"),
System.Net.IPAddress.Parse("248.75.119.79"),
System.Net.IPAddress.Parse("5.148.8.183"),
System.Net.IPAddress.Parse("198.162.121.252"),
},
},
            new IPAddressinetArray1M
{
    Id = 113,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("243.209.242.184"),
System.Net.IPAddress.Parse("251.65.201.104"),
System.Net.IPAddress.Parse("139.210.89.237"),
System.Net.IPAddress.Parse("118.132.44.208"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 72,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("87.168.120.227"),
System.Net.IPAddress.Parse("231.41.52.9"),
System.Net.IPAddress.Parse("251.177.65.12"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("170.205.28.104"),
System.Net.IPAddress.Parse("30.95.189.64"),
System.Net.IPAddress.Parse("154.6.222.208"),
System.Net.IPAddress.Parse("24.208.44.229"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 122,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("65.100.237.212"),
System.Net.IPAddress.Parse("66.24.133.207"),
System.Net.IPAddress.Parse("250.194.111.62"),
System.Net.IPAddress.Parse("51.157.33.134"),
},
    ModelInner = null,
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("11.224.10.51"),
System.Net.IPAddress.Parse("13.193.75.145"),
System.Net.IPAddress.Parse("49.19.83.135"),
System.Net.IPAddress.Parse("84.224.215.54"),
},
},
            new IPAddressinetArray1M
{
    Id = 129,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("136.207.116.221"),
System.Net.IPAddress.Parse("27.223.110.158"),
System.Net.IPAddress.Parse("195.34.62.221"),
System.Net.IPAddress.Parse("47.13.188.226"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 76,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("134.168.88.99"),
System.Net.IPAddress.Parse("68.140.219.128"),
System.Net.IPAddress.Parse("58.76.35.2"),
System.Net.IPAddress.Parse("253.186.120.25"),
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("107.200.182.20"),
System.Net.IPAddress.Parse("236.100.104.40"),
System.Net.IPAddress.Parse("225.102.109.95"),
System.Net.IPAddress.Parse("119.72.52.63"),
},
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("43.182.97.234"),
System.Net.IPAddress.Parse("16.174.220.238"),
System.Net.IPAddress.Parse("89.95.12.230"),
},
},
            new IPAddressinetArray1M
{
    Id = 131,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("215.108.237.228"),
System.Net.IPAddress.Parse("38.50.49.117"),
System.Net.IPAddress.Parse("71.87.186.215"),
System.Net.IPAddress.Parse("179.2.188.73"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 138,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("20.224.87.95"),
System.Net.IPAddress.Parse("98.247.63.215"),
System.Net.IPAddress.Parse("65.237.6.136"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 81,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("62.92.225.33"),
System.Net.IPAddress.Parse("149.41.177.250"),
System.Net.IPAddress.Parse("239.81.149.61"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("65.84.63.208"),
System.Net.IPAddress.Parse("154.171.234.149"),
System.Net.IPAddress.Parse("188.111.159.74"),
},
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 147,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("144.251.96.214"),
System.Net.IPAddress.Parse("188.75.111.3"),
System.Net.IPAddress.Parse("240.119.220.34"),
System.Net.IPAddress.Parse("254.118.180.229"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 150,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("1.59.158.84"),
System.Net.IPAddress.Parse("100.152.80.190"),
System.Net.IPAddress.Parse("134.252.130.149"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 87,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("35.113.241.66"),
System.Net.IPAddress.Parse("116.24.55.7"),
System.Net.IPAddress.Parse("52.193.10.61"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("11.8.107.168"),
System.Net.IPAddress.Parse("196.47.216.57"),
System.Net.IPAddress.Parse("166.109.210.67"),
System.Net.IPAddress.Parse("33.67.13.175"),
},
},
            new IPAddressinetArray1M
{
    Id = 153,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("99.152.139.3"),
System.Net.IPAddress.Parse("1.151.205.4"),
System.Net.IPAddress.Parse("8.168.107.7"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 160,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("231.144.211.65"),
System.Net.IPAddress.Parse("236.231.21.84"),
System.Net.IPAddress.Parse("5.158.181.190"),
System.Net.IPAddress.Parse("34.116.93.110"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 91,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("226.227.188.119"),
System.Net.IPAddress.Parse("253.242.0.128"),
System.Net.IPAddress.Parse("4.253.100.213"),
},
    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("173.23.142.213"),
System.Net.IPAddress.Parse("153.253.232.63"),
System.Net.IPAddress.Parse("4.194.210.147"),
},
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("206.87.33.211"),
System.Net.IPAddress.Parse("87.110.2.105"),
System.Net.IPAddress.Parse("214.34.199.82"),
System.Net.IPAddress.Parse("75.127.16.206"),
},
},
            new IPAddressinetArray1M
{
    Id = 168,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("114.247.47.201"),
System.Net.IPAddress.Parse("89.10.59.119"),
System.Net.IPAddress.Parse("40.104.189.57"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 177,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("133.236.154.231"),
System.Net.IPAddress.Parse("194.189.37.154"),
System.Net.IPAddress.Parse("202.103.177.100"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 95,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("75.73.147.93"),
System.Net.IPAddress.Parse("144.36.230.53"),
System.Net.IPAddress.Parse("200.195.122.78"),
System.Net.IPAddress.Parse("182.81.208.251"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 183,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("109.105.129.24"),
System.Net.IPAddress.Parse("89.123.156.2"),
System.Net.IPAddress.Parse("43.189.31.136"),
System.Net.IPAddress.Parse("217.3.237.90"),
},
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetArray1M
{
    Id = 191,
    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.65.27.206"),
System.Net.IPAddress.Parse("191.105.249.168"),
System.Net.IPAddress.Parse("112.25.35.109"),
System.Net.IPAddress.Parse("103.62.58.246"),
},
    ModelInner = new IPAddressinetArray1MI
{
    Id = 101,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("30.18.161.40"),
System.Net.IPAddress.Parse("173.114.94.126"),
System.Net.IPAddress.Parse("137.169.64.108"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("186.57.26.81"),
System.Net.IPAddress.Parse("4.246.6.101"),
System.Net.IPAddress.Parse("43.202.211.110"),
System.Net.IPAddress.Parse("42.47.211.24"),
},
},
            new IPAddressinetArray1M
{
    Id = 196,
    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("80.23.96.203"),
System.Net.IPAddress.Parse("178.147.30.211"),
System.Net.IPAddress.Parse("8.125.147.88"),
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
System.Net.IPAddress.Parse("49.18.121.197"),
System.Net.IPAddress.Parse("32.227.228.43"),
System.Net.IPAddress.Parse("238.222.227.192"),
System.Net.IPAddress.Parse("205.109.27.111"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("46.67.121.5"),
System.Net.IPAddress.Parse("210.130.228.91"),
System.Net.IPAddress.Parse("159.143.110.106"),
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
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("133.210.61.120"),
System.Net.IPAddress.Parse("209.108.114.25"),
System.Net.IPAddress.Parse("105.176.13.170"),
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
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("242.127.68.228"),
System.Net.IPAddress.Parse("48.128.31.81"),
System.Net.IPAddress.Parse("199.120.251.120"),
System.Net.IPAddress.Parse("248.64.24.218"),
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
System.Net.IPAddress.Parse("74.217.26.108"),
System.Net.IPAddress.Parse("183.116.23.179"),
System.Net.IPAddress.Parse("162.140.64.97"),
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
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[34], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[24],_testData[34], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[4], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[5], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[24],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[25],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[26],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[27],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[28],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[29],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 168;
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems2[17],_testData[34], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[15], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[16], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[17], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[18], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[19], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[20], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[21], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[22], false);
                        IPAddressinetArray1M.AssertModel(models[8],_testData[23], false);
                        IPAddressinetArray1M.AssertModel(models[9],_testData[24], false);
                        IPAddressinetArray1M.AssertModel(models[10],_testData[25], false);
                        IPAddressinetArray1M.AssertModel(models[11],_testData[26], false);
                        IPAddressinetArray1M.AssertModel(models[12],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[13],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[14],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[15],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[16],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[17],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[18],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr2.Value = 168;
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[34], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 106, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[34], false);
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
                await ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 23, query1, 153, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                 ((IIPAddressArrayinetArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 46, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems2[24],_testData[34], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 72, query1, 183, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(secondItems1[1],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 55, query1, 95, query2))
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
                await ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 113, query1, 153, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 65, query1, 37, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatIPAddressinetArray1M.AssertModel(models[0],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(models[1],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(models[2],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(models[3],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(models[4],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(models[5],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(models[6],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(models[7],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(models[8],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(models[9],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(models[10],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(models[11],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(models[12],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(models[13],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(models[14],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(models[15],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(models[16],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(models[17],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(models[18],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(models[19],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(models[20],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(models[21],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(models[22],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(models[23],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(models[24],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(models[25],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(models[26],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(models[27],_testData[34], false);
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
                 ((IIPAddressArrayinetArray)this).DbConnectionDynQuerySelectModelBatch(connection, 30, query1, 177, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatIPAddressinetArray1M.AssertModel(firstItems1[28],_testData[34], false);
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
                foreach(var batchResult in await ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatchAsync(connection, 106, 147))
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[27], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[28], false);
                        IPAddressinetArray1M.AssertModel(models[2],_testData[29], false);
                        IPAddressinetArray1M.AssertModel(models[3],_testData[30], false);
                        IPAddressinetArray1M.AssertModel(models[4],_testData[31], false);
                        IPAddressinetArray1M.AssertModel(models[5],_testData[32], false);
                        IPAddressinetArray1M.AssertModel(models[6],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[7],_testData[34], false);
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
                foreach(var batchResult in  ((IIPAddressArrayinetArray)this).DbConnectionSTSelectModelBatch(connection, 183, 102))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        IPAddressinetArray1M.AssertModel(models[0],_testData[33], false);
                        IPAddressinetArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 46);
                var models = await ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 104);
                var models =  ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

