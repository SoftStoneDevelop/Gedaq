

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
    Value = System.Net.IPAddress.Parse("247.35.198.225"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 3,
    Value = System.Net.IPAddress.Parse("123.137.13.18"),
    NullableValue = System.Net.IPAddress.Parse("120.41.36.10"),
},
    NullableValue = System.Net.IPAddress.Parse("92.246.132.5"),
},
            new IPAddressIPv40M
{
    Id = 11,
    Value = System.Net.IPAddress.Parse("167.235.21.241"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 5,
    Value = System.Net.IPAddress.Parse("244.241.221.194"),
    NullableValue = System.Net.IPAddress.Parse("46.98.117.222"),
},
    NullableValue = System.Net.IPAddress.Parse("227.213.55.153"),
},
            new IPAddressIPv40M
{
    Id = 12,
    Value = System.Net.IPAddress.Parse("107.108.122.13"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 9,
    Value = System.Net.IPAddress.Parse("172.8.31.240"),
    NullableValue = System.Net.IPAddress.Parse("105.10.80.209"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 16,
    Value = System.Net.IPAddress.Parse("80.199.254.245"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 13,
    Value = System.Net.IPAddress.Parse("50.153.78.157"),
    NullableValue = System.Net.IPAddress.Parse("116.24.150.170"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 25,
    Value = System.Net.IPAddress.Parse("95.6.117.150"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 22,
    Value = System.Net.IPAddress.Parse("60.128.118.134"),
    NullableValue = System.Net.IPAddress.Parse("140.9.179.8"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 31,
    Value = System.Net.IPAddress.Parse("237.195.128.104"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 26,
    Value = System.Net.IPAddress.Parse("175.128.64.97"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("203.9.242.39"),
},
            new IPAddressIPv40M
{
    Id = 39,
    Value = System.Net.IPAddress.Parse("50.188.118.236"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 29,
    Value = System.Net.IPAddress.Parse("42.157.186.162"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 43,
    Value = System.Net.IPAddress.Parse("2.220.234.188"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 38,
    Value = System.Net.IPAddress.Parse("49.244.141.135"),
    NullableValue = System.Net.IPAddress.Parse("109.181.124.70"),
},
    NullableValue = System.Net.IPAddress.Parse("158.123.4.209"),
},
            new IPAddressIPv40M
{
    Id = 50,
    Value = System.Net.IPAddress.Parse("227.212.70.51"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 47,
    Value = System.Net.IPAddress.Parse("55.216.168.38"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("233.133.208.139"),
},
            new IPAddressIPv40M
{
    Id = 56,
    Value = System.Net.IPAddress.Parse("212.53.33.72"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 53,
    Value = System.Net.IPAddress.Parse("6.167.2.219"),
    NullableValue = System.Net.IPAddress.Parse("156.233.150.199"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 58,
    Value = System.Net.IPAddress.Parse("131.144.64.223"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 58,
    Value = System.Net.IPAddress.Parse("70.178.185.134"),
    NullableValue = System.Net.IPAddress.Parse("46.230.10.33"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 63,
    Value = System.Net.IPAddress.Parse("29.234.186.126"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 61,
    Value = System.Net.IPAddress.Parse("33.33.136.238"),
    NullableValue = System.Net.IPAddress.Parse("226.26.108.239"),
},
    NullableValue = System.Net.IPAddress.Parse("18.109.105.173"),
},
            new IPAddressIPv40M
{
    Id = 65,
    Value = System.Net.IPAddress.Parse("196.64.186.179"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 69,
    Value = System.Net.IPAddress.Parse("99.89.185.222"),
    NullableValue = System.Net.IPAddress.Parse("7.94.8.110"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 66,
    Value = System.Net.IPAddress.Parse("95.171.199.160"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 78,
    Value = System.Net.IPAddress.Parse("234.239.234.223"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("124.252.169.68"),
},
            new IPAddressIPv40M
{
    Id = 67,
    Value = System.Net.IPAddress.Parse("164.23.77.233"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 80,
    Value = System.Net.IPAddress.Parse("220.31.82.203"),
    NullableValue = System.Net.IPAddress.Parse("229.102.2.27"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 75,
    Value = System.Net.IPAddress.Parse("245.158.219.223"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 89,
    Value = System.Net.IPAddress.Parse("73.12.216.6"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("47.133.240.189"),
},
            new IPAddressIPv40M
{
    Id = 82,
    Value = System.Net.IPAddress.Parse("138.183.11.164"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 93,
    Value = System.Net.IPAddress.Parse("99.10.27.119"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("183.117.186.174"),
},
            new IPAddressIPv40M
{
    Id = 89,
    Value = System.Net.IPAddress.Parse("240.249.92.133"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 102,
    Value = System.Net.IPAddress.Parse("250.204.21.245"),
    NullableValue = System.Net.IPAddress.Parse("179.230.207.244"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 98,
    Value = System.Net.IPAddress.Parse("109.194.16.189"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 104,
    Value = System.Net.IPAddress.Parse("5.15.11.74"),
    NullableValue = System.Net.IPAddress.Parse("190.227.212.155"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 107,
    Value = System.Net.IPAddress.Parse("53.52.134.112"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 106,
    Value = System.Net.IPAddress.Parse("205.38.221.85"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("54.182.174.230"),
},
            new IPAddressIPv40M
{
    Id = 110,
    Value = System.Net.IPAddress.Parse("25.12.128.13"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 112,
    Value = System.Net.IPAddress.Parse("167.34.74.163"),
    NullableValue = System.Net.IPAddress.Parse("91.185.0.11"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 118,
    Value = System.Net.IPAddress.Parse("218.86.108.97"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 114,
    Value = System.Net.IPAddress.Parse("21.95.154.146"),
    NullableValue = System.Net.IPAddress.Parse("4.91.220.160"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 122,
    Value = System.Net.IPAddress.Parse("28.19.197.120"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 116,
    Value = System.Net.IPAddress.Parse("44.91.65.151"),
    NullableValue = System.Net.IPAddress.Parse("175.205.4.189"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 126,
    Value = System.Net.IPAddress.Parse("0.46.125.195"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 118,
    Value = System.Net.IPAddress.Parse("86.53.78.240"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("221.150.74.18"),
},
            new IPAddressIPv40M
{
    Id = 133,
    Value = System.Net.IPAddress.Parse("247.1.112.74"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 127,
    Value = System.Net.IPAddress.Parse("91.140.143.72"),
    NullableValue = System.Net.IPAddress.Parse("92.46.77.117"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 137,
    Value = System.Net.IPAddress.Parse("121.171.157.58"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 132,
    Value = System.Net.IPAddress.Parse("131.44.251.64"),
    NullableValue = System.Net.IPAddress.Parse("224.113.15.69"),
},
    NullableValue = System.Net.IPAddress.Parse("151.178.26.96"),
},
            new IPAddressIPv40M
{
    Id = 142,
    Value = System.Net.IPAddress.Parse("45.180.223.99"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 133,
    Value = System.Net.IPAddress.Parse("195.160.160.200"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("166.9.123.164"),
},
            new IPAddressIPv40M
{
    Id = 147,
    Value = System.Net.IPAddress.Parse("96.155.59.102"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 136,
    Value = System.Net.IPAddress.Parse("71.31.57.147"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("237.111.19.79"),
},
            new IPAddressIPv40M
{
    Id = 153,
    Value = System.Net.IPAddress.Parse("27.45.37.26"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 139,
    Value = System.Net.IPAddress.Parse("139.196.80.137"),
    NullableValue = System.Net.IPAddress.Parse("117.59.57.48"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 156,
    Value = System.Net.IPAddress.Parse("221.100.59.247"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 147,
    Value = System.Net.IPAddress.Parse("238.6.242.235"),
    NullableValue = System.Net.IPAddress.Parse("105.242.2.88"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 157,
    Value = System.Net.IPAddress.Parse("24.44.91.54"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 156,
    Value = System.Net.IPAddress.Parse("72.206.218.216"),
    NullableValue = System.Net.IPAddress.Parse("204.147.27.249"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 161,
    Value = System.Net.IPAddress.Parse("185.46.190.213"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 160,
    Value = System.Net.IPAddress.Parse("159.213.192.203"),
    NullableValue = System.Net.IPAddress.Parse("12.94.160.95"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 168,
    Value = System.Net.IPAddress.Parse("215.64.113.133"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 162,
    Value = System.Net.IPAddress.Parse("18.146.75.237"),
    NullableValue = System.Net.IPAddress.Parse("213.156.237.29"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 172,
    Value = System.Net.IPAddress.Parse("96.97.91.37"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 169,
    Value = System.Net.IPAddress.Parse("175.231.239.147"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 179,
    Value = System.Net.IPAddress.Parse("207.80.21.126"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 176,
    Value = System.Net.IPAddress.Parse("17.227.74.101"),
    NullableValue = System.Net.IPAddress.Parse("151.136.102.249"),
},
    NullableValue = System.Net.IPAddress.Parse("204.8.122.166"),
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

