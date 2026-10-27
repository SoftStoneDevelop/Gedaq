

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
    Id = 2,
    Value = System.Net.IPAddress.Parse("148.205.60.136"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 4,
    Value = System.Net.IPAddress.Parse("57.61.154.60"),
    NullableValue = System.Net.IPAddress.Parse("73.127.138.96"),
},
    NullableValue = System.Net.IPAddress.Parse("57.109.30.225"),
},
            new IPAddressIPv4E0M
{
    Id = 8,
    Value = System.Net.IPAddress.Parse("17.179.119.244"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 13,
    Value = System.Net.IPAddress.Parse("83.241.107.92"),
    NullableValue = System.Net.IPAddress.Parse("181.118.109.234"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 16,
    Value = System.Net.IPAddress.Parse("2.103.195.77"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 19,
    Value = System.Net.IPAddress.Parse("99.181.9.164"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 20,
    Value = System.Net.IPAddress.Parse("41.209.22.26"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 22,
    Value = System.Net.IPAddress.Parse("202.168.52.129"),
    NullableValue = System.Net.IPAddress.Parse("65.229.17.219"),
},
    NullableValue = System.Net.IPAddress.Parse("35.125.220.133"),
},
            new IPAddressIPv4E0M
{
    Id = 28,
    Value = System.Net.IPAddress.Parse("156.35.191.5"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 29,
    Value = System.Net.IPAddress.Parse("102.65.249.11"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 32,
    Value = System.Net.IPAddress.Parse("84.183.185.188"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 35,
    Value = System.Net.IPAddress.Parse("135.217.22.207"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("35.74.232.12"),
},
            new IPAddressIPv4E0M
{
    Id = 34,
    Value = System.Net.IPAddress.Parse("181.130.180.214"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 37,
    Value = System.Net.IPAddress.Parse("197.239.191.116"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 41,
    Value = System.Net.IPAddress.Parse("155.173.111.193"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 46,
    Value = System.Net.IPAddress.Parse("159.202.25.171"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 43,
    Value = System.Net.IPAddress.Parse("108.165.66.145"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 55,
    Value = System.Net.IPAddress.Parse("226.244.115.145"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 51,
    Value = System.Net.IPAddress.Parse("251.107.172.130"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 63,
    Value = System.Net.IPAddress.Parse("93.156.91.152"),
    NullableValue = System.Net.IPAddress.Parse("57.206.152.163"),
},
    NullableValue = System.Net.IPAddress.Parse("109.194.21.187"),
},
            new IPAddressIPv4E0M
{
    Id = 54,
    Value = System.Net.IPAddress.Parse("182.72.138.166"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 67,
    Value = System.Net.IPAddress.Parse("228.139.127.112"),
    NullableValue = System.Net.IPAddress.Parse("236.97.120.198"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 59,
    Value = System.Net.IPAddress.Parse("99.27.229.144"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 73,
    Value = System.Net.IPAddress.Parse("136.244.41.33"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("9.68.17.130"),
},
            new IPAddressIPv4E0M
{
    Id = 64,
    Value = System.Net.IPAddress.Parse("143.59.162.240"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 77,
    Value = System.Net.IPAddress.Parse("1.194.7.1"),
    NullableValue = System.Net.IPAddress.Parse("241.160.230.218"),
},
    NullableValue = System.Net.IPAddress.Parse("50.162.247.207"),
},
            new IPAddressIPv4E0M
{
    Id = 68,
    Value = System.Net.IPAddress.Parse("0.237.231.44"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 80,
    Value = System.Net.IPAddress.Parse("119.38.223.230"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 75,
    Value = System.Net.IPAddress.Parse("100.122.38.233"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 87,
    Value = System.Net.IPAddress.Parse("5.225.241.248"),
    NullableValue = System.Net.IPAddress.Parse("62.70.63.188"),
},
    NullableValue = System.Net.IPAddress.Parse("130.62.168.37"),
},
            new IPAddressIPv4E0M
{
    Id = 76,
    Value = System.Net.IPAddress.Parse("232.197.51.247"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 89,
    Value = System.Net.IPAddress.Parse("79.13.96.236"),
    NullableValue = System.Net.IPAddress.Parse("186.13.103.26"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 82,
    Value = System.Net.IPAddress.Parse("141.9.202.143"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 94,
    Value = System.Net.IPAddress.Parse("127.126.11.127"),
    NullableValue = System.Net.IPAddress.Parse("131.53.117.159"),
},
    NullableValue = System.Net.IPAddress.Parse("165.115.247.146"),
},
            new IPAddressIPv4E0M
{
    Id = 89,
    Value = System.Net.IPAddress.Parse("8.68.222.220"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 97,
    Value = System.Net.IPAddress.Parse("0.241.99.196"),
    NullableValue = System.Net.IPAddress.Parse("37.94.209.216"),
},
    NullableValue = System.Net.IPAddress.Parse("184.51.194.234"),
},
            new IPAddressIPv4E0M
{
    Id = 95,
    Value = System.Net.IPAddress.Parse("36.196.254.22"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 99,
    Value = System.Net.IPAddress.Parse("90.45.14.224"),
    NullableValue = System.Net.IPAddress.Parse("95.90.39.223"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 99,
    Value = System.Net.IPAddress.Parse("17.138.0.65"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 107,
    Value = System.Net.IPAddress.Parse("172.29.133.175"),
    NullableValue = System.Net.IPAddress.Parse("28.8.163.140"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 102,
    Value = System.Net.IPAddress.Parse("137.56.236.44"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 116,
    Value = System.Net.IPAddress.Parse("115.41.94.34"),
    NullableValue = System.Net.IPAddress.Parse("19.107.113.218"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 107,
    Value = System.Net.IPAddress.Parse("191.187.214.6"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 118,
    Value = System.Net.IPAddress.Parse("49.204.229.39"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("232.2.196.41"),
},
            new IPAddressIPv4E0M
{
    Id = 112,
    Value = System.Net.IPAddress.Parse("178.47.81.95"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 122,
    Value = System.Net.IPAddress.Parse("159.128.252.17"),
    NullableValue = System.Net.IPAddress.Parse("33.83.27.187"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 121,
    Value = System.Net.IPAddress.Parse("51.132.102.46"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 127,
    Value = System.Net.IPAddress.Parse("152.59.65.204"),
    NullableValue = System.Net.IPAddress.Parse("224.16.142.20"),
},
    NullableValue = System.Net.IPAddress.Parse("203.87.2.157"),
},
            new IPAddressIPv4E0M
{
    Id = 124,
    Value = System.Net.IPAddress.Parse("88.88.127.98"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 134,
    Value = System.Net.IPAddress.Parse("81.65.182.159"),
    NullableValue = System.Net.IPAddress.Parse("167.16.251.120"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 126,
    Value = System.Net.IPAddress.Parse("37.207.118.178"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 139,
    Value = System.Net.IPAddress.Parse("154.202.59.135"),
    NullableValue = System.Net.IPAddress.Parse("209.167.24.212"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 135,
    Value = System.Net.IPAddress.Parse("108.163.210.154"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 143,
    Value = System.Net.IPAddress.Parse("186.152.175.64"),
    NullableValue = System.Net.IPAddress.Parse("217.220.35.231"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 144,
    Value = System.Net.IPAddress.Parse("68.253.235.6"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 152,
    Value = System.Net.IPAddress.Parse("135.251.11.45"),
    NullableValue = System.Net.IPAddress.Parse("17.236.239.174"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 150,
    Value = System.Net.IPAddress.Parse("73.251.30.72"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 156,
    Value = System.Net.IPAddress.Parse("207.234.114.24"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 154,
    Value = System.Net.IPAddress.Parse("77.144.95.166"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 157,
    Value = System.Net.IPAddress.Parse("138.48.176.217"),
    NullableValue = System.Net.IPAddress.Parse("9.136.73.95"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 156,
    Value = System.Net.IPAddress.Parse("110.65.63.49"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 162,
    Value = System.Net.IPAddress.Parse("83.94.149.208"),
    NullableValue = System.Net.IPAddress.Parse("97.25.158.34"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 158,
    Value = System.Net.IPAddress.Parse("33.206.74.247"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 165,
    Value = System.Net.IPAddress.Parse("144.188.24.188"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("191.16.43.228"),
},
            new IPAddressIPv4E0M
{
    Id = 159,
    Value = System.Net.IPAddress.Parse("150.105.115.229"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 171,
    Value = System.Net.IPAddress.Parse("140.80.185.236"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("17.129.15.199"),
},
            new IPAddressIPv4E0M
{
    Id = 167,
    Value = System.Net.IPAddress.Parse("71.185.72.222"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 177,
    Value = System.Net.IPAddress.Parse("176.131.149.232"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 175,
    Value = System.Net.IPAddress.Parse("2.196.226.247"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 179,
    Value = System.Net.IPAddress.Parse("5.113.123.5"),
    NullableValue = System.Net.IPAddress.Parse("106.210.75.77"),
},
    NullableValue = System.Net.IPAddress.Parse("194.52.175.67"),
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

