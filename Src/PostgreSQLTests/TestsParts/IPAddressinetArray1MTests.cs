

using Npgsql;
using NpgsqlTypes;
using Gedaq.Common.Enums;
using Gedaq.Npgsql.Attributes;
using Gedaq.Npgsql.Enums;
using System;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IIPAddressArrayinetArray
    {
    }
    
    internal partial class IPAddressArrayinetArray : IIPAddressArrayinetArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray1mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
);
",
            methodName:"InsertModelInner",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray1mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
)
RETURNING
    id,
    value,
    nullablevalue
;
",
            methodName:"InsertModelInnerReturning",
            queryMapType: typeof(IPAddressinetArray1MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)
                )
            ]
        public void InsertModelInnerReturningConfig()
        {
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IIPAddressArrayinetArray)this).InsertModelInner(connection, 1147700318, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("23.44.179.107"),

System.Net.IPAddress.Parse("196.169.22.130"),

System.Net.IPAddress.Parse("60.74.92.160"),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IIPAddressArrayinetArray)this).InsertModelInner(connection, 2060396617, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.220.56.129"),

System.Net.IPAddress.Parse("248.21.142.228"),

System.Net.IPAddress.Parse("55.148.181.184"),

System.Net.IPAddress.Parse("222.209.222.92"),

}, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("84.225.137.209"),

System.Net.IPAddress.Parse("27.250.31.59"),

System.Net.IPAddress.Parse("84.59.229.42"),

System.Net.IPAddress.Parse("228.151.53.140"),

});
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((IIPAddressArrayinetArray)this).InsertModelInnerAsync(connection, 898710886, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("215.1.195.107"),

System.Net.IPAddress.Parse("132.185.46.52"),

System.Net.IPAddress.Parse("114.104.142.186"),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressArrayinetArray)this).InsertModelInnerAsync(connection, 1635158325, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.184.164.177"),

System.Net.IPAddress.Parse("87.109.19.33"),

System.Net.IPAddress.Parse("6.0.249.18"),

System.Net.IPAddress.Parse("228.186.18.232"),

}, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.232.248.181"),

System.Net.IPAddress.Parse("254.96.62.95"),

System.Net.IPAddress.Parse("204.27.232.250"),

System.Net.IPAddress.Parse("98.74.63.60"),

});
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturning()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((IIPAddressArrayinetArray)this).InsertModelInnerReturning(connection, 765048204, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.91.147.201"),

System.Net.IPAddress.Parse("147.186.92.48"),

System.Net.IPAddress.Parse("60.71.196.10"),

}, null);
                Assert.That(id, Is.EqualTo(765048204));

                id =  ((IIPAddressArrayinetArray)this).InsertModelInnerReturning(connection, 489967818, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("252.111.135.144"),

System.Net.IPAddress.Parse("142.252.49.61"),

System.Net.IPAddress.Parse("210.184.110.102"),

System.Net.IPAddress.Parse("17.109.148.61"),

}, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.231.247.43"),

System.Net.IPAddress.Parse("212.228.220.217"),

System.Net.IPAddress.Parse("1.77.163.184"),

System.Net.IPAddress.Parse("88.223.57.100"),

});
                Assert.That(id, Is.EqualTo(489967818));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, 1025710404, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("188.72.220.140"),

System.Net.IPAddress.Parse("149.193.199.245"),

System.Net.IPAddress.Parse("219.59.217.173"),

System.Net.IPAddress.Parse("184.132.20.223"),

}, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.12.106.182"),

System.Net.IPAddress.Parse("68.197.243.110"),

System.Net.IPAddress.Parse("241.168.234.162"),

});
                Assert.That(id, Is.EqualTo(1025710404));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, 114614856, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.38.190.64"),

System.Net.IPAddress.Parse("247.12.180.224"),

System.Net.IPAddress.Parse("5.87.110.35"),

System.Net.IPAddress.Parse("106.199.97.74"),

}, null);
                Assert.That(id, Is.EqualTo(114614856));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, 70676916, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("39.60.201.212"),

System.Net.IPAddress.Parse("196.215.17.174"),

System.Net.IPAddress.Parse("228.167.214.185"),

}, null);
                Assert.That(id, Is.EqualTo(70676916));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, 1189751706, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("91.60.140.37"),

System.Net.IPAddress.Parse("150.130.185.226"),

System.Net.IPAddress.Parse("230.21.248.241"),

System.Net.IPAddress.Parse("139.55.222.245"),

}, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("110.70.123.82"),

System.Net.IPAddress.Parse("32.62.116.191"),

System.Net.IPAddress.Parse("74.32.19.198"),

System.Net.IPAddress.Parse("82.243.186.251"),

});
                Assert.That(id, Is.EqualTo(1189751706));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, 734112495, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.57.201.27"),

System.Net.IPAddress.Parse("106.212.15.97"),

System.Net.IPAddress.Parse("213.83.18.25"),

System.Net.IPAddress.Parse("150.36.102.95"),

}, null);
                Assert.That(id, Is.EqualTo(734112495));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, 953727391, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("114.235.170.224"),

System.Net.IPAddress.Parse("193.13.164.151"),

System.Net.IPAddress.Parse("129.238.44.105"),

System.Net.IPAddress.Parse("5.34.244.103"),

}, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("44.89.163.66"),

System.Net.IPAddress.Parse("123.156.187.110"),

System.Net.IPAddress.Parse("96.179.241.171"),

System.Net.IPAddress.Parse("128.45.209.239"),

});
                Assert.That(id, Is.EqualTo(953727391));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, 1862467653, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.88.48.172"),

System.Net.IPAddress.Parse("77.111.187.235"),

System.Net.IPAddress.Parse("140.225.127.72"),

System.Net.IPAddress.Parse("20.222.226.65"),

}, null);
                Assert.That(id, Is.EqualTo(1862467653));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, 1524374413, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("17.243.164.43"),

System.Net.IPAddress.Parse("249.75.193.185"),

System.Net.IPAddress.Parse("250.156.153.118"),

System.Net.IPAddress.Parse("162.55.7.224"),

}, null);
                Assert.That(id, Is.EqualTo(1524374413));

                id = await ((IIPAddressArrayinetArray)this).InsertModelInnerReturningAsync(connection, 1225266561, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("161.64.174.220"),

System.Net.IPAddress.Parse("10.108.45.165"),

System.Net.IPAddress.Parse("236.217.123.2"),

System.Net.IPAddress.Parse("119.54.240.25"),

}, null);
                Assert.That(id, Is.EqualTo(1225266561));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray1m(
	id,
    value,
    nullablevalue,
    ipaddressinetarray1mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "ipaddressinetarray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                )
            ]
        public void InsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IIPAddressArrayinetArray)this).InsertModel(connection, 1528940929, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.6.57.43"),

System.Net.IPAddress.Parse("5.149.125.169"),

System.Net.IPAddress.Parse("43.150.87.253"),

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IIPAddressArrayinetArray)this).InsertModel(connection, 1114047125, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.47.150.250"),

System.Net.IPAddress.Parse("76.64.178.53"),

System.Net.IPAddress.Parse("74.110.254.56"),

System.Net.IPAddress.Parse("56.58.223.51"),

}, null, 1147700318);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((IIPAddressArrayinetArray)this).InsertModelAsync(connection, 1559862906, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("123.191.2.57"),

System.Net.IPAddress.Parse("69.224.113.83"),

System.Net.IPAddress.Parse("102.231.52.253"),

System.Net.IPAddress.Parse("18.4.226.114"),

}, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("254.83.134.181"),

System.Net.IPAddress.Parse("17.232.110.65"),

System.Net.IPAddress.Parse("118.41.56.117"),

System.Net.IPAddress.Parse("129.39.242.162"),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressArrayinetArray)this).InsertModelAsync(connection, 503659545, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("73.216.243.144"),

System.Net.IPAddress.Parse("24.177.166.236"),

System.Net.IPAddress.Parse("115.136.95.27"),

}, null, 2060396617);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Net.IPAddress[] nullable = null;

                nullable =  ((IIPAddressArrayinetArray)this).ScalarInsertModelReturning(connection, 1725349754, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("70.250.73.189"),

System.Net.IPAddress.Parse("95.140.155.78"),

System.Net.IPAddress.Parse("70.94.62.170"),

}, null, null);

                Assert.That(nullable, Is.Null);

                nullable =  ((IIPAddressArrayinetArray)this).ScalarInsertModelReturning(connection, 149175584, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("143.53.239.41"),

System.Net.IPAddress.Parse("240.239.90.237"),

System.Net.IPAddress.Parse("106.206.209.132"),

System.Net.IPAddress.Parse("118.238.228.56"),

}, null, 898710886);

                Assert.That(nullable, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Net.IPAddress[] nullable = null;

                nullable = await ((IIPAddressArrayinetArray)this).ScalarInsertModelReturningAsync(connection, 1717745304, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.137.169.190"),

System.Net.IPAddress.Parse("229.203.251.158"),

System.Net.IPAddress.Parse("171.237.52.109"),

System.Net.IPAddress.Parse("50.147.178.154"),

}, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("172.185.204.186"),

System.Net.IPAddress.Parse("106.82.31.235"),

System.Net.IPAddress.Parse("206.208.220.69"),

}, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("172.185.204.186"),

System.Net.IPAddress.Parse("106.82.31.235"),

System.Net.IPAddress.Parse("206.208.220.69"),

}));

                nullable = await ((IIPAddressArrayinetArray)this).ScalarInsertModelReturningAsync(connection, 2136763513, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.114.250.7"),

System.Net.IPAddress.Parse("218.55.187.129"),

System.Net.IPAddress.Parse("174.79.51.80"),

}, null, 1635158325);

                Assert.That(nullable, Is.Null);

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray1m(
	id,
    value,
    nullablevalue,
    ipaddressinetarray1mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    ipaddressinetarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(IPAddressinetArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "ipaddressinetarray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                )
            ]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetArray1M> models = null;
                IPAddressinetArray1M model = null;

                models =  ((IIPAddressArrayinetArray)this).InsertModelReturning(connection, 1196291033, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("47.247.169.252"),

System.Net.IPAddress.Parse("18.219.84.183"),

System.Net.IPAddress.Parse("13.50.146.145"),

System.Net.IPAddress.Parse("0.239.215.227"),

}, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.119.178.252"),

System.Net.IPAddress.Parse("96.77.21.228"),

System.Net.IPAddress.Parse("226.72.38.185"),

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196291033));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("47.247.169.252"),

System.Net.IPAddress.Parse("18.219.84.183"),

System.Net.IPAddress.Parse("13.50.146.145"),

System.Net.IPAddress.Parse("0.239.215.227"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.119.178.252"),

System.Net.IPAddress.Parse("96.77.21.228"),

System.Net.IPAddress.Parse("226.72.38.185"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IIPAddressArrayinetArray)this).InsertModelReturning(connection, 1046694119, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.87.137.111"),

System.Net.IPAddress.Parse("204.14.65.176"),

System.Net.IPAddress.Parse("194.85.205.44"),

System.Net.IPAddress.Parse("222.89.92.13"),

}, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("174.246.168.218"),

System.Net.IPAddress.Parse("90.240.212.154"),

System.Net.IPAddress.Parse("111.18.35.98"),

System.Net.IPAddress.Parse("58.185.189.175"),

}, 765048204).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1046694119));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.87.137.111"),

System.Net.IPAddress.Parse("204.14.65.176"),

System.Net.IPAddress.Parse("194.85.205.44"),

System.Net.IPAddress.Parse("222.89.92.13"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("174.246.168.218"),

System.Net.IPAddress.Parse("90.240.212.154"),

System.Net.IPAddress.Parse("111.18.35.98"),

System.Net.IPAddress.Parse("58.185.189.175"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(765048204));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Net.IPAddress[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IIPAddressArrayinetArray)this).InsertModelReturning(connection, 514896285, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.219.216.117"),

System.Net.IPAddress.Parse("89.223.230.10"),

System.Net.IPAddress.Parse("101.237.229.93"),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(514896285));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.219.216.117"),

System.Net.IPAddress.Parse("89.223.230.10"),

System.Net.IPAddress.Parse("101.237.229.93"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IIPAddressArrayinetArray)this).InsertModelReturning(connection, 120708206, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("192.57.237.242"),

System.Net.IPAddress.Parse("197.216.231.206"),

System.Net.IPAddress.Parse("242.236.138.184"),

System.Net.IPAddress.Parse("125.3.72.107"),

}, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("64.10.240.26"),

System.Net.IPAddress.Parse("236.225.164.217"),

System.Net.IPAddress.Parse("252.158.32.102"),

System.Net.IPAddress.Parse("82.19.117.150"),

}, 489967818).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(120708206));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("192.57.237.242"),

System.Net.IPAddress.Parse("197.216.231.206"),

System.Net.IPAddress.Parse("242.236.138.184"),

System.Net.IPAddress.Parse("125.3.72.107"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("64.10.240.26"),

System.Net.IPAddress.Parse("236.225.164.217"),

System.Net.IPAddress.Parse("252.158.32.102"),

System.Net.IPAddress.Parse("82.19.117.150"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(489967818));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Net.IPAddress[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetArray1M> models = null;
                IPAddressinetArray1M model = null;

                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, 1836676977, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.164.33.149"),

System.Net.IPAddress.Parse("23.121.117.30"),

System.Net.IPAddress.Parse("14.189.80.148"),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1836676977));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.164.33.149"),

System.Net.IPAddress.Parse("23.121.117.30"),

System.Net.IPAddress.Parse("14.189.80.148"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, 2021824710, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.16.104.58"),

System.Net.IPAddress.Parse("153.225.37.221"),

System.Net.IPAddress.Parse("83.156.198.153"),

System.Net.IPAddress.Parse("96.225.216.80"),

}, null, 1025710404).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2021824710));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.16.104.58"),

System.Net.IPAddress.Parse("153.225.37.221"),

System.Net.IPAddress.Parse("83.156.198.153"),

System.Net.IPAddress.Parse("96.225.216.80"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1025710404));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Net.IPAddress[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, 1471142734, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("140.200.7.193"),

System.Net.IPAddress.Parse("63.81.70.232"),

System.Net.IPAddress.Parse("79.66.113.10"),

}, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("3.239.18.161"),

System.Net.IPAddress.Parse("16.25.54.42"),

System.Net.IPAddress.Parse("69.98.250.33"),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1471142734));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("140.200.7.193"),

System.Net.IPAddress.Parse("63.81.70.232"),

System.Net.IPAddress.Parse("79.66.113.10"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("3.239.18.161"),

System.Net.IPAddress.Parse("16.25.54.42"),

System.Net.IPAddress.Parse("69.98.250.33"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, 1978357694, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.51.23.223"),

System.Net.IPAddress.Parse("134.241.157.196"),

System.Net.IPAddress.Parse("90.94.206.223"),

}, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.7.110.41"),

System.Net.IPAddress.Parse("165.134.153.235"),

System.Net.IPAddress.Parse("238.83.157.117"),

}, 114614856).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1978357694));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.51.23.223"),

System.Net.IPAddress.Parse("134.241.157.196"),

System.Net.IPAddress.Parse("90.94.206.223"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.7.110.41"),

System.Net.IPAddress.Parse("165.134.153.235"),

System.Net.IPAddress.Parse("238.83.157.117"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(114614856));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Net.IPAddress[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, 1790443824, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("45.225.201.133"),

System.Net.IPAddress.Parse("198.20.142.127"),

System.Net.IPAddress.Parse("66.225.239.188"),

System.Net.IPAddress.Parse("227.77.214.15"),

}, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.171.228.100"),

System.Net.IPAddress.Parse("157.88.2.37"),

System.Net.IPAddress.Parse("189.136.20.241"),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1790443824));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("45.225.201.133"),

System.Net.IPAddress.Parse("198.20.142.127"),

System.Net.IPAddress.Parse("66.225.239.188"),

System.Net.IPAddress.Parse("227.77.214.15"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.171.228.100"),

System.Net.IPAddress.Parse("157.88.2.37"),

System.Net.IPAddress.Parse("189.136.20.241"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, 1699076580, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("214.85.93.26"),

System.Net.IPAddress.Parse("106.226.172.212"),

System.Net.IPAddress.Parse("171.14.233.176"),

}, null, 70676916).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1699076580));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("214.85.93.26"),

System.Net.IPAddress.Parse("106.226.172.212"),

System.Net.IPAddress.Parse("171.14.233.176"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(70676916));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Net.IPAddress[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, 1715136659, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("150.90.144.88"),

System.Net.IPAddress.Parse("157.149.111.4"),

System.Net.IPAddress.Parse("147.122.4.69"),

System.Net.IPAddress.Parse("130.156.150.72"),

}, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.78.207.181"),

System.Net.IPAddress.Parse("181.240.67.47"),

System.Net.IPAddress.Parse("56.133.18.53"),

System.Net.IPAddress.Parse("134.229.3.96"),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1715136659));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("150.90.144.88"),

System.Net.IPAddress.Parse("157.149.111.4"),

System.Net.IPAddress.Parse("147.122.4.69"),

System.Net.IPAddress.Parse("130.156.150.72"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.78.207.181"),

System.Net.IPAddress.Parse("181.240.67.47"),

System.Net.IPAddress.Parse("56.133.18.53"),

System.Net.IPAddress.Parse("134.229.3.96"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, 1661207245, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.80.27.184"),

System.Net.IPAddress.Parse("30.2.102.227"),

System.Net.IPAddress.Parse("135.251.204.127"),

System.Net.IPAddress.Parse("246.191.51.237"),

}, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.156.39.174"),

System.Net.IPAddress.Parse("35.142.118.69"),

System.Net.IPAddress.Parse("43.123.160.110"),

}, 1189751706).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1661207245));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.80.27.184"),

System.Net.IPAddress.Parse("30.2.102.227"),

System.Net.IPAddress.Parse("135.251.204.127"),

System.Net.IPAddress.Parse("246.191.51.237"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.156.39.174"),

System.Net.IPAddress.Parse("35.142.118.69"),

System.Net.IPAddress.Parse("43.123.160.110"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1189751706));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Net.IPAddress[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, 408444095, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("139.249.252.248"),

System.Net.IPAddress.Parse("144.156.246.243"),

System.Net.IPAddress.Parse("7.121.72.34"),

}, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("181.47.77.188"),

System.Net.IPAddress.Parse("135.31.242.74"),

System.Net.IPAddress.Parse("45.228.252.243"),

System.Net.IPAddress.Parse("139.12.116.83"),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(408444095));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("139.249.252.248"),

System.Net.IPAddress.Parse("144.156.246.243"),

System.Net.IPAddress.Parse("7.121.72.34"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("181.47.77.188"),

System.Net.IPAddress.Parse("135.31.242.74"),

System.Net.IPAddress.Parse("45.228.252.243"),

System.Net.IPAddress.Parse("139.12.116.83"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, 1010630797, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("163.15.105.153"),

System.Net.IPAddress.Parse("168.113.141.115"),

System.Net.IPAddress.Parse("88.155.244.27"),

System.Net.IPAddress.Parse("96.94.105.38"),

}, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("13.112.111.81"),

System.Net.IPAddress.Parse("145.60.238.238"),

System.Net.IPAddress.Parse("56.181.140.233"),

System.Net.IPAddress.Parse("170.79.152.19"),

}, 734112495).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1010630797));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("163.15.105.153"),

System.Net.IPAddress.Parse("168.113.141.115"),

System.Net.IPAddress.Parse("88.155.244.27"),

System.Net.IPAddress.Parse("96.94.105.38"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("13.112.111.81"),

System.Net.IPAddress.Parse("145.60.238.238"),

System.Net.IPAddress.Parse("56.181.140.233"),

System.Net.IPAddress.Parse("170.79.152.19"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(734112495));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Net.IPAddress[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, 1349174950, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("183.169.138.174"),

System.Net.IPAddress.Parse("95.113.93.167"),

System.Net.IPAddress.Parse("78.227.47.135"),

}, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.145.155.228"),

System.Net.IPAddress.Parse("161.29.190.42"),

System.Net.IPAddress.Parse("168.125.120.148"),

System.Net.IPAddress.Parse("132.155.66.187"),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1349174950));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("183.169.138.174"),

System.Net.IPAddress.Parse("95.113.93.167"),

System.Net.IPAddress.Parse("78.227.47.135"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.145.155.228"),

System.Net.IPAddress.Parse("161.29.190.42"),

System.Net.IPAddress.Parse("168.125.120.148"),

System.Net.IPAddress.Parse("132.155.66.187"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, 1532913521, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("235.117.103.135"),

System.Net.IPAddress.Parse("15.13.51.218"),

System.Net.IPAddress.Parse("197.99.85.98"),

}, null, 953727391).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1532913521));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("235.117.103.135"),

System.Net.IPAddress.Parse("15.13.51.218"),

System.Net.IPAddress.Parse("197.99.85.98"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(953727391));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Net.IPAddress[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, 852427647, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("82.144.42.52"),

System.Net.IPAddress.Parse("220.191.234.145"),

System.Net.IPAddress.Parse("159.116.235.144"),

System.Net.IPAddress.Parse("174.135.250.231"),

}, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("71.164.41.0"),

System.Net.IPAddress.Parse("61.59.30.55"),

System.Net.IPAddress.Parse("45.244.40.47"),

System.Net.IPAddress.Parse("7.148.181.24"),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(852427647));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("82.144.42.52"),

System.Net.IPAddress.Parse("220.191.234.145"),

System.Net.IPAddress.Parse("159.116.235.144"),

System.Net.IPAddress.Parse("174.135.250.231"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("71.164.41.0"),

System.Net.IPAddress.Parse("61.59.30.55"),

System.Net.IPAddress.Parse("45.244.40.47"),

System.Net.IPAddress.Parse("7.148.181.24"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, 1014982688, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("22.191.189.215"),

System.Net.IPAddress.Parse("65.198.53.118"),

System.Net.IPAddress.Parse("253.82.111.81"),

System.Net.IPAddress.Parse("109.106.219.163"),

}, null, 1862467653).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1014982688));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("22.191.189.215"),

System.Net.IPAddress.Parse("65.198.53.118"),

System.Net.IPAddress.Parse("253.82.111.81"),

System.Net.IPAddress.Parse("109.106.219.163"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1862467653));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Net.IPAddress[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, 2147260456, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("222.254.104.151"),

System.Net.IPAddress.Parse("35.120.204.142"),

System.Net.IPAddress.Parse("237.29.120.229"),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147260456));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("222.254.104.151"),

System.Net.IPAddress.Parse("35.120.204.142"),

System.Net.IPAddress.Parse("237.29.120.229"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, 940810195, 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.213.206.216"),

System.Net.IPAddress.Parse("72.223.64.78"),

System.Net.IPAddress.Parse("231.212.27.90"),

System.Net.IPAddress.Parse("183.1.33.133"),

}, null, 1524374413).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(940810195));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.213.206.216"),

System.Net.IPAddress.Parse("72.223.64.78"),

System.Net.IPAddress.Parse("231.212.27.90"),

System.Net.IPAddress.Parse("183.1.33.133"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1524374413));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Net.IPAddress[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, 15009278, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("124.154.94.55"),

System.Net.IPAddress.Parse("157.124.158.178"),

System.Net.IPAddress.Parse("49.165.141.3"),

}, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("105.80.72.238"),

System.Net.IPAddress.Parse("210.212.26.232"),

System.Net.IPAddress.Parse("154.77.207.133"),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(15009278));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("124.154.94.55"),

System.Net.IPAddress.Parse("157.124.158.178"),

System.Net.IPAddress.Parse("49.165.141.3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("105.80.72.238"),

System.Net.IPAddress.Parse("210.212.26.232"),

System.Net.IPAddress.Parse("154.77.207.133"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IIPAddressArrayinetArray)this).InsertModelReturningAsync(connection, 131351132, 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("41.56.170.121"),

System.Net.IPAddress.Parse("249.177.86.74"),

System.Net.IPAddress.Parse("52.16.51.138"),

}, null, 1225266561).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(131351132));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("41.56.170.121"),

System.Net.IPAddress.Parse("249.177.86.74"),

System.Net.IPAddress.Parse("52.16.51.138"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1225266561));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Net.IPAddress[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        #endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.ipaddressinetarray1m m
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(IPAddressinetArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)
            ),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                )
            ]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IIPAddressArrayinetArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(15009278));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("124.154.94.55"),

System.Net.IPAddress.Parse("157.124.158.178"),

