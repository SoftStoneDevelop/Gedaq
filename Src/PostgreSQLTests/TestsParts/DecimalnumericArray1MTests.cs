

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
    internal partial interface IDecimalArraynumericArray
    {
    }
    
    internal partial class DecimalArraynumericArray : IDecimalArraynumericArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1mi(
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
            asPartInterface: typeof(IDecimalArraynumericArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1mi(
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
            queryMapType: typeof(DecimalnumericArray1MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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

                changedRows =  ((IDecimalArraynumericArray)this).InsertModelInner(connection, 989496829, 
new System.Decimal[4]
{
0.79538355099661m,

0.341420965783442m,

0.20182686144094m,

0.259105149616439m,

}, 
new System.Decimal[4]
{
0.647339101314374m,

0.880252315020077m,

0.620730900706259m,

0.266031950292111m,

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalArraynumericArray)this).InsertModelInner(connection, 2031459247, 
new System.Decimal[4]
{
0.988162986683755m,

0.946326933719384m,

0.105785481283932m,

0.457455767107011m,

}, 
new System.Decimal[4]
{
0.668178001735014m,

0.0261309955467016m,

0.109480344091357m,

0.937907531897102m,

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

                changedRows = await ((IDecimalArraynumericArray)this).InsertModelInnerAsync(connection, 1885056944, 
new System.Decimal[4]
{
0.568883731803848m,

0.494724047248429m,

0.626013261435883m,

0.688973982853637m,

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalArraynumericArray)this).InsertModelInnerAsync(connection, 229079168, 
new System.Decimal[3]
{
0.270041495025426m,

0.313447659801434m,

0.761609962736885m,

}, 
new System.Decimal[4]
{
0.631256212298377m,

0.900732747369461m,

0.0253447344957826m,

0.0605754462686936m,

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

                id =  ((IDecimalArraynumericArray)this).InsertModelInnerReturning(connection, 298762578, 
new System.Decimal[4]
{
0.780435546177952m,

0.927047629858877m,

0.845070163448652m,

0.0698609253832982m,

}, 
new System.Decimal[3]
{
0.347830774083804m,

0.258149875687242m,

0.640270661649344m,

});
                Assert.That(id, Is.EqualTo(298762578));

                id =  ((IDecimalArraynumericArray)this).InsertModelInnerReturning(connection, 1802070348, 
new System.Decimal[3]
{
0.500652392755636m,

0.856943238904947m,

0.249133800338953m,

}, null);
                Assert.That(id, Is.EqualTo(1802070348));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, 1798995844, 
new System.Decimal[3]
{
0.343122150810035m,

0.908817296072129m,

0.460561041119878m,

}, 
new System.Decimal[3]
{
0.43746426828906m,

0.462290235511666m,

0.174449967688479m,

});
                Assert.That(id, Is.EqualTo(1798995844));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, 984438229, 
new System.Decimal[3]
{
0.0741905663217527m,

0.268226072193604m,

0.318138234199345m,

}, null);
                Assert.That(id, Is.EqualTo(984438229));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, 309647647, 
new System.Decimal[3]
{
0.0223984689592726m,

0.741701985071582m,

0.506528439131137m,

}, null);
                Assert.That(id, Is.EqualTo(309647647));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, 109042517, 
new System.Decimal[3]
{
0.162812972763803m,

0.871473685385667m,

0.151976994708802m,

}, 
new System.Decimal[3]
{
0.0958054440869829m,

0.491548603531674m,

0.802813849544708m,

});
                Assert.That(id, Is.EqualTo(109042517));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, 376018751, 
new System.Decimal[3]
{
0.285284799320274m,

0.326008956423491m,

0.158336442848866m,

}, null);
                Assert.That(id, Is.EqualTo(376018751));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, 303286147, 
new System.Decimal[3]
{
0.289003967296092m,

0.230715463670717m,

0.634289943023537m,

}, 
new System.Decimal[3]
{
0.90430136229428m,

0.265520434230188m,

0.0882482286785835m,

});
                Assert.That(id, Is.EqualTo(303286147));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, 405219663, 
new System.Decimal[3]
{
0.814892888423264m,

0.644197589395732m,

0.1125124426437m,

}, 
new System.Decimal[4]
{
0.0235298466356579m,

0.70082263441205m,

0.115025107652443m,

0.673573885840338m,

});
                Assert.That(id, Is.EqualTo(405219663));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, 2107226176, 
new System.Decimal[4]
{
0.31300535562594m,

0.325076535243441m,

0.191975226437568m,

0.176069793339158m,

}, null);
                Assert.That(id, Is.EqualTo(2107226176));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, 659192782, 
new System.Decimal[4]
{
0.784408630596159m,

0.326590134732045m,

0.706748565407806m,

0.70714341538462m,

}, null);
                Assert.That(id, Is.EqualTo(659192782));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1m(
	id,
    value,
    nullablevalue,
    decimalnumericarray1mi_id
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
            asPartInterface: typeof(IDecimalArraynumericArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericarray1mi_id", 
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

                changedRows =  ((IDecimalArraynumericArray)this).InsertModel(connection, 1981519788, 
new System.Decimal[3]
{
0.379119266282213m,

0.880053419808111m,

0.513177856651464m,

}, 
new System.Decimal[4]
{
0.245584436378338m,

0.278630769588098m,

0.127043663851826m,

0.741955738302504m,

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalArraynumericArray)this).InsertModel(connection, 2047257074, 
new System.Decimal[4]
{
0.0932479255368816m,

0.0301833862224875m,

0.8564217528517m,

0.648511265153376m,

}, 
new System.Decimal[4]
{
0.757211961836031m,

0.516208897744666m,

0.351346746448164m,

0.302614769465853m,

}, 989496829);
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

                changedRows = await ((IDecimalArraynumericArray)this).InsertModelAsync(connection, 201464680, 
new System.Decimal[3]
{
0.463302337588417m,

0.370629662336532m,

0.548034257027467m,

}, 
new System.Decimal[3]
{
0.232929796134916m,

0.154055025465336m,

0.995804668768241m,

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalArraynumericArray)this).InsertModelAsync(connection, 704906698, 
new System.Decimal[4]
{
0.228357879737918m,

0.844292770150332m,

0.193605402427148m,

0.910272329050301m,

}, null, 2031459247);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[] nullable = null;

                nullable =  ((IDecimalArraynumericArray)this).ScalarInsertModelReturning(connection, 775147825, 
new System.Decimal[4]
{
0.786188446159501m,

0.468384468576442m,

0.0489489316706514m,

0.877494628915112m,

}, null, null);

                Assert.That(nullable, Is.Null);

                nullable =  ((IDecimalArraynumericArray)this).ScalarInsertModelReturning(connection, 475066646, 
new System.Decimal[4]
{
0.699533766733219m,

0.764632014886774m,

0.588266643055788m,

0.270395949931969m,

}, 
new System.Decimal[3]
{
0.744183241846793m,

0.193872558859702m,

0.611955518975458m,

}, 1885056944);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.744183241846793m,

0.193872558859702m,

0.611955518975458m,

}));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[] nullable = null;

                nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelReturningAsync(connection, 2026148453, 
new System.Decimal[3]
{
0.00175304556092548m,

0.219423357641208m,

0.454340333546278m,

}, 
new System.Decimal[4]
{
0.0143247803828197m,

0.228148089371708m,

0.255210017397057m,

0.752840241001218m,

}, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.0143247803828197m,

0.228148089371708m,

0.255210017397057m,

0.752840241001218m,

}));

                nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelReturningAsync(connection, 1024910545, 
new System.Decimal[4]
{
0.14261366059483m,

0.435990139492505m,

0.391420749560393m,

0.968772200172711m,

}, null, 229079168);

                Assert.That(nullable, Is.Null);

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1m(
	id,
    value,
    nullablevalue,
    decimalnumericarray1mi_id
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
    decimalnumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(DecimalnumericArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericarray1mi_id", 
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
                List<DecimalnumericArray1M> models = null;
                DecimalnumericArray1M model = null;

                models =  ((IDecimalArraynumericArray)this).InsertModelReturning(connection, 1360715309, 
new System.Decimal[3]
{
0.261908214215052m,

0.210654276471595m,

0.863478059064684m,

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1360715309));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.261908214215052m,

0.210654276471595m,

0.863478059064684m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDecimalArraynumericArray)this).InsertModelReturning(connection, 483348140, 
new System.Decimal[4]
{
0.235380630453438m,

0.826330004289329m,

0.680774771392299m,

0.624690250671274m,

}, null, 298762578).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(483348140));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.235380630453438m,

0.826330004289329m,

0.680774771392299m,

0.624690250671274m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(298762578));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IDecimalArraynumericArray)this).InsertModelReturning(connection, 159905071, 
new System.Decimal[3]
{
0.753839702305756m,

0.126667817766743m,

0.304093578349578m,

}, 
new System.Decimal[3]
{
0.449697430510138m,

0.765993015823156m,

0.905297705808181m,

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(159905071));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.753839702305756m,

0.126667817766743m,

0.304093578349578m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.449697430510138m,

0.765993015823156m,

0.905297705808181m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDecimalArraynumericArray)this).InsertModelReturning(connection, 1263340027, 
new System.Decimal[4]
{
0.114901119249173m,

0.835300182073698m,

0.862183024648071m,

0.928952987923253m,

}, null, 1802070348).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1263340027));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.114901119249173m,

0.835300182073698m,

0.862183024648071m,

0.928952987923253m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1802070348));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericArray1M> models = null;
                DecimalnumericArray1M model = null;

                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, 1773872135, 
new System.Decimal[4]
{
0.203369818001508m,

0.299211481277628m,

0.436804245520549m,

0.225472153906905m,

}, 
new System.Decimal[3]
{
0.720718131865731m,

0.400667968682213m,

0.0391147048915961m,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1773872135));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.203369818001508m,

0.299211481277628m,

0.436804245520549m,

0.225472153906905m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.720718131865731m,

0.400667968682213m,

0.0391147048915961m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, 959648092, 
new System.Decimal[3]
{
0.674600854216564m,

0.0588175653885267m,

0.693593299124215m,

}, null, 1798995844).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(959648092));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.674600854216564m,

0.0588175653885267m,

0.693593299124215m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1798995844));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, 2105850534, 
new System.Decimal[3]
{
0.879272623584438m,

0.997812462529447m,

0.102298079062808m,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2105850534));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.879272623584438m,

0.997812462529447m,

0.102298079062808m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, 451738282, 
new System.Decimal[4]
{
0.810837131956553m,

0.162300402571884m,

0.282674942099437m,

0.488846588453153m,

}, 
new System.Decimal[3]
{
0.921969052649128m,

0.605019690498457m,

0.798121603649053m,

}, 984438229).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(451738282));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.810837131956553m,

0.162300402571884m,

0.282674942099437m,

0.488846588453153m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.921969052649128m,

0.605019690498457m,

0.798121603649053m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(984438229));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, 1437077957, 
new System.Decimal[4]
{
0.00154420590750259m,

0.832397889829872m,

0.610334530115663m,

0.64418644840852m,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1437077957));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.00154420590750259m,

0.832397889829872m,

0.610334530115663m,

0.64418644840852m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, 43153943, 
new System.Decimal[4]
{
0.332300642589601m,

0.471643124100398m,

0.875514209342379m,

0.121027904813977m,

}, null, 309647647).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(43153943));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.332300642589601m,

0.471643124100398m,

0.875514209342379m,

0.121027904813977m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(309647647));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, 1015440465, 
new System.Decimal[3]
{
0.0442505885074315m,

0.171677856058679m,

0.822341341981591m,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1015440465));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0442505885074315m,

0.171677856058679m,

0.822341341981591m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, 1753210843, 
new System.Decimal[3]
{
0.916769772881913m,

0.567020781896476m,

0.9478835173479m,

}, 
new System.Decimal[4]
{
0.491122538690252m,

0.948238144075311m,

0.87346955182962m,

0.962893590471046m,

}, 109042517).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1753210843));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.916769772881913m,

0.567020781896476m,

0.9478835173479m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.491122538690252m,

0.948238144075311m,

0.87346955182962m,

0.962893590471046m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(109042517));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, 4472279, 
new System.Decimal[3]
{
0.670739165704255m,

0.115430150727337m,

0.77471262428668m,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(4472279));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.670739165704255m,

0.115430150727337m,

0.77471262428668m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, 1888346957, 
new System.Decimal[3]
{
0.655038384125233m,

0.494546225342795m,

0.214793000725172m,

}, 
new System.Decimal[4]
{
0.0170026041539578m,

0.749370461208432m,

0.0485792673212916m,

0.826584380369891m,

}, 376018751).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1888346957));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.655038384125233m,

0.494546225342795m,

0.214793000725172m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0170026041539578m,

0.749370461208432m,

0.0485792673212916m,

0.826584380369891m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(376018751));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, 1632277287, 
new System.Decimal[4]
{
0.740845423062099m,

0.192856443839841m,

0.676531163938029m,

0.745948700176557m,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1632277287));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.740845423062099m,

0.192856443839841m,

0.676531163938029m,

0.745948700176557m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, 305442937, 
new System.Decimal[3]
{
0.00442434600889063m,

0.708893704034158m,

0.695959329016357m,

}, 
new System.Decimal[3]
{
0.304236347756219m,

0.538940488013919m,

0.951903137544338m,

}, 303286147).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(305442937));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.00442434600889063m,

0.708893704034158m,

0.695959329016357m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.304236347756219m,

0.538940488013919m,

0.951903137544338m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(303286147));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, 306247634, 
new System.Decimal[4]
{
0.642302896448763m,

0.0939550411266639m,

0.396298884654832m,

0.544525438222112m,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(306247634));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.642302896448763m,

0.0939550411266639m,

0.396298884654832m,

0.544525438222112m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, 1070446321, 
new System.Decimal[3]
{
0.802858304233387m,

0.930211539843706m,

0.821987258143027m,

}, 
new System.Decimal[3]
{
0.524081989899844m,

0.344075670102832m,

0.130533397824908m,

}, 405219663).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1070446321));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.802858304233387m,

0.930211539843706m,

0.821987258143027m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.524081989899844m,

0.344075670102832m,

0.130533397824908m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(405219663));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, 988453307, 
new System.Decimal[3]
{
0.695013069422763m,

0.0683582645592904m,

0.202507903790901m,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(988453307));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.695013069422763m,

0.0683582645592904m,

0.202507903790901m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, 8800741, 
new System.Decimal[4]
{
0.198864665374831m,

0.286384074901691m,

0.683428746428832m,

0.895162087363908m,

}, null, 2107226176).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(8800741));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.198864665374831m,

0.286384074901691m,

0.683428746428832m,

0.895162087363908m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2107226176));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, 32000850, 
new System.Decimal[4]
{
0.913575567242658m,

0.0615614900869352m,

0.769869774161311m,

0.814376428327162m,

}, 
new System.Decimal[3]
{
0.421290647733418m,

0.255433137392199m,

0.363044360674116m,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(32000850));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.913575567242658m,

0.0615614900869352m,

0.769869774161311m,

0.814376428327162m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.421290647733418m,

0.255433137392199m,

0.363044360674116m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, 1271310123, 
new System.Decimal[3]
{
0.352818123681143m,

0.823590600574034m,

0.663864599075235m,

}, 
new System.Decimal[3]
{
0.0552213646435307m,

0.801008271562292m,

0.682693623617323m,

}, 659192782).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1271310123));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.352818123681143m,

0.823590600574034m,

0.663864599075235m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0552213646435307m,

0.801008271562292m,

0.682693623617323m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(659192782));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal[])default));
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
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(DecimalnumericArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)
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
                var models =  ((IDecimalArraynumericArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(4472279));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.670739165704255m,

0.115430150727337m,

0.77471262428668m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(8800741));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.198864665374831m,

0.286384074901691m,

0.683428746428832m,

0.895162087363908m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2107226176));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.31300535562594m,

0.325076535243441m,

0.191975226437568m,

0.176069793339158m,

};
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
                Assert.That(model.Id, Is.EqualTo(32000850));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.913575567242658m,

0.0615614900869352m,

0.769869774161311m,

0.814376428327162m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.421290647733418m,

0.255433137392199m,

0.363044360674116m,

};
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
                Assert.That(model.Id, Is.EqualTo(43153943));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.332300642589601m,

0.471643124100398m,

0.875514209342379m,

