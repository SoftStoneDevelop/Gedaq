

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
    internal partial interface ISingleListrealArray
    {
    }
    
    internal partial class SingleListrealArray : ISingleListrealArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray2mi(
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
            asPartInterface: typeof(ISingleListrealArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray2mi(
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
            queryMapType: typeof(SinglerealArray2MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)
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

                changedRows =  ((ISingleListrealArray)this).InsertModelInner(connection, 111298471, 
new System.Collections.Generic.List<System.Single>(4)
{
0.38111442f,

0.6106924f,

0.93169767f,

0.53120035f,

}, 
new System.Collections.Generic.List<System.Single>(4)
{
0.42889374f,

0.5532268f,

0.1215893f,

0.25200367f,

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleListrealArray)this).InsertModelInner(connection, 447547747, 
new System.Collections.Generic.List<System.Single>(4)
{
0.073492706f,

0.3385452f,

0.69278383f,

0.5887041f,

}, 
new System.Collections.Generic.List<System.Single>(3)
{
0.57450825f,

0.9345936f,

0.18916482f,

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

                changedRows = await ((ISingleListrealArray)this).InsertModelInnerAsync(connection, 2111584194, 
new System.Collections.Generic.List<System.Single>(4)
{
0.8460261f,

0.8707348f,

0.7030817f,

0.1949814f,

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleListrealArray)this).InsertModelInnerAsync(connection, 1237535761, 
new System.Collections.Generic.List<System.Single>(4)
{
0.2785294f,

0.80813134f,

0.16247958f,

0.033518553f,

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

                id =  ((ISingleListrealArray)this).InsertModelInnerReturning(connection, 1416160647, 
new System.Collections.Generic.List<System.Single>(4)
{
0.3255512f,

0.46324503f,

0.1704809f,

0.5680968f,

}, null);
                Assert.That(id, Is.EqualTo(1416160647));

                id =  ((ISingleListrealArray)this).InsertModelInnerReturning(connection, 1535451802, 
new System.Collections.Generic.List<System.Single>(3)
{
0.7112784f,

0.19532382f,

0.88194853f,

}, null);
                Assert.That(id, Is.EqualTo(1535451802));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, 1099757223, 
new System.Collections.Generic.List<System.Single>(4)
{
0.34864932f,

0.17358232f,

0.5852427f,

0.58064586f,

}, 
new System.Collections.Generic.List<System.Single>(4)
{
0.13372707f,

0.3272789f,

0.24121404f,

0.066414535f,

});
                Assert.That(id, Is.EqualTo(1099757223));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, 457227579, 
new System.Collections.Generic.List<System.Single>(4)
{
0.48824745f,

0.48929715f,

0.07022989f,

0.8419869f,

}, 
new System.Collections.Generic.List<System.Single>(3)
{
0.9349338f,

0.06328577f,

0.97535866f,

});
                Assert.That(id, Is.EqualTo(457227579));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, 897666942, 
new System.Collections.Generic.List<System.Single>(4)
{
0.6454743f,

0.83850855f,

0.09987861f,

0.07376236f,

}, 
new System.Collections.Generic.List<System.Single>(4)
{
0.3980741f,

0.70582503f,

0.554939f,

0.71819735f,

});
                Assert.That(id, Is.EqualTo(897666942));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, 892924785, 
new System.Collections.Generic.List<System.Single>(4)
{
0.23535758f,

0.096842885f,

0.06502473f,

0.51307464f,

}, 
new System.Collections.Generic.List<System.Single>(4)
{
0.85237044f,

0.15166229f,

0.14157635f,

0.71234673f,

});
                Assert.That(id, Is.EqualTo(892924785));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, 1884962037, 
new System.Collections.Generic.List<System.Single>(4)
{
0.041273832f,

0.38159144f,

0.25620645f,

0.14128286f,

}, 
new System.Collections.Generic.List<System.Single>(3)
{
0.5769852f,

0.38471365f,

0.7057446f,

});
                Assert.That(id, Is.EqualTo(1884962037));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, 1911034059, 
new System.Collections.Generic.List<System.Single>(4)
{
0.8597331f,

0.24778455f,

0.32266682f,

0.70744884f,

}, null);
                Assert.That(id, Is.EqualTo(1911034059));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, 1199815725, 
new System.Collections.Generic.List<System.Single>(3)
{
0.36550808f,

0.08386004f,

0.8007212f,

}, 
new System.Collections.Generic.List<System.Single>(3)
{
0.92161345f,

0.7565545f,

0.3048212f,

});
                Assert.That(id, Is.EqualTo(1199815725));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, 524258797, 
new System.Collections.Generic.List<System.Single>(3)
{
0.29988945f,

0.6199064f,

0.5464893f,

}, null);
                Assert.That(id, Is.EqualTo(524258797));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, 1992904301, 
new System.Collections.Generic.List<System.Single>(3)
{
0.34961557f,

0.72442687f,

0.60927194f,

}, 
new System.Collections.Generic.List<System.Single>(3)
{
0.42420083f,

0.17646015f,

0.77016556f,

});
                Assert.That(id, Is.EqualTo(1992904301));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray2m(
	id,
    value,
    nullablevalue,
    singlerealarray2mi_id
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
            asPartInterface: typeof(ISingleListrealArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "singlerealarray2mi_id", 
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

                changedRows =  ((ISingleListrealArray)this).InsertModel(connection, 1739984435, 
new System.Collections.Generic.List<System.Single>(3)
{
0.36293495f,

0.037785113f,

0.5222511f,

}, 
new System.Collections.Generic.List<System.Single>(4)
{
0.13227493f,

0.46334195f,

0.7904288f,

0.10354817f,

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleListrealArray)this).InsertModel(connection, 1612331389, 
new System.Collections.Generic.List<System.Single>(4)
{
0.8327264f,

0.03741318f,

0.4224574f,

0.35395956f,

}, null, 111298471);
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

                changedRows = await ((ISingleListrealArray)this).InsertModelAsync(connection, 319613742, 
new System.Collections.Generic.List<System.Single>(3)
{
0.2499798f,

0.5984741f,

0.45438927f,

}, 
new System.Collections.Generic.List<System.Single>(3)
{
0.58086795f,

0.74077004f,

0.17943323f,

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleListrealArray)this).InsertModelAsync(connection, 338511897, 
new System.Collections.Generic.List<System.Single>(3)
{
0.580113f,

0.34774208f,

0.58363795f,

}, 
new System.Collections.Generic.List<System.Single>(3)
{
0.09077048f,

0.99306977f,

0.019405484f,

}, 447547747);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray2m(
	id,
    value,
    nullablevalue,
    singlerealarray2mi_id
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
    singlerealarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(SinglerealArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "singlerealarray2mi_id", 
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
                List<SinglerealArray2M> models = null;
                SinglerealArray2M model = null;

                models =  ((ISingleListrealArray)this).InsertModelReturning(connection, 946151915, 
new System.Collections.Generic.List<System.Single>(4)
{
0.18162394f,

0.60754126f,

0.557265f,

0.23506981f,

}, 
new System.Collections.Generic.List<System.Single>(4)
{
0.8720046f,

0.8895388f,

0.021931231f,

0.81662625f,

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(946151915));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.18162394f,

0.60754126f,

0.557265f,

0.23506981f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8720046f,

0.8895388f,

0.021931231f,

0.81662625f,

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

                models =  ((ISingleListrealArray)this).InsertModelReturning(connection, 482328903, 
new System.Collections.Generic.List<System.Single>(3)
{
0.13501501f,

0.38359994f,

0.24878669f,

}, 
new System.Collections.Generic.List<System.Single>(4)
{
0.25752568f,

0.8484242f,

0.9043527f,

0.43262017f,

}, 2111584194).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(482328903));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.13501501f,

0.38359994f,

0.24878669f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.25752568f,

0.8484242f,

0.9043527f,

0.43262017f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2111584194));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Single>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((ISingleListrealArray)this).InsertModelReturning(connection, 1267905682, 
new System.Collections.Generic.List<System.Single>(3)
{
0.38489592f,

0.12003738f,

0.0131393075f,

}, 
new System.Collections.Generic.List<System.Single>(3)
{
0.82284886f,

0.38469076f,

0.6586194f,

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1267905682));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.38489592f,

0.12003738f,

0.0131393075f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.82284886f,

0.38469076f,

0.6586194f,

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

                models =  ((ISingleListrealArray)this).InsertModelReturning(connection, 1947305555, 
new System.Collections.Generic.List<System.Single>(4)
{
0.6148245f,

0.11466569f,

0.10825837f,

0.5397294f,

}, null, 1237535761).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1947305555));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6148245f,

0.11466569f,

0.10825837f,

0.5397294f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237535761));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Single>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SinglerealArray2M> models = null;
                SinglerealArray2M model = null;

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, 1302829598, 
new System.Collections.Generic.List<System.Single>(4)
{
0.61329424f,

0.3588876f,

0.8895365f,

0.43167382f,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1302829598));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.61329424f,

0.3588876f,

0.8895365f,

0.43167382f,

};
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

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, 1022550830, 
new System.Collections.Generic.List<System.Single>(4)
{
0.39012402f,

0.051538765f,

0.2260291f,

0.60340947f,

}, null, 1416160647).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1022550830));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.39012402f,

0.051538765f,

0.2260291f,

0.60340947f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1416160647));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Single>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, 728070178, 
new System.Collections.Generic.List<System.Single>(4)
{
0.8247922f,

0.88657606f,

0.6966409f,

0.9770198f,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(728070178));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8247922f,

0.88657606f,

0.6966409f,

0.9770198f,

};
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

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, 1297723547, 
new System.Collections.Generic.List<System.Single>(3)
{
0.64411795f,

0.3725459f,

0.36497152f,

}, 
new System.Collections.Generic.List<System.Single>(4)
{
0.9986498f,

0.48087245f,

0.83996755f,

0.19072181f,

}, 1535451802).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1297723547));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.64411795f,

0.3725459f,

0.36497152f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9986498f,

0.48087245f,

0.83996755f,

0.19072181f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535451802));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Single>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, 367904832, 
new System.Collections.Generic.List<System.Single>(4)
{
0.022737741f,

0.80530876f,

0.2914037f,

0.5814101f,

}, 
new System.Collections.Generic.List<System.Single>(3)
{
0.30143297f,

0.005677521f,

0.6307739f,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(367904832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.022737741f,

0.80530876f,

0.2914037f,

0.5814101f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.30143297f,

0.005677521f,

0.6307739f,

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

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, 254708475, 
new System.Collections.Generic.List<System.Single>(3)
{
0.7623245f,

0.9526623f,

0.9831995f,

}, null, 1099757223).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(254708475));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7623245f,

0.9526623f,

0.9831995f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1099757223));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Single>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, 1108205342, 
new System.Collections.Generic.List<System.Single>(3)
{
0.61472887f,

0.69732517f,

0.7131724f,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1108205342));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.61472887f,

0.69732517f,

0.7131724f,

};
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

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, 708017876, 
new System.Collections.Generic.List<System.Single>(4)
{
0.98777235f,

0.58989346f,

0.85800344f,

0.31756616f,

}, 
new System.Collections.Generic.List<System.Single>(3)
{
0.74288446f,

0.02487886f,

0.74775344f,

}, 457227579).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(708017876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.98777235f,

0.58989346f,

0.85800344f,

0.31756616f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.74288446f,

0.02487886f,

0.74775344f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(457227579));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Single>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, 1277159121, 
new System.Collections.Generic.List<System.Single>(3)
{
0.44573873f,

0.47218084f,

0.084845126f,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1277159121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.44573873f,

0.47218084f,

0.084845126f,

};
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

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, 1901722200, 
new System.Collections.Generic.List<System.Single>(3)
{
0.3572935f,

0.3397079f,

0.04365146f,

}, null, 897666942).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1901722200));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3572935f,

0.3397079f,

0.04365146f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(897666942));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Single>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, 731677834, 
new System.Collections.Generic.List<System.Single>(4)
{
0.44820166f,

0.88920003f,

0.7994896f,

0.32221502f,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(731677834));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.44820166f,

0.88920003f,

0.7994896f,

0.32221502f,

};
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

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, 931000760, 
new System.Collections.Generic.List<System.Single>(4)
{
0.063482046f,

0.32961464f,

0.78257674f,

0.039261937f,

}, null, 892924785).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(931000760));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.063482046f,

0.32961464f,

0.78257674f,

0.039261937f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(892924785));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Single>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, 1153746550, 
new System.Collections.Generic.List<System.Single>(3)
{
0.781832f,

0.064444065f,

0.5294294f,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1153746550));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.781832f,

0.064444065f,

0.5294294f,

};
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

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, 1970672014, 
new System.Collections.Generic.List<System.Single>(3)
{
0.50416803f,

0.8516648f,

0.7370032f,

}, null, 1884962037).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1970672014));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.50416803f,

0.8516648f,

0.7370032f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1884962037));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Single>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, 1331153488, 
new System.Collections.Generic.List<System.Single>(3)
{
0.32075596f,

0.43473178f,

0.14547062f,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331153488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.32075596f,

0.43473178f,

0.14547062f,

};
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

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, 155507141, 
new System.Collections.Generic.List<System.Single>(3)
{
0.72002023f,

0.63042796f,

0.3198427f,

}, 
new System.Collections.Generic.List<System.Single>(3)
{
0.25912172f,

0.32571447f,

0.7634573f,

}, 1911034059).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(155507141));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.72002023f,

0.63042796f,

0.3198427f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.25912172f,

0.32571447f,

0.7634573f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1911034059));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Single>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, 217584221, 
new System.Collections.Generic.List<System.Single>(3)
{
0.19788754f,

0.72246325f,

0.14171016f,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(217584221));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.19788754f,

0.72246325f,

0.14171016f,

};
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

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, 484543978, 
new System.Collections.Generic.List<System.Single>(4)
{
0.77682537f,

0.05695921f,

0.86242616f,

0.52128756f,

}, 
new System.Collections.Generic.List<System.Single>(3)
{
0.39140993f,

0.9502086f,

0.2817353f,

}, 1199815725).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(484543978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.77682537f,

0.05695921f,

0.86242616f,

0.52128756f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.39140993f,

0.9502086f,

0.2817353f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1199815725));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Single>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, 940368705, 
new System.Collections.Generic.List<System.Single>(3)
{
0.114940405f,

0.43694514f,

0.478549f,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(940368705));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.114940405f,