System.Net.IPAddress.Parse("49.165.141.3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("105.80.72.238"),

System.Net.IPAddress.Parse("210.212.26.232"),

System.Net.IPAddress.Parse("154.77.207.133"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(120708206));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("192.57.237.242"),

System.Net.IPAddress.Parse("197.216.231.206"),

System.Net.IPAddress.Parse("242.236.138.184"),

System.Net.IPAddress.Parse("125.3.72.107"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("64.10.240.26"),

System.Net.IPAddress.Parse("236.225.164.217"),

System.Net.IPAddress.Parse("252.158.32.102"),

System.Net.IPAddress.Parse("82.19.117.150"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(489967818));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("252.111.135.144"),

System.Net.IPAddress.Parse("142.252.49.61"),

System.Net.IPAddress.Parse("210.184.110.102"),

System.Net.IPAddress.Parse("17.109.148.61"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.231.247.43"),

System.Net.IPAddress.Parse("212.228.220.217"),

System.Net.IPAddress.Parse("1.77.163.184"),

System.Net.IPAddress.Parse("88.223.57.100"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(131351132));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("41.56.170.121"),

System.Net.IPAddress.Parse("249.177.86.74"),

System.Net.IPAddress.Parse("52.16.51.138"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1225266561));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("161.64.174.220"),

System.Net.IPAddress.Parse("10.108.45.165"),

System.Net.IPAddress.Parse("236.217.123.2"),

System.Net.IPAddress.Parse("119.54.240.25"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(149175584));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("143.53.239.41"),

System.Net.IPAddress.Parse("240.239.90.237"),

System.Net.IPAddress.Parse("106.206.209.132"),

System.Net.IPAddress.Parse("118.238.228.56"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(898710886));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("215.1.195.107"),

System.Net.IPAddress.Parse("132.185.46.52"),

System.Net.IPAddress.Parse("114.104.142.186"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(408444095));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("139.249.252.248"),

System.Net.IPAddress.Parse("144.156.246.243"),

System.Net.IPAddress.Parse("7.121.72.34"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("181.47.77.188"),

System.Net.IPAddress.Parse("135.31.242.74"),

System.Net.IPAddress.Parse("45.228.252.243"),

System.Net.IPAddress.Parse("139.12.116.83"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(503659545));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("73.216.243.144"),

System.Net.IPAddress.Parse("24.177.166.236"),

System.Net.IPAddress.Parse("115.136.95.27"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2060396617));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.220.56.129"),

System.Net.IPAddress.Parse("248.21.142.228"),

System.Net.IPAddress.Parse("55.148.181.184"),

System.Net.IPAddress.Parse("222.209.222.92"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("84.225.137.209"),

System.Net.IPAddress.Parse("27.250.31.59"),

System.Net.IPAddress.Parse("84.59.229.42"),

System.Net.IPAddress.Parse("228.151.53.140"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(514896285));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.219.216.117"),

System.Net.IPAddress.Parse("89.223.230.10"),

System.Net.IPAddress.Parse("101.237.229.93"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(852427647));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("82.144.42.52"),

System.Net.IPAddress.Parse("220.191.234.145"),

System.Net.IPAddress.Parse("159.116.235.144"),

System.Net.IPAddress.Parse("174.135.250.231"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("71.164.41.0"),

System.Net.IPAddress.Parse("61.59.30.55"),

System.Net.IPAddress.Parse("45.244.40.47"),

System.Net.IPAddress.Parse("7.148.181.24"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(940810195));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.213.206.216"),

System.Net.IPAddress.Parse("72.223.64.78"),

System.Net.IPAddress.Parse("231.212.27.90"),

System.Net.IPAddress.Parse("183.1.33.133"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1524374413));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("17.243.164.43"),

System.Net.IPAddress.Parse("249.75.193.185"),

System.Net.IPAddress.Parse("250.156.153.118"),

System.Net.IPAddress.Parse("162.55.7.224"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1010630797));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("163.15.105.153"),

System.Net.IPAddress.Parse("168.113.141.115"),

System.Net.IPAddress.Parse("88.155.244.27"),

System.Net.IPAddress.Parse("96.94.105.38"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("13.112.111.81"),

System.Net.IPAddress.Parse("145.60.238.238"),

System.Net.IPAddress.Parse("56.181.140.233"),

System.Net.IPAddress.Parse("170.79.152.19"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(734112495));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.57.201.27"),

System.Net.IPAddress.Parse("106.212.15.97"),

System.Net.IPAddress.Parse("213.83.18.25"),

System.Net.IPAddress.Parse("150.36.102.95"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1014982688));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("22.191.189.215"),

System.Net.IPAddress.Parse("65.198.53.118"),

System.Net.IPAddress.Parse("253.82.111.81"),

System.Net.IPAddress.Parse("109.106.219.163"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1862467653));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.88.48.172"),

System.Net.IPAddress.Parse("77.111.187.235"),

System.Net.IPAddress.Parse("140.225.127.72"),

System.Net.IPAddress.Parse("20.222.226.65"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1046694119));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.87.137.111"),

System.Net.IPAddress.Parse("204.14.65.176"),

System.Net.IPAddress.Parse("194.85.205.44"),

System.Net.IPAddress.Parse("222.89.92.13"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("174.246.168.218"),

System.Net.IPAddress.Parse("90.240.212.154"),

System.Net.IPAddress.Parse("111.18.35.98"),

System.Net.IPAddress.Parse("58.185.189.175"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(765048204));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.91.147.201"),

System.Net.IPAddress.Parse("147.186.92.48"),

System.Net.IPAddress.Parse("60.71.196.10"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1114047125));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.47.150.250"),

System.Net.IPAddress.Parse("76.64.178.53"),

System.Net.IPAddress.Parse("74.110.254.56"),

System.Net.IPAddress.Parse("56.58.223.51"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1147700318));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("23.44.179.107"),

System.Net.IPAddress.Parse("196.169.22.130"),

System.Net.IPAddress.Parse("60.74.92.160"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196291033));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("47.247.169.252"),

System.Net.IPAddress.Parse("18.219.84.183"),

System.Net.IPAddress.Parse("13.50.146.145"),

System.Net.IPAddress.Parse("0.239.215.227"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.119.178.252"),

System.Net.IPAddress.Parse("96.77.21.228"),

System.Net.IPAddress.Parse("226.72.38.185"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1349174950));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("183.169.138.174"),

System.Net.IPAddress.Parse("95.113.93.167"),

System.Net.IPAddress.Parse("78.227.47.135"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.145.155.228"),

System.Net.IPAddress.Parse("161.29.190.42"),

System.Net.IPAddress.Parse("168.125.120.148"),

System.Net.IPAddress.Parse("132.155.66.187"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1471142734));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("140.200.7.193"),

System.Net.IPAddress.Parse("63.81.70.232"),

System.Net.IPAddress.Parse("79.66.113.10"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("3.239.18.161"),

System.Net.IPAddress.Parse("16.25.54.42"),

System.Net.IPAddress.Parse("69.98.250.33"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1528940929));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.6.57.43"),

System.Net.IPAddress.Parse("5.149.125.169"),

System.Net.IPAddress.Parse("43.150.87.253"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1532913521));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("235.117.103.135"),

System.Net.IPAddress.Parse("15.13.51.218"),

System.Net.IPAddress.Parse("197.99.85.98"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(953727391));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("114.235.170.224"),

System.Net.IPAddress.Parse("193.13.164.151"),

System.Net.IPAddress.Parse("129.238.44.105"),

System.Net.IPAddress.Parse("5.34.244.103"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("44.89.163.66"),

System.Net.IPAddress.Parse("123.156.187.110"),

System.Net.IPAddress.Parse("96.179.241.171"),

System.Net.IPAddress.Parse("128.45.209.239"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1559862906));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("123.191.2.57"),

System.Net.IPAddress.Parse("69.224.113.83"),

System.Net.IPAddress.Parse("102.231.52.253"),

System.Net.IPAddress.Parse("18.4.226.114"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("254.83.134.181"),

System.Net.IPAddress.Parse("17.232.110.65"),

System.Net.IPAddress.Parse("118.41.56.117"),

System.Net.IPAddress.Parse("129.39.242.162"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1661207245));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.80.27.184"),

System.Net.IPAddress.Parse("30.2.102.227"),

System.Net.IPAddress.Parse("135.251.204.127"),

System.Net.IPAddress.Parse("246.191.51.237"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.156.39.174"),

System.Net.IPAddress.Parse("35.142.118.69"),

System.Net.IPAddress.Parse("43.123.160.110"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1189751706));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("91.60.140.37"),

System.Net.IPAddress.Parse("150.130.185.226"),

System.Net.IPAddress.Parse("230.21.248.241"),

System.Net.IPAddress.Parse("139.55.222.245"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("110.70.123.82"),

System.Net.IPAddress.Parse("32.62.116.191"),

System.Net.IPAddress.Parse("74.32.19.198"),

System.Net.IPAddress.Parse("82.243.186.251"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1699076580));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("214.85.93.26"),

System.Net.IPAddress.Parse("106.226.172.212"),

System.Net.IPAddress.Parse("171.14.233.176"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(70676916));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("39.60.201.212"),

System.Net.IPAddress.Parse("196.215.17.174"),

System.Net.IPAddress.Parse("228.167.214.185"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1715136659));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("150.90.144.88"),

System.Net.IPAddress.Parse("157.149.111.4"),

System.Net.IPAddress.Parse("147.122.4.69"),

System.Net.IPAddress.Parse("130.156.150.72"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.78.207.181"),

System.Net.IPAddress.Parse("181.240.67.47"),

System.Net.IPAddress.Parse("56.133.18.53"),

System.Net.IPAddress.Parse("134.229.3.96"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1717745304));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.137.169.190"),

System.Net.IPAddress.Parse("229.203.251.158"),

System.Net.IPAddress.Parse("171.237.52.109"),

System.Net.IPAddress.Parse("50.147.178.154"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("172.185.204.186"),

System.Net.IPAddress.Parse("106.82.31.235"),

System.Net.IPAddress.Parse("206.208.220.69"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1725349754));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("70.250.73.189"),

System.Net.IPAddress.Parse("95.140.155.78"),

System.Net.IPAddress.Parse("70.94.62.170"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1790443824));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("45.225.201.133"),

System.Net.IPAddress.Parse("198.20.142.127"),

System.Net.IPAddress.Parse("66.225.239.188"),

System.Net.IPAddress.Parse("227.77.214.15"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.171.228.100"),

System.Net.IPAddress.Parse("157.88.2.37"),

System.Net.IPAddress.Parse("189.136.20.241"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1836676977));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.164.33.149"),

System.Net.IPAddress.Parse("23.121.117.30"),

System.Net.IPAddress.Parse("14.189.80.148"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1978357694));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.51.23.223"),

System.Net.IPAddress.Parse("134.241.157.196"),

System.Net.IPAddress.Parse("90.94.206.223"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.7.110.41"),

System.Net.IPAddress.Parse("165.134.153.235"),

System.Net.IPAddress.Parse("238.83.157.117"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(114614856));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.38.190.64"),

System.Net.IPAddress.Parse("247.12.180.224"),

System.Net.IPAddress.Parse("5.87.110.35"),

System.Net.IPAddress.Parse("106.199.97.74"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2021824710));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.16.104.58"),

System.Net.IPAddress.Parse("153.225.37.221"),

System.Net.IPAddress.Parse("83.156.198.153"),

System.Net.IPAddress.Parse("96.225.216.80"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1025710404));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("188.72.220.140"),

System.Net.IPAddress.Parse("149.193.199.245"),

System.Net.IPAddress.Parse("219.59.217.173"),

System.Net.IPAddress.Parse("184.132.20.223"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.12.106.182"),

System.Net.IPAddress.Parse("68.197.243.110"),

System.Net.IPAddress.Parse("241.168.234.162"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2136763513));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.114.250.7"),

System.Net.IPAddress.Parse("218.55.187.129"),

System.Net.IPAddress.Parse("174.79.51.80"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1635158325));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.184.164.177"),

System.Net.IPAddress.Parse("87.109.19.33"),

System.Net.IPAddress.Parse("6.0.249.18"),

System.Net.IPAddress.Parse("228.186.18.232"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.232.248.181"),

System.Net.IPAddress.Parse("254.96.62.95"),

System.Net.IPAddress.Parse("204.27.232.250"),

System.Net.IPAddress.Parse("98.74.63.60"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147260456));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("222.254.104.151"),

System.Net.IPAddress.Parse("35.120.204.142"),

System.Net.IPAddress.Parse("237.29.120.229"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressArrayinetArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(15009278));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("124.154.94.55"),

System.Net.IPAddress.Parse("157.124.158.178"),

System.Net.IPAddress.Parse("49.165.141.3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("105.80.72.238"),

System.Net.IPAddress.Parse("210.212.26.232"),

System.Net.IPAddress.Parse("154.77.207.133"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(120708206));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("192.57.237.242"),

System.Net.IPAddress.Parse("197.216.231.206"),

System.Net.IPAddress.Parse("242.236.138.184"),

System.Net.IPAddress.Parse("125.3.72.107"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("64.10.240.26"),

System.Net.IPAddress.Parse("236.225.164.217"),

System.Net.IPAddress.Parse("252.158.32.102"),

System.Net.IPAddress.Parse("82.19.117.150"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(489967818));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("252.111.135.144"),

System.Net.IPAddress.Parse("142.252.49.61"),

System.Net.IPAddress.Parse("210.184.110.102"),

System.Net.IPAddress.Parse("17.109.148.61"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.231.247.43"),

System.Net.IPAddress.Parse("212.228.220.217"),

System.Net.IPAddress.Parse("1.77.163.184"),

System.Net.IPAddress.Parse("88.223.57.100"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(131351132));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("41.56.170.121"),

System.Net.IPAddress.Parse("249.177.86.74"),

System.Net.IPAddress.Parse("52.16.51.138"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1225266561));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("161.64.174.220"),

System.Net.IPAddress.Parse("10.108.45.165"),

System.Net.IPAddress.Parse("236.217.123.2"),

System.Net.IPAddress.Parse("119.54.240.25"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(149175584));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("143.53.239.41"),

System.Net.IPAddress.Parse("240.239.90.237"),

System.Net.IPAddress.Parse("106.206.209.132"),

System.Net.IPAddress.Parse("118.238.228.56"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(898710886));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("215.1.195.107"),

System.Net.IPAddress.Parse("132.185.46.52"),

System.Net.IPAddress.Parse("114.104.142.186"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(408444095));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("139.249.252.248"),

System.Net.IPAddress.Parse("144.156.246.243"),

System.Net.IPAddress.Parse("7.121.72.34"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("181.47.77.188"),

System.Net.IPAddress.Parse("135.31.242.74"),

System.Net.IPAddress.Parse("45.228.252.243"),

System.Net.IPAddress.Parse("139.12.116.83"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(503659545));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("73.216.243.144"),

System.Net.IPAddress.Parse("24.177.166.236"),

System.Net.IPAddress.Parse("115.136.95.27"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2060396617));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.220.56.129"),

System.Net.IPAddress.Parse("248.21.142.228"),

System.Net.IPAddress.Parse("55.148.181.184"),

System.Net.IPAddress.Parse("222.209.222.92"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("84.225.137.209"),

System.Net.IPAddress.Parse("27.250.31.59"),

System.Net.IPAddress.Parse("84.59.229.42"),

System.Net.IPAddress.Parse("228.151.53.140"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(514896285));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.219.216.117"),

System.Net.IPAddress.Parse("89.223.230.10"),

System.Net.IPAddress.Parse("101.237.229.93"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(852427647));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("82.144.42.52"),

System.Net.IPAddress.Parse("220.191.234.145"),

System.Net.IPAddress.Parse("159.116.235.144"),

System.Net.IPAddress.Parse("174.135.250.231"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("71.164.41.0"),

System.Net.IPAddress.Parse("61.59.30.55"),

System.Net.IPAddress.Parse("45.244.40.47"),

System.Net.IPAddress.Parse("7.148.181.24"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(940810195));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.213.206.216"),

System.Net.IPAddress.Parse("72.223.64.78"),

System.Net.IPAddress.Parse("231.212.27.90"),

System.Net.IPAddress.Parse("183.1.33.133"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1524374413));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("17.243.164.43"),

System.Net.IPAddress.Parse("249.75.193.185"),

System.Net.IPAddress.Parse("250.156.153.118"),

System.Net.IPAddress.Parse("162.55.7.224"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1010630797));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("163.15.105.153"),

System.Net.IPAddress.Parse("168.113.141.115"),

System.Net.IPAddress.Parse("88.155.244.27"),

System.Net.IPAddress.Parse("96.94.105.38"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("13.112.111.81"),

System.Net.IPAddress.Parse("145.60.238.238"),

System.Net.IPAddress.Parse("56.181.140.233"),

System.Net.IPAddress.Parse("170.79.152.19"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(734112495));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.57.201.27"),

System.Net.IPAddress.Parse("106.212.15.97"),

System.Net.IPAddress.Parse("213.83.18.25"),

System.Net.IPAddress.Parse("150.36.102.95"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1014982688));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("22.191.189.215"),

System.Net.IPAddress.Parse("65.198.53.118"),

System.Net.IPAddress.Parse("253.82.111.81"),

System.Net.IPAddress.Parse("109.106.219.163"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1862467653));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.88.48.172"),

System.Net.IPAddress.Parse("77.111.187.235"),

System.Net.IPAddress.Parse("140.225.127.72"),

System.Net.IPAddress.Parse("20.222.226.65"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1046694119));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.87.137.111"),

System.Net.IPAddress.Parse("204.14.65.176"),

System.Net.IPAddress.Parse("194.85.205.44"),

System.Net.IPAddress.Parse("222.89.92.13"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("174.246.168.218"),

System.Net.IPAddress.Parse("90.240.212.154"),

System.Net.IPAddress.Parse("111.18.35.98"),

System.Net.IPAddress.Parse("58.185.189.175"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(765048204));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.91.147.201"),

System.Net.IPAddress.Parse("147.186.92.48"),

System.Net.IPAddress.Parse("60.71.196.10"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1114047125));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.47.150.250"),

System.Net.IPAddress.Parse("76.64.178.53"),

System.Net.IPAddress.Parse("74.110.254.56"),

System.Net.IPAddress.Parse("56.58.223.51"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1147700318));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("23.44.179.107"),

System.Net.IPAddress.Parse("196.169.22.130"),

System.Net.IPAddress.Parse("60.74.92.160"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196291033));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("47.247.169.252"),

System.Net.IPAddress.Parse("18.219.84.183"),

System.Net.IPAddress.Parse("13.50.146.145"),

System.Net.IPAddress.Parse("0.239.215.227"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.119.178.252"),

System.Net.IPAddress.Parse("96.77.21.228"),

System.Net.IPAddress.Parse("226.72.38.185"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1349174950));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("183.169.138.174"),

System.Net.IPAddress.Parse("95.113.93.167"),

System.Net.IPAddress.Parse("78.227.47.135"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.145.155.228"),

System.Net.IPAddress.Parse("161.29.190.42"),

System.Net.IPAddress.Parse("168.125.120.148"),

System.Net.IPAddress.Parse("132.155.66.187"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1471142734));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("140.200.7.193"),

System.Net.IPAddress.Parse("63.81.70.232"),

System.Net.IPAddress.Parse("79.66.113.10"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("3.239.18.161"),

System.Net.IPAddress.Parse("16.25.54.42"),

System.Net.IPAddress.Parse("69.98.250.33"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1528940929));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.6.57.43"),

System.Net.IPAddress.Parse("5.149.125.169"),

System.Net.IPAddress.Parse("43.150.87.253"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1532913521));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("235.117.103.135"),

System.Net.IPAddress.Parse("15.13.51.218"),

System.Net.IPAddress.Parse("197.99.85.98"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(953727391));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("114.235.170.224"),

System.Net.IPAddress.Parse("193.13.164.151"),

System.Net.IPAddress.Parse("129.238.44.105"),

System.Net.IPAddress.Parse("5.34.244.103"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("44.89.163.66"),

System.Net.IPAddress.Parse("123.156.187.110"),

System.Net.IPAddress.Parse("96.179.241.171"),

System.Net.IPAddress.Parse("128.45.209.239"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1559862906));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("123.191.2.57"),

System.Net.IPAddress.Parse("69.224.113.83"),

System.Net.IPAddress.Parse("102.231.52.253"),

System.Net.IPAddress.Parse("18.4.226.114"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("254.83.134.181"),

System.Net.IPAddress.Parse("17.232.110.65"),

System.Net.IPAddress.Parse("118.41.56.117"),

System.Net.IPAddress.Parse("129.39.242.162"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1661207245));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.80.27.184"),

System.Net.IPAddress.Parse("30.2.102.227"),

System.Net.IPAddress.Parse("135.251.204.127"),

System.Net.IPAddress.Parse("246.191.51.237"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.156.39.174"),

System.Net.IPAddress.Parse("35.142.118.69"),

System.Net.IPAddress.Parse("43.123.160.110"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1189751706));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("91.60.140.37"),

System.Net.IPAddress.Parse("150.130.185.226"),

System.Net.IPAddress.Parse("230.21.248.241"),

System.Net.IPAddress.Parse("139.55.222.245"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("110.70.123.82"),

System.Net.IPAddress.Parse("32.62.116.191"),

System.Net.IPAddress.Parse("74.32.19.198"),

System.Net.IPAddress.Parse("82.243.186.251"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1699076580));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("214.85.93.26"),

System.Net.IPAddress.Parse("106.226.172.212"),

System.Net.IPAddress.Parse("171.14.233.176"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(70676916));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("39.60.201.212"),

System.Net.IPAddress.Parse("196.215.17.174"),

System.Net.IPAddress.Parse("228.167.214.185"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1715136659));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("150.90.144.88"),

System.Net.IPAddress.Parse("157.149.111.4"),

System.Net.IPAddress.Parse("147.122.4.69"),

System.Net.IPAddress.Parse("130.156.150.72"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.78.207.181"),

System.Net.IPAddress.Parse("181.240.67.47"),

System.Net.IPAddress.Parse("56.133.18.53"),

System.Net.IPAddress.Parse("134.229.3.96"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1717745304));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.137.169.190"),

System.Net.IPAddress.Parse("229.203.251.158"),

System.Net.IPAddress.Parse("171.237.52.109"),

System.Net.IPAddress.Parse("50.147.178.154"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("172.185.204.186"),

System.Net.IPAddress.Parse("106.82.31.235"),

System.Net.IPAddress.Parse("206.208.220.69"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1725349754));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("70.250.73.189"),

System.Net.IPAddress.Parse("95.140.155.78"),

System.Net.IPAddress.Parse("70.94.62.170"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1790443824));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("45.225.201.133"),

System.Net.IPAddress.Parse("198.20.142.127"),

System.Net.IPAddress.Parse("66.225.239.188"),

System.Net.IPAddress.Parse("227.77.214.15"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.171.228.100"),

System.Net.IPAddress.Parse("157.88.2.37"),

System.Net.IPAddress.Parse("189.136.20.241"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1836676977));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.164.33.149"),

System.Net.IPAddress.Parse("23.121.117.30"),

System.Net.IPAddress.Parse("14.189.80.148"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1978357694));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.51.23.223"),

System.Net.IPAddress.Parse("134.241.157.196"),

System.Net.IPAddress.Parse("90.94.206.223"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.7.110.41"),

System.Net.IPAddress.Parse("165.134.153.235"),

System.Net.IPAddress.Parse("238.83.157.117"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(114614856));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.38.190.64"),

System.Net.IPAddress.Parse("247.12.180.224"),

System.Net.IPAddress.Parse("5.87.110.35"),

System.Net.IPAddress.Parse("106.199.97.74"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2021824710));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.16.104.58"),

System.Net.IPAddress.Parse("153.225.37.221"),

System.Net.IPAddress.Parse("83.156.198.153"),

System.Net.IPAddress.Parse("96.225.216.80"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1025710404));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("188.72.220.140"),

System.Net.IPAddress.Parse("149.193.199.245"),

System.Net.IPAddress.Parse("219.59.217.173"),

System.Net.IPAddress.Parse("184.132.20.223"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.12.106.182"),

System.Net.IPAddress.Parse("68.197.243.110"),

System.Net.IPAddress.Parse("241.168.234.162"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2136763513));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.114.250.7"),

System.Net.IPAddress.Parse("218.55.187.129"),

System.Net.IPAddress.Parse("174.79.51.80"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1635158325));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.184.164.177"),

System.Net.IPAddress.Parse("87.109.19.33"),

System.Net.IPAddress.Parse("6.0.249.18"),

System.Net.IPAddress.Parse("228.186.18.232"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.232.248.181"),

System.Net.IPAddress.Parse("254.96.62.95"),

System.Net.IPAddress.Parse("204.27.232.250"),

System.Net.IPAddress.Parse("98.74.63.60"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147260456));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("222.254.104.151"),

System.Net.IPAddress.Parse("35.120.204.142"),

System.Net.IPAddress.Parse("237.29.120.229"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.ipaddressinetarray1m m
LEFT JOIN public.ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(IPAddressinetArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)
            ),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11)
                )
            ]
        private void DbConnectionSelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IIPAddressArrayinetArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(15009278));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("124.154.94.55"),

System.Net.IPAddress.Parse("157.124.158.178"),