0.121027904813977m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(309647647));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0223984689592726m,

0.741701985071582m,

0.506528439131137m,

};
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
                Assert.That(model.Id, Is.EqualTo(159905071));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.753839702305756m,

0.126667817766743m,

0.304093578349578m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.449697430510138m,

0.765993015823156m,

0.905297705808181m,

};
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
                Assert.That(model.Id, Is.EqualTo(201464680));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.463302337588417m,

0.370629662336532m,

0.548034257027467m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.232929796134916m,

0.154055025465336m,

0.995804668768241m,

};
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
                Assert.That(model.Id, Is.EqualTo(305442937));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.00442434600889063m,

0.708893704034158m,

0.695959329016357m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.304236347756219m,

0.538940488013919m,

0.951903137544338m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(303286147));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.289003967296092m,

0.230715463670717m,

0.634289943023537m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.90430136229428m,

0.265520434230188m,

0.0882482286785835m,

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
                Assert.That(model.Id, Is.EqualTo(306247634));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.642302896448763m,

0.0939550411266639m,

0.396298884654832m,

0.544525438222112m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(451738282));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.810837131956553m,

0.162300402571884m,

0.282674942099437m,

0.488846588453153m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.921969052649128m,

0.605019690498457m,

0.798121603649053m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(984438229));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0741905663217527m,

0.268226072193604m,

0.318138234199345m,

};
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
                Assert.That(model.Id, Is.EqualTo(475066646));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.699533766733219m,

0.764632014886774m,

0.588266643055788m,

0.270395949931969m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.744183241846793m,

0.193872558859702m,

0.611955518975458m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1885056944));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.568883731803848m,

0.494724047248429m,

0.626013261435883m,

0.688973982853637m,

};
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
                Assert.That(model.Id, Is.EqualTo(483348140));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.235380630453438m,

0.826330004289329m,

0.680774771392299m,

0.624690250671274m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(298762578));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.780435546177952m,

0.927047629858877m,

0.845070163448652m,

0.0698609253832982m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.347830774083804m,

0.258149875687242m,

0.640270661649344m,

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
                Assert.That(model.Id, Is.EqualTo(704906698));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.228357879737918m,

0.844292770150332m,

0.193605402427148m,

0.910272329050301m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031459247));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.988162986683755m,

0.946326933719384m,

0.105785481283932m,

0.457455767107011m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.668178001735014m,

0.0261309955467016m,

0.109480344091357m,

0.937907531897102m,

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
                Assert.That(model.Id, Is.EqualTo(775147825));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.786188446159501m,

0.468384468576442m,

0.0489489316706514m,

0.877494628915112m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(959648092));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.674600854216564m,

0.0588175653885267m,

0.693593299124215m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1798995844));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.343122150810035m,

0.908817296072129m,

0.460561041119878m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.43746426828906m,

0.462290235511666m,

0.174449967688479m,

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
                Assert.That(model.Id, Is.EqualTo(988453307));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.695013069422763m,

0.0683582645592904m,

0.202507903790901m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1015440465));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0442505885074315m,

0.171677856058679m,

0.822341341981591m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1024910545));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.14261366059483m,

0.435990139492505m,

0.391420749560393m,

0.968772200172711m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(229079168));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.270041495025426m,

0.313447659801434m,

0.761609962736885m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.631256212298377m,

0.900732747369461m,

0.0253447344957826m,

0.0605754462686936m,

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
                Assert.That(model.Id, Is.EqualTo(1070446321));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.802858304233387m,

0.930211539843706m,

0.821987258143027m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.524081989899844m,

0.344075670102832m,

0.130533397824908m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(405219663));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.814892888423264m,

0.644197589395732m,

0.1125124426437m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0235298466356579m,

0.70082263441205m,

0.115025107652443m,

0.673573885840338m,

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
                Assert.That(model.Id, Is.EqualTo(1263340027));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.114901119249173m,

0.835300182073698m,

0.862183024648071m,

0.928952987923253m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1802070348));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.500652392755636m,

0.856943238904947m,

0.249133800338953m,

};
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
                Assert.That(model.Id, Is.EqualTo(1271310123));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.352818123681143m,

0.823590600574034m,

0.663864599075235m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0552213646435307m,

0.801008271562292m,

0.682693623617323m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(659192782));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.784408630596159m,

0.326590134732045m,

0.706748565407806m,

0.70714341538462m,

};
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
                Assert.That(model.Id, Is.EqualTo(1360715309));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.261908214215052m,

0.210654276471595m,

0.863478059064684m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1437077957));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.00154420590750259m,

0.832397889829872m,

0.610334530115663m,

0.64418644840852m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1632277287));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.740845423062099m,

0.192856443839841m,

0.676531163938029m,

0.745948700176557m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1753210843));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.916769772881913m,

0.567020781896476m,

0.9478835173479m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.491122538690252m,

0.948238144075311m,

0.87346955182962m,

0.962893590471046m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(109042517));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.162812972763803m,

0.871473685385667m,

0.151976994708802m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0958054440869829m,

0.491548603531674m,

0.802813849544708m,

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
                Assert.That(model.Id, Is.EqualTo(1773872135));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.203369818001508m,

0.299211481277628m,

0.436804245520549m,

0.225472153906905m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.720718131865731m,

0.400667968682213m,

0.0391147048915961m,

};
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
                Assert.That(model.Id, Is.EqualTo(1888346957));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.655038384125233m,

0.494546225342795m,

0.214793000725172m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0170026041539578m,

0.749370461208432m,

0.0485792673212916m,

0.826584380369891m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(376018751));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.285284799320274m,

0.326008956423491m,

0.158336442848866m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981519788));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.379119266282213m,

0.880053419808111m,

0.513177856651464m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.245584436378338m,

0.278630769588098m,

0.127043663851826m,

0.741955738302504m,

};
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
                Assert.That(model.Id, Is.EqualTo(2026148453));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.00175304556092548m,

0.219423357641208m,

0.454340333546278m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0143247803828197m,

0.228148089371708m,

0.255210017397057m,

0.752840241001218m,

};
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
                Assert.That(model.Id, Is.EqualTo(2047257074));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0932479255368816m,

0.0301833862224875m,

0.8564217528517m,

0.648511265153376m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.757211961836031m,

0.516208897744666m,

0.351346746448164m,

0.302614769465853m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(989496829));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.79538355099661m,

0.341420965783442m,

0.20182686144094m,

0.259105149616439m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.647339101314374m,

0.880252315020077m,

0.620730900706259m,

0.266031950292111m,

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
                Assert.That(model.Id, Is.EqualTo(2105850534));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.879272623584438m,

0.997812462529447m,

0.102298079062808m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                var models = await ((IDecimalArraynumericArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(4472279));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.670739165704255m,

0.115430150727337m,

0.77471262428668m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(8800741));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.198864665374831m,

0.286384074901691m,

0.683428746428832m,

0.895162087363908m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2107226176));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.31300535562594m,

0.325076535243441m,

0.191975226437568m,

0.176069793339158m,

};
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
                Assert.That(model.Id, Is.EqualTo(32000850));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.913575567242658m,

0.0615614900869352m,

0.769869774161311m,

0.814376428327162m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.421290647733418m,

0.255433137392199m,

0.363044360674116m,

};
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
                Assert.That(model.Id, Is.EqualTo(43153943));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.332300642589601m,

0.471643124100398m,

0.875514209342379m,

0.121027904813977m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(309647647));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0223984689592726m,

0.741701985071582m,

0.506528439131137m,

};
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
                Assert.That(model.Id, Is.EqualTo(159905071));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.753839702305756m,

0.126667817766743m,

0.304093578349578m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.449697430510138m,

0.765993015823156m,

0.905297705808181m,

};
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
                Assert.That(model.Id, Is.EqualTo(201464680));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.463302337588417m,

0.370629662336532m,

0.548034257027467m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.232929796134916m,

0.154055025465336m,

0.995804668768241m,

};
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
                Assert.That(model.Id, Is.EqualTo(305442937));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.00442434600889063m,

0.708893704034158m,

0.695959329016357m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.304236347756219m,

0.538940488013919m,

0.951903137544338m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(303286147));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.289003967296092m,

0.230715463670717m,

0.634289943023537m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.90430136229428m,

0.265520434230188m,

0.0882482286785835m,

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
                Assert.That(model.Id, Is.EqualTo(306247634));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.642302896448763m,

0.0939550411266639m,

0.396298884654832m,

0.544525438222112m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(451738282));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.810837131956553m,

0.162300402571884m,

0.282674942099437m,

0.488846588453153m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.921969052649128m,

0.605019690498457m,

0.798121603649053m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(984438229));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0741905663217527m,

0.268226072193604m,

0.318138234199345m,

};
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
                Assert.That(model.Id, Is.EqualTo(475066646));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.699533766733219m,

0.764632014886774m,

0.588266643055788m,

0.270395949931969m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.744183241846793m,

0.193872558859702m,

0.611955518975458m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1885056944));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.568883731803848m,

0.494724047248429m,

0.626013261435883m,

0.688973982853637m,

};
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
                Assert.That(model.Id, Is.EqualTo(483348140));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.235380630453438m,

0.826330004289329m,

0.680774771392299m,

0.624690250671274m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(298762578));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.780435546177952m,

0.927047629858877m,

0.845070163448652m,

0.0698609253832982m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.347830774083804m,

0.258149875687242m,

0.640270661649344m,

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
                Assert.That(model.Id, Is.EqualTo(704906698));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.228357879737918m,

0.844292770150332m,

0.193605402427148m,

0.910272329050301m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031459247));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.988162986683755m,

0.946326933719384m,

0.105785481283932m,

0.457455767107011m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.668178001735014m,

0.0261309955467016m,

0.109480344091357m,

0.937907531897102m,

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
                Assert.That(model.Id, Is.EqualTo(775147825));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.786188446159501m,

0.468384468576442m,

0.0489489316706514m,

0.877494628915112m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(959648092));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.674600854216564m,

0.0588175653885267m,

0.693593299124215m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1798995844));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.343122150810035m,

0.908817296072129m,

0.460561041119878m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.43746426828906m,

0.462290235511666m,

0.174449967688479m,

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
                Assert.That(model.Id, Is.EqualTo(988453307));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.695013069422763m,

0.0683582645592904m,

0.202507903790901m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1015440465));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0442505885074315m,

0.171677856058679m,

0.822341341981591m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1024910545));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.14261366059483m,

0.435990139492505m,

0.391420749560393m,

0.968772200172711m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(229079168));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.270041495025426m,

0.313447659801434m,

0.761609962736885m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.631256212298377m,

0.900732747369461m,

0.0253447344957826m,

0.0605754462686936m,

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
                Assert.That(model.Id, Is.EqualTo(1070446321));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.802858304233387m,

0.930211539843706m,

0.821987258143027m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.524081989899844m,

0.344075670102832m,

0.130533397824908m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(405219663));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.814892888423264m,

0.644197589395732m,

0.1125124426437m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0235298466356579m,

0.70082263441205m,

0.115025107652443m,

0.673573885840338m,

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
                Assert.That(model.Id, Is.EqualTo(1263340027));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.114901119249173m,

0.835300182073698m,

0.862183024648071m,

0.928952987923253m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1802070348));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.500652392755636m,

0.856943238904947m,

0.249133800338953m,

};
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
                Assert.That(model.Id, Is.EqualTo(1271310123));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.352818123681143m,

0.823590600574034m,

0.663864599075235m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0552213646435307m,

0.801008271562292m,

0.682693623617323m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(659192782));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.784408630596159m,

0.326590134732045m,

0.706748565407806m,

0.70714341538462m,

};
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
                Assert.That(model.Id, Is.EqualTo(1360715309));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.261908214215052m,

0.210654276471595m,

0.863478059064684m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1437077957));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.00154420590750259m,

0.832397889829872m,

0.610334530115663m,

0.64418644840852m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1632277287));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.740845423062099m,

0.192856443839841m,

0.676531163938029m,

0.745948700176557m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1753210843));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.916769772881913m,

0.567020781896476m,

0.9478835173479m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.491122538690252m,

0.948238144075311m,

0.87346955182962m,

0.962893590471046m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(109042517));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.162812972763803m,

0.871473685385667m,

0.151976994708802m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0958054440869829m,

0.491548603531674m,

0.802813849544708m,

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
                Assert.That(model.Id, Is.EqualTo(1773872135));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.203369818001508m,

0.299211481277628m,

0.436804245520549m,

0.225472153906905m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.720718131865731m,

0.400667968682213m,

0.0391147048915961m,

};
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
                Assert.That(model.Id, Is.EqualTo(1888346957));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.655038384125233m,

0.494546225342795m,

0.214793000725172m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0170026041539578m,

0.749370461208432m,

0.0485792673212916m,

0.826584380369891m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(376018751));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.285284799320274m,

0.326008956423491m,

0.158336442848866m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981519788));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.379119266282213m,

0.880053419808111m,

0.513177856651464m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.245584436378338m,

0.278630769588098m,

0.127043663851826m,

0.741955738302504m,

};
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
                Assert.That(model.Id, Is.EqualTo(2026148453));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.00175304556092548m,

0.219423357641208m,

0.454340333546278m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0143247803828197m,

0.228148089371708m,

0.255210017397057m,

0.752840241001218m,

};
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
                Assert.That(model.Id, Is.EqualTo(2047257074));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0932479255368816m,

0.0301833862224875m,

0.8564217528517m,

0.648511265153376m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.757211961836031m,

0.516208897744666m,

0.351346746448164m,

0.302614769465853m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(989496829));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.79538355099661m,

0.341420965783442m,

0.20182686144094m,

0.259105149616439m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.647339101314374m,

0.880252315020077m,

0.620730900706259m,

0.266031950292111m,

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
                Assert.That(model.Id, Is.EqualTo(2105850534));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.879272623584438m,

0.997812462529447m,

0.102298079062808m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(DecimalnumericArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)
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
                var models =  ((IDecimalArraynumericArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(4472279));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.670739165704255m,

0.115430150727337m,

0.77471262428668m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(8800741));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.198864665374831m,

0.286384074901691m,

0.683428746428832m,

0.895162087363908m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2107226176));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.31300535562594m,

0.325076535243441m,

0.191975226437568m,

0.176069793339158m,

};
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
                Assert.That(model.Id, Is.EqualTo(32000850));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.913575567242658m,

0.0615614900869352m,

0.769869774161311m,

0.814376428327162m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.421290647733418m,

0.255433137392199m,

0.363044360674116m,

};
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
                Assert.That(model.Id, Is.EqualTo(43153943));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.332300642589601m,

0.471643124100398m,

0.875514209342379m,

0.121027904813977m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(309647647));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0223984689592726m,

0.741701985071582m,

0.506528439131137m,

};
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
                Assert.That(model.Id, Is.EqualTo(159905071));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.753839702305756m,

0.126667817766743m,

0.304093578349578m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.449697430510138m,

0.765993015823156m,

0.905297705808181m,

};
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
                Assert.That(model.Id, Is.EqualTo(201464680));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.463302337588417m,

0.370629662336532m,

0.548034257027467m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.232929796134916m,

0.154055025465336m,

0.995804668768241m,

};
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
                Assert.That(model.Id, Is.EqualTo(305442937));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.00442434600889063m,

0.708893704034158m,

0.695959329016357m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.304236347756219m,

0.538940488013919m,

0.951903137544338m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(303286147));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.289003967296092m,

0.230715463670717m,

0.634289943023537m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.90430136229428m,

0.265520434230188m,

0.0882482286785835m,

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
                Assert.That(model.Id, Is.EqualTo(306247634));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.642302896448763m,

0.0939550411266639m,

0.396298884654832m,

0.544525438222112m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(451738282));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.810837131956553m,

0.162300402571884m,

0.282674942099437m,

0.488846588453153m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.921969052649128m,

0.605019690498457m,

0.798121603649053m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(984438229));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0741905663217527m,

0.268226072193604m,

0.318138234199345m,

};
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
                Assert.That(model.Id, Is.EqualTo(475066646));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.699533766733219m,

0.764632014886774m,

0.588266643055788m,

0.270395949931969m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.744183241846793m,

0.193872558859702m,

0.611955518975458m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1885056944));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.568883731803848m,

0.494724047248429m,

0.626013261435883m,

0.688973982853637m,

};
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
                Assert.That(model.Id, Is.EqualTo(483348140));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.235380630453438m,

0.826330004289329m,

0.680774771392299m,

