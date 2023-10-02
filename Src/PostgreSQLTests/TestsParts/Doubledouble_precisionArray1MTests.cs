

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
    internal partial interface IDoubleArraydouble_precisionArray
    {
    }
    
    internal partial class DoubleArraydouble_precisionArray : IDoubleArraydouble_precisionArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1mi(
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1mi(
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
            queryMapType: typeof(Doubledouble_precisionArray1MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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

                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModelInner(connection, 283357821, 
new System.Double[3]
{
0.3762026568414524d,

0.6514616109727247d,

0.10666446093329995d,

}, 
new System.Double[3]
{
0.6350965768202388d,

0.7364449970239656d,

0.6170729620999107d,

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModelInner(connection, 876498087, 
new System.Double[4]
{
0.5839587573934504d,

0.16229959953844164d,

0.05166021542799504d,

0.054705171681251774d,

}, 
new System.Double[3]
{
0.4455950978835691d,

0.012889239254036622d,

0.365911697962618d,

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

                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerAsync(connection, 1396062439, 
new System.Double[3]
{
0.36043031673652803d,

0.44920721772598715d,

0.9547082859041273d,

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerAsync(connection, 2134784495, 
new System.Double[4]
{
0.6635684089337649d,

0.6914516866463486d,

0.3407343143346171d,

0.8163857880904707d,

}, 
new System.Double[4]
{
0.23571376152551826d,

0.5892834748663432d,

0.16218047163404392d,

0.812415723693509d,

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

                id =  ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturning(connection, 1401688209, 
new System.Double[3]
{
0.7285949238283712d,

0.5733599435593822d,

0.34086697138841326d,

}, 
new System.Double[3]
{
0.019003561494990606d,

0.5673454033171191d,

0.45191953211306135d,

});
                Assert.That(id, Is.EqualTo(1401688209));

                id =  ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturning(connection, 665941176, 
new System.Double[4]
{
0.6007345284456123d,

0.4345557997433672d,

0.9270897092020428d,

0.8441201074343846d,

}, null);
                Assert.That(id, Is.EqualTo(665941176));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, 1914047110, 
new System.Double[3]
{
0.9866980079367033d,

0.9711114290457674d,

0.6336203270722464d,

}, null);
                Assert.That(id, Is.EqualTo(1914047110));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, 871153277, 
new System.Double[4]
{
0.8647330702863328d,

0.7504311628925787d,

0.3558642039145814d,

0.381219391709971d,

}, null);
                Assert.That(id, Is.EqualTo(871153277));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, 1073531153, 
new System.Double[4]
{
0.5852876008048172d,

0.8650137972125318d,

0.6720127322882606d,

0.8579926724905216d,

}, null);
                Assert.That(id, Is.EqualTo(1073531153));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, 1123512386, 
new System.Double[3]
{
0.7924057872325804d,

0.18826557079246586d,

0.8980023770287593d,

}, 
new System.Double[3]
{
0.18052220548543152d,

0.7794956319484363d,

0.4287157896768359d,

});
                Assert.That(id, Is.EqualTo(1123512386));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, 553025882, 
new System.Double[4]
{
0.7069224121325174d,

0.2285607987772753d,

0.7939711165074208d,

0.7284294422963341d,

}, 
new System.Double[3]
{
0.4888467126362911d,

0.550874212734459d,

0.6844178701315258d,

});
                Assert.That(id, Is.EqualTo(553025882));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, 1176809754, 
new System.Double[4]
{
0.3651109639924942d,

0.8856804349654391d,

0.6556235637359085d,

0.35150967423249546d,

}, null);
                Assert.That(id, Is.EqualTo(1176809754));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, 1035409201, 
new System.Double[4]
{
0.7047759882347794d,

0.2341035414238981d,

0.3458497864102972d,

0.6617110491944888d,

}, null);
                Assert.That(id, Is.EqualTo(1035409201));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, 1287977328, 
new System.Double[4]
{
0.3919606767987358d,

0.8958643836111312d,

0.3634904771594514d,

0.8432371463341493d,

}, null);
                Assert.That(id, Is.EqualTo(1287977328));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, 1868142384, 
new System.Double[3]
{
0.6312408406261761d,

0.6910384091661451d,

0.33584671391491183d,

}, 
new System.Double[4]
{
0.6792415009961253d,

0.42942852389095576d,

0.45368987899691815d,

0.15879378615614492d,

});
                Assert.That(id, Is.EqualTo(1868142384));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray1mi_id
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray1mi_id", 
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

                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModel(connection, 1274836410, 
new System.Double[3]
{
0.012300482333735707d,

0.8575843030300441d,

0.3953199073284702d,

}, 
new System.Double[3]
{
0.3802873805132805d,

0.7760282343876094d,

0.24367375090782895d,

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModel(connection, 1298776905, 
new System.Double[3]
{
0.026920823934105664d,

0.2060699798435608d,

0.6784094784107302d,

}, null, 283357821);
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

                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelAsync(connection, 568952966, 
new System.Double[4]
{
0.2549081299446322d,

0.4684485171098728d,

0.7180646054817073d,

0.14333429471865333d,

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelAsync(connection, 1933081192, 
new System.Double[4]
{
0.9138765666850975d,

0.6503755818904282d,

0.5404800306134858d,

0.8912883104673369d,

}, null, 876498087);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Double[] nullable = null;

                nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturning(connection, 1965640956, 
new System.Double[3]
{
0.8799786113245733d,

0.103766859942518d,

0.007847165902295394d,

}, null, null);

                Assert.That(nullable, Is.Null);

                nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturning(connection, 324204378, 
new System.Double[4]
{
0.7129182666882694d,

0.5773018813104558d,

0.1303178521027032d,

0.24777695457455828d,

}, null, 1396062439);

                Assert.That(nullable, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Double[] nullable = null;

                nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturningAsync(connection, 246200596, 
new System.Double[4]
{
0.6528826774753668d,

0.6254299247853704d,

0.47543566122314207d,

0.7930281335726063d,

}, 
new System.Double[4]
{
0.567069722078047d,

0.09427310691668289d,

0.3642694593425063d,

0.005828726918219007d,

}, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.567069722078047d,

0.09427310691668289d,

0.3642694593425063d,

0.005828726918219007d,

}));

                nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturningAsync(connection, 960794115, 
new System.Double[4]
{
0.8584340768029776d,

0.338983987976771d,

0.5165072379349526d,

0.48768908889282836d,

}, 
new System.Double[4]
{
0.42645607878473624d,

0.8045629062412712d,

0.5842290059804607d,

0.53049592839275d,

}, 2134784495);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.42645607878473624d,

0.8045629062412712d,

0.5842290059804607d,

0.53049592839275d,

}));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray1mi_id
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
    doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(Doubledouble_precisionArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray1mi_id", 
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
                List<Doubledouble_precisionArray1M> models = null;
                Doubledouble_precisionArray1M model = null;

                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, 869025017, 
new System.Double[4]
{
0.23029619671977453d,

0.9963881322054496d,

0.29922279043314304d,

0.553359254492766d,

}, 
new System.Double[4]
{
0.1045379747229116d,

0.25625702200631595d,

0.3270116864275764d,

0.19231856481547016d,

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(869025017));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.23029619671977453d,

0.9963881322054496d,

0.29922279043314304d,

0.553359254492766d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.1045379747229116d,

0.25625702200631595d,

0.3270116864275764d,

0.19231856481547016d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, 1228851149, 
new System.Double[4]
{
0.3046752293818199d,

0.8954081781400294d,

0.20001431036328188d,

0.6588513650063575d,

}, 
new System.Double[4]
{
0.016354803552207975d,

0.10753335442476042d,

0.5683871269850892d,

0.31836105153449645d,

}, 1401688209).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1228851149));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3046752293818199d,

0.8954081781400294d,

0.20001431036328188d,

0.6588513650063575d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.016354803552207975d,

0.10753335442476042d,

0.5683871269850892d,

0.31836105153449645d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1401688209));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Double[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, 1216459642, 
new System.Double[3]
{
0.4228646939171534d,

0.48723305829751273d,

0.9874945307068991d,

}, 
new System.Double[3]
{
0.3406725270833162d,

0.6278874871110163d,

0.3397053760273837d,

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1216459642));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4228646939171534d,

0.48723305829751273d,

0.9874945307068991d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.3406725270833162d,

0.6278874871110163d,

0.3397053760273837d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, 815594684, 
new System.Double[3]
{
0.9268337039277679d,

0.2557880366788481d,

0.9708486737945278d,

}, 
new System.Double[3]
{
0.8293420330004952d,

0.6751324902712372d,

0.11744019681431705d,

}, 665941176).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(815594684));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9268337039277679d,

0.2557880366788481d,

0.9708486737945278d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8293420330004952d,

0.6751324902712372d,

0.11744019681431705d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(665941176));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Double[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray1M> models = null;
                Doubledouble_precisionArray1M model = null;

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, 321358953, 
new System.Double[4]
{
0.7800843247230342d,

0.4214549731905376d,

0.7333459397056095d,

0.755163516995959d,

}, 
new System.Double[4]
{
0.026376353541849196d,

0.15951410997648519d,

0.5345173275701939d,

0.022759667888013313d,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(321358953));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7800843247230342d,

0.4214549731905376d,

0.7333459397056095d,

0.755163516995959d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.026376353541849196d,

0.15951410997648519d,

0.5345173275701939d,

0.022759667888013313d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, 617985466, 
new System.Double[4]
{
0.29893900988049793d,

0.3006011137146485d,

0.7983268410297981d,

0.07027811884628865d,

}, 
new System.Double[4]
{
0.022666264179675877d,

0.6168211486873275d,

0.9250709010204006d,

0.31456810051666817d,

}, 1914047110).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(617985466));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.29893900988049793d,

0.3006011137146485d,

0.7983268410297981d,

0.07027811884628865d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.022666264179675877d,

0.6168211486873275d,

0.9250709010204006d,

0.31456810051666817d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1914047110));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Double[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, 1930734881, 
new System.Double[3]
{
0.8844858358873939d,

0.688392437185428d,

0.5512043776449784d,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1930734881));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8844858358873939d,

0.688392437185428d,

0.5512043776449784d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, 1881675292, 
new System.Double[3]
{
0.13944961052197546d,

0.941374159723203d,

0.6535728631023234d,

}, null, 871153277).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1881675292));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.13944961052197546d,

0.941374159723203d,

0.6535728631023234d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871153277));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Double[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, 890753535, 
new System.Double[3]
{
0.006972482696241178d,

0.8870497280113498d,

0.5029194269663007d,

}, 
new System.Double[3]
{
0.37397243565318894d,

0.9666530847812052d,

0.7321744421541623d,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(890753535));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.006972482696241178d,

0.8870497280113498d,

0.5029194269663007d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.37397243565318894d,

0.9666530847812052d,

0.7321744421541623d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, 1262879363, 
new System.Double[4]
{
0.4812440527288484d,

0.3199784489919435d,

0.6382731473826979d,

0.09322032397536795d,

}, 
new System.Double[4]
{
0.018902743328656157d,

0.3517789945819232d,

0.8934958952939568d,

0.31341251587473284d,

}, 1073531153).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1262879363));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.4812440527288484d,

0.3199784489919435d,

0.6382731473826979d,

0.09322032397536795d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.018902743328656157d,

0.3517789945819232d,

0.8934958952939568d,

0.31341251587473284d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1073531153));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Double[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, 1352713090, 
new System.Double[4]
{
0.6083786222771096d,

0.0001882889314861469d,

0.5100959647529927d,

0.7823528511953681d,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1352713090));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6083786222771096d,

0.0001882889314861469d,

0.5100959647529927d,

0.7823528511953681d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, 1064547311, 
new System.Double[4]
{
0.1893886152587244d,

0.5275227744645564d,

0.2713623619895643d,

0.3168228462103305d,

}, 
new System.Double[4]
{
0.8735754679742028d,

0.326431225255876d,

0.3453472790929043d,

0.29467838540432656d,

}, 1123512386).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1064547311));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.1893886152587244d,

0.5275227744645564d,

0.2713623619895643d,

0.3168228462103305d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8735754679742028d,

0.326431225255876d,

0.3453472790929043d,

0.29467838540432656d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1123512386));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Double[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, 325108454, 
new System.Double[4]
{
0.31744060975243693d,

0.4950576982196667d,

0.4511517060268161d,

0.23353987185161118d,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(325108454));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.31744060975243693d,

0.4950576982196667d,

0.4511517060268161d,

0.23353987185161118d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, 1389729061, 
new System.Double[4]
{
0.5768159718249714d,

0.27508325139879664d,

0.08248744166938815d,

0.7328876773389819d,

}, null, 553025882).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1389729061));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5768159718249714d,

0.27508325139879664d,

0.08248744166938815d,

0.7328876773389819d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(553025882));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Double[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, 1558321686, 
new System.Double[4]
{
0.9955207480528168d,

0.9708940640207901d,

0.22478258056371947d,

0.016843841508443202d,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1558321686));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.9955207480528168d,

0.9708940640207901d,

0.22478258056371947d,

0.016843841508443202d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, 720084900, 
new System.Double[4]
{
0.5855030491938493d,

0.3828814855553848d,

0.42799369300590395d,

0.30072275365795853d,

}, 
new System.Double[4]
{
0.5595663268717557d,

0.42641902337908355d,

0.8355087159933785d,

0.1260374739386727d,

}, 1176809754).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(720084900));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5855030491938493d,

0.3828814855553848d,

0.42799369300590395d,

0.30072275365795853d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5595663268717557d,

0.42641902337908355d,

0.8355087159933785d,

0.1260374739386727d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1176809754));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Double[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, 481026883, 
new System.Double[3]
{
0.9085386978293561d,

0.1857654354361994d,

0.41827195921626836d,

}, 
new System.Double[4]
{
0.404034260825876d,

0.5965103178780428d,

0.603258001042972d,

0.64688471673662d,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(481026883));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9085386978293561d,

0.1857654354361994d,

0.41827195921626836d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.404034260825876d,

0.5965103178780428d,

0.603258001042972d,

0.64688471673662d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, 515166406, 
new System.Double[3]
{
0.14740678647980743d,

0.8920088270848197d,

0.10405608417091272d,

}, null, 1035409201).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(515166406));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.14740678647980743d,

0.8920088270848197d,

0.10405608417091272d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1035409201));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Double[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, 1735897709, 
new System.Double[4]
{
0.3669470742487849d,

0.16379944902051724d,

0.7658934828651761d,

0.47248375887341765d,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735897709));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3669470742487849d,

0.16379944902051724d,

0.7658934828651761d,

0.47248375887341765d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, 1298233660, 
new System.Double[4]
{
0.6675363277475983d,

0.6926681157494187d,

0.8126962414663714d,

0.29746421327564687d,

}, 
new System.Double[3]
{
0.7096145407687857d,

0.08460224047984088d,

0.46365613795342464d,

}, 1287977328).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1298233660));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6675363277475983d,

0.6926681157494187d,

0.8126962414663714d,

0.29746421327564687d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.7096145407687857d,

0.08460224047984088d,