0.43694514f,

0.478549f,

};
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

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, 953271073, 
new System.Collections.Generic.List<System.Single>(4)
{
0.42926848f,

0.96555096f,

0.6000328f,

0.975191f,

}, 
new System.Collections.Generic.List<System.Single>(3)
{
0.8051075f,

0.32967263f,

0.11289692f,

}, 524258797).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(953271073));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42926848f,

0.96555096f,

0.6000328f,

0.975191f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8051075f,

0.32967263f,

0.11289692f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(524258797));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Single>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, 160986735, 
new System.Collections.Generic.List<System.Single>(3)
{
0.5188442f,

0.2851737f,

0.47475958f,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(160986735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5188442f,

0.2851737f,

0.47475958f,

};
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

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, 901819125, 
new System.Collections.Generic.List<System.Single>(4)
{
0.5026249f,

0.07041502f,

0.46547616f,

0.2344206f,

}, 
new System.Collections.Generic.List<System.Single>(4)
{
0.80139554f,

0.3304575f,

0.41971147f,

0.8870805f,

}, 1992904301).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(901819125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5026249f,

0.07041502f,

0.46547616f,

0.2344206f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.80139554f,

0.3304575f,

0.41971147f,

0.8870805f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1992904301));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Single>)default));
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
FROM public.singlerealarray2m m
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(SinglerealArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)
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
                var models =  ((ISingleListrealArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(155507141));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.72002023f,

0.63042796f,

0.3198427f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.25912172f,

0.32571447f,

0.7634573f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1911034059));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8597331f,

0.24778455f,

0.32266682f,

0.70744884f,

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
                Assert.That(model.Id, Is.EqualTo(160986735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5188442f,

0.2851737f,

0.47475958f,

};
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
                Assert.That(model.Id, Is.EqualTo(217584221));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.19788754f,

0.72246325f,

0.14171016f,

};
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
                Assert.That(model.Id, Is.EqualTo(254708475));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7623245f,

0.9526623f,

0.9831995f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1099757223));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.34864932f,

0.17358232f,

0.5852427f,

0.58064586f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.13372707f,

0.3272789f,

0.24121404f,

0.066414535f,

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
                Assert.That(model.Id, Is.EqualTo(319613742));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.2499798f,

0.5984741f,

0.45438927f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.58086795f,

0.74077004f,

0.17943323f,

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
                Assert.That(model.Id, Is.EqualTo(338511897));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.580113f,

0.34774208f,

0.58363795f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.09077048f,

0.99306977f,

0.019405484f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(447547747));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.073492706f,

0.3385452f,

0.69278383f,

0.5887041f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.57450825f,

0.9345936f,

0.18916482f,

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
                Assert.That(model.Id, Is.EqualTo(367904832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.022737741f,

0.80530876f,

0.2914037f,

0.5814101f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.30143297f,

0.005677521f,

0.6307739f,

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
                Assert.That(model.Id, Is.EqualTo(482328903));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.13501501f,

0.38359994f,

0.24878669f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.25752568f,

0.8484242f,

0.9043527f,

0.43262017f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2111584194));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8460261f,

0.8707348f,

0.7030817f,

0.1949814f,

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
                Assert.That(model.Id, Is.EqualTo(484543978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.77682537f,

0.05695921f,

0.86242616f,

0.52128756f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.39140993f,

0.9502086f,

0.2817353f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1199815725));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36550808f,

0.08386004f,

0.8007212f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.92161345f,

0.7565545f,

0.3048212f,

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
                Assert.That(model.Id, Is.EqualTo(708017876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.98777235f,

0.58989346f,

0.85800344f,

0.31756616f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.74288446f,

0.02487886f,

0.74775344f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(457227579));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.48824745f,

0.48929715f,

0.07022989f,

0.8419869f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.9349338f,

0.06328577f,

0.97535866f,

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
                Assert.That(model.Id, Is.EqualTo(728070178));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8247922f,

0.88657606f,

0.6966409f,

0.9770198f,

};
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
                Assert.That(model.Id, Is.EqualTo(731677834));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.44820166f,

0.88920003f,

0.7994896f,

0.32221502f,

};
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
                Assert.That(model.Id, Is.EqualTo(901819125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5026249f,

0.07041502f,

0.46547616f,

0.2344206f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.80139554f,

0.3304575f,

0.41971147f,

0.8870805f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1992904301));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.34961557f,

0.72442687f,

0.60927194f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.42420083f,

0.17646015f,

0.77016556f,

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
                Assert.That(model.Id, Is.EqualTo(931000760));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.063482046f,

0.32961464f,

0.78257674f,

0.039261937f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(892924785));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.23535758f,

0.096842885f,

0.06502473f,

0.51307464f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.85237044f,

0.15166229f,

0.14157635f,

0.71234673f,

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
                Assert.That(model.Id, Is.EqualTo(940368705));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.114940405f,

0.43694514f,

0.478549f,

};
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
                Assert.That(model.Id, Is.EqualTo(946151915));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.18162394f,

0.60754126f,

0.557265f,

0.23506981f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8720046f,

0.8895388f,

0.021931231f,

0.81662625f,

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
                Assert.That(model.Id, Is.EqualTo(953271073));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42926848f,

0.96555096f,

0.6000328f,

0.975191f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8051075f,

0.32967263f,

0.11289692f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(524258797));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.29988945f,

0.6199064f,

0.5464893f,

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
                Assert.That(model.Id, Is.EqualTo(1022550830));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.39012402f,

0.051538765f,

0.2260291f,

0.60340947f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1416160647));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3255512f,

0.46324503f,

0.1704809f,

0.5680968f,

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
                Assert.That(model.Id, Is.EqualTo(1108205342));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.61472887f,

0.69732517f,

0.7131724f,

};
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
                Assert.That(model.Id, Is.EqualTo(1153746550));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.781832f,

0.064444065f,

0.5294294f,

};
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

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1267905682));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.38489592f,

0.12003738f,

0.0131393075f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.82284886f,

0.38469076f,

0.6586194f,

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
                Assert.That(model.Id, Is.EqualTo(1277159121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.44573873f,

0.47218084f,

0.084845126f,

};
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
                Assert.That(model.Id, Is.EqualTo(1297723547));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.64411795f,

0.3725459f,

0.36497152f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9986498f,

0.48087245f,

0.83996755f,

0.19072181f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535451802));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7112784f,

0.19532382f,

0.88194853f,

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
                Assert.That(model.Id, Is.EqualTo(1302829598));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.61329424f,

0.3588876f,

0.8895365f,

0.43167382f,

};
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
                Assert.That(model.Id, Is.EqualTo(1331153488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.32075596f,

0.43473178f,

0.14547062f,

};
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

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1612331389));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8327264f,

0.03741318f,

0.4224574f,

0.35395956f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(111298471));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.38111442f,

0.6106924f,

0.93169767f,

0.53120035f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.42889374f,

0.5532268f,

0.1215893f,

0.25200367f,

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
                Assert.That(model.Id, Is.EqualTo(1739984435));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36293495f,

0.037785113f,

0.5222511f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13227493f,

0.46334195f,

0.7904288f,

0.10354817f,

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
                Assert.That(model.Id, Is.EqualTo(1901722200));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3572935f,

0.3397079f,

0.04365146f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(897666942));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6454743f,

0.83850855f,

0.09987861f,

0.07376236f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.3980741f,

0.70582503f,

0.554939f,

0.71819735f,

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
                Assert.That(model.Id, Is.EqualTo(1947305555));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6148245f,

0.11466569f,

0.10825837f,

0.5397294f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237535761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2785294f,

0.80813134f,

0.16247958f,

0.033518553f,

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
                Assert.That(model.Id, Is.EqualTo(1970672014));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.50416803f,

0.8516648f,

0.7370032f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1884962037));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.041273832f,

0.38159144f,

0.25620645f,

0.14128286f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.5769852f,

0.38471365f,

0.7057446f,

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
                var models = await ((ISingleListrealArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(155507141));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.72002023f,

0.63042796f,

0.3198427f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.25912172f,

0.32571447f,

0.7634573f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1911034059));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8597331f,

0.24778455f,

0.32266682f,

0.70744884f,

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
                Assert.That(model.Id, Is.EqualTo(160986735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5188442f,

0.2851737f,

0.47475958f,

};
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
                Assert.That(model.Id, Is.EqualTo(217584221));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.19788754f,

0.72246325f,

0.14171016f,

};
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
                Assert.That(model.Id, Is.EqualTo(254708475));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7623245f,

0.9526623f,

0.9831995f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1099757223));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.34864932f,

0.17358232f,

0.5852427f,

0.58064586f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.13372707f,

0.3272789f,

0.24121404f,

0.066414535f,

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
                Assert.That(model.Id, Is.EqualTo(319613742));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.2499798f,

0.5984741f,

0.45438927f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.58086795f,

0.74077004f,

0.17943323f,

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
                Assert.That(model.Id, Is.EqualTo(338511897));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.580113f,

0.34774208f,

0.58363795f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.09077048f,

0.99306977f,

0.019405484f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(447547747));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.073492706f,

0.3385452f,

0.69278383f,

0.5887041f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.57450825f,

0.9345936f,

0.18916482f,

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
                Assert.That(model.Id, Is.EqualTo(367904832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.022737741f,

0.80530876f,

0.2914037f,

0.5814101f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.30143297f,

0.005677521f,

0.6307739f,

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
                Assert.That(model.Id, Is.EqualTo(482328903));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.13501501f,

0.38359994f,

0.24878669f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.25752568f,

0.8484242f,

0.9043527f,

0.43262017f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2111584194));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8460261f,

0.8707348f,

0.7030817f,

0.1949814f,

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
                Assert.That(model.Id, Is.EqualTo(484543978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.77682537f,

0.05695921f,

0.86242616f,

0.52128756f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.39140993f,

0.9502086f,

0.2817353f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1199815725));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36550808f,

0.08386004f,

0.8007212f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.92161345f,

0.7565545f,

0.3048212f,

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
                Assert.That(model.Id, Is.EqualTo(708017876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.98777235f,

0.58989346f,

0.85800344f,

0.31756616f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.74288446f,

0.02487886f,

0.74775344f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(457227579));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.48824745f,

0.48929715f,

0.07022989f,

0.8419869f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.9349338f,

0.06328577f,

0.97535866f,

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
                Assert.That(model.Id, Is.EqualTo(728070178));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8247922f,

0.88657606f,

0.6966409f,

0.9770198f,

};
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
                Assert.That(model.Id, Is.EqualTo(731677834));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.44820166f,

0.88920003f,

0.7994896f,

0.32221502f,

};
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
                Assert.That(model.Id, Is.EqualTo(901819125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5026249f,

0.07041502f,

0.46547616f,

0.2344206f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.80139554f,

0.3304575f,

0.41971147f,

0.8870805f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1992904301));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.34961557f,

0.72442687f,

0.60927194f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.42420083f,

0.17646015f,

0.77016556f,

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
                Assert.That(model.Id, Is.EqualTo(931000760));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.063482046f,

0.32961464f,

0.78257674f,

0.039261937f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(892924785));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.23535758f,

0.096842885f,

0.06502473f,

0.51307464f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.85237044f,

0.15166229f,

0.14157635f,

0.71234673f,

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
                Assert.That(model.Id, Is.EqualTo(940368705));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.114940405f,

0.43694514f,

0.478549f,

};
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
                Assert.That(model.Id, Is.EqualTo(946151915));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.18162394f,

0.60754126f,

0.557265f,

0.23506981f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8720046f,

0.8895388f,

0.021931231f,

0.81662625f,

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
                Assert.That(model.Id, Is.EqualTo(953271073));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42926848f,

0.96555096f,

0.6000328f,

0.975191f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8051075f,

0.32967263f,

0.11289692f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(524258797));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.29988945f,

0.6199064f,

0.5464893f,

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
                Assert.That(model.Id, Is.EqualTo(1022550830));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.39012402f,

0.051538765f,

0.2260291f,

0.60340947f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1416160647));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3255512f,

0.46324503f,

0.1704809f,

0.5680968f,

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
                Assert.That(model.Id, Is.EqualTo(1108205342));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.61472887f,

0.69732517f,

0.7131724f,

};
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
                Assert.That(model.Id, Is.EqualTo(1153746550));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.781832f,

0.064444065f,

0.5294294f,

};
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

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1267905682));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.38489592f,

0.12003738f,

0.0131393075f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.82284886f,

0.38469076f,

0.6586194f,

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
                Assert.That(model.Id, Is.EqualTo(1277159121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.44573873f,

0.47218084f,

0.084845126f,

};
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
                Assert.That(model.Id, Is.EqualTo(1297723547));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.64411795f,

0.3725459f,

0.36497152f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9986498f,

0.48087245f,

0.83996755f,

0.19072181f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535451802));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7112784f,

0.19532382f,

0.88194853f,

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
                Assert.That(model.Id, Is.EqualTo(1302829598));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.61329424f,

0.3588876f,

0.8895365f,

0.43167382f,

};
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
                Assert.That(model.Id, Is.EqualTo(1331153488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.32075596f,

0.43473178f,

0.14547062f,

};
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

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1612331389));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8327264f,

0.03741318f,

0.4224574f,

0.35395956f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(111298471));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.38111442f,

0.6106924f,

0.93169767f,

0.53120035f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.42889374f,

0.5532268f,

0.1215893f,

0.25200367f,

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
                Assert.That(model.Id, Is.EqualTo(1739984435));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36293495f,

0.037785113f,

0.5222511f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13227493f,

0.46334195f,

0.7904288f,

0.10354817f,

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
                Assert.That(model.Id, Is.EqualTo(1901722200));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3572935f,

0.3397079f,

0.04365146f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(897666942));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6454743f,

0.83850855f,

0.09987861f,

0.07376236f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.3980741f,

0.70582503f,

0.554939f,

0.71819735f,

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
                Assert.That(model.Id, Is.EqualTo(1947305555));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6148245f,

0.11466569f,

0.10825837f,

0.5397294f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237535761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2785294f,

0.80813134f,

0.16247958f,