0.624690250671274m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(298762578));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.780435546177952m,

0.927047629858877m,

0.845070163448652m,

0.0698609253832982m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.347830774083804m,

0.258149875687242m,

0.640270661649344m,

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
                Assert.That(model.Id, Is.EqualTo(704906698));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.228357879737918m,

0.844292770150332m,

0.193605402427148m,

0.910272329050301m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031459247));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.988162986683755m,

0.946326933719384m,

0.105785481283932m,

0.457455767107011m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.668178001735014m,

0.0261309955467016m,

0.109480344091357m,

0.937907531897102m,

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
                Assert.That(model.Id, Is.EqualTo(775147825));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.786188446159501m,

0.468384468576442m,

0.0489489316706514m,

0.877494628915112m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(959648092));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.674600854216564m,

0.0588175653885267m,

0.693593299124215m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1798995844));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.343122150810035m,

0.908817296072129m,

0.460561041119878m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.43746426828906m,

0.462290235511666m,

0.174449967688479m,

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
                Assert.That(model.Id, Is.EqualTo(988453307));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.695013069422763m,

0.0683582645592904m,

0.202507903790901m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1015440465));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0442505885074315m,

0.171677856058679m,

0.822341341981591m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1024910545));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.14261366059483m,

0.435990139492505m,

0.391420749560393m,

0.968772200172711m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(229079168));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.270041495025426m,

0.313447659801434m,

0.761609962736885m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.631256212298377m,

0.900732747369461m,

0.0253447344957826m,

0.0605754462686936m,

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
                Assert.That(model.Id, Is.EqualTo(1070446321));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.802858304233387m,

0.930211539843706m,

0.821987258143027m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.524081989899844m,

0.344075670102832m,

0.130533397824908m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(405219663));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.814892888423264m,

0.644197589395732m,

0.1125124426437m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0235298466356579m,

0.70082263441205m,

0.115025107652443m,

0.673573885840338m,

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
                Assert.That(model.Id, Is.EqualTo(1263340027));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.114901119249173m,

0.835300182073698m,

0.862183024648071m,

0.928952987923253m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1802070348));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.500652392755636m,

0.856943238904947m,

0.249133800338953m,

};
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
                Assert.That(model.Id, Is.EqualTo(1271310123));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.352818123681143m,

0.823590600574034m,

0.663864599075235m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0552213646435307m,

0.801008271562292m,

0.682693623617323m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(659192782));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.784408630596159m,

0.326590134732045m,

0.706748565407806m,

0.70714341538462m,

};
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
                Assert.That(model.Id, Is.EqualTo(1360715309));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.261908214215052m,

0.210654276471595m,

0.863478059064684m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1437077957));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.00154420590750259m,

0.832397889829872m,

0.610334530115663m,

0.64418644840852m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1632277287));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.740845423062099m,

0.192856443839841m,

0.676531163938029m,

0.745948700176557m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1753210843));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.916769772881913m,

0.567020781896476m,

0.9478835173479m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.491122538690252m,

0.948238144075311m,

0.87346955182962m,

0.962893590471046m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(109042517));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.162812972763803m,

0.871473685385667m,

0.151976994708802m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0958054440869829m,

0.491548603531674m,

0.802813849544708m,

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
                Assert.That(model.Id, Is.EqualTo(1773872135));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.203369818001508m,

0.299211481277628m,

0.436804245520549m,

0.225472153906905m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.720718131865731m,

0.400667968682213m,

0.0391147048915961m,

};
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
                Assert.That(model.Id, Is.EqualTo(1888346957));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.655038384125233m,

0.494546225342795m,

0.214793000725172m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0170026041539578m,

0.749370461208432m,

0.0485792673212916m,

0.826584380369891m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(376018751));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.285284799320274m,

0.326008956423491m,

0.158336442848866m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981519788));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.379119266282213m,

0.880053419808111m,

0.513177856651464m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.245584436378338m,

0.278630769588098m,

0.127043663851826m,

0.741955738302504m,

};
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
                Assert.That(model.Id, Is.EqualTo(2026148453));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.00175304556092548m,

0.219423357641208m,

0.454340333546278m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0143247803828197m,

0.228148089371708m,

0.255210017397057m,

0.752840241001218m,

};
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
                Assert.That(model.Id, Is.EqualTo(2047257074));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0932479255368816m,

0.0301833862224875m,

0.8564217528517m,

0.648511265153376m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.757211961836031m,

0.516208897744666m,

0.351346746448164m,

0.302614769465853m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(989496829));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.79538355099661m,

0.341420965783442m,

0.20182686144094m,

0.259105149616439m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.647339101314374m,

0.880252315020077m,

0.620730900706259m,

0.266031950292111m,

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
                Assert.That(model.Id, Is.EqualTo(2105850534));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.879272623584438m,

0.997812462529447m,

0.102298079062808m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                var models = await ((IDecimalArraynumericArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(4472279));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.670739165704255m,

0.115430150727337m,

0.77471262428668m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(8800741));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.198864665374831m,

0.286384074901691m,

0.683428746428832m,

0.895162087363908m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2107226176));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.31300535562594m,

0.325076535243441m,

0.191975226437568m,

0.176069793339158m,

};
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
                Assert.That(model.Id, Is.EqualTo(32000850));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.913575567242658m,

0.0615614900869352m,

0.769869774161311m,

0.814376428327162m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.421290647733418m,

0.255433137392199m,

0.363044360674116m,

};
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
                Assert.That(model.Id, Is.EqualTo(43153943));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.332300642589601m,

0.471643124100398m,

0.875514209342379m,

0.121027904813977m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(309647647));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0223984689592726m,

0.741701985071582m,

0.506528439131137m,

};
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
                Assert.That(model.Id, Is.EqualTo(159905071));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.753839702305756m,

0.126667817766743m,

0.304093578349578m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.449697430510138m,

0.765993015823156m,

0.905297705808181m,

};
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
                Assert.That(model.Id, Is.EqualTo(201464680));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.463302337588417m,

0.370629662336532m,

0.548034257027467m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.232929796134916m,

0.154055025465336m,

0.995804668768241m,

};
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
                Assert.That(model.Id, Is.EqualTo(305442937));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.00442434600889063m,

0.708893704034158m,

0.695959329016357m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.304236347756219m,

0.538940488013919m,

0.951903137544338m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(303286147));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.289003967296092m,

0.230715463670717m,

0.634289943023537m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.90430136229428m,

0.265520434230188m,

0.0882482286785835m,

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
                Assert.That(model.Id, Is.EqualTo(306247634));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.642302896448763m,

0.0939550411266639m,

0.396298884654832m,

0.544525438222112m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(451738282));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.810837131956553m,

0.162300402571884m,

0.282674942099437m,

0.488846588453153m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.921969052649128m,

0.605019690498457m,

0.798121603649053m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(984438229));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0741905663217527m,

0.268226072193604m,

0.318138234199345m,

};
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
                Assert.That(model.Id, Is.EqualTo(475066646));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.699533766733219m,

0.764632014886774m,

0.588266643055788m,

0.270395949931969m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.744183241846793m,

0.193872558859702m,

0.611955518975458m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1885056944));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.568883731803848m,

0.494724047248429m,

0.626013261435883m,

0.688973982853637m,

};
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
                Assert.That(model.Id, Is.EqualTo(483348140));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.235380630453438m,

0.826330004289329m,

0.680774771392299m,

0.624690250671274m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(298762578));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.780435546177952m,

0.927047629858877m,

0.845070163448652m,

0.0698609253832982m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.347830774083804m,

0.258149875687242m,

0.640270661649344m,

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
                Assert.That(model.Id, Is.EqualTo(704906698));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.228357879737918m,

0.844292770150332m,

0.193605402427148m,

0.910272329050301m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031459247));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.988162986683755m,

0.946326933719384m,

0.105785481283932m,

0.457455767107011m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.668178001735014m,

0.0261309955467016m,

0.109480344091357m,

0.937907531897102m,

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
                Assert.That(model.Id, Is.EqualTo(775147825));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.786188446159501m,

0.468384468576442m,

0.0489489316706514m,

0.877494628915112m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(959648092));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.674600854216564m,

0.0588175653885267m,

0.693593299124215m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1798995844));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.343122150810035m,

0.908817296072129m,

0.460561041119878m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.43746426828906m,

0.462290235511666m,

0.174449967688479m,

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
                Assert.That(model.Id, Is.EqualTo(988453307));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.695013069422763m,

0.0683582645592904m,

0.202507903790901m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1015440465));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0442505885074315m,

0.171677856058679m,

0.822341341981591m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1024910545));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.14261366059483m,

0.435990139492505m,

0.391420749560393m,

0.968772200172711m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(229079168));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.270041495025426m,

0.313447659801434m,

0.761609962736885m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.631256212298377m,

0.900732747369461m,

0.0253447344957826m,

0.0605754462686936m,

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
                Assert.That(model.Id, Is.EqualTo(1070446321));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.802858304233387m,

0.930211539843706m,

0.821987258143027m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.524081989899844m,

0.344075670102832m,

0.130533397824908m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(405219663));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.814892888423264m,

0.644197589395732m,

0.1125124426437m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0235298466356579m,

0.70082263441205m,

0.115025107652443m,

0.673573885840338m,

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
                Assert.That(model.Id, Is.EqualTo(1263340027));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.114901119249173m,

0.835300182073698m,

0.862183024648071m,

0.928952987923253m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1802070348));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.500652392755636m,

0.856943238904947m,

0.249133800338953m,

};
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
                Assert.That(model.Id, Is.EqualTo(1271310123));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.352818123681143m,

0.823590600574034m,

0.663864599075235m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0552213646435307m,

0.801008271562292m,

0.682693623617323m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(659192782));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.784408630596159m,

0.326590134732045m,

0.706748565407806m,

0.70714341538462m,

};
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
                Assert.That(model.Id, Is.EqualTo(1360715309));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.261908214215052m,

0.210654276471595m,

0.863478059064684m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1437077957));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.00154420590750259m,

0.832397889829872m,

0.610334530115663m,

0.64418644840852m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1632277287));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.740845423062099m,

0.192856443839841m,

0.676531163938029m,

0.745948700176557m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1753210843));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.916769772881913m,

0.567020781896476m,

0.9478835173479m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.491122538690252m,

0.948238144075311m,

0.87346955182962m,

0.962893590471046m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(109042517));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.162812972763803m,

0.871473685385667m,

0.151976994708802m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0958054440869829m,

0.491548603531674m,

0.802813849544708m,

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
                Assert.That(model.Id, Is.EqualTo(1773872135));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.203369818001508m,

0.299211481277628m,

0.436804245520549m,

0.225472153906905m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.720718131865731m,

0.400667968682213m,

0.0391147048915961m,

};
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
                Assert.That(model.Id, Is.EqualTo(1888346957));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.655038384125233m,

0.494546225342795m,

0.214793000725172m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0170026041539578m,

0.749370461208432m,

0.0485792673212916m,

0.826584380369891m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(376018751));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.285284799320274m,

0.326008956423491m,

0.158336442848866m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981519788));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.379119266282213m,

0.880053419808111m,

0.513177856651464m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.245584436378338m,

0.278630769588098m,

0.127043663851826m,

0.741955738302504m,

};
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
                Assert.That(model.Id, Is.EqualTo(2026148453));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.00175304556092548m,

0.219423357641208m,

0.454340333546278m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0143247803828197m,

0.228148089371708m,

0.255210017397057m,

0.752840241001218m,

};
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
                Assert.That(model.Id, Is.EqualTo(2047257074));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0932479255368816m,

0.0301833862224875m,

0.8564217528517m,

0.648511265153376m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.757211961836031m,

0.516208897744666m,

0.351346746448164m,

0.302614769465853m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(989496829));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.79538355099661m,

0.341420965783442m,

0.20182686144094m,

0.259105149616439m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.647339101314374m,

0.880252315020077m,

0.620730900706259m,

0.266031950292111m,

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
                Assert.That(model.Id, Is.EqualTo(2105850534));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.879272623584438m,

0.997812462529447m,

0.102298079062808m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                 using var cmd =  ((IDecimalArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 1024910545);
                var models =  ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(13));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1070446321));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.802858304233387m,

0.930211539843706m,

0.821987258143027m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.524081989899844m,

0.344075670102832m,

0.130533397824908m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(405219663));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.814892888423264m,

0.644197589395732m,

0.1125124426437m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0235298466356579m,

0.70082263441205m,

0.115025107652443m,

0.673573885840338m,

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
                Assert.That(model.Id, Is.EqualTo(1263340027));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.114901119249173m,

0.835300182073698m,

0.862183024648071m,

0.928952987923253m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1802070348));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.500652392755636m,

0.856943238904947m,

0.249133800338953m,

};
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
                Assert.That(model.Id, Is.EqualTo(1271310123));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.352818123681143m,

0.823590600574034m,

0.663864599075235m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0552213646435307m,

0.801008271562292m,

0.682693623617323m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(659192782));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.784408630596159m,

0.326590134732045m,

0.706748565407806m,

0.70714341538462m,

};
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
                Assert.That(model.Id, Is.EqualTo(1360715309));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.261908214215052m,

0.210654276471595m,

0.863478059064684m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1437077957));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.00154420590750259m,

0.832397889829872m,

0.610334530115663m,

0.64418644840852m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1632277287));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.740845423062099m,

0.192856443839841m,

0.676531163938029m,

0.745948700176557m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1753210843));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.916769772881913m,

0.567020781896476m,

0.9478835173479m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.491122538690252m,

0.948238144075311m,

0.87346955182962m,

0.962893590471046m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(109042517));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.162812972763803m,

0.871473685385667m,

0.151976994708802m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0958054440869829m,

0.491548603531674m,

0.802813849544708m,

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
                Assert.That(model.Id, Is.EqualTo(1773872135));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.203369818001508m,

0.299211481277628m,

0.436804245520549m,

0.225472153906905m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.720718131865731m,

0.400667968682213m,

0.0391147048915961m,

};
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
                Assert.That(model.Id, Is.EqualTo(1888346957));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.655038384125233m,

0.494546225342795m,

0.214793000725172m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0170026041539578m,

0.749370461208432m,

0.0485792673212916m,

0.826584380369891m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(376018751));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.285284799320274m,

0.326008956423491m,

0.158336442848866m,

};
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
                Assert.That(model.Id, Is.EqualTo(1981519788));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.379119266282213m,

0.880053419808111m,

0.513177856651464m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.245584436378338m,

0.278630769588098m,

0.127043663851826m,

0.741955738302504m,

};
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
                Assert.That(model.Id, Is.EqualTo(2026148453));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.00175304556092548m,

0.219423357641208m,

0.454340333546278m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0143247803828197m,

0.228148089371708m,

0.255210017397057m,

0.752840241001218m,

};
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
                Assert.That(model.Id, Is.EqualTo(2047257074));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0932479255368816m,

0.0301833862224875m,

0.8564217528517m,

0.648511265153376m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.757211961836031m,

0.516208897744666m,

0.351346746448164m,

0.302614769465853m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(989496829));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.79538355099661m,

0.341420965783442m,

0.20182686144094m,

0.259105149616439m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.647339101314374m,

0.880252315020077m,

0.620730900706259m,

0.266031950292111m,

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
                Assert.That(model.Id, Is.EqualTo(2105850534));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.879272623584438m,

0.997812462529447m,

0.102298079062808m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                await using var cmd = await ((IDecimalArraynumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 1263340027);
                var models = await ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(11));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1271310123));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.352818123681143m,

0.823590600574034m,

0.663864599075235m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0552213646435307m,

0.801008271562292m,

0.682693623617323m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(659192782));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.784408630596159m,

0.326590134732045m,

0.706748565407806m,

0.70714341538462m,

};
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
                Assert.That(model.Id, Is.EqualTo(1360715309));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.261908214215052m,

0.210654276471595m,

0.863478059064684m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1437077957));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.00154420590750259m,

0.832397889829872m,

0.610334530115663m,

0.64418644840852m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1632277287));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.740845423062099m,

0.192856443839841m,

0.676531163938029m,

0.745948700176557m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1753210843));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.916769772881913m,

0.567020781896476m,

0.9478835173479m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.491122538690252m,

0.948238144075311m,

0.87346955182962m,

0.962893590471046m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(109042517));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.162812972763803m,

0.871473685385667m,

0.151976994708802m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0958054440869829m,

0.491548603531674m,

