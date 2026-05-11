

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

        private readonly IPAddressIPv4E0M[] _testData = new IPAddressIPv4E0M[]
        {
            new IPAddressIPv4E0M
{
    Id = 7,
    Value = System.Net.IPAddress.Parse("212.193.28.130"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 6,
    Value = System.Net.IPAddress.Parse("214.75.218.205"),
    NullableValue = System.Net.IPAddress.Parse("171.151.250.148"),
},
    NullableValue = System.Net.IPAddress.Parse("20.132.191.102"),
},
            new IPAddressIPv4E0M
{
    Id = 13,
    Value = System.Net.IPAddress.Parse("4.112.82.140"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 11,
    Value = System.Net.IPAddress.Parse("12.17.197.124"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("141.192.104.66"),
},
            new IPAddressIPv4E0M
{
    Id = 18,
    Value = System.Net.IPAddress.Parse("65.102.235.121"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 14,
    Value = System.Net.IPAddress.Parse("235.77.202.99"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 25,
    Value = System.Net.IPAddress.Parse("220.229.18.229"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 22,
    Value = System.Net.IPAddress.Parse("122.33.136.122"),
    NullableValue = System.Net.IPAddress.Parse("107.226.21.204"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 29,
    Value = System.Net.IPAddress.Parse("50.156.94.30"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 27,
    Value = System.Net.IPAddress.Parse("219.69.151.180"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 30,
    Value = System.Net.IPAddress.Parse("49.87.19.253"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 29,
    Value = System.Net.IPAddress.Parse("116.5.87.23"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("120.228.150.44"),
},
            new IPAddressIPv4E0M
{
    Id = 38,
    Value = System.Net.IPAddress.Parse("22.37.175.129"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 32,
    Value = System.Net.IPAddress.Parse("13.229.220.230"),
    NullableValue = System.Net.IPAddress.Parse("127.119.101.16"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 43,
    Value = System.Net.IPAddress.Parse("235.154.136.150"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 34,
    Value = System.Net.IPAddress.Parse("197.225.235.108"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("46.174.253.188"),
},
            new IPAddressIPv4E0M
{
    Id = 47,
    Value = System.Net.IPAddress.Parse("132.231.233.142"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 39,
    Value = System.Net.IPAddress.Parse("42.158.37.167"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("222.182.200.87"),
},
            new IPAddressIPv4E0M
{
    Id = 50,
    Value = System.Net.IPAddress.Parse("248.218.133.203"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 46,
    Value = System.Net.IPAddress.Parse("178.228.243.156"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("37.197.10.170"),
},
            new IPAddressIPv4E0M
{
    Id = 52,
    Value = System.Net.IPAddress.Parse("119.42.62.6"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 51,
    Value = System.Net.IPAddress.Parse("205.139.52.81"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 61,
    Value = System.Net.IPAddress.Parse("243.161.143.189"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 60,
    Value = System.Net.IPAddress.Parse("90.98.179.161"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("189.214.213.70"),
},
            new IPAddressIPv4E0M
{
    Id = 64,
    Value = System.Net.IPAddress.Parse("5.81.184.96"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 61,
    Value = System.Net.IPAddress.Parse("250.157.166.199"),
    NullableValue = System.Net.IPAddress.Parse("193.151.110.211"),
},
    NullableValue = System.Net.IPAddress.Parse("235.11.95.115"),
},
            new IPAddressIPv4E0M
{
    Id = 72,
    Value = System.Net.IPAddress.Parse("207.32.8.156"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 67,
    Value = System.Net.IPAddress.Parse("142.224.146.32"),
    NullableValue = System.Net.IPAddress.Parse("75.45.111.82"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 73,
    Value = System.Net.IPAddress.Parse("28.98.94.131"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 72,
    Value = System.Net.IPAddress.Parse("236.37.90.226"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("155.177.154.40"),
},
            new IPAddressIPv4E0M
{
    Id = 81,
    Value = System.Net.IPAddress.Parse("71.159.120.163"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 81,
    Value = System.Net.IPAddress.Parse("116.156.18.227"),
    NullableValue = System.Net.IPAddress.Parse("113.103.240.197"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 85,
    Value = System.Net.IPAddress.Parse("203.162.1.85"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 86,
    Value = System.Net.IPAddress.Parse("148.165.10.228"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 86,
    Value = System.Net.IPAddress.Parse("123.246.156.181"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 88,
    Value = System.Net.IPAddress.Parse("61.157.153.202"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 92,
    Value = System.Net.IPAddress.Parse("213.3.79.152"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 97,
    Value = System.Net.IPAddress.Parse("33.125.97.162"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 93,
    Value = System.Net.IPAddress.Parse("208.237.163.210"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 98,
    Value = System.Net.IPAddress.Parse("90.204.174.24"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("76.12.92.132"),
},
            new IPAddressIPv4E0M
{
    Id = 94,
    Value = System.Net.IPAddress.Parse("219.40.45.85"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 101,
    Value = System.Net.IPAddress.Parse("100.156.199.235"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("192.39.44.88"),
},
            new IPAddressIPv4E0M
{
    Id = 99,
    Value = System.Net.IPAddress.Parse("191.78.224.43"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 109,
    Value = System.Net.IPAddress.Parse("68.15.24.208"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("204.167.54.122"),
},
            new IPAddressIPv4E0M
{
    Id = 107,
    Value = System.Net.IPAddress.Parse("151.125.133.212"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 118,
    Value = System.Net.IPAddress.Parse("189.73.220.161"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 114,
    Value = System.Net.IPAddress.Parse("80.249.174.177"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 123,
    Value = System.Net.IPAddress.Parse("91.194.94.10"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("245.47.61.15"),
},
            new IPAddressIPv4E0M
{
    Id = 117,
    Value = System.Net.IPAddress.Parse("139.221.184.144"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 128,
    Value = System.Net.IPAddress.Parse("5.24.229.87"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 123,
    Value = System.Net.IPAddress.Parse("145.76.58.59"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 132,
    Value = System.Net.IPAddress.Parse("198.13.209.165"),
    NullableValue = System.Net.IPAddress.Parse("205.190.132.157"),
},
    NullableValue = System.Net.IPAddress.Parse("243.61.24.95"),
},
            new IPAddressIPv4E0M
{
    Id = 128,
    Value = System.Net.IPAddress.Parse("54.12.185.251"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 137,
    Value = System.Net.IPAddress.Parse("168.114.82.248"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("184.201.56.30"),
},
            new IPAddressIPv4E0M
{
    Id = 132,
    Value = System.Net.IPAddress.Parse("203.138.32.144"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 140,
    Value = System.Net.IPAddress.Parse("184.100.112.84"),
    NullableValue = System.Net.IPAddress.Parse("216.59.181.225"),
},
    NullableValue = System.Net.IPAddress.Parse("164.80.14.102"),
},
            new IPAddressIPv4E0M
{
    Id = 136,
    Value = System.Net.IPAddress.Parse("178.22.141.172"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 148,
    Value = System.Net.IPAddress.Parse("233.226.72.162"),
    NullableValue = System.Net.IPAddress.Parse("147.38.252.32"),
},
    NullableValue = System.Net.IPAddress.Parse("207.186.252.194"),
},
            new IPAddressIPv4E0M
{
    Id = 144,
    Value = System.Net.IPAddress.Parse("57.198.103.50"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 152,
    Value = System.Net.IPAddress.Parse("236.6.216.29"),
    NullableValue = System.Net.IPAddress.Parse("153.236.210.168"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 149,
    Value = System.Net.IPAddress.Parse("186.152.189.216"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 159,
    Value = System.Net.IPAddress.Parse("116.108.164.109"),
    NullableValue = System.Net.IPAddress.Parse("247.180.154.88"),
},
    NullableValue = System.Net.IPAddress.Parse("3.207.41.61"),
},
            new IPAddressIPv4E0M
{
    Id = 150,
    Value = System.Net.IPAddress.Parse("202.108.57.24"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 165,
    Value = System.Net.IPAddress.Parse("164.172.243.204"),
    NullableValue = System.Net.IPAddress.Parse("71.100.77.247"),
},
    NullableValue = System.Net.IPAddress.Parse("183.214.129.133"),
},
            new IPAddressIPv4E0M
{
    Id = 158,
    Value = System.Net.IPAddress.Parse("151.8.72.147"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 166,
    Value = System.Net.IPAddress.Parse("208.212.179.52"),
    NullableValue = System.Net.IPAddress.Parse("56.17.79.171"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 160,
    Value = System.Net.IPAddress.Parse("164.87.193.221"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 169,
    Value = System.Net.IPAddress.Parse("189.13.8.114"),
    NullableValue = System.Net.IPAddress.Parse("212.22.219.6"),
},
    NullableValue = System.Net.IPAddress.Parse("146.48.24.143"),
},
            new IPAddressIPv4E0M
{
    Id = 165,
    Value = System.Net.IPAddress.Parse("154.37.14.227"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 174,
    Value = System.Net.IPAddress.Parse("80.122.231.119"),
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.ipaddressipv4e0m(
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
FROM gedaqtests.ipaddressipv4e0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(IPAddressIPv4E0M)],
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
                    IPAddressIPv4E0M.AssertModel(models[0],_testData[i], false);
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
                    IPAddressIPv4E0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

