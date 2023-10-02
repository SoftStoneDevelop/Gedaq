

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
    internal partial interface IIPAddressListinetArray
    {
    }
    
    internal partial class IPAddressListinetArray : IIPAddressListinetArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray2mi(
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
            asPartInterface: typeof(IIPAddressListinetArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Net.IPAddress>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Net.IPAddress>), 
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
INSERT INTO public.ipaddressinetarray2mi(
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
            queryMapType: typeof(IPAddressinetArray2MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Net.IPAddress>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Net.IPAddress>), 
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

                changedRows =  ((IIPAddressListinetArray)this).InsertModelInner(connection, 493259895, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("81.113.197.138"),

System.Net.IPAddress.Parse("249.99.38.174"),

System.Net.IPAddress.Parse("165.188.246.116"),

}, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("21.66.153.109"),

System.Net.IPAddress.Parse("236.25.38.174"),

System.Net.IPAddress.Parse("58.17.218.250"),

System.Net.IPAddress.Parse("119.90.85.251"),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IIPAddressListinetArray)this).InsertModelInner(connection, 703320384, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.195.51.129"),

System.Net.IPAddress.Parse("156.38.122.41"),

System.Net.IPAddress.Parse("48.90.16.224"),

System.Net.IPAddress.Parse("31.169.67.31"),

}, null);
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

                changedRows = await ((IIPAddressListinetArray)this).InsertModelInnerAsync(connection, 797012636, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("62.173.14.133"),

System.Net.IPAddress.Parse("67.86.171.23"),

System.Net.IPAddress.Parse("160.65.160.234"),

}, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("181.105.46.223"),

System.Net.IPAddress.Parse("111.116.29.174"),

System.Net.IPAddress.Parse("28.117.6.147"),

System.Net.IPAddress.Parse("130.86.91.56"),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressListinetArray)this).InsertModelInnerAsync(connection, 218881980, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("208.89.35.2"),

System.Net.IPAddress.Parse("2.14.156.67"),

System.Net.IPAddress.Parse("180.72.116.152"),

}, null);
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

                id =  ((IIPAddressListinetArray)this).InsertModelInnerReturning(connection, 775413525, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("130.177.116.86"),

System.Net.IPAddress.Parse("138.151.82.18"),

System.Net.IPAddress.Parse("141.75.165.3"),

}, null);
                Assert.That(id, Is.EqualTo(775413525));

                id =  ((IIPAddressListinetArray)this).InsertModelInnerReturning(connection, 1052968544, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("12.206.107.84"),

System.Net.IPAddress.Parse("253.166.191.242"),

System.Net.IPAddress.Parse("20.12.62.55"),

System.Net.IPAddress.Parse("222.206.221.195"),

}, null);
                Assert.That(id, Is.EqualTo(1052968544));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IIPAddressListinetArray)this).InsertModelInnerReturningAsync(connection, 2079482896, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("118.145.130.134"),

System.Net.IPAddress.Parse("168.145.47.246"),

System.Net.IPAddress.Parse("133.178.124.149"),

System.Net.IPAddress.Parse("205.208.209.69"),

}, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("206.4.8.189"),

System.Net.IPAddress.Parse("178.105.254.175"),

System.Net.IPAddress.Parse("32.108.100.214"),

});
                Assert.That(id, Is.EqualTo(2079482896));

                id = await ((IIPAddressListinetArray)this).InsertModelInnerReturningAsync(connection, 1578563188, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("120.2.76.27"),

System.Net.IPAddress.Parse("83.75.169.142"),

System.Net.IPAddress.Parse("104.84.35.5"),

System.Net.IPAddress.Parse("196.18.179.70"),

}, null);
                Assert.That(id, Is.EqualTo(1578563188));

                id = await ((IIPAddressListinetArray)this).InsertModelInnerReturningAsync(connection, 679149257, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("202.219.60.179"),

System.Net.IPAddress.Parse("187.5.225.114"),

System.Net.IPAddress.Parse("55.30.143.74"),

System.Net.IPAddress.Parse("196.204.74.213"),

}, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("9.159.202.96"),

System.Net.IPAddress.Parse("146.25.129.165"),

System.Net.IPAddress.Parse("176.4.79.145"),

System.Net.IPAddress.Parse("50.140.252.16"),

});
                Assert.That(id, Is.EqualTo(679149257));

                id = await ((IIPAddressListinetArray)this).InsertModelInnerReturningAsync(connection, 436734963, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.204.18.197"),

System.Net.IPAddress.Parse("251.64.78.104"),

System.Net.IPAddress.Parse("239.106.229.118"),

System.Net.IPAddress.Parse("102.155.103.38"),

}, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("160.35.180.101"),

System.Net.IPAddress.Parse("221.52.23.175"),

System.Net.IPAddress.Parse("217.105.180.102"),

});
                Assert.That(id, Is.EqualTo(436734963));

                id = await ((IIPAddressListinetArray)this).InsertModelInnerReturningAsync(connection, 1237378685, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.181.180.192"),

System.Net.IPAddress.Parse("232.201.183.160"),

System.Net.IPAddress.Parse("128.78.180.105"),

System.Net.IPAddress.Parse("83.124.226.123"),

}, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("52.132.213.140"),

System.Net.IPAddress.Parse("97.62.253.66"),

System.Net.IPAddress.Parse("0.168.126.136"),

System.Net.IPAddress.Parse("191.235.71.132"),

});
                Assert.That(id, Is.EqualTo(1237378685));

                id = await ((IIPAddressListinetArray)this).InsertModelInnerReturningAsync(connection, 61017462, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("100.147.193.73"),

System.Net.IPAddress.Parse("233.233.33.9"),

System.Net.IPAddress.Parse("105.130.7.101"),

System.Net.IPAddress.Parse("44.177.139.252"),

}, null);
                Assert.That(id, Is.EqualTo(61017462));

                id = await ((IIPAddressListinetArray)this).InsertModelInnerReturningAsync(connection, 1489277569, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("165.86.216.81"),

System.Net.IPAddress.Parse("245.137.206.18"),

System.Net.IPAddress.Parse("1.79.152.27"),

System.Net.IPAddress.Parse("96.224.29.188"),

}, null);
                Assert.That(id, Is.EqualTo(1489277569));

                id = await ((IIPAddressListinetArray)this).InsertModelInnerReturningAsync(connection, 1683706738, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.82.80.245"),

System.Net.IPAddress.Parse("232.116.79.125"),

System.Net.IPAddress.Parse("174.46.62.103"),

System.Net.IPAddress.Parse("60.126.156.24"),

}, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("13.109.69.5"),

System.Net.IPAddress.Parse("231.51.35.179"),

System.Net.IPAddress.Parse("108.70.229.199"),

});
                Assert.That(id, Is.EqualTo(1683706738));

                id = await ((IIPAddressListinetArray)this).InsertModelInnerReturningAsync(connection, 592622261, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("252.208.123.189"),

System.Net.IPAddress.Parse("208.222.169.239"),

System.Net.IPAddress.Parse("197.116.246.21"),

}, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.242.139.170"),

System.Net.IPAddress.Parse("98.182.29.207"),

System.Net.IPAddress.Parse("128.85.70.118"),

System.Net.IPAddress.Parse("23.10.30.70"),

});
                Assert.That(id, Is.EqualTo(592622261));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray2m(
	id,
    value,
    nullablevalue,
    ipaddressinetarray2mi_id
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
            asPartInterface: typeof(IIPAddressListinetArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Net.IPAddress>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Net.IPAddress>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "ipaddressinetarray2mi_id", 
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

                changedRows =  ((IIPAddressListinetArray)this).InsertModel(connection, 1418534519, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("19.77.126.164"),

System.Net.IPAddress.Parse("165.103.55.104"),

System.Net.IPAddress.Parse("38.19.49.31"),

System.Net.IPAddress.Parse("83.6.206.81"),

}, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("144.244.130.29"),

System.Net.IPAddress.Parse("137.242.134.148"),

System.Net.IPAddress.Parse("231.169.48.185"),

System.Net.IPAddress.Parse("75.59.63.3"),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IIPAddressListinetArray)this).InsertModel(connection, 858895777, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("159.237.35.54"),

System.Net.IPAddress.Parse("82.35.158.59"),

System.Net.IPAddress.Parse("151.16.199.130"),

System.Net.IPAddress.Parse("120.83.190.6"),

}, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("54.39.69.88"),

System.Net.IPAddress.Parse("111.223.164.184"),

System.Net.IPAddress.Parse("169.171.53.112"),

System.Net.IPAddress.Parse("67.158.242.122"),

}, 493259895);
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

                changedRows = await ((IIPAddressListinetArray)this).InsertModelAsync(connection, 257730448, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("119.15.65.137"),

System.Net.IPAddress.Parse("245.182.223.243"),

System.Net.IPAddress.Parse("244.136.201.23"),

}, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("83.62.100.46"),

System.Net.IPAddress.Parse("120.87.237.84"),

System.Net.IPAddress.Parse("223.162.60.65"),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressListinetArray)this).InsertModelAsync(connection, 1922739568, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("228.30.69.115"),

System.Net.IPAddress.Parse("47.141.103.161"),

System.Net.IPAddress.Parse("70.102.228.6"),

System.Net.IPAddress.Parse("254.191.71.128"),

}, null, 703320384);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinetarray2m(
	id,
    value,
    nullablevalue,
    ipaddressinetarray2mi_id
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
    ipaddressinetarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(IPAddressinetArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Net.IPAddress>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Net.IPAddress>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483624)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "ipaddressinetarray2mi_id", 
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
                List<IPAddressinetArray2M> models = null;
                IPAddressinetArray2M model = null;

                models =  ((IIPAddressListinetArray)this).InsertModelReturning(connection, 1438534957, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("15.72.84.63"),

System.Net.IPAddress.Parse("42.139.165.220"),

System.Net.IPAddress.Parse("67.151.201.38"),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1438534957));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("15.72.84.63"),

System.Net.IPAddress.Parse("42.139.165.220"),

System.Net.IPAddress.Parse("67.151.201.38"),

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

                models =  ((IIPAddressListinetArray)this).InsertModelReturning(connection, 1560260232, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.113.47.65"),

System.Net.IPAddress.Parse("205.48.45.20"),

System.Net.IPAddress.Parse("35.138.105.162"),

System.Net.IPAddress.Parse("222.77.163.247"),

}, null, 797012636).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1560260232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.113.47.65"),

System.Net.IPAddress.Parse("205.48.45.20"),

System.Net.IPAddress.Parse("35.138.105.162"),

System.Net.IPAddress.Parse("222.77.163.247"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(797012636));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Net.IPAddress>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IIPAddressListinetArray)this).InsertModelReturning(connection, 1756340245, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("150.75.94.98"),

System.Net.IPAddress.Parse("154.220.34.33"),

System.Net.IPAddress.Parse("142.176.194.74"),

System.Net.IPAddress.Parse("202.218.81.26"),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1756340245));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("150.75.94.98"),

System.Net.IPAddress.Parse("154.220.34.33"),

System.Net.IPAddress.Parse("142.176.194.74"),

System.Net.IPAddress.Parse("202.218.81.26"),

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

                models =  ((IIPAddressListinetArray)this).InsertModelReturning(connection, 1421378455, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("77.64.81.188"),

System.Net.IPAddress.Parse("44.144.63.85"),

System.Net.IPAddress.Parse("208.163.44.211"),

System.Net.IPAddress.Parse("101.86.45.208"),

}, null, 218881980).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1421378455));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("77.64.81.188"),

System.Net.IPAddress.Parse("44.144.63.85"),

System.Net.IPAddress.Parse("208.163.44.211"),

System.Net.IPAddress.Parse("101.86.45.208"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(218881980));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Net.IPAddress>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetArray2M> models = null;
                IPAddressinetArray2M model = null;

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, 423054754, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("164.157.197.43"),

System.Net.IPAddress.Parse("130.23.54.205"),

System.Net.IPAddress.Parse("37.54.239.101"),

System.Net.IPAddress.Parse("73.12.19.35"),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(423054754));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("164.157.197.43"),

System.Net.IPAddress.Parse("130.23.54.205"),

System.Net.IPAddress.Parse("37.54.239.101"),

System.Net.IPAddress.Parse("73.12.19.35"),

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

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, 847185137, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("98.15.82.204"),

System.Net.IPAddress.Parse("252.118.194.18"),

System.Net.IPAddress.Parse("140.28.233.210"),

}, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("200.247.194.13"),

System.Net.IPAddress.Parse("47.236.77.59"),

System.Net.IPAddress.Parse("101.230.108.169"),

System.Net.IPAddress.Parse("253.76.177.154"),

}, 775413525).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(847185137));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("98.15.82.204"),

System.Net.IPAddress.Parse("252.118.194.18"),

System.Net.IPAddress.Parse("140.28.233.210"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("200.247.194.13"),

System.Net.IPAddress.Parse("47.236.77.59"),

System.Net.IPAddress.Parse("101.230.108.169"),

System.Net.IPAddress.Parse("253.76.177.154"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(775413525));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Net.IPAddress>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, 240216224, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("229.179.159.9"),

System.Net.IPAddress.Parse("127.52.178.185"),

System.Net.IPAddress.Parse("91.100.65.63"),

System.Net.IPAddress.Parse("50.192.76.61"),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(240216224));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("229.179.159.9"),

System.Net.IPAddress.Parse("127.52.178.185"),

System.Net.IPAddress.Parse("91.100.65.63"),

System.Net.IPAddress.Parse("50.192.76.61"),

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

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, 2040415786, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("215.22.201.81"),

System.Net.IPAddress.Parse("131.67.161.140"),

System.Net.IPAddress.Parse("49.58.33.156"),

System.Net.IPAddress.Parse("62.233.132.186"),

}, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("88.82.118.139"),

System.Net.IPAddress.Parse("123.16.198.74"),

System.Net.IPAddress.Parse("78.60.212.89"),

}, 1052968544).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2040415786));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("215.22.201.81"),

System.Net.IPAddress.Parse("131.67.161.140"),

System.Net.IPAddress.Parse("49.58.33.156"),

System.Net.IPAddress.Parse("62.233.132.186"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("88.82.118.139"),

System.Net.IPAddress.Parse("123.16.198.74"),

System.Net.IPAddress.Parse("78.60.212.89"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052968544));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Net.IPAddress>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, 1601022817, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("99.66.243.223"),

System.Net.IPAddress.Parse("203.91.144.163"),

System.Net.IPAddress.Parse("91.36.60.111"),

System.Net.IPAddress.Parse("217.167.44.30"),

}, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.179.183.203"),

System.Net.IPAddress.Parse("28.62.216.212"),

System.Net.IPAddress.Parse("236.24.81.156"),

System.Net.IPAddress.Parse("203.241.215.77"),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1601022817));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("99.66.243.223"),

System.Net.IPAddress.Parse("203.91.144.163"),

System.Net.IPAddress.Parse("91.36.60.111"),

System.Net.IPAddress.Parse("217.167.44.30"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.179.183.203"),

System.Net.IPAddress.Parse("28.62.216.212"),

System.Net.IPAddress.Parse("236.24.81.156"),

System.Net.IPAddress.Parse("203.241.215.77"),

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

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, 1619643577, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("234.177.215.48"),

System.Net.IPAddress.Parse("37.193.37.208"),

System.Net.IPAddress.Parse("103.210.118.208"),

}, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("128.38.221.117"),

System.Net.IPAddress.Parse("170.184.57.90"),

System.Net.IPAddress.Parse("222.78.57.150"),

}, 2079482896).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1619643577));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("234.177.215.48"),

System.Net.IPAddress.Parse("37.193.37.208"),

System.Net.IPAddress.Parse("103.210.118.208"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("128.38.221.117"),

System.Net.IPAddress.Parse("170.184.57.90"),

System.Net.IPAddress.Parse("222.78.57.150"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2079482896));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Net.IPAddress>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, 2007192625, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("240.218.19.236"),

System.Net.IPAddress.Parse("230.32.225.58"),

System.Net.IPAddress.Parse("178.243.245.37"),

System.Net.IPAddress.Parse("214.115.0.243"),

}, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("230.17.30.20"),

System.Net.IPAddress.Parse("247.253.47.127"),

System.Net.IPAddress.Parse("141.148.99.217"),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2007192625));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("240.218.19.236"),

System.Net.IPAddress.Parse("230.32.225.58"),

System.Net.IPAddress.Parse("178.243.245.37"),

System.Net.IPAddress.Parse("214.115.0.243"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("230.17.30.20"),

System.Net.IPAddress.Parse("247.253.47.127"),

System.Net.IPAddress.Parse("141.148.99.217"),

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

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, 1250031908, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("29.197.212.239"),

System.Net.IPAddress.Parse("69.253.159.51"),

System.Net.IPAddress.Parse("133.98.78.11"),

}, null, 1578563188).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1250031908));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("29.197.212.239"),

System.Net.IPAddress.Parse("69.253.159.51"),

System.Net.IPAddress.Parse("133.98.78.11"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1578563188));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Net.IPAddress>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, 851516451, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("114.58.46.141"),

System.Net.IPAddress.Parse("41.29.187.157"),

System.Net.IPAddress.Parse("18.58.207.208"),

System.Net.IPAddress.Parse("158.158.51.6"),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(851516451));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("114.58.46.141"),

System.Net.IPAddress.Parse("41.29.187.157"),

System.Net.IPAddress.Parse("18.58.207.208"),

System.Net.IPAddress.Parse("158.158.51.6"),

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

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, 559278709, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("3.86.229.33"),

System.Net.IPAddress.Parse("130.197.93.26"),

System.Net.IPAddress.Parse("72.250.135.43"),

System.Net.IPAddress.Parse("163.155.132.169"),

}, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("140.194.187.99"),

System.Net.IPAddress.Parse("118.102.89.142"),

System.Net.IPAddress.Parse("13.60.73.41"),

}, 679149257).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(559278709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("3.86.229.33"),

System.Net.IPAddress.Parse("130.197.93.26"),

System.Net.IPAddress.Parse("72.250.135.43"),

System.Net.IPAddress.Parse("163.155.132.169"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("140.194.187.99"),

System.Net.IPAddress.Parse("118.102.89.142"),

System.Net.IPAddress.Parse("13.60.73.41"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(679149257));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Net.IPAddress>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, 319861696, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("161.57.84.109"),

System.Net.IPAddress.Parse("56.101.160.188"),

System.Net.IPAddress.Parse("48.177.91.150"),

System.Net.IPAddress.Parse("191.127.158.251"),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(319861696));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("161.57.84.109"),

System.Net.IPAddress.Parse("56.101.160.188"),

System.Net.IPAddress.Parse("48.177.91.150"),

System.Net.IPAddress.Parse("191.127.158.251"),

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

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, 2104615667, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("114.214.121.99"),

System.Net.IPAddress.Parse("189.139.10.2"),

System.Net.IPAddress.Parse("67.190.160.184"),

}, null, 436734963).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2104615667));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("114.214.121.99"),

System.Net.IPAddress.Parse("189.139.10.2"),

System.Net.IPAddress.Parse("67.190.160.184"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(436734963));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Net.IPAddress>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, 472717847, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("241.59.34.38"),

System.Net.IPAddress.Parse("130.204.76.173"),

System.Net.IPAddress.Parse("79.248.179.157"),

System.Net.IPAddress.Parse("188.41.127.62"),

}, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("156.13.97.202"),

System.Net.IPAddress.Parse("159.132.115.209"),

System.Net.IPAddress.Parse("175.21.56.20"),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(472717847));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("241.59.34.38"),

System.Net.IPAddress.Parse("130.204.76.173"),

System.Net.IPAddress.Parse("79.248.179.157"),

System.Net.IPAddress.Parse("188.41.127.62"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("156.13.97.202"),

System.Net.IPAddress.Parse("159.132.115.209"),

System.Net.IPAddress.Parse("175.21.56.20"),

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

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, 1525861477, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("120.57.111.227"),

System.Net.IPAddress.Parse("67.16.249.162"),

System.Net.IPAddress.Parse("220.169.60.178"),

}, null, 1237378685).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1525861477));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("120.57.111.227"),

System.Net.IPAddress.Parse("67.16.249.162"),

System.Net.IPAddress.Parse("220.169.60.178"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237378685));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Net.IPAddress>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, 1204012623, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("36.58.5.135"),

System.Net.IPAddress.Parse("204.131.149.141"),

System.Net.IPAddress.Parse("34.164.207.185"),

}, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("226.180.138.138"),

System.Net.IPAddress.Parse("115.183.220.221"),

System.Net.IPAddress.Parse("112.123.153.54"),

System.Net.IPAddress.Parse("174.176.254.16"),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1204012623));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("36.58.5.135"),

System.Net.IPAddress.Parse("204.131.149.141"),

System.Net.IPAddress.Parse("34.164.207.185"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("226.180.138.138"),

System.Net.IPAddress.Parse("115.183.220.221"),

System.Net.IPAddress.Parse("112.123.153.54"),

System.Net.IPAddress.Parse("174.176.254.16"),

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

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, 1638988125, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("238.176.190.225"),

System.Net.IPAddress.Parse("176.217.220.171"),

System.Net.IPAddress.Parse("250.234.153.105"),

System.Net.IPAddress.Parse("120.141.97.84"),

}, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("27.167.12.59"),

System.Net.IPAddress.Parse("228.0.114.173"),

System.Net.IPAddress.Parse("84.92.209.93"),

System.Net.IPAddress.Parse("222.73.49.253"),

}, 61017462).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1638988125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("238.176.190.225"),

System.Net.IPAddress.Parse("176.217.220.171"),

System.Net.IPAddress.Parse("250.234.153.105"),

System.Net.IPAddress.Parse("120.141.97.84"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("27.167.12.59"),

System.Net.IPAddress.Parse("228.0.114.173"),

System.Net.IPAddress.Parse("84.92.209.93"),

System.Net.IPAddress.Parse("222.73.49.253"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(61017462));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Net.IPAddress>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, 176088676, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("231.154.164.129"),

System.Net.IPAddress.Parse("120.253.84.87"),

System.Net.IPAddress.Parse("212.65.4.68"),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(176088676));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("231.154.164.129"),

System.Net.IPAddress.Parse("120.253.84.87"),

System.Net.IPAddress.Parse("212.65.4.68"),

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

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, 981696302, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("41.213.89.173"),

System.Net.IPAddress.Parse("205.13.25.8"),

System.Net.IPAddress.Parse("2.201.212.105"),

System.Net.IPAddress.Parse("11.197.168.221"),

}, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("65.97.244.44"),

System.Net.IPAddress.Parse("140.204.33.168"),

System.Net.IPAddress.Parse("231.126.13.176"),

}, 1489277569).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981696302));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("41.213.89.173"),

System.Net.IPAddress.Parse("205.13.25.8"),

System.Net.IPAddress.Parse("2.201.212.105"),

System.Net.IPAddress.Parse("11.197.168.221"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("65.97.244.44"),

System.Net.IPAddress.Parse("140.204.33.168"),

System.Net.IPAddress.Parse("231.126.13.176"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1489277569));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Net.IPAddress>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, 1419166380, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("191.209.175.78"),

System.Net.IPAddress.Parse("180.73.250.86"),

System.Net.IPAddress.Parse("159.236.95.242"),

System.Net.IPAddress.Parse("228.237.150.193"),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1419166380));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("191.209.175.78"),

System.Net.IPAddress.Parse("180.73.250.86"),

System.Net.IPAddress.Parse("159.236.95.242"),

System.Net.IPAddress.Parse("228.237.150.193"),

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

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, 1626757037, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.88.198.127"),

System.Net.IPAddress.Parse("74.81.157.228"),

System.Net.IPAddress.Parse("236.35.8.93"),

}, null, 1683706738).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1626757037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.88.198.127"),

System.Net.IPAddress.Parse("74.81.157.228"),

System.Net.IPAddress.Parse("236.35.8.93"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1683706738));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Net.IPAddress>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, 53114524, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("159.183.238.80"),

System.Net.IPAddress.Parse("47.218.200.218"),

System.Net.IPAddress.Parse("195.155.174.179"),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53114524));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("159.183.238.80"),

System.Net.IPAddress.Parse("47.218.200.218"),

System.Net.IPAddress.Parse("195.155.174.179"),

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

                models = await ((IIPAddressListinetArray)this).InsertModelReturningAsync(connection, 902976247, 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.110.99.153"),

System.Net.IPAddress.Parse("106.34.132.127"),

System.Net.IPAddress.Parse("14.244.237.116"),

}, 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("130.224.116.24"),

System.Net.IPAddress.Parse("22.224.44.21"),

System.Net.IPAddress.Parse("191.106.38.6"),

System.Net.IPAddress.Parse("38.34.145.29"),

}, 592622261).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(902976247));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.110.99.153"),

System.Net.IPAddress.Parse("106.34.132.127"),

System.Net.IPAddress.Parse("14.244.237.116"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("130.224.116.24"),

System.Net.IPAddress.Parse("22.224.44.21"),

System.Net.IPAddress.Parse("191.106.38.6"),

System.Net.IPAddress.Parse("38.34.145.29"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(592622261));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Net.IPAddress>)default));
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
FROM public.ipaddressinetarray2m m
LEFT JOIN public.ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(IPAddressinetArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)
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
                var models =  ((IIPAddressListinetArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53114524));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("159.183.238.80"),

System.Net.IPAddress.Parse("47.218.200.218"),

System.Net.IPAddress.Parse("195.155.174.179"),

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

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(176088676));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("231.154.164.129"),

System.Net.IPAddress.Parse("120.253.84.87"),

System.Net.IPAddress.Parse("212.65.4.68"),

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
                Assert.That(model.Id, Is.EqualTo(240216224));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("229.179.159.9"),

System.Net.IPAddress.Parse("127.52.178.185"),

System.Net.IPAddress.Parse("91.100.65.63"),

System.Net.IPAddress.Parse("50.192.76.61"),

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

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(257730448));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("119.15.65.137"),

System.Net.IPAddress.Parse("245.182.223.243"),