0.802813849544708m,

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
                Assert.That(model.Id, Is.EqualTo(1773872135));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.203369818001508m,

0.299211481277628m,

0.436804245520549m,

0.225472153906905m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.720718131865731m,

0.400667968682213m,

0.0391147048915961m,

};
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
                Assert.That(model.Id, Is.EqualTo(1888346957));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.655038384125233m,

0.494546225342795m,

0.214793000725172m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0170026041539578m,

0.749370461208432m,

0.0485792673212916m,

0.826584380369891m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(376018751));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.285284799320274m,

0.326008956423491m,

0.158336442848866m,

};
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
                Assert.That(model.Id, Is.EqualTo(1981519788));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.379119266282213m,

0.880053419808111m,

0.513177856651464m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.245584436378338m,

0.278630769588098m,

0.127043663851826m,

0.741955738302504m,

};
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
                Assert.That(model.Id, Is.EqualTo(2026148453));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.00175304556092548m,

0.219423357641208m,

0.454340333546278m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0143247803828197m,

0.228148089371708m,

0.255210017397057m,

0.752840241001218m,

};
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
                Assert.That(model.Id, Is.EqualTo(2047257074));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0932479255368816m,

0.0301833862224875m,

0.8564217528517m,

0.648511265153376m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.757211961836031m,

0.516208897744666m,

0.351346746448164m,

0.302614769465853m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(989496829));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.79538355099661m,

0.341420965783442m,

0.20182686144094m,

0.259105149616439m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.647339101314374m,

0.880252315020077m,

0.620730900706259m,

0.266031950292111m,

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
                Assert.That(model.Id, Is.EqualTo(2105850534));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.879272623584438m,

0.997812462529447m,

0.102298079062808m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
            asPartInterface: typeof(IDecimalArraynumericArray)
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
                 foreach(var batchResult in ((IDecimalArraynumericArray)this).DbConnectionSelectModelBatch(connection, 1437077957, 704906698))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(8));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1632277287));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.740845423062099m,

0.192856443839841m,

0.676531163938029m,

0.745948700176557m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1753210843));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.916769772881913m,

0.567020781896476m,

0.9478835173479m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.491122538690252m,

0.948238144075311m,

0.87346955182962m,

0.962893590471046m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(109042517));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.162812972763803m,

0.871473685385667m,

0.151976994708802m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0958054440869829m,

0.491548603531674m,

0.802813849544708m,

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
                Assert.That(model.Id, Is.EqualTo(1773872135));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.203369818001508m,

0.299211481277628m,

0.436804245520549m,

0.225472153906905m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.720718131865731m,

0.400667968682213m,

0.0391147048915961m,

};
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
                Assert.That(model.Id, Is.EqualTo(1888346957));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.655038384125233m,

0.494546225342795m,

0.214793000725172m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0170026041539578m,

0.749370461208432m,

0.0485792673212916m,

0.826584380369891m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(376018751));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.285284799320274m,

0.326008956423491m,

0.158336442848866m,

};
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
                Assert.That(model.Id, Is.EqualTo(1981519788));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.379119266282213m,

0.880053419808111m,

0.513177856651464m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.245584436378338m,

0.278630769588098m,

0.127043663851826m,

0.741955738302504m,

};
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
                Assert.That(model.Id, Is.EqualTo(2026148453));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.00175304556092548m,

0.219423357641208m,

0.454340333546278m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0143247803828197m,

0.228148089371708m,

0.255210017397057m,

0.752840241001218m,

};
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
                Assert.That(model.Id, Is.EqualTo(2047257074));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0932479255368816m,

0.0301833862224875m,

0.8564217528517m,

0.648511265153376m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.757211961836031m,

0.516208897744666m,

0.351346746448164m,

0.302614769465853m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(989496829));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.79538355099661m,

0.341420965783442m,

0.20182686144094m,

0.259105149616439m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.647339101314374m,

0.880252315020077m,

0.620730900706259m,

0.266031950292111m,

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
                Assert.That(model.Id, Is.EqualTo(2105850534));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.879272623584438m,

0.997812462529447m,

0.102298079062808m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(775147825));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.786188446159501m,

0.468384468576442m,

0.0489489316706514m,

0.877494628915112m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(959648092));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.674600854216564m,

0.0588175653885267m,

0.693593299124215m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1798995844));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.343122150810035m,

0.908817296072129m,

0.460561041119878m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.43746426828906m,

0.462290235511666m,

0.174449967688479m,

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
                Assert.That(model.Id, Is.EqualTo(988453307));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.695013069422763m,

0.0683582645592904m,

0.202507903790901m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1015440465));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0442505885074315m,

0.171677856058679m,

0.822341341981591m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1024910545));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.14261366059483m,

0.435990139492505m,

0.391420749560393m,

0.968772200172711m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(229079168));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.270041495025426m,

0.313447659801434m,

0.761609962736885m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.631256212298377m,

0.900732747369461m,

0.0253447344957826m,

0.0605754462686936m,

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
                Assert.That(model.Id, Is.EqualTo(1070446321));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.802858304233387m,

0.930211539843706m,

0.821987258143027m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.524081989899844m,

0.344075670102832m,

0.130533397824908m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(405219663));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.814892888423264m,

0.644197589395732m,

0.1125124426437m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0235298466356579m,

0.70082263441205m,

0.115025107652443m,

0.673573885840338m,

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
                Assert.That(model.Id, Is.EqualTo(1263340027));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.114901119249173m,

0.835300182073698m,

0.862183024648071m,

0.928952987923253m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1802070348));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.500652392755636m,

0.856943238904947m,

0.249133800338953m,

};
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
                Assert.That(model.Id, Is.EqualTo(1271310123));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.352818123681143m,

0.823590600574034m,

0.663864599075235m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0552213646435307m,

0.801008271562292m,

0.682693623617323m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(659192782));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.784408630596159m,

0.326590134732045m,

0.706748565407806m,

0.70714341538462m,

};
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
                Assert.That(model.Id, Is.EqualTo(1360715309));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.261908214215052m,

0.210654276471595m,

0.863478059064684m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1437077957));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.00154420590750259m,

0.832397889829872m,

0.610334530115663m,

0.64418644840852m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1632277287));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.740845423062099m,

0.192856443839841m,

0.676531163938029m,

0.745948700176557m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1753210843));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.916769772881913m,

0.567020781896476m,

0.9478835173479m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.491122538690252m,

0.948238144075311m,

0.87346955182962m,

0.962893590471046m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(109042517));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.162812972763803m,

0.871473685385667m,

0.151976994708802m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0958054440869829m,

0.491548603531674m,

0.802813849544708m,

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
                Assert.That(model.Id, Is.EqualTo(1773872135));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.203369818001508m,

0.299211481277628m,

0.436804245520549m,

0.225472153906905m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.720718131865731m,

0.400667968682213m,

0.0391147048915961m,

};
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
                Assert.That(model.Id, Is.EqualTo(1888346957));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.655038384125233m,

0.494546225342795m,

0.214793000725172m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0170026041539578m,

0.749370461208432m,

0.0485792673212916m,

0.826584380369891m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(376018751));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.285284799320274m,

0.326008956423491m,

0.158336442848866m,

};
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
                Assert.That(model.Id, Is.EqualTo(1981519788));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.379119266282213m,

0.880053419808111m,

0.513177856651464m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.245584436378338m,

0.278630769588098m,

0.127043663851826m,

0.741955738302504m,

};
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
                Assert.That(model.Id, Is.EqualTo(2026148453));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.00175304556092548m,

0.219423357641208m,

0.454340333546278m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0143247803828197m,

0.228148089371708m,

0.255210017397057m,

0.752840241001218m,

};
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
                Assert.That(model.Id, Is.EqualTo(2047257074));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0932479255368816m,

0.0301833862224875m,

0.8564217528517m,

0.648511265153376m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.757211961836031m,

0.516208897744666m,

0.351346746448164m,

0.302614769465853m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(989496829));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.79538355099661m,

0.341420965783442m,

0.20182686144094m,

0.259105149616439m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.647339101314374m,

0.880252315020077m,

0.620730900706259m,

0.266031950292111m,

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
                Assert.That(model.Id, Is.EqualTo(2105850534));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.879272623584438m,

0.997812462529447m,

0.102298079062808m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                await foreach(var batchResult in ((IDecimalArraynumericArray)this).DbConnectionSelectModelBatchAsync(connection, 8800741, 1015440465))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(28));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(32000850));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.913575567242658m,

0.0615614900869352m,

0.769869774161311m,

0.814376428327162m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.421290647733418m,

0.255433137392199m,

0.363044360674116m,

};
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
                Assert.That(model.Id, Is.EqualTo(43153943));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.332300642589601m,

0.471643124100398m,

0.875514209342379m,

0.121027904813977m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(309647647));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0223984689592726m,

0.741701985071582m,

0.506528439131137m,

};
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
                Assert.That(model.Id, Is.EqualTo(159905071));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.753839702305756m,

0.126667817766743m,

0.304093578349578m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.449697430510138m,

0.765993015823156m,

0.905297705808181m,

};
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
                Assert.That(model.Id, Is.EqualTo(201464680));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.463302337588417m,

0.370629662336532m,

0.548034257027467m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.232929796134916m,

0.154055025465336m,

0.995804668768241m,

};
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
                Assert.That(model.Id, Is.EqualTo(305442937));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.00442434600889063m,

0.708893704034158m,

0.695959329016357m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.304236347756219m,

0.538940488013919m,

0.951903137544338m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(303286147));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.289003967296092m,

0.230715463670717m,

0.634289943023537m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.90430136229428m,

0.265520434230188m,

0.0882482286785835m,

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
                Assert.That(model.Id, Is.EqualTo(306247634));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.642302896448763m,

0.0939550411266639m,

0.396298884654832m,

0.544525438222112m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(451738282));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.810837131956553m,

0.162300402571884m,

0.282674942099437m,

0.488846588453153m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.921969052649128m,

0.605019690498457m,

0.798121603649053m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(984438229));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0741905663217527m,

0.268226072193604m,

0.318138234199345m,

};
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
                Assert.That(model.Id, Is.EqualTo(475066646));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.699533766733219m,

0.764632014886774m,

0.588266643055788m,

0.270395949931969m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.744183241846793m,

0.193872558859702m,

0.611955518975458m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1885056944));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.568883731803848m,

0.494724047248429m,

0.626013261435883m,

0.688973982853637m,

};
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
                Assert.That(model.Id, Is.EqualTo(483348140));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.235380630453438m,

0.826330004289329m,

0.680774771392299m,

0.624690250671274m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(298762578));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.780435546177952m,

0.927047629858877m,

0.845070163448652m,

0.0698609253832982m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.347830774083804m,

0.258149875687242m,

0.640270661649344m,

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
                Assert.That(model.Id, Is.EqualTo(704906698));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.228357879737918m,

0.844292770150332m,

0.193605402427148m,

0.910272329050301m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031459247));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.988162986683755m,

0.946326933719384m,

0.105785481283932m,

0.457455767107011m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.668178001735014m,

0.0261309955467016m,

0.109480344091357m,

0.937907531897102m,

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
                Assert.That(model.Id, Is.EqualTo(775147825));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.786188446159501m,

0.468384468576442m,

0.0489489316706514m,

0.877494628915112m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(959648092));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.674600854216564m,

0.0588175653885267m,

0.693593299124215m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1798995844));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.343122150810035m,

0.908817296072129m,

0.460561041119878m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.43746426828906m,

0.462290235511666m,

0.174449967688479m,

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
                Assert.That(model.Id, Is.EqualTo(988453307));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.695013069422763m,

0.0683582645592904m,

0.202507903790901m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1015440465));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0442505885074315m,

0.171677856058679m,

0.822341341981591m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1024910545));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.14261366059483m,

0.435990139492505m,

0.391420749560393m,

0.968772200172711m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(229079168));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.270041495025426m,

0.313447659801434m,

0.761609962736885m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.631256212298377m,

0.900732747369461m,

0.0253447344957826m,

0.0605754462686936m,

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
                Assert.That(model.Id, Is.EqualTo(1070446321));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.802858304233387m,

0.930211539843706m,

0.821987258143027m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.524081989899844m,

0.344075670102832m,

0.130533397824908m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(405219663));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.814892888423264m,

0.644197589395732m,

0.1125124426437m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0235298466356579m,

0.70082263441205m,

0.115025107652443m,

0.673573885840338m,

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
                Assert.That(model.Id, Is.EqualTo(1263340027));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.114901119249173m,

0.835300182073698m,

0.862183024648071m,

0.928952987923253m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1802070348));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.500652392755636m,

0.856943238904947m,

0.249133800338953m,

};
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
                Assert.That(model.Id, Is.EqualTo(1271310123));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.352818123681143m,

0.823590600574034m,

0.663864599075235m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0552213646435307m,

0.801008271562292m,

0.682693623617323m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(659192782));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.784408630596159m,

0.326590134732045m,

0.706748565407806m,

0.70714341538462m,

};
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
                Assert.That(model.Id, Is.EqualTo(1360715309));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.261908214215052m,

0.210654276471595m,

0.863478059064684m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1437077957));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.00154420590750259m,

0.832397889829872m,

0.610334530115663m,

0.64418644840852m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1632277287));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.740845423062099m,

0.192856443839841m,

0.676531163938029m,

0.745948700176557m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1753210843));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.916769772881913m,

0.567020781896476m,

0.9478835173479m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.491122538690252m,

0.948238144075311m,

0.87346955182962m,

0.962893590471046m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(109042517));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.162812972763803m,

0.871473685385667m,

0.151976994708802m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0958054440869829m,

0.491548603531674m,

0.802813849544708m,

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1773872135));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.203369818001508m,

0.299211481277628m,

0.436804245520549m,

0.225472153906905m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.720718131865731m,

0.400667968682213m,

0.0391147048915961m,

};
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
                Assert.That(model.Id, Is.EqualTo(1888346957));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.655038384125233m,

0.494546225342795m,

0.214793000725172m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0170026041539578m,

0.749370461208432m,

0.0485792673212916m,

0.826584380369891m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(376018751));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.285284799320274m,

0.326008956423491m,

0.158336442848866m,

};
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
                Assert.That(model.Id, Is.EqualTo(1981519788));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.379119266282213m,

0.880053419808111m,

0.513177856651464m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.245584436378338m,

0.278630769588098m,

0.127043663851826m,

0.741955738302504m,

};
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
                Assert.That(model.Id, Is.EqualTo(2026148453));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.00175304556092548m,

0.219423357641208m,

0.454340333546278m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0143247803828197m,

0.228148089371708m,

0.255210017397057m,

0.752840241001218m,

};
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
                Assert.That(model.Id, Is.EqualTo(2047257074));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0932479255368816m,

0.0301833862224875m,

0.8564217528517m,

0.648511265153376m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.757211961836031m,

0.516208897744666m,

0.351346746448164m,

0.302614769465853m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(989496829));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.79538355099661m,

0.341420965783442m,

0.20182686144094m,

0.259105149616439m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.647339101314374m,

0.880252315020077m,

0.620730900706259m,

0.266031950292111m,

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
                Assert.That(model.Id, Is.EqualTo(2105850534));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.879272623584438m,

0.997812462529447m,

0.102298079062808m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1024910545));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.14261366059483m,

0.435990139492505m,

0.391420749560393m,

0.968772200172711m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(229079168));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.270041495025426m,

0.313447659801434m,

0.761609962736885m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.631256212298377m,

0.900732747369461m,

0.0253447344957826m,

0.0605754462686936m,

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
                Assert.That(model.Id, Is.EqualTo(1070446321));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.802858304233387m,

0.930211539843706m,

0.821987258143027m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.524081989899844m,

0.344075670102832m,

0.130533397824908m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(405219663));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.814892888423264m,

0.644197589395732m,

0.1125124426437m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0235298466356579m,

0.70082263441205m,

0.115025107652443m,

0.673573885840338m,

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
                Assert.That(model.Id, Is.EqualTo(1263340027));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.114901119249173m,

0.835300182073698m,

0.862183024648071m,

0.928952987923253m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1802070348));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.500652392755636m,

0.856943238904947m,

0.249133800338953m,

};
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
                Assert.That(model.Id, Is.EqualTo(1271310123));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.352818123681143m,

0.823590600574034m,

0.663864599075235m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0552213646435307m,

0.801008271562292m,

0.682693623617323m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(659192782));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.784408630596159m,