0.46365613795342464d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1287977328));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Double[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, 689918638, 
new System.Double[3]
{
0.9876768189493348d,

0.3950903873550714d,

0.9050025457274901d,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(689918638));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9876768189493348d,

0.3950903873550714d,

0.9050025457274901d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, 485575216, 
new System.Double[4]
{
0.8671908145349809d,

0.9049378669775808d,

0.18213312490514433d,

0.4613375807858682d,

}, 
new System.Double[4]
{
0.14039778989028162d,

0.5962485072187153d,

0.5871815298295686d,

0.8632846246479523d,

}, 1868142384).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(485575216));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8671908145349809d,

0.9049378669775808d,

0.18213312490514433d,

0.4613375807858682d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.14039778989028162d,

0.5962485072187153d,

0.5871815298295686d,

0.8632846246479523d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1868142384));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Double[])default));
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(Doubledouble_precisionArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)
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
                var models =  ((IDoubleArraydouble_precisionArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(246200596));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6528826774753668d,

0.6254299247853704d,

0.47543566122314207d,

0.7930281335726063d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.567069722078047d,

0.09427310691668289d,

0.3642694593425063d,

0.005828726918219007d,

};
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
                Assert.That(model.Id, Is.EqualTo(321358953));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7800843247230342d,

0.4214549731905376d,

0.7333459397056095d,

0.755163516995959d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.026376353541849196d,

0.15951410997648519d,

0.5345173275701939d,

0.022759667888013313d,

};
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
                Assert.That(model.Id, Is.EqualTo(324204378));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7129182666882694d,

0.5773018813104558d,

0.1303178521027032d,

0.24777695457455828d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1396062439));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.36043031673652803d,

0.44920721772598715d,

0.9547082859041273d,

};
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
                Assert.That(model.Id, Is.EqualTo(325108454));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.31744060975243693d,

0.4950576982196667d,

0.4511517060268161d,

0.23353987185161118d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(481026883));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9085386978293561d,

0.1857654354361994d,

0.41827195921626836d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.404034260825876d,

0.5965103178780428d,

0.603258001042972d,

0.64688471673662d,

};
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
                Assert.That(model.Id, Is.EqualTo(485575216));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8671908145349809d,

0.9049378669775808d,

0.18213312490514433d,

0.4613375807858682d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.14039778989028162d,

0.5962485072187153d,

0.5871815298295686d,

0.8632846246479523d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1868142384));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.6312408406261761d,

0.6910384091661451d,

0.33584671391491183d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6792415009961253d,

0.42942852389095576d,

0.45368987899691815d,

0.15879378615614492d,

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
                Assert.That(model.Id, Is.EqualTo(515166406));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.14740678647980743d,

0.8920088270848197d,

0.10405608417091272d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1035409201));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7047759882347794d,

0.2341035414238981d,

0.3458497864102972d,

0.6617110491944888d,

};
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
                Assert.That(model.Id, Is.EqualTo(568952966));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.2549081299446322d,

0.4684485171098728d,

0.7180646054817073d,

0.14333429471865333d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(617985466));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.29893900988049793d,

0.3006011137146485d,

0.7983268410297981d,

0.07027811884628865d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.022666264179675877d,

0.6168211486873275d,

0.9250709010204006d,

0.31456810051666817d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1914047110));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9866980079367033d,

0.9711114290457674d,

0.6336203270722464d,

};
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
                Assert.That(model.Id, Is.EqualTo(689918638));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9876768189493348d,

0.3950903873550714d,

0.9050025457274901d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(720084900));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5855030491938493d,

0.3828814855553848d,

0.42799369300590395d,

0.30072275365795853d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5595663268717557d,

0.42641902337908355d,

0.8355087159933785d,

0.1260374739386727d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1176809754));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3651109639924942d,

0.8856804349654391d,

0.6556235637359085d,

0.35150967423249546d,

};
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
                Assert.That(model.Id, Is.EqualTo(815594684));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9268337039277679d,

0.2557880366788481d,

0.9708486737945278d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8293420330004952d,

0.6751324902712372d,

0.11744019681431705d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(665941176));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6007345284456123d,

0.4345557997433672d,

0.9270897092020428d,

0.8441201074343846d,

};
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
                Assert.That(model.Id, Is.EqualTo(869025017));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.23029619671977453d,

0.9963881322054496d,

0.29922279043314304d,

0.553359254492766d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.1045379747229116d,

0.25625702200631595d,

0.3270116864275764d,

0.19231856481547016d,

};
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
                Assert.That(model.Id, Is.EqualTo(890753535));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.006972482696241178d,

0.8870497280113498d,

0.5029194269663007d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.37397243565318894d,

0.9666530847812052d,

0.7321744421541623d,

};
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
                Assert.That(model.Id, Is.EqualTo(960794115));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8584340768029776d,

0.338983987976771d,

0.5165072379349526d,

0.48768908889282836d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.42645607878473624d,

0.8045629062412712d,

0.5842290059804607d,

0.53049592839275d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2134784495));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6635684089337649d,

0.6914516866463486d,

0.3407343143346171d,

0.8163857880904707d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.23571376152551826d,

0.5892834748663432d,

0.16218047163404392d,

0.812415723693509d,

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
                Assert.That(model.Id, Is.EqualTo(1064547311));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.1893886152587244d,

0.5275227744645564d,

0.2713623619895643d,

0.3168228462103305d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8735754679742028d,

0.326431225255876d,

0.3453472790929043d,

0.29467838540432656d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1123512386));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.7924057872325804d,

0.18826557079246586d,

0.8980023770287593d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.18052220548543152d,

0.7794956319484363d,

0.4287157896768359d,

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
                Assert.That(model.Id, Is.EqualTo(1216459642));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4228646939171534d,

0.48723305829751273d,

0.9874945307068991d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.3406725270833162d,

0.6278874871110163d,

0.3397053760273837d,

};
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
                Assert.That(model.Id, Is.EqualTo(1228851149));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3046752293818199d,

0.8954081781400294d,

0.20001431036328188d,

0.6588513650063575d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.016354803552207975d,

0.10753335442476042d,

0.5683871269850892d,

0.31836105153449645d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1401688209));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.7285949238283712d,

0.5733599435593822d,

0.34086697138841326d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.019003561494990606d,

0.5673454033171191d,

0.45191953211306135d,

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
                Assert.That(model.Id, Is.EqualTo(1262879363));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.4812440527288484d,

0.3199784489919435d,

0.6382731473826979d,

0.09322032397536795d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.018902743328656157d,

0.3517789945819232d,

0.8934958952939568d,

0.31341251587473284d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1073531153));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5852876008048172d,

0.8650137972125318d,

0.6720127322882606d,

0.8579926724905216d,

};
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
                Assert.That(model.Id, Is.EqualTo(1274836410));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.012300482333735707d,

0.8575843030300441d,

0.3953199073284702d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.3802873805132805d,

0.7760282343876094d,

0.24367375090782895d,

};
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
                Assert.That(model.Id, Is.EqualTo(1298233660));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6675363277475983d,

0.6926681157494187d,

0.8126962414663714d,

0.29746421327564687d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.7096145407687857d,

0.08460224047984088d,

0.46365613795342464d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1287977328));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3919606767987358d,

0.8958643836111312d,

0.3634904771594514d,

0.8432371463341493d,

};
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
                Assert.That(model.Id, Is.EqualTo(1298776905));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.026920823934105664d,

0.2060699798435608d,

0.6784094784107302d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(283357821));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.3762026568414524d,

0.6514616109727247d,

0.10666446093329995d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.6350965768202388d,

0.7364449970239656d,

0.6170729620999107d,

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
                Assert.That(model.Id, Is.EqualTo(1352713090));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6083786222771096d,

0.0001882889314861469d,

0.5100959647529927d,

0.7823528511953681d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1389729061));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5768159718249714d,

0.27508325139879664d,

0.08248744166938815d,

0.7328876773389819d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(553025882));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7069224121325174d,

0.2285607987772753d,

0.7939711165074208d,

0.7284294422963341d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4888467126362911d,

0.550874212734459d,

0.6844178701315258d,

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
                Assert.That(model.Id, Is.EqualTo(1558321686));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.9955207480528168d,

0.9708940640207901d,

0.22478258056371947d,

0.016843841508443202d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1735897709));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3669470742487849d,

0.16379944902051724d,

0.7658934828651761d,

0.47248375887341765d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1881675292));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.13944961052197546d,

0.941374159723203d,

0.6535728631023234d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871153277));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8647330702863328d,

0.7504311628925787d,

0.3558642039145814d,

0.381219391709971d,

};
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
                Assert.That(model.Id, Is.EqualTo(1930734881));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8844858358873939d,

0.688392437185428d,

0.5512043776449784d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1933081192));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.9138765666850975d,

0.6503755818904282d,

0.5404800306134858d,

0.8912883104673369d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(876498087));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5839587573934504d,

0.16229959953844164d,

0.05166021542799504d,

0.054705171681251774d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4455950978835691d,

0.012889239254036622d,

0.365911697962618d,

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
                Assert.That(model.Id, Is.EqualTo(1965640956));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8799786113245733d,

0.103766859942518d,

0.007847165902295394d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(246200596));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6528826774753668d,

0.6254299247853704d,

0.47543566122314207d,

0.7930281335726063d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.567069722078047d,

0.09427310691668289d,

0.3642694593425063d,

0.005828726918219007d,

};
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
                Assert.That(model.Id, Is.EqualTo(321358953));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7800843247230342d,

0.4214549731905376d,

0.7333459397056095d,

0.755163516995959d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.026376353541849196d,

0.15951410997648519d,

0.5345173275701939d,

0.022759667888013313d,

};
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
                Assert.That(model.Id, Is.EqualTo(324204378));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7129182666882694d,

0.5773018813104558d,

0.1303178521027032d,

0.24777695457455828d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1396062439));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.36043031673652803d,

0.44920721772598715d,

0.9547082859041273d,

};
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
                Assert.That(model.Id, Is.EqualTo(325108454));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.31744060975243693d,

0.4950576982196667d,

0.4511517060268161d,

0.23353987185161118d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(481026883));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9085386978293561d,

0.1857654354361994d,

0.41827195921626836d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.404034260825876d,

0.5965103178780428d,

0.603258001042972d,

0.64688471673662d,

};
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
                Assert.That(model.Id, Is.EqualTo(485575216));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8671908145349809d,

0.9049378669775808d,

0.18213312490514433d,

0.4613375807858682d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.14039778989028162d,

0.5962485072187153d,

0.5871815298295686d,

0.8632846246479523d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1868142384));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.6312408406261761d,

0.6910384091661451d,

0.33584671391491183d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6792415009961253d,

0.42942852389095576d,

0.45368987899691815d,

0.15879378615614492d,

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
                Assert.That(model.Id, Is.EqualTo(515166406));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.14740678647980743d,

0.8920088270848197d,

0.10405608417091272d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1035409201));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7047759882347794d,

0.2341035414238981d,

0.3458497864102972d,

0.6617110491944888d,

};
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
                Assert.That(model.Id, Is.EqualTo(568952966));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.2549081299446322d,

0.4684485171098728d,

0.7180646054817073d,

0.14333429471865333d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(617985466));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.29893900988049793d,

0.3006011137146485d,

0.7983268410297981d,

0.07027811884628865d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.022666264179675877d,

0.6168211486873275d,

0.9250709010204006d,

0.31456810051666817d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1914047110));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9866980079367033d,

0.9711114290457674d,

0.6336203270722464d,

};
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
                Assert.That(model.Id, Is.EqualTo(689918638));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9876768189493348d,

0.3950903873550714d,

0.9050025457274901d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(720084900));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5855030491938493d,

0.3828814855553848d,

0.42799369300590395d,

0.30072275365795853d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5595663268717557d,

0.42641902337908355d,

0.8355087159933785d,

0.1260374739386727d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1176809754));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3651109639924942d,

0.8856804349654391d,

0.6556235637359085d,

0.35150967423249546d,

};
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
                Assert.That(model.Id, Is.EqualTo(815594684));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9268337039277679d,

0.2557880366788481d,

0.9708486737945278d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8293420330004952d,

0.6751324902712372d,

0.11744019681431705d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(665941176));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6007345284456123d,

0.4345557997433672d,

0.9270897092020428d,

0.8441201074343846d,

};
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
                Assert.That(model.Id, Is.EqualTo(869025017));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.23029619671977453d,

0.9963881322054496d,

0.29922279043314304d,

0.553359254492766d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.1045379747229116d,

0.25625702200631595d,

0.3270116864275764d,

0.19231856481547016d,

};
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
                Assert.That(model.Id, Is.EqualTo(890753535));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.006972482696241178d,

0.8870497280113498d,

0.5029194269663007d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.37397243565318894d,

0.9666530847812052d,

0.7321744421541623d,

};
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
                Assert.That(model.Id, Is.EqualTo(960794115));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8584340768029776d,

0.338983987976771d,

0.5165072379349526d,

0.48768908889282836d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.42645607878473624d,

0.8045629062412712d,

0.5842290059804607d,

0.53049592839275d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2134784495));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6635684089337649d,

0.6914516866463486d,

0.3407343143346171d,

0.8163857880904707d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.23571376152551826d,

0.5892834748663432d,

0.16218047163404392d,

0.812415723693509d,

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
                Assert.That(model.Id, Is.EqualTo(1064547311));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.1893886152587244d,

0.5275227744645564d,

0.2713623619895643d,

0.3168228462103305d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8735754679742028d,

0.326431225255876d,

0.3453472790929043d,

0.29467838540432656d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1123512386));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.7924057872325804d,

0.18826557079246586d,

0.8980023770287593d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.18052220548543152d,

0.7794956319484363d,

0.4287157896768359d,

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
                Assert.That(model.Id, Is.EqualTo(1216459642));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4228646939171534d,

0.48723305829751273d,

0.9874945307068991d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.3406725270833162d,

0.6278874871110163d,

0.3397053760273837d,

};
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
                Assert.That(model.Id, Is.EqualTo(1228851149));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3046752293818199d,

0.8954081781400294d,

0.20001431036328188d,

0.6588513650063575d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.016354803552207975d,

0.10753335442476042d,

0.5683871269850892d,

0.31836105153449645d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1401688209));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.7285949238283712d,

0.5733599435593822d,

0.34086697138841326d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.019003561494990606d,

0.5673454033171191d,

0.45191953211306135d,

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
                Assert.That(model.Id, Is.EqualTo(1262879363));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.4812440527288484d,

0.3199784489919435d,

0.6382731473826979d,

0.09322032397536795d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.018902743328656157d,

0.3517789945819232d,

0.8934958952939568d,

0.31341251587473284d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1073531153));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5852876008048172d,

0.8650137972125318d,

0.6720127322882606d,

0.8579926724905216d,

};
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
                Assert.That(model.Id, Is.EqualTo(1274836410));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.012300482333735707d,

0.8575843030300441d,

0.3953199073284702d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.3802873805132805d,

0.7760282343876094d,

0.24367375090782895d,

};
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
                Assert.That(model.Id, Is.EqualTo(1298233660));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6675363277475983d,

0.6926681157494187d,

0.8126962414663714d,

0.29746421327564687d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.7096145407687857d,

0.08460224047984088d,

0.46365613795342464d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1287977328));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3919606767987358d,

0.8958643836111312d,