0.033518553f,

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
                Assert.That(model.Id, Is.EqualTo(1970672014));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.50416803f,

0.8516648f,

0.7370032f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1884962037));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.041273832f,

0.38159144f,

0.25620645f,

0.14128286f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.5769852f,

0.38471365f,

0.7057446f,

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
FROM public.singlerealarray2m m
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(SinglerealArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)
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
                var models =  ((ISingleListrealArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(155507141));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.72002023f,

0.63042796f,

0.3198427f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.25912172f,

0.32571447f,

0.7634573f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1911034059));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8597331f,

0.24778455f,

0.32266682f,

0.70744884f,

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
                Assert.That(model.Id, Is.EqualTo(160986735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5188442f,

0.2851737f,

0.47475958f,

};
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
                Assert.That(model.Id, Is.EqualTo(217584221));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.19788754f,

0.72246325f,

0.14171016f,

};
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
                Assert.That(model.Id, Is.EqualTo(254708475));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7623245f,

0.9526623f,

0.9831995f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1099757223));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.34864932f,

0.17358232f,

0.5852427f,

0.58064586f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.13372707f,

0.3272789f,

0.24121404f,

0.066414535f,

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
                Assert.That(model.Id, Is.EqualTo(319613742));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.2499798f,

0.5984741f,

0.45438927f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.58086795f,

0.74077004f,

0.17943323f,

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
                Assert.That(model.Id, Is.EqualTo(338511897));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.580113f,

0.34774208f,

0.58363795f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.09077048f,

0.99306977f,

0.019405484f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(447547747));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.073492706f,

0.3385452f,

0.69278383f,

0.5887041f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.57450825f,

0.9345936f,

0.18916482f,

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
                Assert.That(model.Id, Is.EqualTo(367904832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.022737741f,

0.80530876f,

0.2914037f,

0.5814101f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.30143297f,

0.005677521f,

0.6307739f,

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
                Assert.That(model.Id, Is.EqualTo(482328903));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.13501501f,

0.38359994f,

0.24878669f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.25752568f,

0.8484242f,

0.9043527f,

0.43262017f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2111584194));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8460261f,

0.8707348f,

0.7030817f,

0.1949814f,

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
                Assert.That(model.Id, Is.EqualTo(484543978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.77682537f,

0.05695921f,

0.86242616f,

0.52128756f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.39140993f,

0.9502086f,

0.2817353f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1199815725));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36550808f,

0.08386004f,

0.8007212f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.92161345f,

0.7565545f,

0.3048212f,

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
                Assert.That(model.Id, Is.EqualTo(708017876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.98777235f,

0.58989346f,

0.85800344f,

0.31756616f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.74288446f,

0.02487886f,

0.74775344f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(457227579));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.48824745f,

0.48929715f,

0.07022989f,

0.8419869f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.9349338f,

0.06328577f,

0.97535866f,

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
                Assert.That(model.Id, Is.EqualTo(728070178));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8247922f,

0.88657606f,

0.6966409f,

0.9770198f,

};
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
                Assert.That(model.Id, Is.EqualTo(731677834));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.44820166f,

0.88920003f,

0.7994896f,

0.32221502f,

};
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
                Assert.That(model.Id, Is.EqualTo(901819125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5026249f,

0.07041502f,

0.46547616f,

0.2344206f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.80139554f,

0.3304575f,

0.41971147f,

0.8870805f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1992904301));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.34961557f,

0.72442687f,

0.60927194f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.42420083f,

0.17646015f,

0.77016556f,

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
                Assert.That(model.Id, Is.EqualTo(931000760));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.063482046f,

0.32961464f,

0.78257674f,

0.039261937f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(892924785));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.23535758f,

0.096842885f,

0.06502473f,

0.51307464f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.85237044f,

0.15166229f,

0.14157635f,

0.71234673f,

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
                Assert.That(model.Id, Is.EqualTo(940368705));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.114940405f,

0.43694514f,

0.478549f,

};
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
                Assert.That(model.Id, Is.EqualTo(946151915));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.18162394f,

0.60754126f,

0.557265f,

0.23506981f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8720046f,

0.8895388f,

0.021931231f,

0.81662625f,

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
                Assert.That(model.Id, Is.EqualTo(953271073));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42926848f,

0.96555096f,

0.6000328f,

0.975191f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8051075f,

0.32967263f,

0.11289692f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(524258797));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.29988945f,

0.6199064f,

0.5464893f,

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
                Assert.That(model.Id, Is.EqualTo(1022550830));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.39012402f,

0.051538765f,

0.2260291f,

0.60340947f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1416160647));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3255512f,

0.46324503f,

0.1704809f,

0.5680968f,

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
                Assert.That(model.Id, Is.EqualTo(1108205342));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.61472887f,

0.69732517f,

0.7131724f,

};
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
                Assert.That(model.Id, Is.EqualTo(1153746550));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.781832f,

0.064444065f,

0.5294294f,

};
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

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1267905682));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.38489592f,

0.12003738f,

0.0131393075f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.82284886f,

0.38469076f,

0.6586194f,

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
                Assert.That(model.Id, Is.EqualTo(1277159121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.44573873f,

0.47218084f,

0.084845126f,

};
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
                Assert.That(model.Id, Is.EqualTo(1297723547));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.64411795f,

0.3725459f,

0.36497152f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9986498f,

0.48087245f,

0.83996755f,

0.19072181f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535451802));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7112784f,

0.19532382f,

0.88194853f,

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
                Assert.That(model.Id, Is.EqualTo(1302829598));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.61329424f,

0.3588876f,

0.8895365f,

0.43167382f,

};
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
                Assert.That(model.Id, Is.EqualTo(1331153488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.32075596f,

0.43473178f,

0.14547062f,

};
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

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1612331389));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8327264f,

0.03741318f,

0.4224574f,

0.35395956f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(111298471));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.38111442f,

0.6106924f,

0.93169767f,

0.53120035f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.42889374f,

0.5532268f,

0.1215893f,

0.25200367f,

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
                Assert.That(model.Id, Is.EqualTo(1739984435));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36293495f,

0.037785113f,

0.5222511f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13227493f,

0.46334195f,

0.7904288f,

0.10354817f,

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
                Assert.That(model.Id, Is.EqualTo(1901722200));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3572935f,

0.3397079f,

0.04365146f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(897666942));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6454743f,

0.83850855f,

0.09987861f,

0.07376236f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.3980741f,

0.70582503f,

0.554939f,

0.71819735f,

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
                Assert.That(model.Id, Is.EqualTo(1947305555));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6148245f,

0.11466569f,

0.10825837f,

0.5397294f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237535761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2785294f,

0.80813134f,

0.16247958f,

0.033518553f,

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
                Assert.That(model.Id, Is.EqualTo(1970672014));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.50416803f,

0.8516648f,

0.7370032f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1884962037));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.041273832f,

0.38159144f,

0.25620645f,

0.14128286f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.5769852f,

0.38471365f,

0.7057446f,

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
                var models = await ((ISingleListrealArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(155507141));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.72002023f,

0.63042796f,

0.3198427f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.25912172f,

0.32571447f,

0.7634573f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1911034059));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8597331f,

0.24778455f,

0.32266682f,

0.70744884f,

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
                Assert.That(model.Id, Is.EqualTo(160986735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5188442f,

0.2851737f,

0.47475958f,

};
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
                Assert.That(model.Id, Is.EqualTo(217584221));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.19788754f,

0.72246325f,

0.14171016f,

};
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
                Assert.That(model.Id, Is.EqualTo(254708475));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7623245f,

0.9526623f,

0.9831995f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1099757223));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.34864932f,

0.17358232f,

0.5852427f,

0.58064586f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.13372707f,

0.3272789f,

0.24121404f,

0.066414535f,

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
                Assert.That(model.Id, Is.EqualTo(319613742));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.2499798f,

0.5984741f,

0.45438927f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.58086795f,

0.74077004f,

0.17943323f,

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
                Assert.That(model.Id, Is.EqualTo(338511897));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.580113f,

0.34774208f,

0.58363795f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.09077048f,

0.99306977f,

0.019405484f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(447547747));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.073492706f,

0.3385452f,

0.69278383f,

0.5887041f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.57450825f,

0.9345936f,

0.18916482f,

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
                Assert.That(model.Id, Is.EqualTo(367904832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.022737741f,

0.80530876f,

0.2914037f,

0.5814101f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.30143297f,

0.005677521f,

0.6307739f,

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
                Assert.That(model.Id, Is.EqualTo(482328903));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.13501501f,

0.38359994f,

0.24878669f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.25752568f,

0.8484242f,

0.9043527f,

0.43262017f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2111584194));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8460261f,

0.8707348f,

0.7030817f,

0.1949814f,

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
                Assert.That(model.Id, Is.EqualTo(484543978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.77682537f,

0.05695921f,

0.86242616f,

0.52128756f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.39140993f,

0.9502086f,

0.2817353f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1199815725));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36550808f,

0.08386004f,

0.8007212f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.92161345f,

0.7565545f,

0.3048212f,

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
                Assert.That(model.Id, Is.EqualTo(708017876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.98777235f,

0.58989346f,

0.85800344f,

0.31756616f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.74288446f,

0.02487886f,

0.74775344f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(457227579));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.48824745f,

0.48929715f,

0.07022989f,

0.8419869f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.9349338f,

0.06328577f,

0.97535866f,

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
                Assert.That(model.Id, Is.EqualTo(728070178));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8247922f,

0.88657606f,

0.6966409f,

0.9770198f,

};
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
                Assert.That(model.Id, Is.EqualTo(731677834));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.44820166f,

0.88920003f,

0.7994896f,

0.32221502f,

};
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
                Assert.That(model.Id, Is.EqualTo(901819125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5026249f,

0.07041502f,

0.46547616f,

0.2344206f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.80139554f,

0.3304575f,

0.41971147f,

0.8870805f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1992904301));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.34961557f,

0.72442687f,

0.60927194f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.42420083f,

0.17646015f,

0.77016556f,

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
                Assert.That(model.Id, Is.EqualTo(931000760));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.063482046f,

0.32961464f,

0.78257674f,

0.039261937f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(892924785));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.23535758f,

0.096842885f,

0.06502473f,

0.51307464f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.85237044f,

0.15166229f,

0.14157635f,

0.71234673f,

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
                Assert.That(model.Id, Is.EqualTo(940368705));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.114940405f,

0.43694514f,

0.478549f,

};
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
                Assert.That(model.Id, Is.EqualTo(946151915));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.18162394f,

0.60754126f,

0.557265f,

0.23506981f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8720046f,

0.8895388f,

0.021931231f,

0.81662625f,

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
                Assert.That(model.Id, Is.EqualTo(953271073));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42926848f,

0.96555096f,

0.6000328f,

0.975191f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8051075f,

0.32967263f,

0.11289692f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(524258797));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.29988945f,

0.6199064f,

0.5464893f,

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
                Assert.That(model.Id, Is.EqualTo(1022550830));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.39012402f,

0.051538765f,

0.2260291f,

0.60340947f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1416160647));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3255512f,

0.46324503f,

0.1704809f,

0.5680968f,

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
                Assert.That(model.Id, Is.EqualTo(1108205342));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.61472887f,

0.69732517f,

0.7131724f,

};
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
                Assert.That(model.Id, Is.EqualTo(1153746550));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.781832f,

0.064444065f,

0.5294294f,

};
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

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1267905682));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.38489592f,

0.12003738f,

0.0131393075f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.82284886f,

0.38469076f,

0.6586194f,

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
                Assert.That(model.Id, Is.EqualTo(1277159121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.44573873f,

0.47218084f,

0.084845126f,

};
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
                Assert.That(model.Id, Is.EqualTo(1297723547));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.64411795f,

0.3725459f,

0.36497152f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9986498f,

0.48087245f,

0.83996755f,

0.19072181f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535451802));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7112784f,

0.19532382f,

0.88194853f,

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
                Assert.That(model.Id, Is.EqualTo(1302829598));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.61329424f,

0.3588876f,

0.8895365f,

0.43167382f,

};
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
                Assert.That(model.Id, Is.EqualTo(1331153488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.32075596f,

0.43473178f,

0.14547062f,

};
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

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1612331389));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8327264f,

0.03741318f,

0.4224574f,

0.35395956f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(111298471));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.38111442f,

0.6106924f,

0.93169767f,

0.53120035f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.42889374f,

0.5532268f,

0.1215893f,

0.25200367f,

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
                Assert.That(model.Id, Is.EqualTo(1739984435));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36293495f,

0.037785113f,

0.5222511f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13227493f,

0.46334195f,

0.7904288f,

0.10354817f,

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
                Assert.That(model.Id, Is.EqualTo(1901722200));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3572935f,

0.3397079f,

0.04365146f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(897666942));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6454743f,

0.83850855f,

0.09987861f,

0.07376236f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.3980741f,

0.70582503f,

0.554939f,

0.71819735f,

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
                Assert.That(model.Id, Is.EqualTo(1947305555));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6148245f,

0.11466569f,

0.10825837f,

0.5397294f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237535761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2785294f,

0.80813134f,

0.16247958f,

0.033518553f,

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
                Assert.That(model.Id, Is.EqualTo(1970672014));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.50416803f,

0.8516648f,

0.7370032f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1884962037));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.041273832f,

0.38159144f,

0.25620645f,

0.14128286f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.5769852f,

0.38471365f,

0.7057446f,

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
                 using var cmd =  ((ISingleListrealArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleListrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 484543978);
                var models =  ((ISingleListrealArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(21));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(708017876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.98777235f,

0.58989346f,

0.85800344f,

0.31756616f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.74288446f,

0.02487886f,

0.74775344f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(457227579));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.48824745f,

0.48929715f,

0.07022989f,

0.8419869f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.9349338f,

0.06328577f,

0.97535866f,

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
                Assert.That(model.Id, Is.EqualTo(728070178));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8247922f,

0.88657606f,

0.6966409f,

0.9770198f,

};
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
                Assert.That(model.Id, Is.EqualTo(731677834));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.44820166f,

0.88920003f,

0.7994896f,

0.32221502f,

};
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
                Assert.That(model.Id, Is.EqualTo(901819125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5026249f,

0.07041502f,

0.46547616f,

0.2344206f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.80139554f,

0.3304575f,

0.41971147f,

0.8870805f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1992904301));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.34961557f,