0.326590134732045m,

0.706748565407806m,

0.70714341538462m,

};
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
                Assert.That(model.Id, Is.EqualTo(1360715309));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.261908214215052m,

0.210654276471595m,

0.863478059064684m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1437077957));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.00154420590750259m,

0.832397889829872m,

0.610334530115663m,

0.64418644840852m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1632277287));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.740845423062099m,

0.192856443839841m,

0.676531163938029m,

0.745948700176557m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1753210843));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.916769772881913m,

0.567020781896476m,

0.9478835173479m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.491122538690252m,

0.948238144075311m,

0.87346955182962m,

0.962893590471046m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(109042517));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.162812972763803m,

0.871473685385667m,

0.151976994708802m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0958054440869829m,

0.491548603531674m,

0.802813849544708m,

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
                Assert.That(model.Id, Is.EqualTo(1773872135));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.203369818001508m,

0.299211481277628m,

0.436804245520549m,

0.225472153906905m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.720718131865731m,

0.400667968682213m,

0.0391147048915961m,

};
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
                Assert.That(model.Id, Is.EqualTo(1888346957));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.655038384125233m,

0.494546225342795m,

0.214793000725172m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0170026041539578m,

0.749370461208432m,

0.0485792673212916m,

0.826584380369891m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(376018751));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.285284799320274m,

0.326008956423491m,

0.158336442848866m,

};
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
                Assert.That(model.Id, Is.EqualTo(1981519788));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.379119266282213m,

0.880053419808111m,

0.513177856651464m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.245584436378338m,

0.278630769588098m,

0.127043663851826m,

0.741955738302504m,

};
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
                Assert.That(model.Id, Is.EqualTo(2026148453));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.00175304556092548m,

0.219423357641208m,

0.454340333546278m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0143247803828197m,

0.228148089371708m,

0.255210017397057m,

0.752840241001218m,

};
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
                Assert.That(model.Id, Is.EqualTo(2047257074));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0932479255368816m,

0.0301833862224875m,

0.8564217528517m,

0.648511265153376m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.757211961836031m,

0.516208897744666m,

0.351346746448164m,

0.302614769465853m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(989496829));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.79538355099661m,

0.341420965783442m,

0.20182686144094m,

0.259105149616439m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.647339101314374m,

0.880252315020077m,

0.620730900706259m,

0.266031950292111m,

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
                Assert.That(model.Id, Is.EqualTo(2105850534));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.879272623584438m,

0.997812462529447m,

0.102298079062808m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
COPY public.binary_decimalnumericarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
FROM public.binary_decimalnumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(DecimalnumericArray1MI),
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

                var importCollection = new List<DecimalnumericArray1MI>(7);

                importCollection.Add(
                new DecimalnumericArray1MI
                {
                    Id = 109042517,
                    Value = 
new System.Decimal[3]
{
0.162812972763803m,

0.871473685385667m,

0.151976994708802m,

},
                    NullableValue = 
new System.Decimal[3]
{
0.0958054440869829m,

0.491548603531674m,

0.802813849544708m,

}
                });

                importCollection.Add(
                new DecimalnumericArray1MI
                {
                    Id = 229079168,
                    Value = 
new System.Decimal[3]
{
0.270041495025426m,

0.313447659801434m,

0.761609962736885m,

},
                    NullableValue = 
new System.Decimal[4]
{
0.631256212298377m,

0.900732747369461m,

0.0253447344957826m,

0.0605754462686936m,

}
                });

                importCollection.Add(
                new DecimalnumericArray1MI
                {
                    Id = 298762578,
                    Value = 
new System.Decimal[4]
{
0.780435546177952m,

0.927047629858877m,

0.845070163448652m,

0.0698609253832982m,

},
                    NullableValue = 
new System.Decimal[3]
{
0.347830774083804m,

0.258149875687242m,

0.640270661649344m,

}
                });

                importCollection.Add(
                new DecimalnumericArray1MI
                {
                    Id = 303286147,
                    Value = 
new System.Decimal[3]
{
0.289003967296092m,

0.230715463670717m,

0.634289943023537m,

},
                    NullableValue = 
new System.Decimal[3]
{
0.90430136229428m,

0.265520434230188m,

0.0882482286785835m,

}
                });

                importCollection.Add(
                new DecimalnumericArray1MI
                {
                    Id = 309647647,
                    Value = 
new System.Decimal[3]
{
0.0223984689592726m,

0.741701985071582m,

0.506528439131137m,

},
                    NullableValue = null
                });

                importCollection.Add(
                new DecimalnumericArray1MI
                {
                    Id = 376018751,
                    Value = 
new System.Decimal[3]
{
0.285284799320274m,

0.326008956423491m,

0.158336442848866m,

},
                    NullableValue = null
                });

                importCollection.Add(
                new DecimalnumericArray1MI
                {
                    Id = 405219663,
                    Value = 
new System.Decimal[3]
{
0.814892888423264m,

0.644197589395732m,

0.1125124426437m,

},
                    NullableValue = 
new System.Decimal[4]
{
0.0235298466356579m,

0.70082263441205m,

0.115025107652443m,

0.673573885840338m,

}
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(109042517));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.162812972763803m,

0.871473685385667m,

0.151976994708802m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0958054440869829m,

0.491548603531674m,

0.802813849544708m,

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
                Assert.That(model.Id, Is.EqualTo(229079168));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.270041495025426m,

0.313447659801434m,

0.761609962736885m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.631256212298377m,

0.900732747369461m,

0.0253447344957826m,

0.0605754462686936m,

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
                Assert.That(model.Id, Is.EqualTo(298762578));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.780435546177952m,

0.927047629858877m,

0.845070163448652m,

0.0698609253832982m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.347830774083804m,

0.258149875687242m,

0.640270661649344m,

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
                Assert.That(model.Id, Is.EqualTo(303286147));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.289003967296092m,

0.230715463670717m,

0.634289943023537m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.90430136229428m,

0.265520434230188m,

0.0882482286785835m,

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
                Assert.That(model.Id, Is.EqualTo(309647647));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0223984689592726m,

0.741701985071582m,

0.506528439131137m,

};
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
                Assert.That(model.Id, Is.EqualTo(376018751));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.285284799320274m,

0.326008956423491m,

0.158336442848866m,

};
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
                Assert.That(model.Id, Is.EqualTo(405219663));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.814892888423264m,

0.644197589395732m,

0.1125124426437m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0235298466356579m,

0.70082263441205m,

0.115025107652443m,

0.673573885840338m,

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
                new DecimalnumericArray1MI
                {
                    Id = 659192782,
                    Value = 
new System.Decimal[4]
{
0.784408630596159m,

0.326590134732045m,

0.706748565407806m,

0.70714341538462m,

},
                    NullableValue = null
                });

                importCollection.Add(
                new DecimalnumericArray1MI
                {
                    Id = 984438229,
                    Value = 
new System.Decimal[3]
{
0.0741905663217527m,

0.268226072193604m,

0.318138234199345m,

},
                    NullableValue = null
                });

                importCollection.Add(
                new DecimalnumericArray1MI
                {
                    Id = 989496829,
                    Value = 
new System.Decimal[4]
{
0.79538355099661m,

0.341420965783442m,

0.20182686144094m,

0.259105149616439m,

},
                    NullableValue = 
new System.Decimal[4]
{
0.647339101314374m,

0.880252315020077m,

0.620730900706259m,

0.266031950292111m,

}
                });

                importCollection.Add(
                new DecimalnumericArray1MI
                {
                    Id = 1798995844,
                    Value = 
new System.Decimal[3]
{
0.343122150810035m,

0.908817296072129m,

0.460561041119878m,

},
                    NullableValue = 
new System.Decimal[3]
{
0.43746426828906m,

0.462290235511666m,

0.174449967688479m,

}
                });

                importCollection.Add(
                new DecimalnumericArray1MI
                {
                    Id = 1802070348,
                    Value = 
new System.Decimal[3]
{
0.500652392755636m,

0.856943238904947m,

0.249133800338953m,

},
                    NullableValue = null
                });

                importCollection.Add(
                new DecimalnumericArray1MI
                {
                    Id = 1885056944,
                    Value = 
new System.Decimal[4]
{
0.568883731803848m,

0.494724047248429m,

0.626013261435883m,

0.688973982853637m,

},
                    NullableValue = null
                });

                importCollection.Add(
                new DecimalnumericArray1MI
                {
                    Id = 2031459247,
                    Value = 
new System.Decimal[4]
{
0.988162986683755m,

0.946326933719384m,

0.105785481283932m,

0.457455767107011m,

},
                    NullableValue = 
new System.Decimal[4]
{
0.668178001735014m,

0.0261309955467016m,

0.109480344091357m,

0.937907531897102m,

}
                });

                importCollection.Add(
                new DecimalnumericArray1MI
                {
                    Id = 2107226176,
                    Value = 
new System.Decimal[4]
{
0.31300535562594m,

0.325076535243441m,

0.191975226437568m,

0.176069793339158m,

},
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(109042517));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.162812972763803m,

0.871473685385667m,

0.151976994708802m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0958054440869829m,

0.491548603531674m,

0.802813849544708m,

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
                Assert.That(model.Id, Is.EqualTo(229079168));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.270041495025426m,

0.313447659801434m,

0.761609962736885m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.631256212298377m,

0.900732747369461m,

0.0253447344957826m,

0.0605754462686936m,

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
                Assert.That(model.Id, Is.EqualTo(298762578));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.780435546177952m,

0.927047629858877m,

0.845070163448652m,

0.0698609253832982m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.347830774083804m,

0.258149875687242m,

0.640270661649344m,

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
                Assert.That(model.Id, Is.EqualTo(303286147));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.289003967296092m,

0.230715463670717m,

0.634289943023537m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.90430136229428m,

0.265520434230188m,

0.0882482286785835m,

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
                Assert.That(model.Id, Is.EqualTo(309647647));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0223984689592726m,

0.741701985071582m,

0.506528439131137m,

};
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
                Assert.That(model.Id, Is.EqualTo(376018751));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.285284799320274m,

0.326008956423491m,

0.158336442848866m,

};
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
                Assert.That(model.Id, Is.EqualTo(405219663));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.814892888423264m,

0.644197589395732m,

0.1125124426437m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0235298466356579m,

0.70082263441205m,

0.115025107652443m,

0.673573885840338m,

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
                Assert.That(model.Id, Is.EqualTo(659192782));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.784408630596159m,

0.326590134732045m,

0.706748565407806m,

0.70714341538462m,

};
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
                Assert.That(model.Id, Is.EqualTo(984438229));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0741905663217527m,

0.268226072193604m,

0.318138234199345m,

};
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
                Assert.That(model.Id, Is.EqualTo(989496829));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.79538355099661m,

0.341420965783442m,

0.20182686144094m,

0.259105149616439m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.647339101314374m,

0.880252315020077m,

0.620730900706259m,

0.266031950292111m,

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
                Assert.That(model.Id, Is.EqualTo(1798995844));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.343122150810035m,

0.908817296072129m,

0.460561041119878m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.43746426828906m,

0.462290235511666m,

0.174449967688479m,

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
                Assert.That(model.Id, Is.EqualTo(1802070348));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.500652392755636m,

0.856943238904947m,

0.249133800338953m,

};
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
                Assert.That(model.Id, Is.EqualTo(1885056944));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.568883731803848m,

0.494724047248429m,

0.626013261435883m,

0.688973982853637m,

};
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
                Assert.That(model.Id, Is.EqualTo(2031459247));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.988162986683755m,

0.946326933719384m,

0.105785481283932m,

0.457455767107011m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.668178001735014m,

0.0261309955467016m,

0.109480344091357m,

0.937907531897102m,

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
                Assert.That(model.Id, Is.EqualTo(2107226176));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.31300535562594m,

0.325076535243441m,

0.191975226437568m,

0.176069793339158m,

};
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
COPY public.binary_decimalnumericarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
FROM public.binary_decimalnumericarray1m m
LEFT JOIN public.binary_decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(DecimalnumericArray1M),
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

                var importCollection = new List<DecimalnumericArray1M>(15);

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 4472279,
                    Value = 
new System.Decimal[3]
{
0.670739165704255m,

0.115430150727337m,

0.77471262428668m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 8800741,
                    Value = 
new System.Decimal[4]
{
0.198864665374831m,

0.286384074901691m,

0.683428746428832m,

0.895162087363908m,

},
                    NullableValue = null,

                    ModelInner = new DecimalnumericArray1MI 
                    {
                        Id = 2107226176
                    }

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 32000850,
                    Value = 
new System.Decimal[4]
{
0.913575567242658m,

0.0615614900869352m,

0.769869774161311m,

0.814376428327162m,

},
                    NullableValue = 
new System.Decimal[3]
{
0.421290647733418m,

0.255433137392199m,

0.363044360674116m,

},

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 43153943,
                    Value = 
new System.Decimal[4]
{
0.332300642589601m,

0.471643124100398m,

0.875514209342379m,

0.121027904813977m,

},
                    NullableValue = null,

                    ModelInner = new DecimalnumericArray1MI 
                    {
                        Id = 309647647
                    }

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 159905071,
                    Value = 
new System.Decimal[3]
{
0.753839702305756m,

0.126667817766743m,

0.304093578349578m,

},
                    NullableValue = 
new System.Decimal[3]
{
0.449697430510138m,

0.765993015823156m,

0.905297705808181m,

},

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 201464680,
                    Value = 
new System.Decimal[3]
{
0.463302337588417m,

0.370629662336532m,

0.548034257027467m,

},
                    NullableValue = 
new System.Decimal[3]
{
0.232929796134916m,

0.154055025465336m,

0.995804668768241m,

},

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 305442937,
                    Value = 
new System.Decimal[3]
{
0.00442434600889063m,

0.708893704034158m,

0.695959329016357m,

},
                    NullableValue = 
new System.Decimal[3]
{
0.304236347756219m,

0.538940488013919m,

0.951903137544338m,

},

                    ModelInner = new DecimalnumericArray1MI 
                    {
                        Id = 303286147
                    }

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 306247634,
                    Value = 
new System.Decimal[4]
{
0.642302896448763m,

0.0939550411266639m,

0.396298884654832m,

0.544525438222112m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 451738282,
                    Value = 
new System.Decimal[4]
{
0.810837131956553m,

0.162300402571884m,

0.282674942099437m,

0.488846588453153m,

},
                    NullableValue = 
new System.Decimal[3]
{
0.921969052649128m,

0.605019690498457m,

0.798121603649053m,

},

                    ModelInner = new DecimalnumericArray1MI 
                    {
                        Id = 984438229
                    }

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 475066646,
                    Value = 
new System.Decimal[4]
{
0.699533766733219m,

0.764632014886774m,

0.588266643055788m,

0.270395949931969m,

},
                    NullableValue = 
new System.Decimal[3]
{
0.744183241846793m,

0.193872558859702m,

0.611955518975458m,

},

                    ModelInner = new DecimalnumericArray1MI 
                    {
                        Id = 1885056944
                    }

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 483348140,
                    Value = 
new System.Decimal[4]
{
0.235380630453438m,

0.826330004289329m,

0.680774771392299m,

0.624690250671274m,

},
                    NullableValue = null,

                    ModelInner = new DecimalnumericArray1MI 
                    {
                        Id = 298762578
                    }

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 704906698,
                    Value = 
new System.Decimal[4]
{
0.228357879737918m,

0.844292770150332m,

0.193605402427148m,

0.910272329050301m,

},
                    NullableValue = null,

                    ModelInner = new DecimalnumericArray1MI 
                    {
                        Id = 2031459247
                    }

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 775147825,
                    Value = 
new System.Decimal[4]
{
0.786188446159501m,

0.468384468576442m,

0.0489489316706514m,

0.877494628915112m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 959648092,
                    Value = 
new System.Decimal[3]
{
0.674600854216564m,

0.0588175653885267m,

0.693593299124215m,

},
                    NullableValue = null,

                    ModelInner = new DecimalnumericArray1MI 
                    {
                        Id = 1798995844
                    }

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 988453307,
                    Value = 
new System.Decimal[3]
{
0.695013069422763m,

0.0683582645592904m,

0.202507903790901m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(4472279));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.670739165704255m,

0.115430150727337m,

0.77471262428668m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(8800741));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.198864665374831m,

0.286384074901691m,

0.683428746428832m,

0.895162087363908m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2107226176));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.31300535562594m,

0.325076535243441m,