0.3634904771594514d,

0.8432371463341493d,

};
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
                Assert.That(model.Id, Is.EqualTo(1298776905));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.026920823934105664d,

0.2060699798435608d,

0.6784094784107302d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(283357821));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.3762026568414524d,

0.6514616109727247d,

0.10666446093329995d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.6350965768202388d,

0.7364449970239656d,

0.6170729620999107d,

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
                Assert.That(model.Id, Is.EqualTo(1352713090));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6083786222771096d,

0.0001882889314861469d,

0.5100959647529927d,

0.7823528511953681d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1389729061));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5768159718249714d,

0.27508325139879664d,

0.08248744166938815d,

0.7328876773389819d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(553025882));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7069224121325174d,

0.2285607987772753d,

0.7939711165074208d,

0.7284294422963341d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4888467126362911d,

0.550874212734459d,

0.6844178701315258d,

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
                Assert.That(model.Id, Is.EqualTo(1558321686));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.9955207480528168d,

0.9708940640207901d,

0.22478258056371947d,

0.016843841508443202d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1735897709));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3669470742487849d,

0.16379944902051724d,

0.7658934828651761d,

0.47248375887341765d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1881675292));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.13944961052197546d,

0.941374159723203d,

0.6535728631023234d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871153277));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8647330702863328d,

0.7504311628925787d,

0.3558642039145814d,

0.381219391709971d,

};
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
                Assert.That(model.Id, Is.EqualTo(1930734881));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8844858358873939d,

0.688392437185428d,

0.5512043776449784d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1933081192));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.9138765666850975d,

0.6503755818904282d,

0.5404800306134858d,

0.8912883104673369d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(876498087));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5839587573934504d,

0.16229959953844164d,

0.05166021542799504d,

0.054705171681251774d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4455950978835691d,

0.012889239254036622d,

0.365911697962618d,

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
                Assert.That(model.Id, Is.EqualTo(1965640956));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8799786113245733d,

0.103766859942518d,

0.007847165902295394d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(Doubledouble_precisionArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)
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
                var models =  ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(246200596));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6528826774753668d,

0.6254299247853704d,

0.47543566122314207d,

0.7930281335726063d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.567069722078047d,

0.09427310691668289d,

0.3642694593425063d,

0.005828726918219007d,

};
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
                Assert.That(model.Id, Is.EqualTo(321358953));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7800843247230342d,

0.4214549731905376d,

0.7333459397056095d,

0.755163516995959d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.026376353541849196d,

0.15951410997648519d,

0.5345173275701939d,

0.022759667888013313d,

};
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
                Assert.That(model.Id, Is.EqualTo(324204378));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7129182666882694d,

0.5773018813104558d,

0.1303178521027032d,

0.24777695457455828d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1396062439));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.36043031673652803d,

0.44920721772598715d,

0.9547082859041273d,

};
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
                Assert.That(model.Id, Is.EqualTo(325108454));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.31744060975243693d,

0.4950576982196667d,

0.4511517060268161d,

0.23353987185161118d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(481026883));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9085386978293561d,

0.1857654354361994d,

0.41827195921626836d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.404034260825876d,

0.5965103178780428d,

0.603258001042972d,

0.64688471673662d,

};
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
                Assert.That(model.Id, Is.EqualTo(485575216));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8671908145349809d,

0.9049378669775808d,

0.18213312490514433d,

0.4613375807858682d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.14039778989028162d,

0.5962485072187153d,

0.5871815298295686d,

0.8632846246479523d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1868142384));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.6312408406261761d,

0.6910384091661451d,

0.33584671391491183d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6792415009961253d,

0.42942852389095576d,

0.45368987899691815d,

0.15879378615614492d,

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
                Assert.That(model.Id, Is.EqualTo(515166406));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.14740678647980743d,

0.8920088270848197d,

0.10405608417091272d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1035409201));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7047759882347794d,

0.2341035414238981d,

0.3458497864102972d,

0.6617110491944888d,

};
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
                Assert.That(model.Id, Is.EqualTo(568952966));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.2549081299446322d,

0.4684485171098728d,

0.7180646054817073d,

0.14333429471865333d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(617985466));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.29893900988049793d,

0.3006011137146485d,

0.7983268410297981d,

0.07027811884628865d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.022666264179675877d,

0.6168211486873275d,

0.9250709010204006d,

0.31456810051666817d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1914047110));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9866980079367033d,

0.9711114290457674d,

0.6336203270722464d,

};
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
                Assert.That(model.Id, Is.EqualTo(689918638));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9876768189493348d,

0.3950903873550714d,

0.9050025457274901d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(720084900));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5855030491938493d,

0.3828814855553848d,

0.42799369300590395d,

0.30072275365795853d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5595663268717557d,

0.42641902337908355d,

0.8355087159933785d,

0.1260374739386727d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1176809754));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3651109639924942d,

0.8856804349654391d,

0.6556235637359085d,

0.35150967423249546d,

};
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
                Assert.That(model.Id, Is.EqualTo(815594684));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9268337039277679d,

0.2557880366788481d,

0.9708486737945278d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8293420330004952d,

0.6751324902712372d,

0.11744019681431705d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(665941176));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6007345284456123d,

0.4345557997433672d,

0.9270897092020428d,

0.8441201074343846d,

};
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
                Assert.That(model.Id, Is.EqualTo(869025017));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.23029619671977453d,

0.9963881322054496d,

0.29922279043314304d,

0.553359254492766d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.1045379747229116d,

0.25625702200631595d,

0.3270116864275764d,

0.19231856481547016d,

};
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
                Assert.That(model.Id, Is.EqualTo(890753535));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.006972482696241178d,

0.8870497280113498d,

0.5029194269663007d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.37397243565318894d,

0.9666530847812052d,

0.7321744421541623d,

};
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
                Assert.That(model.Id, Is.EqualTo(960794115));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8584340768029776d,

0.338983987976771d,

0.5165072379349526d,

0.48768908889282836d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.42645607878473624d,

0.8045629062412712d,

0.5842290059804607d,

0.53049592839275d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2134784495));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6635684089337649d,

0.6914516866463486d,

0.3407343143346171d,

0.8163857880904707d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.23571376152551826d,

0.5892834748663432d,

0.16218047163404392d,

0.812415723693509d,

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
                Assert.That(model.Id, Is.EqualTo(1064547311));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.1893886152587244d,

0.5275227744645564d,

0.2713623619895643d,

0.3168228462103305d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8735754679742028d,

0.326431225255876d,

0.3453472790929043d,

0.29467838540432656d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1123512386));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.7924057872325804d,

0.18826557079246586d,

0.8980023770287593d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.18052220548543152d,

0.7794956319484363d,

0.4287157896768359d,

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
                Assert.That(model.Id, Is.EqualTo(1216459642));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4228646939171534d,

0.48723305829751273d,

0.9874945307068991d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.3406725270833162d,

0.6278874871110163d,

0.3397053760273837d,

};
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
                Assert.That(model.Id, Is.EqualTo(1228851149));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3046752293818199d,

0.8954081781400294d,

0.20001431036328188d,

0.6588513650063575d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.016354803552207975d,

0.10753335442476042d,

0.5683871269850892d,

0.31836105153449645d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1401688209));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.7285949238283712d,

0.5733599435593822d,

0.34086697138841326d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.019003561494990606d,

0.5673454033171191d,

0.45191953211306135d,

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
                Assert.That(model.Id, Is.EqualTo(1262879363));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.4812440527288484d,

0.3199784489919435d,

0.6382731473826979d,

0.09322032397536795d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.018902743328656157d,

0.3517789945819232d,

0.8934958952939568d,

0.31341251587473284d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1073531153));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5852876008048172d,

0.8650137972125318d,

0.6720127322882606d,

0.8579926724905216d,

};
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
                Assert.That(model.Id, Is.EqualTo(1274836410));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.012300482333735707d,

0.8575843030300441d,

0.3953199073284702d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.3802873805132805d,

0.7760282343876094d,

0.24367375090782895d,

};
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
                Assert.That(model.Id, Is.EqualTo(1298233660));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6675363277475983d,

0.6926681157494187d,

0.8126962414663714d,

0.29746421327564687d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.7096145407687857d,

0.08460224047984088d,

0.46365613795342464d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1287977328));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3919606767987358d,

0.8958643836111312d,

0.3634904771594514d,

0.8432371463341493d,

};
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
                Assert.That(model.Id, Is.EqualTo(1298776905));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.026920823934105664d,

0.2060699798435608d,

0.6784094784107302d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(283357821));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.3762026568414524d,

0.6514616109727247d,

0.10666446093329995d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.6350965768202388d,

0.7364449970239656d,

0.6170729620999107d,

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
                Assert.That(model.Id, Is.EqualTo(1352713090));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6083786222771096d,

0.0001882889314861469d,

0.5100959647529927d,

0.7823528511953681d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1389729061));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5768159718249714d,

0.27508325139879664d,

0.08248744166938815d,

0.7328876773389819d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(553025882));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7069224121325174d,

0.2285607987772753d,

0.7939711165074208d,

0.7284294422963341d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4888467126362911d,

0.550874212734459d,

0.6844178701315258d,

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
                Assert.That(model.Id, Is.EqualTo(1558321686));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.9955207480528168d,

0.9708940640207901d,

0.22478258056371947d,

0.016843841508443202d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1735897709));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3669470742487849d,

0.16379944902051724d,

0.7658934828651761d,

0.47248375887341765d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1881675292));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.13944961052197546d,

0.941374159723203d,

0.6535728631023234d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871153277));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8647330702863328d,

0.7504311628925787d,

0.3558642039145814d,

0.381219391709971d,

};
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
                Assert.That(model.Id, Is.EqualTo(1930734881));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8844858358873939d,

0.688392437185428d,

0.5512043776449784d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1933081192));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.9138765666850975d,

0.6503755818904282d,

0.5404800306134858d,

0.8912883104673369d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(876498087));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5839587573934504d,

0.16229959953844164d,

0.05166021542799504d,

0.054705171681251774d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4455950978835691d,

0.012889239254036622d,

0.365911697962618d,

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
                Assert.That(model.Id, Is.EqualTo(1965640956));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8799786113245733d,

0.103766859942518d,

0.007847165902295394d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                var models = await ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(246200596));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6528826774753668d,

0.6254299247853704d,

0.47543566122314207d,

0.7930281335726063d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.567069722078047d,

0.09427310691668289d,

0.3642694593425063d,

0.005828726918219007d,

};
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
                Assert.That(model.Id, Is.EqualTo(321358953));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7800843247230342d,

0.4214549731905376d,

0.7333459397056095d,

0.755163516995959d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.026376353541849196d,

0.15951410997648519d,

0.5345173275701939d,

0.022759667888013313d,

};
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
                Assert.That(model.Id, Is.EqualTo(324204378));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7129182666882694d,

0.5773018813104558d,

0.1303178521027032d,

0.24777695457455828d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1396062439));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.36043031673652803d,

0.44920721772598715d,

0.9547082859041273d,

};
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
                Assert.That(model.Id, Is.EqualTo(325108454));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.31744060975243693d,

0.4950576982196667d,

0.4511517060268161d,

0.23353987185161118d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(481026883));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9085386978293561d,

0.1857654354361994d,

0.41827195921626836d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.404034260825876d,

0.5965103178780428d,

0.603258001042972d,

0.64688471673662d,

};
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
                Assert.That(model.Id, Is.EqualTo(485575216));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8671908145349809d,

0.9049378669775808d,

0.18213312490514433d,

0.4613375807858682d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.14039778989028162d,

0.5962485072187153d,

0.5871815298295686d,

0.8632846246479523d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1868142384));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.6312408406261761d,

0.6910384091661451d,

0.33584671391491183d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6792415009961253d,

0.42942852389095576d,

0.45368987899691815d,

0.15879378615614492d,

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
                Assert.That(model.Id, Is.EqualTo(515166406));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.14740678647980743d,

0.8920088270848197d,

0.10405608417091272d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1035409201));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7047759882347794d,

0.2341035414238981d,

0.3458497864102972d,

0.6617110491944888d,

};
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
                Assert.That(model.Id, Is.EqualTo(568952966));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.2549081299446322d,

0.4684485171098728d,

0.7180646054817073d,

0.14333429471865333d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(617985466));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.29893900988049793d,

0.3006011137146485d,

0.7983268410297981d,

0.07027811884628865d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.022666264179675877d,

0.6168211486873275d,

0.9250709010204006d,

0.31456810051666817d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1914047110));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9866980079367033d,

0.9711114290457674d,

0.6336203270722464d,

};
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
                Assert.That(model.Id, Is.EqualTo(689918638));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9876768189493348d,

0.3950903873550714d,

0.9050025457274901d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(720084900));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5855030491938493d,

0.3828814855553848d,

0.42799369300590395d,

0.30072275365795853d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5595663268717557d,

0.42641902337908355d,

0.8355087159933785d,

0.1260374739386727d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1176809754));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3651109639924942d,

0.8856804349654391d,

0.6556235637359085d,

0.35150967423249546d,

};
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
                Assert.That(model.Id, Is.EqualTo(815594684));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9268337039277679d,

0.2557880366788481d,

0.9708486737945278d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8293420330004952d,

0.6751324902712372d,

0.11744019681431705d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(665941176));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6007345284456123d,

0.4345557997433672d,

0.9270897092020428d,

0.8441201074343846d,

};
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
                Assert.That(model.Id, Is.EqualTo(869025017));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.23029619671977453d,

0.9963881322054496d,

0.29922279043314304d,

0.553359254492766d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.1045379747229116d,

0.25625702200631595d,

0.3270116864275764d,

0.19231856481547016d,

};
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
                Assert.That(model.Id, Is.EqualTo(890753535));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.006972482696241178d,

0.8870497280113498d,

0.5029194269663007d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.37397243565318894d,

0.9666530847812052d,

0.7321744421541623d,

};
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
                Assert.That(model.Id, Is.EqualTo(960794115));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8584340768029776d,

0.338983987976771d,

0.5165072379349526d,

0.48768908889282836d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.42645607878473624d,

0.8045629062412712d,

0.5842290059804607d,

0.53049592839275d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2134784495));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6635684089337649d,

0.6914516866463486d,

0.3407343143346171d,

0.8163857880904707d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.23571376152551826d,

0.5892834748663432d,

0.16218047163404392d,

0.812415723693509d,

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
                Assert.That(model.Id, Is.EqualTo(1064547311));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.1893886152587244d,

0.5275227744645564d,

0.2713623619895643d,

0.3168228462103305d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8735754679742028d,

0.326431225255876d,

0.3453472790929043d,

0.29467838540432656d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1123512386));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.7924057872325804d,

0.18826557079246586d,

0.8980023770287593d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.18052220548543152d,

0.7794956319484363d,

0.4287157896768359d,

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
                Assert.That(model.Id, Is.EqualTo(1216459642));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4228646939171534d,

0.48723305829751273d,

0.9874945307068991d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.3406725270833162d,

0.6278874871110163d,

0.3397053760273837d,

};
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
                Assert.That(model.Id, Is.EqualTo(1228851149));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3046752293818199d,

0.8954081781400294d,

0.20001431036328188d,

0.6588513650063575d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.016354803552207975d,