0.72442687f,

0.60927194f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.42420083f,

0.17646015f,

0.77016556f,

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
                Assert.That(model.Id, Is.EqualTo(931000760));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.063482046f,

0.32961464f,

0.78257674f,

0.039261937f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(892924785));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.23535758f,

0.096842885f,

0.06502473f,

0.51307464f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.85237044f,

0.15166229f,

0.14157635f,

0.71234673f,

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(940368705));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.114940405f,

0.43694514f,

0.478549f,

};
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
                Assert.That(model.Id, Is.EqualTo(946151915));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.18162394f,

0.60754126f,

0.557265f,

0.23506981f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8720046f,

0.8895388f,

0.021931231f,

0.81662625f,

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
                Assert.That(model.Id, Is.EqualTo(953271073));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42926848f,

0.96555096f,

0.6000328f,

0.975191f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8051075f,

0.32967263f,

0.11289692f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(524258797));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.29988945f,

0.6199064f,

0.5464893f,

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
                Assert.That(model.Id, Is.EqualTo(1022550830));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.39012402f,

0.051538765f,

0.2260291f,

0.60340947f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1416160647));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3255512f,

0.46324503f,

0.1704809f,

0.5680968f,

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
                Assert.That(model.Id, Is.EqualTo(1108205342));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.61472887f,

0.69732517f,

0.7131724f,

};
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
                Assert.That(model.Id, Is.EqualTo(1153746550));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.781832f,

0.064444065f,

0.5294294f,

};
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
                Assert.That(model.Id, Is.EqualTo(1267905682));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.38489592f,

0.12003738f,

0.0131393075f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.82284886f,

0.38469076f,

0.6586194f,

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
                Assert.That(model.Id, Is.EqualTo(1277159121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.44573873f,

0.47218084f,

0.084845126f,

};
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
                Assert.That(model.Id, Is.EqualTo(1297723547));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.64411795f,

0.3725459f,

0.36497152f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9986498f,

0.48087245f,

0.83996755f,

0.19072181f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535451802));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7112784f,

0.19532382f,

0.88194853f,

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
                Assert.That(model.Id, Is.EqualTo(1302829598));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.61329424f,

0.3588876f,

0.8895365f,

0.43167382f,

};
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
                Assert.That(model.Id, Is.EqualTo(1331153488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.32075596f,

0.43473178f,

0.14547062f,

};
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
                Assert.That(model.Id, Is.EqualTo(1612331389));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8327264f,

0.03741318f,

0.4224574f,

0.35395956f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(111298471));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.38111442f,

0.6106924f,

0.93169767f,

0.53120035f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.42889374f,

0.5532268f,

0.1215893f,

0.25200367f,

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
                Assert.That(model.Id, Is.EqualTo(1739984435));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36293495f,

0.037785113f,

0.5222511f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13227493f,

0.46334195f,

0.7904288f,

0.10354817f,

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
                Assert.That(model.Id, Is.EqualTo(1901722200));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3572935f,

0.3397079f,

0.04365146f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(897666942));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6454743f,

0.83850855f,

0.09987861f,

0.07376236f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.3980741f,

0.70582503f,

0.554939f,

0.71819735f,

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
                Assert.That(model.Id, Is.EqualTo(1947305555));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6148245f,

0.11466569f,

0.10825837f,

0.5397294f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237535761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2785294f,

0.80813134f,

0.16247958f,

0.033518553f,

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
                Assert.That(model.Id, Is.EqualTo(1970672014));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.50416803f,

0.8516648f,

0.7370032f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1884962037));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.041273832f,

0.38159144f,

0.25620645f,

0.14128286f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.5769852f,

0.38471365f,

0.7057446f,

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
                await using var cmd = await ((ISingleListrealArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISingleListrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 728070178);
                var models = await ((ISingleListrealArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(19));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(731677834));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.44820166f,

0.88920003f,

0.7994896f,

0.32221502f,

};
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
                Assert.That(model.Id, Is.EqualTo(901819125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5026249f,

0.07041502f,

0.46547616f,

0.2344206f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.80139554f,

0.3304575f,

0.41971147f,

0.8870805f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1992904301));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.34961557f,

0.72442687f,

0.60927194f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.42420083f,

0.17646015f,

0.77016556f,

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
                Assert.That(model.Id, Is.EqualTo(931000760));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.063482046f,

0.32961464f,

0.78257674f,

0.039261937f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(892924785));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.23535758f,

0.096842885f,

0.06502473f,

0.51307464f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.85237044f,

0.15166229f,

0.14157635f,

0.71234673f,

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
                Assert.That(model.Id, Is.EqualTo(940368705));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.114940405f,

0.43694514f,

0.478549f,

};
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
                Assert.That(model.Id, Is.EqualTo(946151915));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.18162394f,

0.60754126f,

0.557265f,

0.23506981f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8720046f,

0.8895388f,

0.021931231f,

0.81662625f,

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
                Assert.That(model.Id, Is.EqualTo(953271073));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42926848f,

0.96555096f,

0.6000328f,

0.975191f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8051075f,

0.32967263f,

0.11289692f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(524258797));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.29988945f,

0.6199064f,

0.5464893f,

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
                Assert.That(model.Id, Is.EqualTo(1022550830));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.39012402f,

0.051538765f,

0.2260291f,

0.60340947f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1416160647));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3255512f,

0.46324503f,

0.1704809f,

0.5680968f,

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
                Assert.That(model.Id, Is.EqualTo(1108205342));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.61472887f,

0.69732517f,

0.7131724f,

};
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
                Assert.That(model.Id, Is.EqualTo(1153746550));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.781832f,

0.064444065f,

0.5294294f,

};
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
                Assert.That(model.Id, Is.EqualTo(1267905682));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.38489592f,

0.12003738f,

0.0131393075f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.82284886f,

0.38469076f,

0.6586194f,

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
                Assert.That(model.Id, Is.EqualTo(1277159121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.44573873f,

0.47218084f,

0.084845126f,

};
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
                Assert.That(model.Id, Is.EqualTo(1297723547));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.64411795f,

0.3725459f,

0.36497152f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9986498f,

0.48087245f,

0.83996755f,

0.19072181f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535451802));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7112784f,

0.19532382f,

0.88194853f,

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
                Assert.That(model.Id, Is.EqualTo(1302829598));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.61329424f,

0.3588876f,

0.8895365f,

0.43167382f,

};
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
                Assert.That(model.Id, Is.EqualTo(1331153488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.32075596f,

0.43473178f,

0.14547062f,

};
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
                Assert.That(model.Id, Is.EqualTo(1612331389));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8327264f,

0.03741318f,

0.4224574f,

0.35395956f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(111298471));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.38111442f,

0.6106924f,

0.93169767f,

0.53120035f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.42889374f,

0.5532268f,

0.1215893f,

0.25200367f,

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
                Assert.That(model.Id, Is.EqualTo(1739984435));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36293495f,

0.037785113f,

0.5222511f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13227493f,

0.46334195f,

0.7904288f,

0.10354817f,

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
                Assert.That(model.Id, Is.EqualTo(1901722200));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3572935f,

0.3397079f,

0.04365146f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(897666942));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6454743f,

0.83850855f,

0.09987861f,

0.07376236f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.3980741f,

0.70582503f,

0.554939f,

0.71819735f,

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
                Assert.That(model.Id, Is.EqualTo(1947305555));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6148245f,

0.11466569f,

0.10825837f,

0.5397294f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237535761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2785294f,

0.80813134f,

0.16247958f,

0.033518553f,

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
                Assert.That(model.Id, Is.EqualTo(1970672014));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.50416803f,

0.8516648f,

0.7370032f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1884962037));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.041273832f,

0.38159144f,

0.25620645f,

0.14128286f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.5769852f,

0.38471365f,

0.7057446f,

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
            asPartInterface: typeof(ISingleListrealArray)
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
                 foreach(var batchResult in ((ISingleListrealArray)this).DbConnectionSelectModelBatch(connection, 160986735, 1267905682))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(28));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(217584221));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.19788754f,

0.72246325f,

0.14171016f,

};
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
                Assert.That(model.Id, Is.EqualTo(254708475));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7623245f,

0.9526623f,

0.9831995f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1099757223));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.34864932f,

0.17358232f,

0.5852427f,

0.58064586f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.13372707f,

0.3272789f,

0.24121404f,

0.066414535f,

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
                Assert.That(model.Id, Is.EqualTo(319613742));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.2499798f,

0.5984741f,

0.45438927f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.58086795f,

0.74077004f,

0.17943323f,

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
                Assert.That(model.Id, Is.EqualTo(338511897));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.580113f,

0.34774208f,

0.58363795f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.09077048f,

0.99306977f,

0.019405484f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(447547747));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.073492706f,

0.3385452f,

0.69278383f,

0.5887041f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.57450825f,

0.9345936f,

0.18916482f,

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
                Assert.That(model.Id, Is.EqualTo(367904832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.022737741f,

0.80530876f,

0.2914037f,

0.5814101f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.30143297f,

0.005677521f,

0.6307739f,

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
                Assert.That(model.Id, Is.EqualTo(482328903));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.13501501f,

0.38359994f,

0.24878669f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.25752568f,

0.8484242f,

0.9043527f,

0.43262017f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2111584194));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8460261f,

0.8707348f,

0.7030817f,

0.1949814f,

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
                Assert.That(model.Id, Is.EqualTo(484543978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.77682537f,

0.05695921f,

0.86242616f,

0.52128756f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.39140993f,

0.9502086f,

0.2817353f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1199815725));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36550808f,

0.08386004f,

0.8007212f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.92161345f,

0.7565545f,

0.3048212f,

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
                Assert.That(model.Id, Is.EqualTo(708017876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.98777235f,

0.58989346f,

0.85800344f,

0.31756616f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.74288446f,

0.02487886f,

0.74775344f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(457227579));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.48824745f,

0.48929715f,

0.07022989f,

0.8419869f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.9349338f,

0.06328577f,

0.97535866f,

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
                Assert.That(model.Id, Is.EqualTo(728070178));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8247922f,

0.88657606f,

0.6966409f,

0.9770198f,

};
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
                Assert.That(model.Id, Is.EqualTo(731677834));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.44820166f,

0.88920003f,

0.7994896f,

0.32221502f,

};
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
                Assert.That(model.Id, Is.EqualTo(901819125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5026249f,

0.07041502f,

0.46547616f,

0.2344206f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.80139554f,

0.3304575f,

0.41971147f,

0.8870805f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1992904301));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.34961557f,

0.72442687f,

0.60927194f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.42420083f,

0.17646015f,

0.77016556f,

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
                Assert.That(model.Id, Is.EqualTo(931000760));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.063482046f,

0.32961464f,

0.78257674f,

0.039261937f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(892924785));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.23535758f,

0.096842885f,

0.06502473f,

0.51307464f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.85237044f,

0.15166229f,

0.14157635f,

0.71234673f,

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
                Assert.That(model.Id, Is.EqualTo(940368705));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.114940405f,

0.43694514f,

0.478549f,

};
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
                Assert.That(model.Id, Is.EqualTo(946151915));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.18162394f,

0.60754126f,

0.557265f,

0.23506981f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8720046f,

0.8895388f,

0.021931231f,

0.81662625f,

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
                Assert.That(model.Id, Is.EqualTo(953271073));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42926848f,

0.96555096f,

0.6000328f,

0.975191f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8051075f,

0.32967263f,

0.11289692f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(524258797));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.29988945f,

0.6199064f,

0.5464893f,

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
                Assert.That(model.Id, Is.EqualTo(1022550830));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.39012402f,

0.051538765f,

0.2260291f,

0.60340947f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1416160647));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3255512f,

0.46324503f,

0.1704809f,

0.5680968f,

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
                Assert.That(model.Id, Is.EqualTo(1108205342));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.61472887f,

0.69732517f,

0.7131724f,

};
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
                Assert.That(model.Id, Is.EqualTo(1153746550));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.781832f,

0.064444065f,

0.5294294f,

};
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
                Assert.That(model.Id, Is.EqualTo(1267905682));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.38489592f,

0.12003738f,

0.0131393075f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.82284886f,

0.38469076f,

0.6586194f,

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
                Assert.That(model.Id, Is.EqualTo(1277159121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.44573873f,

0.47218084f,

0.084845126f,

};
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

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1297723547));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.64411795f,

0.3725459f,

0.36497152f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9986498f,

0.48087245f,

0.83996755f,

0.19072181f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535451802));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7112784f,

0.19532382f,

0.88194853f,

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
                Assert.That(model.Id, Is.EqualTo(1302829598));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.61329424f,

0.3588876f,

0.8895365f,

0.43167382f,

};
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
                Assert.That(model.Id, Is.EqualTo(1331153488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.32075596f,

0.43473178f,

0.14547062f,

};
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

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1612331389));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8327264f,

0.03741318f,

0.4224574f,

0.35395956f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(111298471));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.38111442f,

0.6106924f,

0.93169767f,

0.53120035f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.42889374f,

0.5532268f,

0.1215893f,

0.25200367f,

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
                Assert.That(model.Id, Is.EqualTo(1739984435));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36293495f,

0.037785113f,

0.5222511f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13227493f,

0.46334195f,

0.7904288f,

0.10354817f,

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
                Assert.That(model.Id, Is.EqualTo(1901722200));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3572935f,

0.3397079f,

0.04365146f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(897666942));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6454743f,

0.83850855f,

0.09987861f,

0.07376236f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.3980741f,

0.70582503f,

0.554939f,

0.71819735f,

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
                Assert.That(model.Id, Is.EqualTo(1947305555));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6148245f,

0.11466569f,

0.10825837f,

0.5397294f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237535761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2785294f,

0.80813134f,

0.16247958f,

0.033518553f,

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
                Assert.That(model.Id, Is.EqualTo(1970672014));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.50416803f,

0.8516648f,

0.7370032f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1884962037));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.041273832f,

0.38159144f,

0.25620645f,

0.14128286f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.5769852f,

0.38471365f,

0.7057446f,

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
                        Assert.That(models, Has.Count.EqualTo(9));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1277159121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.44573873f,

0.47218084f,