0.191975226437568m,

0.176069793339158m,

};
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
                Assert.That(model.Id, Is.EqualTo(32000850));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.913575567242658m,

0.0615614900869352m,

0.769869774161311m,

0.814376428327162m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.421290647733418m,

0.255433137392199m,

0.363044360674116m,

};
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
                Assert.That(model.Id, Is.EqualTo(43153943));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.332300642589601m,

0.471643124100398m,

0.875514209342379m,

0.121027904813977m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(309647647));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0223984689592726m,

0.741701985071582m,

0.506528439131137m,

};
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
                Assert.That(model.Id, Is.EqualTo(159905071));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.753839702305756m,

0.126667817766743m,

0.304093578349578m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.449697430510138m,

0.765993015823156m,

0.905297705808181m,

};
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
                Assert.That(model.Id, Is.EqualTo(201464680));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.463302337588417m,

0.370629662336532m,

0.548034257027467m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.232929796134916m,

0.154055025465336m,

0.995804668768241m,

};
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
                Assert.That(model.Id, Is.EqualTo(305442937));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.00442434600889063m,

0.708893704034158m,

0.695959329016357m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.304236347756219m,

0.538940488013919m,

0.951903137544338m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(303286147));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.289003967296092m,

0.230715463670717m,

0.634289943023537m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.90430136229428m,

0.265520434230188m,

0.0882482286785835m,

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
                Assert.That(model.Id, Is.EqualTo(306247634));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.642302896448763m,

0.0939550411266639m,

0.396298884654832m,

0.544525438222112m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(451738282));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.810837131956553m,

0.162300402571884m,

0.282674942099437m,

0.488846588453153m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.921969052649128m,

0.605019690498457m,

0.798121603649053m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(984438229));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0741905663217527m,

0.268226072193604m,

0.318138234199345m,

};
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
                Assert.That(model.Id, Is.EqualTo(475066646));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.699533766733219m,

0.764632014886774m,

0.588266643055788m,

0.270395949931969m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.744183241846793m,

0.193872558859702m,

0.611955518975458m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1885056944));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.568883731803848m,

0.494724047248429m,

0.626013261435883m,

0.688973982853637m,

};
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
                Assert.That(model.Id, Is.EqualTo(483348140));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.235380630453438m,

0.826330004289329m,

0.680774771392299m,

0.624690250671274m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(298762578));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.780435546177952m,

0.927047629858877m,

0.845070163448652m,

0.0698609253832982m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.347830774083804m,

0.258149875687242m,

0.640270661649344m,

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
                Assert.That(model.Id, Is.EqualTo(704906698));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.228357879737918m,

0.844292770150332m,

0.193605402427148m,

0.910272329050301m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031459247));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.988162986683755m,

0.946326933719384m,

0.105785481283932m,

0.457455767107011m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.668178001735014m,

0.0261309955467016m,

0.109480344091357m,

0.937907531897102m,

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
                Assert.That(model.Id, Is.EqualTo(775147825));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.786188446159501m,

0.468384468576442m,

0.0489489316706514m,

0.877494628915112m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(959648092));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.674600854216564m,

0.0588175653885267m,

0.693593299124215m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1798995844));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.343122150810035m,

0.908817296072129m,

0.460561041119878m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.43746426828906m,

0.462290235511666m,

0.174449967688479m,

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
                Assert.That(model.Id, Is.EqualTo(988453307));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.695013069422763m,

0.0683582645592904m,

0.202507903790901m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                new DecimalnumericArray1M
                {
                    Id = 1015440465,
                    Value = 
new System.Decimal[3]
{
0.0442505885074315m,

0.171677856058679m,

0.822341341981591m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 1024910545,
                    Value = 
new System.Decimal[4]
{
0.14261366059483m,

0.435990139492505m,

0.391420749560393m,

0.968772200172711m,

},
                    NullableValue = null,

                    ModelInner = new DecimalnumericArray1MI 
                    {
                        Id = 229079168
                    }

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 1070446321,
                    Value = 
new System.Decimal[3]
{
0.802858304233387m,

0.930211539843706m,

0.821987258143027m,

},
                    NullableValue = 
new System.Decimal[3]
{
0.524081989899844m,

0.344075670102832m,

0.130533397824908m,

},

                    ModelInner = new DecimalnumericArray1MI 
                    {
                        Id = 405219663
                    }

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 1263340027,
                    Value = 
new System.Decimal[4]
{
0.114901119249173m,

0.835300182073698m,

0.862183024648071m,

0.928952987923253m,

},
                    NullableValue = null,

                    ModelInner = new DecimalnumericArray1MI 
                    {
                        Id = 1802070348
                    }

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 1271310123,
                    Value = 
new System.Decimal[3]
{
0.352818123681143m,

0.823590600574034m,

0.663864599075235m,

},
                    NullableValue = 
new System.Decimal[3]
{
0.0552213646435307m,

0.801008271562292m,

0.682693623617323m,

},

                    ModelInner = new DecimalnumericArray1MI 
                    {
                        Id = 659192782
                    }

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 1360715309,
                    Value = 
new System.Decimal[3]
{
0.261908214215052m,

0.210654276471595m,

0.863478059064684m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 1437077957,
                    Value = 
new System.Decimal[4]
{
0.00154420590750259m,

0.832397889829872m,

0.610334530115663m,

0.64418644840852m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 1632277287,
                    Value = 
new System.Decimal[4]
{
0.740845423062099m,

0.192856443839841m,

0.676531163938029m,

0.745948700176557m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 1753210843,
                    Value = 
new System.Decimal[3]
{
0.916769772881913m,

0.567020781896476m,

0.9478835173479m,

},
                    NullableValue = 
new System.Decimal[4]
{
0.491122538690252m,

0.948238144075311m,

0.87346955182962m,

0.962893590471046m,

},

                    ModelInner = new DecimalnumericArray1MI 
                    {
                        Id = 109042517
                    }

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 1773872135,
                    Value = 
new System.Decimal[4]
{
0.203369818001508m,

0.299211481277628m,

0.436804245520549m,

0.225472153906905m,

},
                    NullableValue = 
new System.Decimal[3]
{
0.720718131865731m,

0.400667968682213m,

0.0391147048915961m,

},

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 1888346957,
                    Value = 
new System.Decimal[3]
{
0.655038384125233m,

0.494546225342795m,

0.214793000725172m,

},
                    NullableValue = 
new System.Decimal[4]
{
0.0170026041539578m,

0.749370461208432m,

0.0485792673212916m,

0.826584380369891m,

},

                    ModelInner = new DecimalnumericArray1MI 
                    {
                        Id = 376018751
                    }

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 1981519788,
                    Value = 
new System.Decimal[3]
{
0.379119266282213m,

0.880053419808111m,

0.513177856651464m,

},
                    NullableValue = 
new System.Decimal[4]
{
0.245584436378338m,

0.278630769588098m,

0.127043663851826m,

0.741955738302504m,

},

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 2026148453,
                    Value = 
new System.Decimal[3]
{
0.00175304556092548m,

0.219423357641208m,

0.454340333546278m,

},
                    NullableValue = 
new System.Decimal[4]
{
0.0143247803828197m,

0.228148089371708m,

0.255210017397057m,

0.752840241001218m,

},

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 2047257074,
                    Value = 
new System.Decimal[4]
{
0.0932479255368816m,

0.0301833862224875m,

0.8564217528517m,

0.648511265153376m,

},
                    NullableValue = 
new System.Decimal[4]
{
0.757211961836031m,

0.516208897744666m,

0.351346746448164m,

0.302614769465853m,

},

                    ModelInner = new DecimalnumericArray1MI 
                    {
                        Id = 989496829
                    }

                });

                importCollection.Add(
                new DecimalnumericArray1M
                {
                    Id = 2105850534,
                    Value = 
new System.Decimal[3]
{
0.879272623584438m,

0.997812462529447m,

0.102298079062808m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(4472279));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.670739165704255m,

0.115430150727337m,

0.77471262428668m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(8800741));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.198864665374831m,

0.286384074901691m,

0.683428746428832m,

0.895162087363908m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2107226176));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.31300535562594m,

0.325076535243441m,

0.191975226437568m,

0.176069793339158m,

};
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
                Assert.That(model.Id, Is.EqualTo(32000850));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.913575567242658m,

0.0615614900869352m,

0.769869774161311m,

0.814376428327162m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.421290647733418m,

0.255433137392199m,

0.363044360674116m,

};
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
                Assert.That(model.Id, Is.EqualTo(43153943));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.332300642589601m,

0.471643124100398m,

0.875514209342379m,

0.121027904813977m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(309647647));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0223984689592726m,

0.741701985071582m,

0.506528439131137m,

};
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
                Assert.That(model.Id, Is.EqualTo(159905071));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.753839702305756m,

0.126667817766743m,

0.304093578349578m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.449697430510138m,

0.765993015823156m,

0.905297705808181m,

};
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
                Assert.That(model.Id, Is.EqualTo(201464680));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.463302337588417m,

0.370629662336532m,

0.548034257027467m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.232929796134916m,

0.154055025465336m,

0.995804668768241m,

};
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
                Assert.That(model.Id, Is.EqualTo(305442937));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.00442434600889063m,

0.708893704034158m,

0.695959329016357m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.304236347756219m,

0.538940488013919m,

0.951903137544338m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(303286147));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.289003967296092m,

0.230715463670717m,

0.634289943023537m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.90430136229428m,

0.265520434230188m,

0.0882482286785835m,

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
                Assert.That(model.Id, Is.EqualTo(306247634));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.642302896448763m,

0.0939550411266639m,

0.396298884654832m,

0.544525438222112m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(451738282));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.810837131956553m,

0.162300402571884m,

0.282674942099437m,

0.488846588453153m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.921969052649128m,

0.605019690498457m,

0.798121603649053m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(984438229));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0741905663217527m,

0.268226072193604m,

0.318138234199345m,

};
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
                Assert.That(model.Id, Is.EqualTo(475066646));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.699533766733219m,

0.764632014886774m,

0.588266643055788m,

0.270395949931969m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.744183241846793m,

0.193872558859702m,

0.611955518975458m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1885056944));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.568883731803848m,

0.494724047248429m,

0.626013261435883m,

0.688973982853637m,

};
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
                Assert.That(model.Id, Is.EqualTo(483348140));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.235380630453438m,

0.826330004289329m,

0.680774771392299m,

0.624690250671274m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(298762578));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.780435546177952m,

0.927047629858877m,

0.845070163448652m,

0.0698609253832982m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.347830774083804m,

0.258149875687242m,

0.640270661649344m,

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
                Assert.That(model.Id, Is.EqualTo(704906698));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.228357879737918m,

0.844292770150332m,

0.193605402427148m,

0.910272329050301m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031459247));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.988162986683755m,

0.946326933719384m,

0.105785481283932m,

0.457455767107011m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.668178001735014m,

0.0261309955467016m,

0.109480344091357m,

0.937907531897102m,

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
                Assert.That(model.Id, Is.EqualTo(775147825));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.786188446159501m,

0.468384468576442m,

0.0489489316706514m,

0.877494628915112m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(959648092));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.674600854216564m,

0.0588175653885267m,

0.693593299124215m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1798995844));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.343122150810035m,

0.908817296072129m,

0.460561041119878m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.43746426828906m,

0.462290235511666m,

0.174449967688479m,

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
                Assert.That(model.Id, Is.EqualTo(988453307));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.695013069422763m,

0.0683582645592904m,

0.202507903790901m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1015440465));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0442505885074315m,

0.171677856058679m,

0.822341341981591m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1024910545));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.14261366059483m,

0.435990139492505m,

0.391420749560393m,

0.968772200172711m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(229079168));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.270041495025426m,

0.313447659801434m,

0.761609962736885m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.631256212298377m,

0.900732747369461m,

0.0253447344957826m,

0.0605754462686936m,

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
                Assert.That(model.Id, Is.EqualTo(1070446321));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.802858304233387m,

0.930211539843706m,

0.821987258143027m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.524081989899844m,

0.344075670102832m,

0.130533397824908m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(405219663));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.814892888423264m,

0.644197589395732m,

0.1125124426437m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0235298466356579m,

0.70082263441205m,

0.115025107652443m,

0.673573885840338m,

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
                Assert.That(model.Id, Is.EqualTo(1263340027));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.114901119249173m,

0.835300182073698m,

0.862183024648071m,

0.928952987923253m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1802070348));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.500652392755636m,

0.856943238904947m,

0.249133800338953m,

};
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
                Assert.That(model.Id, Is.EqualTo(1271310123));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.352818123681143m,

0.823590600574034m,

0.663864599075235m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0552213646435307m,

0.801008271562292m,

0.682693623617323m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(659192782));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.784408630596159m,

0.326590134732045m,

0.706748565407806m,

0.70714341538462m,

};
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
                Assert.That(model.Id, Is.EqualTo(1360715309));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.261908214215052m,

0.210654276471595m,

0.863478059064684m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1437077957));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.00154420590750259m,

0.832397889829872m,

0.610334530115663m,

0.64418644840852m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1632277287));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.740845423062099m,

0.192856443839841m,

0.676531163938029m,

0.745948700176557m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1753210843));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.916769772881913m,

0.567020781896476m,

0.9478835173479m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.491122538690252m,

0.948238144075311m,

0.87346955182962m,

0.962893590471046m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(109042517));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.162812972763803m,

0.871473685385667m,

0.151976994708802m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.0958054440869829m,

0.491548603531674m,

0.802813849544708m,

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
                Assert.That(model.Id, Is.EqualTo(1773872135));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.203369818001508m,

0.299211481277628m,

0.436804245520549m,

0.225472153906905m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.720718131865731m,

0.400667968682213m,

0.0391147048915961m,

};
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
                Assert.That(model.Id, Is.EqualTo(1888346957));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.655038384125233m,

0.494546225342795m,

0.214793000725172m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0170026041539578m,

0.749370461208432m,

0.0485792673212916m,

0.826584380369891m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(376018751));

                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.285284799320274m,

0.326008956423491m,

0.158336442848866m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981519788));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.379119266282213m,

0.880053419808111m,

0.513177856651464m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.245584436378338m,

0.278630769588098m,

0.127043663851826m,

0.741955738302504m,

};
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
                Assert.That(model.Id, Is.EqualTo(2026148453));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.00175304556092548m,

0.219423357641208m,

0.454340333546278m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0143247803828197m,

0.228148089371708m,

0.255210017397057m,

0.752840241001218m,

};
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
                Assert.That(model.Id, Is.EqualTo(2047257074));
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.0932479255368816m,

0.0301833862224875m,

0.8564217528517m,

0.648511265153376m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.757211961836031m,

0.516208897744666m,

0.351346746448164m,

0.302614769465853m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(989496829));

                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.79538355099661m,

0.341420965783442m,

0.20182686144094m,

