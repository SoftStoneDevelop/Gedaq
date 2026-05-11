

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
    Id = 6,
    Value = System.Net.IPAddress.Parse("248.108.237.158"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 4,
    Value = System.Net.IPAddress.Parse("192.133.9.0"),
    NullableValue = System.Net.IPAddress.Parse("17.252.253.33"),
},
    NullableValue = System.Net.IPAddress.Parse("147.22.47.128"),
},
            new IPAddressIPv4E0M
{
    Id = 9,
    Value = System.Net.IPAddress.Parse("133.30.43.31"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 5,
    Value = System.Net.IPAddress.Parse("77.154.139.86"),
    NullableValue = System.Net.IPAddress.Parse("199.9.109.83"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 12,
    Value = System.Net.IPAddress.Parse("171.61.238.242"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 12,
    Value = System.Net.IPAddress.Parse("237.26.74.60"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 20,
    Value = System.Net.IPAddress.Parse("124.123.28.86"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 14,
    Value = System.Net.IPAddress.Parse("160.146.207.204"),
    NullableValue = System.Net.IPAddress.Parse("211.0.144.47"),
},
    NullableValue = System.Net.IPAddress.Parse("118.248.153.131"),
},
            new IPAddressIPv4E0M
{
    Id = 25,
    Value = System.Net.IPAddress.Parse("63.137.64.125"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 21,
    Value = System.Net.IPAddress.Parse("247.131.217.73"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("119.55.24.82"),
},
            new IPAddressIPv4E0M
{
    Id = 33,
    Value = System.Net.IPAddress.Parse("72.182.29.225"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 22,
    Value = System.Net.IPAddress.Parse("43.122.238.102"),
    NullableValue = System.Net.IPAddress.Parse("125.5.42.223"),
},
    NullableValue = System.Net.IPAddress.Parse("34.208.155.219"),
},
            new IPAddressIPv4E0M
{
    Id = 41,
    Value = System.Net.IPAddress.Parse("122.202.127.149"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 24,
    Value = System.Net.IPAddress.Parse("96.157.156.183"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("151.177.120.199"),
},
            new IPAddressIPv4E0M
{
    Id = 46,
    Value = System.Net.IPAddress.Parse("117.63.128.54"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 27,
    Value = System.Net.IPAddress.Parse("113.55.36.61"),
    NullableValue = System.Net.IPAddress.Parse("172.0.101.162"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 55,
    Value = System.Net.IPAddress.Parse("85.154.176.63"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 32,
    Value = System.Net.IPAddress.Parse("243.222.110.1"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 59,
    Value = System.Net.IPAddress.Parse("139.65.251.118"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 38,
    Value = System.Net.IPAddress.Parse("220.155.229.7"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 60,
    Value = System.Net.IPAddress.Parse("233.14.220.74"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 47,
    Value = System.Net.IPAddress.Parse("71.219.61.233"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 68,
    Value = System.Net.IPAddress.Parse("247.168.133.85"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 52,
    Value = System.Net.IPAddress.Parse("7.219.254.80"),
    NullableValue = System.Net.IPAddress.Parse("170.4.137.85"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 73,
    Value = System.Net.IPAddress.Parse("163.34.99.53"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 53,
    Value = System.Net.IPAddress.Parse("116.176.113.220"),
    NullableValue = System.Net.IPAddress.Parse("188.161.61.55"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 80,
    Value = System.Net.IPAddress.Parse("64.128.46.228"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 56,
    Value = System.Net.IPAddress.Parse("245.217.50.170"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 81,
    Value = System.Net.IPAddress.Parse("196.204.164.8"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 57,
    Value = System.Net.IPAddress.Parse("168.8.71.48"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 85,
    Value = System.Net.IPAddress.Parse("223.35.56.128"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 64,
    Value = System.Net.IPAddress.Parse("209.39.236.143"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("152.170.62.63"),
},
            new IPAddressIPv4E0M
{
    Id = 93,
    Value = System.Net.IPAddress.Parse("121.32.136.254"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 67,
    Value = System.Net.IPAddress.Parse("117.90.95.69"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("239.110.169.132"),
},
            new IPAddressIPv4E0M
{
    Id = 96,
    Value = System.Net.IPAddress.Parse("240.53.244.93"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 68,
    Value = System.Net.IPAddress.Parse("164.113.242.8"),
    NullableValue = System.Net.IPAddress.Parse("173.62.63.47"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 100,
    Value = System.Net.IPAddress.Parse("182.237.129.5"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 72,
    Value = System.Net.IPAddress.Parse("205.236.241.176"),
    NullableValue = System.Net.IPAddress.Parse("193.143.3.110"),
},
    NullableValue = System.Net.IPAddress.Parse("70.208.238.224"),
},
            new IPAddressIPv4E0M
{
    Id = 105,
    Value = System.Net.IPAddress.Parse("211.171.39.53"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 73,
    Value = System.Net.IPAddress.Parse("230.87.106.64"),
    NullableValue = System.Net.IPAddress.Parse("177.219.155.105"),
},
    NullableValue = System.Net.IPAddress.Parse("109.32.231.29"),
},
            new IPAddressIPv4E0M
{
    Id = 108,
    Value = System.Net.IPAddress.Parse("251.197.45.152"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 81,
    Value = System.Net.IPAddress.Parse("8.159.36.64"),
    NullableValue = System.Net.IPAddress.Parse("137.137.215.64"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 112,
    Value = System.Net.IPAddress.Parse("152.91.164.133"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 88,
    Value = System.Net.IPAddress.Parse("60.78.61.247"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 114,
    Value = System.Net.IPAddress.Parse("174.14.184.197"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 92,
    Value = System.Net.IPAddress.Parse("136.79.43.192"),
    NullableValue = System.Net.IPAddress.Parse("65.70.229.209"),
},
    NullableValue = System.Net.IPAddress.Parse("133.162.75.150"),
},
            new IPAddressIPv4E0M
{
    Id = 116,
    Value = System.Net.IPAddress.Parse("204.231.157.61"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 100,
    Value = System.Net.IPAddress.Parse("104.58.223.45"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("183.239.228.92"),
},
            new IPAddressIPv4E0M
{
    Id = 123,
    Value = System.Net.IPAddress.Parse("59.222.23.71"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 103,
    Value = System.Net.IPAddress.Parse("129.33.248.170"),
    NullableValue = System.Net.IPAddress.Parse("219.164.121.8"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 128,
    Value = System.Net.IPAddress.Parse("239.127.157.245"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 106,
    Value = System.Net.IPAddress.Parse("156.173.148.209"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 134,
    Value = System.Net.IPAddress.Parse("198.77.100.50"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 107,
    Value = System.Net.IPAddress.Parse("146.4.102.23"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 139,
    Value = System.Net.IPAddress.Parse("119.203.186.162"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 113,
    Value = System.Net.IPAddress.Parse("225.224.70.71"),
    NullableValue = System.Net.IPAddress.Parse("53.73.227.131"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 145,
    Value = System.Net.IPAddress.Parse("108.19.13.86"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 122,
    Value = System.Net.IPAddress.Parse("9.204.144.116"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("245.193.195.237"),
},
            new IPAddressIPv4E0M
{
    Id = 154,
    Value = System.Net.IPAddress.Parse("45.48.95.29"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 129,
    Value = System.Net.IPAddress.Parse("85.254.243.248"),
    NullableValue = System.Net.IPAddress.Parse("136.121.149.122"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 162,
    Value = System.Net.IPAddress.Parse("81.95.63.128"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 133,
    Value = System.Net.IPAddress.Parse("9.246.37.67"),
    NullableValue = System.Net.IPAddress.Parse("175.102.205.247"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 169,
    Value = System.Net.IPAddress.Parse("89.235.235.177"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 137,
    Value = System.Net.IPAddress.Parse("8.111.225.19"),
    NullableValue = System.Net.IPAddress.Parse("129.188.182.137"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 174,
    Value = System.Net.IPAddress.Parse("182.227.100.132"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 139,
    Value = System.Net.IPAddress.Parse("180.109.161.183"),
    NullableValue = System.Net.IPAddress.Parse("7.211.89.251"),
},
    NullableValue = System.Net.IPAddress.Parse("194.222.220.15"),
},
            new IPAddressIPv4E0M
{
    Id = 182,
    Value = System.Net.IPAddress.Parse("114.51.139.86"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 141,
    Value = System.Net.IPAddress.Parse("55.204.82.174"),
    NullableValue = System.Net.IPAddress.Parse("88.176.186.153"),
},
    NullableValue = System.Net.IPAddress.Parse("151.201.124.13"),
},
            new IPAddressIPv4E0M
{
    Id = 187,
    Value = System.Net.IPAddress.Parse("121.29.218.64"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 146,
    Value = System.Net.IPAddress.Parse("84.227.149.27"),
    NullableValue = System.Net.IPAddress.Parse("111.130.145.26"),
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

