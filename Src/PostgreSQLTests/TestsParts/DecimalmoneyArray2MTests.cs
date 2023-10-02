

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
    internal partial interface IDecimalListmoneyArray
    {
    }
    
    internal partial class DecimalListmoneyArray : IDecimalListmoneyArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneyarray2mi(
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
            asPartInterface: typeof(IDecimalListmoneyArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneyarray2mi(
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
            queryMapType: typeof(DecimalmoneyArray2MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636)
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

                changedRows =  ((IDecimalListmoneyArray)this).InsertModelInner(connection, 1989887715, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.34m,

0.43m,

0.90m,

0.29m,

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalListmoneyArray)this).InsertModelInner(connection, 924792188, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.17m,

0.22m,

0.16m,

0.62m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.58m,

0.76m,

0.26m,

0.87m,

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

                changedRows = await ((IDecimalListmoneyArray)this).InsertModelInnerAsync(connection, 2086038716, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.98m,

0.97m,

0.79m,

0.24m,

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalListmoneyArray)this).InsertModelInnerAsync(connection, 1022846180, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.06m,

0.65m,

0.73m,

0.35m,

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

                id =  ((IDecimalListmoneyArray)this).InsertModelInnerReturning(connection, 1084161682, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63m,

0.27m,

0.20m,

0.35m,

}, null);
                Assert.That(id, Is.EqualTo(1084161682));

                id =  ((IDecimalListmoneyArray)this).InsertModelInnerReturning(connection, 745381557, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.03m,

0.24m,

}, null);
                Assert.That(id, Is.EqualTo(745381557));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IDecimalListmoneyArray)this).InsertModelInnerReturningAsync(connection, 915733516, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.84m,

0.62m,

0.28m,

0.43m,

}, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.57m,

0.23m,

0.50m,

});
                Assert.That(id, Is.EqualTo(915733516));

                id = await ((IDecimalListmoneyArray)this).InsertModelInnerReturningAsync(connection, 2016905416, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.30m,

0.96m,

0.04m,

0.80m,

}, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.97m,

0.83m,

});
                Assert.That(id, Is.EqualTo(2016905416));

                id = await ((IDecimalListmoneyArray)this).InsertModelInnerReturningAsync(connection, 1679004264, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.02m,

0.45m,

0.39m,

}, null);
                Assert.That(id, Is.EqualTo(1679004264));

                id = await ((IDecimalListmoneyArray)this).InsertModelInnerReturningAsync(connection, 1940404136, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.32m,

0.30m,

0.13m,

0.01m,

}, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.96m,

0.04m,

0.97m,

});
                Assert.That(id, Is.EqualTo(1940404136));

                id = await ((IDecimalListmoneyArray)this).InsertModelInnerReturningAsync(connection, 1507914019, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.16m,

0.78m,

0.42m,

}, null);
                Assert.That(id, Is.EqualTo(1507914019));

                id = await ((IDecimalListmoneyArray)this).InsertModelInnerReturningAsync(connection, 1391339514, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.84m,

0.30m,

0.05m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.60m,

0.34m,

0.73m,

0.79m,

});
                Assert.That(id, Is.EqualTo(1391339514));

                id = await ((IDecimalListmoneyArray)this).InsertModelInnerReturningAsync(connection, 931433918, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00m,

0.07m,

0.73m,

}, null);
                Assert.That(id, Is.EqualTo(931433918));

                id = await ((IDecimalListmoneyArray)this).InsertModelInnerReturningAsync(connection, 1065938893, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.61m,

0.79m,

0.96m,

0.50m,

}, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.68m,

0.71m,

0.62m,

});
                Assert.That(id, Is.EqualTo(1065938893));

                id = await ((IDecimalListmoneyArray)this).InsertModelInnerReturningAsync(connection, 1128165166, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.04m,

1.00m,

0.43m,

}, null);
                Assert.That(id, Is.EqualTo(1128165166));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneyarray2m(
	id,
    value,
    nullablevalue,
    decimalmoneyarray2mi_id
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
            asPartInterface: typeof(IDecimalListmoneyArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalmoneyarray2mi_id", 
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

                changedRows =  ((IDecimalListmoneyArray)this).InsertModel(connection, 1609735417, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.56m,

0.42m,

0.33m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.15m,

0.87m,

0.97m,

0.52m,

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalListmoneyArray)this).InsertModel(connection, 1455719771, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.05m,

0.66m,

0.49m,

0.18m,

}, null, 1989887715);
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

                changedRows = await ((IDecimalListmoneyArray)this).InsertModelAsync(connection, 197749978, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.14m,

0.55m,

0.11m,

0.75m,

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalListmoneyArray)this).InsertModelAsync(connection, 1650133984, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.30m,

0.88m,

0.40m,

}, null, 924792188);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneyarray2m(
	id,
    value,
    nullablevalue,
    decimalmoneyarray2mi_id
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
    decimalmoneyarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(DecimalmoneyArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalmoneyarray2mi_id", 
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
                List<DecimalmoneyArray2M> models = null;
                DecimalmoneyArray2M model = null;

                models =  ((IDecimalListmoneyArray)this).InsertModelReturning(connection, 2088200534, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.91m,

0.81m,

0.95m,

0.53m,

}, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.79m,

0.92m,

0.66m,

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2088200534));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.91m,

0.81m,

0.95m,

0.53m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.79m,

0.92m,

0.66m,

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

                models =  ((IDecimalListmoneyArray)this).InsertModelReturning(connection, 1591389282, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.69m,

0.51m,

0.24m,

0.20m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.36m,

0.39m,

0.55m,

}, 2086038716).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1591389282));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.69m,

0.51m,

0.24m,

0.20m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.36m,

0.39m,

0.55m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2086038716));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IDecimalListmoneyArray)this).InsertModelReturning(connection, 986984605, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.96m,

0.64m,

0.73m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.88m,

0.17m,

0.64m,

0.98m,

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(986984605));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.96m,

0.64m,

0.73m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.88m,

0.17m,

0.64m,

0.98m,

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

                models =  ((IDecimalListmoneyArray)this).InsertModelReturning(connection, 235819484, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.83m,

0.80m,

0.67m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.46m,

0.15m,

0.16m,

0.29m,

}, 1022846180).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(235819484));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.83m,

0.80m,

0.67m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.46m,

0.15m,

0.16m,

0.29m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1022846180));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalmoneyArray2M> models = null;
                DecimalmoneyArray2M model = null;

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, 89558594, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.83m,

0.27m,

0.91m,

0.59m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.76m,

1.00m,

0.58m,

0.81m,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(89558594));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.83m,

0.27m,

0.91m,

0.59m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.76m,

1.00m,

0.58m,

0.81m,

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

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, 603496749, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.28m,

0.42m,

0.23m,

0.40m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.11m,

0.53m,

0.08m,

0.26m,

}, 1084161682).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(603496749));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.28m,

0.42m,

0.23m,

0.40m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.11m,

0.53m,

0.08m,

0.26m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1084161682));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, 785819060, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.39m,

0.01m,

0.79m,

0.97m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.03m,

0.21m,

0.90m,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(785819060));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.39m,

0.01m,

0.79m,

0.97m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.03m,

0.21m,

0.90m,

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

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, 382211456, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.13m,

0.27m,

0.47m,

}, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.58m,

0.37m,

0.18m,

}, 745381557).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382211456));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.13m,

0.27m,

0.47m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.58m,

0.37m,

0.18m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(745381557));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, 1331109979, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.07m,

0.72m,

0.68m,

}, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.44m,

0.87m,

0.22m,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331109979));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.07m,

0.72m,

0.68m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.44m,

0.87m,

0.22m,

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

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, 585729157, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.35m,

0.47m,

0.40m,

}, null, 915733516).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(585729157));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.35m,

0.47m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(915733516));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, 561702663, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.93m,

0.91m,

0.22m,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(561702663));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.93m,

0.91m,

0.22m,

};
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

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, 1726726308, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.91m,

0.02m,

0.38m,

}, null, 2016905416).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1726726308));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.91m,

0.02m,

0.38m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2016905416));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, 1833587780, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.62m,

1.00m,

0.08m,

}, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.54m,

0.96m,

0.90m,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1833587780));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.62m,

1.00m,

0.08m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.54m,

0.96m,

0.90m,

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

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, 1544303855, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.03m,

0.23m,

0.21m,

}, null, 1679004264).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1544303855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.03m,

0.23m,

0.21m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1679004264));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, 7816882, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.81m,

1.00m,

0.32m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.24m,

0.46m,

0.62m,

0.05m,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(7816882));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.81m,

1.00m,

0.32m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.24m,

0.46m,

0.62m,

0.05m,

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

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, 1027130948, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.52m,

}, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.55m,

0.54m,

0.47m,

}, 1940404136).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1027130948));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.52m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.55m,

0.54m,

0.47m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940404136));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, 1219533177, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.72m,

0.36m,

0.74m,

}, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.17m,

0.47m,

0.04m,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1219533177));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.72m,

0.36m,

0.74m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.17m,

0.47m,

0.04m,

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

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, 742387234, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.78m,

0.43m,

0.08m,

}, null, 1507914019).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(742387234));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.78m,

0.43m,

0.08m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1507914019));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, 2138732876, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.85m,

0.22m,

0.59m,

}, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.40m,

0.07m,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2138732876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.85m,

0.22m,

0.59m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.40m,

0.07m,

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

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, 1469229955, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.88m,

0.20m,

0.40m,

}, null, 1391339514).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1469229955));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.88m,

0.20m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1391339514));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, 336737745, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.03m,

0.01m,

1.00m,

0.35m,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(336737745));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.03m,

0.01m,

1.00m,

0.35m,

};
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

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, 387019197, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.19m,

0.21m,

0.51m,

0.92m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.51m,

0.53m,

0.57m,

0.72m,

}, 931433918).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(387019197));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.19m,

0.21m,

0.51m,

0.92m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.51m,

0.53m,

0.57m,

0.72m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(931433918));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, 1522517769, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.98m,

0.99m,

0.72m,

}, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.98m,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1522517769));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.98m,

0.99m,

0.72m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.98m,

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

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, 948900206, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.90m,

0.81m,

0.87m,

}, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.09m,

0.74m,

0.34m,

}, 1065938893).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948900206));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.90m,

0.81m,

0.87m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.09m,

0.74m,

0.34m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1065938893));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, 1255259303, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.56m,

0.06m,

0.01m,

0.89m,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1255259303));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.56m,

0.06m,

0.01m,

0.89m,

};
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

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, 310591520, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.54m,

0.01m,

}, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.08m,

0.29m,