System.Net.IPAddress.Parse("49.165.141.3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("105.80.72.238"),

System.Net.IPAddress.Parse("210.212.26.232"),

System.Net.IPAddress.Parse("154.77.207.133"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(120708206));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("192.57.237.242"),

System.Net.IPAddress.Parse("197.216.231.206"),

System.Net.IPAddress.Parse("242.236.138.184"),

System.Net.IPAddress.Parse("125.3.72.107"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("64.10.240.26"),

System.Net.IPAddress.Parse("236.225.164.217"),

System.Net.IPAddress.Parse("252.158.32.102"),

System.Net.IPAddress.Parse("82.19.117.150"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(489967818));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("252.111.135.144"),

System.Net.IPAddress.Parse("142.252.49.61"),

System.Net.IPAddress.Parse("210.184.110.102"),

System.Net.IPAddress.Parse("17.109.148.61"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.231.247.43"),

System.Net.IPAddress.Parse("212.228.220.217"),

System.Net.IPAddress.Parse("1.77.163.184"),

System.Net.IPAddress.Parse("88.223.57.100"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(131351132));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("41.56.170.121"),

System.Net.IPAddress.Parse("249.177.86.74"),

System.Net.IPAddress.Parse("52.16.51.138"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1225266561));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("161.64.174.220"),

System.Net.IPAddress.Parse("10.108.45.165"),

System.Net.IPAddress.Parse("236.217.123.2"),

System.Net.IPAddress.Parse("119.54.240.25"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(149175584));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("143.53.239.41"),

System.Net.IPAddress.Parse("240.239.90.237"),

System.Net.IPAddress.Parse("106.206.209.132"),

System.Net.IPAddress.Parse("118.238.228.56"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(898710886));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("215.1.195.107"),

System.Net.IPAddress.Parse("132.185.46.52"),

System.Net.IPAddress.Parse("114.104.142.186"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(408444095));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("139.249.252.248"),

System.Net.IPAddress.Parse("144.156.246.243"),

System.Net.IPAddress.Parse("7.121.72.34"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("181.47.77.188"),

System.Net.IPAddress.Parse("135.31.242.74"),

System.Net.IPAddress.Parse("45.228.252.243"),

System.Net.IPAddress.Parse("139.12.116.83"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(503659545));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("73.216.243.144"),

System.Net.IPAddress.Parse("24.177.166.236"),

System.Net.IPAddress.Parse("115.136.95.27"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2060396617));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.220.56.129"),

System.Net.IPAddress.Parse("248.21.142.228"),

System.Net.IPAddress.Parse("55.148.181.184"),

System.Net.IPAddress.Parse("222.209.222.92"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("84.225.137.209"),

System.Net.IPAddress.Parse("27.250.31.59"),

System.Net.IPAddress.Parse("84.59.229.42"),

System.Net.IPAddress.Parse("228.151.53.140"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(514896285));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.219.216.117"),

System.Net.IPAddress.Parse("89.223.230.10"),

System.Net.IPAddress.Parse("101.237.229.93"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(852427647));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("82.144.42.52"),

System.Net.IPAddress.Parse("220.191.234.145"),

System.Net.IPAddress.Parse("159.116.235.144"),

System.Net.IPAddress.Parse("174.135.250.231"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("71.164.41.0"),

System.Net.IPAddress.Parse("61.59.30.55"),

System.Net.IPAddress.Parse("45.244.40.47"),

System.Net.IPAddress.Parse("7.148.181.24"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(940810195));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.213.206.216"),

System.Net.IPAddress.Parse("72.223.64.78"),

System.Net.IPAddress.Parse("231.212.27.90"),

System.Net.IPAddress.Parse("183.1.33.133"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1524374413));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("17.243.164.43"),

System.Net.IPAddress.Parse("249.75.193.185"),

System.Net.IPAddress.Parse("250.156.153.118"),

System.Net.IPAddress.Parse("162.55.7.224"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1010630797));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("163.15.105.153"),

System.Net.IPAddress.Parse("168.113.141.115"),

System.Net.IPAddress.Parse("88.155.244.27"),

System.Net.IPAddress.Parse("96.94.105.38"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("13.112.111.81"),

System.Net.IPAddress.Parse("145.60.238.238"),

System.Net.IPAddress.Parse("56.181.140.233"),

System.Net.IPAddress.Parse("170.79.152.19"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(734112495));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.57.201.27"),

System.Net.IPAddress.Parse("106.212.15.97"),

System.Net.IPAddress.Parse("213.83.18.25"),

System.Net.IPAddress.Parse("150.36.102.95"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1014982688));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("22.191.189.215"),

System.Net.IPAddress.Parse("65.198.53.118"),

System.Net.IPAddress.Parse("253.82.111.81"),

System.Net.IPAddress.Parse("109.106.219.163"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1862467653));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.88.48.172"),

System.Net.IPAddress.Parse("77.111.187.235"),

System.Net.IPAddress.Parse("140.225.127.72"),

System.Net.IPAddress.Parse("20.222.226.65"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1046694119));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.87.137.111"),

System.Net.IPAddress.Parse("204.14.65.176"),

System.Net.IPAddress.Parse("194.85.205.44"),

System.Net.IPAddress.Parse("222.89.92.13"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("174.246.168.218"),

System.Net.IPAddress.Parse("90.240.212.154"),

System.Net.IPAddress.Parse("111.18.35.98"),

System.Net.IPAddress.Parse("58.185.189.175"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(765048204));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.91.147.201"),

System.Net.IPAddress.Parse("147.186.92.48"),

System.Net.IPAddress.Parse("60.71.196.10"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1114047125));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.47.150.250"),

System.Net.IPAddress.Parse("76.64.178.53"),

System.Net.IPAddress.Parse("74.110.254.56"),

System.Net.IPAddress.Parse("56.58.223.51"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1147700318));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("23.44.179.107"),

System.Net.IPAddress.Parse("196.169.22.130"),

System.Net.IPAddress.Parse("60.74.92.160"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196291033));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("47.247.169.252"),

System.Net.IPAddress.Parse("18.219.84.183"),

System.Net.IPAddress.Parse("13.50.146.145"),

System.Net.IPAddress.Parse("0.239.215.227"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.119.178.252"),

System.Net.IPAddress.Parse("96.77.21.228"),

System.Net.IPAddress.Parse("226.72.38.185"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1349174950));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("183.169.138.174"),

System.Net.IPAddress.Parse("95.113.93.167"),

System.Net.IPAddress.Parse("78.227.47.135"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.145.155.228"),

System.Net.IPAddress.Parse("161.29.190.42"),

System.Net.IPAddress.Parse("168.125.120.148"),

System.Net.IPAddress.Parse("132.155.66.187"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1471142734));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("140.200.7.193"),

System.Net.IPAddress.Parse("63.81.70.232"),

System.Net.IPAddress.Parse("79.66.113.10"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("3.239.18.161"),

System.Net.IPAddress.Parse("16.25.54.42"),

System.Net.IPAddress.Parse("69.98.250.33"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1528940929));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.6.57.43"),

System.Net.IPAddress.Parse("5.149.125.169"),

System.Net.IPAddress.Parse("43.150.87.253"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1532913521));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("235.117.103.135"),

System.Net.IPAddress.Parse("15.13.51.218"),

System.Net.IPAddress.Parse("197.99.85.98"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(953727391));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("114.235.170.224"),

System.Net.IPAddress.Parse("193.13.164.151"),

System.Net.IPAddress.Parse("129.238.44.105"),

System.Net.IPAddress.Parse("5.34.244.103"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("44.89.163.66"),

System.Net.IPAddress.Parse("123.156.187.110"),

System.Net.IPAddress.Parse("96.179.241.171"),

System.Net.IPAddress.Parse("128.45.209.239"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1559862906));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("123.191.2.57"),

System.Net.IPAddress.Parse("69.224.113.83"),

System.Net.IPAddress.Parse("102.231.52.253"),

System.Net.IPAddress.Parse("18.4.226.114"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("254.83.134.181"),

System.Net.IPAddress.Parse("17.232.110.65"),

System.Net.IPAddress.Parse("118.41.56.117"),

System.Net.IPAddress.Parse("129.39.242.162"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1661207245));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.80.27.184"),

System.Net.IPAddress.Parse("30.2.102.227"),

System.Net.IPAddress.Parse("135.251.204.127"),

System.Net.IPAddress.Parse("246.191.51.237"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.156.39.174"),

System.Net.IPAddress.Parse("35.142.118.69"),

System.Net.IPAddress.Parse("43.123.160.110"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1189751706));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("91.60.140.37"),

System.Net.IPAddress.Parse("150.130.185.226"),

System.Net.IPAddress.Parse("230.21.248.241"),

System.Net.IPAddress.Parse("139.55.222.245"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("110.70.123.82"),

System.Net.IPAddress.Parse("32.62.116.191"),

System.Net.IPAddress.Parse("74.32.19.198"),

System.Net.IPAddress.Parse("82.243.186.251"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1699076580));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("214.85.93.26"),

System.Net.IPAddress.Parse("106.226.172.212"),

System.Net.IPAddress.Parse("171.14.233.176"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(70676916));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("39.60.201.212"),

System.Net.IPAddress.Parse("196.215.17.174"),

System.Net.IPAddress.Parse("228.167.214.185"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1715136659));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("150.90.144.88"),

System.Net.IPAddress.Parse("157.149.111.4"),

System.Net.IPAddress.Parse("147.122.4.69"),

System.Net.IPAddress.Parse("130.156.150.72"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.78.207.181"),

System.Net.IPAddress.Parse("181.240.67.47"),

System.Net.IPAddress.Parse("56.133.18.53"),

System.Net.IPAddress.Parse("134.229.3.96"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1717745304));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.137.169.190"),

System.Net.IPAddress.Parse("229.203.251.158"),

System.Net.IPAddress.Parse("171.237.52.109"),

System.Net.IPAddress.Parse("50.147.178.154"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("172.185.204.186"),

System.Net.IPAddress.Parse("106.82.31.235"),

System.Net.IPAddress.Parse("206.208.220.69"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1725349754));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("70.250.73.189"),

System.Net.IPAddress.Parse("95.140.155.78"),

System.Net.IPAddress.Parse("70.94.62.170"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1790443824));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("45.225.201.133"),

System.Net.IPAddress.Parse("198.20.142.127"),

System.Net.IPAddress.Parse("66.225.239.188"),

System.Net.IPAddress.Parse("227.77.214.15"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.171.228.100"),

System.Net.IPAddress.Parse("157.88.2.37"),

System.Net.IPAddress.Parse("189.136.20.241"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1836676977));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.164.33.149"),

System.Net.IPAddress.Parse("23.121.117.30"),

System.Net.IPAddress.Parse("14.189.80.148"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1978357694));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.51.23.223"),

System.Net.IPAddress.Parse("134.241.157.196"),

System.Net.IPAddress.Parse("90.94.206.223"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.7.110.41"),

System.Net.IPAddress.Parse("165.134.153.235"),

System.Net.IPAddress.Parse("238.83.157.117"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(114614856));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.38.190.64"),

System.Net.IPAddress.Parse("247.12.180.224"),

System.Net.IPAddress.Parse("5.87.110.35"),

System.Net.IPAddress.Parse("106.199.97.74"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2021824710));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.16.104.58"),

System.Net.IPAddress.Parse("153.225.37.221"),

System.Net.IPAddress.Parse("83.156.198.153"),

System.Net.IPAddress.Parse("96.225.216.80"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1025710404));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("188.72.220.140"),

System.Net.IPAddress.Parse("149.193.199.245"),

System.Net.IPAddress.Parse("219.59.217.173"),

System.Net.IPAddress.Parse("184.132.20.223"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.12.106.182"),

System.Net.IPAddress.Parse("68.197.243.110"),

System.Net.IPAddress.Parse("241.168.234.162"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2136763513));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.114.250.7"),

System.Net.IPAddress.Parse("218.55.187.129"),

System.Net.IPAddress.Parse("174.79.51.80"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1635158325));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.184.164.177"),

System.Net.IPAddress.Parse("87.109.19.33"),

System.Net.IPAddress.Parse("6.0.249.18"),

System.Net.IPAddress.Parse("228.186.18.232"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.232.248.181"),

System.Net.IPAddress.Parse("254.96.62.95"),

System.Net.IPAddress.Parse("204.27.232.250"),

System.Net.IPAddress.Parse("98.74.63.60"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147260456));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("222.254.104.151"),

System.Net.IPAddress.Parse("35.120.204.142"),

System.Net.IPAddress.Parse("237.29.120.229"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressArrayinetArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(15009278));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("124.154.94.55"),

System.Net.IPAddress.Parse("157.124.158.178"),

System.Net.IPAddress.Parse("49.165.141.3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("105.80.72.238"),

System.Net.IPAddress.Parse("210.212.26.232"),

System.Net.IPAddress.Parse("154.77.207.133"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(120708206));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("192.57.237.242"),

System.Net.IPAddress.Parse("197.216.231.206"),

System.Net.IPAddress.Parse("242.236.138.184"),

System.Net.IPAddress.Parse("125.3.72.107"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("64.10.240.26"),

System.Net.IPAddress.Parse("236.225.164.217"),

System.Net.IPAddress.Parse("252.158.32.102"),

System.Net.IPAddress.Parse("82.19.117.150"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(489967818));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("252.111.135.144"),

System.Net.IPAddress.Parse("142.252.49.61"),

System.Net.IPAddress.Parse("210.184.110.102"),

System.Net.IPAddress.Parse("17.109.148.61"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.231.247.43"),

System.Net.IPAddress.Parse("212.228.220.217"),

System.Net.IPAddress.Parse("1.77.163.184"),

System.Net.IPAddress.Parse("88.223.57.100"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(131351132));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("41.56.170.121"),

System.Net.IPAddress.Parse("249.177.86.74"),

System.Net.IPAddress.Parse("52.16.51.138"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1225266561));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("161.64.174.220"),

System.Net.IPAddress.Parse("10.108.45.165"),

System.Net.IPAddress.Parse("236.217.123.2"),

System.Net.IPAddress.Parse("119.54.240.25"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(149175584));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("143.53.239.41"),

System.Net.IPAddress.Parse("240.239.90.237"),

System.Net.IPAddress.Parse("106.206.209.132"),

System.Net.IPAddress.Parse("118.238.228.56"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(898710886));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("215.1.195.107"),

System.Net.IPAddress.Parse("132.185.46.52"),

System.Net.IPAddress.Parse("114.104.142.186"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(408444095));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("139.249.252.248"),

System.Net.IPAddress.Parse("144.156.246.243"),

System.Net.IPAddress.Parse("7.121.72.34"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("181.47.77.188"),

System.Net.IPAddress.Parse("135.31.242.74"),

System.Net.IPAddress.Parse("45.228.252.243"),

System.Net.IPAddress.Parse("139.12.116.83"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(503659545));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("73.216.243.144"),

System.Net.IPAddress.Parse("24.177.166.236"),

System.Net.IPAddress.Parse("115.136.95.27"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2060396617));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.220.56.129"),

System.Net.IPAddress.Parse("248.21.142.228"),

System.Net.IPAddress.Parse("55.148.181.184"),

System.Net.IPAddress.Parse("222.209.222.92"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("84.225.137.209"),

System.Net.IPAddress.Parse("27.250.31.59"),

System.Net.IPAddress.Parse("84.59.229.42"),

System.Net.IPAddress.Parse("228.151.53.140"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(514896285));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.219.216.117"),

System.Net.IPAddress.Parse("89.223.230.10"),

System.Net.IPAddress.Parse("101.237.229.93"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(852427647));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("82.144.42.52"),

System.Net.IPAddress.Parse("220.191.234.145"),

System.Net.IPAddress.Parse("159.116.235.144"),

System.Net.IPAddress.Parse("174.135.250.231"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("71.164.41.0"),

System.Net.IPAddress.Parse("61.59.30.55"),

System.Net.IPAddress.Parse("45.244.40.47"),

System.Net.IPAddress.Parse("7.148.181.24"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(940810195));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.213.206.216"),

System.Net.IPAddress.Parse("72.223.64.78"),

System.Net.IPAddress.Parse("231.212.27.90"),

System.Net.IPAddress.Parse("183.1.33.133"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1524374413));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("17.243.164.43"),

System.Net.IPAddress.Parse("249.75.193.185"),

System.Net.IPAddress.Parse("250.156.153.118"),

System.Net.IPAddress.Parse("162.55.7.224"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1010630797));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("163.15.105.153"),

System.Net.IPAddress.Parse("168.113.141.115"),

System.Net.IPAddress.Parse("88.155.244.27"),

System.Net.IPAddress.Parse("96.94.105.38"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("13.112.111.81"),

System.Net.IPAddress.Parse("145.60.238.238"),

System.Net.IPAddress.Parse("56.181.140.233"),

System.Net.IPAddress.Parse("170.79.152.19"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(734112495));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.57.201.27"),

System.Net.IPAddress.Parse("106.212.15.97"),

System.Net.IPAddress.Parse("213.83.18.25"),

System.Net.IPAddress.Parse("150.36.102.95"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1014982688));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("22.191.189.215"),

System.Net.IPAddress.Parse("65.198.53.118"),

System.Net.IPAddress.Parse("253.82.111.81"),

System.Net.IPAddress.Parse("109.106.219.163"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1862467653));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.88.48.172"),

System.Net.IPAddress.Parse("77.111.187.235"),

System.Net.IPAddress.Parse("140.225.127.72"),

System.Net.IPAddress.Parse("20.222.226.65"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1046694119));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.87.137.111"),

System.Net.IPAddress.Parse("204.14.65.176"),

System.Net.IPAddress.Parse("194.85.205.44"),

System.Net.IPAddress.Parse("222.89.92.13"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("174.246.168.218"),

System.Net.IPAddress.Parse("90.240.212.154"),

System.Net.IPAddress.Parse("111.18.35.98"),

System.Net.IPAddress.Parse("58.185.189.175"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(765048204));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.91.147.201"),

System.Net.IPAddress.Parse("147.186.92.48"),

System.Net.IPAddress.Parse("60.71.196.10"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1114047125));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.47.150.250"),

System.Net.IPAddress.Parse("76.64.178.53"),

System.Net.IPAddress.Parse("74.110.254.56"),

System.Net.IPAddress.Parse("56.58.223.51"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1147700318));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("23.44.179.107"),

System.Net.IPAddress.Parse("196.169.22.130"),

System.Net.IPAddress.Parse("60.74.92.160"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196291033));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("47.247.169.252"),

System.Net.IPAddress.Parse("18.219.84.183"),

System.Net.IPAddress.Parse("13.50.146.145"),

System.Net.IPAddress.Parse("0.239.215.227"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.119.178.252"),

System.Net.IPAddress.Parse("96.77.21.228"),

System.Net.IPAddress.Parse("226.72.38.185"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1349174950));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("183.169.138.174"),

System.Net.IPAddress.Parse("95.113.93.167"),

System.Net.IPAddress.Parse("78.227.47.135"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.145.155.228"),

System.Net.IPAddress.Parse("161.29.190.42"),

System.Net.IPAddress.Parse("168.125.120.148"),

System.Net.IPAddress.Parse("132.155.66.187"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1471142734));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("140.200.7.193"),

System.Net.IPAddress.Parse("63.81.70.232"),

System.Net.IPAddress.Parse("79.66.113.10"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("3.239.18.161"),

System.Net.IPAddress.Parse("16.25.54.42"),

System.Net.IPAddress.Parse("69.98.250.33"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1528940929));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.6.57.43"),

System.Net.IPAddress.Parse("5.149.125.169"),

System.Net.IPAddress.Parse("43.150.87.253"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1532913521));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("235.117.103.135"),

System.Net.IPAddress.Parse("15.13.51.218"),

System.Net.IPAddress.Parse("197.99.85.98"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(953727391));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("114.235.170.224"),

System.Net.IPAddress.Parse("193.13.164.151"),

System.Net.IPAddress.Parse("129.238.44.105"),

System.Net.IPAddress.Parse("5.34.244.103"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("44.89.163.66"),

System.Net.IPAddress.Parse("123.156.187.110"),

System.Net.IPAddress.Parse("96.179.241.171"),

System.Net.IPAddress.Parse("128.45.209.239"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1559862906));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("123.191.2.57"),

System.Net.IPAddress.Parse("69.224.113.83"),

System.Net.IPAddress.Parse("102.231.52.253"),

System.Net.IPAddress.Parse("18.4.226.114"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("254.83.134.181"),

System.Net.IPAddress.Parse("17.232.110.65"),

System.Net.IPAddress.Parse("118.41.56.117"),

System.Net.IPAddress.Parse("129.39.242.162"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1661207245));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.80.27.184"),

System.Net.IPAddress.Parse("30.2.102.227"),

System.Net.IPAddress.Parse("135.251.204.127"),

System.Net.IPAddress.Parse("246.191.51.237"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.156.39.174"),

System.Net.IPAddress.Parse("35.142.118.69"),

System.Net.IPAddress.Parse("43.123.160.110"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1189751706));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("91.60.140.37"),

System.Net.IPAddress.Parse("150.130.185.226"),

System.Net.IPAddress.Parse("230.21.248.241"),

System.Net.IPAddress.Parse("139.55.222.245"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("110.70.123.82"),

System.Net.IPAddress.Parse("32.62.116.191"),

System.Net.IPAddress.Parse("74.32.19.198"),

System.Net.IPAddress.Parse("82.243.186.251"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1699076580));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("214.85.93.26"),

System.Net.IPAddress.Parse("106.226.172.212"),

System.Net.IPAddress.Parse("171.14.233.176"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(70676916));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("39.60.201.212"),

System.Net.IPAddress.Parse("196.215.17.174"),

System.Net.IPAddress.Parse("228.167.214.185"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1715136659));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("150.90.144.88"),

System.Net.IPAddress.Parse("157.149.111.4"),

System.Net.IPAddress.Parse("147.122.4.69"),

System.Net.IPAddress.Parse("130.156.150.72"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.78.207.181"),

System.Net.IPAddress.Parse("181.240.67.47"),

System.Net.IPAddress.Parse("56.133.18.53"),

System.Net.IPAddress.Parse("134.229.3.96"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1717745304));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.137.169.190"),

System.Net.IPAddress.Parse("229.203.251.158"),

System.Net.IPAddress.Parse("171.237.52.109"),

System.Net.IPAddress.Parse("50.147.178.154"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("172.185.204.186"),

System.Net.IPAddress.Parse("106.82.31.235"),

System.Net.IPAddress.Parse("206.208.220.69"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1725349754));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("70.250.73.189"),

System.Net.IPAddress.Parse("95.140.155.78"),

System.Net.IPAddress.Parse("70.94.62.170"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1790443824));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("45.225.201.133"),

System.Net.IPAddress.Parse("198.20.142.127"),

System.Net.IPAddress.Parse("66.225.239.188"),

System.Net.IPAddress.Parse("227.77.214.15"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.171.228.100"),

System.Net.IPAddress.Parse("157.88.2.37"),

System.Net.IPAddress.Parse("189.136.20.241"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1836676977));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.164.33.149"),

System.Net.IPAddress.Parse("23.121.117.30"),

System.Net.IPAddress.Parse("14.189.80.148"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1978357694));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.51.23.223"),

System.Net.IPAddress.Parse("134.241.157.196"),

System.Net.IPAddress.Parse("90.94.206.223"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.7.110.41"),

System.Net.IPAddress.Parse("165.134.153.235"),

System.Net.IPAddress.Parse("238.83.157.117"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(114614856));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.38.190.64"),

System.Net.IPAddress.Parse("247.12.180.224"),

System.Net.IPAddress.Parse("5.87.110.35"),

System.Net.IPAddress.Parse("106.199.97.74"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2021824710));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.16.104.58"),

System.Net.IPAddress.Parse("153.225.37.221"),

System.Net.IPAddress.Parse("83.156.198.153"),

System.Net.IPAddress.Parse("96.225.216.80"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1025710404));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("188.72.220.140"),

System.Net.IPAddress.Parse("149.193.199.245"),

System.Net.IPAddress.Parse("219.59.217.173"),

System.Net.IPAddress.Parse("184.132.20.223"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.12.106.182"),

System.Net.IPAddress.Parse("68.197.243.110"),

System.Net.IPAddress.Parse("241.168.234.162"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2136763513));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.114.250.7"),

System.Net.IPAddress.Parse("218.55.187.129"),

System.Net.IPAddress.Parse("174.79.51.80"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1635158325));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.184.164.177"),

System.Net.IPAddress.Parse("87.109.19.33"),

System.Net.IPAddress.Parse("6.0.249.18"),

System.Net.IPAddress.Parse("228.186.18.232"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.232.248.181"),

System.Net.IPAddress.Parse("254.96.62.95"),

System.Net.IPAddress.Parse("204.27.232.250"),

System.Net.IPAddress.Parse("98.74.63.60"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147260456));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("222.254.104.151"),

System.Net.IPAddress.Parse("35.120.204.142"),

System.Net.IPAddress.Parse("237.29.120.229"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 1661207245);
                var models =  ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(10));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1699076580));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("214.85.93.26"),

System.Net.IPAddress.Parse("106.226.172.212"),

System.Net.IPAddress.Parse("171.14.233.176"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(70676916));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("39.60.201.212"),

System.Net.IPAddress.Parse("196.215.17.174"),

System.Net.IPAddress.Parse("228.167.214.185"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1715136659));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("150.90.144.88"),

System.Net.IPAddress.Parse("157.149.111.4"),

System.Net.IPAddress.Parse("147.122.4.69"),

System.Net.IPAddress.Parse("130.156.150.72"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.78.207.181"),

System.Net.IPAddress.Parse("181.240.67.47"),

System.Net.IPAddress.Parse("56.133.18.53"),

System.Net.IPAddress.Parse("134.229.3.96"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1717745304));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.137.169.190"),

System.Net.IPAddress.Parse("229.203.251.158"),

System.Net.IPAddress.Parse("171.237.52.109"),

System.Net.IPAddress.Parse("50.147.178.154"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("172.185.204.186"),

System.Net.IPAddress.Parse("106.82.31.235"),

System.Net.IPAddress.Parse("206.208.220.69"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1725349754));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("70.250.73.189"),

System.Net.IPAddress.Parse("95.140.155.78"),

System.Net.IPAddress.Parse("70.94.62.170"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1790443824));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("45.225.201.133"),

System.Net.IPAddress.Parse("198.20.142.127"),

System.Net.IPAddress.Parse("66.225.239.188"),

System.Net.IPAddress.Parse("227.77.214.15"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.171.228.100"),

System.Net.IPAddress.Parse("157.88.2.37"),

System.Net.IPAddress.Parse("189.136.20.241"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1836676977));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.164.33.149"),

System.Net.IPAddress.Parse("23.121.117.30"),

System.Net.IPAddress.Parse("14.189.80.148"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1978357694));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.51.23.223"),

System.Net.IPAddress.Parse("134.241.157.196"),

System.Net.IPAddress.Parse("90.94.206.223"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.7.110.41"),

System.Net.IPAddress.Parse("165.134.153.235"),

System.Net.IPAddress.Parse("238.83.157.117"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(114614856));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.38.190.64"),

System.Net.IPAddress.Parse("247.12.180.224"),

System.Net.IPAddress.Parse("5.87.110.35"),

System.Net.IPAddress.Parse("106.199.97.74"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2021824710));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.16.104.58"),

System.Net.IPAddress.Parse("153.225.37.221"),

System.Net.IPAddress.Parse("83.156.198.153"),

System.Net.IPAddress.Parse("96.225.216.80"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1025710404));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("188.72.220.140"),

System.Net.IPAddress.Parse("149.193.199.245"),

System.Net.IPAddress.Parse("219.59.217.173"),

