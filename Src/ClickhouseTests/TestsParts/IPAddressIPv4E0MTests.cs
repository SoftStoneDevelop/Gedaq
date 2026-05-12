

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
    Id = 4,
    Value = System.Net.IPAddress.Parse("128.67.1.59"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 1,
    Value = System.Net.IPAddress.Parse("51.201.245.42"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 11,
    Value = System.Net.IPAddress.Parse("90.93.131.196"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 10,
    Value = System.Net.IPAddress.Parse("235.241.251.196"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 17,
    Value = System.Net.IPAddress.Parse("184.60.116.19"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 12,
    Value = System.Net.IPAddress.Parse("148.70.187.78"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 25,
    Value = System.Net.IPAddress.Parse("203.216.168.253"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 18,
    Value = System.Net.IPAddress.Parse("119.250.139.171"),
    NullableValue = System.Net.IPAddress.Parse("232.115.203.139"),
},
    NullableValue = System.Net.IPAddress.Parse("200.222.138.147"),
},
            new IPAddressIPv4E0M
{
    Id = 32,
    Value = System.Net.IPAddress.Parse("25.144.143.155"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 21,
    Value = System.Net.IPAddress.Parse("225.204.157.56"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 35,
    Value = System.Net.IPAddress.Parse("26.159.147.46"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 22,
    Value = System.Net.IPAddress.Parse("92.247.106.216"),
    NullableValue = System.Net.IPAddress.Parse("239.6.9.78"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 41,
    Value = System.Net.IPAddress.Parse("71.170.163.156"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 25,
    Value = System.Net.IPAddress.Parse("86.167.26.17"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("198.204.120.182"),
},
            new IPAddressIPv4E0M
{
    Id = 44,
    Value = System.Net.IPAddress.Parse("17.78.247.214"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 34,
    Value = System.Net.IPAddress.Parse("52.215.252.62"),
    NullableValue = System.Net.IPAddress.Parse("52.243.153.37"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 47,
    Value = System.Net.IPAddress.Parse("41.186.237.222"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 42,
    Value = System.Net.IPAddress.Parse("52.159.251.161"),
    NullableValue = System.Net.IPAddress.Parse("21.251.202.19"),
},
    NullableValue = System.Net.IPAddress.Parse("231.214.100.201"),
},
            new IPAddressIPv4E0M
{
    Id = 53,
    Value = System.Net.IPAddress.Parse("94.182.87.119"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 50,
    Value = System.Net.IPAddress.Parse("137.77.62.121"),
    NullableValue = System.Net.IPAddress.Parse("213.66.82.230"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 54,
    Value = System.Net.IPAddress.Parse("182.184.119.5"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 53,
    Value = System.Net.IPAddress.Parse("35.72.79.225"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("178.63.90.15"),
},
            new IPAddressIPv4E0M
{
    Id = 57,
    Value = System.Net.IPAddress.Parse("86.31.216.156"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 57,
    Value = System.Net.IPAddress.Parse("90.38.148.150"),
    NullableValue = System.Net.IPAddress.Parse("128.189.101.124"),
},
    NullableValue = System.Net.IPAddress.Parse("150.104.244.84"),
},
            new IPAddressIPv4E0M
{
    Id = 66,
    Value = System.Net.IPAddress.Parse("116.136.199.108"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 66,
    Value = System.Net.IPAddress.Parse("200.95.245.99"),
    NullableValue = System.Net.IPAddress.Parse("42.13.203.253"),
},
    NullableValue = System.Net.IPAddress.Parse("142.216.124.48"),
},
            new IPAddressIPv4E0M
{
    Id = 69,
    Value = System.Net.IPAddress.Parse("177.67.14.152"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 69,
    Value = System.Net.IPAddress.Parse("8.87.33.95"),
    NullableValue = System.Net.IPAddress.Parse("77.132.204.54"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 73,
    Value = System.Net.IPAddress.Parse("227.213.9.237"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 74,
    Value = System.Net.IPAddress.Parse("53.193.108.165"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 78,
    Value = System.Net.IPAddress.Parse("169.211.52.121"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 80,
    Value = System.Net.IPAddress.Parse("127.207.60.219"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 82,
    Value = System.Net.IPAddress.Parse("123.145.121.77"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 83,
    Value = System.Net.IPAddress.Parse("196.226.157.101"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 83,
    Value = System.Net.IPAddress.Parse("152.36.3.217"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 92,
    Value = System.Net.IPAddress.Parse("163.24.22.177"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 85,
    Value = System.Net.IPAddress.Parse("169.213.133.8"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 101,
    Value = System.Net.IPAddress.Parse("202.33.28.132"),
    NullableValue = System.Net.IPAddress.Parse("165.131.66.247"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 88,
    Value = System.Net.IPAddress.Parse("53.178.15.187"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 103,
    Value = System.Net.IPAddress.Parse("104.104.176.116"),
    NullableValue = System.Net.IPAddress.Parse("141.106.89.7"),
},
    NullableValue = System.Net.IPAddress.Parse("108.243.9.206"),
},
            new IPAddressIPv4E0M
{
    Id = 96,
    Value = System.Net.IPAddress.Parse("201.107.212.117"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 110,
    Value = System.Net.IPAddress.Parse("0.159.68.141"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 105,
    Value = System.Net.IPAddress.Parse("178.151.202.211"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 119,
    Value = System.Net.IPAddress.Parse("123.171.14.233"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("28.66.224.179"),
},
            new IPAddressIPv4E0M
{
    Id = 110,
    Value = System.Net.IPAddress.Parse("215.20.200.100"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 125,
    Value = System.Net.IPAddress.Parse("45.79.142.44"),
    NullableValue = System.Net.IPAddress.Parse("168.184.122.185"),
},
    NullableValue = System.Net.IPAddress.Parse("74.215.235.98"),
},
            new IPAddressIPv4E0M
{
    Id = 117,
    Value = System.Net.IPAddress.Parse("72.140.229.91"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 127,
    Value = System.Net.IPAddress.Parse("95.143.87.237"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("197.207.100.247"),
},
            new IPAddressIPv4E0M
{
    Id = 122,
    Value = System.Net.IPAddress.Parse("29.229.188.79"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 134,
    Value = System.Net.IPAddress.Parse("120.216.106.182"),
    NullableValue = System.Net.IPAddress.Parse("163.105.1.98"),
},
    NullableValue = System.Net.IPAddress.Parse("124.58.185.233"),
},
            new IPAddressIPv4E0M
{
    Id = 129,
    Value = System.Net.IPAddress.Parse("109.88.29.139"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 143,
    Value = System.Net.IPAddress.Parse("133.32.37.226"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("90.74.53.47"),
},
            new IPAddressIPv4E0M
{
    Id = 133,
    Value = System.Net.IPAddress.Parse("234.201.202.10"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 144,
    Value = System.Net.IPAddress.Parse("46.115.114.217"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("76.12.172.186"),
},
            new IPAddressIPv4E0M
{
    Id = 142,
    Value = System.Net.IPAddress.Parse("104.208.198.224"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 149,
    Value = System.Net.IPAddress.Parse("245.114.232.169"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("76.183.195.162"),
},
            new IPAddressIPv4E0M
{
    Id = 150,
    Value = System.Net.IPAddress.Parse("93.51.56.240"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 154,
    Value = System.Net.IPAddress.Parse("33.169.136.196"),
    NullableValue = System.Net.IPAddress.Parse("171.52.35.57"),
},
    NullableValue = System.Net.IPAddress.Parse("226.152.138.170"),
},
            new IPAddressIPv4E0M
{
    Id = 158,
    Value = System.Net.IPAddress.Parse("106.176.70.43"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 161,
    Value = System.Net.IPAddress.Parse("211.102.78.3"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("253.51.6.37"),
},
            new IPAddressIPv4E0M
{
    Id = 165,
    Value = System.Net.IPAddress.Parse("34.56.127.165"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 163,
    Value = System.Net.IPAddress.Parse("18.2.212.66"),
    NullableValue = System.Net.IPAddress.Parse("15.162.90.24"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 172,
    Value = System.Net.IPAddress.Parse("218.134.212.23"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 164,
    Value = System.Net.IPAddress.Parse("227.152.230.66"),
    NullableValue = System.Net.IPAddress.Parse("41.253.179.217"),
},
    NullableValue = System.Net.IPAddress.Parse("172.214.219.69"),
},
            new IPAddressIPv4E0M
{
    Id = 175,
    Value = System.Net.IPAddress.Parse("16.41.99.191"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 171,
    Value = System.Net.IPAddress.Parse("51.94.123.125"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("106.68.72.178"),
},
            new IPAddressIPv4E0M
{
    Id = 184,
    Value = System.Net.IPAddress.Parse("111.143.121.43"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 178,
    Value = System.Net.IPAddress.Parse("93.12.60.247"),
    NullableValue = System.Net.IPAddress.Parse("93.30.45.114"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 193,
    Value = System.Net.IPAddress.Parse("157.36.246.153"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 183,
    Value = System.Net.IPAddress.Parse("211.74.87.153"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("89.198.25.57"),
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