0.05m,

}, 1128165166).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(310591520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.54m,

0.01m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.08m,

0.29m,

0.05m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1128165166));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
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
FROM public.decimalmoneyarray2m m
LEFT JOIN public.decimalmoneyarray2mi mi ON mi.id = m.decimalmoneyarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(DecimalmoneyArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)
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
                var models =  ((IDecimalListmoneyArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(7816882));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.81m,

1.00m,

0.32m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.24m,

0.46m,

0.62m,

0.05m,

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
                Assert.That(model.Id, Is.EqualTo(89558594));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.83m,

0.27m,

0.91m,

0.59m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.76m,

1.00m,

0.58m,

0.81m,

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
                Assert.That(model.Id, Is.EqualTo(197749978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.14m,

0.55m,

0.11m,

0.75m,

};
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
                Assert.That(model.Id, Is.EqualTo(235819484));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.83m,

0.80m,

0.67m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.46m,

0.15m,

0.16m,

0.29m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1022846180));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.06m,

0.65m,

0.73m,

0.35m,

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
                Assert.That(model.Id, Is.EqualTo(310591520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.54m,

0.01m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.08m,

0.29m,

0.05m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1128165166));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.04m,

1.00m,

0.43m,

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
                Assert.That(model.Id, Is.EqualTo(336737745));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.03m,

0.01m,

1.00m,

0.35m,

};
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
                Assert.That(model.Id, Is.EqualTo(382211456));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.13m,

0.27m,

0.47m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.58m,

0.37m,

0.18m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(745381557));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.03m,

0.24m,

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
                Assert.That(model.Id, Is.EqualTo(387019197));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.19m,

0.21m,

0.51m,

0.92m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.51m,

0.53m,

0.57m,

0.72m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(931433918));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00m,

0.07m,

0.73m,

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
                Assert.That(model.Id, Is.EqualTo(561702663));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.93m,

0.91m,

0.22m,

};
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
                Assert.That(model.Id, Is.EqualTo(585729157));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.35m,

0.47m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(915733516));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.84m,

0.62m,

0.28m,

0.43m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.57m,

0.23m,

0.50m,

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
                Assert.That(model.Id, Is.EqualTo(603496749));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.28m,

0.42m,

0.23m,

0.40m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.11m,

0.53m,

0.08m,

0.26m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1084161682));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63m,

0.27m,

0.20m,

0.35m,

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
                Assert.That(model.Id, Is.EqualTo(742387234));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.78m,

0.43m,

0.08m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1507914019));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.16m,

0.78m,

0.42m,

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
                Assert.That(model.Id, Is.EqualTo(785819060));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.39m,

0.01m,

0.79m,

0.97m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.03m,

0.21m,

0.90m,

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
                Assert.That(model.Id, Is.EqualTo(948900206));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.90m,

0.81m,

0.87m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.09m,

0.74m,

0.34m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1065938893));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.61m,

0.79m,

0.96m,

0.50m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.68m,

0.71m,

0.62m,

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
                Assert.That(model.Id, Is.EqualTo(986984605));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.96m,

0.64m,

0.73m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.88m,

0.17m,

0.64m,

0.98m,

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
                Assert.That(model.Id, Is.EqualTo(1027130948));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.52m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.55m,

0.54m,

0.47m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940404136));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.32m,

0.30m,

0.13m,

0.01m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.96m,

0.04m,

0.97m,

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
                Assert.That(model.Id, Is.EqualTo(1219533177));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.72m,

0.36m,

0.74m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.17m,

0.47m,

0.04m,

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
                Assert.That(model.Id, Is.EqualTo(1255259303));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.56m,

0.06m,

0.01m,

0.89m,

};
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
                Assert.That(model.Id, Is.EqualTo(1331109979));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.07m,

0.72m,

0.68m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.44m,

0.87m,

0.22m,

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
                Assert.That(model.Id, Is.EqualTo(1455719771));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.05m,

0.66m,

0.49m,

0.18m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1989887715));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.34m,

0.43m,

0.90m,

0.29m,

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
                Assert.That(model.Id, Is.EqualTo(1469229955));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.88m,

0.20m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1391339514));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.84m,

0.30m,

0.05m,

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
new System.Collections.Generic.List<System.Decimal>(4)
{
0.60m,

0.34m,

0.73m,

0.79m,

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
                Assert.That(model.Id, Is.EqualTo(1522517769));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.98m,

0.99m,

0.72m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.98m,

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
                Assert.That(model.Id, Is.EqualTo(1544303855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.03m,

0.23m,

0.21m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1679004264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.02m,

0.45m,

0.39m,

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
                Assert.That(model.Id, Is.EqualTo(1591389282));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.69m,

0.51m,

0.24m,

0.20m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.36m,

0.39m,

0.55m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2086038716));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.98m,

0.97m,

0.79m,

0.24m,

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

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1609735417));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.56m,

0.42m,

0.33m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.15m,

0.87m,

0.97m,

0.52m,

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
                Assert.That(model.Id, Is.EqualTo(1650133984));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.30m,

0.88m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(924792188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.17m,

0.22m,

0.16m,

0.62m,

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
new System.Collections.Generic.List<System.Decimal>(4)
{
0.58m,

0.76m,

0.26m,

0.87m,

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
                Assert.That(model.Id, Is.EqualTo(1726726308));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.91m,

0.02m,

0.38m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2016905416));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.30m,

0.96m,

0.04m,

0.80m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.97m,

0.83m,

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
                Assert.That(model.Id, Is.EqualTo(1833587780));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.62m,

1.00m,

0.08m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.54m,

0.96m,

0.90m,

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
                Assert.That(model.Id, Is.EqualTo(2088200534));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.91m,

0.81m,

0.95m,

0.53m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.79m,

0.92m,

0.66m,

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2138732876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.85m,

0.22m,

0.59m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.40m,

0.07m,

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

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListmoneyArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(7816882));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.81m,

1.00m,

0.32m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.24m,

0.46m,

0.62m,

0.05m,

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
                Assert.That(model.Id, Is.EqualTo(89558594));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.83m,

0.27m,

0.91m,

0.59m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.76m,

1.00m,

0.58m,

0.81m,

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
                Assert.That(model.Id, Is.EqualTo(197749978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.14m,

0.55m,

0.11m,

0.75m,

};
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
                Assert.That(model.Id, Is.EqualTo(235819484));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.83m,

0.80m,

0.67m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.46m,

0.15m,

0.16m,

0.29m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1022846180));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.06m,

0.65m,

0.73m,

0.35m,

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
                Assert.That(model.Id, Is.EqualTo(310591520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.54m,

0.01m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.08m,

0.29m,

0.05m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1128165166));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.04m,

1.00m,

0.43m,

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
                Assert.That(model.Id, Is.EqualTo(336737745));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.03m,

0.01m,

1.00m,

0.35m,

};
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
                Assert.That(model.Id, Is.EqualTo(382211456));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.13m,

0.27m,

0.47m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.58m,

0.37m,

0.18m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(745381557));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.03m,

0.24m,

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
                Assert.That(model.Id, Is.EqualTo(387019197));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.19m,

0.21m,

0.51m,

0.92m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.51m,

0.53m,

0.57m,

0.72m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(931433918));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00m,

0.07m,

0.73m,

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
                Assert.That(model.Id, Is.EqualTo(561702663));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.93m,

0.91m,

0.22m,

};
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
                Assert.That(model.Id, Is.EqualTo(585729157));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.35m,

0.47m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(915733516));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.84m,

0.62m,

0.28m,

0.43m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.57m,

0.23m,

0.50m,

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
                Assert.That(model.Id, Is.EqualTo(603496749));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.28m,

0.42m,

0.23m,

0.40m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.11m,

0.53m,

0.08m,

0.26m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1084161682));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63m,

0.27m,

0.20m,

0.35m,

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
                Assert.That(model.Id, Is.EqualTo(742387234));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.78m,

0.43m,

0.08m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1507914019));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.16m,

0.78m,

0.42m,

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
                Assert.That(model.Id, Is.EqualTo(785819060));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.39m,

0.01m,

0.79m,

0.97m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.03m,

0.21m,

0.90m,

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
                Assert.That(model.Id, Is.EqualTo(948900206));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.90m,

0.81m,

0.87m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.09m,

0.74m,

0.34m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1065938893));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.61m,

0.79m,

0.96m,

0.50m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.68m,

0.71m,

0.62m,

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
                Assert.That(model.Id, Is.EqualTo(986984605));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.96m,

0.64m,

0.73m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.88m,

0.17m,

0.64m,

0.98m,

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
                Assert.That(model.Id, Is.EqualTo(1027130948));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.52m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.55m,

0.54m,

0.47m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940404136));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.32m,

0.30m,

0.13m,

0.01m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.96m,

0.04m,

0.97m,

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
                Assert.That(model.Id, Is.EqualTo(1219533177));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.72m,

0.36m,

0.74m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.17m,

0.47m,

0.04m,

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
                Assert.That(model.Id, Is.EqualTo(1255259303));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.56m,

0.06m,

0.01m,

0.89m,

};
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
                Assert.That(model.Id, Is.EqualTo(1331109979));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.07m,

0.72m,

0.68m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.44m,

0.87m,

0.22m,

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
                Assert.That(model.Id, Is.EqualTo(1455719771));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.05m,

0.66m,

0.49m,

0.18m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1989887715));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.34m,

0.43m,

0.90m,

0.29m,

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
                Assert.That(model.Id, Is.EqualTo(1469229955));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.88m,

0.20m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1391339514));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.84m,

0.30m,

0.05m,

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
new System.Collections.Generic.List<System.Decimal>(4)
{
0.60m,

0.34m,

0.73m,

0.79m,

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
                Assert.That(model.Id, Is.EqualTo(1522517769));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.98m,

0.99m,

0.72m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.98m,

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
                Assert.That(model.Id, Is.EqualTo(1544303855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.03m,

0.23m,

0.21m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1679004264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.02m,

0.45m,

0.39m,

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
                Assert.That(model.Id, Is.EqualTo(1591389282));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.69m,

0.51m,

0.24m,

0.20m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.36m,

0.39m,

0.55m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2086038716));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.98m,

0.97m,

0.79m,

0.24m,

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

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1609735417));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.56m,

0.42m,

0.33m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.15m,

0.87m,

0.97m,

0.52m,

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
                Assert.That(model.Id, Is.EqualTo(1650133984));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.30m,

0.88m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(924792188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.17m,

0.22m,

0.16m,

0.62m,

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
new System.Collections.Generic.List<System.Decimal>(4)
{
0.58m,

0.76m,

0.26m,

0.87m,

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
                Assert.That(model.Id, Is.EqualTo(1726726308));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.91m,

0.02m,

0.38m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2016905416));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.30m,

0.96m,

0.04m,

0.80m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.97m,