System.Net.IPAddress.Parse("184.132.20.223"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.12.106.182"),

System.Net.IPAddress.Parse("68.197.243.110"),

System.Net.IPAddress.Parse("241.168.234.162"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2136763513));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.114.250.7"),

System.Net.IPAddress.Parse("218.55.187.129"),

System.Net.IPAddress.Parse("174.79.51.80"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1635158325));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.184.164.177"),

System.Net.IPAddress.Parse("87.109.19.33"),

System.Net.IPAddress.Parse("6.0.249.18"),

System.Net.IPAddress.Parse("228.186.18.232"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.232.248.181"),

System.Net.IPAddress.Parse("254.96.62.95"),

System.Net.IPAddress.Parse("204.27.232.250"),

System.Net.IPAddress.Parse("98.74.63.60"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147260456));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("222.254.104.151"),

System.Net.IPAddress.Parse("35.120.204.142"),

System.Net.IPAddress.Parse("237.29.120.229"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IIPAddressArrayinetArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IIPAddressArrayinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 408444095);
                var models = await ((IIPAddressArrayinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(25));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(503659545));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("73.216.243.144"),

System.Net.IPAddress.Parse("24.177.166.236"),

System.Net.IPAddress.Parse("115.136.95.27"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2060396617));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.220.56.129"),

System.Net.IPAddress.Parse("248.21.142.228"),

System.Net.IPAddress.Parse("55.148.181.184"),

System.Net.IPAddress.Parse("222.209.222.92"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("84.225.137.209"),

System.Net.IPAddress.Parse("27.250.31.59"),

System.Net.IPAddress.Parse("84.59.229.42"),

System.Net.IPAddress.Parse("228.151.53.140"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(514896285));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.219.216.117"),

System.Net.IPAddress.Parse("89.223.230.10"),

System.Net.IPAddress.Parse("101.237.229.93"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(852427647));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("82.144.42.52"),

System.Net.IPAddress.Parse("220.191.234.145"),

System.Net.IPAddress.Parse("159.116.235.144"),

System.Net.IPAddress.Parse("174.135.250.231"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("71.164.41.0"),

System.Net.IPAddress.Parse("61.59.30.55"),

System.Net.IPAddress.Parse("45.244.40.47"),

System.Net.IPAddress.Parse("7.148.181.24"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(940810195));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.213.206.216"),

System.Net.IPAddress.Parse("72.223.64.78"),

System.Net.IPAddress.Parse("231.212.27.90"),

System.Net.IPAddress.Parse("183.1.33.133"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1524374413));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("17.243.164.43"),

System.Net.IPAddress.Parse("249.75.193.185"),

System.Net.IPAddress.Parse("250.156.153.118"),

System.Net.IPAddress.Parse("162.55.7.224"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1010630797));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("163.15.105.153"),

System.Net.IPAddress.Parse("168.113.141.115"),

System.Net.IPAddress.Parse("88.155.244.27"),

System.Net.IPAddress.Parse("96.94.105.38"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("13.112.111.81"),

System.Net.IPAddress.Parse("145.60.238.238"),

System.Net.IPAddress.Parse("56.181.140.233"),

System.Net.IPAddress.Parse("170.79.152.19"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(734112495));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.57.201.27"),

System.Net.IPAddress.Parse("106.212.15.97"),

System.Net.IPAddress.Parse("213.83.18.25"),

System.Net.IPAddress.Parse("150.36.102.95"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1014982688));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("22.191.189.215"),

System.Net.IPAddress.Parse("65.198.53.118"),

System.Net.IPAddress.Parse("253.82.111.81"),

System.Net.IPAddress.Parse("109.106.219.163"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1862467653));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.88.48.172"),

System.Net.IPAddress.Parse("77.111.187.235"),

System.Net.IPAddress.Parse("140.225.127.72"),

System.Net.IPAddress.Parse("20.222.226.65"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1046694119));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.87.137.111"),

System.Net.IPAddress.Parse("204.14.65.176"),

System.Net.IPAddress.Parse("194.85.205.44"),

System.Net.IPAddress.Parse("222.89.92.13"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("174.246.168.218"),

System.Net.IPAddress.Parse("90.240.212.154"),

System.Net.IPAddress.Parse("111.18.35.98"),

System.Net.IPAddress.Parse("58.185.189.175"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(765048204));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.91.147.201"),

System.Net.IPAddress.Parse("147.186.92.48"),

System.Net.IPAddress.Parse("60.71.196.10"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1114047125));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.47.150.250"),

System.Net.IPAddress.Parse("76.64.178.53"),

System.Net.IPAddress.Parse("74.110.254.56"),

System.Net.IPAddress.Parse("56.58.223.51"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1147700318));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("23.44.179.107"),

System.Net.IPAddress.Parse("196.169.22.130"),

System.Net.IPAddress.Parse("60.74.92.160"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196291033));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("47.247.169.252"),

System.Net.IPAddress.Parse("18.219.84.183"),

System.Net.IPAddress.Parse("13.50.146.145"),

System.Net.IPAddress.Parse("0.239.215.227"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.119.178.252"),

System.Net.IPAddress.Parse("96.77.21.228"),

System.Net.IPAddress.Parse("226.72.38.185"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1349174950));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("183.169.138.174"),

System.Net.IPAddress.Parse("95.113.93.167"),

System.Net.IPAddress.Parse("78.227.47.135"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.145.155.228"),

System.Net.IPAddress.Parse("161.29.190.42"),

System.Net.IPAddress.Parse("168.125.120.148"),

System.Net.IPAddress.Parse("132.155.66.187"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1471142734));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("140.200.7.193"),

System.Net.IPAddress.Parse("63.81.70.232"),

System.Net.IPAddress.Parse("79.66.113.10"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("3.239.18.161"),

System.Net.IPAddress.Parse("16.25.54.42"),

System.Net.IPAddress.Parse("69.98.250.33"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1528940929));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.6.57.43"),

System.Net.IPAddress.Parse("5.149.125.169"),

System.Net.IPAddress.Parse("43.150.87.253"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1532913521));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("235.117.103.135"),

System.Net.IPAddress.Parse("15.13.51.218"),

System.Net.IPAddress.Parse("197.99.85.98"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(953727391));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("114.235.170.224"),

System.Net.IPAddress.Parse("193.13.164.151"),

System.Net.IPAddress.Parse("129.238.44.105"),

System.Net.IPAddress.Parse("5.34.244.103"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("44.89.163.66"),

System.Net.IPAddress.Parse("123.156.187.110"),

System.Net.IPAddress.Parse("96.179.241.171"),

System.Net.IPAddress.Parse("128.45.209.239"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1559862906));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("123.191.2.57"),

System.Net.IPAddress.Parse("69.224.113.83"),

System.Net.IPAddress.Parse("102.231.52.253"),

System.Net.IPAddress.Parse("18.4.226.114"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("254.83.134.181"),

System.Net.IPAddress.Parse("17.232.110.65"),

System.Net.IPAddress.Parse("118.41.56.117"),

System.Net.IPAddress.Parse("129.39.242.162"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1661207245));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.80.27.184"),

System.Net.IPAddress.Parse("30.2.102.227"),

System.Net.IPAddress.Parse("135.251.204.127"),

System.Net.IPAddress.Parse("246.191.51.237"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.156.39.174"),

System.Net.IPAddress.Parse("35.142.118.69"),

System.Net.IPAddress.Parse("43.123.160.110"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1189751706));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("91.60.140.37"),

System.Net.IPAddress.Parse("150.130.185.226"),

System.Net.IPAddress.Parse("230.21.248.241"),

System.Net.IPAddress.Parse("139.55.222.245"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("110.70.123.82"),

System.Net.IPAddress.Parse("32.62.116.191"),

System.Net.IPAddress.Parse("74.32.19.198"),

System.Net.IPAddress.Parse("82.243.186.251"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1699076580));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("214.85.93.26"),

System.Net.IPAddress.Parse("106.226.172.212"),

System.Net.IPAddress.Parse("171.14.233.176"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(70676916));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("39.60.201.212"),

System.Net.IPAddress.Parse("196.215.17.174"),

System.Net.IPAddress.Parse("228.167.214.185"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1715136659));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("150.90.144.88"),

System.Net.IPAddress.Parse("157.149.111.4"),

System.Net.IPAddress.Parse("147.122.4.69"),

System.Net.IPAddress.Parse("130.156.150.72"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.78.207.181"),

System.Net.IPAddress.Parse("181.240.67.47"),

System.Net.IPAddress.Parse("56.133.18.53"),

System.Net.IPAddress.Parse("134.229.3.96"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1717745304));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.137.169.190"),

System.Net.IPAddress.Parse("229.203.251.158"),

System.Net.IPAddress.Parse("171.237.52.109"),

System.Net.IPAddress.Parse("50.147.178.154"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("172.185.204.186"),

System.Net.IPAddress.Parse("106.82.31.235"),

System.Net.IPAddress.Parse("206.208.220.69"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1725349754));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("70.250.73.189"),

System.Net.IPAddress.Parse("95.140.155.78"),

System.Net.IPAddress.Parse("70.94.62.170"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1790443824));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("45.225.201.133"),

System.Net.IPAddress.Parse("198.20.142.127"),

System.Net.IPAddress.Parse("66.225.239.188"),

System.Net.IPAddress.Parse("227.77.214.15"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.171.228.100"),

System.Net.IPAddress.Parse("157.88.2.37"),

System.Net.IPAddress.Parse("189.136.20.241"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1836676977));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.164.33.149"),

System.Net.IPAddress.Parse("23.121.117.30"),

System.Net.IPAddress.Parse("14.189.80.148"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1978357694));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.51.23.223"),

System.Net.IPAddress.Parse("134.241.157.196"),

System.Net.IPAddress.Parse("90.94.206.223"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.7.110.41"),

System.Net.IPAddress.Parse("165.134.153.235"),

System.Net.IPAddress.Parse("238.83.157.117"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(114614856));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.38.190.64"),

System.Net.IPAddress.Parse("247.12.180.224"),

System.Net.IPAddress.Parse("5.87.110.35"),

System.Net.IPAddress.Parse("106.199.97.74"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2021824710));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.16.104.58"),

System.Net.IPAddress.Parse("153.225.37.221"),

System.Net.IPAddress.Parse("83.156.198.153"),

System.Net.IPAddress.Parse("96.225.216.80"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1025710404));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("188.72.220.140"),

System.Net.IPAddress.Parse("149.193.199.245"),

System.Net.IPAddress.Parse("219.59.217.173"),

System.Net.IPAddress.Parse("184.132.20.223"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.12.106.182"),

System.Net.IPAddress.Parse("68.197.243.110"),

System.Net.IPAddress.Parse("241.168.234.162"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2136763513));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.114.250.7"),

System.Net.IPAddress.Parse("218.55.187.129"),

System.Net.IPAddress.Parse("174.79.51.80"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1635158325));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.184.164.177"),

System.Net.IPAddress.Parse("87.109.19.33"),

System.Net.IPAddress.Parse("6.0.249.18"),

System.Net.IPAddress.Parse("228.186.18.232"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.232.248.181"),

System.Net.IPAddress.Parse("254.96.62.95"),

System.Net.IPAddress.Parse("204.27.232.250"),

System.Net.IPAddress.Parse("98.74.63.60"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147260456));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("222.254.104.151"),

System.Net.IPAddress.Parse("35.120.204.142"),

System.Net.IPAddress.Parse("237.29.120.229"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressArrayinetArray)
            ),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1
            ),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2
            )
            ]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                 foreach(var batchResult in ((IIPAddressArrayinetArray)this).DbConnectionSelectModelBatch(connection, 120708206, 120708206))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(28));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(131351132));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("41.56.170.121"),

System.Net.IPAddress.Parse("249.177.86.74"),

System.Net.IPAddress.Parse("52.16.51.138"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1225266561));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("161.64.174.220"),

System.Net.IPAddress.Parse("10.108.45.165"),

System.Net.IPAddress.Parse("236.217.123.2"),

System.Net.IPAddress.Parse("119.54.240.25"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(149175584));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("143.53.239.41"),

System.Net.IPAddress.Parse("240.239.90.237"),

System.Net.IPAddress.Parse("106.206.209.132"),

System.Net.IPAddress.Parse("118.238.228.56"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(898710886));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("215.1.195.107"),

System.Net.IPAddress.Parse("132.185.46.52"),

System.Net.IPAddress.Parse("114.104.142.186"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(408444095));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("139.249.252.248"),

System.Net.IPAddress.Parse("144.156.246.243"),

System.Net.IPAddress.Parse("7.121.72.34"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("181.47.77.188"),

System.Net.IPAddress.Parse("135.31.242.74"),

System.Net.IPAddress.Parse("45.228.252.243"),

System.Net.IPAddress.Parse("139.12.116.83"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(503659545));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("73.216.243.144"),

System.Net.IPAddress.Parse("24.177.166.236"),

System.Net.IPAddress.Parse("115.136.95.27"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2060396617));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.220.56.129"),

System.Net.IPAddress.Parse("248.21.142.228"),

System.Net.IPAddress.Parse("55.148.181.184"),

System.Net.IPAddress.Parse("222.209.222.92"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("84.225.137.209"),

System.Net.IPAddress.Parse("27.250.31.59"),

System.Net.IPAddress.Parse("84.59.229.42"),

System.Net.IPAddress.Parse("228.151.53.140"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(514896285));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.219.216.117"),

System.Net.IPAddress.Parse("89.223.230.10"),

System.Net.IPAddress.Parse("101.237.229.93"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(852427647));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("82.144.42.52"),

System.Net.IPAddress.Parse("220.191.234.145"),

System.Net.IPAddress.Parse("159.116.235.144"),

System.Net.IPAddress.Parse("174.135.250.231"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("71.164.41.0"),

System.Net.IPAddress.Parse("61.59.30.55"),

System.Net.IPAddress.Parse("45.244.40.47"),

System.Net.IPAddress.Parse("7.148.181.24"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(940810195));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.213.206.216"),

System.Net.IPAddress.Parse("72.223.64.78"),

System.Net.IPAddress.Parse("231.212.27.90"),

System.Net.IPAddress.Parse("183.1.33.133"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1524374413));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("17.243.164.43"),

System.Net.IPAddress.Parse("249.75.193.185"),

System.Net.IPAddress.Parse("250.156.153.118"),

System.Net.IPAddress.Parse("162.55.7.224"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1010630797));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("163.15.105.153"),

System.Net.IPAddress.Parse("168.113.141.115"),

System.Net.IPAddress.Parse("88.155.244.27"),

System.Net.IPAddress.Parse("96.94.105.38"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("13.112.111.81"),

System.Net.IPAddress.Parse("145.60.238.238"),

System.Net.IPAddress.Parse("56.181.140.233"),

System.Net.IPAddress.Parse("170.79.152.19"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(734112495));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.57.201.27"),

System.Net.IPAddress.Parse("106.212.15.97"),

System.Net.IPAddress.Parse("213.83.18.25"),

System.Net.IPAddress.Parse("150.36.102.95"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1014982688));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("22.191.189.215"),

System.Net.IPAddress.Parse("65.198.53.118"),

System.Net.IPAddress.Parse("253.82.111.81"),

System.Net.IPAddress.Parse("109.106.219.163"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1862467653));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.88.48.172"),

System.Net.IPAddress.Parse("77.111.187.235"),

System.Net.IPAddress.Parse("140.225.127.72"),

System.Net.IPAddress.Parse("20.222.226.65"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1046694119));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.87.137.111"),

System.Net.IPAddress.Parse("204.14.65.176"),

System.Net.IPAddress.Parse("194.85.205.44"),

System.Net.IPAddress.Parse("222.89.92.13"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("174.246.168.218"),

System.Net.IPAddress.Parse("90.240.212.154"),

System.Net.IPAddress.Parse("111.18.35.98"),

System.Net.IPAddress.Parse("58.185.189.175"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(765048204));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.91.147.201"),

System.Net.IPAddress.Parse("147.186.92.48"),

System.Net.IPAddress.Parse("60.71.196.10"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1114047125));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.47.150.250"),

System.Net.IPAddress.Parse("76.64.178.53"),

System.Net.IPAddress.Parse("74.110.254.56"),

System.Net.IPAddress.Parse("56.58.223.51"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1147700318));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("23.44.179.107"),

System.Net.IPAddress.Parse("196.169.22.130"),

System.Net.IPAddress.Parse("60.74.92.160"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196291033));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("47.247.169.252"),

System.Net.IPAddress.Parse("18.219.84.183"),

System.Net.IPAddress.Parse("13.50.146.145"),

System.Net.IPAddress.Parse("0.239.215.227"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.119.178.252"),

System.Net.IPAddress.Parse("96.77.21.228"),

System.Net.IPAddress.Parse("226.72.38.185"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1349174950));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("183.169.138.174"),

System.Net.IPAddress.Parse("95.113.93.167"),

System.Net.IPAddress.Parse("78.227.47.135"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.145.155.228"),

System.Net.IPAddress.Parse("161.29.190.42"),

System.Net.IPAddress.Parse("168.125.120.148"),

System.Net.IPAddress.Parse("132.155.66.187"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1471142734));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("140.200.7.193"),

System.Net.IPAddress.Parse("63.81.70.232"),

System.Net.IPAddress.Parse("79.66.113.10"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("3.239.18.161"),

System.Net.IPAddress.Parse("16.25.54.42"),

System.Net.IPAddress.Parse("69.98.250.33"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1528940929));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.6.57.43"),

System.Net.IPAddress.Parse("5.149.125.169"),

System.Net.IPAddress.Parse("43.150.87.253"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1532913521));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("235.117.103.135"),

System.Net.IPAddress.Parse("15.13.51.218"),

System.Net.IPAddress.Parse("197.99.85.98"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(953727391));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("114.235.170.224"),

System.Net.IPAddress.Parse("193.13.164.151"),

System.Net.IPAddress.Parse("129.238.44.105"),

System.Net.IPAddress.Parse("5.34.244.103"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("44.89.163.66"),

System.Net.IPAddress.Parse("123.156.187.110"),

System.Net.IPAddress.Parse("96.179.241.171"),

System.Net.IPAddress.Parse("128.45.209.239"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1559862906));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("123.191.2.57"),

System.Net.IPAddress.Parse("69.224.113.83"),

System.Net.IPAddress.Parse("102.231.52.253"),

System.Net.IPAddress.Parse("18.4.226.114"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("254.83.134.181"),

System.Net.IPAddress.Parse("17.232.110.65"),

System.Net.IPAddress.Parse("118.41.56.117"),

System.Net.IPAddress.Parse("129.39.242.162"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1661207245));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.80.27.184"),

System.Net.IPAddress.Parse("30.2.102.227"),

System.Net.IPAddress.Parse("135.251.204.127"),

System.Net.IPAddress.Parse("246.191.51.237"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.156.39.174"),

System.Net.IPAddress.Parse("35.142.118.69"),

System.Net.IPAddress.Parse("43.123.160.110"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1189751706));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("91.60.140.37"),

System.Net.IPAddress.Parse("150.130.185.226"),

System.Net.IPAddress.Parse("230.21.248.241"),

System.Net.IPAddress.Parse("139.55.222.245"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("110.70.123.82"),

System.Net.IPAddress.Parse("32.62.116.191"),

System.Net.IPAddress.Parse("74.32.19.198"),

System.Net.IPAddress.Parse("82.243.186.251"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1699076580));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("214.85.93.26"),

System.Net.IPAddress.Parse("106.226.172.212"),

System.Net.IPAddress.Parse("171.14.233.176"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(70676916));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("39.60.201.212"),

System.Net.IPAddress.Parse("196.215.17.174"),

System.Net.IPAddress.Parse("228.167.214.185"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1715136659));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("150.90.144.88"),

System.Net.IPAddress.Parse("157.149.111.4"),

System.Net.IPAddress.Parse("147.122.4.69"),

System.Net.IPAddress.Parse("130.156.150.72"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.78.207.181"),

System.Net.IPAddress.Parse("181.240.67.47"),

System.Net.IPAddress.Parse("56.133.18.53"),

System.Net.IPAddress.Parse("134.229.3.96"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1717745304));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.137.169.190"),

System.Net.IPAddress.Parse("229.203.251.158"),

System.Net.IPAddress.Parse("171.237.52.109"),

System.Net.IPAddress.Parse("50.147.178.154"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("172.185.204.186"),

System.Net.IPAddress.Parse("106.82.31.235"),

System.Net.IPAddress.Parse("206.208.220.69"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1725349754));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("70.250.73.189"),

System.Net.IPAddress.Parse("95.140.155.78"),

System.Net.IPAddress.Parse("70.94.62.170"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1790443824));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("45.225.201.133"),

System.Net.IPAddress.Parse("198.20.142.127"),

System.Net.IPAddress.Parse("66.225.239.188"),

System.Net.IPAddress.Parse("227.77.214.15"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.171.228.100"),

System.Net.IPAddress.Parse("157.88.2.37"),

System.Net.IPAddress.Parse("189.136.20.241"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1836676977));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.164.33.149"),

System.Net.IPAddress.Parse("23.121.117.30"),

System.Net.IPAddress.Parse("14.189.80.148"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1978357694));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.51.23.223"),

System.Net.IPAddress.Parse("134.241.157.196"),

System.Net.IPAddress.Parse("90.94.206.223"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.7.110.41"),

System.Net.IPAddress.Parse("165.134.153.235"),

System.Net.IPAddress.Parse("238.83.157.117"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(114614856));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.38.190.64"),

System.Net.IPAddress.Parse("247.12.180.224"),

System.Net.IPAddress.Parse("5.87.110.35"),

System.Net.IPAddress.Parse("106.199.97.74"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2021824710));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.16.104.58"),

System.Net.IPAddress.Parse("153.225.37.221"),

System.Net.IPAddress.Parse("83.156.198.153"),

System.Net.IPAddress.Parse("96.225.216.80"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1025710404));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("188.72.220.140"),

System.Net.IPAddress.Parse("149.193.199.245"),

System.Net.IPAddress.Parse("219.59.217.173"),

System.Net.IPAddress.Parse("184.132.20.223"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.12.106.182"),

System.Net.IPAddress.Parse("68.197.243.110"),

System.Net.IPAddress.Parse("241.168.234.162"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[26];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2136763513));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.114.250.7"),

System.Net.IPAddress.Parse("218.55.187.129"),

System.Net.IPAddress.Parse("174.79.51.80"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1635158325));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.184.164.177"),

System.Net.IPAddress.Parse("87.109.19.33"),

System.Net.IPAddress.Parse("6.0.249.18"),

System.Net.IPAddress.Parse("228.186.18.232"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.232.248.181"),

System.Net.IPAddress.Parse("254.96.62.95"),

System.Net.IPAddress.Parse("204.27.232.250"),

System.Net.IPAddress.Parse("98.74.63.60"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[27];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147260456));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("222.254.104.151"),

System.Net.IPAddress.Parse("35.120.204.142"),

System.Net.IPAddress.Parse("237.29.120.229"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(28));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(131351132));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("41.56.170.121"),

System.Net.IPAddress.Parse("249.177.86.74"),

System.Net.IPAddress.Parse("52.16.51.138"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1225266561));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("161.64.174.220"),

System.Net.IPAddress.Parse("10.108.45.165"),

System.Net.IPAddress.Parse("236.217.123.2"),

System.Net.IPAddress.Parse("119.54.240.25"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(149175584));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("143.53.239.41"),

System.Net.IPAddress.Parse("240.239.90.237"),

System.Net.IPAddress.Parse("106.206.209.132"),

System.Net.IPAddress.Parse("118.238.228.56"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(898710886));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("215.1.195.107"),

System.Net.IPAddress.Parse("132.185.46.52"),

System.Net.IPAddress.Parse("114.104.142.186"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(408444095));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("139.249.252.248"),

System.Net.IPAddress.Parse("144.156.246.243"),

System.Net.IPAddress.Parse("7.121.72.34"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("181.47.77.188"),

System.Net.IPAddress.Parse("135.31.242.74"),

System.Net.IPAddress.Parse("45.228.252.243"),

System.Net.IPAddress.Parse("139.12.116.83"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(503659545));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("73.216.243.144"),

System.Net.IPAddress.Parse("24.177.166.236"),

System.Net.IPAddress.Parse("115.136.95.27"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2060396617));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.220.56.129"),

System.Net.IPAddress.Parse("248.21.142.228"),

System.Net.IPAddress.Parse("55.148.181.184"),

System.Net.IPAddress.Parse("222.209.222.92"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("84.225.137.209"),

System.Net.IPAddress.Parse("27.250.31.59"),

System.Net.IPAddress.Parse("84.59.229.42"),

System.Net.IPAddress.Parse("228.151.53.140"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(514896285));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.219.216.117"),

System.Net.IPAddress.Parse("89.223.230.10"),

System.Net.IPAddress.Parse("101.237.229.93"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(852427647));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("82.144.42.52"),

System.Net.IPAddress.Parse("220.191.234.145"),

System.Net.IPAddress.Parse("159.116.235.144"),

System.Net.IPAddress.Parse("174.135.250.231"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("71.164.41.0"),

System.Net.IPAddress.Parse("61.59.30.55"),

System.Net.IPAddress.Parse("45.244.40.47"),

System.Net.IPAddress.Parse("7.148.181.24"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(940810195));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.213.206.216"),

System.Net.IPAddress.Parse("72.223.64.78"),

System.Net.IPAddress.Parse("231.212.27.90"),

System.Net.IPAddress.Parse("183.1.33.133"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1524374413));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("17.243.164.43"),

System.Net.IPAddress.Parse("249.75.193.185"),

System.Net.IPAddress.Parse("250.156.153.118"),

System.Net.IPAddress.Parse("162.55.7.224"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1010630797));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("163.15.105.153"),

System.Net.IPAddress.Parse("168.113.141.115"),

System.Net.IPAddress.Parse("88.155.244.27"),

