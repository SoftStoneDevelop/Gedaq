

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
    internal partial interface IIPAddressSingleTypeIPv4
    {
    }
    
    internal partial class IPAddressSingleTypeIPv4 : IIPAddressSingleTypeIPv4
    {


#region TestData

        private readonly IPAddressIPv40M[] _testData = new IPAddressIPv40M[]
        {
            new IPAddressIPv40M
{
    Id = 6,
    Value = System.Net.IPAddress.Parse("201.32.207.202"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 8,
    Value = System.Net.IPAddress.Parse("167.125.119.194"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("150.39.146.90"),
},
            new IPAddressIPv40M
{
    Id = 10,
    Value = System.Net.IPAddress.Parse("129.30.62.79"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 10,
    Value = System.Net.IPAddress.Parse("196.173.145.63"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 19,
    Value = System.Net.IPAddress.Parse("252.187.209.160"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 18,
    Value = System.Net.IPAddress.Parse("0.70.35.231"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("131.200.238.37"),
},
            new IPAddressIPv40M
{
    Id = 27,
    Value = System.Net.IPAddress.Parse("80.179.52.107"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 24,
    Value = System.Net.IPAddress.Parse("229.17.138.155"),
    NullableValue = System.Net.IPAddress.Parse("126.203.19.6"),
},
    NullableValue = System.Net.IPAddress.Parse("108.38.112.146"),
},
            new IPAddressIPv40M
{
    Id = 30,
    Value = System.Net.IPAddress.Parse("167.37.149.170"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 29,
    Value = System.Net.IPAddress.Parse("56.79.30.212"),
    NullableValue = System.Net.IPAddress.Parse("6.6.176.180"),
},
    NullableValue = System.Net.IPAddress.Parse("30.154.84.27"),
},
            new IPAddressIPv40M
{
    Id = 35,
    Value = System.Net.IPAddress.Parse("194.43.240.234"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 30,
    Value = System.Net.IPAddress.Parse("187.232.17.89"),
    NullableValue = System.Net.IPAddress.Parse("191.201.151.59"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 41,
    Value = System.Net.IPAddress.Parse("53.59.157.3"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 33,
    Value = System.Net.IPAddress.Parse("50.252.242.98"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 49,
    Value = System.Net.IPAddress.Parse("110.11.61.16"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 35,
    Value = System.Net.IPAddress.Parse("94.242.249.80"),
    NullableValue = System.Net.IPAddress.Parse("179.83.20.29"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 52,
    Value = System.Net.IPAddress.Parse("236.234.235.80"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 44,
    Value = System.Net.IPAddress.Parse("26.186.233.110"),
    NullableValue = System.Net.IPAddress.Parse("207.143.186.58"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 55,
    Value = System.Net.IPAddress.Parse("161.41.26.178"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 51,
    Value = System.Net.IPAddress.Parse("13.167.30.56"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("174.122.108.132"),
},
            new IPAddressIPv40M
{
    Id = 61,
    Value = System.Net.IPAddress.Parse("133.137.142.236"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 52,
    Value = System.Net.IPAddress.Parse("232.233.186.138"),
    NullableValue = System.Net.IPAddress.Parse("113.147.12.229"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 70,
    Value = System.Net.IPAddress.Parse("57.21.116.224"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 56,
    Value = System.Net.IPAddress.Parse("74.108.2.190"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("12.95.160.82"),
},
            new IPAddressIPv40M
{
    Id = 76,
    Value = System.Net.IPAddress.Parse("64.25.11.229"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 63,
    Value = System.Net.IPAddress.Parse("179.205.112.84"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 83,
    Value = System.Net.IPAddress.Parse("177.22.84.142"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 68,
    Value = System.Net.IPAddress.Parse("216.105.215.16"),
    NullableValue = System.Net.IPAddress.Parse("93.191.89.78"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 86,
    Value = System.Net.IPAddress.Parse("68.231.6.29"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 70,
    Value = System.Net.IPAddress.Parse("151.42.67.47"),
    NullableValue = System.Net.IPAddress.Parse("54.153.179.160"),
},
    NullableValue = System.Net.IPAddress.Parse("193.177.83.93"),
},
            new IPAddressIPv40M
{
    Id = 91,
    Value = System.Net.IPAddress.Parse("172.102.24.197"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 72,
    Value = System.Net.IPAddress.Parse("100.19.169.183"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("54.65.67.225"),
},
            new IPAddressIPv40M
{
    Id = 95,
    Value = System.Net.IPAddress.Parse("59.72.101.189"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 81,
    Value = System.Net.IPAddress.Parse("229.114.139.66"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 101,
    Value = System.Net.IPAddress.Parse("94.56.248.3"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 89,
    Value = System.Net.IPAddress.Parse("130.206.166.87"),
    NullableValue = System.Net.IPAddress.Parse("224.232.225.3"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 108,
    Value = System.Net.IPAddress.Parse("222.70.147.183"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 90,
    Value = System.Net.IPAddress.Parse("17.72.200.79"),
    NullableValue = System.Net.IPAddress.Parse("155.172.136.113"),
},
    NullableValue = System.Net.IPAddress.Parse("211.227.6.226"),
},
            new IPAddressIPv40M
{
    Id = 114,
    Value = System.Net.IPAddress.Parse("20.169.240.0"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 98,
    Value = System.Net.IPAddress.Parse("210.91.173.86"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("137.65.5.185"),
},
            new IPAddressIPv40M
{
    Id = 121,
    Value = System.Net.IPAddress.Parse("76.252.21.140"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 106,
    Value = System.Net.IPAddress.Parse("62.150.240.26"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("225.77.128.21"),
},
            new IPAddressIPv40M
{
    Id = 128,
    Value = System.Net.IPAddress.Parse("240.247.182.121"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 111,
    Value = System.Net.IPAddress.Parse("250.163.250.121"),
    NullableValue = System.Net.IPAddress.Parse("74.11.98.187"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 132,
    Value = System.Net.IPAddress.Parse("31.174.34.126"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 116,
    Value = System.Net.IPAddress.Parse("122.7.103.65"),
    NullableValue = System.Net.IPAddress.Parse("151.34.205.245"),
},
    NullableValue = System.Net.IPAddress.Parse("113.236.132.99"),
},
            new IPAddressIPv40M
{
    Id = 141,
    Value = System.Net.IPAddress.Parse("165.236.206.157"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 118,
    Value = System.Net.IPAddress.Parse("112.179.231.71"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 147,
    Value = System.Net.IPAddress.Parse("23.88.163.236"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 119,
    Value = System.Net.IPAddress.Parse("194.142.57.59"),
    NullableValue = System.Net.IPAddress.Parse("30.190.153.60"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 148,
    Value = System.Net.IPAddress.Parse("3.202.171.104"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 127,
    Value = System.Net.IPAddress.Parse("26.138.2.246"),
    NullableValue = System.Net.IPAddress.Parse("56.100.196.253"),
},
    NullableValue = System.Net.IPAddress.Parse("44.3.123.243"),
},
            new IPAddressIPv40M
{
    Id = 150,
    Value = System.Net.IPAddress.Parse("252.20.201.193"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 136,
    Value = System.Net.IPAddress.Parse("75.171.25.91"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("32.242.53.190"),
},
            new IPAddressIPv40M
{
    Id = 151,
    Value = System.Net.IPAddress.Parse("60.22.11.178"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 141,
    Value = System.Net.IPAddress.Parse("233.244.168.167"),
    NullableValue = System.Net.IPAddress.Parse("68.33.170.229"),
},
    NullableValue = System.Net.IPAddress.Parse("251.172.234.211"),
},
            new IPAddressIPv40M
{
    Id = 160,
    Value = System.Net.IPAddress.Parse("97.224.4.173"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 146,
    Value = System.Net.IPAddress.Parse("180.171.148.204"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 167,
    Value = System.Net.IPAddress.Parse("221.159.236.7"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 151,
    Value = System.Net.IPAddress.Parse("140.209.105.30"),
    NullableValue = System.Net.IPAddress.Parse("52.16.21.153"),
},
    NullableValue = System.Net.IPAddress.Parse("57.51.179.216"),
},
            new IPAddressIPv40M
{
    Id = 170,
    Value = System.Net.IPAddress.Parse("127.140.149.239"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 154,
    Value = System.Net.IPAddress.Parse("34.68.207.43"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("145.163.143.250"),
},
            new IPAddressIPv40M
{
    Id = 175,
    Value = System.Net.IPAddress.Parse("206.74.13.81"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 158,
    Value = System.Net.IPAddress.Parse("109.18.27.22"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 180,
    Value = System.Net.IPAddress.Parse("33.10.176.27"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 159,
    Value = System.Net.IPAddress.Parse("62.28.161.89"),
    NullableValue = System.Net.IPAddress.Parse("209.151.243.180"),
},
    NullableValue = System.Net.IPAddress.Parse("186.98.80.146"),
},
            new IPAddressIPv40M
{
    Id = 182,
    Value = System.Net.IPAddress.Parse("115.214.7.236"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 162,
    Value = System.Net.IPAddress.Parse("132.78.203.31"),
    NullableValue = System.Net.IPAddress.Parse("238.97.170.235"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 187,
    Value = System.Net.IPAddress.Parse("145.216.211.88"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 167,
    Value = System.Net.IPAddress.Parse("97.96.9.156"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("171.89.199.221"),
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.ipaddressipv40m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:IPv4}, 
    {mi_id:Int32},
    {mi_value:IPv4}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeIPv4)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress), 
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
                    await ((IIPAddressSingleTypeIPv4)this).InsertModelDbConnectionAsync(
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
                     ((IIPAddressSingleTypeIPv4)this).InsertModelDbConnection(
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
FROM gedaqtests.ipaddressipv40m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(IPAddressIPv40M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeIPv4)),
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
                    var models = await ((IIPAddressSingleTypeIPv4)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    IPAddressIPv40M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IIPAddressSingleTypeIPv4)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    IPAddressIPv40M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