0.83m,

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
                Assert.That(model.Id, Is.EqualTo(1833587780));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.62m,

1.00m,

0.08m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.54m,

0.96m,

0.90m,

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
                Assert.That(model.Id, Is.EqualTo(2088200534));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.91m,

0.81m,

0.95m,

0.53m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.79m,

0.92m,

0.66m,

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2138732876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.85m,

0.22m,

0.59m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.40m,

0.07m,

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
FROM public.decimalmoneyarray2m m
LEFT JOIN public.decimalmoneyarray2mi mi ON mi.id = m.decimalmoneyarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(DecimalmoneyArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)
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
                var models =  ((IDecimalListmoneyArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(7816882));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.81m,

1.00m,

0.32m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.24m,

0.46m,

0.62m,

0.05m,

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
                Assert.That(model.Id, Is.EqualTo(89558594));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.83m,

0.27m,

0.91m,

0.59m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.76m,

1.00m,

0.58m,

0.81m,

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
                Assert.That(model.Id, Is.EqualTo(197749978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.14m,

0.55m,

0.11m,

0.75m,

};
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
                Assert.That(model.Id, Is.EqualTo(235819484));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.83m,

0.80m,

0.67m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.46m,

0.15m,

0.16m,

0.29m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1022846180));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.06m,

0.65m,

0.73m,

0.35m,

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
                Assert.That(model.Id, Is.EqualTo(310591520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.54m,

0.01m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.08m,

0.29m,

0.05m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1128165166));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.04m,

1.00m,

0.43m,

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
                Assert.That(model.Id, Is.EqualTo(336737745));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.03m,

0.01m,

1.00m,

0.35m,

};
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
                Assert.That(model.Id, Is.EqualTo(382211456));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.13m,

0.27m,

0.47m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.58m,

0.37m,

0.18m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(745381557));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.03m,

0.24m,

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
                Assert.That(model.Id, Is.EqualTo(387019197));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.19m,

0.21m,

0.51m,

0.92m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.51m,

0.53m,

0.57m,

0.72m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(931433918));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00m,

0.07m,

0.73m,

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
                Assert.That(model.Id, Is.EqualTo(561702663));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.93m,

0.91m,

0.22m,

};
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
                Assert.That(model.Id, Is.EqualTo(585729157));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.35m,

0.47m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(915733516));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.84m,

0.62m,

0.28m,

0.43m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.57m,

0.23m,

0.50m,

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
                Assert.That(model.Id, Is.EqualTo(603496749));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.28m,

0.42m,

0.23m,

0.40m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.11m,

0.53m,

0.08m,

0.26m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1084161682));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63m,

0.27m,

0.20m,

0.35m,

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
                Assert.That(model.Id, Is.EqualTo(742387234));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.78m,

0.43m,

0.08m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1507914019));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.16m,

0.78m,

0.42m,

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
                Assert.That(model.Id, Is.EqualTo(785819060));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.39m,

0.01m,

0.79m,

0.97m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.03m,

0.21m,

0.90m,

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
                Assert.That(model.Id, Is.EqualTo(948900206));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.90m,

0.81m,

0.87m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.09m,

0.74m,

0.34m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1065938893));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.61m,

0.79m,

0.96m,

0.50m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.68m,

0.71m,

0.62m,

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
                Assert.That(model.Id, Is.EqualTo(986984605));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.96m,

0.64m,

0.73m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.88m,

0.17m,

0.64m,

0.98m,

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
                Assert.That(model.Id, Is.EqualTo(1027130948));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.52m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.55m,

0.54m,

0.47m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940404136));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.32m,

0.30m,

0.13m,

0.01m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.96m,

0.04m,

0.97m,

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
                Assert.That(model.Id, Is.EqualTo(1219533177));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.72m,

0.36m,

0.74m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.17m,

0.47m,

0.04m,

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
                Assert.That(model.Id, Is.EqualTo(1255259303));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.56m,

0.06m,

0.01m,

0.89m,

};
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
                Assert.That(model.Id, Is.EqualTo(1331109979));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.07m,

0.72m,

0.68m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.44m,

0.87m,

0.22m,

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
                Assert.That(model.Id, Is.EqualTo(1455719771));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.05m,

0.66m,

0.49m,

0.18m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1989887715));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.34m,

0.43m,

0.90m,

0.29m,

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
                Assert.That(model.Id, Is.EqualTo(1469229955));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.88m,

0.20m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1391339514));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.84m,

0.30m,

0.05m,

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
new System.Collections.Generic.List<System.Decimal>(4)
{
0.60m,

0.34m,

0.73m,

0.79m,

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
                Assert.That(model.Id, Is.EqualTo(1522517769));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.98m,

0.99m,

0.72m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.98m,

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
                Assert.That(model.Id, Is.EqualTo(1544303855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.03m,

0.23m,

0.21m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1679004264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.02m,

0.45m,

0.39m,

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
                Assert.That(model.Id, Is.EqualTo(1591389282));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.69m,

0.51m,

0.24m,

0.20m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.36m,

0.39m,

0.55m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2086038716));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.98m,

0.97m,

0.79m,

0.24m,

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

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1609735417));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.56m,

0.42m,

0.33m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.15m,

0.87m,

0.97m,

0.52m,

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
                Assert.That(model.Id, Is.EqualTo(1650133984));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.30m,

0.88m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(924792188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.17m,

0.22m,

0.16m,

0.62m,

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
new System.Collections.Generic.List<System.Decimal>(4)
{
0.58m,

0.76m,

0.26m,

0.87m,

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
                Assert.That(model.Id, Is.EqualTo(1726726308));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.91m,

0.02m,

0.38m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2016905416));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.30m,

0.96m,

0.04m,

0.80m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.97m,

0.83m,

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
                Assert.That(model.Id, Is.EqualTo(1833587780));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.62m,

1.00m,

0.08m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.54m,

0.96m,

0.90m,

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
                Assert.That(model.Id, Is.EqualTo(2088200534));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.91m,

0.81m,

0.95m,

0.53m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.79m,

0.92m,

0.66m,

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2138732876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.85m,

0.22m,

0.59m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.40m,

0.07m,

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

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListmoneyArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(7816882));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.81m,

1.00m,

0.32m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.24m,

0.46m,

0.62m,

0.05m,

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
                Assert.That(model.Id, Is.EqualTo(89558594));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.83m,

0.27m,

0.91m,

0.59m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.76m,

1.00m,

0.58m,

0.81m,

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
                Assert.That(model.Id, Is.EqualTo(197749978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.14m,

0.55m,

0.11m,

0.75m,

};
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
                Assert.That(model.Id, Is.EqualTo(235819484));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.83m,

0.80m,

0.67m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.46m,

0.15m,

0.16m,

0.29m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1022846180));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.06m,

0.65m,

0.73m,

0.35m,

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
                Assert.That(model.Id, Is.EqualTo(310591520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.54m,

0.01m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.08m,

0.29m,

0.05m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1128165166));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.04m,

1.00m,

0.43m,

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
                Assert.That(model.Id, Is.EqualTo(336737745));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.03m,

0.01m,

1.00m,

0.35m,

};
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
                Assert.That(model.Id, Is.EqualTo(382211456));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.13m,

0.27m,

0.47m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.58m,

0.37m,

0.18m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(745381557));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.03m,

0.24m,

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
                Assert.That(model.Id, Is.EqualTo(387019197));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.19m,

0.21m,

0.51m,

0.92m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.51m,

0.53m,

0.57m,

0.72m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(931433918));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00m,

0.07m,

0.73m,

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
                Assert.That(model.Id, Is.EqualTo(561702663));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.93m,

0.91m,

0.22m,

};
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
                Assert.That(model.Id, Is.EqualTo(585729157));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.35m,

0.47m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(915733516));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.84m,

0.62m,

0.28m,

0.43m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.57m,

0.23m,

0.50m,

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
                Assert.That(model.Id, Is.EqualTo(603496749));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.28m,

0.42m,

0.23m,

0.40m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.11m,

0.53m,

0.08m,

0.26m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1084161682));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63m,

0.27m,

0.20m,

0.35m,

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
                Assert.That(model.Id, Is.EqualTo(742387234));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.78m,

0.43m,

0.08m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1507914019));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.16m,

0.78m,

0.42m,

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
                Assert.That(model.Id, Is.EqualTo(785819060));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.39m,

0.01m,

0.79m,

0.97m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.03m,

0.21m,

0.90m,

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
                Assert.That(model.Id, Is.EqualTo(948900206));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.90m,

0.81m,

0.87m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.09m,

0.74m,

0.34m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1065938893));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.61m,

0.79m,

0.96m,

0.50m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.68m,

0.71m,

0.62m,

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
                Assert.That(model.Id, Is.EqualTo(986984605));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.96m,

0.64m,

0.73m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.88m,

0.17m,

0.64m,

0.98m,

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
                Assert.That(model.Id, Is.EqualTo(1027130948));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.52m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.55m,

0.54m,

0.47m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940404136));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.32m,

0.30m,

0.13m,

0.01m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.96m,

0.04m,

0.97m,

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
                Assert.That(model.Id, Is.EqualTo(1219533177));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.72m,

0.36m,

0.74m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.17m,

0.47m,

0.04m,

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
                Assert.That(model.Id, Is.EqualTo(1255259303));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.56m,

0.06m,

0.01m,

0.89m,

};
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
                Assert.That(model.Id, Is.EqualTo(1331109979));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.07m,

0.72m,

0.68m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.44m,

0.87m,

0.22m,

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
                Assert.That(model.Id, Is.EqualTo(1455719771));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.05m,

0.66m,

0.49m,

0.18m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1989887715));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.34m,

0.43m,

0.90m,

0.29m,

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
                Assert.That(model.Id, Is.EqualTo(1469229955));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.88m,

0.20m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1391339514));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.84m,

0.30m,

0.05m,

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
new System.Collections.Generic.List<System.Decimal>(4)
{
0.60m,

0.34m,

0.73m,

0.79m,

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
                Assert.That(model.Id, Is.EqualTo(1522517769));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.98m,

0.99m,

0.72m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.98m,

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
                Assert.That(model.Id, Is.EqualTo(1544303855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.03m,

0.23m,

0.21m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1679004264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.02m,

0.45m,

0.39m,

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
                Assert.That(model.Id, Is.EqualTo(1591389282));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.69m,

0.51m,

0.24m,

0.20m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.36m,

0.39m,

0.55m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2086038716));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.98m,

0.97m,

0.79m,

0.24m,

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

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1609735417));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.56m,

0.42m,

0.33m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.15m,

0.87m,

0.97m,

0.52m,

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
                Assert.That(model.Id, Is.EqualTo(1650133984));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.30m,