0.10753335442476042d,

0.5683871269850892d,

0.31836105153449645d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1401688209));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.7285949238283712d,

0.5733599435593822d,

0.34086697138841326d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.019003561494990606d,

0.5673454033171191d,

0.45191953211306135d,

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
                Assert.That(model.Id, Is.EqualTo(1262879363));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.4812440527288484d,

0.3199784489919435d,

0.6382731473826979d,

0.09322032397536795d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.018902743328656157d,

0.3517789945819232d,

0.8934958952939568d,

0.31341251587473284d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1073531153));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5852876008048172d,

0.8650137972125318d,

0.6720127322882606d,

0.8579926724905216d,

};
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
                Assert.That(model.Id, Is.EqualTo(1274836410));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.012300482333735707d,

0.8575843030300441d,

0.3953199073284702d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.3802873805132805d,

0.7760282343876094d,

0.24367375090782895d,

};
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
                Assert.That(model.Id, Is.EqualTo(1298233660));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6675363277475983d,

0.6926681157494187d,

0.8126962414663714d,

0.29746421327564687d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.7096145407687857d,

0.08460224047984088d,

0.46365613795342464d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1287977328));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3919606767987358d,

0.8958643836111312d,

0.3634904771594514d,

0.8432371463341493d,

};
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
                Assert.That(model.Id, Is.EqualTo(1298776905));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.026920823934105664d,

0.2060699798435608d,

0.6784094784107302d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(283357821));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.3762026568414524d,

0.6514616109727247d,

0.10666446093329995d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.6350965768202388d,

0.7364449970239656d,

0.6170729620999107d,

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
                Assert.That(model.Id, Is.EqualTo(1352713090));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6083786222771096d,

0.0001882889314861469d,

0.5100959647529927d,

0.7823528511953681d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1389729061));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5768159718249714d,

0.27508325139879664d,

0.08248744166938815d,

0.7328876773389819d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(553025882));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7069224121325174d,

0.2285607987772753d,

0.7939711165074208d,

0.7284294422963341d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4888467126362911d,

0.550874212734459d,

0.6844178701315258d,

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
                Assert.That(model.Id, Is.EqualTo(1558321686));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.9955207480528168d,

0.9708940640207901d,

0.22478258056371947d,

0.016843841508443202d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1735897709));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3669470742487849d,

0.16379944902051724d,

0.7658934828651761d,

0.47248375887341765d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1881675292));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.13944961052197546d,

0.941374159723203d,

0.6535728631023234d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871153277));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8647330702863328d,

0.7504311628925787d,

0.3558642039145814d,

0.381219391709971d,

};
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
                Assert.That(model.Id, Is.EqualTo(1930734881));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8844858358873939d,

0.688392437185428d,

0.5512043776449784d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1933081192));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.9138765666850975d,

0.6503755818904282d,

0.5404800306134858d,

0.8912883104673369d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(876498087));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5839587573934504d,

0.16229959953844164d,

0.05166021542799504d,

0.054705171681251774d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4455950978835691d,

0.012889239254036622d,

0.365911697962618d,

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
                Assert.That(model.Id, Is.EqualTo(1965640956));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8799786113245733d,

0.103766859942518d,

0.007847165902295394d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                 using var cmd =  ((IDoubleArraydouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 869025017);
                var models =  ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(17));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(890753535));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.006972482696241178d,

0.8870497280113498d,

0.5029194269663007d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.37397243565318894d,

0.9666530847812052d,

0.7321744421541623d,

};
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
                Assert.That(model.Id, Is.EqualTo(960794115));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8584340768029776d,

0.338983987976771d,

0.5165072379349526d,

0.48768908889282836d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.42645607878473624d,

0.8045629062412712d,

0.5842290059804607d,

0.53049592839275d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2134784495));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6635684089337649d,

0.6914516866463486d,

0.3407343143346171d,

0.8163857880904707d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.23571376152551826d,

0.5892834748663432d,

0.16218047163404392d,

0.812415723693509d,

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
                Assert.That(model.Id, Is.EqualTo(1064547311));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.1893886152587244d,

0.5275227744645564d,

0.2713623619895643d,

0.3168228462103305d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8735754679742028d,

0.326431225255876d,

0.3453472790929043d,

0.29467838540432656d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1123512386));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.7924057872325804d,

0.18826557079246586d,

0.8980023770287593d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.18052220548543152d,

0.7794956319484363d,

0.4287157896768359d,

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
                Assert.That(model.Id, Is.EqualTo(1216459642));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4228646939171534d,

0.48723305829751273d,

0.9874945307068991d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.3406725270833162d,

0.6278874871110163d,

0.3397053760273837d,

};
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
                Assert.That(model.Id, Is.EqualTo(1228851149));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3046752293818199d,

0.8954081781400294d,

0.20001431036328188d,

0.6588513650063575d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.016354803552207975d,

0.10753335442476042d,

0.5683871269850892d,

0.31836105153449645d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1401688209));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.7285949238283712d,

0.5733599435593822d,

0.34086697138841326d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.019003561494990606d,

0.5673454033171191d,

0.45191953211306135d,

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
                Assert.That(model.Id, Is.EqualTo(1262879363));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.4812440527288484d,

0.3199784489919435d,

0.6382731473826979d,

0.09322032397536795d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.018902743328656157d,

0.3517789945819232d,

0.8934958952939568d,

0.31341251587473284d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1073531153));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5852876008048172d,

0.8650137972125318d,

0.6720127322882606d,

0.8579926724905216d,

};
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
                Assert.That(model.Id, Is.EqualTo(1274836410));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.012300482333735707d,

0.8575843030300441d,

0.3953199073284702d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.3802873805132805d,

0.7760282343876094d,

0.24367375090782895d,

};
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
                Assert.That(model.Id, Is.EqualTo(1298233660));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6675363277475983d,

0.6926681157494187d,

0.8126962414663714d,

0.29746421327564687d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.7096145407687857d,

0.08460224047984088d,

0.46365613795342464d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1287977328));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3919606767987358d,

0.8958643836111312d,

0.3634904771594514d,

0.8432371463341493d,

};
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
                Assert.That(model.Id, Is.EqualTo(1298776905));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.026920823934105664d,

0.2060699798435608d,

0.6784094784107302d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(283357821));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.3762026568414524d,

0.6514616109727247d,

0.10666446093329995d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.6350965768202388d,

0.7364449970239656d,

0.6170729620999107d,

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
                Assert.That(model.Id, Is.EqualTo(1352713090));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6083786222771096d,

0.0001882889314861469d,

0.5100959647529927d,

0.7823528511953681d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1389729061));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5768159718249714d,

0.27508325139879664d,

0.08248744166938815d,

0.7328876773389819d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(553025882));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7069224121325174d,

0.2285607987772753d,

0.7939711165074208d,

0.7284294422963341d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4888467126362911d,

0.550874212734459d,

0.6844178701315258d,

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
                Assert.That(model.Id, Is.EqualTo(1558321686));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.9955207480528168d,

0.9708940640207901d,

0.22478258056371947d,

0.016843841508443202d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1735897709));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3669470742487849d,

0.16379944902051724d,

0.7658934828651761d,

0.47248375887341765d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1881675292));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.13944961052197546d,

0.941374159723203d,

0.6535728631023234d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871153277));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8647330702863328d,

0.7504311628925787d,

0.3558642039145814d,

0.381219391709971d,

};
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
                Assert.That(model.Id, Is.EqualTo(1930734881));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8844858358873939d,

0.688392437185428d,

0.5512043776449784d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1933081192));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.9138765666850975d,

0.6503755818904282d,

0.5404800306134858d,

0.8912883104673369d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(876498087));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5839587573934504d,

0.16229959953844164d,

0.05166021542799504d,

0.054705171681251774d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4455950978835691d,

0.012889239254036622d,

0.365911697962618d,

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
                Assert.That(model.Id, Is.EqualTo(1965640956));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8799786113245733d,

0.103766859942518d,

0.007847165902295394d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                await using var cmd = await ((IDoubleArraydouble_precisionArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 1735897709);
                var models = await ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(4));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1881675292));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.13944961052197546d,

0.941374159723203d,

0.6535728631023234d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871153277));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8647330702863328d,

0.7504311628925787d,

0.3558642039145814d,

0.381219391709971d,

};
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
                Assert.That(model.Id, Is.EqualTo(1930734881));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8844858358873939d,

0.688392437185428d,

0.5512043776449784d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1933081192));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.9138765666850975d,

0.6503755818904282d,

0.5404800306134858d,

0.8912883104673369d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(876498087));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5839587573934504d,

0.16229959953844164d,

0.05166021542799504d,

0.054705171681251774d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4455950978835691d,

0.012889239254036622d,

0.365911697962618d,

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
                Assert.That(model.Id, Is.EqualTo(1965640956));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8799786113245733d,

0.103766859942518d,

0.007847165902295394d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)
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
                 foreach(var batchResult in ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelBatch(connection, 1352713090, 1930734881))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(7));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1389729061));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5768159718249714d,

0.27508325139879664d,

0.08248744166938815d,

0.7328876773389819d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(553025882));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7069224121325174d,

0.2285607987772753d,

0.7939711165074208d,

0.7284294422963341d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4888467126362911d,

0.550874212734459d,

0.6844178701315258d,

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
                Assert.That(model.Id, Is.EqualTo(1558321686));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.9955207480528168d,

0.9708940640207901d,

0.22478258056371947d,

0.016843841508443202d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1735897709));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3669470742487849d,

0.16379944902051724d,

0.7658934828651761d,

0.47248375887341765d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1881675292));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.13944961052197546d,

0.941374159723203d,

0.6535728631023234d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871153277));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8647330702863328d,

0.7504311628925787d,

0.3558642039145814d,

0.381219391709971d,

};
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
                Assert.That(model.Id, Is.EqualTo(1930734881));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8844858358873939d,

0.688392437185428d,

0.5512043776449784d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1933081192));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.9138765666850975d,

0.6503755818904282d,

0.5404800306134858d,

0.8912883104673369d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(876498087));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5839587573934504d,

0.16229959953844164d,

0.05166021542799504d,

0.054705171681251774d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4455950978835691d,

0.012889239254036622d,

0.365911697962618d,

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
                Assert.That(model.Id, Is.EqualTo(1965640956));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8799786113245733d,

0.103766859942518d,

0.007847165902295394d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1933081192));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.9138765666850975d,

0.6503755818904282d,

0.5404800306134858d,

0.8912883104673369d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(876498087));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5839587573934504d,

0.16229959953844164d,

0.05166021542799504d,

0.054705171681251774d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4455950978835691d,

0.012889239254036622d,

0.365911697962618d,

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
                Assert.That(model.Id, Is.EqualTo(1965640956));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8799786113245733d,

0.103766859942518d,

0.007847165902295394d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                await foreach(var batchResult in ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelBatchAsync(connection, 1274836410, 1930734881))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(10));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1298233660));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6675363277475983d,

0.6926681157494187d,

0.8126962414663714d,

0.29746421327564687d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.7096145407687857d,

0.08460224047984088d,

0.46365613795342464d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1287977328));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3919606767987358d,

0.8958643836111312d,

0.3634904771594514d,

0.8432371463341493d,

};
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
                Assert.That(model.Id, Is.EqualTo(1298776905));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.026920823934105664d,

0.2060699798435608d,

0.6784094784107302d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(283357821));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.3762026568414524d,

0.6514616109727247d,

0.10666446093329995d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.6350965768202388d,

0.7364449970239656d,

0.6170729620999107d,

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
                Assert.That(model.Id, Is.EqualTo(1352713090));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6083786222771096d,

0.0001882889314861469d,

0.5100959647529927d,

0.7823528511953681d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1389729061));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5768159718249714d,

0.27508325139879664d,

0.08248744166938815d,

0.7328876773389819d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(553025882));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7069224121325174d,

0.2285607987772753d,

0.7939711165074208d,

0.7284294422963341d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4888467126362911d,

0.550874212734459d,

0.6844178701315258d,

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
                Assert.That(model.Id, Is.EqualTo(1558321686));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.9955207480528168d,

0.9708940640207901d,

0.22478258056371947d,

0.016843841508443202d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1735897709));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3669470742487849d,

0.16379944902051724d,

0.7658934828651761d,

0.47248375887341765d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1881675292));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.13944961052197546d,

0.941374159723203d,

0.6535728631023234d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871153277));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8647330702863328d,

0.7504311628925787d,

0.3558642039145814d,

0.381219391709971d,

};
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
                Assert.That(model.Id, Is.EqualTo(1930734881));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8844858358873939d,

0.688392437185428d,

0.5512043776449784d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1933081192));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.9138765666850975d,

0.6503755818904282d,

0.5404800306134858d,

0.8912883104673369d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(876498087));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5839587573934504d,

0.16229959953844164d,

0.05166021542799504d,

0.054705171681251774d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4455950978835691d,

0.012889239254036622d,

0.365911697962618d,

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
                Assert.That(model.Id, Is.EqualTo(1965640956));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8799786113245733d,

0.103766859942518d,

0.007847165902295394d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1933081192));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.9138765666850975d,

0.6503755818904282d,

0.5404800306134858d,

0.8912883104673369d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(876498087));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5839587573934504d,

0.16229959953844164d,

0.05166021542799504d,

0.054705171681251774d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4455950978835691d,

0.012889239254036622d,

0.365911697962618d,

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
                Assert.That(model.Id, Is.EqualTo(1965640956));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8799786113245733d,

0.103766859942518d,

0.007847165902295394d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
COPY public.binary_doubledouble_precisionarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MI),
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

                var importCollection = new List<Doubledouble_precisionArray1MI>(7);

                importCollection.Add(
                new Doubledouble_precisionArray1MI
                {
                    Id = 283357821,
                    Value = 
new System.Double[3]
{
0.3762026568414524d,

0.6514616109727247d,

0.10666446093329995d,

},
                    NullableValue = 
new System.Double[3]
{
0.6350965768202388d,

0.7364449970239656d,

0.6170729620999107d,

}
                });

                importCollection.Add(
                new Doubledouble_precisionArray1MI
                {
                    Id = 553025882,
                    Value = 
new System.Double[4]
{
0.7069224121325174d,

0.2285607987772753d,

0.7939711165074208d,

0.7284294422963341d,

},
                    NullableValue = 
new System.Double[3]
{
0.4888467126362911d,

0.550874212734459d,

0.6844178701315258d,

}
                });

                importCollection.Add(
                new Doubledouble_precisionArray1MI
                {
                    Id = 665941176,
                    Value = 
new System.Double[4]
{
0.6007345284456123d,

0.4345557997433672d,

0.9270897092020428d,

0.8441201074343846d,

},
                    NullableValue = null
                });

                importCollection.Add(
                new Doubledouble_precisionArray1MI
                {
                    Id = 871153277,
                    Value = 
new System.Double[4]
{
0.8647330702863328d,

0.7504311628925787d,

0.3558642039145814d,

0.381219391709971d,

},
                    NullableValue = null
                });

                importCollection.Add(
                new Doubledouble_precisionArray1MI
                {
                    Id = 876498087,
                    Value = 
new System.Double[4]
{
0.5839587573934504d,

0.16229959953844164d,

0.05166021542799504d,

0.054705171681251774d,

},
                    NullableValue = 
new System.Double[3]
{
0.4455950978835691d,

0.012889239254036622d,

0.365911697962618d,

}
                });

                importCollection.Add(
                new Doubledouble_precisionArray1MI
                {
                    Id = 1035409201,
                    Value = 
new System.Double[4]
{
0.7047759882347794d,

0.2341035414238981d,

0.3458497864102972d,

0.6617110491944888d,

},
                    NullableValue = null
                });

                importCollection.Add(
                new Doubledouble_precisionArray1MI
                {
                    Id = 1073531153,
                    Value = 
new System.Double[4]
{
0.5852876008048172d,

0.8650137972125318d,

0.6720127322882606d,

0.8579926724905216d,

},
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(283357821));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.3762026568414524d,

0.6514616109727247d,

0.10666446093329995d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.6350965768202388d,

0.7364449970239656d,

0.6170729620999107d,

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
                Assert.That(model.Id, Is.EqualTo(553025882));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7069224121325174d,

0.2285607987772753d,

0.7939711165074208d,

0.7284294422963341d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4888467126362911d,

0.550874212734459d,

0.6844178701315258d,

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
                Assert.That(model.Id, Is.EqualTo(665941176));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6007345284456123d,

0.4345557997433672d,

0.9270897092020428d,

0.8441201074343846d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(871153277));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8647330702863328d,