System.Net.IPAddress.Parse("96.94.105.38"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("13.112.111.81"),

System.Net.IPAddress.Parse("145.60.238.238"),

System.Net.IPAddress.Parse("56.181.140.233"),

System.Net.IPAddress.Parse("170.79.152.19"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(734112495));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.57.201.27"),

System.Net.IPAddress.Parse("106.212.15.97"),

System.Net.IPAddress.Parse("213.83.18.25"),

System.Net.IPAddress.Parse("150.36.102.95"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1014982688));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("22.191.189.215"),

System.Net.IPAddress.Parse("65.198.53.118"),

System.Net.IPAddress.Parse("253.82.111.81"),

System.Net.IPAddress.Parse("109.106.219.163"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1862467653));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.88.48.172"),

System.Net.IPAddress.Parse("77.111.187.235"),

System.Net.IPAddress.Parse("140.225.127.72"),

System.Net.IPAddress.Parse("20.222.226.65"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1046694119));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.87.137.111"),

System.Net.IPAddress.Parse("204.14.65.176"),

System.Net.IPAddress.Parse("194.85.205.44"),

System.Net.IPAddress.Parse("222.89.92.13"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("174.246.168.218"),

System.Net.IPAddress.Parse("90.240.212.154"),

System.Net.IPAddress.Parse("111.18.35.98"),

System.Net.IPAddress.Parse("58.185.189.175"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(765048204));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.91.147.201"),

System.Net.IPAddress.Parse("147.186.92.48"),

System.Net.IPAddress.Parse("60.71.196.10"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1114047125));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.47.150.250"),

System.Net.IPAddress.Parse("76.64.178.53"),

System.Net.IPAddress.Parse("74.110.254.56"),

System.Net.IPAddress.Parse("56.58.223.51"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1147700318));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("23.44.179.107"),

System.Net.IPAddress.Parse("196.169.22.130"),

System.Net.IPAddress.Parse("60.74.92.160"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196291033));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("47.247.169.252"),

System.Net.IPAddress.Parse("18.219.84.183"),

System.Net.IPAddress.Parse("13.50.146.145"),

System.Net.IPAddress.Parse("0.239.215.227"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.119.178.252"),

System.Net.IPAddress.Parse("96.77.21.228"),

System.Net.IPAddress.Parse("226.72.38.185"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1349174950));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("183.169.138.174"),

System.Net.IPAddress.Parse("95.113.93.167"),

System.Net.IPAddress.Parse("78.227.47.135"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.145.155.228"),

System.Net.IPAddress.Parse("161.29.190.42"),

System.Net.IPAddress.Parse("168.125.120.148"),

System.Net.IPAddress.Parse("132.155.66.187"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1471142734));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("140.200.7.193"),

System.Net.IPAddress.Parse("63.81.70.232"),

System.Net.IPAddress.Parse("79.66.113.10"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("3.239.18.161"),

System.Net.IPAddress.Parse("16.25.54.42"),

System.Net.IPAddress.Parse("69.98.250.33"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1528940929));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.6.57.43"),

System.Net.IPAddress.Parse("5.149.125.169"),

System.Net.IPAddress.Parse("43.150.87.253"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1532913521));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("235.117.103.135"),

System.Net.IPAddress.Parse("15.13.51.218"),

System.Net.IPAddress.Parse("197.99.85.98"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(953727391));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("114.235.170.224"),

System.Net.IPAddress.Parse("193.13.164.151"),

System.Net.IPAddress.Parse("129.238.44.105"),

System.Net.IPAddress.Parse("5.34.244.103"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("44.89.163.66"),

System.Net.IPAddress.Parse("123.156.187.110"),

System.Net.IPAddress.Parse("96.179.241.171"),

System.Net.IPAddress.Parse("128.45.209.239"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1559862906));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("123.191.2.57"),

System.Net.IPAddress.Parse("69.224.113.83"),

System.Net.IPAddress.Parse("102.231.52.253"),

System.Net.IPAddress.Parse("18.4.226.114"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("254.83.134.181"),

System.Net.IPAddress.Parse("17.232.110.65"),

System.Net.IPAddress.Parse("118.41.56.117"),

System.Net.IPAddress.Parse("129.39.242.162"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1661207245));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.80.27.184"),

System.Net.IPAddress.Parse("30.2.102.227"),

System.Net.IPAddress.Parse("135.251.204.127"),

System.Net.IPAddress.Parse("246.191.51.237"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.156.39.174"),

System.Net.IPAddress.Parse("35.142.118.69"),

System.Net.IPAddress.Parse("43.123.160.110"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1189751706));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("91.60.140.37"),

System.Net.IPAddress.Parse("150.130.185.226"),

System.Net.IPAddress.Parse("230.21.248.241"),

System.Net.IPAddress.Parse("139.55.222.245"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("110.70.123.82"),

System.Net.IPAddress.Parse("32.62.116.191"),

System.Net.IPAddress.Parse("74.32.19.198"),

System.Net.IPAddress.Parse("82.243.186.251"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1699076580));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("214.85.93.26"),

System.Net.IPAddress.Parse("106.226.172.212"),

System.Net.IPAddress.Parse("171.14.233.176"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(70676916));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("39.60.201.212"),

System.Net.IPAddress.Parse("196.215.17.174"),

System.Net.IPAddress.Parse("228.167.214.185"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1715136659));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("150.90.144.88"),

System.Net.IPAddress.Parse("157.149.111.4"),

System.Net.IPAddress.Parse("147.122.4.69"),

System.Net.IPAddress.Parse("130.156.150.72"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.78.207.181"),

System.Net.IPAddress.Parse("181.240.67.47"),

System.Net.IPAddress.Parse("56.133.18.53"),

System.Net.IPAddress.Parse("134.229.3.96"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1717745304));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.137.169.190"),

System.Net.IPAddress.Parse("229.203.251.158"),

System.Net.IPAddress.Parse("171.237.52.109"),

System.Net.IPAddress.Parse("50.147.178.154"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("172.185.204.186"),

System.Net.IPAddress.Parse("106.82.31.235"),

System.Net.IPAddress.Parse("206.208.220.69"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1725349754));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("70.250.73.189"),

System.Net.IPAddress.Parse("95.140.155.78"),

System.Net.IPAddress.Parse("70.94.62.170"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1790443824));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("45.225.201.133"),

System.Net.IPAddress.Parse("198.20.142.127"),

System.Net.IPAddress.Parse("66.225.239.188"),

System.Net.IPAddress.Parse("227.77.214.15"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.171.228.100"),

System.Net.IPAddress.Parse("157.88.2.37"),

System.Net.IPAddress.Parse("189.136.20.241"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1836676977));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.164.33.149"),

System.Net.IPAddress.Parse("23.121.117.30"),

System.Net.IPAddress.Parse("14.189.80.148"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1978357694));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.51.23.223"),

System.Net.IPAddress.Parse("134.241.157.196"),

System.Net.IPAddress.Parse("90.94.206.223"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.7.110.41"),

System.Net.IPAddress.Parse("165.134.153.235"),

System.Net.IPAddress.Parse("238.83.157.117"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(114614856));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.38.190.64"),

System.Net.IPAddress.Parse("247.12.180.224"),

System.Net.IPAddress.Parse("5.87.110.35"),

System.Net.IPAddress.Parse("106.199.97.74"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2021824710));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.16.104.58"),

System.Net.IPAddress.Parse("153.225.37.221"),

System.Net.IPAddress.Parse("83.156.198.153"),

System.Net.IPAddress.Parse("96.225.216.80"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1025710404));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("188.72.220.140"),

System.Net.IPAddress.Parse("149.193.199.245"),

System.Net.IPAddress.Parse("219.59.217.173"),

System.Net.IPAddress.Parse("184.132.20.223"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.12.106.182"),

System.Net.IPAddress.Parse("68.197.243.110"),

System.Net.IPAddress.Parse("241.168.234.162"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[26];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2136763513));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.114.250.7"),

System.Net.IPAddress.Parse("218.55.187.129"),

System.Net.IPAddress.Parse("174.79.51.80"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1635158325));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.184.164.177"),

System.Net.IPAddress.Parse("87.109.19.33"),

System.Net.IPAddress.Parse("6.0.249.18"),

System.Net.IPAddress.Parse("228.186.18.232"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.232.248.181"),

System.Net.IPAddress.Parse("254.96.62.95"),

System.Net.IPAddress.Parse("204.27.232.250"),

System.Net.IPAddress.Parse("98.74.63.60"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[27];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147260456));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("222.254.104.151"),

System.Net.IPAddress.Parse("35.120.204.142"),

System.Net.IPAddress.Parse("237.29.120.229"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }
                    
                    //todo return false
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                await foreach(var batchResult in ((IIPAddressArrayinetArray)this).DbConnectionSelectModelBatchAsync(connection, 1010630797, 2021824710))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(20));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1014982688));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("22.191.189.215"),

System.Net.IPAddress.Parse("65.198.53.118"),

System.Net.IPAddress.Parse("253.82.111.81"),

System.Net.IPAddress.Parse("109.106.219.163"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1862467653));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.88.48.172"),

System.Net.IPAddress.Parse("77.111.187.235"),

System.Net.IPAddress.Parse("140.225.127.72"),

System.Net.IPAddress.Parse("20.222.226.65"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1046694119));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.87.137.111"),

System.Net.IPAddress.Parse("204.14.65.176"),

System.Net.IPAddress.Parse("194.85.205.44"),

System.Net.IPAddress.Parse("222.89.92.13"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("174.246.168.218"),

System.Net.IPAddress.Parse("90.240.212.154"),

System.Net.IPAddress.Parse("111.18.35.98"),

System.Net.IPAddress.Parse("58.185.189.175"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(765048204));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.91.147.201"),

System.Net.IPAddress.Parse("147.186.92.48"),

System.Net.IPAddress.Parse("60.71.196.10"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1114047125));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.47.150.250"),

System.Net.IPAddress.Parse("76.64.178.53"),

System.Net.IPAddress.Parse("74.110.254.56"),

System.Net.IPAddress.Parse("56.58.223.51"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1147700318));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("23.44.179.107"),

System.Net.IPAddress.Parse("196.169.22.130"),

System.Net.IPAddress.Parse("60.74.92.160"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196291033));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("47.247.169.252"),

System.Net.IPAddress.Parse("18.219.84.183"),

System.Net.IPAddress.Parse("13.50.146.145"),

System.Net.IPAddress.Parse("0.239.215.227"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.119.178.252"),

System.Net.IPAddress.Parse("96.77.21.228"),

System.Net.IPAddress.Parse("226.72.38.185"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1349174950));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("183.169.138.174"),

System.Net.IPAddress.Parse("95.113.93.167"),

System.Net.IPAddress.Parse("78.227.47.135"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.145.155.228"),

System.Net.IPAddress.Parse("161.29.190.42"),

System.Net.IPAddress.Parse("168.125.120.148"),

System.Net.IPAddress.Parse("132.155.66.187"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1471142734));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("140.200.7.193"),

System.Net.IPAddress.Parse("63.81.70.232"),

System.Net.IPAddress.Parse("79.66.113.10"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("3.239.18.161"),

System.Net.IPAddress.Parse("16.25.54.42"),

System.Net.IPAddress.Parse("69.98.250.33"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1528940929));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.6.57.43"),

System.Net.IPAddress.Parse("5.149.125.169"),

System.Net.IPAddress.Parse("43.150.87.253"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1532913521));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("235.117.103.135"),

System.Net.IPAddress.Parse("15.13.51.218"),

System.Net.IPAddress.Parse("197.99.85.98"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(953727391));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("114.235.170.224"),

System.Net.IPAddress.Parse("193.13.164.151"),

System.Net.IPAddress.Parse("129.238.44.105"),

System.Net.IPAddress.Parse("5.34.244.103"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("44.89.163.66"),

System.Net.IPAddress.Parse("123.156.187.110"),

System.Net.IPAddress.Parse("96.179.241.171"),

System.Net.IPAddress.Parse("128.45.209.239"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1559862906));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("123.191.2.57"),

System.Net.IPAddress.Parse("69.224.113.83"),

System.Net.IPAddress.Parse("102.231.52.253"),

System.Net.IPAddress.Parse("18.4.226.114"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("254.83.134.181"),

System.Net.IPAddress.Parse("17.232.110.65"),

System.Net.IPAddress.Parse("118.41.56.117"),

System.Net.IPAddress.Parse("129.39.242.162"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1661207245));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.80.27.184"),

System.Net.IPAddress.Parse("30.2.102.227"),

System.Net.IPAddress.Parse("135.251.204.127"),

System.Net.IPAddress.Parse("246.191.51.237"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.156.39.174"),

System.Net.IPAddress.Parse("35.142.118.69"),

System.Net.IPAddress.Parse("43.123.160.110"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1189751706));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("91.60.140.37"),

System.Net.IPAddress.Parse("150.130.185.226"),

System.Net.IPAddress.Parse("230.21.248.241"),

System.Net.IPAddress.Parse("139.55.222.245"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("110.70.123.82"),

System.Net.IPAddress.Parse("32.62.116.191"),

System.Net.IPAddress.Parse("74.32.19.198"),

System.Net.IPAddress.Parse("82.243.186.251"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1699076580));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("214.85.93.26"),

System.Net.IPAddress.Parse("106.226.172.212"),

System.Net.IPAddress.Parse("171.14.233.176"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(70676916));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("39.60.201.212"),

System.Net.IPAddress.Parse("196.215.17.174"),

System.Net.IPAddress.Parse("228.167.214.185"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1715136659));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("150.90.144.88"),

System.Net.IPAddress.Parse("157.149.111.4"),

System.Net.IPAddress.Parse("147.122.4.69"),

System.Net.IPAddress.Parse("130.156.150.72"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.78.207.181"),

System.Net.IPAddress.Parse("181.240.67.47"),

System.Net.IPAddress.Parse("56.133.18.53"),

System.Net.IPAddress.Parse("134.229.3.96"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1717745304));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.137.169.190"),

System.Net.IPAddress.Parse("229.203.251.158"),

System.Net.IPAddress.Parse("171.237.52.109"),

System.Net.IPAddress.Parse("50.147.178.154"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("172.185.204.186"),

System.Net.IPAddress.Parse("106.82.31.235"),

System.Net.IPAddress.Parse("206.208.220.69"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1725349754));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("70.250.73.189"),

System.Net.IPAddress.Parse("95.140.155.78"),

System.Net.IPAddress.Parse("70.94.62.170"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1790443824));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("45.225.201.133"),

System.Net.IPAddress.Parse("198.20.142.127"),

System.Net.IPAddress.Parse("66.225.239.188"),

System.Net.IPAddress.Parse("227.77.214.15"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.171.228.100"),

System.Net.IPAddress.Parse("157.88.2.37"),

System.Net.IPAddress.Parse("189.136.20.241"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1836676977));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.164.33.149"),

System.Net.IPAddress.Parse("23.121.117.30"),

System.Net.IPAddress.Parse("14.189.80.148"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1978357694));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.51.23.223"),

System.Net.IPAddress.Parse("134.241.157.196"),

System.Net.IPAddress.Parse("90.94.206.223"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.7.110.41"),

System.Net.IPAddress.Parse("165.134.153.235"),

System.Net.IPAddress.Parse("238.83.157.117"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(114614856));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.38.190.64"),

System.Net.IPAddress.Parse("247.12.180.224"),

System.Net.IPAddress.Parse("5.87.110.35"),

System.Net.IPAddress.Parse("106.199.97.74"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2021824710));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.16.104.58"),

System.Net.IPAddress.Parse("153.225.37.221"),

System.Net.IPAddress.Parse("83.156.198.153"),

System.Net.IPAddress.Parse("96.225.216.80"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1025710404));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("188.72.220.140"),

System.Net.IPAddress.Parse("149.193.199.245"),

System.Net.IPAddress.Parse("219.59.217.173"),

System.Net.IPAddress.Parse("184.132.20.223"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.12.106.182"),

System.Net.IPAddress.Parse("68.197.243.110"),

System.Net.IPAddress.Parse("241.168.234.162"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2136763513));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.114.250.7"),

System.Net.IPAddress.Parse("218.55.187.129"),

System.Net.IPAddress.Parse("174.79.51.80"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1635158325));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.184.164.177"),

System.Net.IPAddress.Parse("87.109.19.33"),

System.Net.IPAddress.Parse("6.0.249.18"),

System.Net.IPAddress.Parse("228.186.18.232"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.232.248.181"),

System.Net.IPAddress.Parse("254.96.62.95"),

System.Net.IPAddress.Parse("204.27.232.250"),

System.Net.IPAddress.Parse("98.74.63.60"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147260456));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("222.254.104.151"),

System.Net.IPAddress.Parse("35.120.204.142"),

System.Net.IPAddress.Parse("237.29.120.229"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(2));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2136763513));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.114.250.7"),

System.Net.IPAddress.Parse("218.55.187.129"),

System.Net.IPAddress.Parse("174.79.51.80"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1635158325));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.184.164.177"),

System.Net.IPAddress.Parse("87.109.19.33"),

System.Net.IPAddress.Parse("6.0.249.18"),

System.Net.IPAddress.Parse("228.186.18.232"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.232.248.181"),

System.Net.IPAddress.Parse("254.96.62.95"),

System.Net.IPAddress.Parse("204.27.232.250"),

System.Net.IPAddress.Parse("98.74.63.60"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147260456));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("222.254.104.151"),

System.Net.IPAddress.Parse("35.120.204.142"),

System.Net.IPAddress.Parse("237.29.120.229"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }
                    
                    //todo return false
                }
            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(IPAddressinetArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
        private void ImportModelInnerConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_ipaddressinetarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(IPAddressinetArray1MI),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public
            )
            ]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<IPAddressinetArray1MI>(7);

                importCollection.Add(
                new IPAddressinetArray1MI
                {
                    Id = 70676916,
                    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("39.60.201.212"),

System.Net.IPAddress.Parse("196.215.17.174"),

System.Net.IPAddress.Parse("228.167.214.185"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinetArray1MI
                {
                    Id = 114614856,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.38.190.64"),

System.Net.IPAddress.Parse("247.12.180.224"),

System.Net.IPAddress.Parse("5.87.110.35"),

System.Net.IPAddress.Parse("106.199.97.74"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinetArray1MI
                {
                    Id = 489967818,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("252.111.135.144"),

System.Net.IPAddress.Parse("142.252.49.61"),

System.Net.IPAddress.Parse("210.184.110.102"),

System.Net.IPAddress.Parse("17.109.148.61"),

},
                    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.231.247.43"),

System.Net.IPAddress.Parse("212.228.220.217"),

System.Net.IPAddress.Parse("1.77.163.184"),

System.Net.IPAddress.Parse("88.223.57.100"),

}
                });

                importCollection.Add(
                new IPAddressinetArray1MI
                {
                    Id = 734112495,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.57.201.27"),

System.Net.IPAddress.Parse("106.212.15.97"),

System.Net.IPAddress.Parse("213.83.18.25"),

System.Net.IPAddress.Parse("150.36.102.95"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinetArray1MI
                {
                    Id = 765048204,
                    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.91.147.201"),

System.Net.IPAddress.Parse("147.186.92.48"),

System.Net.IPAddress.Parse("60.71.196.10"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinetArray1MI
                {
                    Id = 898710886,
                    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("215.1.195.107"),

System.Net.IPAddress.Parse("132.185.46.52"),

System.Net.IPAddress.Parse("114.104.142.186"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinetArray1MI
                {
                    Id = 953727391,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("114.235.170.224"),

System.Net.IPAddress.Parse("193.13.164.151"),

System.Net.IPAddress.Parse("129.238.44.105"),

System.Net.IPAddress.Parse("5.34.244.103"),

},
                    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("44.89.163.66"),

System.Net.IPAddress.Parse("123.156.187.110"),

System.Net.IPAddress.Parse("96.179.241.171"),

System.Net.IPAddress.Parse("128.45.209.239"),

}
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(70676916));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("39.60.201.212"),

System.Net.IPAddress.Parse("196.215.17.174"),

System.Net.IPAddress.Parse("228.167.214.185"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(114614856));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.38.190.64"),

System.Net.IPAddress.Parse("247.12.180.224"),

System.Net.IPAddress.Parse("5.87.110.35"),

System.Net.IPAddress.Parse("106.199.97.74"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(489967818));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("252.111.135.144"),

System.Net.IPAddress.Parse("142.252.49.61"),

System.Net.IPAddress.Parse("210.184.110.102"),

System.Net.IPAddress.Parse("17.109.148.61"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.231.247.43"),

System.Net.IPAddress.Parse("212.228.220.217"),

System.Net.IPAddress.Parse("1.77.163.184"),

System.Net.IPAddress.Parse("88.223.57.100"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(734112495));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.57.201.27"),

System.Net.IPAddress.Parse("106.212.15.97"),

System.Net.IPAddress.Parse("213.83.18.25"),

System.Net.IPAddress.Parse("150.36.102.95"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(765048204));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.91.147.201"),

System.Net.IPAddress.Parse("147.186.92.48"),

System.Net.IPAddress.Parse("60.71.196.10"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(898710886));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("215.1.195.107"),

System.Net.IPAddress.Parse("132.185.46.52"),

System.Net.IPAddress.Parse("114.104.142.186"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(953727391));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("114.235.170.224"),

System.Net.IPAddress.Parse("193.13.164.151"),

System.Net.IPAddress.Parse("129.238.44.105"),

System.Net.IPAddress.Parse("5.34.244.103"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("44.89.163.66"),

System.Net.IPAddress.Parse("123.156.187.110"),

System.Net.IPAddress.Parse("96.179.241.171"),

System.Net.IPAddress.Parse("128.45.209.239"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                importCollection.Clear();

                importCollection.Add(
                new IPAddressinetArray1MI
                {
                    Id = 1025710404,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("188.72.220.140"),

System.Net.IPAddress.Parse("149.193.199.245"),

System.Net.IPAddress.Parse("219.59.217.173"),

System.Net.IPAddress.Parse("184.132.20.223"),

},
                    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.12.106.182"),

System.Net.IPAddress.Parse("68.197.243.110"),

System.Net.IPAddress.Parse("241.168.234.162"),

}
                });

                importCollection.Add(
                new IPAddressinetArray1MI
                {
                    Id = 1147700318,
                    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("23.44.179.107"),

System.Net.IPAddress.Parse("196.169.22.130"),

System.Net.IPAddress.Parse("60.74.92.160"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinetArray1MI
                {
                    Id = 1189751706,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("91.60.140.37"),

System.Net.IPAddress.Parse("150.130.185.226"),

System.Net.IPAddress.Parse("230.21.248.241"),

System.Net.IPAddress.Parse("139.55.222.245"),

},
                    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("110.70.123.82"),

System.Net.IPAddress.Parse("32.62.116.191"),

System.Net.IPAddress.Parse("74.32.19.198"),

System.Net.IPAddress.Parse("82.243.186.251"),

}
                });

                importCollection.Add(
                new IPAddressinetArray1MI
                {
                    Id = 1225266561,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("161.64.174.220"),

System.Net.IPAddress.Parse("10.108.45.165"),

System.Net.IPAddress.Parse("236.217.123.2"),

System.Net.IPAddress.Parse("119.54.240.25"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinetArray1MI
                {
                    Id = 1524374413,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("17.243.164.43"),

System.Net.IPAddress.Parse("249.75.193.185"),

System.Net.IPAddress.Parse("250.156.153.118"),

System.Net.IPAddress.Parse("162.55.7.224"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinetArray1MI
                {
                    Id = 1635158325,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.184.164.177"),

System.Net.IPAddress.Parse("87.109.19.33"),

System.Net.IPAddress.Parse("6.0.249.18"),

System.Net.IPAddress.Parse("228.186.18.232"),

},
                    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.232.248.181"),

System.Net.IPAddress.Parse("254.96.62.95"),

System.Net.IPAddress.Parse("204.27.232.250"),

System.Net.IPAddress.Parse("98.74.63.60"),

}
                });

                importCollection.Add(
                new IPAddressinetArray1MI
                {
                    Id = 1862467653,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.88.48.172"),

System.Net.IPAddress.Parse("77.111.187.235"),

System.Net.IPAddress.Parse("140.225.127.72"),

System.Net.IPAddress.Parse("20.222.226.65"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinetArray1MI
                {
                    Id = 2060396617,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.220.56.129"),

System.Net.IPAddress.Parse("248.21.142.228"),

System.Net.IPAddress.Parse("55.148.181.184"),

System.Net.IPAddress.Parse("222.209.222.92"),

},
                    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("84.225.137.209"),

System.Net.IPAddress.Parse("27.250.31.59"),

System.Net.IPAddress.Parse("84.59.229.42"),

System.Net.IPAddress.Parse("228.151.53.140"),

}
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(70676916));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("39.60.201.212"),

System.Net.IPAddress.Parse("196.215.17.174"),

System.Net.IPAddress.Parse("228.167.214.185"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(114614856));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.38.190.64"),

System.Net.IPAddress.Parse("247.12.180.224"),

System.Net.IPAddress.Parse("5.87.110.35"),

System.Net.IPAddress.Parse("106.199.97.74"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(489967818));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("252.111.135.144"),

System.Net.IPAddress.Parse("142.252.49.61"),

System.Net.IPAddress.Parse("210.184.110.102"),

System.Net.IPAddress.Parse("17.109.148.61"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.231.247.43"),

System.Net.IPAddress.Parse("212.228.220.217"),

System.Net.IPAddress.Parse("1.77.163.184"),

System.Net.IPAddress.Parse("88.223.57.100"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(734112495));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.57.201.27"),

System.Net.IPAddress.Parse("106.212.15.97"),

System.Net.IPAddress.Parse("213.83.18.25"),

System.Net.IPAddress.Parse("150.36.102.95"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(765048204));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.91.147.201"),

System.Net.IPAddress.Parse("147.186.92.48"),

System.Net.IPAddress.Parse("60.71.196.10"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(898710886));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("215.1.195.107"),

System.Net.IPAddress.Parse("132.185.46.52"),

System.Net.IPAddress.Parse("114.104.142.186"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(953727391));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("114.235.170.224"),

System.Net.IPAddress.Parse("193.13.164.151"),

System.Net.IPAddress.Parse("129.238.44.105"),

System.Net.IPAddress.Parse("5.34.244.103"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("44.89.163.66"),

System.Net.IPAddress.Parse("123.156.187.110"),

System.Net.IPAddress.Parse("96.179.241.171"),

System.Net.IPAddress.Parse("128.45.209.239"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1025710404));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("188.72.220.140"),

System.Net.IPAddress.Parse("149.193.199.245"),

System.Net.IPAddress.Parse("219.59.217.173"),

System.Net.IPAddress.Parse("184.132.20.223"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.12.106.182"),

System.Net.IPAddress.Parse("68.197.243.110"),

System.Net.IPAddress.Parse("241.168.234.162"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1147700318));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("23.44.179.107"),

System.Net.IPAddress.Parse("196.169.22.130"),

System.Net.IPAddress.Parse("60.74.92.160"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1189751706));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("91.60.140.37"),

System.Net.IPAddress.Parse("150.130.185.226"),

System.Net.IPAddress.Parse("230.21.248.241"),

System.Net.IPAddress.Parse("139.55.222.245"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("110.70.123.82"),

System.Net.IPAddress.Parse("32.62.116.191"),

System.Net.IPAddress.Parse("74.32.19.198"),

System.Net.IPAddress.Parse("82.243.186.251"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225266561));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("161.64.174.220"),

System.Net.IPAddress.Parse("10.108.45.165"),

System.Net.IPAddress.Parse("236.217.123.2"),

System.Net.IPAddress.Parse("119.54.240.25"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1524374413));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("17.243.164.43"),

System.Net.IPAddress.Parse("249.75.193.185"),

System.Net.IPAddress.Parse("250.156.153.118"),

System.Net.IPAddress.Parse("162.55.7.224"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1635158325));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.184.164.177"),

System.Net.IPAddress.Parse("87.109.19.33"),

System.Net.IPAddress.Parse("6.0.249.18"),

System.Net.IPAddress.Parse("228.186.18.232"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.232.248.181"),

System.Net.IPAddress.Parse("254.96.62.95"),

System.Net.IPAddress.Parse("204.27.232.250"),

System.Net.IPAddress.Parse("98.74.63.60"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1862467653));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.88.48.172"),

System.Net.IPAddress.Parse("77.111.187.235"),

System.Net.IPAddress.Parse("140.225.127.72"),

System.Net.IPAddress.Parse("20.222.226.65"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2060396617));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.220.56.129"),

System.Net.IPAddress.Parse("248.21.142.228"),

System.Net.IPAddress.Parse("55.148.181.184"),

System.Net.IPAddress.Parse("222.209.222.92"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("84.225.137.209"),

System.Net.IPAddress.Parse("27.250.31.59"),

System.Net.IPAddress.Parse("84.59.229.42"),

System.Net.IPAddress.Parse("228.151.53.140"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinetarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
ipaddressinetarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(IPAddressinetArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
        private void ImportModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.binary_ipaddressinetarray1m m
LEFT JOIN public.binary_ipaddressinetarray1mi mi ON mi.id = m.ipaddressinetarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(IPAddressinetArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public
            )
            ]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<IPAddressinetArray1M>(15);

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 15009278,
                    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("124.154.94.55"),

System.Net.IPAddress.Parse("157.124.158.178"),

System.Net.IPAddress.Parse("49.165.141.3"),

},
                    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("105.80.72.238"),

System.Net.IPAddress.Parse("210.212.26.232"),

System.Net.IPAddress.Parse("154.77.207.133"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 120708206,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("192.57.237.242"),

System.Net.IPAddress.Parse("197.216.231.206"),

System.Net.IPAddress.Parse("242.236.138.184"),

System.Net.IPAddress.Parse("125.3.72.107"),

},
                    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("64.10.240.26"),

System.Net.IPAddress.Parse("236.225.164.217"),

System.Net.IPAddress.Parse("252.158.32.102"),

System.Net.IPAddress.Parse("82.19.117.150"),

},

                    ModelInner = new IPAddressinetArray1MI 
                    {
                        Id = 489967818
                    }

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 131351132,
                    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("41.56.170.121"),

System.Net.IPAddress.Parse("249.177.86.74"),

System.Net.IPAddress.Parse("52.16.51.138"),

},
                    NullableValue = null,

                    ModelInner = new IPAddressinetArray1MI 
                    {
                        Id = 1225266561
                    }

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 149175584,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("143.53.239.41"),

System.Net.IPAddress.Parse("240.239.90.237"),

System.Net.IPAddress.Parse("106.206.209.132"),

System.Net.IPAddress.Parse("118.238.228.56"),

},
                    NullableValue = null,

                    ModelInner = new IPAddressinetArray1MI 
                    {
                        Id = 898710886
                    }

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 408444095,
                    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("139.249.252.248"),

System.Net.IPAddress.Parse("144.156.246.243"),

System.Net.IPAddress.Parse("7.121.72.34"),

},
                    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("181.47.77.188"),

System.Net.IPAddress.Parse("135.31.242.74"),

System.Net.IPAddress.Parse("45.228.252.243"),

System.Net.IPAddress.Parse("139.12.116.83"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 503659545,
                    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("73.216.243.144"),

System.Net.IPAddress.Parse("24.177.166.236"),

System.Net.IPAddress.Parse("115.136.95.27"),

},
                    NullableValue = null,

                    ModelInner = new IPAddressinetArray1MI 
                    {
                        Id = 2060396617
                    }

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 514896285,
                    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.219.216.117"),

System.Net.IPAddress.Parse("89.223.230.10"),

System.Net.IPAddress.Parse("101.237.229.93"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 852427647,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("82.144.42.52"),

System.Net.IPAddress.Parse("220.191.234.145"),

System.Net.IPAddress.Parse("159.116.235.144"),

System.Net.IPAddress.Parse("174.135.250.231"),

},
                    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("71.164.41.0"),

System.Net.IPAddress.Parse("61.59.30.55"),

System.Net.IPAddress.Parse("45.244.40.47"),

System.Net.IPAddress.Parse("7.148.181.24"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 940810195,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.213.206.216"),

System.Net.IPAddress.Parse("72.223.64.78"),

System.Net.IPAddress.Parse("231.212.27.90"),

System.Net.IPAddress.Parse("183.1.33.133"),

},
                    NullableValue = null,

                    ModelInner = new IPAddressinetArray1MI 
                    {
                        Id = 1524374413
                    }

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 1010630797,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("163.15.105.153"),

System.Net.IPAddress.Parse("168.113.141.115"),

System.Net.IPAddress.Parse("88.155.244.27"),

System.Net.IPAddress.Parse("96.94.105.38"),

},
                    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("13.112.111.81"),

System.Net.IPAddress.Parse("145.60.238.238"),

System.Net.IPAddress.Parse("56.181.140.233"),

System.Net.IPAddress.Parse("170.79.152.19"),

},

                    ModelInner = new IPAddressinetArray1MI 
                    {
                        Id = 734112495
                    }

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 1014982688,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("22.191.189.215"),

System.Net.IPAddress.Parse("65.198.53.118"),

System.Net.IPAddress.Parse("253.82.111.81"),

System.Net.IPAddress.Parse("109.106.219.163"),

},
                    NullableValue = null,

                    ModelInner = new IPAddressinetArray1MI 
                    {
                        Id = 1862467653
                    }

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 1046694119,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.87.137.111"),

System.Net.IPAddress.Parse("204.14.65.176"),

System.Net.IPAddress.Parse("194.85.205.44"),

System.Net.IPAddress.Parse("222.89.92.13"),

},
                    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("174.246.168.218"),

System.Net.IPAddress.Parse("90.240.212.154"),

System.Net.IPAddress.Parse("111.18.35.98"),

System.Net.IPAddress.Parse("58.185.189.175"),

},

                    ModelInner = new IPAddressinetArray1MI 
                    {
                        Id = 765048204
                    }

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 1114047125,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.47.150.250"),