0.88m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(924792188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.17m,

0.22m,

0.16m,

0.62m,

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
new System.Collections.Generic.List<System.Decimal>(4)
{
0.58m,

0.76m,

0.26m,

0.87m,

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
                Assert.That(model.Id, Is.EqualTo(1726726308));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.91m,

0.02m,

0.38m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2016905416));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.30m,

0.96m,

0.04m,

0.80m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.97m,

0.83m,

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
                Assert.That(model.Id, Is.EqualTo(1833587780));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.62m,

1.00m,

0.08m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.54m,

0.96m,

0.90m,

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
                Assert.That(model.Id, Is.EqualTo(2088200534));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.91m,

0.81m,

0.95m,

0.53m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.79m,

0.92m,

0.66m,

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2138732876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.85m,

0.22m,

0.59m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.40m,

0.07m,

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

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListmoneyArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListmoneyArray)this).SetDbConnectionSelectModelParametrs(cmd, 742387234);
                var models =  ((IDecimalListmoneyArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(18));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(785819060));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.39m,

0.01m,

0.79m,

0.97m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.03m,

0.21m,

0.90m,

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
                Assert.That(model.Id, Is.EqualTo(948900206));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.90m,

0.81m,

0.87m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.09m,

0.74m,

0.34m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1065938893));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.61m,

0.79m,

0.96m,

0.50m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.68m,

0.71m,

0.62m,

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
                Assert.That(model.Id, Is.EqualTo(986984605));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.96m,

0.64m,

0.73m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.88m,

0.17m,

0.64m,

0.98m,

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
                Assert.That(model.Id, Is.EqualTo(1027130948));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.52m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.55m,

0.54m,

0.47m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940404136));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.32m,

0.30m,

0.13m,

0.01m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.96m,

0.04m,

0.97m,

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
                Assert.That(model.Id, Is.EqualTo(1219533177));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.72m,

0.36m,

0.74m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.17m,

0.47m,

0.04m,

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
                Assert.That(model.Id, Is.EqualTo(1255259303));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.56m,

0.06m,

0.01m,

0.89m,

};
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
                Assert.That(model.Id, Is.EqualTo(1331109979));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.07m,

0.72m,

0.68m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.44m,

0.87m,

0.22m,

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
                Assert.That(model.Id, Is.EqualTo(1455719771));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.05m,

0.66m,

0.49m,

0.18m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1989887715));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.34m,

0.43m,

0.90m,

0.29m,

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
                Assert.That(model.Id, Is.EqualTo(1469229955));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.88m,

0.20m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1391339514));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.84m,

0.30m,

0.05m,

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
new System.Collections.Generic.List<System.Decimal>(4)
{
0.60m,

0.34m,

0.73m,

0.79m,

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
                Assert.That(model.Id, Is.EqualTo(1522517769));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.98m,

0.99m,

0.72m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.98m,

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
                Assert.That(model.Id, Is.EqualTo(1544303855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.03m,

0.23m,

0.21m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1679004264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.02m,

0.45m,

0.39m,

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
                Assert.That(model.Id, Is.EqualTo(1591389282));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.69m,

0.51m,

0.24m,

0.20m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.36m,

0.39m,

0.55m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2086038716));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.98m,

0.97m,

0.79m,

0.24m,

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
                Assert.That(model.Id, Is.EqualTo(1609735417));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.56m,

0.42m,

0.33m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.15m,

0.87m,

0.97m,

0.52m,

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
                Assert.That(model.Id, Is.EqualTo(1650133984));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.30m,

0.88m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(924792188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.17m,

0.22m,

0.16m,

0.62m,

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
new System.Collections.Generic.List<System.Decimal>(4)
{
0.58m,

0.76m,

0.26m,

0.87m,

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
                Assert.That(model.Id, Is.EqualTo(1726726308));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.91m,

0.02m,

0.38m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2016905416));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.30m,

0.96m,

0.04m,

0.80m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.97m,

0.83m,

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
                Assert.That(model.Id, Is.EqualTo(1833587780));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.62m,

1.00m,

0.08m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.54m,

0.96m,

0.90m,

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
                Assert.That(model.Id, Is.EqualTo(2088200534));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.91m,

0.81m,

0.95m,

0.53m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.79m,

0.92m,

0.66m,

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
                Assert.That(model.Id, Is.EqualTo(2138732876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.85m,

0.22m,

0.59m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.40m,

0.07m,

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

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDecimalListmoneyArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalListmoneyArray)this).SetDbConnectionSelectModelParametrs(cmd, 948900206);
                var models = await ((IDecimalListmoneyArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(16));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(986984605));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.96m,

0.64m,

0.73m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.88m,

0.17m,

0.64m,

0.98m,

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
                Assert.That(model.Id, Is.EqualTo(1027130948));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.52m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.55m,

0.54m,

0.47m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940404136));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.32m,

0.30m,

0.13m,

0.01m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.96m,

0.04m,

0.97m,

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
                Assert.That(model.Id, Is.EqualTo(1219533177));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.72m,

0.36m,

0.74m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.17m,

0.47m,

0.04m,

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
                Assert.That(model.Id, Is.EqualTo(1255259303));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.56m,

0.06m,

0.01m,

0.89m,

};
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
                Assert.That(model.Id, Is.EqualTo(1331109979));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.07m,

0.72m,

0.68m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.44m,

0.87m,

0.22m,

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
                Assert.That(model.Id, Is.EqualTo(1455719771));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.05m,

0.66m,

0.49m,

0.18m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1989887715));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.34m,

0.43m,

0.90m,

0.29m,

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
                Assert.That(model.Id, Is.EqualTo(1469229955));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.88m,

0.20m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1391339514));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.84m,

0.30m,

0.05m,

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
new System.Collections.Generic.List<System.Decimal>(4)
{
0.60m,

0.34m,

0.73m,

0.79m,

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
                Assert.That(model.Id, Is.EqualTo(1522517769));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.98m,

0.99m,

0.72m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.98m,

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
                Assert.That(model.Id, Is.EqualTo(1544303855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.03m,

0.23m,

0.21m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1679004264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.02m,

0.45m,

0.39m,

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
                Assert.That(model.Id, Is.EqualTo(1591389282));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.69m,

0.51m,

0.24m,

0.20m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.36m,

0.39m,

0.55m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2086038716));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.98m,

0.97m,

0.79m,

0.24m,

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
                Assert.That(model.Id, Is.EqualTo(1609735417));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.56m,

0.42m,

0.33m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.15m,

0.87m,

0.97m,

0.52m,

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
                Assert.That(model.Id, Is.EqualTo(1650133984));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.30m,

0.88m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(924792188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.17m,

0.22m,

0.16m,

0.62m,

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
new System.Collections.Generic.List<System.Decimal>(4)
{
0.58m,

0.76m,

0.26m,

0.87m,

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
                Assert.That(model.Id, Is.EqualTo(1726726308));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.91m,

0.02m,

0.38m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2016905416));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.30m,

0.96m,

0.04m,

0.80m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.97m,

0.83m,

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
                Assert.That(model.Id, Is.EqualTo(1833587780));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.62m,

1.00m,

0.08m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.54m,

0.96m,

0.90m,

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
                Assert.That(model.Id, Is.EqualTo(2088200534));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.91m,

0.81m,

0.95m,

0.53m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.79m,

0.92m,

0.66m,

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
                Assert.That(model.Id, Is.EqualTo(2138732876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.85m,

0.22m,

0.59m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.40m,

0.07m,

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

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)
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
                 foreach(var batchResult in ((IDecimalListmoneyArray)this).DbConnectionSelectModelBatch(connection, 1833587780, 1609735417))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(2));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2088200534));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.91m,

0.81m,

0.95m,

0.53m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.79m,

0.92m,

0.66m,

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
                Assert.That(model.Id, Is.EqualTo(2138732876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.85m,

0.22m,

0.59m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.40m,

0.07m,

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

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(5));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1650133984));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.30m,

0.88m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(924792188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.17m,

0.22m,

0.16m,

0.62m,

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
new System.Collections.Generic.List<System.Decimal>(4)
{
0.58m,

0.76m,

0.26m,

0.87m,

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
                Assert.That(model.Id, Is.EqualTo(1726726308));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.91m,

0.02m,

0.38m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2016905416));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.30m,

0.96m,

0.04m,

0.80m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.97m,

0.83m,

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
                Assert.That(model.Id, Is.EqualTo(1833587780));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.62m,

1.00m,

0.08m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.54m,

0.96m,

0.90m,

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
                Assert.That(model.Id, Is.EqualTo(2088200534));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.91m,

0.81m,

0.95m,

0.53m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.79m,

0.92m,

0.66m,

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
                Assert.That(model.Id, Is.EqualTo(2138732876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.85m,

0.22m,

0.59m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.40m,

0.07m,

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
                await foreach(var batchResult in ((IDecimalListmoneyArray)this).DbConnectionSelectModelBatchAsync(connection, 1650133984, 89558594))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(4));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1726726308));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.91m,

0.02m,

0.38m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2016905416));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.30m,

0.96m,

0.04m,

0.80m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.97m,

0.83m,

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
                Assert.That(model.Id, Is.EqualTo(1833587780));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.62m,

1.00m,

0.08m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.54m,

0.96m,

0.90m,

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
                Assert.That(model.Id, Is.EqualTo(2088200534));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.91m,

0.81m,

0.95m,

0.53m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.79m,

0.92m,

0.66m,

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
                Assert.That(model.Id, Is.EqualTo(2138732876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.85m,

0.22m,

0.59m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.40m,

0.07m,

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

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(28));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(197749978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.14m,

0.55m,

0.11m,

0.75m,

};
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
                Assert.That(model.Id, Is.EqualTo(235819484));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.83m,

0.80m,

0.67m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.46m,

0.15m,

0.16m,

0.29m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1022846180));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.06m,

0.65m,

0.73m,

0.35m,

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
                Assert.That(model.Id, Is.EqualTo(310591520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.54m,

0.01m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.08m,

0.29m,

0.05m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1128165166));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.04m,

1.00m,

0.43m,

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
                Assert.That(model.Id, Is.EqualTo(336737745));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.03m,

0.01m,

1.00m,

0.35m,

};
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
                Assert.That(model.Id, Is.EqualTo(382211456));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.13m,

0.27m,

0.47m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.58m,

0.37m,

0.18m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(745381557));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.03m,

0.24m,

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
                Assert.That(model.Id, Is.EqualTo(387019197));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.19m,

0.21m,

0.51m,

0.92m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.51m,

0.53m,

0.57m,

0.72m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(931433918));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00m,

0.07m,