0.7504311628925787d,

0.3558642039145814d,

0.381219391709971d,

};
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
                Assert.That(model.Id, Is.EqualTo(876498087));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5839587573934504d,

0.16229959953844164d,

0.05166021542799504d,

0.054705171681251774d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4455950978835691d,

0.012889239254036622d,

0.365911697962618d,

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
                Assert.That(model.Id, Is.EqualTo(1035409201));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7047759882347794d,

0.2341035414238981d,

0.3458497864102972d,

0.6617110491944888d,

};
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
                Assert.That(model.Id, Is.EqualTo(1073531153));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5852876008048172d,

0.8650137972125318d,

0.6720127322882606d,

0.8579926724905216d,

};
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
                new Doubledouble_precisionArray1MI
                {
                    Id = 1123512386,
                    Value = 
new System.Double[3]
{
0.7924057872325804d,

0.18826557079246586d,

0.8980023770287593d,

},
                    NullableValue = 
new System.Double[3]
{
0.18052220548543152d,

0.7794956319484363d,

0.4287157896768359d,

}
                });

                importCollection.Add(
                new Doubledouble_precisionArray1MI
                {
                    Id = 1176809754,
                    Value = 
new System.Double[4]
{
0.3651109639924942d,

0.8856804349654391d,

0.6556235637359085d,

0.35150967423249546d,

},
                    NullableValue = null
                });

                importCollection.Add(
                new Doubledouble_precisionArray1MI
                {
                    Id = 1287977328,
                    Value = 
new System.Double[4]
{
0.3919606767987358d,

0.8958643836111312d,

0.3634904771594514d,

0.8432371463341493d,

},
                    NullableValue = null
                });

                importCollection.Add(
                new Doubledouble_precisionArray1MI
                {
                    Id = 1396062439,
                    Value = 
new System.Double[3]
{
0.36043031673652803d,

0.44920721772598715d,

0.9547082859041273d,

},
                    NullableValue = null
                });

                importCollection.Add(
                new Doubledouble_precisionArray1MI
                {
                    Id = 1401688209,
                    Value = 
new System.Double[3]
{
0.7285949238283712d,

0.5733599435593822d,

0.34086697138841326d,

},
                    NullableValue = 
new System.Double[3]
{
0.019003561494990606d,

0.5673454033171191d,

0.45191953211306135d,

}
                });

                importCollection.Add(
                new Doubledouble_precisionArray1MI
                {
                    Id = 1868142384,
                    Value = 
new System.Double[3]
{
0.6312408406261761d,

0.6910384091661451d,

0.33584671391491183d,

},
                    NullableValue = 
new System.Double[4]
{
0.6792415009961253d,

0.42942852389095576d,

0.45368987899691815d,

0.15879378615614492d,

}
                });

                importCollection.Add(
                new Doubledouble_precisionArray1MI
                {
                    Id = 1914047110,
                    Value = 
new System.Double[3]
{
0.9866980079367033d,

0.9711114290457674d,

0.6336203270722464d,

},
                    NullableValue = null
                });

                importCollection.Add(
                new Doubledouble_precisionArray1MI
                {
                    Id = 2134784495,
                    Value = 
new System.Double[4]
{
0.6635684089337649d,

0.6914516866463486d,

0.3407343143346171d,

0.8163857880904707d,

},
                    NullableValue = 
new System.Double[4]
{
0.23571376152551826d,

0.5892834748663432d,

0.16218047163404392d,

0.812415723693509d,

}
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(283357821));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.3762026568414524d,

0.6514616109727247d,

0.10666446093329995d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.6350965768202388d,

0.7364449970239656d,

0.6170729620999107d,

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
                Assert.That(model.Id, Is.EqualTo(553025882));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7069224121325174d,

0.2285607987772753d,

0.7939711165074208d,

0.7284294422963341d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4888467126362911d,

0.550874212734459d,

0.6844178701315258d,

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
                Assert.That(model.Id, Is.EqualTo(665941176));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6007345284456123d,

0.4345557997433672d,

0.9270897092020428d,

0.8441201074343846d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(871153277));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8647330702863328d,

0.7504311628925787d,

0.3558642039145814d,

0.381219391709971d,

};
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
                Assert.That(model.Id, Is.EqualTo(876498087));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5839587573934504d,

0.16229959953844164d,

0.05166021542799504d,

0.054705171681251774d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4455950978835691d,

0.012889239254036622d,

0.365911697962618d,

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
                Assert.That(model.Id, Is.EqualTo(1035409201));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7047759882347794d,

0.2341035414238981d,

0.3458497864102972d,

0.6617110491944888d,

};
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
                Assert.That(model.Id, Is.EqualTo(1073531153));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5852876008048172d,

0.8650137972125318d,

0.6720127322882606d,

0.8579926724905216d,

};
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
                Assert.That(model.Id, Is.EqualTo(1123512386));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.7924057872325804d,

0.18826557079246586d,

0.8980023770287593d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.18052220548543152d,

0.7794956319484363d,

0.4287157896768359d,

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
                Assert.That(model.Id, Is.EqualTo(1176809754));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3651109639924942d,

0.8856804349654391d,

0.6556235637359085d,

0.35150967423249546d,

};
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
                Assert.That(model.Id, Is.EqualTo(1287977328));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3919606767987358d,

0.8958643836111312d,

0.3634904771594514d,

0.8432371463341493d,

};
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
                Assert.That(model.Id, Is.EqualTo(1396062439));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.36043031673652803d,

0.44920721772598715d,

0.9547082859041273d,

};
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
                Assert.That(model.Id, Is.EqualTo(1401688209));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.7285949238283712d,

0.5733599435593822d,

0.34086697138841326d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.019003561494990606d,

0.5673454033171191d,

0.45191953211306135d,

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
                Assert.That(model.Id, Is.EqualTo(1868142384));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.6312408406261761d,

0.6910384091661451d,

0.33584671391491183d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6792415009961253d,

0.42942852389095576d,

0.45368987899691815d,

0.15879378615614492d,

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
                Assert.That(model.Id, Is.EqualTo(1914047110));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9866980079367033d,

0.9711114290457674d,

0.6336203270722464d,

};
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
                Assert.That(model.Id, Is.EqualTo(2134784495));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6635684089337649d,

0.6914516866463486d,

0.3407343143346171d,

0.8163857880904707d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.23571376152551826d,

0.5892834748663432d,

0.16218047163404392d,

0.812415723693509d,

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
COPY public.binary_doubledouble_precisionarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
FROM public.binary_doubledouble_precisionarray1m m
LEFT JOIN public.binary_doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(Doubledouble_precisionArray1M),
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

                var importCollection = new List<Doubledouble_precisionArray1M>(15);

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 246200596,
                    Value = 
new System.Double[4]
{
0.6528826774753668d,

0.6254299247853704d,

0.47543566122314207d,

0.7930281335726063d,

},
                    NullableValue = 
new System.Double[4]
{
0.567069722078047d,

0.09427310691668289d,

0.3642694593425063d,

0.005828726918219007d,

},

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 321358953,
                    Value = 
new System.Double[4]
{
0.7800843247230342d,

0.4214549731905376d,

0.7333459397056095d,

0.755163516995959d,

},
                    NullableValue = 
new System.Double[4]
{
0.026376353541849196d,

0.15951410997648519d,

0.5345173275701939d,

0.022759667888013313d,

},

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 324204378,
                    Value = 
new System.Double[4]
{
0.7129182666882694d,

0.5773018813104558d,

0.1303178521027032d,

0.24777695457455828d,

},
                    NullableValue = null,

                    ModelInner = new Doubledouble_precisionArray1MI 
                    {
                        Id = 1396062439
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 325108454,
                    Value = 
new System.Double[4]
{
0.31744060975243693d,

0.4950576982196667d,

0.4511517060268161d,

0.23353987185161118d,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 481026883,
                    Value = 
new System.Double[3]
{
0.9085386978293561d,

0.1857654354361994d,

0.41827195921626836d,

},
                    NullableValue = 
new System.Double[4]
{
0.404034260825876d,

0.5965103178780428d,

0.603258001042972d,

0.64688471673662d,

},

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 485575216,
                    Value = 
new System.Double[4]
{
0.8671908145349809d,

0.9049378669775808d,

0.18213312490514433d,

0.4613375807858682d,

},
                    NullableValue = 
new System.Double[4]
{
0.14039778989028162d,

0.5962485072187153d,

0.5871815298295686d,

0.8632846246479523d,

},

                    ModelInner = new Doubledouble_precisionArray1MI 
                    {
                        Id = 1868142384
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 515166406,
                    Value = 
new System.Double[3]
{
0.14740678647980743d,

0.8920088270848197d,

0.10405608417091272d,

},
                    NullableValue = null,

                    ModelInner = new Doubledouble_precisionArray1MI 
                    {
                        Id = 1035409201
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 568952966,
                    Value = 
new System.Double[4]
{
0.2549081299446322d,

0.4684485171098728d,

0.7180646054817073d,

0.14333429471865333d,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 617985466,
                    Value = 
new System.Double[4]
{
0.29893900988049793d,

0.3006011137146485d,

0.7983268410297981d,

0.07027811884628865d,

},
                    NullableValue = 
new System.Double[4]
{
0.022666264179675877d,

0.6168211486873275d,

0.9250709010204006d,

0.31456810051666817d,

},

                    ModelInner = new Doubledouble_precisionArray1MI 
                    {
                        Id = 1914047110
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 689918638,
                    Value = 
new System.Double[3]
{
0.9876768189493348d,

0.3950903873550714d,

0.9050025457274901d,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 720084900,
                    Value = 
new System.Double[4]
{
0.5855030491938493d,

0.3828814855553848d,

0.42799369300590395d,

0.30072275365795853d,

},
                    NullableValue = 
new System.Double[4]
{
0.5595663268717557d,

0.42641902337908355d,

0.8355087159933785d,

0.1260374739386727d,

},

                    ModelInner = new Doubledouble_precisionArray1MI 
                    {
                        Id = 1176809754
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 815594684,
                    Value = 
new System.Double[3]
{
0.9268337039277679d,

0.2557880366788481d,

0.9708486737945278d,

},
                    NullableValue = 
new System.Double[3]
{
0.8293420330004952d,

0.6751324902712372d,

0.11744019681431705d,

},

                    ModelInner = new Doubledouble_precisionArray1MI 
                    {
                        Id = 665941176
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 869025017,
                    Value = 
new System.Double[4]
{
0.23029619671977453d,

0.9963881322054496d,

0.29922279043314304d,

0.553359254492766d,

},
                    NullableValue = 
new System.Double[4]
{
0.1045379747229116d,

0.25625702200631595d,

0.3270116864275764d,

0.19231856481547016d,

},

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 890753535,
                    Value = 
new System.Double[3]
{
0.006972482696241178d,

0.8870497280113498d,

0.5029194269663007d,

},
                    NullableValue = 
new System.Double[3]
{
0.37397243565318894d,

0.9666530847812052d,

0.7321744421541623d,

},

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 960794115,
                    Value = 
new System.Double[4]
{
0.8584340768029776d,

0.338983987976771d,

0.5165072379349526d,

0.48768908889282836d,

},
                    NullableValue = 
new System.Double[4]
{
0.42645607878473624d,

0.8045629062412712d,

0.5842290059804607d,

0.53049592839275d,

},

                    ModelInner = new Doubledouble_precisionArray1MI 
                    {
                        Id = 2134784495
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(246200596));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6528826774753668d,

0.6254299247853704d,

0.47543566122314207d,

0.7930281335726063d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.567069722078047d,

0.09427310691668289d,

0.3642694593425063d,

0.005828726918219007d,

};
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
                Assert.That(model.Id, Is.EqualTo(321358953));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7800843247230342d,

0.4214549731905376d,

0.7333459397056095d,

0.755163516995959d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.026376353541849196d,

0.15951410997648519d,

0.5345173275701939d,

0.022759667888013313d,

};
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
                Assert.That(model.Id, Is.EqualTo(324204378));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7129182666882694d,

0.5773018813104558d,

0.1303178521027032d,

0.24777695457455828d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1396062439));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.36043031673652803d,

0.44920721772598715d,

0.9547082859041273d,

};
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
                Assert.That(model.Id, Is.EqualTo(325108454));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.31744060975243693d,

0.4950576982196667d,

0.4511517060268161d,

0.23353987185161118d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(481026883));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9085386978293561d,

0.1857654354361994d,

0.41827195921626836d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.404034260825876d,

0.5965103178780428d,

0.603258001042972d,

0.64688471673662d,

};
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
                Assert.That(model.Id, Is.EqualTo(485575216));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8671908145349809d,

0.9049378669775808d,

0.18213312490514433d,

0.4613375807858682d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.14039778989028162d,

0.5962485072187153d,

0.5871815298295686d,

0.8632846246479523d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1868142384));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.6312408406261761d,

0.6910384091661451d,

0.33584671391491183d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6792415009961253d,

0.42942852389095576d,

0.45368987899691815d,

0.15879378615614492d,

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
                Assert.That(model.Id, Is.EqualTo(515166406));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.14740678647980743d,

0.8920088270848197d,

0.10405608417091272d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1035409201));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7047759882347794d,

0.2341035414238981d,

0.3458497864102972d,

0.6617110491944888d,

};
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
                Assert.That(model.Id, Is.EqualTo(568952966));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.2549081299446322d,

0.4684485171098728d,

0.7180646054817073d,

0.14333429471865333d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(617985466));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.29893900988049793d,

0.3006011137146485d,

0.7983268410297981d,

0.07027811884628865d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.022666264179675877d,

0.6168211486873275d,

0.9250709010204006d,

0.31456810051666817d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1914047110));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9866980079367033d,

0.9711114290457674d,

0.6336203270722464d,

};
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
                Assert.That(model.Id, Is.EqualTo(689918638));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9876768189493348d,

0.3950903873550714d,

