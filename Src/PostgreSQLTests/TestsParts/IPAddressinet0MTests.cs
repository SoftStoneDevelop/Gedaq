

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
    internal partial interface IIPAddressSingleTypeinet
    {
    }
    
    internal partial class IPAddressSingleTypeinet : IIPAddressSingleTypeinet
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinet0mi(
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
            asPartInterface: typeof(IIPAddressSingleTypeinet)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(24)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(24)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinet0mi(
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
            queryMapType: typeof(IPAddressinet0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(24)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(24)
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

                changedRows =  ((IIPAddressSingleTypeinet)this).InsertModelInner(connection, 1629562082, System.Net.IPAddress.Parse("52.35.146.235"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IIPAddressSingleTypeinet)this).InsertModelInner(connection, 48344192, System.Net.IPAddress.Parse("168.45.110.238"), System.Net.IPAddress.Parse("103.80.48.208"));
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

                changedRows = await ((IIPAddressSingleTypeinet)this).InsertModelInnerAsync(connection, 1928037316, System.Net.IPAddress.Parse("78.35.183.128"), System.Net.IPAddress.Parse("243.65.211.8"));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).InsertModelInnerAsync(connection, 543785038, System.Net.IPAddress.Parse("34.173.249.57"), null);
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

                id =  ((IIPAddressSingleTypeinet)this).InsertModelInnerReturning(connection, 1060611269, System.Net.IPAddress.Parse("228.27.9.95"), System.Net.IPAddress.Parse("192.108.251.132"));
                Assert.That(id, Is.EqualTo(1060611269));

                id =  ((IIPAddressSingleTypeinet)this).InsertModelInnerReturning(connection, 1037837526, System.Net.IPAddress.Parse("157.111.28.241"), System.Net.IPAddress.Parse("249.168.176.106"));
                Assert.That(id, Is.EqualTo(1037837526));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IIPAddressSingleTypeinet)this).InsertModelInnerReturningAsync(connection, 1996203882, System.Net.IPAddress.Parse("53.164.134.195"), null);
                Assert.That(id, Is.EqualTo(1996203882));

                id = await ((IIPAddressSingleTypeinet)this).InsertModelInnerReturningAsync(connection, 1767359998, System.Net.IPAddress.Parse("36.203.126.56"), null);
                Assert.That(id, Is.EqualTo(1767359998));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinet0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true
                )
            ]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IIPAddressSingleTypeinet)this).DbConnectionInsertInnerModel(connection, 2065281900, System.Net.IPAddress.Parse("42.147.62.72"), null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertInnerModelAsync(connection, 785133126, System.Net.IPAddress.Parse("40.160.240.229"), System.Net.IPAddress.Parse("105.61.63.175"));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertInnerModelAsync(connection, 1523787210, System.Net.IPAddress.Parse("56.52.163.73"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertInnerModelAsync(connection, 621894605, System.Net.IPAddress.Parse("49.14.15.56"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertInnerModelAsync(connection, 2045397857, System.Net.IPAddress.Parse("23.16.239.58"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertInnerModelAsync(connection, 92305813, System.Net.IPAddress.Parse("164.41.134.250"), System.Net.IPAddress.Parse("239.81.207.242"));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertInnerModelAsync(connection, 1914791576, System.Net.IPAddress.Parse("138.22.156.73"), null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinet0m(
	id,
    value,
    nullablevalue,
    ipaddressinet0mi_id
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
            asPartInterface: typeof(IIPAddressSingleTypeinet)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(24)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(24)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "ipaddressinet0mi_id", 
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

                changedRows =  ((IIPAddressSingleTypeinet)this).InsertModel(connection, 260144249, System.Net.IPAddress.Parse("92.42.73.150"), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IIPAddressSingleTypeinet)this).InsertModel(connection, 31110243, System.Net.IPAddress.Parse("76.248.180.103"), System.Net.IPAddress.Parse("149.95.190.235"), 1629562082);
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

                changedRows = await ((IIPAddressSingleTypeinet)this).InsertModelAsync(connection, 338499233, System.Net.IPAddress.Parse("196.95.177.177"), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).InsertModelAsync(connection, 1100969356, System.Net.IPAddress.Parse("168.226.17.159"), null, 48344192);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Net.IPAddress nullable = null;

                nullable =  ((IIPAddressSingleTypeinet)this).ScalarInsertModelReturning(connection, 1183409549, System.Net.IPAddress.Parse("94.84.16.204"), null, null);

                Assert.That(nullable, Is.Null);

                nullable =  ((IIPAddressSingleTypeinet)this).ScalarInsertModelReturning(connection, 1974935209, System.Net.IPAddress.Parse("73.113.92.236"), System.Net.IPAddress.Parse("193.252.107.47"), 1928037316);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(System.Net.IPAddress.Parse("193.252.107.47")));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Net.IPAddress nullable = null;

                nullable = await ((IIPAddressSingleTypeinet)this).ScalarInsertModelReturningAsync(connection, 758492807, System.Net.IPAddress.Parse("123.15.197.244"), System.Net.IPAddress.Parse("202.117.43.158"), null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(System.Net.IPAddress.Parse("202.117.43.158")));

                nullable = await ((IIPAddressSingleTypeinet)this).ScalarInsertModelReturningAsync(connection, 1701908099, System.Net.IPAddress.Parse("26.173.143.228"), null, 543785038);

                Assert.That(nullable, Is.Null);

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinet0m(
	id,
    value,
    nullablevalue,
    ipaddressinet0mi_id
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
    ipaddressinet0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(IPAddressinet0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(24)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(24)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "ipaddressinet0mi_id", 
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
                List<IPAddressinet0M> models = null;
                IPAddressinet0M model = null;

                models =  ((IIPAddressSingleTypeinet)this).InsertModelReturning(connection, 772352621, System.Net.IPAddress.Parse("222.50.15.252"), null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(772352621));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("222.50.15.252")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IIPAddressSingleTypeinet)this).InsertModelReturning(connection, 511234353, System.Net.IPAddress.Parse("127.190.212.37"), null, 1060611269).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(511234353));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("127.190.212.37")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1060611269));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Net.IPAddress)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IIPAddressSingleTypeinet)this).InsertModelReturning(connection, 1159055059, System.Net.IPAddress.Parse("111.236.168.159"), null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1159055059));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("111.236.168.159")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IIPAddressSingleTypeinet)this).InsertModelReturning(connection, 1698183444, System.Net.IPAddress.Parse("94.110.37.43"), null, 1037837526).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1698183444));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("94.110.37.43")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1037837526));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Net.IPAddress)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinet0M> models = null;
                IPAddressinet0M model = null;

                models = await ((IIPAddressSingleTypeinet)this).InsertModelReturningAsync(connection, 2103206234, System.Net.IPAddress.Parse("163.189.55.188"), System.Net.IPAddress.Parse("1.219.185.7"), null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103206234));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("163.189.55.188")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("1.219.185.7")));

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IIPAddressSingleTypeinet)this).InsertModelReturningAsync(connection, 1613792341, System.Net.IPAddress.Parse("166.247.5.76"), System.Net.IPAddress.Parse("138.240.83.0"), 1996203882).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1613792341));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("166.247.5.76")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("138.240.83.0")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1996203882));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Net.IPAddress)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IIPAddressSingleTypeinet)this).InsertModelReturningAsync(connection, 1430947879, System.Net.IPAddress.Parse("93.111.223.59"), System.Net.IPAddress.Parse("186.198.244.109"), null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1430947879));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("93.111.223.59")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("186.198.244.109")));

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IIPAddressSingleTypeinet)this).InsertModelReturningAsync(connection, 543046904, System.Net.IPAddress.Parse("78.244.40.214"), null, 1767359998).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(543046904));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("78.244.40.214")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1767359998));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Net.IPAddress)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinet0m(
	id,
    value,
    nullablevalue,
    ipaddressinet0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @ipaddressinet0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Net.IPAddress), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "ipaddressinet0mi_id", 
                methodParametrName: "ipaddressinet0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true
            )
            ]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IIPAddressSingleTypeinet)this).DbConnectionInsertModel(connection, 1951076245, System.Net.IPAddress.Parse("201.154.253.34"), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IIPAddressSingleTypeinet)this).DbConnectionInsertModel(connection, 151615321, System.Net.IPAddress.Parse("224.10.68.14"), null, 2065281900);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, 211290950, System.Net.IPAddress.Parse("3.40.152.124"), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, 815758951, System.Net.IPAddress.Parse("219.133.174.174"), null, 785133126);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, 1333814213, System.Net.IPAddress.Parse("242.154.78.253"), System.Net.IPAddress.Parse("223.100.7.69"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, 1865715688, System.Net.IPAddress.Parse("166.53.176.166"), null, 1523787210);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, 686871144, System.Net.IPAddress.Parse("90.83.172.28"), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, 1735093903, System.Net.IPAddress.Parse("73.192.16.237"), null, 621894605);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, 646809985, System.Net.IPAddress.Parse("110.100.36.39"), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, 972774719, System.Net.IPAddress.Parse("252.216.26.104"), null, 2045397857);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, 792952108, System.Net.IPAddress.Parse("251.78.78.41"), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, 2130252516, System.Net.IPAddress.Parse("218.254.144.159"), System.Net.IPAddress.Parse("254.52.163.254"), 92305813);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, 1634973760, System.Net.IPAddress.Parse("126.91.7.115"), System.Net.IPAddress.Parse("103.123.220.109"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, 1815306502, System.Net.IPAddress.Parse("86.182.234.220"), null, 1914791576);
                Assert.That(changedRows, Is.EqualTo(1));

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
FROM public.ipaddressinet0m m
LEFT JOIN public.ipaddressinet0mi mi ON mi.id = m.ipaddressinet0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(IPAddressinet0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)
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
                var models =  ((IIPAddressSingleTypeinet)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(31110243));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("76.248.180.103")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("149.95.190.235")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1629562082));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("52.35.146.235")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(151615321));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("224.10.68.14")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2065281900));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("42.147.62.72")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(211290950));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("3.40.152.124")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(260144249));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("92.42.73.150")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(338499233));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("196.95.177.177")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(511234353));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("127.190.212.37")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1060611269));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("228.27.9.95")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("192.108.251.132")));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(543046904));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("78.244.40.214")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1767359998));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("36.203.126.56")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(646809985));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("110.100.36.39")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(686871144));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("90.83.172.28")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(758492807));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("123.15.197.244")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("202.117.43.158")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(772352621));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("222.50.15.252")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(792952108));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("251.78.78.41")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(815758951));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("219.133.174.174")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(785133126));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("40.160.240.229")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("105.61.63.175")));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(972774719));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("252.216.26.104")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2045397857));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("23.16.239.58")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1100969356));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("168.226.17.159")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(48344192));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("168.45.110.238")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("103.80.48.208")));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1159055059));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("111.236.168.159")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1183409549));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("94.84.16.204")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1333814213));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("242.154.78.253")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("223.100.7.69")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1430947879));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("93.111.223.59")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("186.198.244.109")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1613792341));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("166.247.5.76")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("138.240.83.0")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1996203882));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("53.164.134.195")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634973760));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("126.91.7.115")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("103.123.220.109")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1698183444));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("94.110.37.43")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1037837526));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("157.111.28.241")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("249.168.176.106")));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1701908099));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("26.173.143.228")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(543785038));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("34.173.249.57")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735093903));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("73.192.16.237")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(621894605));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("49.14.15.56")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1815306502));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("86.182.234.220")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1914791576));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("138.22.156.73")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865715688));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("166.53.176.166")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523787210));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("56.52.163.73")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1951076245));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("201.154.253.34")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1974935209));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("73.113.92.236")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("193.252.107.47")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1928037316));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("78.35.183.128")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("243.65.211.8")));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103206234));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("163.189.55.188")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("1.219.185.7")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2130252516));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("218.254.144.159")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("254.52.163.254")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92305813));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("164.41.134.250")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("239.81.207.242")));

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressSingleTypeinet)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(31110243));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("76.248.180.103")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("149.95.190.235")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1629562082));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("52.35.146.235")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(151615321));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("224.10.68.14")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2065281900));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("42.147.62.72")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(211290950));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("3.40.152.124")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(260144249));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("92.42.73.150")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(338499233));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("196.95.177.177")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(511234353));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("127.190.212.37")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1060611269));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("228.27.9.95")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("192.108.251.132")));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(543046904));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("78.244.40.214")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1767359998));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("36.203.126.56")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(646809985));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("110.100.36.39")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(686871144));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("90.83.172.28")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(758492807));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("123.15.197.244")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("202.117.43.158")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(772352621));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("222.50.15.252")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(792952108));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("251.78.78.41")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(815758951));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("219.133.174.174")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(785133126));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("40.160.240.229")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("105.61.63.175")));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(972774719));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("252.216.26.104")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2045397857));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("23.16.239.58")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1100969356));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("168.226.17.159")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(48344192));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("168.45.110.238")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("103.80.48.208")));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1159055059));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("111.236.168.159")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1183409549));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("94.84.16.204")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1333814213));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("242.154.78.253")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("223.100.7.69")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1430947879));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("93.111.223.59")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("186.198.244.109")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1613792341));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("166.247.5.76")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("138.240.83.0")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1996203882));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("53.164.134.195")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634973760));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("126.91.7.115")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("103.123.220.109")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1698183444));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("94.110.37.43")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1037837526));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("157.111.28.241")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("249.168.176.106")));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1701908099));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("26.173.143.228")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(543785038));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("34.173.249.57")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735093903));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("73.192.16.237")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(621894605));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("49.14.15.56")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1815306502));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("86.182.234.220")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1914791576));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("138.22.156.73")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865715688));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("166.53.176.166")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523787210));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("56.52.163.73")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1951076245));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("201.154.253.34")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1974935209));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("73.113.92.236")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("193.252.107.47")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1928037316));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("78.35.183.128")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("243.65.211.8")));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103206234));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("163.189.55.188")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("1.219.185.7")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2130252516));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("218.254.144.159")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("254.52.163.254")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92305813));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("164.41.134.250")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("239.81.207.242")));

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
FROM public.ipaddressinet0m m
LEFT JOIN public.ipaddressinet0mi mi ON mi.id = m.ipaddressinet0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(IPAddressinet0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)
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
                var models =  ((IIPAddressSingleTypeinet)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(31110243));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("76.248.180.103")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("149.95.190.235")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1629562082));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("52.35.146.235")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(151615321));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("224.10.68.14")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2065281900));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("42.147.62.72")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(211290950));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("3.40.152.124")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(260144249));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("92.42.73.150")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(338499233));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("196.95.177.177")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(511234353));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("127.190.212.37")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1060611269));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("228.27.9.95")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("192.108.251.132")));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(543046904));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("78.244.40.214")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1767359998));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("36.203.126.56")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(646809985));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("110.100.36.39")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(686871144));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("90.83.172.28")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(758492807));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("123.15.197.244")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("202.117.43.158")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(772352621));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("222.50.15.252")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(792952108));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("251.78.78.41")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(815758951));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("219.133.174.174")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(785133126));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("40.160.240.229")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("105.61.63.175")));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(972774719));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("252.216.26.104")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2045397857));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("23.16.239.58")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1100969356));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("168.226.17.159")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(48344192));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("168.45.110.238")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("103.80.48.208")));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1159055059));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("111.236.168.159")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1183409549));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("94.84.16.204")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1333814213));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("242.154.78.253")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("223.100.7.69")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1430947879));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("93.111.223.59")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("186.198.244.109")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1613792341));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("166.247.5.76")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("138.240.83.0")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1996203882));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("53.164.134.195")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634973760));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("126.91.7.115")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("103.123.220.109")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1698183444));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("94.110.37.43")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1037837526));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("157.111.28.241")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("249.168.176.106")));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1701908099));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("26.173.143.228")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(543785038));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("34.173.249.57")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735093903));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("73.192.16.237")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(621894605));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("49.14.15.56")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1815306502));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("86.182.234.220")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1914791576));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("138.22.156.73")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865715688));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("166.53.176.166")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523787210));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("56.52.163.73")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1951076245));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("201.154.253.34")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1974935209));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("73.113.92.236")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("193.252.107.47")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1928037316));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("78.35.183.128")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("243.65.211.8")));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103206234));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("163.189.55.188")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("1.219.185.7")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2130252516));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("218.254.144.159")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("254.52.163.254")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92305813));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("164.41.134.250")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("239.81.207.242")));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressSingleTypeinet)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(31110243));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("76.248.180.103")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("149.95.190.235")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1629562082));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("52.35.146.235")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(151615321));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("224.10.68.14")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2065281900));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("42.147.62.72")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(211290950));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("3.40.152.124")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(260144249));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("92.42.73.150")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(338499233));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("196.95.177.177")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(511234353));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("127.190.212.37")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1060611269));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("228.27.9.95")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("192.108.251.132")));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(543046904));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("78.244.40.214")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1767359998));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("36.203.126.56")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(646809985));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("110.100.36.39")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(686871144));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("90.83.172.28")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(758492807));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("123.15.197.244")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("202.117.43.158")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(772352621));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("222.50.15.252")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(792952108));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("251.78.78.41")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(815758951));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("219.133.174.174")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(785133126));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("40.160.240.229")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("105.61.63.175")));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(972774719));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("252.216.26.104")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2045397857));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("23.16.239.58")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1100969356));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("168.226.17.159")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(48344192));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("168.45.110.238")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("103.80.48.208")));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1159055059));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("111.236.168.159")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1183409549));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("94.84.16.204")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1333814213));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("242.154.78.253")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("223.100.7.69")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1430947879));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("93.111.223.59")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("186.198.244.109")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1613792341));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("166.247.5.76")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("138.240.83.0")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1996203882));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("53.164.134.195")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634973760));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("126.91.7.115")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("103.123.220.109")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1698183444));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("94.110.37.43")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1037837526));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("157.111.28.241")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("249.168.176.106")));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1701908099));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("26.173.143.228")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(543785038));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("34.173.249.57")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735093903));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("73.192.16.237")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(621894605));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("49.14.15.56")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1815306502));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("86.182.234.220")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1914791576));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("138.22.156.73")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865715688));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("166.53.176.166")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523787210));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("56.52.163.73")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1951076245));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("201.154.253.34")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1974935209));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("73.113.92.236")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("193.252.107.47")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1928037316));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("78.35.183.128")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("243.65.211.8")));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103206234));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("163.189.55.188")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("1.219.185.7")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2130252516));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("218.254.144.159")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("254.52.163.254")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92305813));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("164.41.134.250")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("239.81.207.242")));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressSingleTypeinet)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressSingleTypeinet)this).SetDbConnectionSelectModelParametrs(cmd, 646809985);
                var models =  ((IIPAddressSingleTypeinet)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(22));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(686871144));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("90.83.172.28")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(758492807));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("123.15.197.244")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("202.117.43.158")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(772352621));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("222.50.15.252")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(792952108));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("251.78.78.41")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(815758951));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("219.133.174.174")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(785133126));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("40.160.240.229")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("105.61.63.175")));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(972774719));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("252.216.26.104")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2045397857));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("23.16.239.58")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1100969356));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("168.226.17.159")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(48344192));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("168.45.110.238")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("103.80.48.208")));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1159055059));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("111.236.168.159")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1183409549));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("94.84.16.204")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1333814213));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("242.154.78.253")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("223.100.7.69")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1430947879));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("93.111.223.59")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("186.198.244.109")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1613792341));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("166.247.5.76")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("138.240.83.0")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1996203882));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("53.164.134.195")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634973760));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("126.91.7.115")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("103.123.220.109")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1698183444));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("94.110.37.43")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1037837526));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("157.111.28.241")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("249.168.176.106")));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1701908099));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("26.173.143.228")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(543785038));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("34.173.249.57")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735093903));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("73.192.16.237")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(621894605));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("49.14.15.56")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1815306502));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("86.182.234.220")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1914791576));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("138.22.156.73")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865715688));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("166.53.176.166")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523787210));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("56.52.163.73")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1951076245));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("201.154.253.34")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1974935209));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("73.113.92.236")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("193.252.107.47")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1928037316));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("78.35.183.128")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("243.65.211.8")));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103206234));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("163.189.55.188")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("1.219.185.7")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2130252516));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("218.254.144.159")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("254.52.163.254")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92305813));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("164.41.134.250")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("239.81.207.242")));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IIPAddressSingleTypeinet)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IIPAddressSingleTypeinet)this).SetDbConnectionSelectModelParametrs(cmd, 686871144);
                var models = await ((IIPAddressSingleTypeinet)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(21));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(758492807));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("123.15.197.244")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("202.117.43.158")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(772352621));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("222.50.15.252")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(792952108));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("251.78.78.41")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(815758951));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("219.133.174.174")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(785133126));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("40.160.240.229")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("105.61.63.175")));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(972774719));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("252.216.26.104")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2045397857));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("23.16.239.58")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1100969356));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("168.226.17.159")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(48344192));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("168.45.110.238")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("103.80.48.208")));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1159055059));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("111.236.168.159")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1183409549));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("94.84.16.204")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1333814213));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("242.154.78.253")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("223.100.7.69")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1430947879));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("93.111.223.59")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("186.198.244.109")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1613792341));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("166.247.5.76")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("138.240.83.0")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1996203882));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("53.164.134.195")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634973760));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("126.91.7.115")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("103.123.220.109")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1698183444));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("94.110.37.43")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1037837526));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("157.111.28.241")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("249.168.176.106")));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1701908099));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("26.173.143.228")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(543785038));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("34.173.249.57")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735093903));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("73.192.16.237")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(621894605));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("49.14.15.56")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1815306502));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("86.182.234.220")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1914791576));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("138.22.156.73")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865715688));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("166.53.176.166")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523787210));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("56.52.163.73")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1951076245));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("201.154.253.34")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1974935209));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("73.113.92.236")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("193.252.107.47")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1928037316));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("78.35.183.128")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("243.65.211.8")));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103206234));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("163.189.55.188")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("1.219.185.7")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2130252516));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("218.254.144.159")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("254.52.163.254")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92305813));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("164.41.134.250")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("239.81.207.242")));

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)
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
                 foreach(var batchResult in ((IIPAddressSingleTypeinet)this).DbConnectionSelectModelBatch(connection, 1634973760, 1974935209))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(9));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1698183444));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("94.110.37.43")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1037837526));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("157.111.28.241")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("249.168.176.106")));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1701908099));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("26.173.143.228")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(543785038));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("34.173.249.57")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735093903));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("73.192.16.237")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(621894605));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("49.14.15.56")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1815306502));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("86.182.234.220")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1914791576));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("138.22.156.73")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865715688));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("166.53.176.166")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523787210));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("56.52.163.73")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1951076245));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("201.154.253.34")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1974935209));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("73.113.92.236")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("193.252.107.47")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1928037316));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("78.35.183.128")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("243.65.211.8")));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103206234));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("163.189.55.188")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("1.219.185.7")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2130252516));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("218.254.144.159")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("254.52.163.254")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92305813));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("164.41.134.250")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("239.81.207.242")));

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(2));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103206234));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("163.189.55.188")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("1.219.185.7")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2130252516));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("218.254.144.159")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("254.52.163.254")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92305813));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("164.41.134.250")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("239.81.207.242")));

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
                await foreach(var batchResult in ((IIPAddressSingleTypeinet)this).DbConnectionSelectModelBatchAsync(connection, 758492807, 1815306502))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(20));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(772352621));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("222.50.15.252")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(792952108));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("251.78.78.41")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(815758951));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("219.133.174.174")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(785133126));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("40.160.240.229")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("105.61.63.175")));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(972774719));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("252.216.26.104")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2045397857));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("23.16.239.58")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1100969356));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("168.226.17.159")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(48344192));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("168.45.110.238")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("103.80.48.208")));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1159055059));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("111.236.168.159")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1183409549));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("94.84.16.204")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1333814213));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("242.154.78.253")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("223.100.7.69")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1430947879));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("93.111.223.59")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("186.198.244.109")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1613792341));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("166.247.5.76")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("138.240.83.0")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1996203882));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("53.164.134.195")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634973760));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("126.91.7.115")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("103.123.220.109")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1698183444));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("94.110.37.43")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1037837526));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("157.111.28.241")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("249.168.176.106")));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1701908099));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("26.173.143.228")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(543785038));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("34.173.249.57")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735093903));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("73.192.16.237")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(621894605));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("49.14.15.56")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1815306502));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("86.182.234.220")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1914791576));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("138.22.156.73")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865715688));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("166.53.176.166")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523787210));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("56.52.163.73")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1951076245));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("201.154.253.34")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1974935209));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("73.113.92.236")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("193.252.107.47")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1928037316));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("78.35.183.128")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("243.65.211.8")));

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103206234));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("163.189.55.188")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("1.219.185.7")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2130252516));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("218.254.144.159")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("254.52.163.254")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92305813));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("164.41.134.250")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("239.81.207.242")));

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(5));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865715688));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("166.53.176.166")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523787210));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("56.52.163.73")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1951076245));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("201.154.253.34")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1974935209));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("73.113.92.236")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("193.252.107.47")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1928037316));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("78.35.183.128")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("243.65.211.8")));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103206234));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("163.189.55.188")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("1.219.185.7")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2130252516));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("218.254.144.159")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("254.52.163.254")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92305813));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("164.41.134.250")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("239.81.207.242")));

                        continue;
                    }
                    
                    //todo return false
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
FROM public.ipaddressinet0m m
LEFT JOIN public.ipaddressinet0mi mi ON mi.id = m.ipaddressinet0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapType: typeof(object[]),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)
            )
            ]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IIPAddressSingleTypeinet)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31110243)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("76.248.180.103"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1629562082)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("52.35.146.235"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("149.95.190.235"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151615321)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("224.10.68.14"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2065281900)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("42.147.62.72"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((211290950)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("3.40.152.124"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((260144249)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("92.42.73.150"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((338499233)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("196.95.177.177"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((511234353)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("127.190.212.37"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1060611269)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("228.27.9.95"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("192.108.251.132"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((543046904)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("78.244.40.214"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1767359998)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("36.203.126.56"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((646809985)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("110.100.36.39"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((686871144)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("90.83.172.28"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((758492807)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("123.15.197.244"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("202.117.43.158"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((772352621)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("222.50.15.252"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((792952108)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("251.78.78.41"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((815758951)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("219.133.174.174"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((785133126)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("40.160.240.229"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("105.61.63.175"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((972774719)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("252.216.26.104"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2045397857)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("23.16.239.58"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1100969356)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("168.226.17.159"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48344192)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("168.45.110.238"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("103.80.48.208"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1159055059)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("111.236.168.159"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1183409549)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("94.84.16.204"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1333814213)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("242.154.78.253"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("223.100.7.69"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1430947879)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("93.111.223.59"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("186.198.244.109"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1613792341)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("166.247.5.76"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1996203882)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("53.164.134.195"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("138.240.83.0"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1634973760)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("126.91.7.115"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("103.123.220.109"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1698183444)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("94.110.37.43"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1037837526)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("157.111.28.241"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("249.168.176.106"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1701908099)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("26.173.143.228"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((543785038)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("34.173.249.57"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1735093903)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("73.192.16.237"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((621894605)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("49.14.15.56"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1815306502)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("86.182.234.220"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1914791576)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("138.22.156.73"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1865715688)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("166.53.176.166"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1523787210)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("56.52.163.73"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1951076245)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("201.154.253.34"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1974935209)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("73.113.92.236"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1928037316)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("78.35.183.128"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("243.65.211.8"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("193.252.107.47"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2103206234)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("163.189.55.188"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("1.219.185.7"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2130252516)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("218.254.144.159"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92305813)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("164.41.134.250"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("239.81.207.242"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("254.52.163.254"))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressSingleTypeinet)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31110243)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("76.248.180.103"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1629562082)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("52.35.146.235"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("149.95.190.235"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151615321)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("224.10.68.14"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2065281900)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("42.147.62.72"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((211290950)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("3.40.152.124"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((260144249)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("92.42.73.150"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((338499233)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("196.95.177.177"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((511234353)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("127.190.212.37"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1060611269)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("228.27.9.95"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("192.108.251.132"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((543046904)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("78.244.40.214"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1767359998)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("36.203.126.56"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((646809985)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("110.100.36.39"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((686871144)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("90.83.172.28"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((758492807)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("123.15.197.244"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("202.117.43.158"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((772352621)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("222.50.15.252"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((792952108)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("251.78.78.41"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((815758951)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("219.133.174.174"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((785133126)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("40.160.240.229"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("105.61.63.175"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((972774719)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("252.216.26.104"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2045397857)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("23.16.239.58"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1100969356)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("168.226.17.159"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48344192)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("168.45.110.238"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("103.80.48.208"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1159055059)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("111.236.168.159"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1183409549)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("94.84.16.204"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1333814213)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("242.154.78.253"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("223.100.7.69"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1430947879)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("93.111.223.59"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("186.198.244.109"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1613792341)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("166.247.5.76"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1996203882)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("53.164.134.195"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("138.240.83.0"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1634973760)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("126.91.7.115"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("103.123.220.109"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1698183444)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("94.110.37.43"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1037837526)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("157.111.28.241"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("249.168.176.106"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1701908099)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("26.173.143.228"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((543785038)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("34.173.249.57"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1735093903)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("73.192.16.237"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((621894605)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("49.14.15.56"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1815306502)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("86.182.234.220"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1914791576)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("138.22.156.73"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1865715688)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("166.53.176.166"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1523787210)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("56.52.163.73"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1951076245)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("201.154.253.34"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1974935209)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("73.113.92.236"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1928037316)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("78.35.183.128"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("243.65.211.8"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("193.252.107.47"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2103206234)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("163.189.55.188"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("1.219.185.7"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2130252516)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("218.254.144.159"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92305813)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("164.41.134.250"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("239.81.207.242"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("254.52.163.254"))));

            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinet0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(IPAddressinet0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(24),
                (NpgsqlTypes.NpgsqlDbType)(24)
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
FROM public.binary_ipaddressinet0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(IPAddressinet0MI),
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

                var importCollection = new List<IPAddressinet0MI>(7);

                importCollection.Add(
                new IPAddressinet0MI
                {
                    Id = 48344192,
                    Value = System.Net.IPAddress.Parse("168.45.110.238"),
                    NullableValue = System.Net.IPAddress.Parse("103.80.48.208")
                });

                importCollection.Add(
                new IPAddressinet0MI
                {
                    Id = 92305813,
                    Value = System.Net.IPAddress.Parse("164.41.134.250"),
                    NullableValue = System.Net.IPAddress.Parse("239.81.207.242")
                });

                importCollection.Add(
                new IPAddressinet0MI
                {
                    Id = 543785038,
                    Value = System.Net.IPAddress.Parse("34.173.249.57"),
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinet0MI
                {
                    Id = 621894605,
                    Value = System.Net.IPAddress.Parse("49.14.15.56"),
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinet0MI
                {
                    Id = 785133126,
                    Value = System.Net.IPAddress.Parse("40.160.240.229"),
                    NullableValue = System.Net.IPAddress.Parse("105.61.63.175")
                });

                importCollection.Add(
                new IPAddressinet0MI
                {
                    Id = 1037837526,
                    Value = System.Net.IPAddress.Parse("157.111.28.241"),
                    NullableValue = System.Net.IPAddress.Parse("249.168.176.106")
                });

                importCollection.Add(
                new IPAddressinet0MI
                {
                    Id = 1060611269,
                    Value = System.Net.IPAddress.Parse("228.27.9.95"),
                    NullableValue = System.Net.IPAddress.Parse("192.108.251.132")
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(48344192));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("168.45.110.238")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("103.80.48.208")));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(92305813));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("164.41.134.250")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("239.81.207.242")));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(543785038));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("34.173.249.57")));

                Assert.That(model.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(621894605));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("49.14.15.56")));

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(785133126));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("40.160.240.229")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("105.61.63.175")));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1037837526));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("157.111.28.241")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("249.168.176.106")));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1060611269));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("228.27.9.95")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("192.108.251.132")));

                importCollection.Clear();

                importCollection.Add(
                new IPAddressinet0MI
                {
                    Id = 1523787210,
                    Value = System.Net.IPAddress.Parse("56.52.163.73"),
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinet0MI
                {
                    Id = 1629562082,
                    Value = System.Net.IPAddress.Parse("52.35.146.235"),
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinet0MI
                {
                    Id = 1767359998,
                    Value = System.Net.IPAddress.Parse("36.203.126.56"),
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinet0MI
                {
                    Id = 1914791576,
                    Value = System.Net.IPAddress.Parse("138.22.156.73"),
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinet0MI
                {
                    Id = 1928037316,
                    Value = System.Net.IPAddress.Parse("78.35.183.128"),
                    NullableValue = System.Net.IPAddress.Parse("243.65.211.8")
                });

                importCollection.Add(
                new IPAddressinet0MI
                {
                    Id = 1996203882,
                    Value = System.Net.IPAddress.Parse("53.164.134.195"),
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinet0MI
                {
                    Id = 2045397857,
                    Value = System.Net.IPAddress.Parse("23.16.239.58"),
                    NullableValue = null
                });

                importCollection.Add(
                new IPAddressinet0MI
                {
                    Id = 2065281900,
                    Value = System.Net.IPAddress.Parse("42.147.62.72"),
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(48344192));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("168.45.110.238")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("103.80.48.208")));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(92305813));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("164.41.134.250")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("239.81.207.242")));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(543785038));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("34.173.249.57")));

                Assert.That(model.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(621894605));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("49.14.15.56")));

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(785133126));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("40.160.240.229")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("105.61.63.175")));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1037837526));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("157.111.28.241")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("249.168.176.106")));


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1060611269));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("228.27.9.95")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("192.108.251.132")));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1523787210));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("56.52.163.73")));

                Assert.That(model.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1629562082));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("52.35.146.235")));

                Assert.That(model.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1767359998));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("36.203.126.56")));

                Assert.That(model.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1914791576));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("138.22.156.73")));

                Assert.That(model.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1928037316));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("78.35.183.128")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("243.65.211.8")));


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1996203882));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("53.164.134.195")));

                Assert.That(model.NullableValue, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2045397857));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("23.16.239.58")));

                Assert.That(model.NullableValue, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2065281900));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("42.147.62.72")));

                Assert.That(model.NullableValue, Is.Null);


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinet0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
ipaddressinet0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(IPAddressinet0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(24),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(24)
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
FROM public.binary_ipaddressinet0m m
LEFT JOIN public.binary_ipaddressinet0mi mi ON mi.id = m.ipaddressinet0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(IPAddressinet0M),
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

                var importCollection = new List<IPAddressinet0M>(15);

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 31110243,
                    Value = System.Net.IPAddress.Parse("76.248.180.103"),
                    NullableValue = System.Net.IPAddress.Parse("149.95.190.235"),

                    ModelInner = new IPAddressinet0MI 
                    {
                        Id = 1629562082
                    }

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 151615321,
                    Value = System.Net.IPAddress.Parse("224.10.68.14"),
                    NullableValue = null,

                    ModelInner = new IPAddressinet0MI 
                    {
                        Id = 2065281900
                    }

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 211290950,
                    Value = System.Net.IPAddress.Parse("3.40.152.124"),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 260144249,
                    Value = System.Net.IPAddress.Parse("92.42.73.150"),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 338499233,
                    Value = System.Net.IPAddress.Parse("196.95.177.177"),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 511234353,
                    Value = System.Net.IPAddress.Parse("127.190.212.37"),
                    NullableValue = null,

                    ModelInner = new IPAddressinet0MI 
                    {
                        Id = 1060611269
                    }

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 543046904,
                    Value = System.Net.IPAddress.Parse("78.244.40.214"),
                    NullableValue = null,

                    ModelInner = new IPAddressinet0MI 
                    {
                        Id = 1767359998
                    }

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 646809985,
                    Value = System.Net.IPAddress.Parse("110.100.36.39"),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 686871144,
                    Value = System.Net.IPAddress.Parse("90.83.172.28"),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 758492807,
                    Value = System.Net.IPAddress.Parse("123.15.197.244"),
                    NullableValue = System.Net.IPAddress.Parse("202.117.43.158"),

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 772352621,
                    Value = System.Net.IPAddress.Parse("222.50.15.252"),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 792952108,
                    Value = System.Net.IPAddress.Parse("251.78.78.41"),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 815758951,
                    Value = System.Net.IPAddress.Parse("219.133.174.174"),
                    NullableValue = null,

                    ModelInner = new IPAddressinet0MI 
                    {
                        Id = 785133126
                    }

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 972774719,
                    Value = System.Net.IPAddress.Parse("252.216.26.104"),
                    NullableValue = null,

                    ModelInner = new IPAddressinet0MI 
                    {
                        Id = 2045397857
                    }

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 1100969356,
                    Value = System.Net.IPAddress.Parse("168.226.17.159"),
                    NullableValue = null,

                    ModelInner = new IPAddressinet0MI 
                    {
                        Id = 48344192
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(31110243));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("76.248.180.103")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("149.95.190.235")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1629562082));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("52.35.146.235")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(151615321));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("224.10.68.14")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2065281900));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("42.147.62.72")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(211290950));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("3.40.152.124")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(260144249));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("92.42.73.150")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(338499233));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("196.95.177.177")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(511234353));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("127.190.212.37")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1060611269));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("228.27.9.95")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("192.108.251.132")));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(543046904));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("78.244.40.214")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1767359998));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("36.203.126.56")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(646809985));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("110.100.36.39")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(686871144));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("90.83.172.28")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(758492807));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("123.15.197.244")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("202.117.43.158")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(772352621));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("222.50.15.252")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(792952108));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("251.78.78.41")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(815758951));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("219.133.174.174")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(785133126));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("40.160.240.229")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("105.61.63.175")));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(972774719));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("252.216.26.104")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2045397857));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("23.16.239.58")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1100969356));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("168.226.17.159")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(48344192));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("168.45.110.238")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("103.80.48.208")));

                importCollection.Clear();

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 1159055059,
                    Value = System.Net.IPAddress.Parse("111.236.168.159"),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 1183409549,
                    Value = System.Net.IPAddress.Parse("94.84.16.204"),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 1333814213,
                    Value = System.Net.IPAddress.Parse("242.154.78.253"),
                    NullableValue = System.Net.IPAddress.Parse("223.100.7.69"),

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 1430947879,
                    Value = System.Net.IPAddress.Parse("93.111.223.59"),
                    NullableValue = System.Net.IPAddress.Parse("186.198.244.109"),

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 1613792341,
                    Value = System.Net.IPAddress.Parse("166.247.5.76"),
                    NullableValue = System.Net.IPAddress.Parse("138.240.83.0"),

                    ModelInner = new IPAddressinet0MI 
                    {
                        Id = 1996203882
                    }

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 1634973760,
                    Value = System.Net.IPAddress.Parse("126.91.7.115"),
                    NullableValue = System.Net.IPAddress.Parse("103.123.220.109"),

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 1698183444,
                    Value = System.Net.IPAddress.Parse("94.110.37.43"),
                    NullableValue = null,

                    ModelInner = new IPAddressinet0MI 
                    {
                        Id = 1037837526
                    }

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 1701908099,
                    Value = System.Net.IPAddress.Parse("26.173.143.228"),
                    NullableValue = null,

                    ModelInner = new IPAddressinet0MI 
                    {
                        Id = 543785038
                    }

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 1735093903,
                    Value = System.Net.IPAddress.Parse("73.192.16.237"),
                    NullableValue = null,

                    ModelInner = new IPAddressinet0MI 
                    {
                        Id = 621894605
                    }

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 1815306502,
                    Value = System.Net.IPAddress.Parse("86.182.234.220"),
                    NullableValue = null,

                    ModelInner = new IPAddressinet0MI 
                    {
                        Id = 1914791576
                    }

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 1865715688,
                    Value = System.Net.IPAddress.Parse("166.53.176.166"),
                    NullableValue = null,

                    ModelInner = new IPAddressinet0MI 
                    {
                        Id = 1523787210
                    }

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 1951076245,
                    Value = System.Net.IPAddress.Parse("201.154.253.34"),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 1974935209,
                    Value = System.Net.IPAddress.Parse("73.113.92.236"),
                    NullableValue = System.Net.IPAddress.Parse("193.252.107.47"),

                    ModelInner = new IPAddressinet0MI 
                    {
                        Id = 1928037316
                    }

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 2103206234,
                    Value = System.Net.IPAddress.Parse("163.189.55.188"),
                    NullableValue = System.Net.IPAddress.Parse("1.219.185.7"),

                    ModelInner = null

                });

                importCollection.Add(
                new IPAddressinet0M
                {
                    Id = 2130252516,
                    Value = System.Net.IPAddress.Parse("218.254.144.159"),
                    NullableValue = System.Net.IPAddress.Parse("254.52.163.254"),

                    ModelInner = new IPAddressinet0MI 
                    {
                        Id = 92305813
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(31110243));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("76.248.180.103")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("149.95.190.235")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1629562082));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("52.35.146.235")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(151615321));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("224.10.68.14")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2065281900));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("42.147.62.72")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(211290950));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("3.40.152.124")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(260144249));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("92.42.73.150")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(338499233));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("196.95.177.177")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(511234353));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("127.190.212.37")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1060611269));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("228.27.9.95")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("192.108.251.132")));


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(543046904));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("78.244.40.214")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1767359998));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("36.203.126.56")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(646809985));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("110.100.36.39")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(686871144));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("90.83.172.28")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(758492807));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("123.15.197.244")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("202.117.43.158")));

                Assert.That(model.ModelInner, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(772352621));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("222.50.15.252")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(792952108));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("251.78.78.41")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(815758951));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("219.133.174.174")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(785133126));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("40.160.240.229")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("105.61.63.175")));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(972774719));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("252.216.26.104")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2045397857));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("23.16.239.58")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1100969356));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("168.226.17.159")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(48344192));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("168.45.110.238")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("103.80.48.208")));


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1159055059));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("111.236.168.159")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1183409549));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("94.84.16.204")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1333814213));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("242.154.78.253")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("223.100.7.69")));

                Assert.That(model.ModelInner, Is.Null);


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1430947879));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("93.111.223.59")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("186.198.244.109")));

                Assert.That(model.ModelInner, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1613792341));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("166.247.5.76")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("138.240.83.0")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1996203882));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("53.164.134.195")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634973760));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("126.91.7.115")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("103.123.220.109")));

                Assert.That(model.ModelInner, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1698183444));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("94.110.37.43")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1037837526));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("157.111.28.241")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("249.168.176.106")));


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1701908099));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("26.173.143.228")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(543785038));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("34.173.249.57")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735093903));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("73.192.16.237")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(621894605));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("49.14.15.56")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1815306502));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("86.182.234.220")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1914791576));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("138.22.156.73")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865715688));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("166.53.176.166")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523787210));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("56.52.163.73")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1951076245));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("201.154.253.34")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1974935209));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("73.113.92.236")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("193.252.107.47")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1928037316));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("78.35.183.128")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("243.65.211.8")));


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103206234));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("163.189.55.188")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("1.219.185.7")));

                Assert.That(model.ModelInner, Is.Null);


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2130252516));
                Assert.That(model.Value, Is.EqualTo(System.Net.IPAddress.Parse("218.254.144.159")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("254.52.163.254")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92305813));

                Assert.That(model.ModelInner.Value, Is.EqualTo(System.Net.IPAddress.Parse("164.41.134.250")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(System.Net.IPAddress.Parse("239.81.207.242")));


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinet0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    ipaddressinet0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(IPAddressinet0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(24),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(24)
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

                var expected = new Dictionary<System.Int32,IPAddressinet0M>(30);

                expected.Add(
                    31110243,
                    new IPAddressinet0M
                    {
                        Id = 31110243,
                        Value = System.Net.IPAddress.Parse("76.248.180.103"),
                        NullableValue = System.Net.IPAddress.Parse("149.95.190.235"),

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 1629562082,
                            Value = System.Net.IPAddress.Parse("52.35.146.235"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    151615321,
                    new IPAddressinet0M
                    {
                        Id = 151615321,
                        Value = System.Net.IPAddress.Parse("224.10.68.14"),
                        NullableValue = null,

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 2065281900,
                            Value = System.Net.IPAddress.Parse("42.147.62.72"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    211290950,
                    new IPAddressinet0M
                    {
                        Id = 211290950,
                        Value = System.Net.IPAddress.Parse("3.40.152.124"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    260144249,
                    new IPAddressinet0M
                    {
                        Id = 260144249,
                        Value = System.Net.IPAddress.Parse("92.42.73.150"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    338499233,
                    new IPAddressinet0M
                    {
                        Id = 338499233,
                        Value = System.Net.IPAddress.Parse("196.95.177.177"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    511234353,
                    new IPAddressinet0M
                    {
                        Id = 511234353,
                        Value = System.Net.IPAddress.Parse("127.190.212.37"),
                        NullableValue = null,

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 1060611269,
                            Value = System.Net.IPAddress.Parse("228.27.9.95"),
                            NullableValue = System.Net.IPAddress.Parse("192.108.251.132")
                        }

                    }
                );

                expected.Add(
                    543046904,
                    new IPAddressinet0M
                    {
                        Id = 543046904,
                        Value = System.Net.IPAddress.Parse("78.244.40.214"),
                        NullableValue = null,

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 1767359998,
                            Value = System.Net.IPAddress.Parse("36.203.126.56"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    646809985,
                    new IPAddressinet0M
                    {
                        Id = 646809985,
                        Value = System.Net.IPAddress.Parse("110.100.36.39"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    686871144,
                    new IPAddressinet0M
                    {
                        Id = 686871144,
                        Value = System.Net.IPAddress.Parse("90.83.172.28"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    758492807,
                    new IPAddressinet0M
                    {
                        Id = 758492807,
                        Value = System.Net.IPAddress.Parse("123.15.197.244"),
                        NullableValue = System.Net.IPAddress.Parse("202.117.43.158"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    772352621,
                    new IPAddressinet0M
                    {
                        Id = 772352621,
                        Value = System.Net.IPAddress.Parse("222.50.15.252"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    792952108,
                    new IPAddressinet0M
                    {
                        Id = 792952108,
                        Value = System.Net.IPAddress.Parse("251.78.78.41"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    815758951,
                    new IPAddressinet0M
                    {
                        Id = 815758951,
                        Value = System.Net.IPAddress.Parse("219.133.174.174"),
                        NullableValue = null,

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 785133126,
                            Value = System.Net.IPAddress.Parse("40.160.240.229"),
                            NullableValue = System.Net.IPAddress.Parse("105.61.63.175")
                        }

                    }
                );

                expected.Add(
                    972774719,
                    new IPAddressinet0M
                    {
                        Id = 972774719,
                        Value = System.Net.IPAddress.Parse("252.216.26.104"),
                        NullableValue = null,

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 2045397857,
                            Value = System.Net.IPAddress.Parse("23.16.239.58"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1100969356,
                    new IPAddressinet0M
                    {
                        Id = 1100969356,
                        Value = System.Net.IPAddress.Parse("168.226.17.159"),
                        NullableValue = null,

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 48344192,
                            Value = System.Net.IPAddress.Parse("168.45.110.238"),
                            NullableValue = System.Net.IPAddress.Parse("103.80.48.208")
                        }

                    }
                );

                expected.Add(
                    1159055059,
                    new IPAddressinet0M
                    {
                        Id = 1159055059,
                        Value = System.Net.IPAddress.Parse("111.236.168.159"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1183409549,
                    new IPAddressinet0M
                    {
                        Id = 1183409549,
                        Value = System.Net.IPAddress.Parse("94.84.16.204"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1333814213,
                    new IPAddressinet0M
                    {
                        Id = 1333814213,
                        Value = System.Net.IPAddress.Parse("242.154.78.253"),
                        NullableValue = System.Net.IPAddress.Parse("223.100.7.69"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1430947879,
                    new IPAddressinet0M
                    {
                        Id = 1430947879,
                        Value = System.Net.IPAddress.Parse("93.111.223.59"),
                        NullableValue = System.Net.IPAddress.Parse("186.198.244.109"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1613792341,
                    new IPAddressinet0M
                    {
                        Id = 1613792341,
                        Value = System.Net.IPAddress.Parse("166.247.5.76"),
                        NullableValue = System.Net.IPAddress.Parse("138.240.83.0"),

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 1996203882,
                            Value = System.Net.IPAddress.Parse("53.164.134.195"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1634973760,
                    new IPAddressinet0M
                    {
                        Id = 1634973760,
                        Value = System.Net.IPAddress.Parse("126.91.7.115"),
                        NullableValue = System.Net.IPAddress.Parse("103.123.220.109"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1698183444,
                    new IPAddressinet0M
                    {
                        Id = 1698183444,
                        Value = System.Net.IPAddress.Parse("94.110.37.43"),
                        NullableValue = null,

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 1037837526,
                            Value = System.Net.IPAddress.Parse("157.111.28.241"),
                            NullableValue = System.Net.IPAddress.Parse("249.168.176.106")
                        }

                    }
                );

                expected.Add(
                    1701908099,
                    new IPAddressinet0M
                    {
                        Id = 1701908099,
                        Value = System.Net.IPAddress.Parse("26.173.143.228"),
                        NullableValue = null,

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 543785038,
                            Value = System.Net.IPAddress.Parse("34.173.249.57"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1735093903,
                    new IPAddressinet0M
                    {
                        Id = 1735093903,
                        Value = System.Net.IPAddress.Parse("73.192.16.237"),
                        NullableValue = null,

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 621894605,
                            Value = System.Net.IPAddress.Parse("49.14.15.56"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1815306502,
                    new IPAddressinet0M
                    {
                        Id = 1815306502,
                        Value = System.Net.IPAddress.Parse("86.182.234.220"),
                        NullableValue = null,

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 1914791576,
                            Value = System.Net.IPAddress.Parse("138.22.156.73"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1865715688,
                    new IPAddressinet0M
                    {
                        Id = 1865715688,
                        Value = System.Net.IPAddress.Parse("166.53.176.166"),
                        NullableValue = null,

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 1523787210,
                            Value = System.Net.IPAddress.Parse("56.52.163.73"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1951076245,
                    new IPAddressinet0M
                    {
                        Id = 1951076245,
                        Value = System.Net.IPAddress.Parse("201.154.253.34"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1974935209,
                    new IPAddressinet0M
                    {
                        Id = 1974935209,
                        Value = System.Net.IPAddress.Parse("73.113.92.236"),
                        NullableValue = System.Net.IPAddress.Parse("193.252.107.47"),

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 1928037316,
                            Value = System.Net.IPAddress.Parse("78.35.183.128"),
                            NullableValue = System.Net.IPAddress.Parse("243.65.211.8")
                        }

                    }
                );

                expected.Add(
                    2103206234,
                    new IPAddressinet0M
                    {
                        Id = 2103206234,
                        Value = System.Net.IPAddress.Parse("163.189.55.188"),
                        NullableValue = System.Net.IPAddress.Parse("1.219.185.7"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    2130252516,
                    new IPAddressinet0M
                    {
                        Id = 2130252516,
                        Value = System.Net.IPAddress.Parse("218.254.144.159"),
                        NullableValue = System.Net.IPAddress.Parse("254.52.163.254"),

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 92305813,
                            Value = System.Net.IPAddress.Parse("164.41.134.250"),
                            NullableValue = System.Net.IPAddress.Parse("239.81.207.242")
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
                Assert.That(model.Value, Is.EqualTo(expectedModel.Value));
                if(expectedModel.NullableValue == null)
                {
                    Assert.That(model.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    Assert.That(model.NullableValue, Is.EqualTo(expectedModel.NullableValue));
                }

                if(expectedModel.ModelInner == null)
                {
                    Assert.That(model.ModelInner, Is.Null);
                }
                else
                {
                    Assert.That(model.ModelInner, Is.Not.Null);
                    Assert.That(model.ModelInner.Id, Is.EqualTo(expectedModel.ModelInner.Id));

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Net.IPAddress)default));
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

                var expected = new Dictionary<System.Int32,IPAddressinet0M>(30);

                expected.Add(
                    31110243,
                    new IPAddressinet0M
                    {
                        Id = 31110243,
                        Value = System.Net.IPAddress.Parse("76.248.180.103"),
                        NullableValue = System.Net.IPAddress.Parse("149.95.190.235"),

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 1629562082,
                            Value = System.Net.IPAddress.Parse("52.35.146.235"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    151615321,
                    new IPAddressinet0M
                    {
                        Id = 151615321,
                        Value = System.Net.IPAddress.Parse("224.10.68.14"),
                        NullableValue = null,

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 2065281900,
                            Value = System.Net.IPAddress.Parse("42.147.62.72"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    211290950,
                    new IPAddressinet0M
                    {
                        Id = 211290950,
                        Value = System.Net.IPAddress.Parse("3.40.152.124"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    260144249,
                    new IPAddressinet0M
                    {
                        Id = 260144249,
                        Value = System.Net.IPAddress.Parse("92.42.73.150"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    338499233,
                    new IPAddressinet0M
                    {
                        Id = 338499233,
                        Value = System.Net.IPAddress.Parse("196.95.177.177"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    511234353,
                    new IPAddressinet0M
                    {
                        Id = 511234353,
                        Value = System.Net.IPAddress.Parse("127.190.212.37"),
                        NullableValue = null,

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 1060611269,
                            Value = System.Net.IPAddress.Parse("228.27.9.95"),
                            NullableValue = System.Net.IPAddress.Parse("192.108.251.132")
                        }

                    }
                );

                expected.Add(
                    543046904,
                    new IPAddressinet0M
                    {
                        Id = 543046904,
                        Value = System.Net.IPAddress.Parse("78.244.40.214"),
                        NullableValue = null,

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 1767359998,
                            Value = System.Net.IPAddress.Parse("36.203.126.56"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    646809985,
                    new IPAddressinet0M
                    {
                        Id = 646809985,
                        Value = System.Net.IPAddress.Parse("110.100.36.39"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    686871144,
                    new IPAddressinet0M
                    {
                        Id = 686871144,
                        Value = System.Net.IPAddress.Parse("90.83.172.28"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    758492807,
                    new IPAddressinet0M
                    {
                        Id = 758492807,
                        Value = System.Net.IPAddress.Parse("123.15.197.244"),
                        NullableValue = System.Net.IPAddress.Parse("202.117.43.158"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    772352621,
                    new IPAddressinet0M
                    {
                        Id = 772352621,
                        Value = System.Net.IPAddress.Parse("222.50.15.252"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    792952108,
                    new IPAddressinet0M
                    {
                        Id = 792952108,
                        Value = System.Net.IPAddress.Parse("251.78.78.41"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    815758951,
                    new IPAddressinet0M
                    {
                        Id = 815758951,
                        Value = System.Net.IPAddress.Parse("219.133.174.174"),
                        NullableValue = null,

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 785133126,
                            Value = System.Net.IPAddress.Parse("40.160.240.229"),
                            NullableValue = System.Net.IPAddress.Parse("105.61.63.175")
                        }

                    }
                );

                expected.Add(
                    972774719,
                    new IPAddressinet0M
                    {
                        Id = 972774719,
                        Value = System.Net.IPAddress.Parse("252.216.26.104"),
                        NullableValue = null,

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 2045397857,
                            Value = System.Net.IPAddress.Parse("23.16.239.58"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1100969356,
                    new IPAddressinet0M
                    {
                        Id = 1100969356,
                        Value = System.Net.IPAddress.Parse("168.226.17.159"),
                        NullableValue = null,

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 48344192,
                            Value = System.Net.IPAddress.Parse("168.45.110.238"),
                            NullableValue = System.Net.IPAddress.Parse("103.80.48.208")
                        }

                    }
                );

                expected.Add(
                    1159055059,
                    new IPAddressinet0M
                    {
                        Id = 1159055059,
                        Value = System.Net.IPAddress.Parse("111.236.168.159"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1183409549,
                    new IPAddressinet0M
                    {
                        Id = 1183409549,
                        Value = System.Net.IPAddress.Parse("94.84.16.204"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1333814213,
                    new IPAddressinet0M
                    {
                        Id = 1333814213,
                        Value = System.Net.IPAddress.Parse("242.154.78.253"),
                        NullableValue = System.Net.IPAddress.Parse("223.100.7.69"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1430947879,
                    new IPAddressinet0M
                    {
                        Id = 1430947879,
                        Value = System.Net.IPAddress.Parse("93.111.223.59"),
                        NullableValue = System.Net.IPAddress.Parse("186.198.244.109"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1613792341,
                    new IPAddressinet0M
                    {
                        Id = 1613792341,
                        Value = System.Net.IPAddress.Parse("166.247.5.76"),
                        NullableValue = System.Net.IPAddress.Parse("138.240.83.0"),

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 1996203882,
                            Value = System.Net.IPAddress.Parse("53.164.134.195"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1634973760,
                    new IPAddressinet0M
                    {
                        Id = 1634973760,
                        Value = System.Net.IPAddress.Parse("126.91.7.115"),
                        NullableValue = System.Net.IPAddress.Parse("103.123.220.109"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1698183444,
                    new IPAddressinet0M
                    {
                        Id = 1698183444,
                        Value = System.Net.IPAddress.Parse("94.110.37.43"),
                        NullableValue = null,

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 1037837526,
                            Value = System.Net.IPAddress.Parse("157.111.28.241"),
                            NullableValue = System.Net.IPAddress.Parse("249.168.176.106")
                        }

                    }
                );

                expected.Add(
                    1701908099,
                    new IPAddressinet0M
                    {
                        Id = 1701908099,
                        Value = System.Net.IPAddress.Parse("26.173.143.228"),
                        NullableValue = null,

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 543785038,
                            Value = System.Net.IPAddress.Parse("34.173.249.57"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1735093903,
                    new IPAddressinet0M
                    {
                        Id = 1735093903,
                        Value = System.Net.IPAddress.Parse("73.192.16.237"),
                        NullableValue = null,

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 621894605,
                            Value = System.Net.IPAddress.Parse("49.14.15.56"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1815306502,
                    new IPAddressinet0M
                    {
                        Id = 1815306502,
                        Value = System.Net.IPAddress.Parse("86.182.234.220"),
                        NullableValue = null,

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 1914791576,
                            Value = System.Net.IPAddress.Parse("138.22.156.73"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1865715688,
                    new IPAddressinet0M
                    {
                        Id = 1865715688,
                        Value = System.Net.IPAddress.Parse("166.53.176.166"),
                        NullableValue = null,

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 1523787210,
                            Value = System.Net.IPAddress.Parse("56.52.163.73"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1951076245,
                    new IPAddressinet0M
                    {
                        Id = 1951076245,
                        Value = System.Net.IPAddress.Parse("201.154.253.34"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1974935209,
                    new IPAddressinet0M
                    {
                        Id = 1974935209,
                        Value = System.Net.IPAddress.Parse("73.113.92.236"),
                        NullableValue = System.Net.IPAddress.Parse("193.252.107.47"),

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 1928037316,
                            Value = System.Net.IPAddress.Parse("78.35.183.128"),
                            NullableValue = System.Net.IPAddress.Parse("243.65.211.8")
                        }

                    }
                );

                expected.Add(
                    2103206234,
                    new IPAddressinet0M
                    {
                        Id = 2103206234,
                        Value = System.Net.IPAddress.Parse("163.189.55.188"),
                        NullableValue = System.Net.IPAddress.Parse("1.219.185.7"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    2130252516,
                    new IPAddressinet0M
                    {
                        Id = 2130252516,
                        Value = System.Net.IPAddress.Parse("218.254.144.159"),
                        NullableValue = System.Net.IPAddress.Parse("254.52.163.254"),

                        ModelInner = new IPAddressinet0MI
                        {
                            Id = 92305813,
                            Value = System.Net.IPAddress.Parse("164.41.134.250"),
                            NullableValue = System.Net.IPAddress.Parse("239.81.207.242")
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
                Assert.That(model.Value, Is.EqualTo(expectedModel.Value));
                if(expectedModel.NullableValue == null)
                {
                    Assert.That(model.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    Assert.That(model.NullableValue, Is.EqualTo(expectedModel.NullableValue));
                }

                if(expectedModel.ModelInner == null)
                {
                    Assert.That(model.ModelInner, Is.Null);
                }
                else
                {
                    Assert.That(model.ModelInner, Is.Not.Null);
                    Assert.That(model.ModelInner.Id, Is.EqualTo(expectedModel.ModelInner.Id));

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Net.IPAddress)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinet0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(IPAddressinet0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(24),
                (NpgsqlTypes.NpgsqlDbType)(24)
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

                var expected = new Dictionary<System.Int32,IPAddressinet0MI>(15);

                expected.Add(
                    48344192,
                    new IPAddressinet0MI
                    {
                        Id = 48344192,
                        Value = System.Net.IPAddress.Parse("168.45.110.238"),
                        NullableValue = System.Net.IPAddress.Parse("103.80.48.208")
                    }
                );

                expected.Add(
                    92305813,
                    new IPAddressinet0MI
                    {
                        Id = 92305813,
                        Value = System.Net.IPAddress.Parse("164.41.134.250"),
                        NullableValue = System.Net.IPAddress.Parse("239.81.207.242")
                    }
                );

                expected.Add(
                    543785038,
                    new IPAddressinet0MI
                    {
                        Id = 543785038,
                        Value = System.Net.IPAddress.Parse("34.173.249.57"),
                        NullableValue = null
                    }
                );

                expected.Add(
                    621894605,
                    new IPAddressinet0MI
                    {
                        Id = 621894605,
                        Value = System.Net.IPAddress.Parse("49.14.15.56"),
                        NullableValue = null
                    }
                );

                expected.Add(
                    785133126,
                    new IPAddressinet0MI
                    {
                        Id = 785133126,
                        Value = System.Net.IPAddress.Parse("40.160.240.229"),
                        NullableValue = System.Net.IPAddress.Parse("105.61.63.175")
                    }
                );

                expected.Add(
                    1037837526,
                    new IPAddressinet0MI
                    {
                        Id = 1037837526,
                        Value = System.Net.IPAddress.Parse("157.111.28.241"),
                        NullableValue = System.Net.IPAddress.Parse("249.168.176.106")
                    }
                );

                expected.Add(
                    1060611269,
                    new IPAddressinet0MI
                    {
                        Id = 1060611269,
                        Value = System.Net.IPAddress.Parse("228.27.9.95"),
                        NullableValue = System.Net.IPAddress.Parse("192.108.251.132")
                    }
                );

                expected.Add(
                    1523787210,
                    new IPAddressinet0MI
                    {
                        Id = 1523787210,
                        Value = System.Net.IPAddress.Parse("56.52.163.73"),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1629562082,
                    new IPAddressinet0MI
                    {
                        Id = 1629562082,
                        Value = System.Net.IPAddress.Parse("52.35.146.235"),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1767359998,
                    new IPAddressinet0MI
                    {
                        Id = 1767359998,
                        Value = System.Net.IPAddress.Parse("36.203.126.56"),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1914791576,
                    new IPAddressinet0MI
                    {
                        Id = 1914791576,
                        Value = System.Net.IPAddress.Parse("138.22.156.73"),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1928037316,
                    new IPAddressinet0MI
                    {
                        Id = 1928037316,
                        Value = System.Net.IPAddress.Parse("78.35.183.128"),
                        NullableValue = System.Net.IPAddress.Parse("243.65.211.8")
                    }
                );

                expected.Add(
                    1996203882,
                    new IPAddressinet0MI
                    {
                        Id = 1996203882,
                        Value = System.Net.IPAddress.Parse("53.164.134.195"),
                        NullableValue = null
                    }
                );

                expected.Add(
                    2045397857,
                    new IPAddressinet0MI
                    {
                        Id = 2045397857,
                        Value = System.Net.IPAddress.Parse("23.16.239.58"),
                        NullableValue = null
                    }
                );

                expected.Add(
                    2065281900,
                    new IPAddressinet0MI
                    {
                        Id = 2065281900,
                        Value = System.Net.IPAddress.Parse("42.147.62.72"),
                        NullableValue = null
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
                Assert.That(model.Value, Is.EqualTo(expectedModel.Value));
                if(expectedModel.NullableValue != null)
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    Assert.That(model.NullableValue, Is.EqualTo(expectedModel.NullableValue));
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

                var expected = new Dictionary<System.Int32,IPAddressinet0MI>(15);

                expected.Add(
                    48344192,
                    new IPAddressinet0MI
                    {
                        Id = 48344192,
                        Value = System.Net.IPAddress.Parse("168.45.110.238"),
                        NullableValue = System.Net.IPAddress.Parse("103.80.48.208")
                    }
                );

                expected.Add(
                    92305813,
                    new IPAddressinet0MI
                    {
                        Id = 92305813,
                        Value = System.Net.IPAddress.Parse("164.41.134.250"),
                        NullableValue = System.Net.IPAddress.Parse("239.81.207.242")
                    }
                );

                expected.Add(
                    543785038,
                    new IPAddressinet0MI
                    {
                        Id = 543785038,
                        Value = System.Net.IPAddress.Parse("34.173.249.57"),
                        NullableValue = null
                    }
                );

                expected.Add(
                    621894605,
                    new IPAddressinet0MI
                    {
                        Id = 621894605,
                        Value = System.Net.IPAddress.Parse("49.14.15.56"),
                        NullableValue = null
                    }
                );

                expected.Add(
                    785133126,
                    new IPAddressinet0MI
                    {
                        Id = 785133126,
                        Value = System.Net.IPAddress.Parse("40.160.240.229"),
                        NullableValue = System.Net.IPAddress.Parse("105.61.63.175")
                    }
                );

                expected.Add(
                    1037837526,
                    new IPAddressinet0MI
                    {
                        Id = 1037837526,
                        Value = System.Net.IPAddress.Parse("157.111.28.241"),
                        NullableValue = System.Net.IPAddress.Parse("249.168.176.106")
                    }
                );

                expected.Add(
                    1060611269,
                    new IPAddressinet0MI
                    {
                        Id = 1060611269,
                        Value = System.Net.IPAddress.Parse("228.27.9.95"),
                        NullableValue = System.Net.IPAddress.Parse("192.108.251.132")
                    }
                );

                expected.Add(
                    1523787210,
                    new IPAddressinet0MI
                    {
                        Id = 1523787210,
                        Value = System.Net.IPAddress.Parse("56.52.163.73"),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1629562082,
                    new IPAddressinet0MI
                    {
                        Id = 1629562082,
                        Value = System.Net.IPAddress.Parse("52.35.146.235"),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1767359998,
                    new IPAddressinet0MI
                    {
                        Id = 1767359998,
                        Value = System.Net.IPAddress.Parse("36.203.126.56"),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1914791576,
                    new IPAddressinet0MI
                    {
                        Id = 1914791576,
                        Value = System.Net.IPAddress.Parse("138.22.156.73"),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1928037316,
                    new IPAddressinet0MI
                    {
                        Id = 1928037316,
                        Value = System.Net.IPAddress.Parse("78.35.183.128"),
                        NullableValue = System.Net.IPAddress.Parse("243.65.211.8")
                    }
                );

                expected.Add(
                    1996203882,
                    new IPAddressinet0MI
                    {
                        Id = 1996203882,
                        Value = System.Net.IPAddress.Parse("53.164.134.195"),
                        NullableValue = null
                    }
                );

                expected.Add(
                    2045397857,
                    new IPAddressinet0MI
                    {
                        Id = 2045397857,
                        Value = System.Net.IPAddress.Parse("23.16.239.58"),
                        NullableValue = null
                    }
                );

                expected.Add(
                    2065281900,
                    new IPAddressinet0MI
                    {
                        Id = 2065281900,
                        Value = System.Net.IPAddress.Parse("42.147.62.72"),
                        NullableValue = null
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
                Assert.That(model.Value, Is.EqualTo(expectedModel.Value));
                if(expectedModel.NullableValue != null)
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    Assert.That(model.NullableValue, Is.EqualTo(expectedModel.NullableValue));
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