0.73m,

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
                Assert.That(model.Id, Is.EqualTo(561702663));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.93m,

0.91m,

0.22m,

};
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
                Assert.That(model.Id, Is.EqualTo(585729157));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.35m,

0.47m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(915733516));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.84m,

0.62m,

0.28m,

0.43m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.57m,

0.23m,

0.50m,

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
                Assert.That(model.Id, Is.EqualTo(603496749));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.28m,

0.42m,

0.23m,

0.40m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.11m,

0.53m,

0.08m,

0.26m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1084161682));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63m,

0.27m,

0.20m,

0.35m,

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
                Assert.That(model.Id, Is.EqualTo(742387234));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.78m,

0.43m,

0.08m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1507914019));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.16m,

0.78m,

0.42m,

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
                Assert.That(model.Id, Is.EqualTo(785819060));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.39m,

0.01m,

0.79m,

0.97m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.03m,

0.21m,

0.90m,

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
                Assert.That(model.Id, Is.EqualTo(948900206));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.90m,

0.81m,

0.87m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.09m,

0.74m,

0.34m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1065938893));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.61m,

0.79m,

0.96m,

0.50m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.68m,

0.71m,

0.62m,

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
                Assert.That(model.Id, Is.EqualTo(986984605));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.96m,

0.64m,

0.73m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.88m,

0.17m,

0.64m,

0.98m,

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
                Assert.That(model.Id, Is.EqualTo(1027130948));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.52m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.55m,

0.54m,

0.47m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940404136));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.32m,

0.30m,

0.13m,

0.01m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.96m,

0.04m,

0.97m,

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
                Assert.That(model.Id, Is.EqualTo(1219533177));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.72m,

0.36m,

0.74m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.17m,

0.47m,

0.04m,

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
                Assert.That(model.Id, Is.EqualTo(1255259303));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.56m,

0.06m,

0.01m,

0.89m,

};
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
                Assert.That(model.Id, Is.EqualTo(1331109979));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.07m,

0.72m,

0.68m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.44m,

0.87m,

0.22m,

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
                Assert.That(model.Id, Is.EqualTo(1455719771));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.05m,

0.66m,

0.49m,

0.18m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1989887715));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.34m,

0.43m,

0.90m,

0.29m,

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
                Assert.That(model.Id, Is.EqualTo(1469229955));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.88m,

0.20m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1391339514));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.84m,

0.30m,

0.05m,

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
new System.Collections.Generic.List<System.Decimal>(4)
{
0.60m,

0.34m,

0.73m,

0.79m,

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
                Assert.That(model.Id, Is.EqualTo(1522517769));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.98m,

0.99m,

0.72m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.98m,

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
                Assert.That(model.Id, Is.EqualTo(1544303855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.03m,

0.23m,

0.21m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1679004264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.02m,

0.45m,

0.39m,

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
                Assert.That(model.Id, Is.EqualTo(1591389282));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.69m,

0.51m,

0.24m,

0.20m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.36m,

0.39m,

0.55m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2086038716));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.98m,

0.97m,

0.79m,

0.24m,

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
                Assert.That(model.Id, Is.EqualTo(1609735417));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.56m,

0.42m,

0.33m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.15m,

0.87m,

0.97m,

0.52m,

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
                Assert.That(model.Id, Is.EqualTo(1650133984));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.30m,

0.88m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(924792188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.17m,

0.22m,

0.16m,

0.62m,

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
new System.Collections.Generic.List<System.Decimal>(4)
{
0.58m,

0.76m,

0.26m,

0.87m,

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
                Assert.That(model.Id, Is.EqualTo(1726726308));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.91m,

0.02m,

0.38m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2016905416));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.30m,

0.96m,

0.04m,

0.80m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.97m,

0.83m,

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1833587780));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.62m,

1.00m,

0.08m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.54m,

0.96m,

0.90m,

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

                        model = models[26];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2088200534));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.91m,

0.81m,

0.95m,

0.53m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.79m,

0.92m,

0.66m,

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

                        model = models[27];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2138732876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.85m,

0.22m,

0.59m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.40m,

0.07m,

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
COPY public.binary_decimalmoneyarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalmoneyArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636)
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
FROM public.binary_decimalmoneyarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(DecimalmoneyArray2MI),
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

                var importCollection = new List<DecimalmoneyArray2MI>(7);

                importCollection.Add(
                new DecimalmoneyArray2MI
                {
                    Id = 745381557,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.03m,

0.24m,

},
                    NullableValue = null
                });

                importCollection.Add(
                new DecimalmoneyArray2MI
                {
                    Id = 915733516,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.84m,

0.62m,

0.28m,

0.43m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.57m,

0.23m,

0.50m,

}
                });

                importCollection.Add(
                new DecimalmoneyArray2MI
                {
                    Id = 924792188,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.17m,

0.22m,

0.16m,

0.62m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.58m,

0.76m,

0.26m,

0.87m,

}
                });

                importCollection.Add(
                new DecimalmoneyArray2MI
                {
                    Id = 931433918,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00m,

0.07m,

0.73m,

},
                    NullableValue = null
                });

                importCollection.Add(
                new DecimalmoneyArray2MI
                {
                    Id = 1022846180,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.06m,

0.65m,

0.73m,

0.35m,

},
                    NullableValue = null
                });

                importCollection.Add(
                new DecimalmoneyArray2MI
                {
                    Id = 1065938893,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.61m,

0.79m,

0.96m,

0.50m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.68m,

0.71m,

0.62m,

}
                });

                importCollection.Add(
                new DecimalmoneyArray2MI
                {
                    Id = 1084161682,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63m,

0.27m,

0.20m,

0.35m,

},
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(745381557));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.03m,

0.24m,

};
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
                Assert.That(model.Id, Is.EqualTo(915733516));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.84m,

0.62m,

0.28m,

0.43m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.57m,

0.23m,

0.50m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(924792188));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.17m,

0.22m,

0.16m,

0.62m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.58m,

0.76m,

0.26m,

0.87m,

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
                Assert.That(model.Id, Is.EqualTo(931433918));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00m,

0.07m,

0.73m,

};
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
                Assert.That(model.Id, Is.EqualTo(1022846180));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.06m,

0.65m,

0.73m,

0.35m,

};
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
                Assert.That(model.Id, Is.EqualTo(1065938893));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.61m,

0.79m,

0.96m,

0.50m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.68m,

0.71m,

0.62m,

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
                Assert.That(model.Id, Is.EqualTo(1084161682));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63m,

0.27m,

0.20m,

0.35m,

};
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
                new DecimalmoneyArray2MI
                {
                    Id = 1128165166,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.04m,

1.00m,

0.43m,

},
                    NullableValue = null
                });

                importCollection.Add(
                new DecimalmoneyArray2MI
                {
                    Id = 1391339514,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.84m,

0.30m,

0.05m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.60m,

0.34m,

0.73m,

0.79m,

}
                });

                importCollection.Add(
                new DecimalmoneyArray2MI
                {
                    Id = 1507914019,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.16m,

0.78m,

0.42m,

},
                    NullableValue = null
                });

                importCollection.Add(
                new DecimalmoneyArray2MI
                {
                    Id = 1679004264,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.02m,

0.45m,

0.39m,

},
                    NullableValue = null
                });

                importCollection.Add(
                new DecimalmoneyArray2MI
                {
                    Id = 1940404136,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.32m,

0.30m,

0.13m,

0.01m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.96m,

0.04m,

0.97m,

}
                });

                importCollection.Add(
                new DecimalmoneyArray2MI
                {
                    Id = 1989887715,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.34m,

0.43m,

0.90m,

0.29m,

},
                    NullableValue = null
                });

                importCollection.Add(
                new DecimalmoneyArray2MI
                {
                    Id = 2016905416,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.30m,

0.96m,

0.04m,

0.80m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.97m,

0.83m,

}
                });

                importCollection.Add(
                new DecimalmoneyArray2MI
                {
                    Id = 2086038716,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.98m,

0.97m,

0.79m,

0.24m,

},
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(745381557));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.03m,

0.24m,

};
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
                Assert.That(model.Id, Is.EqualTo(915733516));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.84m,

0.62m,

0.28m,

0.43m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.57m,

0.23m,

0.50m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(924792188));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.17m,

0.22m,

0.16m,

0.62m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.58m,

0.76m,

0.26m,

0.87m,

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
                Assert.That(model.Id, Is.EqualTo(931433918));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00m,

0.07m,

0.73m,

};
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
                Assert.That(model.Id, Is.EqualTo(1022846180));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.06m,

0.65m,

0.73m,

0.35m,

};
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
                Assert.That(model.Id, Is.EqualTo(1065938893));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.61m,

0.79m,

0.96m,

0.50m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.68m,

0.71m,

0.62m,

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
                Assert.That(model.Id, Is.EqualTo(1084161682));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63m,

0.27m,

0.20m,

0.35m,

};
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
                Assert.That(model.Id, Is.EqualTo(1128165166));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.04m,

1.00m,

0.43m,

};
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
                Assert.That(model.Id, Is.EqualTo(1391339514));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.84m,

0.30m,

0.05m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.60m,

0.34m,

0.73m,

0.79m,

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
                Assert.That(model.Id, Is.EqualTo(1507914019));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.16m,

0.78m,

0.42m,

};
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
                Assert.That(model.Id, Is.EqualTo(1679004264));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.02m,

0.45m,

0.39m,

};
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
                Assert.That(model.Id, Is.EqualTo(1940404136));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.32m,

0.30m,

0.13m,

0.01m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.96m,

0.04m,

0.97m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1989887715));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.34m,

0.43m,

0.90m,

0.29m,

};
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
                Assert.That(model.Id, Is.EqualTo(2016905416));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.30m,

0.96m,

0.04m,

0.80m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.97m,

0.83m,

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
                Assert.That(model.Id, Is.EqualTo(2086038716));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.98m,

0.97m,

0.79m,

0.24m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalmoneyarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalmoneyarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalmoneyArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636)
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
FROM public.binary_decimalmoneyarray2m m
LEFT JOIN public.binary_decimalmoneyarray2mi mi ON mi.id = m.decimalmoneyarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(DecimalmoneyArray2M),
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

                var importCollection = new List<DecimalmoneyArray2M>(15);

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 7816882,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.81m,

1.00m,

0.32m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.24m,

0.46m,

0.62m,

0.05m,

},

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 89558594,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.83m,

0.27m,

0.91m,

0.59m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.76m,

1.00m,

0.58m,

0.81m,

},

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 197749978,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.14m,

0.55m,

0.11m,

0.75m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 235819484,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.83m,

0.80m,

0.67m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.46m,

0.15m,

0.16m,

