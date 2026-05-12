

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
    Id = 8,
    Value = System.Net.IPAddress.Parse("72.138.37.154"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 4,
    Value = System.Net.IPAddress.Parse("2.122.207.113"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("2.249.58.220"),
},
            new IPAddressIPv4E0M
{
    Id = 10,
    Value = System.Net.IPAddress.Parse("123.62.216.68"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 5,
    Value = System.Net.IPAddress.Parse("106.214.203.64"),
    NullableValue = System.Net.IPAddress.Parse("245.89.46.228"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 16,
    Value = System.Net.IPAddress.Parse("38.91.50.221"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 12,
    Value = System.Net.IPAddress.Parse("33.201.26.77"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 23,
    Value = System.Net.IPAddress.Parse("89.17.62.207"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 16,
    Value = System.Net.IPAddress.Parse("215.137.36.243"),
    NullableValue = System.Net.IPAddress.Parse("225.73.6.149"),
},
    NullableValue = System.Net.IPAddress.Parse("92.71.201.32"),
},
            new IPAddressIPv4E0M
{
    Id = 30,
    Value = System.Net.IPAddress.Parse("230.245.113.90"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 21,
    Value = System.Net.IPAddress.Parse("147.244.83.42"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("45.77.22.81"),
},
            new IPAddressIPv4E0M
{
    Id = 35,
    Value = System.Net.IPAddress.Parse("155.92.102.245"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 25,
    Value = System.Net.IPAddress.Parse("241.78.26.147"),
    NullableValue = System.Net.IPAddress.Parse("60.118.14.117"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 40,
    Value = System.Net.IPAddress.Parse("100.128.146.126"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 31,
    Value = System.Net.IPAddress.Parse("62.8.114.117"),
    NullableValue = System.Net.IPAddress.Parse("223.5.16.30"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 49,
    Value = System.Net.IPAddress.Parse("158.221.207.21"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 32,
    Value = System.Net.IPAddress.Parse("35.78.178.57"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("241.4.75.27"),
},
            new IPAddressIPv4E0M
{
    Id = 53,
    Value = System.Net.IPAddress.Parse("187.74.215.137"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 40,
    Value = System.Net.IPAddress.Parse("137.108.238.50"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("242.123.225.249"),
},
            new IPAddressIPv4E0M
{
    Id = 61,
    Value = System.Net.IPAddress.Parse("31.243.199.4"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 46,
    Value = System.Net.IPAddress.Parse("243.83.112.127"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("243.25.31.44"),
},
            new IPAddressIPv4E0M
{
    Id = 62,
    Value = System.Net.IPAddress.Parse("157.8.53.235"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 52,
    Value = System.Net.IPAddress.Parse("57.143.121.116"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 65,
    Value = System.Net.IPAddress.Parse("62.254.181.102"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 54,
    Value = System.Net.IPAddress.Parse("84.108.120.174"),
    NullableValue = System.Net.IPAddress.Parse("198.49.55.149"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 72,
    Value = System.Net.IPAddress.Parse("176.219.62.220"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 57,
    Value = System.Net.IPAddress.Parse("124.102.83.135"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 76,
    Value = System.Net.IPAddress.Parse("115.225.224.53"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 60,
    Value = System.Net.IPAddress.Parse("190.6.81.4"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 81,
    Value = System.Net.IPAddress.Parse("170.84.29.25"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 68,
    Value = System.Net.IPAddress.Parse("217.219.111.133"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 84,
    Value = System.Net.IPAddress.Parse("17.104.174.31"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 71,
    Value = System.Net.IPAddress.Parse("213.70.221.89"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("202.105.43.206"),
},
            new IPAddressIPv4E0M
{
    Id = 87,
    Value = System.Net.IPAddress.Parse("101.35.114.219"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 79,
    Value = System.Net.IPAddress.Parse("15.119.237.172"),
    NullableValue = System.Net.IPAddress.Parse("201.219.171.84"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 92,
    Value = System.Net.IPAddress.Parse("29.204.147.247"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 83,
    Value = System.Net.IPAddress.Parse("91.46.29.209"),
    NullableValue = System.Net.IPAddress.Parse("238.230.170.78"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 100,
    Value = System.Net.IPAddress.Parse("167.0.164.228"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 88,
    Value = System.Net.IPAddress.Parse("118.40.253.85"),
    NullableValue = System.Net.IPAddress.Parse("43.101.63.214"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 105,
    Value = System.Net.IPAddress.Parse("169.72.170.53"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 92,
    Value = System.Net.IPAddress.Parse("99.153.249.0"),
    NullableValue = System.Net.IPAddress.Parse("94.34.164.120"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 108,
    Value = System.Net.IPAddress.Parse("250.86.166.96"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 101,
    Value = System.Net.IPAddress.Parse("148.167.202.253"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("117.192.24.246"),
},
            new IPAddressIPv4E0M
{
    Id = 114,
    Value = System.Net.IPAddress.Parse("164.46.200.174"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 103,
    Value = System.Net.IPAddress.Parse("108.12.143.19"),
    NullableValue = System.Net.IPAddress.Parse("36.89.174.12"),
},
    NullableValue = System.Net.IPAddress.Parse("138.203.79.63"),
},
            new IPAddressIPv4E0M
{
    Id = 118,
    Value = System.Net.IPAddress.Parse("169.177.31.128"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 111,
    Value = System.Net.IPAddress.Parse("151.82.92.78"),
    NullableValue = System.Net.IPAddress.Parse("85.187.237.23"),
},
    NullableValue = System.Net.IPAddress.Parse("139.252.6.194"),
},
            new IPAddressIPv4E0M
{
    Id = 122,
    Value = System.Net.IPAddress.Parse("52.40.86.89"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 116,
    Value = System.Net.IPAddress.Parse("67.219.204.200"),
    NullableValue = System.Net.IPAddress.Parse("218.114.14.221"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 123,
    Value = System.Net.IPAddress.Parse("243.11.60.233"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 119,
    Value = System.Net.IPAddress.Parse("241.136.133.64"),
    NullableValue = System.Net.IPAddress.Parse("24.172.197.51"),
},
    NullableValue = System.Net.IPAddress.Parse("16.200.170.159"),
},
            new IPAddressIPv4E0M
{
    Id = 130,
    Value = System.Net.IPAddress.Parse("142.123.91.195"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 128,
    Value = System.Net.IPAddress.Parse("84.19.251.88"),
    NullableValue = System.Net.IPAddress.Parse("23.232.26.228"),
},
    NullableValue = System.Net.IPAddress.Parse("136.93.21.43"),
},
            new IPAddressIPv4E0M
{
    Id = 137,
    Value = System.Net.IPAddress.Parse("130.48.1.105"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 130,
    Value = System.Net.IPAddress.Parse("6.228.207.213"),
    NullableValue = System.Net.IPAddress.Parse("99.65.64.52"),
},
    NullableValue = System.Net.IPAddress.Parse("202.20.22.44"),
},
            new IPAddressIPv4E0M
{
    Id = 146,
    Value = System.Net.IPAddress.Parse("157.86.70.184"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 138,
    Value = System.Net.IPAddress.Parse("222.46.202.231"),
    NullableValue = System.Net.IPAddress.Parse("56.245.197.163"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 148,
    Value = System.Net.IPAddress.Parse("84.246.221.49"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 143,
    Value = System.Net.IPAddress.Parse("206.221.231.49"),
    NullableValue = System.Net.IPAddress.Parse("220.83.12.27"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 154,
    Value = System.Net.IPAddress.Parse("107.100.30.211"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 150,
    Value = System.Net.IPAddress.Parse("181.80.166.133"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("72.249.62.150"),
},
            new IPAddressIPv4E0M
{
    Id = 157,
    Value = System.Net.IPAddress.Parse("79.48.201.225"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 158,
    Value = System.Net.IPAddress.Parse("43.150.207.91"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("214.177.8.49"),
},
            new IPAddressIPv4E0M
{
    Id = 166,
    Value = System.Net.IPAddress.Parse("240.198.79.118"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 167,
    Value = System.Net.IPAddress.Parse("56.89.37.237"),
    NullableValue = System.Net.IPAddress.Parse("207.237.81.229"),
},
    NullableValue = System.Net.IPAddress.Parse("179.64.51.129"),
},
            new IPAddressIPv4E0M
{
    Id = 173,
    Value = System.Net.IPAddress.Parse("61.237.120.187"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 173,
    Value = System.Net.IPAddress.Parse("181.94.163.219"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 174,
    Value = System.Net.IPAddress.Parse("31.19.78.199"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 180,
    Value = System.Net.IPAddress.Parse("48.183.56.2"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 177,
    Value = System.Net.IPAddress.Parse("120.142.126.241"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 189,
    Value = System.Net.IPAddress.Parse("95.160.129.85"),
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