0.259105149616439m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Decimal[4]
{
0.647339101314374m,

0.880252315020077m,

0.620730900706259m,

0.266031950292111m,

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
                Assert.That(model.Id, Is.EqualTo(2105850534));
                {
                    var expectEnumerValue = 
new System.Decimal[3]
{
0.879272623584438m,

0.997812462529447m,

0.102298079062808m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
COPY public.binary_decimalnumericarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(DecimalnumericArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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

                var expected = new Dictionary<System.Int32,DecimalnumericArray1M>(30);

                expected.Add(
                    4472279,
                    new DecimalnumericArray1M
                    {
                        Id = 4472279,
                        Value = 
new System.Decimal[3]
{
0.670739165704255m,

0.115430150727337m,

0.77471262428668m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    8800741,
                    new DecimalnumericArray1M
                    {
                        Id = 8800741,
                        Value = 
new System.Decimal[4]
{
0.198864665374831m,

0.286384074901691m,

0.683428746428832m,

0.895162087363908m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 2107226176,
                            Value = 
new System.Decimal[4]
{
0.31300535562594m,

0.325076535243441m,

0.191975226437568m,

0.176069793339158m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    32000850,
                    new DecimalnumericArray1M
                    {
                        Id = 32000850,
                        Value = 
new System.Decimal[4]
{
0.913575567242658m,

0.0615614900869352m,

0.769869774161311m,

0.814376428327162m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.421290647733418m,

0.255433137392199m,

0.363044360674116m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    43153943,
                    new DecimalnumericArray1M
                    {
                        Id = 43153943,
                        Value = 
new System.Decimal[4]
{
0.332300642589601m,

0.471643124100398m,

0.875514209342379m,

0.121027904813977m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 309647647,
                            Value = 
new System.Decimal[3]
{
0.0223984689592726m,

0.741701985071582m,

0.506528439131137m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    159905071,
                    new DecimalnumericArray1M
                    {
                        Id = 159905071,
                        Value = 
new System.Decimal[3]
{
0.753839702305756m,

0.126667817766743m,

0.304093578349578m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.449697430510138m,

0.765993015823156m,

0.905297705808181m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    201464680,
                    new DecimalnumericArray1M
                    {
                        Id = 201464680,
                        Value = 
new System.Decimal[3]
{
0.463302337588417m,

0.370629662336532m,

0.548034257027467m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.232929796134916m,

0.154055025465336m,

0.995804668768241m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    305442937,
                    new DecimalnumericArray1M
                    {
                        Id = 305442937,
                        Value = 
new System.Decimal[3]
{
0.00442434600889063m,

0.708893704034158m,

0.695959329016357m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.304236347756219m,

0.538940488013919m,

0.951903137544338m,

},

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 303286147,
                            Value = 
new System.Decimal[3]
{
0.289003967296092m,

0.230715463670717m,

0.634289943023537m,

},
                            NullableValue = 
new System.Decimal[3]
{
0.90430136229428m,

0.265520434230188m,

0.0882482286785835m,

}
                        }

                    }
                );

                expected.Add(
                    306247634,
                    new DecimalnumericArray1M
                    {
                        Id = 306247634,
                        Value = 
new System.Decimal[4]
{
0.642302896448763m,

0.0939550411266639m,

0.396298884654832m,

0.544525438222112m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    451738282,
                    new DecimalnumericArray1M
                    {
                        Id = 451738282,
                        Value = 
new System.Decimal[4]
{
0.810837131956553m,

0.162300402571884m,

0.282674942099437m,

0.488846588453153m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.921969052649128m,

0.605019690498457m,

0.798121603649053m,

},

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 984438229,
                            Value = 
new System.Decimal[3]
{
0.0741905663217527m,

0.268226072193604m,

0.318138234199345m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    475066646,
                    new DecimalnumericArray1M
                    {
                        Id = 475066646,
                        Value = 
new System.Decimal[4]
{
0.699533766733219m,

0.764632014886774m,

0.588266643055788m,

0.270395949931969m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.744183241846793m,

0.193872558859702m,

0.611955518975458m,

},

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 1885056944,
                            Value = 
new System.Decimal[4]
{
0.568883731803848m,

0.494724047248429m,

0.626013261435883m,

0.688973982853637m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    483348140,
                    new DecimalnumericArray1M
                    {
                        Id = 483348140,
                        Value = 
new System.Decimal[4]
{
0.235380630453438m,

0.826330004289329m,

0.680774771392299m,

0.624690250671274m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 298762578,
                            Value = 
new System.Decimal[4]
{
0.780435546177952m,

0.927047629858877m,

0.845070163448652m,

0.0698609253832982m,

},
                            NullableValue = 
new System.Decimal[3]
{
0.347830774083804m,

0.258149875687242m,

0.640270661649344m,

}
                        }

                    }
                );

                expected.Add(
                    704906698,
                    new DecimalnumericArray1M
                    {
                        Id = 704906698,
                        Value = 
new System.Decimal[4]
{
0.228357879737918m,

0.844292770150332m,

0.193605402427148m,

0.910272329050301m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 2031459247,
                            Value = 
new System.Decimal[4]
{
0.988162986683755m,

0.946326933719384m,

0.105785481283932m,

0.457455767107011m,

},
                            NullableValue = 
new System.Decimal[4]
{
0.668178001735014m,

0.0261309955467016m,

0.109480344091357m,

0.937907531897102m,

}
                        }

                    }
                );

                expected.Add(
                    775147825,
                    new DecimalnumericArray1M
                    {
                        Id = 775147825,
                        Value = 
new System.Decimal[4]
{
0.786188446159501m,

0.468384468576442m,

0.0489489316706514m,

0.877494628915112m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    959648092,
                    new DecimalnumericArray1M
                    {
                        Id = 959648092,
                        Value = 
new System.Decimal[3]
{
0.674600854216564m,

0.0588175653885267m,

0.693593299124215m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 1798995844,
                            Value = 
new System.Decimal[3]
{
0.343122150810035m,

0.908817296072129m,

0.460561041119878m,

},
                            NullableValue = 
new System.Decimal[3]
{
0.43746426828906m,

0.462290235511666m,

0.174449967688479m,

}
                        }

                    }
                );

                expected.Add(
                    988453307,
                    new DecimalnumericArray1M
                    {
                        Id = 988453307,
                        Value = 
new System.Decimal[3]
{
0.695013069422763m,

0.0683582645592904m,

0.202507903790901m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1015440465,
                    new DecimalnumericArray1M
                    {
                        Id = 1015440465,
                        Value = 
new System.Decimal[3]
{
0.0442505885074315m,

0.171677856058679m,

0.822341341981591m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1024910545,
                    new DecimalnumericArray1M
                    {
                        Id = 1024910545,
                        Value = 
new System.Decimal[4]
{
0.14261366059483m,

0.435990139492505m,

0.391420749560393m,

0.968772200172711m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 229079168,
                            Value = 
new System.Decimal[3]
{
0.270041495025426m,

0.313447659801434m,

0.761609962736885m,

},
                            NullableValue = 
new System.Decimal[4]
{
0.631256212298377m,

0.900732747369461m,

0.0253447344957826m,

0.0605754462686936m,

}
                        }

                    }
                );

                expected.Add(
                    1070446321,
                    new DecimalnumericArray1M
                    {
                        Id = 1070446321,
                        Value = 
new System.Decimal[3]
{
0.802858304233387m,

0.930211539843706m,

0.821987258143027m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.524081989899844m,

0.344075670102832m,

0.130533397824908m,

},

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 405219663,
                            Value = 
new System.Decimal[3]
{
0.814892888423264m,

0.644197589395732m,

0.1125124426437m,

},
                            NullableValue = 
new System.Decimal[4]
{
0.0235298466356579m,

0.70082263441205m,

0.115025107652443m,

0.673573885840338m,

}
                        }

                    }
                );

                expected.Add(
                    1263340027,
                    new DecimalnumericArray1M
                    {
                        Id = 1263340027,
                        Value = 
new System.Decimal[4]
{
0.114901119249173m,

0.835300182073698m,

0.862183024648071m,

0.928952987923253m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 1802070348,
                            Value = 
new System.Decimal[3]
{
0.500652392755636m,

0.856943238904947m,

0.249133800338953m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1271310123,
                    new DecimalnumericArray1M
                    {
                        Id = 1271310123,
                        Value = 
new System.Decimal[3]
{
0.352818123681143m,

0.823590600574034m,

0.663864599075235m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.0552213646435307m,

0.801008271562292m,

0.682693623617323m,

},

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 659192782,
                            Value = 
new System.Decimal[4]
{
0.784408630596159m,

0.326590134732045m,

0.706748565407806m,

0.70714341538462m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1360715309,
                    new DecimalnumericArray1M
                    {
                        Id = 1360715309,
                        Value = 
new System.Decimal[3]
{
0.261908214215052m,

0.210654276471595m,

0.863478059064684m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1437077957,
                    new DecimalnumericArray1M
                    {
                        Id = 1437077957,
                        Value = 
new System.Decimal[4]
{
0.00154420590750259m,

0.832397889829872m,

0.610334530115663m,

0.64418644840852m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1632277287,
                    new DecimalnumericArray1M
                    {
                        Id = 1632277287,
                        Value = 
new System.Decimal[4]
{
0.740845423062099m,

0.192856443839841m,

0.676531163938029m,

0.745948700176557m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1753210843,
                    new DecimalnumericArray1M
                    {
                        Id = 1753210843,
                        Value = 
new System.Decimal[3]
{
0.916769772881913m,

0.567020781896476m,

0.9478835173479m,

},
                        NullableValue = 
new System.Decimal[4]
{
0.491122538690252m,

0.948238144075311m,

0.87346955182962m,

0.962893590471046m,

},

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 109042517,
                            Value = 
new System.Decimal[3]
{
0.162812972763803m,

0.871473685385667m,

0.151976994708802m,

},
                            NullableValue = 
new System.Decimal[3]
{
0.0958054440869829m,

0.491548603531674m,

0.802813849544708m,

}
                        }

                    }
                );

                expected.Add(
                    1773872135,
                    new DecimalnumericArray1M
                    {
                        Id = 1773872135,
                        Value = 
new System.Decimal[4]
{
0.203369818001508m,

0.299211481277628m,

0.436804245520549m,

0.225472153906905m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.720718131865731m,

0.400667968682213m,

0.0391147048915961m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1888346957,
                    new DecimalnumericArray1M
                    {
                        Id = 1888346957,
                        Value = 
new System.Decimal[3]
{
0.655038384125233m,

0.494546225342795m,

0.214793000725172m,

},
                        NullableValue = 
new System.Decimal[4]
{
0.0170026041539578m,

0.749370461208432m,

0.0485792673212916m,

0.826584380369891m,

},

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 376018751,
                            Value = 
new System.Decimal[3]
{
0.285284799320274m,

0.326008956423491m,

0.158336442848866m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1981519788,
                    new DecimalnumericArray1M
                    {
                        Id = 1981519788,
                        Value = 
new System.Decimal[3]
{
0.379119266282213m,

0.880053419808111m,

0.513177856651464m,

},
                        NullableValue = 
new System.Decimal[4]
{
0.245584436378338m,

0.278630769588098m,

0.127043663851826m,

0.741955738302504m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2026148453,
                    new DecimalnumericArray1M
                    {
                        Id = 2026148453,
                        Value = 
new System.Decimal[3]
{
0.00175304556092548m,

0.219423357641208m,

0.454340333546278m,

},
                        NullableValue = 
new System.Decimal[4]
{
0.0143247803828197m,

0.228148089371708m,

0.255210017397057m,

0.752840241001218m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2047257074,
                    new DecimalnumericArray1M
                    {
                        Id = 2047257074,
                        Value = 
new System.Decimal[4]
{
0.0932479255368816m,

0.0301833862224875m,

0.8564217528517m,

0.648511265153376m,

},
                        NullableValue = 
new System.Decimal[4]
{
0.757211961836031m,

0.516208897744666m,

0.351346746448164m,

0.302614769465853m,

},

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 989496829,
                            Value = 
new System.Decimal[4]
{
0.79538355099661m,

0.341420965783442m,

0.20182686144094m,

0.259105149616439m,

},
                            NullableValue = 
new System.Decimal[4]
{
0.647339101314374m,

0.880252315020077m,

0.620730900706259m,

0.266031950292111m,

}
                        }

                    }
                );

                expected.Add(
                    2105850534,
                    new DecimalnumericArray1M
                    {
                        Id = 2105850534,
                        Value = 
new System.Decimal[3]
{
0.879272623584438m,

0.997812462529447m,

0.102298079062808m,

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal[])default));
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

                var expected = new Dictionary<System.Int32,DecimalnumericArray1M>(30);

                expected.Add(
                    4472279,
                    new DecimalnumericArray1M
                    {
                        Id = 4472279,
                        Value = 
new System.Decimal[3]
{
0.670739165704255m,

0.115430150727337m,

0.77471262428668m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    8800741,
                    new DecimalnumericArray1M
                    {
                        Id = 8800741,
                        Value = 
new System.Decimal[4]
{
0.198864665374831m,

0.286384074901691m,

0.683428746428832m,

0.895162087363908m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 2107226176,
                            Value = 
new System.Decimal[4]
{
0.31300535562594m,

0.325076535243441m,

0.191975226437568m,

0.176069793339158m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    32000850,
                    new DecimalnumericArray1M
                    {
                        Id = 32000850,
                        Value = 
new System.Decimal[4]
{
0.913575567242658m,

0.0615614900869352m,

0.769869774161311m,

0.814376428327162m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.421290647733418m,

0.255433137392199m,

0.363044360674116m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    43153943,
                    new DecimalnumericArray1M
                    {
                        Id = 43153943,
                        Value = 
new System.Decimal[4]
{
0.332300642589601m,

0.471643124100398m,

0.875514209342379m,

0.121027904813977m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 309647647,
                            Value = 
new System.Decimal[3]
{
0.0223984689592726m,

0.741701985071582m,

0.506528439131137m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    159905071,
                    new DecimalnumericArray1M
                    {
                        Id = 159905071,
                        Value = 
new System.Decimal[3]
{
0.753839702305756m,

0.126667817766743m,

0.304093578349578m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.449697430510138m,

0.765993015823156m,

0.905297705808181m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    201464680,
                    new DecimalnumericArray1M
                    {
                        Id = 201464680,
                        Value = 
new System.Decimal[3]
{
0.463302337588417m,

0.370629662336532m,

0.548034257027467m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.232929796134916m,

0.154055025465336m,

0.995804668768241m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    305442937,
                    new DecimalnumericArray1M
                    {
                        Id = 305442937,
                        Value = 
new System.Decimal[3]
{
0.00442434600889063m,

0.708893704034158m,

0.695959329016357m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.304236347756219m,

0.538940488013919m,

0.951903137544338m,

},

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 303286147,
                            Value = 
new System.Decimal[3]
{
0.289003967296092m,

0.230715463670717m,

0.634289943023537m,

},
                            NullableValue = 
new System.Decimal[3]
{
0.90430136229428m,

0.265520434230188m,

0.0882482286785835m,

}
                        }

                    }
                );

                expected.Add(
                    306247634,
                    new DecimalnumericArray1M
                    {
                        Id = 306247634,
                        Value = 
new System.Decimal[4]
{
0.642302896448763m,

0.0939550411266639m,

0.396298884654832m,

0.544525438222112m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    451738282,
                    new DecimalnumericArray1M
                    {
                        Id = 451738282,
                        Value = 
new System.Decimal[4]
{
0.810837131956553m,

0.162300402571884m,

0.282674942099437m,

0.488846588453153m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.921969052649128m,

0.605019690498457m,

0.798121603649053m,

},

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 984438229,
                            Value = 
new System.Decimal[3]
{
0.0741905663217527m,

0.268226072193604m,

0.318138234199345m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    475066646,
                    new DecimalnumericArray1M
                    {
                        Id = 475066646,
                        Value = 
new System.Decimal[4]
{
0.699533766733219m,

0.764632014886774m,

0.588266643055788m,

0.270395949931969m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.744183241846793m,

0.193872558859702m,

0.611955518975458m,

},

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 1885056944,
                            Value = 
new System.Decimal[4]
{
0.568883731803848m,

0.494724047248429m,

0.626013261435883m,

0.688973982853637m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    483348140,
                    new DecimalnumericArray1M
                    {
                        Id = 483348140,
                        Value = 
new System.Decimal[4]
{
0.235380630453438m,

0.826330004289329m,

0.680774771392299m,

0.624690250671274m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 298762578,
                            Value = 
new System.Decimal[4]
{
0.780435546177952m,

0.927047629858877m,

0.845070163448652m,

0.0698609253832982m,

},
                            NullableValue = 
new System.Decimal[3]
{
0.347830774083804m,

0.258149875687242m,

0.640270661649344m,

}
                        }

                    }
                );

                expected.Add(
                    704906698,
                    new DecimalnumericArray1M
                    {
                        Id = 704906698,
                        Value = 
new System.Decimal[4]
{
0.228357879737918m,

0.844292770150332m,

0.193605402427148m,

0.910272329050301m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 2031459247,
                            Value = 
new System.Decimal[4]
{
0.988162986683755m,

0.946326933719384m,

0.105785481283932m,

0.457455767107011m,

},
                            NullableValue = 
new System.Decimal[4]
{
0.668178001735014m,

0.0261309955467016m,

0.109480344091357m,

0.937907531897102m,

}
                        }

                    }
                );

                expected.Add(
                    775147825,
                    new DecimalnumericArray1M
                    {
                        Id = 775147825,
                        Value = 
new System.Decimal[4]
{
0.786188446159501m,

0.468384468576442m,

0.0489489316706514m,

0.877494628915112m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    959648092,
                    new DecimalnumericArray1M
                    {
                        Id = 959648092,
                        Value = 
new System.Decimal[3]
{
0.674600854216564m,

0.0588175653885267m,

0.693593299124215m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 1798995844,
                            Value = 
new System.Decimal[3]
{
0.343122150810035m,

0.908817296072129m,

0.460561041119878m,

},
                            NullableValue = 
new System.Decimal[3]
{
0.43746426828906m,

0.462290235511666m,

0.174449967688479m,

}
                        }

                    }
                );

                expected.Add(
                    988453307,
                    new DecimalnumericArray1M
                    {
                        Id = 988453307,
                        Value = 
new System.Decimal[3]
{
0.695013069422763m,

0.0683582645592904m,

0.202507903790901m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1015440465,
                    new DecimalnumericArray1M
                    {
                        Id = 1015440465,
                        Value = 
new System.Decimal[3]
{
0.0442505885074315m,

0.171677856058679m,

0.822341341981591m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1024910545,
                    new DecimalnumericArray1M
                    {
                        Id = 1024910545,
                        Value = 
new System.Decimal[4]
{
0.14261366059483m,

0.435990139492505m,

0.391420749560393m,

0.968772200172711m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 229079168,
                            Value = 
new System.Decimal[3]
{
0.270041495025426m,

0.313447659801434m,

0.761609962736885m,

},
                            NullableValue = 
new System.Decimal[4]
{
0.631256212298377m,

0.900732747369461m,

0.0253447344957826m,

0.0605754462686936m,

}
                        }

                    }
                );

                expected.Add(
                    1070446321,
                    new DecimalnumericArray1M
                    {
                        Id = 1070446321,
                        Value = 
new System.Decimal[3]
{
0.802858304233387m,

0.930211539843706m,

0.821987258143027m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.524081989899844m,

0.344075670102832m,

0.130533397824908m,

},

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 405219663,
                            Value = 
new System.Decimal[3]
{
0.814892888423264m,

0.644197589395732m,

0.1125124426437m,

},
                            NullableValue = 
new System.Decimal[4]
{
0.0235298466356579m,

0.70082263441205m,

0.115025107652443m,

0.673573885840338m,

}
                        }

                    }
                );

                expected.Add(
                    1263340027,
                    new DecimalnumericArray1M
                    {
                        Id = 1263340027,
                        Value = 
new System.Decimal[4]
{
0.114901119249173m,

0.835300182073698m,

0.862183024648071m,

0.928952987923253m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 1802070348,
                            Value = 
new System.Decimal[3]
{
0.500652392755636m,

0.856943238904947m,

0.249133800338953m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1271310123,
                    new DecimalnumericArray1M
                    {
                        Id = 1271310123,
                        Value = 
new System.Decimal[3]
{
0.352818123681143m,

0.823590600574034m,

0.663864599075235m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.0552213646435307m,

0.801008271562292m,

0.682693623617323m,

},

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 659192782,
                            Value = 
new System.Decimal[4]
{
0.784408630596159m,

0.326590134732045m,

0.706748565407806m,

0.70714341538462m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1360715309,
                    new DecimalnumericArray1M
                    {
                        Id = 1360715309,
                        Value = 
new System.Decimal[3]
{
0.261908214215052m,

0.210654276471595m,

0.863478059064684m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1437077957,
                    new DecimalnumericArray1M
                    {
                        Id = 1437077957,
                        Value = 
new System.Decimal[4]
{
0.00154420590750259m,

0.832397889829872m,

0.610334530115663m,

0.64418644840852m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1632277287,
                    new DecimalnumericArray1M
                    {
                        Id = 1632277287,
                        Value = 
new System.Decimal[4]
{
0.740845423062099m,

0.192856443839841m,

0.676531163938029m,

0.745948700176557m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1753210843,
                    new DecimalnumericArray1M
                    {
                        Id = 1753210843,
                        Value = 
new System.Decimal[3]
{
0.916769772881913m,

0.567020781896476m,

0.9478835173479m,

},
                        NullableValue = 
new System.Decimal[4]
{
0.491122538690252m,

0.948238144075311m,

0.87346955182962m,

0.962893590471046m,

},

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 109042517,
                            Value = 
new System.Decimal[3]
{
0.162812972763803m,

0.871473685385667m,

0.151976994708802m,

},
                            NullableValue = 
new System.Decimal[3]
{
0.0958054440869829m,

0.491548603531674m,

0.802813849544708m,

}
                        }

                    }
                );

                expected.Add(
                    1773872135,
                    new DecimalnumericArray1M
                    {
                        Id = 1773872135,
                        Value = 
new System.Decimal[4]
{
0.203369818001508m,

0.299211481277628m,

0.436804245520549m,

0.225472153906905m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.720718131865731m,

0.400667968682213m,

0.0391147048915961m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1888346957,
                    new DecimalnumericArray1M
                    {
                        Id = 1888346957,
                        Value = 
new System.Decimal[3]
{
0.655038384125233m,

0.494546225342795m,

0.214793000725172m,

},
                        NullableValue = 
new System.Decimal[4]
{
0.0170026041539578m,

0.749370461208432m,

0.0485792673212916m,

0.826584380369891m,

},

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 376018751,
                            Value = 
new System.Decimal[3]
{
0.285284799320274m,

0.326008956423491m,

0.158336442848866m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1981519788,
                    new DecimalnumericArray1M
                    {
                        Id = 1981519788,
                        Value = 
new System.Decimal[3]
{
0.379119266282213m,

0.880053419808111m,

0.513177856651464m,

},
                        NullableValue = 
new System.Decimal[4]
{
0.245584436378338m,

0.278630769588098m,

0.127043663851826m,

0.741955738302504m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2026148453,
                    new DecimalnumericArray1M
                    {
                        Id = 2026148453,
                        Value = 
new System.Decimal[3]
{
0.00175304556092548m,

0.219423357641208m,

0.454340333546278m,

},
                        NullableValue = 
new System.Decimal[4]
{
0.0143247803828197m,

0.228148089371708m,

0.255210017397057m,

0.752840241001218m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2047257074,
                    new DecimalnumericArray1M
                    {
                        Id = 2047257074,
                        Value = 
new System.Decimal[4]
{
0.0932479255368816m,

0.0301833862224875m,

0.8564217528517m,

0.648511265153376m,

},
                        NullableValue = 
new System.Decimal[4]
{
0.757211961836031m,

0.516208897744666m,

0.351346746448164m,

0.302614769465853m,

},

                        ModelInner = new DecimalnumericArray1MI
                        {
                            Id = 989496829,
                            Value = 
new System.Decimal[4]
{
0.79538355099661m,

0.341420965783442m,

0.20182686144094m,

0.259105149616439m,

},
                            NullableValue = 
new System.Decimal[4]
{
0.647339101314374m,

0.880252315020077m,

0.620730900706259m,

0.266031950292111m,

}
                        }

                    }
                );

                expected.Add(
                    2105850534,
                    new DecimalnumericArray1M
                    {
                        Id = 2105850534,
                        Value = 
new System.Decimal[3]
{
0.879272623584438m,

0.997812462529447m,

0.102298079062808m,

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal[])default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(DecimalnumericArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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

                var expected = new Dictionary<System.Int32,DecimalnumericArray1MI>(15);

                expected.Add(
                    109042517,
                    new DecimalnumericArray1MI
                    {
                        Id = 109042517,
                        Value = 
new System.Decimal[3]
{
0.162812972763803m,

0.871473685385667m,

0.151976994708802m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.0958054440869829m,

0.491548603531674m,

0.802813849544708m,

}
                    }
                );

                expected.Add(
                    229079168,
                    new DecimalnumericArray1MI
                    {
                        Id = 229079168,
                        Value = 
new System.Decimal[3]
{
0.270041495025426m,

0.313447659801434m,

0.761609962736885m,

},
                        NullableValue = 
new System.Decimal[4]
{
0.631256212298377m,

0.900732747369461m,

0.0253447344957826m,

0.0605754462686936m,

}
                    }
                );

                expected.Add(
                    298762578,
                    new DecimalnumericArray1MI
                    {
                        Id = 298762578,
                        Value = 
new System.Decimal[4]
{
0.780435546177952m,

0.927047629858877m,

0.845070163448652m,

0.0698609253832982m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.347830774083804m,

0.258149875687242m,

0.640270661649344m,

}
                    }
                );

                expected.Add(
                    303286147,
                    new DecimalnumericArray1MI
                    {
                        Id = 303286147,
                        Value = 
new System.Decimal[3]
{
0.289003967296092m,

0.230715463670717m,

0.634289943023537m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.90430136229428m,

0.265520434230188m,

0.0882482286785835m,

}
                    }
                );

                expected.Add(
                    309647647,
                    new DecimalnumericArray1MI
                    {
                        Id = 309647647,
                        Value = 
new System.Decimal[3]
{
0.0223984689592726m,

0.741701985071582m,

0.506528439131137m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    376018751,
                    new DecimalnumericArray1MI
                    {
                        Id = 376018751,
                        Value = 
new System.Decimal[3]
{
0.285284799320274m,

0.326008956423491m,

0.158336442848866m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    405219663,
                    new DecimalnumericArray1MI
                    {
                        Id = 405219663,
                        Value = 
new System.Decimal[3]
{
0.814892888423264m,

0.644197589395732m,

0.1125124426437m,

},
                        NullableValue = 
new System.Decimal[4]
{
0.0235298466356579m,

0.70082263441205m,

0.115025107652443m,

0.673573885840338m,

}
                    }
                );

                expected.Add(
                    659192782,
                    new DecimalnumericArray1MI
                    {
                        Id = 659192782,
                        Value = 
new System.Decimal[4]
{
0.784408630596159m,

0.326590134732045m,

0.706748565407806m,

0.70714341538462m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    984438229,
                    new DecimalnumericArray1MI
                    {
                        Id = 984438229,
                        Value = 
new System.Decimal[3]
{
0.0741905663217527m,

0.268226072193604m,

0.318138234199345m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    989496829,
                    new DecimalnumericArray1MI
                    {
                        Id = 989496829,
                        Value = 
new System.Decimal[4]
{
0.79538355099661m,

0.341420965783442m,

0.20182686144094m,

0.259105149616439m,

},
                        NullableValue = 
new System.Decimal[4]
{
0.647339101314374m,

0.880252315020077m,

0.620730900706259m,

0.266031950292111m,

}
                    }
                );

                expected.Add(
                    1798995844,
                    new DecimalnumericArray1MI
                    {
                        Id = 1798995844,
                        Value = 
new System.Decimal[3]
{
0.343122150810035m,

0.908817296072129m,

0.460561041119878m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.43746426828906m,

0.462290235511666m,

0.174449967688479m,

}
                    }
                );

                expected.Add(
                    1802070348,
                    new DecimalnumericArray1MI
                    {
                        Id = 1802070348,
                        Value = 
new System.Decimal[3]
{
0.500652392755636m,

0.856943238904947m,

0.249133800338953m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1885056944,
                    new DecimalnumericArray1MI
                    {
                        Id = 1885056944,
                        Value = 
new System.Decimal[4]
{
0.568883731803848m,

0.494724047248429m,

0.626013261435883m,

0.688973982853637m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2031459247,
                    new DecimalnumericArray1MI
                    {
                        Id = 2031459247,
                        Value = 
new System.Decimal[4]
{
0.988162986683755m,

0.946326933719384m,

0.105785481283932m,

0.457455767107011m,

},
                        NullableValue = 
new System.Decimal[4]
{
0.668178001735014m,

0.0261309955467016m,

0.109480344091357m,

0.937907531897102m,

}
                    }
                );

                expected.Add(
                    2107226176,
                    new DecimalnumericArray1MI
                    {
                        Id = 2107226176,
                        Value = 
new System.Decimal[4]
{
0.31300535562594m,

0.325076535243441m,

0.191975226437568m,

0.176069793339158m,

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

                var expected = new Dictionary<System.Int32,DecimalnumericArray1MI>(15);

                expected.Add(
                    109042517,
                    new DecimalnumericArray1MI
                    {
                        Id = 109042517,
                        Value = 
new System.Decimal[3]
{
0.162812972763803m,

0.871473685385667m,

0.151976994708802m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.0958054440869829m,

0.491548603531674m,

0.802813849544708m,

}
                    }
                );

                expected.Add(
                    229079168,
                    new DecimalnumericArray1MI
                    {
                        Id = 229079168,
                        Value = 
new System.Decimal[3]
{
0.270041495025426m,

0.313447659801434m,

0.761609962736885m,

},
                        NullableValue = 
new System.Decimal[4]
{
0.631256212298377m,

0.900732747369461m,

0.0253447344957826m,

0.0605754462686936m,

}
                    }
                );

                expected.Add(
                    298762578,
                    new DecimalnumericArray1MI
                    {
                        Id = 298762578,
                        Value = 
new System.Decimal[4]
{
0.780435546177952m,

0.927047629858877m,

0.845070163448652m,

0.0698609253832982m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.347830774083804m,

0.258149875687242m,

0.640270661649344m,

}
                    }
                );

                expected.Add(
                    303286147,
                    new DecimalnumericArray1MI
                    {
                        Id = 303286147,
                        Value = 
new System.Decimal[3]
{
0.289003967296092m,

0.230715463670717m,

0.634289943023537m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.90430136229428m,

0.265520434230188m,

0.0882482286785835m,

}
                    }
                );

                expected.Add(
                    309647647,
                    new DecimalnumericArray1MI
                    {
                        Id = 309647647,
                        Value = 
new System.Decimal[3]
{
0.0223984689592726m,

0.741701985071582m,

0.506528439131137m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    376018751,
                    new DecimalnumericArray1MI
                    {
                        Id = 376018751,
                        Value = 
new System.Decimal[3]
{
0.285284799320274m,

0.326008956423491m,

0.158336442848866m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    405219663,
                    new DecimalnumericArray1MI
                    {
                        Id = 405219663,
                        Value = 
new System.Decimal[3]
{
0.814892888423264m,

0.644197589395732m,

0.1125124426437m,

},
                        NullableValue = 
new System.Decimal[4]
{
0.0235298466356579m,

0.70082263441205m,

0.115025107652443m,

0.673573885840338m,

}
                    }
                );

                expected.Add(
                    659192782,
                    new DecimalnumericArray1MI
                    {
                        Id = 659192782,
                        Value = 
new System.Decimal[4]
{
0.784408630596159m,

0.326590134732045m,

0.706748565407806m,

0.70714341538462m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    984438229,
                    new DecimalnumericArray1MI
                    {
                        Id = 984438229,
                        Value = 
new System.Decimal[3]
{
0.0741905663217527m,

0.268226072193604m,

0.318138234199345m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    989496829,
                    new DecimalnumericArray1MI
                    {
                        Id = 989496829,
                        Value = 
new System.Decimal[4]
{
0.79538355099661m,

0.341420965783442m,

0.20182686144094m,

0.259105149616439m,

},
                        NullableValue = 
new System.Decimal[4]
{
0.647339101314374m,

0.880252315020077m,

0.620730900706259m,

0.266031950292111m,

}
                    }
                );

                expected.Add(
                    1798995844,
                    new DecimalnumericArray1MI
                    {
                        Id = 1798995844,
                        Value = 
new System.Decimal[3]
{
0.343122150810035m,

0.908817296072129m,

0.460561041119878m,

},
                        NullableValue = 
new System.Decimal[3]
{
0.43746426828906m,

0.462290235511666m,

0.174449967688479m,

}
                    }
                );

                expected.Add(
                    1802070348,
                    new DecimalnumericArray1MI
                    {
                        Id = 1802070348,
                        Value = 
new System.Decimal[3]
{
0.500652392755636m,

0.856943238904947m,

0.249133800338953m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1885056944,
                    new DecimalnumericArray1MI
                    {
                        Id = 1885056944,
                        Value = 
new System.Decimal[4]
{
0.568883731803848m,

0.494724047248429m,

0.626013261435883m,

0.688973982853637m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2031459247,
                    new DecimalnumericArray1MI
                    {
                        Id = 2031459247,
                        Value = 
new System.Decimal[4]
{
0.988162986683755m,

0.946326933719384m,

0.105785481283932m,

0.457455767107011m,

},
                        NullableValue = 
new System.Decimal[4]
{
0.668178001735014m,

0.0261309955467016m,

0.109480344091357m,

0.937907531897102m,

}
                    }
                );

                expected.Add(
                    2107226176,
                    new DecimalnumericArray1MI
                    {
                        Id = 2107226176,
                        Value = 
new System.Decimal[4]
{
0.31300535562594m,

0.325076535243441m,

0.191975226437568m,

0.176069793339158m,

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