0.29m,

},

                    ModelInner = new DecimalmoneyArray2MI 
                    {
                        Id = 1022846180
                    }

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 310591520,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.54m,

0.01m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.08m,

0.29m,

0.05m,

},

                    ModelInner = new DecimalmoneyArray2MI 
                    {
                        Id = 1128165166
                    }

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 336737745,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.03m,

0.01m,

1.00m,

0.35m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 382211456,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.13m,

0.27m,

0.47m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.58m,

0.37m,

0.18m,

},

                    ModelInner = new DecimalmoneyArray2MI 
                    {
                        Id = 745381557
                    }

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 387019197,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.19m,

0.21m,

0.51m,

0.92m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.51m,

0.53m,

0.57m,

0.72m,

},

                    ModelInner = new DecimalmoneyArray2MI 
                    {
                        Id = 931433918
                    }

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 561702663,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.93m,

0.91m,

0.22m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 585729157,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.35m,

0.47m,

0.40m,

},
                    NullableValue = null,

                    ModelInner = new DecimalmoneyArray2MI 
                    {
                        Id = 915733516
                    }

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 603496749,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.28m,

0.42m,

0.23m,

0.40m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.11m,

0.53m,

0.08m,

0.26m,

},

                    ModelInner = new DecimalmoneyArray2MI 
                    {
                        Id = 1084161682
                    }

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 742387234,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.78m,

0.43m,

0.08m,

},
                    NullableValue = null,

                    ModelInner = new DecimalmoneyArray2MI 
                    {
                        Id = 1507914019
                    }

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 785819060,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.39m,

0.01m,

0.79m,

0.97m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.03m,

0.21m,

0.90m,

},

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 948900206,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.90m,

0.81m,

0.87m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.09m,

0.74m,

0.34m,

},

                    ModelInner = new DecimalmoneyArray2MI 
                    {
                        Id = 1065938893
                    }

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 986984605,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.96m,

0.64m,

0.73m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.88m,

0.17m,

0.64m,

0.98m,

},

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(7816882));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.81m,

1.00m,

0.32m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.24m,

0.46m,

0.62m,

0.05m,

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
                Assert.That(model.Id, Is.EqualTo(89558594));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.83m,

0.27m,

0.91m,

0.59m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.76m,

1.00m,

0.58m,

0.81m,

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
                Assert.That(model.Id, Is.EqualTo(197749978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.14m,

0.55m,

0.11m,

0.75m,

};
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
                Assert.That(model.Id, Is.EqualTo(235819484));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.83m,

0.80m,

0.67m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.46m,

0.15m,

0.16m,

0.29m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1022846180));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.06m,

0.65m,

0.73m,

0.35m,

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
                Assert.That(model.Id, Is.EqualTo(310591520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.54m,

0.01m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.08m,

0.29m,

0.05m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1128165166));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.04m,

1.00m,

0.43m,

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
                Assert.That(model.Id, Is.EqualTo(336737745));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.03m,

0.01m,

1.00m,

0.35m,

};
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
                Assert.That(model.Id, Is.EqualTo(382211456));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.13m,

0.27m,

0.47m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.58m,

0.37m,

0.18m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(745381557));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.03m,

0.24m,

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
                Assert.That(model.Id, Is.EqualTo(387019197));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.19m,

0.21m,

0.51m,

0.92m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.51m,

0.53m,

0.57m,

0.72m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(931433918));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00m,

0.07m,

0.73m,

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
                Assert.That(model.Id, Is.EqualTo(561702663));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.93m,

0.91m,

0.22m,

};
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
                Assert.That(model.Id, Is.EqualTo(585729157));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.35m,

0.47m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(915733516));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.84m,

0.62m,

0.28m,

0.43m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.57m,

0.23m,

0.50m,

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
                Assert.That(model.Id, Is.EqualTo(603496749));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.28m,

0.42m,

0.23m,

0.40m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.11m,

0.53m,

0.08m,

0.26m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1084161682));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63m,

0.27m,

0.20m,

0.35m,

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
                Assert.That(model.Id, Is.EqualTo(742387234));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.78m,

0.43m,

0.08m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1507914019));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.16m,

0.78m,

0.42m,

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
                Assert.That(model.Id, Is.EqualTo(785819060));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.39m,

0.01m,

0.79m,

0.97m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.03m,

0.21m,

0.90m,

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
                Assert.That(model.Id, Is.EqualTo(948900206));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.90m,

0.81m,

0.87m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.09m,

0.74m,

0.34m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1065938893));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.61m,

0.79m,

0.96m,

0.50m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.68m,

0.71m,

0.62m,

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
                Assert.That(model.Id, Is.EqualTo(986984605));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.96m,

0.64m,

0.73m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.88m,

0.17m,

0.64m,

0.98m,

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
                new DecimalmoneyArray2M
                {
                    Id = 1027130948,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.52m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.55m,

0.54m,

0.47m,

},

                    ModelInner = new DecimalmoneyArray2MI 
                    {
                        Id = 1940404136
                    }

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 1219533177,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.72m,

0.36m,

0.74m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.17m,

0.47m,

0.04m,

},

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 1255259303,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.56m,

0.06m,

0.01m,

0.89m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 1331109979,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.07m,

0.72m,

0.68m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.44m,

0.87m,

0.22m,

},

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 1455719771,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.05m,

0.66m,

0.49m,

0.18m,

},
                    NullableValue = null,

                    ModelInner = new DecimalmoneyArray2MI 
                    {
                        Id = 1989887715
                    }

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 1469229955,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.88m,

0.20m,

0.40m,

},
                    NullableValue = null,

                    ModelInner = new DecimalmoneyArray2MI 
                    {
                        Id = 1391339514
                    }

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 1522517769,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.98m,

0.99m,

0.72m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.98m,

},

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 1544303855,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.03m,

0.23m,

0.21m,

},
                    NullableValue = null,

                    ModelInner = new DecimalmoneyArray2MI 
                    {
                        Id = 1679004264
                    }

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 1591389282,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.69m,

0.51m,

0.24m,

0.20m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.36m,

0.39m,

0.55m,

},

                    ModelInner = new DecimalmoneyArray2MI 
                    {
                        Id = 2086038716
                    }

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 1609735417,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.56m,

0.42m,

0.33m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.15m,

0.87m,

0.97m,

0.52m,

},

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 1650133984,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.30m,

0.88m,

0.40m,

},
                    NullableValue = null,

                    ModelInner = new DecimalmoneyArray2MI 
                    {
                        Id = 924792188
                    }

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 1726726308,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.91m,

0.02m,

0.38m,

},
                    NullableValue = null,

                    ModelInner = new DecimalmoneyArray2MI 
                    {
                        Id = 2016905416
                    }

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 1833587780,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.62m,

1.00m,

0.08m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.54m,

0.96m,

0.90m,

},

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 2088200534,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.91m,

0.81m,

0.95m,

0.53m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.79m,

0.92m,

0.66m,

},

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalmoneyArray2M
                {
                    Id = 2138732876,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.85m,

0.22m,

0.59m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.40m,

0.07m,

},

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(7816882));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.81m,

1.00m,

0.32m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.24m,

0.46m,

0.62m,

0.05m,

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
                Assert.That(model.Id, Is.EqualTo(89558594));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.83m,

0.27m,

0.91m,

0.59m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.76m,

1.00m,

0.58m,

0.81m,

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
                Assert.That(model.Id, Is.EqualTo(197749978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.14m,

0.55m,

0.11m,

0.75m,

};
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
                Assert.That(model.Id, Is.EqualTo(235819484));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.83m,

0.80m,

0.67m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.46m,

0.15m,

0.16m,

0.29m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1022846180));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.06m,

0.65m,

0.73m,

0.35m,

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
                Assert.That(model.Id, Is.EqualTo(310591520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.54m,

0.01m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.08m,

0.29m,

0.05m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1128165166));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.04m,

1.00m,

0.43m,

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
                Assert.That(model.Id, Is.EqualTo(336737745));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.03m,

0.01m,

1.00m,

0.35m,

};
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
                Assert.That(model.Id, Is.EqualTo(382211456));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.13m,

0.27m,

0.47m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.58m,

0.37m,

0.18m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(745381557));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.03m,

0.24m,

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
                Assert.That(model.Id, Is.EqualTo(387019197));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.19m,

0.21m,

0.51m,

0.92m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.51m,

0.53m,

0.57m,

0.72m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(931433918));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00m,

0.07m,

0.73m,

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
                Assert.That(model.Id, Is.EqualTo(561702663));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.93m,

0.91m,

0.22m,

};
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
                Assert.That(model.Id, Is.EqualTo(585729157));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.35m,

0.47m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(915733516));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.84m,

0.62m,

0.28m,

0.43m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.57m,

0.23m,

0.50m,

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
                Assert.That(model.Id, Is.EqualTo(603496749));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.28m,

0.42m,

0.23m,

0.40m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.11m,

0.53m,

0.08m,

0.26m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1084161682));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63m,

0.27m,

0.20m,

0.35m,

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
                Assert.That(model.Id, Is.EqualTo(742387234));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.78m,

0.43m,

0.08m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1507914019));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.16m,

0.78m,

0.42m,

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
                Assert.That(model.Id, Is.EqualTo(785819060));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.39m,

0.01m,

0.79m,

0.97m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.03m,

0.21m,

0.90m,

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
                Assert.That(model.Id, Is.EqualTo(948900206));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.90m,

0.81m,

0.87m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.09m,

0.74m,

0.34m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1065938893));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.61m,

0.79m,

0.96m,

0.50m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.68m,

0.71m,

0.62m,

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
                Assert.That(model.Id, Is.EqualTo(986984605));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.96m,

0.64m,

0.73m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.88m,

0.17m,

0.64m,

0.98m,

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
                Assert.That(model.Id, Is.EqualTo(1027130948));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.52m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.55m,

0.54m,

0.47m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940404136));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.32m,

0.30m,

0.13m,

0.01m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.96m,

0.04m,

0.97m,

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
                Assert.That(model.Id, Is.EqualTo(1219533177));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.72m,

0.36m,

0.74m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.17m,

0.47m,

0.04m,

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
                Assert.That(model.Id, Is.EqualTo(1255259303));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.56m,

0.06m,

0.01m,

0.89m,

};
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
                Assert.That(model.Id, Is.EqualTo(1331109979));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.07m,

0.72m,

0.68m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.44m,

0.87m,

0.22m,

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
                Assert.That(model.Id, Is.EqualTo(1455719771));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.05m,

0.66m,

0.49m,

0.18m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1989887715));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.34m,

0.43m,

0.90m,

0.29m,

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
                Assert.That(model.Id, Is.EqualTo(1469229955));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.88m,

0.20m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1391339514));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.84m,

0.30m,