0.084845126f,

};
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
                Assert.That(model.Id, Is.EqualTo(1297723547));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.64411795f,

0.3725459f,

0.36497152f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9986498f,

0.48087245f,

0.83996755f,

0.19072181f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535451802));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7112784f,

0.19532382f,

0.88194853f,

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
                Assert.That(model.Id, Is.EqualTo(1302829598));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.61329424f,

0.3588876f,

0.8895365f,

0.43167382f,

};
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
                Assert.That(model.Id, Is.EqualTo(1331153488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.32075596f,

0.43473178f,

0.14547062f,

};
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
                Assert.That(model.Id, Is.EqualTo(1612331389));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8327264f,

0.03741318f,

0.4224574f,

0.35395956f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(111298471));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.38111442f,

0.6106924f,

0.93169767f,

0.53120035f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.42889374f,

0.5532268f,

0.1215893f,

0.25200367f,

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1739984435));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36293495f,

0.037785113f,

0.5222511f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13227493f,

0.46334195f,

0.7904288f,

0.10354817f,

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
                Assert.That(model.Id, Is.EqualTo(1901722200));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3572935f,

0.3397079f,

0.04365146f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(897666942));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6454743f,

0.83850855f,

0.09987861f,

0.07376236f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.3980741f,

0.70582503f,

0.554939f,

0.71819735f,

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
                Assert.That(model.Id, Is.EqualTo(1947305555));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6148245f,

0.11466569f,

0.10825837f,

0.5397294f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237535761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2785294f,

0.80813134f,

0.16247958f,

0.033518553f,

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
                Assert.That(model.Id, Is.EqualTo(1970672014));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.50416803f,

0.8516648f,

0.7370032f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1884962037));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.041273832f,

0.38159144f,

0.25620645f,

0.14128286f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.5769852f,

0.38471365f,

0.7057446f,

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
                await foreach(var batchResult in ((ISingleListrealArray)this).DbConnectionSelectModelBatchAsync(connection, 482328903, 728070178))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(22));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(484543978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.77682537f,

0.05695921f,

0.86242616f,

0.52128756f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.39140993f,

0.9502086f,

0.2817353f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1199815725));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36550808f,

0.08386004f,

0.8007212f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.92161345f,

0.7565545f,

0.3048212f,

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
                Assert.That(model.Id, Is.EqualTo(708017876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.98777235f,

0.58989346f,

0.85800344f,

0.31756616f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.74288446f,

0.02487886f,

0.74775344f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(457227579));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.48824745f,

0.48929715f,

0.07022989f,

0.8419869f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.9349338f,

0.06328577f,

0.97535866f,

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
                Assert.That(model.Id, Is.EqualTo(728070178));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8247922f,

0.88657606f,

0.6966409f,

0.9770198f,

};
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
                Assert.That(model.Id, Is.EqualTo(731677834));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.44820166f,

0.88920003f,

0.7994896f,

0.32221502f,

};
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
                Assert.That(model.Id, Is.EqualTo(901819125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5026249f,

0.07041502f,

0.46547616f,

0.2344206f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.80139554f,

0.3304575f,

0.41971147f,

0.8870805f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1992904301));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.34961557f,

0.72442687f,

0.60927194f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.42420083f,

0.17646015f,

0.77016556f,

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(931000760));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.063482046f,

0.32961464f,

0.78257674f,

0.039261937f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(892924785));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.23535758f,

0.096842885f,

0.06502473f,

0.51307464f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.85237044f,

0.15166229f,

0.14157635f,

0.71234673f,

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
                Assert.That(model.Id, Is.EqualTo(940368705));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.114940405f,

0.43694514f,

0.478549f,

};
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
                Assert.That(model.Id, Is.EqualTo(946151915));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.18162394f,

0.60754126f,

0.557265f,

0.23506981f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8720046f,

0.8895388f,

0.021931231f,

0.81662625f,

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
                Assert.That(model.Id, Is.EqualTo(953271073));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42926848f,

0.96555096f,

0.6000328f,

0.975191f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8051075f,

0.32967263f,

0.11289692f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(524258797));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.29988945f,

0.6199064f,

0.5464893f,

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
                Assert.That(model.Id, Is.EqualTo(1022550830));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.39012402f,

0.051538765f,

0.2260291f,

0.60340947f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1416160647));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3255512f,

0.46324503f,

0.1704809f,

0.5680968f,

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
                Assert.That(model.Id, Is.EqualTo(1108205342));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.61472887f,

0.69732517f,

0.7131724f,

};
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
                Assert.That(model.Id, Is.EqualTo(1153746550));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.781832f,

0.064444065f,

0.5294294f,

};
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
                Assert.That(model.Id, Is.EqualTo(1267905682));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.38489592f,

0.12003738f,

0.0131393075f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.82284886f,

0.38469076f,

0.6586194f,

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
                Assert.That(model.Id, Is.EqualTo(1277159121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.44573873f,

0.47218084f,

0.084845126f,

};
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
                Assert.That(model.Id, Is.EqualTo(1297723547));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.64411795f,

0.3725459f,

0.36497152f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9986498f,

0.48087245f,

0.83996755f,

0.19072181f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535451802));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7112784f,

0.19532382f,

0.88194853f,

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
                Assert.That(model.Id, Is.EqualTo(1302829598));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.61329424f,

0.3588876f,

0.8895365f,

0.43167382f,

};
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
                Assert.That(model.Id, Is.EqualTo(1331153488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.32075596f,

0.43473178f,

0.14547062f,

};
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
                Assert.That(model.Id, Is.EqualTo(1612331389));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8327264f,

0.03741318f,

0.4224574f,

0.35395956f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(111298471));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.38111442f,

0.6106924f,

0.93169767f,

0.53120035f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.42889374f,

0.5532268f,

0.1215893f,

0.25200367f,

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
                Assert.That(model.Id, Is.EqualTo(1739984435));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36293495f,

0.037785113f,

0.5222511f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13227493f,

0.46334195f,

0.7904288f,

0.10354817f,

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
                Assert.That(model.Id, Is.EqualTo(1901722200));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3572935f,

0.3397079f,

0.04365146f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(897666942));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6454743f,

0.83850855f,

0.09987861f,

0.07376236f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.3980741f,

0.70582503f,

0.554939f,

0.71819735f,

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
                Assert.That(model.Id, Is.EqualTo(1947305555));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6148245f,

0.11466569f,

0.10825837f,

0.5397294f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237535761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2785294f,

0.80813134f,

0.16247958f,

0.033518553f,

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
                Assert.That(model.Id, Is.EqualTo(1970672014));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.50416803f,

0.8516648f,

0.7370032f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1884962037));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.041273832f,

0.38159144f,

0.25620645f,

0.14128286f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.5769852f,

0.38471365f,

0.7057446f,

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
                        Assert.That(models, Has.Count.EqualTo(19));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(731677834));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.44820166f,

0.88920003f,

0.7994896f,

0.32221502f,

};
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
                Assert.That(model.Id, Is.EqualTo(901819125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5026249f,

0.07041502f,

0.46547616f,

0.2344206f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.80139554f,

0.3304575f,

0.41971147f,

0.8870805f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1992904301));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.34961557f,

0.72442687f,

0.60927194f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.42420083f,

0.17646015f,

0.77016556f,

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
                Assert.That(model.Id, Is.EqualTo(931000760));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.063482046f,

0.32961464f,

0.78257674f,

0.039261937f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(892924785));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.23535758f,

0.096842885f,

0.06502473f,

0.51307464f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.85237044f,

0.15166229f,

0.14157635f,

0.71234673f,

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
                Assert.That(model.Id, Is.EqualTo(940368705));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.114940405f,

0.43694514f,

0.478549f,

};
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
                Assert.That(model.Id, Is.EqualTo(946151915));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.18162394f,

0.60754126f,

0.557265f,

0.23506981f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8720046f,

0.8895388f,

0.021931231f,

0.81662625f,

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
                Assert.That(model.Id, Is.EqualTo(953271073));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42926848f,

0.96555096f,

0.6000328f,

0.975191f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8051075f,

0.32967263f,

0.11289692f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(524258797));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.29988945f,

0.6199064f,

0.5464893f,

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
                Assert.That(model.Id, Is.EqualTo(1022550830));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.39012402f,

0.051538765f,

0.2260291f,

0.60340947f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1416160647));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3255512f,

0.46324503f,

0.1704809f,

0.5680968f,

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
                Assert.That(model.Id, Is.EqualTo(1108205342));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.61472887f,

0.69732517f,

0.7131724f,

};
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
                Assert.That(model.Id, Is.EqualTo(1153746550));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.781832f,

0.064444065f,

0.5294294f,

};
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
                Assert.That(model.Id, Is.EqualTo(1267905682));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.38489592f,

0.12003738f,

0.0131393075f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.82284886f,

0.38469076f,

0.6586194f,

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
                Assert.That(model.Id, Is.EqualTo(1277159121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.44573873f,

0.47218084f,

0.084845126f,

};
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
                Assert.That(model.Id, Is.EqualTo(1297723547));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.64411795f,

0.3725459f,

0.36497152f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9986498f,

0.48087245f,

0.83996755f,

0.19072181f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535451802));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7112784f,

0.19532382f,

0.88194853f,

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
                Assert.That(model.Id, Is.EqualTo(1302829598));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.61329424f,

0.3588876f,

0.8895365f,

0.43167382f,

};
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
                Assert.That(model.Id, Is.EqualTo(1331153488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.32075596f,

0.43473178f,

0.14547062f,

};
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
                Assert.That(model.Id, Is.EqualTo(1612331389));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8327264f,

0.03741318f,

0.4224574f,

0.35395956f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(111298471));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.38111442f,

0.6106924f,

0.93169767f,

0.53120035f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.42889374f,

0.5532268f,

0.1215893f,

0.25200367f,

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
                Assert.That(model.Id, Is.EqualTo(1739984435));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36293495f,

0.037785113f,

0.5222511f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13227493f,

0.46334195f,

0.7904288f,

0.10354817f,

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
                Assert.That(model.Id, Is.EqualTo(1901722200));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3572935f,

0.3397079f,

0.04365146f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(897666942));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6454743f,

0.83850855f,

0.09987861f,

0.07376236f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.3980741f,

0.70582503f,

0.554939f,

0.71819735f,

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
                Assert.That(model.Id, Is.EqualTo(1947305555));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6148245f,

0.11466569f,

0.10825837f,

0.5397294f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237535761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2785294f,

0.80813134f,

0.16247958f,

0.033518553f,

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
                Assert.That(model.Id, Is.EqualTo(1970672014));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.50416803f,

0.8516648f,

0.7370032f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1884962037));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.041273832f,

0.38159144f,

0.25620645f,

0.14128286f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.5769852f,

0.38471365f,

0.7057446f,

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
COPY public.binary_singlerealarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(SinglerealArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
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
FROM public.binary_singlerealarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(SinglerealArray2MI),
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

                var importCollection = new List<SinglerealArray2MI>(7);

                importCollection.Add(
                new SinglerealArray2MI
                {
                    Id = 111298471,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.38111442f,

0.6106924f,

0.93169767f,

0.53120035f,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42889374f,

0.5532268f,

0.1215893f,

0.25200367f,

}
                });

                importCollection.Add(
                new SinglerealArray2MI
                {
                    Id = 447547747,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.073492706f,

0.3385452f,

0.69278383f,

0.5887041f,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.57450825f,

0.9345936f,

0.18916482f,

}
                });

                importCollection.Add(
                new SinglerealArray2MI
                {
                    Id = 457227579,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.48824745f,

0.48929715f,

0.07022989f,

0.8419869f,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9349338f,

0.06328577f,

0.97535866f,

}
                });

                importCollection.Add(
                new SinglerealArray2MI
                {
                    Id = 524258797,
                    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.29988945f,

0.6199064f,

0.5464893f,

},
                    NullableValue = null
                });

                importCollection.Add(
                new SinglerealArray2MI
                {
                    Id = 892924785,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.23535758f,

0.096842885f,

0.06502473f,

0.51307464f,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.85237044f,

0.15166229f,

0.14157635f,

0.71234673f,

}
                });

                importCollection.Add(
                new SinglerealArray2MI
                {
                    Id = 897666942,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6454743f,

0.83850855f,

0.09987861f,

0.07376236f,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3980741f,

0.70582503f,

0.554939f,

0.71819735f,

}
                });

                importCollection.Add(
                new SinglerealArray2MI
                {
                    Id = 1099757223,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.34864932f,

0.17358232f,

0.5852427f,

0.58064586f,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13372707f,

0.3272789f,

0.24121404f,

0.066414535f,

}
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(111298471));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.38111442f,

0.6106924f,

0.93169767f,

0.53120035f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42889374f,

0.5532268f,

0.1215893f,

0.25200367f,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(447547747));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.073492706f,

0.3385452f,

0.69278383f,

0.5887041f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.57450825f,

0.9345936f,

0.18916482f,

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
                Assert.That(model.Id, Is.EqualTo(457227579));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.48824745f,

0.48929715f,

0.07022989f,

0.8419869f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9349338f,

0.06328577f,

0.97535866f,

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
                Assert.That(model.Id, Is.EqualTo(524258797));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.29988945f,

0.6199064f,

0.5464893f,

};
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
                Assert.That(model.Id, Is.EqualTo(892924785));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.23535758f,

0.096842885f,

0.06502473f,

0.51307464f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.85237044f,

0.15166229f,

0.14157635f,

0.71234673f,

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
                Assert.That(model.Id, Is.EqualTo(897666942));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6454743f,

0.83850855f,

0.09987861f,

0.07376236f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3980741f,

0.70582503f,

0.554939f,

0.71819735f,

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
                Assert.That(model.Id, Is.EqualTo(1099757223));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.34864932f,

0.17358232f,

0.5852427f,

0.58064586f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13372707f,

0.3272789f,

0.24121404f,

