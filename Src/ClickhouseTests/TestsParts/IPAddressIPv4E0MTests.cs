

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
    Id = 3,
    Value = System.Net.IPAddress.Parse("97.117.249.167"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 8,
    Value = System.Net.IPAddress.Parse("153.82.167.27"),
    NullableValue = System.Net.IPAddress.Parse("184.51.126.85"),
},
    NullableValue = System.Net.IPAddress.Parse("233.225.185.17"),
},
            new IPAddressIPv4E0M
{
    Id = 9,
    Value = System.Net.IPAddress.Parse("183.7.252.73"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 16,
    Value = System.Net.IPAddress.Parse("44.62.89.170"),
    NullableValue = System.Net.IPAddress.Parse("54.78.189.28"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 17,
    Value = System.Net.IPAddress.Parse("251.52.121.177"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 21,
    Value = System.Net.IPAddress.Parse("196.67.98.174"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 26,
    Value = System.Net.IPAddress.Parse("138.127.96.26"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 27,
    Value = System.Net.IPAddress.Parse("8.54.135.63"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 28,
    Value = System.Net.IPAddress.Parse("67.20.178.250"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 33,
    Value = System.Net.IPAddress.Parse("236.110.86.243"),
    NullableValue = System.Net.IPAddress.Parse("254.60.169.95"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 34,
    Value = System.Net.IPAddress.Parse("253.44.99.252"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 35,
    Value = System.Net.IPAddress.Parse("219.180.144.57"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 42,
    Value = System.Net.IPAddress.Parse("214.63.199.211"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 37,
    Value = System.Net.IPAddress.Parse("65.68.201.148"),
    NullableValue = System.Net.IPAddress.Parse("228.174.124.236"),
},
    NullableValue = System.Net.IPAddress.Parse("171.171.206.123"),
},
            new IPAddressIPv4E0M
{
    Id = 50,
    Value = System.Net.IPAddress.Parse("197.35.72.100"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 43,
    Value = System.Net.IPAddress.Parse("180.26.60.103"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 55,
    Value = System.Net.IPAddress.Parse("244.36.236.172"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 49,
    Value = System.Net.IPAddress.Parse("190.93.112.31"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 57,
    Value = System.Net.IPAddress.Parse("120.87.37.121"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 53,
    Value = System.Net.IPAddress.Parse("216.151.15.133"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("66.23.13.48"),
},
            new IPAddressIPv4E0M
{
    Id = 65,
    Value = System.Net.IPAddress.Parse("166.147.6.9"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 58,
    Value = System.Net.IPAddress.Parse("172.151.209.251"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 68,
    Value = System.Net.IPAddress.Parse("230.170.38.55"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 64,
    Value = System.Net.IPAddress.Parse("224.253.98.225"),
    NullableValue = System.Net.IPAddress.Parse("190.86.149.60"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 70,
    Value = System.Net.IPAddress.Parse("233.201.238.187"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 69,
    Value = System.Net.IPAddress.Parse("54.137.29.182"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 72,
    Value = System.Net.IPAddress.Parse("31.78.170.123"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 71,
    Value = System.Net.IPAddress.Parse("0.111.213.213"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 80,
    Value = System.Net.IPAddress.Parse("239.208.148.98"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 80,
    Value = System.Net.IPAddress.Parse("39.184.80.194"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("38.44.65.186"),
},
            new IPAddressIPv4E0M
{
    Id = 82,
    Value = System.Net.IPAddress.Parse("228.53.239.139"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 89,
    Value = System.Net.IPAddress.Parse("190.94.47.84"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 84,
    Value = System.Net.IPAddress.Parse("97.3.190.122"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 95,
    Value = System.Net.IPAddress.Parse("194.212.74.11"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 88,
    Value = System.Net.IPAddress.Parse("139.42.149.135"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 96,
    Value = System.Net.IPAddress.Parse("186.41.233.4"),
    NullableValue = System.Net.IPAddress.Parse("192.65.80.161"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 89,
    Value = System.Net.IPAddress.Parse("117.92.175.108"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 105,
    Value = System.Net.IPAddress.Parse("47.30.44.24"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("88.164.151.209"),
},
            new IPAddressIPv4E0M
{
    Id = 92,
    Value = System.Net.IPAddress.Parse("184.45.164.83"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 113,
    Value = System.Net.IPAddress.Parse("133.56.144.185"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("49.221.94.161"),
},
            new IPAddressIPv4E0M
{
    Id = 98,
    Value = System.Net.IPAddress.Parse("154.135.7.33"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 118,
    Value = System.Net.IPAddress.Parse("81.14.84.176"),
    NullableValue = System.Net.IPAddress.Parse("213.252.104.90"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 102,
    Value = System.Net.IPAddress.Parse("137.197.89.238"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 121,
    Value = System.Net.IPAddress.Parse("235.150.121.26"),
    NullableValue = System.Net.IPAddress.Parse("0.12.31.68"),
},
    NullableValue = System.Net.IPAddress.Parse("210.62.185.78"),
},
            new IPAddressIPv4E0M
{
    Id = 106,
    Value = System.Net.IPAddress.Parse("157.31.229.205"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 130,
    Value = System.Net.IPAddress.Parse("90.5.217.249"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 112,
    Value = System.Net.IPAddress.Parse("174.25.70.186"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 134,
    Value = System.Net.IPAddress.Parse("81.13.195.154"),
    NullableValue = System.Net.IPAddress.Parse("133.189.173.236"),
},
    NullableValue = System.Net.IPAddress.Parse("123.50.25.7"),
},
            new IPAddressIPv4E0M
{
    Id = 113,
    Value = System.Net.IPAddress.Parse("125.95.108.45"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 135,
    Value = System.Net.IPAddress.Parse("92.57.129.227"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("74.183.217.170"),
},
            new IPAddressIPv4E0M
{
    Id = 117,
    Value = System.Net.IPAddress.Parse("199.194.99.6"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 136,
    Value = System.Net.IPAddress.Parse("15.127.36.186"),
    NullableValue = System.Net.IPAddress.Parse("105.112.201.27"),
},
    NullableValue = System.Net.IPAddress.Parse("30.207.84.92"),
},
            new IPAddressIPv4E0M
{
    Id = 123,
    Value = System.Net.IPAddress.Parse("225.253.53.10"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 144,
    Value = System.Net.IPAddress.Parse("86.35.125.120"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 132,
    Value = System.Net.IPAddress.Parse("134.54.135.82"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 152,
    Value = System.Net.IPAddress.Parse("99.29.58.218"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 140,
    Value = System.Net.IPAddress.Parse("189.234.190.168"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 158,
    Value = System.Net.IPAddress.Parse("157.69.69.211"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 149,
    Value = System.Net.IPAddress.Parse("64.7.14.145"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 159,
    Value = System.Net.IPAddress.Parse("179.146.61.6"),
    NullableValue = System.Net.IPAddress.Parse("184.234.51.47"),
},
    NullableValue = System.Net.IPAddress.Parse("95.201.128.10"),
},
            new IPAddressIPv4E0M
{
    Id = 152,
    Value = System.Net.IPAddress.Parse("15.208.78.227"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 161,
    Value = System.Net.IPAddress.Parse("192.201.180.212"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 159,
    Value = System.Net.IPAddress.Parse("175.1.18.245"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 165,
    Value = System.Net.IPAddress.Parse("88.46.238.208"),
    NullableValue = System.Net.IPAddress.Parse("121.211.244.91"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 165,
    Value = System.Net.IPAddress.Parse("142.137.218.135"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 171,
    Value = System.Net.IPAddress.Parse("215.116.105.219"),
    NullableValue = System.Net.IPAddress.Parse("253.167.147.2"),
},
    NullableValue = System.Net.IPAddress.Parse("33.1.209.190"),
},
            new IPAddressIPv4E0M
{
    Id = 172,
    Value = System.Net.IPAddress.Parse("220.167.41.7"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 177,
    Value = System.Net.IPAddress.Parse("53.204.206.219"),
    NullableValue = System.Net.IPAddress.Parse("120.192.76.179"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 175,
    Value = System.Net.IPAddress.Parse("246.154.221.174"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 178,
    Value = System.Net.IPAddress.Parse("41.174.107.108"),
    NullableValue = System.Net.IPAddress.Parse("123.175.209.68"),
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