0.05m,

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
new System.Collections.Generic.List<System.Decimal>(4)
{
0.60m,

0.34m,

0.73m,

0.79m,

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
                Assert.That(model.Id, Is.EqualTo(1522517769));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.98m,

0.99m,

0.72m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.98m,

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
                Assert.That(model.Id, Is.EqualTo(1544303855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.03m,

0.23m,

0.21m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1679004264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.02m,

0.45m,

0.39m,

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
                Assert.That(model.Id, Is.EqualTo(1591389282));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.69m,

0.51m,

0.24m,

0.20m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.36m,

0.39m,

0.55m,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2086038716));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.98m,

0.97m,

0.79m,

0.24m,

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


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1609735417));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.56m,

0.42m,

0.33m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.15m,

0.87m,

0.97m,

0.52m,

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
                Assert.That(model.Id, Is.EqualTo(1650133984));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.30m,

0.88m,

0.40m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(924792188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.17m,

0.22m,

0.16m,

0.62m,

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
new System.Collections.Generic.List<System.Decimal>(4)
{
0.58m,

0.76m,

0.26m,

0.87m,

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
                Assert.That(model.Id, Is.EqualTo(1726726308));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.91m,

0.02m,

0.38m,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2016905416));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.30m,

0.96m,

0.04m,

0.80m,

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
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.97m,

0.83m,

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
                Assert.That(model.Id, Is.EqualTo(1833587780));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.62m,

1.00m,

0.08m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.54m,

0.96m,

0.90m,

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
                Assert.That(model.Id, Is.EqualTo(2088200534));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.91m,

0.81m,

0.95m,

0.53m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.79m,

0.92m,

0.66m,

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


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2138732876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.85m,

0.22m,

0.59m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.40m,