0.9050025457274901d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(720084900));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5855030491938493d,

0.3828814855553848d,

0.42799369300590395d,

0.30072275365795853d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5595663268717557d,

0.42641902337908355d,

0.8355087159933785d,

0.1260374739386727d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1176809754));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3651109639924942d,

0.8856804349654391d,

0.6556235637359085d,

0.35150967423249546d,

};
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
                Assert.That(model.Id, Is.EqualTo(815594684));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9268337039277679d,

0.2557880366788481d,

0.9708486737945278d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8293420330004952d,

0.6751324902712372d,

0.11744019681431705d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(665941176));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6007345284456123d,

0.4345557997433672d,

0.9270897092020428d,

0.8441201074343846d,

};
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
                Assert.That(model.Id, Is.EqualTo(869025017));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.23029619671977453d,

0.9963881322054496d,

0.29922279043314304d,

0.553359254492766d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.1045379747229116d,

0.25625702200631595d,

0.3270116864275764d,

0.19231856481547016d,

};
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
                Assert.That(model.Id, Is.EqualTo(890753535));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.006972482696241178d,

0.8870497280113498d,

0.5029194269663007d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.37397243565318894d,

0.9666530847812052d,

0.7321744421541623d,

};
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
                Assert.That(model.Id, Is.EqualTo(960794115));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8584340768029776d,

0.338983987976771d,

0.5165072379349526d,

0.48768908889282836d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.42645607878473624d,

0.8045629062412712d,

0.5842290059804607d,

0.53049592839275d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2134784495));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6635684089337649d,

0.6914516866463486d,

0.3407343143346171d,

0.8163857880904707d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.23571376152551826d,

0.5892834748663432d,

0.16218047163404392d,

0.812415723693509d,

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                importCollection.Clear();

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 1064547311,
                    Value = 
new System.Double[4]
{
0.1893886152587244d,

0.5275227744645564d,

0.2713623619895643d,

0.3168228462103305d,

},
                    NullableValue = 
new System.Double[4]
{
0.8735754679742028d,

0.326431225255876d,

0.3453472790929043d,

0.29467838540432656d,

},

                    ModelInner = new Doubledouble_precisionArray1MI 
                    {
                        Id = 1123512386
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 1216459642,
                    Value = 
new System.Double[3]
{
0.4228646939171534d,

0.48723305829751273d,

0.9874945307068991d,

},
                    NullableValue = 
new System.Double[3]
{
0.3406725270833162d,

0.6278874871110163d,

0.3397053760273837d,

},

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 1228851149,
                    Value = 
new System.Double[4]
{
0.3046752293818199d,

0.8954081781400294d,

0.20001431036328188d,

0.6588513650063575d,

},
                    NullableValue = 
new System.Double[4]
{
0.016354803552207975d,

0.10753335442476042d,

0.5683871269850892d,

0.31836105153449645d,

},

                    ModelInner = new Doubledouble_precisionArray1MI 
                    {
                        Id = 1401688209
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 1262879363,
                    Value = 
new System.Double[4]
{
0.4812440527288484d,

0.3199784489919435d,

0.6382731473826979d,

0.09322032397536795d,

},
                    NullableValue = 
new System.Double[4]
{
0.018902743328656157d,

0.3517789945819232d,

0.8934958952939568d,

0.31341251587473284d,

},

                    ModelInner = new Doubledouble_precisionArray1MI 
                    {
                        Id = 1073531153
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 1274836410,
                    Value = 
new System.Double[3]
{
0.012300482333735707d,

0.8575843030300441d,

0.3953199073284702d,

},
                    NullableValue = 
new System.Double[3]
{
0.3802873805132805d,

0.7760282343876094d,

0.24367375090782895d,

},

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 1298233660,
                    Value = 
new System.Double[4]
{
0.6675363277475983d,

0.6926681157494187d,

0.8126962414663714d,

0.29746421327564687d,

},
                    NullableValue = 
new System.Double[3]
{
0.7096145407687857d,

0.08460224047984088d,

0.46365613795342464d,

},

                    ModelInner = new Doubledouble_precisionArray1MI 
                    {
                        Id = 1287977328
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 1298776905,
                    Value = 
new System.Double[3]
{
0.026920823934105664d,

0.2060699798435608d,

0.6784094784107302d,

},
                    NullableValue = null,

                    ModelInner = new Doubledouble_precisionArray1MI 
                    {
                        Id = 283357821
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 1352713090,
                    Value = 
new System.Double[4]
{
0.6083786222771096d,

0.0001882889314861469d,

0.5100959647529927d,

0.7823528511953681d,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 1389729061,
                    Value = 
new System.Double[4]
{
0.5768159718249714d,

0.27508325139879664d,

0.08248744166938815d,

0.7328876773389819d,

},
                    NullableValue = null,

                    ModelInner = new Doubledouble_precisionArray1MI 
                    {
                        Id = 553025882
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 1558321686,
                    Value = 
new System.Double[4]
{
0.9955207480528168d,

0.9708940640207901d,

0.22478258056371947d,

0.016843841508443202d,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 1735897709,
                    Value = 
new System.Double[4]
{
0.3669470742487849d,

0.16379944902051724d,

0.7658934828651761d,

0.47248375887341765d,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 1881675292,
                    Value = 
new System.Double[3]
{
0.13944961052197546d,

0.941374159723203d,

0.6535728631023234d,

},
                    NullableValue = null,

                    ModelInner = new Doubledouble_precisionArray1MI 
                    {
                        Id = 871153277
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 1930734881,
                    Value = 
new System.Double[3]
{
0.8844858358873939d,

0.688392437185428d,

0.5512043776449784d,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 1933081192,
                    Value = 
new System.Double[4]
{
0.9138765666850975d,

0.6503755818904282d,

0.5404800306134858d,

0.8912883104673369d,

},
                    NullableValue = null,

                    ModelInner = new Doubledouble_precisionArray1MI 
                    {
                        Id = 876498087
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray1M
                {
                    Id = 1965640956,
                    Value = 
new System.Double[3]
{
0.8799786113245733d,

0.103766859942518d,

0.007847165902295394d,

},
                    NullableValue = null,

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(246200596));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6528826774753668d,

0.6254299247853704d,

0.47543566122314207d,

0.7930281335726063d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.567069722078047d,

0.09427310691668289d,

0.3642694593425063d,

0.005828726918219007d,

};
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
                Assert.That(model.Id, Is.EqualTo(321358953));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7800843247230342d,

0.4214549731905376d,

0.7333459397056095d,

0.755163516995959d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.026376353541849196d,

0.15951410997648519d,

0.5345173275701939d,

0.022759667888013313d,

};
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
                Assert.That(model.Id, Is.EqualTo(324204378));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7129182666882694d,

0.5773018813104558d,

0.1303178521027032d,

0.24777695457455828d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1396062439));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.36043031673652803d,

0.44920721772598715d,

0.9547082859041273d,

};
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
                Assert.That(model.Id, Is.EqualTo(325108454));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.31744060975243693d,

0.4950576982196667d,

0.4511517060268161d,

0.23353987185161118d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(481026883));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9085386978293561d,

0.1857654354361994d,

0.41827195921626836d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.404034260825876d,

0.5965103178780428d,

0.603258001042972d,

0.64688471673662d,

};
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
                Assert.That(model.Id, Is.EqualTo(485575216));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8671908145349809d,

0.9049378669775808d,

0.18213312490514433d,

0.4613375807858682d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.14039778989028162d,

0.5962485072187153d,

0.5871815298295686d,

0.8632846246479523d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1868142384));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.6312408406261761d,

0.6910384091661451d,

0.33584671391491183d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6792415009961253d,

0.42942852389095576d,

0.45368987899691815d,

0.15879378615614492d,

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
                Assert.That(model.Id, Is.EqualTo(515166406));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.14740678647980743d,

0.8920088270848197d,

0.10405608417091272d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1035409201));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7047759882347794d,

0.2341035414238981d,

0.3458497864102972d,

0.6617110491944888d,

};
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
                Assert.That(model.Id, Is.EqualTo(568952966));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.2549081299446322d,

0.4684485171098728d,

0.7180646054817073d,

0.14333429471865333d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(617985466));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.29893900988049793d,

0.3006011137146485d,

0.7983268410297981d,

0.07027811884628865d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.022666264179675877d,

0.6168211486873275d,

0.9250709010204006d,

0.31456810051666817d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1914047110));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9866980079367033d,

0.9711114290457674d,

0.6336203270722464d,

};
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
                Assert.That(model.Id, Is.EqualTo(689918638));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9876768189493348d,

0.3950903873550714d,

0.9050025457274901d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(720084900));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5855030491938493d,

0.3828814855553848d,

0.42799369300590395d,

0.30072275365795853d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5595663268717557d,

0.42641902337908355d,

0.8355087159933785d,

0.1260374739386727d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1176809754));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3651109639924942d,

0.8856804349654391d,

0.6556235637359085d,

0.35150967423249546d,

};
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
                Assert.That(model.Id, Is.EqualTo(815594684));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.9268337039277679d,

0.2557880366788481d,

0.9708486737945278d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8293420330004952d,

0.6751324902712372d,

0.11744019681431705d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(665941176));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6007345284456123d,

0.4345557997433672d,

0.9270897092020428d,

0.8441201074343846d,

};
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
                Assert.That(model.Id, Is.EqualTo(869025017));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.23029619671977453d,

0.9963881322054496d,

0.29922279043314304d,

0.553359254492766d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.1045379747229116d,

0.25625702200631595d,

0.3270116864275764d,

0.19231856481547016d,

};
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
                Assert.That(model.Id, Is.EqualTo(890753535));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.006972482696241178d,

0.8870497280113498d,

0.5029194269663007d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.37397243565318894d,

0.9666530847812052d,

0.7321744421541623d,

};
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
                Assert.That(model.Id, Is.EqualTo(960794115));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8584340768029776d,

0.338983987976771d,

0.5165072379349526d,

0.48768908889282836d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.42645607878473624d,

0.8045629062412712d,

0.5842290059804607d,

0.53049592839275d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2134784495));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6635684089337649d,

0.6914516866463486d,

0.3407343143346171d,

0.8163857880904707d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.23571376152551826d,

0.5892834748663432d,

0.16218047163404392d,

0.812415723693509d,

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
                Assert.That(model.Id, Is.EqualTo(1064547311));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.1893886152587244d,

0.5275227744645564d,

0.2713623619895643d,

0.3168228462103305d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8735754679742028d,

0.326431225255876d,

0.3453472790929043d,

0.29467838540432656d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1123512386));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.7924057872325804d,

0.18826557079246586d,

0.8980023770287593d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.18052220548543152d,

0.7794956319484363d,

0.4287157896768359d,

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
                Assert.That(model.Id, Is.EqualTo(1216459642));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4228646939171534d,

0.48723305829751273d,

0.9874945307068991d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.3406725270833162d,

0.6278874871110163d,

0.3397053760273837d,

};
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
                Assert.That(model.Id, Is.EqualTo(1228851149));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3046752293818199d,

0.8954081781400294d,

0.20001431036328188d,

0.6588513650063575d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.016354803552207975d,

0.10753335442476042d,

0.5683871269850892d,

0.31836105153449645d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1401688209));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.7285949238283712d,

0.5733599435593822d,

0.34086697138841326d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.019003561494990606d,

0.5673454033171191d,

0.45191953211306135d,

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
                Assert.That(model.Id, Is.EqualTo(1262879363));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.4812440527288484d,

0.3199784489919435d,

0.6382731473826979d,

0.09322032397536795d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.018902743328656157d,

0.3517789945819232d,

0.8934958952939568d,

0.31341251587473284d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1073531153));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5852876008048172d,

0.8650137972125318d,

0.6720127322882606d,

0.8579926724905216d,

};
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
                Assert.That(model.Id, Is.EqualTo(1274836410));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.012300482333735707d,

0.8575843030300441d,

0.3953199073284702d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.3802873805132805d,

0.7760282343876094d,

0.24367375090782895d,

};
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
                Assert.That(model.Id, Is.EqualTo(1298233660));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6675363277475983d,

0.6926681157494187d,

0.8126962414663714d,

0.29746421327564687d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.7096145407687857d,

0.08460224047984088d,

0.46365613795342464d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1287977328));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3919606767987358d,

0.8958643836111312d,

0.3634904771594514d,

0.8432371463341493d,

};
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
                Assert.That(model.Id, Is.EqualTo(1298776905));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.026920823934105664d,

0.2060699798435608d,

0.6784094784107302d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(283357821));

                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.3762026568414524d,

0.6514616109727247d,

0.10666446093329995d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.6350965768202388d,

0.7364449970239656d,

0.6170729620999107d,

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
                Assert.That(model.Id, Is.EqualTo(1352713090));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.6083786222771096d,

0.0001882889314861469d,

0.5100959647529927d,

0.7823528511953681d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1389729061));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5768159718249714d,

0.27508325139879664d,

0.08248744166938815d,

0.7328876773389819d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(553025882));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.7069224121325174d,

0.2285607987772753d,

0.7939711165074208d,

0.7284294422963341d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4888467126362911d,

0.550874212734459d,

0.6844178701315258d,

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
                Assert.That(model.Id, Is.EqualTo(1558321686));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.9955207480528168d,

0.9708940640207901d,

0.22478258056371947d,

0.016843841508443202d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1735897709));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.3669470742487849d,

0.16379944902051724d,

0.7658934828651761d,

0.47248375887341765d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1881675292));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.13944961052197546d,

0.941374159723203d,

0.6535728631023234d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871153277));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.8647330702863328d,

0.7504311628925787d,

0.3558642039145814d,

0.381219391709971d,

};
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
                Assert.That(model.Id, Is.EqualTo(1930734881));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8844858358873939d,

0.688392437185428d,

0.5512043776449784d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1933081192));
                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.9138765666850975d,

0.6503755818904282d,

0.5404800306134858d,

