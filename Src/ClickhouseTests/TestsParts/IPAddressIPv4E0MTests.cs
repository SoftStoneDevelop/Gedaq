

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
    Id = 5,
    Value = System.Net.IPAddress.Parse("154.47.33.186"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 7,
    Value = System.Net.IPAddress.Parse("251.18.129.210"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 12,
    Value = System.Net.IPAddress.Parse("138.55.68.60"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 13,
    Value = System.Net.IPAddress.Parse("150.52.204.90"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 20,
    Value = System.Net.IPAddress.Parse("9.48.122.64"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 14,
    Value = System.Net.IPAddress.Parse("150.49.252.2"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("11.189.176.79"),
},
            new IPAddressIPv4E0M
{
    Id = 24,
    Value = System.Net.IPAddress.Parse("27.37.227.204"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 23,
    Value = System.Net.IPAddress.Parse("149.198.226.34"),
    NullableValue = System.Net.IPAddress.Parse("149.17.85.180"),
},
    NullableValue = System.Net.IPAddress.Parse("189.75.143.70"),
},
            new IPAddressIPv4E0M
{
    Id = 26,
    Value = System.Net.IPAddress.Parse("176.250.248.73"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 25,
    Value = System.Net.IPAddress.Parse("106.196.125.11"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("82.18.171.3"),
},
            new IPAddressIPv4E0M
{
    Id = 32,
    Value = System.Net.IPAddress.Parse("215.192.180.146"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 29,
    Value = System.Net.IPAddress.Parse("12.251.230.166"),
    NullableValue = System.Net.IPAddress.Parse("181.55.219.75"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 34,
    Value = System.Net.IPAddress.Parse("161.22.165.138"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 38,
    Value = System.Net.IPAddress.Parse("21.52.120.73"),
    NullableValue = System.Net.IPAddress.Parse("181.73.51.191"),
},
    NullableValue = System.Net.IPAddress.Parse("5.199.98.70"),
},
            new IPAddressIPv4E0M
{
    Id = 38,
    Value = System.Net.IPAddress.Parse("74.24.196.196"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 45,
    Value = System.Net.IPAddress.Parse("176.191.175.201"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("147.206.143.205"),
},
            new IPAddressIPv4E0M
{
    Id = 47,
    Value = System.Net.IPAddress.Parse("52.8.41.44"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 46,
    Value = System.Net.IPAddress.Parse("245.73.247.249"),
    NullableValue = System.Net.IPAddress.Parse("200.88.28.191"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 49,
    Value = System.Net.IPAddress.Parse("226.92.241.165"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 53,
    Value = System.Net.IPAddress.Parse("64.231.201.164"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("212.100.238.218"),
},
            new IPAddressIPv4E0M
{
    Id = 51,
    Value = System.Net.IPAddress.Parse("232.226.219.150"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 56,
    Value = System.Net.IPAddress.Parse("100.99.228.45"),
    NullableValue = System.Net.IPAddress.Parse("23.99.225.185"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 57,
    Value = System.Net.IPAddress.Parse("101.160.221.88"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 58,
    Value = System.Net.IPAddress.Parse("145.118.22.97"),
    NullableValue = System.Net.IPAddress.Parse("86.16.153.24"),
},
    NullableValue = System.Net.IPAddress.Parse("160.13.119.61"),
},
            new IPAddressIPv4E0M
{
    Id = 65,
    Value = System.Net.IPAddress.Parse("249.74.116.83"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 66,
    Value = System.Net.IPAddress.Parse("166.203.11.92"),
    NullableValue = System.Net.IPAddress.Parse("118.34.39.23"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 67,
    Value = System.Net.IPAddress.Parse("226.181.206.245"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 70,
    Value = System.Net.IPAddress.Parse("211.25.72.98"),
    NullableValue = System.Net.IPAddress.Parse("197.76.175.228"),
},
    NullableValue = System.Net.IPAddress.Parse("211.156.144.80"),
},
            new IPAddressIPv4E0M
{
    Id = 74,
    Value = System.Net.IPAddress.Parse("205.116.54.240"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 76,
    Value = System.Net.IPAddress.Parse("65.149.189.89"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("66.206.5.189"),
},
            new IPAddressIPv4E0M
{
    Id = 75,
    Value = System.Net.IPAddress.Parse("155.125.33.170"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 79,
    Value = System.Net.IPAddress.Parse("155.254.63.252"),
    NullableValue = System.Net.IPAddress.Parse("111.168.12.209"),
},
    NullableValue = System.Net.IPAddress.Parse("19.184.123.216"),
},
            new IPAddressIPv4E0M
{
    Id = 84,
    Value = System.Net.IPAddress.Parse("249.224.37.217"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 87,
    Value = System.Net.IPAddress.Parse("124.179.218.19"),
    NullableValue = System.Net.IPAddress.Parse("31.26.87.101"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 88,
    Value = System.Net.IPAddress.Parse("170.57.204.85"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 90,
    Value = System.Net.IPAddress.Parse("97.180.106.134"),
    NullableValue = System.Net.IPAddress.Parse("253.156.26.188"),
},
    NullableValue = System.Net.IPAddress.Parse("69.78.199.138"),
},
            new IPAddressIPv4E0M
{
    Id = 95,
    Value = System.Net.IPAddress.Parse("156.251.120.19"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 96,
    Value = System.Net.IPAddress.Parse("37.102.72.226"),
    NullableValue = System.Net.IPAddress.Parse("72.211.62.144"),
},
    NullableValue = System.Net.IPAddress.Parse("85.2.147.116"),
},
            new IPAddressIPv4E0M
{
    Id = 104,
    Value = System.Net.IPAddress.Parse("222.77.12.189"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 101,
    Value = System.Net.IPAddress.Parse("30.45.200.19"),
    NullableValue = System.Net.IPAddress.Parse("157.55.48.94"),
},
    NullableValue = System.Net.IPAddress.Parse("42.196.154.237"),
},
            new IPAddressIPv4E0M
{
    Id = 110,
    Value = System.Net.IPAddress.Parse("5.136.164.72"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 104,
    Value = System.Net.IPAddress.Parse("136.160.13.62"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("2.12.156.77"),
},
            new IPAddressIPv4E0M
{
    Id = 111,
    Value = System.Net.IPAddress.Parse("47.170.200.133"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 112,
    Value = System.Net.IPAddress.Parse("101.224.195.156"),
    NullableValue = System.Net.IPAddress.Parse("107.58.106.250"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 119,
    Value = System.Net.IPAddress.Parse("163.34.208.42"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 113,
    Value = System.Net.IPAddress.Parse("182.60.189.142"),
    NullableValue = System.Net.IPAddress.Parse("105.31.25.22"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 121,
    Value = System.Net.IPAddress.Parse("198.142.34.63"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 115,
    Value = System.Net.IPAddress.Parse("240.230.196.201"),
    NullableValue = System.Net.IPAddress.Parse("53.243.212.20"),
},
    NullableValue = System.Net.IPAddress.Parse("40.227.207.205"),
},
            new IPAddressIPv4E0M
{
    Id = 129,
    Value = System.Net.IPAddress.Parse("217.39.187.248"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 120,
    Value = System.Net.IPAddress.Parse("120.218.82.37"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("19.73.86.249"),
},
            new IPAddressIPv4E0M
{
    Id = 132,
    Value = System.Net.IPAddress.Parse("148.148.42.180"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 123,
    Value = System.Net.IPAddress.Parse("136.141.228.232"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 135,
    Value = System.Net.IPAddress.Parse("33.125.194.56"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 125,
    Value = System.Net.IPAddress.Parse("244.251.105.182"),
    NullableValue = System.Net.IPAddress.Parse("39.119.180.220"),
},
    NullableValue = System.Net.IPAddress.Parse("203.174.158.217"),
},
            new IPAddressIPv4E0M
{
    Id = 139,
    Value = System.Net.IPAddress.Parse("165.246.212.1"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 134,
    Value = System.Net.IPAddress.Parse("214.123.198.71"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("197.198.95.138"),
},
            new IPAddressIPv4E0M
{
    Id = 140,
    Value = System.Net.IPAddress.Parse("137.82.127.7"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 140,
    Value = System.Net.IPAddress.Parse("23.23.88.78"),
    NullableValue = System.Net.IPAddress.Parse("153.197.142.218"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 144,
    Value = System.Net.IPAddress.Parse("1.227.123.214"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 147,
    Value = System.Net.IPAddress.Parse("200.139.230.156"),
    NullableValue = System.Net.IPAddress.Parse("163.74.115.95"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 148,
    Value = System.Net.IPAddress.Parse("239.116.81.80"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 151,
    Value = System.Net.IPAddress.Parse("134.50.110.210"),
    NullableValue = System.Net.IPAddress.Parse("188.64.202.136"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 149,
    Value = System.Net.IPAddress.Parse("4.204.134.97"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 155,
    Value = System.Net.IPAddress.Parse("227.117.157.190"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("11.165.62.66"),
},
            new IPAddressIPv4E0M
{
    Id = 152,
    Value = System.Net.IPAddress.Parse("107.143.218.218"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 162,
    Value = System.Net.IPAddress.Parse("145.221.81.59"),
    NullableValue = System.Net.IPAddress.Parse("32.160.80.73"),
},
    NullableValue = System.Net.IPAddress.Parse("10.131.250.3"),
},
            new IPAddressIPv4E0M
{
    Id = 159,
    Value = System.Net.IPAddress.Parse("108.121.19.18"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 170,
    Value = System.Net.IPAddress.Parse("15.205.196.172"),
    NullableValue = System.Net.IPAddress.Parse("180.15.80.50"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 167,
    Value = System.Net.IPAddress.Parse("125.35.5.218"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 176,
    Value = System.Net.IPAddress.Parse("49.131.8.129"),
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