System.Net.IPAddress.Parse("76.64.178.53"),

System.Net.IPAddress.Parse("74.110.254.56"),

System.Net.IPAddress.Parse("56.58.223.51"),

},
                    NullableValue = null,

                    ModelInner = new IPAddressinetArray1MI 
                    {
                        Id = 1147700318
                    }

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 1196291033,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("47.247.169.252"),

System.Net.IPAddress.Parse("18.219.84.183"),

System.Net.IPAddress.Parse("13.50.146.145"),

System.Net.IPAddress.Parse("0.239.215.227"),

},
                    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.119.178.252"),

System.Net.IPAddress.Parse("96.77.21.228"),

System.Net.IPAddress.Parse("226.72.38.185"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 1349174950,
                    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("183.169.138.174"),

System.Net.IPAddress.Parse("95.113.93.167"),

System.Net.IPAddress.Parse("78.227.47.135"),

},
                    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.145.155.228"),

System.Net.IPAddress.Parse("161.29.190.42"),

System.Net.IPAddress.Parse("168.125.120.148"),

System.Net.IPAddress.Parse("132.155.66.187"),

},

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(15009278));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("124.154.94.55"),

System.Net.IPAddress.Parse("157.124.158.178"),

System.Net.IPAddress.Parse("49.165.141.3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("105.80.72.238"),

System.Net.IPAddress.Parse("210.212.26.232"),

System.Net.IPAddress.Parse("154.77.207.133"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(120708206));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("192.57.237.242"),

System.Net.IPAddress.Parse("197.216.231.206"),

System.Net.IPAddress.Parse("242.236.138.184"),

System.Net.IPAddress.Parse("125.3.72.107"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("64.10.240.26"),

System.Net.IPAddress.Parse("236.225.164.217"),

System.Net.IPAddress.Parse("252.158.32.102"),

System.Net.IPAddress.Parse("82.19.117.150"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(489967818));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("252.111.135.144"),

System.Net.IPAddress.Parse("142.252.49.61"),

System.Net.IPAddress.Parse("210.184.110.102"),

System.Net.IPAddress.Parse("17.109.148.61"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.231.247.43"),

System.Net.IPAddress.Parse("212.228.220.217"),

System.Net.IPAddress.Parse("1.77.163.184"),

System.Net.IPAddress.Parse("88.223.57.100"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(131351132));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("41.56.170.121"),

System.Net.IPAddress.Parse("249.177.86.74"),

System.Net.IPAddress.Parse("52.16.51.138"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1225266561));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("161.64.174.220"),

System.Net.IPAddress.Parse("10.108.45.165"),

System.Net.IPAddress.Parse("236.217.123.2"),

System.Net.IPAddress.Parse("119.54.240.25"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(149175584));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("143.53.239.41"),

System.Net.IPAddress.Parse("240.239.90.237"),

System.Net.IPAddress.Parse("106.206.209.132"),

System.Net.IPAddress.Parse("118.238.228.56"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(898710886));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("215.1.195.107"),

System.Net.IPAddress.Parse("132.185.46.52"),

System.Net.IPAddress.Parse("114.104.142.186"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(408444095));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("139.249.252.248"),

System.Net.IPAddress.Parse("144.156.246.243"),

System.Net.IPAddress.Parse("7.121.72.34"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("181.47.77.188"),

System.Net.IPAddress.Parse("135.31.242.74"),

System.Net.IPAddress.Parse("45.228.252.243"),

System.Net.IPAddress.Parse("139.12.116.83"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(503659545));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("73.216.243.144"),

System.Net.IPAddress.Parse("24.177.166.236"),

System.Net.IPAddress.Parse("115.136.95.27"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2060396617));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.220.56.129"),

System.Net.IPAddress.Parse("248.21.142.228"),

System.Net.IPAddress.Parse("55.148.181.184"),

System.Net.IPAddress.Parse("222.209.222.92"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("84.225.137.209"),

System.Net.IPAddress.Parse("27.250.31.59"),

System.Net.IPAddress.Parse("84.59.229.42"),

System.Net.IPAddress.Parse("228.151.53.140"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(514896285));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.219.216.117"),

System.Net.IPAddress.Parse("89.223.230.10"),

System.Net.IPAddress.Parse("101.237.229.93"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(852427647));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("82.144.42.52"),

System.Net.IPAddress.Parse("220.191.234.145"),

System.Net.IPAddress.Parse("159.116.235.144"),

System.Net.IPAddress.Parse("174.135.250.231"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("71.164.41.0"),

System.Net.IPAddress.Parse("61.59.30.55"),

System.Net.IPAddress.Parse("45.244.40.47"),

System.Net.IPAddress.Parse("7.148.181.24"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(940810195));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.213.206.216"),

System.Net.IPAddress.Parse("72.223.64.78"),

System.Net.IPAddress.Parse("231.212.27.90"),

System.Net.IPAddress.Parse("183.1.33.133"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1524374413));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("17.243.164.43"),

System.Net.IPAddress.Parse("249.75.193.185"),

System.Net.IPAddress.Parse("250.156.153.118"),

System.Net.IPAddress.Parse("162.55.7.224"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1010630797));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("163.15.105.153"),

System.Net.IPAddress.Parse("168.113.141.115"),

System.Net.IPAddress.Parse("88.155.244.27"),

System.Net.IPAddress.Parse("96.94.105.38"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("13.112.111.81"),

System.Net.IPAddress.Parse("145.60.238.238"),

System.Net.IPAddress.Parse("56.181.140.233"),

System.Net.IPAddress.Parse("170.79.152.19"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(734112495));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.57.201.27"),

System.Net.IPAddress.Parse("106.212.15.97"),

System.Net.IPAddress.Parse("213.83.18.25"),

System.Net.IPAddress.Parse("150.36.102.95"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1014982688));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("22.191.189.215"),

System.Net.IPAddress.Parse("65.198.53.118"),

System.Net.IPAddress.Parse("253.82.111.81"),

System.Net.IPAddress.Parse("109.106.219.163"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1862467653));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.88.48.172"),

System.Net.IPAddress.Parse("77.111.187.235"),

System.Net.IPAddress.Parse("140.225.127.72"),

System.Net.IPAddress.Parse("20.222.226.65"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1046694119));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.87.137.111"),

System.Net.IPAddress.Parse("204.14.65.176"),

System.Net.IPAddress.Parse("194.85.205.44"),

System.Net.IPAddress.Parse("222.89.92.13"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("174.246.168.218"),

System.Net.IPAddress.Parse("90.240.212.154"),

System.Net.IPAddress.Parse("111.18.35.98"),

System.Net.IPAddress.Parse("58.185.189.175"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(765048204));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.91.147.201"),

System.Net.IPAddress.Parse("147.186.92.48"),

System.Net.IPAddress.Parse("60.71.196.10"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1114047125));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.47.150.250"),

System.Net.IPAddress.Parse("76.64.178.53"),

System.Net.IPAddress.Parse("74.110.254.56"),

System.Net.IPAddress.Parse("56.58.223.51"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1147700318));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("23.44.179.107"),

System.Net.IPAddress.Parse("196.169.22.130"),

System.Net.IPAddress.Parse("60.74.92.160"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196291033));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("47.247.169.252"),

System.Net.IPAddress.Parse("18.219.84.183"),

System.Net.IPAddress.Parse("13.50.146.145"),

System.Net.IPAddress.Parse("0.239.215.227"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.119.178.252"),

System.Net.IPAddress.Parse("96.77.21.228"),

System.Net.IPAddress.Parse("226.72.38.185"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1349174950));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("183.169.138.174"),

System.Net.IPAddress.Parse("95.113.93.167"),

System.Net.IPAddress.Parse("78.227.47.135"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.145.155.228"),

System.Net.IPAddress.Parse("161.29.190.42"),

System.Net.IPAddress.Parse("168.125.120.148"),

System.Net.IPAddress.Parse("132.155.66.187"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 1471142734,
                    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("140.200.7.193"),

System.Net.IPAddress.Parse("63.81.70.232"),

System.Net.IPAddress.Parse("79.66.113.10"),

},
                    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("3.239.18.161"),

System.Net.IPAddress.Parse("16.25.54.42"),

System.Net.IPAddress.Parse("69.98.250.33"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 1528940929,
                    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.6.57.43"),

System.Net.IPAddress.Parse("5.149.125.169"),

System.Net.IPAddress.Parse("43.150.87.253"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 1532913521,
                    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("235.117.103.135"),

System.Net.IPAddress.Parse("15.13.51.218"),

System.Net.IPAddress.Parse("197.99.85.98"),

},
                    NullableValue = null,

                    ModelInner = new IPAddressinetArray1MI 
                    {
                        Id = 953727391
                    }

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 1559862906,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("123.191.2.57"),

System.Net.IPAddress.Parse("69.224.113.83"),

System.Net.IPAddress.Parse("102.231.52.253"),

System.Net.IPAddress.Parse("18.4.226.114"),

},
                    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("254.83.134.181"),

System.Net.IPAddress.Parse("17.232.110.65"),

System.Net.IPAddress.Parse("118.41.56.117"),

System.Net.IPAddress.Parse("129.39.242.162"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 1661207245,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.80.27.184"),

System.Net.IPAddress.Parse("30.2.102.227"),

System.Net.IPAddress.Parse("135.251.204.127"),

System.Net.IPAddress.Parse("246.191.51.237"),

},
                    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.156.39.174"),

System.Net.IPAddress.Parse("35.142.118.69"),

System.Net.IPAddress.Parse("43.123.160.110"),

},

                    ModelInner = new IPAddressinetArray1MI 
                    {
                        Id = 1189751706
                    }

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 1699076580,
                    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("214.85.93.26"),

System.Net.IPAddress.Parse("106.226.172.212"),

System.Net.IPAddress.Parse("171.14.233.176"),

},
                    NullableValue = null,

                    ModelInner = new IPAddressinetArray1MI 
                    {
                        Id = 70676916
                    }

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 1715136659,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("150.90.144.88"),

System.Net.IPAddress.Parse("157.149.111.4"),

System.Net.IPAddress.Parse("147.122.4.69"),

System.Net.IPAddress.Parse("130.156.150.72"),

},
                    NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.78.207.181"),

System.Net.IPAddress.Parse("181.240.67.47"),

System.Net.IPAddress.Parse("56.133.18.53"),

System.Net.IPAddress.Parse("134.229.3.96"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 1717745304,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.137.169.190"),

System.Net.IPAddress.Parse("229.203.251.158"),

System.Net.IPAddress.Parse("171.237.52.109"),

System.Net.IPAddress.Parse("50.147.178.154"),

},
                    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("172.185.204.186"),

System.Net.IPAddress.Parse("106.82.31.235"),

System.Net.IPAddress.Parse("206.208.220.69"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 1725349754,
                    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("70.250.73.189"),

System.Net.IPAddress.Parse("95.140.155.78"),

System.Net.IPAddress.Parse("70.94.62.170"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 1790443824,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("45.225.201.133"),

System.Net.IPAddress.Parse("198.20.142.127"),

System.Net.IPAddress.Parse("66.225.239.188"),

System.Net.IPAddress.Parse("227.77.214.15"),

},
                    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.171.228.100"),

System.Net.IPAddress.Parse("157.88.2.37"),

System.Net.IPAddress.Parse("189.136.20.241"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 1836676977,
                    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.164.33.149"),

System.Net.IPAddress.Parse("23.121.117.30"),

System.Net.IPAddress.Parse("14.189.80.148"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 1978357694,
                    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.51.23.223"),

System.Net.IPAddress.Parse("134.241.157.196"),

System.Net.IPAddress.Parse("90.94.206.223"),

},
                    NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.7.110.41"),

System.Net.IPAddress.Parse("165.134.153.235"),

System.Net.IPAddress.Parse("238.83.157.117"),

},

                    ModelInner = new IPAddressinetArray1MI 
                    {
                        Id = 114614856
                    }

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 2021824710,
                    Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.16.104.58"),

System.Net.IPAddress.Parse("153.225.37.221"),

System.Net.IPAddress.Parse("83.156.198.153"),

System.Net.IPAddress.Parse("96.225.216.80"),

},
                    NullableValue = null,

                    ModelInner = new IPAddressinetArray1MI 
                    {
                        Id = 1025710404
                    }

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 2136763513,
                    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.114.250.7"),

System.Net.IPAddress.Parse("218.55.187.129"),

System.Net.IPAddress.Parse("174.79.51.80"),

},
                    NullableValue = null,

                    ModelInner = new IPAddressinetArray1MI 
                    {
                        Id = 1635158325
                    }

                });

                importCollection.Add(
                new IPAddressinetArray1M
                {
                    Id = 2147260456,
                    Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("222.254.104.151"),

System.Net.IPAddress.Parse("35.120.204.142"),

System.Net.IPAddress.Parse("237.29.120.229"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(15009278));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("124.154.94.55"),

System.Net.IPAddress.Parse("157.124.158.178"),

System.Net.IPAddress.Parse("49.165.141.3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("105.80.72.238"),

System.Net.IPAddress.Parse("210.212.26.232"),

System.Net.IPAddress.Parse("154.77.207.133"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(120708206));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("192.57.237.242"),

System.Net.IPAddress.Parse("197.216.231.206"),

System.Net.IPAddress.Parse("242.236.138.184"),

System.Net.IPAddress.Parse("125.3.72.107"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("64.10.240.26"),

System.Net.IPAddress.Parse("236.225.164.217"),

System.Net.IPAddress.Parse("252.158.32.102"),

System.Net.IPAddress.Parse("82.19.117.150"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(489967818));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("252.111.135.144"),

System.Net.IPAddress.Parse("142.252.49.61"),

System.Net.IPAddress.Parse("210.184.110.102"),

System.Net.IPAddress.Parse("17.109.148.61"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.231.247.43"),

System.Net.IPAddress.Parse("212.228.220.217"),

System.Net.IPAddress.Parse("1.77.163.184"),

System.Net.IPAddress.Parse("88.223.57.100"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(131351132));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("41.56.170.121"),

System.Net.IPAddress.Parse("249.177.86.74"),

System.Net.IPAddress.Parse("52.16.51.138"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1225266561));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("161.64.174.220"),

System.Net.IPAddress.Parse("10.108.45.165"),

System.Net.IPAddress.Parse("236.217.123.2"),

System.Net.IPAddress.Parse("119.54.240.25"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(149175584));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("143.53.239.41"),

System.Net.IPAddress.Parse("240.239.90.237"),

System.Net.IPAddress.Parse("106.206.209.132"),

System.Net.IPAddress.Parse("118.238.228.56"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(898710886));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("215.1.195.107"),

System.Net.IPAddress.Parse("132.185.46.52"),

System.Net.IPAddress.Parse("114.104.142.186"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(408444095));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("139.249.252.248"),

System.Net.IPAddress.Parse("144.156.246.243"),

System.Net.IPAddress.Parse("7.121.72.34"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("181.47.77.188"),

System.Net.IPAddress.Parse("135.31.242.74"),

System.Net.IPAddress.Parse("45.228.252.243"),

System.Net.IPAddress.Parse("139.12.116.83"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(503659545));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("73.216.243.144"),

System.Net.IPAddress.Parse("24.177.166.236"),

System.Net.IPAddress.Parse("115.136.95.27"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2060396617));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.220.56.129"),

System.Net.IPAddress.Parse("248.21.142.228"),

System.Net.IPAddress.Parse("55.148.181.184"),

System.Net.IPAddress.Parse("222.209.222.92"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("84.225.137.209"),

System.Net.IPAddress.Parse("27.250.31.59"),

System.Net.IPAddress.Parse("84.59.229.42"),

System.Net.IPAddress.Parse("228.151.53.140"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(514896285));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.219.216.117"),

System.Net.IPAddress.Parse("89.223.230.10"),

System.Net.IPAddress.Parse("101.237.229.93"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(852427647));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("82.144.42.52"),

System.Net.IPAddress.Parse("220.191.234.145"),

System.Net.IPAddress.Parse("159.116.235.144"),

System.Net.IPAddress.Parse("174.135.250.231"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("71.164.41.0"),

System.Net.IPAddress.Parse("61.59.30.55"),

System.Net.IPAddress.Parse("45.244.40.47"),

System.Net.IPAddress.Parse("7.148.181.24"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(940810195));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.213.206.216"),

System.Net.IPAddress.Parse("72.223.64.78"),

System.Net.IPAddress.Parse("231.212.27.90"),

System.Net.IPAddress.Parse("183.1.33.133"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1524374413));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("17.243.164.43"),

System.Net.IPAddress.Parse("249.75.193.185"),

System.Net.IPAddress.Parse("250.156.153.118"),

System.Net.IPAddress.Parse("162.55.7.224"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1010630797));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("163.15.105.153"),

System.Net.IPAddress.Parse("168.113.141.115"),

System.Net.IPAddress.Parse("88.155.244.27"),

System.Net.IPAddress.Parse("96.94.105.38"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("13.112.111.81"),

System.Net.IPAddress.Parse("145.60.238.238"),

System.Net.IPAddress.Parse("56.181.140.233"),

System.Net.IPAddress.Parse("170.79.152.19"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(734112495));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.57.201.27"),

System.Net.IPAddress.Parse("106.212.15.97"),

System.Net.IPAddress.Parse("213.83.18.25"),

System.Net.IPAddress.Parse("150.36.102.95"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1014982688));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("22.191.189.215"),

System.Net.IPAddress.Parse("65.198.53.118"),

System.Net.IPAddress.Parse("253.82.111.81"),

System.Net.IPAddress.Parse("109.106.219.163"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1862467653));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.88.48.172"),

System.Net.IPAddress.Parse("77.111.187.235"),

System.Net.IPAddress.Parse("140.225.127.72"),

System.Net.IPAddress.Parse("20.222.226.65"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1046694119));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.87.137.111"),

System.Net.IPAddress.Parse("204.14.65.176"),

System.Net.IPAddress.Parse("194.85.205.44"),

System.Net.IPAddress.Parse("222.89.92.13"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("174.246.168.218"),

System.Net.IPAddress.Parse("90.240.212.154"),

System.Net.IPAddress.Parse("111.18.35.98"),

System.Net.IPAddress.Parse("58.185.189.175"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(765048204));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.91.147.201"),

System.Net.IPAddress.Parse("147.186.92.48"),

System.Net.IPAddress.Parse("60.71.196.10"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1114047125));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.47.150.250"),

System.Net.IPAddress.Parse("76.64.178.53"),

System.Net.IPAddress.Parse("74.110.254.56"),

System.Net.IPAddress.Parse("56.58.223.51"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1147700318));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("23.44.179.107"),

System.Net.IPAddress.Parse("196.169.22.130"),

System.Net.IPAddress.Parse("60.74.92.160"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196291033));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("47.247.169.252"),