0.066414535f,

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
                new SinglerealArray2MI
                {
                    Id = 1199815725,
                    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36550808f,

0.08386004f,

0.8007212f,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.92161345f,

0.7565545f,

0.3048212f,

}
                });

                importCollection.Add(
                new SinglerealArray2MI
                {
                    Id = 1237535761,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2785294f,

0.80813134f,

0.16247958f,

0.033518553f,

},
                    NullableValue = null
                });

                importCollection.Add(
                new SinglerealArray2MI
                {
                    Id = 1416160647,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3255512f,

0.46324503f,

0.1704809f,

0.5680968f,

},
                    NullableValue = null
                });

                importCollection.Add(
                new SinglerealArray2MI
                {
                    Id = 1535451802,
                    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7112784f,

0.19532382f,

0.88194853f,

},
                    NullableValue = null
                });

                importCollection.Add(
                new SinglerealArray2MI
                {
                    Id = 1884962037,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.041273832f,

0.38159144f,

0.25620645f,

0.14128286f,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5769852f,

0.38471365f,

0.7057446f,

}
                });

                importCollection.Add(
                new SinglerealArray2MI
                {
                    Id = 1911034059,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8597331f,

0.24778455f,

0.32266682f,

0.70744884f,

},
                    NullableValue = null
                });

                importCollection.Add(
                new SinglerealArray2MI
                {
                    Id = 1992904301,
                    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.34961557f,

0.72442687f,

0.60927194f,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.42420083f,

0.17646015f,

0.77016556f,

}
                });

                importCollection.Add(
                new SinglerealArray2MI
                {
                    Id = 2111584194,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8460261f,

0.8707348f,

0.7030817f,

0.1949814f,

},
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(111298471));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.38111442f,

0.6106924f,

0.93169767f,

0.53120035f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42889374f,

0.5532268f,

0.1215893f,

0.25200367f,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(447547747));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.073492706f,

0.3385452f,

0.69278383f,

0.5887041f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.57450825f,

0.9345936f,

0.18916482f,

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
                Assert.That(model.Id, Is.EqualTo(457227579));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.48824745f,

0.48929715f,

0.07022989f,

0.8419869f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9349338f,

0.06328577f,

0.97535866f,

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
                Assert.That(model.Id, Is.EqualTo(524258797));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.29988945f,

0.6199064f,

0.5464893f,

};
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
                Assert.That(model.Id, Is.EqualTo(892924785));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.23535758f,

0.096842885f,

0.06502473f,

0.51307464f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.85237044f,

0.15166229f,

0.14157635f,

0.71234673f,

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
                Assert.That(model.Id, Is.EqualTo(897666942));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6454743f,

0.83850855f,

0.09987861f,

0.07376236f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3980741f,

0.70582503f,

0.554939f,

0.71819735f,

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
                Assert.That(model.Id, Is.EqualTo(1099757223));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.34864932f,

0.17358232f,

0.5852427f,

0.58064586f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13372707f,

0.3272789f,

0.24121404f,

0.066414535f,

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
                Assert.That(model.Id, Is.EqualTo(1199815725));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36550808f,

0.08386004f,

0.8007212f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.92161345f,

0.7565545f,

0.3048212f,

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
                Assert.That(model.Id, Is.EqualTo(1237535761));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2785294f,

0.80813134f,

0.16247958f,

0.033518553f,

};
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
                Assert.That(model.Id, Is.EqualTo(1416160647));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3255512f,

0.46324503f,

0.1704809f,

0.5680968f,

};
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
                Assert.That(model.Id, Is.EqualTo(1535451802));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7112784f,

0.19532382f,

0.88194853f,

};
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
                Assert.That(model.Id, Is.EqualTo(1884962037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.041273832f,

0.38159144f,

0.25620645f,

0.14128286f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5769852f,

0.38471365f,

0.7057446f,

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
                Assert.That(model.Id, Is.EqualTo(1911034059));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8597331f,

0.24778455f,

0.32266682f,

0.70744884f,

};
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
                Assert.That(model.Id, Is.EqualTo(1992904301));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.34961557f,

0.72442687f,

0.60927194f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.42420083f,

0.17646015f,

0.77016556f,

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
                Assert.That(model.Id, Is.EqualTo(2111584194));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8460261f,

0.8707348f,

0.7030817f,

0.1949814f,

};
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
COPY public.binary_singlerealarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
singlerealarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(SinglerealArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
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
FROM public.binary_singlerealarray2m m
LEFT JOIN public.binary_singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(SinglerealArray2M),
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

                var importCollection = new List<SinglerealArray2M>(15);

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 155507141,
                    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.72002023f,

0.63042796f,

0.3198427f,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.25912172f,

0.32571447f,

0.7634573f,

},

                    ModelInner = new SinglerealArray2MI 
                    {
                        Id = 1911034059
                    }

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 160986735,
                    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5188442f,

0.2851737f,

0.47475958f,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 217584221,
                    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.19788754f,

0.72246325f,

0.14171016f,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 254708475,
                    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7623245f,

0.9526623f,

0.9831995f,

},
                    NullableValue = null,

                    ModelInner = new SinglerealArray2MI 
                    {
                        Id = 1099757223
                    }

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 319613742,
                    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.2499798f,

0.5984741f,

0.45438927f,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.58086795f,

0.74077004f,

0.17943323f,

},

                    ModelInner = null

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 338511897,
                    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.580113f,

0.34774208f,

0.58363795f,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.09077048f,

0.99306977f,

0.019405484f,

},

                    ModelInner = new SinglerealArray2MI 
                    {
                        Id = 447547747
                    }

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 367904832,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.022737741f,

0.80530876f,

0.2914037f,

0.5814101f,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.30143297f,

0.005677521f,

0.6307739f,

},

                    ModelInner = null

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 482328903,
                    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.13501501f,

0.38359994f,

0.24878669f,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.25752568f,

0.8484242f,

0.9043527f,

0.43262017f,

},

                    ModelInner = new SinglerealArray2MI 
                    {
                        Id = 2111584194
                    }

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 484543978,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.77682537f,

0.05695921f,

0.86242616f,

0.52128756f,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.39140993f,

0.9502086f,

0.2817353f,

},

                    ModelInner = new SinglerealArray2MI 
                    {
                        Id = 1199815725
                    }

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 708017876,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.98777235f,

0.58989346f,

0.85800344f,

0.31756616f,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.74288446f,

0.02487886f,

0.74775344f,

},

                    ModelInner = new SinglerealArray2MI 
                    {
                        Id = 457227579
                    }

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 728070178,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8247922f,

0.88657606f,

0.6966409f,

0.9770198f,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 731677834,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.44820166f,

0.88920003f,

0.7994896f,

0.32221502f,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 901819125,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5026249f,

0.07041502f,

0.46547616f,

0.2344206f,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.80139554f,

0.3304575f,

0.41971147f,

0.8870805f,

},

                    ModelInner = new SinglerealArray2MI 
                    {
                        Id = 1992904301
                    }

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 931000760,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.063482046f,

0.32961464f,

0.78257674f,

0.039261937f,

},
                    NullableValue = null,

                    ModelInner = new SinglerealArray2MI 
                    {
                        Id = 892924785
                    }

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 940368705,
                    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.114940405f,

0.43694514f,

0.478549f,

},
                    NullableValue = null,

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(155507141));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.72002023f,

0.63042796f,

0.3198427f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.25912172f,

0.32571447f,

0.7634573f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1911034059));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8597331f,

0.24778455f,

0.32266682f,

0.70744884f,

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
                Assert.That(model.Id, Is.EqualTo(160986735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5188442f,

0.2851737f,

0.47475958f,

};
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
                Assert.That(model.Id, Is.EqualTo(217584221));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.19788754f,

0.72246325f,

0.14171016f,

};
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
                Assert.That(model.Id, Is.EqualTo(254708475));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7623245f,

0.9526623f,

0.9831995f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1099757223));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.34864932f,

0.17358232f,

0.5852427f,

0.58064586f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.13372707f,

0.3272789f,

0.24121404f,

0.066414535f,

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
                Assert.That(model.Id, Is.EqualTo(319613742));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.2499798f,

0.5984741f,

0.45438927f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.58086795f,

0.74077004f,

0.17943323f,

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
                Assert.That(model.Id, Is.EqualTo(338511897));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.580113f,

0.34774208f,

0.58363795f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.09077048f,

0.99306977f,

0.019405484f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(447547747));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.073492706f,

0.3385452f,

0.69278383f,

0.5887041f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.57450825f,

0.9345936f,

0.18916482f,

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
                Assert.That(model.Id, Is.EqualTo(367904832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.022737741f,

0.80530876f,

0.2914037f,

0.5814101f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.30143297f,

0.005677521f,

0.6307739f,

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
                Assert.That(model.Id, Is.EqualTo(482328903));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.13501501f,

0.38359994f,

0.24878669f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.25752568f,

0.8484242f,

0.9043527f,

0.43262017f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2111584194));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8460261f,

0.8707348f,

0.7030817f,

0.1949814f,

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
                Assert.That(model.Id, Is.EqualTo(484543978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.77682537f,

0.05695921f,

0.86242616f,

0.52128756f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.39140993f,

0.9502086f,

0.2817353f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1199815725));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36550808f,

0.08386004f,

0.8007212f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.92161345f,

0.7565545f,

0.3048212f,

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
                Assert.That(model.Id, Is.EqualTo(708017876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.98777235f,

0.58989346f,

0.85800344f,

0.31756616f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.74288446f,

0.02487886f,

0.74775344f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(457227579));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.48824745f,

0.48929715f,

0.07022989f,

0.8419869f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.9349338f,

0.06328577f,

0.97535866f,

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
                Assert.That(model.Id, Is.EqualTo(728070178));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8247922f,

0.88657606f,

0.6966409f,

0.9770198f,

};
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
                Assert.That(model.Id, Is.EqualTo(731677834));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.44820166f,

0.88920003f,

0.7994896f,

0.32221502f,

};
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
                Assert.That(model.Id, Is.EqualTo(901819125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5026249f,

0.07041502f,

0.46547616f,

0.2344206f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.80139554f,

0.3304575f,

0.41971147f,

0.8870805f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1992904301));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.34961557f,

0.72442687f,

0.60927194f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.42420083f,

0.17646015f,

0.77016556f,

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
                Assert.That(model.Id, Is.EqualTo(931000760));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.063482046f,

0.32961464f,

0.78257674f,

0.039261937f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(892924785));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.23535758f,

0.096842885f,

0.06502473f,

0.51307464f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.85237044f,

0.15166229f,

0.14157635f,

0.71234673f,

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
                Assert.That(model.Id, Is.EqualTo(940368705));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.114940405f,

0.43694514f,

0.478549f,

};
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

                importCollection.Clear();

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 946151915,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.18162394f,

0.60754126f,

0.557265f,

0.23506981f,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8720046f,

0.8895388f,

0.021931231f,

0.81662625f,

},

                    ModelInner = null

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 953271073,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42926848f,

0.96555096f,

0.6000328f,

0.975191f,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8051075f,

0.32967263f,

0.11289692f,

},

                    ModelInner = new SinglerealArray2MI 
                    {
                        Id = 524258797
                    }

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 1022550830,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.39012402f,

0.051538765f,

0.2260291f,

0.60340947f,

},
                    NullableValue = null,

                    ModelInner = new SinglerealArray2MI 
                    {
                        Id = 1416160647
                    }

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 1108205342,
                    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.61472887f,

0.69732517f,

0.7131724f,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 1153746550,
                    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.781832f,

0.064444065f,

0.5294294f,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 1267905682,
                    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.38489592f,

0.12003738f,

0.0131393075f,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.82284886f,

0.38469076f,

0.6586194f,

},

                    ModelInner = null

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 1277159121,
                    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.44573873f,

0.47218084f,

0.084845126f,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 1297723547,
                    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.64411795f,

0.3725459f,

0.36497152f,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9986498f,

0.48087245f,

0.83996755f,

0.19072181f,

},

                    ModelInner = new SinglerealArray2MI 
                    {
                        Id = 1535451802
                    }

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 1302829598,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.61329424f,

0.3588876f,

0.8895365f,

0.43167382f,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 1331153488,
                    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.32075596f,

0.43473178f,

0.14547062f,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 1612331389,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8327264f,

0.03741318f,

0.4224574f,

0.35395956f,

},
                    NullableValue = null,

                    ModelInner = new SinglerealArray2MI 
                    {
                        Id = 111298471
                    }

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 1739984435,
                    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36293495f,

0.037785113f,

0.5222511f,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13227493f,

0.46334195f,

0.7904288f,

0.10354817f,

},

                    ModelInner = null

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 1901722200,
                    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3572935f,

0.3397079f,

0.04365146f,

},
                    NullableValue = null,

                    ModelInner = new SinglerealArray2MI 
                    {
                        Id = 897666942
                    }

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 1947305555,
                    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6148245f,

0.11466569f,

0.10825837f,

0.5397294f,

},
                    NullableValue = null,

                    ModelInner = new SinglerealArray2MI 
                    {
                        Id = 1237535761
                    }

                });

                importCollection.Add(
                new SinglerealArray2M
                {
                    Id = 1970672014,
                    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.50416803f,

0.8516648f,

0.7370032f,

},
                    NullableValue = null,

                    ModelInner = new SinglerealArray2MI 
                    {
                        Id = 1884962037
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(155507141));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.72002023f,

0.63042796f,

0.3198427f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.25912172f,

0.32571447f,

0.7634573f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1911034059));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8597331f,

0.24778455f,

0.32266682f,

0.70744884f,

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
                Assert.That(model.Id, Is.EqualTo(160986735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5188442f,

0.2851737f,

0.47475958f,

};
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
                Assert.That(model.Id, Is.EqualTo(217584221));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.19788754f,

0.72246325f,

0.14171016f,

};
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
                Assert.That(model.Id, Is.EqualTo(254708475));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7623245f,

0.9526623f,

0.9831995f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1099757223));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.34864932f,

0.17358232f,

0.5852427f,

0.58064586f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.13372707f,

0.3272789f,

0.24121404f,

0.066414535f,

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
                Assert.That(model.Id, Is.EqualTo(319613742));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.2499798f,

0.5984741f,

0.45438927f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.58086795f,

0.74077004f,

0.17943323f,

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
                Assert.That(model.Id, Is.EqualTo(338511897));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.580113f,

0.34774208f,

0.58363795f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.09077048f,

0.99306977f,

0.019405484f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(447547747));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.073492706f,

0.3385452f,

0.69278383f,

0.5887041f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.57450825f,

0.9345936f,

