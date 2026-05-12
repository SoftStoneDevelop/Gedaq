

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
    Value = System.Net.IPAddress.Parse("193.18.198.94"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 2,
    Value = System.Net.IPAddress.Parse("53.32.31.83"),
    NullableValue = System.Net.IPAddress.Parse("119.201.97.188"),
},
    NullableValue = System.Net.IPAddress.Parse("9.98.147.36"),
},
            new IPAddressIPv4E0M
{
    Id = 3,
    Value = System.Net.IPAddress.Parse("34.45.77.190"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 5,
    Value = System.Net.IPAddress.Parse("184.94.228.59"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 11,
    Value = System.Net.IPAddress.Parse("7.112.183.100"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 12,
    Value = System.Net.IPAddress.Parse("141.167.134.179"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("22.100.12.127"),
},
            new IPAddressIPv4E0M
{
    Id = 15,
    Value = System.Net.IPAddress.Parse("97.169.72.215"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 17,
    Value = System.Net.IPAddress.Parse("51.235.93.252"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 22,
    Value = System.Net.IPAddress.Parse("93.127.65.113"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 21,
    Value = System.Net.IPAddress.Parse("148.250.88.114"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("81.245.144.5"),
},
            new IPAddressIPv4E0M
{
    Id = 25,
    Value = System.Net.IPAddress.Parse("146.38.93.221"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 30,
    Value = System.Net.IPAddress.Parse("29.229.121.23"),
    NullableValue = System.Net.IPAddress.Parse("79.243.211.190"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 33,
    Value = System.Net.IPAddress.Parse("203.168.178.233"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 32,
    Value = System.Net.IPAddress.Parse("186.199.42.208"),
    NullableValue = System.Net.IPAddress.Parse("124.133.8.110"),
},
    NullableValue = System.Net.IPAddress.Parse("197.16.115.60"),
},
            new IPAddressIPv4E0M
{
    Id = 39,
    Value = System.Net.IPAddress.Parse("219.205.212.135"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 36,
    Value = System.Net.IPAddress.Parse("223.76.149.54"),
    NullableValue = System.Net.IPAddress.Parse("137.203.61.253"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 43,
    Value = System.Net.IPAddress.Parse("214.122.71.170"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 38,
    Value = System.Net.IPAddress.Parse("104.10.24.186"),
    NullableValue = System.Net.IPAddress.Parse("71.182.129.72"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 52,
    Value = System.Net.IPAddress.Parse("199.99.148.222"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 44,
    Value = System.Net.IPAddress.Parse("206.157.180.118"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("3.90.243.215"),
},
            new IPAddressIPv4E0M
{
    Id = 56,
    Value = System.Net.IPAddress.Parse("236.42.43.227"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 52,
    Value = System.Net.IPAddress.Parse("128.242.187.227"),
    NullableValue = System.Net.IPAddress.Parse("67.200.169.113"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 58,
    Value = System.Net.IPAddress.Parse("218.4.91.18"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 60,
    Value = System.Net.IPAddress.Parse("151.50.147.237"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("98.179.4.82"),
},
            new IPAddressIPv4E0M
{
    Id = 65,
    Value = System.Net.IPAddress.Parse("165.46.111.59"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 66,
    Value = System.Net.IPAddress.Parse("114.53.242.83"),
    NullableValue = System.Net.IPAddress.Parse("186.173.203.148"),
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 72,
    Value = System.Net.IPAddress.Parse("219.225.56.124"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 71,
    Value = System.Net.IPAddress.Parse("160.234.206.56"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 78,
    Value = System.Net.IPAddress.Parse("63.188.217.179"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 79,
    Value = System.Net.IPAddress.Parse("0.117.153.178"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 84,
    Value = System.Net.IPAddress.Parse("99.92.210.120"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 85,
    Value = System.Net.IPAddress.Parse("240.56.34.115"),
    NullableValue = System.Net.IPAddress.Parse("17.117.151.246"),
},
    NullableValue = System.Net.IPAddress.Parse("44.162.14.247"),
},
            new IPAddressIPv4E0M
{
    Id = 91,
    Value = System.Net.IPAddress.Parse("114.121.217.232"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 91,
    Value = System.Net.IPAddress.Parse("106.120.171.144"),
    NullableValue = System.Net.IPAddress.Parse("108.142.242.162"),
},
    NullableValue = System.Net.IPAddress.Parse("12.130.204.97"),
},
            new IPAddressIPv4E0M
{
    Id = 99,
    Value = System.Net.IPAddress.Parse("5.219.83.129"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 92,
    Value = System.Net.IPAddress.Parse("174.178.118.62"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 107,
    Value = System.Net.IPAddress.Parse("237.107.106.243"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 95,
    Value = System.Net.IPAddress.Parse("2.41.82.179"),
    NullableValue = System.Net.IPAddress.Parse("132.188.34.86"),
},
    NullableValue = System.Net.IPAddress.Parse("181.108.230.114"),
},
            new IPAddressIPv4E0M
{
    Id = 112,
    Value = System.Net.IPAddress.Parse("110.12.93.199"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 100,
    Value = System.Net.IPAddress.Parse("59.236.180.205"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("157.137.114.86"),
},
            new IPAddressIPv4E0M
{
    Id = 121,
    Value = System.Net.IPAddress.Parse("185.152.249.104"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 103,
    Value = System.Net.IPAddress.Parse("43.9.219.125"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 124,
    Value = System.Net.IPAddress.Parse("80.40.69.156"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 106,
    Value = System.Net.IPAddress.Parse("63.186.65.178"),
    NullableValue = System.Net.IPAddress.Parse("150.122.28.177"),
},
    NullableValue = System.Net.IPAddress.Parse("7.49.147.184"),
},
            new IPAddressIPv4E0M
{
    Id = 126,
    Value = System.Net.IPAddress.Parse("35.216.149.174"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 113,
    Value = System.Net.IPAddress.Parse("167.13.50.45"),
    NullableValue = System.Net.IPAddress.Parse("193.34.197.43"),
},
    NullableValue = System.Net.IPAddress.Parse("238.157.93.79"),
},
            new IPAddressIPv4E0M
{
    Id = 135,
    Value = System.Net.IPAddress.Parse("186.234.219.92"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 121,
    Value = System.Net.IPAddress.Parse("81.186.192.71"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 137,
    Value = System.Net.IPAddress.Parse("63.42.139.183"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 130,
    Value = System.Net.IPAddress.Parse("231.95.212.99"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("52.249.254.245"),
},
            new IPAddressIPv4E0M
{
    Id = 140,
    Value = System.Net.IPAddress.Parse("151.235.161.69"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 134,
    Value = System.Net.IPAddress.Parse("194.229.51.113"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 146,
    Value = System.Net.IPAddress.Parse("206.175.3.65"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 135,
    Value = System.Net.IPAddress.Parse("52.23.231.215"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("59.10.140.205"),
},
            new IPAddressIPv4E0M
{
    Id = 153,
    Value = System.Net.IPAddress.Parse("181.75.111.52"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 139,
    Value = System.Net.IPAddress.Parse("6.80.69.213"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("244.242.209.57"),
},
            new IPAddressIPv4E0M
{
    Id = 158,
    Value = System.Net.IPAddress.Parse("113.244.199.200"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 141,
    Value = System.Net.IPAddress.Parse("120.110.29.136"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("175.29.125.154"),
},
            new IPAddressIPv4E0M
{
    Id = 162,
    Value = System.Net.IPAddress.Parse("72.235.127.130"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 142,
    Value = System.Net.IPAddress.Parse("225.117.205.182"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("123.142.210.164"),
},
            new IPAddressIPv4E0M
{
    Id = 169,
    Value = System.Net.IPAddress.Parse("126.252.52.40"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 144,
    Value = System.Net.IPAddress.Parse("186.31.124.155"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv4E0M
{
    Id = 177,
    Value = System.Net.IPAddress.Parse("6.36.116.16"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 151,
    Value = System.Net.IPAddress.Parse("189.22.73.250"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("176.191.146.184"),
},
            new IPAddressIPv4E0M
{
    Id = 180,
    Value = System.Net.IPAddress.Parse("144.28.51.222"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 157,
    Value = System.Net.IPAddress.Parse("10.63.63.125"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("92.96.152.111"),
},
            new IPAddressIPv4E0M
{
    Id = 185,
    Value = System.Net.IPAddress.Parse("21.209.117.93"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 159,
    Value = System.Net.IPAddress.Parse("101.184.108.47"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("75.27.80.112"),
},
            new IPAddressIPv4E0M
{
    Id = 192,
    Value = System.Net.IPAddress.Parse("145.165.251.142"),
    ModelInner = new IPAddressIPv4E0MI
{
    Id = 160,
    Value = System.Net.IPAddress.Parse("62.83.50.197"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("93.215.200.37"),
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