System.Net.IPAddress.Parse("18.219.84.183"),

System.Net.IPAddress.Parse("13.50.146.145"),

System.Net.IPAddress.Parse("0.239.215.227"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.119.178.252"),

System.Net.IPAddress.Parse("96.77.21.228"),

System.Net.IPAddress.Parse("226.72.38.185"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1349174950));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("183.169.138.174"),

System.Net.IPAddress.Parse("95.113.93.167"),

System.Net.IPAddress.Parse("78.227.47.135"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.145.155.228"),

System.Net.IPAddress.Parse("161.29.190.42"),

System.Net.IPAddress.Parse("168.125.120.148"),

System.Net.IPAddress.Parse("132.155.66.187"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1471142734));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("140.200.7.193"),

System.Net.IPAddress.Parse("63.81.70.232"),

System.Net.IPAddress.Parse("79.66.113.10"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("3.239.18.161"),

System.Net.IPAddress.Parse("16.25.54.42"),

System.Net.IPAddress.Parse("69.98.250.33"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1528940929));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.6.57.43"),

System.Net.IPAddress.Parse("5.149.125.169"),

System.Net.IPAddress.Parse("43.150.87.253"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1532913521));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("235.117.103.135"),

System.Net.IPAddress.Parse("15.13.51.218"),

System.Net.IPAddress.Parse("197.99.85.98"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(953727391));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("114.235.170.224"),

System.Net.IPAddress.Parse("193.13.164.151"),

System.Net.IPAddress.Parse("129.238.44.105"),

System.Net.IPAddress.Parse("5.34.244.103"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("44.89.163.66"),

System.Net.IPAddress.Parse("123.156.187.110"),

System.Net.IPAddress.Parse("96.179.241.171"),

System.Net.IPAddress.Parse("128.45.209.239"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1559862906));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("123.191.2.57"),

System.Net.IPAddress.Parse("69.224.113.83"),

System.Net.IPAddress.Parse("102.231.52.253"),

System.Net.IPAddress.Parse("18.4.226.114"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("254.83.134.181"),

System.Net.IPAddress.Parse("17.232.110.65"),

System.Net.IPAddress.Parse("118.41.56.117"),

System.Net.IPAddress.Parse("129.39.242.162"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1661207245));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.80.27.184"),

System.Net.IPAddress.Parse("30.2.102.227"),

System.Net.IPAddress.Parse("135.251.204.127"),

System.Net.IPAddress.Parse("246.191.51.237"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.156.39.174"),

System.Net.IPAddress.Parse("35.142.118.69"),

System.Net.IPAddress.Parse("43.123.160.110"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1189751706));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("91.60.140.37"),

System.Net.IPAddress.Parse("150.130.185.226"),

System.Net.IPAddress.Parse("230.21.248.241"),

System.Net.IPAddress.Parse("139.55.222.245"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("110.70.123.82"),

System.Net.IPAddress.Parse("32.62.116.191"),

System.Net.IPAddress.Parse("74.32.19.198"),

System.Net.IPAddress.Parse("82.243.186.251"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1699076580));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("214.85.93.26"),

System.Net.IPAddress.Parse("106.226.172.212"),

System.Net.IPAddress.Parse("171.14.233.176"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(70676916));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("39.60.201.212"),

System.Net.IPAddress.Parse("196.215.17.174"),

System.Net.IPAddress.Parse("228.167.214.185"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1715136659));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("150.90.144.88"),

System.Net.IPAddress.Parse("157.149.111.4"),

System.Net.IPAddress.Parse("147.122.4.69"),

System.Net.IPAddress.Parse("130.156.150.72"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.78.207.181"),

System.Net.IPAddress.Parse("181.240.67.47"),

System.Net.IPAddress.Parse("56.133.18.53"),

System.Net.IPAddress.Parse("134.229.3.96"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1717745304));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.137.169.190"),

System.Net.IPAddress.Parse("229.203.251.158"),

System.Net.IPAddress.Parse("171.237.52.109"),

System.Net.IPAddress.Parse("50.147.178.154"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("172.185.204.186"),

System.Net.IPAddress.Parse("106.82.31.235"),

System.Net.IPAddress.Parse("206.208.220.69"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1725349754));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("70.250.73.189"),

System.Net.IPAddress.Parse("95.140.155.78"),

System.Net.IPAddress.Parse("70.94.62.170"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1790443824));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("45.225.201.133"),

System.Net.IPAddress.Parse("198.20.142.127"),

System.Net.IPAddress.Parse("66.225.239.188"),

System.Net.IPAddress.Parse("227.77.214.15"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.171.228.100"),

System.Net.IPAddress.Parse("157.88.2.37"),

System.Net.IPAddress.Parse("189.136.20.241"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1836676977));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.164.33.149"),

System.Net.IPAddress.Parse("23.121.117.30"),

System.Net.IPAddress.Parse("14.189.80.148"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1978357694));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.51.23.223"),

System.Net.IPAddress.Parse("134.241.157.196"),

System.Net.IPAddress.Parse("90.94.206.223"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.7.110.41"),

System.Net.IPAddress.Parse("165.134.153.235"),

System.Net.IPAddress.Parse("238.83.157.117"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(114614856));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.38.190.64"),

System.Net.IPAddress.Parse("247.12.180.224"),

System.Net.IPAddress.Parse("5.87.110.35"),

System.Net.IPAddress.Parse("106.199.97.74"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2021824710));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.16.104.58"),

System.Net.IPAddress.Parse("153.225.37.221"),

System.Net.IPAddress.Parse("83.156.198.153"),

System.Net.IPAddress.Parse("96.225.216.80"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1025710404));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("188.72.220.140"),

System.Net.IPAddress.Parse("149.193.199.245"),

System.Net.IPAddress.Parse("219.59.217.173"),

System.Net.IPAddress.Parse("184.132.20.223"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.12.106.182"),

System.Net.IPAddress.Parse("68.197.243.110"),

System.Net.IPAddress.Parse("241.168.234.162"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2136763513));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.114.250.7"),

System.Net.IPAddress.Parse("218.55.187.129"),

System.Net.IPAddress.Parse("174.79.51.80"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1635158325));

                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.184.164.177"),

System.Net.IPAddress.Parse("87.109.19.33"),

System.Net.IPAddress.Parse("6.0.249.18"),