0.18916482f,

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
                Assert.That(model.Id, Is.EqualTo(367904832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.022737741f,

0.80530876f,

0.2914037f,

0.5814101f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.30143297f,

0.005677521f,

0.6307739f,

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
                Assert.That(model.Id, Is.EqualTo(482328903));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.13501501f,

0.38359994f,

0.24878669f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.25752568f,

0.8484242f,

0.9043527f,

0.43262017f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2111584194));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8460261f,

0.8707348f,

0.7030817f,

0.1949814f,

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
                Assert.That(model.Id, Is.EqualTo(484543978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.77682537f,

0.05695921f,

0.86242616f,

0.52128756f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.39140993f,

0.9502086f,

0.2817353f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1199815725));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36550808f,

0.08386004f,

0.8007212f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.92161345f,

0.7565545f,

0.3048212f,

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
                Assert.That(model.Id, Is.EqualTo(708017876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.98777235f,

0.58989346f,

0.85800344f,

0.31756616f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.74288446f,

0.02487886f,

0.74775344f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(457227579));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.48824745f,

0.48929715f,

0.07022989f,

0.8419869f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.9349338f,

0.06328577f,

0.97535866f,

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
                Assert.That(model.Id, Is.EqualTo(728070178));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8247922f,

0.88657606f,

0.6966409f,

0.9770198f,

};
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
                Assert.That(model.Id, Is.EqualTo(731677834));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.44820166f,

0.88920003f,

0.7994896f,

0.32221502f,

};
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
                Assert.That(model.Id, Is.EqualTo(901819125));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5026249f,

0.07041502f,

0.46547616f,

0.2344206f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.80139554f,

0.3304575f,

0.41971147f,

0.8870805f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1992904301));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.34961557f,

0.72442687f,

0.60927194f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.42420083f,

0.17646015f,

0.77016556f,

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
                Assert.That(model.Id, Is.EqualTo(931000760));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.063482046f,

0.32961464f,

0.78257674f,

0.039261937f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(892924785));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.23535758f,

0.096842885f,

0.06502473f,

0.51307464f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.85237044f,

0.15166229f,

0.14157635f,

0.71234673f,

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
                Assert.That(model.Id, Is.EqualTo(940368705));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.114940405f,

0.43694514f,

0.478549f,

};
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
                Assert.That(model.Id, Is.EqualTo(946151915));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.18162394f,

0.60754126f,

0.557265f,

0.23506981f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8720046f,

0.8895388f,

0.021931231f,

0.81662625f,

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
                Assert.That(model.Id, Is.EqualTo(953271073));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42926848f,

0.96555096f,

0.6000328f,

0.975191f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8051075f,

0.32967263f,

0.11289692f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(524258797));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.29988945f,

0.6199064f,

0.5464893f,

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
                Assert.That(model.Id, Is.EqualTo(1022550830));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.39012402f,

0.051538765f,

0.2260291f,

0.60340947f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1416160647));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3255512f,

0.46324503f,

0.1704809f,

0.5680968f,

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
                Assert.That(model.Id, Is.EqualTo(1108205342));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.61472887f,

0.69732517f,

0.7131724f,

};
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
                Assert.That(model.Id, Is.EqualTo(1153746550));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.781832f,

0.064444065f,

0.5294294f,

};
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


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1267905682));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.38489592f,

0.12003738f,

0.0131393075f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.82284886f,

0.38469076f,

0.6586194f,

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
                Assert.That(model.Id, Is.EqualTo(1277159121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.44573873f,

0.47218084f,

0.084845126f,

};
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
                Assert.That(model.Id, Is.EqualTo(1297723547));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.64411795f,

0.3725459f,

0.36497152f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9986498f,

0.48087245f,

0.83996755f,

0.19072181f,

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535451802));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7112784f,

0.19532382f,

0.88194853f,

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
                Assert.That(model.Id, Is.EqualTo(1302829598));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.61329424f,

0.3588876f,

0.8895365f,

0.43167382f,

};
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
                Assert.That(model.Id, Is.EqualTo(1331153488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.32075596f,

0.43473178f,

0.14547062f,

};
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


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1612331389));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8327264f,

0.03741318f,

0.4224574f,

0.35395956f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(111298471));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.38111442f,

0.6106924f,

0.93169767f,

0.53120035f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.42889374f,

0.5532268f,

0.1215893f,

0.25200367f,

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
                Assert.That(model.Id, Is.EqualTo(1739984435));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36293495f,

0.037785113f,

0.5222511f,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13227493f,

0.46334195f,

0.7904288f,

0.10354817f,

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
                Assert.That(model.Id, Is.EqualTo(1901722200));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3572935f,

0.3397079f,

0.04365146f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(897666942));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6454743f,

0.83850855f,

0.09987861f,

0.07376236f,

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
new System.Collections.Generic.List<System.Single>(4)
{
0.3980741f,

0.70582503f,

0.554939f,

0.71819735f,

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
                Assert.That(model.Id, Is.EqualTo(1947305555));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6148245f,

0.11466569f,

0.10825837f,

0.5397294f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237535761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2785294f,

0.80813134f,

0.16247958f,

0.033518553f,

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
                Assert.That(model.Id, Is.EqualTo(1970672014));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.50416803f,

0.8516648f,

0.7370032f,

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1884962037));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.041273832f,

0.38159144f,

0.25620645f,

