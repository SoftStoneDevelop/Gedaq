

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
    Id = 2,
    Value = System.Net.IPAddress.Parse("53.237.39.148"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 4,
    Value = System.Net.IPAddress.Parse("68.175.71.111"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 8,
    Value = System.Net.IPAddress.Parse("248.148.138.143"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 9,
    Value = System.Net.IPAddress.Parse("52.63.194.222"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 13,
    Value = System.Net.IPAddress.Parse("254.55.200.7"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 11,
    Value = System.Net.IPAddress.Parse("189.149.89.40"),
    NullableValue = System.Net.IPAddress.Parse("49.152.47.204"),
},
    NullableValue = System.Net.IPAddress.Parse("15.13.34.93"),
},
            new IPAddressIPv40M
{
    Id = 22,
    Value = System.Net.IPAddress.Parse("133.25.223.112"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 15,
    Value = System.Net.IPAddress.Parse("178.220.214.177"),
    NullableValue = System.Net.IPAddress.Parse("27.149.81.155"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 26,
    Value = System.Net.IPAddress.Parse("119.122.46.30"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 21,
    Value = System.Net.IPAddress.Parse("162.71.52.62"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 30,
    Value = System.Net.IPAddress.Parse("36.245.201.33"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 25,
    Value = System.Net.IPAddress.Parse("111.9.249.20"),
    NullableValue = System.Net.IPAddress.Parse("135.46.161.106"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 34,
    Value = System.Net.IPAddress.Parse("225.138.47.160"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 31,
    Value = System.Net.IPAddress.Parse("188.92.106.222"),
    NullableValue = System.Net.IPAddress.Parse("87.76.171.200"),
},
    NullableValue = System.Net.IPAddress.Parse("230.175.59.115"),
},
            new IPAddressIPv40M
{
    Id = 39,
    Value = System.Net.IPAddress.Parse("7.99.194.3"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 37,
    Value = System.Net.IPAddress.Parse("110.51.3.107"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 40,
    Value = System.Net.IPAddress.Parse("1.178.190.85"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 44,
    Value = System.Net.IPAddress.Parse("153.230.3.56"),
    NullableValue = System.Net.IPAddress.Parse("201.144.208.141"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 45,
    Value = System.Net.IPAddress.Parse("41.221.165.93"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 53,
    Value = System.Net.IPAddress.Parse("148.82.201.208"),
    NullableValue = System.Net.IPAddress.Parse("1.115.72.160"),
},
    NullableValue = System.Net.IPAddress.Parse("128.95.204.19"),
},
            new IPAddressIPv40M
{
    Id = 47,
    Value = System.Net.IPAddress.Parse("54.96.239.183"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 59,
    Value = System.Net.IPAddress.Parse("58.247.221.53"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 48,
    Value = System.Net.IPAddress.Parse("245.85.146.35"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 61,
    Value = System.Net.IPAddress.Parse("28.207.52.76"),
    NullableValue = System.Net.IPAddress.Parse("112.139.84.237"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 55,
    Value = System.Net.IPAddress.Parse("130.157.126.134"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 69,
    Value = System.Net.IPAddress.Parse("5.193.218.63"),
    NullableValue = System.Net.IPAddress.Parse("69.61.23.216"),
},
    NullableValue = System.Net.IPAddress.Parse("220.242.192.227"),
},
            new IPAddressIPv40M
{
    Id = 62,
    Value = System.Net.IPAddress.Parse("243.29.190.78"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 70,
    Value = System.Net.IPAddress.Parse("189.79.78.66"),
    NullableValue = System.Net.IPAddress.Parse("64.182.100.120"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 68,
    Value = System.Net.IPAddress.Parse("226.151.163.168"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 73,
    Value = System.Net.IPAddress.Parse("65.153.51.129"),
    NullableValue = System.Net.IPAddress.Parse("17.20.39.22"),
},
    NullableValue = System.Net.IPAddress.Parse("120.170.190.42"),
},
            new IPAddressIPv40M
{
    Id = 75,
    Value = System.Net.IPAddress.Parse("66.134.206.78"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 77,
    Value = System.Net.IPAddress.Parse("130.106.230.30"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 81,
    Value = System.Net.IPAddress.Parse("164.59.237.181"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 80,
    Value = System.Net.IPAddress.Parse("126.183.152.60"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("124.38.67.49"),
},
            new IPAddressIPv40M
{
    Id = 85,
    Value = System.Net.IPAddress.Parse("183.135.105.145"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 87,
    Value = System.Net.IPAddress.Parse("130.79.195.76"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("85.89.113.204"),
},
            new IPAddressIPv40M
{
    Id = 87,
    Value = System.Net.IPAddress.Parse("241.250.165.206"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 92,
    Value = System.Net.IPAddress.Parse("183.83.35.184"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("234.49.250.42"),
},
            new IPAddressIPv40M
{
    Id = 96,
    Value = System.Net.IPAddress.Parse("227.101.76.137"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 93,
    Value = System.Net.IPAddress.Parse("158.228.25.206"),
    NullableValue = System.Net.IPAddress.Parse("239.216.142.185"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 101,
    Value = System.Net.IPAddress.Parse("101.8.83.158"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 94,
    Value = System.Net.IPAddress.Parse("164.184.129.59"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 104,
    Value = System.Net.IPAddress.Parse("243.201.209.179"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 103,
    Value = System.Net.IPAddress.Parse("74.25.69.91"),
    NullableValue = System.Net.IPAddress.Parse("162.85.227.73"),
},
    NullableValue = System.Net.IPAddress.Parse("240.224.19.214"),
},
            new IPAddressIPv40M
{
    Id = 113,
    Value = System.Net.IPAddress.Parse("85.3.58.96"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 104,
    Value = System.Net.IPAddress.Parse("241.67.163.84"),
    NullableValue = System.Net.IPAddress.Parse("226.40.193.63"),
},
    NullableValue = System.Net.IPAddress.Parse("220.91.246.158"),
},
            new IPAddressIPv40M
{
    Id = 120,
    Value = System.Net.IPAddress.Parse("91.250.244.140"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 107,
    Value = System.Net.IPAddress.Parse("131.14.239.81"),
    NullableValue = System.Net.IPAddress.Parse("85.91.82.77"),
},
    NullableValue = System.Net.IPAddress.Parse("33.60.57.137"),
},
            new IPAddressIPv40M
{
    Id = 125,
    Value = System.Net.IPAddress.Parse("230.184.40.7"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 108,
    Value = System.Net.IPAddress.Parse("179.50.27.80"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("19.115.148.77"),
},
            new IPAddressIPv40M
{
    Id = 128,
    Value = System.Net.IPAddress.Parse("164.201.213.63"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 110,
    Value = System.Net.IPAddress.Parse("122.154.169.69"),
    NullableValue = System.Net.IPAddress.Parse("180.37.16.205"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 137,
    Value = System.Net.IPAddress.Parse("30.103.112.90"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 116,
    Value = System.Net.IPAddress.Parse("122.185.181.16"),
    NullableValue = System.Net.IPAddress.Parse("168.236.175.171"),
},
    NullableValue = System.Net.IPAddress.Parse("222.203.254.26"),
},
            new IPAddressIPv40M
{
    Id = 145,
    Value = System.Net.IPAddress.Parse("57.97.136.7"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 118,
    Value = System.Net.IPAddress.Parse("247.202.121.248"),
    NullableValue = System.Net.IPAddress.Parse("68.229.183.214"),
},
    NullableValue = System.Net.IPAddress.Parse("61.40.142.20"),
},
            new IPAddressIPv40M
{
    Id = 148,
    Value = System.Net.IPAddress.Parse("15.218.175.176"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 127,
    Value = System.Net.IPAddress.Parse("169.134.22.185"),
    NullableValue = System.Net.IPAddress.Parse("246.31.41.90"),
},
    NullableValue = System.Net.IPAddress.Parse("216.46.57.207"),
},
            new IPAddressIPv40M
{
    Id = 156,
    Value = System.Net.IPAddress.Parse("167.118.109.157"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 128,
    Value = System.Net.IPAddress.Parse("197.89.36.197"),
    NullableValue = System.Net.IPAddress.Parse("83.147.57.49"),
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 158,
    Value = System.Net.IPAddress.Parse("163.239.4.224"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 137,
    Value = System.Net.IPAddress.Parse("109.45.199.146"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 163,
    Value = System.Net.IPAddress.Parse("188.40.14.213"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 144,
    Value = System.Net.IPAddress.Parse("142.128.175.95"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressIPv40M
{
    Id = 169,
    Value = System.Net.IPAddress.Parse("123.36.239.129"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 153,
    Value = System.Net.IPAddress.Parse("148.49.174.166"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("127.145.100.122"),
},
            new IPAddressIPv40M
{
    Id = 170,
    Value = System.Net.IPAddress.Parse("69.246.173.79"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 158,
    Value = System.Net.IPAddress.Parse("86.170.246.150"),
    NullableValue = System.Net.IPAddress.Parse("151.51.48.39"),
},
    NullableValue = System.Net.IPAddress.Parse("108.200.88.39"),
},
            new IPAddressIPv40M
{
    Id = 178,
    Value = System.Net.IPAddress.Parse("228.52.73.209"),
    ModelInner = new IPAddressIPv40MI
{
    Id = 164,
    Value = System.Net.IPAddress.Parse("205.223.112.244"),
    NullableValue = System.Net.IPAddress.Parse("97.171.202.126"),
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