0.8912883104673369d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(876498087));

                {
                    var expectEnumerValue = 
new System.Double[4]
{
0.5839587573934504d,

0.16229959953844164d,

0.05166021542799504d,

0.054705171681251774d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.4455950978835691d,

0.012889239254036622d,

0.365911697962618d,

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
                Assert.That(model.Id, Is.EqualTo(1965640956));
                {
                    var expectEnumerValue = 
new System.Double[3]
{
0.8799786113245733d,

0.103766859942518d,

0.007847165902295394d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
COPY public.binary_doubledouble_precisionarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(Doubledouble_precisionArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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

                var expected = new Dictionary<System.Int32,Doubledouble_precisionArray1M>(30);

                expected.Add(
                    246200596,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 246200596,
                        Value = 
new System.Double[4]
{
0.6528826774753668d,

0.6254299247853704d,

0.47543566122314207d,

0.7930281335726063d,

},
                        NullableValue = 
new System.Double[4]
{
0.567069722078047d,

0.09427310691668289d,

0.3642694593425063d,

0.005828726918219007d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    321358953,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 321358953,
                        Value = 
new System.Double[4]
{
0.7800843247230342d,

0.4214549731905376d,

0.7333459397056095d,

0.755163516995959d,

},
                        NullableValue = 
new System.Double[4]
{
0.026376353541849196d,

0.15951410997648519d,

0.5345173275701939d,

0.022759667888013313d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    324204378,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 324204378,
                        Value = 
new System.Double[4]
{
0.7129182666882694d,

0.5773018813104558d,

0.1303178521027032d,

0.24777695457455828d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 1396062439,
                            Value = 
new System.Double[3]
{
0.36043031673652803d,

0.44920721772598715d,

0.9547082859041273d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    325108454,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 325108454,
                        Value = 
new System.Double[4]
{
0.31744060975243693d,

0.4950576982196667d,

0.4511517060268161d,

0.23353987185161118d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    481026883,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 481026883,
                        Value = 
new System.Double[3]
{
0.9085386978293561d,

0.1857654354361994d,

0.41827195921626836d,

},
                        NullableValue = 
new System.Double[4]
{
0.404034260825876d,

0.5965103178780428d,

0.603258001042972d,

0.64688471673662d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    485575216,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 485575216,
                        Value = 
new System.Double[4]
{
0.8671908145349809d,

0.9049378669775808d,

0.18213312490514433d,

0.4613375807858682d,

},
                        NullableValue = 
new System.Double[4]
{
0.14039778989028162d,

0.5962485072187153d,

0.5871815298295686d,

0.8632846246479523d,

},

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 1868142384,
                            Value = 
new System.Double[3]
{
0.6312408406261761d,

0.6910384091661451d,

0.33584671391491183d,

},
                            NullableValue = 
new System.Double[4]
{
0.6792415009961253d,

0.42942852389095576d,

0.45368987899691815d,

0.15879378615614492d,

}
                        }

                    }
                );

                expected.Add(
                    515166406,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 515166406,
                        Value = 
new System.Double[3]
{
0.14740678647980743d,

0.8920088270848197d,

0.10405608417091272d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 1035409201,
                            Value = 
new System.Double[4]
{
0.7047759882347794d,

0.2341035414238981d,

0.3458497864102972d,

0.6617110491944888d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    568952966,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 568952966,
                        Value = 
new System.Double[4]
{
0.2549081299446322d,

0.4684485171098728d,

0.7180646054817073d,

0.14333429471865333d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    617985466,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 617985466,
                        Value = 
new System.Double[4]
{
0.29893900988049793d,

0.3006011137146485d,

0.7983268410297981d,

0.07027811884628865d,

},
                        NullableValue = 
new System.Double[4]
{
0.022666264179675877d,

0.6168211486873275d,

0.9250709010204006d,

0.31456810051666817d,

},

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 1914047110,
                            Value = 
new System.Double[3]
{
0.9866980079367033d,

0.9711114290457674d,

0.6336203270722464d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    689918638,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 689918638,
                        Value = 
new System.Double[3]
{
0.9876768189493348d,

0.3950903873550714d,

0.9050025457274901d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    720084900,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 720084900,
                        Value = 
new System.Double[4]
{
0.5855030491938493d,

0.3828814855553848d,

0.42799369300590395d,

0.30072275365795853d,

},
                        NullableValue = 
new System.Double[4]
{
0.5595663268717557d,

0.42641902337908355d,

0.8355087159933785d,

0.1260374739386727d,

},

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 1176809754,
                            Value = 
new System.Double[4]
{
0.3651109639924942d,

0.8856804349654391d,

0.6556235637359085d,

0.35150967423249546d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    815594684,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 815594684,
                        Value = 
new System.Double[3]
{
0.9268337039277679d,

0.2557880366788481d,

0.9708486737945278d,

},
                        NullableValue = 
new System.Double[3]
{
0.8293420330004952d,

0.6751324902712372d,

0.11744019681431705d,

},

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 665941176,
                            Value = 
new System.Double[4]
{
0.6007345284456123d,

0.4345557997433672d,

0.9270897092020428d,

0.8441201074343846d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    869025017,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 869025017,
                        Value = 
new System.Double[4]
{
0.23029619671977453d,

0.9963881322054496d,

0.29922279043314304d,

0.553359254492766d,

},
                        NullableValue = 
new System.Double[4]
{
0.1045379747229116d,

0.25625702200631595d,

0.3270116864275764d,

0.19231856481547016d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    890753535,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 890753535,
                        Value = 
new System.Double[3]
{
0.006972482696241178d,

0.8870497280113498d,

0.5029194269663007d,

},
                        NullableValue = 
new System.Double[3]
{
0.37397243565318894d,

0.9666530847812052d,

0.7321744421541623d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    960794115,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 960794115,
                        Value = 
new System.Double[4]
{
0.8584340768029776d,

0.338983987976771d,

0.5165072379349526d,

0.48768908889282836d,

},
                        NullableValue = 
new System.Double[4]
{
0.42645607878473624d,

0.8045629062412712d,

0.5842290059804607d,

0.53049592839275d,

},

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 2134784495,
                            Value = 
new System.Double[4]
{
0.6635684089337649d,

0.6914516866463486d,

0.3407343143346171d,

0.8163857880904707d,

},
                            NullableValue = 
new System.Double[4]
{
0.23571376152551826d,

0.5892834748663432d,

0.16218047163404392d,

0.812415723693509d,

}
                        }

                    }
                );

                expected.Add(
                    1064547311,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1064547311,
                        Value = 
new System.Double[4]
{
0.1893886152587244d,

0.5275227744645564d,

0.2713623619895643d,

0.3168228462103305d,

},
                        NullableValue = 
new System.Double[4]
{
0.8735754679742028d,

0.326431225255876d,

0.3453472790929043d,

0.29467838540432656d,

},

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 1123512386,
                            Value = 
new System.Double[3]
{
0.7924057872325804d,

0.18826557079246586d,

0.8980023770287593d,

},
                            NullableValue = 
new System.Double[3]
{
0.18052220548543152d,

0.7794956319484363d,

0.4287157896768359d,

}
                        }

                    }
                );

                expected.Add(
                    1216459642,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1216459642,
                        Value = 
new System.Double[3]
{
0.4228646939171534d,

0.48723305829751273d,

0.9874945307068991d,

},
                        NullableValue = 
new System.Double[3]
{
0.3406725270833162d,

0.6278874871110163d,

0.3397053760273837d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1228851149,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1228851149,
                        Value = 
new System.Double[4]
{
0.3046752293818199d,

0.8954081781400294d,

0.20001431036328188d,

0.6588513650063575d,

},
                        NullableValue = 
new System.Double[4]
{
0.016354803552207975d,

0.10753335442476042d,

0.5683871269850892d,

0.31836105153449645d,

},

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 1401688209,
                            Value = 
new System.Double[3]
{
0.7285949238283712d,

0.5733599435593822d,

0.34086697138841326d,

},
                            NullableValue = 
new System.Double[3]
{
0.019003561494990606d,

0.5673454033171191d,

0.45191953211306135d,

}
                        }

                    }
                );

                expected.Add(
                    1262879363,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1262879363,
                        Value = 
new System.Double[4]
{
0.4812440527288484d,

0.3199784489919435d,

0.6382731473826979d,

0.09322032397536795d,

},
                        NullableValue = 
new System.Double[4]
{
0.018902743328656157d,

0.3517789945819232d,

0.8934958952939568d,

0.31341251587473284d,

},

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 1073531153,
                            Value = 
new System.Double[4]
{
0.5852876008048172d,

0.8650137972125318d,

0.6720127322882606d,

0.8579926724905216d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1274836410,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1274836410,
                        Value = 
new System.Double[3]
{
0.012300482333735707d,

0.8575843030300441d,

0.3953199073284702d,

},
                        NullableValue = 
new System.Double[3]
{
0.3802873805132805d,

0.7760282343876094d,

0.24367375090782895d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1298233660,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1298233660,
                        Value = 
new System.Double[4]
{
0.6675363277475983d,

0.6926681157494187d,

0.8126962414663714d,

0.29746421327564687d,

},
                        NullableValue = 
new System.Double[3]
{
0.7096145407687857d,

0.08460224047984088d,

0.46365613795342464d,

},

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 1287977328,
                            Value = 
new System.Double[4]
{
0.3919606767987358d,

0.8958643836111312d,

0.3634904771594514d,

0.8432371463341493d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1298776905,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1298776905,
                        Value = 
new System.Double[3]
{
0.026920823934105664d,

0.2060699798435608d,

0.6784094784107302d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 283357821,
                            Value = 
new System.Double[3]
{
0.3762026568414524d,

0.6514616109727247d,

0.10666446093329995d,

},
                            NullableValue = 
new System.Double[3]
{
0.6350965768202388d,

0.7364449970239656d,

0.6170729620999107d,

}
                        }

                    }
                );

                expected.Add(
                    1352713090,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1352713090,
                        Value = 
new System.Double[4]
{
0.6083786222771096d,

0.0001882889314861469d,

0.5100959647529927d,

0.7823528511953681d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1389729061,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1389729061,
                        Value = 
new System.Double[4]
{
0.5768159718249714d,

0.27508325139879664d,

0.08248744166938815d,

0.7328876773389819d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 553025882,
                            Value = 
new System.Double[4]
{
0.7069224121325174d,

0.2285607987772753d,

0.7939711165074208d,

0.7284294422963341d,

},
                            NullableValue = 
new System.Double[3]
{
0.4888467126362911d,

0.550874212734459d,

0.6844178701315258d,

}
                        }

                    }
                );

                expected.Add(
                    1558321686,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1558321686,
                        Value = 
new System.Double[4]
{
0.9955207480528168d,

0.9708940640207901d,

0.22478258056371947d,

0.016843841508443202d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1735897709,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1735897709,
                        Value = 
new System.Double[4]
{
0.3669470742487849d,

0.16379944902051724d,

0.7658934828651761d,

0.47248375887341765d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1881675292,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1881675292,
                        Value = 
new System.Double[3]
{
0.13944961052197546d,

0.941374159723203d,

0.6535728631023234d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 871153277,
                            Value = 
new System.Double[4]
{
0.8647330702863328d,

0.7504311628925787d,

0.3558642039145814d,

0.381219391709971d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1930734881,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1930734881,
                        Value = 
new System.Double[3]
{
0.8844858358873939d,

0.688392437185428d,

0.5512043776449784d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1933081192,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1933081192,
                        Value = 
new System.Double[4]
{
0.9138765666850975d,

0.6503755818904282d,

0.5404800306134858d,

0.8912883104673369d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 876498087,
                            Value = 
new System.Double[4]
{
0.5839587573934504d,

0.16229959953844164d,

0.05166021542799504d,

0.054705171681251774d,

},
                            NullableValue = 
new System.Double[3]
{
0.4455950978835691d,

0.012889239254036622d,

0.365911697962618d,

}
                        }

                    }
                );

                expected.Add(
                    1965640956,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1965640956,
                        Value = 
new System.Double[3]
{
0.8799786113245733d,

0.103766859942518d,

0.007847165902295394d,

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Double[])default));
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

                var expected = new Dictionary<System.Int32,Doubledouble_precisionArray1M>(30);

                expected.Add(
                    246200596,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 246200596,
                        Value = 
new System.Double[4]
{
0.6528826774753668d,

0.6254299247853704d,

0.47543566122314207d,

0.7930281335726063d,

},
                        NullableValue = 
new System.Double[4]
{
0.567069722078047d,

0.09427310691668289d,

0.3642694593425063d,

0.005828726918219007d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    321358953,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 321358953,
                        Value = 
new System.Double[4]
{
0.7800843247230342d,

0.4214549731905376d,

0.7333459397056095d,

0.755163516995959d,

},
                        NullableValue = 
new System.Double[4]
{
0.026376353541849196d,

0.15951410997648519d,

0.5345173275701939d,

0.022759667888013313d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    324204378,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 324204378,
                        Value = 
new System.Double[4]
{
0.7129182666882694d,

0.5773018813104558d,

0.1303178521027032d,

0.24777695457455828d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 1396062439,
                            Value = 
new System.Double[3]
{
0.36043031673652803d,

0.44920721772598715d,

0.9547082859041273d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    325108454,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 325108454,
                        Value = 
new System.Double[4]
{
0.31744060975243693d,

0.4950576982196667d,

0.4511517060268161d,

0.23353987185161118d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    481026883,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 481026883,
                        Value = 
new System.Double[3]
{
0.9085386978293561d,

0.1857654354361994d,

0.41827195921626836d,

},
                        NullableValue = 
new System.Double[4]
{
0.404034260825876d,

0.5965103178780428d,

0.603258001042972d,

0.64688471673662d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    485575216,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 485575216,
                        Value = 
new System.Double[4]
{
0.8671908145349809d,

0.9049378669775808d,

0.18213312490514433d,

0.4613375807858682d,

},
                        NullableValue = 
new System.Double[4]
{
0.14039778989028162d,

0.5962485072187153d,

0.5871815298295686d,

0.8632846246479523d,

},

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 1868142384,
                            Value = 
new System.Double[3]
{
0.6312408406261761d,

0.6910384091661451d,

0.33584671391491183d,

},
                            NullableValue = 
new System.Double[4]
{
0.6792415009961253d,

0.42942852389095576d,

0.45368987899691815d,

0.15879378615614492d,

}
                        }

                    }
                );

                expected.Add(
                    515166406,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 515166406,
                        Value = 
new System.Double[3]
{
0.14740678647980743d,

0.8920088270848197d,

0.10405608417091272d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 1035409201,
                            Value = 
new System.Double[4]
{
0.7047759882347794d,

0.2341035414238981d,

0.3458497864102972d,

0.6617110491944888d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    568952966,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 568952966,
                        Value = 
new System.Double[4]
{
0.2549081299446322d,

0.4684485171098728d,

0.7180646054817073d,

0.14333429471865333d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    617985466,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 617985466,
                        Value = 
new System.Double[4]
{
0.29893900988049793d,

0.3006011137146485d,

0.7983268410297981d,

0.07027811884628865d,

},
                        NullableValue = 
new System.Double[4]
{
0.022666264179675877d,

0.6168211486873275d,

0.9250709010204006d,

0.31456810051666817d,

},

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 1914047110,
                            Value = 
new System.Double[3]
{
0.9866980079367033d,

0.9711114290457674d,

0.6336203270722464d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    689918638,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 689918638,
                        Value = 
new System.Double[3]
{
0.9876768189493348d,

0.3950903873550714d,

0.9050025457274901d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    720084900,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 720084900,
                        Value = 
new System.Double[4]
{
0.5855030491938493d,

0.3828814855553848d,

0.42799369300590395d,

0.30072275365795853d,

},
                        NullableValue = 
new System.Double[4]
{
0.5595663268717557d,

0.42641902337908355d,

0.8355087159933785d,

0.1260374739386727d,

},

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 1176809754,
                            Value = 
new System.Double[4]
{
0.3651109639924942d,

0.8856804349654391d,

0.6556235637359085d,

0.35150967423249546d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    815594684,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 815594684,
                        Value = 
new System.Double[3]
{
0.9268337039277679d,

0.2557880366788481d,

0.9708486737945278d,

},
                        NullableValue = 
new System.Double[3]
{
0.8293420330004952d,

0.6751324902712372d,

0.11744019681431705d,

},

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 665941176,
                            Value = 
new System.Double[4]
{
0.6007345284456123d,

0.4345557997433672d,

0.9270897092020428d,

0.8441201074343846d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    869025017,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 869025017,
                        Value = 
new System.Double[4]
{
0.23029619671977453d,

0.9963881322054496d,

0.29922279043314304d,

0.553359254492766d,

},
                        NullableValue = 
new System.Double[4]
{
0.1045379747229116d,

0.25625702200631595d,

0.3270116864275764d,

0.19231856481547016d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    890753535,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 890753535,
                        Value = 
new System.Double[3]
{
0.006972482696241178d,

0.8870497280113498d,

0.5029194269663007d,

},
                        NullableValue = 
new System.Double[3]
{
0.37397243565318894d,

0.9666530847812052d,

0.7321744421541623d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    960794115,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 960794115,
                        Value = 
new System.Double[4]
{
0.8584340768029776d,

0.338983987976771d,

0.5165072379349526d,

0.48768908889282836d,

},
                        NullableValue = 
new System.Double[4]
{
0.42645607878473624d,

0.8045629062412712d,

0.5842290059804607d,

0.53049592839275d,

},

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 2134784495,
                            Value = 
new System.Double[4]
{
0.6635684089337649d,

0.6914516866463486d,

0.3407343143346171d,

0.8163857880904707d,

},
                            NullableValue = 
new System.Double[4]
{
0.23571376152551826d,

0.5892834748663432d,

0.16218047163404392d,

0.812415723693509d,

}
                        }

                    }
                );

                expected.Add(
                    1064547311,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1064547311,
                        Value = 
new System.Double[4]
{
0.1893886152587244d,

0.5275227744645564d,

0.2713623619895643d,

0.3168228462103305d,

},
                        NullableValue = 
new System.Double[4]
{
0.8735754679742028d,

0.326431225255876d,

0.3453472790929043d,

0.29467838540432656d,

},

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 1123512386,
                            Value = 
new System.Double[3]
{
0.7924057872325804d,

0.18826557079246586d,

0.8980023770287593d,

},
                            NullableValue = 
new System.Double[3]
{
0.18052220548543152d,

0.7794956319484363d,

0.4287157896768359d,

}
                        }

                    }
                );

                expected.Add(
                    1216459642,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1216459642,
                        Value = 
new System.Double[3]
{
0.4228646939171534d,

0.48723305829751273d,

0.9874945307068991d,

},
                        NullableValue = 
new System.Double[3]
{
0.3406725270833162d,

0.6278874871110163d,

0.3397053760273837d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1228851149,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1228851149,
                        Value = 
new System.Double[4]
{
0.3046752293818199d,

0.8954081781400294d,

0.20001431036328188d,

0.6588513650063575d,

},
                        NullableValue = 
new System.Double[4]
{
0.016354803552207975d,

0.10753335442476042d,

0.5683871269850892d,

0.31836105153449645d,

},

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 1401688209,
                            Value = 
new System.Double[3]
{
0.7285949238283712d,

0.5733599435593822d,

0.34086697138841326d,

},
                            NullableValue = 
new System.Double[3]
{
0.019003561494990606d,

0.5673454033171191d,

0.45191953211306135d,

}
                        }

                    }
                );

                expected.Add(
                    1262879363,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1262879363,
                        Value = 
new System.Double[4]
{
0.4812440527288484d,

0.3199784489919435d,

0.6382731473826979d,

0.09322032397536795d,

},
                        NullableValue = 
new System.Double[4]
{
0.018902743328656157d,

0.3517789945819232d,

0.8934958952939568d,

0.31341251587473284d,

},

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 1073531153,
                            Value = 
new System.Double[4]
{
0.5852876008048172d,

0.8650137972125318d,

0.6720127322882606d,

0.8579926724905216d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1274836410,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1274836410,
                        Value = 
new System.Double[3]
{
0.012300482333735707d,

0.8575843030300441d,

0.3953199073284702d,

},
                        NullableValue = 
new System.Double[3]
{
0.3802873805132805d,

0.7760282343876094d,

0.24367375090782895d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1298233660,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1298233660,
                        Value = 
new System.Double[4]
{
0.6675363277475983d,

0.6926681157494187d,

0.8126962414663714d,

0.29746421327564687d,

},
                        NullableValue = 
new System.Double[3]
{
0.7096145407687857d,

0.08460224047984088d,

0.46365613795342464d,

},

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 1287977328,
                            Value = 
new System.Double[4]
{
0.3919606767987358d,

0.8958643836111312d,

0.3634904771594514d,

0.8432371463341493d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1298776905,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1298776905,
                        Value = 
new System.Double[3]
{
0.026920823934105664d,

0.2060699798435608d,

0.6784094784107302d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 283357821,
                            Value = 
new System.Double[3]
{
0.3762026568414524d,

0.6514616109727247d,

0.10666446093329995d,

},
                            NullableValue = 
new System.Double[3]
{
0.6350965768202388d,

0.7364449970239656d,

0.6170729620999107d,

}
                        }

                    }
                );

                expected.Add(
                    1352713090,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1352713090,
                        Value = 
new System.Double[4]
{
0.6083786222771096d,

0.0001882889314861469d,

0.5100959647529927d,

0.7823528511953681d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1389729061,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1389729061,
                        Value = 
new System.Double[4]
{
0.5768159718249714d,

0.27508325139879664d,

0.08248744166938815d,

0.7328876773389819d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 553025882,
                            Value = 
new System.Double[4]
{
0.7069224121325174d,

0.2285607987772753d,

0.7939711165074208d,

0.7284294422963341d,

},
                            NullableValue = 
new System.Double[3]
{
0.4888467126362911d,

0.550874212734459d,

0.6844178701315258d,

}
                        }

                    }
                );

                expected.Add(
                    1558321686,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1558321686,
                        Value = 
new System.Double[4]
{
0.9955207480528168d,

0.9708940640207901d,

0.22478258056371947d,

0.016843841508443202d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1735897709,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1735897709,
                        Value = 
new System.Double[4]
{
0.3669470742487849d,

0.16379944902051724d,

0.7658934828651761d,

0.47248375887341765d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1881675292,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1881675292,
                        Value = 
new System.Double[3]
{
0.13944961052197546d,

0.941374159723203d,

0.6535728631023234d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 871153277,
                            Value = 
new System.Double[4]
{
0.8647330702863328d,

0.7504311628925787d,

0.3558642039145814d,

0.381219391709971d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1930734881,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1930734881,
                        Value = 
new System.Double[3]
{
0.8844858358873939d,

0.688392437185428d,

0.5512043776449784d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1933081192,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1933081192,
                        Value = 
new System.Double[4]
{
0.9138765666850975d,

0.6503755818904282d,

0.5404800306134858d,

0.8912883104673369d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray1MI
                        {
                            Id = 876498087,
                            Value = 
new System.Double[4]
{
0.5839587573934504d,

0.16229959953844164d,

0.05166021542799504d,

0.054705171681251774d,

},
                            NullableValue = 
new System.Double[3]
{
0.4455950978835691d,

0.012889239254036622d,

0.365911697962618d,

}
                        }

                    }
                );

                expected.Add(
                    1965640956,
                    new Doubledouble_precisionArray1M
                    {
                        Id = 1965640956,
                        Value = 
new System.Double[3]
{
0.8799786113245733d,

0.103766859942518d,

0.007847165902295394d,

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Double[])default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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

                var expected = new Dictionary<System.Int32,Doubledouble_precisionArray1MI>(15);

                expected.Add(
                    283357821,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 283357821,
                        Value = 
new System.Double[3]
{
0.3762026568414524d,

0.6514616109727247d,

0.10666446093329995d,

},
                        NullableValue = 
new System.Double[3]
{
0.6350965768202388d,

0.7364449970239656d,

0.6170729620999107d,

}
                    }
                );

                expected.Add(
                    553025882,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 553025882,
                        Value = 
new System.Double[4]
{
0.7069224121325174d,

0.2285607987772753d,

0.7939711165074208d,

0.7284294422963341d,

},
                        NullableValue = 
new System.Double[3]
{
0.4888467126362911d,

0.550874212734459d,

0.6844178701315258d,

}
                    }
                );

                expected.Add(
                    665941176,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 665941176,
                        Value = 
new System.Double[4]
{
0.6007345284456123d,

0.4345557997433672d,

0.9270897092020428d,

0.8441201074343846d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    871153277,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 871153277,
                        Value = 
new System.Double[4]
{
0.8647330702863328d,

0.7504311628925787d,

0.3558642039145814d,

0.381219391709971d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    876498087,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 876498087,
                        Value = 
new System.Double[4]
{
0.5839587573934504d,

0.16229959953844164d,

0.05166021542799504d,

0.054705171681251774d,

},
                        NullableValue = 
new System.Double[3]
{
0.4455950978835691d,

0.012889239254036622d,

0.365911697962618d,

}
                    }
                );

                expected.Add(
                    1035409201,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 1035409201,
                        Value = 
new System.Double[4]
{
0.7047759882347794d,

0.2341035414238981d,

0.3458497864102972d,

0.6617110491944888d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1073531153,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 1073531153,
                        Value = 
new System.Double[4]
{
0.5852876008048172d,

0.8650137972125318d,

0.6720127322882606d,

0.8579926724905216d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1123512386,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 1123512386,
                        Value = 
new System.Double[3]
{
0.7924057872325804d,

0.18826557079246586d,

0.8980023770287593d,

},
                        NullableValue = 
new System.Double[3]
{
0.18052220548543152d,

0.7794956319484363d,

0.4287157896768359d,

}
                    }
                );

                expected.Add(
                    1176809754,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 1176809754,
                        Value = 
new System.Double[4]
{
0.3651109639924942d,

0.8856804349654391d,

0.6556235637359085d,

0.35150967423249546d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1287977328,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 1287977328,
                        Value = 
new System.Double[4]
{
0.3919606767987358d,

0.8958643836111312d,

0.3634904771594514d,

0.8432371463341493d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1396062439,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 1396062439,
                        Value = 
new System.Double[3]
{
0.36043031673652803d,

0.44920721772598715d,

0.9547082859041273d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1401688209,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 1401688209,
                        Value = 
new System.Double[3]
{
0.7285949238283712d,

0.5733599435593822d,

0.34086697138841326d,

},
                        NullableValue = 
new System.Double[3]
{
0.019003561494990606d,

0.5673454033171191d,

0.45191953211306135d,

}
                    }
                );

                expected.Add(
                    1868142384,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 1868142384,
                        Value = 
new System.Double[3]
{
0.6312408406261761d,

0.6910384091661451d,

0.33584671391491183d,

},
                        NullableValue = 
new System.Double[4]
{
0.6792415009961253d,

0.42942852389095576d,

0.45368987899691815d,

0.15879378615614492d,

}
                    }
                );

                expected.Add(
                    1914047110,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 1914047110,
                        Value = 
new System.Double[3]
{
0.9866980079367033d,

0.9711114290457674d,

0.6336203270722464d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2134784495,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 2134784495,
                        Value = 
new System.Double[4]
{
0.6635684089337649d,

0.6914516866463486d,

0.3407343143346171d,

0.8163857880904707d,

},
                        NullableValue = 
new System.Double[4]
{
0.23571376152551826d,

0.5892834748663432d,

0.16218047163404392d,

0.812415723693509d,

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

                var expected = new Dictionary<System.Int32,Doubledouble_precisionArray1MI>(15);

                expected.Add(
                    283357821,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 283357821,
                        Value = 
new System.Double[3]
{
0.3762026568414524d,

0.6514616109727247d,

0.10666446093329995d,

},
                        NullableValue = 
new System.Double[3]
{
0.6350965768202388d,

0.7364449970239656d,

0.6170729620999107d,

}
                    }
                );

                expected.Add(
                    553025882,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 553025882,
                        Value = 
new System.Double[4]
{
0.7069224121325174d,

0.2285607987772753d,

0.7939711165074208d,

0.7284294422963341d,

},
                        NullableValue = 
new System.Double[3]
{
0.4888467126362911d,

0.550874212734459d,

0.6844178701315258d,

}
                    }
                );

                expected.Add(
                    665941176,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 665941176,
                        Value = 
new System.Double[4]
{
0.6007345284456123d,

0.4345557997433672d,

0.9270897092020428d,

0.8441201074343846d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    871153277,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 871153277,
                        Value = 
new System.Double[4]
{
0.8647330702863328d,

0.7504311628925787d,

0.3558642039145814d,

0.381219391709971d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    876498087,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 876498087,
                        Value = 
new System.Double[4]
{
0.5839587573934504d,

0.16229959953844164d,

0.05166021542799504d,

0.054705171681251774d,

},
                        NullableValue = 
new System.Double[3]
{
0.4455950978835691d,

0.012889239254036622d,

0.365911697962618d,

}
                    }
                );

                expected.Add(
                    1035409201,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 1035409201,
                        Value = 
new System.Double[4]
{
0.7047759882347794d,

0.2341035414238981d,

0.3458497864102972d,

0.6617110491944888d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1073531153,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 1073531153,
                        Value = 
new System.Double[4]
{
0.5852876008048172d,

0.8650137972125318d,

0.6720127322882606d,

0.8579926724905216d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1123512386,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 1123512386,
                        Value = 
new System.Double[3]
{
0.7924057872325804d,

0.18826557079246586d,

0.8980023770287593d,

},
                        NullableValue = 
new System.Double[3]
{
0.18052220548543152d,

0.7794956319484363d,

0.4287157896768359d,

}
                    }
                );

                expected.Add(
                    1176809754,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 1176809754,
                        Value = 
new System.Double[4]
{
0.3651109639924942d,

0.8856804349654391d,

0.6556235637359085d,

0.35150967423249546d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1287977328,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 1287977328,
                        Value = 
new System.Double[4]
{
0.3919606767987358d,

0.8958643836111312d,

0.3634904771594514d,

0.8432371463341493d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1396062439,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 1396062439,
                        Value = 
new System.Double[3]
{
0.36043031673652803d,

0.44920721772598715d,

0.9547082859041273d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1401688209,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 1401688209,
                        Value = 
new System.Double[3]
{
0.7285949238283712d,

0.5733599435593822d,

0.34086697138841326d,

},
                        NullableValue = 
new System.Double[3]
{
0.019003561494990606d,

0.5673454033171191d,

0.45191953211306135d,

}
                    }
                );

                expected.Add(
                    1868142384,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 1868142384,
                        Value = 
new System.Double[3]
{
0.6312408406261761d,

0.6910384091661451d,

0.33584671391491183d,

},
                        NullableValue = 
new System.Double[4]
{
0.6792415009961253d,

0.42942852389095576d,

0.45368987899691815d,

0.15879378615614492d,

}
                    }
                );

                expected.Add(
                    1914047110,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 1914047110,
                        Value = 
new System.Double[3]
{
0.9866980079367033d,

0.9711114290457674d,

0.6336203270722464d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2134784495,
                    new Doubledouble_precisionArray1MI
                    {
                        Id = 2134784495,
                        Value = 
new System.Double[4]
{
0.6635684089337649d,

0.6914516866463486d,

0.3407343143346171d,

0.8163857880904707d,

},
                        NullableValue = 
new System.Double[4]
{
0.23571376152551826d,

0.5892834748663432d,

0.16218047163404392d,

0.812415723693509d,

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