System.Net.IPAddress.Parse("228.186.18.232"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.232.248.181"),

System.Net.IPAddress.Parse("254.96.62.95"),

System.Net.IPAddress.Parse("204.27.232.250"),

System.Net.IPAddress.Parse("98.74.63.60"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147260456));
                {
                    var expectEnumerValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("222.254.104.151"),

System.Net.IPAddress.Parse("35.120.204.142"),

System.Net.IPAddress.Parse("237.29.120.229"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    ipaddressinetarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(IPAddressinetArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,IPAddressinetArray1M>(30);

                expected.Add(
                    15009278,
                    new IPAddressinetArray1M
                    {
                        Id = 15009278,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("124.154.94.55"),

System.Net.IPAddress.Parse("157.124.158.178"),

System.Net.IPAddress.Parse("49.165.141.3"),

},
                        NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("105.80.72.238"),

System.Net.IPAddress.Parse("210.212.26.232"),

System.Net.IPAddress.Parse("154.77.207.133"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    120708206,
                    new IPAddressinetArray1M
                    {
                        Id = 120708206,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("192.57.237.242"),

System.Net.IPAddress.Parse("197.216.231.206"),

System.Net.IPAddress.Parse("242.236.138.184"),

System.Net.IPAddress.Parse("125.3.72.107"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("64.10.240.26"),

System.Net.IPAddress.Parse("236.225.164.217"),

System.Net.IPAddress.Parse("252.158.32.102"),

System.Net.IPAddress.Parse("82.19.117.150"),

},

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 489967818,
                            Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("252.111.135.144"),

System.Net.IPAddress.Parse("142.252.49.61"),

System.Net.IPAddress.Parse("210.184.110.102"),

System.Net.IPAddress.Parse("17.109.148.61"),

},
                            NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.231.247.43"),

System.Net.IPAddress.Parse("212.228.220.217"),

System.Net.IPAddress.Parse("1.77.163.184"),

System.Net.IPAddress.Parse("88.223.57.100"),

}
                        }

                    }
                );

                expected.Add(
                    131351132,
                    new IPAddressinetArray1M
                    {
                        Id = 131351132,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("41.56.170.121"),

System.Net.IPAddress.Parse("249.177.86.74"),

System.Net.IPAddress.Parse("52.16.51.138"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 1225266561,
                            Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("161.64.174.220"),

System.Net.IPAddress.Parse("10.108.45.165"),

System.Net.IPAddress.Parse("236.217.123.2"),

System.Net.IPAddress.Parse("119.54.240.25"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    149175584,
                    new IPAddressinetArray1M
                    {
                        Id = 149175584,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("143.53.239.41"),

System.Net.IPAddress.Parse("240.239.90.237"),

System.Net.IPAddress.Parse("106.206.209.132"),

System.Net.IPAddress.Parse("118.238.228.56"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 898710886,
                            Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("215.1.195.107"),

System.Net.IPAddress.Parse("132.185.46.52"),

System.Net.IPAddress.Parse("114.104.142.186"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    408444095,
                    new IPAddressinetArray1M
                    {
                        Id = 408444095,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("139.249.252.248"),

System.Net.IPAddress.Parse("144.156.246.243"),

System.Net.IPAddress.Parse("7.121.72.34"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("181.47.77.188"),

System.Net.IPAddress.Parse("135.31.242.74"),

System.Net.IPAddress.Parse("45.228.252.243"),

System.Net.IPAddress.Parse("139.12.116.83"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    503659545,
                    new IPAddressinetArray1M
                    {
                        Id = 503659545,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("73.216.243.144"),

System.Net.IPAddress.Parse("24.177.166.236"),

System.Net.IPAddress.Parse("115.136.95.27"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 2060396617,
                            Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.220.56.129"),

System.Net.IPAddress.Parse("248.21.142.228"),

System.Net.IPAddress.Parse("55.148.181.184"),

System.Net.IPAddress.Parse("222.209.222.92"),

},
                            NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("84.225.137.209"),

System.Net.IPAddress.Parse("27.250.31.59"),

System.Net.IPAddress.Parse("84.59.229.42"),

System.Net.IPAddress.Parse("228.151.53.140"),

}
                        }

                    }
                );

                expected.Add(
                    514896285,
                    new IPAddressinetArray1M
                    {
                        Id = 514896285,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.219.216.117"),

System.Net.IPAddress.Parse("89.223.230.10"),

System.Net.IPAddress.Parse("101.237.229.93"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    852427647,
                    new IPAddressinetArray1M
                    {
                        Id = 852427647,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("82.144.42.52"),

System.Net.IPAddress.Parse("220.191.234.145"),

System.Net.IPAddress.Parse("159.116.235.144"),

System.Net.IPAddress.Parse("174.135.250.231"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("71.164.41.0"),

System.Net.IPAddress.Parse("61.59.30.55"),

System.Net.IPAddress.Parse("45.244.40.47"),

System.Net.IPAddress.Parse("7.148.181.24"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    940810195,
                    new IPAddressinetArray1M
                    {
                        Id = 940810195,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.213.206.216"),

System.Net.IPAddress.Parse("72.223.64.78"),

System.Net.IPAddress.Parse("231.212.27.90"),

System.Net.IPAddress.Parse("183.1.33.133"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 1524374413,
                            Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("17.243.164.43"),

System.Net.IPAddress.Parse("249.75.193.185"),

System.Net.IPAddress.Parse("250.156.153.118"),

System.Net.IPAddress.Parse("162.55.7.224"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1010630797,
                    new IPAddressinetArray1M
                    {
                        Id = 1010630797,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("163.15.105.153"),

System.Net.IPAddress.Parse("168.113.141.115"),

System.Net.IPAddress.Parse("88.155.244.27"),

System.Net.IPAddress.Parse("96.94.105.38"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("13.112.111.81"),

System.Net.IPAddress.Parse("145.60.238.238"),

System.Net.IPAddress.Parse("56.181.140.233"),

System.Net.IPAddress.Parse("170.79.152.19"),

},

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 734112495,
                            Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.57.201.27"),

System.Net.IPAddress.Parse("106.212.15.97"),

System.Net.IPAddress.Parse("213.83.18.25"),

System.Net.IPAddress.Parse("150.36.102.95"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1014982688,
                    new IPAddressinetArray1M
                    {
                        Id = 1014982688,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("22.191.189.215"),

System.Net.IPAddress.Parse("65.198.53.118"),

System.Net.IPAddress.Parse("253.82.111.81"),

System.Net.IPAddress.Parse("109.106.219.163"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 1862467653,
                            Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.88.48.172"),

System.Net.IPAddress.Parse("77.111.187.235"),

System.Net.IPAddress.Parse("140.225.127.72"),

System.Net.IPAddress.Parse("20.222.226.65"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1046694119,
                    new IPAddressinetArray1M
                    {
                        Id = 1046694119,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.87.137.111"),

System.Net.IPAddress.Parse("204.14.65.176"),

System.Net.IPAddress.Parse("194.85.205.44"),

System.Net.IPAddress.Parse("222.89.92.13"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("174.246.168.218"),

System.Net.IPAddress.Parse("90.240.212.154"),

System.Net.IPAddress.Parse("111.18.35.98"),

System.Net.IPAddress.Parse("58.185.189.175"),

},

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 765048204,
                            Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.91.147.201"),

System.Net.IPAddress.Parse("147.186.92.48"),

System.Net.IPAddress.Parse("60.71.196.10"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1114047125,
                    new IPAddressinetArray1M
                    {
                        Id = 1114047125,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.47.150.250"),

System.Net.IPAddress.Parse("76.64.178.53"),

System.Net.IPAddress.Parse("74.110.254.56"),

System.Net.IPAddress.Parse("56.58.223.51"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 1147700318,
                            Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("23.44.179.107"),

System.Net.IPAddress.Parse("196.169.22.130"),

System.Net.IPAddress.Parse("60.74.92.160"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1196291033,
                    new IPAddressinetArray1M
                    {
                        Id = 1196291033,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("47.247.169.252"),

System.Net.IPAddress.Parse("18.219.84.183"),

System.Net.IPAddress.Parse("13.50.146.145"),

System.Net.IPAddress.Parse("0.239.215.227"),

},
                        NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.119.178.252"),

System.Net.IPAddress.Parse("96.77.21.228"),

System.Net.IPAddress.Parse("226.72.38.185"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1349174950,
                    new IPAddressinetArray1M
                    {
                        Id = 1349174950,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("183.169.138.174"),

System.Net.IPAddress.Parse("95.113.93.167"),

System.Net.IPAddress.Parse("78.227.47.135"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.145.155.228"),

System.Net.IPAddress.Parse("161.29.190.42"),

System.Net.IPAddress.Parse("168.125.120.148"),

System.Net.IPAddress.Parse("132.155.66.187"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1471142734,
                    new IPAddressinetArray1M
                    {
                        Id = 1471142734,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("140.200.7.193"),

System.Net.IPAddress.Parse("63.81.70.232"),

System.Net.IPAddress.Parse("79.66.113.10"),

},
                        NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("3.239.18.161"),

System.Net.IPAddress.Parse("16.25.54.42"),

System.Net.IPAddress.Parse("69.98.250.33"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1528940929,
                    new IPAddressinetArray1M
                    {
                        Id = 1528940929,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.6.57.43"),

System.Net.IPAddress.Parse("5.149.125.169"),

System.Net.IPAddress.Parse("43.150.87.253"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1532913521,
                    new IPAddressinetArray1M
                    {
                        Id = 1532913521,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("235.117.103.135"),

System.Net.IPAddress.Parse("15.13.51.218"),

System.Net.IPAddress.Parse("197.99.85.98"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 953727391,
                            Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("114.235.170.224"),

System.Net.IPAddress.Parse("193.13.164.151"),

System.Net.IPAddress.Parse("129.238.44.105"),

System.Net.IPAddress.Parse("5.34.244.103"),

},
                            NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("44.89.163.66"),

System.Net.IPAddress.Parse("123.156.187.110"),

System.Net.IPAddress.Parse("96.179.241.171"),

System.Net.IPAddress.Parse("128.45.209.239"),

}
                        }

                    }
                );

                expected.Add(
                    1559862906,
                    new IPAddressinetArray1M
                    {
                        Id = 1559862906,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("123.191.2.57"),

System.Net.IPAddress.Parse("69.224.113.83"),

System.Net.IPAddress.Parse("102.231.52.253"),

System.Net.IPAddress.Parse("18.4.226.114"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("254.83.134.181"),

System.Net.IPAddress.Parse("17.232.110.65"),

System.Net.IPAddress.Parse("118.41.56.117"),

System.Net.IPAddress.Parse("129.39.242.162"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1661207245,
                    new IPAddressinetArray1M
                    {
                        Id = 1661207245,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.80.27.184"),

System.Net.IPAddress.Parse("30.2.102.227"),

System.Net.IPAddress.Parse("135.251.204.127"),

System.Net.IPAddress.Parse("246.191.51.237"),

},
                        NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.156.39.174"),

System.Net.IPAddress.Parse("35.142.118.69"),

System.Net.IPAddress.Parse("43.123.160.110"),

},

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 1189751706,
                            Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("91.60.140.37"),

System.Net.IPAddress.Parse("150.130.185.226"),

System.Net.IPAddress.Parse("230.21.248.241"),

System.Net.IPAddress.Parse("139.55.222.245"),

},
                            NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("110.70.123.82"),

System.Net.IPAddress.Parse("32.62.116.191"),

System.Net.IPAddress.Parse("74.32.19.198"),

System.Net.IPAddress.Parse("82.243.186.251"),

}
                        }

                    }
                );

                expected.Add(
                    1699076580,
                    new IPAddressinetArray1M
                    {
                        Id = 1699076580,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("214.85.93.26"),

System.Net.IPAddress.Parse("106.226.172.212"),

System.Net.IPAddress.Parse("171.14.233.176"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 70676916,
                            Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("39.60.201.212"),

System.Net.IPAddress.Parse("196.215.17.174"),

System.Net.IPAddress.Parse("228.167.214.185"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1715136659,
                    new IPAddressinetArray1M
                    {
                        Id = 1715136659,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("150.90.144.88"),

System.Net.IPAddress.Parse("157.149.111.4"),

System.Net.IPAddress.Parse("147.122.4.69"),

System.Net.IPAddress.Parse("130.156.150.72"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.78.207.181"),

System.Net.IPAddress.Parse("181.240.67.47"),

System.Net.IPAddress.Parse("56.133.18.53"),

System.Net.IPAddress.Parse("134.229.3.96"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1717745304,
                    new IPAddressinetArray1M
                    {
                        Id = 1717745304,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.137.169.190"),

System.Net.IPAddress.Parse("229.203.251.158"),

System.Net.IPAddress.Parse("171.237.52.109"),

System.Net.IPAddress.Parse("50.147.178.154"),

},
                        NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("172.185.204.186"),

System.Net.IPAddress.Parse("106.82.31.235"),

System.Net.IPAddress.Parse("206.208.220.69"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1725349754,
                    new IPAddressinetArray1M
                    {
                        Id = 1725349754,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("70.250.73.189"),

System.Net.IPAddress.Parse("95.140.155.78"),

System.Net.IPAddress.Parse("70.94.62.170"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1790443824,
                    new IPAddressinetArray1M
                    {
                        Id = 1790443824,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("45.225.201.133"),

System.Net.IPAddress.Parse("198.20.142.127"),

System.Net.IPAddress.Parse("66.225.239.188"),

System.Net.IPAddress.Parse("227.77.214.15"),

},
                        NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.171.228.100"),

System.Net.IPAddress.Parse("157.88.2.37"),

System.Net.IPAddress.Parse("189.136.20.241"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1836676977,
                    new IPAddressinetArray1M
                    {
                        Id = 1836676977,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.164.33.149"),

System.Net.IPAddress.Parse("23.121.117.30"),

System.Net.IPAddress.Parse("14.189.80.148"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1978357694,
                    new IPAddressinetArray1M
                    {
                        Id = 1978357694,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.51.23.223"),

System.Net.IPAddress.Parse("134.241.157.196"),

System.Net.IPAddress.Parse("90.94.206.223"),

},
                        NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.7.110.41"),

System.Net.IPAddress.Parse("165.134.153.235"),

System.Net.IPAddress.Parse("238.83.157.117"),

},

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 114614856,
                            Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.38.190.64"),

System.Net.IPAddress.Parse("247.12.180.224"),

System.Net.IPAddress.Parse("5.87.110.35"),

System.Net.IPAddress.Parse("106.199.97.74"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2021824710,
                    new IPAddressinetArray1M
                    {
                        Id = 2021824710,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.16.104.58"),

System.Net.IPAddress.Parse("153.225.37.221"),

System.Net.IPAddress.Parse("83.156.198.153"),

System.Net.IPAddress.Parse("96.225.216.80"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 1025710404,
                            Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("188.72.220.140"),

System.Net.IPAddress.Parse("149.193.199.245"),

System.Net.IPAddress.Parse("219.59.217.173"),

System.Net.IPAddress.Parse("184.132.20.223"),

},
                            NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.12.106.182"),

System.Net.IPAddress.Parse("68.197.243.110"),

System.Net.IPAddress.Parse("241.168.234.162"),

}
                        }

                    }
                );

                expected.Add(
                    2136763513,
                    new IPAddressinetArray1M
                    {
                        Id = 2136763513,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.114.250.7"),

System.Net.IPAddress.Parse("218.55.187.129"),

System.Net.IPAddress.Parse("174.79.51.80"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 1635158325,
                            Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.184.164.177"),

System.Net.IPAddress.Parse("87.109.19.33"),

System.Net.IPAddress.Parse("6.0.249.18"),

System.Net.IPAddress.Parse("228.186.18.232"),

},
                            NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.232.248.181"),

System.Net.IPAddress.Parse("254.96.62.95"),

System.Net.IPAddress.Parse("204.27.232.250"),

System.Net.IPAddress.Parse("98.74.63.60"),

}
                        }

                    }
                );

                expected.Add(
                    2147260456,
                    new IPAddressinetArray1M
                    {
                        Id = 2147260456,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("222.254.104.151"),

System.Net.IPAddress.Parse("35.120.204.142"),

System.Net.IPAddress.Parse("237.29.120.229"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                var models =  ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue == null)
                {
                    Assert.That(model.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                    }
                }

                if(expectedModel.ModelInner == null)
                {
                    Assert.That(model.ModelInner, Is.Null);
                }
                else
                {
                    Assert.That(model.ModelInner, Is.Not.Null);
                    Assert.That(model.ModelInner.Id, Is.EqualTo(expectedModel.ModelInner.Id));

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Net.IPAddress[])default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,IPAddressinetArray1M>(30);

                expected.Add(
                    15009278,
                    new IPAddressinetArray1M
                    {
                        Id = 15009278,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("124.154.94.55"),

System.Net.IPAddress.Parse("157.124.158.178"),

System.Net.IPAddress.Parse("49.165.141.3"),

},
                        NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("105.80.72.238"),

System.Net.IPAddress.Parse("210.212.26.232"),

System.Net.IPAddress.Parse("154.77.207.133"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    120708206,
                    new IPAddressinetArray1M
                    {
                        Id = 120708206,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("192.57.237.242"),

System.Net.IPAddress.Parse("197.216.231.206"),

System.Net.IPAddress.Parse("242.236.138.184"),

System.Net.IPAddress.Parse("125.3.72.107"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("64.10.240.26"),

System.Net.IPAddress.Parse("236.225.164.217"),

System.Net.IPAddress.Parse("252.158.32.102"),

System.Net.IPAddress.Parse("82.19.117.150"),

},

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 489967818,
                            Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("252.111.135.144"),

System.Net.IPAddress.Parse("142.252.49.61"),

System.Net.IPAddress.Parse("210.184.110.102"),

System.Net.IPAddress.Parse("17.109.148.61"),

},
                            NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.231.247.43"),

System.Net.IPAddress.Parse("212.228.220.217"),

System.Net.IPAddress.Parse("1.77.163.184"),

System.Net.IPAddress.Parse("88.223.57.100"),

}
                        }

                    }
                );

                expected.Add(
                    131351132,
                    new IPAddressinetArray1M
                    {
                        Id = 131351132,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("41.56.170.121"),

System.Net.IPAddress.Parse("249.177.86.74"),

System.Net.IPAddress.Parse("52.16.51.138"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 1225266561,
                            Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("161.64.174.220"),

System.Net.IPAddress.Parse("10.108.45.165"),

System.Net.IPAddress.Parse("236.217.123.2"),

System.Net.IPAddress.Parse("119.54.240.25"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    149175584,
                    new IPAddressinetArray1M
                    {
                        Id = 149175584,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("143.53.239.41"),

System.Net.IPAddress.Parse("240.239.90.237"),

System.Net.IPAddress.Parse("106.206.209.132"),

System.Net.IPAddress.Parse("118.238.228.56"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 898710886,
                            Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("215.1.195.107"),

System.Net.IPAddress.Parse("132.185.46.52"),

System.Net.IPAddress.Parse("114.104.142.186"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    408444095,
                    new IPAddressinetArray1M
                    {
                        Id = 408444095,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("139.249.252.248"),

System.Net.IPAddress.Parse("144.156.246.243"),

System.Net.IPAddress.Parse("7.121.72.34"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("181.47.77.188"),

System.Net.IPAddress.Parse("135.31.242.74"),

System.Net.IPAddress.Parse("45.228.252.243"),

System.Net.IPAddress.Parse("139.12.116.83"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    503659545,
                    new IPAddressinetArray1M
                    {
                        Id = 503659545,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("73.216.243.144"),

System.Net.IPAddress.Parse("24.177.166.236"),

System.Net.IPAddress.Parse("115.136.95.27"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 2060396617,
                            Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.220.56.129"),

System.Net.IPAddress.Parse("248.21.142.228"),

System.Net.IPAddress.Parse("55.148.181.184"),

System.Net.IPAddress.Parse("222.209.222.92"),

},
                            NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("84.225.137.209"),

System.Net.IPAddress.Parse("27.250.31.59"),

System.Net.IPAddress.Parse("84.59.229.42"),

System.Net.IPAddress.Parse("228.151.53.140"),

}
                        }

                    }
                );

                expected.Add(
                    514896285,
                    new IPAddressinetArray1M
                    {
                        Id = 514896285,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.219.216.117"),

System.Net.IPAddress.Parse("89.223.230.10"),

System.Net.IPAddress.Parse("101.237.229.93"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    852427647,
                    new IPAddressinetArray1M
                    {
                        Id = 852427647,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("82.144.42.52"),

System.Net.IPAddress.Parse("220.191.234.145"),

System.Net.IPAddress.Parse("159.116.235.144"),

System.Net.IPAddress.Parse("174.135.250.231"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("71.164.41.0"),

System.Net.IPAddress.Parse("61.59.30.55"),

System.Net.IPAddress.Parse("45.244.40.47"),

System.Net.IPAddress.Parse("7.148.181.24"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    940810195,
                    new IPAddressinetArray1M
                    {
                        Id = 940810195,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.213.206.216"),

System.Net.IPAddress.Parse("72.223.64.78"),

System.Net.IPAddress.Parse("231.212.27.90"),

System.Net.IPAddress.Parse("183.1.33.133"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 1524374413,
                            Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("17.243.164.43"),

System.Net.IPAddress.Parse("249.75.193.185"),

System.Net.IPAddress.Parse("250.156.153.118"),

System.Net.IPAddress.Parse("162.55.7.224"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1010630797,
                    new IPAddressinetArray1M
                    {
                        Id = 1010630797,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("163.15.105.153"),

System.Net.IPAddress.Parse("168.113.141.115"),

System.Net.IPAddress.Parse("88.155.244.27"),

System.Net.IPAddress.Parse("96.94.105.38"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("13.112.111.81"),

System.Net.IPAddress.Parse("145.60.238.238"),

System.Net.IPAddress.Parse("56.181.140.233"),

System.Net.IPAddress.Parse("170.79.152.19"),

},

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 734112495,
                            Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.57.201.27"),

System.Net.IPAddress.Parse("106.212.15.97"),

System.Net.IPAddress.Parse("213.83.18.25"),

System.Net.IPAddress.Parse("150.36.102.95"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1014982688,
                    new IPAddressinetArray1M
                    {
                        Id = 1014982688,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("22.191.189.215"),

System.Net.IPAddress.Parse("65.198.53.118"),

System.Net.IPAddress.Parse("253.82.111.81"),

System.Net.IPAddress.Parse("109.106.219.163"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 1862467653,
                            Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.88.48.172"),

System.Net.IPAddress.Parse("77.111.187.235"),

System.Net.IPAddress.Parse("140.225.127.72"),

System.Net.IPAddress.Parse("20.222.226.65"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1046694119,
                    new IPAddressinetArray1M
                    {
                        Id = 1046694119,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.87.137.111"),

System.Net.IPAddress.Parse("204.14.65.176"),

System.Net.IPAddress.Parse("194.85.205.44"),

System.Net.IPAddress.Parse("222.89.92.13"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("174.246.168.218"),

System.Net.IPAddress.Parse("90.240.212.154"),

System.Net.IPAddress.Parse("111.18.35.98"),

System.Net.IPAddress.Parse("58.185.189.175"),

},

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 765048204,
                            Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.91.147.201"),

System.Net.IPAddress.Parse("147.186.92.48"),

System.Net.IPAddress.Parse("60.71.196.10"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1114047125,
                    new IPAddressinetArray1M
                    {
                        Id = 1114047125,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.47.150.250"),

System.Net.IPAddress.Parse("76.64.178.53"),

System.Net.IPAddress.Parse("74.110.254.56"),

System.Net.IPAddress.Parse("56.58.223.51"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 1147700318,
                            Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("23.44.179.107"),

System.Net.IPAddress.Parse("196.169.22.130"),

System.Net.IPAddress.Parse("60.74.92.160"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1196291033,
                    new IPAddressinetArray1M
                    {
                        Id = 1196291033,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("47.247.169.252"),

System.Net.IPAddress.Parse("18.219.84.183"),

System.Net.IPAddress.Parse("13.50.146.145"),

System.Net.IPAddress.Parse("0.239.215.227"),

},
                        NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("170.119.178.252"),

System.Net.IPAddress.Parse("96.77.21.228"),

System.Net.IPAddress.Parse("226.72.38.185"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1349174950,
                    new IPAddressinetArray1M
                    {
                        Id = 1349174950,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("183.169.138.174"),

System.Net.IPAddress.Parse("95.113.93.167"),

System.Net.IPAddress.Parse("78.227.47.135"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("246.145.155.228"),

System.Net.IPAddress.Parse("161.29.190.42"),

System.Net.IPAddress.Parse("168.125.120.148"),

System.Net.IPAddress.Parse("132.155.66.187"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1471142734,
                    new IPAddressinetArray1M
                    {
                        Id = 1471142734,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("140.200.7.193"),

System.Net.IPAddress.Parse("63.81.70.232"),

System.Net.IPAddress.Parse("79.66.113.10"),

},
                        NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("3.239.18.161"),

System.Net.IPAddress.Parse("16.25.54.42"),

System.Net.IPAddress.Parse("69.98.250.33"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1528940929,
                    new IPAddressinetArray1M
                    {
                        Id = 1528940929,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("107.6.57.43"),

System.Net.IPAddress.Parse("5.149.125.169"),

System.Net.IPAddress.Parse("43.150.87.253"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1532913521,
                    new IPAddressinetArray1M
                    {
                        Id = 1532913521,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("235.117.103.135"),

System.Net.IPAddress.Parse("15.13.51.218"),

System.Net.IPAddress.Parse("197.99.85.98"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 953727391,
                            Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("114.235.170.224"),

System.Net.IPAddress.Parse("193.13.164.151"),

System.Net.IPAddress.Parse("129.238.44.105"),

System.Net.IPAddress.Parse("5.34.244.103"),

},
                            NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("44.89.163.66"),

System.Net.IPAddress.Parse("123.156.187.110"),

System.Net.IPAddress.Parse("96.179.241.171"),

System.Net.IPAddress.Parse("128.45.209.239"),

}
                        }

                    }
                );

                expected.Add(
                    1559862906,
                    new IPAddressinetArray1M
                    {
                        Id = 1559862906,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("123.191.2.57"),

System.Net.IPAddress.Parse("69.224.113.83"),

System.Net.IPAddress.Parse("102.231.52.253"),

System.Net.IPAddress.Parse("18.4.226.114"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("254.83.134.181"),

System.Net.IPAddress.Parse("17.232.110.65"),

System.Net.IPAddress.Parse("118.41.56.117"),

System.Net.IPAddress.Parse("129.39.242.162"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1661207245,
                    new IPAddressinetArray1M
                    {
                        Id = 1661207245,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("77.80.27.184"),

System.Net.IPAddress.Parse("30.2.102.227"),

System.Net.IPAddress.Parse("135.251.204.127"),

System.Net.IPAddress.Parse("246.191.51.237"),

},
                        NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.156.39.174"),

System.Net.IPAddress.Parse("35.142.118.69"),

System.Net.IPAddress.Parse("43.123.160.110"),

},

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 1189751706,
                            Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("91.60.140.37"),

System.Net.IPAddress.Parse("150.130.185.226"),

System.Net.IPAddress.Parse("230.21.248.241"),

System.Net.IPAddress.Parse("139.55.222.245"),

},
                            NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("110.70.123.82"),

System.Net.IPAddress.Parse("32.62.116.191"),

System.Net.IPAddress.Parse("74.32.19.198"),

System.Net.IPAddress.Parse("82.243.186.251"),

}
                        }

                    }
                );

                expected.Add(
                    1699076580,
                    new IPAddressinetArray1M
                    {
                        Id = 1699076580,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("214.85.93.26"),

System.Net.IPAddress.Parse("106.226.172.212"),

System.Net.IPAddress.Parse("171.14.233.176"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 70676916,
                            Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("39.60.201.212"),

System.Net.IPAddress.Parse("196.215.17.174"),

System.Net.IPAddress.Parse("228.167.214.185"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1715136659,
                    new IPAddressinetArray1M
                    {
                        Id = 1715136659,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("150.90.144.88"),

System.Net.IPAddress.Parse("157.149.111.4"),

System.Net.IPAddress.Parse("147.122.4.69"),

System.Net.IPAddress.Parse("130.156.150.72"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("112.78.207.181"),

System.Net.IPAddress.Parse("181.240.67.47"),

System.Net.IPAddress.Parse("56.133.18.53"),

System.Net.IPAddress.Parse("134.229.3.96"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1717745304,
                    new IPAddressinetArray1M
                    {
                        Id = 1717745304,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("205.137.169.190"),

System.Net.IPAddress.Parse("229.203.251.158"),

System.Net.IPAddress.Parse("171.237.52.109"),

System.Net.IPAddress.Parse("50.147.178.154"),

},
                        NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("172.185.204.186"),

System.Net.IPAddress.Parse("106.82.31.235"),

System.Net.IPAddress.Parse("206.208.220.69"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1725349754,
                    new IPAddressinetArray1M
                    {
                        Id = 1725349754,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("70.250.73.189"),

System.Net.IPAddress.Parse("95.140.155.78"),

System.Net.IPAddress.Parse("70.94.62.170"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1790443824,
                    new IPAddressinetArray1M
                    {
                        Id = 1790443824,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("45.225.201.133"),

System.Net.IPAddress.Parse("198.20.142.127"),

System.Net.IPAddress.Parse("66.225.239.188"),

System.Net.IPAddress.Parse("227.77.214.15"),

},
                        NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.171.228.100"),

System.Net.IPAddress.Parse("157.88.2.37"),

System.Net.IPAddress.Parse("189.136.20.241"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1836676977,
                    new IPAddressinetArray1M
                    {
                        Id = 1836676977,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("18.164.33.149"),

System.Net.IPAddress.Parse("23.121.117.30"),

System.Net.IPAddress.Parse("14.189.80.148"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1978357694,
                    new IPAddressinetArray1M
                    {
                        Id = 1978357694,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("251.51.23.223"),

System.Net.IPAddress.Parse("134.241.157.196"),

System.Net.IPAddress.Parse("90.94.206.223"),

},
                        NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("111.7.110.41"),

System.Net.IPAddress.Parse("165.134.153.235"),

System.Net.IPAddress.Parse("238.83.157.117"),

},

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 114614856,
                            Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.38.190.64"),

System.Net.IPAddress.Parse("247.12.180.224"),

System.Net.IPAddress.Parse("5.87.110.35"),

System.Net.IPAddress.Parse("106.199.97.74"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2021824710,
                    new IPAddressinetArray1M
                    {
                        Id = 2021824710,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("153.16.104.58"),

System.Net.IPAddress.Parse("153.225.37.221"),

System.Net.IPAddress.Parse("83.156.198.153"),

System.Net.IPAddress.Parse("96.225.216.80"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 1025710404,
                            Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("188.72.220.140"),

System.Net.IPAddress.Parse("149.193.199.245"),

System.Net.IPAddress.Parse("219.59.217.173"),

System.Net.IPAddress.Parse("184.132.20.223"),

},
                            NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.12.106.182"),

System.Net.IPAddress.Parse("68.197.243.110"),

System.Net.IPAddress.Parse("241.168.234.162"),

}
                        }

                    }
                );

                expected.Add(
                    2136763513,
                    new IPAddressinetArray1M
                    {
                        Id = 2136763513,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.114.250.7"),

System.Net.IPAddress.Parse("218.55.187.129"),

System.Net.IPAddress.Parse("174.79.51.80"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray1MI
                        {
                            Id = 1635158325,
                            Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.184.164.177"),

System.Net.IPAddress.Parse("87.109.19.33"),

System.Net.IPAddress.Parse("6.0.249.18"),

System.Net.IPAddress.Parse("228.186.18.232"),

},
                            NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.232.248.181"),

System.Net.IPAddress.Parse("254.96.62.95"),

System.Net.IPAddress.Parse("204.27.232.250"),

System.Net.IPAddress.Parse("98.74.63.60"),

}
                        }

                    }
                );

                expected.Add(
                    2147260456,
                    new IPAddressinetArray1M
                    {
                        Id = 2147260456,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("222.254.104.151"),

System.Net.IPAddress.Parse("35.120.204.142"),

System.Net.IPAddress.Parse("237.29.120.229"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                var models = await ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue == null)
                {
                    Assert.That(model.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                    }
                }

                if(expectedModel.ModelInner == null)
                {
                    Assert.That(model.ModelInner, Is.Null);
                }
                else
                {
                    Assert.That(model.ModelInner, Is.Not.Null);
                    Assert.That(model.ModelInner.Id, Is.EqualTo(expectedModel.ModelInner.Id));

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Net.IPAddress[])default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(IPAddressinetArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624),
                (NpgsqlTypes.NpgsqlDbType)(-2147483624)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,IPAddressinetArray1MI>(15);

                expected.Add(
                    70676916,
                    new IPAddressinetArray1MI
                    {
                        Id = 70676916,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("39.60.201.212"),

System.Net.IPAddress.Parse("196.215.17.174"),

System.Net.IPAddress.Parse("228.167.214.185"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    114614856,
                    new IPAddressinetArray1MI
                    {
                        Id = 114614856,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.38.190.64"),

System.Net.IPAddress.Parse("247.12.180.224"),

System.Net.IPAddress.Parse("5.87.110.35"),

System.Net.IPAddress.Parse("106.199.97.74"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    489967818,
                    new IPAddressinetArray1MI
                    {
                        Id = 489967818,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("252.111.135.144"),

System.Net.IPAddress.Parse("142.252.49.61"),

System.Net.IPAddress.Parse("210.184.110.102"),

System.Net.IPAddress.Parse("17.109.148.61"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.231.247.43"),

System.Net.IPAddress.Parse("212.228.220.217"),

System.Net.IPAddress.Parse("1.77.163.184"),

System.Net.IPAddress.Parse("88.223.57.100"),

}
                    }
                );

                expected.Add(
                    734112495,
                    new IPAddressinetArray1MI
                    {
                        Id = 734112495,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.57.201.27"),

System.Net.IPAddress.Parse("106.212.15.97"),

System.Net.IPAddress.Parse("213.83.18.25"),

System.Net.IPAddress.Parse("150.36.102.95"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    765048204,
                    new IPAddressinetArray1MI
                    {
                        Id = 765048204,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.91.147.201"),

System.Net.IPAddress.Parse("147.186.92.48"),

System.Net.IPAddress.Parse("60.71.196.10"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    898710886,
                    new IPAddressinetArray1MI
                    {
                        Id = 898710886,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("215.1.195.107"),

System.Net.IPAddress.Parse("132.185.46.52"),

System.Net.IPAddress.Parse("114.104.142.186"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    953727391,
                    new IPAddressinetArray1MI
                    {
                        Id = 953727391,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("114.235.170.224"),

System.Net.IPAddress.Parse("193.13.164.151"),

System.Net.IPAddress.Parse("129.238.44.105"),

System.Net.IPAddress.Parse("5.34.244.103"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("44.89.163.66"),

System.Net.IPAddress.Parse("123.156.187.110"),

System.Net.IPAddress.Parse("96.179.241.171"),

System.Net.IPAddress.Parse("128.45.209.239"),

}
                    }
                );

                expected.Add(
                    1025710404,
                    new IPAddressinetArray1MI
                    {
                        Id = 1025710404,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("188.72.220.140"),

System.Net.IPAddress.Parse("149.193.199.245"),

System.Net.IPAddress.Parse("219.59.217.173"),

System.Net.IPAddress.Parse("184.132.20.223"),

},
                        NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.12.106.182"),

System.Net.IPAddress.Parse("68.197.243.110"),

System.Net.IPAddress.Parse("241.168.234.162"),

}
                    }
                );

                expected.Add(
                    1147700318,
                    new IPAddressinetArray1MI
                    {
                        Id = 1147700318,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("23.44.179.107"),

System.Net.IPAddress.Parse("196.169.22.130"),

System.Net.IPAddress.Parse("60.74.92.160"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1189751706,
                    new IPAddressinetArray1MI
                    {
                        Id = 1189751706,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("91.60.140.37"),

System.Net.IPAddress.Parse("150.130.185.226"),

System.Net.IPAddress.Parse("230.21.248.241"),

System.Net.IPAddress.Parse("139.55.222.245"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("110.70.123.82"),

System.Net.IPAddress.Parse("32.62.116.191"),

System.Net.IPAddress.Parse("74.32.19.198"),

System.Net.IPAddress.Parse("82.243.186.251"),

}
                    }
                );

                expected.Add(
                    1225266561,
                    new IPAddressinetArray1MI
                    {
                        Id = 1225266561,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("161.64.174.220"),

System.Net.IPAddress.Parse("10.108.45.165"),

System.Net.IPAddress.Parse("236.217.123.2"),

System.Net.IPAddress.Parse("119.54.240.25"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1524374413,
                    new IPAddressinetArray1MI
                    {
                        Id = 1524374413,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("17.243.164.43"),

System.Net.IPAddress.Parse("249.75.193.185"),

System.Net.IPAddress.Parse("250.156.153.118"),

System.Net.IPAddress.Parse("162.55.7.224"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1635158325,
                    new IPAddressinetArray1MI
                    {
                        Id = 1635158325,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.184.164.177"),

System.Net.IPAddress.Parse("87.109.19.33"),

System.Net.IPAddress.Parse("6.0.249.18"),

System.Net.IPAddress.Parse("228.186.18.232"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.232.248.181"),

System.Net.IPAddress.Parse("254.96.62.95"),

System.Net.IPAddress.Parse("204.27.232.250"),

System.Net.IPAddress.Parse("98.74.63.60"),

}
                    }
                );

                expected.Add(
                    1862467653,
                    new IPAddressinetArray1MI
                    {
                        Id = 1862467653,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.88.48.172"),

System.Net.IPAddress.Parse("77.111.187.235"),

System.Net.IPAddress.Parse("140.225.127.72"),

System.Net.IPAddress.Parse("20.222.226.65"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2060396617,
                    new IPAddressinetArray1MI
                    {
                        Id = 2060396617,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.220.56.129"),

System.Net.IPAddress.Parse("248.21.142.228"),

System.Net.IPAddress.Parse("55.148.181.184"),

System.Net.IPAddress.Parse("222.209.222.92"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("84.225.137.209"),

System.Net.IPAddress.Parse("27.250.31.59"),

System.Net.IPAddress.Parse("84.59.229.42"),

System.Net.IPAddress.Parse("228.151.53.140"),

}
                    }
                );

                var models =  ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue != null)
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                }
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Null);
                }


                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,IPAddressinetArray1MI>(15);

                expected.Add(
                    70676916,
                    new IPAddressinetArray1MI
                    {
                        Id = 70676916,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("39.60.201.212"),

System.Net.IPAddress.Parse("196.215.17.174"),

System.Net.IPAddress.Parse("228.167.214.185"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    114614856,
                    new IPAddressinetArray1MI
                    {
                        Id = 114614856,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("87.38.190.64"),

System.Net.IPAddress.Parse("247.12.180.224"),

System.Net.IPAddress.Parse("5.87.110.35"),

System.Net.IPAddress.Parse("106.199.97.74"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    489967818,
                    new IPAddressinetArray1MI
                    {
                        Id = 489967818,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("252.111.135.144"),

System.Net.IPAddress.Parse("142.252.49.61"),

System.Net.IPAddress.Parse("210.184.110.102"),

System.Net.IPAddress.Parse("17.109.148.61"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("46.231.247.43"),

System.Net.IPAddress.Parse("212.228.220.217"),

System.Net.IPAddress.Parse("1.77.163.184"),

System.Net.IPAddress.Parse("88.223.57.100"),

}
                    }
                );

                expected.Add(
                    734112495,
                    new IPAddressinetArray1MI
                    {
                        Id = 734112495,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("235.57.201.27"),

System.Net.IPAddress.Parse("106.212.15.97"),

System.Net.IPAddress.Parse("213.83.18.25"),

System.Net.IPAddress.Parse("150.36.102.95"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    765048204,
                    new IPAddressinetArray1MI
                    {
                        Id = 765048204,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("211.91.147.201"),

System.Net.IPAddress.Parse("147.186.92.48"),

System.Net.IPAddress.Parse("60.71.196.10"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    898710886,
                    new IPAddressinetArray1MI
                    {
                        Id = 898710886,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("215.1.195.107"),

System.Net.IPAddress.Parse("132.185.46.52"),

System.Net.IPAddress.Parse("114.104.142.186"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    953727391,
                    new IPAddressinetArray1MI
                    {
                        Id = 953727391,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("114.235.170.224"),

System.Net.IPAddress.Parse("193.13.164.151"),

System.Net.IPAddress.Parse("129.238.44.105"),

System.Net.IPAddress.Parse("5.34.244.103"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("44.89.163.66"),

System.Net.IPAddress.Parse("123.156.187.110"),

System.Net.IPAddress.Parse("96.179.241.171"),

System.Net.IPAddress.Parse("128.45.209.239"),

}
                    }
                );

                expected.Add(
                    1025710404,
                    new IPAddressinetArray1MI
                    {
                        Id = 1025710404,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("188.72.220.140"),

System.Net.IPAddress.Parse("149.193.199.245"),

System.Net.IPAddress.Parse("219.59.217.173"),

System.Net.IPAddress.Parse("184.132.20.223"),

},
                        NullableValue = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("19.12.106.182"),

System.Net.IPAddress.Parse("68.197.243.110"),

System.Net.IPAddress.Parse("241.168.234.162"),

}
                    }
                );

                expected.Add(
                    1147700318,
                    new IPAddressinetArray1MI
                    {
                        Id = 1147700318,
                        Value = 
new System.Net.IPAddress[3]
{
System.Net.IPAddress.Parse("23.44.179.107"),

System.Net.IPAddress.Parse("196.169.22.130"),

System.Net.IPAddress.Parse("60.74.92.160"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1189751706,
                    new IPAddressinetArray1MI
                    {
                        Id = 1189751706,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("91.60.140.37"),

System.Net.IPAddress.Parse("150.130.185.226"),

System.Net.IPAddress.Parse("230.21.248.241"),

System.Net.IPAddress.Parse("139.55.222.245"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("110.70.123.82"),

System.Net.IPAddress.Parse("32.62.116.191"),

System.Net.IPAddress.Parse("74.32.19.198"),

System.Net.IPAddress.Parse("82.243.186.251"),

}
                    }
                );

                expected.Add(
                    1225266561,
                    new IPAddressinetArray1MI
                    {
                        Id = 1225266561,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("161.64.174.220"),

System.Net.IPAddress.Parse("10.108.45.165"),

System.Net.IPAddress.Parse("236.217.123.2"),

System.Net.IPAddress.Parse("119.54.240.25"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1524374413,
                    new IPAddressinetArray1MI
                    {
                        Id = 1524374413,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("17.243.164.43"),

System.Net.IPAddress.Parse("249.75.193.185"),

System.Net.IPAddress.Parse("250.156.153.118"),

System.Net.IPAddress.Parse("162.55.7.224"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1635158325,
                    new IPAddressinetArray1MI
                    {
                        Id = 1635158325,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("185.184.164.177"),

System.Net.IPAddress.Parse("87.109.19.33"),

System.Net.IPAddress.Parse("6.0.249.18"),

System.Net.IPAddress.Parse("228.186.18.232"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("151.232.248.181"),

System.Net.IPAddress.Parse("254.96.62.95"),

System.Net.IPAddress.Parse("204.27.232.250"),

System.Net.IPAddress.Parse("98.74.63.60"),

}
                    }
                );

                expected.Add(
                    1862467653,
                    new IPAddressinetArray1MI
                    {
                        Id = 1862467653,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("7.88.48.172"),

System.Net.IPAddress.Parse("77.111.187.235"),

System.Net.IPAddress.Parse("140.225.127.72"),

System.Net.IPAddress.Parse("20.222.226.65"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2060396617,
                    new IPAddressinetArray1MI
                    {
                        Id = 2060396617,
                        Value = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("157.220.56.129"),

System.Net.IPAddress.Parse("248.21.142.228"),

System.Net.IPAddress.Parse("55.148.181.184"),

System.Net.IPAddress.Parse("222.209.222.92"),

},
                        NullableValue = 
new System.Net.IPAddress[4]
{
System.Net.IPAddress.Parse("84.225.137.209"),

System.Net.IPAddress.Parse("27.250.31.59"),

System.Net.IPAddress.Parse("84.59.229.42"),

System.Net.IPAddress.Parse("228.151.53.140"),

}
                    }
                );

                var models = await ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue != null)
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                }
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Null);
                }


                }
            }
        }

        #endregion

    }
}