0.14128286f,

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
new System.Collections.Generic.List<System.Single>(3)
{
0.5769852f,

0.38471365f,

0.7057446f,

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
COPY public.binary_singlerealarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    singlerealarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(SinglerealArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
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

                var expected = new Dictionary<System.Int32,SinglerealArray2M>(30);

                expected.Add(
                    155507141,
                    new SinglerealArray2M
                    {
                        Id = 155507141,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.72002023f,

0.63042796f,

0.3198427f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.25912172f,

0.32571447f,

0.7634573f,

},

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 1911034059,
                            Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8597331f,

0.24778455f,

0.32266682f,

0.70744884f,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    160986735,
                    new SinglerealArray2M
                    {
                        Id = 160986735,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5188442f,

0.2851737f,

0.47475958f,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    217584221,
                    new SinglerealArray2M
                    {
                        Id = 217584221,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.19788754f,

0.72246325f,

0.14171016f,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    254708475,
                    new SinglerealArray2M
                    {
                        Id = 254708475,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7623245f,

0.9526623f,

0.9831995f,

},
                        NullableValue = null,

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 1099757223,
                            Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.34864932f,

0.17358232f,

0.5852427f,

0.58064586f,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13372707f,

0.3272789f,

0.24121404f,

0.066414535f,

}
                        }

                    }
                );

                expected.Add(
                    319613742,
                    new SinglerealArray2M
                    {
                        Id = 319613742,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.2499798f,

0.5984741f,

0.45438927f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.58086795f,

0.74077004f,

0.17943323f,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    338511897,
                    new SinglerealArray2M
                    {
                        Id = 338511897,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.580113f,

0.34774208f,

0.58363795f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.09077048f,

0.99306977f,

0.019405484f,

},

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 447547747,
                            Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.073492706f,

0.3385452f,

0.69278383f,

0.5887041f,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.57450825f,

0.9345936f,

0.18916482f,

}
                        }

                    }
                );

                expected.Add(
                    367904832,
                    new SinglerealArray2M
                    {
                        Id = 367904832,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.022737741f,

0.80530876f,

0.2914037f,

0.5814101f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.30143297f,

0.005677521f,

0.6307739f,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    482328903,
                    new SinglerealArray2M
                    {
                        Id = 482328903,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.13501501f,

0.38359994f,

0.24878669f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.25752568f,

0.8484242f,

0.9043527f,

0.43262017f,

},

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 2111584194,
                            Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8460261f,

0.8707348f,

0.7030817f,

0.1949814f,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    484543978,
                    new SinglerealArray2M
                    {
                        Id = 484543978,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.77682537f,

0.05695921f,

0.86242616f,

0.52128756f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.39140993f,

0.9502086f,

0.2817353f,

},

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 1199815725,
                            Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36550808f,

0.08386004f,

0.8007212f,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.92161345f,

0.7565545f,

0.3048212f,

}
                        }

                    }
                );

                expected.Add(
                    708017876,
                    new SinglerealArray2M
                    {
                        Id = 708017876,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.98777235f,

0.58989346f,

0.85800344f,

0.31756616f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.74288446f,

0.02487886f,

0.74775344f,

},

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 457227579,
                            Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.48824745f,

0.48929715f,

0.07022989f,

0.8419869f,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9349338f,

0.06328577f,

0.97535866f,

}
                        }

                    }
                );

                expected.Add(
                    728070178,
                    new SinglerealArray2M
                    {
                        Id = 728070178,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8247922f,

0.88657606f,

0.6966409f,

0.9770198f,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    731677834,
                    new SinglerealArray2M
                    {
                        Id = 731677834,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.44820166f,

0.88920003f,

0.7994896f,

0.32221502f,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    901819125,
                    new SinglerealArray2M
                    {
                        Id = 901819125,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5026249f,

0.07041502f,

0.46547616f,

0.2344206f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.80139554f,

0.3304575f,

0.41971147f,

0.8870805f,

},

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 1992904301,
                            Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.34961557f,

0.72442687f,

0.60927194f,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.42420083f,

0.17646015f,

0.77016556f,

}
                        }

                    }
                );

                expected.Add(
                    931000760,
                    new SinglerealArray2M
                    {
                        Id = 931000760,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.063482046f,

0.32961464f,

0.78257674f,

0.039261937f,

},
                        NullableValue = null,

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 892924785,
                            Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.23535758f,

0.096842885f,

0.06502473f,

0.51307464f,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.85237044f,

0.15166229f,

0.14157635f,

0.71234673f,

}
                        }

                    }
                );

                expected.Add(
                    940368705,
                    new SinglerealArray2M
                    {
                        Id = 940368705,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.114940405f,

0.43694514f,

0.478549f,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    946151915,
                    new SinglerealArray2M
                    {
                        Id = 946151915,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.18162394f,

0.60754126f,

0.557265f,

0.23506981f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8720046f,

0.8895388f,

0.021931231f,

0.81662625f,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    953271073,
                    new SinglerealArray2M
                    {
                        Id = 953271073,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42926848f,

0.96555096f,

0.6000328f,

0.975191f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8051075f,

0.32967263f,

0.11289692f,

},

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 524258797,
                            Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.29988945f,

0.6199064f,

0.5464893f,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1022550830,
                    new SinglerealArray2M
                    {
                        Id = 1022550830,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.39012402f,

0.051538765f,

0.2260291f,

0.60340947f,

},
                        NullableValue = null,

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 1416160647,
                            Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3255512f,

0.46324503f,

0.1704809f,

0.5680968f,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1108205342,
                    new SinglerealArray2M
                    {
                        Id = 1108205342,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.61472887f,

0.69732517f,

0.7131724f,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1153746550,
                    new SinglerealArray2M
                    {
                        Id = 1153746550,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.781832f,

0.064444065f,

0.5294294f,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1267905682,
                    new SinglerealArray2M
                    {
                        Id = 1267905682,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.38489592f,

0.12003738f,

0.0131393075f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.82284886f,

0.38469076f,

0.6586194f,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1277159121,
                    new SinglerealArray2M
                    {
                        Id = 1277159121,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.44573873f,

0.47218084f,

0.084845126f,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1297723547,
                    new SinglerealArray2M
                    {
                        Id = 1297723547,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.64411795f,

0.3725459f,

0.36497152f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9986498f,

0.48087245f,

0.83996755f,

0.19072181f,

},

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 1535451802,
                            Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7112784f,

0.19532382f,

0.88194853f,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1302829598,
                    new SinglerealArray2M
                    {
                        Id = 1302829598,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.61329424f,

0.3588876f,

0.8895365f,

0.43167382f,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1331153488,
                    new SinglerealArray2M
                    {
                        Id = 1331153488,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.32075596f,

0.43473178f,

0.14547062f,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1612331389,
                    new SinglerealArray2M
                    {
                        Id = 1612331389,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8327264f,

0.03741318f,

0.4224574f,

0.35395956f,

},
                        NullableValue = null,

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 111298471,
                            Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.38111442f,

0.6106924f,

0.93169767f,

0.53120035f,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42889374f,

0.5532268f,

0.1215893f,

0.25200367f,

}
                        }

                    }
                );

                expected.Add(
                    1739984435,
                    new SinglerealArray2M
                    {
                        Id = 1739984435,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36293495f,

0.037785113f,

0.5222511f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13227493f,

0.46334195f,

0.7904288f,

0.10354817f,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1901722200,
                    new SinglerealArray2M
                    {
                        Id = 1901722200,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3572935f,

0.3397079f,

0.04365146f,

},
                        NullableValue = null,

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 897666942,
                            Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6454743f,

0.83850855f,

0.09987861f,

0.07376236f,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3980741f,

0.70582503f,

0.554939f,

0.71819735f,

}
                        }

                    }
                );

                expected.Add(
                    1947305555,
                    new SinglerealArray2M
                    {
                        Id = 1947305555,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6148245f,

0.11466569f,

0.10825837f,

0.5397294f,

},
                        NullableValue = null,

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 1237535761,
                            Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2785294f,

0.80813134f,

0.16247958f,

0.033518553f,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1970672014,
                    new SinglerealArray2M
                    {
                        Id = 1970672014,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.50416803f,

0.8516648f,

0.7370032f,

},
                        NullableValue = null,

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 1884962037,
                            Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.041273832f,

0.38159144f,

0.25620645f,

0.14128286f,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5769852f,

0.38471365f,

0.7057446f,

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Single>)default));
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

                var expected = new Dictionary<System.Int32,SinglerealArray2M>(30);

                expected.Add(
                    155507141,
                    new SinglerealArray2M
                    {
                        Id = 155507141,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.72002023f,

0.63042796f,

0.3198427f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.25912172f,

0.32571447f,

0.7634573f,

},

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 1911034059,
                            Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8597331f,

0.24778455f,

0.32266682f,

0.70744884f,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    160986735,
                    new SinglerealArray2M
                    {
                        Id = 160986735,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5188442f,

0.2851737f,

0.47475958f,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    217584221,
                    new SinglerealArray2M
                    {
                        Id = 217584221,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.19788754f,

0.72246325f,

0.14171016f,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    254708475,
                    new SinglerealArray2M
                    {
                        Id = 254708475,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7623245f,

0.9526623f,

0.9831995f,

},
                        NullableValue = null,

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 1099757223,
                            Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.34864932f,

0.17358232f,

0.5852427f,

0.58064586f,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13372707f,

0.3272789f,

0.24121404f,

0.066414535f,

}
                        }

                    }
                );

                expected.Add(
                    319613742,
                    new SinglerealArray2M
                    {
                        Id = 319613742,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.2499798f,

0.5984741f,

0.45438927f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.58086795f,

0.74077004f,

0.17943323f,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    338511897,
                    new SinglerealArray2M
                    {
                        Id = 338511897,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.580113f,

0.34774208f,

0.58363795f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.09077048f,

0.99306977f,

0.019405484f,

},

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 447547747,
                            Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.073492706f,

0.3385452f,

0.69278383f,

0.5887041f,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.57450825f,

0.9345936f,

0.18916482f,

}
                        }

                    }
                );

                expected.Add(
                    367904832,
                    new SinglerealArray2M
                    {
                        Id = 367904832,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.022737741f,

0.80530876f,

0.2914037f,

0.5814101f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.30143297f,

0.005677521f,

0.6307739f,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    482328903,
                    new SinglerealArray2M
                    {
                        Id = 482328903,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.13501501f,

0.38359994f,

0.24878669f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.25752568f,

0.8484242f,

0.9043527f,

0.43262017f,

},

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 2111584194,
                            Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8460261f,

0.8707348f,

0.7030817f,

0.1949814f,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    484543978,
                    new SinglerealArray2M
                    {
                        Id = 484543978,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.77682537f,

0.05695921f,

0.86242616f,

0.52128756f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.39140993f,

0.9502086f,

0.2817353f,

},

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 1199815725,
                            Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36550808f,

0.08386004f,

0.8007212f,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.92161345f,

0.7565545f,

0.3048212f,

}
                        }

                    }
                );

                expected.Add(
                    708017876,
                    new SinglerealArray2M
                    {
                        Id = 708017876,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.98777235f,

0.58989346f,

0.85800344f,

0.31756616f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.74288446f,

0.02487886f,

0.74775344f,

},

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 457227579,
                            Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.48824745f,

0.48929715f,

0.07022989f,

0.8419869f,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9349338f,

0.06328577f,

0.97535866f,

}
                        }

                    }
                );

                expected.Add(
                    728070178,
                    new SinglerealArray2M
                    {
                        Id = 728070178,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8247922f,

0.88657606f,

0.6966409f,

0.9770198f,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    731677834,
                    new SinglerealArray2M
                    {
                        Id = 731677834,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.44820166f,

0.88920003f,

0.7994896f,

0.32221502f,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    901819125,
                    new SinglerealArray2M
                    {
                        Id = 901819125,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5026249f,

0.07041502f,

0.46547616f,

0.2344206f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.80139554f,

0.3304575f,

0.41971147f,

0.8870805f,

},

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 1992904301,
                            Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.34961557f,

0.72442687f,

0.60927194f,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.42420083f,

0.17646015f,

0.77016556f,

}
                        }

                    }
                );

                expected.Add(
                    931000760,
                    new SinglerealArray2M
                    {
                        Id = 931000760,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.063482046f,

0.32961464f,

0.78257674f,

0.039261937f,

},
                        NullableValue = null,

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 892924785,
                            Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.23535758f,

0.096842885f,

0.06502473f,

0.51307464f,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.85237044f,

0.15166229f,

0.14157635f,

0.71234673f,

}
                        }

                    }
                );

                expected.Add(
                    940368705,
                    new SinglerealArray2M
                    {
                        Id = 940368705,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.114940405f,

0.43694514f,

0.478549f,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    946151915,
                    new SinglerealArray2M
                    {
                        Id = 946151915,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.18162394f,

0.60754126f,

0.557265f,

0.23506981f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8720046f,

0.8895388f,

0.021931231f,

0.81662625f,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    953271073,
                    new SinglerealArray2M
                    {
                        Id = 953271073,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42926848f,

0.96555096f,

0.6000328f,

0.975191f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8051075f,

0.32967263f,

0.11289692f,

},

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 524258797,
                            Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.29988945f,

0.6199064f,

0.5464893f,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1022550830,
                    new SinglerealArray2M
                    {
                        Id = 1022550830,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.39012402f,

0.051538765f,

0.2260291f,

0.60340947f,

},
                        NullableValue = null,

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 1416160647,
                            Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3255512f,

0.46324503f,

0.1704809f,

0.5680968f,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1108205342,
                    new SinglerealArray2M
                    {
                        Id = 1108205342,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.61472887f,

0.69732517f,

0.7131724f,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1153746550,
                    new SinglerealArray2M
                    {
                        Id = 1153746550,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.781832f,

0.064444065f,

0.5294294f,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1267905682,
                    new SinglerealArray2M
                    {
                        Id = 1267905682,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.38489592f,

0.12003738f,

0.0131393075f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.82284886f,

0.38469076f,

0.6586194f,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1277159121,
                    new SinglerealArray2M
                    {
                        Id = 1277159121,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.44573873f,

0.47218084f,

0.084845126f,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1297723547,
                    new SinglerealArray2M
                    {
                        Id = 1297723547,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.64411795f,

0.3725459f,

0.36497152f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9986498f,

0.48087245f,

0.83996755f,

0.19072181f,

},

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 1535451802,
                            Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7112784f,

0.19532382f,

0.88194853f,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1302829598,
                    new SinglerealArray2M
                    {
                        Id = 1302829598,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.61329424f,

0.3588876f,

0.8895365f,

0.43167382f,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1331153488,
                    new SinglerealArray2M
                    {
                        Id = 1331153488,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.32075596f,

0.43473178f,

0.14547062f,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1612331389,
                    new SinglerealArray2M
                    {
                        Id = 1612331389,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8327264f,

0.03741318f,

0.4224574f,

0.35395956f,

},
                        NullableValue = null,

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 111298471,
                            Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.38111442f,

0.6106924f,

0.93169767f,

0.53120035f,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42889374f,

0.5532268f,

0.1215893f,

0.25200367f,

}
                        }

                    }
                );

                expected.Add(
                    1739984435,
                    new SinglerealArray2M
                    {
                        Id = 1739984435,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36293495f,

0.037785113f,

0.5222511f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13227493f,

0.46334195f,

0.7904288f,

0.10354817f,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1901722200,
                    new SinglerealArray2M
                    {
                        Id = 1901722200,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3572935f,

0.3397079f,

0.04365146f,

},
                        NullableValue = null,

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 897666942,
                            Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6454743f,

0.83850855f,

0.09987861f,

0.07376236f,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3980741f,

0.70582503f,

0.554939f,

0.71819735f,

}
                        }

                    }
                );

                expected.Add(
                    1947305555,
                    new SinglerealArray2M
                    {
                        Id = 1947305555,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6148245f,

0.11466569f,

0.10825837f,

0.5397294f,

},
                        NullableValue = null,

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 1237535761,
                            Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2785294f,

0.80813134f,

0.16247958f,

0.033518553f,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1970672014,
                    new SinglerealArray2M
                    {
                        Id = 1970672014,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.50416803f,

0.8516648f,

0.7370032f,

},
                        NullableValue = null,

                        ModelInner = new SinglerealArray2MI
                        {
                            Id = 1884962037,
                            Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.041273832f,

0.38159144f,

0.25620645f,

0.14128286f,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5769852f,

0.38471365f,

0.7057446f,

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Single>)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(SinglerealArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
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

                var expected = new Dictionary<System.Int32,SinglerealArray2MI>(15);

                expected.Add(
                    111298471,
                    new SinglerealArray2MI
                    {
                        Id = 111298471,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.38111442f,

0.6106924f,

0.93169767f,

0.53120035f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42889374f,

0.5532268f,

0.1215893f,

0.25200367f,

}
                    }
                );

                expected.Add(
                    447547747,
                    new SinglerealArray2MI
                    {
                        Id = 447547747,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.073492706f,

0.3385452f,

0.69278383f,

0.5887041f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.57450825f,

0.9345936f,

0.18916482f,

}
                    }
                );

                expected.Add(
                    457227579,
                    new SinglerealArray2MI
                    {
                        Id = 457227579,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.48824745f,

0.48929715f,

0.07022989f,

0.8419869f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9349338f,

0.06328577f,

0.97535866f,

}
                    }
                );

                expected.Add(
                    524258797,
                    new SinglerealArray2MI
                    {
                        Id = 524258797,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.29988945f,

0.6199064f,

0.5464893f,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    892924785,
                    new SinglerealArray2MI
                    {
                        Id = 892924785,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.23535758f,

0.096842885f,

0.06502473f,

0.51307464f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.85237044f,

0.15166229f,

0.14157635f,

0.71234673f,

}
                    }
                );

                expected.Add(
                    897666942,
                    new SinglerealArray2MI
                    {
                        Id = 897666942,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6454743f,

0.83850855f,

0.09987861f,

0.07376236f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3980741f,

0.70582503f,

0.554939f,

0.71819735f,

}
                    }
                );

                expected.Add(
                    1099757223,
                    new SinglerealArray2MI
                    {
                        Id = 1099757223,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.34864932f,

0.17358232f,

0.5852427f,

0.58064586f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13372707f,

0.3272789f,

0.24121404f,

0.066414535f,

}
                    }
                );

                expected.Add(
                    1199815725,
                    new SinglerealArray2MI
                    {
                        Id = 1199815725,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36550808f,

0.08386004f,

0.8007212f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.92161345f,

0.7565545f,

0.3048212f,

}
                    }
                );

                expected.Add(
                    1237535761,
                    new SinglerealArray2MI
                    {
                        Id = 1237535761,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2785294f,

0.80813134f,

0.16247958f,

0.033518553f,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1416160647,
                    new SinglerealArray2MI
                    {
                        Id = 1416160647,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3255512f,

0.46324503f,

0.1704809f,

0.5680968f,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1535451802,
                    new SinglerealArray2MI
                    {
                        Id = 1535451802,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7112784f,

0.19532382f,

0.88194853f,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1884962037,
                    new SinglerealArray2MI
                    {
                        Id = 1884962037,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.041273832f,

0.38159144f,

0.25620645f,

0.14128286f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5769852f,

0.38471365f,

0.7057446f,

}
                    }
                );

                expected.Add(
                    1911034059,
                    new SinglerealArray2MI
                    {
                        Id = 1911034059,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8597331f,

0.24778455f,

0.32266682f,

0.70744884f,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1992904301,
                    new SinglerealArray2MI
                    {
                        Id = 1992904301,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.34961557f,

0.72442687f,

0.60927194f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.42420083f,

0.17646015f,

0.77016556f,

}
                    }
                );

                expected.Add(
                    2111584194,
                    new SinglerealArray2MI
                    {
                        Id = 2111584194,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8460261f,

0.8707348f,

0.7030817f,

0.1949814f,

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

                var expected = new Dictionary<System.Int32,SinglerealArray2MI>(15);

                expected.Add(
                    111298471,
                    new SinglerealArray2MI
                    {
                        Id = 111298471,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.38111442f,

0.6106924f,

0.93169767f,

0.53120035f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42889374f,

0.5532268f,

0.1215893f,

0.25200367f,

}
                    }
                );

                expected.Add(
                    447547747,
                    new SinglerealArray2MI
                    {
                        Id = 447547747,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.073492706f,

0.3385452f,

0.69278383f,

0.5887041f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.57450825f,

0.9345936f,

0.18916482f,

}
                    }
                );

                expected.Add(
                    457227579,
                    new SinglerealArray2MI
                    {
                        Id = 457227579,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.48824745f,

0.48929715f,

0.07022989f,

0.8419869f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9349338f,

0.06328577f,

0.97535866f,

}
                    }
                );

                expected.Add(
                    524258797,
                    new SinglerealArray2MI
                    {
                        Id = 524258797,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.29988945f,

0.6199064f,

0.5464893f,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    892924785,
                    new SinglerealArray2MI
                    {
                        Id = 892924785,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.23535758f,

0.096842885f,

0.06502473f,

0.51307464f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.85237044f,

0.15166229f,

0.14157635f,

0.71234673f,

}
                    }
                );

                expected.Add(
                    897666942,
                    new SinglerealArray2MI
                    {
                        Id = 897666942,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6454743f,

0.83850855f,

0.09987861f,

0.07376236f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3980741f,

0.70582503f,

0.554939f,

0.71819735f,

}
                    }
                );

                expected.Add(
                    1099757223,
                    new SinglerealArray2MI
                    {
                        Id = 1099757223,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.34864932f,

0.17358232f,

0.5852427f,

0.58064586f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13372707f,

0.3272789f,

0.24121404f,

0.066414535f,

}
                    }
                );

                expected.Add(
                    1199815725,
                    new SinglerealArray2MI
                    {
                        Id = 1199815725,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36550808f,

0.08386004f,

0.8007212f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.92161345f,

0.7565545f,

0.3048212f,

}
                    }
                );

                expected.Add(
                    1237535761,
                    new SinglerealArray2MI
                    {
                        Id = 1237535761,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2785294f,

0.80813134f,

0.16247958f,

0.033518553f,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1416160647,
                    new SinglerealArray2MI
                    {
                        Id = 1416160647,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3255512f,

0.46324503f,

0.1704809f,

0.5680968f,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1535451802,
                    new SinglerealArray2MI
                    {
                        Id = 1535451802,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7112784f,

0.19532382f,

0.88194853f,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1884962037,
                    new SinglerealArray2MI
                    {
                        Id = 1884962037,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.041273832f,

0.38159144f,

0.25620645f,

0.14128286f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5769852f,

0.38471365f,

0.7057446f,

}
                    }
                );

                expected.Add(
                    1911034059,
                    new SinglerealArray2MI
                    {
                        Id = 1911034059,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8597331f,

0.24778455f,

0.32266682f,

0.70744884f,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1992904301,
                    new SinglerealArray2MI
                    {
                        Id = 1992904301,
                        Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.34961557f,

0.72442687f,

0.60927194f,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.42420083f,

0.17646015f,

0.77016556f,

}
                    }
                );

                expected.Add(
                    2111584194,
                    new SinglerealArray2MI
                    {
                        Id = 2111584194,
                        Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8460261f,

0.8707348f,

0.7030817f,

0.1949814f,

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