0.07m,

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


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalmoneyarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalmoneyarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(DecimalmoneyArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636)
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

                var expected = new Dictionary<System.Int32,DecimalmoneyArray2M>(30);

                expected.Add(
                    7816882,
                    new DecimalmoneyArray2M
                    {
                        Id = 7816882,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.81m,

1.00m,

0.32m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.24m,

0.46m,

0.62m,

0.05m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    89558594,
                    new DecimalmoneyArray2M
                    {
                        Id = 89558594,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.83m,

0.27m,

0.91m,

0.59m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.76m,

1.00m,

0.58m,

0.81m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    197749978,
                    new DecimalmoneyArray2M
                    {
                        Id = 197749978,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.14m,

0.55m,

0.11m,

0.75m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    235819484,
                    new DecimalmoneyArray2M
                    {
                        Id = 235819484,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.83m,

0.80m,

0.67m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.46m,

0.15m,

0.16m,

0.29m,

},

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 1022846180,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.06m,

0.65m,

0.73m,

0.35m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    310591520,
                    new DecimalmoneyArray2M
                    {
                        Id = 310591520,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.54m,

0.01m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.08m,

0.29m,

0.05m,

},

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 1128165166,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.04m,

1.00m,

0.43m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    336737745,
                    new DecimalmoneyArray2M
                    {
                        Id = 336737745,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.03m,

0.01m,

1.00m,

0.35m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    382211456,
                    new DecimalmoneyArray2M
                    {
                        Id = 382211456,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.13m,

0.27m,

0.47m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.58m,

0.37m,

0.18m,

},

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 745381557,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.03m,

0.24m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    387019197,
                    new DecimalmoneyArray2M
                    {
                        Id = 387019197,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.19m,

0.21m,

0.51m,

0.92m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.51m,

0.53m,

0.57m,

0.72m,

},

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 931433918,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00m,

0.07m,

0.73m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    561702663,
                    new DecimalmoneyArray2M
                    {
                        Id = 561702663,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.93m,

0.91m,

0.22m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    585729157,
                    new DecimalmoneyArray2M
                    {
                        Id = 585729157,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.35m,

0.47m,

0.40m,

},
                        NullableValue = null,

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 915733516,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.84m,

0.62m,

0.28m,

0.43m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.57m,

0.23m,

0.50m,

}
                        }

                    }
                );

                expected.Add(
                    603496749,
                    new DecimalmoneyArray2M
                    {
                        Id = 603496749,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.28m,

0.42m,

0.23m,

0.40m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.11m,

0.53m,

0.08m,

0.26m,

},

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 1084161682,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63m,

0.27m,

0.20m,

0.35m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    742387234,
                    new DecimalmoneyArray2M
                    {
                        Id = 742387234,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.78m,

0.43m,

0.08m,

},
                        NullableValue = null,

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 1507914019,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.16m,

0.78m,

0.42m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    785819060,
                    new DecimalmoneyArray2M
                    {
                        Id = 785819060,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.39m,

0.01m,

0.79m,

0.97m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.03m,

0.21m,

0.90m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    948900206,
                    new DecimalmoneyArray2M
                    {
                        Id = 948900206,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.90m,

0.81m,

0.87m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.09m,

0.74m,

0.34m,

},

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 1065938893,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.61m,

0.79m,

0.96m,

0.50m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.68m,

0.71m,

0.62m,

}
                        }

                    }
                );

                expected.Add(
                    986984605,
                    new DecimalmoneyArray2M
                    {
                        Id = 986984605,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.96m,

0.64m,

0.73m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.88m,

0.17m,

0.64m,

0.98m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1027130948,
                    new DecimalmoneyArray2M
                    {
                        Id = 1027130948,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.52m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.55m,

0.54m,

0.47m,

},

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 1940404136,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.32m,

0.30m,

0.13m,

0.01m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.96m,

0.04m,

0.97m,

}
                        }

                    }
                );

                expected.Add(
                    1219533177,
                    new DecimalmoneyArray2M
                    {
                        Id = 1219533177,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.72m,

0.36m,

0.74m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.17m,

0.47m,

0.04m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1255259303,
                    new DecimalmoneyArray2M
                    {
                        Id = 1255259303,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.56m,

0.06m,

0.01m,

0.89m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1331109979,
                    new DecimalmoneyArray2M
                    {
                        Id = 1331109979,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.07m,

0.72m,

0.68m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.44m,

0.87m,

0.22m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1455719771,
                    new DecimalmoneyArray2M
                    {
                        Id = 1455719771,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.05m,

0.66m,

0.49m,

0.18m,

},
                        NullableValue = null,

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 1989887715,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.34m,

0.43m,

0.90m,

0.29m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1469229955,
                    new DecimalmoneyArray2M
                    {
                        Id = 1469229955,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.88m,

0.20m,

0.40m,

},
                        NullableValue = null,

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 1391339514,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.84m,

0.30m,

0.05m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.60m,

0.34m,

0.73m,

0.79m,

}
                        }

                    }
                );

                expected.Add(
                    1522517769,
                    new DecimalmoneyArray2M
                    {
                        Id = 1522517769,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.98m,

0.99m,

0.72m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.98m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1544303855,
                    new DecimalmoneyArray2M
                    {
                        Id = 1544303855,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.03m,

0.23m,

0.21m,

},
                        NullableValue = null,

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 1679004264,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.02m,

0.45m,

0.39m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1591389282,
                    new DecimalmoneyArray2M
                    {
                        Id = 1591389282,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.69m,

0.51m,

0.24m,

0.20m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.36m,

0.39m,

0.55m,

},

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 2086038716,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.98m,

0.97m,

0.79m,

0.24m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1609735417,
                    new DecimalmoneyArray2M
                    {
                        Id = 1609735417,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.56m,

0.42m,

0.33m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.15m,

0.87m,

0.97m,

0.52m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1650133984,
                    new DecimalmoneyArray2M
                    {
                        Id = 1650133984,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.30m,

0.88m,

0.40m,

},
                        NullableValue = null,

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 924792188,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.17m,

0.22m,

0.16m,

0.62m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.58m,

0.76m,

0.26m,

0.87m,

}
                        }

                    }
                );

                expected.Add(
                    1726726308,
                    new DecimalmoneyArray2M
                    {
                        Id = 1726726308,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.91m,

0.02m,

0.38m,

},
                        NullableValue = null,

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 2016905416,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.30m,

0.96m,

0.04m,

0.80m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.97m,

0.83m,

}
                        }

                    }
                );

                expected.Add(
                    1833587780,
                    new DecimalmoneyArray2M
                    {
                        Id = 1833587780,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.62m,

1.00m,

0.08m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.54m,

0.96m,

0.90m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2088200534,
                    new DecimalmoneyArray2M
                    {
                        Id = 2088200534,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.91m,

0.81m,

0.95m,

0.53m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.79m,

0.92m,

0.66m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2138732876,
                    new DecimalmoneyArray2M
                    {
                        Id = 2138732876,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.85m,

0.22m,

0.59m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.40m,

0.07m,

},

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
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

                var expected = new Dictionary<System.Int32,DecimalmoneyArray2M>(30);

                expected.Add(
                    7816882,
                    new DecimalmoneyArray2M
                    {
                        Id = 7816882,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.81m,

1.00m,

0.32m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.24m,

0.46m,

0.62m,

0.05m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    89558594,
                    new DecimalmoneyArray2M
                    {
                        Id = 89558594,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.83m,

0.27m,

0.91m,

0.59m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.76m,

1.00m,

0.58m,

0.81m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    197749978,
                    new DecimalmoneyArray2M
                    {
                        Id = 197749978,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.14m,

0.55m,

0.11m,

0.75m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    235819484,
                    new DecimalmoneyArray2M
                    {
                        Id = 235819484,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.83m,

0.80m,

0.67m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.46m,

0.15m,

0.16m,

0.29m,

},

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 1022846180,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.06m,

0.65m,

0.73m,

0.35m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    310591520,
                    new DecimalmoneyArray2M
                    {
                        Id = 310591520,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.54m,

0.01m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.08m,

0.29m,

0.05m,

},

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 1128165166,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.04m,

1.00m,

0.43m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    336737745,
                    new DecimalmoneyArray2M
                    {
                        Id = 336737745,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.03m,

0.01m,

1.00m,

0.35m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    382211456,
                    new DecimalmoneyArray2M
                    {
                        Id = 382211456,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.13m,

0.27m,

0.47m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.58m,

0.37m,

0.18m,

},

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 745381557,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.03m,

0.24m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    387019197,
                    new DecimalmoneyArray2M
                    {
                        Id = 387019197,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.19m,

0.21m,

0.51m,

0.92m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.51m,

0.53m,

0.57m,

0.72m,

},

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 931433918,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00m,

0.07m,

0.73m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    561702663,
                    new DecimalmoneyArray2M
                    {
                        Id = 561702663,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.93m,

0.91m,

0.22m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    585729157,
                    new DecimalmoneyArray2M
                    {
                        Id = 585729157,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.35m,

0.47m,

0.40m,

},
                        NullableValue = null,

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 915733516,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.84m,

0.62m,

0.28m,

0.43m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.57m,

0.23m,

0.50m,

}
                        }

                    }
                );

                expected.Add(
                    603496749,
                    new DecimalmoneyArray2M
                    {
                        Id = 603496749,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.28m,

0.42m,

0.23m,

0.40m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.11m,

0.53m,

0.08m,

0.26m,

},

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 1084161682,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63m,

0.27m,

0.20m,

0.35m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    742387234,
                    new DecimalmoneyArray2M
                    {
                        Id = 742387234,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.78m,

0.43m,

0.08m,

},
                        NullableValue = null,

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 1507914019,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.16m,

0.78m,

0.42m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    785819060,
                    new DecimalmoneyArray2M
                    {
                        Id = 785819060,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.39m,

0.01m,

0.79m,

0.97m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.03m,

0.21m,

0.90m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    948900206,
                    new DecimalmoneyArray2M
                    {
                        Id = 948900206,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.90m,

0.81m,

0.87m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.09m,

0.74m,

0.34m,

},

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 1065938893,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.61m,

0.79m,

0.96m,

0.50m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.68m,

0.71m,

0.62m,

}
                        }

                    }
                );

                expected.Add(
                    986984605,
                    new DecimalmoneyArray2M
                    {
                        Id = 986984605,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.96m,

0.64m,

0.73m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.88m,

0.17m,

0.64m,

0.98m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1027130948,
                    new DecimalmoneyArray2M
                    {
                        Id = 1027130948,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.52m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.55m,

0.54m,

0.47m,

},

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 1940404136,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.32m,

0.30m,

0.13m,

0.01m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.96m,

0.04m,

0.97m,

}
                        }

                    }
                );

                expected.Add(
                    1219533177,
                    new DecimalmoneyArray2M
                    {
                        Id = 1219533177,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.72m,

0.36m,

0.74m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.17m,

0.47m,

0.04m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1255259303,
                    new DecimalmoneyArray2M
                    {
                        Id = 1255259303,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.56m,

0.06m,

0.01m,

0.89m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1331109979,
                    new DecimalmoneyArray2M
                    {
                        Id = 1331109979,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.07m,

0.72m,

0.68m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.44m,

0.87m,

0.22m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1455719771,
                    new DecimalmoneyArray2M
                    {
                        Id = 1455719771,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.05m,

0.66m,

0.49m,

0.18m,

},
                        NullableValue = null,

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 1989887715,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.34m,

0.43m,

0.90m,

0.29m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1469229955,
                    new DecimalmoneyArray2M
                    {
                        Id = 1469229955,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.88m,

0.20m,

0.40m,

},
                        NullableValue = null,

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 1391339514,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.84m,

0.30m,

0.05m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.60m,

0.34m,

0.73m,

0.79m,

}
                        }

                    }
                );

                expected.Add(
                    1522517769,
                    new DecimalmoneyArray2M
                    {
                        Id = 1522517769,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.98m,

0.99m,

0.72m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.80m,

0.98m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1544303855,
                    new DecimalmoneyArray2M
                    {
                        Id = 1544303855,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.03m,

0.23m,

0.21m,

},
                        NullableValue = null,

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 1679004264,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.02m,

0.45m,

0.39m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1591389282,
                    new DecimalmoneyArray2M
                    {
                        Id = 1591389282,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.69m,

0.51m,

0.24m,

0.20m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.36m,

0.39m,

0.55m,

},

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 2086038716,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.98m,

0.97m,

0.79m,

0.24m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1609735417,
                    new DecimalmoneyArray2M
                    {
                        Id = 1609735417,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.56m,

0.42m,

0.33m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.15m,

0.87m,

0.97m,

0.52m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1650133984,
                    new DecimalmoneyArray2M
                    {
                        Id = 1650133984,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.30m,

0.88m,

0.40m,

},
                        NullableValue = null,

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 924792188,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.17m,

0.22m,

0.16m,

0.62m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.58m,

0.76m,

0.26m,

0.87m,

}
                        }

                    }
                );

                expected.Add(
                    1726726308,
                    new DecimalmoneyArray2M
                    {
                        Id = 1726726308,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.91m,

0.02m,

0.38m,

},
                        NullableValue = null,

                        ModelInner = new DecimalmoneyArray2MI
                        {
                            Id = 2016905416,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.30m,

0.96m,

0.04m,

0.80m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.97m,

0.83m,

}
                        }

                    }
                );

                expected.Add(
                    1833587780,
                    new DecimalmoneyArray2M
                    {
                        Id = 1833587780,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.62m,

1.00m,

0.08m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.54m,

0.96m,

0.90m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2088200534,
                    new DecimalmoneyArray2M
                    {
                        Id = 2088200534,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.91m,

0.81m,

0.95m,

0.53m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.79m,

0.92m,

0.66m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2138732876,
                    new DecimalmoneyArray2M
                    {
                        Id = 2138732876,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.85m,

0.22m,

0.59m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.40m,

0.07m,

},

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalmoneyarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(DecimalmoneyArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636)
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

                var expected = new Dictionary<System.Int32,DecimalmoneyArray2MI>(15);

                expected.Add(
                    745381557,
                    new DecimalmoneyArray2MI
                    {
                        Id = 745381557,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.03m,

0.24m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    915733516,
                    new DecimalmoneyArray2MI
                    {
                        Id = 915733516,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.84m,

0.62m,

0.28m,

0.43m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.57m,

0.23m,

0.50m,

}
                    }
                );

                expected.Add(
                    924792188,
                    new DecimalmoneyArray2MI
                    {
                        Id = 924792188,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.17m,

0.22m,

0.16m,

0.62m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.58m,

0.76m,

0.26m,

0.87m,

}
                    }
                );

                expected.Add(
                    931433918,
                    new DecimalmoneyArray2MI
                    {
                        Id = 931433918,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00m,

0.07m,

0.73m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1022846180,
                    new DecimalmoneyArray2MI
                    {
                        Id = 1022846180,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.06m,

0.65m,

0.73m,

0.35m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1065938893,
                    new DecimalmoneyArray2MI
                    {
                        Id = 1065938893,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.61m,

0.79m,

0.96m,

0.50m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.68m,

0.71m,

0.62m,

}
                    }
                );

                expected.Add(
                    1084161682,
                    new DecimalmoneyArray2MI
                    {
                        Id = 1084161682,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63m,

0.27m,

0.20m,

0.35m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1128165166,
                    new DecimalmoneyArray2MI
                    {
                        Id = 1128165166,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.04m,

1.00m,

0.43m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1391339514,
                    new DecimalmoneyArray2MI
                    {
                        Id = 1391339514,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.84m,

0.30m,

0.05m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.60m,

0.34m,

0.73m,

0.79m,

}
                    }
                );

                expected.Add(
                    1507914019,
                    new DecimalmoneyArray2MI
                    {
                        Id = 1507914019,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.16m,

0.78m,

0.42m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1679004264,
                    new DecimalmoneyArray2MI
                    {
                        Id = 1679004264,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.02m,

0.45m,

0.39m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1940404136,
                    new DecimalmoneyArray2MI
                    {
                        Id = 1940404136,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.32m,

0.30m,

0.13m,

0.01m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.96m,

0.04m,

0.97m,

}
                    }
                );

                expected.Add(
                    1989887715,
                    new DecimalmoneyArray2MI
                    {
                        Id = 1989887715,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.34m,

0.43m,

0.90m,

0.29m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2016905416,
                    new DecimalmoneyArray2MI
                    {
                        Id = 2016905416,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.30m,

0.96m,

0.04m,

0.80m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.97m,

0.83m,

}
                    }
                );

                expected.Add(
                    2086038716,
                    new DecimalmoneyArray2MI
                    {
                        Id = 2086038716,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.98m,

0.97m,

0.79m,

0.24m,

},
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

                var expected = new Dictionary<System.Int32,DecimalmoneyArray2MI>(15);

                expected.Add(
                    745381557,
                    new DecimalmoneyArray2MI
                    {
                        Id = 745381557,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.03m,

0.24m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    915733516,
                    new DecimalmoneyArray2MI
                    {
                        Id = 915733516,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.84m,

0.62m,

0.28m,

0.43m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.57m,

0.23m,

0.50m,

}
                    }
                );

                expected.Add(
                    924792188,
                    new DecimalmoneyArray2MI
                    {
                        Id = 924792188,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.17m,

0.22m,

0.16m,

0.62m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.58m,

0.76m,

0.26m,

0.87m,

}
                    }
                );

                expected.Add(
                    931433918,
                    new DecimalmoneyArray2MI
                    {
                        Id = 931433918,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00m,

0.07m,

0.73m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1022846180,
                    new DecimalmoneyArray2MI
                    {
                        Id = 1022846180,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.06m,

0.65m,

0.73m,

0.35m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1065938893,
                    new DecimalmoneyArray2MI
                    {
                        Id = 1065938893,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.61m,

0.79m,

0.96m,

0.50m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.68m,

0.71m,

0.62m,

}
                    }
                );

                expected.Add(
                    1084161682,
                    new DecimalmoneyArray2MI
                    {
                        Id = 1084161682,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63m,

0.27m,

0.20m,

0.35m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1128165166,
                    new DecimalmoneyArray2MI
                    {
                        Id = 1128165166,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.04m,

1.00m,

0.43m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1391339514,
                    new DecimalmoneyArray2MI
                    {
                        Id = 1391339514,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.84m,

0.30m,

0.05m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.60m,

0.34m,

0.73m,

0.79m,

}
                    }
                );

                expected.Add(
                    1507914019,
                    new DecimalmoneyArray2MI
                    {
                        Id = 1507914019,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.16m,

0.78m,

0.42m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1679004264,
                    new DecimalmoneyArray2MI
                    {
                        Id = 1679004264,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.02m,

0.45m,

0.39m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1940404136,
                    new DecimalmoneyArray2MI
                    {
                        Id = 1940404136,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.32m,

0.30m,

0.13m,

0.01m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.96m,

0.04m,

0.97m,

}
                    }
                );

                expected.Add(
                    1989887715,
                    new DecimalmoneyArray2MI
                    {
                        Id = 1989887715,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.34m,

0.43m,

0.90m,

0.29m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2016905416,
                    new DecimalmoneyArray2MI
                    {
                        Id = 2016905416,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.30m,

0.96m,

0.04m,

0.80m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.97m,

0.83m,

}
                    }
                );

                expected.Add(
                    2086038716,
                    new DecimalmoneyArray2MI
                    {
                        Id = 2086038716,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.98m,

0.97m,

0.79m,

0.24m,

},
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