System.Net.IPAddress.Parse("244.136.201.23"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("83.62.100.46"),

System.Net.IPAddress.Parse("120.87.237.84"),

System.Net.IPAddress.Parse("223.162.60.65"),

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
                Assert.That(model.Id, Is.EqualTo(319861696));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("161.57.84.109"),

System.Net.IPAddress.Parse("56.101.160.188"),

System.Net.IPAddress.Parse("48.177.91.150"),

System.Net.IPAddress.Parse("191.127.158.251"),

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
                Assert.That(model.Id, Is.EqualTo(423054754));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("164.157.197.43"),

System.Net.IPAddress.Parse("130.23.54.205"),

System.Net.IPAddress.Parse("37.54.239.101"),

System.Net.IPAddress.Parse("73.12.19.35"),

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
                Assert.That(model.Id, Is.EqualTo(472717847));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("241.59.34.38"),

System.Net.IPAddress.Parse("130.204.76.173"),

System.Net.IPAddress.Parse("79.248.179.157"),

System.Net.IPAddress.Parse("188.41.127.62"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("156.13.97.202"),

System.Net.IPAddress.Parse("159.132.115.209"),

System.Net.IPAddress.Parse("175.21.56.20"),

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

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(559278709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("3.86.229.33"),

System.Net.IPAddress.Parse("130.197.93.26"),

System.Net.IPAddress.Parse("72.250.135.43"),

System.Net.IPAddress.Parse("163.155.132.169"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("140.194.187.99"),

System.Net.IPAddress.Parse("118.102.89.142"),

System.Net.IPAddress.Parse("13.60.73.41"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(679149257));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("202.219.60.179"),

System.Net.IPAddress.Parse("187.5.225.114"),

System.Net.IPAddress.Parse("55.30.143.74"),

System.Net.IPAddress.Parse("196.204.74.213"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("9.159.202.96"),

System.Net.IPAddress.Parse("146.25.129.165"),

System.Net.IPAddress.Parse("176.4.79.145"),

System.Net.IPAddress.Parse("50.140.252.16"),

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
                Assert.That(model.Id, Is.EqualTo(847185137));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("98.15.82.204"),

System.Net.IPAddress.Parse("252.118.194.18"),

System.Net.IPAddress.Parse("140.28.233.210"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("200.247.194.13"),

System.Net.IPAddress.Parse("47.236.77.59"),

System.Net.IPAddress.Parse("101.230.108.169"),

System.Net.IPAddress.Parse("253.76.177.154"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(775413525));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("130.177.116.86"),

System.Net.IPAddress.Parse("138.151.82.18"),

System.Net.IPAddress.Parse("141.75.165.3"),

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
                Assert.That(model.Id, Is.EqualTo(851516451));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("114.58.46.141"),

System.Net.IPAddress.Parse("41.29.187.157"),

System.Net.IPAddress.Parse("18.58.207.208"),

System.Net.IPAddress.Parse("158.158.51.6"),

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

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(858895777));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("159.237.35.54"),

System.Net.IPAddress.Parse("82.35.158.59"),

System.Net.IPAddress.Parse("151.16.199.130"),

System.Net.IPAddress.Parse("120.83.190.6"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("54.39.69.88"),

System.Net.IPAddress.Parse("111.223.164.184"),

System.Net.IPAddress.Parse("169.171.53.112"),

System.Net.IPAddress.Parse("67.158.242.122"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(493259895));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("81.113.197.138"),

System.Net.IPAddress.Parse("249.99.38.174"),

System.Net.IPAddress.Parse("165.188.246.116"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("21.66.153.109"),

System.Net.IPAddress.Parse("236.25.38.174"),

System.Net.IPAddress.Parse("58.17.218.250"),

System.Net.IPAddress.Parse("119.90.85.251"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(902976247));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.110.99.153"),

System.Net.IPAddress.Parse("106.34.132.127"),

System.Net.IPAddress.Parse("14.244.237.116"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("130.224.116.24"),

System.Net.IPAddress.Parse("22.224.44.21"),

System.Net.IPAddress.Parse("191.106.38.6"),

System.Net.IPAddress.Parse("38.34.145.29"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(592622261));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("252.208.123.189"),

System.Net.IPAddress.Parse("208.222.169.239"),

System.Net.IPAddress.Parse("197.116.246.21"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.242.139.170"),

System.Net.IPAddress.Parse("98.182.29.207"),

System.Net.IPAddress.Parse("128.85.70.118"),

System.Net.IPAddress.Parse("23.10.30.70"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981696302));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("41.213.89.173"),

System.Net.IPAddress.Parse("205.13.25.8"),

System.Net.IPAddress.Parse("2.201.212.105"),

System.Net.IPAddress.Parse("11.197.168.221"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("65.97.244.44"),

System.Net.IPAddress.Parse("140.204.33.168"),

System.Net.IPAddress.Parse("231.126.13.176"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1489277569));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("165.86.216.81"),

System.Net.IPAddress.Parse("245.137.206.18"),

System.Net.IPAddress.Parse("1.79.152.27"),

System.Net.IPAddress.Parse("96.224.29.188"),

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
                Assert.That(model.Id, Is.EqualTo(1204012623));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("36.58.5.135"),

System.Net.IPAddress.Parse("204.131.149.141"),

System.Net.IPAddress.Parse("34.164.207.185"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("226.180.138.138"),

System.Net.IPAddress.Parse("115.183.220.221"),

System.Net.IPAddress.Parse("112.123.153.54"),

System.Net.IPAddress.Parse("174.176.254.16"),

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
                Assert.That(model.Id, Is.EqualTo(1250031908));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("29.197.212.239"),

System.Net.IPAddress.Parse("69.253.159.51"),

System.Net.IPAddress.Parse("133.98.78.11"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1578563188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("120.2.76.27"),

System.Net.IPAddress.Parse("83.75.169.142"),

System.Net.IPAddress.Parse("104.84.35.5"),

System.Net.IPAddress.Parse("196.18.179.70"),

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

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1418534519));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("19.77.126.164"),

System.Net.IPAddress.Parse("165.103.55.104"),

System.Net.IPAddress.Parse("38.19.49.31"),

System.Net.IPAddress.Parse("83.6.206.81"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("144.244.130.29"),

System.Net.IPAddress.Parse("137.242.134.148"),

System.Net.IPAddress.Parse("231.169.48.185"),

System.Net.IPAddress.Parse("75.59.63.3"),

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
                Assert.That(model.Id, Is.EqualTo(1419166380));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("191.209.175.78"),

System.Net.IPAddress.Parse("180.73.250.86"),

System.Net.IPAddress.Parse("159.236.95.242"),

System.Net.IPAddress.Parse("228.237.150.193"),

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
                Assert.That(model.Id, Is.EqualTo(1421378455));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("77.64.81.188"),

System.Net.IPAddress.Parse("44.144.63.85"),

System.Net.IPAddress.Parse("208.163.44.211"),

System.Net.IPAddress.Parse("101.86.45.208"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(218881980));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("208.89.35.2"),

System.Net.IPAddress.Parse("2.14.156.67"),

System.Net.IPAddress.Parse("180.72.116.152"),

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

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1438534957));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("15.72.84.63"),

System.Net.IPAddress.Parse("42.139.165.220"),

System.Net.IPAddress.Parse("67.151.201.38"),

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
                Assert.That(model.Id, Is.EqualTo(1525861477));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("120.57.111.227"),

System.Net.IPAddress.Parse("67.16.249.162"),

System.Net.IPAddress.Parse("220.169.60.178"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237378685));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.181.180.192"),

System.Net.IPAddress.Parse("232.201.183.160"),

System.Net.IPAddress.Parse("128.78.180.105"),

System.Net.IPAddress.Parse("83.124.226.123"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("52.132.213.140"),

System.Net.IPAddress.Parse("97.62.253.66"),

System.Net.IPAddress.Parse("0.168.126.136"),

System.Net.IPAddress.Parse("191.235.71.132"),

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
                Assert.That(model.Id, Is.EqualTo(1560260232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.113.47.65"),

System.Net.IPAddress.Parse("205.48.45.20"),

System.Net.IPAddress.Parse("35.138.105.162"),

System.Net.IPAddress.Parse("222.77.163.247"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(797012636));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("62.173.14.133"),

System.Net.IPAddress.Parse("67.86.171.23"),

System.Net.IPAddress.Parse("160.65.160.234"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("181.105.46.223"),

System.Net.IPAddress.Parse("111.116.29.174"),

System.Net.IPAddress.Parse("28.117.6.147"),

System.Net.IPAddress.Parse("130.86.91.56"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1601022817));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("99.66.243.223"),

System.Net.IPAddress.Parse("203.91.144.163"),

System.Net.IPAddress.Parse("91.36.60.111"),

System.Net.IPAddress.Parse("217.167.44.30"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.179.183.203"),

System.Net.IPAddress.Parse("28.62.216.212"),

System.Net.IPAddress.Parse("236.24.81.156"),

System.Net.IPAddress.Parse("203.241.215.77"),

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
                Assert.That(model.Id, Is.EqualTo(1619643577));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("234.177.215.48"),

System.Net.IPAddress.Parse("37.193.37.208"),

System.Net.IPAddress.Parse("103.210.118.208"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("128.38.221.117"),

System.Net.IPAddress.Parse("170.184.57.90"),

System.Net.IPAddress.Parse("222.78.57.150"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2079482896));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("118.145.130.134"),

System.Net.IPAddress.Parse("168.145.47.246"),

System.Net.IPAddress.Parse("133.178.124.149"),

System.Net.IPAddress.Parse("205.208.209.69"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("206.4.8.189"),

System.Net.IPAddress.Parse("178.105.254.175"),

System.Net.IPAddress.Parse("32.108.100.214"),

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
                Assert.That(model.Id, Is.EqualTo(1626757037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.88.198.127"),

System.Net.IPAddress.Parse("74.81.157.228"),

System.Net.IPAddress.Parse("236.35.8.93"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1683706738));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.82.80.245"),

System.Net.IPAddress.Parse("232.116.79.125"),

System.Net.IPAddress.Parse("174.46.62.103"),

System.Net.IPAddress.Parse("60.126.156.24"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("13.109.69.5"),

System.Net.IPAddress.Parse("231.51.35.179"),

System.Net.IPAddress.Parse("108.70.229.199"),

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
                Assert.That(model.Id, Is.EqualTo(1638988125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("238.176.190.225"),

System.Net.IPAddress.Parse("176.217.220.171"),

System.Net.IPAddress.Parse("250.234.153.105"),

System.Net.IPAddress.Parse("120.141.97.84"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("27.167.12.59"),

System.Net.IPAddress.Parse("228.0.114.173"),

System.Net.IPAddress.Parse("84.92.209.93"),

System.Net.IPAddress.Parse("222.73.49.253"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(61017462));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("100.147.193.73"),

System.Net.IPAddress.Parse("233.233.33.9"),

System.Net.IPAddress.Parse("105.130.7.101"),

System.Net.IPAddress.Parse("44.177.139.252"),

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
                Assert.That(model.Id, Is.EqualTo(1756340245));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("150.75.94.98"),

System.Net.IPAddress.Parse("154.220.34.33"),

System.Net.IPAddress.Parse("142.176.194.74"),

System.Net.IPAddress.Parse("202.218.81.26"),

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
                Assert.That(model.Id, Is.EqualTo(1922739568));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("228.30.69.115"),

System.Net.IPAddress.Parse("47.141.103.161"),

System.Net.IPAddress.Parse("70.102.228.6"),

System.Net.IPAddress.Parse("254.191.71.128"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(703320384));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.195.51.129"),

System.Net.IPAddress.Parse("156.38.122.41"),

System.Net.IPAddress.Parse("48.90.16.224"),

System.Net.IPAddress.Parse("31.169.67.31"),

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
                Assert.That(model.Id, Is.EqualTo(2007192625));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("240.218.19.236"),

System.Net.IPAddress.Parse("230.32.225.58"),

System.Net.IPAddress.Parse("178.243.245.37"),

System.Net.IPAddress.Parse("214.115.0.243"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("230.17.30.20"),

System.Net.IPAddress.Parse("247.253.47.127"),

System.Net.IPAddress.Parse("141.148.99.217"),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2040415786));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("215.22.201.81"),

System.Net.IPAddress.Parse("131.67.161.140"),

System.Net.IPAddress.Parse("49.58.33.156"),

System.Net.IPAddress.Parse("62.233.132.186"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("88.82.118.139"),

System.Net.IPAddress.Parse("123.16.198.74"),

System.Net.IPAddress.Parse("78.60.212.89"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052968544));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("12.206.107.84"),

System.Net.IPAddress.Parse("253.166.191.242"),

System.Net.IPAddress.Parse("20.12.62.55"),

System.Net.IPAddress.Parse("222.206.221.195"),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2104615667));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("114.214.121.99"),

System.Net.IPAddress.Parse("189.139.10.2"),

System.Net.IPAddress.Parse("67.190.160.184"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(436734963));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.204.18.197"),

System.Net.IPAddress.Parse("251.64.78.104"),

System.Net.IPAddress.Parse("239.106.229.118"),

System.Net.IPAddress.Parse("102.155.103.38"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("160.35.180.101"),

System.Net.IPAddress.Parse("221.52.23.175"),

System.Net.IPAddress.Parse("217.105.180.102"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressListinetArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53114524));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("159.183.238.80"),

System.Net.IPAddress.Parse("47.218.200.218"),

System.Net.IPAddress.Parse("195.155.174.179"),

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

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(176088676));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("231.154.164.129"),

System.Net.IPAddress.Parse("120.253.84.87"),

System.Net.IPAddress.Parse("212.65.4.68"),

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
                Assert.That(model.Id, Is.EqualTo(240216224));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("229.179.159.9"),

System.Net.IPAddress.Parse("127.52.178.185"),

System.Net.IPAddress.Parse("91.100.65.63"),

System.Net.IPAddress.Parse("50.192.76.61"),

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

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(257730448));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("119.15.65.137"),

System.Net.IPAddress.Parse("245.182.223.243"),

System.Net.IPAddress.Parse("244.136.201.23"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("83.62.100.46"),

System.Net.IPAddress.Parse("120.87.237.84"),

System.Net.IPAddress.Parse("223.162.60.65"),

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
                Assert.That(model.Id, Is.EqualTo(319861696));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("161.57.84.109"),

System.Net.IPAddress.Parse("56.101.160.188"),

System.Net.IPAddress.Parse("48.177.91.150"),

System.Net.IPAddress.Parse("191.127.158.251"),

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
                Assert.That(model.Id, Is.EqualTo(423054754));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("164.157.197.43"),

System.Net.IPAddress.Parse("130.23.54.205"),

System.Net.IPAddress.Parse("37.54.239.101"),

System.Net.IPAddress.Parse("73.12.19.35"),

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
                Assert.That(model.Id, Is.EqualTo(472717847));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("241.59.34.38"),

System.Net.IPAddress.Parse("130.204.76.173"),

System.Net.IPAddress.Parse("79.248.179.157"),

System.Net.IPAddress.Parse("188.41.127.62"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("156.13.97.202"),

System.Net.IPAddress.Parse("159.132.115.209"),

System.Net.IPAddress.Parse("175.21.56.20"),

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

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(559278709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("3.86.229.33"),

System.Net.IPAddress.Parse("130.197.93.26"),

System.Net.IPAddress.Parse("72.250.135.43"),

System.Net.IPAddress.Parse("163.155.132.169"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("140.194.187.99"),

System.Net.IPAddress.Parse("118.102.89.142"),

System.Net.IPAddress.Parse("13.60.73.41"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(679149257));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("202.219.60.179"),

System.Net.IPAddress.Parse("187.5.225.114"),

System.Net.IPAddress.Parse("55.30.143.74"),

System.Net.IPAddress.Parse("196.204.74.213"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("9.159.202.96"),

System.Net.IPAddress.Parse("146.25.129.165"),

System.Net.IPAddress.Parse("176.4.79.145"),

System.Net.IPAddress.Parse("50.140.252.16"),

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
                Assert.That(model.Id, Is.EqualTo(847185137));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("98.15.82.204"),

System.Net.IPAddress.Parse("252.118.194.18"),

System.Net.IPAddress.Parse("140.28.233.210"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("200.247.194.13"),

System.Net.IPAddress.Parse("47.236.77.59"),

System.Net.IPAddress.Parse("101.230.108.169"),

System.Net.IPAddress.Parse("253.76.177.154"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(775413525));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("130.177.116.86"),

System.Net.IPAddress.Parse("138.151.82.18"),

System.Net.IPAddress.Parse("141.75.165.3"),

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
                Assert.That(model.Id, Is.EqualTo(851516451));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("114.58.46.141"),

System.Net.IPAddress.Parse("41.29.187.157"),

System.Net.IPAddress.Parse("18.58.207.208"),

System.Net.IPAddress.Parse("158.158.51.6"),

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

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(858895777));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("159.237.35.54"),

System.Net.IPAddress.Parse("82.35.158.59"),

System.Net.IPAddress.Parse("151.16.199.130"),

System.Net.IPAddress.Parse("120.83.190.6"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("54.39.69.88"),

System.Net.IPAddress.Parse("111.223.164.184"),

System.Net.IPAddress.Parse("169.171.53.112"),

System.Net.IPAddress.Parse("67.158.242.122"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(493259895));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("81.113.197.138"),

System.Net.IPAddress.Parse("249.99.38.174"),

System.Net.IPAddress.Parse("165.188.246.116"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("21.66.153.109"),

System.Net.IPAddress.Parse("236.25.38.174"),

System.Net.IPAddress.Parse("58.17.218.250"),

System.Net.IPAddress.Parse("119.90.85.251"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(902976247));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.110.99.153"),

System.Net.IPAddress.Parse("106.34.132.127"),

System.Net.IPAddress.Parse("14.244.237.116"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("130.224.116.24"),

System.Net.IPAddress.Parse("22.224.44.21"),

System.Net.IPAddress.Parse("191.106.38.6"),

System.Net.IPAddress.Parse("38.34.145.29"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(592622261));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("252.208.123.189"),

System.Net.IPAddress.Parse("208.222.169.239"),

System.Net.IPAddress.Parse("197.116.246.21"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.242.139.170"),

System.Net.IPAddress.Parse("98.182.29.207"),

System.Net.IPAddress.Parse("128.85.70.118"),

System.Net.IPAddress.Parse("23.10.30.70"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981696302));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("41.213.89.173"),

System.Net.IPAddress.Parse("205.13.25.8"),

System.Net.IPAddress.Parse("2.201.212.105"),

System.Net.IPAddress.Parse("11.197.168.221"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("65.97.244.44"),

System.Net.IPAddress.Parse("140.204.33.168"),

System.Net.IPAddress.Parse("231.126.13.176"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1489277569));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("165.86.216.81"),

System.Net.IPAddress.Parse("245.137.206.18"),

System.Net.IPAddress.Parse("1.79.152.27"),

System.Net.IPAddress.Parse("96.224.29.188"),

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
                Assert.That(model.Id, Is.EqualTo(1204012623));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("36.58.5.135"),

System.Net.IPAddress.Parse("204.131.149.141"),

System.Net.IPAddress.Parse("34.164.207.185"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("226.180.138.138"),

System.Net.IPAddress.Parse("115.183.220.221"),

System.Net.IPAddress.Parse("112.123.153.54"),

System.Net.IPAddress.Parse("174.176.254.16"),

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
                Assert.That(model.Id, Is.EqualTo(1250031908));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("29.197.212.239"),

System.Net.IPAddress.Parse("69.253.159.51"),

System.Net.IPAddress.Parse("133.98.78.11"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1578563188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("120.2.76.27"),

System.Net.IPAddress.Parse("83.75.169.142"),

System.Net.IPAddress.Parse("104.84.35.5"),

System.Net.IPAddress.Parse("196.18.179.70"),

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

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1418534519));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("19.77.126.164"),

System.Net.IPAddress.Parse("165.103.55.104"),

System.Net.IPAddress.Parse("38.19.49.31"),

System.Net.IPAddress.Parse("83.6.206.81"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("144.244.130.29"),

System.Net.IPAddress.Parse("137.242.134.148"),

System.Net.IPAddress.Parse("231.169.48.185"),

System.Net.IPAddress.Parse("75.59.63.3"),

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
                Assert.That(model.Id, Is.EqualTo(1419166380));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("191.209.175.78"),

System.Net.IPAddress.Parse("180.73.250.86"),

System.Net.IPAddress.Parse("159.236.95.242"),

System.Net.IPAddress.Parse("228.237.150.193"),

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
                Assert.That(model.Id, Is.EqualTo(1421378455));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("77.64.81.188"),

System.Net.IPAddress.Parse("44.144.63.85"),

System.Net.IPAddress.Parse("208.163.44.211"),

System.Net.IPAddress.Parse("101.86.45.208"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(218881980));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("208.89.35.2"),

System.Net.IPAddress.Parse("2.14.156.67"),

System.Net.IPAddress.Parse("180.72.116.152"),

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

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1438534957));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("15.72.84.63"),

System.Net.IPAddress.Parse("42.139.165.220"),

System.Net.IPAddress.Parse("67.151.201.38"),

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
                Assert.That(model.Id, Is.EqualTo(1525861477));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("120.57.111.227"),

System.Net.IPAddress.Parse("67.16.249.162"),

System.Net.IPAddress.Parse("220.169.60.178"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237378685));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.181.180.192"),

System.Net.IPAddress.Parse("232.201.183.160"),

System.Net.IPAddress.Parse("128.78.180.105"),

System.Net.IPAddress.Parse("83.124.226.123"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("52.132.213.140"),

System.Net.IPAddress.Parse("97.62.253.66"),

System.Net.IPAddress.Parse("0.168.126.136"),

System.Net.IPAddress.Parse("191.235.71.132"),

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
                Assert.That(model.Id, Is.EqualTo(1560260232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.113.47.65"),

System.Net.IPAddress.Parse("205.48.45.20"),

System.Net.IPAddress.Parse("35.138.105.162"),

System.Net.IPAddress.Parse("222.77.163.247"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(797012636));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("62.173.14.133"),

System.Net.IPAddress.Parse("67.86.171.23"),

System.Net.IPAddress.Parse("160.65.160.234"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("181.105.46.223"),

System.Net.IPAddress.Parse("111.116.29.174"),

System.Net.IPAddress.Parse("28.117.6.147"),

System.Net.IPAddress.Parse("130.86.91.56"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1601022817));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("99.66.243.223"),

System.Net.IPAddress.Parse("203.91.144.163"),

System.Net.IPAddress.Parse("91.36.60.111"),

System.Net.IPAddress.Parse("217.167.44.30"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.179.183.203"),

System.Net.IPAddress.Parse("28.62.216.212"),

System.Net.IPAddress.Parse("236.24.81.156"),

System.Net.IPAddress.Parse("203.241.215.77"),

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
                Assert.That(model.Id, Is.EqualTo(1619643577));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("234.177.215.48"),

System.Net.IPAddress.Parse("37.193.37.208"),

System.Net.IPAddress.Parse("103.210.118.208"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("128.38.221.117"),

System.Net.IPAddress.Parse("170.184.57.90"),

System.Net.IPAddress.Parse("222.78.57.150"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2079482896));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("118.145.130.134"),

System.Net.IPAddress.Parse("168.145.47.246"),

System.Net.IPAddress.Parse("133.178.124.149"),

System.Net.IPAddress.Parse("205.208.209.69"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("206.4.8.189"),

System.Net.IPAddress.Parse("178.105.254.175"),

System.Net.IPAddress.Parse("32.108.100.214"),

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
                Assert.That(model.Id, Is.EqualTo(1626757037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.88.198.127"),

System.Net.IPAddress.Parse("74.81.157.228"),

System.Net.IPAddress.Parse("236.35.8.93"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1683706738));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.82.80.245"),

System.Net.IPAddress.Parse("232.116.79.125"),

System.Net.IPAddress.Parse("174.46.62.103"),

System.Net.IPAddress.Parse("60.126.156.24"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("13.109.69.5"),

System.Net.IPAddress.Parse("231.51.35.179"),

System.Net.IPAddress.Parse("108.70.229.199"),

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
                Assert.That(model.Id, Is.EqualTo(1638988125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("238.176.190.225"),

System.Net.IPAddress.Parse("176.217.220.171"),

System.Net.IPAddress.Parse("250.234.153.105"),

System.Net.IPAddress.Parse("120.141.97.84"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("27.167.12.59"),

System.Net.IPAddress.Parse("228.0.114.173"),

System.Net.IPAddress.Parse("84.92.209.93"),

System.Net.IPAddress.Parse("222.73.49.253"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(61017462));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("100.147.193.73"),

System.Net.IPAddress.Parse("233.233.33.9"),

System.Net.IPAddress.Parse("105.130.7.101"),

System.Net.IPAddress.Parse("44.177.139.252"),

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
                Assert.That(model.Id, Is.EqualTo(1756340245));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("150.75.94.98"),

System.Net.IPAddress.Parse("154.220.34.33"),

System.Net.IPAddress.Parse("142.176.194.74"),

System.Net.IPAddress.Parse("202.218.81.26"),

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
                Assert.That(model.Id, Is.EqualTo(1922739568));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("228.30.69.115"),

System.Net.IPAddress.Parse("47.141.103.161"),

System.Net.IPAddress.Parse("70.102.228.6"),

System.Net.IPAddress.Parse("254.191.71.128"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(703320384));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.195.51.129"),

System.Net.IPAddress.Parse("156.38.122.41"),

System.Net.IPAddress.Parse("48.90.16.224"),

System.Net.IPAddress.Parse("31.169.67.31"),

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
                Assert.That(model.Id, Is.EqualTo(2007192625));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("240.218.19.236"),

System.Net.IPAddress.Parse("230.32.225.58"),

System.Net.IPAddress.Parse("178.243.245.37"),

System.Net.IPAddress.Parse("214.115.0.243"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("230.17.30.20"),

System.Net.IPAddress.Parse("247.253.47.127"),

System.Net.IPAddress.Parse("141.148.99.217"),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2040415786));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("215.22.201.81"),

System.Net.IPAddress.Parse("131.67.161.140"),

System.Net.IPAddress.Parse("49.58.33.156"),

System.Net.IPAddress.Parse("62.233.132.186"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("88.82.118.139"),

System.Net.IPAddress.Parse("123.16.198.74"),

System.Net.IPAddress.Parse("78.60.212.89"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052968544));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("12.206.107.84"),

System.Net.IPAddress.Parse("253.166.191.242"),

System.Net.IPAddress.Parse("20.12.62.55"),

System.Net.IPAddress.Parse("222.206.221.195"),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2104615667));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("114.214.121.99"),

System.Net.IPAddress.Parse("189.139.10.2"),

System.Net.IPAddress.Parse("67.190.160.184"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(436734963));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.204.18.197"),

System.Net.IPAddress.Parse("251.64.78.104"),

System.Net.IPAddress.Parse("239.106.229.118"),

System.Net.IPAddress.Parse("102.155.103.38"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("160.35.180.101"),

System.Net.IPAddress.Parse("221.52.23.175"),

System.Net.IPAddress.Parse("217.105.180.102"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

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
FROM public.ipaddressinetarray2m m
LEFT JOIN public.ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(IPAddressinetArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)
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
                var models =  ((IIPAddressListinetArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53114524));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("159.183.238.80"),

System.Net.IPAddress.Parse("47.218.200.218"),

System.Net.IPAddress.Parse("195.155.174.179"),

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

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(176088676));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("231.154.164.129"),

System.Net.IPAddress.Parse("120.253.84.87"),

System.Net.IPAddress.Parse("212.65.4.68"),

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
                Assert.That(model.Id, Is.EqualTo(240216224));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("229.179.159.9"),

System.Net.IPAddress.Parse("127.52.178.185"),

System.Net.IPAddress.Parse("91.100.65.63"),

System.Net.IPAddress.Parse("50.192.76.61"),

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

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(257730448));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("119.15.65.137"),

System.Net.IPAddress.Parse("245.182.223.243"),

System.Net.IPAddress.Parse("244.136.201.23"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("83.62.100.46"),

System.Net.IPAddress.Parse("120.87.237.84"),

System.Net.IPAddress.Parse("223.162.60.65"),

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
                Assert.That(model.Id, Is.EqualTo(319861696));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("161.57.84.109"),

System.Net.IPAddress.Parse("56.101.160.188"),

System.Net.IPAddress.Parse("48.177.91.150"),

System.Net.IPAddress.Parse("191.127.158.251"),

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
                Assert.That(model.Id, Is.EqualTo(423054754));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("164.157.197.43"),

System.Net.IPAddress.Parse("130.23.54.205"),

System.Net.IPAddress.Parse("37.54.239.101"),

System.Net.IPAddress.Parse("73.12.19.35"),

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
                Assert.That(model.Id, Is.EqualTo(472717847));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("241.59.34.38"),

System.Net.IPAddress.Parse("130.204.76.173"),

System.Net.IPAddress.Parse("79.248.179.157"),

System.Net.IPAddress.Parse("188.41.127.62"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("156.13.97.202"),

System.Net.IPAddress.Parse("159.132.115.209"),

System.Net.IPAddress.Parse("175.21.56.20"),

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

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(559278709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("3.86.229.33"),

System.Net.IPAddress.Parse("130.197.93.26"),

System.Net.IPAddress.Parse("72.250.135.43"),

System.Net.IPAddress.Parse("163.155.132.169"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("140.194.187.99"),

System.Net.IPAddress.Parse("118.102.89.142"),

System.Net.IPAddress.Parse("13.60.73.41"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(679149257));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("202.219.60.179"),

System.Net.IPAddress.Parse("187.5.225.114"),

System.Net.IPAddress.Parse("55.30.143.74"),

System.Net.IPAddress.Parse("196.204.74.213"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("9.159.202.96"),

System.Net.IPAddress.Parse("146.25.129.165"),

System.Net.IPAddress.Parse("176.4.79.145"),

System.Net.IPAddress.Parse("50.140.252.16"),

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
                Assert.That(model.Id, Is.EqualTo(847185137));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("98.15.82.204"),

System.Net.IPAddress.Parse("252.118.194.18"),

System.Net.IPAddress.Parse("140.28.233.210"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("200.247.194.13"),

System.Net.IPAddress.Parse("47.236.77.59"),

System.Net.IPAddress.Parse("101.230.108.169"),

System.Net.IPAddress.Parse("253.76.177.154"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(775413525));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("130.177.116.86"),

System.Net.IPAddress.Parse("138.151.82.18"),

System.Net.IPAddress.Parse("141.75.165.3"),

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
                Assert.That(model.Id, Is.EqualTo(851516451));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("114.58.46.141"),

System.Net.IPAddress.Parse("41.29.187.157"),

System.Net.IPAddress.Parse("18.58.207.208"),

System.Net.IPAddress.Parse("158.158.51.6"),

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

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(858895777));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("159.237.35.54"),

System.Net.IPAddress.Parse("82.35.158.59"),

System.Net.IPAddress.Parse("151.16.199.130"),

System.Net.IPAddress.Parse("120.83.190.6"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("54.39.69.88"),

System.Net.IPAddress.Parse("111.223.164.184"),

System.Net.IPAddress.Parse("169.171.53.112"),

System.Net.IPAddress.Parse("67.158.242.122"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(493259895));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("81.113.197.138"),

System.Net.IPAddress.Parse("249.99.38.174"),

System.Net.IPAddress.Parse("165.188.246.116"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("21.66.153.109"),

System.Net.IPAddress.Parse("236.25.38.174"),

System.Net.IPAddress.Parse("58.17.218.250"),

System.Net.IPAddress.Parse("119.90.85.251"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(902976247));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.110.99.153"),

System.Net.IPAddress.Parse("106.34.132.127"),

System.Net.IPAddress.Parse("14.244.237.116"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("130.224.116.24"),

System.Net.IPAddress.Parse("22.224.44.21"),

System.Net.IPAddress.Parse("191.106.38.6"),

System.Net.IPAddress.Parse("38.34.145.29"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(592622261));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("252.208.123.189"),

System.Net.IPAddress.Parse("208.222.169.239"),

System.Net.IPAddress.Parse("197.116.246.21"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.242.139.170"),

System.Net.IPAddress.Parse("98.182.29.207"),

System.Net.IPAddress.Parse("128.85.70.118"),

System.Net.IPAddress.Parse("23.10.30.70"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981696302));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("41.213.89.173"),

System.Net.IPAddress.Parse("205.13.25.8"),

System.Net.IPAddress.Parse("2.201.212.105"),

System.Net.IPAddress.Parse("11.197.168.221"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("65.97.244.44"),

System.Net.IPAddress.Parse("140.204.33.168"),

System.Net.IPAddress.Parse("231.126.13.176"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1489277569));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("165.86.216.81"),

System.Net.IPAddress.Parse("245.137.206.18"),

System.Net.IPAddress.Parse("1.79.152.27"),

System.Net.IPAddress.Parse("96.224.29.188"),

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
                Assert.That(model.Id, Is.EqualTo(1204012623));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("36.58.5.135"),

System.Net.IPAddress.Parse("204.131.149.141"),

System.Net.IPAddress.Parse("34.164.207.185"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("226.180.138.138"),

System.Net.IPAddress.Parse("115.183.220.221"),

System.Net.IPAddress.Parse("112.123.153.54"),

System.Net.IPAddress.Parse("174.176.254.16"),

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
                Assert.That(model.Id, Is.EqualTo(1250031908));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("29.197.212.239"),

System.Net.IPAddress.Parse("69.253.159.51"),

System.Net.IPAddress.Parse("133.98.78.11"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1578563188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("120.2.76.27"),

System.Net.IPAddress.Parse("83.75.169.142"),

System.Net.IPAddress.Parse("104.84.35.5"),

System.Net.IPAddress.Parse("196.18.179.70"),

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

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1418534519));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("19.77.126.164"),

System.Net.IPAddress.Parse("165.103.55.104"),

System.Net.IPAddress.Parse("38.19.49.31"),

System.Net.IPAddress.Parse("83.6.206.81"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("144.244.130.29"),

System.Net.IPAddress.Parse("137.242.134.148"),

System.Net.IPAddress.Parse("231.169.48.185"),

System.Net.IPAddress.Parse("75.59.63.3"),

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
                Assert.That(model.Id, Is.EqualTo(1419166380));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("191.209.175.78"),

System.Net.IPAddress.Parse("180.73.250.86"),

System.Net.IPAddress.Parse("159.236.95.242"),

System.Net.IPAddress.Parse("228.237.150.193"),

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
                Assert.That(model.Id, Is.EqualTo(1421378455));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("77.64.81.188"),

System.Net.IPAddress.Parse("44.144.63.85"),

System.Net.IPAddress.Parse("208.163.44.211"),

System.Net.IPAddress.Parse("101.86.45.208"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(218881980));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("208.89.35.2"),

System.Net.IPAddress.Parse("2.14.156.67"),

System.Net.IPAddress.Parse("180.72.116.152"),

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

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1438534957));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("15.72.84.63"),

System.Net.IPAddress.Parse("42.139.165.220"),

System.Net.IPAddress.Parse("67.151.201.38"),

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
                Assert.That(model.Id, Is.EqualTo(1525861477));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("120.57.111.227"),

System.Net.IPAddress.Parse("67.16.249.162"),

System.Net.IPAddress.Parse("220.169.60.178"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237378685));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.181.180.192"),

System.Net.IPAddress.Parse("232.201.183.160"),

System.Net.IPAddress.Parse("128.78.180.105"),

System.Net.IPAddress.Parse("83.124.226.123"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("52.132.213.140"),

System.Net.IPAddress.Parse("97.62.253.66"),

System.Net.IPAddress.Parse("0.168.126.136"),

System.Net.IPAddress.Parse("191.235.71.132"),

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
                Assert.That(model.Id, Is.EqualTo(1560260232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.113.47.65"),

System.Net.IPAddress.Parse("205.48.45.20"),

System.Net.IPAddress.Parse("35.138.105.162"),

System.Net.IPAddress.Parse("222.77.163.247"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(797012636));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("62.173.14.133"),

System.Net.IPAddress.Parse("67.86.171.23"),

System.Net.IPAddress.Parse("160.65.160.234"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("181.105.46.223"),

System.Net.IPAddress.Parse("111.116.29.174"),

System.Net.IPAddress.Parse("28.117.6.147"),

System.Net.IPAddress.Parse("130.86.91.56"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1601022817));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("99.66.243.223"),

System.Net.IPAddress.Parse("203.91.144.163"),

System.Net.IPAddress.Parse("91.36.60.111"),

System.Net.IPAddress.Parse("217.167.44.30"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.179.183.203"),

System.Net.IPAddress.Parse("28.62.216.212"),

System.Net.IPAddress.Parse("236.24.81.156"),

System.Net.IPAddress.Parse("203.241.215.77"),

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
                Assert.That(model.Id, Is.EqualTo(1619643577));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("234.177.215.48"),

System.Net.IPAddress.Parse("37.193.37.208"),

System.Net.IPAddress.Parse("103.210.118.208"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("128.38.221.117"),

System.Net.IPAddress.Parse("170.184.57.90"),

System.Net.IPAddress.Parse("222.78.57.150"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2079482896));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("118.145.130.134"),

System.Net.IPAddress.Parse("168.145.47.246"),

System.Net.IPAddress.Parse("133.178.124.149"),

System.Net.IPAddress.Parse("205.208.209.69"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("206.4.8.189"),

System.Net.IPAddress.Parse("178.105.254.175"),

System.Net.IPAddress.Parse("32.108.100.214"),

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
                Assert.That(model.Id, Is.EqualTo(1626757037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.88.198.127"),

System.Net.IPAddress.Parse("74.81.157.228"),

System.Net.IPAddress.Parse("236.35.8.93"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1683706738));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.82.80.245"),

System.Net.IPAddress.Parse("232.116.79.125"),

System.Net.IPAddress.Parse("174.46.62.103"),

System.Net.IPAddress.Parse("60.126.156.24"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("13.109.69.5"),

System.Net.IPAddress.Parse("231.51.35.179"),

System.Net.IPAddress.Parse("108.70.229.199"),

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
                Assert.That(model.Id, Is.EqualTo(1638988125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("238.176.190.225"),

System.Net.IPAddress.Parse("176.217.220.171"),

System.Net.IPAddress.Parse("250.234.153.105"),

System.Net.IPAddress.Parse("120.141.97.84"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("27.167.12.59"),

System.Net.IPAddress.Parse("228.0.114.173"),

System.Net.IPAddress.Parse("84.92.209.93"),

System.Net.IPAddress.Parse("222.73.49.253"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(61017462));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("100.147.193.73"),

System.Net.IPAddress.Parse("233.233.33.9"),

System.Net.IPAddress.Parse("105.130.7.101"),

System.Net.IPAddress.Parse("44.177.139.252"),

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
                Assert.That(model.Id, Is.EqualTo(1756340245));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("150.75.94.98"),

System.Net.IPAddress.Parse("154.220.34.33"),

System.Net.IPAddress.Parse("142.176.194.74"),

System.Net.IPAddress.Parse("202.218.81.26"),

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
                Assert.That(model.Id, Is.EqualTo(1922739568));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("228.30.69.115"),

System.Net.IPAddress.Parse("47.141.103.161"),

System.Net.IPAddress.Parse("70.102.228.6"),

System.Net.IPAddress.Parse("254.191.71.128"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(703320384));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.195.51.129"),

System.Net.IPAddress.Parse("156.38.122.41"),

System.Net.IPAddress.Parse("48.90.16.224"),

System.Net.IPAddress.Parse("31.169.67.31"),

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
                Assert.That(model.Id, Is.EqualTo(2007192625));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("240.218.19.236"),

System.Net.IPAddress.Parse("230.32.225.58"),

System.Net.IPAddress.Parse("178.243.245.37"),

System.Net.IPAddress.Parse("214.115.0.243"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("230.17.30.20"),

System.Net.IPAddress.Parse("247.253.47.127"),

System.Net.IPAddress.Parse("141.148.99.217"),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2040415786));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("215.22.201.81"),

System.Net.IPAddress.Parse("131.67.161.140"),

System.Net.IPAddress.Parse("49.58.33.156"),

System.Net.IPAddress.Parse("62.233.132.186"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("88.82.118.139"),

System.Net.IPAddress.Parse("123.16.198.74"),

System.Net.IPAddress.Parse("78.60.212.89"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052968544));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("12.206.107.84"),

System.Net.IPAddress.Parse("253.166.191.242"),

System.Net.IPAddress.Parse("20.12.62.55"),

System.Net.IPAddress.Parse("222.206.221.195"),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2104615667));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("114.214.121.99"),

System.Net.IPAddress.Parse("189.139.10.2"),

System.Net.IPAddress.Parse("67.190.160.184"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(436734963));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.204.18.197"),

System.Net.IPAddress.Parse("251.64.78.104"),

System.Net.IPAddress.Parse("239.106.229.118"),

System.Net.IPAddress.Parse("102.155.103.38"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("160.35.180.101"),

System.Net.IPAddress.Parse("221.52.23.175"),

System.Net.IPAddress.Parse("217.105.180.102"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressListinetArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53114524));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("159.183.238.80"),

System.Net.IPAddress.Parse("47.218.200.218"),

System.Net.IPAddress.Parse("195.155.174.179"),

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

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(176088676));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("231.154.164.129"),

System.Net.IPAddress.Parse("120.253.84.87"),

System.Net.IPAddress.Parse("212.65.4.68"),

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
                Assert.That(model.Id, Is.EqualTo(240216224));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("229.179.159.9"),

System.Net.IPAddress.Parse("127.52.178.185"),

System.Net.IPAddress.Parse("91.100.65.63"),

System.Net.IPAddress.Parse("50.192.76.61"),

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

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(257730448));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("119.15.65.137"),

System.Net.IPAddress.Parse("245.182.223.243"),

System.Net.IPAddress.Parse("244.136.201.23"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("83.62.100.46"),

System.Net.IPAddress.Parse("120.87.237.84"),

System.Net.IPAddress.Parse("223.162.60.65"),

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
                Assert.That(model.Id, Is.EqualTo(319861696));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("161.57.84.109"),

System.Net.IPAddress.Parse("56.101.160.188"),

System.Net.IPAddress.Parse("48.177.91.150"),

System.Net.IPAddress.Parse("191.127.158.251"),

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
                Assert.That(model.Id, Is.EqualTo(423054754));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("164.157.197.43"),

System.Net.IPAddress.Parse("130.23.54.205"),

System.Net.IPAddress.Parse("37.54.239.101"),

System.Net.IPAddress.Parse("73.12.19.35"),

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
                Assert.That(model.Id, Is.EqualTo(472717847));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("241.59.34.38"),

System.Net.IPAddress.Parse("130.204.76.173"),

System.Net.IPAddress.Parse("79.248.179.157"),

System.Net.IPAddress.Parse("188.41.127.62"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("156.13.97.202"),

System.Net.IPAddress.Parse("159.132.115.209"),

System.Net.IPAddress.Parse("175.21.56.20"),

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

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(559278709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("3.86.229.33"),

System.Net.IPAddress.Parse("130.197.93.26"),

System.Net.IPAddress.Parse("72.250.135.43"),

System.Net.IPAddress.Parse("163.155.132.169"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("140.194.187.99"),

System.Net.IPAddress.Parse("118.102.89.142"),

System.Net.IPAddress.Parse("13.60.73.41"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(679149257));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("202.219.60.179"),

System.Net.IPAddress.Parse("187.5.225.114"),

System.Net.IPAddress.Parse("55.30.143.74"),

System.Net.IPAddress.Parse("196.204.74.213"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("9.159.202.96"),

System.Net.IPAddress.Parse("146.25.129.165"),

System.Net.IPAddress.Parse("176.4.79.145"),

System.Net.IPAddress.Parse("50.140.252.16"),

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
                Assert.That(model.Id, Is.EqualTo(847185137));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("98.15.82.204"),

System.Net.IPAddress.Parse("252.118.194.18"),

System.Net.IPAddress.Parse("140.28.233.210"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("200.247.194.13"),

System.Net.IPAddress.Parse("47.236.77.59"),

System.Net.IPAddress.Parse("101.230.108.169"),

System.Net.IPAddress.Parse("253.76.177.154"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(775413525));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("130.177.116.86"),

System.Net.IPAddress.Parse("138.151.82.18"),

System.Net.IPAddress.Parse("141.75.165.3"),

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
                Assert.That(model.Id, Is.EqualTo(851516451));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("114.58.46.141"),

System.Net.IPAddress.Parse("41.29.187.157"),

System.Net.IPAddress.Parse("18.58.207.208"),

System.Net.IPAddress.Parse("158.158.51.6"),

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

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(858895777));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("159.237.35.54"),

System.Net.IPAddress.Parse("82.35.158.59"),

System.Net.IPAddress.Parse("151.16.199.130"),

System.Net.IPAddress.Parse("120.83.190.6"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("54.39.69.88"),

System.Net.IPAddress.Parse("111.223.164.184"),

System.Net.IPAddress.Parse("169.171.53.112"),

System.Net.IPAddress.Parse("67.158.242.122"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(493259895));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("81.113.197.138"),

System.Net.IPAddress.Parse("249.99.38.174"),

System.Net.IPAddress.Parse("165.188.246.116"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("21.66.153.109"),

System.Net.IPAddress.Parse("236.25.38.174"),

System.Net.IPAddress.Parse("58.17.218.250"),

System.Net.IPAddress.Parse("119.90.85.251"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(902976247));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.110.99.153"),

System.Net.IPAddress.Parse("106.34.132.127"),

System.Net.IPAddress.Parse("14.244.237.116"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("130.224.116.24"),

System.Net.IPAddress.Parse("22.224.44.21"),

System.Net.IPAddress.Parse("191.106.38.6"),

System.Net.IPAddress.Parse("38.34.145.29"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(592622261));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("252.208.123.189"),

System.Net.IPAddress.Parse("208.222.169.239"),

System.Net.IPAddress.Parse("197.116.246.21"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.242.139.170"),

System.Net.IPAddress.Parse("98.182.29.207"),

System.Net.IPAddress.Parse("128.85.70.118"),

System.Net.IPAddress.Parse("23.10.30.70"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981696302));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("41.213.89.173"),

System.Net.IPAddress.Parse("205.13.25.8"),

System.Net.IPAddress.Parse("2.201.212.105"),

System.Net.IPAddress.Parse("11.197.168.221"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("65.97.244.44"),

System.Net.IPAddress.Parse("140.204.33.168"),

System.Net.IPAddress.Parse("231.126.13.176"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1489277569));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("165.86.216.81"),

System.Net.IPAddress.Parse("245.137.206.18"),

System.Net.IPAddress.Parse("1.79.152.27"),

System.Net.IPAddress.Parse("96.224.29.188"),

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
                Assert.That(model.Id, Is.EqualTo(1204012623));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("36.58.5.135"),

System.Net.IPAddress.Parse("204.131.149.141"),

System.Net.IPAddress.Parse("34.164.207.185"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("226.180.138.138"),

System.Net.IPAddress.Parse("115.183.220.221"),

System.Net.IPAddress.Parse("112.123.153.54"),

System.Net.IPAddress.Parse("174.176.254.16"),

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
                Assert.That(model.Id, Is.EqualTo(1250031908));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("29.197.212.239"),

System.Net.IPAddress.Parse("69.253.159.51"),

System.Net.IPAddress.Parse("133.98.78.11"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1578563188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("120.2.76.27"),

System.Net.IPAddress.Parse("83.75.169.142"),

System.Net.IPAddress.Parse("104.84.35.5"),

System.Net.IPAddress.Parse("196.18.179.70"),

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

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1418534519));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("19.77.126.164"),

System.Net.IPAddress.Parse("165.103.55.104"),

System.Net.IPAddress.Parse("38.19.49.31"),

System.Net.IPAddress.Parse("83.6.206.81"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("144.244.130.29"),

System.Net.IPAddress.Parse("137.242.134.148"),

System.Net.IPAddress.Parse("231.169.48.185"),

System.Net.IPAddress.Parse("75.59.63.3"),

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
                Assert.That(model.Id, Is.EqualTo(1419166380));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("191.209.175.78"),

System.Net.IPAddress.Parse("180.73.250.86"),

System.Net.IPAddress.Parse("159.236.95.242"),

System.Net.IPAddress.Parse("228.237.150.193"),

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
                Assert.That(model.Id, Is.EqualTo(1421378455));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("77.64.81.188"),

System.Net.IPAddress.Parse("44.144.63.85"),

System.Net.IPAddress.Parse("208.163.44.211"),

System.Net.IPAddress.Parse("101.86.45.208"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(218881980));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("208.89.35.2"),

System.Net.IPAddress.Parse("2.14.156.67"),

System.Net.IPAddress.Parse("180.72.116.152"),

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

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1438534957));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("15.72.84.63"),

System.Net.IPAddress.Parse("42.139.165.220"),

System.Net.IPAddress.Parse("67.151.201.38"),

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
                Assert.That(model.Id, Is.EqualTo(1525861477));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("120.57.111.227"),

System.Net.IPAddress.Parse("67.16.249.162"),

System.Net.IPAddress.Parse("220.169.60.178"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237378685));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.181.180.192"),

System.Net.IPAddress.Parse("232.201.183.160"),

System.Net.IPAddress.Parse("128.78.180.105"),

System.Net.IPAddress.Parse("83.124.226.123"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("52.132.213.140"),

System.Net.IPAddress.Parse("97.62.253.66"),

System.Net.IPAddress.Parse("0.168.126.136"),

System.Net.IPAddress.Parse("191.235.71.132"),

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
                Assert.That(model.Id, Is.EqualTo(1560260232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.113.47.65"),

System.Net.IPAddress.Parse("205.48.45.20"),

System.Net.IPAddress.Parse("35.138.105.162"),

System.Net.IPAddress.Parse("222.77.163.247"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(797012636));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("62.173.14.133"),

System.Net.IPAddress.Parse("67.86.171.23"),

System.Net.IPAddress.Parse("160.65.160.234"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("181.105.46.223"),

System.Net.IPAddress.Parse("111.116.29.174"),

System.Net.IPAddress.Parse("28.117.6.147"),

System.Net.IPAddress.Parse("130.86.91.56"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1601022817));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("99.66.243.223"),

System.Net.IPAddress.Parse("203.91.144.163"),

System.Net.IPAddress.Parse("91.36.60.111"),

System.Net.IPAddress.Parse("217.167.44.30"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.179.183.203"),

System.Net.IPAddress.Parse("28.62.216.212"),

System.Net.IPAddress.Parse("236.24.81.156"),

System.Net.IPAddress.Parse("203.241.215.77"),

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
                Assert.That(model.Id, Is.EqualTo(1619643577));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("234.177.215.48"),

System.Net.IPAddress.Parse("37.193.37.208"),

System.Net.IPAddress.Parse("103.210.118.208"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("128.38.221.117"),

System.Net.IPAddress.Parse("170.184.57.90"),

System.Net.IPAddress.Parse("222.78.57.150"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2079482896));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("118.145.130.134"),

System.Net.IPAddress.Parse("168.145.47.246"),

System.Net.IPAddress.Parse("133.178.124.149"),

System.Net.IPAddress.Parse("205.208.209.69"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("206.4.8.189"),

System.Net.IPAddress.Parse("178.105.254.175"),

System.Net.IPAddress.Parse("32.108.100.214"),

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
                Assert.That(model.Id, Is.EqualTo(1626757037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.88.198.127"),

System.Net.IPAddress.Parse("74.81.157.228"),

System.Net.IPAddress.Parse("236.35.8.93"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1683706738));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.82.80.245"),

System.Net.IPAddress.Parse("232.116.79.125"),

System.Net.IPAddress.Parse("174.46.62.103"),

System.Net.IPAddress.Parse("60.126.156.24"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("13.109.69.5"),

System.Net.IPAddress.Parse("231.51.35.179"),

System.Net.IPAddress.Parse("108.70.229.199"),

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
                Assert.That(model.Id, Is.EqualTo(1638988125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("238.176.190.225"),

System.Net.IPAddress.Parse("176.217.220.171"),

System.Net.IPAddress.Parse("250.234.153.105"),

System.Net.IPAddress.Parse("120.141.97.84"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("27.167.12.59"),

System.Net.IPAddress.Parse("228.0.114.173"),

System.Net.IPAddress.Parse("84.92.209.93"),

System.Net.IPAddress.Parse("222.73.49.253"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(61017462));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("100.147.193.73"),

System.Net.IPAddress.Parse("233.233.33.9"),

System.Net.IPAddress.Parse("105.130.7.101"),

System.Net.IPAddress.Parse("44.177.139.252"),

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
                Assert.That(model.Id, Is.EqualTo(1756340245));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("150.75.94.98"),

System.Net.IPAddress.Parse("154.220.34.33"),

System.Net.IPAddress.Parse("142.176.194.74"),

System.Net.IPAddress.Parse("202.218.81.26"),

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
                Assert.That(model.Id, Is.EqualTo(1922739568));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("228.30.69.115"),

System.Net.IPAddress.Parse("47.141.103.161"),

System.Net.IPAddress.Parse("70.102.228.6"),

System.Net.IPAddress.Parse("254.191.71.128"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(703320384));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.195.51.129"),

System.Net.IPAddress.Parse("156.38.122.41"),

System.Net.IPAddress.Parse("48.90.16.224"),

System.Net.IPAddress.Parse("31.169.67.31"),

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
                Assert.That(model.Id, Is.EqualTo(2007192625));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("240.218.19.236"),

System.Net.IPAddress.Parse("230.32.225.58"),

System.Net.IPAddress.Parse("178.243.245.37"),

System.Net.IPAddress.Parse("214.115.0.243"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("230.17.30.20"),

System.Net.IPAddress.Parse("247.253.47.127"),

System.Net.IPAddress.Parse("141.148.99.217"),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2040415786));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("215.22.201.81"),

System.Net.IPAddress.Parse("131.67.161.140"),

System.Net.IPAddress.Parse("49.58.33.156"),

System.Net.IPAddress.Parse("62.233.132.186"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("88.82.118.139"),

System.Net.IPAddress.Parse("123.16.198.74"),

System.Net.IPAddress.Parse("78.60.212.89"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052968544));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("12.206.107.84"),

System.Net.IPAddress.Parse("253.166.191.242"),

System.Net.IPAddress.Parse("20.12.62.55"),

System.Net.IPAddress.Parse("222.206.221.195"),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2104615667));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("114.214.121.99"),

System.Net.IPAddress.Parse("189.139.10.2"),

System.Net.IPAddress.Parse("67.190.160.184"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(436734963));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.204.18.197"),

System.Net.IPAddress.Parse("251.64.78.104"),

System.Net.IPAddress.Parse("239.106.229.118"),

System.Net.IPAddress.Parse("102.155.103.38"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("160.35.180.101"),

System.Net.IPAddress.Parse("221.52.23.175"),

System.Net.IPAddress.Parse("217.105.180.102"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressListinetArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 1626757037);
                var models =  ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(6));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1638988125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("238.176.190.225"),

System.Net.IPAddress.Parse("176.217.220.171"),

System.Net.IPAddress.Parse("250.234.153.105"),

System.Net.IPAddress.Parse("120.141.97.84"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("27.167.12.59"),

System.Net.IPAddress.Parse("228.0.114.173"),

System.Net.IPAddress.Parse("84.92.209.93"),

System.Net.IPAddress.Parse("222.73.49.253"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(61017462));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("100.147.193.73"),

System.Net.IPAddress.Parse("233.233.33.9"),

System.Net.IPAddress.Parse("105.130.7.101"),

System.Net.IPAddress.Parse("44.177.139.252"),

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
                Assert.That(model.Id, Is.EqualTo(1756340245));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("150.75.94.98"),

System.Net.IPAddress.Parse("154.220.34.33"),

System.Net.IPAddress.Parse("142.176.194.74"),

System.Net.IPAddress.Parse("202.218.81.26"),

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
                Assert.That(model.Id, Is.EqualTo(1922739568));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("228.30.69.115"),

System.Net.IPAddress.Parse("47.141.103.161"),

System.Net.IPAddress.Parse("70.102.228.6"),

System.Net.IPAddress.Parse("254.191.71.128"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(703320384));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.195.51.129"),

System.Net.IPAddress.Parse("156.38.122.41"),

System.Net.IPAddress.Parse("48.90.16.224"),

System.Net.IPAddress.Parse("31.169.67.31"),

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
                Assert.That(model.Id, Is.EqualTo(2007192625));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("240.218.19.236"),

System.Net.IPAddress.Parse("230.32.225.58"),

System.Net.IPAddress.Parse("178.243.245.37"),

System.Net.IPAddress.Parse("214.115.0.243"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("230.17.30.20"),

System.Net.IPAddress.Parse("247.253.47.127"),

System.Net.IPAddress.Parse("141.148.99.217"),

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
                Assert.That(model.Id, Is.EqualTo(2040415786));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("215.22.201.81"),

System.Net.IPAddress.Parse("131.67.161.140"),

System.Net.IPAddress.Parse("49.58.33.156"),

System.Net.IPAddress.Parse("62.233.132.186"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("88.82.118.139"),

System.Net.IPAddress.Parse("123.16.198.74"),

System.Net.IPAddress.Parse("78.60.212.89"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052968544));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("12.206.107.84"),

System.Net.IPAddress.Parse("253.166.191.242"),

System.Net.IPAddress.Parse("20.12.62.55"),

System.Net.IPAddress.Parse("222.206.221.195"),

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
                Assert.That(model.Id, Is.EqualTo(2104615667));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("114.214.121.99"),

System.Net.IPAddress.Parse("189.139.10.2"),

System.Net.IPAddress.Parse("67.190.160.184"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(436734963));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.204.18.197"),

System.Net.IPAddress.Parse("251.64.78.104"),

System.Net.IPAddress.Parse("239.106.229.118"),

System.Net.IPAddress.Parse("102.155.103.38"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("160.35.180.101"),

System.Net.IPAddress.Parse("221.52.23.175"),

System.Net.IPAddress.Parse("217.105.180.102"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IIPAddressListinetArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IIPAddressListinetArray)this).SetDbConnectionSelectModelParametrs(cmd, 847185137);
                var models = await ((IIPAddressListinetArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(21));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(851516451));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("114.58.46.141"),

System.Net.IPAddress.Parse("41.29.187.157"),

System.Net.IPAddress.Parse("18.58.207.208"),

System.Net.IPAddress.Parse("158.158.51.6"),

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

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(858895777));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("159.237.35.54"),

System.Net.IPAddress.Parse("82.35.158.59"),

System.Net.IPAddress.Parse("151.16.199.130"),

System.Net.IPAddress.Parse("120.83.190.6"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("54.39.69.88"),

System.Net.IPAddress.Parse("111.223.164.184"),

System.Net.IPAddress.Parse("169.171.53.112"),

System.Net.IPAddress.Parse("67.158.242.122"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(493259895));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("81.113.197.138"),

System.Net.IPAddress.Parse("249.99.38.174"),

System.Net.IPAddress.Parse("165.188.246.116"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("21.66.153.109"),

System.Net.IPAddress.Parse("236.25.38.174"),

System.Net.IPAddress.Parse("58.17.218.250"),

System.Net.IPAddress.Parse("119.90.85.251"),

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
                Assert.That(model.Id, Is.EqualTo(902976247));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.110.99.153"),

System.Net.IPAddress.Parse("106.34.132.127"),

System.Net.IPAddress.Parse("14.244.237.116"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("130.224.116.24"),

System.Net.IPAddress.Parse("22.224.44.21"),

System.Net.IPAddress.Parse("191.106.38.6"),

System.Net.IPAddress.Parse("38.34.145.29"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(592622261));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("252.208.123.189"),

System.Net.IPAddress.Parse("208.222.169.239"),

System.Net.IPAddress.Parse("197.116.246.21"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.242.139.170"),

System.Net.IPAddress.Parse("98.182.29.207"),

System.Net.IPAddress.Parse("128.85.70.118"),

System.Net.IPAddress.Parse("23.10.30.70"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981696302));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("41.213.89.173"),

System.Net.IPAddress.Parse("205.13.25.8"),

System.Net.IPAddress.Parse("2.201.212.105"),

System.Net.IPAddress.Parse("11.197.168.221"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("65.97.244.44"),

System.Net.IPAddress.Parse("140.204.33.168"),

System.Net.IPAddress.Parse("231.126.13.176"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1489277569));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("165.86.216.81"),

System.Net.IPAddress.Parse("245.137.206.18"),

System.Net.IPAddress.Parse("1.79.152.27"),

System.Net.IPAddress.Parse("96.224.29.188"),

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
                Assert.That(model.Id, Is.EqualTo(1204012623));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("36.58.5.135"),

System.Net.IPAddress.Parse("204.131.149.141"),

System.Net.IPAddress.Parse("34.164.207.185"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("226.180.138.138"),

System.Net.IPAddress.Parse("115.183.220.221"),

System.Net.IPAddress.Parse("112.123.153.54"),

System.Net.IPAddress.Parse("174.176.254.16"),

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
                Assert.That(model.Id, Is.EqualTo(1250031908));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("29.197.212.239"),

System.Net.IPAddress.Parse("69.253.159.51"),

System.Net.IPAddress.Parse("133.98.78.11"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1578563188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("120.2.76.27"),

System.Net.IPAddress.Parse("83.75.169.142"),

System.Net.IPAddress.Parse("104.84.35.5"),

System.Net.IPAddress.Parse("196.18.179.70"),

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
                Assert.That(model.Id, Is.EqualTo(1418534519));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("19.77.126.164"),

System.Net.IPAddress.Parse("165.103.55.104"),

System.Net.IPAddress.Parse("38.19.49.31"),

System.Net.IPAddress.Parse("83.6.206.81"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("144.244.130.29"),

System.Net.IPAddress.Parse("137.242.134.148"),

System.Net.IPAddress.Parse("231.169.48.185"),

System.Net.IPAddress.Parse("75.59.63.3"),

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

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1419166380));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("191.209.175.78"),

System.Net.IPAddress.Parse("180.73.250.86"),

System.Net.IPAddress.Parse("159.236.95.242"),

System.Net.IPAddress.Parse("228.237.150.193"),

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

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1421378455));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("77.64.81.188"),

System.Net.IPAddress.Parse("44.144.63.85"),

System.Net.IPAddress.Parse("208.163.44.211"),

System.Net.IPAddress.Parse("101.86.45.208"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(218881980));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("208.89.35.2"),

System.Net.IPAddress.Parse("2.14.156.67"),

System.Net.IPAddress.Parse("180.72.116.152"),

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
                Assert.That(model.Id, Is.EqualTo(1438534957));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("15.72.84.63"),

System.Net.IPAddress.Parse("42.139.165.220"),

System.Net.IPAddress.Parse("67.151.201.38"),

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

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1525861477));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("120.57.111.227"),

System.Net.IPAddress.Parse("67.16.249.162"),

System.Net.IPAddress.Parse("220.169.60.178"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237378685));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.181.180.192"),

System.Net.IPAddress.Parse("232.201.183.160"),

System.Net.IPAddress.Parse("128.78.180.105"),

System.Net.IPAddress.Parse("83.124.226.123"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("52.132.213.140"),

System.Net.IPAddress.Parse("97.62.253.66"),

System.Net.IPAddress.Parse("0.168.126.136"),

System.Net.IPAddress.Parse("191.235.71.132"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1560260232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.113.47.65"),

System.Net.IPAddress.Parse("205.48.45.20"),

System.Net.IPAddress.Parse("35.138.105.162"),

System.Net.IPAddress.Parse("222.77.163.247"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(797012636));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("62.173.14.133"),

System.Net.IPAddress.Parse("67.86.171.23"),

System.Net.IPAddress.Parse("160.65.160.234"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("181.105.46.223"),

System.Net.IPAddress.Parse("111.116.29.174"),

System.Net.IPAddress.Parse("28.117.6.147"),

System.Net.IPAddress.Parse("130.86.91.56"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1601022817));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("99.66.243.223"),

System.Net.IPAddress.Parse("203.91.144.163"),

System.Net.IPAddress.Parse("91.36.60.111"),

System.Net.IPAddress.Parse("217.167.44.30"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.179.183.203"),

System.Net.IPAddress.Parse("28.62.216.212"),

System.Net.IPAddress.Parse("236.24.81.156"),

System.Net.IPAddress.Parse("203.241.215.77"),

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
                Assert.That(model.Id, Is.EqualTo(1619643577));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("234.177.215.48"),

System.Net.IPAddress.Parse("37.193.37.208"),

System.Net.IPAddress.Parse("103.210.118.208"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("128.38.221.117"),

System.Net.IPAddress.Parse("170.184.57.90"),

System.Net.IPAddress.Parse("222.78.57.150"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2079482896));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("118.145.130.134"),

System.Net.IPAddress.Parse("168.145.47.246"),

System.Net.IPAddress.Parse("133.178.124.149"),

System.Net.IPAddress.Parse("205.208.209.69"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("206.4.8.189"),

System.Net.IPAddress.Parse("178.105.254.175"),

System.Net.IPAddress.Parse("32.108.100.214"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1626757037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.88.198.127"),

System.Net.IPAddress.Parse("74.81.157.228"),

System.Net.IPAddress.Parse("236.35.8.93"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1683706738));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.82.80.245"),

System.Net.IPAddress.Parse("232.116.79.125"),

System.Net.IPAddress.Parse("174.46.62.103"),

System.Net.IPAddress.Parse("60.126.156.24"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("13.109.69.5"),

System.Net.IPAddress.Parse("231.51.35.179"),

System.Net.IPAddress.Parse("108.70.229.199"),

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
                Assert.That(model.Id, Is.EqualTo(1638988125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("238.176.190.225"),

System.Net.IPAddress.Parse("176.217.220.171"),

System.Net.IPAddress.Parse("250.234.153.105"),

System.Net.IPAddress.Parse("120.141.97.84"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("27.167.12.59"),

System.Net.IPAddress.Parse("228.0.114.173"),

System.Net.IPAddress.Parse("84.92.209.93"),

System.Net.IPAddress.Parse("222.73.49.253"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(61017462));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("100.147.193.73"),

System.Net.IPAddress.Parse("233.233.33.9"),

System.Net.IPAddress.Parse("105.130.7.101"),

System.Net.IPAddress.Parse("44.177.139.252"),

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
                Assert.That(model.Id, Is.EqualTo(1756340245));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("150.75.94.98"),

System.Net.IPAddress.Parse("154.220.34.33"),

System.Net.IPAddress.Parse("142.176.194.74"),

System.Net.IPAddress.Parse("202.218.81.26"),

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
                Assert.That(model.Id, Is.EqualTo(1922739568));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("228.30.69.115"),

System.Net.IPAddress.Parse("47.141.103.161"),

System.Net.IPAddress.Parse("70.102.228.6"),

System.Net.IPAddress.Parse("254.191.71.128"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(703320384));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.195.51.129"),

System.Net.IPAddress.Parse("156.38.122.41"),

System.Net.IPAddress.Parse("48.90.16.224"),

System.Net.IPAddress.Parse("31.169.67.31"),

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

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2007192625));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("240.218.19.236"),

System.Net.IPAddress.Parse("230.32.225.58"),

System.Net.IPAddress.Parse("178.243.245.37"),

System.Net.IPAddress.Parse("214.115.0.243"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("230.17.30.20"),

System.Net.IPAddress.Parse("247.253.47.127"),

System.Net.IPAddress.Parse("141.148.99.217"),

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
                Assert.That(model.Id, Is.EqualTo(2040415786));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("215.22.201.81"),

System.Net.IPAddress.Parse("131.67.161.140"),

System.Net.IPAddress.Parse("49.58.33.156"),

System.Net.IPAddress.Parse("62.233.132.186"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("88.82.118.139"),

System.Net.IPAddress.Parse("123.16.198.74"),

System.Net.IPAddress.Parse("78.60.212.89"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052968544));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("12.206.107.84"),

System.Net.IPAddress.Parse("253.166.191.242"),

System.Net.IPAddress.Parse("20.12.62.55"),

System.Net.IPAddress.Parse("222.206.221.195"),

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

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2104615667));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("114.214.121.99"),

System.Net.IPAddress.Parse("189.139.10.2"),

System.Net.IPAddress.Parse("67.190.160.184"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(436734963));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.204.18.197"),

System.Net.IPAddress.Parse("251.64.78.104"),

System.Net.IPAddress.Parse("239.106.229.118"),

System.Net.IPAddress.Parse("102.155.103.38"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("160.35.180.101"),

System.Net.IPAddress.Parse("221.52.23.175"),

System.Net.IPAddress.Parse("217.105.180.102"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressListinetArray)
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
                 foreach(var batchResult in ((IIPAddressListinetArray)this).DbConnectionSelectModelBatch(connection, 1756340245, 559278709))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(4));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1922739568));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("228.30.69.115"),

System.Net.IPAddress.Parse("47.141.103.161"),

System.Net.IPAddress.Parse("70.102.228.6"),

System.Net.IPAddress.Parse("254.191.71.128"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(703320384));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.195.51.129"),

System.Net.IPAddress.Parse("156.38.122.41"),

System.Net.IPAddress.Parse("48.90.16.224"),

System.Net.IPAddress.Parse("31.169.67.31"),

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
                Assert.That(model.Id, Is.EqualTo(2007192625));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("240.218.19.236"),

System.Net.IPAddress.Parse("230.32.225.58"),

System.Net.IPAddress.Parse("178.243.245.37"),

System.Net.IPAddress.Parse("214.115.0.243"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("230.17.30.20"),

System.Net.IPAddress.Parse("247.253.47.127"),

System.Net.IPAddress.Parse("141.148.99.217"),

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
                Assert.That(model.Id, Is.EqualTo(2040415786));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("215.22.201.81"),

System.Net.IPAddress.Parse("131.67.161.140"),

System.Net.IPAddress.Parse("49.58.33.156"),

System.Net.IPAddress.Parse("62.233.132.186"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("88.82.118.139"),

System.Net.IPAddress.Parse("123.16.198.74"),

System.Net.IPAddress.Parse("78.60.212.89"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052968544));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("12.206.107.84"),

System.Net.IPAddress.Parse("253.166.191.242"),

System.Net.IPAddress.Parse("20.12.62.55"),

System.Net.IPAddress.Parse("222.206.221.195"),

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
                Assert.That(model.Id, Is.EqualTo(2104615667));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("114.214.121.99"),

System.Net.IPAddress.Parse("189.139.10.2"),

System.Net.IPAddress.Parse("67.190.160.184"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(436734963));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.204.18.197"),

System.Net.IPAddress.Parse("251.64.78.104"),

System.Net.IPAddress.Parse("239.106.229.118"),

System.Net.IPAddress.Parse("102.155.103.38"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("160.35.180.101"),

System.Net.IPAddress.Parse("221.52.23.175"),

System.Net.IPAddress.Parse("217.105.180.102"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(22));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(847185137));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("98.15.82.204"),

System.Net.IPAddress.Parse("252.118.194.18"),

System.Net.IPAddress.Parse("140.28.233.210"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("200.247.194.13"),

System.Net.IPAddress.Parse("47.236.77.59"),

System.Net.IPAddress.Parse("101.230.108.169"),

System.Net.IPAddress.Parse("253.76.177.154"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(775413525));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("130.177.116.86"),

System.Net.IPAddress.Parse("138.151.82.18"),

System.Net.IPAddress.Parse("141.75.165.3"),

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
                Assert.That(model.Id, Is.EqualTo(851516451));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("114.58.46.141"),

System.Net.IPAddress.Parse("41.29.187.157"),

System.Net.IPAddress.Parse("18.58.207.208"),

System.Net.IPAddress.Parse("158.158.51.6"),

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
                Assert.That(model.Id, Is.EqualTo(858895777));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("159.237.35.54"),

System.Net.IPAddress.Parse("82.35.158.59"),

System.Net.IPAddress.Parse("151.16.199.130"),

System.Net.IPAddress.Parse("120.83.190.6"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("54.39.69.88"),

System.Net.IPAddress.Parse("111.223.164.184"),

System.Net.IPAddress.Parse("169.171.53.112"),

System.Net.IPAddress.Parse("67.158.242.122"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(493259895));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("81.113.197.138"),

System.Net.IPAddress.Parse("249.99.38.174"),

System.Net.IPAddress.Parse("165.188.246.116"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("21.66.153.109"),

System.Net.IPAddress.Parse("236.25.38.174"),

System.Net.IPAddress.Parse("58.17.218.250"),

System.Net.IPAddress.Parse("119.90.85.251"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(902976247));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.110.99.153"),

System.Net.IPAddress.Parse("106.34.132.127"),

System.Net.IPAddress.Parse("14.244.237.116"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("130.224.116.24"),

System.Net.IPAddress.Parse("22.224.44.21"),

System.Net.IPAddress.Parse("191.106.38.6"),

System.Net.IPAddress.Parse("38.34.145.29"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(592622261));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("252.208.123.189"),

System.Net.IPAddress.Parse("208.222.169.239"),

System.Net.IPAddress.Parse("197.116.246.21"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.242.139.170"),

System.Net.IPAddress.Parse("98.182.29.207"),

System.Net.IPAddress.Parse("128.85.70.118"),

System.Net.IPAddress.Parse("23.10.30.70"),

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
                Assert.That(model.Id, Is.EqualTo(981696302));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("41.213.89.173"),

System.Net.IPAddress.Parse("205.13.25.8"),

System.Net.IPAddress.Parse("2.201.212.105"),

System.Net.IPAddress.Parse("11.197.168.221"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("65.97.244.44"),

System.Net.IPAddress.Parse("140.204.33.168"),

System.Net.IPAddress.Parse("231.126.13.176"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1489277569));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("165.86.216.81"),

System.Net.IPAddress.Parse("245.137.206.18"),

System.Net.IPAddress.Parse("1.79.152.27"),

System.Net.IPAddress.Parse("96.224.29.188"),

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
                Assert.That(model.Id, Is.EqualTo(1204012623));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("36.58.5.135"),

System.Net.IPAddress.Parse("204.131.149.141"),

System.Net.IPAddress.Parse("34.164.207.185"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("226.180.138.138"),

System.Net.IPAddress.Parse("115.183.220.221"),

System.Net.IPAddress.Parse("112.123.153.54"),

System.Net.IPAddress.Parse("174.176.254.16"),

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
                Assert.That(model.Id, Is.EqualTo(1250031908));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("29.197.212.239"),

System.Net.IPAddress.Parse("69.253.159.51"),

System.Net.IPAddress.Parse("133.98.78.11"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1578563188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("120.2.76.27"),

System.Net.IPAddress.Parse("83.75.169.142"),

System.Net.IPAddress.Parse("104.84.35.5"),

System.Net.IPAddress.Parse("196.18.179.70"),

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
                Assert.That(model.Id, Is.EqualTo(1418534519));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("19.77.126.164"),

System.Net.IPAddress.Parse("165.103.55.104"),

System.Net.IPAddress.Parse("38.19.49.31"),

System.Net.IPAddress.Parse("83.6.206.81"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("144.244.130.29"),

System.Net.IPAddress.Parse("137.242.134.148"),

System.Net.IPAddress.Parse("231.169.48.185"),

System.Net.IPAddress.Parse("75.59.63.3"),

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
                Assert.That(model.Id, Is.EqualTo(1419166380));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("191.209.175.78"),

System.Net.IPAddress.Parse("180.73.250.86"),

System.Net.IPAddress.Parse("159.236.95.242"),

System.Net.IPAddress.Parse("228.237.150.193"),

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

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1421378455));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("77.64.81.188"),

System.Net.IPAddress.Parse("44.144.63.85"),

System.Net.IPAddress.Parse("208.163.44.211"),

System.Net.IPAddress.Parse("101.86.45.208"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(218881980));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("208.89.35.2"),

System.Net.IPAddress.Parse("2.14.156.67"),

System.Net.IPAddress.Parse("180.72.116.152"),

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
                Assert.That(model.Id, Is.EqualTo(1438534957));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("15.72.84.63"),

System.Net.IPAddress.Parse("42.139.165.220"),

System.Net.IPAddress.Parse("67.151.201.38"),

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

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1525861477));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("120.57.111.227"),

System.Net.IPAddress.Parse("67.16.249.162"),

System.Net.IPAddress.Parse("220.169.60.178"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237378685));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.181.180.192"),

System.Net.IPAddress.Parse("232.201.183.160"),

System.Net.IPAddress.Parse("128.78.180.105"),

System.Net.IPAddress.Parse("83.124.226.123"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("52.132.213.140"),

System.Net.IPAddress.Parse("97.62.253.66"),

System.Net.IPAddress.Parse("0.168.126.136"),

System.Net.IPAddress.Parse("191.235.71.132"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1560260232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.113.47.65"),

System.Net.IPAddress.Parse("205.48.45.20"),

System.Net.IPAddress.Parse("35.138.105.162"),

System.Net.IPAddress.Parse("222.77.163.247"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(797012636));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("62.173.14.133"),

System.Net.IPAddress.Parse("67.86.171.23"),

System.Net.IPAddress.Parse("160.65.160.234"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("181.105.46.223"),

System.Net.IPAddress.Parse("111.116.29.174"),

System.Net.IPAddress.Parse("28.117.6.147"),

System.Net.IPAddress.Parse("130.86.91.56"),

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
                Assert.That(model.Id, Is.EqualTo(1601022817));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("99.66.243.223"),

System.Net.IPAddress.Parse("203.91.144.163"),

System.Net.IPAddress.Parse("91.36.60.111"),

System.Net.IPAddress.Parse("217.167.44.30"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.179.183.203"),

System.Net.IPAddress.Parse("28.62.216.212"),

System.Net.IPAddress.Parse("236.24.81.156"),

System.Net.IPAddress.Parse("203.241.215.77"),

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
                Assert.That(model.Id, Is.EqualTo(1619643577));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("234.177.215.48"),

System.Net.IPAddress.Parse("37.193.37.208"),

System.Net.IPAddress.Parse("103.210.118.208"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("128.38.221.117"),

System.Net.IPAddress.Parse("170.184.57.90"),

System.Net.IPAddress.Parse("222.78.57.150"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2079482896));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("118.145.130.134"),

System.Net.IPAddress.Parse("168.145.47.246"),

System.Net.IPAddress.Parse("133.178.124.149"),

System.Net.IPAddress.Parse("205.208.209.69"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("206.4.8.189"),

System.Net.IPAddress.Parse("178.105.254.175"),

System.Net.IPAddress.Parse("32.108.100.214"),

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
                Assert.That(model.Id, Is.EqualTo(1626757037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.88.198.127"),

System.Net.IPAddress.Parse("74.81.157.228"),

System.Net.IPAddress.Parse("236.35.8.93"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1683706738));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.82.80.245"),

System.Net.IPAddress.Parse("232.116.79.125"),

System.Net.IPAddress.Parse("174.46.62.103"),

System.Net.IPAddress.Parse("60.126.156.24"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("13.109.69.5"),

System.Net.IPAddress.Parse("231.51.35.179"),

System.Net.IPAddress.Parse("108.70.229.199"),

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
                Assert.That(model.Id, Is.EqualTo(1638988125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("238.176.190.225"),

System.Net.IPAddress.Parse("176.217.220.171"),

System.Net.IPAddress.Parse("250.234.153.105"),

System.Net.IPAddress.Parse("120.141.97.84"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("27.167.12.59"),

System.Net.IPAddress.Parse("228.0.114.173"),

System.Net.IPAddress.Parse("84.92.209.93"),

System.Net.IPAddress.Parse("222.73.49.253"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(61017462));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("100.147.193.73"),

System.Net.IPAddress.Parse("233.233.33.9"),

System.Net.IPAddress.Parse("105.130.7.101"),

System.Net.IPAddress.Parse("44.177.139.252"),

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
                Assert.That(model.Id, Is.EqualTo(1756340245));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("150.75.94.98"),

System.Net.IPAddress.Parse("154.220.34.33"),

System.Net.IPAddress.Parse("142.176.194.74"),

System.Net.IPAddress.Parse("202.218.81.26"),

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

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1922739568));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("228.30.69.115"),

System.Net.IPAddress.Parse("47.141.103.161"),

System.Net.IPAddress.Parse("70.102.228.6"),

System.Net.IPAddress.Parse("254.191.71.128"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(703320384));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.195.51.129"),

System.Net.IPAddress.Parse("156.38.122.41"),

System.Net.IPAddress.Parse("48.90.16.224"),

System.Net.IPAddress.Parse("31.169.67.31"),

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
                Assert.That(model.Id, Is.EqualTo(2007192625));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("240.218.19.236"),

System.Net.IPAddress.Parse("230.32.225.58"),

System.Net.IPAddress.Parse("178.243.245.37"),

System.Net.IPAddress.Parse("214.115.0.243"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("230.17.30.20"),

System.Net.IPAddress.Parse("247.253.47.127"),

System.Net.IPAddress.Parse("141.148.99.217"),

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
                Assert.That(model.Id, Is.EqualTo(2040415786));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("215.22.201.81"),

System.Net.IPAddress.Parse("131.67.161.140"),

System.Net.IPAddress.Parse("49.58.33.156"),

System.Net.IPAddress.Parse("62.233.132.186"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("88.82.118.139"),

System.Net.IPAddress.Parse("123.16.198.74"),

System.Net.IPAddress.Parse("78.60.212.89"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052968544));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("12.206.107.84"),

System.Net.IPAddress.Parse("253.166.191.242"),

System.Net.IPAddress.Parse("20.12.62.55"),

System.Net.IPAddress.Parse("222.206.221.195"),

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
                Assert.That(model.Id, Is.EqualTo(2104615667));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("114.214.121.99"),

System.Net.IPAddress.Parse("189.139.10.2"),

System.Net.IPAddress.Parse("67.190.160.184"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(436734963));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.204.18.197"),

System.Net.IPAddress.Parse("251.64.78.104"),

System.Net.IPAddress.Parse("239.106.229.118"),

System.Net.IPAddress.Parse("102.155.103.38"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("160.35.180.101"),

System.Net.IPAddress.Parse("221.52.23.175"),

System.Net.IPAddress.Parse("217.105.180.102"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

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
                await foreach(var batchResult in ((IIPAddressListinetArray)this).DbConnectionSelectModelBatchAsync(connection, 1619643577, 257730448))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(7));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1626757037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.88.198.127"),

System.Net.IPAddress.Parse("74.81.157.228"),

System.Net.IPAddress.Parse("236.35.8.93"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1683706738));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.82.80.245"),

System.Net.IPAddress.Parse("232.116.79.125"),

System.Net.IPAddress.Parse("174.46.62.103"),

System.Net.IPAddress.Parse("60.126.156.24"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("13.109.69.5"),

System.Net.IPAddress.Parse("231.51.35.179"),

System.Net.IPAddress.Parse("108.70.229.199"),

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
                Assert.That(model.Id, Is.EqualTo(1638988125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("238.176.190.225"),

System.Net.IPAddress.Parse("176.217.220.171"),

System.Net.IPAddress.Parse("250.234.153.105"),

System.Net.IPAddress.Parse("120.141.97.84"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("27.167.12.59"),

System.Net.IPAddress.Parse("228.0.114.173"),

System.Net.IPAddress.Parse("84.92.209.93"),

System.Net.IPAddress.Parse("222.73.49.253"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(61017462));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("100.147.193.73"),

System.Net.IPAddress.Parse("233.233.33.9"),

System.Net.IPAddress.Parse("105.130.7.101"),

System.Net.IPAddress.Parse("44.177.139.252"),

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
                Assert.That(model.Id, Is.EqualTo(1756340245));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("150.75.94.98"),

System.Net.IPAddress.Parse("154.220.34.33"),

System.Net.IPAddress.Parse("142.176.194.74"),

System.Net.IPAddress.Parse("202.218.81.26"),

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

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1922739568));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("228.30.69.115"),

System.Net.IPAddress.Parse("47.141.103.161"),

System.Net.IPAddress.Parse("70.102.228.6"),

System.Net.IPAddress.Parse("254.191.71.128"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(703320384));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.195.51.129"),

System.Net.IPAddress.Parse("156.38.122.41"),

System.Net.IPAddress.Parse("48.90.16.224"),

System.Net.IPAddress.Parse("31.169.67.31"),

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
                Assert.That(model.Id, Is.EqualTo(2007192625));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("240.218.19.236"),

System.Net.IPAddress.Parse("230.32.225.58"),

System.Net.IPAddress.Parse("178.243.245.37"),

System.Net.IPAddress.Parse("214.115.0.243"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("230.17.30.20"),

System.Net.IPAddress.Parse("247.253.47.127"),

System.Net.IPAddress.Parse("141.148.99.217"),

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
                Assert.That(model.Id, Is.EqualTo(2040415786));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("215.22.201.81"),

System.Net.IPAddress.Parse("131.67.161.140"),

System.Net.IPAddress.Parse("49.58.33.156"),

System.Net.IPAddress.Parse("62.233.132.186"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("88.82.118.139"),

System.Net.IPAddress.Parse("123.16.198.74"),

System.Net.IPAddress.Parse("78.60.212.89"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052968544));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("12.206.107.84"),

System.Net.IPAddress.Parse("253.166.191.242"),

System.Net.IPAddress.Parse("20.12.62.55"),

System.Net.IPAddress.Parse("222.206.221.195"),

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
                Assert.That(model.Id, Is.EqualTo(2104615667));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("114.214.121.99"),

System.Net.IPAddress.Parse("189.139.10.2"),

System.Net.IPAddress.Parse("67.190.160.184"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(436734963));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.204.18.197"),

System.Net.IPAddress.Parse("251.64.78.104"),

System.Net.IPAddress.Parse("239.106.229.118"),

System.Net.IPAddress.Parse("102.155.103.38"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("160.35.180.101"),

System.Net.IPAddress.Parse("221.52.23.175"),

System.Net.IPAddress.Parse("217.105.180.102"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(26));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(319861696));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("161.57.84.109"),

System.Net.IPAddress.Parse("56.101.160.188"),

System.Net.IPAddress.Parse("48.177.91.150"),

System.Net.IPAddress.Parse("191.127.158.251"),

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

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(423054754));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("164.157.197.43"),

System.Net.IPAddress.Parse("130.23.54.205"),

System.Net.IPAddress.Parse("37.54.239.101"),

System.Net.IPAddress.Parse("73.12.19.35"),

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
                Assert.That(model.Id, Is.EqualTo(472717847));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("241.59.34.38"),

System.Net.IPAddress.Parse("130.204.76.173"),

System.Net.IPAddress.Parse("79.248.179.157"),

System.Net.IPAddress.Parse("188.41.127.62"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("156.13.97.202"),

System.Net.IPAddress.Parse("159.132.115.209"),

System.Net.IPAddress.Parse("175.21.56.20"),

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
                Assert.That(model.Id, Is.EqualTo(559278709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("3.86.229.33"),

System.Net.IPAddress.Parse("130.197.93.26"),

System.Net.IPAddress.Parse("72.250.135.43"),

System.Net.IPAddress.Parse("163.155.132.169"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("140.194.187.99"),

System.Net.IPAddress.Parse("118.102.89.142"),

System.Net.IPAddress.Parse("13.60.73.41"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(679149257));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("202.219.60.179"),

System.Net.IPAddress.Parse("187.5.225.114"),

System.Net.IPAddress.Parse("55.30.143.74"),

System.Net.IPAddress.Parse("196.204.74.213"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("9.159.202.96"),

System.Net.IPAddress.Parse("146.25.129.165"),

System.Net.IPAddress.Parse("176.4.79.145"),

System.Net.IPAddress.Parse("50.140.252.16"),

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
                Assert.That(model.Id, Is.EqualTo(847185137));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("98.15.82.204"),

System.Net.IPAddress.Parse("252.118.194.18"),

System.Net.IPAddress.Parse("140.28.233.210"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("200.247.194.13"),

System.Net.IPAddress.Parse("47.236.77.59"),

System.Net.IPAddress.Parse("101.230.108.169"),

System.Net.IPAddress.Parse("253.76.177.154"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(775413525));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("130.177.116.86"),

System.Net.IPAddress.Parse("138.151.82.18"),

System.Net.IPAddress.Parse("141.75.165.3"),

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
                Assert.That(model.Id, Is.EqualTo(851516451));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("114.58.46.141"),

System.Net.IPAddress.Parse("41.29.187.157"),

System.Net.IPAddress.Parse("18.58.207.208"),

System.Net.IPAddress.Parse("158.158.51.6"),

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
                Assert.That(model.Id, Is.EqualTo(858895777));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("159.237.35.54"),

System.Net.IPAddress.Parse("82.35.158.59"),

System.Net.IPAddress.Parse("151.16.199.130"),

System.Net.IPAddress.Parse("120.83.190.6"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("54.39.69.88"),

System.Net.IPAddress.Parse("111.223.164.184"),

System.Net.IPAddress.Parse("169.171.53.112"),

System.Net.IPAddress.Parse("67.158.242.122"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(493259895));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("81.113.197.138"),

System.Net.IPAddress.Parse("249.99.38.174"),

System.Net.IPAddress.Parse("165.188.246.116"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("21.66.153.109"),

System.Net.IPAddress.Parse("236.25.38.174"),

System.Net.IPAddress.Parse("58.17.218.250"),

System.Net.IPAddress.Parse("119.90.85.251"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(902976247));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.110.99.153"),

System.Net.IPAddress.Parse("106.34.132.127"),

System.Net.IPAddress.Parse("14.244.237.116"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("130.224.116.24"),

System.Net.IPAddress.Parse("22.224.44.21"),

System.Net.IPAddress.Parse("191.106.38.6"),

System.Net.IPAddress.Parse("38.34.145.29"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(592622261));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("252.208.123.189"),

System.Net.IPAddress.Parse("208.222.169.239"),

System.Net.IPAddress.Parse("197.116.246.21"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.242.139.170"),

System.Net.IPAddress.Parse("98.182.29.207"),

System.Net.IPAddress.Parse("128.85.70.118"),

System.Net.IPAddress.Parse("23.10.30.70"),

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
                Assert.That(model.Id, Is.EqualTo(981696302));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("41.213.89.173"),

System.Net.IPAddress.Parse("205.13.25.8"),

System.Net.IPAddress.Parse("2.201.212.105"),

System.Net.IPAddress.Parse("11.197.168.221"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("65.97.244.44"),

System.Net.IPAddress.Parse("140.204.33.168"),

System.Net.IPAddress.Parse("231.126.13.176"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1489277569));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("165.86.216.81"),

System.Net.IPAddress.Parse("245.137.206.18"),

System.Net.IPAddress.Parse("1.79.152.27"),

System.Net.IPAddress.Parse("96.224.29.188"),

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
                Assert.That(model.Id, Is.EqualTo(1204012623));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("36.58.5.135"),

System.Net.IPAddress.Parse("204.131.149.141"),

System.Net.IPAddress.Parse("34.164.207.185"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("226.180.138.138"),

System.Net.IPAddress.Parse("115.183.220.221"),

System.Net.IPAddress.Parse("112.123.153.54"),

System.Net.IPAddress.Parse("174.176.254.16"),

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
                Assert.That(model.Id, Is.EqualTo(1250031908));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("29.197.212.239"),

System.Net.IPAddress.Parse("69.253.159.51"),

System.Net.IPAddress.Parse("133.98.78.11"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1578563188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("120.2.76.27"),

System.Net.IPAddress.Parse("83.75.169.142"),

System.Net.IPAddress.Parse("104.84.35.5"),

System.Net.IPAddress.Parse("196.18.179.70"),

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
                Assert.That(model.Id, Is.EqualTo(1418534519));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("19.77.126.164"),

System.Net.IPAddress.Parse("165.103.55.104"),

System.Net.IPAddress.Parse("38.19.49.31"),

System.Net.IPAddress.Parse("83.6.206.81"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("144.244.130.29"),

System.Net.IPAddress.Parse("137.242.134.148"),

System.Net.IPAddress.Parse("231.169.48.185"),

System.Net.IPAddress.Parse("75.59.63.3"),

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
                Assert.That(model.Id, Is.EqualTo(1419166380));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("191.209.175.78"),

System.Net.IPAddress.Parse("180.73.250.86"),

System.Net.IPAddress.Parse("159.236.95.242"),

System.Net.IPAddress.Parse("228.237.150.193"),

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

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1421378455));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("77.64.81.188"),

System.Net.IPAddress.Parse("44.144.63.85"),

System.Net.IPAddress.Parse("208.163.44.211"),

System.Net.IPAddress.Parse("101.86.45.208"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(218881980));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("208.89.35.2"),

System.Net.IPAddress.Parse("2.14.156.67"),

System.Net.IPAddress.Parse("180.72.116.152"),

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

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1438534957));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("15.72.84.63"),

System.Net.IPAddress.Parse("42.139.165.220"),

System.Net.IPAddress.Parse("67.151.201.38"),

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
                Assert.That(model.Id, Is.EqualTo(1525861477));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("120.57.111.227"),

System.Net.IPAddress.Parse("67.16.249.162"),

System.Net.IPAddress.Parse("220.169.60.178"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237378685));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.181.180.192"),

System.Net.IPAddress.Parse("232.201.183.160"),

System.Net.IPAddress.Parse("128.78.180.105"),

System.Net.IPAddress.Parse("83.124.226.123"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("52.132.213.140"),

System.Net.IPAddress.Parse("97.62.253.66"),

System.Net.IPAddress.Parse("0.168.126.136"),

System.Net.IPAddress.Parse("191.235.71.132"),

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
                Assert.That(model.Id, Is.EqualTo(1560260232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.113.47.65"),

System.Net.IPAddress.Parse("205.48.45.20"),

System.Net.IPAddress.Parse("35.138.105.162"),

System.Net.IPAddress.Parse("222.77.163.247"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(797012636));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("62.173.14.133"),

System.Net.IPAddress.Parse("67.86.171.23"),

System.Net.IPAddress.Parse("160.65.160.234"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("181.105.46.223"),

System.Net.IPAddress.Parse("111.116.29.174"),

System.Net.IPAddress.Parse("28.117.6.147"),

System.Net.IPAddress.Parse("130.86.91.56"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1601022817));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("99.66.243.223"),

System.Net.IPAddress.Parse("203.91.144.163"),

System.Net.IPAddress.Parse("91.36.60.111"),

System.Net.IPAddress.Parse("217.167.44.30"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.179.183.203"),

System.Net.IPAddress.Parse("28.62.216.212"),

System.Net.IPAddress.Parse("236.24.81.156"),

System.Net.IPAddress.Parse("203.241.215.77"),

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
                Assert.That(model.Id, Is.EqualTo(1619643577));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("234.177.215.48"),

System.Net.IPAddress.Parse("37.193.37.208"),

System.Net.IPAddress.Parse("103.210.118.208"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("128.38.221.117"),

System.Net.IPAddress.Parse("170.184.57.90"),

System.Net.IPAddress.Parse("222.78.57.150"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2079482896));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("118.145.130.134"),

System.Net.IPAddress.Parse("168.145.47.246"),

System.Net.IPAddress.Parse("133.178.124.149"),

System.Net.IPAddress.Parse("205.208.209.69"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("206.4.8.189"),

System.Net.IPAddress.Parse("178.105.254.175"),

System.Net.IPAddress.Parse("32.108.100.214"),

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
                Assert.That(model.Id, Is.EqualTo(1626757037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.88.198.127"),

System.Net.IPAddress.Parse("74.81.157.228"),

System.Net.IPAddress.Parse("236.35.8.93"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1683706738));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.82.80.245"),

System.Net.IPAddress.Parse("232.116.79.125"),

System.Net.IPAddress.Parse("174.46.62.103"),

System.Net.IPAddress.Parse("60.126.156.24"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("13.109.69.5"),

System.Net.IPAddress.Parse("231.51.35.179"),

System.Net.IPAddress.Parse("108.70.229.199"),

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
                Assert.That(model.Id, Is.EqualTo(1638988125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("238.176.190.225"),

System.Net.IPAddress.Parse("176.217.220.171"),

System.Net.IPAddress.Parse("250.234.153.105"),

System.Net.IPAddress.Parse("120.141.97.84"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("27.167.12.59"),

System.Net.IPAddress.Parse("228.0.114.173"),

System.Net.IPAddress.Parse("84.92.209.93"),

System.Net.IPAddress.Parse("222.73.49.253"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(61017462));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("100.147.193.73"),

System.Net.IPAddress.Parse("233.233.33.9"),

System.Net.IPAddress.Parse("105.130.7.101"),

System.Net.IPAddress.Parse("44.177.139.252"),

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
                Assert.That(model.Id, Is.EqualTo(1756340245));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("150.75.94.98"),

System.Net.IPAddress.Parse("154.220.34.33"),

System.Net.IPAddress.Parse("142.176.194.74"),

System.Net.IPAddress.Parse("202.218.81.26"),

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
                Assert.That(model.Id, Is.EqualTo(1922739568));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("228.30.69.115"),

System.Net.IPAddress.Parse("47.141.103.161"),

System.Net.IPAddress.Parse("70.102.228.6"),

System.Net.IPAddress.Parse("254.191.71.128"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(703320384));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.195.51.129"),

System.Net.IPAddress.Parse("156.38.122.41"),

System.Net.IPAddress.Parse("48.90.16.224"),

System.Net.IPAddress.Parse("31.169.67.31"),

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

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2007192625));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("240.218.19.236"),

System.Net.IPAddress.Parse("230.32.225.58"),

System.Net.IPAddress.Parse("178.243.245.37"),

System.Net.IPAddress.Parse("214.115.0.243"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("230.17.30.20"),

System.Net.IPAddress.Parse("247.253.47.127"),

System.Net.IPAddress.Parse("141.148.99.217"),

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

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2040415786));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("215.22.201.81"),

System.Net.IPAddress.Parse("131.67.161.140"),

System.Net.IPAddress.Parse("49.58.33.156"),

System.Net.IPAddress.Parse("62.233.132.186"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("88.82.118.139"),

System.Net.IPAddress.Parse("123.16.198.74"),

System.Net.IPAddress.Parse("78.60.212.89"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052968544));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("12.206.107.84"),

System.Net.IPAddress.Parse("253.166.191.242"),

System.Net.IPAddress.Parse("20.12.62.55"),

System.Net.IPAddress.Parse("222.206.221.195"),

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
                Assert.That(model.Id, Is.EqualTo(2104615667));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("114.214.121.99"),

System.Net.IPAddress.Parse("189.139.10.2"),

System.Net.IPAddress.Parse("67.190.160.184"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(436734963));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.204.18.197"),

System.Net.IPAddress.Parse("251.64.78.104"),

System.Net.IPAddress.Parse("239.106.229.118"),

System.Net.IPAddress.Parse("102.155.103.38"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("160.35.180.101"),

System.Net.IPAddress.Parse("221.52.23.175"),

System.Net.IPAddress.Parse("217.105.180.102"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

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
COPY public.binary_ipaddressinetarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(IPAddressinetArray2MI),
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
FROM public.binary_ipaddressinetarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(IPAddressinetArray2MI),
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

                var importCollection = new List<IPAddressinetArray2MI>(7);

                importCollection.Add(
                new IPAddressinetArray2MI
                {
                    Id = 61017462,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("100.147.193.73"),

System.Net.IPAddress.Parse("233.233.33.9"),

System.Net.IPAddress.Parse("105.130.7.101"),

System.Net.IPAddress.Parse("44.177.139.252"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinetArray2MI
                {
                    Id = 218881980,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("208.89.35.2"),

System.Net.IPAddress.Parse("2.14.156.67"),

System.Net.IPAddress.Parse("180.72.116.152"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinetArray2MI
                {
                    Id = 436734963,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.204.18.197"),

System.Net.IPAddress.Parse("251.64.78.104"),

System.Net.IPAddress.Parse("239.106.229.118"),

System.Net.IPAddress.Parse("102.155.103.38"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("160.35.180.101"),

System.Net.IPAddress.Parse("221.52.23.175"),

System.Net.IPAddress.Parse("217.105.180.102"),

}
                });

                importCollection.Add(
                new IPAddressinetArray2MI
                {
                    Id = 493259895,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("81.113.197.138"),

System.Net.IPAddress.Parse("249.99.38.174"),

System.Net.IPAddress.Parse("165.188.246.116"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("21.66.153.109"),

System.Net.IPAddress.Parse("236.25.38.174"),

System.Net.IPAddress.Parse("58.17.218.250"),

System.Net.IPAddress.Parse("119.90.85.251"),

}
                });

                importCollection.Add(
                new IPAddressinetArray2MI
                {
                    Id = 592622261,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("252.208.123.189"),

System.Net.IPAddress.Parse("208.222.169.239"),

System.Net.IPAddress.Parse("197.116.246.21"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.242.139.170"),

System.Net.IPAddress.Parse("98.182.29.207"),

System.Net.IPAddress.Parse("128.85.70.118"),

System.Net.IPAddress.Parse("23.10.30.70"),

}
                });

                importCollection.Add(
                new IPAddressinetArray2MI
                {
                    Id = 679149257,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("202.219.60.179"),

System.Net.IPAddress.Parse("187.5.225.114"),

System.Net.IPAddress.Parse("55.30.143.74"),

System.Net.IPAddress.Parse("196.204.74.213"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("9.159.202.96"),

System.Net.IPAddress.Parse("146.25.129.165"),

System.Net.IPAddress.Parse("176.4.79.145"),

System.Net.IPAddress.Parse("50.140.252.16"),

}
                });

                importCollection.Add(
                new IPAddressinetArray2MI
                {
                    Id = 703320384,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.195.51.129"),

System.Net.IPAddress.Parse("156.38.122.41"),

System.Net.IPAddress.Parse("48.90.16.224"),

System.Net.IPAddress.Parse("31.169.67.31"),

},
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(61017462));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("100.147.193.73"),

System.Net.IPAddress.Parse("233.233.33.9"),

System.Net.IPAddress.Parse("105.130.7.101"),

System.Net.IPAddress.Parse("44.177.139.252"),

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
                Assert.That(model.Id, Is.EqualTo(218881980));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("208.89.35.2"),

System.Net.IPAddress.Parse("2.14.156.67"),

System.Net.IPAddress.Parse("180.72.116.152"),

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
                Assert.That(model.Id, Is.EqualTo(436734963));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.204.18.197"),

System.Net.IPAddress.Parse("251.64.78.104"),

System.Net.IPAddress.Parse("239.106.229.118"),

System.Net.IPAddress.Parse("102.155.103.38"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("160.35.180.101"),

System.Net.IPAddress.Parse("221.52.23.175"),

System.Net.IPAddress.Parse("217.105.180.102"),

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
                Assert.That(model.Id, Is.EqualTo(493259895));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("81.113.197.138"),

System.Net.IPAddress.Parse("249.99.38.174"),

System.Net.IPAddress.Parse("165.188.246.116"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("21.66.153.109"),

System.Net.IPAddress.Parse("236.25.38.174"),

System.Net.IPAddress.Parse("58.17.218.250"),

System.Net.IPAddress.Parse("119.90.85.251"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(592622261));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("252.208.123.189"),

System.Net.IPAddress.Parse("208.222.169.239"),

System.Net.IPAddress.Parse("197.116.246.21"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.242.139.170"),

System.Net.IPAddress.Parse("98.182.29.207"),

System.Net.IPAddress.Parse("128.85.70.118"),

System.Net.IPAddress.Parse("23.10.30.70"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(679149257));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("202.219.60.179"),

System.Net.IPAddress.Parse("187.5.225.114"),

System.Net.IPAddress.Parse("55.30.143.74"),

System.Net.IPAddress.Parse("196.204.74.213"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("9.159.202.96"),

System.Net.IPAddress.Parse("146.25.129.165"),

System.Net.IPAddress.Parse("176.4.79.145"),

System.Net.IPAddress.Parse("50.140.252.16"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(703320384));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.195.51.129"),

System.Net.IPAddress.Parse("156.38.122.41"),

System.Net.IPAddress.Parse("48.90.16.224"),

System.Net.IPAddress.Parse("31.169.67.31"),

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

                importCollection.Clear();

                importCollection.Add(
                new IPAddressinetArray2MI
                {
                    Id = 775413525,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("130.177.116.86"),

System.Net.IPAddress.Parse("138.151.82.18"),

System.Net.IPAddress.Parse("141.75.165.3"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinetArray2MI
                {
                    Id = 797012636,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("62.173.14.133"),

System.Net.IPAddress.Parse("67.86.171.23"),

System.Net.IPAddress.Parse("160.65.160.234"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("181.105.46.223"),

System.Net.IPAddress.Parse("111.116.29.174"),

System.Net.IPAddress.Parse("28.117.6.147"),

System.Net.IPAddress.Parse("130.86.91.56"),

}
                });

                importCollection.Add(
                new IPAddressinetArray2MI
                {
                    Id = 1052968544,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("12.206.107.84"),

System.Net.IPAddress.Parse("253.166.191.242"),

System.Net.IPAddress.Parse("20.12.62.55"),

System.Net.IPAddress.Parse("222.206.221.195"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinetArray2MI
                {
                    Id = 1237378685,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.181.180.192"),

System.Net.IPAddress.Parse("232.201.183.160"),

System.Net.IPAddress.Parse("128.78.180.105"),

System.Net.IPAddress.Parse("83.124.226.123"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("52.132.213.140"),

System.Net.IPAddress.Parse("97.62.253.66"),

System.Net.IPAddress.Parse("0.168.126.136"),

System.Net.IPAddress.Parse("191.235.71.132"),

}
                });

                importCollection.Add(
                new IPAddressinetArray2MI
                {
                    Id = 1489277569,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("165.86.216.81"),

System.Net.IPAddress.Parse("245.137.206.18"),

System.Net.IPAddress.Parse("1.79.152.27"),

System.Net.IPAddress.Parse("96.224.29.188"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinetArray2MI
                {
                    Id = 1578563188,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("120.2.76.27"),

System.Net.IPAddress.Parse("83.75.169.142"),

System.Net.IPAddress.Parse("104.84.35.5"),

System.Net.IPAddress.Parse("196.18.179.70"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinetArray2MI
                {
                    Id = 1683706738,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.82.80.245"),

System.Net.IPAddress.Parse("232.116.79.125"),

System.Net.IPAddress.Parse("174.46.62.103"),

System.Net.IPAddress.Parse("60.126.156.24"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("13.109.69.5"),

System.Net.IPAddress.Parse("231.51.35.179"),

System.Net.IPAddress.Parse("108.70.229.199"),

}
                });

                importCollection.Add(
                new IPAddressinetArray2MI
                {
                    Id = 2079482896,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("118.145.130.134"),

System.Net.IPAddress.Parse("168.145.47.246"),

System.Net.IPAddress.Parse("133.178.124.149"),

System.Net.IPAddress.Parse("205.208.209.69"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("206.4.8.189"),

System.Net.IPAddress.Parse("178.105.254.175"),

System.Net.IPAddress.Parse("32.108.100.214"),

}
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(61017462));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("100.147.193.73"),

System.Net.IPAddress.Parse("233.233.33.9"),

System.Net.IPAddress.Parse("105.130.7.101"),

System.Net.IPAddress.Parse("44.177.139.252"),

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
                Assert.That(model.Id, Is.EqualTo(218881980));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("208.89.35.2"),

System.Net.IPAddress.Parse("2.14.156.67"),

System.Net.IPAddress.Parse("180.72.116.152"),

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
                Assert.That(model.Id, Is.EqualTo(436734963));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.204.18.197"),

System.Net.IPAddress.Parse("251.64.78.104"),

System.Net.IPAddress.Parse("239.106.229.118"),

System.Net.IPAddress.Parse("102.155.103.38"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("160.35.180.101"),

System.Net.IPAddress.Parse("221.52.23.175"),

System.Net.IPAddress.Parse("217.105.180.102"),

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
                Assert.That(model.Id, Is.EqualTo(493259895));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("81.113.197.138"),

System.Net.IPAddress.Parse("249.99.38.174"),

System.Net.IPAddress.Parse("165.188.246.116"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("21.66.153.109"),

System.Net.IPAddress.Parse("236.25.38.174"),

System.Net.IPAddress.Parse("58.17.218.250"),

System.Net.IPAddress.Parse("119.90.85.251"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(592622261));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("252.208.123.189"),

System.Net.IPAddress.Parse("208.222.169.239"),

System.Net.IPAddress.Parse("197.116.246.21"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.242.139.170"),

System.Net.IPAddress.Parse("98.182.29.207"),

System.Net.IPAddress.Parse("128.85.70.118"),

System.Net.IPAddress.Parse("23.10.30.70"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(679149257));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("202.219.60.179"),

System.Net.IPAddress.Parse("187.5.225.114"),

System.Net.IPAddress.Parse("55.30.143.74"),

System.Net.IPAddress.Parse("196.204.74.213"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("9.159.202.96"),

System.Net.IPAddress.Parse("146.25.129.165"),

System.Net.IPAddress.Parse("176.4.79.145"),

System.Net.IPAddress.Parse("50.140.252.16"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(703320384));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.195.51.129"),

System.Net.IPAddress.Parse("156.38.122.41"),

System.Net.IPAddress.Parse("48.90.16.224"),

System.Net.IPAddress.Parse("31.169.67.31"),

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


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(775413525));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("130.177.116.86"),

System.Net.IPAddress.Parse("138.151.82.18"),

System.Net.IPAddress.Parse("141.75.165.3"),

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


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797012636));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("62.173.14.133"),

System.Net.IPAddress.Parse("67.86.171.23"),

System.Net.IPAddress.Parse("160.65.160.234"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("181.105.46.223"),

System.Net.IPAddress.Parse("111.116.29.174"),

System.Net.IPAddress.Parse("28.117.6.147"),

System.Net.IPAddress.Parse("130.86.91.56"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1052968544));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("12.206.107.84"),

System.Net.IPAddress.Parse("253.166.191.242"),

System.Net.IPAddress.Parse("20.12.62.55"),

System.Net.IPAddress.Parse("222.206.221.195"),

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


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1237378685));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.181.180.192"),

System.Net.IPAddress.Parse("232.201.183.160"),

System.Net.IPAddress.Parse("128.78.180.105"),

System.Net.IPAddress.Parse("83.124.226.123"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("52.132.213.140"),

System.Net.IPAddress.Parse("97.62.253.66"),

System.Net.IPAddress.Parse("0.168.126.136"),

System.Net.IPAddress.Parse("191.235.71.132"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1489277569));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("165.86.216.81"),

System.Net.IPAddress.Parse("245.137.206.18"),

System.Net.IPAddress.Parse("1.79.152.27"),

System.Net.IPAddress.Parse("96.224.29.188"),

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
                Assert.That(model.Id, Is.EqualTo(1578563188));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("120.2.76.27"),

System.Net.IPAddress.Parse("83.75.169.142"),

System.Net.IPAddress.Parse("104.84.35.5"),

System.Net.IPAddress.Parse("196.18.179.70"),

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


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683706738));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.82.80.245"),

System.Net.IPAddress.Parse("232.116.79.125"),

System.Net.IPAddress.Parse("174.46.62.103"),

System.Net.IPAddress.Parse("60.126.156.24"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("13.109.69.5"),

System.Net.IPAddress.Parse("231.51.35.179"),

System.Net.IPAddress.Parse("108.70.229.199"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079482896));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("118.145.130.134"),

System.Net.IPAddress.Parse("168.145.47.246"),

System.Net.IPAddress.Parse("133.178.124.149"),

System.Net.IPAddress.Parse("205.208.209.69"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("206.4.8.189"),

System.Net.IPAddress.Parse("178.105.254.175"),

System.Net.IPAddress.Parse("32.108.100.214"),

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
COPY public.binary_ipaddressinetarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
ipaddressinetarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(IPAddressinetArray2M),
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
FROM public.binary_ipaddressinetarray2m m
LEFT JOIN public.binary_ipaddressinetarray2mi mi ON mi.id = m.ipaddressinetarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(IPAddressinetArray2M),
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

                var importCollection = new List<IPAddressinetArray2M>(15);

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 53114524,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("159.183.238.80"),

System.Net.IPAddress.Parse("47.218.200.218"),

System.Net.IPAddress.Parse("195.155.174.179"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 176088676,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("231.154.164.129"),

System.Net.IPAddress.Parse("120.253.84.87"),

System.Net.IPAddress.Parse("212.65.4.68"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 240216224,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("229.179.159.9"),

System.Net.IPAddress.Parse("127.52.178.185"),

System.Net.IPAddress.Parse("91.100.65.63"),

System.Net.IPAddress.Parse("50.192.76.61"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 257730448,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("119.15.65.137"),

System.Net.IPAddress.Parse("245.182.223.243"),

System.Net.IPAddress.Parse("244.136.201.23"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("83.62.100.46"),

System.Net.IPAddress.Parse("120.87.237.84"),

System.Net.IPAddress.Parse("223.162.60.65"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 319861696,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("161.57.84.109"),

System.Net.IPAddress.Parse("56.101.160.188"),

System.Net.IPAddress.Parse("48.177.91.150"),

System.Net.IPAddress.Parse("191.127.158.251"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 423054754,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("164.157.197.43"),

System.Net.IPAddress.Parse("130.23.54.205"),

System.Net.IPAddress.Parse("37.54.239.101"),

System.Net.IPAddress.Parse("73.12.19.35"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 472717847,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("241.59.34.38"),

System.Net.IPAddress.Parse("130.204.76.173"),

System.Net.IPAddress.Parse("79.248.179.157"),

System.Net.IPAddress.Parse("188.41.127.62"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("156.13.97.202"),

System.Net.IPAddress.Parse("159.132.115.209"),

System.Net.IPAddress.Parse("175.21.56.20"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 559278709,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("3.86.229.33"),

System.Net.IPAddress.Parse("130.197.93.26"),

System.Net.IPAddress.Parse("72.250.135.43"),

System.Net.IPAddress.Parse("163.155.132.169"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("140.194.187.99"),

System.Net.IPAddress.Parse("118.102.89.142"),

System.Net.IPAddress.Parse("13.60.73.41"),

},

                    ModelInner = new IPAddressinetArray2MI 
                    {
                        Id = 679149257
                    }

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 847185137,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("98.15.82.204"),

System.Net.IPAddress.Parse("252.118.194.18"),

System.Net.IPAddress.Parse("140.28.233.210"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("200.247.194.13"),

System.Net.IPAddress.Parse("47.236.77.59"),

System.Net.IPAddress.Parse("101.230.108.169"),

System.Net.IPAddress.Parse("253.76.177.154"),

},

                    ModelInner = new IPAddressinetArray2MI 
                    {
                        Id = 775413525
                    }

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 851516451,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("114.58.46.141"),

System.Net.IPAddress.Parse("41.29.187.157"),

System.Net.IPAddress.Parse("18.58.207.208"),

System.Net.IPAddress.Parse("158.158.51.6"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 858895777,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("159.237.35.54"),

System.Net.IPAddress.Parse("82.35.158.59"),

System.Net.IPAddress.Parse("151.16.199.130"),

System.Net.IPAddress.Parse("120.83.190.6"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("54.39.69.88"),

System.Net.IPAddress.Parse("111.223.164.184"),

System.Net.IPAddress.Parse("169.171.53.112"),

System.Net.IPAddress.Parse("67.158.242.122"),

},

                    ModelInner = new IPAddressinetArray2MI 
                    {
                        Id = 493259895
                    }

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 902976247,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.110.99.153"),

System.Net.IPAddress.Parse("106.34.132.127"),

System.Net.IPAddress.Parse("14.244.237.116"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("130.224.116.24"),

System.Net.IPAddress.Parse("22.224.44.21"),

System.Net.IPAddress.Parse("191.106.38.6"),

System.Net.IPAddress.Parse("38.34.145.29"),

},

                    ModelInner = new IPAddressinetArray2MI 
                    {
                        Id = 592622261
                    }

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 981696302,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("41.213.89.173"),

System.Net.IPAddress.Parse("205.13.25.8"),

System.Net.IPAddress.Parse("2.201.212.105"),

System.Net.IPAddress.Parse("11.197.168.221"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("65.97.244.44"),

System.Net.IPAddress.Parse("140.204.33.168"),

System.Net.IPAddress.Parse("231.126.13.176"),

},

                    ModelInner = new IPAddressinetArray2MI 
                    {
                        Id = 1489277569
                    }

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 1204012623,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("36.58.5.135"),

System.Net.IPAddress.Parse("204.131.149.141"),

System.Net.IPAddress.Parse("34.164.207.185"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("226.180.138.138"),

System.Net.IPAddress.Parse("115.183.220.221"),

System.Net.IPAddress.Parse("112.123.153.54"),

System.Net.IPAddress.Parse("174.176.254.16"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 1250031908,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("29.197.212.239"),

System.Net.IPAddress.Parse("69.253.159.51"),

System.Net.IPAddress.Parse("133.98.78.11"),

},
                    NullableValue = null,

                    ModelInner = new IPAddressinetArray2MI 
                    {
                        Id = 1578563188
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53114524));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("159.183.238.80"),

System.Net.IPAddress.Parse("47.218.200.218"),

System.Net.IPAddress.Parse("195.155.174.179"),

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

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(176088676));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("231.154.164.129"),

System.Net.IPAddress.Parse("120.253.84.87"),

System.Net.IPAddress.Parse("212.65.4.68"),

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
                Assert.That(model.Id, Is.EqualTo(240216224));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("229.179.159.9"),

System.Net.IPAddress.Parse("127.52.178.185"),

System.Net.IPAddress.Parse("91.100.65.63"),

System.Net.IPAddress.Parse("50.192.76.61"),

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

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(257730448));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("119.15.65.137"),

System.Net.IPAddress.Parse("245.182.223.243"),

System.Net.IPAddress.Parse("244.136.201.23"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("83.62.100.46"),

System.Net.IPAddress.Parse("120.87.237.84"),

System.Net.IPAddress.Parse("223.162.60.65"),

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
                Assert.That(model.Id, Is.EqualTo(319861696));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("161.57.84.109"),

System.Net.IPAddress.Parse("56.101.160.188"),

System.Net.IPAddress.Parse("48.177.91.150"),

System.Net.IPAddress.Parse("191.127.158.251"),

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
                Assert.That(model.Id, Is.EqualTo(423054754));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("164.157.197.43"),

System.Net.IPAddress.Parse("130.23.54.205"),

System.Net.IPAddress.Parse("37.54.239.101"),

System.Net.IPAddress.Parse("73.12.19.35"),

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
                Assert.That(model.Id, Is.EqualTo(472717847));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("241.59.34.38"),

System.Net.IPAddress.Parse("130.204.76.173"),

System.Net.IPAddress.Parse("79.248.179.157"),

System.Net.IPAddress.Parse("188.41.127.62"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("156.13.97.202"),

System.Net.IPAddress.Parse("159.132.115.209"),

System.Net.IPAddress.Parse("175.21.56.20"),

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

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(559278709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("3.86.229.33"),

System.Net.IPAddress.Parse("130.197.93.26"),

System.Net.IPAddress.Parse("72.250.135.43"),

System.Net.IPAddress.Parse("163.155.132.169"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("140.194.187.99"),

System.Net.IPAddress.Parse("118.102.89.142"),

System.Net.IPAddress.Parse("13.60.73.41"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(679149257));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("202.219.60.179"),

System.Net.IPAddress.Parse("187.5.225.114"),

System.Net.IPAddress.Parse("55.30.143.74"),

System.Net.IPAddress.Parse("196.204.74.213"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("9.159.202.96"),

System.Net.IPAddress.Parse("146.25.129.165"),

System.Net.IPAddress.Parse("176.4.79.145"),

System.Net.IPAddress.Parse("50.140.252.16"),

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
                Assert.That(model.Id, Is.EqualTo(847185137));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("98.15.82.204"),

System.Net.IPAddress.Parse("252.118.194.18"),

System.Net.IPAddress.Parse("140.28.233.210"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("200.247.194.13"),

System.Net.IPAddress.Parse("47.236.77.59"),

System.Net.IPAddress.Parse("101.230.108.169"),

System.Net.IPAddress.Parse("253.76.177.154"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(775413525));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("130.177.116.86"),

System.Net.IPAddress.Parse("138.151.82.18"),

System.Net.IPAddress.Parse("141.75.165.3"),

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
                Assert.That(model.Id, Is.EqualTo(851516451));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("114.58.46.141"),

System.Net.IPAddress.Parse("41.29.187.157"),

System.Net.IPAddress.Parse("18.58.207.208"),

System.Net.IPAddress.Parse("158.158.51.6"),

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

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(858895777));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("159.237.35.54"),

System.Net.IPAddress.Parse("82.35.158.59"),

System.Net.IPAddress.Parse("151.16.199.130"),

System.Net.IPAddress.Parse("120.83.190.6"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("54.39.69.88"),

System.Net.IPAddress.Parse("111.223.164.184"),

System.Net.IPAddress.Parse("169.171.53.112"),

System.Net.IPAddress.Parse("67.158.242.122"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(493259895));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("81.113.197.138"),

System.Net.IPAddress.Parse("249.99.38.174"),

System.Net.IPAddress.Parse("165.188.246.116"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("21.66.153.109"),

System.Net.IPAddress.Parse("236.25.38.174"),

System.Net.IPAddress.Parse("58.17.218.250"),

System.Net.IPAddress.Parse("119.90.85.251"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(902976247));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.110.99.153"),

System.Net.IPAddress.Parse("106.34.132.127"),

System.Net.IPAddress.Parse("14.244.237.116"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("130.224.116.24"),

System.Net.IPAddress.Parse("22.224.44.21"),

System.Net.IPAddress.Parse("191.106.38.6"),

System.Net.IPAddress.Parse("38.34.145.29"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(592622261));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("252.208.123.189"),

System.Net.IPAddress.Parse("208.222.169.239"),

System.Net.IPAddress.Parse("197.116.246.21"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.242.139.170"),

System.Net.IPAddress.Parse("98.182.29.207"),

System.Net.IPAddress.Parse("128.85.70.118"),

System.Net.IPAddress.Parse("23.10.30.70"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981696302));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("41.213.89.173"),

System.Net.IPAddress.Parse("205.13.25.8"),

System.Net.IPAddress.Parse("2.201.212.105"),

System.Net.IPAddress.Parse("11.197.168.221"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("65.97.244.44"),

System.Net.IPAddress.Parse("140.204.33.168"),

System.Net.IPAddress.Parse("231.126.13.176"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1489277569));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("165.86.216.81"),

System.Net.IPAddress.Parse("245.137.206.18"),

System.Net.IPAddress.Parse("1.79.152.27"),

System.Net.IPAddress.Parse("96.224.29.188"),

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
                Assert.That(model.Id, Is.EqualTo(1204012623));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("36.58.5.135"),

System.Net.IPAddress.Parse("204.131.149.141"),

System.Net.IPAddress.Parse("34.164.207.185"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("226.180.138.138"),

System.Net.IPAddress.Parse("115.183.220.221"),

System.Net.IPAddress.Parse("112.123.153.54"),

System.Net.IPAddress.Parse("174.176.254.16"),

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
                Assert.That(model.Id, Is.EqualTo(1250031908));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("29.197.212.239"),

System.Net.IPAddress.Parse("69.253.159.51"),

System.Net.IPAddress.Parse("133.98.78.11"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1578563188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("120.2.76.27"),

System.Net.IPAddress.Parse("83.75.169.142"),

System.Net.IPAddress.Parse("104.84.35.5"),

System.Net.IPAddress.Parse("196.18.179.70"),

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

                importCollection.Clear();

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 1418534519,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("19.77.126.164"),

System.Net.IPAddress.Parse("165.103.55.104"),

System.Net.IPAddress.Parse("38.19.49.31"),

System.Net.IPAddress.Parse("83.6.206.81"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("144.244.130.29"),

System.Net.IPAddress.Parse("137.242.134.148"),

System.Net.IPAddress.Parse("231.169.48.185"),

System.Net.IPAddress.Parse("75.59.63.3"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 1419166380,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("191.209.175.78"),

System.Net.IPAddress.Parse("180.73.250.86"),

System.Net.IPAddress.Parse("159.236.95.242"),

System.Net.IPAddress.Parse("228.237.150.193"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 1421378455,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("77.64.81.188"),

System.Net.IPAddress.Parse("44.144.63.85"),

System.Net.IPAddress.Parse("208.163.44.211"),

System.Net.IPAddress.Parse("101.86.45.208"),

},
                    NullableValue = null,

                    ModelInner = new IPAddressinetArray2MI 
                    {
                        Id = 218881980
                    }

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 1438534957,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("15.72.84.63"),

System.Net.IPAddress.Parse("42.139.165.220"),

System.Net.IPAddress.Parse("67.151.201.38"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 1525861477,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("120.57.111.227"),

System.Net.IPAddress.Parse("67.16.249.162"),

System.Net.IPAddress.Parse("220.169.60.178"),

},
                    NullableValue = null,

                    ModelInner = new IPAddressinetArray2MI 
                    {
                        Id = 1237378685
                    }

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 1560260232,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.113.47.65"),

System.Net.IPAddress.Parse("205.48.45.20"),

System.Net.IPAddress.Parse("35.138.105.162"),

System.Net.IPAddress.Parse("222.77.163.247"),

},
                    NullableValue = null,

                    ModelInner = new IPAddressinetArray2MI 
                    {
                        Id = 797012636
                    }

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 1601022817,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("99.66.243.223"),

System.Net.IPAddress.Parse("203.91.144.163"),

System.Net.IPAddress.Parse("91.36.60.111"),

System.Net.IPAddress.Parse("217.167.44.30"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.179.183.203"),

System.Net.IPAddress.Parse("28.62.216.212"),

System.Net.IPAddress.Parse("236.24.81.156"),

System.Net.IPAddress.Parse("203.241.215.77"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 1619643577,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("234.177.215.48"),

System.Net.IPAddress.Parse("37.193.37.208"),

System.Net.IPAddress.Parse("103.210.118.208"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("128.38.221.117"),

System.Net.IPAddress.Parse("170.184.57.90"),

System.Net.IPAddress.Parse("222.78.57.150"),

},

                    ModelInner = new IPAddressinetArray2MI 
                    {
                        Id = 2079482896
                    }

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 1626757037,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.88.198.127"),

System.Net.IPAddress.Parse("74.81.157.228"),

System.Net.IPAddress.Parse("236.35.8.93"),

},
                    NullableValue = null,

                    ModelInner = new IPAddressinetArray2MI 
                    {
                        Id = 1683706738
                    }

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 1638988125,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("238.176.190.225"),

System.Net.IPAddress.Parse("176.217.220.171"),

System.Net.IPAddress.Parse("250.234.153.105"),

System.Net.IPAddress.Parse("120.141.97.84"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("27.167.12.59"),

System.Net.IPAddress.Parse("228.0.114.173"),

System.Net.IPAddress.Parse("84.92.209.93"),

System.Net.IPAddress.Parse("222.73.49.253"),

},

                    ModelInner = new IPAddressinetArray2MI 
                    {
                        Id = 61017462
                    }

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 1756340245,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("150.75.94.98"),

System.Net.IPAddress.Parse("154.220.34.33"),

System.Net.IPAddress.Parse("142.176.194.74"),

System.Net.IPAddress.Parse("202.218.81.26"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 1922739568,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("228.30.69.115"),

System.Net.IPAddress.Parse("47.141.103.161"),

System.Net.IPAddress.Parse("70.102.228.6"),

System.Net.IPAddress.Parse("254.191.71.128"),

},
                    NullableValue = null,

                    ModelInner = new IPAddressinetArray2MI 
                    {
                        Id = 703320384
                    }

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 2007192625,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("240.218.19.236"),

System.Net.IPAddress.Parse("230.32.225.58"),

System.Net.IPAddress.Parse("178.243.245.37"),

System.Net.IPAddress.Parse("214.115.0.243"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("230.17.30.20"),

System.Net.IPAddress.Parse("247.253.47.127"),

System.Net.IPAddress.Parse("141.148.99.217"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 2040415786,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("215.22.201.81"),

System.Net.IPAddress.Parse("131.67.161.140"),

System.Net.IPAddress.Parse("49.58.33.156"),

System.Net.IPAddress.Parse("62.233.132.186"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("88.82.118.139"),

System.Net.IPAddress.Parse("123.16.198.74"),

System.Net.IPAddress.Parse("78.60.212.89"),

},

                    ModelInner = new IPAddressinetArray2MI 
                    {
                        Id = 1052968544
                    }

                });

                importCollection.Add(
                new IPAddressinetArray2M
                {
                    Id = 2104615667,
                    Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("114.214.121.99"),

System.Net.IPAddress.Parse("189.139.10.2"),

System.Net.IPAddress.Parse("67.190.160.184"),

},
                    NullableValue = null,

                    ModelInner = new IPAddressinetArray2MI 
                    {
                        Id = 436734963
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53114524));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("159.183.238.80"),

System.Net.IPAddress.Parse("47.218.200.218"),

System.Net.IPAddress.Parse("195.155.174.179"),

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


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(176088676));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("231.154.164.129"),

System.Net.IPAddress.Parse("120.253.84.87"),

System.Net.IPAddress.Parse("212.65.4.68"),

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
                Assert.That(model.Id, Is.EqualTo(240216224));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("229.179.159.9"),

System.Net.IPAddress.Parse("127.52.178.185"),

System.Net.IPAddress.Parse("91.100.65.63"),

System.Net.IPAddress.Parse("50.192.76.61"),

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


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(257730448));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("119.15.65.137"),

System.Net.IPAddress.Parse("245.182.223.243"),

System.Net.IPAddress.Parse("244.136.201.23"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("83.62.100.46"),

System.Net.IPAddress.Parse("120.87.237.84"),

System.Net.IPAddress.Parse("223.162.60.65"),

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
                Assert.That(model.Id, Is.EqualTo(319861696));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("161.57.84.109"),

System.Net.IPAddress.Parse("56.101.160.188"),

System.Net.IPAddress.Parse("48.177.91.150"),

System.Net.IPAddress.Parse("191.127.158.251"),

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
                Assert.That(model.Id, Is.EqualTo(423054754));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("164.157.197.43"),

System.Net.IPAddress.Parse("130.23.54.205"),

System.Net.IPAddress.Parse("37.54.239.101"),

System.Net.IPAddress.Parse("73.12.19.35"),

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
                Assert.That(model.Id, Is.EqualTo(472717847));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("241.59.34.38"),

System.Net.IPAddress.Parse("130.204.76.173"),

System.Net.IPAddress.Parse("79.248.179.157"),

System.Net.IPAddress.Parse("188.41.127.62"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("156.13.97.202"),

System.Net.IPAddress.Parse("159.132.115.209"),

System.Net.IPAddress.Parse("175.21.56.20"),

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


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(559278709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("3.86.229.33"),

System.Net.IPAddress.Parse("130.197.93.26"),

System.Net.IPAddress.Parse("72.250.135.43"),

System.Net.IPAddress.Parse("163.155.132.169"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("140.194.187.99"),

System.Net.IPAddress.Parse("118.102.89.142"),

System.Net.IPAddress.Parse("13.60.73.41"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(679149257));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("202.219.60.179"),

System.Net.IPAddress.Parse("187.5.225.114"),

System.Net.IPAddress.Parse("55.30.143.74"),

System.Net.IPAddress.Parse("196.204.74.213"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("9.159.202.96"),

System.Net.IPAddress.Parse("146.25.129.165"),

System.Net.IPAddress.Parse("176.4.79.145"),

System.Net.IPAddress.Parse("50.140.252.16"),

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
                Assert.That(model.Id, Is.EqualTo(847185137));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("98.15.82.204"),

System.Net.IPAddress.Parse("252.118.194.18"),

System.Net.IPAddress.Parse("140.28.233.210"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("200.247.194.13"),

System.Net.IPAddress.Parse("47.236.77.59"),

System.Net.IPAddress.Parse("101.230.108.169"),

System.Net.IPAddress.Parse("253.76.177.154"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(775413525));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("130.177.116.86"),

System.Net.IPAddress.Parse("138.151.82.18"),

System.Net.IPAddress.Parse("141.75.165.3"),

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
                Assert.That(model.Id, Is.EqualTo(851516451));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("114.58.46.141"),

System.Net.IPAddress.Parse("41.29.187.157"),

System.Net.IPAddress.Parse("18.58.207.208"),

System.Net.IPAddress.Parse("158.158.51.6"),

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


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(858895777));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("159.237.35.54"),

System.Net.IPAddress.Parse("82.35.158.59"),

System.Net.IPAddress.Parse("151.16.199.130"),

System.Net.IPAddress.Parse("120.83.190.6"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("54.39.69.88"),

System.Net.IPAddress.Parse("111.223.164.184"),

System.Net.IPAddress.Parse("169.171.53.112"),

System.Net.IPAddress.Parse("67.158.242.122"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(493259895));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("81.113.197.138"),

System.Net.IPAddress.Parse("249.99.38.174"),

System.Net.IPAddress.Parse("165.188.246.116"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("21.66.153.109"),

System.Net.IPAddress.Parse("236.25.38.174"),

System.Net.IPAddress.Parse("58.17.218.250"),

System.Net.IPAddress.Parse("119.90.85.251"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(902976247));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.110.99.153"),

System.Net.IPAddress.Parse("106.34.132.127"),

System.Net.IPAddress.Parse("14.244.237.116"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("130.224.116.24"),

System.Net.IPAddress.Parse("22.224.44.21"),

System.Net.IPAddress.Parse("191.106.38.6"),

System.Net.IPAddress.Parse("38.34.145.29"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(592622261));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("252.208.123.189"),

System.Net.IPAddress.Parse("208.222.169.239"),

System.Net.IPAddress.Parse("197.116.246.21"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.242.139.170"),

System.Net.IPAddress.Parse("98.182.29.207"),

System.Net.IPAddress.Parse("128.85.70.118"),

System.Net.IPAddress.Parse("23.10.30.70"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981696302));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("41.213.89.173"),

System.Net.IPAddress.Parse("205.13.25.8"),

System.Net.IPAddress.Parse("2.201.212.105"),

System.Net.IPAddress.Parse("11.197.168.221"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("65.97.244.44"),

System.Net.IPAddress.Parse("140.204.33.168"),

System.Net.IPAddress.Parse("231.126.13.176"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1489277569));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("165.86.216.81"),

System.Net.IPAddress.Parse("245.137.206.18"),

System.Net.IPAddress.Parse("1.79.152.27"),

System.Net.IPAddress.Parse("96.224.29.188"),

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
                Assert.That(model.Id, Is.EqualTo(1204012623));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("36.58.5.135"),

System.Net.IPAddress.Parse("204.131.149.141"),

System.Net.IPAddress.Parse("34.164.207.185"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("226.180.138.138"),

System.Net.IPAddress.Parse("115.183.220.221"),

System.Net.IPAddress.Parse("112.123.153.54"),

System.Net.IPAddress.Parse("174.176.254.16"),

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
                Assert.That(model.Id, Is.EqualTo(1250031908));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("29.197.212.239"),

System.Net.IPAddress.Parse("69.253.159.51"),

System.Net.IPAddress.Parse("133.98.78.11"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1578563188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("120.2.76.27"),

System.Net.IPAddress.Parse("83.75.169.142"),

System.Net.IPAddress.Parse("104.84.35.5"),

System.Net.IPAddress.Parse("196.18.179.70"),

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


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1418534519));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("19.77.126.164"),

System.Net.IPAddress.Parse("165.103.55.104"),

System.Net.IPAddress.Parse("38.19.49.31"),

System.Net.IPAddress.Parse("83.6.206.81"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("144.244.130.29"),

System.Net.IPAddress.Parse("137.242.134.148"),

System.Net.IPAddress.Parse("231.169.48.185"),

System.Net.IPAddress.Parse("75.59.63.3"),

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
                Assert.That(model.Id, Is.EqualTo(1419166380));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("191.209.175.78"),

System.Net.IPAddress.Parse("180.73.250.86"),

System.Net.IPAddress.Parse("159.236.95.242"),

System.Net.IPAddress.Parse("228.237.150.193"),

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
                Assert.That(model.Id, Is.EqualTo(1421378455));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("77.64.81.188"),

System.Net.IPAddress.Parse("44.144.63.85"),

System.Net.IPAddress.Parse("208.163.44.211"),

System.Net.IPAddress.Parse("101.86.45.208"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(218881980));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("208.89.35.2"),

System.Net.IPAddress.Parse("2.14.156.67"),

System.Net.IPAddress.Parse("180.72.116.152"),

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


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1438534957));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("15.72.84.63"),

System.Net.IPAddress.Parse("42.139.165.220"),

System.Net.IPAddress.Parse("67.151.201.38"),

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
                Assert.That(model.Id, Is.EqualTo(1525861477));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("120.57.111.227"),

System.Net.IPAddress.Parse("67.16.249.162"),

System.Net.IPAddress.Parse("220.169.60.178"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237378685));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.181.180.192"),

System.Net.IPAddress.Parse("232.201.183.160"),

System.Net.IPAddress.Parse("128.78.180.105"),

System.Net.IPAddress.Parse("83.124.226.123"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("52.132.213.140"),

System.Net.IPAddress.Parse("97.62.253.66"),

System.Net.IPAddress.Parse("0.168.126.136"),

System.Net.IPAddress.Parse("191.235.71.132"),

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
                Assert.That(model.Id, Is.EqualTo(1560260232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.113.47.65"),

System.Net.IPAddress.Parse("205.48.45.20"),

System.Net.IPAddress.Parse("35.138.105.162"),

System.Net.IPAddress.Parse("222.77.163.247"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(797012636));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("62.173.14.133"),

System.Net.IPAddress.Parse("67.86.171.23"),

System.Net.IPAddress.Parse("160.65.160.234"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("181.105.46.223"),

System.Net.IPAddress.Parse("111.116.29.174"),

System.Net.IPAddress.Parse("28.117.6.147"),

System.Net.IPAddress.Parse("130.86.91.56"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1601022817));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("99.66.243.223"),

System.Net.IPAddress.Parse("203.91.144.163"),

System.Net.IPAddress.Parse("91.36.60.111"),

System.Net.IPAddress.Parse("217.167.44.30"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.179.183.203"),

System.Net.IPAddress.Parse("28.62.216.212"),

System.Net.IPAddress.Parse("236.24.81.156"),

System.Net.IPAddress.Parse("203.241.215.77"),

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
                Assert.That(model.Id, Is.EqualTo(1619643577));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("234.177.215.48"),

System.Net.IPAddress.Parse("37.193.37.208"),

System.Net.IPAddress.Parse("103.210.118.208"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("128.38.221.117"),

System.Net.IPAddress.Parse("170.184.57.90"),

System.Net.IPAddress.Parse("222.78.57.150"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2079482896));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("118.145.130.134"),

System.Net.IPAddress.Parse("168.145.47.246"),

System.Net.IPAddress.Parse("133.178.124.149"),

System.Net.IPAddress.Parse("205.208.209.69"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("206.4.8.189"),

System.Net.IPAddress.Parse("178.105.254.175"),

System.Net.IPAddress.Parse("32.108.100.214"),

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
                Assert.That(model.Id, Is.EqualTo(1626757037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.88.198.127"),

System.Net.IPAddress.Parse("74.81.157.228"),

System.Net.IPAddress.Parse("236.35.8.93"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1683706738));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.82.80.245"),

System.Net.IPAddress.Parse("232.116.79.125"),

System.Net.IPAddress.Parse("174.46.62.103"),

System.Net.IPAddress.Parse("60.126.156.24"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("13.109.69.5"),

System.Net.IPAddress.Parse("231.51.35.179"),

System.Net.IPAddress.Parse("108.70.229.199"),

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
                Assert.That(model.Id, Is.EqualTo(1638988125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("238.176.190.225"),

System.Net.IPAddress.Parse("176.217.220.171"),

System.Net.IPAddress.Parse("250.234.153.105"),

System.Net.IPAddress.Parse("120.141.97.84"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("27.167.12.59"),

System.Net.IPAddress.Parse("228.0.114.173"),

System.Net.IPAddress.Parse("84.92.209.93"),

System.Net.IPAddress.Parse("222.73.49.253"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(61017462));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("100.147.193.73"),

System.Net.IPAddress.Parse("233.233.33.9"),

System.Net.IPAddress.Parse("105.130.7.101"),

System.Net.IPAddress.Parse("44.177.139.252"),

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
                Assert.That(model.Id, Is.EqualTo(1756340245));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("150.75.94.98"),

System.Net.IPAddress.Parse("154.220.34.33"),

System.Net.IPAddress.Parse("142.176.194.74"),

System.Net.IPAddress.Parse("202.218.81.26"),

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
                Assert.That(model.Id, Is.EqualTo(1922739568));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("228.30.69.115"),

System.Net.IPAddress.Parse("47.141.103.161"),

System.Net.IPAddress.Parse("70.102.228.6"),

System.Net.IPAddress.Parse("254.191.71.128"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(703320384));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.195.51.129"),

System.Net.IPAddress.Parse("156.38.122.41"),

System.Net.IPAddress.Parse("48.90.16.224"),

System.Net.IPAddress.Parse("31.169.67.31"),

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
                Assert.That(model.Id, Is.EqualTo(2007192625));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("240.218.19.236"),

System.Net.IPAddress.Parse("230.32.225.58"),

System.Net.IPAddress.Parse("178.243.245.37"),

System.Net.IPAddress.Parse("214.115.0.243"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("230.17.30.20"),

System.Net.IPAddress.Parse("247.253.47.127"),

System.Net.IPAddress.Parse("141.148.99.217"),

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


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2040415786));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("215.22.201.81"),

System.Net.IPAddress.Parse("131.67.161.140"),

System.Net.IPAddress.Parse("49.58.33.156"),

System.Net.IPAddress.Parse("62.233.132.186"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("88.82.118.139"),

System.Net.IPAddress.Parse("123.16.198.74"),

System.Net.IPAddress.Parse("78.60.212.89"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052968544));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("12.206.107.84"),

System.Net.IPAddress.Parse("253.166.191.242"),

System.Net.IPAddress.Parse("20.12.62.55"),

System.Net.IPAddress.Parse("222.206.221.195"),

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


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2104615667));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("114.214.121.99"),

System.Net.IPAddress.Parse("189.139.10.2"),

System.Net.IPAddress.Parse("67.190.160.184"),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(436734963));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.204.18.197"),

System.Net.IPAddress.Parse("251.64.78.104"),

System.Net.IPAddress.Parse("239.106.229.118"),

System.Net.IPAddress.Parse("102.155.103.38"),

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
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("160.35.180.101"),

System.Net.IPAddress.Parse("221.52.23.175"),

System.Net.IPAddress.Parse("217.105.180.102"),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    ipaddressinetarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(IPAddressinetArray2M),
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

                var expected = new Dictionary<System.Int32,IPAddressinetArray2M>(30);

                expected.Add(
                    53114524,
                    new IPAddressinetArray2M
                    {
                        Id = 53114524,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("159.183.238.80"),

System.Net.IPAddress.Parse("47.218.200.218"),

System.Net.IPAddress.Parse("195.155.174.179"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    176088676,
                    new IPAddressinetArray2M
                    {
                        Id = 176088676,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("231.154.164.129"),

System.Net.IPAddress.Parse("120.253.84.87"),

System.Net.IPAddress.Parse("212.65.4.68"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    240216224,
                    new IPAddressinetArray2M
                    {
                        Id = 240216224,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("229.179.159.9"),

System.Net.IPAddress.Parse("127.52.178.185"),

System.Net.IPAddress.Parse("91.100.65.63"),

System.Net.IPAddress.Parse("50.192.76.61"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    257730448,
                    new IPAddressinetArray2M
                    {
                        Id = 257730448,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("119.15.65.137"),

System.Net.IPAddress.Parse("245.182.223.243"),

System.Net.IPAddress.Parse("244.136.201.23"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("83.62.100.46"),

System.Net.IPAddress.Parse("120.87.237.84"),

System.Net.IPAddress.Parse("223.162.60.65"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    319861696,
                    new IPAddressinetArray2M
                    {
                        Id = 319861696,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("161.57.84.109"),

System.Net.IPAddress.Parse("56.101.160.188"),

System.Net.IPAddress.Parse("48.177.91.150"),

System.Net.IPAddress.Parse("191.127.158.251"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    423054754,
                    new IPAddressinetArray2M
                    {
                        Id = 423054754,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("164.157.197.43"),

System.Net.IPAddress.Parse("130.23.54.205"),

System.Net.IPAddress.Parse("37.54.239.101"),

System.Net.IPAddress.Parse("73.12.19.35"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    472717847,
                    new IPAddressinetArray2M
                    {
                        Id = 472717847,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("241.59.34.38"),

System.Net.IPAddress.Parse("130.204.76.173"),

System.Net.IPAddress.Parse("79.248.179.157"),

System.Net.IPAddress.Parse("188.41.127.62"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("156.13.97.202"),

System.Net.IPAddress.Parse("159.132.115.209"),

System.Net.IPAddress.Parse("175.21.56.20"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    559278709,
                    new IPAddressinetArray2M
                    {
                        Id = 559278709,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("3.86.229.33"),

System.Net.IPAddress.Parse("130.197.93.26"),

System.Net.IPAddress.Parse("72.250.135.43"),

System.Net.IPAddress.Parse("163.155.132.169"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("140.194.187.99"),

System.Net.IPAddress.Parse("118.102.89.142"),

System.Net.IPAddress.Parse("13.60.73.41"),

},

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 679149257,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("202.219.60.179"),

System.Net.IPAddress.Parse("187.5.225.114"),

System.Net.IPAddress.Parse("55.30.143.74"),

System.Net.IPAddress.Parse("196.204.74.213"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("9.159.202.96"),

System.Net.IPAddress.Parse("146.25.129.165"),

System.Net.IPAddress.Parse("176.4.79.145"),

System.Net.IPAddress.Parse("50.140.252.16"),

}
                        }

                    }
                );

                expected.Add(
                    847185137,
                    new IPAddressinetArray2M
                    {
                        Id = 847185137,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("98.15.82.204"),

System.Net.IPAddress.Parse("252.118.194.18"),

System.Net.IPAddress.Parse("140.28.233.210"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("200.247.194.13"),

System.Net.IPAddress.Parse("47.236.77.59"),

System.Net.IPAddress.Parse("101.230.108.169"),

System.Net.IPAddress.Parse("253.76.177.154"),

},

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 775413525,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("130.177.116.86"),

System.Net.IPAddress.Parse("138.151.82.18"),

System.Net.IPAddress.Parse("141.75.165.3"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    851516451,
                    new IPAddressinetArray2M
                    {
                        Id = 851516451,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("114.58.46.141"),

System.Net.IPAddress.Parse("41.29.187.157"),

System.Net.IPAddress.Parse("18.58.207.208"),

System.Net.IPAddress.Parse("158.158.51.6"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    858895777,
                    new IPAddressinetArray2M
                    {
                        Id = 858895777,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("159.237.35.54"),

System.Net.IPAddress.Parse("82.35.158.59"),

System.Net.IPAddress.Parse("151.16.199.130"),

System.Net.IPAddress.Parse("120.83.190.6"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("54.39.69.88"),

System.Net.IPAddress.Parse("111.223.164.184"),

System.Net.IPAddress.Parse("169.171.53.112"),

System.Net.IPAddress.Parse("67.158.242.122"),

},

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 493259895,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("81.113.197.138"),

System.Net.IPAddress.Parse("249.99.38.174"),

System.Net.IPAddress.Parse("165.188.246.116"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("21.66.153.109"),

System.Net.IPAddress.Parse("236.25.38.174"),

System.Net.IPAddress.Parse("58.17.218.250"),

System.Net.IPAddress.Parse("119.90.85.251"),

}
                        }

                    }
                );

                expected.Add(
                    902976247,
                    new IPAddressinetArray2M
                    {
                        Id = 902976247,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.110.99.153"),

System.Net.IPAddress.Parse("106.34.132.127"),

System.Net.IPAddress.Parse("14.244.237.116"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("130.224.116.24"),

System.Net.IPAddress.Parse("22.224.44.21"),

System.Net.IPAddress.Parse("191.106.38.6"),

System.Net.IPAddress.Parse("38.34.145.29"),

},

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 592622261,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("252.208.123.189"),

System.Net.IPAddress.Parse("208.222.169.239"),

System.Net.IPAddress.Parse("197.116.246.21"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.242.139.170"),

System.Net.IPAddress.Parse("98.182.29.207"),

System.Net.IPAddress.Parse("128.85.70.118"),

System.Net.IPAddress.Parse("23.10.30.70"),

}
                        }

                    }
                );

                expected.Add(
                    981696302,
                    new IPAddressinetArray2M
                    {
                        Id = 981696302,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("41.213.89.173"),

System.Net.IPAddress.Parse("205.13.25.8"),

System.Net.IPAddress.Parse("2.201.212.105"),

System.Net.IPAddress.Parse("11.197.168.221"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("65.97.244.44"),

System.Net.IPAddress.Parse("140.204.33.168"),

System.Net.IPAddress.Parse("231.126.13.176"),

},

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 1489277569,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("165.86.216.81"),

System.Net.IPAddress.Parse("245.137.206.18"),

System.Net.IPAddress.Parse("1.79.152.27"),

System.Net.IPAddress.Parse("96.224.29.188"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1204012623,
                    new IPAddressinetArray2M
                    {
                        Id = 1204012623,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("36.58.5.135"),

System.Net.IPAddress.Parse("204.131.149.141"),

System.Net.IPAddress.Parse("34.164.207.185"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("226.180.138.138"),

System.Net.IPAddress.Parse("115.183.220.221"),

System.Net.IPAddress.Parse("112.123.153.54"),

System.Net.IPAddress.Parse("174.176.254.16"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1250031908,
                    new IPAddressinetArray2M
                    {
                        Id = 1250031908,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("29.197.212.239"),

System.Net.IPAddress.Parse("69.253.159.51"),

System.Net.IPAddress.Parse("133.98.78.11"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 1578563188,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("120.2.76.27"),

System.Net.IPAddress.Parse("83.75.169.142"),

System.Net.IPAddress.Parse("104.84.35.5"),

System.Net.IPAddress.Parse("196.18.179.70"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1418534519,
                    new IPAddressinetArray2M
                    {
                        Id = 1418534519,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("19.77.126.164"),

System.Net.IPAddress.Parse("165.103.55.104"),

System.Net.IPAddress.Parse("38.19.49.31"),

System.Net.IPAddress.Parse("83.6.206.81"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("144.244.130.29"),

System.Net.IPAddress.Parse("137.242.134.148"),

System.Net.IPAddress.Parse("231.169.48.185"),

System.Net.IPAddress.Parse("75.59.63.3"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1419166380,
                    new IPAddressinetArray2M
                    {
                        Id = 1419166380,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("191.209.175.78"),

System.Net.IPAddress.Parse("180.73.250.86"),

System.Net.IPAddress.Parse("159.236.95.242"),

System.Net.IPAddress.Parse("228.237.150.193"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1421378455,
                    new IPAddressinetArray2M
                    {
                        Id = 1421378455,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("77.64.81.188"),

System.Net.IPAddress.Parse("44.144.63.85"),

System.Net.IPAddress.Parse("208.163.44.211"),

System.Net.IPAddress.Parse("101.86.45.208"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 218881980,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("208.89.35.2"),

System.Net.IPAddress.Parse("2.14.156.67"),

System.Net.IPAddress.Parse("180.72.116.152"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1438534957,
                    new IPAddressinetArray2M
                    {
                        Id = 1438534957,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("15.72.84.63"),

System.Net.IPAddress.Parse("42.139.165.220"),

System.Net.IPAddress.Parse("67.151.201.38"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1525861477,
                    new IPAddressinetArray2M
                    {
                        Id = 1525861477,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("120.57.111.227"),

System.Net.IPAddress.Parse("67.16.249.162"),

System.Net.IPAddress.Parse("220.169.60.178"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 1237378685,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.181.180.192"),

System.Net.IPAddress.Parse("232.201.183.160"),

System.Net.IPAddress.Parse("128.78.180.105"),

System.Net.IPAddress.Parse("83.124.226.123"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("52.132.213.140"),

System.Net.IPAddress.Parse("97.62.253.66"),

System.Net.IPAddress.Parse("0.168.126.136"),

System.Net.IPAddress.Parse("191.235.71.132"),

}
                        }

                    }
                );

                expected.Add(
                    1560260232,
                    new IPAddressinetArray2M
                    {
                        Id = 1560260232,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.113.47.65"),

System.Net.IPAddress.Parse("205.48.45.20"),

System.Net.IPAddress.Parse("35.138.105.162"),

System.Net.IPAddress.Parse("222.77.163.247"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 797012636,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("62.173.14.133"),

System.Net.IPAddress.Parse("67.86.171.23"),

System.Net.IPAddress.Parse("160.65.160.234"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("181.105.46.223"),

System.Net.IPAddress.Parse("111.116.29.174"),

System.Net.IPAddress.Parse("28.117.6.147"),

System.Net.IPAddress.Parse("130.86.91.56"),

}
                        }

                    }
                );

                expected.Add(
                    1601022817,
                    new IPAddressinetArray2M
                    {
                        Id = 1601022817,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("99.66.243.223"),

System.Net.IPAddress.Parse("203.91.144.163"),

System.Net.IPAddress.Parse("91.36.60.111"),

System.Net.IPAddress.Parse("217.167.44.30"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.179.183.203"),

System.Net.IPAddress.Parse("28.62.216.212"),

System.Net.IPAddress.Parse("236.24.81.156"),

System.Net.IPAddress.Parse("203.241.215.77"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1619643577,
                    new IPAddressinetArray2M
                    {
                        Id = 1619643577,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("234.177.215.48"),

System.Net.IPAddress.Parse("37.193.37.208"),

System.Net.IPAddress.Parse("103.210.118.208"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("128.38.221.117"),

System.Net.IPAddress.Parse("170.184.57.90"),

System.Net.IPAddress.Parse("222.78.57.150"),

},

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 2079482896,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("118.145.130.134"),

System.Net.IPAddress.Parse("168.145.47.246"),

System.Net.IPAddress.Parse("133.178.124.149"),

System.Net.IPAddress.Parse("205.208.209.69"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("206.4.8.189"),

System.Net.IPAddress.Parse("178.105.254.175"),

System.Net.IPAddress.Parse("32.108.100.214"),

}
                        }

                    }
                );

                expected.Add(
                    1626757037,
                    new IPAddressinetArray2M
                    {
                        Id = 1626757037,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.88.198.127"),

System.Net.IPAddress.Parse("74.81.157.228"),

System.Net.IPAddress.Parse("236.35.8.93"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 1683706738,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.82.80.245"),

System.Net.IPAddress.Parse("232.116.79.125"),

System.Net.IPAddress.Parse("174.46.62.103"),

System.Net.IPAddress.Parse("60.126.156.24"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("13.109.69.5"),

System.Net.IPAddress.Parse("231.51.35.179"),

System.Net.IPAddress.Parse("108.70.229.199"),

}
                        }

                    }
                );

                expected.Add(
                    1638988125,
                    new IPAddressinetArray2M
                    {
                        Id = 1638988125,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("238.176.190.225"),

System.Net.IPAddress.Parse("176.217.220.171"),

System.Net.IPAddress.Parse("250.234.153.105"),

System.Net.IPAddress.Parse("120.141.97.84"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("27.167.12.59"),

System.Net.IPAddress.Parse("228.0.114.173"),

System.Net.IPAddress.Parse("84.92.209.93"),

System.Net.IPAddress.Parse("222.73.49.253"),

},

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 61017462,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("100.147.193.73"),

System.Net.IPAddress.Parse("233.233.33.9"),

System.Net.IPAddress.Parse("105.130.7.101"),

System.Net.IPAddress.Parse("44.177.139.252"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1756340245,
                    new IPAddressinetArray2M
                    {
                        Id = 1756340245,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("150.75.94.98"),

System.Net.IPAddress.Parse("154.220.34.33"),

System.Net.IPAddress.Parse("142.176.194.74"),

System.Net.IPAddress.Parse("202.218.81.26"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1922739568,
                    new IPAddressinetArray2M
                    {
                        Id = 1922739568,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("228.30.69.115"),

System.Net.IPAddress.Parse("47.141.103.161"),

System.Net.IPAddress.Parse("70.102.228.6"),

System.Net.IPAddress.Parse("254.191.71.128"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 703320384,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.195.51.129"),

System.Net.IPAddress.Parse("156.38.122.41"),

System.Net.IPAddress.Parse("48.90.16.224"),

System.Net.IPAddress.Parse("31.169.67.31"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2007192625,
                    new IPAddressinetArray2M
                    {
                        Id = 2007192625,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("240.218.19.236"),

System.Net.IPAddress.Parse("230.32.225.58"),

System.Net.IPAddress.Parse("178.243.245.37"),

System.Net.IPAddress.Parse("214.115.0.243"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("230.17.30.20"),

System.Net.IPAddress.Parse("247.253.47.127"),

System.Net.IPAddress.Parse("141.148.99.217"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2040415786,
                    new IPAddressinetArray2M
                    {
                        Id = 2040415786,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("215.22.201.81"),

System.Net.IPAddress.Parse("131.67.161.140"),

System.Net.IPAddress.Parse("49.58.33.156"),

System.Net.IPAddress.Parse("62.233.132.186"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("88.82.118.139"),

System.Net.IPAddress.Parse("123.16.198.74"),

System.Net.IPAddress.Parse("78.60.212.89"),

},

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 1052968544,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("12.206.107.84"),

System.Net.IPAddress.Parse("253.166.191.242"),

System.Net.IPAddress.Parse("20.12.62.55"),

System.Net.IPAddress.Parse("222.206.221.195"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2104615667,
                    new IPAddressinetArray2M
                    {
                        Id = 2104615667,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("114.214.121.99"),

System.Net.IPAddress.Parse("189.139.10.2"),

System.Net.IPAddress.Parse("67.190.160.184"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 436734963,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.204.18.197"),

System.Net.IPAddress.Parse("251.64.78.104"),

System.Net.IPAddress.Parse("239.106.229.118"),

System.Net.IPAddress.Parse("102.155.103.38"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("160.35.180.101"),

System.Net.IPAddress.Parse("221.52.23.175"),

System.Net.IPAddress.Parse("217.105.180.102"),

}
                        }

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Net.IPAddress>)default));
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

                var expected = new Dictionary<System.Int32,IPAddressinetArray2M>(30);

                expected.Add(
                    53114524,
                    new IPAddressinetArray2M
                    {
                        Id = 53114524,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("159.183.238.80"),

System.Net.IPAddress.Parse("47.218.200.218"),

System.Net.IPAddress.Parse("195.155.174.179"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    176088676,
                    new IPAddressinetArray2M
                    {
                        Id = 176088676,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("231.154.164.129"),

System.Net.IPAddress.Parse("120.253.84.87"),

System.Net.IPAddress.Parse("212.65.4.68"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    240216224,
                    new IPAddressinetArray2M
                    {
                        Id = 240216224,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("229.179.159.9"),

System.Net.IPAddress.Parse("127.52.178.185"),

System.Net.IPAddress.Parse("91.100.65.63"),

System.Net.IPAddress.Parse("50.192.76.61"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    257730448,
                    new IPAddressinetArray2M
                    {
                        Id = 257730448,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("119.15.65.137"),

System.Net.IPAddress.Parse("245.182.223.243"),

System.Net.IPAddress.Parse("244.136.201.23"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("83.62.100.46"),

System.Net.IPAddress.Parse("120.87.237.84"),

System.Net.IPAddress.Parse("223.162.60.65"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    319861696,
                    new IPAddressinetArray2M
                    {
                        Id = 319861696,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("161.57.84.109"),

System.Net.IPAddress.Parse("56.101.160.188"),

System.Net.IPAddress.Parse("48.177.91.150"),

System.Net.IPAddress.Parse("191.127.158.251"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    423054754,
                    new IPAddressinetArray2M
                    {
                        Id = 423054754,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("164.157.197.43"),

System.Net.IPAddress.Parse("130.23.54.205"),

System.Net.IPAddress.Parse("37.54.239.101"),

System.Net.IPAddress.Parse("73.12.19.35"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    472717847,
                    new IPAddressinetArray2M
                    {
                        Id = 472717847,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("241.59.34.38"),

System.Net.IPAddress.Parse("130.204.76.173"),

System.Net.IPAddress.Parse("79.248.179.157"),

System.Net.IPAddress.Parse("188.41.127.62"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("156.13.97.202"),

System.Net.IPAddress.Parse("159.132.115.209"),

System.Net.IPAddress.Parse("175.21.56.20"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    559278709,
                    new IPAddressinetArray2M
                    {
                        Id = 559278709,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("3.86.229.33"),

System.Net.IPAddress.Parse("130.197.93.26"),

System.Net.IPAddress.Parse("72.250.135.43"),

System.Net.IPAddress.Parse("163.155.132.169"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("140.194.187.99"),

System.Net.IPAddress.Parse("118.102.89.142"),

System.Net.IPAddress.Parse("13.60.73.41"),

},

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 679149257,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("202.219.60.179"),

System.Net.IPAddress.Parse("187.5.225.114"),

System.Net.IPAddress.Parse("55.30.143.74"),

System.Net.IPAddress.Parse("196.204.74.213"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("9.159.202.96"),

System.Net.IPAddress.Parse("146.25.129.165"),

System.Net.IPAddress.Parse("176.4.79.145"),

System.Net.IPAddress.Parse("50.140.252.16"),

}
                        }

                    }
                );

                expected.Add(
                    847185137,
                    new IPAddressinetArray2M
                    {
                        Id = 847185137,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("98.15.82.204"),

System.Net.IPAddress.Parse("252.118.194.18"),

System.Net.IPAddress.Parse("140.28.233.210"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("200.247.194.13"),

System.Net.IPAddress.Parse("47.236.77.59"),

System.Net.IPAddress.Parse("101.230.108.169"),

System.Net.IPAddress.Parse("253.76.177.154"),

},

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 775413525,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("130.177.116.86"),

System.Net.IPAddress.Parse("138.151.82.18"),

System.Net.IPAddress.Parse("141.75.165.3"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    851516451,
                    new IPAddressinetArray2M
                    {
                        Id = 851516451,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("114.58.46.141"),

System.Net.IPAddress.Parse("41.29.187.157"),

System.Net.IPAddress.Parse("18.58.207.208"),

System.Net.IPAddress.Parse("158.158.51.6"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    858895777,
                    new IPAddressinetArray2M
                    {
                        Id = 858895777,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("159.237.35.54"),

System.Net.IPAddress.Parse("82.35.158.59"),

System.Net.IPAddress.Parse("151.16.199.130"),

System.Net.IPAddress.Parse("120.83.190.6"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("54.39.69.88"),

System.Net.IPAddress.Parse("111.223.164.184"),

System.Net.IPAddress.Parse("169.171.53.112"),

System.Net.IPAddress.Parse("67.158.242.122"),

},

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 493259895,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("81.113.197.138"),

System.Net.IPAddress.Parse("249.99.38.174"),

System.Net.IPAddress.Parse("165.188.246.116"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("21.66.153.109"),

System.Net.IPAddress.Parse("236.25.38.174"),

System.Net.IPAddress.Parse("58.17.218.250"),

System.Net.IPAddress.Parse("119.90.85.251"),

}
                        }

                    }
                );

                expected.Add(
                    902976247,
                    new IPAddressinetArray2M
                    {
                        Id = 902976247,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.110.99.153"),

System.Net.IPAddress.Parse("106.34.132.127"),

System.Net.IPAddress.Parse("14.244.237.116"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("130.224.116.24"),

System.Net.IPAddress.Parse("22.224.44.21"),

System.Net.IPAddress.Parse("191.106.38.6"),

System.Net.IPAddress.Parse("38.34.145.29"),

},

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 592622261,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("252.208.123.189"),

System.Net.IPAddress.Parse("208.222.169.239"),

System.Net.IPAddress.Parse("197.116.246.21"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.242.139.170"),

System.Net.IPAddress.Parse("98.182.29.207"),

System.Net.IPAddress.Parse("128.85.70.118"),

System.Net.IPAddress.Parse("23.10.30.70"),

}
                        }

                    }
                );

                expected.Add(
                    981696302,
                    new IPAddressinetArray2M
                    {
                        Id = 981696302,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("41.213.89.173"),

System.Net.IPAddress.Parse("205.13.25.8"),

System.Net.IPAddress.Parse("2.201.212.105"),

System.Net.IPAddress.Parse("11.197.168.221"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("65.97.244.44"),

System.Net.IPAddress.Parse("140.204.33.168"),

System.Net.IPAddress.Parse("231.126.13.176"),

},

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 1489277569,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("165.86.216.81"),

System.Net.IPAddress.Parse("245.137.206.18"),

System.Net.IPAddress.Parse("1.79.152.27"),

System.Net.IPAddress.Parse("96.224.29.188"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1204012623,
                    new IPAddressinetArray2M
                    {
                        Id = 1204012623,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("36.58.5.135"),

System.Net.IPAddress.Parse("204.131.149.141"),

System.Net.IPAddress.Parse("34.164.207.185"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("226.180.138.138"),

System.Net.IPAddress.Parse("115.183.220.221"),

System.Net.IPAddress.Parse("112.123.153.54"),

System.Net.IPAddress.Parse("174.176.254.16"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1250031908,
                    new IPAddressinetArray2M
                    {
                        Id = 1250031908,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("29.197.212.239"),

System.Net.IPAddress.Parse("69.253.159.51"),

System.Net.IPAddress.Parse("133.98.78.11"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 1578563188,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("120.2.76.27"),

System.Net.IPAddress.Parse("83.75.169.142"),

System.Net.IPAddress.Parse("104.84.35.5"),

System.Net.IPAddress.Parse("196.18.179.70"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1418534519,
                    new IPAddressinetArray2M
                    {
                        Id = 1418534519,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("19.77.126.164"),

System.Net.IPAddress.Parse("165.103.55.104"),

System.Net.IPAddress.Parse("38.19.49.31"),

System.Net.IPAddress.Parse("83.6.206.81"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("144.244.130.29"),

System.Net.IPAddress.Parse("137.242.134.148"),

System.Net.IPAddress.Parse("231.169.48.185"),

System.Net.IPAddress.Parse("75.59.63.3"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1419166380,
                    new IPAddressinetArray2M
                    {
                        Id = 1419166380,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("191.209.175.78"),

System.Net.IPAddress.Parse("180.73.250.86"),

System.Net.IPAddress.Parse("159.236.95.242"),

System.Net.IPAddress.Parse("228.237.150.193"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1421378455,
                    new IPAddressinetArray2M
                    {
                        Id = 1421378455,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("77.64.81.188"),

System.Net.IPAddress.Parse("44.144.63.85"),

System.Net.IPAddress.Parse("208.163.44.211"),

System.Net.IPAddress.Parse("101.86.45.208"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 218881980,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("208.89.35.2"),

System.Net.IPAddress.Parse("2.14.156.67"),

System.Net.IPAddress.Parse("180.72.116.152"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1438534957,
                    new IPAddressinetArray2M
                    {
                        Id = 1438534957,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("15.72.84.63"),

System.Net.IPAddress.Parse("42.139.165.220"),

System.Net.IPAddress.Parse("67.151.201.38"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1525861477,
                    new IPAddressinetArray2M
                    {
                        Id = 1525861477,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("120.57.111.227"),

System.Net.IPAddress.Parse("67.16.249.162"),

System.Net.IPAddress.Parse("220.169.60.178"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 1237378685,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.181.180.192"),

System.Net.IPAddress.Parse("232.201.183.160"),

System.Net.IPAddress.Parse("128.78.180.105"),

System.Net.IPAddress.Parse("83.124.226.123"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("52.132.213.140"),

System.Net.IPAddress.Parse("97.62.253.66"),

System.Net.IPAddress.Parse("0.168.126.136"),

System.Net.IPAddress.Parse("191.235.71.132"),

}
                        }

                    }
                );

                expected.Add(
                    1560260232,
                    new IPAddressinetArray2M
                    {
                        Id = 1560260232,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.113.47.65"),

System.Net.IPAddress.Parse("205.48.45.20"),

System.Net.IPAddress.Parse("35.138.105.162"),

System.Net.IPAddress.Parse("222.77.163.247"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 797012636,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("62.173.14.133"),

System.Net.IPAddress.Parse("67.86.171.23"),

System.Net.IPAddress.Parse("160.65.160.234"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("181.105.46.223"),

System.Net.IPAddress.Parse("111.116.29.174"),

System.Net.IPAddress.Parse("28.117.6.147"),

System.Net.IPAddress.Parse("130.86.91.56"),

}
                        }

                    }
                );

                expected.Add(
                    1601022817,
                    new IPAddressinetArray2M
                    {
                        Id = 1601022817,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("99.66.243.223"),

System.Net.IPAddress.Parse("203.91.144.163"),

System.Net.IPAddress.Parse("91.36.60.111"),

System.Net.IPAddress.Parse("217.167.44.30"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.179.183.203"),

System.Net.IPAddress.Parse("28.62.216.212"),

System.Net.IPAddress.Parse("236.24.81.156"),

System.Net.IPAddress.Parse("203.241.215.77"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1619643577,
                    new IPAddressinetArray2M
                    {
                        Id = 1619643577,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("234.177.215.48"),

System.Net.IPAddress.Parse("37.193.37.208"),

System.Net.IPAddress.Parse("103.210.118.208"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("128.38.221.117"),

System.Net.IPAddress.Parse("170.184.57.90"),

System.Net.IPAddress.Parse("222.78.57.150"),

},

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 2079482896,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("118.145.130.134"),

System.Net.IPAddress.Parse("168.145.47.246"),

System.Net.IPAddress.Parse("133.178.124.149"),

System.Net.IPAddress.Parse("205.208.209.69"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("206.4.8.189"),

System.Net.IPAddress.Parse("178.105.254.175"),

System.Net.IPAddress.Parse("32.108.100.214"),

}
                        }

                    }
                );

                expected.Add(
                    1626757037,
                    new IPAddressinetArray2M
                    {
                        Id = 1626757037,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("225.88.198.127"),

System.Net.IPAddress.Parse("74.81.157.228"),

System.Net.IPAddress.Parse("236.35.8.93"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 1683706738,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.82.80.245"),

System.Net.IPAddress.Parse("232.116.79.125"),

System.Net.IPAddress.Parse("174.46.62.103"),

System.Net.IPAddress.Parse("60.126.156.24"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("13.109.69.5"),

System.Net.IPAddress.Parse("231.51.35.179"),

System.Net.IPAddress.Parse("108.70.229.199"),

}
                        }

                    }
                );

                expected.Add(
                    1638988125,
                    new IPAddressinetArray2M
                    {
                        Id = 1638988125,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("238.176.190.225"),

System.Net.IPAddress.Parse("176.217.220.171"),

System.Net.IPAddress.Parse("250.234.153.105"),

System.Net.IPAddress.Parse("120.141.97.84"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("27.167.12.59"),

System.Net.IPAddress.Parse("228.0.114.173"),

System.Net.IPAddress.Parse("84.92.209.93"),

System.Net.IPAddress.Parse("222.73.49.253"),

},

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 61017462,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("100.147.193.73"),

System.Net.IPAddress.Parse("233.233.33.9"),

System.Net.IPAddress.Parse("105.130.7.101"),

System.Net.IPAddress.Parse("44.177.139.252"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1756340245,
                    new IPAddressinetArray2M
                    {
                        Id = 1756340245,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("150.75.94.98"),

System.Net.IPAddress.Parse("154.220.34.33"),

System.Net.IPAddress.Parse("142.176.194.74"),

System.Net.IPAddress.Parse("202.218.81.26"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1922739568,
                    new IPAddressinetArray2M
                    {
                        Id = 1922739568,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("228.30.69.115"),

System.Net.IPAddress.Parse("47.141.103.161"),

System.Net.IPAddress.Parse("70.102.228.6"),

System.Net.IPAddress.Parse("254.191.71.128"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 703320384,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.195.51.129"),

System.Net.IPAddress.Parse("156.38.122.41"),

System.Net.IPAddress.Parse("48.90.16.224"),

System.Net.IPAddress.Parse("31.169.67.31"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2007192625,
                    new IPAddressinetArray2M
                    {
                        Id = 2007192625,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("240.218.19.236"),

System.Net.IPAddress.Parse("230.32.225.58"),

System.Net.IPAddress.Parse("178.243.245.37"),

System.Net.IPAddress.Parse("214.115.0.243"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("230.17.30.20"),

System.Net.IPAddress.Parse("247.253.47.127"),

System.Net.IPAddress.Parse("141.148.99.217"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2040415786,
                    new IPAddressinetArray2M
                    {
                        Id = 2040415786,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("215.22.201.81"),

System.Net.IPAddress.Parse("131.67.161.140"),

System.Net.IPAddress.Parse("49.58.33.156"),

System.Net.IPAddress.Parse("62.233.132.186"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("88.82.118.139"),

System.Net.IPAddress.Parse("123.16.198.74"),

System.Net.IPAddress.Parse("78.60.212.89"),

},

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 1052968544,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("12.206.107.84"),

System.Net.IPAddress.Parse("253.166.191.242"),

System.Net.IPAddress.Parse("20.12.62.55"),

System.Net.IPAddress.Parse("222.206.221.195"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2104615667,
                    new IPAddressinetArray2M
                    {
                        Id = 2104615667,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("114.214.121.99"),

System.Net.IPAddress.Parse("189.139.10.2"),

System.Net.IPAddress.Parse("67.190.160.184"),

},
                        NullableValue = null,

                        ModelInner = new IPAddressinetArray2MI
                        {
                            Id = 436734963,
                            Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.204.18.197"),

System.Net.IPAddress.Parse("251.64.78.104"),

System.Net.IPAddress.Parse("239.106.229.118"),

System.Net.IPAddress.Parse("102.155.103.38"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("160.35.180.101"),

System.Net.IPAddress.Parse("221.52.23.175"),

System.Net.IPAddress.Parse("217.105.180.102"),

}
                        }

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Net.IPAddress>)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinetarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(IPAddressinetArray2MI),
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

                var expected = new Dictionary<System.Int32,IPAddressinetArray2MI>(15);

                expected.Add(
                    61017462,
                    new IPAddressinetArray2MI
                    {
                        Id = 61017462,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("100.147.193.73"),

System.Net.IPAddress.Parse("233.233.33.9"),

System.Net.IPAddress.Parse("105.130.7.101"),

System.Net.IPAddress.Parse("44.177.139.252"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    218881980,
                    new IPAddressinetArray2MI
                    {
                        Id = 218881980,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("208.89.35.2"),

System.Net.IPAddress.Parse("2.14.156.67"),

System.Net.IPAddress.Parse("180.72.116.152"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    436734963,
                    new IPAddressinetArray2MI
                    {
                        Id = 436734963,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.204.18.197"),

System.Net.IPAddress.Parse("251.64.78.104"),

System.Net.IPAddress.Parse("239.106.229.118"),

System.Net.IPAddress.Parse("102.155.103.38"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("160.35.180.101"),

System.Net.IPAddress.Parse("221.52.23.175"),

System.Net.IPAddress.Parse("217.105.180.102"),

}
                    }
                );

                expected.Add(
                    493259895,
                    new IPAddressinetArray2MI
                    {
                        Id = 493259895,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("81.113.197.138"),

System.Net.IPAddress.Parse("249.99.38.174"),

System.Net.IPAddress.Parse("165.188.246.116"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("21.66.153.109"),

System.Net.IPAddress.Parse("236.25.38.174"),

System.Net.IPAddress.Parse("58.17.218.250"),

System.Net.IPAddress.Parse("119.90.85.251"),

}
                    }
                );

                expected.Add(
                    592622261,
                    new IPAddressinetArray2MI
                    {
                        Id = 592622261,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("252.208.123.189"),

System.Net.IPAddress.Parse("208.222.169.239"),

System.Net.IPAddress.Parse("197.116.246.21"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.242.139.170"),

System.Net.IPAddress.Parse("98.182.29.207"),

System.Net.IPAddress.Parse("128.85.70.118"),

System.Net.IPAddress.Parse("23.10.30.70"),

}
                    }
                );

                expected.Add(
                    679149257,
                    new IPAddressinetArray2MI
                    {
                        Id = 679149257,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("202.219.60.179"),

System.Net.IPAddress.Parse("187.5.225.114"),

System.Net.IPAddress.Parse("55.30.143.74"),

System.Net.IPAddress.Parse("196.204.74.213"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("9.159.202.96"),

System.Net.IPAddress.Parse("146.25.129.165"),

System.Net.IPAddress.Parse("176.4.79.145"),

System.Net.IPAddress.Parse("50.140.252.16"),

}
                    }
                );

                expected.Add(
                    703320384,
                    new IPAddressinetArray2MI
                    {
                        Id = 703320384,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.195.51.129"),

System.Net.IPAddress.Parse("156.38.122.41"),

System.Net.IPAddress.Parse("48.90.16.224"),

System.Net.IPAddress.Parse("31.169.67.31"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    775413525,
                    new IPAddressinetArray2MI
                    {
                        Id = 775413525,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("130.177.116.86"),

System.Net.IPAddress.Parse("138.151.82.18"),

System.Net.IPAddress.Parse("141.75.165.3"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    797012636,
                    new IPAddressinetArray2MI
                    {
                        Id = 797012636,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("62.173.14.133"),

System.Net.IPAddress.Parse("67.86.171.23"),

System.Net.IPAddress.Parse("160.65.160.234"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("181.105.46.223"),

System.Net.IPAddress.Parse("111.116.29.174"),

System.Net.IPAddress.Parse("28.117.6.147"),

System.Net.IPAddress.Parse("130.86.91.56"),

}
                    }
                );

                expected.Add(
                    1052968544,
                    new IPAddressinetArray2MI
                    {
                        Id = 1052968544,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("12.206.107.84"),

System.Net.IPAddress.Parse("253.166.191.242"),

System.Net.IPAddress.Parse("20.12.62.55"),

System.Net.IPAddress.Parse("222.206.221.195"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1237378685,
                    new IPAddressinetArray2MI
                    {
                        Id = 1237378685,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.181.180.192"),

System.Net.IPAddress.Parse("232.201.183.160"),

System.Net.IPAddress.Parse("128.78.180.105"),

System.Net.IPAddress.Parse("83.124.226.123"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("52.132.213.140"),

System.Net.IPAddress.Parse("97.62.253.66"),

System.Net.IPAddress.Parse("0.168.126.136"),

System.Net.IPAddress.Parse("191.235.71.132"),

}
                    }
                );

                expected.Add(
                    1489277569,
                    new IPAddressinetArray2MI
                    {
                        Id = 1489277569,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("165.86.216.81"),

System.Net.IPAddress.Parse("245.137.206.18"),

System.Net.IPAddress.Parse("1.79.152.27"),

System.Net.IPAddress.Parse("96.224.29.188"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1578563188,
                    new IPAddressinetArray2MI
                    {
                        Id = 1578563188,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("120.2.76.27"),

System.Net.IPAddress.Parse("83.75.169.142"),

System.Net.IPAddress.Parse("104.84.35.5"),

System.Net.IPAddress.Parse("196.18.179.70"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1683706738,
                    new IPAddressinetArray2MI
                    {
                        Id = 1683706738,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.82.80.245"),

System.Net.IPAddress.Parse("232.116.79.125"),

System.Net.IPAddress.Parse("174.46.62.103"),

System.Net.IPAddress.Parse("60.126.156.24"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("13.109.69.5"),

System.Net.IPAddress.Parse("231.51.35.179"),

System.Net.IPAddress.Parse("108.70.229.199"),

}
                    }
                );

                expected.Add(
                    2079482896,
                    new IPAddressinetArray2MI
                    {
                        Id = 2079482896,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("118.145.130.134"),

System.Net.IPAddress.Parse("168.145.47.246"),

System.Net.IPAddress.Parse("133.178.124.149"),

System.Net.IPAddress.Parse("205.208.209.69"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("206.4.8.189"),

System.Net.IPAddress.Parse("178.105.254.175"),

System.Net.IPAddress.Parse("32.108.100.214"),

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

                var expected = new Dictionary<System.Int32,IPAddressinetArray2MI>(15);

                expected.Add(
                    61017462,
                    new IPAddressinetArray2MI
                    {
                        Id = 61017462,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("100.147.193.73"),

System.Net.IPAddress.Parse("233.233.33.9"),

System.Net.IPAddress.Parse("105.130.7.101"),

System.Net.IPAddress.Parse("44.177.139.252"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    218881980,
                    new IPAddressinetArray2MI
                    {
                        Id = 218881980,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("208.89.35.2"),

System.Net.IPAddress.Parse("2.14.156.67"),

System.Net.IPAddress.Parse("180.72.116.152"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    436734963,
                    new IPAddressinetArray2MI
                    {
                        Id = 436734963,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("141.204.18.197"),

System.Net.IPAddress.Parse("251.64.78.104"),

System.Net.IPAddress.Parse("239.106.229.118"),

System.Net.IPAddress.Parse("102.155.103.38"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("160.35.180.101"),

System.Net.IPAddress.Parse("221.52.23.175"),

System.Net.IPAddress.Parse("217.105.180.102"),

}
                    }
                );

                expected.Add(
                    493259895,
                    new IPAddressinetArray2MI
                    {
                        Id = 493259895,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("81.113.197.138"),

System.Net.IPAddress.Parse("249.99.38.174"),

System.Net.IPAddress.Parse("165.188.246.116"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("21.66.153.109"),

System.Net.IPAddress.Parse("236.25.38.174"),

System.Net.IPAddress.Parse("58.17.218.250"),

System.Net.IPAddress.Parse("119.90.85.251"),

}
                    }
                );

                expected.Add(
                    592622261,
                    new IPAddressinetArray2MI
                    {
                        Id = 592622261,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("252.208.123.189"),

System.Net.IPAddress.Parse("208.222.169.239"),

System.Net.IPAddress.Parse("197.116.246.21"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("157.242.139.170"),

System.Net.IPAddress.Parse("98.182.29.207"),

System.Net.IPAddress.Parse("128.85.70.118"),

System.Net.IPAddress.Parse("23.10.30.70"),

}
                    }
                );

                expected.Add(
                    679149257,
                    new IPAddressinetArray2MI
                    {
                        Id = 679149257,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("202.219.60.179"),

System.Net.IPAddress.Parse("187.5.225.114"),

System.Net.IPAddress.Parse("55.30.143.74"),

System.Net.IPAddress.Parse("196.204.74.213"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("9.159.202.96"),

System.Net.IPAddress.Parse("146.25.129.165"),

System.Net.IPAddress.Parse("176.4.79.145"),

System.Net.IPAddress.Parse("50.140.252.16"),

}
                    }
                );

                expected.Add(
                    703320384,
                    new IPAddressinetArray2MI
                    {
                        Id = 703320384,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("125.195.51.129"),

System.Net.IPAddress.Parse("156.38.122.41"),

System.Net.IPAddress.Parse("48.90.16.224"),

System.Net.IPAddress.Parse("31.169.67.31"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    775413525,
                    new IPAddressinetArray2MI
                    {
                        Id = 775413525,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("130.177.116.86"),

System.Net.IPAddress.Parse("138.151.82.18"),

System.Net.IPAddress.Parse("141.75.165.3"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    797012636,
                    new IPAddressinetArray2MI
                    {
                        Id = 797012636,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("62.173.14.133"),

System.Net.IPAddress.Parse("67.86.171.23"),

System.Net.IPAddress.Parse("160.65.160.234"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("181.105.46.223"),

System.Net.IPAddress.Parse("111.116.29.174"),

System.Net.IPAddress.Parse("28.117.6.147"),

System.Net.IPAddress.Parse("130.86.91.56"),

}
                    }
                );

                expected.Add(
                    1052968544,
                    new IPAddressinetArray2MI
                    {
                        Id = 1052968544,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("12.206.107.84"),

System.Net.IPAddress.Parse("253.166.191.242"),

System.Net.IPAddress.Parse("20.12.62.55"),

System.Net.IPAddress.Parse("222.206.221.195"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1237378685,
                    new IPAddressinetArray2MI
                    {
                        Id = 1237378685,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("160.181.180.192"),

System.Net.IPAddress.Parse("232.201.183.160"),

System.Net.IPAddress.Parse("128.78.180.105"),

System.Net.IPAddress.Parse("83.124.226.123"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("52.132.213.140"),

System.Net.IPAddress.Parse("97.62.253.66"),

System.Net.IPAddress.Parse("0.168.126.136"),

System.Net.IPAddress.Parse("191.235.71.132"),

}
                    }
                );

                expected.Add(
                    1489277569,
                    new IPAddressinetArray2MI
                    {
                        Id = 1489277569,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("165.86.216.81"),

System.Net.IPAddress.Parse("245.137.206.18"),

System.Net.IPAddress.Parse("1.79.152.27"),

System.Net.IPAddress.Parse("96.224.29.188"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1578563188,
                    new IPAddressinetArray2MI
                    {
                        Id = 1578563188,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("120.2.76.27"),

System.Net.IPAddress.Parse("83.75.169.142"),

System.Net.IPAddress.Parse("104.84.35.5"),

System.Net.IPAddress.Parse("196.18.179.70"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1683706738,
                    new IPAddressinetArray2MI
                    {
                        Id = 1683706738,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("84.82.80.245"),

System.Net.IPAddress.Parse("232.116.79.125"),

System.Net.IPAddress.Parse("174.46.62.103"),

System.Net.IPAddress.Parse("60.126.156.24"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("13.109.69.5"),

System.Net.IPAddress.Parse("231.51.35.179"),

System.Net.IPAddress.Parse("108.70.229.199"),

}
                    }
                );

                expected.Add(
                    2079482896,
                    new IPAddressinetArray2MI
                    {
                        Id = 2079482896,
                        Value = 
new System.Collections.Generic.List<System.Net.IPAddress>(4)
{
System.Net.IPAddress.Parse("118.145.130.134"),

System.Net.IPAddress.Parse("168.145.47.246"),

System.Net.IPAddress.Parse("133.178.124.149"),

System.Net.IPAddress.Parse("205.208.209.69"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Net.IPAddress>(3)
{
System.Net.IPAddress.Parse("206.4.8.189"),

System.Net.IPAddress.Parse("178.105.254.175"),

System.Net.IPAddress.Parse("32.108.100.214"),

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

